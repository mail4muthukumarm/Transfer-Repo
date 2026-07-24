// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.ExcelImport.ExcelDataLoadedEventArgs
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.ExcelImport;

public class ExcelDataLoadedEventArgs : EventArgs
{
  public DataSet ExcelData { get; private set; }

  public string ExcelFileName { get; private set; }

  public ExcelDataLoadedEventArgs()
  {
  }

  public ExcelDataLoadedEventArgs(DataSet excelData, string excelFileName)
  {
    this.ExcelData = excelData;
    this.ExcelFileName = excelFileName;
  }
}
