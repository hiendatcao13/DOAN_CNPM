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
        public void TaskBar(ToolStrip tool)
        {
            icon_logo(tool);
            icon_home(tool);
            icon_library(tool);
            icon_add(tool);
            icon_export(tool);
            icon_Help(tool);
        }
        private void common_menustrip(ToolStripButton tool, ToolStrip menu)
        {
            tool.AutoSize = false;
            menu.ImageScalingSize = new Size(75, 75);
            tool.ImageTransparentColor = Color.Magenta;
            tool.Size = new Size(96, 96);
            tool.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tool.Font = new Font("Comfortaa", 17, FontStyle.Bold);
            tool.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            tool.TextImageRelation = TextImageRelation.ImageAboveText;
            menu.Items.Add(tool);
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
            this.Controls.Add(logo);
            logo.BringToFront();
        }
        private void icon_home(ToolStrip menu)
        {
            ToolStripButton iconHome = new ToolStripButton();
            iconHome.Image = global::flashcard.Properties.Resources.home__1_;
            iconHome.Margin = new System.Windows.Forms.Padding(0, 120, 0, 0);
            iconHome.Name = "iconHome";
            iconHome.Text = "Home";
            common_menustrip(iconHome, menu);
        }
        private void icon_library(ToolStrip menu)
        {
            ToolStripButton iconLibrary = new ToolStripButton();
            iconLibrary.Image = global::flashcard.Properties.Resources.library;
            iconLibrary.Name = "iconLibrary";
            iconLibrary.Text = "Library";
            common_menustrip(iconLibrary, menu);
        }
        private void icon_add(ToolStrip menu)
        {
            ToolStripButton iconAdd = new ToolStripButton();
            iconAdd.Image = global::flashcard.Properties.Resources.plus;
            iconAdd.Name = "iconAdd";
            iconAdd.Text = "Add";
            common_menustrip(iconAdd, menu);
        }
        private void icon_export(ToolStrip menu)
        {
            ToolStripButton iconExport = new ToolStripButton();
            iconExport.Image = global::flashcard.Properties.Resources.export__1_;
            iconExport.Margin = new System.Windows.Forms.Padding(0, 300, 0, 0);
            iconExport.Name = "iconExport";
            iconExport.Text = "Export";
            common_menustrip(iconExport, menu);
        }
        private void icon_Help(ToolStrip menu)
        {
            ToolStripButton iconHelp = new ToolStripButton();
            iconHelp.Image = global::flashcard.Properties.Resources.question;
            iconHelp.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            iconHelp.Name = "iconHelp";
            iconHelp.Text = "Help";
            common_menustrip(iconHelp, menu);
        }
    }
}
