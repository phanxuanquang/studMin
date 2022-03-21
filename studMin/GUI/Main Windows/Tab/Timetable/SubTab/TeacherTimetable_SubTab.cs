using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
namespace studMin
{
    public partial class TeacherTimetable_SubTab : UserControl
    {
        private List<Action.Excel.ScheduleAllTeacher.Item> data = null;

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

            // lấy dữ liệu thời khóa biểu từ database

            List<Action.Excel.ScheduleAllTeacher.Item> list = new List<Action.Excel.ScheduleAllTeacher.Item>();

            var classLesson = studMin.Database.DataProvider.Instance.Database.CLASSes.ToList();
            foreach (var classes in classLesson)
            {
                var lesson = studMin.Database.DataProvider.Instance.Database.LESSONs.Where(item => item.IDCLASS == classes.ID).ToList();

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
                        Lop = classes.CLASSNAME,
                        MonHoc = subject.DisplayName,
                        NgayHoc = (int)item.DAYOFW - 1,

                    };
                    list.Add(temp);
                }
            }



            //{
            //    //Dữ liệu mẫu
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
            //        GiaoVien="Nguyễn Hoàng Lân",
            //        Buoi="M",
            //        TietBatDau=1,
            //        TietKeoDai=2,
            //        Lop="10A3",
            //        MonHoc="Anh",
            //        NgayHoc=Methods.TryParse("14/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Nguyễn Võ Thanh Minh",
            //        Buoi="M",
            //        TietBatDau=1,
            //        TietKeoDai=1,
            //        Lop="10A3",
            //        MonHoc="Địa",
            //        NgayHoc=Methods.TryParse("15/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Trần Phan Anh Đức",
            //        Buoi="A",
            //        TietBatDau=1,
            //        TietKeoDai=2,
            //        Lop="10A3",
            //        MonHoc="Sinh",
            //        NgayHoc=Methods.TryParse("16/03/2022")
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
            //        GiaoVien="Cao Liên Thi",
            //        Buoi="A",
            //        TietBatDau=1,
            //        TietKeoDai=2,
            //        Lop="10A3",
            //        MonHoc="Toán",
            //        NgayHoc=Methods.TryParse("15/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Phạm Võ Anh Thi",
            //        Buoi="A",
            //        TietBatDau=5,
            //        TietKeoDai=1,
            //        Lop="10A3",
            //        MonHoc="GDCN",
            //        NgayHoc=Methods.TryParse("16/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Nguyễn Kim Phượng",
            //        Buoi="M",
            //        TietBatDau=3,
            //        TietKeoDai=2,
            //        Lop="10A4",
            //        MonHoc="Toán",
            //        NgayHoc=Methods.TryParse("14/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Nguyễn Kim Liên",
            //        Buoi="A",
            //        TietBatDau=4,
            //        TietKeoDai=2,
            //        Lop="10A4",
            //        MonHoc="Văn",
            //        NgayHoc=Methods.TryParse("15/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Nguyễn Hoàng Lân",
            //        Buoi="M",
            //        TietBatDau=3,
            //        TietKeoDai=2,
            //        Lop="10A4",
            //        MonHoc="Anh",
            //        NgayHoc=Methods.TryParse("17/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Nguyễn Võ Thanh Minh",
            //        Buoi="M",
            //        TietBatDau=2,
            //        TietKeoDai=1,
            //        Lop="10A4",
            //        MonHoc="Địa",
            //        NgayHoc=Methods.TryParse("15/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Trần Phan Anh Đức",
            //        Buoi="A",
            //        TietBatDau=3,
            //        TietKeoDai=2,
            //        Lop="10A4",
            //        MonHoc="Sinh",
            //        NgayHoc=Methods.TryParse("16/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Lý Hoàng Phi",
            //        Buoi="M",
            //        TietBatDau=4,
            //        TietKeoDai=2,
            //        Lop="10A4",
            //        MonHoc="Lý",
            //        NgayHoc=Methods.TryParse("18/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Cao Liên Thi",
            //        Buoi="A",
            //        TietBatDau=4,
            //        TietKeoDai=2,
            //        Lop="10A5",
            //        MonHoc="Toán",
            //        NgayHoc=Methods.TryParse("17/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Phạm Võ Anh Thi",
            //        Buoi="A",
            //        TietBatDau=5,
            //        TietKeoDai=1,
            //        Lop="10A5",
            //        MonHoc="GDCN",
            //        NgayHoc=Methods.TryParse("18/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Nguyễn Kim Phượng",
            //        Buoi="M",
            //        TietBatDau=3,
            //        TietKeoDai=2,
            //        Lop="10A5",
            //        MonHoc="Toán",
            //        NgayHoc=Methods.TryParse("18/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Nguyễn Kim Liên",
            //        Buoi="A",
            //        TietBatDau=4,
            //        TietKeoDai=2,
            //        Lop="10A5",
            //        MonHoc="Văn",
            //        NgayHoc=Methods.TryParse("16/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Nguyễn Hoàng Lân",
            //        Buoi="M",
            //        TietBatDau=3,
            //        TietKeoDai=2,
            //        Lop="10A5",
            //        MonHoc="Anh",
            //        NgayHoc=Methods.TryParse("14/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Nguyễn Võ Thanh Minh",
            //        Buoi="M",
            //        TietBatDau=2,
            //        TietKeoDai=1,
            //        Lop="10A5",
            //        MonHoc="Địa",
            //        NgayHoc=Methods.TryParse("17/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Trần Phan Anh Đức",
            //        Buoi="A",
            //        TietBatDau=3,
            //        TietKeoDai=2,
            //        Lop="10A5",
            //        MonHoc="Sinh",
            //        NgayHoc=Methods.TryParse("19/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Lý Hoàng Phi",
            //        Buoi="M",
            //        TietBatDau=4,
            //        TietKeoDai=2,
            //        Lop="10A5",
            //        MonHoc="Lý",
            //        NgayHoc=Methods.TryParse("16/03/2022")
            //    },
            //    new Action.Excel.ScheduleAllTeacher.Item()
            //    {
            //        GiaoVien="Phạm Võ Anh Thi",
            //        Buoi="A",
            //        TietBatDau=5,
            //        TietKeoDai=1,
            //        Lop="10A5",
            //        MonHoc="GDCN",
            //        NgayHoc=Methods.TryParse("19/03/2022")
            //    }
            //};

            this.BeginInvoke(new System.Action(() =>
            {
                studMin.Action.Excel.ScheduleAllTeacher scheduleAllTeacher = new studMin.Action.Excel.ScheduleAllTeacher();

                scheduleAllTeacher.InsertInfo(info);

                foreach (Action.Excel.ScheduleAllTeacher.Item item in list)
                {
                    scheduleAllTeacher.InsertItem(item);
                }

                scheduleAllTeacher.ShowExcel();

                scheduleAllTeacher.Save(exportPath);

                if (MessageBox.Show("Bạn có muốn xem bảng tính lúc in?", "In Bảng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    scheduleAllTeacher.ShowPrintPreview();
                }

                scheduleAllTeacher.Dispose();
            }));
        }

        private void TimetableImport_Button_Click(object sender, EventArgs e)
        {
            this.BeginInvoke((System.Action)(() =>
            {
                Action.Excel.ScheduleAllTeacher scheduleAllTeacher = new Action.Excel.ScheduleAllTeacher(true);

                Action.Excel.ScheduleAllTeacher.Info info = scheduleAllTeacher.SelecteInfo();

                data = scheduleAllTeacher.SelectItem(info.NgayApDung);

                scheduleAllTeacher.Dispose();

                List<string> ListTeacher = new List<string>();
                for (int index = 0; index < data.Count; index++)
                {
                    if (!ListTeacher.Contains(data[index].GiaoVien))
                    {
                        ListTeacher.Add(data[index].GiaoVien);
                    }
                }

                Class_ComboBox.DataSource = ListTeacher;
            }));
        }

        private void Class_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (data == null) return;

            string teacher = Class_ComboBox.SelectedItem.ToString();

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
                if (data[index].GiaoVien == teacher)
                {
                    //Chỗ này chưa tìm hiểu cách merge trong DataGridView

                    int offset = data[index].Buoi == "Afternoon" ? 6 : 0;

                    for (int tietkeodai = 0; tietkeodai < data[index].TietKeoDai; tietkeodai++)
                    {
                        dataSource.Rows[data[index].TietBatDau + tietkeodai + offset - 1][(int)data[index].NgayHoc] = data[index].Lop;
                    }
                }
            }
        }
    }
}
