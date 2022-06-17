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

    public partial class StudentInforModify_Form : Form
    {
        STUDYING studyingCurrent;
        public StudentInforModify_Form(object studying)
        {
            InitializeComponent();
            studyingCurrent = studying as STUDYING;
            this.Load += StudentInforModify_Form_Load;
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

        private void StudentInforModify_Form_Load(object sender, EventArgs e)
        {
            cLASSBindingSource.DataSource = studyingCurrent.CLASS;
            sTUDENTBindingSource.DataSource = studyingCurrent.STUDENT;
            iNFORBindingSource.DataSource = studyingCurrent.STUDENT.INFOR;
            SetupCombobox();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupCombobox()
        {
            var listSex = new[]
            {
                new { id = 0, value = "Nam" },
                new { id = 1, value = "Nữ" },

            }.ToList();
            Sex_ComboBox.DisplayMember = "value";
            Sex_ComboBox.ValueMember = "id";
            Sex_ComboBox.DataSource = listSex;
            Sex_ComboBox.SelectedValue = studyingCurrent.STUDENT.INFOR.SEX;
            var listStatus = new[]
            {
                new { id = 1, value = "Đang học" },
                new { id = 0, value = "Đã nghỉ học" },

            }.ToList();
            Status_ComboBox.DisplayMember = "value";
            Status_ComboBox.ValueMember = "id";
            Status_ComboBox.DataSource= listStatus;
            Status_ComboBox.SelectedValue = studyingCurrent.STUDENT.Status;

        }

        private void Complete_Button_Click(object sender, EventArgs e)
        {
            if (CheckEmptyInput())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            PARAMETER limitAge = Database.ParameterServices.Instance.GetParameterByName("AGE");

            DateTime dateOfBirth = Birthday_ComboBox.Value;
            int maxAge = (int)limitAge.MAX;
            int minAge = (int)limitAge.MIN;
            if (CheckAge(dateOfBirth, maxAge, minAge) == false)
            {
                MessageBox.Show(String.Format("Tuổi của học sinh phải từ {0} đến {1}", minAge, maxAge), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!CheckEmail(ParentEmail_Box.Text) || !CheckEmail(Email_Box.Text))
            {
                MessageBox.Show("E-mail không hợp lệ. Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                studyingCurrent.STUDENT.Status = (int?)Status_ComboBox.SelectedValue;
                studyingCurrent.STUDENT.INFOR.SEX = (int?)Sex_ComboBox.SelectedValue;
                Database.DataProvider.Instance.Database.SaveChanges();
                MessageBox.Show("Chỉnh sửa thông tin học sinh thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
 
                MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
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
