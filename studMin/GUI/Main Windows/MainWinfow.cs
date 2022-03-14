using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studMin
{
    public partial class MainWinfow : Form
    {
        ClassHeadTeacherDashboard classHeadTeacherDashboard;
        Timetable_Tab timetable_Tab;
        public MainWinfow()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
            this.Icon = Properties.Resources.studMin_Icon;

            classHeadTeacherDashboard = new ClassHeadTeacherDashboard();
            timetable_Tab = new Timetable_Tab();

            LoadMainTab(classHeadTeacherDashboard);
        }

        void LoadMainTab(UserControl tab)
        {
            if (ContainerPanel.Controls.Contains(tab))
            {
                tab.BringToFront();
            }
            else
            {
                ContainerPanel.Controls.Add(tab);
                tab.BringToFront();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Program.login_Window = new Login_Window();
            Program.login_Window.ShowIcon = Program.login_Window.ShowInTaskbar = true;
            Program.login_Window.Show();
        }

        private void Timetable_MenuButton_Click(object sender, EventArgs e)
        {
            LoadMainTab(timetable_Tab);
        }

        private void Dashboard_MenuButton_Click(object sender, EventArgs e)
        {
            LoadMainTab(classHeadTeacherDashboard);
        }
    }
}
