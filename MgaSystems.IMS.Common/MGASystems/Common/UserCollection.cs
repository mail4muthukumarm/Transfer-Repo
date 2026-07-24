// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.UserCollection
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common;

public class UserCollection : List<User>
{
  private Dictionary<Guid, User> _userGuidHash;
  private Dictionary<int, User> _userIdHash;

  public void Refresh()
  {
    this.Clear();
    this._userGuidHash.Clear();
    this._userIdHash.Clear();
    try
    {
      foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, "select u.firstname, u.lastname, u.userguid, u.userId, u.username, o.officeId from tblUsers u inner join tblClientOffices o on u.OfficeGuid = o.OfficeGuid order by lastname").Rows)
      {
        User user = new User(Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["firstname"]), "unknown"), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["lastname"]), "unknown"), (Guid) row["userguid"], (int) (short) row["userid"], Utility.IsNull<int>(RuntimeHelpers.GetObjectValue(row["officeId"]), -1), (string) row["username"]);
        this._userGuidHash.Add(user.UserGuid, user);
        this._userIdHash.Add(user.UserID, user);
        this.Add(user);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public User this[Guid userGuid]
  {
    get
    {
      if (!this._userGuidHash.ContainsKey(userGuid))
      {
        try
        {
          foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, "select u.firstname, u.lastname, u.userguid, u.userId, u.username, o.officeId from tblUsers u inner join tblClientOffices o on u.OfficeGuid = o.OfficeGuid where u.userguid = @userguid", new object[2]
          {
            (object) "@userGuid",
            (object) userGuid
          }).Rows)
          {
            User user = new User(Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["firstname"]), "unknown"), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["lastname"]), "unknown"), (Guid) row["userguid"], (int) (short) row["userid"], Utility.IsNull<int>(RuntimeHelpers.GetObjectValue(row["officeId"]), -1), (string) row["username"]);
            this._userGuidHash.Add(user.UserGuid, user);
            this._userIdHash.Add(user.UserID, user);
            this.Add(user);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      return !this._userGuidHash.ContainsKey(userGuid) ? (User) null : this._userGuidHash[userGuid];
    }
  }

  public User FindById(int userId)
  {
    if (!this._userIdHash.ContainsKey(userId))
    {
      try
      {
        foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, "select u.firstname, u.lastname, u.userguid, u.userId, u.username, o.officeId from tblUsers u inner join tblClientOffices o on u.OfficeGuid = o.OfficeGuid where u.userId = @userID", new object[2]
        {
          (object) "@userID",
          (object) userId
        }).Rows)
        {
          User user = new User(Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["firstname"]), "unknown"), Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["lastname"]), "unknown"), (Guid) row["userguid"], (int) (short) row["userid"], Utility.IsNull<int>(RuntimeHelpers.GetObjectValue(row["officeId"]), -1), (string) row["username"]);
          this._userGuidHash.Add(user.UserGuid, user);
          this._userIdHash.Add(user.UserID, user);
          this.Add(user);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    return !this._userIdHash.ContainsKey(userId) ? (User) null : this._userIdHash[userId];
  }

  public UserCollection()
  {
    this._userGuidHash = new Dictionary<Guid, User>();
    this._userIdHash = new Dictionary<int, User>();
    this.Refresh();
  }
}
