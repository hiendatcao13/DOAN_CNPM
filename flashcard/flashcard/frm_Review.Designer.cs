using System.Windows.Forms;

namespace flashcard
{
    partial class frm_Review
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
            this.Progress_Bar = new CustomControls.RJControls.RJProgressBar();
            this.btn_No_Remember = new CustomControls.RJControls.RJButton();
            this.btn_Remember = new CustomControls.RJControls.RJButton();
            this.button_Content = new System.Windows.Forms.Button();
            this.btn_Content = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(26, 930);
            this.menu.TabIndex = 0;
            this.menu.Text = "toolStrip1";
            // 
            // Progress_Bar
            // 
            this.Progress_Bar.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.Progress_Bar.ChannelHeight = 50;
            this.Progress_Bar.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progress_Bar.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.Progress_Bar.ForeColor = System.Drawing.Color.White;
            this.Progress_Bar.Location = new System.Drawing.Point(191, 141);
            this.Progress_Bar.Name = "Progress_Bar";
            this.Progress_Bar.ShowMaximun = false;
            this.Progress_Bar.ShowValue = CustomControls.RJControls.TextPosition.Right;
            this.Progress_Bar.Size = new System.Drawing.Size(1146, 98);
            this.Progress_Bar.SliderColor = System.Drawing.Color.RoyalBlue;
            this.Progress_Bar.SliderHeight = 10;
            this.Progress_Bar.SymbolAfter = "";
            this.Progress_Bar.SymbolBefore = "";
            this.Progress_Bar.TabIndex = 6;
            // 
            // btn_No_Remember
            // 
            this.btn_No_Remember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            this.btn_No_Remember.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            this.btn_No_Remember.BorderColor = System.Drawing.Color.Black;
            this.btn_No_Remember.BorderRadius = 45;
            this.btn_No_Remember.BorderSize = 3;
            this.btn_No_Remember.FlatAppearance.BorderSize = 4;
            this.btn_No_Remember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_No_Remember.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No_Remember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_No_Remember.Location = new System.Drawing.Point(911, 559);
            this.btn_No_Remember.Name = "btn_No_Remember";
            this.btn_No_Remember.Size = new System.Drawing.Size(366, 133);
            this.btn_No_Remember.TabIndex = 4;
            this.btn_No_Remember.Text = "No Remember";
            this.btn_No_Remember.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_No_Remember.UseVisualStyleBackColor = false;
            // 
            // btn_Remember
            // 
            this.btn_Remember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            this.btn_Remember.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            this.btn_Remember.BorderColor = System.Drawing.Color.Black;
            this.btn_Remember.BorderRadius = 45;
            this.btn_Remember.BorderSize = 3;
            this.btn_Remember.FlatAppearance.BorderSize = 4;
            this.btn_Remember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remember.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Remember.Location = new System.Drawing.Point(239, 559);
            this.btn_Remember.Name = "btn_Remember";
            this.btn_Remember.Size = new System.Drawing.Size(366, 133);
            this.btn_Remember.TabIndex = 3;
            this.btn_Remember.Text = "Remember";
            this.btn_Remember.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Remember.UseVisualStyleBackColor = false;
            // 
            // button_Content
            // 
            this.button_Content.Location = new System.Drawing.Point(0, 0);
            this.button_Content.Name = "button_Content";
            this.button_Content.Size = new System.Drawing.Size(75, 23);
            this.button_Content.TabIndex = 10;
            this.btn_Content.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Content
            // 
            this.btn_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            this.btn_Content.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            this.btn_Content.BorderColor = System.Drawing.Color.Black;
            this.btn_Content.BorderRadius = 23;
            this.btn_Content.BorderSize = 3;
            this.btn_Content.FlatAppearance.BorderSize = 0;
            this.btn_Content.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Content.ForeColor = System.Drawing.Color.Black;
            this.btn_Content.Location = new System.Drawing.Point(385, 274);
            this.btn_Content.Name = "btn_Content";
            this.btn_Content.Size = new System.Drawing.Size(751, 210);
            this.btn_Content.TabIndex = 9;
            this.btn_Content.TextColor = System.Drawing.Color.Black;
            this.btn_Content.UseVisualStyleBackColor = false;
            // 
            // frm_Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 930);
            this.Controls.Add(this.btn_Content);
            this.Controls.Add(this.Progress_Bar);
            this.Controls.Add(this.btn_No_Remember);
            this.Controls.Add(this.btn_Remember);
            this.Controls.Add(this.button_Content);
            this.Controls.Add(this.menu);
            this.Name = "frm_Review";
            this.Text = "frm_Review";
            this.Load += new System.EventHandler(this.frm_Review_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu;
        private CustomControls.RJControls.RJButton btn_No_Remember;
        private CustomControls.RJControls.RJButton btn_Remember;
        private CustomControls.RJControls.RJProgressBar Progress_Bar;
        private Button button_Content;
        private CustomControls.RJControls.RJButton btn_Content;
    }
}