// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Attorney_Management.AttorneyManagementDto
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data.CommonInterface;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Attorney_Management;

public class AttorneyManagementDto : 
  DtoBase<Guid>,
  INamedValue<Guid>,
  IUniqueObject<Guid>,
  IUniqueObject,
  INamedValue
{
  public string Name => this.AttorneyName.Length <= 0 ? this.LawFirm : this.AttorneyName;

  public virtual Guid UniqueIdentifier => this.AttorneyGuid;

  [TableFieldMapping("AttorneyGuid")]
  public virtual Guid AttorneyGuid { get; set; }

  [TableFieldMapping("AttorneyType")]
  public virtual string AttorneyType { get; set; } = string.Empty;

  [TableFieldMapping("LawFirm")]
  public virtual string LawFirm { get; set; } = string.Empty;

  [TableFieldMapping("AttorneyName")]
  public virtual string AttorneyName { get; set; } = string.Empty;

  [TableFieldMapping("FEINSSN")]
  public virtual string FEINSSN { get; set; } = string.Empty;

  [TableFieldMapping("AttorneyEntityType")]
  public virtual string AttorneyEntityType { get; set; } = string.Empty;

  [TableFieldMapping("Address1")]
  public virtual string Address1 { get; set; } = string.Empty;

  [TableFieldMapping("Address2")]
  public virtual string Address2 { get; set; } = string.Empty;

  [TableFieldMapping("City")]
  public virtual string City { get; set; } = string.Empty;

  [TableFieldMapping("State")]
  public virtual string State { get; set; } = string.Empty;

  [TableFieldMapping("Zip")]
  public virtual string ZipCode { get; set; } = string.Empty;

  [TableFieldMapping("ZipExt")]
  public virtual string ZipCodeExtension { get; set; } = string.Empty;

  [TableFieldMapping("County")]
  public virtual string County { get; set; } = string.Empty;

  [TableFieldMapping("ISOCountryCode")]
  public virtual string ISOCountryCode { get; set; } = string.Empty;

  [TableFieldMapping("PhoneNumber")]
  public virtual string PhoneNumber { get; set; } = string.Empty;

  [TableFieldMapping("FaxNumber")]
  public virtual string FaxNumber { get; set; } = string.Empty;

  [TableFieldMapping("LastModified")]
  public virtual DateTime LastModifiedDate { get; set; }

  [TableFieldMapping("ModifiedByGuid")]
  public virtual Guid LastModifiedByUserGuid { get; set; }

  [TableFieldMapping("UserName")]
  public virtual string LastModifiedUserName { get; set; } = string.Empty;
}
