using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        int count = 0;
        string password = "hasan123";
        List<DateTime> dateTimes;
        public Form2()
        {
            dateTimes = new(); 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ++count;

            
            if (count == 3)
            {
                Application.Exit();
            }

            if (textBox1.Text == password)
            {
                Form1 form1 = new Form1();

                string str = "Başarısız Giriş Denememeleri " + Environment.NewLine;
                foreach (var item in dateTimes)
                {
                    str += item.ToString() + Environment.NewLine;
                }

                form1.label1.Text = str;

                this.Hide;
                this.Visible = false;
                form1.Show();
            }
            else
            {
                dateTimes.Add(DateTime.Now);

                MessageBox.Show(3-count+" kadar hakkınız kaldı");
            }

        }
    }
}
