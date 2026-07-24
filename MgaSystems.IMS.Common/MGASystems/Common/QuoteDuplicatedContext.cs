// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.QuoteDuplicatedContext
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;

#nullable disable
namespace MGASystems.Common;

public class QuoteDuplicatedContext
{
  private readonly Guid _originalQuoteGuid;
  private readonly Guid _duplicateQuoteGuid;

  public Guid OriginalQuoteGuid => this._originalQuoteGuid;

  public Guid DuplicateQuoteGuid => this._duplicateQuoteGuid;

  public QuoteDuplicatedContext(Guid originalQuoteGuid, Guid duplicateQuoteGuid)
  {
    this._originalQuoteGuid = originalQuoteGuid;
    this._duplicateQuoteGuid = duplicateQuoteGuid;
  }
}
