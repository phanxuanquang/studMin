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
        public AddClass_Form()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
            this.Load += AddClass_Form_Load;
        }

        private void AddClass_Form_Load(object sender, EventArgs e)
        {
            LoadTeacher();
            LoadLimit();
        }

        private void LoadTeacher()
        {
            var teachers = Database.TeacherServices.Instance.GetTeachers().Where(item => item.TEACHERROLE.ROLE == "Giáo viên").Select(item => new
            {
                ID = item.ID,
                NAME = item.INFOR.LASTNAME + " " + item.INFOR.FIRSTNAME
            }).ToArray();
            Teacher_ComboBox.DataSource = (teachers);
            Teacher_ComboBox.ValueMember = "ID";
            Teacher_ComboBox.DisplayMember = "NAME";
        }

        private void LoadLimit()
        {
            int sisomax = 35;
            var param = Database.ParameterServices.Instance.GetParameterByName("MAXQUANTITY");
            if (param != null)
            {
                sisomax = (int)param.MAX;
            }
            MaxQuantity_Box.Text = sisomax.ToString();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Complete_Button_Click(object sender, EventArgs e)
        {
            if (CheckClassExisting(ClassName_Box.Text))
            {
                MessageBox.Show("Tên lớp đã tồn tại!");
                ClassName_Box.Focus();
                return;
            }    
            Guid guid = Database.DataProvider.Instance.Database.GRADEs.Where(item => item.NAME == "10").FirstOrDefault().ID;
            var tmpID = new Guid(Teacher_ComboBox.SelectedValue.ToString());
            if (Database.ClassServices.Instance.CreateClass(ClassName_Box.Text,tmpID, DateTime.Now.Year.ToString(), guid) != null)
            {
               
                var tempTeacher = Database.TeacherServices.Instance.GetTeacherById(tmpID);
                tempTeacher.TEACHERROLE = Database.DataProvider.Instance.Database.TEACHERROLEs.Where(item => item.ROLE == "Chủ nhiệm").FirstOrDefault();
                Database.DataProvider.Instance.Database.SaveChanges();
                this.Close();
            }    

        }

        private bool CheckClassExisting(string className)
        {
             return Database.ClassServices.Instance.GetClasss().Select(item => item.CLASSNAME).Contains(className);
        }
    }
}
