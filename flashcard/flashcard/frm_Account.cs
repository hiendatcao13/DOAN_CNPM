using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace flashcard
{
    public partial class frm_Account : Form
    {
        System.Drawing.Color green = System.Drawing.ColorTranslator.FromHtml("#A8DF8E");
        System.Drawing.Color lightgreen = System.Drawing.ColorTranslator.FromHtml("#F3FDE8");
        System.Drawing.Color lightpink = System.Drawing.ColorTranslator.FromHtml("#FFE5E5");
        System.Drawing.Color pink = System.Drawing.ColorTranslator.FromHtml("#FFBFBF");
        System.Drawing.Color yellow = System.Drawing.ColorTranslator.FromHtml("#FEFDCA");
        public frm_Account()
        {
            InitializeComponent();
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
        private void resize_form() // chỉnh lại tỷ lệ của form
        {
            this.AutoSize = false;
            this.Width = 1440;
            this.Height = 1024;
            menu.Width = 96;
            menu.Height = this.Height;
            menu.BackColor = lightpink;
        }
        private void getMenu()
        {
            frm_main frm = new frm_main();
            frm.TaskBar(menu);
            icon_logo(menu);
        }

        private void frm_Account_Load(object sender, EventArgs e)
        {
            resize_form();
            getMenu();
        }

        private void btn_Sign_in_Click(object sender, EventArgs e)
        {
            frm_Sign_in frm_signin = new frm_Sign_in();
            frm_signin.ShowDialog();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            frm_Register frm_Register = new frm_Register();
            frm_Register.ShowDialog();
        }

        private void btn_Save_Imformation_Click(object sender, EventArgs e)
        {

        }
    }
}
