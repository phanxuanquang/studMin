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
        List<REPORTSUBJECT> recordExists = null;
        List<int> SiSo = null;

        private List<string> subjects = new List<string>();
        private List<string> schoolyears = new List<string>();
        private List<string> semesters = new List<string>();

        List<SUBJECT> listSub = new List<SUBJECT>();
        List<SEMESTER> listSem = new List<SEMESTER>();
        List<STUDYING> studying = null;

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
            private double ratio;

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
            public double _TiLeDat
            {
                get { return ratio; }
                set { ratio = value; }
            }

            public string TiLeDat { get { return String.Format("{0}%", ratio != -1 ? Math.Round(ratio, 2) : Math.Round(SoLuongDat * 100.0 / SiSo, 2)); } }

            public GRIDVIEW4REPORT(Guid IdClass, Guid IdSemester, Guid IdSubject)
            {
                _idClass = IdClass;
                _idSemester = IdSemester;
                _idSubject = IdSubject;
                ratio = -1.0;
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
            int semester = -1;
            string subject = string.Empty;
            string schoolYear = string.Empty;

            void GetValue()
            {
                semester = Methods.ParseSemester(Semester_ComboBox.SelectedItem as string);
                subject = Subject_ComboBox.SelectedItem as string;
                schoolYear = SchoolYear_ComboBox.SelectedItem as string;
            }

            if (Semester_ComboBox.InvokeRequired)
            {
                this.Invoke(new System.Action(() =>
                {
                    GetValue();
                }));
            }
            else GetValue();

            Action.Excel.ReportSubject.Info info = new studMin.Action.Excel.ReportSubject.Info() { HocKy = semester, MonHoc = subject, NamHoc = schoolYear };

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
            if (userControl.InvokeRequired)
            {
                userControl.Invoke(new System.Action(() => { userControl.DataSource = list; }));
            }
            else userControl.DataSource = list;
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
            string _semester = Methods.ParseSemester(Semester_ComboBox.SelectedItem.ToString()).ToString();
            string _subject = Subject_ComboBox.SelectedItem.ToString();
            SEMESTER semester = listSem.Where(x => x.NAME == _semester).FirstOrDefault();

            if (String.IsNullOrEmpty(schoolYear) || String.IsNullOrEmpty(_semester) || String.IsNullOrEmpty(_subject)) return;

            SUBJECT subject = listSub.FirstOrDefault(item => item.DisplayName == _subject);

            if (data == null) data = new List<GRIDVIEW4REPORT>();
            else data.Clear();

            this.BeginInvoke(new System.Action(() =>
            {
                tittleLabel.Text = TitleSchedule(_subject, int.Parse(_semester), int.Parse(schoolYear));
            }));

            List<CLASS> classes = studying.Where(itemx => itemx.SCHOOLYEAR == schoolYear && itemx.IDSEMESTER == semester.ID).Select(itemy => itemy.CLASS).Distinct().ToList();
            for (int indexClass = 0; indexClass < classes.Count; indexClass++)
            {
                Guid idClass = classes[indexClass].ID;
                string className = classes[indexClass].CLASSNAME;

                REPORTSUBJECT filter = recordExists.Where(item => item.IDCLASS == idClass && item.IDSUBJECT == subject.Id && item.IDSEMESTER == semester.ID).FirstOrDefault();

                if (filter != null)
                {
                    int indexSiSo = recordExists.IndexOf(filter);
                    data.Add(new GRIDVIEW4REPORT(filter.IDCLASS, filter.IDSEMESTER, filter.IDSUBJECT) { Lop = className, SiSo = SiSo[indexSiSo], SoLuongDat = filter.PASSQUANTITY.Value, _TiLeDat = filter.RATIO.Value });
                }
            }

            if (this.InvokeRequired)
            {
                this.Invoke(new System.Action(() => { dataGridViewBindingSource.DataSource = data.ToList(); }));
            }
            else dataGridViewBindingSource.DataSource = data.ToList();
        }

        private string TitleSchedule(string subject, int semester, int schoolYear)
        {
            return String.Format("BẢNG TỔNG KẾT MÔN {0} - {1} - NĂM HỌC {2} - {3}", subject, Methods.HocKy(semester), schoolYear, schoolYear + 1).ToUpper();
        }

        private void LoadSubjectFromDatabase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadingWindow.Close();
        }

        private void LoadSubjectFromDatabase_DoWork(object sender, DoWorkEventArgs e)
        {
            recordExists = studMin.Database.DataProvider.Instance.Database.REPORTSUBJECTs.ToList();
            List<(Guid, int)> listClass = (recordExists.Select(item => item.CLASS).Distinct().ToList()).Select(item => (item.ID, studMin.Database.ClassServices.Instance.GetQuantityOfClass(item))).ToList();

            SiSo = recordExists.Select(item => listClass.Where(list => list.Item1 == item.IDCLASS).First().Item2).ToList();

            listSub = studMin.Database.SubjectServices.Instance.GetSubjects();
            listSem = studMin.Database.DataProvider.Instance.Database.SEMESTERs.ToList();
            subjects = listSub.Select(item => item.DisplayName).ToList();
            schoolyears = studMin.Database.DataProvider.Instance.Database.CLASSes.Select(x => x.SCHOOLYEAR).Distinct().ToList();
            studying = studMin.Database.DataProvider.Instance.Database.STUDYINGs.ToList();

            SEMESTER temp = listSem[0];
            listSem.Remove(temp);
            listSem.Add(temp);

            semesters = listSem.Select(y => Methods.HocKy(int.Parse(y.NAME))).ToList();
            AssignDataToComboBox(SchoolYear_ComboBox, schoolyears);

            Task<bool> updateReportSubject = Task<bool>.Factory.StartNew(() =>
            {
                List<int> tempSiSo = new List<int>();
                List<REPORTSUBJECT> tempRecordExists = new List<REPORTSUBJECT>();
                List<STUDYING> studying = studMin.Database.DataProvider.Instance.Database.STUDYINGs.ToList();
                List<SCORE> scores = studMin.Database.DataProvider.Instance.Database.SCOREs.ToList();
                int currentSchoolYear = int.Parse(studMin.Database.ClassServices.Instance.GetCurrentSchoolYear());
                bool isUpdate = false;

                int coefficientOralMark = 1;
                int coefficientRegularMark = 1;
                int coefficientMidTermMark = 1;
                int coefficientFinalMark = 1;

                var listRolescore = Database.DataProvider.Instance.Database.ROLESCOREs.ToList();
                foreach (var item in listRolescore)
                {
                    switch (item.ROLE)
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

                foreach (var subject in listSub)
                {
                    foreach (var semester in listSem)
                    {
                        foreach (var schoolYear in schoolyears)
                        {
                            List<CLASS> classes = studying.Where(itemx => itemx.SCHOOLYEAR == schoolYear && itemx.IDSEMESTER == semester.ID).Select(itemy => itemy.CLASS).Distinct().ToList();
                            for (int indexClass = 0; indexClass < classes.Count; indexClass++)
                            {
                                Guid idClass = classes[indexClass].ID;
                                string className = classes[indexClass].CLASSNAME;

                                List<Guid> students = studying.Where(item => item.IDCLASS == idClass).Select(item => item.IDSTUDENT).Distinct().ToList();

                                if (students.Count == 0) continue;

                                List<double> avgScoreStudent = new List<double>();

                                foreach (Guid student in students)
                                {
                                    List<SCORE> scoreFilter = scores.Where(item => item.IDSEMESTER == semester.ID && item.SCHOOLYEAR == schoolYear && item.IDSTUDENT == student && item.IDSUBJECT == subject.Id).ToList();
                                    if (scores.Count == 0) continue;
                                    List<double> oralMark = new List<double>();
                                    List<double> regularMark = new List<double>();
                                    List<double> midTermMark = new List<double>();
                                    List<double> finalMark = new List<double>();
                                    foreach (var x in scoreFilter)
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
                                tempSiSo.Add(students.Count);
                                tempRecordExists.Add(new REPORTSUBJECT() { IDCLASS = idClass, IDSEMESTER = semester.ID, IDSUBJECT = subject.Id, PASSQUANTITY = avgScoreStudent.Count, RATIO = avgScoreStudent.Count * 100.0 / students.Count });

                                if (currentSchoolYear == int.Parse(schoolYear))
                                {
                                    List<REPORTSUBJECT> filters = recordExists.Where(item => item.IDCLASS == idClass && item.IDSUBJECT == subject.Id && item.IDSEMESTER == semester.ID).ToList();

                                    if (filters.Count > 0)
                                    {
                                        foreach (var filter in filters)
                                        {
                                            if (filter.PASSQUANTITY.Value != avgScoreStudent.Count || filter.RATIO.Value != avgScoreStudent.Count * 100.0 / students.Count)
                                            {
                                                filter.PASSQUANTITY = avgScoreStudent.Count;
                                                filter.RATIO = avgScoreStudent.Count * 100.0 / students.Count;
                                                isUpdate = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        recordExists.Add(new REPORTSUBJECT() { IDCLASS = idClass, IDSEMESTER = semester.ID, IDSUBJECT = subject.Id, PASSQUANTITY = avgScoreStudent.Count, RATIO = avgScoreStudent.Count * 100.0 / students.Count });
                                        isUpdate = true;
                                    }
                                }
                            }
                        }
                    }
                }


                SiSo.Clear();
                recordExists.Clear();

                SiSo.AddRange(tempSiSo);
                recordExists.AddRange(tempRecordExists);

                return isUpdate;
            });

            updateReportSubject.GetAwaiter().OnCompleted(new System.Action(() =>
            {
                studMin.Database.DataProvider.Instance.Database.SaveChangesAsync();
                if (updateReportSubject.Result)
                {
                    MessageBox.Show("Đã có sự thay đổi trong bảng thống kê! Hiện tại đã được cập nhật.");
                }
            }));
        }

        private void Search_Box_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[DataTable.DataSource];
                cm.SuspendBinding();

                for (int i = 0; i < DataTable.RowCount; i++)
                {
                    if (DataTable.Rows[i].Cells[1].Value != null)
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
