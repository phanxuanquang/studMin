using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace studMin
{
    public partial class TeacherTimetable_SubTab : UserControl
    {
        public TeacherTimetable_SubTab()
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

            Action.Excel.ScheduleAllTeacher.Info info = new Action.Excel.ScheduleAllTeacher.Info()
            {
                //Dữ liệu mẫu
                BieuMauSo = 1,
                HocKy = 1,
                NgayApDung = DateTime.Now,
                NamHoc = "2022 - 2023",
                Truong = "Trường THPT Di Linh",
            };

            List<Action.Excel.ScheduleAllTeacher.Item> list = new List<Action.Excel.ScheduleAllTeacher.Item>()
            {
                //Dữ liệu mẫu
                new Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien="Nguyễn Kim Phượng",
                    Buoi="M",
                    TietBatDau=1,
                    TietKeoDai=2,
                    Lop="10A2",
                    MonHoc="Toán",
                    NgayHoc=Methods.TryParse("14/3/2022")
                },
                new Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien="Nguyễn Kim Liên",
                    Buoi="A",
                    TietBatDau=2,
                    TietKeoDai=2,
                    Lop="10A2",
                    MonHoc="Văn",
                    NgayHoc=Methods.TryParse("15/3/2022")
                },
                new Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien="Nguyễn Hoàng Lân",
                    Buoi="M",
                    TietBatDau=1,
                    TietKeoDai=2,
                    Lop="10A3",
                    MonHoc="Anh",
                    NgayHoc=Methods.TryParse("14/3/2022")
                },
                new Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien="Nguyễn Võ Thanh Minh",
                    Buoi="M",
                    TietBatDau=1,
                    TietKeoDai=1,
                    Lop="10A3",
                    MonHoc="Địa",
                    NgayHoc=Methods.TryParse("15/3/2022")
                },
                new Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien="Trần Phan Anh Đức",
                    Buoi="A",
                    TietBatDau=1,
                    TietKeoDai=2,
                    Lop="10A3",
                    MonHoc="Sinh",
                    NgayHoc=Methods.TryParse("16/3/2022")
                },
                new Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien="Lý Hoàng Phi",
                    Buoi="M",
                    TietBatDau=4,
                    TietKeoDai=2,
                    Lop="10A2",
                    MonHoc="Lý",
                    NgayHoc=Methods.TryParse("14/3/2022")
                },
                new Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien="Cao Liên Thi",
                    Buoi="A",
                    TietBatDau=1,
                    TietKeoDai=2,
                    Lop="10A3",
                    MonHoc="Toán",
                    NgayHoc=Methods.TryParse("15/3/2022")
                },
                new Action.Excel.ScheduleAllTeacher.Item()
                {
                    GiaoVien="Phạm Võ Anh Thi",
                    Buoi="A",
                    TietBatDau=5,
                    TietKeoDai=1,
                    Lop="10A3",
                    MonHoc="GDCN",
                    NgayHoc=Methods.TryParse("16/3/2022")
                }
            };

            this.BeginInvoke(new System.Action(() =>
            {
                studMin.Action.Excel.ScheduleAllTeacher scheduleAllTeacher = new studMin.Action.Excel.ScheduleAllTeacher();

                scheduleAllTeacher.InsertInfo(info);

                foreach (Action.Excel.ScheduleAllTeacher.Item item in list)
                {
                    scheduleAllTeacher.InsertItem(item);
                }

                scheduleAllTeacher.ShowExcel();

                if (MessageBox.Show("Bạn có muốn xem bảng tính lúc in?", "In Bảng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    scheduleAllTeacher.ShowPrintPreview();
                }

                scheduleAllTeacher.Close(exportPath);
            }));
        }
    }
}
