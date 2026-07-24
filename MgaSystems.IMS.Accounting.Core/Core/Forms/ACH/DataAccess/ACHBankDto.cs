// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.DataAccess.ACHBankDto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.CommonInterface;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH.DataAccess;

public class ACHBankDto : DtoBase<int>, INamedValue, IUniqueObject
{
  public override int UniqueIdentifier => this.Id;

  [TableFieldMapping("AchSettingsBankId")]
  public int Id { get; set; }

  [TableFieldMapping("EntityGuid")]
  public Guid EntityGuid { get; set; }

  [TableFieldMapping("BankName")]
  public string Name { get; set; }

  [TableFieldMapping("BankIsoCountryCode")]
  public string BankIsoCountryCode { get; set; }

  [TableFieldMapping("BankAddress1")]
  public string BankAddress1 { get; set; }

  [TableFieldMapping("BankAddress2")]
  public string BankAddress2 { get; set; }

  [TableFieldMapping("BankCity")]
  public string BankCity { get; set; }

  [TableFieldMapping("BankState")]
  public string BankState { get; set; }

  [TableFieldMapping("BankZipCode")]
  public string BankZipCode { get; set; }

  [TableFieldMapping("BankZipExt")]
  public string BankZipExt { get; set; }

  [TableFieldMapping("SwiftCode")]
  public string SwiftCode { get; set; }

  [TableFieldMapping("SortCode")]
  public string SortCode { get; set; }

  [TableFieldMapping("DateEntered")]
  public DateTime DateEntered { get; set; }

  [TableFieldMapping("EnteredBy")]
  public Guid EnteredBy { get; set; }

  [TableFieldMapping("IsApproved")]
  public bool IsApproved { get; set; }

  [TableFieldMapping("IsDeleted")]
  public bool IsDeleted { get; set; }

  [TableFieldMapping("DateApproved")]
  public DateTime? DateApproved { get; set; }

  [TableFieldMapping("ApprovedBy")]
  public Guid? ApprovedBy { get; set; }

  [TableFieldMapping("IsDefault")]
  public bool IsDefault { get; set; }
}
