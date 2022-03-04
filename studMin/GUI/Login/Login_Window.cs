using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace studMin
{
    public partial class Login_Window : Form
    {
        public Login_Window()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
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
        private void Login_Window_Load(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://google.com/generate_204"))
                    {
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không có kết nối mạng, vui lòng thử lại sau.", "Lỗi kết nối mạng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }
        bool isValidAccount(string username, string password)
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
        private void Login_Button_Click(object sender, EventArgs e)
        {
            if(Username_Box.Text == String.Empty || Password_Box.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập.", "Không thể đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(isValidAccount(Username_Box.Text, Password_Box.Text))
            {
                // Do something
            }
        }
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void ForgetPassword_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPasswordUC_MoverUp.Activate();
            forgetPassword_UC1.BackToLogin_Button.Visible = true;
        }
    }
}
