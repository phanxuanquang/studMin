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

        public GradeModify_SubTab()
        {
            this.Load += GradeModify_SubTab_Load;
            InitializeComponent();
        }

        private void GradeModify_SubTab_Load(object sender, EventArgs e)
        {
            //sTUDENTBindingSource.DataSource = Database.DataProvider.Instance.Database.STUDENTs.ToList();
            Class_ComboBox.DataSource = studMin.Database.TeacherServices.Instance.GetAllClassTeaching().Select(item => item.CLASSNAME).ToList();
        }

        void CheckValidGrade(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            double numericTest;

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
                return;
            }

            if (numericTest < 0 || numericTest > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10. \nVui lòng nhập lại điểm số.", "Điểm số nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox.Text = String.Empty;
            }
        }

        private void MidTermTestScore_Box_TextChanged(object sender, EventArgs e)
        {
            CheckValidGrade(MidTermTestScore_Box);
        }

        private void RegularTestScore_Box_TextChanged(object sender, EventArgs e)
        {
            CheckValidGrade(RegularTestScore_Box);
        }

        private void OralTestScore_Box_TextChanged(object sender, EventArgs e)
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
            /*try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataTable dt = new DataTable();

                dt.Columns.Add("Mã học sinh");
                dt.Columns.Add("Họ tên");
                dt.Columns.Add("Kiểm tra miệng");
                dt.Columns.Add("Kiểm tra 15 phút");
                dt.Columns.Add("Kiểm tra 1 tiết");
                dt.Columns.Add("Kiểm tra học kỳ");
                dt.Columns.Add("Trung bình chung");

                using (XLWorkbook workBook = new XLWorkbook(Action.Excel.StoragePath.TemplateSubject))
                {
                    int flag = 0;
                    var rows = workBook.Worksheet(1).RowsUsed();
                    foreach (var row in rows)
                    {
                        if (flag >= 4)
                        {
                            dt.Rows.Add();
                            int i = 0;
                            double oralTest = 0, fifteenMinutes = 0, fortyMinutes = 0, semesterTest = 0, overallAverage = 0;
                            int flagOralTest = 0, flagFifteenMinutes = 0;
                            foreach (IXLCell cell in row.Cells())
                            {
                                if (!cell.IsEmpty())
                                {
                                    if (i == 0 || i == 1)
                                    {
                                        dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                    }
                                    else if (i >= 2 && i <= 6)
                                    {
                                        oralTest += Double.Parse(cell.Value.ToString());
                                        flagOralTest++;
                                    }
                                    else if (i >= 7 && i <= 11)
                                    {
                                        fifteenMinutes += Double.Parse(cell.Value.ToString());
                                        flagFifteenMinutes++;
                                    }
                                    else if (i >= 12 && i <= 14)
                                    {
                                        fortyMinutes += Double.Parse(cell.Value.ToString());
                                    }
                                    else if (i == 15)
                                    {
                                        semesterTest = Double.Parse(cell.Value.ToString());
                                    }
                                    else
                                    {
                                        overallAverage = Double.Parse(cell.Value.ToString());
                                    }
                                }

                                i++;
                            }

                            dt.Rows[dt.Rows.Count - 1][2] = Math.Round((oralTest / flagOralTest), 2).ToString();
                            dt.Rows[dt.Rows.Count - 1][3] = Math.Round((fifteenMinutes / flagFifteenMinutes), 2).ToString();
                            dt.Rows[dt.Rows.Count - 1][4] = Math.Round((fortyMinutes / 3), 2).ToString();
                            dt.Rows[dt.Rows.Count - 1][5] = Math.Round(semesterTest, 2).ToString();
                            dt.Rows[dt.Rows.Count - 1][6] = Math.Round(overallAverage, 2).ToString();
                        }

                        flag++;
                    }

                    GridView.DataSource = dt.DefaultView;
                    Cursor.Current = Cursors.Default;
                }
            }
            catch
            {
                MessageBox.Show("Truy xuất dữ liệu thất bại. Tệp tin bạn chọn không đúng quy chuẩn hoặc chứa dữ liệu không hợp lệ.\nVui lòng thử lại sau.", "LỖI TRUY XUẤT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
        }

        private void ImportExcel_RunrWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //throw new NotImplementedException();
            if (!(Class_ComboBox.DataSource as List<string>).Contains(importInfo.Lop) && MessageBox.Show("đưa điểm vào csdl?", "IMPORT DATABASE", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //studMin.Database.ClassServices.Instance.CreateClass(importInfo.Lop, studMin.Database.TeacherServices.Instance.GetTeacherByName(importInfo.GiaoVien), importInfo.NamHoc, )
                List<STUDENT> students = studMin.Database.StudentServices.Instance.GetStudentByClass(Class_ComboBox.SelectedItem.ToString(), "", "");

                for(int index = 0; index < students.Count; index++)
                {
                    SCORE score = new SCORE() { ID = Guid.NewGuid(), IDSTUDENT = students[index].ID, IDSUBJECT = studMin.Database.SubjectServices.Instance.GetSubjectByName(importInfo.MonHoc).Id, IDSEMESTER = null, IDROLESCORE = null, SCHOOLYEAR = importInfo.NamHoc, SCORE1 = data[index].Diem15Phut[0] };
                    studMin.Database.DataProvider.Instance.Database.Set<SCORE>().Add(score);
                    studMin.Database.DataProvider.Instance.Database.SaveChanges();
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
            Action.Excel.Subject.Info info = new Action.Excel.Subject.Info()
            {
                GiaoVien = "Nguyễn Ngân Hà",
                HocKy = 1,
                Lop = "10A2",
                NamHoc = "2022 - 2023",
                MonHoc = "Toán",
            };

            List<Action.Excel.Subject.Item> list = new List<Action.Excel.Subject.Item>()
            {
                new studMin.Action.Excel.Subject.Item()
                {
                    HoTen = "Nguyễn Văn Tèo",
                    Diem15Phut = new List<double>() { 5, 5.3, 6.7, 8.7 },
                    Diem1Tiet = new List<double>() { 7, 9 },
                    DiemCuoiKy = 8.5,
                    DiemMieng = new List<double>() { 9, 8 }
                },
                new studMin.Action.Excel.Subject.Item()
                {
                    HoTen = "Trần Xuân Tài",
                    Diem15Phut = new List<double>() { 5, 5.3, 6.7, 8.7 },
                    Diem1Tiet = new List<double>() { 7, 6 },
                    DiemCuoiKy = 8.5,
                    DiemMieng = new List<double>() { 9, 8 }
                },
                new studMin.Action.Excel.Subject.Item()
                {
                    HoTen = "Ngô Xuân Yến",
                    Diem15Phut = new List<double>() { 5, 5.3, 6.7, 8.7 },
                    Diem1Tiet = new List<double>() { 7, 7 },
                    DiemCuoiKy = 8.5,
                    DiemMieng = new List<double>() { 9, 8 }
                },
                new studMin.Action.Excel.Subject.Item()
                {
                    HoTen = "Trần Thị Thanh Hiền",
                    Diem15Phut = new List<double>() { 5, 5.3, 6.7, 8.7 },
                    Diem1Tiet = new List<double>() { 7, 8 },
                    DiemCuoiKy = 8,
                    DiemMieng = new List<double>() { 8, 8 }
                },
                new studMin.Action.Excel.Subject.Item()
                {
                    HoTen = "Phạm Nguyễn Vi Trân",
                    Diem15Phut = new List<double>() { 5, 5.3, 6.7, 8.7 },
                    Diem1Tiet = new List<double>() { 7, 9 },
                    DiemCuoiKy = 8.5,
                    DiemMieng = new List<double>() { 9, 8 }
                },
                new studMin.Action.Excel.Subject.Item()
                {
                    HoTen = "Đỗ Minh Thanh",
                    Diem15Phut = new List<double>() { 5, 5.3, 6.7, 8.7 },
                    Diem1Tiet = new List<double>() { 7, 9 },
                    DiemCuoiKy = 10,
                    DiemMieng = new List<double>() { 9, 8 }
                }
            };

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
            mDataGridView.Rows.Clear();
            m15DataGridView.Rows.Clear();
            m45DataGridView.Rows.Clear();
            finalDataGridView.Rows.Clear();
            if (e.RowIndex > 0)
            {
                STUDENT4GRIDVIEW student = sTUDENTBindingSource.Current as STUDENT4GRIDVIEW;
                List<SCORE> scores = Database.DataProvider.Instance.Database.SCOREs.Where(item => item.IDSTUDENT == student.ID).ToList();
                sCOREMBindingSource.DataSource = scores/*.Where(item => item.ROLESCORE.ROLE == "M")*/.Select(score => new SCORE4GRIDVIEW(score.ID, score.SCORE1.Value)).ToList();
                /*sCORE15MBindingSource.DataSource = scores.Where(item => item.ROLESCORE.ROLE == "15M").Select(score => new SCORE4GRIDVIEW(score.ID, score.SCORE1.Value)).ToList();
                sCORE45MBindingSource.DataSource = scores.Where(item => item.ROLESCORE.ROLE == "45M").Select(score => new SCORE4GRIDVIEW(score.ID, score.SCORE1.Value)).ToList();
                sCOREFinalBindingSource.DataSource = scores.Where(item => item.ROLESCORE.ROLE == "FINAL").Select(score => new SCORE4GRIDVIEW(score.ID, score.SCORE1.Value)).ToList();*/
            }
        }

        private void Class_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string className = Class_ComboBox.SelectedItem.ToString();
            List<STUDENT> students = studMin.Database.StudentServices.Instance.GetStudentByClass(className, "", "");
            sTUDENTBindingSource.DataSource = students.Select(student => new STUDENT4GRIDVIEW(student.ID, student.INFOR.FIRSTNAME, student.INFOR.LASTNAME)).ToList();
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
    }
}
