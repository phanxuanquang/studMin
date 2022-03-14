using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Database.LoginServices
{
    internal class LoginServices
    {
        private static LoginServices instance;
        public static LoginServices Instance => instance ?? (instance = new LoginServices());

        private LoginServices() { }

        public bool CheckAccount(string userName, string passWord)
        {
            string passHashed = Hash.Encrypt(passWord);
            int accCount = DataProvider.Instance.Database.USERS.Where(user => user.USERNAME == userName && user.PASSWORD == passHashed).Count();
            return accCount > 0;
        }
    }
}
