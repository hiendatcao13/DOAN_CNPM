namespace flashcard
{
    partial class frm_Account
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Upload_Image = new CustomControls.RJControls.RJButton();
            this.btn_Save_Imformation = new CustomControls.RJControls.RJButton();
            this.txt_Email = new CustomControls.RJControls.RJTextBox();
            this.txt_Password = new CustomControls.RJControls.RJTextBox();
            this.txt_Username = new CustomControls.RJControls.RJTextBox();
            this.txt_Display_Name = new CustomControls.RJControls.RJTextBox();
            this.menu = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::flashcard.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = global::flashcard.Properties.Resources.logo;
            this.pictureBox1.Image = global::flashcard.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::flashcard.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(972, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F);
            this.label1.Location = new System.Drawing.Point(162, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Display Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 16F);
            this.label2.Location = new System.Drawing.Point(162, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 16F);
            this.label3.Location = new System.Drawing.Point(162, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 16F);
            this.label4.Location = new System.Drawing.Point(162, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // btn_Upload_Image
            // 
            this.btn_Upload_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(223)))), ((int)(((byte)(142)))));
            this.btn_Upload_Image.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(223)))), ((int)(((byte)(142)))));
            this.btn_Upload_Image.BorderColor = System.Drawing.Color.Black;
            this.btn_Upload_Image.BorderRadius = 11;
            this.btn_Upload_Image.BorderSize = 3;
            this.btn_Upload_Image.FlatAppearance.BorderSize = 0;
            this.btn_Upload_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Upload_Image.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload_Image.ForeColor = System.Drawing.Color.Black;
            this.btn_Upload_Image.Location = new System.Drawing.Point(989, 604);
            this.btn_Upload_Image.Name = "btn_Upload_Image";
            this.btn_Upload_Image.Size = new System.Drawing.Size(224, 48);
            this.btn_Upload_Image.TabIndex = 7;
            this.btn_Upload_Image.Text = "Log out";
            this.btn_Upload_Image.TextColor = System.Drawing.Color.Black;
            this.btn_Upload_Image.UseVisualStyleBackColor = false;
            this.btn_Upload_Image.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Save_Imformation
            // 
            this.btn_Save_Imformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(223)))), ((int)(((byte)(142)))));
            this.btn_Save_Imformation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(223)))), ((int)(((byte)(142)))));
            this.btn_Save_Imformation.BorderColor = System.Drawing.Color.Black;
            this.btn_Save_Imformation.BorderRadius = 11;
            this.btn_Save_Imformation.BorderSize = 3;
            this.btn_Save_Imformation.FlatAppearance.BorderSize = 0;
            this.btn_Save_Imformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save_Imformation.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save_Imformation.ForeColor = System.Drawing.Color.Black;
            this.btn_Save_Imformation.Location = new System.Drawing.Point(729, 606);
            this.btn_Save_Imformation.Name = "btn_Save_Imformation";
            this.btn_Save_Imformation.Size = new System.Drawing.Size(224, 46);
            this.btn_Save_Imformation.TabIndex = 6;
            this.btn_Save_Imformation.Text = "Save";
            this.btn_Save_Imformation.TextColor = System.Drawing.Color.Black;
            this.btn_Save_Imformation.UseVisualStyleBackColor = false;
            this.btn_Save_Imformation.Click += new System.EventHandler(this.btn_Save_Imformation_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.AutoSize = true;
            this.txt_Email.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Email.BorderColor = System.Drawing.Color.Black;
            this.txt_Email.BorderFocusColor = System.Drawing.Color.Black;
            this.txt_Email.BorderRadius = 11;
            this.txt_Email.BorderSize = 3;
            this.txt_Email.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.Black;
            this.txt_Email.Location = new System.Drawing.Point(156, 491);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Email.PasswordChar = false;
            this.txt_Email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Email.PlaceholderText = "";
            this.txt_Email.Size = new System.Drawing.Size(750, 50);
            this.txt_Email.TabIndex = 4;
            this.txt_Email.Texts = "";
            this.txt_Email.UnderlinedStyle = false;
            // 
            // txt_Password
            // 
            this.txt_Password.AutoSize = true;
            this.txt_Password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Password.BorderColor = System.Drawing.Color.Black;
            this.txt_Password.BorderFocusColor = System.Drawing.Color.Black;
            this.txt_Password.BorderRadius = 11;
            this.txt_Password.BorderSize = 3;
            this.txt_Password.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.Black;
            this.txt_Password.Location = new System.Drawing.Point(156, 385);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Multiline = false;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Password.PasswordChar = true;
            this.txt_Password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Password.PlaceholderText = "";
            this.txt_Password.Size = new System.Drawing.Size(750, 53);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.Texts = "";
            this.txt_Password.UnderlinedStyle = false;
            // 
            // txt_Username
            // 
            this.txt_Username.AutoSize = true;
            this.txt_Username.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Username.BorderColor = System.Drawing.Color.Black;
            this.txt_Username.BorderFocusColor = System.Drawing.Color.Black;
            this.txt_Username.BorderRadius = 11;
            this.txt_Username.BorderSize = 3;
            this.txt_Username.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.Black;
            this.txt_Username.Location = new System.Drawing.Point(156, 279);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Username.PasswordChar = true;
            this.txt_Username.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Username.PlaceholderText = "";
            this.txt_Username.Size = new System.Drawing.Size(750, 50);
            this.txt_Username.TabIndex = 2;
            this.txt_Username.Texts = "";
            this.txt_Username.UnderlinedStyle = false;
            // 
            // txt_Display_Name
            // 
            this.txt_Display_Name.AutoSize = true;
            this.txt_Display_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_Display_Name.BorderColor = System.Drawing.Color.Black;
            this.txt_Display_Name.BorderFocusColor = System.Drawing.Color.Black;
            this.txt_Display_Name.BorderRadius = 11;
            this.txt_Display_Name.BorderSize = 3;
            this.txt_Display_Name.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Display_Name.ForeColor = System.Drawing.Color.Black;
            this.txt_Display_Name.Location = new System.Drawing.Point(156, 173);
            this.txt_Display_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Display_Name.Multiline = false;
            this.txt_Display_Name.Name = "txt_Display_Name";
            this.txt_Display_Name.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Display_Name.PasswordChar = false;
            this.txt_Display_Name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Display_Name.PlaceholderText = "";
            this.txt_Display_Name.Size = new System.Drawing.Size(750, 53);
            this.txt_Display_Name.TabIndex = 1;
            this.txt_Display_Name.Texts = "";
            this.txt_Display_Name.UnderlinedStyle = false;
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(26, 749);
            this.menu.TabIndex = 12;
            this.menu.Text = "toolStrip1";
            // 
            // frm_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Upload_Image);
            this.Controls.Add(this.btn_Save_Imformation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_Display_Name);
            this.Name = "frm_Account";
            this.Text = "LDD App";
            this.Load += new System.EventHandler(this.frm_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJTextBox txt_Display_Name;
        private CustomControls.RJControls.RJTextBox txt_Username;
        private CustomControls.RJControls.RJTextBox txt_Password;
        private CustomControls.RJControls.RJTextBox txt_Email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton btn_Save_Imformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJButton btn_Upload_Image;
        private System.Windows.Forms.ToolStrip menu;
    }
}