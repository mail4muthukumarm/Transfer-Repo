// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.PolicyIssuedContext
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;

#nullable disable
namespace MGASystems.Common;

public class PolicyIssuedContext
{
  private Guid _quoteGuid;
  private bool _isPreview;
  private bool _isReprint;
  private int _printTypeID;

  public Guid QuoteGuid => this._quoteGuid;

  public bool IsPreview => this._isPreview;

  public bool IsReprint => this._isReprint;

  public int PrintTypeID
  {
    get => this._printTypeID;
    set => this._printTypeID = value;
  }

  public PolicyIssuedContext(Guid quoteGuid, bool isPreview)
  {
    this._printTypeID = -1;
    this._quoteGuid = quoteGuid;
    this._isPreview = isPreview;
  }

  public PolicyIssuedContext(Guid quoteGuid, bool isPreview, bool isReprint)
  {
    this._printTypeID = -1;
    this._quoteGuid = quoteGuid;
    this._isPreview = isPreview;
    this._isReprint = isReprint;
  }
}
