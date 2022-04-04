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
        List<STUDENT> listStudent;
        public StudentMoralQualify_SubTab()
        {
            this.Load += StudentMoralQualify_SubTab_Load;
            InitializeComponent();
        }
        private void StudentMoralQualify_SubTab_Load(object sender, EventArgs e)
        {
            listStudent = Database.ClassServices.Instance.GetListStudentOfClass(LoginServices.Instance.ClassOfHeadTeacher.CLASSNAME);
            cONDUCTBindingSource.DataSource = Database.DataProvider.Instance.Database.CONDUCTs.ToList();
            tRANSCRIPTBindingSource.DataSource = GetTRANSCRIPTs(listStudent);
            LoadGridView();
        }

        private void LoadGridView()
        {
            int count = 1;
            foreach (DataGridViewRow row in DataTable.Rows)
            {
                TRANSCRIPT selected = row.DataBoundItem as TRANSCRIPT;
                if (selected != null)
                {
                    row.Cells["sttDataGridViewTextBoxColumn"].Value = count++;
                    row.Cells["nameDataGridViewTextBoxColumn"].Value = selected.STUDENT.FIRSTNAME + " " + selected.STUDENT.LASTNAME;
                    row.Cells["semesterDataGridViewTextBoxColumn"].Value = selected.SEMESTER.NAME;
                }
            }
        }

        private List<TRANSCRIPT> GetTRANSCRIPTs(List<STUDENT> students)
        {
            List<TRANSCRIPT> transcripts = new List<TRANSCRIPT>();
            foreach (var student in students)
            {
                var transcript = Database.DataProvider.Instance.Database.TRANSCRIPTs.Where(item => item.IDSTUDENT == student.ID).FirstOrDefault();
                if (transcript != null)
                { 
                    transcripts.Add(transcript);
                }    
            }
            return transcripts;
        }

        private void FullGridView_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Search_Box.Text))
            {
                listStudent = Database.ClassServices.Instance.GetListStudentOfClass(LoginServices.Instance.ClassOfHeadTeacher.CLASSNAME);
            }
            else
            {
                listStudent = Database.ClassServices.Instance.GetListStudentOfClass(LoginServices.Instance.ClassOfHeadTeacher.CLASSNAME).Where(item => ((item.FIRSTNAME + " " + item.LASTNAME)).ToLower().Contains(Search_Box.Text.ToLower()) || item.ID.ToString().Contains(Search_Box.Text)).ToList();
            }
            tRANSCRIPTBindingSource.DataSource = GetTRANSCRIPTs(listStudent);
            LoadGridView();
        }

        private void UpdateData_Button_Click(object sender, EventArgs e)
        {
            Database.DataProvider.Instance.Database.SaveChanges();
        }
    }
}
