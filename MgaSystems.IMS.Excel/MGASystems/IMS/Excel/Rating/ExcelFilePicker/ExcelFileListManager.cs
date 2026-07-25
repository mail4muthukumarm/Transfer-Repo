// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Rating.ExcelFilePicker.ExcelFileListManager
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Data;
using MGASystems.Data.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Excel.Rating.ExcelFilePicker;

public class ExcelFileListManager : BindingObject
{
  public ObservableCollection<ExcelFileInfo> ExcelFiles { get; private set; }

  private ExcelFileListManager()
  {
  }

  public static ExcelFileListManager FromControlNo(int controlNo)
  {
    return new ExcelFileListManager()
    {
      ExcelFiles = new ObservableCollection<ExcelFileInfo>((IEnumerable<ExcelFileInfo>) DefaultDatabase.ExecuteDataTable("DocumentSystem_FetchExcelDocumentsByControl", new object[2]
      {
        (object) "@controlNo",
        (object) controlNo
      }).AsEnumerable().Select<DataRow, ExcelFileInfo>((System.Func<DataRow, ExcelFileInfo>) (row => new ExcelFileInfo(row.Field<Guid>("DocumentStoreGUID"), row.Field<string>("FileName"), row.Field<string>("Description"), row.Field<DateTime>("DateAdded")))))
    };
  }

  public static ExcelFileListManager FromQuoteId(int quoteID)
  {
    return new ExcelFileListManager()
    {
      ExcelFiles = new ObservableCollection<ExcelFileInfo>((IEnumerable<ExcelFileInfo>) DefaultDatabase.ExecuteDataTable("DocumentSystem_FetchExcelDocumentsByQuote", new object[2]
      {
        (object) "@QuoteID",
        (object) quoteID
      }).AsEnumerable().Select<DataRow, ExcelFileInfo>((System.Func<DataRow, ExcelFileInfo>) (row => new ExcelFileInfo(row.Field<Guid>("DocumentStoreGUID"), row.Field<string>("FileName"), row.Field<string>("Description"), row.Field<DateTime>("DateAdded")))))
    };
  }
}
