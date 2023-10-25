using flashcard.Properties;
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
    public partial class frm_main : Form
    { // font màu để chọn (4 màu + 1 màu vàng cho silde trang chủ)
        System.Drawing.Color green = System.Drawing.ColorTranslator.FromHtml("#A8DF8E");
        System.Drawing.Color lightgreen = System.Drawing.ColorTranslator.FromHtml("#F3FDE8");
        System.Drawing.Color lightpink = System.Drawing.ColorTranslator.FromHtml("#FFE5E5");
        System.Drawing.Color pink = System.Drawing.ColorTranslator.FromHtml("#FFBFBF");
        System.Drawing.Color yellow = System.Drawing.ColorTranslator.FromHtml("#FEFDCA");
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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            menu.BackColor = lightpink;
            resize_form();
            TaskBar();
            taskbar_Level();
            handbook();
            trophy();
        }
        private void Form1_Paint(object sender, PaintEventArgs e) // vẻ đường thẳng
        {
            Pen line = new Pen(Color.Black, 7);
            e.Graphics.DrawLine(line, 189, 853, 1147, 853);

        }
        private void taskbar_Level()
        {
            for(int i = 0; i < 5; i++)
            {
                Button btn = new Button
                {
                    Location = new System.Drawing.Point(189 + i * 200, 290),
                    
                    Name = "button" + (i+1) + "",
                    Size = new System.Drawing.Size(158, 563),
                    TabIndex = 2,
                    Text = "",
                    BackColor = (i == 0) ? pink : (i == 1) ? lightgreen : (i == 2) ? yellow : (i == 3) ? green : lightpink,
                    FlatStyle = FlatStyle.Flat,
                };
                Label number_word = new Label
                {
                    Location = new System.Drawing.Point(205 + i * 200, btn.Location.Y - 55),
                    Name = "lblNumb" + (i + 1) + "",
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new System.Drawing.Size(131, 50),
                    TabIndex = 2,
                    Text = "100",
                    Font = new Font("Comfortaa", 35),
                };
                Label level = new Label
                {
                    Location = new System.Drawing.Point(189 + i * 200, 891),
                    Name = "lblLevel" + (i + 1) + "",
                    AutoSize = false,
                    TextAlign = ContentAlignment.TopCenter,
                    Size = new System.Drawing.Size(158, 95),
                    TabIndex = 2,
                    Text = (i + 1) + "",
                    Font = new Font("Comfortaa", 35),
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
                Font = new Font("Comfortaa", 35),
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
            Label text = new Label
            {
                Location = new System.Drawing.Point(302, 98),
                Name = "txtHandBook",
                AutoSize = false,
                TextAlign = ContentAlignment.TopCenter,
                Size = new System.Drawing.Size(487, 100),
                TabIndex = 2,
                Text = "contains " + "454" + " words",
                Font = new Font("Comfortaa", 35),
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
                Text = "18" + " days streak",
                Font = new Font("Comfortaa", 35),
            };
            Controls.AddRange(new Control[] { trophy, text });
        }
    }
}
