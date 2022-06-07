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
    using studMin.Database.LoginServices;
    using studMin.Database.Models;
    public partial class StudentInforTab_Staff : UserControl
    {
        private BackgroundWorker backgroundWorker = null;
        private GUI.LoadingWindow loadingWindow = null;
        public StudentInforTab_Staff()
        {
            this.Load += StudentInfor_SubTab_Load;
            InitializeComponent();
        }

        private void AddStudent_Button_Click(object sender, EventArgs e)
        {
            AddStudent_Form addStudent_Form = new AddStudent_Form(this);
            addStudent_Form.ShowDialog();
            this.Refresh();
        }

        private void StudentInfor_SubTab_Load(object sender, EventArgs e)
        {
            loadingWindow = new GUI.LoadingWindow(this.ParentForm, "ĐANG TẢI DỮ LIỆU");

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
            backgroundWorker.DoWork += LoadFromDB_DoWork;
            backgroundWorker.RunWorkerCompleted += LoadFromDB_RunrWorkerCompleted;
            backgroundWorker.RunWorkerAsync();
            loadingWindow.ShowDialog();
            //LoadFromDB();
            //Class_ComboBox.SelectedIndex = 0;
            //SchoolYear_ComboBox.SelectedIndex = 0;
            //LoadToDataTable(GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
        }

        private void LoadFromDB_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = (Database.ClassServices.Instance.GetClasss().Select(item => item.CLASSNAME).Distinct().ToArray(), Database.DataProvider.Instance.Database.CLASSes.Select(item => item.SCHOOLYEAR).Distinct().ToArray());
        }

        private void LoadFromDB_RunrWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            (string[], string[]) results = ((string[], string[]))(e.Result);
            Class_ComboBox.Items.AddRange(results.Item1);
            SchoolYear_ComboBox.Items.AddRange(results.Item2);

            Class_ComboBox.SelectedIndex = 0;
            SchoolYear_ComboBox.SelectedIndex = 0;
            BindingStudent(GetListStudying(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
            //LoadToDataTable(GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
            loadingWindow.Close();
        }

        //private void LoadFromDB()
        //{
        //    var teach = Database.DataProvider.Instance.Database.TEACHes;
        //    var className = teach.Select(item => item.CLASS.CLASSNAME).Distinct();
        //    foreach (var item in className)
        //    {
        //        Class_ComboBox.Items.Add(item);
        //    }
        //    var years = Database.DataProvider.Instance.Database.CLASSes.Select(item => item.SCHOOLYEAR).Distinct().ToList();
        //    foreach (var year in years)
        //    {
        //        SchoolYear_ComboBox.Items.Add(year.ToString());
        //    }
        //}

        public void BindingStudent(List<STUDYING> sTUDENTs)
        {
            sTUDYINGBindingSource.ResetBindings(false);
            sTUDYINGBindingSource.DataSource = sTUDENTs;
            foreach (DataGridViewRow row in DataTable.Rows)
            {
                STUDYING selected = row.DataBoundItem as STUDYING;
                if (selected != null)
                {
                    row.Cells["SchoolYear"].Value = selected.CLASS.SCHOOLYEAR;
                    row.Cells["Class"].Value = selected.CLASS.CLASSNAME;

                    row.Cells["Id"].Value = selected.IDSTUDENT.ToString().Substring(0, 8).ToUpper();
                    row.Cells["FullName"].Value = selected.STUDENT.INFOR.FIRSTNAME + " " + selected.STUDENT.INFOR.LASTNAME;
                    row.Cells["Status"].Value = selected.STUDENT.Status == 1 ? "Đang học" : "Đã nghỉ học";
                }
            }
        }

        private List<STUDYING> GetListStudying(string className, string schoolYear)
        {
            List<STUDYING> students = new List<STUDYING>();
            if (className == "Mọi lớp")
            {
                if (schoolYear == "Mọi niên khóa")
                {
                    var allClass = Database.DataProvider.Instance.Database.CLASSes.ToList();
                    foreach (var aClass in allClass)
                    {
                        var listStudent = Database.ClassServices.Instance.GetListStudyingOfClass(aClass.CLASSNAME, aClass.SCHOOLYEAR);
                        foreach (var student in listStudent)
                        {
                            //DataTable.Rows.Add(student.CLASS.SCHOOLYEAR, student.ID.ToString().Substring(0, 7).ToUpper(), student.CLASS.CLASSNAME, student.INFOR.FIRSTNAME + " " + student.INFOR.LASTNAME, student.Status);
                            students.Add(student);
                        }
                    }
                }
                else
                {

                    var allClass = Database.DataProvider.Instance.Database.CLASSes.Where(item => item.SCHOOLYEAR == schoolYear).ToList();
                    foreach (var aClass in allClass)
                    {
                        var listStudent = Database.ClassServices.Instance.GetListStudyingOfClass(aClass.CLASSNAME, aClass.SCHOOLYEAR);
                        foreach (var student in listStudent)
                        {
                            //DataTable.Rows.Add(student.CLASS.SCHOOLYEAR, student.ID.ToString().Substring(0, 7).ToUpper(), student.CLASS.CLASSNAME, student.INFOR.FIRSTNAME + " " + student.INFOR.LASTNAME, student.Status);
                            students.Add(student);
                        }
                    }
                }
            }
            else
            {
                if (schoolYear == "Mọi niên khóa")
                {
                    var allClass = Database.DataProvider.Instance.Database.CLASSes.Where(item => item.CLASSNAME == Class_ComboBox.SelectedItem.ToString()).ToList();
                    foreach (var aClass in allClass)
                    {
                        var listStudent = Database.ClassServices.Instance.GetListStudyingOfClass(aClass.CLASSNAME, aClass.SCHOOLYEAR);
                        foreach (var student in listStudent)
                        {
                            //DataTable.Rows.Add(student.CLASS.SCHOOLYEAR, student.ID.ToString().Substring(0, 7).ToUpper(), student.CLASS.CLASSNAME, student.INFOR.FIRSTNAME + " " + student.INFOR.LASTNAME, student.Status);
                            students.Add(student);
                        }
                    }
                }
                else
                {

                    //var allClass = Database.ClassServices.Instance.GetClassByClassNameAndSchoolYear(className,schoolYear);

                    {
                        var listStudent = Database.ClassServices.Instance.GetListStudyingOfClass(className, schoolYear);
                        foreach (var student in listStudent)
                        {
                            //DataTable.Rows.Add(student.CLASS.SCHOOLYEAR, student.ID, student.CLASS.CLASSNAME, student.FIRSTNAME + " " + student.LASTNAME, student.Status);
                            students.Add(student);
                        }
                    }
                }
            }
            return students;
        }

        //public void LoadToDataTable(List<STUDENT> students)
        //{
        //    DataTable.Rows.Clear();

        //    foreach (var student in students)
        //    {
        //        string newStudentID = student.ID.ToString().Substring(0, 8).ToUpper();
        //        string newStudentStatus = String.Empty;
        //        if (student.Status.ToString() == "1")
        //        {
        //            newStudentStatus = "Đang học";
        //        }
        //        else
        //        {
        //            newStudentStatus = "Đã nghỉ học";
        //        }
        //        DataTable.Rows.Add(student.CLASS.SCHOOLYEAR, newStudentID, student.CLASS.CLASSNAME, student.INFOR.FIRSTNAME + " " + student.INFOR.LASTNAME, newStudentStatus);
        //    }
        //}

        private void Search_Button_Click(object sender, EventArgs e)
        {
            DataTable.Rows.Clear();
            if (string.IsNullOrWhiteSpace(Search_Box.Text))
            {
                BindingStudent(GetListStudying(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
                //LoadToDataTable(GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
            }
            else
            {
                var students = GetListStudying(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()).Where(item => (item.STUDENT.INFOR.FIRSTNAME + " " + item.STUDENT.INFOR.LASTNAME).ToLower().Contains(Search_Box.Text.ToLower()) || (item.STUDENT.ID.ToString().ToLower().Contains(Search_Box.Text.ToLower()))).ToList();
                BindingStudent(GetListStudying(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
                //LoadToDataTable(students);
            }
        }

        private void BindStudentToTextBox(STUDENT student)
        {
            ID_Box.Text = student.ID.ToString().Substring(0, 7).ToUpper();
            FullName_Box.Text = student.INFOR.FIRSTNAME + " " + student.INFOR.LASTNAME;
            SchoolYear_Box.Text = student.CLASS.SCHOOLYEAR;
            Class_Box.Text = student.CLASS.CLASSNAME;
            Genre_Box.Text = student.INFOR.SEX == 0 ? "Nam" : "Nữ";
            Bloodline_Box.Text = student.BLOODLINE;
            Email_Box.Text = student.EMAIL;
            Address_Box.Text = student.INFOR.ADDRESS;
            ParentNumber_Box.Text = student.EMAILPARENT;
        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            STUDYING studentCurrent;
            if (e.RowIndex < 0) return;
            if (DataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                studentCurrent = sTUDYINGBindingSource.Current as STUDYING;
                if (studentCurrent != null)
                {
                    BindStudentToTextBox(studentCurrent.STUDENT);
                }
            }
        }

        private void Search_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Search_Box.Text = String.Empty;
            }
            try
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[DataTable.DataSource];
                cm.SuspendBinding();

                for (int i = 0; i < DataTable.RowCount; i++)
                {
                    if (DataTable.Rows[i].Cells[1].Value != null &&
                        DataTable.Rows[i].Cells[3].Value != null)
                    {
                        if (DataTable.Rows[i].Cells[1].Value.ToString().ToLower().Contains(Search_Box.Text.ToLower()) || DataTable.Rows[i].Cells[3].Value.ToString().ToLower().Contains(Search_Box.Text.ToLower()))
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

        private void DataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentInforModify_Form studentInforModify_Form = new StudentInforModify_Form(sTUDYINGBindingSource.Current);
            studentInforModify_Form.ShowDialog();
            BindingStudent(GetListStudying(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
        }
    }
}
