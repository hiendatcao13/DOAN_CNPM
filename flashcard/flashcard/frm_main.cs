using CustomControls.RJControls;
using flashcard.Model;
using flashcard.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashcard
{
    public partial class frm_main : Form
    { // font màu để chọn (4 màu + 1 màu vàng cho silde trang chủ)
        System.Drawing.Color green = System.Drawing.ColorTranslator.FromHtml("#A8DF8E");
        System.Drawing.Color lightgreen = System.Drawing.ColorTranslator.FromHtml("#F3FDE8");
        System.Drawing.Color lightpink = System.Drawing.ColorTranslator.FromHtml("#FFE5E5");
        System.Drawing.Color pink = System.Drawing.ColorTranslator.FromHtml("#FFBFBF");
        System.Drawing.Color yellow = System.Drawing.ColorTranslator.FromHtml("#FEFDCA");
        Flash_Card db;
        int account_id;
        public frm_main()
        {
            InitializeComponent();
        }
        private void resize_form() // chỉnh lại tỷ lệ của form
        {
            this.Width = 1440;
            this.Height = 1024;
            menu.Width = 96;
            menu.Height = this.Height;
            menu.BackColor = lightpink;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Flash_Card();
            account_id = db.Accounts.FirstOrDefault(p => p.Status == true).ID_Account;
            resize_form();
            TaskBar(menu);
            taskbar_Level();
            handbook();
            trophy();
        }
        private void Form1_Paint(object sender, PaintEventArgs e) // vẻ đường thẳng
        {
            Pen line = new Pen(Color.Black, 7);
            e.Graphics.DrawLine(line, 189, 853, 1147, 853);

        }
        private List<Card> getAllCard()
        {
            Flash_Card db = new Flash_Card();
            int account_id = db.Accounts.FirstOrDefault(p => p.Status == true).ID_Account;
            List<Category> categories = db.Categories.Where(p => p.ID_Account == account_id).ToList();
            List<Card> cards = db.Cards.ToList();
            List<Level> levels = db.Levels.ToList();
            List<Card> temp = new List<Card>();
            foreach (Card card_item in cards)
            {
                foreach (Category category_item in categories)
                    if (card_item.Category_ID == category_item.ID_Category)
                        temp.Add(card_item);
            }
            if(temp.Count == 0)
            {
                Card card = new Card();
                temp.Add(card);
            }
            return temp;
        }
            private void animation(Button btn, int level)
        {
            int sum = getAllCard().Count;
            int count = getAllCard().Where(p => p.Level_ID == level).Count();
            if(count == 0)
            {
                btn.Visible = false;
                return;
            }
            double percentage = 1 - (double)count / sum;
            int end = (int)Math.Floor(percentage * btn.Height);
            for(int i = 0; i < end; i++)
            {
                btn.Location = new Point(btn.Location.X, btn.Location.Y + 1);
                btn.Height--;
            }
        }
        private void taskbar_Level()
        {
            for(int i = 0; i < 5; i++)
            {
                RJButton btn = new RJButton
                {
                    Location = new System.Drawing.Point(189 + i * 200, 290),
                    Name = "button" + (i+1) + "",
                    Size = new System.Drawing.Size(158, 561),
                    TabIndex = 2,
                    Text = "",
                    BackColor = (i == 0) ? pink : (i == 1) ? lightgreen : (i == 2) ? yellow : (i == 3) ? green : lightpink,
                    FlatStyle = FlatStyle.Flat,
                    BorderRadius = 20,
                    BorderSize = 3,
                    BorderColor = Color.Black
                };
                animation(btn, i + 1);
                Label number_word = new Label
                {
                    Location = new System.Drawing.Point(205 + i * 200, btn.Location.Y - 55),
                    Name = "lblNumb" + (i + 1) + "",
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new System.Drawing.Size(131, 50),
                    TabIndex = 2,
                    Text = getAllCard().Where(p => p.Level_ID == (i+1)).Count().ToString(),
                    Font = new Font("Yu Gothic UI", 35),
                };
                if (number_word.Text == "0")
                    number_word.Visible = false;
                Label level = new Label
                {
                    Location = new System.Drawing.Point(189 + i * 200, 891),
                    Name = "lblLevel" + (i + 1) + "",
                    AutoSize = false,
                    TextAlign = ContentAlignment.TopCenter,
                    Size = new System.Drawing.Size(158, 95),
                    TabIndex = 2,
                    Text = (i + 1) + "",
                    Font = new Font("Yu Gothic UI", 35),
                };
                btn.FlatAppearance.BorderColor = Color.Black;
                btn.FlatAppearance.BorderSize = 3;
                Controls.AddRange(new Control[] { btn, number_word, level });
            }
            Label txtlabel = new Label
            {
                Location = new System.Drawing.Point(1159, 853),
                Name = "txtLabel",
                AutoSize = false,
                TextAlign = ContentAlignment.TopCenter,
                Size = new System.Drawing.Size(206, 79),
                TabIndex = 2,
                Text = "Level",
                Font = new Font("Yu Gothic UI", 35),
            };
            Controls.Add(txtlabel);
        }
        private void handbook() // sổ từ vựng
        {
            PictureBox handbook = new PictureBox
            {
                Image = global::flashcard.Properties.Resources.handbook,
                Location = new System.Drawing.Point(189, 81),
                Margin = new System.Windows.Forms.Padding(2),
                Name = "handbook",
                Size = new System.Drawing.Size(95, 95),
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
                TabIndex = 1,
                TabStop = false,
            };
            int count = getAllCard().Count();
            Label text = new Label
            {
                Location = new System.Drawing.Point(302, 98),
                Name = "txtHandBook",
                AutoSize = false,
                TextAlign = ContentAlignment.TopCenter,
                Size = new System.Drawing.Size(487, 100),
                TabIndex = 2,
                Text = "contains " + count + " words",
                Font = new Font("Yu Gothic UI", 35),
            };
            Controls.AddRange(new Control[] { handbook, text});
        }


        private void trophy()
        {
            PictureBox trophy = new PictureBox
            {
                Image = global::flashcard.Properties.Resources.trophy,
                Location = new System.Drawing.Point(821, 81),
                Margin = new System.Windows.Forms.Padding(2),
                Name = "handbook",
                Size = new System.Drawing.Size(93, 96),
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
                TabIndex = 1,
                TabStop = false,
            };
            Label text = new Label
            {
                Location = new System.Drawing.Point(895, 100),
                Name = "txtTrophy",
                AutoSize = false,
                TextAlign = ContentAlignment.TopCenter,
                Size = new System.Drawing.Size(423, 65),
                TabIndex = 2,
                Font = new Font("Yu Gothic UI", 35),
            };
            text.Text = count_streak() + " days streak";
            Controls.AddRange(new Control[] { trophy, text });
        }
        private int count_streak()
        {
            int count = 0;
            List<Card> cards = getAllCard();
            DateTime max = getAllCard().FirstOrDefault().Last_Modify;
            foreach (var item in cards)
                max = (max > item.Last_Modify) ? max : item.Last_Modify;
            if (max.AddDays(2).Date <= DateTime.Now.Date)
            {
                return 0;
            }
            for(int i = 0; i < cards.Count; i++)
            {
                foreach (var item in cards)
                    if (DateTime.Now.Date.AddDays(-(i+1)) == item.Last_Modify)
                    {
                        count++;
                        break;
                    }

            }
            return count;
        }

        
    }
}
