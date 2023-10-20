using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashcard
{
    public partial class frm_main : Form
    {
        public void TaskBar()
        {
            icon_logo();
            icon_home();
            icon_library();
            icon_add();
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
            Controls.Add(logo);
            logo.BringToFront();
        }
        private void icon_home()
        {
            ToolStripButton iconHome = new System.Windows.Forms.ToolStripButton();
            iconHome.AutoSize = false;
            menu.ImageScalingSize = new Size(96, 96);
            iconHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            iconHome.Image = global::flashcard.Properties.Resources.home;
            iconHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            iconHome.Margin = new System.Windows.Forms.Padding(0, 120, 0, 0);
            iconHome.Name = "iconHome";
            iconHome.Size = new System.Drawing.Size(96, 96);
            iconHome.Text = "Home";
            iconHome.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            iconHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            iconHome.ImageScaling = ToolStripItemImageScaling.None;
            menu.Items.Add(iconHome);
        }
        private void icon_library()
        {
            ToolStripButton iconLibrary = new System.Windows.Forms.ToolStripButton();
            iconLibrary.AutoSize = false;
            menu.ImageScalingSize = new Size(75, 75);
            iconLibrary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            iconLibrary.Image = global::flashcard.Properties.Resources.library;
            iconLibrary.ImageTransparentColor = System.Drawing.Color.Magenta;
            iconLibrary.Name = "iconLibrary";
            iconLibrary.Size = new System.Drawing.Size(96, 96);
            iconLibrary.Text = "Library";
            iconLibrary.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            iconLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            iconLibrary.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            menu.Items.Add(iconLibrary);
        }
        private void icon_add()
        {
            ToolStripButton iconAdd = new System.Windows.Forms.ToolStripButton();
            iconAdd.AutoSize = false;
            menu.ImageScalingSize = new Size(75, 75);
            iconAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            iconAdd.Image = global::flashcard.Properties.Resources.add;
            iconAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            iconAdd.Name = "iconAdd";
            iconAdd.Size = new System.Drawing.Size(96, 96);
            iconAdd.Text = "Add";
            iconAdd.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            iconAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            iconAdd.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            menu.Items.Add(iconAdd);
        }
    }
}
