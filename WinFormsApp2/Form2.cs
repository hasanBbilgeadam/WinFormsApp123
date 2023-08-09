using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            foreach (int c in form1.Koltuklar)
            {
                listBox1.Items.Add(c);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int numara))
            {
                //
                MessageBox.Show("hatalı bir karakter girişi yaptınız");
                textBox1.Clear();
                return;
            }

            if (!form1.Koltuklar.Contains(numara))
            {
                form1.Koltuklar.Add(numara);

                this.listBox1.Items.Add(numara);
                return;
            }

            MessageBox.Show("bu koltuk başkası tarafından alınmıştır");
            textBox1.Clear();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.listBox1.Items.Clear();
            form1.Koltuklar.ForEach(x => form1.listBox1.Items.Add(x));

            form1.Visible = true;
        }
    }
}
