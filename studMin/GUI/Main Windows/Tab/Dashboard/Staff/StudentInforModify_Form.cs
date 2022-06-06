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
    using Database.Models;
    public partial class StudentInforModify_Form : Form
    {
        STUDYING studyingCurrent;
        public StudentInforModify_Form(object studying)
        {
            InitializeComponent();
            studyingCurrent = studying as STUDYING;
            this.Load += StudentInforModify_Form_Load;
        }

        private void StudentInforModify_Form_Load(object sender, EventArgs e)
        {
            cLASSBindingSource.DataSource = studyingCurrent.CLASS;
            sTUDENTBindingSource.DataSource = studyingCurrent.STUDENT;
            iNFORBindingSource.DataSource = studyingCurrent.STUDENT.INFOR;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
