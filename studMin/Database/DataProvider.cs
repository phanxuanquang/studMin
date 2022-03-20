using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Database
{
    using Models;
    public class DataProvider
    {
        private static DataProvider instance;

        public StudMinDBEntities Database { get; set; }
        public static DataProvider Instance => instance ?? (instance = new DataProvider());
        private DataProvider()
        {
            Database = new StudMinDBEntities();
        }
    }
}