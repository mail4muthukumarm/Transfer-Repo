// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.W9.W9Dto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.CommonInterface;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.W9;

public class W9Dto : 
  DtoBase<Guid>,
  INamedValue<Guid>,
  IUniqueObject<Guid>,
  IUniqueObject,
  INamedValue
{
  public string Name => this.BusinessName;

  public override Guid UniqueIdentifier => this.EntityGuid;

  [TableFieldMapping("EntityGuid")]
  public virtual Guid EntityGuid { get; set; }

  [TableFieldMapping("TaxingEntity")]
  public virtual string TaxingEntity { get; set; } = string.Empty;

  [TableFieldMapping("BusinessName")]
  public virtual string BusinessName { get; set; } = string.Empty;

  [TableFieldMapping("Address1")]
  public virtual string Address1 { get; set; } = string.Empty;

  [TableFieldMapping("Address2")]
  public virtual string Address2 { get; set; } = string.Empty;

  [TableFieldMapping("City")]
  public virtual string City { get; set; } = string.Empty;

  [TableFieldMapping("State")]
  public virtual string State { get; set; } = string.Empty;

  [TableFieldMapping("ZipCode")]
  public virtual string ZipCode { get; set; } = string.Empty;

  [TableFieldMapping("ZipExt")]
  public virtual string ZipCodeExtension { get; set; } = string.Empty;

  [TableFieldMapping("TinEin")]
  public virtual string TinEin { get; set; } = string.Empty;

  [TableFieldMapping("W9Date")]
  public virtual DateTime? W9Date { get; set; }

  [TableFieldMapping("EntityTypeId")]
  public virtual int EntityTypeId { get; set; } = -1;

  [TableFieldMapping("EntityTypeOther")]
  public virtual string EntityTypeOther { get; set; } = string.Empty;

  [TableFieldMapping("LastModified")]
  public virtual DateTime LastModifiedDate { get; set; }

  [TableFieldMapping("ModifiedByGuid")]
  public virtual Guid LastModifiedByUserGuid { get; set; }

  [TableFieldMapping("UserName")]
  public virtual string LastModifiedUserName { get; set; } = string.Empty;

  [TableFieldMapping("AccountingEntityType")]
  public virtual string AccountingEntityType { get; set; } = string.Empty;
}
