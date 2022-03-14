using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
