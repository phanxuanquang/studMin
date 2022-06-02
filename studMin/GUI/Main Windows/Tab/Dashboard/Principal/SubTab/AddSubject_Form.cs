﻿using studMin.Database;
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
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        List<TEACHER> teacherList;

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

            string subjectName = SubjectName_Box.Text;

            SUBJECT existingSubject = SubjectServices.Instance.GetSubjectByName(subjectName);
            if (existingSubject != null)
            {
                MessageBox.Show("Môn học này đã tồn tại, vui lòng chọn tên môn học khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Guid headTeacherId = new Guid((SubjectHead_ComboBox.SelectedItem as ComboboxItem).Value.ToString());
            SubjectServices.Instance.AddSubject(subjectName, headTeacherId);

            SUBJECT addedSubject = SubjectServices.Instance.GetSubjectByName(subjectName);

            foreach (DataGridViewRow row in DataTable.Rows)
            {
                string subId = row.Cells[0].Value.ToString().ToLower();
                TEACHER currentTeacher = DataProvider.Instance.Database.TEACHERs.Where(item => item.ID.ToString().Substring(0, 8).ToLower() == subId).FirstOrDefault();

                currentTeacher.IDSUBJECT = addedSubject.Id;
            }

            DataProvider.Instance.Database.SaveChanges();
            MessageBox.Show("Bổ sung môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddSubject_Form_Load(object sender, EventArgs e)
        {
            teacherList = Database.TeacherServices.Instance.GetTeachersIsNotAssigned();

            foreach (TEACHER teacher in teacherList)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = teacher.INFOR.FIRSTNAME + " " + teacher.INFOR.LASTNAME;
                item.Value = teacher.ID;

                SubjectTeacher_ComboBox.Items.Add(item);
                SubjectHead_ComboBox.Items.Add(item);
            }
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
        }
    }
}
