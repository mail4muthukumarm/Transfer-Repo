// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.AsposeExcelExtensions
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.AsposeFacade.Cells;
using System;

#nullable disable
namespace MGASystems.IMS.Excel;

public static class AsposeExcelExtensions
{
  public static void SetCustomDocumentProperty(
    this Workbook workBook,
    string propertyName,
    string value)
  {
    if (string.IsNullOrWhiteSpace(propertyName))
      throw new ArgumentNullException(nameof (propertyName));
    if (!workBook.CustomDocumentProperties.Contains(propertyName))
      workBook.CustomDocumentProperties.Add(propertyName, value);
    else
      workBook.CustomDocumentProperties[propertyName].Value = (object) value;
  }

  public static void SetCustomDocumentProperty(
    this Workbook workBook,
    string propertyName,
    int value)
  {
    if (string.IsNullOrWhiteSpace(propertyName))
      throw new ArgumentNullException(nameof (propertyName));
    if (!workBook.CustomDocumentProperties.Contains(propertyName))
      workBook.CustomDocumentProperties.Add(propertyName, value);
    else
      workBook.CustomDocumentProperties[propertyName].Value = (object) value;
  }
}
