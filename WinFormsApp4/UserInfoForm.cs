using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp4
{
    public partial class UserInfoForm : Form
    {
        public int ID { get; set; }
        public UserInfoForm()
        {
            InitializeComponent();
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            button3.Text = ID + " numaralı kişiyi siliniz";
            string[] arr = SearchById(ID);
            lblAd.Text = arr[0];
            lblSoyAd.Text = arr[1];
            lblTelefon.Text = arr[2];
            lblId.Text = arr[3];

            textBoxAd.Text = arr[0];
            textBoxSoyad.Text = arr[1];
            textBoxTelefon.Text = arr[2];

            ShowHobbies();

        }

        private void ShowHobbies()
        {
            List<string> hobiler = GetHobbiesById(ID);

            if (hobiler == null)
            {
                lblHobi.Text = "HOBİ ALANI BOŞ";
            }
            else
            {
                foreach (var item in hobiler)
                {
                    lblHobi.Text += item + Environment.NewLine;
                }
            }
        }

        public string[] SearchById(int id)
        {

            StreamReader streamReader = new StreamReader(Form1.Path);


            while (!streamReader.EndOfStream)
            {
                string[] data = streamReader.ReadLine().Split('|');

                if (id.ToString() == data[3])
                {

                    streamReader.Close();
                    return data;
                }

            }


            streamReader.Close();
            return null;

        }
        bool open = false;
        private void button1_Click(object sender, EventArgs e)
        {

            open = !open;

            if (open)
            {
                this.ClientSize = new Size(480, 276);
                return;
            }
            this.ClientSize = new Size(304, 276);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateUser(ID.ToString(), textBoxAd.Text, textBoxSoyad.Text, textBoxTelefon.Text);
        }

        //silme btn
        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("kişiyi silmek istiyor musunuz", "sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {
                //silme işlemi burada olacak
                UserDelete(ID.ToString());
            }

            return;

        }

        bool openDelete = false;
        private void button4_Click(object sender, EventArgs e)
        {
            openDelete = !openDelete;

            if (openDelete)
            {
                this.ClientSize = new Size(723, 276);
                return;
            }
            else
            {
                this.ClientSize = new Size(304, 276);
            }
        }



        private void UpdateUser(string id, string name, string surname, string phonenumber)
        {



            StreamReader sr = new StreamReader(Form1.Path);

            List<string> kişiler = new();


            while (!sr.EndOfStream)
            {

                kişiler.Add(sr.ReadLine());
            }
            sr.Close();





            for (int i = 0; i < kişiler.Count; i++)
            {
                if (kişiler[i].Split('|')[3] == id)
                {
                    kişiler[i] = name + "|" + surname + "|" + phonenumber + "|" + id;
                    break;
                }
            }



            StreamWriter sw = new StreamWriter(Form1.Path);
            sw.Write("");
            sw.Close();

            StreamWriter sw2 = new StreamWriter(Form1.Path, true);

            foreach (var item in kişiler)
            {
                sw2.WriteLine(item);
            }

            sw2.Close();

        }
        private void UpdateUser(string id, string name, string surname, string phonenumber, string hobi)
        {



            StreamReader sr = new StreamReader(Form1.Path);

            List<string> kişiler = new();


            while (!sr.EndOfStream)
            {

                kişiler.Add(sr.ReadLine());
            }
            sr.Close();



            //ad|soyad|telefon|id|(hobi-asdasdasd-adasd)

            for (int i = 0; i < kişiler.Count; i++)
            {
                if (kişiler[i].Split('|')[3] == id)
                {
                    if (kişiler[i].Split('|').Length > 4)
                    {
                        string[] arr = kişiler[i].Split('|');

                        kişiler[i] = arr[0] + "|" + arr[1] + "|" + arr[2] + "|" + arr[3] + "|" + arr[4] + "-" + hobi;
                    }
                    else
                    {
                        kişiler[i] = name + "|" + surname + "|" + phonenumber + "|" + id + "|" + hobi;
                        break;
                    }

                }
            }



            StreamWriter sw = new StreamWriter(Form1.Path);
            sw.Write("");
            sw.Close();

            StreamWriter sw2 = new StreamWriter(Form1.Path, true);

            foreach (var item in kişiler)
            {
                sw2.WriteLine(item);
            }

            sw2.Close();

        }

        private void UserDelete(string id)
        {



            StreamReader sr = new StreamReader(Form1.Path);

            List<string> kişiler = new();


            while (!sr.EndOfStream)
            {

                kişiler.Add(sr.ReadLine());
            }
            sr.Close();


            //a
            //c


            for (int i = 0; i < kişiler.Count; i++)
            {
                if (kişiler[i].Split('|')[3] == id)
                {
                    kişiler.Remove(kişiler[i]);
                }
            }




            StreamWriter sw = new StreamWriter(Form1.Path);
            sw.Write("");
            sw.Close();

            StreamWriter sw2 = new StreamWriter(Form1.Path, true);

            foreach (var item in kişiler)
            {
                sw2.WriteLine(item);
            }

            sw2.Close();

        }

        private List<string> GetHobbiesById(int id)
        {

            List<string> hobbies = new List<string>();


            StreamReader sr = new StreamReader(Form1.Path);

            string kişi = "";


            while (!sr.EndOfStream)
            {

                kişi = sr.ReadLine();

                if (kişi.Split('|')[3] == id.ToString())
                {
                    break;
                }


            }
            sr.Close();


            if (kişi.Split('|').Length > 4)
            {

                hobbies = kişi.Split('|')[4].Split('-').ToList();

                return hobbies;

            }
            return null;
        }

        private void AddHobi(int id)
        {


        }

        //hobi ekleme
        private void button6_Click(object sender, EventArgs e)
        {
            lblHobi.Text = "";

            UpdateUser(ID.ToString(), textBoxAd.Text, textBoxSoyad.Text, textBoxTelefon.Text, textBoxHobi.Text);

            ShowHobbies();
        }

        bool hobiAlan = false;
        private void button5_Click(object sender, EventArgs e)
        {
            hobiAlan = !hobiAlan;


            if (hobiAlan)
            {
                this.ClientSize = new Size(310, 475);

            }
            else
            {
                this.ClientSize = new Size(310, 277);
            }

        }
    }
}
