using flashcard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace flashcard
{
    public partial class frm_test : Form
    {
        System.Drawing.Color green = System.Drawing.ColorTranslator.FromHtml("#A8DF8E");
        System.Drawing.Color lightgreen = System.Drawing.ColorTranslator.FromHtml("#F3FDE8");
        System.Drawing.Color lightpink = System.Drawing.ColorTranslator.FromHtml("#FFE5E5");
        System.Drawing.Color pink = System.Drawing.ColorTranslator.FromHtml("#FFBFBF");
        System.Drawing.Color yellow = System.Drawing.ColorTranslator.FromHtml("#FEFDCA");
        System.Drawing.Color grey = System.Drawing.ColorTranslator.FromHtml("#D9D9D9");
        Flash_Card db;
        string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\");
        int account_id;
        int number_word;
        List<Card> allCard = new List<Card>();
        public frm_test()
        {
            InitializeComponent();
        }
        private void Format(System.Windows.Forms.Button btn, int X, int Y, int width, int height, int sizeFont, Color color, string text)
        {
            btn.Location = new Point(X, Y);
            btn.Size = new Size(width, height);
            btn.Font = new Font("Yu Gothic UI", sizeFont);
            btn.BackColor = color;
            btn.Text = text;
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

        private void frmTest_Load(object sender, EventArgs e)
        {
            frm_library frm_Library = new frm_library();
            db = new Flash_Card();
            number_word = 0;
            account_id = db.Accounts.FirstOrDefault(p => p.Status == true).ID_Account;
            icon_logo();
            resize_form();
            getToolStrip();
            changeFormat();
            showCard();
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
            logo.Click += new EventHandler(show_account);
        }
        private void show_account(object sender, EventArgs e)
        {
            for (int i = 0; i < System.Windows.Forms.Application.OpenForms.Count; i++)
                System.Windows.Forms.Application.OpenForms[i].Hide();
            frm_Account account = new frm_Account();
            account.ShowDialog();
            for (int i = 0; i < System.Windows.Forms.Application.OpenForms.Count; i++)
                System.Windows.Forms.Application.OpenForms[i].Close();
        }
        private void changeFormat()
        {
            image.BackColor = lightgreen;
            image.Location = new Point(314, 290);
            image.Size = new Size(873, 546);
            Format(btnPrev, 410, 882, 287, 91, 50, pink, "Prev");
            Format(btnNext, 813, 882, 287, 91, 50, pink, "Nex");
            Format(txtCenter, 317, 86, 873, 156, 64, green, "");
        }
        public void getCard(List<Card> cards)
        {
            allCard = cards;
        }
        private void showCard()
        {
            if(number_word == allCard.Count - 1)
            {
                MessageBox.Show("You review all your word. Congratulation!!!!");
                return;
            }

            txtCenter.Text = text_word = allCard[number_word].Name_Card;
            image.Image = System.Drawing.Image.FromFile(filePath + allCard[number_word].Picture);
        }
        string text_word;
        private void txtCenter_Click(object sender, EventArgs e)
        {
            if (txtCenter.Text.Contains("..."))
            {
                txtCenter.Font = new Font("Yu Gothic UI", 72);
                txtCenter.Text = text_word;
                txtCenter.Image = null;
            }
            else
            {
                string description = allCard.FirstOrDefault(p => p.Name_Card == text_word).Description;
                txtCenter.Font = new Font("Consolas", 72);
                txtCenter.Text = "..." + description;
                txtCenter.Image = null;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            number_word++;
            showCard();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (number_word < 0)
                return;
            number_word--;
            showCard();
        }
        
    }
}
