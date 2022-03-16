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
    public partial class StudentTimetable_SubTab : UserControl
    {
        public StudentTimetable_SubTab()
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
            else
            {
                return;
            }

            studMin.Action.Excel.ScheduleStudent scheduleStudent = new studMin.Action.Excel.ScheduleStudent();

            Action.Excel.ScheduleStudent.Info info = new Action.Excel.ScheduleStudent.Info();
            scheduleStudent.InsertInfo(info);

            List<Action.Excel.ScheduleTeacher.Item> list = new List<Action.Excel.ScheduleTeacher.Item>();
            foreach (Action.Excel.ScheduleTeacher.Item item in list)
            {
                scheduleStudent.InsertItem(item);
            }

            scheduleStudent.Close(exportPath);
        }
    }
}
