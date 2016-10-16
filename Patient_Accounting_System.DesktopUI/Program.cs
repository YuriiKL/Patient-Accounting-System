using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Accounting_System.DesktopUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException+= new ThreadExceptionEventHandler(MainForm.UIThreadException);

            Forms.LoginForm loginForm = new Forms.LoginForm();

            if (loginForm.ShowDialog() != DialogResult.OK)
                return;
            
            Application.Run(new MainForm());
        }
    }
}
