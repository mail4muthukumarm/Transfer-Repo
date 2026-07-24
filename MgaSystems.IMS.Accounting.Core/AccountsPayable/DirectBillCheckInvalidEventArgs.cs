// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.DirectBillCheckInvalidEventArgs
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class DirectBillCheckInvalidEventArgs : EventArgs
{
  private string message;

  public DirectBillCheckInvalidEventArgs(string Message) => this.message = Message;

  public string Message => this.message;
}
