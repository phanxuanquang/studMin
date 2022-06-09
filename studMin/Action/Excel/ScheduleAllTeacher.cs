using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studMin.Action.Excel
{
    internal class ScheduleAllTeacher : CommonExcel
    {
        private const string nameSchool = "A1";
        private const string title = "A2";

        private const int StartColumnClass = 4;
        private const int StartRowOfClass = 4;
        private const int RowClass = 3;
        private const int EndRowOfClass = 123;
        private const int MaxPeriod = 5;
        private const int RowOfPeriod = 2;

        List<Item> data = new List<Item>();

        public ScheduleAllTeacher(bool isReadOnly = false, string pathFile = "", string sheetNamePrimary = "")
        {
            if (isReadOnly && String.IsNullOrEmpty(pathFile)) throw new Exception("Path file unavailable");
            this.template = isReadOnly ? pathFile : StoragePath.TemplateScheduleAllTeacher;
            this.isReadOnly = isReadOnly;
            InitExcel();
            if (!String.IsNullOrEmpty(sheetNamePrimary)) sheet.Name = sheetNamePrimary;
        }

        public class Info
        {
            private string school;
            private int No;
            private int semester;
            private int startYear;
            private DateTime dateApply;
            private string msg;

            public string Truong
            {
                get { return school; }
                set { school = value; }
            }

            public int BieuMauSo
            {
                get { return No; }
                set { No = value; }
            }

            public int HocKy
            {
                get { return semester; }
                set { semester = value; }
            }

            public string NamHoc
            {
                get { return String.Format("{0} - {1}", startYear, startYear + 1); }
                set { startYear = Convert.ToInt32(value.Split(new string[] { " - " }, StringSplitOptions.None)[0]); }
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

            public string GetHocKy()
            {
                return (Methods.Semester(HocKy));
            }

            public string Title()
            {
                string dateOfWeekVNese = string.Empty;
                switch (dateApply.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        dateOfWeekVNese = "CHỦ NHẬT";
                        break;
                    case DayOfWeek.Monday:
                        dateOfWeekVNese = "THỨ HAI";
                        break;
                    case DayOfWeek.Tuesday:
                        dateOfWeekVNese = "THỨ BA";
                        break;
                    case DayOfWeek.Wednesday:
                        dateOfWeekVNese = "THỨ TƯ";
                        break;
                    case DayOfWeek.Thursday:
                        dateOfWeekVNese = "THỨ NĂM";
                        break;
                    case DayOfWeek.Friday:
                        dateOfWeekVNese = "THỨ SÁU";
                        break;
                    case DayOfWeek.Saturday:
                        dateOfWeekVNese = "THỨ BẢY";
                        break;
                }
                return String.Format("THỜI KHÓA BIỂU SỐ {0} - HỌC KỲ {1} - NĂM HỌC {2}, ÁP DỤNG TỪ {3}, {4}", BieuMauSo, GetHocKy().ToUpper(), NamHoc, dateOfWeekVNese, NgayApDung.ToString("dd/MM/yyyy"));
            }

            public static Info Parse(string value)
            {
                Info info = new Info();

                string[] split = value.Split(new string[] { " - " }, StringSplitOptions.None);

                try
                {
                    string[] bieumauso = split[0].Split(' ');
                    info.BieuMauSo = int.Parse(bieumauso[bieumauso.Length - 1]);

                    string[] hocky = split[1].Split(' ');
                    info.HocKy = Methods.ParseSemester(hocky[hocky.Length - 1]);

                    string[] namhoc = split[2].Split(' ');
                    info.NamHoc = namhoc[namhoc.Length - 1];

                    string[] apdung = split[3].Split(' ');
                    info.NgayApDung = Methods.TryParse(apdung[apdung.Length - 1]);

                    return info;
                }
                catch
                {
                    return null;
                }
            }
        }

        public class Item
        {
            private string _teacher;
            private int _start;
            private int _duration;
            private int _date;
            private Guid _idTeacher;
            private Guid _idClass;
            private enum _session
            {
                Morning,
                Afternoon,
            }
            private _session session;
            private string _subject;
            private string _class;

            public Guid IDTeacher
            {
                get { return _idTeacher; }
                set { _idTeacher = value; }
            }

            public Guid IDClass
            {
                get { return _idClass; }
                set { _idClass = value; }
            }

            public string Lop
            {
                get { return _class; }
                set { _class = value; }
            }

            public int NgayHoc
            {
                get { return _date; }
                set { _date = value; }
            }

            public string GiaoVien
            {
                get { return _teacher; }
                set { _teacher = value; }
            }

            public int TietBatDau
            {
                get { return _start; }
                set { _start = value; }
            }

            public int TietKeoDai
            {
                get { return _duration; }
                set { _duration = value; }
            }

            public string MonHoc
            {
                get { return _subject; }
                set { _subject = value; }
            }

            public string Buoi
            {
                get { return session.ToString(); }
                set
                {
                    switch (value)
                    {
                        case "M":
                            session = _session.Morning;
                            break;
                        case "A":
                            session = _session.Afternoon;
                            break;
                    }
                }
            }

            public Item Clone()
            {
                return new Item()
                {
                    Buoi = this.Buoi == "Morning" ? "M" : "A",
                    GiaoVien = this.GiaoVien,
                    Lop = this.Lop,
                    MonHoc = this.MonHoc,
                    NgayHoc = this.NgayHoc,
                    TietBatDau = this.TietBatDau,
                    TietKeoDai = this.TietKeoDai
                };
            }
        }

        private void NewClass(string nameClass)
        {
            Microsoft.Office.Interop.Excel.Range oRng = sheet.Range["D" + RowClass.ToString()];
            oRng.EntireColumn.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Microsoft.Office.Interop.Excel.XlInsertFormatOrigin.xlFormatFromRightOrBelow);
            sheet.get_Range("D" + RowClass.ToString()).Value = nameClass;
            Range formatCell = sheet.get_Range("D" + StartRowOfClass + ":" + "D" + EndRowOfClass);
            formatCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            formatCell.Borders.LineStyle = XlLineStyle.xlLineStyleNone;
            formatCell.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;

            for (int index = StartRowOfClass; index <= EndRowOfClass; index += 10)
            {
                if (index % 10 == 4)
                {
                    sheet.Cells[index, StartColumnClass].Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                    sheet.Cells[index, StartColumnClass].Borders[XlBordersIndex.xlEdgeTop].Weight = XlBorderWeight.xlMedium;
                }
            }

            //Sửa không có border ở cuối bảng
            sheet.Cells[EndRowOfClass, StartColumnClass].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            sheet.Cells[EndRowOfClass, StartColumnClass].Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlMedium;
        }

        private bool CheckExist(int startIndex, int offset, string lop)
        {
            var temp = sheet.get_Range(String.Format("D{0}:D{1}", startIndex, startIndex + offset - 1)).Value as object[,];
            for (int index = 1; index <= temp.Length; index++)
            {
                if (temp[index, 1] != null)
                {
                    return true;
                }
            }

            if (data.Where(item => Condition(item, startIndex, offset, lop)).ToList().Count > 0)
            {
                return true;
            }
            return false;
        }

        private bool Condition(Item item, int startIndex, int offset, string lop)
        {
            if (item != null && item.Lop != lop) return false;
            int startIndexRow = ((int)item.NgayHoc - 1) * 20 + StartRowOfClass;
            startIndexRow += item.Buoi == "Afternoon" ? 10 : 0;
            startIndexRow += (item.TietBatDau - 1) * 2;

            int _offset = item.TietKeoDai * 2;

            if (startIndexRow <= startIndex && startIndexRow + _offset > startIndex)
            {
                return true;
            }
            if (startIndex <= startIndexRow && startIndex + offset > startIndexRow)
            {
                return true;
            }
            return false;
        }

        public override void InsertInfo(dynamic info)
        {
            try
            {
                if (info == null) return;

                sheet.get_Range(nameSchool).Value = info.Truong;
                sheet.get_Range(title).Value = info.Title();
            }
            catch
            {
                //MessageBox.Show("Lỗi");
                throw new Exception();
            }
        }

        public override void InsertItem(dynamic item)
        {
            //Nut them do nha
            try
            {
                if (item == null) return;

                if (item.TietBatDau + item.TietKeoDai > MaxPeriod + 1)
                {
                    //MessageBox.Show("qua thoi gian quy dinh");
                    return;
                }

                Item newItem = item.Clone();

                if (CheckBusyTeacher(data, newItem))
                {
                    MessageBox.Show("Lỗi! TKB có giáo viên bị trùng lịch.");
                    return;
                }

                int startIndexRow = ((int)newItem.NgayHoc - 1) * RowOfPeriod * MaxPeriod * 2 + StartRowOfClass;
                startIndexRow += newItem.Buoi == "Afternoon" ? RowOfPeriod * MaxPeriod : 0;
                startIndexRow += (newItem.TietBatDau - 1) * RowOfPeriod;

                int offset = newItem.TietKeoDai * RowOfPeriod;

                string columnName = string.Empty;
                (bool, int) checkClass = FindClass(newItem.Lop);

                switch (checkClass.Item1)
                {
                    case true:
                        if (CheckExist(startIndexRow, offset, newItem.Lop))
                        {
                            //MessageBox.Show("da co tiet");
                            break;
                        }
                        else
                        {
                            columnName = GetExcelColumnName(checkClass.Item2);
                        }
                        goto case false;
                    case false:
                        if (string.IsNullOrEmpty(columnName))
                        {
                            NewClass(newItem.Lop);
                            checkClass = FindClass(newItem.Lop);
                            if (checkClass.Item1)
                            {
                                columnName = GetExcelColumnName(checkClass.Item2);
                            }
                        }
                        if (newItem.TietBatDau != 1)
                        {
                            sheet.get_Range(columnName + startIndexRow.ToString()).Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                        }

                        sheet.get_Range(columnName + startIndexRow.ToString() + ":" + columnName + (startIndexRow + offset - 1).ToString()).Merge();

                        sheet.get_Range(columnName + startIndexRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Transparent);
                        sheet.get_Range(columnName + startIndexRow.ToString()).Value = newItem.MonHoc + "\n" + newItem.GiaoVien;

                        if (newItem.TietBatDau + newItem.TietKeoDai < MaxPeriod + 1)
                        {
                            sheet.get_Range(columnName + (startIndexRow + offset - 1).ToString()).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                        }
                        data.Add(newItem);
                        break;
                }
            }
            catch
            {
                //MessageBox.Show("Lỗi");
                throw new Exception();
            }
        }

        private (bool, int) FindClass(string nameClass)
        {
            var lastUsedColumn = FindLastColumnUsed();
            for (int index = StartColumnClass; index <= lastUsedColumn; index++)
            {
                var cell = sheet.Cells[3, index];
                if (cell != null && cell.Value == nameClass)
                {
                    return (true, index);
                }
            }
            return (false, StartColumnClass);
        }

        private bool CheckBusyTeacher(List<Item> currentItem, Item itemCheck)
        {
            if (itemCheck == null) return false;
            for (int index = 0; index < currentItem.Count; index++)
            {
                if (itemCheck.Buoi == currentItem[index].Buoi && itemCheck.NgayHoc == currentItem[index].NgayHoc && itemCheck.GiaoVien == currentItem[index].GiaoVien)
                {
                    if (itemCheck.TietBatDau >= currentItem[index].TietBatDau && itemCheck.TietBatDau < currentItem[index].TietBatDau + currentItem[index].TietKeoDai)
                    {
                        return true;
                    }
                    if (itemCheck.TietBatDau <= currentItem[index].TietBatDau && itemCheck.TietBatDau + itemCheck.TietKeoDai > currentItem[index].TietBatDau)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override object SelectInfo()
        {
            Info info = Info.Parse(sheet.get_Range(title).Value.ToString());
            info.Truong = sheet.get_Range(nameSchool).Value.ToString();
            return info;
        }

        private DateTime FindDayNearly(DateTime dateTime, DayOfWeek dayOfWeek)
        {
            for (int index = 0; index < 7; index++)
            {
                //7 là số ngày trong tuần

                if (dateTime.Add(TimeSpan.FromDays(index)).DayOfWeek == dayOfWeek)
                {
                    return dateTime.Add(TimeSpan.FromDays(index));
                }
            }
            return DateTime.Now;
        }

        public override object SelectItem(object argument)
        {
            List<Item> list = new List<Item>();
            Item item = null;
            DateTime dateTime = (DateTime)argument;

            dateTime = FindDayNearly(dateTime, DayOfWeek.Monday);

            int endColumn = FindLastColumnUsed();

            for (int column = StartColumnClass; column <= endColumn; column++)
            {
                if (sheet.get_Range(GetExcelColumnName(column) + RowClass.ToString()).Value == null) break;
                string _class = sheet.get_Range(GetExcelColumnName(column) + RowClass.ToString()).Value.ToString();

                for (int row = StartRowOfClass; row <= EndRowOfClass; row++)
                {
                    Range cell = sheet.Cells[row, column];
                    if (cell != null && cell.Value != null)
                    {
                        item = new Item();
                        item.Lop = _class;

                        bool isMerged = false;
                        int merge = cell.MergeArea.Count;
                        if (merge > RowOfPeriod)
                        {
                            isMerged = true;
                        }

                        item.TietKeoDai = merge / RowOfPeriod;

                        int calculation = row - StartRowOfClass;
                        item.NgayHoc = ((int)((calculation / (RowOfPeriod * MaxPeriod * 2)) + 1));

                        calculation = calculation % (RowOfPeriod * MaxPeriod * 2);
                        item.Buoi = ((int)calculation / 10) == 0 ? "M" : "A";

                        calculation = calculation % (RowOfPeriod * MaxPeriod);
                        item.TietBatDau = ((int)(calculation / RowOfPeriod)) + 1;

                        string[] value = cell.Value.ToString().Split('\n');
                        item.MonHoc = value[0];
                        item.GiaoVien = value[1];

                        if (isMerged)
                        {
                            row += merge - 1;
                        }

                        if (CheckBusyTeacher(list, item))
                        {
                            return new object[] { false, null };
                        }
                        else
                        {
                            list.Add(item);
                        }
                    }
                }
            }

            /*Marshal.ReleaseComObject(sheet);
            workbook.Close();*/

            return new object[] { true, list };
        }
    }
}
