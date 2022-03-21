using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Action.Excel
{
    internal class ScheduleTeacher : CommonExcel
    {
        private (string, string) MaGiaoVien(string msg)
        {
            return ("C2", String.Format("Mã giáo viên: {0}", msg));
        }

        private (string, string) GVCN(string msg)
        {
            return ("D2", String.Format("Họ và tên: {0}", msg));
        }

        private (string, string) NamHoc(string msg)
        {
            return ("C3", String.Format("Năm học: {0}", msg));
        }

        private (string, string) HocKy(int msg)
        {
            string convert = null;
            switch (msg)
            {
                case 0:
                    convert = "I";
                    break;
                case 1:
                    convert = "II";
                    break;
                case 2:
                    convert = "Hè";
                    break;
            }
            return ("D3", String.Format("Học kỳ: {0}", convert));
        }

        private (string, string) NgayApDung(DateTime dateTime)
        {
            return ("E3", String.Format("Áp dụng từ: {0}", dateTime.ToString("dd/MM/yyyy")));
        }

        private const int StartColumn = 3;
        private const int StartRowClass = 6;
        private const int MaxPeriod = 5;
        private const int offset = 1;

        public class Info
        {
            private string mgv;
            private string teacher;
            private int startYear;
            private int semester;
            private DateTime dateApply;
            private string msg;

            public Info(ScheduleAllTeacher.Info info = null)
            {
                if (info == null) return;
                startYear = Convert.ToInt32(info.NamHoc.Split(new string[] { " - " }, StringSplitOptions.None)[0]);
                semester = info.HocKy;
                dateApply = info.NgayApDung;
                msg = info.ThongTinThem;
            }

            public string MaGiaoVien
            {
                get { return mgv; }
                set { mgv = value; }
            }

            public string GiaoVien
            {
                get { return teacher; }
                set { teacher = value; }
            }

            public string NamHoc
            {
                get { return String.Format("{0} - {1}", startYear, startYear + 1); }
                set { startYear = Convert.ToInt32(value.Split(new string[] { " - " }, StringSplitOptions.None)[0]); }
            }

            public int HocKy
            {
                get { return semester; }
                set { semester = value; }
            }

            public DateTime NgayApDung
            {
                get { return dateApply; }
                set { dateApply = value; }
            }

            public string ThongTinThem
            {
                get { return msg; }
                set { msg = value; }
            }
        }

        List<ScheduleAllTeacher.Item> data;

        public ScheduleTeacher()
        {
            this.template = StoragePath.TemplateScheduleTeacher;
            data = new List<ScheduleAllTeacher.Item>();
            InitExcel();
        }

        public override void InsertInfo(dynamic info)
        {
            try
            {
                if (info == null) return;
                Info clone = info as Info;

                (string, string) Info_MaGiaoVien = MaGiaoVien(clone.MaGiaoVien);
                (string, string) Info_GVCN = GVCN(clone.GiaoVien);
                (string, string) Info_HocKy = HocKy(clone.HocKy);
                (string, string) Info_NamHoc = NamHoc(clone.NamHoc);
                (string, string) Info_NgayApDung = NgayApDung(clone.NgayApDung);

                sheet.get_Range(Info_MaGiaoVien.Item1).Value = Info_MaGiaoVien.Item2;
                sheet.get_Range(Info_GVCN.Item1).Value = Info_GVCN.Item2;
                sheet.get_Range(Info_HocKy.Item1).Value = Info_HocKy.Item2;
                sheet.get_Range(Info_NamHoc.Item1).Value = Info_NamHoc.Item2;
                sheet.get_Range(Info_NgayApDung.Item1).Value = Info_NgayApDung.Item2;
            }
            catch
            {
                //MessageBox.Show("Lỗi");
                throw new Exception();
            }
        }

        public override void InsertItem(dynamic item)
        {
            ScheduleAllTeacher.Item clone = item as ScheduleAllTeacher.Item;

            try
            {
                if (clone == null) return;

                int startIndexColumn = ((int)clone.NgayHoc - 1) + StartColumn;
                int startIndexRow = StartRowClass + clone.TietBatDau + (clone.Buoi == "Afternoon" ? MaxPeriod + offset : 0) - 1;

                string columnName = GetExcelColumnName(startIndexColumn);

                if (clone.TietBatDau != 1)
                {
                    sheet.get_Range(columnName + startIndexRow.ToString()).Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                }

                sheet.get_Range(columnName + startIndexRow.ToString() + ":" + columnName + (startIndexRow + clone.TietKeoDai - 1).ToString()).Merge();
                sheet.get_Range(columnName + startIndexRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Transparent);
                sheet.get_Range(columnName + startIndexRow.ToString()).Value = clone.Lop + " - " + clone.MonHoc;

                if (clone.TietBatDau + clone.TietKeoDai < MaxPeriod + 1)
                {
                    sheet.get_Range(columnName + (startIndexRow + clone.TietKeoDai - 1).ToString()).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                }
            }
            catch
            {
                //MessageBox.Show("Lỗi");
                throw new Exception();
            }
        }
    }
}
