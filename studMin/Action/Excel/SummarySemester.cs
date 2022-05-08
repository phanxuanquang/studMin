using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace studMin.Action.Excel
{
    internal class SummarySemester : CommonExcel
    {
        private const int StartColumnIndex = 1;
        private const int StartRowIndex = 7;

        private (string, string) HocKy(int num)
        {
            string convert = null;
            switch (num)
            {
                case 1:
                    convert = "I";
                    break;
                case 2:
                    convert = "II";
                    break;
            }
            return ("B2", String.Format("Học kỳ: {0}", convert));
        }

        private (string, string) NamHoc(string msg)
        {
            return ("C2", String.Format("Năm học: {0}", msg));
        }

        public class Item
        {
            private string className;
            private int quantity;
            private int passQuantity;
            private double passRatio;

            public string Lop
            {
                get { return className; }
                set { className = value; }
            }

            public int SiSo
            {
                get { return quantity; }
                set { quantity = value; }
            }

            public int SoLuongDat
            {
                get { return passQuantity; }
                set { passQuantity = value; }
            }

            public double TiLeDat
            {
                get { return passRatio; }
                set { passRatio = Math.Round(1.0 * SoLuongDat / SiSo, 2); }
            }
        }

        List<Item> data;
        public SummarySemester()
        {
            template = StoragePath.TemplateSummarySemester;
            data = new List<Item>();
            InitExcel();
        }

        public class SummaryInfo
        {
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
        }

        public override void InsertInfo(dynamic info)
        {
            try
            {
                if (info == null) return;

                SummaryInfo clone = info as SummaryInfo;

                (string, string) Info_HocKy = HocKy(clone.HocKy);
                (string, string) Info_NamHoc = NamHoc(clone.NamHoc);

                sheet.get_Range(Info_HocKy.Item1).Value = Info_HocKy.Item2;
                sheet.get_Range(Info_NamHoc.Item1).Value = Info_NamHoc.Item2;
            } 
            catch
            {
                throw new Exception();
            }
        }

        int rowUsed = 1;
        public override void InsertItem(dynamic item)
        {
            Item clone = item as Item;

            try
            {
                if (item == null) return;

                int indexColumn = StartColumnIndex;
                int lastRow = FindLastRowUsed() + rowUsed;
                int No = lastRow - StartRowIndex + 1;

                string columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = No;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.Lop;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.SiSo;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.SoLuongDat;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.TiLeDat;

                rowUsed++;
            }
            catch { }
        }

        public override object SelectInfo()
        {
            return null;
        }

        public override object SelectItem(object argument)
        {
            return null;
        }
    }
}
