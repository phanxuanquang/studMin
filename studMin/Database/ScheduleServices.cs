using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Database
{
    using Models;
    public class ScheduleServices
    {
        private static ScheduleServices instance;
        public static ScheduleServices Instance => instance ?? (instance = new ScheduleServices());

        private ScheduleServices() { }

        public SCHEDULE GetScheduleById(Guid id)
        {
            return DataProvider.Instance.Database.SCHEDULEs.Where(Schedule => Schedule.ID == id).FirstOrDefault();
        }

        public List<SCHEDULE> GetSchedules()
        {
            return DataProvider.Instance.Database.SCHEDULEs.Select(Schedule => Schedule).ToList();
        }

        public SCHEDULE GetFirstSchedule()
        {
            return DataProvider.Instance.Database.SCHEDULEs.FirstOrDefault();
        }


        public SCHEDULE CreateASchedule(DateTime dayApply, int schoolYear, int semester)
        {
            try
            {
                SCHEDULE schedule = new SCHEDULE()
                {
                    ID = Guid.NewGuid(),
                    DATEAPPLY = dayApply,
                    SCHOOLYEAR = schoolYear,
                    SEMESTER = semester,
                    SCHEDULENAME = "TKB tao ngay 28/3",
                };
                DataProvider.Instance.Database.SaveChanges();
                return schedule;
            }
            catch
            {
                return null;
            }
        }
        public bool SaveLessonToDB(string teacherName,string subjectName, string className, byte timeStart, byte timeEnd, byte dayofweek, string timeofday)
        {
            SCHEDULE schedule = CreateASchedule(new DateTime(2022, 3, 28), 2022, 2);
            try
            {
                if (schedule != null)
                {
                    LESSON lesson = new LESSON()
                    {
                        IDTEACHER = TeacherServices.Instance.GetTeacherByName(teacherName).ID,
                        IDSUBJECT = SubjectServices.Instance.GetSubjectByName(subjectName).Id,
                        IDCLASS = ClassServices.Instance.GetClassByClassName(className).ID,
                        IDSCHEDULE = schedule.ID,
                        TIMESTART = timeStart,
                        TIMEEND = timeEnd,
                        DAYOFW = dayofweek,
                        TIMEOFDAY = timeofday,
                    };
                    DataProvider.Instance.Database.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
