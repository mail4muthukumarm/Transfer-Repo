// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.BankAccount.BankAccountDto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.BankAccount;

public class BankAccountDto : DtoBase<BankAccountKey>
{
  [TableFieldMapping("BankAcctTypeID")]
  public char BankAccountTypeId { get; set; }

  [TableFieldMapping("BankAcctNum")]
  public string BankAccountNumber { get; set; }

  [TableFieldMapping("ABARouteNum")]
  public string AbaRouteNumber { get; set; }

  [TableFieldMapping("DepositRoutingNumber")]
  public string DepositRoutingNumber { get; set; }

  [TableFieldMapping("ABAFractionalTransitNum")]
  public string AbaFractionalTransitNumber { get; set; }

  [TableFieldMapping("GLAcctID")]
  public int GeneralLedgerAccountId { get; set; }

  [TableFieldMapping("NextCheckNum")]
  public int NextCheckNumber { get; set; }

  [TableFieldMapping("BankName")]
  public string BankName { get; set; }

  [TableFieldMapping("Addr1")]
  public string Address1 { get; set; }

  [TableFieldMapping("Addr2")]
  public string Address2 { get; set; }

  [TableFieldMapping("City")]
  public string City { get; set; }

  [TableFieldMapping("State")]
  public string State { get; set; }

  [TableFieldMapping("Zip")]
  public string ZipCode { get; set; }

  [TableFieldMapping("ZipExt")]
  public string ZipCodeExtension { get; set; }

  [TableFieldMapping("ContactName")]
  public string ContactName { get; set; }

  [TableFieldMapping("ContactFax")]
  public string ContactFax { get; set; }

  [TableFieldMapping("ContactPhone")]
  public string ContactPhone { get; set; }

  [TableFieldMapping("ContactEmail")]
  public string ContactEmail { get; set; }

  [TableFieldMapping("Updated")]
  public DateTime LastUpdated { get; set; }

  [TableFieldMapping("UserGUID")]
  public Guid LastUpdatedByUserGuid { get; set; }

  [TableFieldMapping("FeesGLAcctID")]
  public int? FeesGeneralLedgerAccountId { get; set; }

  [TableFieldMapping("InterestGLAcctID")]
  public int? InterestGeneralLedgerAccountId { get; set; }

  [TableFieldMapping("StartingBal")]
  public double? StartingBalance { get; set; }

  [TableFieldMapping("StartingBalDate")]
  public DateTime? StartingBalanceDate { get; set; }

  [TableFieldMapping("DepositSlipSuffix")]
  public string DepositSlipSuffix { get; set; }

  [TableFieldMapping("ISOCountryCode")]
  public string IsoCountryCode { get; set; }

  [TableFieldMapping("CurrencyCode")]
  public string CurrencyCode { get; set; }

  [TableFieldMapping("CheckText1")]
  public string CheckText1 { get; set; }

  [TableFieldMapping("CheckText2")]
  public string CheckText2 { get; set; }

  [TableFieldMapping("CheckText3")]
  public string CheckText3 { get; set; }

  [TableFieldMapping("CheckText4")]
  public string CheckText4 { get; set; }

  [TableFieldMapping("ACHCompanyID")]
  public string AchCompanyId { get; set; }

  [TableFieldMapping("ACHCompanyName")]
  public string AchCompanyName { get; set; }

  [TableFieldMapping("UseACH")]
  public bool UseAch { get; set; }

  public override BankAccountKey UniqueIdentifier
  {
    get => new BankAccountKey(new char?(this.BankAccountTypeId), this.BankAccountNumber);
  }
}
