// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MustCompleteContextGUID
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;

#nullable disable
namespace MGASystems.Tools;

public sealed class MustCompleteContextGUID : ContextGuid
{
  private bool _mustComplete;

  public MustCompleteContextGUID(Guid guid, GuidContext context, bool mustComplete)
    : base(guid, context)
  {
    this._mustComplete = mustComplete;
  }

  public MustCompleteContextGUID(Guid guid, GuidContext context)
    : base(guid, context)
  {
    this._mustComplete = this.MustComplete;
  }

  public bool MustComplete
  {
    get => this._mustComplete;
    set => this._mustComplete = value;
  }
}
