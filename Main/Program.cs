using System;
using System.Windows.Forms;
using System.Threading;

namespace Esr.Main
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var splash = new SplashScreen();
                splash.Show();
                Application.DoEvents();
                Thread.Sleep(3000);
                var login = new FLogin(splash);
                //Application.Run(new FSearch());
                Application.Run(login);
                if (login.Confirmed)
                    Application.Run(new FMain());
                //Application.Run(new FSearch());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "O sistema será fechado");
            }
        }
    }
}
