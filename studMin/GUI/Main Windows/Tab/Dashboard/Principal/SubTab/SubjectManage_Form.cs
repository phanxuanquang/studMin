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
    public partial class SubjectManage_Form : Form
    {
        public SubjectManage_Form()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
        }

        private void FirePerson_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeSubjectName_Button_Click(object sender, EventArgs e)
        {
            ChangeSubjectName_Form changeSubjectName_Form = new ChangeSubjectName_Form();
            changeSubjectName_Form.ShowDialog();
        }

        private void AddSubject_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Từ từ rồi có! Hối đấm giờ!");
        }
    }
}
