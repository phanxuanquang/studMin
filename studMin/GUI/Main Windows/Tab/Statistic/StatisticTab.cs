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
        string schoolYear;
        string semesterName;

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

            List<Action.Excel.ReportSemester.Item> list = GetListReportSemesterItem();

            if (list.Count == 0)
            {
                MessageBox.Show("Hiện tại chưa có dữ liệu tương ứng với học kỳ và năm học bạn đã chọn, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ComboBoxesSelectedIndexChangedHandler()
        {
            if (Semester_ComboBox.SelectedIndex == 0 || SchoolYear_ComboBox.SelectedIndex == 0) return;

            List<Action.Excel.ReportSemester.Item> list = GetListReportSemesterItem();
            if (list.Count == 0)
            {
                MessageBox.Show("Hiện tại chưa có dữ liệu tương ứng với học kỳ và năm học bạn đã chọn, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dataSource = new DataTable();
            dataSource.Columns.Add("Thứ tự");
            dataSource.Columns.Add("Lớp");
            dataSource.Columns.Add("Sỉ số");
            dataSource.Columns.Add("Số lượng đạt");
            dataSource.Columns.Add("Tỉ lệ đạt");

            foreach (Action.Excel.ReportCommon.Item item in list)
            {
                dataSource.Rows.Add(dataSource.Rows.Count + 1, item.Lop, item.SiSo, item.SoLuongDat, item.TiLeDat + "%");
            }

            DataTable.DataSource = dataSource;
        }

        private void Semester_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            semesterName = Semester_ComboBox.SelectedIndex == 1 ? "1" : "2";
            ComboBoxesSelectedIndexChangedHandler();
        }

        private void SchoolYear_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            schoolYear = SchoolYear_ComboBox.SelectedItem.ToString();
            ComboBoxesSelectedIndexChangedHandler();
        }

        private List<Action.Excel.ReportSemester.Item> GetListReportSemesterItem()
        {
            List<Action.Excel.ReportSemester.Item> list = new List<Action.Excel.ReportSemester.Item>();

            List<REPORTSEMESTER> listReports = ReportSemesterServices.Instance.GetReports();

            semesterName = Semester_ComboBox.SelectedIndex == 1 ? "1" : "2";
            SEMESTER selectedSemester = GetSelectedSemester(semesterName);

            schoolYear = SchoolYear_ComboBox.SelectedItem.ToString();
            List<CLASS> listClassesOfSchoolYear = ClassServices.Instance.GetClassBySchoolYear(schoolYear);



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

            return list;
        }
    }
}
