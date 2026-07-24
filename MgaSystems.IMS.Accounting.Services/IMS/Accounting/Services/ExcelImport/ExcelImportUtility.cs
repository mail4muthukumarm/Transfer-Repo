// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.ExcelImport.ExcelImportUtility
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.AsposeFacade.Cells;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.ExcelImport;

public static class ExcelImportUtility
{
  public static DataTable BuildExcelDataTable(MGASystems.AsposeFacade.Cells.Cells cellList)
  {
    DataTable dataTable = new DataTable();
    int num1 = 1;
    for (int index = 0; index <= cellList.MaxDataColumn; ++index)
    {
      string str = (cellList.Worksheet.Cells[0, index].Value ?? (object) string.Empty).ToString();
      if (str != string.Empty)
      {
        if (!dataTable.Columns.Contains(str))
        {
          dataTable.Columns.Add(str, typeof (string));
        }
        else
        {
          int num2 = (int) MessageBox.Show($"Duplicate column {str} found in worksheet. Please correct worksheet before uploading.");
          return new DataTable();
        }
      }
      else
      {
        dataTable.Columns.Add($"F{num1.ToString()}", typeof (string));
        ++num1;
      }
    }
    for (int index1 = 1; index1 < cellList.Rows.Count; ++index1)
    {
      List<object> objectList = new List<object>();
      for (int index2 = 0; index2 <= cellList.MaxDataColumn; ++index2)
      {
        if (cellList[index1, index2].Value != null)
          objectList.Add((object) cellList[index1, index2].Value.ToString());
        else
          objectList.Add((object) string.Empty);
      }
      dataTable.Rows.Add(objectList.ToArray());
    }
    return dataTable;
  }

  public static DataTable BuildExcelDataTable(byte[] data, string worksheetName)
  {
    using (MemoryStream memoryStream = new MemoryStream(data))
    {
      memoryStream.Position = 0L;
      return ExcelImportUtility.BuildExcelDataTable(new Workbook((Stream) memoryStream).Worksheets[worksheetName].Cells);
    }
  }

  public static DataTable BuildExcelDataTable(Workbook wb, string worksheetName)
  {
    return ExcelImportUtility.BuildExcelDataTable(wb.Worksheets[worksheetName].Cells);
  }
}
