// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.BankAccountPaymentType.BankAccountPaymentTypeDto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using MGASystems.IMS.Accounting.Core.Forms.ACH;
using MGASystems.IMS.Accounting.Utilities;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.BankAccountPaymentType;

public class BankAccountPaymentTypeDto : DtoBase<int>
{
  private string _bankAccountNumber;

  public override int UniqueIdentifier => this.AchSettingsAccountId;

  [TableFieldMapping("AccountName")]
  public string AccountName { get; set; }

  [TableFieldMapping("AchSettingsAccountId")]
  public int AchSettingsAccountId { get; set; }

  [TableFieldMapping("AchSettingsBankId")]
  public int AchSettingsBankId { get; set; }

  [TableFieldMapping("AlternativePayee")]
  public string AlternativePayee { get; set; }

  [TableFieldMapping("BankAccountNumber")]
  public string BankAccountNumber
  {
    get
    {
      return !MultiACHSettingsSecurity.CanViewEncryptedSettings ? this._bankAccountNumber.TruncateToLastFour() : this._bankAccountNumber;
    }
    set
    {
      this._bankAccountNumber = value == null || value.Length <= 0 ? value : MultiACHSettingsSecurity.Decrypt(value);
    }
  }

  [TableFieldMapping("BankName")]
  public string BankName { get; set; }

  [TableFieldMapping("Currency")]
  public string Currency { get; set; }

  [TableFieldMapping("EntityGuid")]
  public Guid EntityGuid { get; set; }

  [TableFieldMapping("IsDefault")]
  public bool IsDefault { get; set; }

  [TableFieldMapping("PayMethodId")]
  public char PaymentMethodId { get; set; }

  [TableFieldMapping("MethodName")]
  public string PaymentMethodName { get; set; }
}
