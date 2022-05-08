using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studMin.Database;
using studMin.Database.Models;

namespace studMin
{
    public partial class StatisticTab : UserControl
    {
        public StatisticTab()
        {
            InitializeComponent();
        }

        private void DataGridViewExport_Button_Click(object sender, EventArgs e)
        {
            if (Semester_ComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SchoolYear_ComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<REPORTSEMESTER> listSemesters = ReportSemesterServices.Instance.GetSemesters();

            string semesterName = Semester_ComboBox.SelectedIndex == 1 ? "1" : "2";
            SEMESTER selectedSemester = GetSelectedSemester(semesterName);

            string schoolYear = SchoolYear_ComboBox.SelectedItem.ToString();
            List<CLASS> listClassesOfSchoolYear = ClassServices.Instance.GetClassBySchoolYear(schoolYear);

            foreach (var report in listSemesters)
            {
                if (report.IDSEMESTER == selectedSemester.ID && listClassesOfSchoolYear.Find(item => item.ID == report.IDCLASS) != null)
                {

                }
            }
        }

        private SEMESTER GetSelectedSemester(string semester)
        {
            return DataProvider.Instance.Database.SEMESTERs.Where(item => item.NAME == semester).FirstOrDefault();
        }
    }
}
