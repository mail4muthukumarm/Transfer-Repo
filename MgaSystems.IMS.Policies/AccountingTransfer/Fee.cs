// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AccountingTransfer.Fee
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.Common.Enums;
using MGASystems.Data;
using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Policies.AccountingTransfer;

public sealed class Fee
{
  private Decimal _modFactor;
  private Decimal _amount;
  private int _chargeCode;
  private int _optionFeeID;
  private Guid _quoteOptionGuid;
  private Guid _companyLineGuid;

  public Fee(int optionFeeID, Decimal modFactor, Decimal amount)
  {
    this._optionFeeID = optionFeeID;
    this._modFactor = modFactor;
    this._amount = amount;
  }

  public Decimal Amount => this._amount;

  public int OptionFeeID
  {
    get => this._optionFeeID;
    set => this._optionFeeID = value;
  }

  public Decimal ModFactor
  {
    get => this._modFactor;
    set => this._modFactor = value;
  }

  public int ChargeCode
  {
    get => this._chargeCode;
    set => this._chargeCode = value;
  }

  public Guid QuoteOptionGuid
  {
    get => this._quoteOptionGuid;
    set => this._quoteOptionGuid = value;
  }

  public Guid CompanyLineGuid
  {
    get => this._companyLineGuid;
    set => this._companyLineGuid = value;
  }

  public string ChargeName
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT ChargeName FROM tblFin_PolicyCharges C INNER JOIN tblQuoteOptionCharges O ON C.ChargeCode=O.ChargeCode WHERE OptionFeeID=@ID", new object[2]
      {
        (object) "@ID",
        (object) this.OptionFeeID
      });
    }
  }

  public int FeeTypeID
  {
    get
    {
      return (int) DefaultDatabase.ExecuteScalar<byte>(CommandType.Text, "SELECT FeeTypeID FROM tblQuoteOptionCharges WHERE OptionFeeID=@ID", new object[2]
      {
        (object) "@ID",
        (object) this.OptionFeeID
      });
    }
  }

  public FeeTypes FeeType => (FeeTypes) Enum.Parse(typeof (FeeTypes), this.FeeTypeID.ToString());
}
