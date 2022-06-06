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
    public partial class SubjectManage_Form : Form
    {
        public SubjectManage_Form()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeSubjectName_Button_Click(object sender, EventArgs e)
        {
            string subjectName = DataTable.SelectedRows[0].Cells["Tên môn học"].Value.ToString();
            ChangeSubjectName_Form changeSubjectName_Form = new ChangeSubjectName_Form(subjectName, this);
            changeSubjectName_Form.ShowDialog();
        }

        private void AddSubject_Button_Click(object sender, EventArgs e)
        {
            AddSubject_Form addSubject_Form = new AddSubject_Form(this);
            addSubject_Form.ShowDialog();
        }

        private void SubjectManage_Form_Load(object sender, EventArgs e)
        {
            LoadSubjectsInfor();
        }

        public void LoadSubjectsInfor()
        {
            DataTable dataSource = new DataTable();

            dataSource.Columns.Add("Mã môn học");
            dataSource.Columns.Add("Tên môn học");
            dataSource.Columns.Add("Trưởng bộ môn");
            dataSource.Columns.Add("Số lượng giáo viên");

            List<SUBJECT> listSubjects = SubjectServices.Instance.GetSubjects();

            foreach (SUBJECT subject in listSubjects)
            {
                int quantityOfTeacher = TeacherServices.Instance.GetTeachersBySubject(subject.Id).Count;
                if (subject.IDHEADTEACHER == null || subject.TEACHER.USER.ISDELETED == true)
                {
                    dataSource.Rows.Add(subject.Id.ToString().Substring(0, 8).ToUpper(), subject.DisplayName, "Chưa có", quantityOfTeacher);
                }
                else
                {
                    TEACHER headTeacher = TeacherServices.Instance.GetTeacherById((Guid)subject.IDHEADTEACHER);
                    dataSource.Rows.Add(subject.Id.ToString().Substring(0,8).ToUpper(), subject.DisplayName, headTeacher.INFOR.FIRSTNAME + " " + headTeacher.INFOR.LASTNAME, quantityOfTeacher);
                }
            }

            DataTable.DataSource = dataSource;
        }

        private void ChangeSubjectHead_Button_Click(object sender, EventArgs e)
        {
            string subjectName = DataTable.SelectedRows[0].Cells["Tên môn học"].Value.ToString();
            ChangeSubjectHead_Form changeSubjectHead_Form = new ChangeSubjectHead_Form(subjectName, this);
            changeSubjectHead_Form.ShowDialog();
        }

        private void changeGeneralPassScore_Button_Click(object sender, EventArgs e)
        {
            ChangeGeneralPassScore_Form changeGeneralPassScore_Form = new ChangeGeneralPassScore_Form();
            changeGeneralPassScore_Form.ShowDialog();
        }
    }
}
