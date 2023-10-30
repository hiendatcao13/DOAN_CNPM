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

namespace flashcard
{
    public partial class frm_Sign_in : Form
    {
        frm_main form = new frm_main();
        
        public frm_Sign_in()
        {
            InitializeComponent();
        }

        private void btn_Sign_in_Click(object sender, EventArgs e)
        {
            Flash_Card context = new Flash_Card();
            bool flag = false;//cờ để check xem có tài khoản hông
            Account account = new Account();
            foreach(var item in context.Account.ToList())
            {
                if(item.Username.Equals( txt_UserName.Texts))
                {
                    account = item;
                    flag = true;
                }
            }
            if(flag == false)
            {
                MessageBox.Show("Oops! Hình như bạn chưa có tài khoản. Đăng ký đi nhé <3 <3 ");
                return;
            }
            if (CheckPass(account))
            {
                account.Status = true;
                context.SaveChanges();
                form.ShowDialog();
            }
        }

        private bool CheckPass(Account acc)
        {
            if (acc.Password.Equals(txt_Password.Texts))
            {
                MessageBox.Show("Đăng nhập thành công !");
                return true;
            }
            else
            {
                MessageBox.Show("Sai mật khẩu rồi, nhập lại đi ");
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
    }
}
