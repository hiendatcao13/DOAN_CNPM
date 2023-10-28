using System.Drawing;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.cmbTopic = new System.Windows.Forms.ComboBox();
            this.tabWord = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descibe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.PictureBox();
            this.txtWord = new CustomControls.RJControls.RJButton();
            this.txtDesc = new CustomControls.RJControls.RJTextBox();
            this.txtSearch = new CustomControls.RJControls.RJTextBox();
            this.btnDelete = new CustomControls.RJControls.RJButton();
            this.btnSave = new CustomControls.RJControls.RJButton();
            this.btnDesc = new CustomControls.RJControls.RJButton();
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
            this.menu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.menu.Size = new System.Drawing.Size(27, 1061);
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
            this.cmbTopic.Size = new System.Drawing.Size(361, 81);
            this.cmbTopic.TabIndex = 1;
            this.cmbTopic.SelectedIndexChanged += new System.EventHandler(this.cmbTopic_SelectedIndexChanged);
            // 
            // tabWord
            // 
            this.tabWord.AllowUserToAddRows = false;
            this.tabWord.AllowUserToDeleteRows = false;
            this.tabWord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabWord.ColumnHeadersVisible = false;
            this.tabWord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Descibe,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabWord.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabWord.Location = new System.Drawing.Point(100, 212);
            this.tabWord.Margin = new System.Windows.Forms.Padding(2);
            this.tabWord.Name = "tabWord";
            this.tabWord.ReadOnly = true;
            this.tabWord.RowHeadersVisible = false;
            this.tabWord.RowHeadersWidth = 62;
            this.tabWord.RowTemplate.Height = 28;
            this.tabWord.Size = new System.Drawing.Size(359, 351);
            this.tabWord.TabIndex = 3;
            this.tabWord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabWord_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.FillWeight = 1000F;
            this.Column1.HeaderText = "Vocabulary";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Topic";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Descibe
            // 
            this.Descibe.HeaderText = "Description";
            this.Descibe.Name = "Descibe";
            this.Descibe.ReadOnly = true;
            this.Descibe.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Path Image";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(513, 267);
            this.image.Margin = new System.Windows.Forms.Padding(2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(436, 296);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 8;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtWord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtWord.BorderColor = System.Drawing.Color.Black;
            this.txtWord.BorderRadius = 20;
            this.txtWord.BorderSize = 3;
            this.txtWord.FlatAppearance.BorderSize = 0;
            this.txtWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.ForeColor = System.Drawing.Color.Black;
            this.txtWord.Location = new System.Drawing.Point(691, 106);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(150, 40);
            this.txtWord.TabIndex = 16;
            this.txtWord.Text = "rjButton1";
            this.txtWord.TextColor = System.Drawing.Color.Black;
            this.txtWord.UseVisualStyleBackColor = false;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtDesc.BorderColor = System.Drawing.Color.Black;
            this.txtDesc.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDesc.BorderRadius = 30;
            this.txtDesc.BorderSize = 3;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDesc.Location = new System.Drawing.Point(499, 92);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtDesc.PasswordChar = false;
            this.txtDesc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDesc.PlaceholderText = "";
            this.txtDesc.Size = new System.Drawing.Size(156, 142);
            this.txtDesc.TabIndex = 15;
            this.txtDesc.Texts = "";
            this.txtDesc.UnderlinedStyle = false;
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
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
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
            this.btnDelete.Location = new System.Drawing.Point(633, 578);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 27);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "rjButton1";
            this.btnDelete.TextColor = System.Drawing.Color.Black;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnSave.Location = new System.Drawing.Point(499, 578);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "rjButton1";
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnDesc.Location = new System.Drawing.Point(523, 48);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(100, 27);
            this.btnDesc.TabIndex = 12;
            this.btnDesc.Text = "rjButton1";
            this.btnDesc.TextColor = System.Drawing.Color.Black;
            this.btnDesc.UseVisualStyleBackColor = false;
            // 
            // frm_library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(950, 1061);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDesc);
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
        private CustomControls.RJControls.RJButton btnDesc;
        private CustomControls.RJControls.RJButton btnSave;
        private CustomControls.RJControls.RJTextBox txtSearch;
        private CustomControls.RJControls.RJButton btnDelete;
        private CustomControls.RJControls.RJTextBox txtDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descibe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private CustomControls.RJControls.RJButton txtWord;
    }
}