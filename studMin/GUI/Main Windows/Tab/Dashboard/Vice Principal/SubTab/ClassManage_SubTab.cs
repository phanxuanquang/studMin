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
    public partial class ClassManage_SubTab : UserControl
    {
        public ClassManage_SubTab()
        {
            InitializeComponent();
        }

        private void AddClass_Button_Click(object sender, EventArgs e)
        {
            AddClass_Form addClass_Form = new AddClass_Form();
            addClass_Form.ShowDialog();
        }
    }
}
