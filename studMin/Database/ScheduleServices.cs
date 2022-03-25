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

        public bool CreateASchedule(DateTime dayApply, int schoolYear, int semester)
        {
            try
            {
                SCHEDULE schedule = new SCHEDULE()
                {
                    ID = Guid.NewGuid(),
                    DATEAPPLY = dayApply,
                    SCHOOLYEAR = schoolYear,
                    SEMESTER = semester,
                };
                DataProvider.Instance.Database.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //public bool SaveScheduleToDB(string teacherName, string className, int timeStart, int timeEnd, int dayofweek, string timeofday)
        //{
           
        //   if (CreateASchedule())

            
        //    return true;
        //}

    }
}
