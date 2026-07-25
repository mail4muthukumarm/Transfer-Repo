// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.CompanyGroupsCompaniesCompanyLocations
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class CompanyGroupsCompaniesCompanyLocations(
  string labelText,
  bool ShowAllOption,
  bool CheckAllOption,
  bool ShowEntityLocations,
  bool ShowEntityContacts,
  bool ReturnAll,
  int ControlHeight = 144 /*0x90*/) : EntityEntityLocationEntityContactTree(labelText, $"SELECT CompanyGroupGUID AS EntityGUID, CompanyGroupName AS EntityName FROM tblCompanyGroups UNION SELECT '{"39788CC4-4B05-4F34-8EE8-862E71A46D69"}' AS EntityGUID, 'Ungrouped' AS EntityName  ORDER BY EntityName", string.Format("SELECT IsNull(cg.CompanyGroupGUID,CAST('{0}' as UNIQUEIDENTIFIER)) AS EntityGUID, c.CompanyGUID AS EntityLocationGUID, c.CompanyName AS EntityLocationName FROM tblCompanyGroups AS cg RIGHT OUTER JOIN tblCompanies AS c ON cg.CompanyGroupGUID = c.CompanyGroupGUID UNION SELECT CAST('{0}' as UNIQUEIDENTIFIER) AS EntityGUID, '{1}' AS EntityLocationGUID, 'Unknown' AS EntityLocationName ORDER BY EntityLocationName", (object) "39788CC4-4B05-4F34-8EE8-862E71A46D69", (object) "A8E63007-DE82-4E6D-B491-6AA89F2FF540"), $"SELECT IsNull(cg.CompanyGroupGUID,CAST('{"39788CC4-4B05-4F34-8EE8-862E71A46D69"}' as UNIQUEIDENTIFIER)) AS EntityGUID, IsNull(c.CompanyGUID,CAST('{"A8E63007-DE82-4E6D-B491-6AA89F2FF540"}' as UNIQUEIDENTIFIER))  AS EntityLocationGUID, cl.CompanyLocationGUID AS EntityContactGUID, cl.LocationName AS EntityContactnName FROM tblCompanyGroups AS cg RIGHT OUTER JOIN tblCompanies AS c ON cg.CompanyGroupGUID = c.CompanyGroupGUID RIGHT OUTER JOIN tblCompanyLocations AS cl ON c.CompanyGUID = cl.CompanyGUID ORDER BY EntityContactnName", ShowAllOption, CheckAllOption, ShowEntityLocations, ShowEntityContacts, ReturnAll, ControlHeight)
{
  private const string SQLCompanies = "SELECT CompanyGroupGUID AS EntityGUID, CompanyGroupName AS EntityName FROM tblCompanyGroups UNION SELECT '{0}' AS EntityGUID, 'Ungrouped' AS EntityName  ORDER BY EntityName";
  private const string SQLCompaniesLocations = "SELECT IsNull(cg.CompanyGroupGUID,CAST('{0}' as UNIQUEIDENTIFIER)) AS EntityGUID, c.CompanyGUID AS EntityLocationGUID, c.CompanyName AS EntityLocationName FROM tblCompanyGroups AS cg RIGHT OUTER JOIN tblCompanies AS c ON cg.CompanyGroupGUID = c.CompanyGroupGUID UNION SELECT CAST('{0}' as UNIQUEIDENTIFIER) AS EntityGUID, '{1}' AS EntityLocationGUID, 'Unknown' AS EntityLocationName ORDER BY EntityLocationName";
  private const string SQLCompaniesContacts = "SELECT IsNull(cg.CompanyGroupGUID,CAST('{0}' as UNIQUEIDENTIFIER)) AS EntityGUID, IsNull(c.CompanyGUID,CAST('{1}' as UNIQUEIDENTIFIER))  AS EntityLocationGUID, cl.CompanyLocationGUID AS EntityContactGUID, cl.LocationName AS EntityContactnName FROM tblCompanyGroups AS cg RIGHT OUTER JOIN tblCompanies AS c ON cg.CompanyGroupGUID = c.CompanyGroupGUID RIGHT OUTER JOIN tblCompanyLocations AS cl ON c.CompanyGUID = cl.CompanyGUID ORDER BY EntityContactnName";
  private const string EmptyGroupGUID = "39788CC4-4B05-4F34-8EE8-862E71A46D69";
  private const string EmptyCompanyGUID = "A8E63007-DE82-4E6D-B491-6AA89F2FF540";
}
