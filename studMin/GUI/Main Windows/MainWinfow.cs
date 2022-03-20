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
        TeacherDashboard_Base Dashboard;
        Timetable_Tab timetable_Tab;
        public MainWinfow(role personRole)
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
            this.Icon = Properties.Resources.studMin_Icon;

            switch (personRole)
            {
                case role.classHead:
                    Dashboard = new ClassHeadTeacherDashboard();
                    timetable_Tab = new Timetable_Tab();
                    break;
                case role.subjectHead:
                    Dashboard = new SubjectHeadTeacherDashboard();
                    timetable_Tab = new Timetable_Tab();
                    break;
                case role.principal:
                    timetable_Tab = new Timetable_Tab();
                    break;
                case role.vicePrincipal:
                    timetable_Tab = new Timetable_Tab();
                    break;
                case role.normalTeacher:
                    Dashboard = new NormalTeacherDashboard();
                    timetable_Tab = new Timetable_Tab();
                    break;
                default: // office staff

                    break;
            }
            LoadMainTab(Dashboard);
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
            LoadMainTab(Dashboard);
        }
    }
}
