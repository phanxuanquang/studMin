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
using studMin.Database.Models;
using studMin.Database;

namespace studMin
{
    public partial class StudentTimetable_SubTab : UserControl
    {
        private List<Action.Excel.ScheduleAllTeacher.Item> data = null;
        private BackgroundWorker backgroundWorker = null;
        Action.Excel.ScheduleAllTeacher.Info importInfo = null;
        private GUI.LoadingWindow loadingWindow = null;

        BindingSource listClass = null;
        BindingSource listSemester = null;
        BindingSource listSchoolYear = null;
        BindingSource listDateApply = null;

        private class SCHEDULE4COMBOBOX
        {
            private List<SCHEDULE> _grouping;
            private string _key;

            public string NamHoc { get { return _key; } }
            public List<SCHEDULE> TKB_Nam { get { return _grouping; } }

            public SCHEDULE4COMBOBOX(string NamHoc, List<SCHEDULE> TKB_Nam)
            {
                _key = NamHoc;
                _grouping = TKB_Nam;
            }
        }

        private class CLASS4GRIDVIEW
        {
            private Guid _id;
            private string _name;

            public Guid ID { get { return _id; } }
            public string Lop { get { return _name; } }

            public CLASS4GRIDVIEW(Guid ID, string Lop)
            {
                _id = ID;
                _name = Lop;
            }
        }

        public StudentTimetable_SubTab()
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

                if ((listClass.Current as CLASS4GRIDVIEW).Lop != "Mọi lớp")
                {
                    backgroundWorker.DoWork += ExportExcelSingle_DoWork;
                }
                else backgroundWorker.DoWork += ExportExcelAll_DoWork;

                backgroundWorker.RunWorkerAsync(exportPath);
            }
        }

        private void ExportExcelAll_DoWork(object sender, DoWorkEventArgs e)
        {
            if (listSchoolYear.Current == null || listSemester.Current == null || listDateApply.Current == null || listClass.Current == null) return;
            string schoolYear = (listSchoolYear.Current as SCHEDULE4COMBOBOX).NamHoc;
            string semester = Methods.ParseSemester(listSemester.Current as string).ToString();
            (DateTime, string) dateApply_scheduleName = Methods.DateApplyParse(listDateApply.Current as string);

            if (String.IsNullOrEmpty(schoolYear) || String.IsNullOrEmpty(semester) || dateApply_scheduleName.Item1 == DateTime.MinValue || String.IsNullOrEmpty(dateApply_scheduleName.Item2))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }

            SCHEDULE findSchedule = studMin.Database.DataProvider.Instance.Database.SCHEDULEs.Where(
                schedule => schedule.SCHOOLYEAR == schoolYear
                && schedule.SEMESTER.NAME == semester
                && schedule.DATEAPPLY.Value.Equals(dateApply_scheduleName.Item1)
                && schedule.SCHEDULENAME == dateApply_scheduleName.Item2)
                .FirstOrDefault();

            if (findSchedule == null)
            {
                MessageBox.Show("Lỗi - Không tìm thấy TKB");
                return;
            }

            Action.Excel.ScheduleAllTeacher.Info info = new Action.Excel.ScheduleAllTeacher.Info()
            {
                //Dữ liệu mẫu
                //tạm thời để số 1 do database chưa chính xác
                BieuMauSo = int.Parse(dateApply_scheduleName.Item2),
                HocKy = int.Parse(semester),
                NgayApDung = dateApply_scheduleName.Item1,
                NamHoc = schoolYear,
                Truong = "Trường THPT Di Linh"
            };

            // lấy dữ liệu thời khóa biểu từ database

            List<Action.Excel.ScheduleAllTeacher.Item> list = new List<Action.Excel.ScheduleAllTeacher.Item>();

            List<CLASS4GRIDVIEW> classesOfTeacher = listClass.DataSource as List<CLASS4GRIDVIEW>;
            for (int indexClass = 0; indexClass < classesOfTeacher.Count; indexClass++)
            {
                Guid idClass = classesOfTeacher[indexClass].ID;
                if (idClass == Guid.Empty) continue;

                List<LESSON> lesson = studMin.Database.DataProvider.Instance.Database.LESSONs.Where(item => item.IDCLASS == idClass && item.IDSCHEDULE == findSchedule.ID).ToList();

                for (int indexLesson = 0; indexLesson < lesson.Count; indexLesson++)
                {
                    Action.Excel.ScheduleAllTeacher.Item temp = new studMin.Action.Excel.ScheduleAllTeacher.Item()
                    {
                        GiaoVien = lesson[indexLesson].TEACHER.INFOR.FIRSTNAME + " " + lesson[indexLesson].TEACHER.INFOR.LASTNAME,
                        Buoi = lesson[indexLesson].TIMEOFDAY,
                        TietBatDau = (int)(lesson[indexLesson].TIMESTART),
                        TietKeoDai = (int)(lesson[indexLesson].TIMEEND) - (int)(lesson[indexLesson].TIMESTART) + 1,
                        Lop = lesson[indexLesson].CLASS.CLASSNAME,
                        MonHoc = lesson[indexLesson].SUBJECT.DisplayName,
                        NgayHoc = (int)lesson[indexLesson].DAYOFW - 1,

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

        private void ExportExcelSingle_DoWork(object sender, DoWorkEventArgs e)
        {
            if (listSchoolYear.Current == null || listSemester.Current == null || listDateApply.Current == null || listClass.Current == null) return;

            string schoolYear = (listSchoolYear.Current as SCHEDULE4COMBOBOX).NamHoc;
            string semester = Methods.ParseSemester(listSemester.Current as string).ToString();
            (DateTime, string) dateApply_scheduleName = Methods.DateApplyParse(listDateApply.Current as string);
            CLASS4GRIDVIEW @class = (listClass.Current as CLASS4GRIDVIEW);

            if (String.IsNullOrEmpty(schoolYear) || String.IsNullOrEmpty(semester) || dateApply_scheduleName.Item1 == DateTime.MinValue || String.IsNullOrEmpty(dateApply_scheduleName.Item2))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }

            SCHEDULE findSchedule = studMin.Database.DataProvider.Instance.Database.SCHEDULEs.Where(
                schedule => schedule.SCHOOLYEAR == schoolYear
                && schedule.SEMESTER.NAME == semester
                && schedule.DATEAPPLY.Value.Equals(dateApply_scheduleName.Item1)
                && schedule.SCHEDULENAME == dateApply_scheduleName.Item2)
                .FirstOrDefault();

            if (findSchedule == null)
            {
                MessageBox.Show("Lỗi - Không tìm thấy TKB");
                return;
            }

            TEACHER teacher = studMin.Database.LoginServices.LoginServices.Instance.CurrentTeacher;
            List<LESSON> lesson = studMin.Database.DataProvider.Instance.Database.LESSONs.Where(item => item.IDSCHEDULE == findSchedule.ID && item.IDCLASS == @class.ID).ToList();

            if (lesson == null)
            {
                MessageBox.Show("Lỗi - Không tìm thấy các môn giáo viên dạy");
                return;
            }

            Action.Excel.ScheduleStudent.Info info = new Action.Excel.ScheduleStudent.Info()
            {
                GiaoVien = teacher.INFOR.FIRSTNAME + " " + teacher.INFOR.LASTNAME,
                HocKy = Methods.ParseSemester(findSchedule.SEMESTER.NAME),
                NgayApDung = findSchedule.DATEAPPLY.Value,
                Lop = @class.Lop,
                NamHoc = findSchedule.SCHOOLYEAR + " - " + (int.Parse(findSchedule.SCHOOLYEAR) + 1).ToString()
            };

            // lấy dữ liệu thời khóa biểu từ database

            List<Action.Excel.ScheduleAllTeacher.Item> list = new List<Action.Excel.ScheduleAllTeacher.Item>();

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

            studMin.Action.Excel.ScheduleStudent scheduleStudent = new studMin.Action.Excel.ScheduleStudent();

            scheduleStudent.InsertInfo(info);

            foreach (Action.Excel.ScheduleAllTeacher.Item item in list)
            {
                scheduleStudent.InsertItem(item);
            }

            scheduleStudent.ShowExcel();

            scheduleStudent.Save((string)e.Argument);

            if (MessageBox.Show("Bạn có muốn xem bảng tính lúc in?", "In Bảng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                scheduleStudent.ShowPrintPreview();
            }

            scheduleStudent.Dispose();
        }

        /*private void TimetableImport_Button_Click(object sender, EventArgs e)
        {
            if (Semester_ComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (SchoolYear_ComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
        }*/

        private void ImportExcel_RunrWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đưa dữ liệu lên cơ sở dữ liệu không?", "Đưa thời khóa biểu lên cơ sở dữ liệu", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            MessageBox.Show("Đưa thời khóa biểu lên cơ sở dữ liệu");
        }

        private void UploadScheduleToDatabase_DoWork(object sender, DoWorkEventArgs e)
        {
            studMin.Database.Models.SCHEDULE newSchedule = studMin.Database.ScheduleServices.Instance.CreateSchedule(
                importInfo.NgayApDung,
                importInfo.NamHoc.Split(new string[] { " - " }, StringSplitOptions.None)[0],
                importInfo.HocKy,
                importInfo.BieuMauSo
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
                    data[index].Buoi.Substring(0, 1),
                    importInfo.NamHoc.Split(new string[] { " - " }, StringSplitOptions.None)[0]
                    );
            }
        }

        private void ImportExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            Action.Excel.ScheduleAllTeacher scheduleAllTeacher = new Action.Excel.ScheduleAllTeacher(true, (string)e.Argument);

            importInfo = (Action.Excel.ScheduleAllTeacher.Info)scheduleAllTeacher.SelectInfo();

            data = (List<Action.Excel.ScheduleAllTeacher.Item>)scheduleAllTeacher.SelectItem(importInfo.NgayApDung);

            scheduleAllTeacher.Dispose();
        }

        private void FilterTimeTableByClass(Guid idClass)
        {
            if (data == null) return;

            if (data != null && data.Count > 0)
            {
                this.BeginInvoke(new System.Action(() =>
                {
                    (DateTime, string) get = Methods.DateApplyParse(listDateApply.Current as string);
                    string schoolYear = (listSchoolYear.Current as SCHEDULE4COMBOBOX).NamHoc;
                    int semester = Methods.ParseSemester(listSemester.Current as string);
                    string @class = (listClass.Current as CLASS4GRIDVIEW).Lop;
                    ApplyDate_Label.Text = TitleSchedule(get.Item1, get.Item2, @class, schoolYear, semester);
                }));
            }

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

            Timetable_GridView.Invoke(new System.Action(() => { Timetable_GridView.DataSource = dataSource; }));

            for (int index = 0; index < data.Count; index++)
            {
                if (data[index].IDClass == idClass)
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
            if (listClass.Current == null) return;
            Guid idClass = (listClass.Current as CLASS4GRIDVIEW).ID;

            if (listClass.Count > 1 && idClass == Guid.Empty && MessageBox.Show("Xuất Excel để xem thời khóa biểu của mọi lớp!", "Có muốn xem thời khóa biểu mọi lớp không?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TimetableExport_Button_Click(null, null);
                return;
            }

            /*if (@class == null)
            {
                string formatedYear = schoolYear.ToString() + " - " + (int.Parse(schoolYear) + 1);
                MessageBox.Show("Hiện tại lớp mà bạn chọn trong năm học " + formatedYear + " chưa có dữ liệu, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/
            FilterTimeTableByClass(idClass);
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

        private void StudentTimetable_SubTab_Load(object sender, EventArgs e)
        {
            loadingWindow = new GUI.LoadingWindow(this.ParentForm, "ĐANG TẢI THỜI KHÓA BIỂU HỌC SINH");

            listClass = new BindingSource();
            listSemester = new BindingSource();
            listSchoolYear = new BindingSource();
            listDateApply = new BindingSource();

            listClass.DataSource = typeof(CLASS4GRIDVIEW);
            listSemester.DataSource = typeof(string);
            listSchoolYear.DataSource = typeof(SCHEDULE4COMBOBOX);
            listDateApply.DataSource = typeof(string);

            listSchoolYear.CurrentChanged += ListSchoolYear_CurrentChanged;
            listSemester.CurrentChanged += ListSemester_CurrentChanged;

            listSchoolYear.CurrentChanged += ListClassChanged;
            listSemester.CurrentChanged += ListClassChanged;
            listDateApply.CurrentChanged += ListClassChanged;

            listClass.CurrentChanged += Class_ComboBox_SelectedIndexChanged;

            Class_ComboBox.DataSource = listClass;
            Semester_ComboBox.DataSource = listSemester;
            SchoolYear_ComboBox.DataSource = listSchoolYear;
            DateApply_ComboBox.DataSource = listDateApply;

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

            backgroundWorker.DoWork += LoadScheduleFromDatabase_DoWork;
            backgroundWorker.RunWorkerCompleted += LoadScheduleFromDatabase_RunrWorkerCompleted;
            backgroundWorker.RunWorkerAsync();
            loadingWindow.ShowDialog();
        }

        private void ListClassChanged(object sender, EventArgs e)
        {
            if (listSchoolYear.Current == null || listSemester.Current == null || listDateApply.Current == null) return;
            string schoolYear = (listSchoolYear.Current as SCHEDULE4COMBOBOX).NamHoc;
            string semester = Methods.ParseSemester(listSemester.Current as string).ToString();
            (DateTime, string) dateApply_scheduleName = Methods.DateApplyParse(listDateApply.Current as string);

            if (String.IsNullOrEmpty(schoolYear) || String.IsNullOrEmpty(semester) || dateApply_scheduleName.Item1 == DateTime.MinValue || String.IsNullOrEmpty(dateApply_scheduleName.Item2)) return;

            SCHEDULE findSchedule = studMin.Database.DataProvider.Instance.Database.SCHEDULEs.Where(
                schedule => schedule.SCHOOLYEAR == schoolYear
                && schedule.SEMESTER.NAME == semester
                && schedule.DATEAPPLY.Value.Equals(dateApply_scheduleName.Item1)
                && schedule.SCHEDULENAME == dateApply_scheduleName.Item2)
                .FirstOrDefault();

            if (findSchedule == null) return;

            Guid idTeacher = studMin.Database.LoginServices.LoginServices.Instance.CurrentTeacher.ID;
            //dựa vào teach load ra các lớp
            List<CLASS> classesOfTeacher = studMin.Database.DataProvider.Instance.Database.LESSONs.Where(item => item.IDSCHEDULE == findSchedule.ID && (item.IDTEACHER == idTeacher || item.CLASS.IDTEACHER == idTeacher)).Select(item => item.CLASS).Distinct().ToList();

            List<CLASS4GRIDVIEW> sourceBinding = classesOfTeacher.Select(item => new CLASS4GRIDVIEW(item.ID, item.CLASSNAME)).ToList();
            sourceBinding.Add(new CLASS4GRIDVIEW(Guid.Empty, "Mọi lớp"));

            data = new List<studMin.Action.Excel.ScheduleAllTeacher.Item>();

            for (int indexClass = 0; indexClass < classesOfTeacher.Count; indexClass++)
            {
                Guid idClass = classesOfTeacher[indexClass].ID;
                List<LESSON> lesson = studMin.Database.DataProvider.Instance.Database.LESSONs.Where(item => item.IDSCHEDULE == findSchedule.ID && item.IDCLASS == idClass).ToList();

                for (int indexLesson = 0; indexLesson < lesson.Count; indexLesson++)
                {
                    data.Add(new studMin.Action.Excel.ScheduleAllTeacher.Item()
                    {
                        IDTeacher = lesson[indexLesson].IDTEACHER,
                        IDClass = classesOfTeacher[indexClass].ID,
                        GiaoVien = lesson[indexLesson].TEACHER.INFOR.FIRSTNAME + " " + lesson[indexLesson].TEACHER.INFOR.LASTNAME,
                        Lop = lesson[indexLesson].CLASS.CLASSNAME,
                        MonHoc = lesson[indexLesson].SUBJECT.DisplayName,
                        TietBatDau = lesson[indexLesson].TIMESTART.Value,
                        TietKeoDai = lesson[indexLesson].TIMEEND.Value - lesson[indexLesson].TIMESTART.Value + 1,
                        NgayHoc = lesson[indexLesson].DAYOFW.Value - 1,
                        Buoi = lesson[indexLesson].TIMEOFDAY
                    });
                }
            }

            AssignDataToComboBox(Class_ComboBox, listClass, sourceBinding, "Lop", "Lop");
        }

        private void ListSemester_CurrentChanged(object sender, EventArgs e)
        {
            if (listSchoolYear.Current == null || listSemester.Current == null) return;
            List<SCHEDULE> schedule = (listSchoolYear.Current as SCHEDULE4COMBOBOX).TKB_Nam;
            string semester = Methods.ParseSemester(listSemester.Current as string).ToString();
            AssignDataToComboBox(DateApply_ComboBox, listDateApply, schedule.Where(sche => sche.SEMESTER.NAME == semester).Select(item => Methods.DateApply(item.DATEAPPLY.Value, item.SCHEDULENAME)).ToList(), "", "");
        }

        private void ListSchoolYear_CurrentChanged(object sender, EventArgs e)
        {
            if (listSchoolYear.Current == null) return;
            List<SCHEDULE> schedule = (listSchoolYear.Current as SCHEDULE4COMBOBOX).TKB_Nam;
            AssignDataToComboBox(DateApply_ComboBox, listDateApply, schedule.Select(item => Methods.DateApply(item.DATEAPPLY.Value, item.SCHEDULENAME)).ToList(), "", "");
            AssignDataToComboBox(Semester_ComboBox, listSemester, schedule.Select(item => item.SEMESTER.NAME).Distinct().Select(semester => Methods.HocKy(int.Parse(semester))).ToList(), "", "");
        }

        private void LoadScheduleFromDatabase_RunrWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //ListSchoolYear_CurrentChanged(null, null);
            loadingWindow.Close();
        }

        private void LoadScheduleFromDatabase_DoWork(object sender, DoWorkEventArgs e)
        {
            List<IGrouping<string, SCHEDULE>> schoolYear = studMin.Database.DataProvider.Instance.Database.SCHEDULEs.GroupBy(schedule => schedule.SCHOOLYEAR).ToList();
            AssignDataToComboBox(SchoolYear_ComboBox, listSchoolYear, schoolYear.Select(item => new SCHEDULE4COMBOBOX(item.Key, item.ToList())).ToList(), "NamHoc", "NamHoc");
        }

        private void AssignDataToComboBox(Guna.UI2.WinForms.Guna2ComboBox userControl, BindingSource binding, object data, string displayMember, string valueMember)
        {
            if (userControl.InvokeRequired)
            {
                userControl.Invoke(new System.Action(() =>
                {
                    binding.DataSource = data;
                    userControl.DisplayMember = displayMember;
                    userControl.ValueMember = valueMember;
                }));
            }
            else
            {
                binding.DataSource = data;
                userControl.DisplayMember = displayMember;
                userControl.ValueMember = valueMember;
            }
        }

        private string TitleSchedule(DateTime dateApply, string scheduleName, string @class, string schoolYear, int semester)
        {
            return String.Format("THỜI KHÓA BIỂU LỚP {0} - SỐ {1}, HỌC KỲ {2}, NĂM HỌC {3}\nNGÀY ÁP DỤNG {4}", @class, scheduleName, Methods.Semester(semester), schoolYear, dateApply.ToString("dd/MM/yyyy")).ToUpper();
        }
    }
}
