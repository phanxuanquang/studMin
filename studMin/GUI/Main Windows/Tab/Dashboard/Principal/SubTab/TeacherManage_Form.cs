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
    public partial class TeacherManage_Form : Form
    {
        public TeacherManage_Form()
        {
            
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
