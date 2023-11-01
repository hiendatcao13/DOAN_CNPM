namespace flashcard
{
    partial class frm_about
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
            this.txtCenter = new CustomControls.RJControls.RJButton();
            this.txtDetails = new System.Windows.Forms.Button();
            this.txtDetails2 = new System.Windows.Forms.Button();
            this.txtThanks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.menu.Size = new System.Drawing.Size(31, 985);
            this.menu.TabIndex = 0;
            this.menu.Text = "toolStrip1";
            // 
            // txtCenter
            // 
            this.txtCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCenter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCenter.BorderColor = System.Drawing.Color.Black;
            this.txtCenter.BorderRadius = 20;
            this.txtCenter.BorderSize = 3;
            this.txtCenter.FlatAppearance.BorderSize = 0;
            this.txtCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCenter.Font = new System.Drawing.Font("Yu Gothic UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenter.ForeColor = System.Drawing.Color.Black;
            this.txtCenter.Location = new System.Drawing.Point(177, 71);
            this.txtCenter.Margin = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.txtCenter.Name = "txtCenter";
            this.txtCenter.Size = new System.Drawing.Size(1100, 80);
            this.txtCenter.TabIndex = 1;
            this.txtCenter.Text = "Some thing about Vocabulary Flashcard LLD";
            this.txtCenter.TextColor = System.Drawing.Color.Black;
            this.txtCenter.UseVisualStyleBackColor = false;
            // 
            // txtDetails
            // 
            this.txtDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDetails.FlatAppearance.BorderSize = 0;
            this.txtDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDetails.Location = new System.Drawing.Point(191, 224);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(936, 142);
            this.txtDetails.TabIndex = 2;
            this.txtDetails.Text = "button1";
            this.txtDetails.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.txtDetails.UseVisualStyleBackColor = false;
            // 
            // txtDetails2
            // 
            this.txtDetails2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDetails2.FlatAppearance.BorderSize = 0;
            this.txtDetails2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDetails2.Location = new System.Drawing.Point(383, 432);
            this.txtDetails2.Name = "txtDetails2";
            this.txtDetails2.Size = new System.Drawing.Size(834, 211);
            this.txtDetails2.TabIndex = 3;
            this.txtDetails2.Text = "button1";
            this.txtDetails2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.txtDetails2.UseVisualStyleBackColor = false;
            // 
            // txtThanks
            // 
            this.txtThanks.FlatAppearance.BorderSize = 0;
            this.txtThanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtThanks.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanks.Location = new System.Drawing.Point(1217, 363);
            this.txtThanks.Name = "txtThanks";
            this.txtThanks.Size = new System.Drawing.Size(75, 23);
            this.txtThanks.TabIndex = 4;
            this.txtThanks.Text = "button1";
            this.txtThanks.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.txtThanks.UseVisualStyleBackColor = true;
            // 
            // frm_about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(35F, 69F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.txtThanks);
            this.Controls.Add(this.txtDetails2);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtCenter);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.Name = "frm_about";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LDD App";
            this.Load += new System.EventHandler(this.frm_about_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu;
        private CustomControls.RJControls.RJButton txtCenter;
        private System.Windows.Forms.Button txtDetails;
        private System.Windows.Forms.Button txtDetails2;
        private System.Windows.Forms.Button txtThanks;
    }
}