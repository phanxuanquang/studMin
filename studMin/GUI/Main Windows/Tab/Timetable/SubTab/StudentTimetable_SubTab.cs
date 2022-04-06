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
using studMin.Database.LoginServices;

namespace studMin
{
    public partial class StudentTimetable_SubTab : UserControl
    {
        private List<Action.Excel.ScheduleAllTeacher.Item> data = null;
        bool isImported = false;
        bool isLoaded = false;

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
                Action.Excel.ScheduleAllTeacher.Item temp = new studMin.Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien = item.TEACHER.INFOR.FIRSTNAME + " " + item.TEACHER.INFOR.LASTNAME,
                    Buoi = "M",
                    TietBatDau = (int)(item.TIMESTART),
                    TietKeoDai = (int)(item.TIMEEND) - (int)(item.TIMESTART) + 1,
                    Lop = item.CLASS.CLASSNAME,
                    MonHoc = item.SUBJECT.DisplayName,
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
            if (isImported) return;

            this.BeginInvoke((System.Action)(() =>
            {
                List<string> ListClass = new List<string>();
                for (int index = 0; index < data.Count; index++)
                {
                    if (!ListClass.Contains(data[index].Lop))
                    {
                        ListClass.Add(data[index].Lop);
                    }
                }

                Class_ComboBox.DataSource = ListClass;
                isImported = true;
            }));
        }

        private void FilterTimeTableByClass(string className)
        {
            

            if (data == null) return;

            DataTable dataSource = new DataTable();

            dataSource.Columns.Add("TIẾT");
            dataSource.Columns.Add("THỨ HAI");
            dataSource.Columns.Add("THỨ BA");
            dataSource.Columns.Add("THỨ TƯ");
            dataSource.Columns.Add("THỨ NĂM");
            dataSource.Columns.Add("THỨ SÁU");
            dataSource.Columns.Add("THỨ BẢY");

            for (int index = 0; index < 11; index++)
            {
                if (index < 5)
                {
                    dataSource.Rows.Add(index + 1);
                }
                else if (index > 5)
                {
                    dataSource.Rows.Add(index - 5);
                }
                else dataSource.Rows.Add();
            }

            Timetable_GridView.DataSource = dataSource;

            for (int index = 0; index < data.Count; index++)
            {
                if (data[index].Lop == className)
                {
                    int offset = data[index].Buoi == "Afternoon" ? 6 : 0;

                    for (int tietkeodai = 0; tietkeodai < data[index].TietKeoDai; tietkeodai++)
                    {
                        dataSource.Rows[data[index].TietBatDau + tietkeodai + offset - 1][(int)data[index].NgayHoc] = data[index].MonHoc + "\n" + data[index].GiaoVien;
                    }
                }
            }
        }

        private void Class_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if (Class_ComboBox.SelectedIndex == 0) return;

            string className = Class_ComboBox.SelectedItem.ToString();
            FilterTimeTableByClass(className);
        }

        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = Timetable_GridView[column, row];
            DataGridViewCell cell2 = Timetable_GridView[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void Timetable_GridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            }
        }

        private void StudentTimetable_SubTab_Load(object sender, EventArgs e)
        {
            if (isLoaded) return;

            this.BeginInvoke((System.Action)(() =>
            {
                Action.Excel.ScheduleAllTeacher scheduleAllTeacher = new Action.Excel.ScheduleAllTeacher(true);

                Action.Excel.ScheduleAllTeacher.Info info = scheduleAllTeacher.SelecteInfo();

                data = scheduleAllTeacher.SelectItem(info.NgayApDung);

                scheduleAllTeacher.Dispose();
                isLoaded = true;
            }));
        }

        private void Timetable_GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }
    }
}
