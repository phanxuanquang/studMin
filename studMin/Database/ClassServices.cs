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

        public CLASS GetClassByClassNameAndSchoolYear(string className, string schoolYear)
        {
            return DataProvider.Instance.Database.CLASSes.Where(item => item.CLASSNAME == className && item.SCHOOLYEAR == schoolYear).FirstOrDefault();
        }

        public List<CLASS> GetClassBySchoolYear(string schoolYear)
        {
            return DataProvider.Instance.Database.CLASSes.Where(item => item.SCHOOLYEAR == schoolYear).ToList();
        }

        public List<STUDENT> GetListStudentOfClass(string className)
        {
            CLASS tempClass = GetClassByClassName(className);
            return DataProvider.Instance.Database.STUDENTs.Where(item => item.IDCLASS == tempClass.ID).ToList();
        }

        public string GetCurrentSchoolYear()
        {
            return DataProvider.Instance.Database.CLASSes.Select(item => item.SCHOOLYEAR).Max();
        }

        public CLASS CreateClass(string className, Guid idTeacher, string schoolYear, Guid idGrade)
        {
            try
            {
                CLASS _class = new CLASS()
                {
                    ID = Guid.NewGuid(),
                    CLASSNAME = className,
                    IDTEACHER = idTeacher,
                    IDGRADE = idGrade,
                    SCHOOLYEAR = schoolYear
                };
                DataProvider.Instance.Database.Set<CLASS>().Add(_class);
                DataProvider.Instance.Database.SaveChanges();
                return _class;
            }
            catch
            {
                return null;
            }
        }
    }
}
