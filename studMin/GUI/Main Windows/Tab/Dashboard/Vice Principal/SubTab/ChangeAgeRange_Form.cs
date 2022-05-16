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

        private void ChangeAgeRange_Form_Load(object sender, EventArgs e)
        {
            LoadAgeLimit();
        }

        private void LoadAgeLimit()
        {
            MinAgeCurrent_Box.Text = GetAgeLimit().Item1.ToString();
            MaxAgeCurrent_Box.Text = GetAgeLimit().Item2.ToString();
        }
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            int minAge = (int)(string.IsNullOrEmpty(MinAge_Box.Text) ? GetAgeLimit().Item1 : int.Parse(MinAge_Box.Text));
            int maxAge = (int)(string.IsNullOrEmpty(MaxAge_Box.Text) ? GetAgeLimit().Item2 : int.Parse(MaxAge_Box.Text));
            SaveAgeLimit(minAge, maxAge);
            LoadAgeLimit();
            MinAge_Box.Clear();
            MaxAge_Box.Clear();
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

        private void Age_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void SaveAgeLimit(int min, int max)
        {
            if (min >= max) return;

            var param = Database.ParameterServices.Instance.GetParameterByName("AGE");
            param.MAX = max;
            param.MIN = min;

            Database.DataProvider.Instance.Database.SaveChanges();
        }
    }
}
