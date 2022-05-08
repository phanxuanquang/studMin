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
    public partial class Timetable_Tab : UserControl
    {
        StudentTimetable_SubTab studentTimetableSubTab;
        TeacherTimetable_SubTab teacherTimetableSubTab;
        public Timetable_Tab(role Role = role.normalTeacher)
        {
            InitializeComponent();
            studentTimetableSubTab = new StudentTimetable_SubTab();
            teacherTimetableSubTab = new TeacherTimetable_SubTab();

            Program.loadTab(teacherTimetableSubTab, ContainerPanel, TeacherTimetable_Button, this.Badge);
        }

        private void StudentTimetable_Button_Click(object sender, EventArgs e)
        {
            Program.loadTab(studentTimetableSubTab, ContainerPanel, StudentTimetable_Button, this.Badge);
        }

        private void TeacherTimetable_Button_Click(object sender, EventArgs e)
        {
            Program.loadTab(teacherTimetableSubTab, ContainerPanel, TeacherTimetable_Button, this.Badge);
        }
    }
}
