using studMin.Database;
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
    public partial class ChangeGeneralPassScore_Form : Form
    {
        PARAMETER generalPassScore;

        public ChangeGeneralPassScore_Form()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
        }

        private void PassScoreTrackBar_ValueChanged(object sender, EventArgs e)
        {
            PassScoreLabel.Text = "Điểm đạt để lên lớp: " + (PassScoreTrackBar.Value).ToString();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeGeneralPassScore_Form_Load(object sender, EventArgs e)
        {
            generalPassScore = DataProvider.Instance.Database.PARAMETERs.Where(item => item.NAME == "PASSSCORE").FirstOrDefault();
            PassScoreTrackBar.Value = (int)generalPassScore.MIN;
            PassScoreLabel.Text = "Điểm đạt để lên lớp: " + PassScoreTrackBar.Value.ToString();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            generalPassScore.MIN = PassScoreTrackBar.Value;
            generalPassScore.MAX = PassScoreTrackBar.Value;

            DataProvider.Instance.Database.SaveChanges();
            MessageBox.Show("Thay đổi điểm đạt để lên lớp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
