using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using studMin.Database.LoginServices;
namespace studMin
{
    public partial class Login_Window : Form
    {
        role personRole;
        public Login_Window()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
            this.Icon = Properties.Resources.studMin_Icon;
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

        bool isInternetAvailable()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://google.com/generate_204"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void Login_Window_Load(object sender, EventArgs e)
        {
            if (!isInternetAvailable())
            {
                MessageBox.Show("Không có kết nối mạng, vui lòng thử lại sau.", "Lỗi kết nối mạng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #region Buttons
        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (Username_Box.Text == String.Empty || Password_Box.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập.", "Không thể đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (isInternetAvailable())
            {
                if (LoginServices.Instance.CheckAccount(Username_Box.Text, Password_Box.Text))
                {
                    this.Hide();
                    this.ShowIcon = this.ShowInTaskbar = false;
                    // add check role here !
                    //personRole = role.classHead; // example

                    string role = LoginServices.Instance.CheckUserRole(Username_Box.Text);
                    switch (role)
                    {
                        case "Giáo viên":
                            personRole = studMin.role.normalTeacher;
                            break;
                        case "Nhân viên":
                            personRole = studMin.role.officeStaff;
                            break;
                        case "Quản lí":
                            personRole = studMin.role.manager;
                            break;
                        case "Chủ nhiệm":
                            personRole = studMin.role.classHead;
                            break;
                        case "Trưởng bộ môn":
                            personRole = studMin.role.subjectHead;
                            break;
                        case "Hiệu trưởng":
                            personRole = studMin.role.principal;
                            break;
                        case "Phó hiệu trưởng":
                            personRole = studMin.role.vicePrincipal;
                            break;
                    }    

                    MainWinfow mainWinfow = new MainWinfow(personRole);
                    mainWinfow.ShowDialog();
                }
                else
                {
                    Username_Box.Text = Password_Box.Text = String.Empty;
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.\nVui lòng điền lại thông tin đăng nhập.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Không có kết nối mạng, vui lòng thử lại sau.", "Lỗi kết nối mạng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForgetPassword_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetPassword_UC1.BringToFront();
            ForgetPasswordUC_MoverUp.Activate();
            forgetPassword_UC1.BackToLogin_Button.Visible = true;
        }
        #endregion
    }
    public enum role
    {
        classHead, subjectHead, normalTeacher, principal, vicePrincipal, officeStaff, manager
    }
}
