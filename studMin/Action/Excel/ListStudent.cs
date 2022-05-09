using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Action.Excel
{
    internal class ListStudent : CommonExcel
    {
        private const int StartColumnIndex = 1;
        private const int StartRowIndex = 6;

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

        private (string, string) SiSo(int member)
        {
            return ("B3", String.Format("Sỉ số: {0}", member));
        }

        public class Item
        {
            private string id;
            private string name;
            private DateTime birth;
            private bool gender;
            private string ethnic;
            private string address;
            private string email;
            private string phone;

            public string MaHocSinh
            {
                get { return id; }
                set { id = value; }
            }

            public string HoTen
            {
                get { return name; }
                set { name = value; }
            }

            public DateTime NgaySinh
            {
                get { return birth; }
                set { birth = value; }
            }

            public bool GioiTinh
            {
                get { return gender; }
                set { gender = value; }
            }

            public string DanToc
            {
                get { return ethnic; }
                set { ethnic = value; }
            }

            public string DiaChi
            {
                get { return address; }
                set { address = value; }
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public string SDT
            {
                get { return phone; }
                set { phone = value; }
            }
        }

        public class Info
        {
            private string _class;
            private string teacher;
            private int startYear;
            private int semester;
            private int member;
            private string msg;

            public string Lop
            {
                get { return _class; }
                set { _class = value; }
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

            public int SiSo
            {
                get { return member; }
                set { member = value; }
            }

            public string ThongTinThem
            {
                get { return msg; }
                set { msg = value; }
            }
        }

        List<Item> data;

        public ListStudent()
        {
            template = StoragePath.TemplateStudent;
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
                (string, string) Info_GVCN = GVCN(clone.GiaoVien);
                (string, string) Info_NamHoc = NamHoc(clone.NamHoc);
                (string, string) Info_SiSo = SiSo(clone.SiSo);

                sheet.get_Range(Info_Lop.Item1).Value = Info_Lop.Item2;
                sheet.get_Range(Info_GVCN.Item1).Value = Info_GVCN.Item2;
                sheet.get_Range(Info_NamHoc.Item1).Value = Info_NamHoc.Item2;
                sheet.get_Range(Info_SiSo.Item1).Value = Info_SiSo.Item2;
            }
            catch
            {
                //MessageBox.Show("Lỗi");
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

                (string, string) Info_SiSo = SiSo(No);
                sheet.get_Range(Info_SiSo.Item1).Value = Info_SiSo.Item2;

                string columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = No;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.MaHocSinh;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.HoTen;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.NgaySinh.ToString("dd/MM/yyyy");

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.GioiTinh ? "Nữ" : "Nam";

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.DanToc;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.DiaChi;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.Email;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.SDT;

                rowUsed++;
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
