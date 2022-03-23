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

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    OTPServices.Instance.DeleteOTPOverTime();
                    if (!OTPServices.Instance.CheckOTPGetFromEmail(this.userName, textBox1.Text))
                    {
                        MessageBox.Show("Mã xác nhận không chính xác", "Thông báo");
                        return;
                    }
                    UserServices.Instance.ChangePassWord(textBox2.Text, this.userName);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Có lỗi trong việc cập nhật mật khẩu mới");
                }

            }
        }
    }
}
