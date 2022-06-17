using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Database
{
    using Models;
    public class ReportSemesterServices
    {
        private static ReportSemesterServices instance;
        public static ReportSemesterServices Instance => instance ?? (instance = new ReportSemesterServices());

        public List<REPORTSEMESTER> GetReports()
        {
            return DataProvider.Instance.Database.REPORTSEMESTERs.Select(Report => Report).ToList();
        }
    }
}
