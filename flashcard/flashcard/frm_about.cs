using flashcard.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void resize_form() // chỉnh lại tỷ lệ của form
        {
            this.Width = 1440;
            this.Height = 1024;
            menu.Width = 96;
            menu.Height = this.Height;
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
        }

        private void icon_mem1() 
        {
            PictureBox mem1 = new PictureBox();
            mem1.Image = global::flashcard.Properties.Resources.mem1;
            mem1.InitialImage = null;
            mem1.Location = new System.Drawing.Point(250,250);
            mem1.Name = "mem1";
            mem1.Size = new System.Drawing.Size(250,250);
            mem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            mem2.Image = global::flashcard.Properties.Resources.mem2;
            mem2.InitialImage = null;
            mem2.Location = new System.Drawing.Point(650, 250);
            mem2.Name = "mem2";
            mem2.Size = new System.Drawing.Size(250, 250);
            mem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            mem3.Image = global::flashcard.Properties.Resources.mem3;
            mem3.InitialImage = null;
            mem3.Location = new System.Drawing.Point(1050, 250);
            mem3.Name = "mem3";
            mem3.Size = new System.Drawing.Size(250, 250);
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
