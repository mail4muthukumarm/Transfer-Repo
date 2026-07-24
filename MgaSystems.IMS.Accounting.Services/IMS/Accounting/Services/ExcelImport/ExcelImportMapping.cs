// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.ExcelImport.ExcelImportMapping
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.ExcelImport;

[Serializable]
public class ExcelImportMapping
{
  public string MappingName { get; set; }

  public Type MappingType { get; set; }

  public string ExcelFieldName { get; set; }

  public bool IsRequired { get; set; }

  public bool GenerateField { get; set; }

  public object DefaultValue { get; set; }

  public ExcelImportMapping()
  {
  }

  public ExcelImportMapping(string mapName, Type mapType, bool isRequired = false, bool generateField = false)
  {
    this.MappingName = mapName;
    this.MappingType = mapType;
    this.IsRequired = isRequired;
    this.GenerateField = generateField;
    this.DefaultValue = (object) null;
  }

  public ExcelImportMapping(
    string mapName,
    Type mapType,
    object defaultValue,
    bool isRequired = false,
    bool generateField = true)
  {
    this.MappingName = mapName;
    this.MappingType = mapType;
    this.IsRequired = isRequired;
    this.GenerateField = generateField;
    this.DefaultValue = defaultValue;
  }
}
