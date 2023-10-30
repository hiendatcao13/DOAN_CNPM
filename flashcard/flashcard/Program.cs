using flashcard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashcard
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Flash_Card db = new Flash_Card();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Account account = db.Account.FirstOrDefault(p => p.Status == true);
            if(account == null)
                Application.Run(new frm_Sign_in());
            else
                Application.Run(new frm_main());
        }
    }
}
