// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.GenericPremiumCharges
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using System;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class GenericPremiumCharges
{
  private readonly string _stateID;
  private readonly int _chargeCode;
  private Decimal _annualAmount;
  private readonly string _endCalcTyype;
  private readonly Decimal _factor;
  private Decimal _billedAmount;

  public GenericPremiumCharges(
    string stateID,
    int ChargeCode,
    Decimal annualAmount,
    string endCalcTyype,
    Decimal factor,
    Decimal billedAmount)
  {
    this._stateID = stateID;
    this._chargeCode = ChargeCode;
    this._annualAmount = annualAmount;
    this._endCalcTyype = endCalcTyype;
    this._factor = factor;
    this._billedAmount = billedAmount;
  }

  public string PremiumStateID => this._stateID;

  public int ChargeCode => this._chargeCode;

  public Decimal Factor => this._factor;

  public Decimal AnnualAmount
  {
    get => this._annualAmount;
    set => this._annualAmount = value;
  }

  public string EndCalculationType => this._endCalcTyype;

  public Decimal BilledAmount
  {
    get => this._billedAmount;
    set => this._billedAmount = value;
  }
}
