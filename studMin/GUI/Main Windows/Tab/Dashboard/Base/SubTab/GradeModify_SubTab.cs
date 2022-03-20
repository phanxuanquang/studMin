using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studMin
{
    public partial class GradeModify_SubTab : UserControl
    {
        public GradeModify_SubTab()
        {
            InitializeComponent();
        }

        void CheckValidGrade(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            double numericTest;

            try
            {
                if (textBox.Text == String.Empty)
                {
                    return;
                }
                numericTest = double.Parse(textBox.Text);
            }
            catch
            {
                MessageBox.Show("Điểm chỉ bao gồm chữ số và dấu chấm thập phân. \nVui lòng nhập lại điểm số.", "Điểm số nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox.Text = String.Empty;
                return;
            }

            if (numericTest < 0 || numericTest > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10. \nVui lòng nhập lại điểm số.", "Điểm số nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox.Text = String.Empty;
            }

        }

        private void MidTermTestScore_Box_TextChanged(object sender, EventArgs e)
        {
            CheckValidGrade(MidTermTestScore_Box);
        }

        private void RegularTestScore_Box_TextChanged(object sender, EventArgs e)
        {
            CheckValidGrade(RegularTestScore_Box);
        }

        private void OralTestScore_Box_TextChanged(object sender, EventArgs e)
        {
            CheckValidGrade(MidTermTestScore_Box);
        }

        private void DataGridViewImport_Button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files| *.xlsc; *.xls; *.xlsm; *.xlsx", Multiselect = false})
            {
                try
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        DataTable dt = new DataTable();

                        dt.Columns.Add("Mã học sinh");
                        dt.Columns.Add("Họ tên");
                        dt.Columns.Add("Kiểm tra miệng");
                        dt.Columns.Add("Kiểm tra 15 phút");
                        dt.Columns.Add("Kiểm tra 1 tiết");
                        dt.Columns.Add("Kiểm tra học kỳ");
                        dt.Columns.Add("Trung bình chung");

                        using (XLWorkbook workBook = new XLWorkbook(ofd.FileName))
                        {
                            int flag = 0;
                            var rows = workBook.Worksheet(1).RowsUsed();
                            foreach (var row in rows)
                            {
                                if (flag >= 2)
                                {
                                    dt.Rows.Add();
                                    int i = 0;
                                    double oralTest = 0, fifteenMinutes = 0, fortyMinutes = 0, semesterTest = 0, overallAverage = 0;
                                    int flagOralTest = 0, flagFifteenMinutes = 0;
                                    foreach (IXLCell cell in row.Cells())
                                    {
                                        if (!cell.IsEmpty())
                                        {
                                            if (i == 0 || i == 1)
                                            {
                                                dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                            }
                                            else if (i >= 2 && i <= 6)
                                            {
                                                oralTest += Double.Parse(cell.Value.ToString());
                                                flagOralTest++;
                                            }
                                            else if (i >= 7 && i <= 11)
                                            {
                                                fifteenMinutes += Double.Parse(cell.Value.ToString());
                                                flagFifteenMinutes++;
                                            }
                                            else if (i >= 12 && i <= 14)
                                            {
                                                fortyMinutes += Double.Parse(cell.Value.ToString());
                                            }
                                            else if (i == 15)
                                            {
                                                semesterTest = Double.Parse(cell.Value.ToString());
                                            }
                                            else
                                            {
                                                overallAverage = Double.Parse(cell.Value.ToString());
                                            }
                                        }

                                        i++;
                                    }

                                    dt.Rows[dt.Rows.Count - 1][2] = (oralTest / flagOralTest).ToString();
                                    dt.Rows[dt.Rows.Count - 1][3] = (fifteenMinutes / flagFifteenMinutes).ToString();
                                    dt.Rows[dt.Rows.Count - 1][4] = (fortyMinutes / 3).ToString();
                                    dt.Rows[dt.Rows.Count - 1][5] = semesterTest.ToString();
                                    dt.Rows[dt.Rows.Count - 1][6] = overallAverage.ToString();
                                }

                                flag++;
                            }

                            GridView.DataSource = dt.DefaultView;
                            Cursor.Current = Cursors.Default;
                        }
                    }
                }
                catch 
                {
                    MessageBox.Show("Truy xuất dữ liệu thất bại. Tệp tin bạn chọn không đúng quy chuẩn hoặc chứa dữ liệu không hợp lệ.\nVui lòng thử lại sau.", "LỖI TRUY XUẤT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Search_Box_TextChanged(object sender, EventArgs e)
        {
            if (Class_ComboBox.Text != "Mọi lớp")
            {
                MessageBox.Show("Bạn phải chọn lớp trước khi tra cứu.", "LỖI TRUY XUẤT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    CurrencyManager cm = (CurrencyManager)BindingContext[GridView.DataSource];
                    cm.SuspendBinding();

                    for (int i = 0; i < GridView.RowCount; i++)
                    {
                        if (GridView.Rows[i].Cells[0].Value != null && 
                            GridView.Rows[i].Cells[1].Value != null && 
                            GridView.Rows[i].Cells[0].Value.ToString().ToLower().Contains(Search_Box.Text.ToLower()) || 
                            GridView.Rows[i].Cells[1].Value.ToString().ToLower().Contains(Search_Box.Text.ToLower()))
                        {
                            
                            GridView.Rows[i].Visible = true;
                            
                        }
                        else
                        {
                            GridView.Rows[i].Visible = false;
                        }
                    }

                    cm.ResumeBinding();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FullGridView_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridView.RowCount; i++)
            {
                GridView.Rows[i].Visible = true;
            }
        }

        private void DataGridViewExport_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Excel | *.xlsx";

            string exportPath = string.Empty;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                exportPath = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            Action.Excel.Subject.Info info = new Action.Excel.Subject.Info()
            {
                GiaoVien = "Nguyễn Ngân Hà",
                HocKy = 1,
                Lop = "10A2",
                NamHoc = "2022 - 2023",
                MonHoc = "Toán",
            };

            List<Action.Excel.Subject.Item> list = new List<Action.Excel.Subject.Item>()
            {
                new studMin.Action.Excel.Subject.Item()
                {
                    HoTen = "Nguyễn Văn Tèo",
                    Diem15Phut = new List<double>() { 5, 5.3, 6.7, 8.7 },
                    Diem1Tiet = new List<double>() { 7, 9 },
                    DiemCuoiKy = 8.5,
                    DiemMieng = new List<double>() { 9, 8 }
                },
                new studMin.Action.Excel.Subject.Item()
                {
                    HoTen = "Trần Xuân Tài",
                    Diem15Phut = new List<double>() { 5, 5.3, 6.7, 8.7 },
                    Diem1Tiet = new List<double>() { 7, 6 },
                    DiemCuoiKy = 8.5,
                    DiemMieng = new List<double>() { 9, 8 }
                },
                new studMin.Action.Excel.Subject.Item()
                {
                    HoTen = "Ngô Xuân Yến",
                    Diem15Phut = new List<double>() { 5, 5.3, 6.7, 8.7 },
                    Diem1Tiet = new List<double>() { 7, 7 },
                    DiemCuoiKy = 8.5,
                    DiemMieng = new List<double>() { 9, 8 }
                },
                new studMin.Action.Excel.Subject.Item()
                {
                    HoTen = "Trần Thị Thanh Hiền",
                    Diem15Phut = new List<double>() { 5, 5.3, 6.7, 8.7 },
                    Diem1Tiet = new List<double>() { 7, 8 },
                    DiemCuoiKy = 8,
                    DiemMieng = new List<double>() { 8, 8 }
                },
                new studMin.Action.Excel.Subject.Item()
                {
                    HoTen = "Phạm Nguyễn Vi Trân",
                    Diem15Phut = new List<double>() { 5, 5.3, 6.7, 8.7 },
                    Diem1Tiet = new List<double>() { 7, 9 },
                    DiemCuoiKy = 8.5,
                    DiemMieng = new List<double>() { 9, 8 }
                },
                new studMin.Action.Excel.Subject.Item()
                {
                    HoTen = "Đỗ Minh Thanh",
                    Diem15Phut = new List<double>() { 5, 5.3, 6.7, 8.7 },
                    Diem1Tiet = new List<double>() { 7, 9 },
                    DiemCuoiKy = 10,
                    DiemMieng = new List<double>() { 9, 8 }
                }
            };

            this.BeginInvoke(new System.Action(() =>
            {
                studMin.Action.Excel.Subject subject = new studMin.Action.Excel.Subject();

                subject.InsertInfo(info);

                foreach (Action.Excel.Subject.Item item in list)
                {
                    subject.InsertItem(item);
                }

                subject.ShowExcel();

                subject.Save(exportPath);

                if (MessageBox.Show("Bạn có muốn xem bảng tính lúc in?", "In Bảng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    subject.ShowPrintPreview();
                }

                subject.Dispose();
            }));
        }
    }
}
