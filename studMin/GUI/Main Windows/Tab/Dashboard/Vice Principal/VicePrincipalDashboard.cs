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
    public partial class VicePrincipalDashboard : TeacherDashboard_Base
    {
        ClassManage_SubTab classManageSubTab;
        public VicePrincipalDashboard()
        {
            classManageSubTab = new ClassManage_SubTab();
            InitializeComponent();
        }

        private void Specialized_Button_Click(object sender, EventArgs e)
        {
            Program.loadTab(classManageSubTab, ContainerPanel, Specialized_Button, this.Badge);
        }
    }
}
