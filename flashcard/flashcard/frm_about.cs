using flashcard.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashcard
{
    public partial class frm_about : Form
    {
        System.Drawing.Color green = System.Drawing.ColorTranslator.FromHtml("#A8DF8E");
        System.Drawing.Color lightgreen = System.Drawing.ColorTranslator.FromHtml("#F3FDE8");
        System.Drawing.Color lightpink = System.Drawing.ColorTranslator.FromHtml("#FFE5E5");
        System.Drawing.Color pink = System.Drawing.ColorTranslator.FromHtml("#FFBFBF");
        System.Drawing.Color yellow = System.Drawing.ColorTranslator.FromHtml("#FEFDCA");
        
        public frm_about()
        {
            InitializeComponent();
        }

        private void frm_about_Load(object sender, EventArgs e)
        {
            menu.BackColor = lightpink;
            resize_form();
            frm_main form = new frm_main();
            form.TaskBar(menu);
            icon_logo(menu);
            icon_mem1();
            icon_mem2();
            icon_mem3();
            resize_text();
        }
        private void resize_text()
        {
            txtDetails.Text = "This application applies spaced repetition method to help you remember knowledge scientifically.";
            txtDetails.Font = new Font("Yu Gothic UI", 28);
            txtDetails.Location = new Point(208, 196);
            txtDetails.Size = new Size(1157, 96);
            txtDetails.BackColor = SystemColors.ButtonFace;
            txtDetails2.Text = "What is spaced repetition and how does it work?\r\nSpaced repetition is a learning strategy where lessons are repeatedly reviewed at increasing intervals. The amount of information we retain is sharp in the first 20 minutes but slowly declines as hours and days go by reviewing the same lessons at increasing intervals, you are training your brain to keep a piece of information stored longer in your long-term memory.";
            txtDetails2.Location = new Point(216, 292);
            txtDetails2.Size = new Size(1094, 423);
            txtDetails2.Font = new Font("Yu Gothic UI", 28);
            txtDetails2.BackColor = SystemColors.ButtonFace;
            txtThanks.Text = "THANK YOU FOR USING APP";
            txtThanks.Location = new Point(414, 735);
            txtThanks.Size = new Size(611, 120);
        }

        private void resize_form() // chỉnh lại tỷ lệ của form
        {
            this.Width = 1440;
            this.Height = 1024;
            menu.Width = 96;
            menu.Height = this.Height;
            txtCenter.BackColor = lightgreen;
            txtCenter.Location = new Point(177, 71);
            txtCenter.Size = new Size(1200, 77);
        }

        private void icon_logo(ToolStrip menu) //tạo logo và có bo cong tròn
        {
            PictureBox logo = new PictureBox();
            logo.Image = global::flashcard.Properties.Resources.logo;
            logo.InitialImage = null;
            logo.Location = new System.Drawing.Point(3, 10);
            logo.Name = "logo";
            logo.Size = new System.Drawing.Size(96, 96);
            logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 1;
            logo.TabStop = false;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, logo.Width - 3, logo.Height - 3);
            Region rg = new Region(gp);
            logo.Region = rg;
            Controls.Add(logo);
            logo.BringToFront();
            logo.Click += new EventHandler(show_account);
        }
        private void show_account(object sender, EventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Hide();
            frm_Account account = new frm_Account();
            account.ShowDialog();
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Close();
        }

        private void icon_mem1() 
        {
            PictureBox mem1 = new PictureBox();
            mem1.Image = global::flashcard.Properties.Resources.DuyLinh;
            mem1.InitialImage = null;
            mem1.Location = new System.Drawing.Point(365,817);
            mem1.Name = "mem1";
            mem1.Size = new System.Drawing.Size(160, 160);
            mem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            mem1.TabIndex = 1;
            mem1.TabStop = false;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, mem1.Width - 3, mem1.Height - 3);
            Region rg = new Region(gp);
            mem1.Region = rg;
            Controls.Add(mem1);
            mem1.BringToFront();
        }
        private void icon_mem2()
        {
            PictureBox mem2 = new PictureBox();
            mem2.Image = global::flashcard.Properties.Resources.DTDung;
            mem2.InitialImage = null;
            mem2.Location = new System.Drawing.Point(617, 817);
            mem2.Name = "mem2";
            mem2.Size = new System.Drawing.Size(160, 160);
            mem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            mem2.TabIndex = 1;
            mem2.TabStop = false;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, mem2.Width - 3, mem2.Height - 3);
            Region rg = new Region(gp);
            mem2.Region = rg;
            Controls.Add(mem2);
            mem2.BringToFront();
        }
        private void icon_mem3()
        {
            PictureBox mem3 = new PictureBox();
            mem3.Image = global::flashcard.Properties.Resources.CHDat;
            mem3.InitialImage = null;
            mem3.Location = new System.Drawing.Point(869, 817);
            mem3.Name = "mem3";
            mem3.Size = new System.Drawing.Size(160, 160);
            mem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            mem3.TabIndex = 1;
            mem3.TabStop = false;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, mem3.Width - 3, mem3.Height - 3);
            Region rg = new Region(gp);
            mem3.Region = rg;
            Controls.Add(mem3);
            mem3.BringToFront();
        }
    }
}
