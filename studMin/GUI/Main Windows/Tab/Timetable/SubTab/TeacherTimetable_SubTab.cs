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
    public partial class TeacherTimetable_SubTab : UserControl
    {
        public TeacherTimetable_SubTab()
        {
            InitializeComponent();
        }

        private void TimetableExport_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Excel | *.xlsx";

            string exportPath = string.Empty;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                exportPath = saveFileDialog.FileName;
            }

            studMin.Action.Excel.ScheduleTeacher scheduleTeacher = new studMin.Action.Excel.ScheduleTeacher();

            Action.Excel.ScheduleTeacher.Info info = new Action.Excel.ScheduleTeacher.Info();
            scheduleTeacher.InsertInfo(info);

            List<Action.Excel.ScheduleTeacher.Item> list = new List<Action.Excel.ScheduleTeacher.Item>();
            foreach (Action.Excel.ScheduleTeacher.Item item in list)
            {
                scheduleTeacher.InsertItem(item);
            }

            scheduleTeacher.Close(exportPath);
        }
    }
}
