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
    public partial class ChangeSubjectHead_Form : Form
    {
        SubjectManage_Form subjectManageForm;
        string subjectName;

        public ChangeSubjectHead_Form()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
        }

        public ChangeSubjectHead_Form(string _subjectName, SubjectManage_Form _subjectManageForm)
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);

            subjectName = _subjectName;
            SubjectName_Label.Text += _subjectName.ToUpper();
            subjectManageForm = _subjectManageForm;
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

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            if (SubjectTeacher_ComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Guid teacherId = TeacherServices.Instance.GetTeacherByName(SubjectTeacher_ComboBox.SelectedItem.ToString()).ID;
                SubjectServices.Instance.ChangeSubjectHeadTeacher(subjectName, teacherId);

                subjectManageForm.LoadSubjectsInfor();
                MessageBox.Show("Thay đổi trưởng bộ môn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeSubjectHead_Form_Load(object sender, EventArgs e)
        {
            Guid idSubject = SubjectServices.Instance.GetSubjectByName(subjectName).Id;
            List<TEACHER> listTeacher = TeacherServices.Instance.GetTeachersBySubject(idSubject);

            foreach (TEACHER teacher in listTeacher)
            {
                SubjectTeacher_ComboBox.Items.Add(teacher.INFOR.FIRSTNAME + " " + teacher.INFOR.LASTNAME);
            }
        }
    }
}
