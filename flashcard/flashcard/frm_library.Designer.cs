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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabWord = new System.Windows.Forms.DataGridView();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnDesc = new System.Windows.Forms.Button();
            this.btnExample = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtExample = new System.Windows.Forms.RichTextBox();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
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
            this.menu.Size = new System.Drawing.Size(27, 986);
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
            this.cmbTopic.Location = new System.Drawing.Point(150, 25);
            this.cmbTopic.Name = "cmbTopic";
            this.cmbTopic.Size = new System.Drawing.Size(538, 116);
            this.cmbTopic.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(223)))), ((int)(((byte)(142)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.txtSearch.Location = new System.Drawing.Point(150, 204);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(538, 116);
            this.txtSearch.TabIndex = 2;
            // 
            // tabWord
            // 
            this.tabWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabWord.Location = new System.Drawing.Point(150, 326);
            this.tabWord.Name = "tabWord";
            this.tabWord.RowHeadersWidth = 62;
            this.tabWord.RowTemplate.Height = 28;
            this.tabWord.Size = new System.Drawing.Size(538, 660);
            this.tabWord.TabIndex = 3;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(813, 45);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(489, 26);
            this.txtWord.TabIndex = 4;
            this.txtWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(850, 109);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(138, 50);
            this.btnDesc.TabIndex = 5;
            this.btnDesc.Text = "button1";
            this.btnDesc.UseVisualStyleBackColor = true;
            // 
            // btnExample
            // 
            this.btnExample.Location = new System.Drawing.Point(1211, 109);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(132, 48);
            this.btnExample.TabIndex = 6;
            this.btnExample.Text = "button2";
            this.btnExample.UseVisualStyleBackColor = true;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(769, 411);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(654, 455);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 8;
            this.image.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1240, 921);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 53);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtExample
            // 
            this.txtExample.Location = new System.Drawing.Point(1111, 180);
            this.txtExample.Name = "txtExample";
            this.txtExample.Size = new System.Drawing.Size(302, 195);
            this.txtExample.TabIndex = 11;
            this.txtExample.Text = "";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(753, 180);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(302, 195);
            this.txtDesc.TabIndex = 11;
            this.txtDesc.Text = "";
            // 
            // frm_library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1425, 986);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtExample);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.image);
            this.Controls.Add(this.btnExample);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.tabWord);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbTopic);
            this.Controls.Add(this.menu);
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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView tabWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Button btnExample;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtExample;
        private System.Windows.Forms.RichTextBox txtDesc;
    }
}