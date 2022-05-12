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
        dynamic Dashboard;
        Timetable_Tab timetable_Tab;
        role Role;
        dynamic statisticTab;
        public MainWinfow(role personRole)
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
            this.Icon = Properties.Resources.studMin_Icon;
            Role = personRole;
        }

        void LoadMainTab(UserControl tab)
        {
            if (!ContainerPanel.Controls.Contains(tab))
            {
                ContainerPanel.Controls.Add(tab);
            }
            tab.BringToFront();
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
        void changeButtonColor(Guna.UI2.WinForms.Guna2Button button)
        {
            button.FillColor = button.HoverState.FillColor;
            switch (button.Tag.ToString())
            {
                case "1":
                    Timetable_MenuButton.FillColor = Statistic_MenuButton.FillColor = Color.White;
                    return;
                case "2":
                    Dashboard_MenuButton.FillColor = Statistic_MenuButton.FillColor = Color.White;
                    return;
                case "3":
                    Timetable_MenuButton.FillColor = Dashboard_MenuButton.FillColor = Color.White;
                    return;
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

        #region Menu Buttons
        private void Statistic_MenuButton_Click(object sender, EventArgs e)
        {
            LoadMainTab(statisticTab);
            changeButtonColor(Statistic_MenuButton);
        }
        private void Timetable_MenuButton_Click(object sender, EventArgs e)
        {
            LoadMainTab(timetable_Tab);
            changeButtonColor(Timetable_MenuButton);
        }
        private void Dashboard_MenuButton_Click(object sender, EventArgs e)
        {
            LoadMainTab(Dashboard);
            changeButtonColor(Dashboard_MenuButton);
        }
        #endregion

        private void MainWinfow_Load(object sender, EventArgs e)
        {

            switch (Role)
            {
                case role.classHead:
                    Dashboard = new ClassHeadTeacherDashboard();
                    timetable_Tab = new Timetable_Tab();
                    statisticTab = new StatisticTab_Headteacher();
                    break;
                case role.subjectHead:
                    Dashboard = new SubjectHeadTeacherDashboard();
                    timetable_Tab = new Timetable_Tab();
                    statisticTab = new StatisticTab();
                    Statistic_MenuButton.Visible = false;
                    break;
                case role.principal:
                    Dashboard = new PrincipalDashboard();
                    timetable_Tab = new Timetable_Tab();
                    statisticTab = new StatisticTab();
                    break;
                case role.vicePrincipal:
                    Dashboard = new NormalTeacherDashboard();
                    timetable_Tab = new Timetable_Tab();
                    statisticTab = new StatisticTab();
                    break;
                case role.normalTeacher:
                    Dashboard = new NormalTeacherDashboard();
                    timetable_Tab = new Timetable_Tab();
                    Statistic_MenuButton.Visible = false;
                    break;
                default: // office staff
                    Dashboard = new StaffDashboard();
                    timetable_Tab = new Timetable_Tab(role.officeStaff);
                    statisticTab = new StatisticTab();
                    break;
            }

            LoadMainTab(Dashboard);
            changeButtonColor(Dashboard_MenuButton);
        }
    }
}
