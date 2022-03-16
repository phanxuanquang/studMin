using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMin.Action.Excel
{
    internal class StoragePath
    {
        private static string folderFile = Path.GetFullPath(System.Windows.Forms.Application.StartupPath + @"..\..\..\TemplateExcel\");
        private static string schedule_all_teacher = "schedule_all_teacher.xlsx";
        private static string schedule_teacher = "schedule_teacher.xlsx";
        private static string schedule_student = "schedule_student.xlsx";
        private static string student = "student.xlsx";
        private static string summary = "summary.xlsx";
        private static string subject = "subject.xlsx";

        public static string TemplateScheduleAllTeacher
        {
            get { return Path.Combine(folderFile, schedule_all_teacher); }
        }

        public static string TemplateScheduleTeacher
        {
            get { return Path.Combine(folderFile, schedule_teacher); }
        }

        public static string TemplateScheduleStudent
        {
            get { return Path.Combine(folderFile, schedule_student); }
        }

        public static string TemplateStudent
        {
            get { return Path.Combine(folderFile, student); }
        }

        public static string TemplateSummary
        {
            get { return Path.Combine(folderFile, summary); }
        }

        public static string TemplateSubject
        {
            get { return Path.Combine(folderFile, subject); }
        }
    }
}
