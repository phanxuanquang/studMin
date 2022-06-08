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
        List<REPORTSEMESTER> listReports;
        DataTable dataSource;
        string schoolYear;
        string semesterName;
        bool isSelectedRows = false;

        public StatisticTab()
        {
            InitializeComponent();
        }

        private void DataGridViewExport_Button_Click(object sender, EventArgs e)
        {
            if (DataTable.Rows.Count == 0 || DataTable.Rows.GetRowCount(DataGridViewElementStates.Visible) == 0)
            {
                MessageBox.Show("Không có báo cáo tổng kết của bất kỳ lớp nào được tìm thấy, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DataTable.SelectedRows.Count >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn in các hàng đã chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    isSelectedRows = true;
                    ExportExcel();
                    return;
                }
            }

            isSelectedRows = false;
            ExportExcel();

            
        }

        private void ExportExcel()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel | *.xlsx";

            string exportPath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                exportPath = saveFileDialog.FileName;
            }
            else return;

            Action.Excel.ReportSemester ReportSemester = new Action.Excel.ReportSemester();

            string exportSchoolYear;
            string exportSemester;

            if (isSelectedRows)
            {
                exportSchoolYear = DataTable.SelectedRows[0].Cells[3].Value.ToString();
                exportSemester = DataTable.SelectedRows[0].Cells[2].Value.ToString();

                foreach (DataGridViewRow row in DataTable.SelectedRows)
                {
                    Action.Excel.ReportSemester.Item item = new Action.Excel.ReportSemester.Item()
                    {
                        Lop = row.Cells[1].Value.ToString(),
                        SiSo = int.Parse(row.Cells[4].Value.ToString()),
                        SoLuongDat = int.Parse(row.Cells[5].Value.ToString()),
                    };
                    ReportSemester.InsertItem(item);

                    if (row.Index + 1 < DataTable.SelectedRows.Count)
                    {
                        if (exportSchoolYear != DataTable.SelectedRows[row.Index + 1].Cells[3].Value.ToString())
                        {
                            exportSchoolYear = "Mọi năm học";
                        }

                        if (exportSemester != DataTable.SelectedRows[row.Index + 1].Cells[2].Value.ToString())
                        {
                            exportSemester = "3";
                        }
                    }
                    
                }
            }
            else
            {
                exportSchoolYear = DataTable.Rows[0].Cells[3].Value.ToString();
                exportSemester = DataTable.Rows[0].Cells[2].Value.ToString();

                foreach (DataGridViewRow row in DataTable.Rows)
                {
                    Action.Excel.ReportSemester.Item item = new Action.Excel.ReportSemester.Item()
                    {
                        Lop = row.Cells[1].Value.ToString(),
                        SiSo = int.Parse(row.Cells[4].Value.ToString()),
                        SoLuongDat = int.Parse(row.Cells[5].Value.ToString()),
                    };
                    ReportSemester.InsertItem(item);

                    if (row.Index + 1 < DataTable.Rows.Count)
                    {
                        if (exportSchoolYear != DataTable.Rows[row.Index + 1].Cells[3].Value.ToString())
                        {
                            exportSchoolYear = "Mọi năm học";
                        }

                        if (exportSemester != DataTable.Rows[row.Index + 1].Cells[2].Value.ToString())
                        {
                            exportSemester = "3";
                        }
                    }
                }
            }

            Action.Excel.ReportSemester.Info info = new Action.Excel.ReportSemester.Info()
            {
                HocKy = int.Parse(exportSemester),
                NamHoc = exportSchoolYear
            };
            ReportSemester.InsertInfo(info);

            ReportSemester.ShowExcel();
            ReportSemester.Save(exportPath);
        }

        private SEMESTER GetSelectedSemester(string semester)
        {
            return DataProvider.Instance.Database.SEMESTERs.Where(item => item.NAME == semester).FirstOrDefault();
        }

        private void ComboBoxesSelectedIndexChangedHandler()
        {
            if (Semester_ComboBox.SelectedIndex == 0 && SchoolYear_ComboBox.SelectedIndex == 0)
            {
                TittleLabel.Text = "BẢNG THỐNG KÊ KẾT QUẢ HỌC TẬP MỌI HỌC KỲ, MỌI NĂM HỌC";
                LoadReportsForAllSemesterAllSchoolYear(null, true, true);
            }

            else if (Semester_ComboBox.SelectedIndex == 0 && SchoolYear_ComboBox.SelectedIndex != 0)
            {
                TittleLabel.Text = "BẢNG THỐNG KÊ KẾT QUẢ HỌC TẬP MỌI HỌC KỲ NĂM HỌC " + schoolYear + " - " + (int.Parse(schoolYear) + 1);
                LoadReportsForAllSemesterAllSchoolYear(null, true, false);
            }

            else if (Semester_ComboBox.SelectedIndex != 0 && SchoolYear_ComboBox.SelectedIndex == 0)
            {
                TittleLabel.Text = "BẢNG THỐNG KÊ KẾT QUẢ HỌC TẬP HỌC KỲ " + semesterName + " MỌI NĂM HỌC";
                LoadReportsForAllSemesterAllSchoolYear(null, false, true);
            }

            else if (Semester_ComboBox.SelectedIndex != 0 && SchoolYear_ComboBox.SelectedIndex != 0)
            {
                TittleLabel.Text = "BẢNG THỐNG KÊ KẾT QUẢ HỌC TẬP HỌC KỲ " + semesterName + " NĂM HỌC " + schoolYear + " - " + (int.Parse(schoolYear) + 1);
                LoadReportsForAllSemesterAllSchoolYear(null, false, false);
            }
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

            semesterName = Semester_ComboBox.SelectedIndex == 1 ? "1" : "2";
            SEMESTER selectedSemester = GetSelectedSemester(semesterName);

            schoolYear = SchoolYear_ComboBox.SelectedItem.ToString();
            List<CLASS> listClass = ClassServices.Instance.GetClassBySchoolYear(schoolYear);



            foreach (var report in listReports)
            {
                CLASS currentClass = listClass.Find(item => item.ID == report.IDCLASS);
                if (report.IDSEMESTER == selectedSemester.ID && currentClass != null)
                {
                    Action.Excel.ReportSemester.Item item = new Action.Excel.ReportSemester.Item()
                    {
                        Lop = currentClass.CLASSNAME,
                        SiSo = ClassServices.Instance.GetQuantityOfClass(currentClass),
                        SoLuongDat = (int)report.PASSQUANTITY
                    };
                    list.Add(item);
                }
            }

            return list;
        }

        private void StatisticTab_Load(object sender, EventArgs e)
        {
            listReports = ReportSemesterServices.Instance.GetReports();
            List<SEMESTER> listSemesters = DataProvider.Instance.Database.SEMESTERs.Select(item => item).ToList();

            foreach (SEMESTER semester in listSemesters)
            {
                if (semester.NAME == "1")
                {
                    Semester_ComboBox.Items.Add("Học kỳ 1");
                } else if (semester.NAME == "2")
                {
                    Semester_ComboBox.Items.Add("Học kỳ 2");
                }
            }

            List<string> listSchoolYear = new List<string>();
            List<CLASS> listClass = ClassServices.Instance.GetClasss();

            foreach (CLASS currentClass in listClass)
            {
                if (!listSchoolYear.Contains(currentClass.SCHOOLYEAR))
                {
                    listSchoolYear.Add(currentClass.SCHOOLYEAR);
                }
            }

            foreach (string schoolYear in listSchoolYear)
            {
                SchoolYear_ComboBox.Items.Add(schoolYear);
            }

            TittleLabel.Text = "BẢNG THỐNG KÊ KẾT QUẢ HỌC TẬP THEO HỌC KỲ, NĂM HỌC";

            dataSource = new DataTable();
            dataSource.Columns.Add("Thứ tự");
            dataSource.Columns.Add("Lớp");
            dataSource.Columns.Add("Học kỳ");
            dataSource.Columns.Add("Năm học");
            dataSource.Columns.Add("Sỉ số");
            dataSource.Columns.Add("Số lượng đạt");
            dataSource.Columns.Add("Tỉ lệ đạt");
            LoadReportsForAllSemesterAllSchoolYear(null, true, true);
        }

        private void LoadReportsForAllSemesterAllSchoolYear(string enteredText = null, bool forAllSemester = false, bool forAllSchoolYear = false)
        {
            List<CLASS> listClass = ClassServices.Instance.GetClasss();

            dataSource.Rows.Clear();

            foreach (var report in listReports)
            {
                CLASS currentClass = listClass.Find(classItem => classItem.ID == report.IDCLASS);

                int order = dataSource.Rows.Count + 1;
                string className = currentClass.CLASSNAME;
                string semesterName = report.SEMESTER.NAME;
                string schoolYear = currentClass.SCHOOLYEAR;
                int quantity = ClassServices.Instance.GetQuantityOfClass(currentClass);
                int passQuantity = (int)report.PASSQUANTITY;
                double ratio = Math.Round((double)(100.0 * passQuantity / quantity), 2);

                if (enteredText != null)
                {
                    if (className.ToLower().Contains(enteredText.ToLower()))
                    {
                        dataSource.Rows.Add(order, className, semesterName, schoolYear, quantity, passQuantity, ratio + "%");
                    }
                }
                else if (forAllSemester && forAllSchoolYear)
                {
                    dataSource.Rows.Add(order, className, semesterName, schoolYear, quantity, passQuantity, ratio + "%");
                }
                else if (forAllSemester && !forAllSchoolYear)
                {
                    if (this.schoolYear == schoolYear)
                    {
                        dataSource.Rows.Add(order, className, semesterName, schoolYear, quantity, passQuantity, ratio + "%");
                    }
                }
                else if (!forAllSemester && forAllSchoolYear)
                {
                    if (this.semesterName == semesterName)
                    {
                        dataSource.Rows.Add(order, className, semesterName, schoolYear, quantity, passQuantity, ratio + "%");
                    }
                }
                else if (!forAllSemester && !forAllSchoolYear)
                {
                    if (this.semesterName == semesterName && this.schoolYear == schoolYear)
                    {
                        dataSource.Rows.Add(order, className, semesterName, schoolYear, quantity, passQuantity, ratio + "%");
                    }
                }
            }

            DataTable.DataSource = dataSource;
            /*DataTable.Rows[0].Selected = false;*/
        }

        private void Search_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Search_Box.Text = String.Empty;
            }
        }

        private void Search_Box_TextChanged(object sender, EventArgs e)
        {
            string enteredText = Search_Box.Text;
           /* if (String.IsNullOrEmpty(enteredText))
            {
                LoadReportsForAllSemesterAllSchoolYear(null, true, true);
                return;
            }*/

            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DataTable.DataSource];
            currencyManager1.SuspendBinding();

            foreach (DataGridViewRow row in DataTable.Rows)
            {
                string className = row.Cells[1].Value.ToString();

                if (className != null)
                {
                    if (className.ToLower().Contains(enteredText))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

            currencyManager1.ResumeBinding();

            DataGridViewElementStates state = DataGridViewElementStates.Visible;
            int i = DataTable.Rows.GetFirstRow(state);

            if (i >= 0)
            {
                DataTable.Rows[i].Selected = true;
            }
        }
    }
}
