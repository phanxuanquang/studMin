using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Database
{
    using Models;
    internal class UserServices
    {
        private static UserServices instance;
        
        public static UserServices Instance => instance ?? (instance = new UserServices());

        private UserServices() { }

        public USER GetUserByUserName(string userName)
        {
            return DataProvider.Instance.Database.USERS.Where(item => item.USERNAME == userName).FirstOrDefault();
        }

        public USER GetUserByOTP(OTP otp)
        {
            return DataProvider.Instance.Database.USERS.Where(item => item.IDOTP == otp.ID).FirstOrDefault();
        }

        public bool CheckValidEmailByUserName(string userName, string email)
        {
            if (LoginServices.LoginServices.Instance.CheckUser(userName))
            {
                USER user = GetUserByUserName(userName);
                if (user.EMAIL == email)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsValidEmail(string email)
        {
            if (email.Trim().EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool ChangePassWord(string newPassword, string userName)
        {
            try
            {
                USER temp = GetUserByUserName(userName) as USER;
                temp.PASSWORD = newPassword;
                DataProvider.Instance.Database.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}
