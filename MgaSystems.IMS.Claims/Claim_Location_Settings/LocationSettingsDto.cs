// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claim_Location_Settings.LocationSettingsDto
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data.CommonInterface;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Claim_Location_Settings;

public class LocationSettingsDto : 
  DtoBase<Guid>,
  INamedValue<Guid>,
  IUniqueObject<Guid>,
  IUniqueObject,
  INamedValue
{
  public string Name => this.QuotingOfficeName;

  public virtual Guid UniqueIdentifier => this.QuotingOfficeGuid;

  [TableFieldMapping("QuotingOfficeGuid")]
  public virtual Guid QuotingOfficeGuid { get; set; }

  [TableFieldMapping("QuotingOfficeId")]
  public virtual int QuotingOfficeId { get; set; } = -1;

  [TableFieldMapping("QuotingOfficeName")]
  public virtual string QuotingOfficeName { get; set; } = string.Empty;

  [TableFieldMapping("ClaimsOfficeId")]
  public virtual int ClaimsOfficeId { get; set; } = -1;

  [TableFieldMapping("ClaimsOfficeName")]
  public virtual string ClaimsOfficeName { get; set; } = string.Empty;

  [TableFieldMapping("GLAcctId")]
  public virtual int GLAcctId { get; set; } = -1;

  [TableFieldMapping("GLAcctName")]
  public virtual string GLAcctName { get; set; } = string.Empty;

  [TableFieldMapping("DateModified")]
  public virtual DateTime LastModifiedDate { get; set; }

  [TableFieldMapping("ModifiedByGuid")]
  public virtual Guid LastModifiedByUserGuid { get; set; }

  [TableFieldMapping("UserName")]
  public virtual string LastModifiedUserName { get; set; } = string.Empty;
}
