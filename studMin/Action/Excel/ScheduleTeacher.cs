using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Action.Excel
{
    internal class ScheduleTeacher:CommonExcel
    {
        private const string nameSchool = "A1";
        private const string title = "A2";

        private const int StartColumnClass = 4;
        private const int StartRowClass = 4;
        private const int EndRowClass = 123;
        private const int MaxPeriod = 5;

        List<Item> data = new List<Item>();

        public ScheduleTeacher()
        {
            this.template = StoragePath.TemplateScheduleTeacher;
            InitExcel();
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

            private string GetHocKy()
            {
                string temp = string.Empty;
                switch (HocKy)
                {
                    case 0:
                        temp = "1";
                        break;
                    case 1:
                        temp = "2";
                        break;
                    case 2:
                        temp = "Hè";
                        break;
                }
                return temp;
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
                return String.Format("THỜI KHÓA BIỂU SỐ {0} - HỌC KỲ {1} - NĂM HỌC {2}, ÁP DỤNG TỪ {3}, {4}", BieuMauSo, GetHocKy(), NamHoc, dateOfWeekVNese, NgayApDung.ToString("dd/MM/yyyy"));
            }
        }

        public class Item
        {
            private string _teacher;
            private int _start;
            private int _duration;
            private DateTime _date;
            private enum _session
            {
                Morning,
                Afternoon,
            }
            private _session session;
            private string _subject;
            private string _class;

            public string Lop
            {
                get { return _class; }
                set { _class = value; }
            }

            public DateTime NgayHoc
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
            Microsoft.Office.Interop.Excel.Range oRng = sheet.Range["D3"];
            oRng.EntireColumn.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Microsoft.Office.Interop.Excel.XlInsertFormatOrigin.xlFormatFromRightOrBelow);
            sheet.get_Range("D3").Value = nameClass;
            Range formatCell = sheet.get_Range("D" + StartRowClass + ":" + "D" + EndRowClass);
            formatCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            formatCell.Borders.LineStyle = XlLineStyle.xlLineStyleNone;
            formatCell.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;

            for (int index = StartRowClass; index <= EndRowClass; index += 10)
            {
                if (index % 10 == 4)
                {
                    sheet.Cells[index, StartColumnClass].Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                    sheet.Cells[index, StartColumnClass].Borders[XlBordersIndex.xlEdgeTop].Weight = XlBorderWeight.xlMedium;
                }
            }

            //Sửa không có border ở cuối bảng
            sheet.Cells[EndRowClass, StartColumnClass].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            sheet.Cells[EndRowClass, StartColumnClass].Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlMedium;
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
            int startIndexRow = ((int)item.NgayHoc.DayOfWeek - 1) * 20 + StartRowClass;
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

                if (CheckBusyTeacher(newItem))
                {
                    //MessageBox.Show("giao vien ban");
                    return;
                }

                int startIndexRow = ((int)newItem.NgayHoc.DayOfWeek - 1) * 20 + 4;
                startIndexRow += newItem.Buoi == "Afternoon" ? 10 : 0;
                startIndexRow += (newItem.TietBatDau - 1) * 2;

                int offset = newItem.TietKeoDai * 2;

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

        private bool CheckBusyTeacher(Item itemCheck)
        {
            if (itemCheck == null) return false;
            for (int index = 0; index < data.Count; index++)
            {
                if (itemCheck.Buoi == data[index].Buoi && itemCheck.NgayHoc.DayOfWeek == data[index].NgayHoc.DayOfWeek && itemCheck.GiaoVien == data[index].GiaoVien)
                {
                    if (itemCheck.TietBatDau >= data[index].TietBatDau && itemCheck.TietBatDau < data[index].TietBatDau + data[index].TietKeoDai)
                    {
                        return true;
                    }
                    if (itemCheck.TietBatDau <= data[index].TietBatDau && itemCheck.TietBatDau + itemCheck.TietKeoDai > data[index].TietBatDau)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
