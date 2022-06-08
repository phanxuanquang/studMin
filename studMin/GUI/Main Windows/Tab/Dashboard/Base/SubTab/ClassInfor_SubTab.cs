using studMin.Database;
using studMin.Database.Models;
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
    public partial class ClassInfor_SubTab : UserControl
    {
        List<CLASS> listClasses;

        public ClassInfor_SubTab()
        {
            InitializeComponent();
        }

        void DataExport_toExcel()
        {
            if (DataTable_Info.Rows.Count == 0)
            {
                LoadSearchingInfor();
            }

            if (DataTable_Info.Rows.Count > 0 && DataTable_Info.Columns[0].HeaderCell.Value.ToString() != "Mã học sinh")
            {
                MessageBox.Show("Bạn chỉ có thể in Danh sách học sinh.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string className = Class_ComboBox.SelectedItem.ToString();
            string schoolYear = SchoolYear_ComboBox.SelectedItem.ToString();
            CLASS currentClass = ClassServices.Instance.GetClassByClassNameAndSchoolYear(className, schoolYear);
            List<STUDENT> listStudents = ClassServices.Instance.GetListStudentOfClass(className, schoolYear);

            if (currentClass == null || listStudents.Count == 0)
            {
                string formatedYear = schoolYear.ToString() + " - " + (int.Parse(schoolYear) + 1);
                MessageBox.Show("Hiện tại lớp mà bạn chọn trong năm học " + formatedYear + " chưa có dữ liệu, vui lòng thử lại sau", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            

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

            List<Action.Excel.ListStudent.Item> list = new List<Action.Excel.ListStudent.Item>();

            foreach (var student in listStudents)
            {
                Action.Excel.ListStudent.Item temp = new studMin.Action.Excel.ListStudent.Item()
                {
                    MaHocSinh = student.ID.ToString(),
                    HoTen = student.INFOR.FIRSTNAME + " " + student.INFOR.LASTNAME,
                    NgaySinh = (DateTime)student.INFOR.DAYOFBIRTH,
                    GioiTinh = student.INFOR.SEX == 1,
                    DanToc = student.BLOODLINE,
                    DiaChi = student.INFOR.ADDRESS,
                    Email = student.EMAIL,
                    SDT = student.TEL
                };
                list.Add(temp);
            }

            INFOR inforTeacher = currentClass.TEACHER.INFOR;

            Action.Excel.ListStudent.Info info = new Action.Excel.ListStudent.Info()
            {
                Lop = Class_ComboBox.SelectedItem.ToString(),
                GiaoVien = inforTeacher.FIRSTNAME + " " + inforTeacher.LASTNAME,
                NamHoc = SchoolYear_ComboBox.SelectedItem.ToString(),
                SiSo = listStudents.Count,
                ThongTinThem = "Danh sách lớp " + className
            };

            Action.Excel.ListStudent students = new Action.Excel.ListStudent();

            students.InsertInfo(info);
            foreach (Action.Excel.ListStudent.Item item in list)
            {
                students.InsertItem(item);
            }

            students.ShowExcel();
            students.Save(exportPath);
        }

        /*private void ClassInfor_SubTab_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((System.Action)(() =>
            {

                List<CLASS> listClasses = ClassServices.Instance.GetClasss();

                List<string> ListClass = new List<string>();
                List<string> ListSchoolYear = new List<string>();

                for (int index = 0; index < listClasses.Count; index++)
                {
                    if (!ListClass.Contains(listClasses[index].CLASSNAME))
                    {
                        ListClass.Add(listClasses[index].CLASSNAME);
                    }

                    if (!ListSchoolYear.Contains(listClasses[index].SCHOOLYEAR))
                    {
                        ListSchoolYear.Add(listClasses[index].SCHOOLYEAR);
                    }
                }

                Class_ComboBox.DataSource = ListClass;
                SchoolYear_ComboBox.DataSource = ListSchoolYear;
            }));
        }*/

        #region Buttons
        private void Search_Button_Click(object sender, EventArgs e)
        {
            LoadSearchingInfor();
        }

        private void LoadSearchingInfor()
        {
            DataTable_Info.Columns.Clear();
            DataTable_Info.Rows.Clear();

            switch (Filter_ComboBox.SelectedIndex)
            {
                case 0:
                    GetListClasses(listClasses);
                    break;
                case 1:
                    if (Class_ComboBox.SelectedIndex == 0)
                    {
                        MessageBox.Show("Vui lòng chọn lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (SchoolYear_ComboBox.SelectedIndex == 0)
                    {
                        MessageBox.Show("Vui lòng chọn năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    GetListStudents();
                    break;
                case 2:
                    if (Class_ComboBox.SelectedIndex == 0 && SchoolYear_ComboBox.SelectedIndex == 0)
                    {
                        GetTeachersByClassesBySchoolYear(listClasses, false, false);
                        return;
                    }

                    if (Class_ComboBox.SelectedIndex == 0 && SchoolYear_ComboBox.SelectedIndex != 0)
                    {
                        GetTeachersByClassesBySchoolYear(listClasses, false, true);
                        return;
                    }

                    if (Class_ComboBox.SelectedIndex != 0 && SchoolYear_ComboBox.SelectedIndex == 0)
                    {
                        GetTeachersByClassesBySchoolYear(listClasses, true, false);
                        return;
                    }

                    if (Class_ComboBox.SelectedIndex != 0 && SchoolYear_ComboBox.SelectedIndex != 0)
                    {
                        GetTeachersByClassesBySchoolYear(listClasses, true, true);
                        return;
                    }
                    break;
            }
        }

        private void GetTeachersByClassesBySchoolYear(List<CLASS> listClasses, bool filterByClass, bool filterBySchoolYear)
        {
            DataTable_Info.Columns.Add("Column1", "Mã định danh");
            DataTable_Info.Columns.Add("Column2", "Họ và tên");
            DataTable_Info.Columns.Add("Column3", "Lớp phụ trách");
            DataTable_Info.Columns.Add("Column4", "Năm học");
            DataTable_Info.Columns.Add("Column5", "Giới tính");
            DataTable_Info.Columns.Add("Column6", "Ngày sinh");
            DataTable_Info.Columns.Add("Column7", "Địa chỉ");

            foreach (var classItem in listClasses)
            {
                if (classItem.TEACHER == null || classItem.TEACHER.USER.ISDELETED == true)
                {
                    continue;
                }

                INFOR inforTeacher = classItem.TEACHER.INFOR;
                string id = classItem.TEACHER.ID.ToString().Substring(0, 8).ToUpper();
                string teacherName = inforTeacher.FIRSTNAME + " " + inforTeacher.LASTNAME;
                string className = classItem.CLASSNAME;
                string schoolYear = classItem.SCHOOLYEAR;
                string sex = inforTeacher.SEX == 0 ? "Nam" : "Nữ";
                string dayOfBirth = String.Format("{0:dd/MM/yyyy}", inforTeacher.DAYOFBIRTH);
                string address = inforTeacher.ADDRESS;

                if (!filterByClass && filterBySchoolYear)
                {
                    if (classItem.SCHOOLYEAR == SchoolYear_ComboBox.SelectedItem.ToString())
                    {
                        DataTable_Info.Rows.Add(id, teacherName, className, schoolYear, sex, dayOfBirth, address);
                    }
                }
                else if (!filterByClass && !filterBySchoolYear)
                {
                    DataTable_Info.Rows.Add(id, teacherName, className, schoolYear, sex, dayOfBirth, address);
                }
                else if (filterByClass && !filterBySchoolYear)
                {
                    if (classItem.CLASSNAME == Class_ComboBox.SelectedItem.ToString())
                    {
                        DataTable_Info.Rows.Add(id, teacherName, className, schoolYear, sex, dayOfBirth, address);
                    }
                }
                else if (filterByClass && filterBySchoolYear)
                {
                    if (classItem.CLASSNAME == Class_ComboBox.SelectedItem.ToString() && classItem.SCHOOLYEAR == SchoolYear_ComboBox.SelectedItem.ToString())
                    {
                        DataTable_Info.Rows.Add(id, teacherName, className, schoolYear, sex, dayOfBirth, address);
                    }
                }
            }
        }

        private void GetListClasses(List<CLASS> listClasses)
        {
            DataTable_Info.Columns.Add("Column1", "Mã lớp");
            DataTable_Info.Columns.Add("Column2", "Tên lớp");
            DataTable_Info.Columns.Add("Column3", "Năm học");
            DataTable_Info.Columns.Add("Column4", "Sỉ số");
            DataTable_Info.Columns.Add("Column5", "Khối");
            DataTable_Info.Columns.Add("Column6", "Chủ nhiệm");

            foreach (var classItem in listClasses)
            {
                string id = classItem.ID.ToString().Substring(0, 8).ToUpper();
                string className = classItem.CLASSNAME;
                string schoolYear = classItem.SCHOOLYEAR;
                int quantityOfClass = classItem.STUDYINGs.Where(item => item.IDCLASS == classItem.ID).Distinct().ToList().Count() / 2;
                string grade = classItem.GRADE.NAME;
                string teacherName = classItem.TEACHER.INFOR.FIRSTNAME + " " + classItem.TEACHER.INFOR.LASTNAME;

                if (SchoolYear_ComboBox.SelectedIndex != 0)
                {
                    if (classItem.SCHOOLYEAR == SchoolYear_ComboBox.SelectedItem.ToString())
                    {
                        DataTable_Info.Rows.Add(id, className, schoolYear, quantityOfClass, grade, teacherName);
                    }
                }
                else
                {
                    DataTable_Info.Rows.Add(id, className, schoolYear, quantityOfClass, grade, teacherName);
                }
            }

            Class_ComboBox.SelectedIndex = 0;
        }

        private void GetListStudents()
        {
            DataTable_Info.Columns.Add("Column1", "Mã học sinh");
            DataTable_Info.Columns.Add("Column2", "Họ và tên");
            DataTable_Info.Columns.Add("Column3", "Giới tính");
            DataTable_Info.Columns.Add("Column4", "Ngày sinh");
            DataTable_Info.Columns.Add("Column5", "Địa chỉ");
            DataTable_Info.Columns.Add("Column6", "Số điện thoại");
            DataTable_Info.Columns.Add("Column7", "E-mail");

            string className = Class_ComboBox.SelectedItem.ToString();
            string schoolYear = SchoolYear_ComboBox.SelectedItem.ToString();

            CLASS tempClass = ClassServices.Instance.GetClassByClassNameAndSchoolYear(className, schoolYear == null ? ClassServices.Instance.GetCurrentSchoolYear() : schoolYear);
            if (tempClass == null) return;

            List<STUDYING> listStudying = tempClass.STUDYINGs.ToList();

            List<STUDENT> listStudents = new List<STUDENT>();
            foreach (STUDYING studying in listStudying)
            {
                STUDENT student = DataProvider.Instance.Database.STUDENTs.Where(x => x.ID == studying.IDSTUDENT).FirstOrDefault();
                if (!listStudents.Contains(student))
                {
                    listStudents.Add(student);
                    string sex = student.INFOR.SEX == 0 ? "Nam" : "Nữ";
                    string dayOfBirth = String.Format("{0:dd/MM/yyyy}", student.INFOR.DAYOFBIRTH);
                    DataTable_Info.Rows.Add(student.ID.ToString().Substring(0, 8).ToUpper(), student.INFOR.FIRSTNAME + " " + student.INFOR.LASTNAME, sex, dayOfBirth, student.INFOR.ADDRESS, student.TEL, student.EMAIL);
                }
            }
        }

        private void DataGridViewExport_Button_Click(object sender, EventArgs e)
        {
            /*try
            {
                DataExport_toExcel();
            }
            catch
            {
                MessageBox.Show("Xuất dữ liệu không thành công.", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/

            DataExport_toExcel();
        }
        #endregion

        private void ClassInfor_SubTab_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((System.Action)(() =>
            {

                listClasses = ClassServices.Instance.GetClasss();

                List<string> ListClass = new List<string>();
                List<string> ListSchoolYear = new List<string>();

                for (int index = 0; index < listClasses.Count; index++)
                {
                    if (!ListClass.Contains(listClasses[index].CLASSNAME))
                    {
                        ListClass.Add(listClasses[index].CLASSNAME);
                        Class_ComboBox.Items.Add(listClasses[index].CLASSNAME);
                    }

                    if (!ListSchoolYear.Contains(listClasses[index].SCHOOLYEAR))
                    {
                        ListSchoolYear.Add(listClasses[index].SCHOOLYEAR);
                        SchoolYear_ComboBox.Items.Add(listClasses[index].SCHOOLYEAR);
                    }
                }

            }));
        }
    }
}
