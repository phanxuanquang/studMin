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
                MessageBox.Show("Vui lòng chọn học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (SchoolYear_ComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            string semesterName = Semester_ComboBox.SelectedIndex == 1 ? "0" : "1";
            SEMESTER selectedSemester = GetSelectedSemester(semesterName);

            string schoolYear = SchoolYear_ComboBox.SelectedItem.ToString();
            List<CLASS> listClassesOfSchoolYear = ClassServices.Instance.GetClassBySchoolYear(schoolYear);

            List<Action.Excel.ReportSemester.Item> list = new List<Action.Excel.ReportSemester.Item>();

            foreach (var report in listReports)
            {
                CLASS currentClass = listClassesOfSchoolYear.Find(item => item.ID == report.IDCLASS);
                if (report.IDSEMESTER == selectedSemester.ID && currentClass != null)
                {
                    Action.Excel.ReportSemester.Item item = new Action.Excel.ReportSemester.Item()
                    {
                        Lop = currentClass.CLASSNAME,
                        SiSo = currentClass.STUDENTs.Count,
                        SoLuongDat = (int)report.PASSQUANTITY
                    };
                    list.Add(item);
                }
            }

            string formattedSchoolYear = int.Parse(schoolYear) + " - " + (int.Parse(schoolYear) + 1);
            Action.Excel.ReportSemester.Info info = new Action.Excel.ReportSemester.Info()
            {
                HocKy = int.Parse(semesterName),
                NamHoc = formattedSchoolYear
            };

            Action.Excel.ReportSemester ReportSemester = new Action.Excel.ReportSemester();
            ReportSemester.InsertInfo(info);

            foreach (Action.Excel.ReportSemester.Item item in list)
            {
                ReportSemester.InsertItem(item);
            }

            ReportSemester.ShowExcel();
            ReportSemester.Save(exportPath);
        }

        private SEMESTER GetSelectedSemester(string semester)
        {
            return DataProvider.Instance.Database.SEMESTERs.Where(item => item.NAME == semester).FirstOrDefault();
        }
    }
}
