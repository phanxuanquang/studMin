﻿using System;
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
            if (DataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có báo cáo tổng kết của bất kỳ lớp nào được tìm thấy, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            Action.Excel.ReportSemester ReportSemester = new Action.Excel.ReportSemester();
            
            foreach (DataGridViewRow row in DataTable.Rows)
            {
                Action.Excel.ReportSemester.Item item = new Action.Excel.ReportSemester.Item()
                {
                    Lop = row.Cells[1].Value.ToString(),
                    SiSo = int.Parse(row.Cells[4].Value.ToString()),
                    SoLuongDat = int.Parse(row.Cells[5].Value.ToString()),
                };
                ReportSemester.InsertItem(item);
            }

            string exportSchoolYear = DataTable.Rows[0].Cells[3].Value.ToString();
            for (int i = 0; i < DataTable.Rows.Count - 1; i++)
            {
                if (exportSchoolYear != DataTable.Rows[i + 1].Cells[3].Value.ToString())
                {
                    exportSchoolYear = "Mọi năm học";
                    break;
                }
            }

            string exportSemester = DataTable.Rows[0].Cells[2].Value.ToString();
            for (int i = 0; i < DataTable.Rows.Count - 1; i++)
            {
                if (exportSemester != DataTable.Rows[i + 1].Cells[2].Value.ToString())
                {
                    exportSemester = "3";
                    break;
                }
            }

            string formattedSchoolYear = int.Parse(exportSchoolYear) + " - " + (int.Parse(exportSchoolYear) + 1);
            Action.Excel.ReportSemester.Info info = new Action.Excel.ReportSemester.Info()
            {
                HocKy = int.Parse(exportSemester),
                NamHoc = formattedSchoolYear
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
                LoadReportsForAllSemesterAllSchoolYear();
                return;
            }

            if (Semester_ComboBox.SelectedIndex == 0 || SchoolYear_ComboBox.SelectedIndex == 0) return;

            List<Action.Excel.ReportSemester.Item> list = GetListReportSemesterItem();
            if (list.Count == 0)
            {
                MessageBox.Show("Hiện tại chưa có dữ liệu tương ứng với học kỳ và năm học bạn đã chọn, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataSource.Rows.Clear();

            foreach (Action.Excel.ReportCommon.Item item in list)
            {
                dataSource.Rows.Add(dataSource.Rows.Count + 1, item.Lop, semesterName, schoolYear, item.SiSo, item.SoLuongDat, item.TiLeDat + "%");
            }

            DataTable.DataSource = dataSource;
            TittleLabel.Text = "BẢNG THỐNG KÊ KẾT QUẢ HỌC TẬP HỌC KỲ " + semesterName + " NĂM HỌC " + schoolYear + " - " + (int.Parse(schoolYear) + 1);
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
                        SiSo = currentClass.STUDENTs.Count,
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

            dataSource = new DataTable();
            dataSource.Columns.Add("Thứ tự");
            dataSource.Columns.Add("Lớp");
            dataSource.Columns.Add("Học kỳ");
            dataSource.Columns.Add("Năm học");
            dataSource.Columns.Add("Sỉ số");
            dataSource.Columns.Add("Số lượng đạt");
            dataSource.Columns.Add("Tỉ lệ đạt");
            LoadReportsForAllSemesterAllSchoolYear();
        }

        private void LoadReportsForAllSemesterAllSchoolYear(string enteredText = null)
        {
            List<CLASS> listClass = ClassServices.Instance.GetClasss();

            dataSource.Rows.Clear();

            foreach (var report in listReports)
            {
                CLASS currentClass = listClass.Find(classItem => classItem.ID == report.IDCLASS);

                int order = dataSource.Rows.Count + 1;
                string className = currentClass.CLASSNAME;
                int quantity = currentClass.STUDENTs.Count;
                int passQuantity = (int)report.PASSQUANTITY;
                double ratio = Math.Round((double)(100.0 * report.PASSQUANTITY / currentClass.STUDENTs.Count), 2);

                if (enteredText != null)
                {
                    if (className.ToLower().Contains(enteredText.ToLower()))
                    {
                        dataSource.Rows.Add(dataSource.Rows.Count + 1, currentClass.CLASSNAME, report.SEMESTER.NAME, currentClass.SCHOOLYEAR, currentClass.STUDENTs.Count, report.PASSQUANTITY, ratio + "%");
                    }
                }
                else
                {
                    dataSource.Rows.Add(dataSource.Rows.Count + 1, currentClass.CLASSNAME, report.SEMESTER.NAME, currentClass.SCHOOLYEAR, currentClass.STUDENTs.Count, report.PASSQUANTITY, ratio + "%");
                }
            }

            DataTable.DataSource = dataSource;
            TittleLabel.Text = "BẢNG THỐNG KÊ KẾT QUẢ HỌC TẬP THEO HỌC KỲ VÀ NĂM HỌC";
        }

        private void Search_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string enteredText = Search_Box.Text;
                if (String.IsNullOrEmpty(enteredText))
                {
                    LoadReportsForAllSemesterAllSchoolYear();
                    return;
                }

                LoadReportsForAllSemesterAllSchoolYear(enteredText.Trim());
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                Search_Box.Text = String.Empty;
            }
        }
    }
}
