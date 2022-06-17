using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace studMin
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(true);
            ChangePath();
            _isRunning = true;
            Application.Run(login_Window);
        }
        public static Login_Window login_Window = new Login_Window();
        public static void loadTab(UserControl tab, Panel container, Guna2GradientButton button, Panel Badge)
        {
            Badge.Left = button.Location.X;

            if (container.Controls.Contains(tab))
            {
                tab.BringToFront();
            }
            else
            {
                container.Controls.Add(tab);
                tab.BringToFront();
            }
        }

        public static void ChangePath()
        {
            string executable = AppDomain.CurrentDomain.BaseDirectory;

            string path = (System.IO.Path.GetDirectoryName(executable));
            for (int i = 0; i < 3; i++)
            {
                path = path.Remove(path.LastIndexOf("\\", StringComparison.Ordinal));
            }
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }

        public static bool isRunning
        {
            get { return _isRunning; }
        }
        private static bool _isRunning = false;
    }
}
