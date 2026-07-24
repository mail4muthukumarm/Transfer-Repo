// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.DocumentTemplateMetaData.DocumentTemplateMetaDataDto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.DocumentTemplateMetaData;

public class DocumentTemplateMetaDataDto : DtoBase<int>
{
  [TableFieldMapping("TemplateId")]
  public int TemplateId { get; set; }

  [TableFieldMapping("TemplateType")]
  public char TemplateType { get; set; }

  [TableFieldMapping("AutomationGroupID")]
  public int AutomationGroupID { get; set; }

  [TableFieldMapping("TemplateName")]
  public string TemplateName { get; set; }

  [TableFieldMapping("Description")]
  public string Description { get; set; }

  [TableFieldMapping("FolderID")]
  public int? FolderID { get; set; }

  [TableFieldMapping("TemplateGroupID")]
  public int? TemplateGroupID { get; set; }

  [TableFieldMapping("IsPolicyForm")]
  public bool IsPolicyForm { get; set; }

  [TableFieldMapping("IsEditable")]
  public bool IsEditable { get; set; }

  [TableFieldMapping("SaveAsType")]
  public char SaveAsType { get; set; }

  [TableFieldMapping("FileOnly")]
  public bool FileOnly { get; set; }

  [TableFieldMapping("Hidden")]
  public bool Hidden { get; set; }

  [TableFieldMapping("Removable")]
  public bool Removable { get; set; }

  [TableFieldMapping("HideWaterMark")]
  public bool HideWaterMark { get; set; }

  [TableFieldMapping("IsEmail")]
  public bool IsEmail { get; set; }

  [TableFieldMapping("FileOnlyName")]
  public string FileOnlyName { get; set; }

  [TableFieldMapping("SeparateDoc")]
  public bool SeparateDoc { get; set; }

  [TableFieldMapping("SeparateDocName")]
  public string SeparateDocName { get; set; }

  [TableFieldMapping("RequiresEdit")]
  public bool RequiresEdit { get; set; }

  [TableFieldMapping("CopyForwardOnRenewal")]
  public bool? CopyForwardOnRenewal { get; set; }

  [TableFieldMapping("SuppressTags")]
  public bool? SuppressTags { get; set; }

  [TableFieldMapping("OnDemand")]
  public bool OnDemand { get; set; }

  [TableFieldMapping("OriginalFileName")]
  public string OriginalFileName { get; set; }

  public override int UniqueIdentifier => this.TemplateId;
}
