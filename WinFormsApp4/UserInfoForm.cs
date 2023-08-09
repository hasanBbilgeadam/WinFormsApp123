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
    }
}
