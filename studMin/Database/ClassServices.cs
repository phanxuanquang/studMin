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

        public List<STUDENT> GetListStudentOfClass(string className, string schoolYear = null)
        {
            CLASS tempClass = GetClassByClassNameAndSchoolYear(className, schoolYear == null ? GetCurrentSchoolYear() : schoolYear);
            if (tempClass == null)
            {
                return new List<STUDENT>();
            }

            var listStudent = DataProvider.Instance.Database.STUDYINGs.Where(x => x.IDCLASS == tempClass.ID).Select(item => item.STUDENT).Distinct().ToList();
            return listStudent;
        }

        public List<STUDENT> GetListStudentOfClass(string className, string schoolYear, string semester)
        {
            CLASS tempClass = GetClassByClassNameAndSchoolYear(className, schoolYear == null ? GetCurrentSchoolYear() : schoolYear);
            if (tempClass == null)
            {
                return new List<STUDENT>();
            }

            var listStudent = DataProvider.Instance.Database.STUDYINGs.Where(x => x.IDCLASS == tempClass.ID && x.SEMESTER.NAME == semester).Select(item => item.STUDENT).Distinct().ToList();
            return listStudent;
        }

        public List<STUDENT> GetListStudentOfClass(CLASS Class)
        {
            var listStudent = Class.STUDYINGs.Select(x => x.STUDENT).Distinct().ToList();
            return listStudent;
        }

        public List<STUDYING> GetListStudyingOfClass(string className, string schoolYear)
        {
            var listStudying = new List<STUDYING>();
            CLASS tempClass = GetClassByClassNameAndSchoolYear(className, schoolYear == null ? GetCurrentSchoolYear() : schoolYear);
            if (tempClass != null)
            {
                listStudying = DataProvider.Instance.Database.STUDYINGs.Where(x => x.IDCLASS == tempClass.ID).ToList();
            }
            return listStudying.Distinct(new STUDYINGCompare()).ToList();
        }
        
        public bool Check(List<STUDYING> sTUDYINGs, STUDYING a)
        {
            foreach (var item in sTUDYINGs)
            {
                if (item.IDCLASS == a.IDCLASS)
                {
                    return true;
                }    
            }
            return false;
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

        public int GetQuantityOfClass(CLASS Class)
        {
            return Class.STUDYINGs.Where(item => item.IDCLASS == Class.ID).Distinct(new STUDYINGCompare()).ToList().Count();
        }

        public int GetQuantityOfClass(string className, string schoolYear = null)
        {
            return GetListStudentOfClass(className, schoolYear).Count();
        }

        public class STUDYINGCompare : IEqualityComparer<STUDYING>
        {
            public bool Equals(STUDYING x, STUDYING y)
            {
                if (x.IDCLASS == y.IDCLASS && x.IDSTUDENT == y.IDSTUDENT)
                {
                    return true;
                }    
                return false;
            }

            public int GetHashCode(STUDYING obj)
            {
                if (object.ReferenceEquals(obj, null))
                    return 0;
                int hashProductName = obj.IDCLASS == null ? 0 : obj.IDCLASS.GetHashCode();

                //Get hash code for the Code field.
                int hashProductCode = obj.IDSTUDENT.GetHashCode();

                //Calculate the hash code for the product.
                return hashProductName ^ hashProductCode;
            }
        }
    }
}
