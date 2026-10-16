using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagerPro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());

            //var LoginWindow = new Login();
            //LoginWindow.FormClosed += new FormClosedEventHandler(FormClosed);
            //LoginWindow.Show();

            var MainWindow = new MainWindow("Antoine", "", "English");
            MainWindow.FormClosed += new FormClosedEventHandler(FormClosed);
            MainWindow.Show();

            Application.Run();
        }

        #region FormClosed
        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }
        #endregion

    }
}
