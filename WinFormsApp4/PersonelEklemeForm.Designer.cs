namespace WinFormsApp4
{
    partial class PersonelEklemeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxAd = new TextBox();
            textBoxSoyAd = new TextBox();
            textBoxTelefon = new TextBox();
            textBoxID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(94, 12);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(146, 23);
            textBoxAd.TabIndex = 0;
            // 
            // textBoxSoyAd
            // 
            textBoxSoyAd.Location = new Point(94, 59);
            textBoxSoyAd.Name = "textBoxSoyAd";
            textBoxSoyAd.Size = new Size(146, 23);
            textBoxSoyAd.TabIndex = 1;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Location = new Point(94, 119);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new Size(146, 23);
            textBoxTelefon.TabIndex = 2;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(94, 178);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(146, 23);
            textBoxID.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 4;
            label1.Text = "AD :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(8, 59);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 5;
            label2.Text = "SoyAd :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(8, 119);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 6;
            label3.Text = "Telefon :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(8, 177);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 7;
            label4.Text = "ID :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.Location = new Point(94, 226);
            button1.Name = "button1";
            button1.Size = new Size(93, 47);
            button1.TabIndex = 8;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PersonelEklemeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 285);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxID);
            Controls.Add(textBoxTelefon);
            Controls.Add(textBoxSoyAd);
            Controls.Add(textBoxAd);
            Name = "PersonelEklemeForm";
            Text = "PersonelEklemeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAd;
        private TextBox textBoxSoyAd;
        private TextBox textBoxTelefon;
        private TextBox textBoxID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}