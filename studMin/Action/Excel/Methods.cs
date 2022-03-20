using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin
{
    internal class Methods
    {
        public static DateTime TryParse(string value)
        {
            try
            {
                // Default system: Control Panel\Clock and Region\Region
                return DateTime.Parse(value);
            }
            catch
            {
                //Format: 15/05/2022
                //Format: 15/11/2022
                return DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
        }
    }
}
