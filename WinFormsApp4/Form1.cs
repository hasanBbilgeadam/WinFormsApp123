using AjandanSistemi;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public static string Path = "data.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelEklemeForm form = new PersonelEklemeForm();

            form.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Person person = new Person();   
            Ajanda ajanda = new Ajanda();

            ajanda.AddPerson();
            ajanda.DeletePerson();
            

            if (!File.Exists(Path))
            {
                FileStream fs = File.Create(Path);
                fs.Close();
            }


            FillListBox();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void FillListBox()
        {

            listBox1.Items.Clear();
            StreamReader sr = new StreamReader(Path);
            while (!sr.EndOfStream)
            {
                string[] data = sr.ReadLine().Split('|');
                listBox1.Items.Add(data[0] + " " + data[3]);

            }

            sr.Close();

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            string Data = lb.SelectedItem.ToString().Split(' ')[1];

            UserInfoForm userInfoForm = new UserInfoForm();

            userInfoForm.ID = int.Parse(Data);

            userInfoForm.Show();

        }
    }
}