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
            Teacher_ComboBox.Items.AddRange(teachers);
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
            
        }
    }
}
