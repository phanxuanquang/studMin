﻿using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studMin.Database.LoginServices;

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
            
            // lấy dữ liệu thời khóa biểu từ database
            
            List<Action.Excel.ScheduleAllTeacher.Item> list = new List<Action.Excel.ScheduleAllTeacher.Item>();
           
            var classLesson = studMin.Database.DataProvider.Instance.Database.CLASSes.Where(item => item.CLASSNAME == "10A1").FirstOrDefault();
            var lesson = studMin.Database.DataProvider.Instance.Database.LESSONs.Where(item => item.IDCLASS == classLesson.ID).ToList();

            foreach (var item in lesson)
            {
                var teacher = studMin.Database.DataProvider.Instance.Database.TEACHERs.Where(itemTeacher => itemTeacher.ID == item.IDTEACHER).FirstOrDefault();
                
                var infoteacher = studMin.Database.DataProvider.Instance.Database.INFORs.Where(iteminfo => iteminfo.ID == teacher.IDINFOR).FirstOrDefault();

                var subject = studMin.Database.DataProvider.Instance.Database.SUBJECTs.Where(itemsubject => itemsubject.Id == item.IDSUBJECT).FirstOrDefault();

                Action.Excel.ScheduleAllTeacher.Item temp = new studMin.Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien = infoteacher.FIRSTNAME + " " + infoteacher.LASTNAME,
                    Buoi = "M",
                    TietBatDau = (int)(item.TIMESTART),
                    TietKeoDai = (int)(item.TIMEEND) - (int)(item.TIMESTART) + 1,
                    Lop = classLesson.CLASSNAME,
                    MonHoc = subject.DisplayName,
                    NgayHoc = (int)item.DAYOFW - 1,

                };
                list.Add(temp);
            }


            //List<Action.Excel.ScheduleAllTeacher.Item> list = new List<Action.Excel.ScheduleAllTeacher.Item>()
            //{
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Nguyễn Kim Phượng",
            //        Buoi="M",
            //        TietBatDau=1,
            //        TietKeoDai=2,
            //        Lop="10A2",
            //        MonHoc="Toán",
            //        NgayHoc=Methods.TryParse("14/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Nguyễn Kim Liên",
            //        Buoi="A",
            //        TietBatDau=2,
            //        TietKeoDai=2,
            //        Lop="10A2",
            //        MonHoc="Văn",
            //        NgayHoc=Methods.TryParse("15/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Lý Hoàng Phi",
            //        Buoi="M",
            //        TietBatDau=4,
            //        TietKeoDai=2,
            //        Lop="10A2",
            //        MonHoc="Lý",
            //        NgayHoc=Methods.TryParse("14/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Nguyễn Kim Phượng",
            //        Buoi="M",
            //        TietBatDau=3,
            //        TietKeoDai=1,
            //        Lop="10A2",
            //        MonHoc="Toán",
            //        NgayHoc=Methods.TryParse("17/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Nguyễn Kim Liên",
            //        Buoi="A",
            //        TietBatDau=5,
            //        TietKeoDai=1,
            //        Lop="10A2",
            //        MonHoc="Văn",
            //        NgayHoc=Methods.TryParse("15/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Lý Hoàng Phi",
            //        Buoi="M",
            //        TietBatDau=4,
            //        TietKeoDai=2,
            //        Lop="10A2",
            //        MonHoc="Lý",
            //        NgayHoc=Methods.TryParse("17/03/2022")
            //    },
            //};

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
                                                dt.Rows[dt.Rows.Count - 1][i - 1] = cell.Value.ToString();
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

        /*bool IsInTheSameMergedRange(IXLCell cell1, IXLCell cell2)
        {
            if (cell1.MergedRange() == null || cell2.MergedRange() == null) return false;

            if (cell1.MergedRange().ToString() == cell2.MergedRange().ToString())
            {
                return true;
            }

            return false;
        }

        private void Timetable_GridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;

            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;

            int columnOfEachClass = 0;
            switch (Class_ComboBox.SelectedItem.ToString())
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

            using (XLWorkbook workBook = new XLWorkbook(Action.Excel.StoragePath.DataSample))
            {
                int flag = 0;
                var rows = workBook.Worksheet(1).RowsUsed();

                foreach (var row in rows)
                {
                    if (flag >= 3)
                    {
                        int i = 0;

                        foreach (IXLCell cell in row.Cells())
                        {
                            if (i == columnOfEachClass)
                            {
                                if (IsInTheSameMergedRange(cell, cell.CellAbove()))
                                {
                                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                                }
                                else
                                {
                                    e.AdvancedBorderStyle.Top = Timetable_GridView.AdvancedCellBorderStyle.Top;
                                }
                            }

                            i++;
                        }
                    }
                    

                    flag++;
                }
            }
        }*/
    }
}
