using Microsoft.Office.Interop.Excel;
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
        private const int RowTitle = 5;
        private const int StartRowIndex = 6;

        private const string locationClass = "B2";
        private const string locationTeacher = "C2";
        private const string locationYear = "C3";
        private const string locationSemester = "B3";
        private const string locationSubject = "A1";

        public Coefficient coefficient = null;

        public class Coefficient
        {
            private int coefficientOral = 1;
            private int coefficientRegular = 1;
            private int coefficientMidTerm = 2;
            private int coefficientFinal = 3;

            public int HeSoDiemMieng
            {
                get { return coefficientOral; }
                set { coefficientOral = value; }
            }

            public int HeSoDiem15Phut
            {
                get { return coefficientRegular; }
                set { coefficientRegular = value; }
            }

            public int HeSoDiem1Tiet
            {
                get { return coefficientMidTerm; }
                set { coefficientMidTerm = value; }
            }

            public int HeSoDiemHocKy
            {
                get { return coefficientFinal; }
                set { coefficientFinal = value; }
            }
        }

        public string Fomular(int row, Coefficient coefficient, List<(string, string, int)> rangeExcel)
        {
            //{0} dòng đang tương tác
            //{coefficient.HeSoDiemMieng} hệ số cho điểm miệng
            //{coefficient.HeSoDiem15Phut}} hệ số cho điểm 15p
            //{coefficient.HeSoDiem1Tiet} hệ số cho điểm 1 tiết
            //{coefficient.HeSoDiemHocKy} hệ số cho điểm học kỳ
            //{maxOral} số cột tối đa của cột điểm miệng
            //{maxRegular} số cột tối đa của cột điểm 15p
            //{maxMidTerm} số cột tối đa của cột điểm 1 tiết

            (string, string, int) rangeExcelOral = rangeExcel[0];
            (string, string, int) rangeExcelRegular = rangeExcel[1];
            (string, string, int) rangeExcelMidTerm = rangeExcel[2];
            (string, string, int) rangeExcelFinal = rangeExcel[3];

            return $"=ROUNDUP((SUM({rangeExcelOral.Item1}{row}:{rangeExcelOral.Item2}{row})*{coefficient.HeSoDiemMieng} + SUM({rangeExcelRegular.Item1}{row}:{rangeExcelRegular.Item2}{row})*{coefficient.HeSoDiem15Phut} + SUM({rangeExcelMidTerm.Item1}{row}:{rangeExcelMidTerm.Item2}{row})*{coefficient.HeSoDiem1Tiet} + {rangeExcelFinal.Item1}{row}*{coefficient.HeSoDiemHocKy}) / ({rangeExcelOral.Item3} - COUNTIF({rangeExcelOral.Item1}{row}:{rangeExcelOral.Item2}{row},\"\")*{coefficient.HeSoDiemMieng} + ({rangeExcelRegular.Item3} - COUNTIF({rangeExcelRegular.Item1}{row}:{rangeExcelRegular.Item2}{row},\"\")*{coefficient.HeSoDiem15Phut}) + ({rangeExcelMidTerm.Item3} - COUNTIF({rangeExcelMidTerm.Item1}{row}:{rangeExcelMidTerm.Item2}{row},\"\"))*{coefficient.HeSoDiem1Tiet} + {coefficient.HeSoDiemHocKy}), 2)";
        }

        public class Item
        {
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

            public void AddOral(List<double> marks)
            {
                if (oralMark == null) oralMark = new List<double>();
                if (marks != null)
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
                if (marks != null)
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
                if (marks != null)
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

        public Subject(bool isReadOnly, string pathFile = "")
        {
            if (isReadOnly && String.IsNullOrEmpty(pathFile)) throw new Exception("Path file unavailable");
            this.template = isReadOnly ? pathFile : StoragePath.TemplateSubject;
            this.isReadOnly = isReadOnly;
            data = new List<Item>();
            coefficient = new Coefficient();
            InitExcel();
        }

        public override void InsertInfo(dynamic info)
        {
            try
            {
                if (info == null) return;
                Info clone = info as Info;

                string convert = Methods.Semester(clone.HocKy);

                sheet.get_Range(locationClass).Value = String.Format("Lớp: {0}", clone.Lop);
                sheet.get_Range(locationTeacher).Value = String.Format("Giáo viên bộ môn: {0}", clone.GiaoVien);
                sheet.get_Range(locationSemester).Value = String.Format("Học kỳ: {0}", convert);
                sheet.get_Range(locationYear).Value = String.Format("Năm học: {0}", clone.NamHoc);
                sheet.get_Range(locationSubject).Value = String.Format("BẢNG ĐIỂM MÔN {0}", clone.MonHoc.ToUpper());
            }
            catch
            {
                //MessageBox.Show("Lỗi");
                throw new Exception();
            }
        }

        public override object SelectInfo()
        {
            Info info = new Info();

            info.Lop = ((string)sheet.get_Range(locationClass).Value).Split(new string[] { "Lớp: " }, StringSplitOptions.None)[1];
            info.GiaoVien = ((string)sheet.get_Range(locationTeacher).Value).Split(new string[] { "Giáo viên bộ môn: " }, StringSplitOptions.None)[1];

            string convert = ((string)sheet.get_Range(locationSemester).Value).Split(new string[] { "Học kỳ: " }, StringSplitOptions.None)[1];
            info.HocKy = Methods.ParseSemester(convert);

            info.NamHoc = ((string)sheet.get_Range(locationYear).Value).Split(new string[] { "Năm học: " }, StringSplitOptions.None)[1];

            string subject = ((string)sheet.get_Range(locationSubject).Value).Split(new string[] { "BẢNG ĐIỂM MÔN " }, StringSplitOptions.None)[1].ToLower();
            subject = Char.ToUpper(subject[0]) + subject.Substring(1);
            info.MonHoc = subject;

            return info;
        }

        private void InsertColumn(List<double> values, ref string columnName, ref int indexColumn, int lastRow, int currentScoreColumnNumber)
        {
            if (values != null)
            {
                int counts = values.Count;
                int addColumn = counts - currentScoreColumnNumber + 1;
                int maxColumnScore = Math.Max(currentScoreColumnNumber - 1, values.Count) + 1;

                for (int index = 0; index < addColumn; index++)
                {
                    sheet.Columns[GetExcelColumnName(indexColumn + currentScoreColumnNumber + index - 1)].Insert();
                }

                for (int index = 0; index < maxColumnScore; index++)
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
                InsertColumn(values, ref columnName, ref indexColumn, lastRow, countMerge(indexColumn));

                values = clone.Diem15Phut;
                InsertColumn(values, ref columnName, ref indexColumn, lastRow, countMerge(indexColumn));

                values = clone.Diem1Tiet;
                InsertColumn(values, ref columnName, ref indexColumn, lastRow, countMerge(indexColumn));

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.DiemCuoiKy;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Formula = "=0";
            }
            catch
            {
                //MessageBox.Show("Lỗi");
                throw new Exception();
            }
        }

        public void SetFomular()
        {
            List<(string, string, int)> rangeExcel = UpdateRangeExcel();

            int lastRow = FindLastRowUsed();
            string columnName = GetExcelColumnName(FindLastColumnUsed());

            for (int indexRow = StartRowIndex; indexRow <= lastRow; indexRow++)
            {
                sheet.get_Range(columnName + indexRow.ToString()).Formula = Fomular(indexRow, coefficient, rangeExcel);
            }
        }

        private List<(string, string, int)> UpdateRangeExcel()
        {
            List<(string, string, int)> rangeExcel = new List<(string, string, int)>();

            int lastColumn = FindLastColumnUsed();
            int count = 0;
            int countCellMerge = 0;

            for (int index = 1; index <= lastColumn; index++)
            {
                countCellMerge = countMerge(index);
                if (countCellMerge > 1)
                {
                    count++;
                    rangeExcel.Add((GetExcelColumnName(index), GetExcelColumnName(index + countCellMerge - 1), countCellMerge));
                    index += countCellMerge - 1;
                }
                if (count == 3)
                {
                    rangeExcel.Add((GetExcelColumnName(index + 1), "", 1));
                    break;
                }
            }

            return rangeExcel;
        }

        private int countMerge(int indexColumn)
        {
            int currentScoreColumnNumber = 0;
            Range cell = sheet.Cells[RowTitle, indexColumn];
            if (cell != null && cell.Value != null)
            {
                return currentScoreColumnNumber = cell.MergeArea.Count;
            }
            return 1;
        }

        public override object SelectItem(object argument)
        {
            List<Item> list = new List<Item>();

            Item item = null;
            List<double> oralMark = null;
            List<double> regularMark = null;
            List<double> midTermMark = null;

            int endRow = FindLastRowUsed();
            int endColumn = FindLastColumnUsed();

            for (int row = StartRowIndex; row <= endRow; row++)
            {
                item = new Item();
                oralMark = new List<double>();
                regularMark = new List<double>();
                midTermMark = new List<double>();

                int countGroup = 0;
                bool isLoadedFinalScore = false;
                for (int column = StartColumnIndex + 1; column <= endColumn; column++)
                {
                    int countCellMerge = countMerge(column);
                    object cell = null;
                    if (countCellMerge > 1)
                    {
                        countGroup++;
                        for (int index = 0; index < countCellMerge; index++)
                        {
                            cell = sheet.get_Range(GetExcelColumnName(column + index) + row.ToString()).Value;
                            if (cell == null) continue;

                            switch (countGroup)
                            {
                                case 1:
                                    oralMark.Add(Convert.ToDouble(cell));
                                    break;
                                case 2:
                                    regularMark.Add(Convert.ToDouble(cell));
                                    break;
                                case 3:
                                    midTermMark.Add(Convert.ToDouble(cell));
                                    break;
                            }
                        }
                        column += countCellMerge - 1;
                    }
                    else if (countCellMerge == 1 && !isLoadedFinalScore)
                    {
                        cell = sheet.get_Range(GetExcelColumnName(column) + row.ToString()).Value;
                        if (cell == null) continue;
                        switch (countGroup)
                        {
                            case 0:
                                item.HoTen = cell.ToString();
                                break;
                            case 3:
                                item.DiemCuoiKy = Convert.ToDouble(cell);
                                isLoadedFinalScore = true;
                                break;
                        }
                    }
                }

                item.AddOral(oralMark);
                item.AddRegular(regularMark);
                item.AddMidTearm(midTermMark);

                list.Add(item);
            }

            return list;
        }
    }
}
