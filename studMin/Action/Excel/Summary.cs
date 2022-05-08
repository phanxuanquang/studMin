using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Action.Excel
{
    internal class Summary : CommonExcel
    {
        private const int StartColumnIndex = 1;
        private const int StartRowIndex = 7;

        private (string, string) Lop(string msg)
        {
            return ("B2", String.Format("Lớp: {0}", msg));
        }

        private (string, string) GVCN(string msg)
        {
            return ("C2", String.Format("Giáo viên chủ nhiệm: {0}", msg));
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

        private (string, string) SiSo(int member)
        {
            return ("B3", String.Format("Sỉ số: {0}", member));
        }

        public class Item
        {
            private string name;
            private double math;
            private double literature;
            private double physic;
            private double bio;
            private double chemistry;
            private double history;
            private double civicEducation;
            private double physicalEducation;

            public enum Conduct
            {
                VeryGood, //giỏi
                Good, //khá
                Average, //trung bình
                Weak //yếu
            }

            public enum Classified
            {
                Excellent, //xuất sắc
                VeryGood, //giỏi
                Good, //khá
                Average, //trung bình
                Weak //yếu
            }

            private Conduct conduct;

            public string Hoten
            {
                get { return name; }
                set { name = value; }
            }

            public double Toan
            {
                get { return math; }
                set { math = value; }
            }

            public double Van
            {
                get { return literature; }
                set { literature = value; }
            }

            public double Ly
            {
                get { return physic; }
                set { physic = value; }
            }

            public double Sinh
            {
                get { return bio; }
                set { bio = value; }
            }

            public double Hoa
            {
                get { return chemistry; }
                set { chemistry = value; }
            }

            public double Su
            {
                get { return history; }
                set { history = value; }
            }

            public double GDCD
            {
                get { return civicEducation; }
                set { civicEducation = value; }
            }

            public double TheDuc
            {
                get { return physicalEducation; }
                set { physicalEducation = value; }
            }

            public Conduct HanhKiem
            {
                get { return conduct; }
                set { conduct = value; }
            }

            public string HanhKiemString
            {
                get
                {
                    switch (conduct)
                    {
                        case Conduct.VeryGood: return "Giỏi";
                        case Conduct.Good: return "Khá";
                        case Conduct.Average: return "Trung bình";
                        case Conduct.Weak: return "Yếu";
                    }
                    return "";
                }
            }

            private double Average()
            {
                return (math + literature + physic + bio + chemistry + history + civicEducation + physicalEducation) / 8;
            }

            public Classified XetLoai()
            {
                double average = Average();
                switch (conduct)
                {
                    case Conduct.VeryGood:
                        if (average >= 9) return Classified.Excellent;
                        if (average >= 8) return Classified.VeryGood;
                        if (average >= 6.5) return Classified.Good;
                        if (average >= 5) return Classified.Average;
                        return Classified.Weak;
                    case Conduct.Good:
                        if (average >= 9) return Classified.VeryGood;
                        if (average >= 8) return Classified.Good;
                        if (average >= 6.5) return Classified.Average;
                        return Classified.Weak;
                    case Conduct.Average:
                        if (average >= 9) return Classified.Good;
                        if (average >= 8) return Classified.Average;
                        return Classified.Weak;
                    case Conduct.Weak:
                        return Classified.Weak;
                }
                return Classified.Weak;
            }

            public string XepLoai
            {
                get
                {
                    switch (XetLoai())
                    {
                        case Classified.Excellent: return "Xuất sắc";
                        case Classified.VeryGood: return "Giỏi";
                        case Classified.Good: return "Khá";
                        case Classified.Average: return "Trung bình";
                        case Classified.Weak: return "Yếu";
                    }
                    return "";
                }
            }
        }

        List<Item> data;

        public Summary()
        {
            template = StoragePath.TemplateSummary;
            data = new List<Item>();
            InitExcel();
        }

        public override void InsertInfo(dynamic info)
        {
            try
            {
                if (info == null) return;
                ListStudent.Info clone = info as ListStudent.Info;

                (string, string) Info_Lop = Lop(clone.Lop);
                (string, string) Info_GVCN = GVCN(clone.GiaoVien);
                (string, string) Info_HocKy = HocKy(clone.HocKy);
                (string, string) Info_NamHoc = NamHoc(clone.NamHoc);
                (string, string) Info_SiSo = SiSo(clone.SiSo);

                sheet.get_Range(Info_Lop.Item1).Value = Info_Lop.Item2;
                sheet.get_Range(Info_GVCN.Item1).Value = Info_GVCN.Item2;
                sheet.get_Range(Info_HocKy.Item1).Value = Info_HocKy.Item2;
                sheet.get_Range(Info_NamHoc.Item1).Value = Info_NamHoc.Item2;
                sheet.get_Range(Info_SiSo.Item1).Value = Info_SiSo.Item2;
            }
            catch
            {
                //MessageBox.Show("Lỗi");
                throw new Exception();
            }
        }

        public override void InsertItem(dynamic item)
        {
            Item clone = item as Item;
            try
            {
                if (item == null) return;

                int indexColumn = StartColumnIndex;
                int lastRow = FindLastRowUsed() + 1;
                int No = lastRow - StartRowIndex + 1;

                (string, string) Info_SiSo = SiSo(No);
                sheet.get_Range(Info_SiSo.Item1).Value = Info_SiSo.Item2;

                string columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = No;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.Hoten;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.Toan;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.Van;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.Ly;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.Sinh;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.Hoa;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.Su;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.GDCD;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.TheDuc;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Formula = String.Format("=ROUNDUP(AVERAGE(C{0}:J{0}), 2)", lastRow);

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.HanhKiemString;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.XepLoai;
            }
            catch
            {
                //MessageBox.Show("Lỗi");
                throw new Exception();
            }
        }

        public override object SelectInfo()
        {
            //throw new NotImplementedException();
            return null;
        }

        public override object SelectItem(object argument)
        {
            //throw new NotImplementedException();
            return null;
        }
    }
}
