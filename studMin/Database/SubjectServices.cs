using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Database
{
    using Models;
    public class SubjectServices
    {
        private static SubjectServices instance;
        public static SubjectServices Instance => instance ?? (instance = new SubjectServices());

        private SubjectServices() { }

        
        public List<SUBJECT> GetSubjects()
        {
            return DataProvider.Instance.Database.SUBJECTs.Select(Subject => Subject).ToList();
        }

        public SUBJECT GetFirstSubject()
        {
            return DataProvider.Instance.Database.SUBJECTs.FirstOrDefault();
        }

        public SUBJECT GetSubjectByName(string subjectName)
        {
            return DataProvider.Instance.Database.SUBJECTs.Where(item => item.DisplayName == subjectName).FirstOrDefault();
        }

        public ROLESCORE GetRoleSubject(string role)
        {
            return DataProvider.Instance.Database.ROLESCOREs.Where(item => item.ROLE == role).FirstOrDefault();
        }

        public void ChangeSubjectHeadTeacher(string subjectName, Guid teacherId)
        {
            SUBJECT currentSubject = GetSubjectByName(subjectName);
            currentSubject.IDHEADTEACHER = teacherId;

            DataProvider.Instance.Database.SaveChanges();
        }
    }
}
