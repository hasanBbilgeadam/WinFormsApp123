namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Button[,] buttons = new Button[8, 8];
        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    buttons[i, j] = new Button()
                    {
                       
                        Size = new Size(30, 30),
                        Location = new Point(x, y),
                        BackColor = (j+i) % 2 == 0 ? Color.White : Color.Black,
                     
                    };

                    x += 31;


                    this.Controls.Add(buttons[i, j]);
                }

                y += 31;
                x = 0;
            }

        }
    }
}