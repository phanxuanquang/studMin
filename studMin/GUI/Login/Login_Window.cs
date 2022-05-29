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
        private role personRole;
        private bool isLoading = false;
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
            if (!isInternetAvailable() && MessageBox.Show("Không có kết nối mạng, vui lòng thử lại sau.", "Lỗi kết nối mạng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                // đọc trạng thái của RememberLogin_CheckBox ở file lưu trong máy
                bool isRememberLogin = RememberLogin_CheckBox.Checked = true;
                if (isRememberLogin)
                {
 
                    Username_Box.Text = LoginServices.Instance.GetRememberAccount().Item1;
                    Password_Box.Text = LoginServices.Instance.GetRememberAccount().Item2;
                }
            }
        }

        #region Buttons
        private async void Login_Button_Click(object sender, EventArgs e)
        {
            if (Username_Box.Text == String.Empty || Password_Box.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập.", "Không thể đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (isInternetAvailable())
            {
                bool isValidAccount = false;
                string accountRole = String.Empty;

                GUI.LoadingWindow loadingWindow = new GUI.LoadingWindow(this, "ĐANG XÁC THỰC \n VUI LÒNG ĐỢI");
                loadingWindow.Show();
                this.Enabled = false;

                await System.Threading.Tasks.Task.Factory.StartNew(() =>
                {
                    isValidAccount = LoginServices.Instance.CheckAccount(Username_Box.Text, Password_Box.Text);
                    if (isValidAccount)
                    {
                        LoginServices.Instance.Login(Username_Box.Text);
                        accountRole = LoginServices.Instance.CheckUserRole(Username_Box.Text);
                        if (RememberLogin_CheckBox.Checked)
                        {
                            LoginServices.Instance.RememberAccount(Username_Box.Text, Password_Box.Text);
                        }
                    }
                });

                loadingWindow.Close();
                loadingWindow.Dispose();
                this.Enabled = true;

                if (isValidAccount)
                {
                    this.Hide();
                    this.ShowIcon = this.ShowInTaskbar = false;
                    
                    switch (accountRole)
                    {
                        case "Nhân viên":
                            personRole = studMin.role.officeStaff;
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
                        default:
                            personRole = studMin.role.normalTeacher;
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
        private void EnterAccountComplete_KeyPress(dynamic sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login_Button_Click(sender, e);
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                sender.Text = String.Empty;
            }
            //thêm tab event
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
        classHead, subjectHead, normalTeacher, principal, vicePrincipal, officeStaff
    }
}
