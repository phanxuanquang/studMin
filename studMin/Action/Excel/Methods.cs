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

        public static string Semester(int num)
        {
            string convert = String.Empty;
            switch (num)
            {
                case 0:
                    convert = "Hè";
                    break;
                case 1:
                    convert = "I";
                    break;
                case 2:
                    convert = "II";
                    break;
            }
            return convert;
        }

        public static int ParseSemester(string msg)
        {
            if (String.IsNullOrEmpty(msg)) return -1;

            string[] split = msg.Split(' ');
            if (split.Length == 3) msg = split[2];

            int convert = -1;
            msg = msg.Trim().ToLower();
            switch (msg)
            {
                case "hè":
                    convert = 0;
                    break;
                case "i":
                    convert = 1;
                    break;
                case "ii":
                    convert = 2;
                    break;
            }
            return convert;
        }
    }
}
