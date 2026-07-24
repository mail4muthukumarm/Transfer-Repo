// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ModifyReserveSavedEventArgs
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;

#nullable disable
namespace MGASystems.IMS.Claims;

public class ModifyReserveSavedEventArgs
{
  public ModifyReserveSavedEventArgs(int reservePaymentid, Decimal amount)
  {
    this.ReservePaymentId = reservePaymentid;
  }

  public int ReservePaymentId { get; }

  public Decimal Amount { get; }
}
