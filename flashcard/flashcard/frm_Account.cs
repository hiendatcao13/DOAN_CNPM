using CustomControls.RJControls;
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
        static frm_main frm = new frm_main();
        int idAcc = frm.IsSignined();
        OpenFileDialog file = new OpenFileDialog();
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
            txt_Display_Name.BackColor = txt_Email.BackColor = txt_Password.BackColor = txt_Username.BackColor =lightpink;
            
        }

        public void frm_Account_Load(object sender, EventArgs e)
        {
            resize_form();
            BindForm(idAcc);
        }

        private void BindForm(int idAcc)
        {
            Flash_Card context = new Flash_Card();
            Account acc= context.Account.ToList().Where(p => p.ID_Account == idAcc).FirstOrDefault();
            if (acc == null)
                return;
            txt_Display_Name.Texts = acc.DisplayName;
            txt_Username.Texts = acc.Username;
            txt_Password.Texts = acc.Password;
            txt_Email.Texts = acc.Email;
            Load_Ava(acc);
        }

        private void Load_Ava(Account acc)
        {
            if(acc.Picture != null)
            {
                string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\");
                pictureBox1.Image = System.Drawing.Image.FromFile(filePath + acc.Picture);
            }
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
            try
            {
                Flash_Card context = new Flash_Card();
                Account account = context.Account.ToList().Where(p => p.ID_Account == idAcc).FirstOrDefault();
                account.DisplayName = txt_Display_Name.Texts;
                account.Username = txt_Username.Texts;
                account.Password = txt_Password.Texts;
                account.Email = txt_Email.Texts;
                if (pictureBox1.Image != null)
                {
                    //thuộc tính Picture chỉ lưu tên tấm ảnh
                    string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\");
                    //Sửa lại tên file = tên textbox "word" với ngày giờ để tránh trùng tên (ví dụ record vừa là động từ vừa là danh từ)
                    string newimage_name = txt_Username.Texts + ".png";
                    // copy file tới thư mục resources
                    File.Copy(file.FileName, filePath + newimage_name);
                    //thuộc tính Picture chỉ lưu tên tấm ảnh

                    account.Picture = newimage_name;
                }
                context.SaveChanges();
                MessageBox.Show("Đã lưu thay đổi");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            Flash_Card context = new Flash_Card();
            Account acc = context.Account.ToList().Where(p => p.ID_Account == idAcc).FirstOrDefault();
            acc.Status = false;
            context.SaveChanges();
            Environment.Exit(0);
        }

        private void txt_Password_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txt_Username.PasswordChar == true)
                txt_Username.PasswordChar = false;
            else
                txt_Username.PasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            file.Filter = " Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            file.ShowDialog();
            pictureBox1.ImageLocation = file.FileName;
        }
    }
}
