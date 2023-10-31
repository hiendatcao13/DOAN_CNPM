using flashcard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace flashcard
{
    public partial class frm_Sign_in : Form
    {
        frm_main form = new frm_main();
        string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\");
        public frm_Sign_in()
        {
            InitializeComponent();
        }

        private void btn_Sign_in_Click(object sender, EventArgs e)
        {
            Flash_Card context = new Flash_Card();
            bool flag = false;//cờ để check xem có tài khoản hông
            Account account = new Account();
            foreach(var item in context.Accounts.ToList())
            {
                if(item.Username.Equals( txt_UserName.Texts))
                {
                    account = item;
                    flag = true;
                }
            }
            if(flag == false)
            {
                MessageBox.Show("Oops! Look like this account is not created. Please register now <3 <3 ", "Can't identify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CheckPass(account))
            {
                account.Status = true;
                context.SaveChanges();
                for (int i = 0; i < Application.OpenForms.Count; i++)
                    Application.OpenForms[i].Hide();
                form.ShowDialog();
                for (int i = 0; i < Application.OpenForms.Count; i++)
                    Application.OpenForms[i].Close();
            }
        }
        private Account getUserName()
        {
            Flash_Card context = new Flash_Card();
            Account account = context.Accounts.FirstOrDefault(p => p.Username == txt_UserName.Texts);
            return account;
        }
        private string content()
        {
            Flash_Card db = new Flash_Card();
            Account account = db.Accounts.FirstOrDefault(p => p.Username == txt_UserName.Texts);
            string name = account.DisplayName;
            string password = account.Password;
            string context = "" +
                "<html><body><h1> Xin chào bạn <mark>" + name + "</mark> thân mếm </h1>" +
                "<p>Sau đây là mật khẩu của bạn <b style=\"background-color:black;font-size:150%;color:white;\">" + password + "</b></br></p>" +
                "<p>Vui lòng không chi sẻ password này với bất kì ai." +
                " Đặc biệt, đừng quên mật khẩu nữa nhé 😘😘😘</p>" +
                "<hr>" +
                "<p>Nếu có những thắc mắc gì, xin vui lòng liên hệ thông tin dưới đây: </p>" +
                "<p>Email liên hệ: dungdatling@gmail.com Số điện thoại: 0378793221 </p>" +
                "<p>Thư này đã được gửi đến <Email> đã được mã hóa.</p>" +
                "<p>Để bảo vệ tài khoản của bạn, vui lòng không chuyển tiếp email này.</p>" +
                "<img src = \"https://drive.google.com/uc?export=view&id=11-ogUr2l7eO1GC2CY0lpdGGaDvMl9tBE\" height = \"300\" width = \"300\">" +
                "<p>Cảm ơn bạn vì đã tin tưởng sử dụng app LDD của chúng tôi. Xin cảm ơn <3 <3 </p>" +
                "</body></html>";
            return context;
        }
        private void sendtoMail()
        {
            string fromMail = "moonsanme13@gmail.com";
            string toMail = getUserName().Email;
            string fromPassword = "fwvohdvalhfttuoa";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Recovery Password App LLD";
            message.To.Add(new MailAddress(toMail));
            message.Body = content();
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true
            };

            smtpClient.Send(message);
        }

        private bool CheckPass(Account acc)
        {
            if (acc.Password.Equals(txt_Password.Texts))
            {
                MessageBox.Show("Sign in successfully. Enjoy our LDD app !");
                return true;
            }
            else
            {
                MessageBox.Show("Look like this password is wrong! Please enter again ");
                txt_Password.Texts = "";
                DialogResult dr = MessageBox.Show("Don't remember password. Get recovery password through your email is register before ?", "Recovery Password", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    sendtoMail();
                    string full = getUserName().Email;
                    string email = getUserName().Email;
                    int index = email.IndexOf("@");
                    int count = email.Substring(0, index).Count();
                    email = email.Substring(0, 5);
                    for(int i = 0; i < count; i++)
                        email = email + "*";
                    email = email + full.Substring(index);
                    MessageBox.Show("Send to " + email + " successfully");
                }
                return false;
            }
        }

        private void lbl_Register_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Hide();
            frm_Register form = new frm_Register();
            form.ShowDialog();
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Close();
        }

        private void frm_Sign_in_Load(object sender, EventArgs e)
        {
            int id = form.IsSignined();
            if(id > 0)
            {
                form.ShowDialog();
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = !txt_Password.PasswordChar;
        }
    }
}
