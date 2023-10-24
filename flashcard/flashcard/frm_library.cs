using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace flashcard
{
    public partial class frm_library : Form
    {
        System.Drawing.Color green = System.Drawing.ColorTranslator.FromHtml("#A8DF8E");
        System.Drawing.Color lightgreen = System.Drawing.ColorTranslator.FromHtml("#F3FDE8");
        System.Drawing.Color lightpink = System.Drawing.ColorTranslator.FromHtml("#FFE5E5");
        System.Drawing.Color pink = System.Drawing.ColorTranslator.FromHtml("#FFBFBF");
        System.Drawing.Color yellow = System.Drawing.ColorTranslator.FromHtml("#FEFDCA");
        System.Drawing.Color grey = System.Drawing.ColorTranslator.FromHtml("#D9D9D9");
        public frm_library()
        {
            InitializeComponent();
        }
        private void frm_library_Load(object sender, EventArgs e)
        {
            icon_logo();
            resize_form();
            getToolStrip();
            changeFormat();
        }
        private void getToolStrip()
        {
            frm_main frm_Main = new frm_main();
            frm_Main.TaskBar(menu);
        }
        private void resize_form() // chỉnh lại tỷ lệ của form
        {
            this.Width = 1440;
            this.Height = 1024;
            menu.Width = 96;
            menu.Height = this.Height;
            menu.BackColor = lightpink;
        }
        private void Format(System.Windows.Forms.Button btn, int X, int Y, int width, int height, int sizeFont, Color color, string text)
        {
            btn.Location = new Point(X, Y);
            btn.Size = new Size(width, height);
            btn.Font = new Font("Cofortaa", sizeFont);
            btn.BackColor = color;
            btn.Text = text;
        }
        //Overload
        private void Format(System.Windows.Forms.TextBox txt, int X, int Y, int width, int height, int sizeFont, Color color, string text)
        {
            txt.Location = new Point(X, Y);
            txt.Size = new Size(width, height);
            txt.Font = new Font("Cofortaa", sizeFont);
            txt.BackColor = color;
            txt.Text = text;
        }
        private void Format(System.Windows.Forms.RichTextBox txt, int X, int Y, int width, int height, int sizeFont, Color color, string text)
        {
            txt.Location = new Point(X, Y);
            txt.Size = new Size(width, height);
            txt.Font = new Font("Cofortaa", sizeFont);
            txt.BackColor = color;
            txt.Text = text;
        }
        private void changeFormat()
        {
            txtSearch.BringToFront();
            cmbTopic.Location = new Point(96, 25);
            cmbTopic.Size = new Size(538, 59);
            tabWord.Location = new Point(96, 210);
            tabWord.Size = new Size(538, 690);
            tabWord.BackgroundColor = lightgreen;
            image.Location = new Point(634, 579);
            image.Size = new Size(806, 322);
            image.BackColor = lightpink;
            txtWord.Location = new Point(634, 25);
            txtWord.Size = new Size(805, 165);
            txtSearch.Location = new Point(96, 125);
            txtSearch.Size = new Size(538, 59);
            Format(btnDesc, 724, 486, 200, 74, 35, pink, "Desc");
            Format(btnExample, 1148, 487, 200, 74, 35, pink, "Ex");
            Format(txtDesc, 633, 210, 399, 257, 40, lightpink, "");
            Format(txtExample, 1048, 210, 391, 257, 40, lightpink, "");
            Format(btnSave, 1048, 929, 186, 71, 35, pink, "Save");
            Format(btnTest, 272, 938, 186, 71, 35, yellow, "Test");
            Format(btnDelete, 847, 929, 186, 71, 35, pink, "Delete");
        }
        private void icon_logo() //tạo logo và có bo cong tròn
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
            this.Controls.Add(logo);
            logo.BringToFront();
        }

    }
}
