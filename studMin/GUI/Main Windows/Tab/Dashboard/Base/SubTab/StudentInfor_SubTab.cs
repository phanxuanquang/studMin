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
        public StudentInfor_SubTab()
        {
            
            this.Load += StudentInfor_SubTab_Load;
            InitializeComponent();
        }

        private void StudentInfor_SubTab_Load(object sender, EventArgs e)
        {
            LoadFromDB();
            Class_ComboBox.SelectedIndex = 0;
            SchoolYear_ComboBox.SelectedIndex = 0;
            LoadToDataTable(GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
        }

        private void LoadFromDB()
        {
            var teach = LoginServices.Instance.CurrentTeacher.TEACHes.ToList();
            foreach (var item in teach)
            {
                Class_ComboBox.Items.Add(item.CLASS.CLASSNAME);
            }
            var years = Database.DataProvider.Instance.Database.CLASSes.Select(item => item.SCHOOLYEAR).Distinct().ToList();
            foreach (var year in years)
            {
                SchoolYear_ComboBox.Items.Add(year.ToString());
            }    
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
                            //DataTable.Rows.Add(student.CLASS.SCHOOLYEAR, student.ID, student.CLASS.CLASSNAME, student.FIRSTNAME + " " + student.LASTNAME, student.Status);
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
                            //DataTable.Rows.Add(student.CLASS.SCHOOLYEAR, student.ID, student.CLASS.CLASSNAME, student.FIRSTNAME + " " + student.LASTNAME, student.Status);
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
                            //DataTable.Rows.Add(student.CLASS.SCHOOLYEAR, student.ID, student.CLASS.CLASSNAME, student.FIRSTNAME + " " + student.LASTNAME, student.Status);
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

        public void LoadToDataTable(List<STUDENT> students)
        {
            foreach (var student in students)
            {
                string newStudentID = student.ID.ToString().Substring(0, 8).ToUpper();
                string newStudentStatus = String.Empty;
                if (student.Status.ToString() == "1")
                {
                    newStudentStatus = "Đang học";
                }
                else
                {
                    newStudentStatus = "Đã nghỉ học";
                }
                DataTable.Rows.Add(student.CLASS.SCHOOLYEAR, newStudentID, student.CLASS.CLASSNAME, student.INFOR.FIRSTNAME + " " + student.INFOR.LASTNAME, newStudentStatus);
            }
        }

        

        private void Search_Button_Click(object sender, EventArgs e)
        {
            DataTable.Rows.Clear();
            if (string.IsNullOrWhiteSpace(Search_Box.Text))
            {
                LoadToDataTable(GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()));
            }    
            else
            {
                var students = GetListStudent(Class_ComboBox.SelectedItem.ToString(), SchoolYear_ComboBox.SelectedItem.ToString()).Where(item => (item.INFOR.FIRSTNAME + " " + item.INFOR.LASTNAME).Contains(Search_Box.Text) || (item.ID.ToString().Contains(Search_Box.Text))).ToList();
                LoadToDataTable(students);
            }    
        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
