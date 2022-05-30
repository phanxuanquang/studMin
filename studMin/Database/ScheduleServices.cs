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

        public SCHEDULE GetNewestSchedule()
        {
            return DataProvider.Instance.Database.SCHEDULEs.OrderByDescending(schedule => schedule.SCHOOLYEAR).ThenBy(schedule => schedule.SEMESTER.NAME).ThenBy(schedule => schedule.SCHEDULENAME).Take(1).FirstOrDefault();
        }

        public SCHEDULE CreateSchedule(DateTime dayApply, string schoolYear, string semester)
        {
            try
            {
                SCHEDULE schedule = new SCHEDULE()
                {
                    ID = Guid.NewGuid(),
                    DATEAPPLY = dayApply,
                    SCHOOLYEAR = schoolYear,
                    SEMESTER = DataProvider.Instance.Database.SEMESTERs.Where(item => item.NAME == semester).FirstOrDefault(),
                    SCHEDULENAME = "TKB tao ngay 28/3"
                };
                DataProvider.Instance.Database.Set<SCHEDULE>().Add(schedule);
                DataProvider.Instance.Database.SaveChanges();
                return schedule;
            }
            catch
            {
                return null;
            }
        }

        public bool SaveLessonToDB(SCHEDULE infoSchedule, string teacherName, string subjectName, string className, byte timeStart, byte timeEnd, byte dayofweek, string timeofday, string schoolYear)
        {
            try
            {
                if (infoSchedule != null)
                {
                    LESSON lesson = new LESSON()
                    {
                        ID = Guid.NewGuid(),
                        IDTEACHER = TeacherServices.Instance.GetTeacherByName(teacherName).ID,
                        IDSUBJECT = SubjectServices.Instance.GetSubjectByName(subjectName).Id,
                        IDCLASS = ClassServices.Instance.GetClassByClassNameAndSchoolYear(className, schoolYear).ID,
                        IDSCHEDULE = infoSchedule.ID,
                        TIMESTART = timeStart,
                        TIMEEND = timeEnd,
                        DAYOFW = dayofweek,
                        TIMEOFDAY = timeofday
                    };
                    DataProvider.Instance.Database.Set<LESSON>().Add(lesson);
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
