namespace flashcard
{
    partial class frm_library
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
            this.menu = new System.Windows.Forms.ToolStrip();
            this.cmbTopic = new System.Windows.Forms.ComboBox();
            this.tabWord = new System.Windows.Forms.DataGridView();
            this.image = new System.Windows.Forms.PictureBox();
            this.txtExample = new System.Windows.Forms.RichTextBox();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.btnExample = new CustomControls.RJControls.RJButton();
            this.btnDesc = new CustomControls.RJControls.RJButton();
            this.btnSave = new CustomControls.RJControls.RJButton();
            this.btnTest = new CustomControls.RJControls.RJButton();
            this.txtWord = new CustomControls.RJControls.RJTextBox();
            this.txtSearch = new CustomControls.RJControls.RJTextBox();
            this.btnDelete = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(26, 641);
            this.menu.TabIndex = 0;
            this.menu.Text = "toolStrip1";
            // 
            // cmbTopic
            // 
            this.cmbTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(223)))), ((int)(((byte)(142)))));
            this.cmbTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.cmbTopic.FormattingEnabled = true;
            this.cmbTopic.Location = new System.Drawing.Point(100, 16);
            this.cmbTopic.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTopic.Name = "cmbTopic";
            this.cmbTopic.Size = new System.Drawing.Size(360, 81);
            this.cmbTopic.TabIndex = 1;
            // 
            // tabWord
            // 
            this.tabWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabWord.Location = new System.Drawing.Point(100, 212);
            this.tabWord.Margin = new System.Windows.Forms.Padding(2);
            this.tabWord.Name = "tabWord";
            this.tabWord.RowHeadersWidth = 62;
            this.tabWord.RowTemplate.Height = 28;
            this.tabWord.Size = new System.Drawing.Size(359, 351);
            this.tabWord.TabIndex = 3;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(513, 267);
            this.image.Margin = new System.Windows.Forms.Padding(2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(436, 296);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 8;
            this.image.TabStop = false;
            // 
            // txtExample
            // 
            this.txtExample.Location = new System.Drawing.Point(741, 117);
            this.txtExample.Margin = new System.Windows.Forms.Padding(2);
            this.txtExample.Name = "txtExample";
            this.txtExample.Size = new System.Drawing.Size(203, 128);
            this.txtExample.TabIndex = 11;
            this.txtExample.Text = "";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(502, 117);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(203, 128);
            this.txtDesc.TabIndex = 11;
            this.txtDesc.Text = "";
            // 
            // btnExample
            // 
            this.btnExample.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExample.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExample.BorderColor = System.Drawing.Color.Black;
            this.btnExample.BorderRadius = 20;
            this.btnExample.BorderSize = 3;
            this.btnExample.FlatAppearance.BorderSize = 3;
            this.btnExample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExample.ForeColor = System.Drawing.Color.Black;
            this.btnExample.Location = new System.Drawing.Point(775, 72);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(150, 40);
            this.btnExample.TabIndex = 12;
            this.btnExample.Text = "rjButton1";
            this.btnExample.TextColor = System.Drawing.Color.Black;
            this.btnExample.UseVisualStyleBackColor = false;
            // 
            // btnDesc
            // 
            this.btnDesc.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDesc.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDesc.BorderColor = System.Drawing.Color.Black;
            this.btnDesc.BorderRadius = 20;
            this.btnDesc.BorderSize = 3;
            this.btnDesc.FlatAppearance.BorderSize = 3;
            this.btnDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesc.ForeColor = System.Drawing.Color.Black;
            this.btnDesc.Location = new System.Drawing.Point(531, 72);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(150, 40);
            this.btnDesc.TabIndex = 12;
            this.btnDesc.Text = "rjButton1";
            this.btnDesc.TextColor = System.Drawing.Color.Black;
            this.btnDesc.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 3;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(555, 589);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "rjButton1";
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTest.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTest.BorderColor = System.Drawing.Color.Black;
            this.btnTest.BorderRadius = 20;
            this.btnTest.BorderSize = 3;
            this.btnTest.FlatAppearance.BorderSize = 3;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.ForeColor = System.Drawing.Color.Black;
            this.btnTest.Location = new System.Drawing.Point(201, 589);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(150, 40);
            this.btnTest.TabIndex = 12;
            this.btnTest.Text = "rjButton1";
            this.btnTest.TextColor = System.Drawing.Color.Black;
            this.btnTest.UseVisualStyleBackColor = false;
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtWord.BorderColor = System.Drawing.Color.Black;
            this.txtWord.BorderFocusColor = System.Drawing.Color.Black;
            this.txtWord.BorderRadius = 10;
            this.txtWord.BorderSize = 3;
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.txtWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWord.Location = new System.Drawing.Point(523, 326);
            this.txtWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtWord.Multiline = false;
            this.txtWord.Name = "txtWord";
            this.txtWord.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtWord.PasswordChar = false;
            this.txtWord.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtWord.PlaceholderText = "";
            this.txtWord.Size = new System.Drawing.Size(414, 168);
            this.txtWord.TabIndex = 13;
            this.txtWord.Texts = "";
            this.txtWord.UnderlinedStyle = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(223)))), ((int)(((byte)(142)))));
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.BorderSize = 3;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(100, 137);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.Black;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Size = new System.Drawing.Size(359, 61);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 3;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(725, 589);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "rjButton1";
            this.btnDelete.TextColor = System.Drawing.Color.Black;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // frm_library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(950, 641);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.btnExample);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtExample);
            this.Controls.Add(this.image);
            this.Controls.Add(this.tabWord);
            this.Controls.Add(this.cmbTopic);
            this.Controls.Add(this.menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_library";
            this.Text = "frm_library";
            this.Load += new System.EventHandler(this.frm_library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ComboBox cmbTopic;
        private System.Windows.Forms.DataGridView tabWord;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.RichTextBox txtExample;
        private System.Windows.Forms.RichTextBox txtDesc;
        private CustomControls.RJControls.RJButton btnExample;
        private CustomControls.RJControls.RJButton btnDesc;
        private CustomControls.RJControls.RJButton btnSave;
        private CustomControls.RJControls.RJButton btnTest;
        private CustomControls.RJControls.RJTextBox txtWord;
        private CustomControls.RJControls.RJTextBox txtSearch;
        private CustomControls.RJControls.RJButton btnDelete;
    }
}