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
    public partial class PrincipalDashboard : TeacherDashboard_Base
    {
        PrincipalControl_SubTab principalControl_SubTab;
        public PrincipalDashboard()
        {
            principalControl_SubTab = new PrincipalControl_SubTab();
            InitializeComponent();
        }

        private void Specialized_Button_Click(object sender, EventArgs e)
        {
           Program.loadTab(principalControl_SubTab, ContainerPanel, Specialized_Button, this.Badge);
        }
    }
}
