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
            //string passHashed = Hash.Encrypt(passWord);
            string passHashed = passWord;
            int accCount = DataProvider.Instance.Database.USERS.Where(user => user.USERNAME == userName && user.PASSWORD == passHashed).Count();

            return accCount > 0;
        }

        public bool CheckUser(string userName)
        {
            int countUser = DataProvider.Instance.Database.USERS.Where((user) => user.USERNAME == userName).Count(); 
            return countUser > 0;   
        }

        public string CheckUserRole(string userName)
        {
            if (!CheckUser(userName))
                return null;
            else
            {
                var user = DataProvider.Instance.Database.USERS.Where((item) => item.USERNAME == userName).FirstOrDefault();
                if (user.USERROLE.ROLE == "Giáo viên")
                {
                    var teacher = DataProvider.Instance.Database.TEACHERs.Where((item) => item.IDUSER == user.ID).FirstOrDefault();
                    return teacher.TEACHERROLE.ROLE;
                }
                else if (user.USERROLE.ROLE == "Nhân viên")
                {
                    var staff = DataProvider.Instance.Database.STAFFs.Where((item) => item.IDUSER == user.ID).FirstOrDefault();
                    return staff.STAFFROLE.ROLE;
                }
                return user.USERROLE.ROLE;
            } 
                
        }
    }
}
