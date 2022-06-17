using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace studMin.Database
{
    using Database.LoginServices;
    using Models;
    internal class ParameterServices
    {
        private static ParameterServices instance;

        public static ParameterServices Instance => instance ?? (instance = new ParameterServices());

        private ParameterServices() { }

        public PARAMETER GetParameterByName(string name)
        {
            return DataProvider.Instance.Database.PARAMETERs.Where(item => item.NAME == name).FirstOrDefault();
        }
    }
}
