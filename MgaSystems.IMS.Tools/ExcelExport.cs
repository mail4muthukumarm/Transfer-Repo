// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ExcelExport
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using MGASystems.AsposeFacade.Cells;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public sealed class ExcelExport
{
  private static FormattedExportInfo _fmt = new FormattedExportInfo();
  private static ExcelExport.TrackSheets SheetTracker = new ExcelExport.TrackSheets();

  public static void ToExcel(DataView source, string filePath)
  {
    if (source == null)
      throw new ArgumentNullException(nameof (source));
    ExcelExport.ToExcel(new DataSet()
    {
      Tables = {
        ADOHelper.DataViewToDataTable(source, DataViewRowState.CurrentRows)
      }
    }, filePath, (EventHandler<ExportExcelCellCreatedEventArgs>) null, (FileFormatType) 6);
  }

  public static void ToExcel(DataTable source, string filePath)
  {
    if (source == null)
      throw new ArgumentNullException(nameof (source));
    ExcelExport.ToExcel(new DataSet()
    {
      Tables = {
        source.Copy()
      }
    }, filePath, (EventHandler<ExportExcelCellCreatedEventArgs>) null, (FileFormatType) 6);
  }

  public static void ToExcel(DataSet source, string filePath)
  {
    ExcelExport._fmt = source != null ? new FormattedExportInfo(source) : throw new ArgumentNullException(nameof (source));
    if (!ExcelExport._fmt.IsFormatted)
    {
      ExcelExport.ToExcel(source, filePath, (EventHandler<ExportExcelCellCreatedEventArgs>) null, (FileFormatType) 6);
    }
    else
    {
      ExcelExport._fmt.FilePath = filePath;
      ExcelExport.ToExcel(ExcelExport._fmt);
    }
  }

  public static void ToExcel(
    DataTable source,
    string filePath,
    EventHandler<ExportExcelCellCreatedEventArgs> cellCreatedHandler)
  {
    if (source == null)
      throw new ArgumentNullException(nameof (source));
    ExcelExport.ToExcel(new DataSet()
    {
      Tables = {
        source.Copy()
      }
    }, filePath, cellCreatedHandler, (FileFormatType) 6);
  }

  public static void ToExcel(
    DataSet source,
    string filePath,
    EventHandler<ExportExcelCellCreatedEventArgs> cellCreatedHandler)
  {
    ExcelExport._fmt = source != null ? new FormattedExportInfo(source) : throw new ArgumentNullException(nameof (source));
    if (!ExcelExport._fmt.IsFormatted)
    {
      ExcelExport.ToExcel(source, filePath, cellCreatedHandler, (FileFormatType) 6);
    }
    else
    {
      ExcelExport._fmt.FilePath = filePath;
      ExcelExport._fmt.CellCreatedHandler = cellCreatedHandler;
      ExcelExport.ToExcel(ExcelExport._fmt);
    }
  }

  public static Workbook ToWorkbook(DataView source)
  {
    return source != null ? ExcelExport.ToWorkbook(new DataSet()
    {
      Tables = {
        ADOHelper.DataViewToDataTable(source, DataViewRowState.CurrentRows)
      }
    }, (EventHandler<ExportExcelCellCreatedEventArgs>) null) : throw new ArgumentNullException(nameof (source));
  }

  public static Workbook ToWorkbook(DataTable source)
  {
    return source != null ? ExcelExport.ToWorkbook(new DataSet()
    {
      Tables = {
        source.Copy()
      }
    }, (EventHandler<ExportExcelCellCreatedEventArgs>) null) : throw new ArgumentNullException(nameof (source));
  }

  public static Workbook ToWorkbook(DataSet source)
  {
    ExcelExport._fmt = source != null ? new FormattedExportInfo(source) : throw new ArgumentNullException(nameof (source));
    return ExcelExport._fmt.IsFormatted ? ExcelExport.ToExcel(ExcelExport._fmt) : ExcelExport.ToWorkbook(source, (EventHandler<ExportExcelCellCreatedEventArgs>) null);
  }

  public static Workbook ToWorkbook(
    DataTable source,
    EventHandler<ExportExcelCellCreatedEventArgs> cellCreatedHandler)
  {
    return source != null ? ExcelExport.ToWorkbook(new DataSet()
    {
      Tables = {
        source.Copy()
      }
    }, cellCreatedHandler) : throw new ArgumentNullException(nameof (source));
  }

  public static void ToExcel(
    DataSet source,
    string filePath,
    EventHandler<ExportExcelCellCreatedEventArgs> cellCreatedHandler,
    FileFormatType exportFormat)
  {
    ExcelExport._fmt = source != null ? new FormattedExportInfo(source) : throw new ArgumentNullException(nameof (source));
    Workbook workbook;
    if (!ExcelExport._fmt.IsFormatted)
    {
      workbook = ExcelExport.ToWorkbook(source, cellCreatedHandler);
    }
    else
    {
      ExcelExport._fmt.FilePath = filePath;
      ExcelExport._fmt.CellCreatedHandler = cellCreatedHandler;
      ExcelExport._fmt.ExportFormat = exportFormat;
      workbook = ExcelExport.ToExcel(ExcelExport._fmt);
    }
    workbook.FileFormat = !(filePath.Contains(".xls") & filePath.LastIndexOf(".xls") == filePath.Length - 4) ? exportFormat : (FileFormatType) 5;
    workbook.Save(filePath);
  }

  private static Workbook ToWorkbook(
    DataSet source,
    EventHandler<ExportExcelCellCreatedEventArgs> cellCreatedHandler)
  {
    ExcelExport._fmt = source != null ? new FormattedExportInfo(source) : throw new ArgumentNullException(nameof (source));
    Workbook workbook1;
    if (ExcelExport._fmt.IsFormatted)
    {
      workbook1 = ExcelExport.ToExcel(ExcelExport._fmt);
    }
    else
    {
      Workbook workbook2 = new Workbook();
      workbook2.Worksheets.RemoveAt(0);
      EventHandler<ExportExcelCellCreatedEventArgs> eventHandler = cellCreatedHandler;
      int index1 = 0;
      try
      {
        foreach (DataTable table in (InternalDataCollectionBase) source.Tables)
        {
          workbook2.Worksheets.Add();
          bool flag = false;
          workbook2.Worksheets[index1].Name = source.Tables[index1].TableName.Length <= 4 || !source.Tables[index1].TableName.Substring(0, 5).Equals("Table") ? source.Tables[index1].TableName : "Sheet " + (index1 + 1).ToString();
          Style style1 = workbook2.CreateStyle();
          style1.Font.IsBold = true;
          int num1 = table.Columns.Count - 1;
          for (int index2 = 0; index2 <= num1; ++index2)
          {
            Cell cell = workbook2.Worksheets[index1].Cells[0, index2];
            cell.PutValue(table.Columns[index2].ColumnName);
            cell.SetStyle(style1);
            int num2 = table.Rows.Count - 1;
            for (int index3 = 0; index3 <= num2; ++index3)
            {
              try
              {
                string str = table.Rows[index3][index2].GetType().ToString();
                // ISSUE: reference to a compiler-generated method
                switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
                {
                  case 347085918:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Boolean", false) == 0)
                      break;
                    goto default;
                  case 531277785:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.DBNull", false) == 0)
                    {
                      workbook2.Worksheets[index1].Cells[index3 + 1, index2].PutValue(string.Empty);
                      goto label_28;
                    }
                    goto default;
                  case 848225627:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Double", false) == 0)
                    {
                      workbook2.Worksheets[index1].Cells[index3 + 1, index2].PutValue((double) table.Rows[index3][index2]);
                      goto label_28;
                    }
                    goto default;
                  case 1541528931:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.DateTime", false) == 0)
                    {
                      workbook2.Worksheets[index1].Cells[index3 + 1, index2].PutValue(Conversions.ToDate(table.Rows[index3][index2]).ToOADate());
                      Style style2 = workbook2.Worksheets[index1].Cells[index3 + 1, index2].GetStyle();
                      style2.Number = 14;
                      workbook2.Worksheets[index1].Cells[index3 + 1, index2].SetStyle(style2);
                      goto label_28;
                    }
                    goto default;
                  case 1697786220:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Int16", false) == 0)
                    {
                      workbook2.Worksheets[index1].Cells[index3 + 1, index2].PutValue((int) (short) table.Rows[index3][index2]);
                      goto label_28;
                    }
                    goto default;
                  case 1741144581:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Decimal", false) == 0)
                    {
                      workbook2.Worksheets[index1].Cells[index3 + 1, index2].PutValue((Decimal) table.Rows[index3][index2]);
                      goto label_28;
                    }
                    goto default;
                  case 2736390927:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Guid", false) == 0)
                      break;
                    goto default;
                  case 3079944380:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Byte", false) == 0)
                      break;
                    goto default;
                  case 3552946656:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Integer", false) == 0)
                      goto label_23;
                    goto default;
                  case 4180476474:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.Int32", false) == 0)
                      goto label_23;
                    goto default;
                  case 4201364391:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "System.String", false) == 0)
                      break;
                    goto default;
                  default:
                    workbook2.Worksheets[index1].Cells[index3 + 1, index2].PutValue(table.Rows[index3][index2].ToString());
                    goto label_28;
                }
                workbook2.Worksheets[index1].Cells[index3 + 1, index2].PutValue(table.Rows[index3][index2].ToString());
                goto label_28;
label_23:
                workbook2.Worksheets[index1].Cells[index3 + 1, index2].PutValue((int) table.Rows[index3][index2]);
label_28:
                Style style3 = workbook2.Worksheets[index1].Cells[index3 + 1, index2].GetStyle();
                if (eventHandler != null)
                {
                  ExportExcelCellCreatedEventArgs e = new ExportExcelCellCreatedEventArgs(index3, index2, workbook2.Worksheets[index1].Cells[index3 + 1, index2].GetStyle().Custom);
                  eventHandler((object) null, e);
                  if (!string.IsNullOrEmpty(e.NumberFormat))
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.NumberFormat, style3.Custom, false) != 0)
                    {
                      style3.Custom = e.NumberFormat;
                      workbook2.Worksheets[index1].Cells[index3 + 1, index2].SetStyle(style3);
                    }
                  }
                }
              }
              catch (ArgumentOutOfRangeException ex)
              {
                ProjectData.SetProjectError((Exception) ex);
                int num3 = (int) MessageBox.Show("The maximum number of columns for an Excel spreadsheet has been exceeded for this sheet.\n\nAdditional columns will not be exported.", "Maximum Columns Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
                ProjectData.ClearProjectError();
                break;
              }
            }
            if (flag)
              break;
          }
          ++index1;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      workbook1 = workbook2;
    }
    return workbook1;
  }

  private static Workbook ToExcel(FormattedExportInfo format)
  {
    List<SheetInXML> sheetInXmlList1 = new List<SheetInXML>();
    DataRow[] dataRowArray1 = format.DtFormat.Select("ExtendedExportCellFormat=0");
    int index1 = 0;
    while (index1 < dataRowArray1.Length)
    {
      SheetInXML sheetInXml = StyleSerializationRoutines.DeserializeSheetInXML(dataRowArray1[index1]["CellFormat"].ToString());
      sheetInXmlList1.Add(sheetInXml);
      checked { ++index1; }
    }
    List<SheetInXML> sheetInXmlList2 = sheetInXmlList1;
    Comparison<SheetInXML> comparison;
    // ISSUE: reference to a compiler-generated field
    if (ExcelExport._Closure\u0024__.\u0024I15\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      comparison = ExcelExport._Closure\u0024__.\u0024I15\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      ExcelExport._Closure\u0024__.\u0024I15\u002D0 = comparison = (Comparison<SheetInXML>) ([SpecialName] (x, y) => x.Index.CompareTo(y.Index));
    }
    sheetInXmlList2.Sort(comparison);
    Workbook wkb = new Workbook();
    wkb.Worksheets.Clear();
    try
    {
      foreach (SheetInXML sheetInXml in sheetInXmlList1)
      {
        int num = wkb.Worksheets.Add();
        wkb.Worksheets[num].Name = sheetInXml.Name;
      }
    }
    finally
    {
      List<SheetInXML>.Enumerator enumerator;
      enumerator.Dispose();
    }
    List<StyleInXML> styleInXmlList = new List<StyleInXML>();
    DataRow[] dataRowArray2 = format.DtFormat.Select("ExtendedExportCellFormat=1");
    int index2 = 0;
    while (index2 < dataRowArray2.Length)
    {
      StyleInXML styleInXml = StyleSerializationRoutines.DeSerializeStyleInXML(dataRowArray2[index2]["CellFormat"].ToString());
      styleInXmlList.Add(styleInXml);
      checked { ++index2; }
    }
    try
    {
      foreach (StyleInXML xStyle in styleInXmlList)
        ExcelExport.ValidateTableData(format.DsData, ref xStyle);
    }
    finally
    {
      List<StyleInXML>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (StyleInXML stl in styleInXmlList)
      {
        if (stl.CellType == RangeType.CellConstant)
          ExcelExport.ApplyStyleCellConstant(stl, wkb);
      }
    }
    finally
    {
      List<StyleInXML>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (StyleInXML stl in styleInXmlList)
      {
        if (stl.CellType == RangeType.CellConstantFormula)
          ExcelExport.ApplyStyleCellConstantFormula(stl, wkb);
      }
    }
    finally
    {
      List<StyleInXML>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (StyleInXML stl in styleInXmlList)
      {
        if (stl.CellType == RangeType.CellTableValue)
          ExcelExport.ApplyStyleCellTableValue(stl, format.DsData, wkb);
      }
    }
    finally
    {
      List<StyleInXML>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (StyleInXML stl in styleInXmlList)
      {
        if (stl.CellType == RangeType.CellDataImportBegin)
          ExcelExport.ApplyStyleCellDataImportBegin(stl, format.DsData, wkb);
      }
    }
    finally
    {
      List<StyleInXML>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (StyleInXML stl in styleInXmlList)
      {
        if (stl.CellType == RangeType.ColumnImportBegin)
          ExcelExport.ApplyStyleColumnImportBegin(stl, format.DsData, wkb);
      }
    }
    finally
    {
      List<StyleInXML>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (StyleInXML stl in styleInXmlList)
      {
        if (stl.CellType == RangeType.ColumnFormat)
        {
          ExcelExport.ApplyStyleColumnFormat(stl, wkb);
          GC.Collect();
        }
      }
    }
    finally
    {
      List<StyleInXML>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (StyleInXML stl in styleInXmlList)
      {
        if (stl.CellType == RangeType.ColumnFormula)
        {
          ExcelExport.ApplyStyleColumnFormula(stl, wkb);
          GC.Collect();
        }
      }
    }
    finally
    {
      List<StyleInXML>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (StyleInXML stl in styleInXmlList)
      {
        if (stl.CellType == RangeType.CellSummaryConstant)
          ExcelExport.ApplyStyleCellSummaryConstant(stl, wkb);
      }
    }
    finally
    {
      List<StyleInXML>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (StyleInXML stl in styleInXmlList)
      {
        if (stl.CellType == RangeType.CellSummaryFormula)
          ExcelExport.ApplyStylCellSummaryFormula(stl, wkb);
      }
    }
    finally
    {
      List<StyleInXML>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (SheetInXML sht in sheetInXmlList1)
        ExcelExport.ApplyStylSheetFormat(sht, wkb);
    }
    finally
    {
      List<SheetInXML>.Enumerator enumerator;
      enumerator.Dispose();
    }
    wkb.CalculateFormula();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(format.FilePath, "", false) != 0)
    {
      wkb.FileFormat = !(format.FilePath.Contains(".xls") & format.FilePath.LastIndexOf(".xls") == format.FilePath.Length - 4) ? format.ExportFormat : (FileFormatType) 5;
      wkb.Save(format.FilePath);
    }
    return wkb;
  }

  private static void ApplyStylSheetFormat(SheetInXML sht, Workbook wkb)
  {
    Worksheet worksheet1 = sht.ACSheet();
    Worksheet worksheet2 = wkb.Worksheets[worksheet1.Name];
    Type type = typeof (Worksheet);
    try
    {
      foreach (WorkSheetProperties workSheetProperties in (List<WorkSheetProperties>) sht)
      {
        if (workSheetProperties.Name.Length <= 10 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(workSheetProperties.Name.Substring(0, 7), "Freezed", false) != 0)
        {
          PropertyInfo property = type.GetProperty(workSheetProperties.Name);
          if (property.CanWrite)
            property.SetValue((object) worksheet2, RuntimeHelpers.GetObjectValue(property.GetValue((object) worksheet1)));
        }
      }
    }
    finally
    {
      List<WorkSheetProperties>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (sht.FreezedPanesRows > 0 | sht.FreezedPanesColumns > 0)
      worksheet2.FreezePanes(sht.FreezedPanesRow, sht.FreezedPanesColumn, sht.FreezedPanesRows, sht.FreezedPanesColumns);
  }

  private static void ApplyStylCellSummaryFormula(StyleInXML stl, Workbook wkb)
  {
    Worksheet worksheet = wkb.Worksheets[stl.SheetName];
    Cell cell1 = worksheet.Cells[stl.CellName];
    int row = cell1.Row;
    int lastRow = ExcelExport.SheetTracker[stl.SheetName].LastRow;
    int column = cell1.Column;
    ExcelExport.CellFormula cellFormula = new ExcelExport.CellFormula(stl.CellContent, ExcelExport.SheetTracker[stl.SheetName].DataStartRow);
    Cell cell2 = worksheet.Cells[lastRow + 1, column];
    cell2.Formula = cellFormula.ValueForRow(lastRow);
    cell2.SetStyle(stl.ACStyle());
  }

  private static void ApplyStyleCellSummaryConstant(StyleInXML stl, Workbook wkb)
  {
    Worksheet worksheet = wkb.Worksheets[stl.SheetName];
    Cell cell1 = worksheet.Cells[stl.CellName];
    Cell cell2 = worksheet.Cells[ExcelExport.SheetTracker[stl.SheetName].LastRow + 1, cell1.Column];
    cell2.PutValue(stl.CellContent);
    cell2.SetStyle(stl.ACStyle());
  }

  private static void ApplyStyleColumnFormula(StyleInXML stl, Workbook wkb)
  {
    Worksheet worksheet = wkb.Worksheets[stl.SheetName];
    Cell cell = worksheet.Cells[stl.CellName];
    int num = worksheet.Cells.MaxDataRow - cell.Row;
    StyleFlag styleFlag = new StyleFlag();
    if (num < 1)
      return;
    int row = cell.Row;
    int column = cell.Column;
    styleFlag.All = true;
    cell.SetSharedFormula(stl.CellContent, num + 1, 1);
    worksheet.Cells.CreateRange(cell.Row, cell.Column, num, 1).ApplyStyle(stl.ACStyle(), styleFlag);
    GC.Collect();
  }

  private static void ApplyStyleColumnFormat(StyleInXML stl, Workbook wkb)
  {
    Worksheet worksheet = wkb.Worksheets[stl.SheetName];
    Cell cell = worksheet.Cells[stl.CellName];
    int num = worksheet.Cells.MaxDataRow - cell.Row + 1;
    StyleFlag styleFlag = new StyleFlag();
    if (num < 1)
      return;
    styleFlag.All = true;
    worksheet.Cells.CreateRange(cell.Row, cell.Column, num, 1).ApplyStyle(stl.ACStyle(), styleFlag);
  }

  private static void ApplyStyleColumnImportBegin(StyleInXML stl, DataSet dsData, Workbook wkb)
  {
    Worksheet worksheet = wkb.Worksheets[stl.SheetName];
    Cell cell = worksheet.Cells[stl.CellName];
    DataColumn column = dsData.Tables[stl.DataTableIndex].Columns[stl.DataColumnIndex];
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add(column.ColumnName, column.DataType);
    try
    {
      foreach (DataRow row in dsData.Tables[stl.DataTableIndex].Rows)
        dataTable.Rows.Add(row[stl.DataColumnIndex]);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    worksheet.Cells.ImportDataTable(dataTable, false, cell.Row, cell.Column);
    ExcelExport.SheetTracker.AddSheetInfo(new ExcelExport.SheetInfo(stl)
    {
      LastRow = worksheet.Cells.MaxDataRow,
      LastColumn = worksheet.Cells.MaxDataColumn,
      DataStartRow = cell.Row
    });
    GC.Collect();
  }

  private static void ApplyStyleCellTableValue(StyleInXML stl, DataSet dsData, Workbook wkb)
  {
    string str = dsData.Tables[stl.DataTableIndex].Rows[stl.DataRowIndex][stl.DataColumnIndex].ToString();
    Cell cell = ExcelExport.ApplyStyleToCell(stl, wkb);
    cell.PutValue(str);
    ExcelExport.SheetTracker.AddSheetInfo(new ExcelExport.SheetInfo(stl)
    {
      LastRow = cell.Row,
      LastColumn = cell.Column
    });
    GC.Collect();
  }

  private static void ApplyStyleCellDataImportBegin(StyleInXML stl, DataSet dsData, Workbook wkb)
  {
    DataTable table = dsData.Tables[stl.DataTableIndex];
    Worksheet worksheet = wkb.Worksheets[stl.SheetName];
    Cell cell = worksheet.Cells[stl.CellName];
    worksheet.Cells.ImportDataTable(table, false, cell.Row, cell.Column);
    ExcelExport.SheetTracker.AddSheetInfo(new ExcelExport.SheetInfo(stl)
    {
      LastRow = worksheet.Cells.MaxDataRow,
      LastColumn = worksheet.Cells.MaxDataColumn,
      DataStartRow = cell.Row
    });
    GC.Collect();
  }

  private static void ApplyStyleCellConstant(StyleInXML stl, Workbook wkb)
  {
    Cell cell = ExcelExport.ApplyStyleToCell(stl, wkb);
    cell.PutValue(stl.CellContent);
    ExcelExport.SheetTracker.AddSheetInfo(new ExcelExport.SheetInfo(stl)
    {
      LastRow = cell.Row,
      LastColumn = cell.Column
    });
  }

  private static void ApplyStyleCellConstantFormula(StyleInXML stl, Workbook wkb)
  {
    Cell cell = ExcelExport.ApplyStyleToCell(stl, wkb);
    cell.Formula = stl.CellContent;
    ExcelExport.SheetTracker.AddSheetInfo(new ExcelExport.SheetInfo(stl)
    {
      LastRow = cell.Row,
      LastColumn = cell.Column
    });
  }

  private static Cell ApplyStyleToCell(StyleInXML stl, Workbook wkb)
  {
    Worksheet worksheet = wkb.Worksheets[stl.SheetName];
    Cell cell = worksheet.Cells[stl.CellName];
    worksheet.Cells.SetRowHeight(cell.Row, stl.RowHeight);
    worksheet.Cells.SetColumnWidth(cell.Column, stl.ColWidth);
    cell.SetStyle(stl.ACStyle());
    return cell;
  }

  private static Cell ApplyStyleToCell(StyleInXML stl, Workbook wkb, int Row, int Col)
  {
    Worksheet worksheet = wkb.Worksheets[stl.SheetName];
    Cell cell = worksheet.Cells[Row, Col];
    worksheet.Cells.SetRowHeight(cell.Row, stl.RowHeight);
    worksheet.Cells.SetColumnWidth(cell.Column, stl.ColWidth);
    cell.SetStyle(stl.ACStyle());
    return cell;
  }

  private static void ValidateTableData(DataSet dsData, ref StyleInXML xStyle)
  {
    if (xStyle.CellType == RangeType.CellDataImportBegin | xStyle.CellType == RangeType.CellTableValue | xStyle.CellType == RangeType.ColumnImportBegin)
    {
      if (xStyle.DataTableIndex < 0)
        throw new ExcelExportBadDataDefinitionException(xStyle, $"Table index is not defined for cell: {xStyle.CellName} Cell format of type {xStyle.CellType.ToString()} requires table index to be set.");
      if (dsData.Tables.Count < xStyle.DataTableIndex + 1)
      {
        StyleInXML styleInXml = xStyle;
        string[] strArray = new string[6]
        {
          "Table index is out of bounds: ",
          xStyle.CellName,
          "Table index requested: ",
          null,
          null,
          null
        };
        int num = xStyle.DataTableIndex;
        strArray[3] = num.ToString();
        strArray[4] = " # Of Tables in provided dataset:";
        num = dsData.Tables.Count;
        strArray[5] = num.ToString();
        string Message = string.Concat(strArray);
        throw new ExcelExportBadDataDefinitionException(styleInXml, Message);
      }
    }
    if (xStyle.CellType == RangeType.CellTableValue)
    {
      if (xStyle.DataRowIndex < 0)
        throw new ExcelExportBadDataDefinitionException(xStyle, $"Row index is not defined for cell: {xStyle.CellName} Cell format of type {xStyle.CellType.ToString()} requires row index to be set.");
      if (dsData.Tables[xStyle.DataRowIndex].Rows.Count < xStyle.DataRowIndex + 1)
      {
        StyleInXML styleInXml = xStyle;
        string[] strArray = new string[6]
        {
          "Row index is out of bounds: ",
          xStyle.CellName,
          "Row index requested: ",
          null,
          null,
          null
        };
        int num = xStyle.DataTableIndex;
        strArray[3] = num.ToString();
        strArray[4] = " # Of Rows in provided table:";
        num = dsData.Tables.Count;
        strArray[5] = num.ToString();
        string Message = string.Concat(strArray);
        throw new ExcelExportBadDataDefinitionException(styleInXml, Message);
      }
    }
    if (xStyle.CellType == RangeType.CellTableValue | xStyle.CellType == RangeType.ColumnImportBegin)
    {
      if (xStyle.DataColumnIndex < 0)
        throw new ExcelExportBadDataDefinitionException(xStyle, $"Column index is not defined for cell: {xStyle.CellName} Cell format of type {xStyle.CellType.ToString()} requires column index to be set.");
      if (dsData.Tables[xStyle.DataTableIndex].Columns.Count < xStyle.DataColumnIndex + 1)
      {
        StyleInXML styleInXml = xStyle;
        string[] strArray = new string[6]
        {
          "Column index is out of bounds: ",
          xStyle.CellName,
          "Column index requested: ",
          null,
          null,
          null
        };
        int num = xStyle.DataTableIndex;
        strArray[3] = num.ToString();
        strArray[4] = " # Of Columns in provided table:";
        num = dsData.Tables[xStyle.DataTableIndex].Columns.Count;
        strArray[5] = num.ToString();
        string Message = string.Concat(strArray);
        throw new ExcelExportBadDataDefinitionException(styleInXml, Message);
      }
    }
    xStyle.ProvidedDataValid = true;
  }

  private class CellFormula
  {
    private string _originalFormula;
    private List<ExcelExport.CellOperand> Operands;
    private int _currentRow;
    private ExcelFormula _formula;
    private string _column;

    public int CurrentRow
    {
      get => this._currentRow;
      set => this._currentRow = value;
    }

    public CellFormula(string Formula, int row)
    {
      this.Operands = new List<ExcelExport.CellOperand>();
      this._originalFormula = Formula;
      this._currentRow = row;
      this._formula = new ExcelFormula(Formula);
      int num = this._formula.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (this._formula[index].Type == ExcelFormulaTokenType.Operand && this._formula[index].Subtype == ExcelFormulaTokenSubtype.Range)
          this.Operands.Add(new ExcelExport.CellOperand(this._formula[index].Value, ref row));
      }
    }

    public void MoveNext() => ++this._currentRow;

    public string CurrentValue
    {
      get
      {
        string currentValue = this._originalFormula;
        try
        {
          foreach (ExcelExport.CellOperand operand in this.Operands)
            currentValue = currentValue.Replace(operand.OriginalValue, operand.ValueForRow(this._currentRow));
        }
        finally
        {
          List<ExcelExport.CellOperand>.Enumerator enumerator;
          enumerator.Dispose();
        }
        return currentValue;
      }
    }

    public string ValueForRow(int Row)
    {
      string str = this._originalFormula;
      try
      {
        foreach (ExcelExport.CellOperand operand in this.Operands)
          str = str.Replace(operand.OriginalValue, operand.ValueForRow(Row));
      }
      finally
      {
        List<ExcelExport.CellOperand>.Enumerator enumerator;
        enumerator.Dispose();
      }
      return str;
    }
  }

  private class CellOperand
  {
    private string _originalValue;
    private string _originalColumn;
    private int _originalRow;
    private int _currentRow;
    private string _currentValue;
    private int _FirstPlacementRow;
    private int _CurrentRowDelta;
    private bool _IsRange;
    private int _RangeFirstRow;
    private string _RangeFirstCol;
    private int _RangeLastRow;
    private string _RangeLastCol;

    public CellOperand(string Operand, ref int FirstRow)
    {
      this._IsRange = false;
      if (Operand.Contains(":"))
        this.IsRange = true;
      this.OriginalValue = Operand;
      this._FirstPlacementRow = FirstRow;
      this._CurrentRowDelta = this._originalRow - this._FirstPlacementRow;
    }

    public string OriginalValue
    {
      get
      {
        string originalValue;
        if (!this.IsRange)
          originalValue = this._originalColumn + this._originalRow.ToString();
        else
          originalValue = $"{this._RangeFirstCol}{this._RangeFirstRow.ToString()}:{this._RangeLastCol}{this._RangeLastRow.ToString()}";
        return originalValue;
      }
      set => this.SetOriginalValue(value);
    }

    private void SetOriginalValue(string value)
    {
      string str = value.Trim();
      if (!this.IsRange)
      {
        int num = str.IndexOfAny("0123456789".ToCharArray());
        this._originalColumn = str.Substring(0, num);
        this._originalRow = int.Parse(str.Substring(num, str.Length - num));
      }
      else
      {
        string[] strArray = str.Split(":".ToCharArray()[0]);
        int num1 = strArray[0].IndexOfAny("0123456789".ToCharArray());
        int num2 = strArray[1].IndexOfAny("0123456789".ToCharArray());
        this._originalColumn = strArray[0].Substring(0, num1);
        this._originalRow = int.Parse(strArray[0].Substring(num1, strArray[0].Length - num1));
        this._RangeFirstRow = this._originalRow;
        this._RangeFirstCol = this._originalColumn;
        this._RangeLastRow = int.Parse(strArray[1].Substring(num2, strArray[1].Length - num2));
        this._RangeLastCol = strArray[1].Substring(0, num2);
      }
    }

    public string OriginalColumn
    {
      get => this._originalColumn;
      set => this._originalColumn = value;
    }

    public int OriginalRow
    {
      get => this._originalRow;
      set => this._originalRow = value;
    }

    public int CurrentRow
    {
      get => this._currentRow;
      set => this._currentRow = value;
    }

    public string CurrentValue
    {
      get
      {
        string currentValue;
        if (!this.IsRange)
          currentValue = this._originalColumn + (this._currentRow + this._CurrentRowDelta).ToString();
        else
          currentValue = $"{this._RangeFirstCol}{this._RangeFirstRow.ToString()}:{this._RangeLastCol}{(this._currentRow + this._CurrentRowDelta).ToString()}";
        return currentValue;
      }
    }

    public bool IsRange
    {
      get => this._IsRange;
      set => this._IsRange = value;
    }

    public string ValueForRow(int Row)
    {
      string str;
      if (!this.IsRange)
        str = this._originalColumn + (Row + this._CurrentRowDelta).ToString();
      else
        str = $"{this._RangeFirstCol}{this._RangeFirstRow.ToString()}:{this._RangeLastCol}{(Row + this._CurrentRowDelta).ToString()}";
      return str;
    }
  }

  private class SheetInfo
  {
    private string _SheetName;
    private int _LastRow;
    private int _LastColumn;
    private int _dataStartRow;

    public SheetInfo()
    {
      this._LastRow = 0;
      this._LastColumn = 0;
      this._dataStartRow = int.MaxValue;
    }

    public SheetInfo(SheetInXML sheet)
    {
      this._LastRow = 0;
      this._LastColumn = 0;
      this._dataStartRow = int.MaxValue;
      this._SheetName = sheet.Name;
    }

    public SheetInfo(StyleInXML cell)
    {
      this._LastRow = 0;
      this._LastColumn = 0;
      this._dataStartRow = int.MaxValue;
      this._SheetName = cell.SheetName;
    }

    public int LastRow
    {
      get => this._LastRow;
      set
      {
        if (value <= this._LastRow)
          return;
        this._LastRow = value;
      }
    }

    public string SheetName
    {
      get => this._SheetName;
      set => this._SheetName = value;
    }

    public int LastColumn
    {
      get => this._LastColumn;
      set
      {
        if (value <= this._LastColumn)
          return;
        this._LastColumn = value;
      }
    }

    public int DataStartRow
    {
      get => this._dataStartRow;
      set
      {
        if (value >= this._dataStartRow)
          return;
        this._dataStartRow = value;
      }
    }
  }

  private class TrackSheets : Dictionary<string, ExcelExport.SheetInfo>
  {
    public void AddSheetInfo(ExcelExport.SheetInfo SheetInfo)
    {
      string sheetName = SheetInfo.SheetName;
      if (this.ContainsKey(sheetName))
      {
        this[sheetName].LastRow = SheetInfo.LastRow;
        this[sheetName].DataStartRow = SheetInfo.DataStartRow;
        this[sheetName].LastColumn = SheetInfo.LastColumn;
      }
      else
        this.Add(sheetName, SheetInfo);
    }
  }
}
