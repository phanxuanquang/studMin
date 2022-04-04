using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studMin.Database.LoginServices
{
    using Models;
    internal class LoginServices
    {
        private USER currentUser;

        public  USER CurrentUser => currentUser;

        private TEACHER currentTeacher;

        public TEACHER CurrentTeacher => currentTeacher;

        private STAFF currentStaff;

        public STAFF CurrentStaff => currentStaff;

        private CLASS classOfHeadTeacher;

        public CLASS ClassOfHeadTeacher => classOfHeadTeacher;

        private static LoginServices instance;
        
        public static LoginServices Instance => instance ?? (instance = new LoginServices());

        private static string FilePathRememberAccount = Application.StartupPath + @"/Document/accRe.studMin";

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

        public string GetFilePathRememberAccount()
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(FilePathRememberAccount)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(FilePathRememberAccount));
                }
                if (!File.Exists(FilePathRememberAccount))
                {
                    File.Create(FilePathRememberAccount);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Lỗi truy cập , mã lỗi: {e}");
            }
            return FilePathRememberAccount;
        }

        public (string, string) GetRememberAccount()
        {
            string filePath = LoginServices.Instance.GetFilePathRememberAccount();
            if (File.Exists(filePath))
            {
                string fileContent = "";
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        fileContent = sr.ReadToEnd();
                        string accountRow = fileContent.Split('\n')[0];
                        if (accountRow == "")
                            return (null, null);
                        string[] account = accountRow.Split('\t');
                        return (account[0], Hash.Decrypt(account[1].ToString()));
                    }
                }
                catch
                {
                    Application.Exit();
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                }
            }
            return (null, null);
        }

        public void RememberAccount(string userName, string passWord)
        {
            try
            {
                if (LoginServices.Instance.CheckAccount(userName, passWord))
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(LoginServices.Instance.GetFilePathRememberAccount()))
                        {
                            sw.Write(userName + '\t' + Hash.Encrypt(passWord));
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đã có lỗi trong việc ghi nhớ tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Login(string userName)
        {
            currentUser = UserServices.Instance.GetUserByUserName(userName);

            if (currentUser.USERROLE.ROLE == "Giáo viên")
            {
                currentTeacher = TeacherServices.Instance.GetTeacherByUsername(userName);
                if (currentTeacher.TEACHERROLE.ROLE == "Chủ nhiệm")
                {
                    classOfHeadTeacher = Database.DataProvider.Instance.Database.CLASSes.Where(item => item.IDTEACHER == currentTeacher.ID).FirstOrDefault();
                }    
            }
            if (currentUser.USERROLE.ROLE == "Nhân viên")
            {
                currentStaff = StaffServices.Instance.GetStaffByUsername(userName);
            }
        }

    }
}
