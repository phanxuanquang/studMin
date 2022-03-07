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

        private void GradeModify_SubTab_Load(object sender, EventArgs e)
        {

        }

        private void Search_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridViewImport_Button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel|*.xlsx", Multiselect = false})
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
                                            if (i >= 3 && i <= 6)
                                            {
                                                dt.Rows[dt.Rows.Count - 1][2] += " " + cell.Value.ToString();
                                            }
                                            else
                                            {
                                                dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                            }
                                            i++;
                                        }
                                    }
                                }

                                flag++;
                            }

                            dataGridView1.DataSource = dt.DefaultView;
                            Cursor.Current = Cursors.Default;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
