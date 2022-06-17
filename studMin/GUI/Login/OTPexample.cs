using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studMin.Database;

namespace studMin.GUI.Login
{
    public partial class OTPexample : Form
    {
        public string userName;
        public OTPexample(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            if(NewPassword_Box.Text == ConfirmNewPassword_Box.Text)
            {
                try
                {
                    OTPServices.Instance.DeleteOTPOverTime();
                    if (!OTPServices.Instance.CheckOTPGetFromEmail(this.userName, OTP_Box.Text))
                    {
                        MessageBox.Show("Mã xác thực không chính xác. Vui lòng nhập lại.", "Xác thực thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        OTP_Box.Text = String.Empty;
                        return;
                    }
                    UserServices.Instance.ChangePassWord(NewPassword_Box.Text, this.userName);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Không thể thay đổi mật khẩu vào lúc này. Vui lòng thử lại sau.", "Đổi mật khẩu thất bại", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu xác nhập lại không trùng khớp. Vui lòng nhập lại.", "Xác thực thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConfirmNewPassword_Box.Text = String.Empty;
            }
        }
    }
}
