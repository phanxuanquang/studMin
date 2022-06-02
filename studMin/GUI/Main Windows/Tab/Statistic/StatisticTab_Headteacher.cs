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

        private List<String> subjects = new List<string>();
        private List<String> schoolyears = new List<string>();
        private List<String> semesters = new List<string>();

        List<SUBJECT> listSub = new List<SUBJECT>();
        List<SEMESTER> listSem = new List<SEMESTER>();

        private GUI.LoadingWindow loadingWindow = null;

        private class TEACH4COMBOBOX
        {
            private List<TEACH> _grouping;
            private string _key;

            public string NamHoc { get { return _key; } }
            public List<TEACH> GiangDay { get { return _grouping; } }

            public TEACH4COMBOBOX(string NamHoc, List<TEACH> GiangDay)
            {
                _key = NamHoc;
                _grouping = GiangDay;
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
            Action.Excel.ReportSubject.Info info = new studMin.Action.Excel.ReportSubject.Info() { HocKy = Methods.ParseSemester(Semester_ComboBox.SelectedItem as string), MonHoc = Subject_ComboBox.SelectedItem as string, NamHoc = SchoolYear_ComboBox.SelectedItem as String };

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

        private void AssignDataToComboBox(Guna.UI2.WinForms.Guna2ComboBox userControl, List<String> list)
        {
            userControl.Invoke(new System.Action(() =>
            {
                userControl.DataSource = list;
            }));
        }

        private void StatisticTab_Headteacher_Load(object sender, EventArgs e)
        {
            loadingWindow = new GUI.LoadingWindow(this.ParentForm, "ĐANG TẢI BẢNG TỔNG KẾT MÔN HỌC");
           
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

            SchoolYear_ComboBox.SelectedIndexChanged += ListSchoolYear_CurrentChanged;

            Semester_ComboBox.SelectedIndexChanged += ListSemester_CurrentChanged;

            Subject_ComboBox.SelectedIndexChanged += Subject_ComboBox_SelectedIndexChanged;
            Semester_ComboBox.SelectedIndexChanged += Semester_ComboBox_SelectedIndexChanged;
            SchoolYear_ComboBox.SelectedIndexChanged += SchoolYear_ComboBox_SelectedIndexChanged;
           
            backgroundWorker.DoWork += LoadSubjectFromDatabase_DoWork;
            backgroundWorker.RunWorkerCompleted += LoadSubjectFromDatabase_RunWorkerCompleted;
            backgroundWorker.RunWorkerAsync();
            loadingWindow.ShowDialog();
        }
        private void ListSchoolYear_CurrentChanged(object sender, EventArgs e)
        {
            AssignDataToComboBox(Semester_ComboBox, semesters);
        }

        private void ListSemester_CurrentChanged(object sender, EventArgs e)
        {
            AssignDataToComboBox(Subject_ComboBox, subjects);
        }

        private void Semester_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateReportSubject_CurrentChanged();
        }

        private void Subject_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateReportSubject_CurrentChanged();
        }

        private void SchoolYear_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateReportSubject_CurrentChanged();
        }

        private void UpdateReportSubject_CurrentChanged()
        {
            string schoolYear = SchoolYear_ComboBox.SelectedItem.ToString();
            string _semester = Semester_ComboBox.SelectedItem.ToString();
            string _subject = Subject_ComboBox.SelectedItem.ToString();
            SEMESTER sEMESTERs = listSem.Where(x => x.NAME == _semester).FirstOrDefault();

            if (String.IsNullOrEmpty(schoolYear) || String.IsNullOrEmpty(_semester) || String.IsNullOrEmpty(_subject)) return;

           
            SUBJECT subject = listSub.FirstOrDefault(item => item.DisplayName == _subject);
            int coefficientOralMark = 1;
            int coefficientRegularMark = 1;
            int coefficientMidTermMark = 1;
            int coefficientFinalMark = 1;

            var listRolescore = Database.DataProvider.Instance.Database.ROLESCOREs.ToList();
            foreach (var item in listRolescore)
            {
                switch(item.ROLE)
                {
                    case "M":
                        coefficientFinalMark = item.COEFFICIENT.Value;
                        break;
                    case "15M":
                        coefficientRegularMark = item.COEFFICIENT.Value;
                        break;
                    case "45M":
                        coefficientMidTermMark = item.COEFFICIENT.Value;
                        break;
                    default:
                        coefficientFinalMark = item.COEFFICIENT.Value;
                        break;
                }
            }

            if (data == null) data = new List<GRIDVIEW4REPORT>();
            else data.Clear();
            //foreach (var itemSEM in sEMESTERs)
            {
                List<CLASS> classes = studMin.Database.DataProvider.Instance.Database.STUDYINGs.Where(itemx => itemx.SCHOOLYEAR == schoolYear && itemx.IDSEMESTER == sEMESTERs.ID).Select(itemy => itemy.CLASS).Distinct().ToList();
                for (int indexClass = 0; indexClass < classes.Count; indexClass++)
                {
                    Guid idClass = classes[indexClass].ID;
                    string className = classes[indexClass].CLASSNAME;

                    List<STUDENT> students = studMin.Database.ClassServices.Instance.GetListStudentOfClass(className, schoolYear);

                    if (students.Count == 0) continue;

                    List<double> avgScoreStudent = new List<double>();

                    //for (int indexStudent = 0; indexStudent < students.Count; indexStudent++)
                    {
                        foreach (STUDENT student in students)
                        {
                            List<SCORE> scores = studMin.Database.DataProvider.Instance.Database.SCOREs.Where(item => item.IDSEMESTER == sEMESTERs.ID && item.SCHOOLYEAR == schoolYear && item.IDSTUDENT == student.ID && item.IDSUBJECT == subject.Id).ToList();
                            if (scores.Count == 0) continue;
                            List<double> oralMark = new List<double>();
                            List<double> regularMark = new List<double>();
                            List<double> midTermMark = new List<double>();
                            List<double> finalMark = new List<double>();
                            foreach(var x in scores)
                            {
                                switch (x.ROLESCORE.ROLE)
                                {
                                    case "M":
                                        oralMark.Add(x.SCORE1.Value);
                                        break;
                                    case "15M":
                                        regularMark.Add(x.SCORE1.Value);
                                        break;
                                    case "45M":
                                        midTermMark.Add(x.SCORE1.Value);
                                        break;
                                    default:
                                        finalMark.Add(x.SCORE1.Value);
                                        break;
                                }
                            }
                            double avg = (oralMark.Sum() + regularMark.Sum() + midTermMark.Sum() + finalMark.Sum()) / (coefficientOralMark * oralMark.Count + coefficientRegularMark * regularMark.Count + coefficientMidTermMark * midTermMark.Count + coefficientFinalMark * finalMark.Count);

                            if (!double.IsNaN(avg) && avg >= subject.PASSSCORE)
                            {
                                avgScoreStudent.Add(avg);
                            }
                        }
                    }
                    data.Add(new GRIDVIEW4REPORT(classes[indexClass].ID, sEMESTERs.ID, subject.Id) { ThuTu = indexClass + 1, Lop = classes[indexClass].CLASSNAME, SiSo = students.Count, SoLuongDat = avgScoreStudent.Count });
                }    
            }

            this.Invoke(new System.Action(() => { dataGridViewBindingSource.DataSource = data.ToList();}));
        }


        private void LoadSubjectFromDatabase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            loadingWindow.Close();
        }

        private void LoadSubjectFromDatabase_DoWork(object sender, DoWorkEventArgs e)
        {
            listSub = studMin.Database.SubjectServices.Instance.GetSubjects();
            listSem = studMin.Database.DataProvider.Instance.Database.SEMESTERs.Where(x => x.NAME != "0").ToList();
            subjects = listSub.Select(item => item.DisplayName).ToList();
            schoolyears = studMin.Database.DataProvider.Instance.Database.CLASSes.Select(x => x.SCHOOLYEAR).Distinct().ToList();
            semesters = listSem.Select(y => y.NAME).ToList();
            AssignDataToComboBox(SchoolYear_ComboBox, schoolyears);
           
        }

        private string HocKy(int msg)
        {
            return String.Format("Học kỳ: {0}", Methods.Semester(msg));
        }

        private void Search_Box_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[DataTable.DataSource];
                cm.SuspendBinding();

                for (int i = 0; i < DataTable.RowCount; i++)
                {
                    if (DataTable.Rows[i].Cells[0].Value != null &&
                        DataTable.Rows[i].Cells[1].Value != null)
                    {
                        string @class = DataTable.Rows[i].Cells[1].Value.ToString().ToLower();

                        if (@class.Contains(Search_Box.Text.ToLower()))
                        {
                            DataTable.Rows[i].Visible = true;
                        }
                        else
                        {
                            DataTable.Rows[i].Visible = false;
                        }
                    }
                }

                cm.ResumeBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
