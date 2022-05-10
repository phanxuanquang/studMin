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

            //Program.loadTab(gradeModify_SubTab, ContainerPanel, GradeModify_Button, this.Badge);
        }


        #region Buttons
        private void GradeModify_Button_Click(object sender, EventArgs e)
        {
            Program.loadTab(gradeModify_SubTab, ContainerPanel, GradeModify_Button, this.Badge);
        }

        private void StudentInfor_Button_Click(object sender, EventArgs e)
        {
            Program.loadTab(studentInfor_SubTab, ContainerPanel, StudentInfor_Button, this.Badge);
        }

        private void ClassInfor_Button_Click(object sender, EventArgs e)
        {
            Program.loadTab(classInfor_SubTab, ContainerPanel, ClassInfor_Button, this.Badge);
        }
        #endregion
    }
}
