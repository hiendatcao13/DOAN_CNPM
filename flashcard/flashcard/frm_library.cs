using CustomControls.RJControls;
using flashcard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
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
        Flash_Card db;
        string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\");
        int account_id;
        public frm_library()
        {
            InitializeComponent();
        }
        private void frm_library_Load(object sender, EventArgs e)
        {
            db = new Flash_Card();
            account_id = db.Accounts.FirstOrDefault(p => p.Status == true).ID_Account;
            icon_logo();
            resize_form();
            getToolStrip();
            changeFormat();
            fillCombobox();
            BindGrid(checkListCard());
            visible_property(false);
        }
        private void visible_property(bool check)
        {
            txtWord.Visible = txtDesc.Visible = image.Visible = btnDelete.Visible = btnSave.Visible
                 = btnDesc.Visible = check;
        }
        private void fillCombobox()
        {
            List<Category> categories = db.Categories.Where(p => p.ID_Account == account_id).ToList();
            Category category = new Category();
            category.Name_Category = "<<All>>";
            categories.Insert(0, category);
            cmbTopic.DataSource = categories;
            cmbTopic.DisplayMember = "Name_Category";
            cmbTopic.ValueMember = "ID_Category";
            cmbTopic.SelectedIndex = 0;
        }
        private void BindGrid(List<Card> cards)
        {
            tabWord.Rows.Clear();
            foreach(var item in cards)
            {
                int index = tabWord.Rows.Add();
                tabWord.Rows[index].Cells[0].Value = item.Name_Card;
                tabWord.Rows[index].Cells[1].Value = item.Category.Name_Category;
                tabWord.Rows[index].Cells[2].Value = item.Description;
                if (item.Picture != null)
                    tabWord.Rows[index].Cells[3].Value = filePath + item.Picture;
                else
                    tabWord.Rows[index].Cells[3].Value = "This word not have image";
            }
        }
        public DataGridView getDataGridView()
        {
            Flash_Card db = new Flash_Card();
            foreach (DataGridViewColumn column in tabWord.Columns)
                column.Visible = true;
            tabWord.ColumnHeadersVisible = true;
            BindGrid(db.Cards.ToList());
            return tabWord;
        }
        private void getToolStrip()
        {
            frm_main frm_Main = new frm_main();
            frm_Main.TaskBar(menu);
        }
        private void resize_form() // chỉnh lại tỷ lệ của form
        {
            this.Width = 1500;
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
        private void changeFormat()
        {
            txtSearch.BringToFront();
            cmbTopic.Location = new Point(96, 25);
            cmbTopic.Size = new Size(538, 59);
            tabWord.Location = new Point(96, 210);
            tabWord.Size = new Size(538, 814);
            tabWord.BackgroundColor = lightgreen;
            image.Location = new Point(634, 579);
            image.Size = new Size(806, 322);
            image.BackColor = lightpink;
            txtWord.Location = new Point(634, 25);
            txtWord.Size = new Size(805, 165);
            txtSearch.Location = new Point(96, 125);
            txtSearch.Size = new Size(538, 59);
            txtDesc.Location = new Point(927, 247);
            txtDesc.Size = new Size(514, 274);
            Format(btnDesc, 685, 358, 200, 74, 35, pink, "Desc");
            Format(btnSave, 1048, 929, 186, 71, 35, pink, "Save");
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
        private List<Card> checkListCard()
        {
            List<Category> categories = db.Categories.Where(p => p.ID_Account == account_id).ToList();
            List<Card> cards = db.Cards.ToList();
            List<Card> temp = new List<Card>();
            foreach (Card card in cards)
                foreach (Category category in categories)
                    if (card.Category_ID == category.ID_Category)
                        temp.Add(card);
            if (cmbTopic.SelectedIndex == 0)
                return temp;
            return temp.Where(p => p.Category_ID == (cmbTopic.SelectedItem as Category).ID_Category).ToList();
        }

        private void cmbTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            visible_property(false);
            txtDesc.Texts = "";
            BindGrid(checkListCard());
        }
        private int getRowIndex = 0;
        private void tabWord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            visible_property(true);
            int index = getRowIndex = e.RowIndex;
            txtWord.Text = tabWord.Rows[index].Cells[0].Value.ToString();
            Card card = db.Cards.FirstOrDefault(p => p.Name_Card == txtWord.Text);
            txtDesc.Texts = card.Description;
            txtWord.Text = card.Name_Card;
            if (card.Picture == null)
                image.Image = null;
            else
                load_ảnh(card);
        }
        private void load_ảnh(Card card)
        {
            image.Image = Image.FromFile(filePath + card.Picture);
        }
        OpenFileDialog file;
        private void image_Click(object sender, EventArgs e)
        {
            file = new OpenFileDialog();
            file.Filter = "Image File|*png;*jpg;*jpeg";
            if (file.ShowDialog() == DialogResult.OK)
                image.Image = Image.FromFile(file.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtWord.Text == "" || txtDesc.Texts == "")
                    throw new Exception("Please fill all information !");
                txtSearch.Texts = "";
                Card card = db.Cards.FirstOrDefault(p => p.Name_Card == txtWord.Text);
                card.Description = txtDesc.Texts;
                if (card.Picture != null)
                    File.Delete(filePath + card.Picture);
                if(image.Image != null)
                {
                    //Sửa lại tên file = tên textbox "word" với ngày giờ để tránh trùng tên (ví dụ record vừa là động từ vừa là danh từ)
                    string newimage_name = txtWord.Text  + ".png";
                    // copy file tới thư mục resources
                    File.Copy(file.FileName, filePath + newimage_name);
                    //thuộc tính Picture chỉ lưu tên tấm ảnh
                    card.Picture = newimage_name;
                }
                db.Cards.AddOrUpdate(card);
                db.SaveChanges();
                MessageBox.Show("Update word successfully !!!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tabWord.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower().Contains(txtSearch.Texts.ToLower()))
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result =  MessageBox.Show("Are you sure ?", "Pay attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    txtSearch.Texts = "";
                    List<Card> cards = checkListCard();
                    Card card = cards.FirstOrDefault(p => p.Name_Card == txtWord.Text);
                    db.Cards.Remove(card);
                    db.SaveChanges();
                    MessageBox.Show("Delete flashcard successfully !!!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGrid(checkListCard());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
