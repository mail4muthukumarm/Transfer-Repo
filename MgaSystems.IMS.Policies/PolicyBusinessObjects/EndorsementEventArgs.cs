// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyBusinessObjects.EndorsementEventArgs
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.Common.Enums;
using System;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyBusinessObjects;

public class EndorsementEventArgs : EventArgs
{
  private Guid _newQuoteGuid;
  private QuoteStatus _newQuoteStatus;

  public EndorsementEventArgs(Guid newQuoteGuid, QuoteStatus newQuoteStatus)
  {
    this._newQuoteGuid = newQuoteGuid;
    this._newQuoteStatus = newQuoteStatus;
  }

  public QuoteStatus NewQuoteStatus => this._newQuoteStatus;

  public Guid NewQuoteGuid => this._newQuoteGuid;
}
