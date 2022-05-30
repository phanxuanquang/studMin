using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Database
{
    using Models;
    using Database;
    public class TeacherServices
    {
        
        private static TeacherServices instance;
        public static TeacherServices Instance => instance ?? (instance = new TeacherServices());

        private TeacherServices() { }

        public TEACHER GetTeacherById(Guid id)
        {
            return DataProvider.Instance.Database.TEACHERs.Where(Teacher => Teacher.ID == id).FirstOrDefault();
        }

        public List<TEACHER> GetTeachers()
        {
            return DataProvider.Instance.Database.TEACHERs.Select(Teacher => Teacher).ToList();
        }

        public TEACHER GetFirstTeacher()
        {
            return DataProvider.Instance.Database.TEACHERs.FirstOrDefault();
        }

        public TEACHER GetTeacherByUsername(string userName)
        {
            USER user = UserServices.Instance.GetUserByUserName(userName);
            return DataProvider.Instance.Database.TEACHERs.Where(item => item.IDUSER == user.ID).FirstOrDefault();
        }

        public SUBJECT GetSubjectOfTeacher()
        {
            return DataProvider.Instance.Database.SUBJECTs.Where(item => item.Id == LoginServices.LoginServices.Instance.CurrentTeacher.IDSUBJECT).FirstOrDefault();
        }

        public List<TEACHER> GetTeachersBySubject(Guid idSubject)
        {
            return DataProvider.Instance.Database.TEACHERs.Where(item => item.IDSUBJECT == idSubject).ToList();
        }

        public List<CLASS> GetAllClassTeaching(string schoolYear = null)
        {
            if (schoolYear == null)
            {
                schoolYear = ClassServices.Instance.GetCurrentSchoolYear();
            }    
            List<CLASS> list = new List<CLASS>();
            var teaching = DataProvider.Instance.Database.TEACHes.Where(item => item.IDTEACHER == LoginServices.LoginServices.Instance.CurrentTeacher.ID && item.SCHOOLYEAR == schoolYear).ToList();
            foreach (var item in teaching)
            {
                if (!list.Contains(item.CLASS))
                    list.Add(item.CLASS);
            }    
            return list;
        }

        public TEACHER GetTeacherByName(string teacherName)
        {
            return DataProvider.Instance.Database.TEACHERs.Where(item => (item.INFOR.FIRSTNAME + " " + item.INFOR.LASTNAME) == teacherName).FirstOrDefault();
        }
    }
}