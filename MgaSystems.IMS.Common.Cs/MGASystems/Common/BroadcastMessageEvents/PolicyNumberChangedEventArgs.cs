// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.BroadcastMessageEvents.PolicyNumberChangedEventArgs
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;

#nullable disable
namespace MGASystems.Common.BroadcastMessageEvents;

public class PolicyNumberChangedEventArgs : EventArgs
{
  public string OldPolicyNumber { get; }

  public string NewPolicyNumber { get; }

  public Guid QuoteGUID { get; }

  public PolicyNumberChangedEventArgs(
    Guid quoteguid,
    string oldPolicyNumber,
    string newPolicyNumber)
  {
    this.OldPolicyNumber = oldPolicyNumber;
    this.NewPolicyNumber = newPolicyNumber;
    this.QuoteGUID = quoteguid;
  }
}
