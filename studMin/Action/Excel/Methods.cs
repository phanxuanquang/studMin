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
                default:
                    convert = "Mọi học kỳ";
                    break ;
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

        public static string DateApply(DateTime date, string scheduleName)
        {
            return String.Format("{0} - {1}", date.ToString("dd/MM/yyyy"), scheduleName);
        }

        public static (DateTime, string) DateApplyParse(string msg)
        {
            string[] split = msg.Split(new string[] { " - " }, StringSplitOptions.None);
            return (Methods.TryParse(split[0]), split[1]);
        }

        public static string HocKy(int msg)
        {
            return String.Format("Học kỳ: {0}", Methods.Semester(msg));
        }
    }
}
