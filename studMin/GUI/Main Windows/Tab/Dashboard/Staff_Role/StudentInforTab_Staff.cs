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
    public partial class StudentInforTab_Staff : UserControl
    {
        public StudentInforTab_Staff()
        {
            InitializeComponent();
        }

        private void AddStudent_Button_Click(object sender, EventArgs e)
        {
            AddStudent_Form addStudent_Form = new AddStudent_Form();
            addStudent_Form.ShowDialog();
            this.Refresh();
        }
    }
}
