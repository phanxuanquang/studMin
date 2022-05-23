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

        private void LoadAgeLimit()
        {
            (int, int) getAge = GetAgeLimit();
            MinAgeTextBox.PlaceholderText = getAge.Item1.ToString();
            MaxAgeTextBox.PlaceholderText = getAge.Item2.ToString();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            int minAge = int.Parse(MinAgeTextBox.PlaceholderText);
            int maxAge = int.Parse(MaxAgeTextBox.PlaceholderText);

            if (!String.IsNullOrEmpty(MaxAgeTextBox.Text) && !int.TryParse(MaxAgeTextBox.Text, out maxAge))
            {
                MessageBox.Show("Tuổi tối đa không hợp lệ!");
                return;
            }
            if (!String.IsNullOrEmpty(MinAgeTextBox.Text) && !int.TryParse(MinAgeTextBox.Text, out minAge))
            {
                MessageBox.Show("Tuổi tối thiểu không hợp lệ!");
                return;
            }

            if (MessageBox.Show("Có chắc chắn muốn thay đổi hay không?", "XÁC NHẬN", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaveAgeLimit(minAge, maxAge);
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
            if (min >= max) return;

            var param = Database.ParameterServices.Instance.GetParameterByName("AGE");
            param.MAX = max;
            param.MIN = min;

            Database.DataProvider.Instance.Database.SaveChanges();
        }

        private void MaxAgeTextBox_Validated(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox textbox = sender as Guna.UI2.WinForms.Guna2TextBox;
            if (!String.IsNullOrEmpty(textbox.Text))
            {
                if (int.TryParse(textbox.Text, out int value))
                {
                    ValidProvider.SetError(textbox, "Hợp lệ");
                }
                else
                {
                    InvalidProvider.SetError(textbox, "Vui lòng nhập số nguyên!");
                }
            }
        }
    }
}
