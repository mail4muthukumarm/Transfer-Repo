// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims_Entities.DataAccess.ClaimsEntityDto
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Data.CommonInterface;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Claims_Entities.DataAccess;

public class ClaimsEntityDto : 
  DtoBase<Guid>,
  INamedValue<Guid>,
  IUniqueObject<Guid>,
  IUniqueObject,
  INamedValue
{
  public string Name => this.EntityName;

  public virtual Guid UniqueIdentifier => this.EntityGuid;

  [TableFieldMapping("EntityGuid")]
  public virtual Guid EntityGuid { get; set; }

  [TableFieldMapping("EntityTypeId")]
  public virtual int EntityTypeId { get; set; } = -1;

  [TableFieldMapping("EntityName")]
  public virtual string EntityName { get; set; } = string.Empty;

  [TableFieldMapping("DBA")]
  public virtual string DBA { get; set; } = string.Empty;

  [TableFieldMapping("FirstName")]
  public virtual string FirstName { get; set; } = string.Empty;

  [TableFieldMapping("MiddleName")]
  public virtual string MiddleName { get; set; } = string.Empty;

  [TableFieldMapping("LastName")]
  public virtual string LastName { get; set; } = string.Empty;

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

  [TableFieldMapping("FEINSSN")]
  public virtual string FEINSSN { get; set; } = string.Empty;

  [TableFieldMapping("ContactName")]
  public virtual string ContactName { get; set; } = string.Empty;

  [TableFieldMapping("PhoneNumber")]
  public virtual string PhoneNumber { get; set; } = string.Empty;

  [TableFieldMapping("FaxNumber")]
  public virtual string FaxNumber { get; set; } = string.Empty;

  [TableFieldMapping("LastModified")]
  public virtual DateTime LastModifiedDate { get; set; }

  [TableFieldMapping("ModifiedByGuid")]
  public virtual Guid LastModifiedByUserGuid => CurrentUser.Instance.UserGUID;

  [TableFieldMapping("UserName")]
  public virtual string LastModifiedUserName { get; set; } = string.Empty;
}
