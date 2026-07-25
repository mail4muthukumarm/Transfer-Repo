// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.GenericCancellationPremiumCharges
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using System;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class GenericCancellationPremiumCharges
{
  private string _stateID;
  private int _chargeCode;
  private Decimal _annualAmount;
  private Decimal _finalPremium;

  public GenericCancellationPremiumCharges(
    string stateID,
    int ChargeCode,
    Decimal annualAmount,
    Decimal finalPremium)
  {
    this._stateID = stateID;
    this._chargeCode = ChargeCode;
    this._annualAmount = annualAmount;
    this._finalPremium = finalPremium;
  }

  public string PremiumStateID => this._stateID;

  public int ChargeCode => this._chargeCode;

  public Decimal AnnualAmount => this._annualAmount;

  public Decimal FinalPremium => this._finalPremium;
}
