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
                        using (XLWorkbook workBook = new XLWorkbook(ofd.FileName))
                        {
                            int flag = 0;
                            var rows = workBook.Worksheet(1).RowsUsed();
                            foreach (var row in rows)
                            {
                                if (flag > 0)
                                {
                                    if (flag == 1)
                                    {
                                        foreach (IXLCell cell in row.Cells())
                                        {
                                            dt.Columns.Add(cell.Value.ToString());
                                        }
                                    }
                                    else
                                    {
                                        dt.Rows.Add();
                                        int i = 0;
                                        foreach (IXLCell cell in row.Cells())
                                        {
                                            if (i >= 0 && i<= 2 || i == 15 || i == 16)
                                            {
                                                dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                            }
                                            else if (i >= 3 && i <= 6)
                                            {
                                                dt.Rows[dt.Rows.Count - 1][2] += " " + cell.Value.ToString();
                                            }
                                            else if (i >= 7 && i <= 11)
                                            {
                                                dt.Rows[dt.Rows.Count - 1][3] += " " + cell.Value.ToString();
                                            }
                                            else if (i >= 12 && i <= 14)
                                            {
                                                dt.Rows[dt.Rows.Count - 1][4] += " " + cell.Value.ToString();
                                            }
                                            i++;
                                        }
                                    }
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
                MessageBox.Show("Bận phải chọn lớp trước khi tra cứu.", "LỖI TRUY XUẤT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    for (int i = 0; i < GridView.RowCount; i++)
                    {
                        if (GridView.Rows[i].Cells[0].Value != null && GridView.Rows[i].Cells[1].Value != null && GridView.Rows[i].Cells[0].Value.ToString().ToLower() == Search_Box.Text.ToLower() || GridView.Rows[i].Cells[1].Value.ToString().ToLower() == Search_Box.Text.ToLower())
                        {
                            GridView.Rows[i].Visible = true;
                        }
                        else
                        {
                            GridView.Rows[i].Visible = false;
                        }
                    }
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
    }
}
