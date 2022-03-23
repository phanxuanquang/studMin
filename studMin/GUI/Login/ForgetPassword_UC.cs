using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace studMin
{
    using Database;
    using System.IO;

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
                return UserServices.Instance.CheckValidEmailByUserName(username, email);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến hệ thống.\nNội dung lỗi: " + ex.Message, "Không thể đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return false;
        }

        #region Buttons
        private void BackToLogin_Button_Click(object sender, EventArgs e)
        {
            ForgetPasswordUC_MoverDown.Activate();
            BackToLogin_Button.Visible = false;
        }
        private async void getPassword_Button_Click(object sender, EventArgs e)
        {
            if (Username_Box.Text == String.Empty || Email_Box.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Không thể kết nối đến hệ thống!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (isValidAccount(Username_Box.Text, Email_Box.Text))
            {
                // Do something
                await GetOPTAsync(Username_Box.Text ,Email_Box.Text);

                //MessageBox.Show("Mật khẩu mới đã được gửi đến e-mail của bạn.\nVui lòng kiểm tra hộp thư đến.");
                ForgetPasswordUC_MoverDown.Activate();
                BackToLogin_Button.Visible = false;
                this.Visible = false;
                studMin.GUI.Login.OTPexample oTPexample = new GUI.Login.OTPexample(Username_Box.Text);
                oTPexample.ShowDialog();
                this.Visible = true;
            }
        }
        #endregion


        public async Task SetupAndSendOTPForEmailAsync(string email, string OTP)
        {
            var body = File.ReadAllText("../../Resources/mail.html");
            var from = new MailAddress("example@gmail.com", "StudMin Development Team");
            var to = new MailAddress(email);
            MailMessage mm = new MailMessage(from, to)
            {
                Subject = OTP + " là mã khôi phục tài khoản Stuman của bạn",
                IsBodyHtml = true,
                Body = body.Replace("OTP_CODE", OTP),
                Priority = MailPriority.High
            };
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential(Properties.Settings.Default.Email, Properties.Settings.Default.Password),
                EnableSsl = true
            };
            try
            {
                await smtp.SendMailAsync(mm);
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra, không thể gửi mã OTP", "OTP");
            }
        }

        public async Task GetOPTAsync(string userName, string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Cần phải nhập địa chỉ mail trước khi lấy mã");
                    return;
                }
                if (!UserServices.Instance.IsValidEmail(email))
                {
                    MessageBox.Show("Địa chỉ mail không hợp lệ");
                    return;
                }


                string OTP = OTPServices.Instance.RandomOTP();


                await OTPServices.Instance.SaveOTP(userName, OTP);

                await SetupAndSendOTPForEmailAsync(email, OTP);
            }
            catch
            {
                MessageBox.Show("Có lỗi trong việc tạo OTP");
            }

        }
    }
}
