﻿namespace WinFormsApp4
{
    partial class UserInfoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblAd = new Label();
            lblSoyAd = new Label();
            lblTelefon = new Label();
            lblId = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 46);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(104, 46);
            label2.TabIndex = 1;
            label2.Text = "SoyAd :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(104, 46);
            label3.TabIndex = 2;
            label3.Text = "Telefon :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 189);
            label4.Name = "label4";
            label4.Size = new Size(104, 46);
            label4.TabIndex = 3;
            label4.Text = "ID :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAd.Location = new Point(132, 29);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(14, 21);
            lblAd.TabIndex = 4;
            lblAd.Text = " ";
            // 
            // lblSoyAd
            // 
            lblSoyAd.AutoSize = true;
            lblSoyAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoyAd.Location = new Point(132, 88);
            lblSoyAd.Name = "lblSoyAd";
            lblSoyAd.Size = new Size(14, 21);
            lblSoyAd.TabIndex = 5;
            lblSoyAd.Text = " ";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefon.Location = new Point(132, 149);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(14, 21);
            lblTelefon.TabIndex = 6;
            lblTelefon.Text = " ";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(132, 209);
            lblId.Name = "lblId";
            lblId.Size = new Size(14, 21);
            lblId.TabIndex = 7;
            lblId.Text = " ";
            // 
            // UserInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 276);
            Controls.Add(lblId);
            Controls.Add(lblTelefon);
            Controls.Add(lblSoyAd);
            Controls.Add(lblAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserInfoForm";
            Text = "UserInfoForm";
            Load += UserInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblAd;
        private Label lblSoyAd;
        private Label lblTelefon;
        private Label lblId;
    }
}