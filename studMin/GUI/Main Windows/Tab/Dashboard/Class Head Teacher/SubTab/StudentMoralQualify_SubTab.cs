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
    using Database.LoginServices;
    using Database.Models;
    public partial class StudentMoralQualify_SubTab : UserControl
    {
        public StudentMoralQualify_SubTab()
        {
            this.Load += StudentMoralQualify_SubTab_Load;
            InitializeComponent();
        }

        private void StudentMoralQualify_SubTab_Load(object sender, EventArgs e)
        {
            var listStudent = Database.ClassServices.Instance.GetListStudentOfClass(LoginServices.Instance.ClassOfHeadTeacher.CLASSNAME);
            DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            dgvCmb.HeaderText = "Hạnh kiểm";
            dgvCmb.Items.Add("Tốt");
            dgvCmb.Items.Add("Khá");
            dgvCmb.Items.Add("Trung bình");
            dgvCmb.Name = "cmbName";
            DataTable.Columns.Add(dgvCmb);
            LoadToDT(listStudent);
        }

        private void LoadToDT(List<STUDENT> students)
        {
            foreach (var student in students)
            {
                //var transcript = Database.DataProvider.Instance.Database.TRANSCRIPTs.Where(item => item.IDSTUDENT == student.ID).FirstOrDefault();
                DataTable.Rows.Add(student.ID, student.FIRSTNAME + " " + student.LASTNAME);
            }
        }

        private void FullGridView_Button_Click(object sender, EventArgs e)
        {
            DataTable.AutoGenerateColumns = false;
            var listStudent = Database.ClassServices.Instance.GetListStudentOfClass(LoginServices.Instance.ClassOfHeadTeacher.CLASSNAME);
            var students = listStudent.Where(item => (item.FIRSTNAME + " " + item.LASTNAME).Contains(Search_Box.Text) || (item.ID.ToString().Contains(Search_Box.Text))).ToList();
            //LoadToDT(students);
            DataTable.DataSource = students;
            DataTable.Columns[0].DataPropertyName = "ID";
            DataTable.Columns[1].DataPropertyName = "FIRSTNAME" + "LASTNAME";
            
        }

    }
}
