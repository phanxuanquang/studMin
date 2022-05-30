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
    using System.Net.Mail;

    public partial class AddStudent_Form : Form
    {
        StudentInforTab_Staff studentInforTab_Staff;
        public AddStudent_Form()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
            this.Load += AddStudent_Form_Load;
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
        public AddStudent_Form(StudentInforTab_Staff studentInforTab)
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
            this.Load += AddStudent_Form_Load;

            studentInforTab_Staff = studentInforTab;
        }

        private void AddStudent_Form_Load(object sender, EventArgs e)
        {
            string shoolYear = Database.ClassServices.Instance.GetCurrentSchoolYear();
            List<CLASS> cLASSes = Database.ClassServices.Instance.GetClassBySchoolYear(shoolYear);
            foreach (var item in cLASSes)
            {
                Class_ComboBox.Items.Add(item.CLASSNAME);
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();

            //studentInforTab_Staff.LoadStudentsInfor();
        }

        private void Complete_Button_Click(object sender, EventArgs e)
        {
            if (CheckEmptyInput())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PARAMETER limitAge = Database.ParameterServices.Instance.GetParameterByName("AGE");

            DateTime dateOfBirth = Birthday_ComboBox.Value;
            int maxAge = (int)limitAge.MAX;
            int minAge = (int)limitAge.MIN;
            if (CheckAge(dateOfBirth, maxAge, minAge) == false)
            {
                MessageBox.Show(String.Format("Tuổi của học sinh phải từ {0} đến {1}", minAge, maxAge), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Class_ComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn lớp học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!CheckEmail(ParentEmail_Box.Text))
            {
                MessageBox.Show("Email không hợp lệ, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string firstName = FirstName_Box.Text;
            string lastName = LastName_Box.Text;
            int sex = Sex_ComboBox.SelectedIndex == 0 ? 0 : 1;
            string className = Class_ComboBox.SelectedItem.ToString();
            string bloodLine = Bloodline_Box.Text;
            string address = Address_Box.Text;
            string telephone = PhoneNumber_Box.Text;
            string emailParent = ParentEmail_Box.Text;
            string email = Email_Box.Text;
            string shoolYear = Database.ClassServices.Instance.GetCurrentSchoolYear();
            Guid idClass = Database.ClassServices.Instance.GetClassByClassNameAndSchoolYear(className,shoolYear).ID;

            if (Database.StudentServices.Instance.SaveStudentToDB(firstName, lastName, sex, dateOfBirth, address, email, idClass, emailParent, telephone, 1, bloodLine))
            {
                MessageBox.Show("Thêm học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();

            //Luu hoc sinh
            //Thong tin hoc sinh
            //Database.StudentServices.Instance.SaveStudentToDB();
            /*Database.DataProvider.Instance.Database.SaveChanges();*/
        }

        private bool CheckAge(DateTime dateOfBirth, int maxAge, int minAge)
        {
            int age = int.Parse(Database.ClassServices.Instance.GetCurrentSchoolYear()) - dateOfBirth.Year;
            if (dateOfBirth.Date > DateTime.Today.AddYears(-age)) age--;
            return age >= minAge && age <= maxAge;
        }

        private bool CheckEmptyInput()
        {
            return String.IsNullOrEmpty(FirstName_Box.Text) || String.IsNullOrEmpty(LastName_Box.Text) || String.IsNullOrEmpty(Bloodline_Box.Text) || String.IsNullOrEmpty(Address_Box.Text) || String.IsNullOrEmpty(PhoneNumber_Box.Text) || String.IsNullOrEmpty(ParentEmail_Box.Text);
        }

        public bool CheckEmail(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
