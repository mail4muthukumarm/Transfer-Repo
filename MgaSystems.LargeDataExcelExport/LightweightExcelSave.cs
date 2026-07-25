// Decompiled with JetBrains decompiler
// Type: MgaSystems.LargeDataExcelExport.LightweightExcelSave
// Assembly: MgaSystems.LargeDataExcelExport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4F6E514B-28D1-48BF-8E06-BB678B09C1E7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.LargeDataExcelExport.dll

using MGASystems.AsposeFacade.Cells;
using System;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Xml;

#nullable disable
namespace MgaSystems.LargeDataExcelExport;

internal class LightweightExcelSave : LightCellsDataProvider, IDisposable
{
  private Workbook _wkb;
  private int _tableCount;
  private int _row = -1;
  private int _column = -1;
  private string _dataType = string.Empty;
  private DataSet _schemaDs;
  private string _lastReadTableName;
  private bool _nextTable;
  private FileStream _fs;
  private ZipArchive _zipStream;
  private ZipArchiveEntry _zipEntry;
  private XmlReader _xrdr;
  private string _zipPath;
  private IProgress<LargeDataExcelExportProgress> _progress;
  private int _recordsToWrite;
  private int _rowsWritten;
  private int _progressPercentIncrement;
  private XmlNodeType _previousNodeType;
  private string _previousNodeName;
  private bool _disposed;

  internal LightweightExcelSave(
    Workbook wkb,
    DataSet schemaDs,
    string zipPath,
    string tempFilePath,
    IProgress<LargeDataExcelExportProgress> progress,
    int recordsToWrite)
  {
    this._wkb = wkb;
    this._schemaDs = schemaDs;
    this._zipPath = zipPath;
    this._fs = new FileStream(this._zipPath, FileMode.Open);
    this._zipStream = new ZipArchive((Stream) this._fs);
    this._zipEntry = this._zipStream.Entries[0];
    this._xrdr = XmlReader.Create(this._zipEntry.Open());
    this._tableCount = 0;
    this._progress = progress;
    this._recordsToWrite = recordsToWrite;
    this._progressPercentIncrement = this._recordsToWrite / 33;
  }

  public bool IsGatherString() => false;

  public int NextCell()
  {
    if (!this._disposed)
    {
      ++this._column;
      if (this._row == 0)
      {
        if (this._column == this._schemaDs.Tables[this._tableCount].Columns.Count)
          this._column = -1;
      }
      else
      {
        do
        {
          this._previousNodeType = this._xrdr.NodeType;
          this._previousNodeName = this._xrdr.Name;
          if (!this._xrdr.Read())
          {
            this._row = -1;
            this._column = -1;
            break;
          }
          if (this._xrdr.Name.StartsWith("Table"))
          {
            if (string.IsNullOrEmpty(this._lastReadTableName))
              this._lastReadTableName = this._xrdr.Name;
            if (!this._lastReadTableName.Equals(this._xrdr.Name))
            {
              ++this._tableCount;
              this._nextTable = true;
              this._lastReadTableName = this._xrdr.Name;
              this._row = -1;
              this._column = -1;
              break;
            }
            if (this._xrdr.NodeType.Equals((object) XmlNodeType.EndElement))
              this._column = -1;
            else if (this._xrdr.NodeType.Equals((object) XmlNodeType.Element))
              this._column = 0;
          }
          else if (this._xrdr.NodeType.Equals((object) XmlNodeType.Element))
            this._dataType = this._xrdr.GetAttribute("DataType");
        }
        while (this._xrdr.NodeType != XmlNodeType.Text && !this._xrdr.IsEmptyElement && (!this._xrdr.Name.StartsWith("Table") || !this._xrdr.NodeType.Equals((object) XmlNodeType.EndElement)) && (!this._previousNodeType.Equals((object) XmlNodeType.Element) || !this._xrdr.NodeType.Equals((object) XmlNodeType.EndElement) || !this._previousNodeName.Equals(this._xrdr.Name)));
      }
    }
    return this._column;
  }

  public int NextRow()
  {
    if (!this._nextTable)
      ++this._row;
    else
      this._nextTable = false;
    if (!this._disposed && this._xrdr.EOF)
    {
      this._row = -1;
      this._xrdr.Close();
      this._xrdr.Dispose();
    }
    ++this._rowsWritten;
    return this._row;
  }

  public void StartCell(Cell cell)
  {
    if (!this._disposed && this._row == 0)
      cell.PutValue(this._schemaDs.Tables[this._tableCount].Columns[this._column].ColumnName);
    else if (!this._disposed && (this._xrdr.IsEmptyElement || this._previousNodeType.Equals((object) XmlNodeType.Element) && this._xrdr.NodeType.Equals((object) XmlNodeType.EndElement) && this._previousNodeName.Equals(this._xrdr.Name)))
    {
      cell.PutValue(string.Empty);
    }
    else
    {
      if (this._disposed)
        return;
      string dataType = this._dataType;
      if (dataType != null)
      {
        switch (dataType.Length)
        {
          case 4:
            switch (dataType[0])
            {
              case 'B':
                if (dataType == "Byte")
                  goto label_32;
                goto label_41;
              case 'G':
                if (dataType == "Guid")
                  break;
                goto label_41;
              default:
                goto label_41;
            }
            break;
          case 5:
            switch (dataType[3])
            {
              case '1':
                if (dataType == "Int16")
                {
                  short result;
                  if (short.TryParse(this._xrdr.Value, out result))
                  {
                    cell.PutValue((int) result);
                    return;
                  }
                  cell.PutValue(this._xrdr.Value);
                  return;
                }
                goto label_41;
              case '3':
                if (dataType == "Int32")
                  goto label_32;
                goto label_41;
              default:
                goto label_41;
            }
          case 6:
            switch (dataType[0])
            {
              case 'D':
                if (dataType == "Double")
                {
                  double result;
                  if (double.TryParse(this._xrdr.Value, out result))
                  {
                    cell.PutValue(result);
                    return;
                  }
                  cell.PutValue(this._xrdr.Value);
                  return;
                }
                goto label_41;
              case 'S':
                if (dataType == "String")
                  break;
                goto label_41;
              default:
                goto label_41;
            }
            break;
          case 7:
            switch (dataType[0])
            {
              case 'B':
                if (dataType == "Boolean")
                {
                  bool result;
                  if (bool.TryParse(this._xrdr.Value, out result))
                  {
                    cell.PutValue(result);
                    return;
                  }
                  cell.PutValue(this._xrdr.Value);
                  return;
                }
                goto label_41;
              case 'D':
                if (dataType == "Decimal")
                {
                  Decimal result;
                  if (Decimal.TryParse(this._xrdr.Value, out result))
                  {
                    cell.PutValue(result);
                    return;
                  }
                  cell.PutValue(this._xrdr.Value);
                  return;
                }
                goto label_41;
              case 'I':
                if (dataType == "Integer")
                  goto label_32;
                goto label_41;
              default:
                goto label_41;
            }
          case 8:
            if (dataType == "DateTime")
            {
              DateTime result;
              if (DateTime.TryParse(this._xrdr.Value, out result))
              {
                Style style = cell.GetStyle();
                style.Custom = "mm/dd/yyyy";
                cell.SetStyle(style);
                cell.PutValue(result);
                return;
              }
              cell.PutValue(this._xrdr.Value);
              return;
            }
            goto label_41;
          default:
            goto label_41;
        }
        cell.PutValue(this._xrdr.Value);
        return;
label_32:
        int result1;
        if (int.TryParse(this._xrdr.Value, out result1))
        {
          cell.PutValue(result1);
          return;
        }
        cell.PutValue(this._xrdr.Value);
        return;
      }
label_41:
      cell.PutValue(this._xrdr.Value);
    }
  }

  public void StartRow(Row row)
  {
    if (this._rowsWritten % 1000 != 0 && (this._progressPercentIncrement == 0 || this._rowsWritten % this._progressPercentIncrement != 0))
      return;
    LargeDataExcelExportProgress excelExportProgress = new LargeDataExcelExportProgress();
    excelExportProgress.ProgressMessage = $"Creating excel file. Writing row {this._rowsWritten.ToString()} written";
    excelExportProgress.ProgressPercentChange = this._rowsWritten % this._progressPercentIncrement != 0 ? 0 : 1;
    if (this._progress != null)
      this._progress.Report(excelExportProgress);
  }

  public bool StartSheet(int sheetIndex)
  {
    if (!this._disposed && sheetIndex <= this._schemaDs.Tables.Count)
      return true;
    if (!this._disposed)
    {
      this._xrdr.Close();
      this._xrdr.Dispose();
    }
    return false;
  }

  public void Dispose()
  {
    this.Dispose(true);
    GC.SuppressFinalize((object) this);
  }

  public void Dispose(bool disposing)
  {
    if (this._disposed || !disposing)
      return;
    if (this._schemaDs != null)
      this._schemaDs.Dispose();
    if (this._xrdr != null)
    {
      this._xrdr.Close();
      this._xrdr.Dispose();
    }
    if (this._zipStream != null)
      this._zipStream.Dispose();
    if (this._fs != null)
    {
      this._fs.Close();
      this._fs.Dispose();
    }
    this._disposed = true;
  }
}
