// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.User
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System;
using System.Collections.Concurrent;
using System.Data;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblUsers")]
public class User : BaseDataObject
{
  private static readonly ConcurrentDictionary<int, Guid> _userIdToGuidCache = new ConcurrentDictionary<int, Guid>();
  private Guid _userGuid;

  public User(Guid userGuid) => this._userGuid = userGuid;

  public User(int userID)
  {
    this._userGuid = User._userIdToGuidCache.GetOrAdd(userID, new System.Func<int, Guid>(User.GetUserGuid));
  }

  private static Guid GetUserGuid(int userID)
  {
    if ((DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT UserGUID FROM dbo.tblUsers WITH(NOLOCK) WHERE UserID = @UID", new object[2]
    {
      (object) "@UID",
      (object) userID
    }) ?? Guid.Empty).Equals(Guid.Empty))
      throw new InvalidOperationException("Specified User does not exist");
    Guid userGuid;
    return userGuid;
  }

  [DataKey]
  public Guid UserGuid
  {
    get => this._userGuid;
    protected set
    {
      this._userGuid = this._userGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified User {this._userGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public int UserID => (int) this.GetField<short>(nameof (UserID), nameof (UserID));

  [TableFieldMapping]
  public Guid OfficeGuid => this.GetField<Guid>(nameof (OfficeGuid), nameof (OfficeGuid));

  [TableFieldMapping]
  public string FirstName => this.GetField<string>(nameof (FirstName), nameof (FirstName));

  [TableFieldMapping]
  public string LastName => this.GetField<string>(nameof (LastName), nameof (LastName));

  [TableFieldMapping]
  public string Title => this.GetField<string>(nameof (Title), nameof (Title));

  [TableFieldMapping("EmailAddress")]
  public string Email => this.GetField<string>("EmailAddress", nameof (Email));

  public bool HasEmail => !string.IsNullOrEmpty(this.Email);

  [TableFieldMapping]
  public string UserName => this.GetField<string>(nameof (UserName), nameof (UserName));

  [TableFieldMapping]
  public string Phone => this.GetField<string>(nameof (Phone), nameof (Phone));

  [TableFieldMapping]
  public string ForeignPhone => this.GetField<string>(nameof (ForeignPhone), nameof (ForeignPhone));

  [Obsolete("Use ContactPhoneExtension instead")]
  [TableFieldMapping("PhoneExt")]
  public int? PhoneExtension => this.GetField<int?>("PhoneExt", nameof (PhoneExtension));

  [TableFieldMapping("PhoneExtension")]
  public string ContactPhoneExtension
  {
    get => this.GetField<string>("PhoneExtension", nameof (ContactPhoneExtension));
  }

  [TableFieldMapping]
  public string Fax => this.GetField<string>(nameof (Fax), nameof (Fax));

  [TableFieldMapping]
  public string Initials => this.GetField<string>(nameof (Initials), nameof (Initials));

  [TableFieldMapping]
  public byte StatusID => this.GetField<byte>(nameof (StatusID), nameof (StatusID));

  public bool IsActive => this.StatusID == (byte) 1;

  [TableFieldMapping]
  public bool CommissionsFromOperatingAccount
  {
    get
    {
      return this.GetField<bool>(nameof (CommissionsFromOperatingAccount), nameof (CommissionsFromOperatingAccount));
    }
  }

  public string Address1
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (Address1), nameof (Address1));
    }
  }

  public string Address2
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (Address2), nameof (Address2));
    }
  }

  public string ZipCode
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (ZipCode), nameof (ZipCode));
    }
  }

  public string ZipPlus
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (ZipPlus), nameof (ZipPlus));
    }
  }

  public string City
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (City), nameof (City));
    }
  }

  public string State
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (State), nameof (State));
    }
  }

  public string County
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (County), nameof (County));
    }
  }

  public string ISOCountryCode
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (ISOCountryCode), nameof (ISOCountryCode));
    }
  }

  public string Region
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (Region), nameof (Region));
    }
  }

  private bool GetAddressFields()
  {
    return this.RetrieveFields("Address1", "Address2", "ZipCode", "ZipPlus", "City", "State", "County", "ISOCountryCode", "Region");
  }

  public byte[] UserSignature => this.GetLazyField<byte[]>(nameof (UserSignature));

  public string Name_FirstLast => $"{this.FirstName} {this.LastName}";

  public string Name_LastFirst => $"{this.LastName}, {this.FirstName}";
}
