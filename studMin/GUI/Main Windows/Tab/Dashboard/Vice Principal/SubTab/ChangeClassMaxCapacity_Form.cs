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
    public partial class ChangeClassMaxCapacity_Form : Form
    {
        public ChangeClassMaxCapacity_Form()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinTrackBar_ValueChanged(object sender, EventArgs e)
        {
            MaxCapacityLabel.Text = String.Format("Sỉ số tối đa của lớp học hiện tại: {0} học sinh", MaxCapacityTrackBar.Value.ToString());
        }
    }
}
