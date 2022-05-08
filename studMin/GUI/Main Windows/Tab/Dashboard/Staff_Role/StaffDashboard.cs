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
    public partial class StaffDashboard : UserControl
    {
        ClassInforTab_Staff classInforTab_Staff;
        StudentInforTab_Staff studentInforTab_Staff;
        public StaffDashboard()
        {
            classInforTab_Staff = new ClassInforTab_Staff();
            studentInforTab_Staff = new StudentInforTab_Staff();

            InitializeComponent();

            Program.loadTab(studentInforTab_Staff, ContainerPanel, StudentInfor_Button, this.Badge);
        }

        private void StudentInfor_Button_Click(object sender, EventArgs e)
        {
            Program.loadTab(studentInforTab_Staff, ContainerPanel, StudentInfor_Button, this.Badge);
        }

        private void ClassInfor_Button_Click(object sender, EventArgs e)
        {
            Program.loadTab(classInforTab_Staff, ContainerPanel, ClassInfor_Button, this.Badge);
        }
    }
}
