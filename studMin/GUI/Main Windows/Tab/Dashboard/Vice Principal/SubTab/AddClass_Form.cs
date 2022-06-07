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
    public partial class AddClass_Form : Form
    {
        ClassManage_SubTab classManageSubTab;

        public AddClass_Form()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
            this.Load += AddClass_Form_Load;
        }

        public AddClass_Form(ClassManage_SubTab classManage_SubTab)
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
            this.Load += AddClass_Form_Load;
            classManageSubTab = classManage_SubTab;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        private void AddClass_Form_Load(object sender, EventArgs e)
        {
            LoadTeacher();
        }

        private void LoadTeacher()
        {
            var teachers = Database.TeacherServices.Instance.GetTeachers().Where(item => item.TEACHERROLE.ROLE == "Giáo viên").Select(item => new
            {
                ID = item.ID,
                NAME = item.INFOR.FIRSTNAME + " " + item.INFOR.LASTNAME
            }).ToArray();
            Teacher_ComboBox.DataSource = (teachers);
            Teacher_ComboBox.ValueMember = "ID";
            Teacher_ComboBox.DisplayMember = "NAME";
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Complete_Button_Click(object sender, EventArgs e)
        {
            string enteredClassName = ClassName_Box.Text;

            if (String.IsNullOrEmpty(enteredClassName.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string currentYear = DateTime.Now.Year.ToString();
            CLASS classItem = Database.ClassServices.Instance.GetClassByClassNameAndSchoolYear(enteredClassName, currentYear);
            if (classItem != null)
            {
                MessageBox.Show("Đã tồn tại lớp " + enteredClassName + " trong năm học " + currentYear + ", vui lòng chọn tên lớp khác", "Thôn báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClassName_Box.Focus();
                return;
            }

            int numGrade;
            if (enteredClassName.Trim().Length <= 3)
            {
                MessageBox.Show("Tên lớp không hợp lệ, vui lòng thử lại sau. Ví dụ tên lớp hợp lệ: 10A2, 11A1, ... theo cấu trúc xAy với x là tên khối từ 10 đến 12, y là một con số bất kỳ không âm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string grade = enteredClassName.Substring(0, 2);
                if (!int.TryParse(grade, out numGrade))
                {
                    MessageBox.Show("Tên lớp học phải bắt đầu bằng tên khối từ 10 đến 12, ví dụ: 10A5, với tên khối lớp là 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (numGrade < 10 || numGrade > 12)
                {
                    MessageBox.Show("Khối lớp phải nằm trong khoảng từ 10 đến 12, vui lòng nhập lại tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (enteredClassName[2].ToString() != "a" && enteredClassName[2].ToString() != "A")
                {
                    MessageBox.Show("Ký tự phía sau tên khối phải là a hoặc A, vui lòng nhập lại tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int classIndex;
                bool isValidIndex = int.TryParse(enteredClassName.Substring(3), out classIndex);

                if (!isValidIndex || classIndex < 0)
                {
                    MessageBox.Show("Ký tự phía sau a (hoặc A) phải là một số không âm, vui lòng nhập lại tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            Guid gradeId = Database.DataProvider.Instance.Database.GRADEs.Where(item => item.NAME == numGrade.ToString()).FirstOrDefault().ID;
            var teacherId = new Guid(Teacher_ComboBox.SelectedValue.ToString());

            if (Database.ClassServices.Instance.CreateClass(enteredClassName.Trim().ToUpper(), teacherId, DateTime.Now.Year.ToString(), gradeId) != null)
            {
                var tempTeacher = Database.TeacherServices.Instance.GetTeacherById(teacherId);
                tempTeacher.TEACHERROLE = Database.DataProvider.Instance.Database.TEACHERROLEs.Where(item => item.ROLE == "Chủ nhiệm").FirstOrDefault();
                
                Database.DataProvider.Instance.Database.SaveChanges();

                LoadTeacher();
                classManageSubTab.BindingClass();

                MessageBox.Show("Thêm lớp học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
