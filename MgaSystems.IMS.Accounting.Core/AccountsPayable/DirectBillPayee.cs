// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.DirectBillPayee
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.Core.ClassObjects;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class DirectBillPayee
{
  private Guid _payeeGuid;
  private string _payeeName;
  private Decimal _totalGrossPayable;
  private Decimal _totalProportionalAmount;

  public DirectBillPayee(Guid PayeeGuid)
  {
    this._payeeGuid = PayeeGuid;
    this._payeeName = Utility.GetEntityName(this._payeeGuid);
  }

  public DirectBillPayee(Guid payeeGuid, string payeeName)
  {
    this._payeeGuid = payeeGuid;
    this._payeeName = payeeName;
  }

  public DirectBillPayee(
    Guid payeeGuid,
    string payeeName,
    Decimal totalGrossPayable,
    Decimal totalProportionalAmount)
  {
    this._payeeGuid = payeeGuid;
    this._payeeName = payeeName;
    this._totalGrossPayable = totalGrossPayable;
    this._totalProportionalAmount = totalProportionalAmount;
  }

  public Guid PayeeGuid
  {
    get => this._payeeGuid;
    set => this._payeeGuid = value;
  }

  public string PayeeName => this._payeeGuid.Equals(Guid.Empty) ? string.Empty : this._payeeName;

  public Decimal TotalGrossPayable
  {
    get => this._totalGrossPayable;
    set => this._totalGrossPayable = value;
  }

  public Decimal TotalProportionalAmount
  {
    get => this._totalProportionalAmount;
    set => this._totalProportionalAmount = value;
  }
}
