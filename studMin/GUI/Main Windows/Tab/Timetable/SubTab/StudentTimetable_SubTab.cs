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
    }
}
