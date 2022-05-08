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

        public ClassInfor_SubTab()
        {
            InitializeComponent();
        }

        void DataExport_toExcel()
        {
            if (Filter_ComboBox.SelectedIndex != 1)
            {
                MessageBox.Show("Bạn chỉ có thể in Danh sách học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Semester_ComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string className = Class_ComboBox.SelectedItem.ToString();
            string schoolYear = SchoolYear_ComboBox.SelectedItem.ToString();
            CLASS currentClass = ClassServices.Instance.GetClassByClassNameAndSchoolYear(className, schoolYear);

            if (currentClass == null)
            {
                string formatedYear = schoolYear.ToString() + " - " + (int.Parse(schoolYear) + 1);
                MessageBox.Show("Hiện tại lớp mà bạn chọn trong năm học " + formatedYear + " chưa có dữ liệu, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            
            List<STUDENT> listStudents = ClassServices.Instance.GetListStudentOfClass(className);

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
            string startYear = currentClass.SCHOOLYEAR;

            Action.Excel.ListStudent.Info info = new Action.Excel.ListStudent.Info()
            {
                Lop = Class_ComboBox.SelectedItem.ToString(),
                GiaoVien = inforTeacher.FIRSTNAME + " " + inforTeacher.LASTNAME,
                NamHoc = SchoolYear_ComboBox.SelectedItem.ToString(),
                HocKy = Semester_ComboBox.SelectedIndex == 1 ? 0 : 1,
                SiSo = listStudents.Count,
                ThongTinThem = "Danh sách lớp"
            };

            studMin.Action.Excel.ListStudent students = new studMin.Action.Excel.ListStudent();

            students.InsertInfo(info);
            foreach (Action.Excel.ListStudent.Item item in list)
            {
                students.InsertItem(item);
            }

            students.ShowExcel();
            students.Save(exportPath);
        }

        #region Buttons
        private void Search_Button_Click(object sender, EventArgs e)
        {
            DataTable_Info.Columns.Clear();
            try
            {
                DataTable dataSource = new DataTable();
                List<CLASS> listClasses = Database.ClassServices.Instance.GetClasss();

                switch (Filter_ComboBox.SelectedIndex)
                {
                    case 0:
                        dataSource.Columns.Add("Mã lớp");
                        dataSource.Columns.Add("Tên lớp");
                        dataSource.Columns.Add("Khối");
                        dataSource.Columns.Add("Giáo viên");
                        dataSource.Columns.Add("Năm học");
                        
                        foreach (var classItem in listClasses)
                        {
                            dataSource.Rows.Add(classItem.ID, classItem.CLASSNAME, classItem.GRADE.NAME, classItem.TEACHER.INFOR.FIRSTNAME + " " + classItem.TEACHER.INFOR.LASTNAME, classItem.SCHOOLYEAR);
                        }
                        break;
                     case 1:
                        dataSource.Columns.Add("Mã học sinh");
                        dataSource.Columns.Add("Họ tên");
                        dataSource.Columns.Add("Giới tính");
                        dataSource.Columns.Add("Ngày sinh");
                        dataSource.Columns.Add("Địa chỉ");
                        dataSource.Columns.Add("Số điện thoại");
                        dataSource.Columns.Add("Email");

                        List<STUDENT> listStudents = new List<STUDENT>();

                        foreach (var classItem in listClasses)
                        {
                            if (classItem.CLASSNAME == Class_ComboBox.SelectedItem.ToString() && classItem.SCHOOLYEAR == SchoolYear_ComboBox.SelectedItem.ToString())
                            {
                                listStudents = classItem.STUDENTs.ToList();
                            }
                        }

                        
                        foreach (var student in listStudents)
                        {
                            string sex = student.INFOR.SEX == 0 ? "Nam" : "Nữ";
                            string dayOfBirth = String.Format("{0:dd/MM/yyyy}", student.INFOR.DAYOFBIRTH);
                            dataSource.Rows.Add(student.ID, student.INFOR.FIRSTNAME + " " + student.INFOR.LASTNAME, sex, dayOfBirth, student.INFOR.ADDRESS, student.TEL, student.EMAIL);
                        }
                        break;
                    case 4:
                        dataSource.Columns.Add("Mã giáo viên");
                        dataSource.Columns.Add("Họ tên");
                        dataSource.Columns.Add("Giới tính");
                        dataSource.Columns.Add("Ngày sinh");
                        dataSource.Columns.Add("Địa chỉ");

                        foreach (var classItem in listClasses)
                        {
                            if (classItem.CLASSNAME == Class_ComboBox.SelectedItem.ToString() && classItem.SCHOOLYEAR == SchoolYear_ComboBox.SelectedItem.ToString())
                            {
                                INFOR inforTeacher = classItem.TEACHER.INFOR;

                                string sex = inforTeacher.SEX == 0 ? "Nam" : "Nữ";
                                string dayOfBirth = String.Format("{0:dd/MM/yyyy}", inforTeacher.DAYOFBIRTH);
                                dataSource.Rows.Add(inforTeacher.ID, inforTeacher.FIRSTNAME + " " + inforTeacher.LASTNAME, sex, dayOfBirth, inforTeacher.ADDRESS);
                            }
                        }
                        break;
                }

                DataTable_Info.DataSource = dataSource;
            }
            catch 
            {
                MessageBox.Show("Vui lòng kiểm tra lại điều kiên truy xuất và kết nối mạng.", "TRUY XUÂT THÔNG TIN THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DataGridViewExport_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DataExport_toExcel();
            }
            catch
            {
                MessageBox.Show("Xuất dữ liệu không thành công.", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        private void ClassInfor_SubTab_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((System.Action)(() =>
            {

                List<CLASS> listClasses = Database.ClassServices.Instance.GetClasss();

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
        }
    }
}
