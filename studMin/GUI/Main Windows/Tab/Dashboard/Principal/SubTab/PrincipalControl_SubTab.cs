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
    public partial class PrincipalControl_SubTab : UserControl
    {
        public PrincipalControl_SubTab()
        {
            InitializeComponent();
        }


        private void SubjectManage_Button_Click(object sender, EventArgs e)
        {
            SubjectManage_Form subjectManage_Form = new SubjectManage_Form();
            subjectManage_Form.ShowDialog();    
        }

        private void PeopleManage_Button_Click(object sender, EventArgs e)
        {
            TeacherManage_Form teacherManage_Form = new TeacherManage_Form();
            teacherManage_Form.ShowDialog();
        }
    }
}
