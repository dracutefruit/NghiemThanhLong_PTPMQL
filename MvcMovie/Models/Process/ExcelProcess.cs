using OfficeOpenXml;
using System.Data;

namespace MvcMovie.Models.Process
{
    public class ExcelProcess
    {
        public DataTable ExcelToDataTable(string filePath)
        {
            ExcelPackage.License.SetNonCommercialPersonal("Long");

            DataTable dt = new DataTable();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                // Lấy tiêu đề cột từ dòng đầu tiên
                for (int col = 1; col <= colCount; col++)
                {
                    dt.Columns.Add(worksheet.Cells[1, col].Text);
                }

                // Đọc dữ liệu từ dòng thứ 2
                for (int row = 2; row <= rowCount; row++)
                {
                    DataRow dr = dt.NewRow();

                    for (int col = 1; col <= colCount; col++)
                    {
                        dr[col - 1] = worksheet.Cells[row, col].Text;
                    }

                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }
    }
}