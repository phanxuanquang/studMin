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
    public partial class AddSubject_Form : Form
    {
        public AddSubject_Form()
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
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SubjectName_Box.Text))
            {
                MessageBox.Show("Vui lòng nhập tên môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (SubjectHead_ComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn trưởng bộ môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DataTable.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 giáo viên phụ trách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void AddSubject_Form_Load(object sender, EventArgs e)
        {
            List<TEACHER> teacherList = Database.TeacherServices.Instance.GetTeachersIsNotAssigned();

            foreach (TEACHER teacher in teacherList)
            {
                SubjectHead_ComboBox.Items.Add(teacher.INFOR.FIRSTNAME + " " + teacher.INFOR.LASTNAME);
            }
        }
    }
}
