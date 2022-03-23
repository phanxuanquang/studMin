using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace studMin.Database
{
    using Database.LoginServices;
    using Models;
    internal class OTPServices
    {
        private static OTPServices instance;

        public static OTPServices Instance => instance ?? (instance = new OTPServices());

        private OTPServices() { }

        public string RandomOTP()
        {
            Random generator = new Random();
            return Hash.HashOTP(generator.Next(0, 1000000).ToString("D6"));
        }


        public bool CheckOTPGetFromEmail(string userName,string OTP)
        {
            if (LoginServices.LoginServices.Instance.CheckUser(userName))
            {
                USER temp = UserServices.Instance.GetUserByUserName(userName);

                if (temp.IDOTP == null)
                    return false;
                
                if (temp.OTP.CODE == OTP)
                    return true;
            }
            return false;
        }

        public async Task SaveOTP(string userName, string OTP)
        {
            if (LoginServices.LoginServices.Instance.CheckUser(userName))
            {
                USER temp = UserServices.Instance.GetUserByUserName(userName);

                var otp = new OTP()
                {
                    ID = Guid.NewGuid(),
                    CODE = OTP,
                    Time = DateTime.Now,
                };
                
                DataProvider.Instance.Database.OTPs.Add(otp);
                temp.IDOTP = otp.ID;
                
                await DataProvider.Instance.Database.SaveChangesAsync();
            }
           
            await DataProvider.Instance.Database.SaveChangesAsync();
        }

        

        public void DeleteOTPOverTime()
        {
            if (DataProvider.Instance.Database.OTPs.ToList().Count == 0)
                return;
            var listOTP = DataProvider.Instance.Database.OTPs.Where(otp => DbFunctions.DiffMinutes(otp.Time, DateTime.Now) > 5).ToList();
            if (listOTP.Count < 0)
                return;
            foreach (var otp in listOTP)
            {
                
                DataProvider.Instance.Database.OTPs.Remove(otp);
                var user = UserServices.Instance.GetUserByOTP(otp);
                
                try
                {
                    user.IDOTP = null;
                }
                catch { }
            }
            DataProvider.Instance.Database.SaveChanges();
        }
    }
}
