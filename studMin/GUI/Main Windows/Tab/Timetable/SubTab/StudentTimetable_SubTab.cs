using ClosedXML.Excel;
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
    public partial class StudentTimetable_SubTab : UserControl
    {
        public StudentTimetable_SubTab()
        {
            InitializeComponent();
        }

        private void TimetableExport_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Excel | *.xlsx";

            string exportPath = string.Empty;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                exportPath = saveFileDialog.FileName;
            } 
            else
            {
                return;
            }

            Action.Excel.ScheduleStudent.Info info = new Action.Excel.ScheduleStudent.Info()
            {
                GiaoVien = "Nguyễn Ngân Hà",
                HocKy = 1,
                NgayApDung = DateTime.Now,
                Lop = "10A2",
                NamHoc = "2022 - 2023"
            };

            List<Action.Excel.ScheduleAllTeacher.Item> list = new List<Action.Excel.ScheduleAllTeacher.Item>()
            {
                new Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien="Nguyễn Kim Phượng",
                    Buoi="M",
                    TietBatDau=1,
                    TietKeoDai=2,
                    Lop="10A2",
                    MonHoc="Toán",
                    NgayHoc=Methods.TryParse("14/03/2022")
                },
                new Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien="Nguyễn Kim Liên",
                    Buoi="A",
                    TietBatDau=2,
                    TietKeoDai=2,
                    Lop="10A2",
                    MonHoc="Văn",
                    NgayHoc=Methods.TryParse("15/03/2022")
                },
                new Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien="Lý Hoàng Phi",
                    Buoi="M",
                    TietBatDau=4,
                    TietKeoDai=2,
                    Lop="10A2",
                    MonHoc="Lý",
                    NgayHoc=Methods.TryParse("14/03/2022")
                },
                new Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien="Nguyễn Kim Phượng",
                    Buoi="M",
                    TietBatDau=3,
                    TietKeoDai=1,
                    Lop="10A2",
                    MonHoc="Toán",
                    NgayHoc=Methods.TryParse("17/03/2022")
                },
                new Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien="Nguyễn Kim Liên",
                    Buoi="A",
                    TietBatDau=5,
                    TietKeoDai=1,
                    Lop="10A2",
                    MonHoc="Văn",
                    NgayHoc=Methods.TryParse("15/03/2022")
                },
                new Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien="Lý Hoàng Phi",
                    Buoi="M",
                    TietBatDau=4,
                    TietKeoDai=2,
                    Lop="10A2",
                    MonHoc="Lý",
                    NgayHoc=Methods.TryParse("17/03/2022")
                },
            };

            this.BeginInvoke(new System.Action(() =>
            {
                studMin.Action.Excel.ScheduleStudent scheduleStudent = new studMin.Action.Excel.ScheduleStudent();

                scheduleStudent.InsertInfo(info);

                foreach (Action.Excel.ScheduleAllTeacher.Item item in list)
                {
                    scheduleStudent.InsertItem(item);
                }

                scheduleStudent.ShowExcel();

                scheduleStudent.Save(exportPath);

                if (MessageBox.Show("Bạn có muốn xem bảng tính lúc in?", "In Bảng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    scheduleStudent.ShowPrintPreview();
                }

                scheduleStudent.Dispose();
            }));
        }

        private void TimetableImport_Button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Files| *.xlsc; *.xls; *.xlsm; *.xlsx", Multiselect = false })
            {
                try
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        DataTable dt = new DataTable();

                        dt.Columns.Add("Tiết học");
                        dt.Columns.Add("Thứ hai");
                        dt.Columns.Add("Thứ ba");
                        dt.Columns.Add("Thứ tư");
                        dt.Columns.Add("Thứ năm");
                        dt.Columns.Add("Thứ sáu");
                        dt.Columns.Add("Thứ bảy");

                        using (XLWorkbook workBook = new XLWorkbook(ofd.FileName))
                        {
                            int flag = 0;
                            var rows = workBook.Worksheet(1).RowsUsed();

                            foreach (var row in rows)
                            {
                                if (flag >= 4)
                                {
                                    dt.Rows.Add();
                                    int i = 0;

                                    foreach (IXLCell cell in row.Cells())
                                    {
                                        if (!cell.IsEmpty())
                                        {
                                            if (i >= 1)
                                            {
                                                dt.Rows[dt.Rows.Count - 1][i-1] = cell.Value.ToString();
                                            }
                                        }

                                        i++;
                                    }
                                }

                                if (flag == 8)
                                {
                                    dt.Rows.Add();
                                }

                                flag++;
                            }

                            Timetable_GridView.DataSource = dt.DefaultView;
                            Cursor.Current = Cursors.Default;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FilterTimeTableByClass(string className)
        {
            int columnOfEachClass = 0;
            switch (className)
            {
                case "10A5":
                    columnOfEachClass = 3;
                    break;
                case "10A4":
                    columnOfEachClass = 4;
                    break;
                case "10A3":
                    columnOfEachClass = 5;
                    break;
                case "10A2":
                    columnOfEachClass = 6;
                    break;
            }

            Cursor.Current = Cursors.WaitCursor;
            DataTable dt = new DataTable();

            dt.Columns.Add("Tiết học");
            dt.Columns.Add("Thứ hai");
            dt.Columns.Add("Thứ ba");
            dt.Columns.Add("Thứ tư");
            dt.Columns.Add("Thứ năm");
            dt.Columns.Add("Thứ sáu");
            dt.Columns.Add("Thứ bảy");

            using (XLWorkbook workBook = new XLWorkbook(Action.Excel.StoragePath.DataSample))
            {
                int flag = 0;
                int rowOfEachDay = 0;
                int columnIndex = 1;
                var rows = workBook.Worksheet(1).RowsUsed();

                foreach (var row in rows)
                {
                    if (flag > 3 && flag % 10 == 3)
                    {
                        rowOfEachDay = 0;
                        columnIndex++;
                    }

                    if (flag >= 3 && flag <= 12)
                    {
                        dt.Rows.Add();
                        int i = 0;

                        foreach (IXLCell cell in row.Cells())
                        {
                            if (i == 2)
                            {
                                dt.Rows[dt.Rows.Count - 1][0] = cell.Value.ToString();
                            }

                            if (i == columnOfEachClass)
                            {
                                dt.Rows[dt.Rows.Count - 1][1] = cell.Value.ToString();
                            }

                            i++;
                        }
                    }
                    else if (flag >= 13 && flag <= 63)
                    {
                        int t = 0;

                        foreach (IXLCell cell in row.Cells())
                        {
                            if (t == columnOfEachClass)
                            {
                                dt.Rows[rowOfEachDay][columnIndex] = cell.Value.ToString();
                            }


                            t++;
                        }
                    }

                    rowOfEachDay++;
                    flag++;
                }

                Timetable_GridView.DataSource = dt.DefaultView;
                Cursor.Current = Cursors.Default;
            }
        }

        private void Class_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_ComboBox.SelectedIndex == 0) return;

            string className = Class_ComboBox.SelectedItem.ToString();
            FilterTimeTableByClass(className);
        }
    }
}
