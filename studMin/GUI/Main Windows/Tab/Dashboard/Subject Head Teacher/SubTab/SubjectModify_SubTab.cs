using studMin.Database.Models;
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
    public partial class SubjectModify_SubTab : UserControl
    {
        public SubjectModify_SubTab()
        {
            InitializeComponent();
        }

        private void PassGrade_SaveButton_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(PassGrade_Box.Text, out _))
            {
                MessageBox.Show("Điểm chỉ có thể là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Double.Parse(PassGrade_Box.Text) < 0)
            {
                MessageBox.Show("Điểm không được là một số âm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SUBJECT subject = Database.TeacherServices.Instance.GetSubjectOfTeacher();
            }
        }
    }
}
