using studMin.Database;
using studMin.Database.Models;
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
    public partial class ClassInfor_SubTab : UserControl
    {
        private List<Action.Excel.ScheduleAllTeacher.Item> data = null;

        public ClassInfor_SubTab()
        {
            InitializeComponent();
        }

        void DataExport_toExcel()
        {
            // Something
        }

        #region Buttons
        private void Search_Button_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch 
            {
                MessageBox.Show("Vui lòng kiểm tra lại điều kiên truy xuất và kết nối mạng.", "TRUY XUÂT THÔNG TIN THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DataGridViewExport_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DataExport_toExcel();
            }
            catch
            {
                MessageBox.Show("Xuất dữ liệu không thành công.", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        private void ClassInfor_SubTab_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((System.Action)(() =>
            {
                Action.Excel.ScheduleAllTeacher scheduleAllTeacher = new Action.Excel.ScheduleAllTeacher(true);

                Action.Excel.ScheduleAllTeacher.Info info = scheduleAllTeacher.SelecteInfo();

                data = scheduleAllTeacher.SelectItem(info.NgayApDung);

                scheduleAllTeacher.Dispose();

                List<string> ListClass = new List<string>();

                /*List<SCHEDULE> listSchedule = ScheduleServices.Instance.GetSchedules();
                List<string> ListSchoolYear = new List<string>();*/

                for (int index = 0; index < data.Count; index++)
                {
                    if (!ListClass.Contains(data[index].Lop))
                    {
                        ListClass.Add(data[index].Lop);
                    }
                }

                /*for (int index = 0; index < listSchedule.Count; index++)
                {
                    if (!ListSchoolYear.Contains(listSchedule[index].SCHOOLYEAR))
                    {
                        ListSchoolYear.Add(listSchedule[index].SCHOOLYEAR);
                    }
                }*/

                Class_ComboBox.DataSource = ListClass;
                // SchoolYear_ComboBox.DataSource = ListSchoolYear;
            }));
        }
    }
}
