using System;
using System.Windows.Forms;

namespace Morskoy_boy
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //UI.LoadingScreen.SplashScreen.ShowSplashScreen();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //UI.LoadingScreen.SplashScreen.CloseForm();
            Application.Run(new UI.LoadingScreen.SplashScreen());
        }
    }
}
