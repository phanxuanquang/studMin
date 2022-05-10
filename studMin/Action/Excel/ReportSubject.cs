using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Action.Excel
{
    internal class ReportSubject : ReportCommon
    {
        private string locationSubject = "B2";
        public class Info
        {
            private string subject;
            private int semester;
            private string schoolYear;

            public int HocKy
            {
                get { return semester; }
                set { semester = value; }
            }

            public string NamHoc
            {
                get { return schoolYear; }
                set { schoolYear = value; }
            }

            public string MonHoc
            {
                get { return subject; }
                set { subject = value; }
            }
        }

        protected (string, string) MonHoc(string msg)
        {
            return (locationSubject, String.Format("Môn học: {0}", msg));
        }

        public ReportSubject()
        {
            locationSchoolYear = "D2";
            locationSemester = "C2";
            title = "BẢNG BÁO CÁO TỔNG KẾT MÔN HỌC";
        }

        public override void InsertInfo(dynamic info)
        {
            try
            {
                if (info == null) return;

                Info clone = info as Info;

                (string, string) Info_HocKy = HocKy(clone.HocKy);
                (string, string) Info_NamHoc = NamHoc(clone.NamHoc);
                (string, string) Info_MonHoc = MonHoc(clone.MonHoc);

                sheet.get_Range(locationTitle).Value = title;
                sheet.get_Range(Info_MonHoc.Item1).Value = Info_MonHoc.Item2;
                sheet.get_Range(Info_HocKy.Item1).Value = Info_HocKy.Item2;
                sheet.get_Range(Info_NamHoc.Item1).Value = Info_NamHoc.Item2;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
