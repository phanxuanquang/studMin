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
    public partial class AddStudent_Form : Form
    {
        public AddStudent_Form()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
            this.Load += AddStudent_Form_Load;
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
        }

        private void Complete_Button_Click(object sender, EventArgs e)
        {
            
            DateTime dateOfBirth = Birthday_ComboBox.Value;
            int maxAge = 20;
            int minAge = 13;
            PARAMETER limitAge = Database.ParameterServices.Instance.GetParameterByName("TUOI");
            if (limitAge != null)
            {
                maxAge = (int)limitAge.MAX;
                minAge = (int)limitAge.MIN;
            }
            if (CheckAge (dateOfBirth,maxAge, minAge) == false)
            {
                MessageBox.Show("Tuoi khong hop le");
                return;
            }
            //Luu hoc sinh
            //Thong tin hoc sinh
            //Database.StudentServices.Instance.SaveStudentToDB();
            Database.DataProvider.Instance.Database.SaveChanges();
        }

        private bool CheckAge(DateTime dateOfBirth, int maxAge, int minAge)
        {
            int age = int.Parse(Database.ClassServices.Instance.GetCurrentSchoolYear()) - dateOfBirth.Year;
            return maxAge <= age && age >= minAge;
        }
    }
}
