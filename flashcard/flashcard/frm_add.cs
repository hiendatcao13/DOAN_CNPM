using flashcard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace flashcard
{

    public partial class frm_add : Form
    {
        System.Drawing.Color green = System.Drawing.ColorTranslator.FromHtml("#A8DF8E");
        System.Drawing.Color lightgreen = System.Drawing.ColorTranslator.FromHtml("#F3FDE8");
        System.Drawing.Color lightpink = System.Drawing.ColorTranslator.FromHtml("#FFE5E5");
        System.Drawing.Color pink = System.Drawing.ColorTranslator.FromHtml("#FFBFBF");
        System.Drawing.Color yellow = System.Drawing.ColorTranslator.FromHtml("#FEFDCA");
        OpenFileDialog file = new OpenFileDialog();
        public frm_add()
        {
            InitializeComponent();
        }
        private void resize_form() // chỉnh lại tỷ lệ của form
        {
            this.Width = 1440;
            this.Height = 1024;
            menu.Width = 96;
            menu.Height = this.Height;
        }
        private void frm_add_Load(object sender, EventArgs e)
        {
            menu.BackColor = lightpink;
            resize_form();
            frm_main form = new frm_main();
            form.TaskBar(menu);
            icon_logo(menu);
            FillCategotyList();
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
            for (int i = 0; i < System.Windows.Forms.Application.OpenForms.Count; i++)
                System.Windows.Forms.Application.OpenForms[i].Hide();
            frm_Account account = new frm_Account();
            account.ShowDialog();
            for (int i = 0; i < System.Windows.Forms.Application.OpenForms.Count; i++)
                System.Windows.Forms.Application.OpenForms[i].Close();
        }


        private void rjButton6_Click(object sender, EventArgs e)// button chọn ảnh
        {
            
            file.Filter = " Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            file.ShowDialog(); 
            pictureBox1.ImageLocation = file.FileName;
        }
        
        private void update_Category(Flash_Card context)
        {
            try
            {
                if (rjComboBox1.SelectedIndex == -1)
                {
                    Category category = new Category();
                    category.Name_Category = rjComboBox1.Texts;
                    frm_main form = new frm_main();
                    int idAccount = form.IsSignined();
                    category.ID_Account = idAccount;
                    context.Category.Add(category);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void rjButton5_Click(object sender, EventArgs e)//button save
        {
            try
            {
                if (rjTextBox1.Texts == "" || rjTextBox2.Texts == "")
                {
                    MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                }
                Flash_Card context = new Flash_Card();
                update_Category(context);
                //kiểm tra lặp từ
                foreach (var item in context.Card.ToList())
                {
                    if (String.Compare(item.Name_Card, rjTextBox1.Texts, true) == 0)
                    {
                        DialogResult result = MessageBox.Show("Từ này đã có, bạn có chắc muốn thêm", "Thông báo tí <3 ", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            break;
                        }
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                        if(result == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                }    
                Card card = new Card();
                card.Name_Card = rjTextBox1.Texts;
                card.Description = rjTextBox2.Texts;
                if (pictureBox1.Image != null)
                {
                    //thuộc tính Picture chỉ lưu tên tấm ảnh
                    string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\");
                    //Sửa lại tên file = tên textbox "word" với ngày giờ để tránh trùng tên (ví dụ record vừa là động từ vừa là danh từ)
                    string newimage_name = rjTextBox1.Texts + ".png";
                    // copy file tới thư mục resources
                    File.Copy(file.FileName, filePath + newimage_name);
                    //thuộc tính Picture chỉ lưu tên tấm ảnh

                    card.Picture = newimage_name;
                }
                card.Category_ID = context.Category.FirstOrDefault(p => p.Name_Category == rjComboBox1.Texts).ID_Category;
                card.Level_ID = 1;
                card.Last_Modify = DateTime.Now;
                context.Card.Add(card);
                context.SaveChanges();

            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        MessageBox.Show("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }

            MessageBox.Show("Đã lưu");
            rjTextBox1.Texts = null;
            rjTextBox2.Texts = null;
            pictureBox1.Image = null;
        }

        private void FillCategotyList()
        {
            frm_main form = new frm_main();
            int idAccount = form.IsSignined();
            Flash_Card context = new Flash_Card();
            List<Category> categories = context.Category.Where(p => p.ID_Account == idAccount).ToList();
            this.rjComboBox1.DataSource = categories;
            this.rjComboBox1.DisplayMember = "Name_Category";
            this.rjComboBox1.ValueMember = "ID_Category";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rjComboBox1.Texts.ToString());
        }
    }
}