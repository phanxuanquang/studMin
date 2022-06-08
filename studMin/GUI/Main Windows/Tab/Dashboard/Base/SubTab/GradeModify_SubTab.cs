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

namespace studMin
{
    using Database.Models;
    public partial class GradeModify_SubTab : UserControl
    {
        private BackgroundWorker backgroundWorker = null;
        private Action.Excel.Subject.Info importInfo = null;
        private List<Action.Excel.Subject.Item> data = null;
        private string className = string.Empty;
        private string schoolYear = string.Empty;
        private string semester = string.Empty;
        private Timer timer = null;

        private bool isAllowEdit = false;
        private int lastestSchoolYear = -1;

        public GradeModify_SubTab()
        {
            InitializeComponent();
            this.Load += GradeModify_SubTab_Load;
        }

        private async void GradeModify_SubTab_Load(object sender, EventArgs e)
        {
            await System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                lastestSchoolYear = int.Parse(studMin.Database.ClassServices.Instance.GetCurrentSchoolYear());
                List<string> schoolYear = studMin.Database.DataProvider.Instance.Database.TEACHes.Where(item => item.IDTEACHER == studMin.Database.LoginServices.LoginServices.Instance.CurrentTeacher.ID).Select(item => item.SCHOOLYEAR).Distinct().ToList();
                if (this.InvokeRequired)
                {
                    this.Invoke(new System.Action(() => { SchoolYear_ComboBox.DataSource = schoolYear; }));
                }
                else SchoolYear_ComboBox.DataSource = schoolYear;
                var listSemester = Database.DataProvider.Instance.Database.SEMESTERs.ToList().Select(item => item.NAME).ToList();

                string temp = listSemester[0];
                listSemester[0] = listSemester[1];
                listSemester[1] = temp;

                listSemester = listSemester.Select(item => Methods.HocKy(int.Parse(item))).ToList();

                SemesterComboBox.DataSource = listSemester;
            });
        }

        bool CheckValidGrade(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
            {
                Guna.UI2.WinForms.Guna2ComboBox targetCall = null;
                if (textBox != null)
                {
                    if (textBox.Equals(OralTestScore_Box))
                    {
                        targetCall = OralTestScore_ComboBox;
                    }
                    else if (textBox.Equals(RegularTestScore_Box))
                    {
                        targetCall = RegularTestScore_ComboBox;
                    }
                    else if (textBox.Equals(MidTermTestScore_Box))
                    {
                        targetCall = MidTermTestScore_ComboBox;
                    }
                }

                if (targetCall != null && targetCall.SelectedIndex != 0)
                {
                    if (MessageBox.Show("Điểm số đã được thay đổi. \nBạn có muốn tiếp tục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        targetCall.SelectedIndex = 0;
                    }
                    else
                    {
                        textBox.Focus();
                    }
                }

                return false;
            }

            bool isValid = double.TryParse(textBox.Text, out double numericTest);

            if (textBox.Enabled && !isValid)
            {
                MessageBox.Show("Điểm số chỉ bao gồm chữ số và dấu chấm thập phân. \nVui lòng nhập lại điểm.", "Điểm số không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox.Text = String.Empty;
                textBox.Focus();
                return false;
            }

            int minScore = 0;
            int maxScore = 10;

            PARAMETER limitScore = Database.ParameterServices.Instance.GetParameterByName("POINTLADDER");

            if (limitScore != null)
            {
                minScore = (int)limitScore.MIN;
                maxScore = (int)limitScore.MAX;
            }

            if (numericTest < minScore || numericTest > maxScore)
            {
                MessageBox.Show($"Điểm phải nằm trong khoảng từ {minScore} đến {maxScore}. \nVui lòng nhập lại điểm.", "Điểm số không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox.Text = String.Empty;
                textBox.Focus();
                return false;
            }

            if (textBox.Text.Length > 4)
            {
                ToolTipRound.Show(String.Format("Điểm sẽ được làm tròn thành: {0}", Math.Round(numericTest, 2)), textBox);

                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += (s, e) =>
                {
                    textBox.Text = Math.Round(numericTest, 2).ToString();
                    ToolTipRound.Hide(textBox);
                    timer.Stop();
                    timer.Dispose();
                    timer = null;
                };
                timer.Start();
            }
            return true;
        }

        private void OralTestScore_Box_Validated(object sender, EventArgs e)
        {
            CheckValidGrade(OralTestScore_Box);
        }

        private void RegularTestScore_Box_Validated(object sender, EventArgs e)
        {
            CheckValidGrade(RegularTestScore_Box);
        }

        private void MidTermTestScore_Box_Validated(object sender, EventArgs e)
        {
            CheckValidGrade(MidTermTestScore_Box);
        }

        private void DataGridViewImport_Button_Click(object sender, EventArgs e)
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
                MessageBox.Show("Đang truy xuất danh sách. Vui lòng đợi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (MessageBox.Show("Cập nhật điềm vào cơ sở dữ liệu?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TEACHER teacher = studMin.Database.LoginServices.LoginServices.Instance.CurrentTeacher;
                string schoolYear = importInfo.NamHoc.Split(new string[] { " - " }, StringSplitOptions.None)[0];
                CLASS @class = studMin.Database.ClassServices.Instance.GetClassByClassNameAndSchoolYear(importInfo.Lop, schoolYear);

                List<STUDENT> students = studMin.Database.ClassServices.Instance.GetListStudentOfClass(@class.CLASSNAME, schoolYear);

                for (int index = 0; index < data.Count; index++)
                {
                    STUDENT student = students.Where(item => item.INFOR.FIRSTNAME + " " + item.INFOR.LASTNAME == data[index].HoTen).FirstOrDefault();
                    for (int oral = 0; oral < data[index].DiemMieng.Count; oral++)
                    {
                        studMin.Database.StudentServices.Instance.SaveScoreToDB(student.ID, data[index].DiemMieng[oral], schoolYear, importInfo.HocKy.ToString(), "M");
                    }
                    for (int regular = 0; regular < data[index].Diem15Phut.Count; regular++)
                    {
                        studMin.Database.StudentServices.Instance.SaveScoreToDB(student.ID, data[index].Diem15Phut[regular], schoolYear, importInfo.HocKy.ToString(), "15M");
                    }
                    for (int midTerm = 0; midTerm < data[index].Diem1Tiet.Count; midTerm++)
                    {
                        studMin.Database.StudentServices.Instance.SaveScoreToDB(student.ID, data[index].Diem1Tiet[midTerm], schoolYear, importInfo.HocKy.ToString(), "45M");
                    }
                    studMin.Database.StudentServices.Instance.SaveScoreToDB(student.ID, data[index].DiemCuoiKy, schoolYear, importInfo.HocKy.ToString(), "FINAL");
                }
            }
        }

        private void ImportExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            Action.Excel.Subject subject = new Action.Excel.Subject(true, (string)e.Argument);

            importInfo = (Action.Excel.Subject.Info)subject.SelectInfo();

            data = (List<Action.Excel.Subject.Item>)subject.SelectItem(null);

            subject.Dispose();
        }

        private void DataGridViewExport_Button_Click(object sender, EventArgs e)
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
                MessageBox.Show("Đang có tiến trình đang chạy. Vui lòng đợi trong giây lát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            backgroundWorker.DoWork += ExportExcel_DoWork;
            backgroundWorker.RunWorkerAsync(exportPath);
        }
        // sửa hàm khi có combobox
        private void ExportExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            if (className == "Mọi lớp")
            {
                MessageBox.Show("Hãy chọn lớp học để xuất danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TEACHER teacher = studMin.Database.LoginServices.LoginServices.Instance.CurrentTeacher;
            TEACH teach = studMin.Database.DataProvider.Instance.Database.TEACHes.Where(item => item.CLASS.CLASSNAME == className && item.SCHOOLYEAR == schoolYear && item.IDTEACHER == teacher.ID).FirstOrDefault();

            Action.Excel.Subject.Info info = new Action.Excel.Subject.Info()
            {
                GiaoVien = teacher.INFOR.FIRSTNAME + " " + teacher.INFOR.LASTNAME,
                HocKy = Convert.ToInt32(teach.SEMESTER.NAME),
                Lop = className,
                NamHoc = schoolYear,
                MonHoc = teach.SUBJECT.DisplayName,
            };

            List<STUDENT> students = studMin.Database.ClassServices.Instance.GetListStudentOfClass(className, schoolYear);
            List<Action.Excel.Subject.Item> list = new List<Action.Excel.Subject.Item>();

            for (int index = 0; index < students.Count; index++)
            {
                //không biết vì sao để lồng vào thì lại lỗi
                //List<SCORE> scores = Database.DataProvider.Instance.Database.SCOREs.Where(item => item.IDSTUDENT == students[index].ID).ToList();
                Guid idStudent = students[index].ID;
                List<SCORE> scores = Database.DataProvider.Instance.Database.SCOREs.Where(item => item.IDSTUDENT == idStudent && item.IDSUBJECT == teach.IDSUBJECT && item.SCHOOLYEAR == schoolYear).ToList();

                List<double> oralMark = scores.Where(item => item.ROLESCORE.ROLE == "M").Select(score => score.SCORE1.Value).ToList();
                List<double> regularMark = scores.Where(item => item.ROLESCORE.ROLE == "15M").Select(score => score.SCORE1.Value).ToList();
                List<double> midTermMark = scores.Where(item => item.ROLESCORE.ROLE == "45M").Select(score => score.SCORE1.Value).ToList();
                double finalMark = scores.Where(item => item.ROLESCORE.ROLE == "FINAL").Select(score => score.SCORE1.Value).FirstOrDefault();

                list.Add(new Action.Excel.Subject.Item() { HoTen = students[index].INFOR.FIRSTNAME + " " + students[index].INFOR.LASTNAME, DiemMieng = oralMark, Diem15Phut = regularMark, Diem1Tiet = midTermMark, DiemCuoiKy = finalMark });
            }

            studMin.Action.Excel.Subject subject = new studMin.Action.Excel.Subject(false);

            subject.InsertInfo(info);

            for (int index = 0; index < list.Count; index++)
            {
                subject.InsertItem(list[index]);
            }

            List<ROLESCORE> roleScore = studMin.Database.DataProvider.Instance.Database.ROLESCOREs.ToList();
            subject.coefficient = new studMin.Action.Excel.Subject.Coefficient()
            {
                HeSoDiemMieng = roleScore.Where(role => role.ROLE == "M").Select(item => item.COEFFICIENT).FirstOrDefault().Value,
                HeSoDiem15Phut = roleScore.Where(role => role.ROLE == "15M").Select(item => item.COEFFICIENT).FirstOrDefault().Value,
                HeSoDiem1Tiet = roleScore.Where(role => role.ROLE == "45M").Select(item => item.COEFFICIENT).FirstOrDefault().Value,
                HeSoDiemHocKy = roleScore.Where(role => role.ROLE == "FINAL").Select(item => item.COEFFICIENT).FirstOrDefault().Value,
            };

            subject.SetFomular();

            subject.ShowExcel();

            subject.Save((string)e.Argument);

            //if (MessageBox.Show("Bạn có muốn xem bảng tính lúc in?", "In Bảng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    subject.ShowPrintPreview();
            //}

            /*subject.Dispose();*/
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                LoadScore();
            }
        }

        private void LoadScore()
        {
            mDataGridView.Rows.Clear();
            m15DataGridView.Rows.Clear();
            m45DataGridView.Rows.Clear();
            finalDataGridView.Rows.Clear();

            STUDENT4GRIDVIEW student = sTUDENTBindingSource.Current as STUDENT4GRIDVIEW;
            //đè lấy điểm (năm học, lớp, học sinh, (môn học của giáo viên))

            Guid idSubject = studMin.Database.LoginServices.LoginServices.Instance.CurrentTeacher.IDSUBJECT.Value;
            SEMESTER _semester = studMin.Database.DataProvider.Instance.Database.SEMESTERs.Where(item => item.NAME == semester).FirstOrDefault();
            List<SCORE> scores = Database.DataProvider.Instance.Database.SCOREs.Where(item => item.IDSTUDENT == student.ID && item.IDSUBJECT == idSubject && item.SCHOOLYEAR == schoolYear && item.IDSEMESTER == _semester.ID).ToList();

            List<SCORE4GRIDVIEW> orals = scores.Where(item => item.ROLESCORE.ROLE == "M").Select(score => new SCORE4GRIDVIEW(score.ID, score.SCORE1.Value)).ToList();
            List<SCORE4GRIDVIEW> regulars = scores.Where(item => item.ROLESCORE.ROLE == "15M").Select(score => new SCORE4GRIDVIEW(score.ID, score.SCORE1.Value)).ToList();
            List<SCORE4GRIDVIEW> midterms = scores.Where(item => item.ROLESCORE.ROLE == "45M").Select(score => new SCORE4GRIDVIEW(score.ID, score.SCORE1.Value)).ToList();
            List<SCORE4GRIDVIEW> finals = scores.Where(item => item.ROLESCORE.ROLE == "FINAL").Select(score => new SCORE4GRIDVIEW(score.ID, score.SCORE1.Value)).ToList();

            sCOREMBindingSource.DataSource = orals;
            sCORE15MBindingSource.DataSource = regulars;
            sCORE45MBindingSource.DataSource = midterms;
            sCOREFinalBindingSource.DataSource = finals;

            OralTestScore_ComboBox.Items.Clear();
            RegularTestScore_ComboBox.Items.Clear();
            MidTermTestScore_ComboBox.Items.Clear();

            OralTestScore_ComboBox.Items.Add("Lần kiểm tra");
            RegularTestScore_ComboBox.Items.Add("Lần kiểm tra");
            MidTermTestScore_ComboBox.Items.Add("Lần kiểm tra");

            OralTestScore_ComboBox.Items.AddRange(orals.Select(item => String.Format("Lần {0}", orals.IndexOf(item) + 1)).ToArray());
            RegularTestScore_ComboBox.Items.AddRange(regulars.Select(item => String.Format("Lần {0}", regulars.IndexOf(item) + 1)).ToArray());
            MidTermTestScore_ComboBox.Items.AddRange(midterms.Select(item => String.Format("Lần {0}", midterms.IndexOf(item) + 1)).ToArray());

            if (isAllowEdit)
            {
                OralTestScore_ComboBox.Items.Add("Thêm...");
                RegularTestScore_ComboBox.Items.Add("Thêm...");
                MidTermTestScore_ComboBox.Items.Add("Thêm...");
            }

            ResetComboBox();
        }

        private void Class_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetComboBox();
            ResetDataGridView();
            className = Class_ComboBox.SelectedItem.ToString();
            var listSemester = Database.DataProvider.Instance.Database.SEMESTERs.ToList().Select(item => item.NAME).ToList();

            string temp = listSemester[0];
            listSemester[0] = listSemester[1];
            listSemester[1] = temp;

            listSemester = listSemester.Select(item => Methods.HocKy(int.Parse(item))).ToList();

            SemesterComboBox.DataSource = listSemester;
            //if (className != "Mọi lớp")
            //{
            //    List<STUDENT> students = studMin.Database.ClassServices.Instance.GetListStudentOfClass(className, schoolYear);
            //    sTUDENTBindingSource.DataSource = students.Select(student => new STUDENT4GRIDVIEW(student.ID, student.INFOR.FIRSTNAME, student.INFOR.LASTNAME)).ToList();
            //}
            //else
            //{
            //    List<string> @class = (Class_ComboBox.DataSource as List<string>);
            //    List<STUDENT> students = new List<STUDENT>();
            //    for (int index = 0; index < @class.Count; index++)
            //    {
            //        if (@class[index] != "Mọi lớp")
            //        {
            //            students.AddRange(studMin.Database.ClassServices.Instance.GetListStudentOfClass(@class[index], schoolYear));
            //        }
            //    }
            //    sTUDENTBindingSource.DataSource = students.Select(student => new STUDENT4GRIDVIEW(student.ID, student.INFOR.FIRSTNAME, student.INFOR.LASTNAME)).ToList();
            //}
        }

        private void SchoolYear_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetDataGridView();
            schoolYear = SchoolYear_ComboBox.SelectedItem.ToString();

            isAllowEdit = lastestSchoolYear == int.Parse(schoolYear);

            if (!String.IsNullOrEmpty(schoolYear))
            {
                List<string> @class = studMin.Database.DataProvider.Instance.Database.TEACHes.Where(item => item.SCHOOLYEAR == schoolYear && item.IDTEACHER == studMin.Database.LoginServices.LoginServices.Instance.CurrentTeacher.ID).Select(item => item.CLASS.CLASSNAME).Distinct().ToList();
                Class_ComboBox.DataSource = @class;
            }
        }

        private void ResetDataGridView()
        {
            sCOREMBindingSource.Clear();
            sCORE15MBindingSource.Clear();
            sCORE45MBindingSource.Clear();
            sCOREFinalBindingSource.Clear();
        }

        private void ResetComboBox()
        {
            OralTestScore_ComboBox.SelectedIndex = RegularTestScore_ComboBox.SelectedIndex = MidTermTestScore_ComboBox.SelectedIndex = 0;
        }

        class STUDENT4GRIDVIEW
        {
            private Guid _id;
            private string _firstName;
            private string _lastName;

            public Guid ID
            {
                get { return _id; }
            }

            public string PresentID
            {
                get { return _id.ToString().Substring(0, 8).ToUpper(); }
            }
            
            public string FirstName
            {
                get { return _firstName; }
            }
            
            public string LastName
            {
                get { return _lastName; }
            }

            public STUDENT4GRIDVIEW(Guid ID, string FirstName, string LastName)
            {
                _id = ID;
                _firstName = FirstName;
                _lastName = LastName;
            }
        }

        class SCORE4GRIDVIEW
        {
            private Guid _id;
            private double _score;

            public Guid ID
            {
                get { return _id; }
            }

            public double Score
            {
                get { return _score; }
            }

            public SCORE4GRIDVIEW(Guid ID, double Score)
            {
                _id = ID;
                _score = Score;
            }
        }

        void scoreModify(Guna.UI2.WinForms.Guna2ComboBox comboBox, Guna.UI2.WinForms.Guna2TextBox textBox, BindingSource binding)
        {
            int index = comboBox.SelectedIndex;
            int count = binding.Count;

            if (index == 0)
            {
                textBox.Text = String.Empty;
                textBox.Enabled = false;
            }
            else if (index == count + 1)
            {
                textBox.Text = String.Empty;
                textBox.Enabled = true;
            }
            else if (index > 0 && index <= count)
            {
                textBox.Text = ((SCORE4GRIDVIEW)binding.List[index - 1]).Score.ToString();
                if (!isAllowEdit)
                {
                    textBox.ReadOnly = true;
                    textBox.Enabled = false;
                }
                else
                {
                    textBox.Enabled = true;
                    textBox.ReadOnly = false;
                }
            }
        }

        private void OralTestScore_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoreModify(OralTestScore_ComboBox, OralTestScore_Box, sCOREMBindingSource);
        }

        private void RegularTestScore_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoreModify(RegularTestScore_ComboBox, RegularTestScore_Box, sCORE15MBindingSource);
        }

        private void MidTermTestScore_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoreModify(MidTermTestScore_ComboBox, MidTermTestScore_Box, sCORE45MBindingSource);
        }

        private void UpdateData_Button_Click(object sender, EventArgs e)
        {
            double score = 0.0;
            int index = -1;

            if (String.IsNullOrEmpty(OralTestScore_Box.Text) && String.IsNullOrEmpty(RegularTestScore_Box.Text) && String.IsNullOrEmpty(MidTermTestScore_Box.Text))
            {
                return;
            }

            if (!String.IsNullOrEmpty(OralTestScore_Box.Text))
            {
                index = OralTestScore_ComboBox.SelectedIndex;
                if (index > 0)
                {
                    score = double.Parse(OralTestScore_Box.Text);
                    UpdateScore(sCOREMBindingSource, index, score, "M");
                }
                else OralTestScore_Box.Text = string.Empty;
            }

            if (!String.IsNullOrEmpty(RegularTestScore_Box.Text))
            {
                index = RegularTestScore_ComboBox.SelectedIndex;
                if (index > 0)
                {
                    score = double.Parse(RegularTestScore_Box.Text);
                    UpdateScore(sCORE15MBindingSource, index, score, "15M");
                }
                else RegularTestScore_Box.Text = string.Empty;
            }

            if (!String.IsNullOrEmpty(MidTermTestScore_Box.Text))
            {
                index = MidTermTestScore_ComboBox.SelectedIndex;
                if (index > 0)
                {
                    score = double.Parse(MidTermTestScore_Box.Text);
                    UpdateScore(sCORE45MBindingSource, index, score, "45M");
                }
                else MidTermTestScore_Box.Text = string.Empty;
            }
            LoadScore();
            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateScore(BindingSource binding, int index, double score, string roleScore)
        {
            if (index <= binding.Count)
            {
                Guid idScore = ((SCORE4GRIDVIEW)binding.List[index - 1]).ID;
                SCORE _score = studMin.Database.DataProvider.Instance.Database.SCOREs.Where(item => item.ID == idScore).FirstOrDefault();
                _score.SCORE1 = score;
                studMin.Database.DataProvider.Instance.Database.SaveChanges();
            }
            else
            {
                TEACHER teacher = studMin.Database.LoginServices.LoginServices.Instance.CurrentTeacher;
                CLASS @class = studMin.Database.ClassServices.Instance.GetClassByClassNameAndSchoolYear(className, schoolYear);
                TEACH teach = studMin.Database.DataProvider.Instance.Database.TEACHes.Where(item => item.IDCLASS == @class.ID && item.IDTEACHER == teacher.ID).FirstOrDefault();
                studMin.Database.StudentServices.Instance.SaveScoreToDB((sTUDENTBindingSource.Current as STUDENT4GRIDVIEW).ID, score, @class.SCHOOLYEAR, teach.SEMESTER.NAME, roleScore);
            }
        }

        private void Search_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Search_Box.Text = String.Empty;
            }
        }

        private void Search_Box_TextChanged(object sender, EventArgs e)
        {
            Search_Button_Click(null, null);
        }

        private void DetailScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView whoCall = sender as Guna.UI2.WinForms.Guna2DataGridView;
            Guna.UI2.WinForms.Guna2ComboBox targetCall = null;

            if (whoCall != null)
            {
                if (whoCall.Equals(mDataGridView))
                {
                    targetCall = OralTestScore_ComboBox;
                }
                else if (whoCall.Equals(m15DataGridView))
                {
                    targetCall = RegularTestScore_ComboBox;
                }
                else if (whoCall.Equals(m45DataGridView))
                {
                    targetCall = MidTermTestScore_ComboBox;
                }
            }

            if (targetCall != null)
            {
                targetCall.SelectedIndex = e.RowIndex + 1;
            }
        }

        private void UpdateScore_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)) return;
            Guna.UI2.WinForms.Guna2TextBox whoCall = sender as Guna.UI2.WinForms.Guna2TextBox;
            Guna.UI2.WinForms.Guna2ComboBox targetCall = null;
            BindingSource binding = null;

            if (CheckValidGrade(whoCall))
            {
                if (whoCall != null)
                {
                    if (whoCall.Equals(OralTestScore_Box))
                    {
                        targetCall = OralTestScore_ComboBox;
                    }
                    else if (whoCall.Equals(RegularTestScore_Box))
                    {
                        targetCall = RegularTestScore_ComboBox;
                    }
                    else if (whoCall.Equals(MidTermTestScore_Box))
                    {
                        targetCall = MidTermTestScore_ComboBox;
                    }
                }

                if (targetCall != null)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Enter:
                            UpdateData_Button_Click(null, null);
                            break;
                        case Keys.Delete:
                            if (whoCall != null)
                            {
                                if (whoCall.Equals(OralTestScore_Box))
                                {
                                    binding = sCOREMBindingSource;
                                }
                                else if (whoCall.Equals(RegularTestScore_Box))
                                {
                                    binding = sCORE15MBindingSource;
                                }
                                else if (whoCall.Equals(MidTermTestScore_Box))
                                {
                                    binding = sCORE45MBindingSource;
                                }
                            }

                            if (binding != null)
                            {
                                RemoveScore(binding, targetCall.SelectedIndex);
                            }
                            break;
                        case Keys.Escape:
                            targetCall.SelectedIndex = 0;
                            break;
                    }
                }
            }
        }

        private void RemoveScore(BindingSource binding, int index)
        {
            if (index <= binding.Count)
            {
                Guid idScore = ((SCORE4GRIDVIEW)binding.List[index - 1]).ID;
                SCORE score = studMin.Database.DataProvider.Instance.Database.SCOREs.Where(item => item.ID == idScore).FirstOrDefault();
                studMin.Database.DataProvider.Instance.Database.SCOREs.Remove(score);
                studMin.Database.DataProvider.Instance.Database.SaveChanges();
            }
            LoadScore();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[GridView.DataSource];
                cm.SuspendBinding();

                for (int i = 0; i < GridView.RowCount; i++)
                {
                    if (GridView.Rows[i].Cells[0].Value != null &&
                        GridView.Rows[i].Cells[1].Value != null)
                    {
                        string fullName = GridView.Rows[i].Cells[1].Value.ToString().ToLower() + " " + GridView.Rows[i].Cells[2].Value.ToString().ToLower();
                        string searching = Search_Box.Text.ToLower();

                        if (fullName.Contains(searching) || GridView.Rows[i].Cells[0].Value.ToString().ToLower().StartsWith(searching))
                        {
                            GridView.Rows[i].Visible = true;
                        }
                        else
                        {
                            GridView.Rows[i].Visible = false;
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

        private void SemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetComboBox();
            ResetDataGridView();
            semester = Methods.ParseSemester(SemesterComboBox.SelectedItem.ToString()).ToString();
            if (className != "Mọi học kỳ")
            {
                List<STUDENT> students = studMin.Database.ClassServices.Instance.GetListStudentOfClass(className, schoolYear, semester);
               
                {
                    sTUDENTBindingSource.DataSource = students.Select(student => new STUDENT4GRIDVIEW(student.ID, student.INFOR.FIRSTNAME, student.INFOR.LASTNAME)).ToList();
                }    
            }
        }
    }
}
