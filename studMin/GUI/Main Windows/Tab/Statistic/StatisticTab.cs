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

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel | *.xlsx";

            string exportPath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                exportPath = saveFileDialog.FileName;
            }
            else return;

            List<REPORTSEMESTER> listReports = ReportSemesterServices.Instance.GetReports();

            string semesterName = Semester_ComboBox.SelectedIndex == 1 ? "1" : "2";
            SEMESTER selectedSemester = GetSelectedSemester(semesterName);

            string schoolYear = SchoolYear_ComboBox.SelectedItem.ToString();
            List<CLASS> listClassesOfSchoolYear = ClassServices.Instance.GetClassBySchoolYear(schoolYear);

            List<Action.Excel.SummarySemester.Item> list = new List<Action.Excel.SummarySemester.Item>();

            foreach (var report in listReports)
            {
                CLASS currentClass = listClassesOfSchoolYear.Find(item => item.ID == report.IDCLASS);
                if (report.IDSEMESTER == selectedSemester.ID && currentClass != null)
                {
                    Action.Excel.SummarySemester.Item item = new Action.Excel.SummarySemester.Item()
                    {
                        Lop = currentClass.CLASSNAME,
                        SiSo = currentClass.STUDENTs.Count,
                        SoLuongDat = (int)report.PASSQUANTITY
                    };
                    list.Add(item);
                }
            }

            string formattedSchoolYear = int.Parse(schoolYear) + " - " + (int.Parse(schoolYear) + 1);
            Action.Excel.SummarySemester.SummaryInfo info = new Action.Excel.SummarySemester.SummaryInfo()
            {
                HocKy = int.Parse(semesterName),
                NamHoc = formattedSchoolYear
            };

            Action.Excel.SummarySemester summarySemester = new Action.Excel.SummarySemester();
            summarySemester.InsertInfo(info);

            foreach (Action.Excel.SummarySemester.Item item in list)
            {
                summarySemester.InsertItem(item);
            }

            summarySemester.ShowExcel();
            summarySemester.Save(exportPath);
        }

        private SEMESTER GetSelectedSemester(string semester)
        {
            return DataProvider.Instance.Database.SEMESTERs.Where(item => item.NAME == semester).FirstOrDefault();
        }
    }
}
