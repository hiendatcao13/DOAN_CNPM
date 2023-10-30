using flashcard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace flashcard
{

    public partial class frm_Review : Form
    {
        private List<Card> Cards;
        private int currentCardIndex;
        private bool isReviewing;
        private int totalRemembered;
        private int totalNotRemembered;
        private bool showingDescription;

        #region
        System.Drawing.Color green = System.Drawing.ColorTranslator.FromHtml("#A8DF8E");
        System.Drawing.Color lightgreen = System.Drawing.ColorTranslator.FromHtml("#F3FDE8");
        System.Drawing.Color lightpink = System.Drawing.ColorTranslator.FromHtml("#FFE5E5");
        System.Drawing.Color pink = System.Drawing.ColorTranslator.FromHtml("#FFBFBF");
        System.Drawing.Color yellow = System.Drawing.ColorTranslator.FromHtml("#FEFDCA");
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
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Hide();
            frm_Account account = new frm_Account();
            account.ShowDialog();
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Close();
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
        #endregion
        

        public frm_Review()
        {

            InitializeComponent();
            isReviewing = false;
            totalRemembered = 0;
            totalNotRemembered = 0;
            showingDescription = false;

            btn_StartReview.Enabled = true;
        }

        private void frm_Review_Load(object sender, EventArgs e)
        {
            resize_form();
            getMenu();

            // Lấy danh sách thẻ theo tài khoản đã đăng nhập
            Flash_Card dbContext = new Flash_Card();
            int accountId = dbContext.Account.FirstOrDefault(p => p.Status == true).ID_Account;
            Cards = GetCardNames(accountId);
        }

        private List<Card> GetCardNames(int accountId)
        {
            List<Card> ListCard = new List<Card>();

            using (Flash_Card dbContext = new Flash_Card())
            {
                var cards = dbContext.Card
                    .Where(card => card.Category.ID_Account == accountId)
                    .ToList();

                foreach (var card in cards)
                {
                    int minutes = getTime(card);

                    if (card.Last_Modify.AddMinutes(minutes) <= DateTime.Now.Date)
                    {
                        ListCard.Add(card);
                    }
                }
            }

            return ListCard;
        }

        private void UpdateProgressBar()
        {
            int progress = (int)(((double)(currentCardIndex + 1) / Cards.Count) * 100);
            Progress_Bar.Value = progress;
        }

        private void ShowCard(int index)
        {
            if (isReviewing && index < Cards.Count)
            {
                int cardId = Cards[index].ID_Card;
                int levelId = Cards[index].Level_ID;

                if (levelId >= 5)
                {
                    // Bỏ qua từ này nếu Level_ID là 5 hoặc cao hơn
                    currentCardIndex++;
                    ShowCard(currentCardIndex);
                    return;
                }

                using (Flash_Card dbContext = new Flash_Card())
                {
                    Card currentCard = dbContext.Card.Find(cardId);

                    if (showingDescription)
                    {
                        btn_Content.Text = currentCard.Description;
                    }
                    else
                    {
                        btn_Content.Text = currentCard.Name_Card;
                    }
                }

                currentCardIndex = index;
                UpdateProgressBar();
            }
        }

        private void btn_Remember_Click(object sender, EventArgs e)
        {
            if (isReviewing && currentCardIndex < Cards.Count)
            {
                // Tăng Level_ID của Card lên 1
                Cards[currentCardIndex].Level_ID++;
                Cards[currentCardIndex].Last_Modify = DateTime.Now;

                using (Flash_Card dbContext = new Flash_Card())
                {
                    dbContext.Entry(Cards[currentCardIndex]).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }

                totalRemembered++;
                currentCardIndex++;

                if (currentCardIndex < Cards.Count)
                {
                    showingDescription = false; // Đặt lại biến showingDescription khi di chuyển đến thẻ tiếp theo
                    ShowCard(currentCardIndex);
                }
                else
                {
                    EndReview();
                }
                btn_No_Remember.Enabled = true;
            }
        }

        private void btn_No_Remember_Click(object sender, EventArgs e)
        {
            if (isReviewing && currentCardIndex < Cards.Count)
            {
                // Kiểm tra ID_Level
                if (Cards[currentCardIndex].Level_ID < 5)
                {
                    // Reset Level_ID của Card về 1
                    Cards[currentCardIndex].Level_ID = 1;
                    Cards[currentCardIndex].Last_Modify = DateTime.Now;

                    using (Flash_Card dbContext = new Flash_Card())
                    {
                        dbContext.Entry(Cards[currentCardIndex]).State = EntityState.Modified;
                        dbContext.SaveChanges();
                    }

                    totalNotRemembered++;
                }
                if (currentCardIndex < Cards.Count)
                {
                    showingDescription = true; // Hiển thị Description khi không nhớ từ
                    ShowCard(currentCardIndex);
                }
                else
                {
                    EndReview();
                }

                currentCardIndex++;
                btn_No_Remember.Enabled = false;
                
            }
        }

        private void StartReview()
        {
            // Lấy danh sách thẻ theo tài khoản đã đăng nhập
            using (Flash_Card dbContext = new Flash_Card())
            {
                int accountId = dbContext.Account.FirstOrDefault(p => p.Status == true).ID_Account;
                Cards = GetCardNames(accountId);
            }

            if (Cards != null && Cards.Count > 0)
            {
                isReviewing = true;
                currentCardIndex = 0;
                totalRemembered = 0;
                totalNotRemembered = 0;
                Progress_Bar.Value = 0;
                ShowCard(currentCardIndex);
            }
            else
            {
                MessageBox.Show("Không có thẻ cần ôn tập.");
            }
        }

        private void EndReview()
        {
            isReviewing = false;

            currentCardIndex = 0;
            Progress_Bar.Value = 0;
            btn_No_Remember.Enabled= true;
            btn_StartReview.Enabled= true;
            MessageBox.Show($"Số từ đã Remember: {totalRemembered} , Số từ Not Remember: {totalNotRemembered}");
        }

        private void btn_StartReview_Click(object sender, EventArgs e)
        {
            showingDescription = false; // nếu 
            StartReview();

            btn_StartReview.Enabled = false;
        }

        private void btn_Stop_Review_Click(object sender, EventArgs e)
        {
            EndReview();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (isReviewing && currentCardIndex < Cards.Count)
            {
                Cards[currentCardIndex].Last_Modify = DateTime.Now;

                using (Flash_Card dbContext = new Flash_Card())
                {
                    dbContext.Entry(Cards[currentCardIndex]).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }

                currentCardIndex++;

                if (currentCardIndex < Cards.Count)
                {
                    showingDescription = false; // Đặt lại biến showingDescription khi di chuyển đến thẻ tiếp theo
                    ShowCard(currentCardIndex);
                }
                else
                {
                    EndReview();
                }
                btn_No_Remember.Enabled = true;

            }
        }

        private int getTime(Card card)
        {
            using (Flash_Card db = new Flash_Card())
            {
                var level = db.Level.FirstOrDefault(l => l.ID_Level == card.Level_ID);
                return (level != null) ? level.Time : -1;
            }
        }

    }
}
