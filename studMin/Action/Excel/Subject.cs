using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Action.Excel
{
    internal class Subject : CommonExcel
    {
        private const int StartColumnIndex = 1;
        private const int StartRowIndex = 6;

        private (string, string) Lop(string msg)
        {
            return ("B2", String.Format("Lớp: {0}", msg));
        }

        private (string, string) GVBM(string msg)
        {
            return ("C2", String.Format("Giáo viên bộ môn: {0}", msg));
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
            return ("B3", String.Format("Học kỳ: {0}", convert));
        }

        private (string, string) MonHoc(string msg)
        {
            return ("A1", String.Format("BẢNG ĐIỂM MÔN {0}", msg.ToUpper()));
        }

        public class Item
        {
            public static int MaxOralMark = 5;
            public static int MaxRegularMark = 5;
            public static int MaxMidTermMark = 3;
            public static int MaxEndTerm = 1;

            private List<double> oralMark;
            private List<double> regularMark;
            private List<double> midTerm;
            private double endTerm;
            private string name;

            public List<double> DiemMieng
            {
                get { return new List<double>(oralMark); }
                set { oralMark = new List<double>(value); }
            }

            public List<double> Diem15Phut
            {
                get { return new List<double>(regularMark); }
                set { regularMark = new List<double>(value); }
            }

            public List<double> Diem1Tiet
            {
                get { return new List<double>(midTerm); }
                set { midTerm = new List<double>(value); }
            }

            public double DiemCuoiKy
            {
                get { return endTerm; }
                set { endTerm = value; }
            }

            public string HoTen
            {
                get { return name; }
                set { name = value; }
            }

            public enum Factor
            {
                Oral,
                Regular,
                MidTerm,
                EndTerm
            }

            public int GetFactor(Factor factor)
            {
                switch (factor)
                {
                    case Factor.Oral:
                        return 1;
                    case Factor.Regular:
                        return 1;
                    case Factor.MidTerm:
                        return 2;
                    case Factor.EndTerm:
                        return 3;
                }
                return 0;
            }

            public int GetAllFactor()
            {
                int total = 0;

                if (oralMark != null)
                {
                    total = 1 * oralMark.Count;
                }

                if (regularMark != null)
                {
                    total = 1 * regularMark.Count;
                }

                if (midTerm != null)
                {
                    total = 2 * midTerm.Count;
                }

                total += 3;

                return total;
            }

            public string Fomular(int row)
            {
                //{0} dòng đang tương tác
                //{1} hệ số cho điểm miệng
                //{2} hệ số cho điểm 15p
                //{3} hệ số cho điểm 1 tiết
                //{4} số cột tối đa của cột điểm miệng
                //{5} số cột tối đa của cột điểm 15p
                //{6} số cột tối đa của cột điểm 1 tiết
                return String.Format("=ROUNDUP((SUM(C{0}:G{0})*{1} + SUM(H{0}:L{0})*{1} + SUM(M{0}:O{0})*{2} + P{0}*{3}) / ({4} - COUNTIF(C{0}:G{0},\"\")*{1} + {5} - COUNTIF(H{0}:L{0},\"\")*{1} + ({6} - COUNTIF(M{0}:O{0},\"\"))*{2} + {3}), 2)", row, GetFactor(Factor.Oral), GetFactor(Factor.MidTerm), GetFactor(Factor.EndTerm), MaxOralMark, MaxRegularMark, MaxMidTermMark);
            }

            public void AddOral(List<double> marks)
            {
                if (oralMark == null) oralMark = new List<double>();
                if (marks != null && oralMark.Count + marks.Count < Item.MaxOralMark + 1)
                {
                    for (int index = 0; index < marks.Count; index++)
                    {
                        oralMark.Add(marks[index]);
                    }
                }
                else throw new Exception();
            }

            public void AddRegular(List<double> marks)
            {
                if (regularMark == null) regularMark = new List<double>();
                if (marks != null && regularMark.Count + marks.Count < Item.MaxRegularMark + 1)
                {
                    for (int index = 0; index < marks.Count; index++)
                    {
                        regularMark.Add(marks[index]);
                    }
                }
                else throw new Exception();
            }

            public void AddMidTearm(List<double> marks)
            {
                if (midTerm == null) midTerm = new List<double>();
                if (marks != null && midTerm.Count + marks.Count < Item.MaxMidTermMark + 1)
                {
                    for (int index = 0; index < marks.Count; index++)
                    {
                        midTerm.Add(marks[index]);
                    }
                }
                else throw new Exception();
            }
        }

        public class Info : ListStudent.Info
        {
            private string subject;

            public string MonHoc 
            { 
                get { return subject; } 
                set { subject = value; } 
            }
        }

        List<Item> data;

        public Subject()
        {
            template = StoragePath.TemplateSubject;
            data = new List<Item>();
            InitExcel();
        }

        public override void InsertInfo(dynamic info)
        {
            try
            {
                if (info == null) return;
                Info clone = info as Info;

                (string, string) Info_Lop = Lop(clone.Lop);
                (string, string) Info_GVCN = GVBM(clone.GiaoVien);
                (string, string) Info_HocKy = HocKy(clone.HocKy);
                (string, string) Info_NamHoc = NamHoc(clone.NamHoc);
                (string, string) Info_MonHoc = MonHoc(clone.MonHoc);

                sheet.get_Range(Info_Lop.Item1).Value = Info_Lop.Item2;
                sheet.get_Range(Info_GVCN.Item1).Value = Info_GVCN.Item2;
                sheet.get_Range(Info_HocKy.Item1).Value = Info_HocKy.Item2;
                sheet.get_Range(Info_NamHoc.Item1).Value = Info_NamHoc.Item2;
                sheet.get_Range(Info_MonHoc.Item1).Value = Info_MonHoc.Item2;
            }
            catch
            {
                //MessageBox.Show("Lỗi");
                throw new Exception();
            }
        }

        private void InsertColumn(List<double> values, ref string columnName, ref int indexColumn, int lastRow, int MaxMark)
        {
            if (values != null)
            {
                int counts = values.Count;
                for (int index = 0; index < MaxMark; index++)
                {
                    columnName = GetExcelColumnName(indexColumn++);
                    if (counts > index)
                    {
                        sheet.get_Range(columnName + lastRow.ToString()).Value = values[index];
                    }
                    else
                    {
                        sheet.get_Range(columnName + lastRow.ToString()).Value = null;
                    }
                }
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

                string columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = No;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.HoTen;

                List<double> values = clone.DiemMieng;
                InsertColumn(values, ref columnName, ref indexColumn, lastRow, Item.MaxOralMark);

                values = clone.Diem15Phut;
                InsertColumn(values, ref columnName, ref indexColumn, lastRow, Item.MaxRegularMark);

                values = clone.Diem1Tiet;
                InsertColumn(values, ref columnName, ref indexColumn, lastRow, Item.MaxMidTermMark);

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.DiemCuoiKy;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Formula = clone.Fomular(lastRow);
            }
            catch
            {
                //MessageBox.Show("Lỗi");
                throw new Exception();
            }
        }
    }
}
