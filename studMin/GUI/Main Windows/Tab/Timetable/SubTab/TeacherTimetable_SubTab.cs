using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel;

namespace studMin
{
    using Database.Models;
    public partial class TeacherTimetable_SubTab : UserControl
    {
        private List<Action.Excel.ScheduleAllTeacher.Item> data = null;
        private BackgroundWorker backgroundWorker = null;
        private GUI.WaitControl waitControl = null;
        Action.Excel.ScheduleAllTeacher.Info importInfo = null;

        BindingSource listTeacher = null;
        BindingSource listSemester = null;
        BindingSource listSchoolYear = null;
        BindingSource listDateApply = null;

        private class TEACHER4COMBOBOX
        {
            private Guid _id;
            private string _name;
            
            public Guid ID { get { return _id; } }
            public string GiaoVien { get { return _name; } }
            
            public TEACHER4COMBOBOX(Guid ID, string GiaoVien)
            {
                _id = ID;
                _name = GiaoVien;
            }
        }

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
                
                if((listTeacher.Current as TEACHER4COMBOBOX).GiaoVien != "Mọi giáo viên")
                {
                    backgroundWorker.DoWork += ExportExcelSingle_DoWork;
                }
                else backgroundWorker.DoWork += ExportExcelAll_DoWork;

                backgroundWorker.RunWorkerAsync(exportPath);
            }
        }

        private void ExportExcelSingle_DoWork(object sender, DoWorkEventArgs e)
        {
            if (listSchoolYear.Current == null || listSemester.Current == null || listDateApply.Current == null && listTeacher.Current == null) return;
            string schoolYear = (listSchoolYear.Current as SCHEDULE4COMBOBOX).NamHoc;
            string semester = Methods.ParseSemester(listSemester.Current as string).ToString();
            DateTime dateApply = DateTime.ParseExact((listDateApply.Current as string), "dd/MM/yyyy", null);
            TEACHER4COMBOBOX teacher = (listTeacher.Current as TEACHER4COMBOBOX);

            if (String.IsNullOrEmpty(schoolYear) || String.IsNullOrEmpty(semester) || dateApply == DateTime.MinValue)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }

            SCHEDULE findSchedule = studMin.Database.DataProvider.Instance.Database.SCHEDULEs.Where(
                schedule => schedule.SCHOOLYEAR == schoolYear
                && schedule.SEMESTER.NAME == semester
                && schedule.DATEAPPLY.Value.Equals(dateApply))
                .FirstOrDefault();

            if (findSchedule == null)
            {
                MessageBox.Show("Lỗi - Không tìm thấy TKB");
                return;
            }

            List<LESSON> lesson = studMin.Database.DataProvider.Instance.Database.LESSONs.Where(item => item.IDSCHEDULE == findSchedule.ID && item.IDTEACHER == teacher.ID).ToList();

            if (lesson == null)
            {
                MessageBox.Show("Lỗi - Không tìm thấy các môn giáo viên dạy");
                return;
            }

            Action.Excel.ScheduleTeacher.Info info = new Action.Excel.ScheduleTeacher.Info()
            {
                MaGiaoVien = teacher.ID.ToString(),
                GiaoVien = teacher.GiaoVien,
                NgayApDung = dateApply,
                HocKy = int.Parse(semester),
                NamHoc = schoolYear
            };

            List<Action.Excel.ScheduleAllTeacher.Item> list = new List<studMin.Action.Excel.ScheduleAllTeacher.Item>();

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

            studMin.Action.Excel.ScheduleTeacher scheduleTeacher = new studMin.Action.Excel.ScheduleTeacher();

            scheduleTeacher.InsertInfo(info);

            foreach (Action.Excel.ScheduleAllTeacher.Item item in list)
            {
                scheduleTeacher.InsertItem(item);
            }

            scheduleTeacher.ShowExcel();

            scheduleTeacher.Save((string)e.Argument);

            if (MessageBox.Show("Bạn có muốn xem bảng tính lúc in?", "In Bảng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                scheduleTeacher.ShowPrintPreview();
            }

            scheduleTeacher.Dispose();
        }

        private void ExportExcelAll_DoWork(object sender, DoWorkEventArgs e)
        {
            if (listSchoolYear.Current == null || listSemester.Current == null || listDateApply.Current == null) return;
            string schoolYear = (listSchoolYear.Current as SCHEDULE4COMBOBOX).NamHoc;
            string semester = Methods.ParseSemester(listSemester.Current as string).ToString();
            DateTime dateApply = DateTime.ParseExact((listDateApply.Current as string), "dd/MM/yyyy", null);

            if (String.IsNullOrEmpty(schoolYear) || String.IsNullOrEmpty(semester) || dateApply == DateTime.MinValue)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }

            SCHEDULE findSchedule = studMin.Database.DataProvider.Instance.Database.SCHEDULEs.Where(
                schedule => schedule.SCHOOLYEAR == schoolYear
                && schedule.SEMESTER.NAME == semester
                && schedule.DATEAPPLY.Value.Equals(dateApply))
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
                BieuMauSo = 1,
                HocKy = int.Parse(semester),
                NgayApDung = dateApply,
                NamHoc = schoolYear,
                Truong = "Trường THPT Di Linh"
            };

            // lấy dữ liệu thời khóa biểu từ database

            List<Action.Excel.ScheduleAllTeacher.Item> list = new List<Action.Excel.ScheduleAllTeacher.Item>();

            List<CLASS> classLesson = studMin.Database.DataProvider.Instance.Database.CLASSes.ToList();
            foreach (var classes in classLesson)
            {
                List<LESSON> lesson = studMin.Database.DataProvider.Instance.Database.LESSONs.Where(item => item.IDCLASS == classes.ID && item.IDSCHEDULE == findSchedule.ID).ToList();

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
            Class_ComboBox.DataSource = listTeacher;

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

            List<TEACHER4COMBOBOX> sourceBinding = new List<TEACHER4COMBOBOX>();
            for (int index = 0; index < data.Count; index++)
            {
                if (sourceBinding.FindIndex(teacher => teacher.ID == data[index].IDTeacher) == -1)
                {
                    sourceBinding.Add(new TEACHER4COMBOBOX(data[index].IDTeacher, data[index].GiaoVien));
                }
            }

            sourceBinding.Add(new TEACHER4COMBOBOX(Guid.Empty, "Mọi giáo viên"));
            int loadCurrentTeacherFirst = sourceBinding.FindIndex(teacher => teacher.ID == studMin.Database.LoginServices.LoginServices.Instance.CurrentTeacher.ID);
            if (loadCurrentTeacherFirst > 0)
            {
                TEACHER4COMBOBOX currentTeacher = sourceBinding[loadCurrentTeacherFirst];
                sourceBinding.RemoveAt(loadCurrentTeacherFirst);
                sourceBinding.Insert(0, currentTeacher);
            }

            listTeacher.DataSource = sourceBinding;
        }

        private void Class_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (data == null) return;

            Guid teacher = (listTeacher.Current as TEACHER4COMBOBOX).ID;

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

            Timetable_GridView.Invoke(new System.Action(() =>
            {
                Timetable_GridView.DataSource = dataSource;
            }));

            for (int index = 0; index < data.Count; index++)
            {
                if (data[index].IDTeacher == teacher)
                {
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

        private void TeacherTimetable_SubTab_Load(object sender, EventArgs e)
        {
            waitControl = new GUI.WaitControl(this.ParentForm);

            listTeacher = new BindingSource();
            listSemester = new BindingSource();
            listSchoolYear = new BindingSource();
            listDateApply = new BindingSource();

            listTeacher.DataSource = typeof(TEACHER4COMBOBOX);
            listSemester.DataSource = typeof(string);
            listSchoolYear.DataSource = typeof(SCHEDULE4COMBOBOX);
            listDateApply.DataSource = typeof(string);

            listSchoolYear.CurrentChanged += ListSchoolYear_CurrentChanged;
            listSemester.CurrentChanged += ListSemester_CurrentChanged;

            listSchoolYear.CurrentChanged += ListTeacherUpdate;
            listSemester.CurrentChanged += ListTeacherUpdate;
            listDateApply.CurrentChanged += ListTeacherUpdate;

            listTeacher.CurrentChanged += Class_ComboBox_SelectedIndexChanged;

            Class_ComboBox.DataSource = listTeacher;
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
        }

        private void ListTeacherUpdate(object sender, EventArgs e)
        {
            if (listSchoolYear.Current == null || listSemester.Current == null || listDateApply.Current == null) return;
            string schoolYear = (listSchoolYear.Current as SCHEDULE4COMBOBOX).NamHoc;
            string semester = Methods.ParseSemester(listSemester.Current as string).ToString();
            DateTime dateApply = DateTime.ParseExact((listDateApply.Current as string), "dd/MM/yyyy", null);

            if (String.IsNullOrEmpty(schoolYear) || String.IsNullOrEmpty(semester) || dateApply == DateTime.MinValue) return;

            SCHEDULE findSchedule = studMin.Database.DataProvider.Instance.Database.SCHEDULEs.Where(
                schedule => schedule.SCHOOLYEAR == schoolYear
                && schedule.SEMESTER.NAME == semester
                && schedule.DATEAPPLY.Value.Equals(dateApply))
                .FirstOrDefault();

            if (findSchedule == null) return;

            List<LESSON> lesson = studMin.Database.DataProvider.Instance.Database.LESSONs.Where(item => item.IDSCHEDULE == findSchedule.ID).ToList();

            data = new List<studMin.Action.Excel.ScheduleAllTeacher.Item>();

            for (int index = 0; index < lesson.Count; index++)
            {
                data.Add(new studMin.Action.Excel.ScheduleAllTeacher.Item()
                {
                    IDTeacher = lesson[index].IDTEACHER,
                    GiaoVien = lesson[index].TEACHER.INFOR.FIRSTNAME + " " + lesson[index].TEACHER.INFOR.LASTNAME,
                    Lop = lesson[index].CLASS.CLASSNAME,
                    MonHoc = lesson[index].SUBJECT.DisplayName,
                    TietBatDau = lesson[index].TIMESTART.Value,
                    TietKeoDai = lesson[index].TIMEEND.Value - lesson[index].TIMESTART.Value + 1,
                    NgayHoc = lesson[index].DAYOFW.Value - 1,
                    Buoi = lesson[index].TIMEOFDAY
                });
            }

            List<TEACHER4COMBOBOX> sourceBinding = new List<TEACHER4COMBOBOX>();
            for (int index = 0; index < data.Count; index++)
            {
                if (sourceBinding.FindIndex(teacher => teacher.ID == data[index].IDTeacher) == -1)
                {
                    sourceBinding.Add(new TEACHER4COMBOBOX(data[index].IDTeacher, data[index].GiaoVien));
                }
            }

            sourceBinding.Add(new TEACHER4COMBOBOX(Guid.Empty, "Mọi giáo viên"));
            int loadCurrentTeacherFirst = sourceBinding.FindIndex(teacher => teacher.ID == studMin.Database.LoginServices.LoginServices.Instance.CurrentTeacher.ID);
            if (loadCurrentTeacherFirst > 0)
            {
                TEACHER4COMBOBOX currentTeacher = sourceBinding[loadCurrentTeacherFirst];
                sourceBinding.RemoveAt(loadCurrentTeacherFirst);
                sourceBinding.Insert(0, currentTeacher);
            }

            AssignDataToComboBox(Class_ComboBox, listTeacher, sourceBinding, "GiaoVien", "GiaoVien");
        }

        private void LoadScheduleFromDatabase_RunrWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListSchoolYear_CurrentChanged(null, null);
            waitControl.Stop();
        }

        private void ListSemester_CurrentChanged(object sender, EventArgs e)
        {
            if (listSchoolYear.Current == null || listSemester.Current == null) return;
            List<SCHEDULE> schedule = (listSchoolYear.Current as SCHEDULE4COMBOBOX).TKB_Nam;
            string semester = Methods.ParseSemester(listSemester.Current as string).ToString();
            AssignDataToComboBox(DateApply_ComboBox, listDateApply, schedule.Where(sche => sche.SEMESTER.NAME == semester).Select(item => item.DATEAPPLY.Value.ToString("dd/MM/yyyy")).ToList(), "", "");
        }

        private void LoadScheduleFromDatabase_DoWork(object sender, DoWorkEventArgs e)
        {
            waitControl.Start();
            List<IGrouping<string, SCHEDULE>> schoolYear = studMin.Database.DataProvider.Instance.Database.SCHEDULEs.GroupBy(schedule => schedule.SCHOOLYEAR).ToList();
            AssignDataToComboBox(SchoolYear_ComboBox, listSchoolYear, schoolYear.Select(item => new SCHEDULE4COMBOBOX(item.Key, item.ToList())).ToList(), "NamHoc", "NamHoc");
        }

        private void ListSchoolYear_CurrentChanged(object sender, EventArgs e)
        {
            if (listSchoolYear.Current == null) return;
            List<SCHEDULE> schedule = (listSchoolYear.Current as SCHEDULE4COMBOBOX).TKB_Nam;
            AssignDataToComboBox(DateApply_ComboBox, listDateApply, schedule.Select(item => item.DATEAPPLY.Value.ToString("dd/MM/yyyy")).ToList(), "", "");
            AssignDataToComboBox(Semester_ComboBox, listSemester, schedule.Select(item => item.SEMESTER.NAME).Distinct().Select(semester => HocKy(int.Parse(semester))).ToList(), "", "");
        }

        private void AssignDataToComboBox(Guna.UI2.WinForms.Guna2ComboBox userControl, BindingSource binding, object data, string displayMember, string valueMember)
        {
            binding.DataSource = data;
            userControl.Invoke(new System.Action(() =>
            {
                userControl.DisplayMember = displayMember;
                userControl.ValueMember = valueMember;
            }));
        }

        private string HocKy(int msg)
        {
            return String.Format("Học kỳ: {0}", Methods.Semester(msg));
        }
    }
}
