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
    public partial class ChangeSubjectName_Form : Form
    {
        string subjectName;
        SubjectManage_Form subjectManageForm;
        public ChangeSubjectName_Form()
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
        public ChangeSubjectName_Form(string _subjectName, SubjectManage_Form _subjectManageForm)
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);

            subjectName = _subjectName;
            subjectManageForm = _subjectManageForm;

            SubjectName_Label.Text += subjectName.ToUpper();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            if (SubjectName_Box.Text.Trim().Length == 0 || ConfirmSubjectName_Box.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (SubjectName_Box.Text != ConfirmSubjectName_Box.Text)
            {
                MessageBox.Show("Vui lòng xác nhận lại tên mới của môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SUBJECT currentSubject = SubjectServices.Instance.GetSubjectByName(subjectName);
            currentSubject.DisplayName = SubjectName_Box.Text.Trim();

            DataProvider.Instance.Database.SaveChanges();
            subjectManageForm.LoadSubjectsInfor();

            /*DataProvider.Instance.Database.SUBJECTs.Where(item => item.Id == currentSubject.Id).FirstOrDefault().DisplayName = SubjectName_Box.Text.Trim();*/

            MessageBox.Show("Thay đổi tên môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
