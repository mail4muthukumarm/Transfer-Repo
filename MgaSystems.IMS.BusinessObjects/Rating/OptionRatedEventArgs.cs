// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.Rating.OptionRatedEventArgs
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using System;

#nullable disable
namespace MGASystems.BusinessObjects.Rating;

public sealed class OptionRatedEventArgs : EventArgs
{
  private readonly QuoteOption _quoteOption;

  public OptionRatedEventArgs(Guid optionGuid)
    : this(ObjectFactory.Instance.CreateObjectAs<QuoteOption>((object) optionGuid))
  {
  }

  public OptionRatedEventArgs(QuoteOption qo) => this._quoteOption = qo;

  public QuoteOption QuoteOption => this._quoteOption;
}
