using System;
using System.Windows.Forms;
using ExcelInterop = Microsoft.Office.Interop.Excel;

namespace Office.Helper.Excel;

internal static class ExcelHelper
{
    public static void DataTableToExcel(DataGridView dgv)
    {
        var excel = CreateExcel(dgv.Name);
        FillExcel(dgv, excel);

        static ExcelEntity CreateExcel(string sheetName)
        {
            var excel = new ExcelInterop.Application
            {
                Visible = false,
                DisplayAlerts = false
            };
            var excelBook = excel.Workbooks.Add(Type.Missing);
            ExcelInterop.Worksheet excelSheet = excelBook.ActiveSheet;
            excelSheet.Name = sheetName;

            ExcelInterop.Range formatRange;
            formatRange = excelSheet.get_Range("a1").EntireRow.EntireColumn;
            formatRange.NumberFormat = "@";

            return new(excel, excelBook, excelSheet, formatRange);
        }

        static void FillExcel(DataGridView dgv, ExcelEntity excel)
        {
            for (int i = 0; i <= dgv.Columns.Count - 1; i++)
                excel.Worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText.ToString();

            for (int i = 0; i <= dgv.Rows.Count - 2; i++)
                for (int j = 0; j <= dgv.Columns.Count - 1; j++)
                    excel.Worksheet.Cells[i + 2, j + 1] = dgv[j, i].Value.ToString();

            excel.Worksheet.Columns.AutoFit();
            excel.Application.Visible = true;
        }
    }
}