using ClosedXML.Excel;
using System.Reflection;

namespace DiffancyAssignment.Services
{
    public static class DocumentService
    {

        public static Task<List<T>> ImportExcelAsync<T>(string fileName, string mapping = null) where T : new()
        {
            var result = new List<T>();
            var properties = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public).ToDictionary(a => a.Name);
            var mappings = string.IsNullOrEmpty(mapping) ? new string[] { } : mapping.Split(',');
            using (var workbook = new XLWorkbook(fileName))
            {
                var workSheet = workbook.Worksheet(1);
                int i = 0;
                var header = workSheet.FirstRow().Cells().ToDictionary(a => i++, b => b.Value.ToString());
                var rows = workSheet.Rows().Skip(1).ToList();
                foreach (IXLRow row in rows)
                {
                    var record = new T();
                    i = 0;
                    foreach (var cell in row.Cells())
                    {
                        //TODO: Empty cells skipped (ignored) while reading data from Excel to DataTable in ClosedXML,
                        //Two-letter columns are not considered !
                        i = (int)((char)cell.Address.ColumnLetter[0]) - 65;

                        if (i >= header.Count())
                            break;
                        string propName = (mappings.Any() && mappings.Length >= i + 1) ? mappings[i] : header[i];
                        if (properties.TryGetValue(propName, out PropertyInfo prop))
                            prop.SetValue(record, cell.Value.ToString());
                    }
                    result.Add(record);
                }
            }
            return Task.FromResult(result);
        }

    }
}