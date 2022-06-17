using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace studMin.Action.Excel
{
    internal abstract class CommonExcel : IDisposable
    {
        private bool isSaved = false;

        protected Microsoft.Office.Interop.Excel.Application excel = null;
        protected Microsoft.Office.Interop.Excel.Workbook workbook = null;
        protected Microsoft.Office.Interop.Excel.Worksheet sheet = null;
        protected string template = null;
        protected string export = null;
        protected bool isReadOnly = false;

        protected void InitExcel()
        {
            excel = new Microsoft.Office.Interop.Excel.Application();
            workbook = excel.Workbooks.Open(template);
            sheet = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
        }

        public void NewSheets(string[] sheetsName)
        {
            if (sheetsName != null)
            {
                Sheets xlSheets = workbook.Sheets;
                for(int index = 0; index < sheetsName.Length; index++)
                {
                    sheet.Copy(Type.Missing, xlSheets[xlSheets.Count]);
                    xlSheets[xlSheets.Count].Name = sheetsName[index];
                }
            }
        }

        public void FocusToSheetName(string sheetName)
        {
            sheet = excel.Sheets[sheetName];
        }

        public abstract void InsertItem(dynamic item);

        public abstract void InsertInfo(dynamic info);

        public abstract object SelectInfo();

        public abstract object SelectItem(object argument);

        protected string GetExcelColumnName(int columnNumber)
        {
            string columnName = "";

            while (columnNumber > 0)
            {
                int modulo = (columnNumber - 1) % 26;
                columnName = Convert.ToChar('A' + modulo) + columnName;
                columnNumber = (columnNumber - modulo) / 26;
            }

            return columnName;
        }

        public void ShowExcel()
        {
            if (excel != null && sheet != null)
            {
                try
                {
                    //sheet.Protect("doanxempassword");
                    excel.Visible = true;
                    excel.EditDirectlyInCell = false;
                }
                catch
                {

                }
            }
        }

        public void ShowPrintPreview()
        {
            if (excel != null && sheet != null)
            {
                try
                {
                    sheet.PageSetup.Zoom = false;
                    sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA3;
                    sheet.PageSetup.FitToPagesTall = 1;
                    sheet.PrintPreview();
                }
                catch
                {

                }
            }
        }

        public void Save(string exportPath)
        {
            export = exportPath == string.Empty ? export : exportPath;
            if (isReadOnly) return;
            if (export == null) throw new Exception();
            try
            {
                if (File.Exists(export))
                {
                    File.Delete(export);
                }

                workbook.SaveAs(export);

                isSaved = true;
            }
            catch
            {

            }
        }

        public void Dispose()
        {
            try
            {
                if (!isSaved && !isReadOnly)
                {
                    Save(string.Empty);
                }
                workbook.Close();
                excel.Quit();
            }
            catch
            {

            }

            GC.SuppressFinalize(this);
        }

        protected int FindLastRowUsed()
        {
            return sheet.Cells.Find("*", System.Reflection.Missing.Value,
                               System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                               Microsoft.Office.Interop.Excel.XlSearchOrder.xlByColumns, Microsoft.Office.Interop.Excel.XlSearchDirection.xlPrevious,
                               false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;
        }

        protected int FindLastColumnUsed()
        {
            return sheet.Cells.Find("*", System.Reflection.Missing.Value,
                               System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                               Microsoft.Office.Interop.Excel.XlSearchOrder.xlByColumns, Microsoft.Office.Interop.Excel.XlSearchDirection.xlPrevious,
                               false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Column;
        }
    }
}
