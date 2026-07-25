// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.StandardRating.ExcelMappingError
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Data.Export;

#nullable disable
namespace MGASystems.IMS.Excel.Data.StandardRating;

public class ExcelMappingError
{
  [ExcelExportMapping("Error", 1)]
  public string Error { get; }

  [ExcelExportMapping("Cell", 0)]
  public string Cell { get; }

  public ExcelMappingError(string cell, string error)
  {
    this.Error = error;
    this.Cell = cell;
  }

  public override string ToString() => this.Error;
}
