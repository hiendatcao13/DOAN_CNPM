﻿namespace flashcard
{
    partial class frm_Sign_in
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserName = new CustomControls.RJControls.RJTextBox();
            this.txt_Password = new CustomControls.RJControls.RJTextBox();
            this.btn_Sign_in = new CustomControls.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.btnShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.SystemColors.Window;
            this.txt_UserName.BorderColor = System.Drawing.Color.Black;
            this.txt_UserName.BorderFocusColor = System.Drawing.Color.Black;
            this.txt_UserName.BorderRadius = 15;
            this.txt_UserName.BorderSize = 2;
            this.txt_UserName.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_UserName.Location = new System.Drawing.Point(465, 258);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_UserName.PasswordChar = false;
            this.txt_UserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_UserName.PlaceholderText = "";
            this.txt_UserName.Size = new System.Drawing.Size(549, 43);
            this.txt_UserName.TabIndex = 4;
            this.txt_UserName.Texts = "";
            this.txt_UserName.UnderlinedStyle = false;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Password.BorderColor = System.Drawing.Color.Black;
            this.txt_Password.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Password.BorderRadius = 15;
            this.txt_Password.BorderSize = 2;
            this.txt_Password.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Password.Location = new System.Drawing.Point(465, 364);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Multiline = false;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Password.PasswordChar = true;
            this.txt_Password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Password.PlaceholderText = "";
            this.txt_Password.Size = new System.Drawing.Size(549, 43);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.Texts = "";
            this.txt_Password.UnderlinedStyle = false;
            // 
            // btn_Sign_in
            // 
            this.btn_Sign_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            this.btn_Sign_in.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            this.btn_Sign_in.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Sign_in.BorderRadius = 18;
            this.btn_Sign_in.BorderSize = 3;
            this.btn_Sign_in.FlatAppearance.BorderSize = 0;
            this.btn_Sign_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sign_in.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign_in.ForeColor = System.Drawing.Color.Black;
            this.btn_Sign_in.Location = new System.Drawing.Point(826, 455);
            this.btn_Sign_in.Name = "btn_Sign_in";
            this.btn_Sign_in.Size = new System.Drawing.Size(188, 48);
            this.btn_Sign_in.TabIndex = 6;
            this.btn_Sign_in.Text = "Sign in";
            this.btn_Sign_in.TextColor = System.Drawing.Color.Black;
            this.btn_Sign_in.UseVisualStyleBackColor = false;
            this.btn_Sign_in.Click += new System.EventHandler(this.btn_Sign_in_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(477, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Don\'t have an account yet? ";
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Font = new System.Drawing.Font("Yu Gothic UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Register.Location = new System.Drawing.Point(762, 522);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(100, 32);
            this.lbl_Register.TabIndex = 10;
            this.lbl_Register.Text = "Register";
            this.lbl_Register.Click += new System.EventHandler(this.lbl_Register_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.AutoSize = true;
            this.btnShowPass.Location = new System.Drawing.Point(912, 414);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(102, 17);
            this.btnShowPass.TabIndex = 12;
            this.btnShowPass.Text = "Show Password";
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.CheckedChanged += new System.EventHandler(this.btnShowPass_Click);
            // 
            // frm_Sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1257, 714);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.lbl_Register);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Sign_in);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Sign_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LDD App";
            this.Load += new System.EventHandler(this.frm_Sign_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox txt_UserName;
        private CustomControls.RJControls.RJTextBox txt_Password;
        private CustomControls.RJControls.RJButton btn_Sign_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Register;
        private System.Windows.Forms.CheckBox btnShowPass;
    }
}