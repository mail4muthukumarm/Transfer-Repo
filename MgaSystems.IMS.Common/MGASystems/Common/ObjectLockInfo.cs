// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ObjectLockInfo
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;

#nullable disable
namespace MGASystems.Common;

public class ObjectLockInfo
{
  private int _lockId;
  private string _description;
  private Guid _userGuid;
  private DateTime _created;

  public string Description => this._description;

  public int LockId => this._lockId;

  public Guid UserGuid => this._userGuid;

  public DateTime Created => this._created;

  public ObjectLockInfo(int lockId, string description, Guid userGuid, DateTime created)
  {
    this._lockId = lockId;
    this._description = description;
    this._userGuid = userGuid;
    this._created = created;
  }
}
