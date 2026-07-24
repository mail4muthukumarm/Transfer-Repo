// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.DirectBillCheckCreatedEventArgs
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class DirectBillCheckCreatedEventArgs : EventArgs
{
  private int checkNumber;
  private string payeeName;
  private Decimal checkAmount;

  public DirectBillCheckCreatedEventArgs(int CheckNumber, string PayeeName, Decimal CheckAmount)
  {
    this.checkNumber = CheckNumber;
    this.payeeName = PayeeName;
    this.checkAmount = CheckAmount;
  }

  public int CheckNumber => this.checkNumber;

  public string PayeeName => this.payeeName;

  public Decimal CheckAmount => this.checkAmount;
}
