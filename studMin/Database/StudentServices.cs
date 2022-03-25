using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Database
{
    using Models;
    public class StudentServices
    {
        private static StudentServices instance;
        public static StudentServices Instance => instance ?? (instance = new StudentServices());

        private StudentServices() { }

        public STUDENT GetStudentById(Guid id)
        {
            return DataProvider.Instance.Database.STUDENTs.Where(student => student.ID == id).FirstOrDefault();
        }

        public List<STUDENT> GetStudents()
        {
            return DataProvider.Instance.Database.STUDENTs.Select(student => student).ToList();
        }

        public STUDENT GetFirstStudent()
        {
            return DataProvider.Instance.Database.STUDENTs.FirstOrDefault();
        }

        public bool SaveStudentToDB(STUDENT saveStudent)
        {
            try
            {
                if (saveStudent == null)
                {
                    return false;
                }
                else
                {
                    DataProvider.Instance.Database.STUDENTs.Add(saveStudent);
                }
                DataProvider.Instance.Database.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool SaveStudentToDB(string firstName, string lastName, int sex, DateTime dayOfBirth, string address, string email, Guid idClass, string emailParent, int grade, string telephone, int status, string bloodLine)
        {
            STUDENT student = new STUDENT()
            {
                ID = Guid.NewGuid(),
                FIRSTNAME = firstName,
                LASTNAME = lastName,
                SEX = sex,
                DAYOFBIRTH = dayOfBirth,
                ADDRESS = address,
                EMAIL = email,
                IDCLASS = idClass,
                EMAILPARENT = emailParent,
                GRADE = grade,
                TEL = telephone,
                Status = status,
                BLOODLINE = bloodLine,
            };
            return SaveStudentToDB(student);
        }

    }
}