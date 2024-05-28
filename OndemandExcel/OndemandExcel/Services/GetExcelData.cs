using Microsoft.AspNetCore.Components.Forms;
using OfficeOpenXml;
using OndemandExcel.Services.Interfaces;
using System.Dynamic;

namespace OndemandExcel.Services
{
    public class GetExcelData : IGetData
    {
        public List<ExpandoObject> GetData(string filepath)
        {
            List<ExpandoObject> data = new List<ExpandoObject>();
            string _filepath = $"C:/{filepath}";
            FileInfo fileInfo = new FileInfo(_filepath);

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
            {
                if (excelPackage == null || excelPackage.Workbook == null || excelPackage.Workbook.Worksheets == null) return null;
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets.FirstOrDefault();
                if (excelWorksheet == null || excelWorksheet.Dimension == null) return null; 
                int totalColumn = excelWorksheet.Dimension.End.Column;
                int totalRow = excelWorksheet.Dimension.End.Row;

                for (int row = 1; row <= totalRow; row++)
                {
                    IDictionary<string, object> Expando = new ExpandoObject();
                    for (int col = 1; col <= totalColumn; col++)
                    {
                        if (excelWorksheet != null && excelWorksheet.Cells != null && excelWorksheet.Cells[row, col].Value != null)
                        {
                            Expando[$"value{col}"] = excelWorksheet.Cells[row, col].Value.ToString();
                        }
                    }
                    if (Expando != null) data.Add((ExpandoObject)Expando);
                }
            }
            return data;
        }
    }
}
