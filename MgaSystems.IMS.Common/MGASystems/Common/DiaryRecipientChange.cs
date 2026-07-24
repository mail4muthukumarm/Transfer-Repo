// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DiaryRecipientChange
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;

#nullable disable
namespace MGASystems.Common;

public class DiaryRecipientChange
{
  private Guid _userGuid;
  private DateTime _completedDate;
  private bool _completed;

  public DiaryRecipientChange(Guid userGuid, DateTime completedDate, bool completed)
  {
    this._userGuid = userGuid;
    this._completedDate = completedDate;
    this._completed = completed;
  }

  public Guid UserGuid => this._userGuid;

  public DateTime CompletedDate
  {
    get
    {
      if (!this._completed)
        throw new InvalidOperationException("Property CompletedDate can only be read when the item is Completed, check that property prior to checking this one");
      return this._completedDate;
    }
  }

  public bool Completed => this._completed;
}
