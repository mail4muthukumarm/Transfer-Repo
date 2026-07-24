// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.DirectBill.BaseClasses.DirectBillObject
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.DirectBill.BaseClasses;

public abstract class DirectBillObject
{
  private string _policyNumber;
  private string _insuredName;
  private int _controlNumber;
  private DateTime _effectiveDate;
  private DateTime _expirationDate;
  private string _currencyCode = "USD";

  public DirectBillObject(
    string policyNumber,
    string insuredName,
    int controlNumber,
    DateTime effectiveDate,
    DateTime expirationDate)
  {
    this._policyNumber = policyNumber;
    this._insuredName = insuredName;
    this._controlNumber = controlNumber;
    this._effectiveDate = effectiveDate;
    this._expirationDate = expirationDate;
  }

  public DirectBillObject(
    string policyNumber,
    string insuredName,
    int controlNumber,
    DateTime effectiveDate,
    DateTime expirationDate,
    string currencyCode)
  {
    this._policyNumber = policyNumber;
    this._insuredName = insuredName;
    this._controlNumber = controlNumber;
    this._effectiveDate = effectiveDate;
    this._expirationDate = expirationDate;
    this._currencyCode = currencyCode;
  }

  internal string PolicyNumber => this._policyNumber;

  internal string InsuredName => this._insuredName;

  internal int ControlNumber => this._controlNumber;

  internal DateTime EffectiveDate => this._effectiveDate;

  internal DateTime ExpirationDate => this._expirationDate;

  internal string CurrencyCode => this._currencyCode;
}
