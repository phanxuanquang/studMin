using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Database
{
    using Models;

    using studMin.Database.LoginServices;
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

        public bool SaveStudentToDB(STUDENT saveStudent, INFOR infor)
        {
            try
            {
                if (saveStudent == null || infor == null)
                {
                    return false;
                }
                else
                {
                    DataProvider.Instance.Database.STUDENTs.Add(saveStudent);
                    DataProvider.Instance.Database.INFORs.Add(infor);
                }
                DataProvider.Instance.Database.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool SaveStudentToDB(string firstName, string lastName, int sex, DateTime dayOfBirth, string address, string email, Guid idClass, string emailParent, string telephone, int status, string bloodLine)
        {
            STUDENT student = new STUDENT()
            {
                ID = Guid.NewGuid(),
                
                EMAIL = email,
                IDCLASS = idClass,
                EMAILPARENT = emailParent,
                TEL = telephone,
                Status = status,
                BLOODLINE = bloodLine,
            };
            INFOR infor = new INFOR()
            {
                ID = Guid.NewGuid(),
                FIRSTNAME = firstName,
                LASTNAME = lastName,
                SEX = sex,
                DAYOFBIRTH = dayOfBirth,
                ADDRESS = address,
            };
            student.IDINFOR = infor.ID; 
            return SaveStudentToDB(student, infor);
        }

        // Nhập điểm cho một học sinh
        public bool SaveScoreToDB(Guid idStudent, double score, string schoolYear, string semester, string role)
        {
            SCORE scoreofstudent = new SCORE()
            {
                ID = Guid.NewGuid(),
                IDSTUDENT = idStudent,
                IDSUBJECT = TeacherServices.Instance.GetSubjectOfTeacher().Id,
                SCORE1 = score,
                SCHOOLYEAR = schoolYear,
                SEMESTER = DataProvider.Instance.Database.SEMESTERs.Where(item => item.NAME == semester).FirstOrDefault(),
                /*
                 * có 4 role 
                 * M -> miệng
                 * 15M -> 15 phút
                 * 45M -> 45 phút
                 * FINAL -> cuối kỳ
                 */
                IDROLESCORE = SubjectServices.Instance.GetRoleSubject(role).ID,
            };
            return SaveScoreToDB(scoreofstudent);
        }

        //Nhập điểm 15 phút cho toàn bộ lớp được dạy bởi giáo viên hiện đang đăng nhập
        public void SaveScoreOfClass()
        {
            string role = "15M";
            string schoolYear = "2022";
            string semester = "2";
            float score = 10;
            List<CLASS> listClass = TeacherServices.Instance.GetAllClassTeaching();
            foreach (var item in listClass)
            {
                List<STUDENT> listStudent = ClassServices.Instance.GetListStudentOfClass(item.CLASSNAME);
                foreach (STUDENT student in listStudent)
                {
                    if (!SaveScoreToDB(student.ID, score, schoolYear, semester, role))
                    {
                        //thông báo có lỗi khi lưu điểm
                    }
                    else
                    {
                        //đã lưu thành công
                    }
                }
            }
        }

        public bool SaveScoreToDB(SCORE saveScore)
        {
            try
            {
                if (saveScore == null)
                {
                    return false;
                }
                else
                {
                    DataProvider.Instance.Database.SCOREs.Add(saveScore);
                }
                DataProvider.Instance.Database.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}