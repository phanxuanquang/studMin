﻿using System;
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

            MinLabel.Text = String.Format("Tuổi nhập học tối thiểu: {0} tuổi", getAge.Item1.ToString());
            MaxLabel.Text = String.Format("Tuổi nhập học tối đa: {0} tuổi", getAge.Item2.ToString());

            MinTrackBar.Value = getAge.Item1;
            MaxTrackBar.Value = getAge.Item2;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn muốn thay đổi hay không?", "XÁC NHẬN", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaveAgeLimit(MinTrackBar.Value, MaxTrackBar.Value);
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
