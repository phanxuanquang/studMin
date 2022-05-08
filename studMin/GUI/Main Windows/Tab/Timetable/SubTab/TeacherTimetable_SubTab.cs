﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel;

namespace studMin
{
    public partial class TeacherTimetable_SubTab : UserControl
    {
        private List<Action.Excel.ScheduleAllTeacher.Item> data = null;
        private BackgroundWorker backgroundWorker = null;
        Action.Excel.ScheduleAllTeacher.Info importInfo = null;
        List<string> ListTeacher = null;

        public TeacherTimetable_SubTab()
        {
            InitializeComponent();
        }

        private void TimetableExport_Button_Click(object sender, EventArgs e)
        {
            if (backgroundWorker == null)
            {
                backgroundWorker = new BackgroundWorker();
            }
            else if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.Dispose();
                backgroundWorker = new BackgroundWorker();
            }
            else
            {
                MessageBox.Show("Đang có tiến trình đang chạy, vui lòng đợi trong giây lát!");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Excel | *.xlsx";

            string exportPath = string.Empty;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                exportPath = saveFileDialog.FileName;
                backgroundWorker.DoWork += ExportExcel_DoWork;
                backgroundWorker.RunWorkerAsync(exportPath);
            }
        }

        private void ExportExcel_DoWork(object sender, DoWorkEventArgs e)
        {
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

                    Action.Excel.ScheduleAllTeacher.Item temp = new studMin.Action.Excel.ScheduleAllTeacher.Item()
                    {
                        GiaoVien = item.TEACHER.INFOR.FIRSTNAME + " " + item.TEACHER.INFOR.LASTNAME,
                        Buoi = item.TIMEOFDAY,
                        TietBatDau = (int)(item.TIMESTART),
                        TietKeoDai = (int)(item.TIMEEND) - (int)(item.TIMESTART) + 1,
                        Lop = item.CLASS.CLASSNAME,
                        MonHoc = item.SUBJECT.DisplayName,
                        NgayHoc = (int)item.DAYOFW - 1,

                    };
                    list.Add(temp);

                }
            }

            studMin.Action.Excel.ScheduleAllTeacher scheduleAllTeacher = new studMin.Action.Excel.ScheduleAllTeacher();

            scheduleAllTeacher.InsertInfo(info);

            foreach (Action.Excel.ScheduleAllTeacher.Item item in list)
            {
                scheduleAllTeacher.InsertItem(item);
            }

            scheduleAllTeacher.ShowExcel();

            scheduleAllTeacher.Save((string)e.Argument);

            if (MessageBox.Show("Bạn có muốn xem bảng tính lúc in?", "In Bảng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                scheduleAllTeacher.ShowPrintPreview();
            }

            scheduleAllTeacher.Dispose();
        }

        private void TimetableImport_Button_Click(object sender, EventArgs e)
        {
            if (backgroundWorker == null)
            {
                backgroundWorker = new BackgroundWorker();
            }
            else if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.Dispose();
                backgroundWorker = new BackgroundWorker();
            }
            else
            {
                MessageBox.Show("Đang nhập danh sách, vui lòng đợi!");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Excel | *.xlsx";

            string importPath = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                importPath = openFileDialog.FileName;
            }
            else
            {
                return;
            }
            backgroundWorker.DoWork += ImportExcel_DoWork;
            backgroundWorker.RunWorkerCompleted += ImportExcel_RunrWorkerCompleted;
            backgroundWorker.RunWorkerAsync(importPath);
        }

        private void ImportExcel_RunrWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Class_ComboBox.DataSource = ListTeacher;

            if (MessageBox.Show("Bạn có muốn đưa dữ liệu lên cơ sở dữ liệu không?", "Đưa TKB lên CSDL", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (backgroundWorker == null)
                {
                    backgroundWorker = new BackgroundWorker();
                }
                else if (!backgroundWorker.IsBusy)
                {
                    backgroundWorker.Dispose();
                    backgroundWorker = new BackgroundWorker();
                }
                else
                {
                    MessageBox.Show("Đang nhập danh sách, vui lòng đợi!");
                    return;
                }

                backgroundWorker.DoWork += UploadScheduleToDatabase_DoWork;
                backgroundWorker.RunWorkerCompleted += UploadScheduleToDatabase_RunrWorkerCompleted;
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void UploadScheduleToDatabase_RunrWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Đã đưa dữ liệu TKB lên CSDL");
        }

        private void UploadScheduleToDatabase_DoWork(object sender, DoWorkEventArgs e)
        {
            studMin.Database.Models.SCHEDULE newSchedule = studMin.Database.ScheduleServices.Instance.CreateSchedule(
                importInfo.NgayApDung,
                importInfo.NamHoc.Split(new string[] { " - " }, StringSplitOptions.None)[0],
                importInfo.GetHocKy()
                );

            for (int index = 0; index < data.Count; index++)
            {
                studMin.Database.ScheduleServices.Instance.SaveLessonToDB(
                    newSchedule,
                    data[index].GiaoVien,
                    data[index].MonHoc,
                    data[index].Lop,
                    (byte)data[index].TietBatDau,
                    (byte)(data[index].TietKeoDai + data[index].TietBatDau - 1),
                    (byte)(data[index].NgayHoc + 1),
                    data[index].Buoi.Substring(0, 1)
                    );
            }
        }

        private void ImportExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            Action.Excel.ScheduleAllTeacher scheduleAllTeacher = new Action.Excel.ScheduleAllTeacher(true, (string)e.Argument);

            importInfo = (Action.Excel.ScheduleAllTeacher.Info)scheduleAllTeacher.SelectInfo();

            data = (List<Action.Excel.ScheduleAllTeacher.Item>)scheduleAllTeacher.SelectItem(importInfo.NgayApDung);

            scheduleAllTeacher.Dispose();

            if (ListTeacher == null)
            {
                ListTeacher = new List<string>();
            }
            else
            {
                ListTeacher.Clear();
            }
            for (int index = 0; index < data.Count; index++)
            {
                if (!ListTeacher.Contains(data[index].GiaoVien))
                {
                    ListTeacher.Add(data[index].GiaoVien);
                }
            }
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
                        dataSource.Rows[data[index].TietBatDau + tietkeodai + offset - 1][(int)data[index].NgayHoc] = data[index].Lop + "\n" + data[index].MonHoc;
                    }
                }
            }
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
