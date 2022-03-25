using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Database
{
    using Models;
    public class ClassServices
    {
        private static ClassServices instance;
        public static ClassServices Instance => instance ?? (instance = new ClassServices());

        private ClassServices() { }

        public CLASS GetClassById(Guid id)
        {
            return DataProvider.Instance.Database.CLASSes.Where(Class => Class.ID == id).FirstOrDefault();
        }

        public List<CLASS> GetClasss()
        {
            return DataProvider.Instance.Database.CLASSes.Select(Class => Class).ToList();
        }

        public CLASS GetFirstClass()
        {
            return DataProvider.Instance.Database.CLASSes.FirstOrDefault();
        }

        public CLASS GetClassByClassName(string className)
        {
            return DataProvider.Instance.Database.CLASSes.Where(item => item.CLASSNAME == className).FirstOrDefault();
        }

        public List<STUDENT> GetListStudentOfClass(string className)
        {
            CLASS tempClass = GetClassByClassName(className);
            return DataProvider.Instance.Database.STUDENTs.Where(item => item.IDCLASS == tempClass.ID).ToList();
        }
    }
}
