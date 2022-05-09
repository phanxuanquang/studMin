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
        string className = string.Empty;

        public GradeModify_SubTab()
        {
            this.Load += GradeModify_SubTab_Load;
            InitializeComponent();
        }

        private void GradeModify_SubTab_Load(object sender, EventArgs e)
        {
            List<string> @class = studMin.Database.TeacherServices.Instance.GetAllClassTeaching().Select(item => item.CLASSNAME).ToList();
            @class.Add("Mọi lớp");
            Class_ComboBox.DataSource = @class;
        }

        void CheckValidGrade(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            double numericTest;
            PARAMETER limitScore = Database.ParameterServices.Instance.GetParameterByName("THANDIEM");
            int minScore = 0;
            int maxScore = 10;
            if (limitScore != null)
            {
                minScore = (int)limitScore.MIN;
                maxScore = (int)limitScore.MAX;
            }
            try
            {
                if (textBox.Text == String.Empty)
                {
                    return;
                }
                numericTest = double.Parse(textBox.Text);
            }
            catch
            {
                MessageBox.Show("Điểm chỉ bao gồm chữ số và dấu chấm thập phân. \nVui lòng nhập lại điểm số.", "Điểm số nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox.Text = String.Empty;
                textBox.Focus();
                return;
            }

            if (numericTest < minScore || numericTest > maxScore)
            {
                MessageBox.Show($"Điểm phải nằm trong khoảng từ {minScore} đến {maxScore}. \nVui lòng nhập lại điểm số.", "Điểm số nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox.Text = String.Empty;
                textBox.Focus();
            }
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
            if (!(Class_ComboBox.DataSource as List<string>).Contains(importInfo.Lop) && MessageBox.Show("đưa điểm vào csdl?", "IMPORT DATABASE", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TEACHER teacher = studMin.Database.LoginServices.LoginServices.Instance.CurrentTeacher;
                CLASS @class = studMin.Database.ClassServices.Instance.GetClassByClassName(importInfo.Lop);

                List<STUDENT> students = studMin.Database.ClassServices.Instance.GetListStudentOfClass(@class.CLASSNAME);

                string schoolYear = importInfo.NamHoc.Split(new string[] { " - " }, StringSplitOptions.None)[0];

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

        private void Search_Box_TextChanged(object sender, EventArgs e)
        {
            if (Class_ComboBox.Text != "Mọi lớp")
            {
                MessageBox.Show("Bạn phải chọn lớp trước khi tra cứu.", "LỖI TRUY XUẤT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
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
                            string fullName = GridView.Rows[i].Cells[0].Value.ToString().ToLower() + " " + GridView.Rows[i].Cells[1].Value.ToString().ToLower();

                            if (fullName.Contains(Search_Box.Text.ToLower()))
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
        }

        private void FullGridView_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridView.RowCount; i++)
            {
                GridView.Rows[i].Visible = true;
            }
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
                MessageBox.Show("Đang có tiến trình đang chạy, vui lòng đợi trong giây lát!");
                return;
            }
            backgroundWorker.DoWork += ExportExcel_DoWork;
            backgroundWorker.RunWorkerAsync(exportPath);
        }

        private void ExportExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            if (className == "Mọi lớp")
            {
                MessageBox.Show("Chọn lớp để xuất");
                return;
            }

            TEACHER teacher = studMin.Database.LoginServices.LoginServices.Instance.CurrentTeacher;
            CLASS @class = studMin.Database.ClassServices.Instance.GetClassByClassName(className);
            TEACH teach = studMin.Database.DataProvider.Instance.Database.TEACHes.Where(item => item.IDCLASS == @class.ID && item.IDTEACHER == teacher.ID).FirstOrDefault();

            Action.Excel.Subject.Info info = new Action.Excel.Subject.Info()
            {
                GiaoVien = teacher.INFOR.FIRSTNAME + " " + teacher.INFOR.LASTNAME,
                HocKy = Convert.ToInt32(teach.SEMESTER.NAME),
                Lop = @class.CLASSNAME,
                NamHoc = @class.SCHOOLYEAR,
                MonHoc = teach.SUBJECT.DisplayName,
            };

            List<STUDENT> students = studMin.Database.ClassServices.Instance.GetListStudentOfClass(@class.CLASSNAME);
            List<Action.Excel.Subject.Item> list = new List<Action.Excel.Subject.Item>();

            for (int index = 0; index < students.Count; index++)
            {
                //không biết vì sao để lồng vào thì lại lỗi
                //List<SCORE> scores = Database.DataProvider.Instance.Database.SCOREs.Where(item => item.IDSTUDENT == students[index].ID).ToList();
                Guid idStudent = students[index].ID;
                List<SCORE> scores = Database.DataProvider.Instance.Database.SCOREs.Where(item => item.IDSTUDENT == idStudent).ToList();

                List<double> oralMark = scores.Where(item => item.ROLESCORE.ROLE == "M").Select(score => score.SCORE1.Value).ToList();
                List<double> regularMark = scores.Where(item => item.ROLESCORE.ROLE == "15M").Select(score => score.SCORE1.Value).ToList();
                List<double> midTermMark = scores.Where(item => item.ROLESCORE.ROLE == "45M").Select(score => score.SCORE1.Value).ToList();
                double finalMark = scores.Where(item => item.ROLESCORE.ROLE == "FINAL").Select(score => score.SCORE1.Value).FirstOrDefault();

                list.Add(new Action.Excel.Subject.Item() { HoTen = students[index].INFOR.FIRSTNAME + " " + students[index].INFOR.LASTNAME, DiemMieng = oralMark, Diem15Phut = regularMark, Diem1Tiet = midTermMark, DiemCuoiKy = finalMark });
            }

            studMin.Action.Excel.Subject subject = new studMin.Action.Excel.Subject(false);

            subject.InsertInfo(info);

            foreach (Action.Excel.Subject.Item item in list)
            {
                subject.InsertItem(item);
            }

            subject.ShowExcel();

            subject.Save((string)e.Argument);

            if (MessageBox.Show("Bạn có muốn xem bảng tính lúc in?", "In Bảng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                subject.ShowPrintPreview();
            }

            subject.Dispose();
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
                List<SCORE> scores = Database.DataProvider.Instance.Database.SCOREs.Where(item => item.IDSTUDENT == student.ID).ToList();
                sCOREMBindingSource.DataSource = scores.Where(item => item.ROLESCORE.ROLE == "M").Select(score => new SCORE4GRIDVIEW(score.ID, score.SCORE1.Value)).ToList();
                sCORE15MBindingSource.DataSource = scores.Where(item => item.ROLESCORE.ROLE == "15M").Select(score => new SCORE4GRIDVIEW(score.ID, score.SCORE1.Value)).ToList();
                sCORE45MBindingSource.DataSource = scores.Where(item => item.ROLESCORE.ROLE == "45M").Select(score => new SCORE4GRIDVIEW(score.ID, score.SCORE1.Value)).ToList();
                sCOREFinalBindingSource.DataSource = scores.Where(item => item.ROLESCORE.ROLE == "FINAL").Select(score => new SCORE4GRIDVIEW(score.ID, score.SCORE1.Value)).ToList();

                ResetComboBox();
        }

        private void Class_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetComboBox();
            className = Class_ComboBox.SelectedItem.ToString();
            if (className != "Mọi lớp")
            {
                List<STUDENT> students = studMin.Database.ClassServices.Instance.GetListStudentOfClass(className);
                sTUDENTBindingSource.DataSource = students.Select(student => new STUDENT4GRIDVIEW(student.ID, student.INFOR.FIRSTNAME, student.INFOR.LASTNAME)).ToList();
            }
            else
            {
                List<string> @class = (Class_ComboBox.DataSource as List<string>);
                List<STUDENT> students = new List<STUDENT>();
                for (int index = 0; index < @class.Count; index++)
                {
                    if (@class[index] != "Mọi lớp")
                    {
                        students.AddRange(studMin.Database.ClassServices.Instance.GetListStudentOfClass(@class[index]));
                    }
                }
                sTUDENTBindingSource.DataSource = students.Select(student => new STUDENT4GRIDVIEW(student.ID, student.INFOR.FIRSTNAME, student.INFOR.LASTNAME)).ToList();
            }
        }

        private void ResetComboBox()
        {
            OralTestScore_ComboBox.SelectedIndex = 0;
            RegularTestScore_ComboBox.SelectedIndex = 0;
            MidTermTestScore_ComboBox.SelectedIndex = 0;
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

        private void OralTestScore_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = OralTestScore_ComboBox.SelectedIndex;
            if (index > 0 && index <= sCOREMBindingSource.Count)
            {
                OralTestScore_Box.Text = ((SCORE4GRIDVIEW)sCOREMBindingSource.List[index - 1]).Score.ToString();
            }
            else OralTestScore_Box.Text = string.Empty;
        }

        private void RegularTestScore_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = RegularTestScore_ComboBox.SelectedIndex;
            if (index > 0 && index <= sCORE15MBindingSource.Count)
            {
                RegularTestScore_Box.Text = ((SCORE4GRIDVIEW)sCORE15MBindingSource.List[index - 1]).Score.ToString();
            }
            else RegularTestScore_Box.Text = string.Empty;
        }

        private void MidTermTestScore_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = MidTermTestScore_ComboBox.SelectedIndex;
            if (index > 0 && index <= sCORE45MBindingSource.Count)
            {
                MidTermTestScore_Box.Text = ((SCORE4GRIDVIEW)sCORE45MBindingSource.List[index - 1]).Score.ToString();
            }
            else MidTermTestScore_Box.Text = string.Empty;
        }

        private void UpdateData_Button_Click(object sender, EventArgs e)
        {
            double score = 0.0;
            int index = -1;

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
                CLASS @class = studMin.Database.ClassServices.Instance.GetClassByClassName(className);
                TEACH teach = studMin.Database.DataProvider.Instance.Database.TEACHes.Where(item => item.IDCLASS == @class.ID && item.IDTEACHER == teacher.ID).FirstOrDefault();
                studMin.Database.StudentServices.Instance.SaveScoreToDB((sTUDENTBindingSource.Current as STUDENT4GRIDVIEW).ID, score, @class.SCHOOLYEAR, teach.SEMESTER.NAME, roleScore);
            }
        }
    }
}
