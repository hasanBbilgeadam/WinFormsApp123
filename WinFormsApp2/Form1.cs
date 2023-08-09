namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public List<int> Koltuklar;
        public Form1()
        {

            Koltuklar = new List<int>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;


            form2.form1.listBox1.Items.Clear();
            form2.form1.Koltuklar.ForEach(k => form2.form1.listBox1.Items.Add(k));

            this.Visible = false;
            form2.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();

            form3.Message = Koltuklar.LastOrDefault().ToString()+Environment.NewLine+
                "numaralý koltuk satýn alýnmýþtýr";
            form3.Show();

        }
    }
}