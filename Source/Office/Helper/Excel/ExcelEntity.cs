using ExcelInterop = Microsoft.Office.Interop.Excel;

namespace Office.Helper.Excel;

internal class ExcelEntity
{
    public ExcelInterop.Application Application { get; }

    public ExcelInterop.Workbook Workbook { get; }

    public ExcelInterop.Worksheet Worksheet { get; }

    public ExcelInterop.Range Range { get; }

    public ExcelEntity(ExcelInterop.Application application,
                       ExcelInterop.Workbook workbook,
                       ExcelInterop.Worksheet excelSheet,
                       ExcelInterop.Range range)
    {
        Application = application;
        Workbook = workbook;
        Worksheet = excelSheet;
        Range = range;
    }
}