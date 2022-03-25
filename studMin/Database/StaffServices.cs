using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Database
{
    using Models;
    public class StaffServices
    {
        private static StaffServices instance;
        public static StaffServices Instance => instance ?? (instance = new StaffServices());

        private StaffServices() { }

        public STAFF GetStaffById(Guid id)
        {
            return DataProvider.Instance.Database.STAFFs.Where(Staff => Staff.ID == id).FirstOrDefault();
        }

        public List<STAFF> GetStaffs()
        {
            return DataProvider.Instance.Database.STAFFs.Select(Staff => Staff).ToList();
        }

        public STAFF GetFirstStaff()
        {
            return DataProvider.Instance.Database.STAFFs.FirstOrDefault();
        }

        public STAFF GetStaffByUsername(string userName)
        {
            USER user = UserServices.Instance.GetUserByUserName(userName);
            return DataProvider.Instance.Database.STAFFs.Where(item => item.IDUSER == user.ID).FirstOrDefault();
        }
    }
}
