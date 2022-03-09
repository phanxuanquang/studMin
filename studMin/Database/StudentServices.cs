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

    }
}
