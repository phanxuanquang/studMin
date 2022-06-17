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
    public partial class ChangeClassMaxCapacity_Form : Form
    {
        PARAMETER parameter;
        int maxCapacity;

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
            MaxCapacityLabel.Text = String.Format("Sỉ số tối đa của các lớp hiện tại: {0} học sinh", MaxCapacityTrackBar.Value.ToString());
            maxCapacity = MaxCapacityTrackBar.Value;
        }

        private void ChangeClassMaxCapacity_Form_Load(object sender, EventArgs e)
        {
            parameter = ParameterServices.Instance.GetParameterByName("MAXQUANTITY");
            maxCapacity = (int)parameter.MAX;
            MaxCapacityTrackBar.Value = maxCapacity;
            MaxCapacityLabel.Text = String.Format("Sỉ số tối đa của các lớp hiện tại: {0} học sinh", MaxCapacityTrackBar.Value.ToString());
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            parameter.MAX = maxCapacity;

            DataProvider.Instance.Database.SaveChanges();
            MessageBox.Show("Thay đổi sỉ số tối đa thành công.\nGiới hạn sỉ số này sẽ được áp dụng khi lớp học mới được thêm vào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
