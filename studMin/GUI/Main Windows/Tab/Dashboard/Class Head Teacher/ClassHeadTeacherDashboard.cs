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
    public partial class ClassHeadTeacherDashboard : TeacherDashboard_Base
    {
        StudentMoralQualify_SubTab studentMoralQualify_SubTab;
        public ClassHeadTeacherDashboard()
        {
            InitializeComponent();
            studentMoralQualify_SubTab = new StudentMoralQualify_SubTab();
        }

        private void MoralQualify_Button_Click(object sender, EventArgs e)
        {
            Program.loadTab(studentMoralQualify_SubTab, ContainerPanel, Specialized_Button, this.Badge);
        }
    }
}
