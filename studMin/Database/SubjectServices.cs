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

        public bool ChangeSubjectHeadTeacher(string subjectName, Guid teacherId)
        {
            SUBJECT currentSubject = GetSubjectByName(subjectName);

            if (currentSubject.IDHEADTEACHER == teacherId)
            {
                return false;
            }

            currentSubject.IDHEADTEACHER = teacherId;
            DataProvider.Instance.Database.SaveChanges();

            return true;
        }

        public void AddSubject(string subjectName, Guid headTeacherId)
        {
            SUBJECT newSubject = new SUBJECT()
            {
                Id = Guid.NewGuid(),
                DisplayName = subjectName,
                IDHEADTEACHER = headTeacherId,
                PASSSCORE = 5,
            };

            DataProvider.Instance.Database.SUBJECTs.Add(newSubject);
            DataProvider.Instance.Database.SaveChanges();
        }
    }
}
