using studMin.Database;
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
            if (PassGrade_Box.Text.Trim().Length == 0)
            {
                MessageBox.Show("Điểm không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(PassGrade_Box.Text, out _))
            {
                MessageBox.Show("Điểm chỉ có thể là số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Double.Parse(PassGrade_Box.Text) <= 0)
            {
                MessageBox.Show("Điểm không được là một số âm hoặc bằng 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SUBJECT subject = TeacherServices.Instance.GetSubjectOfTeacher();
                subject.PASSSCORE = int.Parse(PassGrade_Box.Text);

                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DataProvider.Instance.Database.SaveChanges();
        }

        private void SubjectModify_SubTab_Load(object sender, EventArgs e)
        {
            SUBJECT subject = TeacherServices.Instance.GetSubjectOfTeacher();
            List<TEACHER> listTeachers = TeacherServices.Instance.GetTeachers();

            for (int i = 0; i < listTeachers.Count; i++)
            {
                if (listTeachers[i].IDSUBJECT == subject.Id)
                {
                    GridView.Rows.Add(listTeachers[i].ID, listTeachers[i].INFOR.FIRSTNAME + " " + listTeachers[i].INFOR.LASTNAME, listTeachers[i].INFOR.DAYOFBIRTH, listTeachers[i].USER.EMAIL, "1/1/2022");
                }
            }
            SubjectLabel.Text = subject.DisplayName;
            LoadScoreParameter();
        }

        private void LoadScoreParameter()
        {
            SUBJECT subject = TeacherServices.Instance.GetSubjectOfTeacher();
            int passScore = (int)subject.PASSSCORE;
            int maxScore = 10;
            PARAMETER limitScore = Database.ParameterServices.Instance.GetParameterByName("POINTLADDER");
            if (limitScore != null)
            {
                maxScore = (int)limitScore.MAX;
            }

            PassGrade_Box.Text = passScore.ToString();
            /*MaxGrade_Box.Text = maxScore.ToString();*/
        }
    }
}
