// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.Client
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Data;
using System.Data;

#nullable disable
namespace MGASystems.BusinessObjects;

public class Client
{
  public string Name => Client.GetDatabaseField("CompanyName") ?? string.Empty;

  public string Phone => Client.GetDatabaseField("CompanyPhone") ?? string.Empty;

  public string Fax => Client.GetDatabaseField("CompanyFax") ?? string.Empty;

  public string Address1 => Client.GetDatabaseField("CompanyAddress1") ?? string.Empty;

  public string Address2 => Client.GetDatabaseField("CompanyAddress2") ?? string.Empty;

  public string City => Client.GetDatabaseField("CompanyCity") ?? string.Empty;

  public string State => Client.GetDatabaseField("CompanyState") ?? string.Empty;

  public string Zip => Client.GetDatabaseField("CompanyZip") ?? string.Empty;

  public string Zip4 => Client.GetDatabaseField("CompanyZip4") ?? string.Empty;

  private static string GetDatabaseField(string fieldName)
  {
    return DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT SettingValueString FROM tblSystemSettings WHERE Setting=@Setting", new object[2]
    {
      (object) "@Setting",
      (object) fieldName
    });
  }
}
