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

        public bool ChangeSubjectHeadTeacher(string subjectName, Guid teacherId, List<Guid> otherTeachersId)
        {
            SUBJECT currentSubject = GetSubjectByName(subjectName);

            if (currentSubject.IDHEADTEACHER == teacherId)
            {
                return false;
            }

            TEACHER currentTeacher = TeacherServices.Instance.GetTeacherById(teacherId);
            if (currentTeacher == null)
            {
                return false;
            }

            Guid normalTeacherRoleId = DataProvider.Instance.Database.TEACHERROLEs.Where(item => item.ROLE == "Giáo viên").FirstOrDefault().ID;
            Guid assignedTeacherRoleId = DataProvider.Instance.Database.TEACHERROLEs.Where(item => item.ROLE == "Chủ nhiệm").FirstOrDefault().ID;
            Guid headTeacherRoleId = DataProvider.Instance.Database.TEACHERROLEs.Where(item => item.ROLE == "Trưởng bộ môn").FirstOrDefault().ID;
            Guid vicePrincipalRoleId = DataProvider.Instance.Database.TEACHERROLEs.Where(item => item.ROLE == "Phó hiệu trưởng").FirstOrDefault().ID;
            Guid principalRoleId = DataProvider.Instance.Database.TEACHERROLEs.Where(item => item.ROLE == "Hiệu trưởng").FirstOrDefault().ID;

            foreach (Guid id in otherTeachersId)
            {
                TEACHER teacher = TeacherServices.Instance.GetTeacherById(id);
                if (teacher.IDTEACHERROLE == assignedTeacherRoleId || teacher.IDTEACHERROLE == vicePrincipalRoleId || teacher.IDTEACHERROLE == principalRoleId)
                {
                    continue;
                } 
                else
                {
                    teacher.IDTEACHERROLE = normalTeacherRoleId;
                }
            }

            currentSubject.IDHEADTEACHER = teacherId;
            currentTeacher.IDTEACHERROLE = headTeacherRoleId;

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
