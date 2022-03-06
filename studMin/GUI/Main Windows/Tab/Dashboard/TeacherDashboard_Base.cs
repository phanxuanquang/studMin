using Guna.UI2.WinForms;
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
    public partial class TeacherDashboard_Base : UserControl
    {
        GradeModify_SubTab gradeModify_SubTab;
        ClassInfor_SubTab classInfor_SubTab;
        StudentInfor_SubTab studentInfor_SubTab;
        public TeacherDashboard_Base()
        {
            InitializeComponent();

            gradeModify_SubTab = new GradeModify_SubTab();
            classInfor_SubTab = new ClassInfor_SubTab();
            studentInfor_SubTab = new StudentInfor_SubTab();

            moveBadgeAndLoadTab(ClassInfor_Button, classInfor_SubTab);
        }
        void moveBadgeAndLoadTab(Guna2GradientButton button, UserControl SubTab)
        {
            Badge.Left = button.Location.X;
            
            if(SubTab != null)
            {
                if (!ContainerPanel.Controls.Contains(SubTab))
                {
                    ContainerPanel.Controls.Add(SubTab);
                    SubTab.BringToFront();
                }
                else
                {
                    SubTab.BringToFront();
                }
            }
        }

        #region Buttons
        private void GradeModify_Button_Click(object sender, EventArgs e)
        {
            moveBadgeAndLoadTab(GradeModify_Button, gradeModify_SubTab);
        }

        private void StudentInfor_Button_Click(object sender, EventArgs e)
        {
            moveBadgeAndLoadTab(StudentInfor_Button, studentInfor_SubTab);
        }

        private void ClassInfor_Button_Click(object sender, EventArgs e)
        {
            moveBadgeAndLoadTab(ClassInfor_Button, classInfor_SubTab);
        }

        private void AccountInfor_Button_Click(object sender, EventArgs e)
        {
            moveBadgeAndLoadTab(AccountInfor_Button, null);
        }
        #endregion
    }
}
