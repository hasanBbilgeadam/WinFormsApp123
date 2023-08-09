using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            string[] arr = SearchById(ID);
            lblAd.Text = arr[0];
            lblSoyAd.Text = arr[1];
            lblTelefon.Text = arr[2];
            lblId.Text = arr[3];

            textBoxAd.Text = arr[0];
            textBoxSoyad.Text = arr[1];
            textBoxTelefon.Text = arr[2];


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
            this.ClientSize = new Size(245, 276);
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

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateUser(ID.ToString(), textBoxAd.Text, textBoxSoyad.Text, textBoxTelefon.Text);
        }
    }
}
