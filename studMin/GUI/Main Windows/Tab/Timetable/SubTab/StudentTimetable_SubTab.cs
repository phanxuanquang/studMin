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

            studMin.Action.Excel.ScheduleStudent scheduleStudent = new studMin.Action.Excel.ScheduleStudent();

            Action.Excel.ScheduleStudent.Info info = new Action.Excel.ScheduleStudent.Info()
            {
                GiaoVien = "Nguyễn Ngân Hà",
                HocKy = 1,
                NgayApDung = DateTime.Now,
                Lop = "10A2",
                NamHoc = "2022 - 2023"
            };
            scheduleStudent.InsertInfo(info);

            List<Action.Excel.ScheduleTeacher.Item> list = new List<Action.Excel.ScheduleTeacher.Item>()
            {
                new Action.Excel.ScheduleTeacher.Item()
                {
                    GiaoVien="Nguyễn Kim Phượng",
                    Buoi="M",
                    TietBatDau=1,
                    TietKeoDai=2,
                    Lop="10A2",
                    MonHoc="Toán",
                    NgayHoc=DateTime.Parse("14/3/2022")
                },
                new Action.Excel.ScheduleTeacher.Item()
                {
                    GiaoVien="Nguyễn Kim Liên",
                    Buoi="A",
                    TietBatDau=2,
                    TietKeoDai=2,
                    Lop="10A2",
                    MonHoc="Văn",
                    NgayHoc=DateTime.Parse("15/3/2022")
                },
                new Action.Excel.ScheduleTeacher.Item()
                {
                    GiaoVien="Lý Hoàng Phi",
                    Buoi="M",
                    TietBatDau=4,
                    TietKeoDai=2,
                    Lop="10A2",
                    MonHoc="Lý",
                    NgayHoc=DateTime.Parse("14/3/2022")
                },
                new Action.Excel.ScheduleTeacher.Item()
                {
                    GiaoVien="Nguyễn Kim Phượng",
                    Buoi="M",
                    TietBatDau=3,
                    TietKeoDai=1,
                    Lop="10A2",
                    MonHoc="Toán",
                    NgayHoc=DateTime.Parse("17/3/2022")
                },
                new Action.Excel.ScheduleTeacher.Item()
                {
                    GiaoVien="Nguyễn Kim Liên",
                    Buoi="A",
                    TietBatDau=5,
                    TietKeoDai=1,
                    Lop="10A2",
                    MonHoc="Văn",
                    NgayHoc=DateTime.Parse("15/3/2022")
                },
                new Action.Excel.ScheduleTeacher.Item()
                {
                    GiaoVien="Lý Hoàng Phi",
                    Buoi="M",
                    TietBatDau=4,
                    TietKeoDai=2,
                    Lop="10A2",
                    MonHoc="Lý",
                    NgayHoc=DateTime.Parse("17/3/2022")
                },
            };

            foreach (Action.Excel.ScheduleTeacher.Item item in list)
            {
                scheduleStudent.InsertItem(item);
            }

            scheduleStudent.Close(exportPath);
        }

        private void TimetableImport_Button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files| *.xlsc; *.xls; *.xlsm; *.xlsx", Multiselect = false })
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
    }
}
