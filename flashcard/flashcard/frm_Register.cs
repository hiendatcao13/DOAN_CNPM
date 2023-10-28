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

namespace flashcard
{
    public partial class frm_Register : Form
    {
        Flash_Card db;
        string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\");
        public frm_Register()
        {
            InitializeComponent();
        }
        private void checkErrorInput()
        {
            if (txtEmail.Texts == "" || txtPassword.Texts == "" || txtUserName.Texts == "" || txt_Name.Texts == "")
                throw new Exception("Please fill all information");
            if (!txtEmail.Texts.Contains("@"))
                throw new Exception("The email is invalid!!!!");
            if (txtPassword.Texts != txtRepassword.Texts)
                throw new Exception("The password and repassword is not the same. Check again!");
            if (!HasSpecialChars(txtPassword.Texts) || !txtPassword.Texts.Any(c => char.IsUpper(c)))
                throw new Exception("The password is too weak!!! Try again");
            List<Account> accounts = db.Accounts.ToList();
            Account temp = accounts.FirstOrDefault(p => p.Username == txtUserName.Text);
            if (temp != null)
                throw new Exception("This username is already exist !");
        }
        private void save_Image(Account account)
        {
            if (image.Image != null)
            {
                //thuộc tính Picture chỉ lưu tên tấm ảnh
                string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\");
                //Sửa lại tên file = tên textbox "word" với ngày giờ để tránh trùng tên (ví dụ record vừa là động từ vừa là danh từ)
                string newimage_name = txtUserName.Texts + ".png";
                // copy file tới thư mục resources
                File.Copy(file.FileName, filePath + newimage_name);
                //thuộc tính Picture chỉ lưu tên tấm ảnh
                account.Picture = newimage_name;
            }
        }
        private void btn_Sign_in_Click(object sender, EventArgs e)
        {
            try
            {
                checkErrorInput();
                Account account = new Account();
                account.DisplayName = txt_Name.Texts;
                account.Username = txtUserName.Texts;
                account.Password = txtPassword.Texts;
                save_Image(account);
                account.Status = false;
                db.Accounts.Add(account);
                db.SaveChanges();
                MessageBox.Show("Register account successfully ! Please sign in");
                this.Hide();
                frm_Sign_in frm = new frm_Sign_in();
                frm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Register_Load(object sender, EventArgs e)
        {
            db = new Flash_Card();
        }

        private void txtRepassword__TextChanged(object sender, EventArgs e)
        {
            if (txtRepassword.Texts.Length == 0 || txtRepassword.Texts == txtPassword.Texts)
                errorInput.Clear();
            else
                errorInput.SetError(txtRepassword, "The repassword and password does not match");
        }

        private void txtEmail__TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Texts.Length == 0 || txtEmail.Texts.Contains("@"))
                errorInput.Clear();
            else
                errorInput.SetError(txtEmail, "Email is invalid");
        }

        private void txtPassword__TextChanged(object sender, EventArgs e)
        {
            if(HasSpecialChars(txtPassword.Texts) && txtPassword.Texts.Any(c => char.IsUpper(c)) || txtPassword.Texts == "")
            {
                errorInput.Clear();
                lblRePass.Visible = false;
            }
            else
            {
                errorInput.SetError(txtPassword, "Password is invalid");
                lblRePass.Visible = true;
            }
        }
        private bool HasSpecialChars(string yourString)
        {
            return yourString.Any(ch => !char.IsLetterOrDigit(ch));
        }
        OpenFileDialog file;
        private void rjButton1_Click(object sender, EventArgs e)
        {
            file = new OpenFileDialog();
            if(file.ShowDialog() == DialogResult.OK)
            {
                image.Image = Image.FromFile(file.FileName);
            }
        }

        private void txtUserName__TextChanged(object sender, EventArgs e)
        {
            List<Account> accounts = db.Accounts.ToList();
            Account temp = accounts.FirstOrDefault(p => p.Username == txtUserName.Text);
            if (temp == null)
                errorInput.Clear();
            else
                errorInput.SetError(txtUserName, "This username is already exist !");
        }

        private void lbl_Register_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Hide();
            frm_Register frm = new frm_Register();
            frm.ShowDialog();
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Close();
        }
    }
}
