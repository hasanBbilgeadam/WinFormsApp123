using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class PersonelEklemeForm : Form
    {
        public PersonelEklemeForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxAd.Text==string.Empty ||
                textBoxSoyAd.Text == string.Empty||
                textBoxTelefon.Text == string.Empty|| 
                textBoxID.Text == string.Empty)
            {
                MessageBox.Show("herhangi bir alan boş bırakılmaz");
                return;
            }


            if (Control(int.Parse(textBoxID.Text)))
            {
                MessageBox.Show("bu id kayıtlı id'yi değiştiriniz");
                textBoxID.Clear();
                return;
            }


            string data = textBoxAd.Text+"|"+textBoxSoyAd.Text+"|"+textBoxTelefon.Text+"|"+textBoxID.Text;
            StreamWriter sw = new StreamWriter(Form1.Path,true);
            sw.WriteLine(data); 
            sw.Close();
            this.Close();
        }
        private bool Control(int id)
        {


            StreamReader stream = new StreamReader(Form1.Path);

            //hasan|baysal|0555|33
            //hasan|baysal|0555|33
            //hasan|baysal|0555|33
            //hasan|baysal|0555|33
            //hasan|baysal|0555|33
            List<string> list = new List<string>();
            while (!stream.EndOfStream) 
            {

                if (int.Parse(stream.ReadLine().Split('|')[3]) == id)
                {

                    stream.Close();
                    return true; //var
                }

            }
            stream.Close();
            return false;//yok
        }
    }
}
