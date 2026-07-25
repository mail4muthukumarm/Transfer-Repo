// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.OnCopyBoundOptionArgs
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using System;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public sealed class OnCopyBoundOptionArgs
{
  private Guid _originalQuoteGuid;
  private Guid _originalBoundOptionGuid;
  private Guid _newOptionGuid;
  private Guid _newQuoteGuid;
  private int _newOptionId;

  public OnCopyBoundOptionArgs(
    Guid originalQuoteGuid,
    Guid originalBoundOptionGuid,
    Guid newQuoteGuid,
    Guid newOptionGuid,
    int newOptionId)
  {
    this._newOptionGuid = Guid.Empty;
    this._originalQuoteGuid = originalQuoteGuid;
    this._originalBoundOptionGuid = originalBoundOptionGuid;
    this._newQuoteGuid = newQuoteGuid;
    this._newOptionGuid = newOptionGuid;
    this._newOptionId = newOptionId;
  }

  public int NewOptionId => this._newOptionId;

  public Guid OriginalQuoteGuid => this._originalQuoteGuid;

  public Guid OriginalBoundOptionGuid => this._originalBoundOptionGuid;

  public Guid NewQuoteGuid => this._newQuoteGuid;

  public Guid NewOptionGuid => this._newOptionGuid;
}
