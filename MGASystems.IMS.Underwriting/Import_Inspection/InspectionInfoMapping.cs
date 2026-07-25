// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Import_Inspection.InspectionInfoMapping
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Mga.Wpf.Ims.Data;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.Validation;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Underwriting.Import_Inspection;

public abstract class InspectionInfoMapping : BindingObject, IDataErrorInfo
{
  public string MappingName { get; set; }

  [NotificationProperty]
  public virtual ObservableCollection<InspectionInfoColumnMapping> ColumnMapping { get; set; }

  [NotificationProperty]
  public virtual SpreadsheetColumn SelectedMapping { get; set; }

  [Required(ErrorMessage = "Policy No. mapping required")]
  [NotificationProperty]
  public virtual string PolicyNumberColumn { get; set; }

  string IDataErrorInfo.Error => string.Empty;

  string IDataErrorInfo.this[string memberName]
  {
    get => DataErrorInfoSupport.GetError((object) this, memberName);
  }

  public static InspectionInfoMapping Create()
  {
    return NotifyProxyTypeManager.Allocate<InspectionInfoMapping>();
  }

  public void LoadDatabaseColumns()
  {
    this.ColumnMapping = new ObservableCollection<InspectionInfoColumnMapping>();
    foreach (string column in InspectionInformation.GetColumns())
      this.ColumnMapping.Add(InspectionInfoColumnMapping.Create(column));
    this.ColumnMapping.Add(InspectionInfoColumnMapping.Create("PolicyNumber"));
  }

  public static ObservableCollection<SearchObject> GetMappings()
  {
    return new ObservableCollection<SearchObject>((IEnumerable<SearchObject>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DISTINCT MappingName FROM tblInspectionInfoSpreadsheetMapping").AsEnumerable().Select<DataRow, SearchObject>((System.Func<DataRow, SearchObject>) (row => SearchObject.Create(0, row.Field<string>("MappingName"), (object) row.Field<string>("MappingName")))));
  }

  public List<InspectionInfoColumnMapping> LoadMappings(
    string mappingName,
    SpreadsheetInfo sheetInfo)
  {
    EnumerableRowCollection<InspectionInfoColumnMapping> enumerableRowCollection = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT MappingName, IMSColumn, SpreadsheetColumn FROM tblInspectionInfoSpreadsheetMapping WHERE MappingName = @MappingName", new object[2]
    {
      (object) "@MappingName",
      (object) mappingName
    }).AsEnumerable().Select<DataRow, InspectionInfoColumnMapping>((System.Func<DataRow, InspectionInfoColumnMapping>) (row => InspectionInfoColumnMapping.Create(row.Field<string>("MappingName"), row.Field<string>("IMSColumn"), row.Field<string>("SpreadsheetColumn"))));
    List<InspectionInfoColumnMapping> infoColumnMappingList1 = new List<InspectionInfoColumnMapping>();
    List<InspectionInfoColumnMapping> infoColumnMappingList2 = new List<InspectionInfoColumnMapping>();
    foreach (InspectionInfoColumnMapping infoColumnMapping in enumerableRowCollection)
    {
      InspectionInfoColumnMapping dbMapping = infoColumnMapping;
      if (sheetInfo.ColumnList.Where<SpreadsheetColumn>((System.Func<SpreadsheetColumn, bool>) (x => x.ColumnName.Trim() == dbMapping.Spreadsheet.Trim())).FirstOrDefault<SpreadsheetColumn>() != null)
        infoColumnMappingList1.Add(dbMapping);
      else
        infoColumnMappingList2.Add(dbMapping);
    }
    foreach (InspectionInfoColumnMapping infoColumnMapping1 in infoColumnMappingList1)
    {
      InspectionInfoColumnMapping dbMapping = infoColumnMapping1;
      InspectionInfoColumnMapping infoColumnMapping2 = this.ColumnMapping.Where<InspectionInfoColumnMapping>((System.Func<InspectionInfoColumnMapping, bool>) (x => x.IMS == dbMapping.IMS)).FirstOrDefault<InspectionInfoColumnMapping>();
      if (infoColumnMapping2 != null)
        infoColumnMapping2.Spreadsheet = dbMapping.Spreadsheet;
    }
    InspectionInfoColumnMapping infoColumnMapping3 = this.ColumnMapping.Where<InspectionInfoColumnMapping>((System.Func<InspectionInfoColumnMapping, bool>) (m => m.IMS == "PolicyNumber")).FirstOrDefault<InspectionInfoColumnMapping>();
    if (infoColumnMapping3 != null)
      this.PolicyNumberColumn = infoColumnMapping3.Spreadsheet;
    return infoColumnMappingList2;
  }

  public void UpdateMappings()
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblInspectionInfoSpreadsheetMapping WHERE MappingName=@MN", new object[2]
    {
      (object) "@MN",
      (object) this.MappingName
    });
    foreach (InspectionInfoColumnMapping infoColumnMapping in this.ColumnMapping.Where<InspectionInfoColumnMapping>((System.Func<InspectionInfoColumnMapping, bool>) (x => !string.IsNullOrEmpty(x.Spreadsheet))))
      infoColumnMapping.UpdateMappings(this.MappingName, infoColumnMapping.IMSTable, infoColumnMapping.IMS, infoColumnMapping.Spreadsheet);
  }
}
