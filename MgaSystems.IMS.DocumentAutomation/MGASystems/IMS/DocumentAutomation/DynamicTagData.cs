// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.DynamicTagData
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public class DynamicTagData
{
  private string _dataTableName;
  private string _tagName;
  private string _tagDescription;
  private string _dataFieldName;
  private string _groupName;

  public DynamicTagData(
    string dataTableName,
    string tagName,
    string tagDescription,
    string dataFieldName,
    string groupName)
  {
    this._dataTableName = dataTableName;
    this._tagName = tagName;
    this._tagDescription = tagDescription;
    this._dataFieldName = dataFieldName;
    this._groupName = groupName;
  }

  public string DataTableName => this._dataTableName;

  public string TagName => this._tagName;

  public string TagDescription => this._tagDescription;

  public string DataFieldName => this._dataFieldName;

  public string GroupName => this._groupName;
}
