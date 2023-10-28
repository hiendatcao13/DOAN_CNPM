using flashcard.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
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
            icon_review(tool);
            icon_export(tool);
            icon_About(tool);
        }
        private void common_menustrip(ToolStripButton tool, ToolStrip menu)
        {
            tool.AutoSize = false;
            menu.ImageScalingSize = new Size(75, 75);
            tool.ImageTransparentColor = Color.Magenta;
            tool.Size = new Size(96, 96);
            tool.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tool.Font = new Font("Consolas", 17, FontStyle.Bold);
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

        private void icon_home(ToolStrip menu)
        {
            ToolStripButton iconHome = new ToolStripButton();
            iconHome.Image = global::flashcard.Properties.Resources.home__1_;
            iconHome.Margin = new System.Windows.Forms.Padding(0, 120, 0, 0);
            iconHome.Name = "iconHome";
            iconHome.Text = "Home";
            common_menustrip(iconHome, menu);
            iconHome.Click += new EventHandler(iconHome_CLick);
        }

        private void iconHome_CLick(object sender, EventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Hide();
            frm_main frm = new frm_main();
            frm.ShowDialog();
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Close();
        }

        private void icon_library(ToolStrip menu)
        {
            ToolStripButton iconLibrary = new ToolStripButton();
            iconLibrary.Image = global::flashcard.Properties.Resources.library;
            iconLibrary.Name = "iconLibrary";
            iconLibrary.Text = "Library";
            common_menustrip(iconLibrary, menu);
            iconLibrary.Click += new EventHandler(IconLibrary_Click);
        }

        private void IconLibrary_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Hide();
            frm_library frm1 = new frm_library();
            frm1.ShowDialog();
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Close();
        }

        private void icon_add(ToolStrip menu)
        {
            ToolStripButton iconAdd = new ToolStripButton();
            iconAdd.Image = global::flashcard.Properties.Resources.plus;
            iconAdd.Name = "iconAdd";
            iconAdd.Text = "Add";
            common_menustrip(iconAdd, menu);
            iconAdd.Click += new EventHandler(IconAdd_Click);
        }

        private void IconAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Hide();
            frm_add form = new frm_add();
            form.ShowDialog();
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Close();
        }
        private void icon_review(ToolStrip menu)
        {
            ToolStripButton iconReview = new ToolStripButton();
            iconReview.Image = global::flashcard.Properties.Resources.review;
            iconReview.Name = "iconreview";
            iconReview.Text = "Review";
            common_menustrip(iconReview, menu);
            iconReview.Click += new EventHandler(click_review);
        }

        private void click_review(object sender, EventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Hide();
            frm_Review frm = new frm_Review();
            frm.ShowDialog();
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Close();
        }

        private void icon_export(ToolStrip menu)
        {
            ToolStripButton iconExport = new ToolStripButton();
            iconExport.Image = global::flashcard.Properties.Resources.export__1_;
            iconExport.Margin = new System.Windows.Forms.Padding(0, 230, 0, 0);
            iconExport.Name = "iconExport";
            iconExport.Text = "Export";
            common_menustrip(iconExport, menu);
            iconExport.Click += new EventHandler(iconExport_Click);
        }
        private void copyAlltoClipboard(DataGridView tabData)
        {
            tabData.ReadOnly = true;
            tabData.SelectAll();
            DataObject dataObj = tabData.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void iconExport_Click(object sender, EventArgs e)
        {
            frm_library frm_Library = new frm_library();
            DataGridView gridView = frm_Library.getDataGridView();
            copyAlltoClipboard(gridView);
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            gridView.ReadOnly = false;
        }

        private void icon_About(ToolStrip menu)
        {
            ToolStripButton iconHelp = new ToolStripButton();
            iconHelp.Image = global::flashcard.Properties.Resources.question;
            iconHelp.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            iconHelp.Name = "iconAbout";
            iconHelp.Text = "About";
            common_menustrip(iconHelp, menu);
            iconHelp.Click += new EventHandler(iconAbout_Click);
        }

        private void iconAbout_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Hide();
            frm_about frm_About = new frm_about();
            frm_About.ShowDialog();
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Close();
        }
        public int IsSignined()
        {
            Flash_Card contex = new Flash_Card();
            foreach (var item in contex.Accounts.ToList())
            {
                if (item.Status == true)
                {
                    return item.ID_Account;
                }
            }
            return -1;
        }
    }
}
