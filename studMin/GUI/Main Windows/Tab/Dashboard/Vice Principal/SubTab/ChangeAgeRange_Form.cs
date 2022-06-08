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
    public partial class ChangeAgeRange_Form : Form
    {
        public ChangeAgeRange_Form()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
            this.Load += ChangeAgeRange_Form_Load;
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

        private void ChangeAgeRange_Form_Load(object sender, EventArgs e)
        {
            LoadAgeLimit();
        }

        int currentMax, currentMin;
        private void LoadAgeLimit()
        {
            (int, int) getAge = GetAgeLimit();

            MinLabel.Text = String.Format("Tuổi nhập học tối thiểu: {0} tuổi", getAge.Item1.ToString());
            MaxLabel.Text = String.Format("Tuổi nhập học tối đa: {0} tuổi", getAge.Item2.ToString());

            MinTrackBar.Value = currentMin = getAge.Item1;
            MaxTrackBar.Value = currentMax = getAge.Item2;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            if (MinTrackBar.Value > MaxTrackBar.Value)
            {
                MessageBox.Show("Tuổi tối thiểu phải nhỏ hơn hoặc bằng tuổi tối đa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Có chắc chắn muốn thay đổi hay không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveAgeLimit(MinTrackBar.Value, MaxTrackBar.Value);

                MessageBox.Show("Thay đổi khoảng tuổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Exit_Button_Click(null, null);
            }
        }

        private (int, int) GetAgeLimit()
        {
            var param = Database.ParameterServices.Instance.GetParameterByName("AGE");
            int minAge = 3;
            int maxAge = 18;
            if (param != null)
            {
                minAge = (int)param.MIN;
                maxAge = (int)param.MAX;
            }
            return (minAge, maxAge);
        }

        private void SaveAgeLimit(int min, int max)
        {
            if (min > max) return;

            var param = Database.ParameterServices.Instance.GetParameterByName("AGE");
            param.MAX = max;
            param.MIN = min;

            Database.DataProvider.Instance.Database.SaveChanges();
        }

        private void MinTrackBar_ValueChanged(object sender, EventArgs e)
        {
            MinLabel.Text = String.Format("Tuổi nhập học tối thiểu: {0} tuổi", MinTrackBar.Value.ToString());
        }

        private void MaxTrackBar_ValueChanged(object sender, EventArgs e)
        {
            MaxLabel.Text = String.Format("Tuổi nhập học tối đa: {0} tuổi", MaxTrackBar.Value.ToString());
        }
    }
}
