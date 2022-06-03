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
    public partial class AddSubject_Form : Form
    {
        Guid selectedHeadTeacherId;
        int atLeastOneNormalTeacher = 0;
        List<TEACHER> teacherList;

        
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

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

            if (selectedHeadTeacherId.ToString().StartsWith("00000000"))
            {
                MessageBox.Show("Vui lòng chọn trưởng bộ môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (atLeastOneNormalTeacher == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 giáo viên phụ trách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string subjectName = SubjectName_Box.Text;

            SUBJECT existingSubject = SubjectServices.Instance.GetSubjectByName(subjectName.ToLower());
            if (existingSubject != null)
            {
                MessageBox.Show("Môn học này đã tồn tại, vui lòng chọn tên môn học khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TEACHER selectedHeadTeacher = TeacherServices.Instance.GetTeacherById(selectedHeadTeacherId);

            Guid headTeacherRoleId = DataProvider.Instance.Database.TEACHERROLEs.Where(item => item.ROLE == "Trưởng bộ môn").FirstOrDefault().ID;
            selectedHeadTeacher.IDTEACHERROLE = headTeacherRoleId;

            SubjectServices.Instance.AddSubject(subjectName, selectedHeadTeacherId);

            SUBJECT addedSubject = SubjectServices.Instance.GetSubjectByName(subjectName);

            foreach (DataGridViewRow row in DataTable.Rows)
            {
                string subId = row.Cells[0].Value.ToString().ToLower();
                TEACHER currentTeacher = DataProvider.Instance.Database.TEACHERs.Where(item => item.ID.ToString().Substring(0, 8).ToLower() == subId).FirstOrDefault();

                currentTeacher.IDSUBJECT = addedSubject.Id;
            }

            DataProvider.Instance.Database.SaveChanges();
            MessageBox.Show("Bổ sung môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadInforFromDatabase();
        }

        private void AddSubject_Form_Load(object sender, EventArgs e)
        {
            LoadInforFromDatabase();
        }

        private void LoadInforFromDatabase()
        {
            teacherList = new List<TEACHER>();
            SubjectName_Box.Text = String.Empty;
            SubjectHead_ComboBox.Items.Clear();
            SubjectTeacher_ComboBox.Items.Clear();

            SubjectHead_ComboBox.Items.Add("Chọn giáo viên trưởng bộ môn mới");
            SubjectTeacher_ComboBox.Items.Add("Chọn giáo viên phụ trách");
            SubjectHead_ComboBox.SelectedIndex = SubjectTeacher_ComboBox.SelectedIndex = 0;

            teacherList = TeacherServices.Instance.GetTeachersIsNotAssigned();

            foreach (TEACHER teacher in teacherList)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = teacher.INFOR.FIRSTNAME + " " + teacher.INFOR.LASTNAME;
                item.Value = teacher.ID;

                SubjectHead_ComboBox.Items.Add(item);
                SubjectTeacher_ComboBox.Items.Add(item);
            }

            SubjectName_Box.Focus();
            DataTable.Rows.Clear();
        }

        private void AddSubjectTeacher_Button_Click(object sender, EventArgs e)
        {
            if (SubjectTeacher_ComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên phụ trách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Guid teacherId = new Guid((SubjectTeacher_ComboBox.SelectedItem as ComboboxItem).Value.ToString());
            TEACHER selectedTeacher = TeacherServices.Instance.GetTeacherById(teacherId);

            foreach (DataGridViewRow row in DataTable.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower() == teacherId.ToString().Substring(0, 8).ToLower())
                {
                    MessageBox.Show("Giáo viên này đã được chọn, vui lòng chọn giáo viên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            DataTable.Rows.Add(teacherId.ToString().Substring(0, 8).ToUpper(), selectedTeacher.INFOR.FIRSTNAME + " " + selectedTeacher.INFOR.LASTNAME, selectedTeacher.TEACHERROLE.ROLE);
            atLeastOneNormalTeacher++;
        }

        private void SubjectHead_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubjectHead_ComboBox.SelectedIndex == 0) return;

            Guid teacherId = new Guid((SubjectHead_ComboBox.SelectedItem as ComboboxItem).Value.ToString());
            TEACHER selectedHeadTeacher = TeacherServices.Instance.GetTeacherById(teacherId);
            string headTeacherSubId = selectedHeadTeacher.ID.ToString().Substring(0, 8).ToLower();

            foreach (DataGridViewRow row in DataTable.Rows)
            {
                string cellId = row.Cells[0].Value.ToString().ToLower();
                if (row.Cells[2].Value.ToString() == "Trưởng bộ môn")
                {
                    if (cellId == headTeacherSubId) return;

                    MessageBox.Show("Bạn chỉ có thể phân công tối đa 1 trưởng bộ môn, vui lòng hủy giáo viên đã phân công để chọn giáo viên mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cellId == headTeacherSubId)
                {
                    row.Cells[2].Value = "Trưởng bộ môn";
                    selectedHeadTeacherId = selectedHeadTeacher.ID;
                    atLeastOneNormalTeacher--;
                    return;
                }
            }

            DataTable.Rows.Add(selectedHeadTeacher.ID.ToString().Substring(0, 8).ToUpper(), selectedHeadTeacher.INFOR.FIRSTNAME + " " + selectedHeadTeacher.INFOR.LASTNAME, "Trưởng bộ môn");
            selectedHeadTeacherId = selectedHeadTeacher.ID;
        }

        private void DataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn hủy phân công cho giáo viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (DataTable.Rows[e.RowIndex].Cells[2].Value.ToString() == "Trưởng bộ môn")
                {
                    selectedHeadTeacherId = new Guid();
                }
                else
                {
                    atLeastOneNormalTeacher--;
                }
                DataTable.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
