// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Rating.ExcelFilePicker.ExcelFileInfo
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Data.Binding;
using System;

#nullable disable
namespace MGASystems.IMS.Excel.Rating.ExcelFilePicker;

public class ExcelFileInfo : BindingObject
{
  public string FileName { get; }

  public string Description { get; }

  public Guid DocumentStoreGuid { get; }

  public DateTime DateAdded { get; }

  public ExcelFileInfo(
    Guid documentStoreGuid,
    string fileName,
    string description,
    DateTime dateAdded)
  {
    this.DocumentStoreGuid = documentStoreGuid;
    this.FileName = fileName;
    this.Description = description;
    this.DateAdded = dateAdded;
  }
}
