namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        string path = "dosya.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(path,true);
            streamWriter.WriteLine(textBox1.Text);
            streamWriter.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("dosya yok");
                return;
            }
            StreamReader streamReader = new StreamReader(path);
            string data = "";
            while (!streamReader.EndOfStream)
            {
                data += streamReader.ReadLine();
            }
            MessageBox.Show(data);
            streamReader.Close();
        }
    }
}