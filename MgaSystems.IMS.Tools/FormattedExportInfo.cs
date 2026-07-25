// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.FormattedExportInfo
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using MGASystems.AsposeFacade.Cells;
using System;
using System.Data;

#nullable disable
namespace MGASystems.Tools;

public class FormattedExportInfo : IDisposable
{
  private bool _isFormatted;
  private DataTable _dtFormat;
  private DataSet _dsData;
  private DataSet _source;
  private string _filePath;
  private EventHandler<ExportExcelCellCreatedEventArgs> _cellCreatedHandler;
  private FileFormatType _exportFormat;
  private bool disposedValue;

  public bool IsFormatted
  {
    get => this._isFormatted;
    set => this._isFormatted = value;
  }

  public DataTable DtFormat
  {
    get => this._dtFormat;
    set => this._dtFormat = value;
  }

  public DataSet DsData
  {
    get => this._dsData;
    set => this._dsData = value;
  }

  public DataSet Source
  {
    get => this._source;
    set => this._source = value;
  }

  public string FilePath
  {
    get => this._filePath;
    set => this._filePath = value;
  }

  public EventHandler<ExportExcelCellCreatedEventArgs> CellCreatedHandler
  {
    get => this._cellCreatedHandler;
    set => this._cellCreatedHandler = value;
  }

  public FileFormatType ExportFormat
  {
    get => this._exportFormat;
    set => this._exportFormat = value;
  }

  public FormattedExportInfo()
  {
    this._isFormatted = false;
    this._dtFormat = new DataTable();
    this._dsData = new DataSet();
    this._filePath = "";
    this._exportFormat = (FileFormatType) 6;
  }

  public FormattedExportInfo(DataSet source)
  {
    this._isFormatted = false;
    this._dtFormat = new DataTable();
    this._dsData = new DataSet();
    this._filePath = "";
    this._exportFormat = (FileFormatType) 6;
    this._source = source;
    int num = source.Tables.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (source.Tables[index].Columns.Contains("ExtendedExportCellFormat") && source.Tables[index].Columns.Contains("CellFormat"))
      {
        this._dsData = source.Copy();
        this._dsData.Tables.RemoveAt(index);
        this._dtFormat = source.Tables[index].Copy();
        this._isFormatted = true;
        break;
      }
    }
  }

  protected virtual void Dispose(bool disposing)
  {
    if (!this.disposedValue && disposing)
    {
      this._dtFormat.Dispose();
      this._dsData.Dispose();
      GC.Collect();
    }
    this.disposedValue = true;
  }

  public void Dispose() => this.Dispose(true);
}
