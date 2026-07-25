// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Import_Inspection.InspectionInfoColumnMapping
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using MGASystems.Data;
using MGASystems.Data.Binding;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Underwriting.Import_Inspection;

public abstract class InspectionInfoColumnMapping : BindingObject
{
  public string MappingName { get; set; }

  [NotificationProperty]
  public virtual string IMS { get; set; }

  [NotificationProperty]
  public virtual string Spreadsheet { get; set; }

  public string IMSTable { get; set; }

  public static InspectionInfoColumnMapping Create(string imsColName)
  {
    return NotifyProxyTypeManager.Allocate<InspectionInfoColumnMapping>(new object[1]
    {
      (object) imsColName
    });
  }

  public static InspectionInfoColumnMapping Create(
    string mappingName,
    string imsColName,
    string spreadsheetColumn)
  {
    return NotifyProxyTypeManager.Allocate<InspectionInfoColumnMapping>(new object[3]
    {
      (object) mappingName,
      (object) imsColName,
      (object) spreadsheetColumn
    });
  }

  public InspectionInfoColumnMapping(string imsColName)
  {
    this.IMS = imsColName;
    this.Spreadsheet = "";
    this.IMSTable = "tblInspectionInformation";
  }

  public InspectionInfoColumnMapping(
    string mappingName,
    string imsColName,
    string spreadsheetColumn)
  {
    this.MappingName = mappingName;
    this.IMS = imsColName;
    this.Spreadsheet = spreadsheetColumn;
  }

  public void UpdateMappings(
    string mappingName,
    string imsTable,
    string imsColumn,
    string spreadsheetColumn)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblInspectionInfoSpreadsheetMapping (MappingName, IMSTable, IMSColumn, SpreadsheetColumn) VALUES (@MappingName, @IMSTable, @IMSColumn, @SpreadsheetColumn)", new object[8]
    {
      (object) "@MappingName",
      (object) mappingName,
      (object) "@IMSTable",
      (object) imsTable,
      (object) "@IMSColumn",
      (object) imsColumn,
      (object) "@SpreadsheetColumn",
      (object) spreadsheetColumn
    });
  }
}
