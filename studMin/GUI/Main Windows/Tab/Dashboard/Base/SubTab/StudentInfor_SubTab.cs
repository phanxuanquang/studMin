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

    public partial class StudentInfor_SubTab : UserControl
    {
        private BackgroundWorker backgroundWorker = null;
        private GUI.LoadingWindow loadingWindow = null;
        public StudentInfor_SubTab()
        {
            InitializeComponent();
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
        }

        private void LoadFromDB_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = (LoginServices.Instance.CurrentTeacher.TEACHes.Select(item => item.CLASS.CLASSNAME).ToArray(), Database.DataProvider.Instance.Database.CLASSes.Select(item => item.SCHOOLYEAR).Distinct().ToArray());
        }

        private void LoadFromDB_RunrWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            (string[], string[]) results = ((string[], string[]))(e.Result);
            Class_ComboBox.Items.AddRange(results.Item1);
            SchoolYear_ComboBox.Items.AddRange(results.Item2);

            Class_ComboBox.SelectedIndex = 0;
            SchoolYear_ComboBox.SelectedIndex = 0;
            BindingStudent(GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
            //LoadToDataTable(GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
            loadingWindow.Close();
        }

        private List<STUDENT> GetListStudent(string className, string schoolYear)
        {
            List<STUDENT> students = new List<STUDENT>();
            if (className == "Mọi lớp")
            {
                if (schoolYear == "Mọi niên khóa")
                {
                    var allClass = Database.DataProvider.Instance.Database.CLASSes.ToList();
                    foreach (var aClass in allClass)
                    {
                        var listStudent = Database.ClassServices.Instance.GetListStudentOfClass(aClass.CLASSNAME);
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
                        var listStudent = Database.ClassServices.Instance.GetListStudentOfClass(aClass.CLASSNAME);
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
                    var allClass = Database.DataProvider.Instance.Database.CLASSes.Where(item => item.CLASSNAME == Class_ComboBox.SelectedItem.ToString());
                    foreach (var aClass in allClass)
                    {
                        var listStudent = Database.ClassServices.Instance.GetListStudentOfClass(aClass.CLASSNAME);
                        foreach (var student in listStudent)
                        {
                            //DataTable.Rows.Add(student.CLASS.SCHOOLYEAR, student.ID.ToString().Substring(0, 7).ToUpper(), student.CLASS.CLASSNAME, student.INFOR.FIRSTNAME + " " + student.INFOR.LASTNAME, student.Status);
                            students.Add(student);
                        }
                    }
                }
                else
                {
                    
                    var allClass = Database.DataProvider.Instance.Database.CLASSes.Where(item =>item.CLASSNAME == Class_ComboBox.SelectedItem.ToString() && item.SCHOOLYEAR == schoolYear).ToList();
                    foreach (var aClass in allClass)
                    {
                        var listStudent = Database.ClassServices.Instance.GetListStudentOfClass(aClass.CLASSNAME);
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

        public void BindingStudent(List<STUDENT> sTUDENTs)
        {
            sTUDENTBindingSource.ResetBindings(true);
            sTUDENTBindingSource.DataSource = sTUDENTs;
            foreach (DataGridViewRow row in DataTable.Rows)
            {
                STUDENT selected = row.DataBoundItem as STUDENT;
                if (selected != null)
                {
                    row.Cells["SchoolYear"].Value = selected.CLASS.SCHOOLYEAR;
                    row.Cells["Id"].Value = selected.ID.ToString().Substring(0, 8).ToUpper();
                    row.Cells["Class"].Value = selected.CLASS.CLASSNAME;
                    row.Cells["FullName"].Value = selected.INFOR.FIRSTNAME + " " + selected.INFOR.LASTNAME;
                    row.Cells["Status"].Value = selected.Status == 1 ? "Đang học" : "Đã nghỉ học";
                }
            }
        }

        //public void LoadToDataTable(List<STUDENT> students)
        //{
        //    foreach (var student in students)
        //    {
        //        string newStudentStatus = String.Empty;
        //        if (student.Status.ToString() == "1")
        //        {
        //            newStudentStatus = "Đang học";
        //        }
        //        else
        //        {
        //            newStudentStatus = "Đã nghỉ học";
        //        }
        //        DataTable.Rows.Add(student.CLASS.SCHOOLYEAR, student.ID, student.CLASS.CLASSNAME, student.INFOR.FIRSTNAME + " " + student.INFOR.LASTNAME, newStudentStatus);
        //    }
        //}

        private void Search_Button_Click(object sender, EventArgs e)
        {
            DataTable.Rows.Clear();
            if (string.IsNullOrWhiteSpace(Search_Box.Text))
            {
                BindingStudent(GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
                //LoadToDataTable(GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
            }    
            else
            {
                var students = GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()).Where(item => (item.INFOR.FIRSTNAME + " " + item.INFOR.LASTNAME).ToLower().Contains(Search_Box.Text.ToLower()) || (item.ID.ToString().ToLower().Contains(Search_Box.Text.ToLower()))).ToList();
                BindingStudent(GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
                //LoadToDataTable(students);
            }    
        }

        private void BindStudentToTextBox(STUDENT student)
        {
            ID_Box.Text = student.ID.ToString().Substring(0,8).ToUpper();
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
            STUDENT studentCurrent;
            if (DataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                studentCurrent = sTUDENTBindingSource.Current as STUDENT;
                if (studentCurrent != null)
                {
                    BindStudentToTextBox(studentCurrent);
                }
            }
        }

        private void Search_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable.Rows.Clear();
                if (string.IsNullOrWhiteSpace(Search_Box.Text))
                {
                    //LoadToDataTable(GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
                    BindingStudent(GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
                }
                else
                {
                    var students = GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()).Where(item => (item.INFOR.FIRSTNAME + " " + item.INFOR.LASTNAME).ToLower().Contains(Search_Box.Text.ToLower()) || (item.ID.ToString().ToLower().Contains(Search_Box.Text.ToLower()))).ToList();
                    BindingStudent(GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
                    //LoadToDataTable(students);
                }
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                Search_Box.Text = String.Empty;
            }
        }
    }
}
