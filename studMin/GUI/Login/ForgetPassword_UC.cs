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
    public partial class ForgetPassword_UC : UserControl
    {
        public ForgetPassword_UC()
        {
            InitializeComponent();
        }
        bool isValidAccount(string username, string email)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến hệ thống.\nNội dung lỗi: " + ex.Message, "Không thể đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return true;
        }

        #region Buttons
        private void BackToLogin_Button_Click(object sender, EventArgs e)
        {
            ForgetPasswordUC_MoverDown.Activate();
            BackToLogin_Button.Visible = false;
        }
        private void getPassword_Button_Click(object sender, EventArgs e)
        {
            if (Username_Box.Text == String.Empty || Email_Box.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Không thể kết nối đến hệ thống!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (isValidAccount(Username_Box.Text, Email_Box.Text))
            {
                // Do something

                MessageBox.Show("Mật khẩu mới đã được gửi đến e-mail của bạn.\nVui lòng kiểm tra hộp thư đến.");
                ForgetPasswordUC_MoverDown.Activate();
                BackToLogin_Button.Visible = false;
            }
        }
        #endregion
    }
}
