// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.User
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;

#nullable disable
namespace MGASystems.Common;

public class User
{
  private string _firstName;
  private string _lastName;
  private Guid _userGuid;
  private int _userId;
  private int _officeId;
  private string _userName;

  public Guid UserGuid => this._userGuid;

  public string FirstName => this._firstName;

  public string LastName => this._lastName;

  public User(
    string firstName,
    string lastName,
    Guid userGuid,
    int userId,
    int officeId,
    string userName)
  {
    this._firstName = firstName;
    this._lastName = lastName;
    this._userGuid = userGuid;
    this._userId = userId;
    this._officeId = officeId;
    this._userName = userName;
  }

  public string DisplayName => $"{this.FirstName} {this.LastName}";

  public string DisplayNameLastFirst => $"{this.LastName}, {this.FirstName}";

  public int UserID => this._userId;

  public int OfficeID => this._officeId;

  public string UserName => this._userName;
}
