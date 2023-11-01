namespace flashcard
{
    partial class frm_test
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
            this.btnNext = new CustomControls.RJControls.RJButton();
            this.btnPrev = new CustomControls.RJControls.RJButton();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(26, 985);
            this.menu.TabIndex = 0;
            this.menu.Text = "toolStrip1";
            // 
            // txtCenter
            // 
            this.txtCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            this.txtCenter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            this.txtCenter.BorderColor = System.Drawing.Color.Black;
            this.txtCenter.BorderRadius = 20;
            this.txtCenter.BorderSize = 3;
            this.txtCenter.FlatAppearance.BorderSize = 0;
            this.txtCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCenter.Font = new System.Drawing.Font("Yu Gothic UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenter.ForeColor = System.Drawing.Color.Black;
            this.txtCenter.Location = new System.Drawing.Point(404, 93);
            this.txtCenter.Name = "txtCenter";
            this.txtCenter.Size = new System.Drawing.Size(500, 363);
            this.txtCenter.TabIndex = 1;
            this.txtCenter.Text = "Example";
            this.txtCenter.TextColor = System.Drawing.Color.Black;
            this.txtCenter.UseVisualStyleBackColor = false;
            this.txtCenter.Click += new System.EventHandler(this.txtCenter_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNext.BorderColor = System.Drawing.Color.Black;
            this.btnNext.BorderRadius = 20;
            this.btnNext.BorderSize = 3;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Yu Gothic UI", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(1066, 179);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 40);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "rjButton1";
            this.btnNext.TextColor = System.Drawing.Color.Black;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrev.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrev.BorderColor = System.Drawing.Color.Black;
            this.btnPrev.BorderRadius = 20;
            this.btnPrev.BorderSize = 3;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Yu Gothic UI", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.Location = new System.Drawing.Point(1066, 315);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(150, 40);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "rjButton1";
            this.btnPrev.TextColor = System.Drawing.Color.Black;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(443, 541);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(524, 157);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 3;
            this.image.TabStop = false;
            // 
            // frm_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.image);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtCenter);
            this.Controls.Add(this.menu);
            this.Name = "frm_test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LDD App";
            this.Load += new System.EventHandler(this.frmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu;
        private CustomControls.RJControls.RJButton txtCenter;
        private CustomControls.RJControls.RJButton btnNext;
        private CustomControls.RJControls.RJButton btnPrev;
        private System.Windows.Forms.PictureBox image;
    }
}