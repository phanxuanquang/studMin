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
    using Database.Models;
    public partial class StatisticTab_Headteacher : UserControl
    {
        private BackgroundWorker backgroundWorker = null;
        private List<GRIDVIEW4REPORT> data = null;

        private BindingSource listSemester = null;
        private BindingSource listSchoolYear = null;
        private BindingSource listSubject = null;

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

        private class GRIDVIEW4REPORT
        {
            private Guid _idClass;
            private Guid _idSemester;
            private Guid _idSubject;
            private int no;
            private string _class;
            private int _quantity;
            private int _quantityPassed;

            public Guid IdClass { get { return _idClass; } }
            public Guid IdSemester { get { return _idSemester; } }
            public Guid IdSubject { get { return _idSubject; } }

            public int ThuTu
            {
                get { return no; }
                set { no = value; }
            }
            public string Lop
            {
                get { return _class; }
                set { _class = value; }
            }
            public int SiSo
            {
                get { return _quantity; }
                set { _quantity = value; }
            }
            public int SoLuongDat
            {
                get { return _quantityPassed; }
                set { _quantityPassed = value; }
            }
            public string TiLeDat { get { return String.Format("{0}%", Math.Round(SoLuongDat * 100.0 / SiSo, 2)); } }

            public GRIDVIEW4REPORT(Guid IdClass, Guid IdSemester, Guid IdSubject)
            {
                _idClass = IdClass;
                _idSemester = IdSemester;
                _idSubject = IdSubject;
            }
        }

        public StatisticTab_Headteacher()
        {
            InitializeComponent();
        }

        private void DataGridViewExport_Button_Click(object sender, EventArgs e)
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
            Action.Excel.ReportSubject.Info info = new studMin.Action.Excel.ReportSubject.Info() { HocKy = Methods.ParseSemester(listSemester.Current as string), MonHoc = listSubject.Current as string, NamHoc = (listSchoolYear.Current as SCHEDULE4COMBOBOX).NamHoc };

            Action.Excel.ReportSubject reportSubject = new studMin.Action.Excel.ReportSubject();

            reportSubject.InsertInfo(info);

            List<Action.Excel.ReportCommon.Item> items = data.Select(item => new Action.Excel.ReportCommon.Item() { Lop = item.Lop, SiSo = item.SiSo, SoLuongDat = item.SoLuongDat }).ToList();
            for (int index = 0; index < items.Count; index++)
            {
                reportSubject.InsertItem(items[index]);
            }

            reportSubject.ShowExcel();

            reportSubject.Save((string)e.Argument);

            if (MessageBox.Show("Bạn có muốn xem bảng tính lúc in?", "In Bảng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                reportSubject.ShowPrintPreview();
            }

            reportSubject.Dispose();
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

        private void StatisticTab_Headteacher_Load(object sender, EventArgs e)
        {
            listSemester = new BindingSource();
            listSchoolYear = new BindingSource();
            listSubject = new BindingSource();

            Subject_ComboBox.DataSource = listSubject;
            Semester_ComboBox.DataSource = listSemester;
            SchoolYear_ComboBox.DataSource = listSchoolYear;

            listSemester.DataSource = typeof(string);
            listSchoolYear.DataSource = typeof(SCHEDULE4COMBOBOX);
            listSubject.DataSource = typeof(string);

            listSchoolYear.CurrentChanged += ListSchoolYear_CurrentChanged;

            listSemester.CurrentChanged += UpdateReportSubject_CurrentChanged;
            listSubject.CurrentChanged += UpdateReportSubject_CurrentChanged;
            listSchoolYear.CurrentChanged += UpdateReportSubject_CurrentChanged;

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

            backgroundWorker.DoWork += LoadSubjectFromDatabase_DoWork;
            backgroundWorker.RunWorkerCompleted += LoadSubjectFromDatabase_RunWorkerCompleted;
            backgroundWorker.RunWorkerAsync();
        }

        private void UpdateReportSubject_CurrentChanged(object sender, EventArgs e)
        {
            string schoolYear = (listSchoolYear.Current as SCHEDULE4COMBOBOX).NamHoc;
            string _semester = Methods.ParseSemester(listSemester.Current as string).ToString();
            string _subject = (listSubject.Current as string);

            if (String.IsNullOrEmpty(schoolYear) || String.IsNullOrEmpty(_semester) || String.IsNullOrEmpty(_subject)) return;

            List<CLASS> classes = studMin.Database.DataProvider.Instance.Database.CLASSes.Where(item => item.SCHOOLYEAR == schoolYear).ToList();
            SUBJECT subject = studMin.Database.DataProvider.Instance.Database.SUBJECTs.FirstOrDefault(item => item.DisplayName == _subject);
            Guid idSemester = studMin.Database.DataProvider.Instance.Database.SEMESTERs.FirstOrDefault(item => item.NAME == _semester).ID;

            if (data == null) data = new List<GRIDVIEW4REPORT>();
            else data.Clear();

            for (int indexClass = 0; indexClass < classes.Count; indexClass++)
            {
                Guid idClass = classes[indexClass].ID;
                List<SCORE> scores = studMin.Database.DataProvider.Instance.Database.SCOREs.Where(item => item.SEMESTER.ID == idSemester && item.SCHOOLYEAR == schoolYear && item.STUDENT.IDCLASS == idClass).ToList();
                List<STUDENT> students = studMin.Database.DataProvider.Instance.Database.STUDENTs.Where(student => student.IDCLASS == idClass && student.CLASS.SCHOOLYEAR == schoolYear).ToList();

                if (scores.Count == 0 || students.Count == 0) continue;

                List<double> avgScoreStudent = new List<double>();

                for (int indexStudent = 0; indexStudent < students.Count; indexStudent++)
                {
                    int coefficientOralMark = scores.FirstOrDefault(score => score.ROLESCORE.ROLE == "M").ROLESCORE.COEFFICIENT.Value;
                    int coefficientRegularMark = scores.FirstOrDefault(score => score.ROLESCORE.ROLE == "15M").ROLESCORE.COEFFICIENT.Value;
                    int coefficientMidTermMark = scores.FirstOrDefault(score => score.ROLESCORE.ROLE == "45M").ROLESCORE.COEFFICIENT.Value;
                    int coefficientFinalMark = scores.FirstOrDefault(score => score.ROLESCORE.ROLE == "FINAL").ROLESCORE.COEFFICIENT.Value;

                    List<double> oralMark = scores.Where(item => item.IDSUBJECT == subject.Id && item.IDSTUDENT == students[indexStudent].ID && item.ROLESCORE.ROLE == "M").Select(score => score.SCORE1.Value * score.ROLESCORE.COEFFICIENT.Value).ToList();
                    List<double> regularMark = scores.Where(item => item.IDSUBJECT == subject.Id && item.IDSTUDENT == students[indexStudent].ID && item.ROLESCORE.ROLE == "15M").Select(score => score.SCORE1.Value * score.ROLESCORE.COEFFICIENT.Value).ToList();
                    List<double> midTermMark = scores.Where(item => item.IDSUBJECT == subject.Id && item.IDSTUDENT == students[indexStudent].ID && item.ROLESCORE.ROLE == "45M").Select(score => score.SCORE1.Value * score.ROLESCORE.COEFFICIENT.Value).ToList();
                    List<double> finalMark = scores.Where(item => item.IDSUBJECT == subject.Id && item.IDSTUDENT == students[indexStudent].ID && item.ROLESCORE.ROLE == "FINAL").Select(score => score.SCORE1.Value * score.ROLESCORE.COEFFICIENT.Value).ToList();

                    double avg = (oralMark.Sum() + regularMark.Sum() + midTermMark.Sum() + finalMark.Sum()) / (coefficientOralMark * oralMark.Count + coefficientRegularMark * regularMark.Count + coefficientMidTermMark * midTermMark.Count + coefficientFinalMark * finalMark.Count);

                    if (!double.IsNaN(avg) && avg >= subject.PASSSCORE)
                    {
                        avgScoreStudent.Add(avg);
                    }
                }

                data.Add(new GRIDVIEW4REPORT(classes[indexClass].ID, idSemester, subject.Id) { ThuTu = indexClass + 1, Lop = classes[indexClass].CLASSNAME, SiSo = students.Count, SoLuongDat = avgScoreStudent.Count });
            }

            this.Invoke(new System.Action(() => { dataGridViewBindingSource.DataSource = data.ToList(); }));
        }

        private void LoadSubjectFromDatabase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListSchoolYear_CurrentChanged(null, null);
            LoadSubjectFromDatabase_DoWork(null, null);
        }

        private void LoadSubjectFromDatabase_DoWork(object sender, DoWorkEventArgs e)
        {
            List<string> subjects = studMin.Database.SubjectServices.Instance.GetSubjects().Select(item => item.DisplayName).ToList();
            List<IGrouping<string, SCHEDULE>> schoolYear = studMin.Database.DataProvider.Instance.Database.SCHEDULEs.GroupBy(schedule => schedule.SCHOOLYEAR).ToList();

            AssignDataToComboBox(SchoolYear_ComboBox, listSchoolYear, schoolYear.Select(item => new SCHEDULE4COMBOBOX(item.Key, item.ToList())).ToList(), "NamHoc", "NamHoc");
            AssignDataToComboBox(Subject_ComboBox, listSubject, subjects, "", "");
        }

        private void ListSchoolYear_CurrentChanged(object sender, EventArgs e)
        {
            List<SCHEDULE> schedule = (listSchoolYear.Current as SCHEDULE4COMBOBOX).TKB_Nam;
            AssignDataToComboBox(Semester_ComboBox, listSemester, schedule.Select(item => item.SEMESTER.NAME).Distinct().Select(semester => HocKy(int.Parse(semester))).ToList(), "", "");
        }

        private string HocKy(int msg)
        {
            return String.Format("Học kỳ: {0}", Methods.Semester(msg));
        }

        private void Search_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable.Rows.Clear();
                // query load lại table theo từ khóa trong search box
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                Search_Box.Text = String.Empty;
            }
        }
    }
}
