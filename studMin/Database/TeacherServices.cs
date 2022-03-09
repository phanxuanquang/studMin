using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Database
{
    using Models;
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
    }
}
