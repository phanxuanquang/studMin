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

        public StatisticTab()
        {
            InitializeComponent();
        }

        private void DataGridViewExport_Button_Click(object sender, EventArgs e)
        {
            if (DataTable.Rows.Count == 0 || DataTable.Rows.GetRowCount(DataGridViewElementStates.Visible) == 0)
            {
                MessageBox.Show("Không có báo cáo tổng kết của bất kỳ lớp nào được tìm thấy.\nVui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

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

            foreach (DataGridViewRow row in DataTable.Rows)
            {
                if (row.Visible == true)
                {
                    Action.Excel.ReportSemester.Item item = new Action.Excel.ReportSemester.Item()
                    {
                        Lop = row.Cells[1].Value.ToString(),
                        SiSo = int.Parse(row.Cells[4].Value.ToString()),
                        SoLuongDat = int.Parse(row.Cells[5].Value.ToString()),
                    };
                    ReportSemester.InsertItem(item);
                }
                
            }

            Action.Excel.ReportSemester.Info info = new Action.Excel.ReportSemester.Info()
            {
                HocKy = int.Parse(semesterName),
                NamHoc = schoolYear
            };
            ReportSemester.InsertInfo(info);

            ReportSemester.ShowExcel();
            ReportSemester.Save(exportPath);
        }

        private void ComboBoxesSelectedIndexChangedHandler()
        {
            if (Semester_ComboBox.SelectedIndex == 0)
            {
                TittleLabel.Text = "BẢNG THỐNG KÊ KẾT QUẢ HỌC TẬP HỌC KỲ HÈ NĂM HỌC " + schoolYear + " - " + (int.Parse(schoolYear) + 1);
            }
            else if (Semester_ComboBox.SelectedIndex == 1)
            {
                TittleLabel.Text = "BẢNG THỐNG KÊ KẾT QUẢ HỌC TẬP HỌC KỲ I NĂM HỌC " + schoolYear + " - " + (int.Parse(schoolYear) + 1);
            }
            else if (Semester_ComboBox.SelectedIndex == 2)
            {
                TittleLabel.Text = "BẢNG THỐNG KÊ KẾT QUẢ HỌC TẬP HỌC KỲ II NĂM HỌC " + schoolYear + " - " + (int.Parse(schoolYear) + 1);
            }
        }

        private void Semester_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Semester_ComboBox.SelectedIndex == 0)
            {
                semesterName = "0";
            }
            else if (Semester_ComboBox.SelectedIndex == 1)
            {
                semesterName = "1";
            }
            else
            {
                semesterName = "2";
            }

            if (schoolYear != null)
            {
                ComboBoxesSelectedIndexChangedHandler();
            }

            if (dataSource != null)
            {
                LoadReportsForAllSemesterAllSchoolYear(null, true, true);
            }
        }

        private void SchoolYear_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            schoolYear = SchoolYear_ComboBox.SelectedItem.ToString();
            ComboBoxesSelectedIndexChangedHandler();
            if (dataSource != null)
            {
                LoadReportsForAllSemesterAllSchoolYear(null, true, true);
            }
        }

        private void StatisticTab_Load(object sender, EventArgs e)
        {
            listReports = ReportSemesterServices.Instance.GetReports();
            List<SEMESTER> listSemesters = DataProvider.Instance.Database.SEMESTERs.Select(item => item).ToList();
            List<string> listSem = new List<string>();

            foreach (SEMESTER semester in listSemesters)
            {
                if (semester.NAME == "1")
                {
                    listSem.Add("Học kỳ 1");
                }
                else if (semester.NAME == "2")
                {
                    listSem.Add("Học kỳ 2");
                }
                else
                {
                    listSem.Add("Học kỳ hè");
                }
            }

            Semester_ComboBox.DataSource = listSem;

            List<string> listSchoolYear = new List<string>();
            List<CLASS> listClass = ClassServices.Instance.GetClasss();

            foreach (CLASS currentClass in listClass)
            {
                if (!listSchoolYear.Contains(currentClass.SCHOOLYEAR))
                {
                    listSchoolYear.Add(currentClass.SCHOOLYEAR);
                }
            }

            SchoolYear_ComboBox.DataSource = listSchoolYear;


            TittleLabel.Text = "BẢNG THỐNG KÊ KẾT QUẢ HỌC TẬP THEO HỌC KỲ VÀ NĂM HỌC";

            dataSource = new DataTable();
            dataSource.Columns.Add("Thứ tự");
            dataSource.Columns.Add("Lớp học");
            dataSource.Columns.Add("Học kỳ");
            dataSource.Columns.Add("Năm học");
            dataSource.Columns.Add("Sỉ số");
            dataSource.Columns.Add("Số lượng đạt");
            dataSource.Columns.Add("Tỉ lệ đạt");
            LoadReportsForAllSemesterAllSchoolYear(null, true, true);
        }

        private void LoadReportsForAllSemesterAllSchoolYear(string enteredText = null, bool forAllSemester = false, bool forAllSchoolYear = false)
        {
            List<CLASS> listClass = ClassServices.Instance.GetClassBySchoolYear(schoolYear);
            List<SUBJECT> listSubject = SubjectServices.Instance.GetSubjects();
            List<SCORE> scores = DataProvider.Instance.Database.SCOREs.ToList();
            PARAMETER param = DataProvider.Instance.Database.PARAMETERs.Where(item => item.NAME == "PASSSCORE").FirstOrDefault();

            dataSource.Rows.Clear();

            int coefficientOralMark = 1;
            int coefficientRegularMark = 1;
            int coefficientMidTermMark = 1;
            int coefficientFinalMark = 1;

            var listRolescore = Database.DataProvider.Instance.Database.ROLESCOREs.ToList();
            foreach (var item in listRolescore)
            {
                switch (item.ROLE)
                {
                    case "M":
                        coefficientOralMark = item.COEFFICIENT.Value;
                        break;
                    case "15M":
                        coefficientRegularMark = item.COEFFICIENT.Value;
                        break;
                    case "45M":
                        coefficientMidTermMark = item.COEFFICIENT.Value;
                        break;
                    case "FINAL":
                        coefficientFinalMark = item.COEFFICIENT.Value;
                        break;
                }
            }

            foreach (CLASS currentClass in listClass)
            {
                int passQuantity = 0;
                List<STUDENT> listStudents = ClassServices.Instance.GetListStudentOfClass(currentClass);
                if (listStudents.Count == 0) continue;

                foreach (STUDENT student in listStudents)
                {
                    List<double> listAvgAllSubject = new List<double>();

                    foreach (SUBJECT subject in listSubject)
                    {
                        List<SCORE> scoreFilter = scores.Where(item => item.SEMESTER.NAME == semesterName && item.SCHOOLYEAR == schoolYear && item.IDSTUDENT == student.ID && item.IDSUBJECT == subject.Id).ToList();
                        if (scores.Count == 0) continue;
                        List<double> oralMark = new List<double>();
                        List<double> regularMark = new List<double>();
                        List<double> midTermMark = new List<double>();
                        List<double> finalMark = new List<double>();
                        foreach (var x in scoreFilter)
                        {
                            switch (x.ROLESCORE.ROLE)
                            {
                                case "M":
                                    oralMark.Add(x.SCORE1.Value);
                                    break;
                                case "15M":
                                    regularMark.Add(x.SCORE1.Value);
                                    break;
                                case "45M":
                                    midTermMark.Add(x.SCORE1.Value);
                                    break;
                                default:
                                    finalMark.Add(x.SCORE1.Value);
                                    break;
                            }
                        }
                        double avg = (oralMark.Sum() + regularMark.Sum() + midTermMark.Sum() + finalMark.Sum()) / (coefficientOralMark * oralMark.Count + coefficientRegularMark * regularMark.Count + coefficientMidTermMark * midTermMark.Count + coefficientFinalMark * finalMark.Count);
                        if (!double.IsNaN(avg))
                        {
                            listAvgAllSubject.Add(avg);
                        }
                    }

                    if ((listAvgAllSubject.Sum() / listSubject.Count) >= param.MAX)
                    {
                        passQuantity++;
                    }
                }

                string sem = semesterName == "0" ? "Hè" : semesterName;
                dataSource.Rows.Add(dataSource.Rows.Count + 1, currentClass.CLASSNAME, sem, schoolYear, listStudents.Count, passQuantity, Math.Round(passQuantity * 100.0 / listStudents.Count, 2).ToString() + "%");
            }

           /* foreach (var report in listReports)
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
            }*/

            DataTable.DataSource = dataSource;
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

            /*DataGridViewElementStates state = DataGridViewElementStates.Visible;
            int i = DataTable.Rows.GetFirstRow(state);

            if (i >= 0)
            {
                DataTable.Rows[i].Selected = true;
            }*/
        }
    }
}
