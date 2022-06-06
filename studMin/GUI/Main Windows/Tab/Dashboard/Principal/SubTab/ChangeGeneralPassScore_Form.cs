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
    public partial class ChangeGeneralPassScore_Form : Form
    {
        public ChangeGeneralPassScore_Form()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
        }

        private void PassScoreTrackBar_ValueChanged(object sender, EventArgs e)
        {
            PassScoreLabel.Text = "Điểm đạt để lên lớp: " + PassScoreTrackBar.Value.ToString();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
