// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Excel.Data.DatabaseInformation
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Common.ErrorHandling;
using System;

#nullable disable
namespace MgaSystems.IMS.Excel.Data;

internal static class DatabaseInformation
{
  private static string _excelFileStoreBinarySerializationType;

  public static string ExcelFileStoreBinarySerializationType
  {
    get
    {
      if (string.IsNullOrEmpty(DatabaseInformation._excelFileStoreBinarySerializationType))
      {
        try
        {
          DatabaseInformation._excelFileStoreBinarySerializationType = MGASystems.IMS.NoteDocuments.Common.FetchColumnDataType("tblExcelRating_ExcelFileStore", "CompressedExcelSheet");
        }
        catch (Exception ex)
        {
          ErrorHandler.SilentHandleError(ex);
          DatabaseInformation._excelFileStoreBinarySerializationType = "image";
        }
      }
      return DatabaseInformation._excelFileStoreBinarySerializationType;
    }
  }
}
