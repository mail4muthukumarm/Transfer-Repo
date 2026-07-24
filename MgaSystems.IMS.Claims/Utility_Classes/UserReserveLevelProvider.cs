// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Utility_Classes.UserReserveLevelProvider
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.IMS.Security;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Utility_Classes;

public class UserReserveLevelProvider
{
  protected virtual string[] ReservePermissions
  {
    get
    {
      return new string[5]
      {
        "{A4A5CC1F-C53B-450d-886D-2135CB41BA19}",
        "{425C784D-8F13-4200-A559-D0F858D5B001}",
        "{82B2AE8C-3332-42ca-93E8-02B9525E90C7}",
        "{3B739F4B-4D2A-45e6-B017-00389ABBAC8E}",
        "{D276F1BA-F310-4e36-B6D5-88A3628F1082}"
      };
    }
  }

  protected virtual string[] ClaimPermissions
  {
    get
    {
      return new string[5]
      {
        "{7E33061B-EA6E-403D-A736-FA183B88CF1E}",
        "{BB48491A-6794-463E-89B8-60AA47361BF0}",
        "{E72454EC-5C6C-457C-9C19-ACE5077EF104}",
        "{4F197F4D-E1B6-4AFD-9E6F-2B52C2977E91}",
        "{274800B8-DFDB-41E1-83DE-84C9E18B8208}"
      };
    }
  }

  public Guid GetUserReserveLevel() => this.AssertPermission(this.ReservePermissions);

  public Guid GetUserClaimReserveLevel() => this.AssertPermission(this.ClaimPermissions);

  protected virtual Guid AssertPermission(string[] permissions)
  {
    foreach (string permission in permissions)
    {
      if (SecurityManager.Instance.AssertPermission(permission))
        return new Guid(permission);
    }
    return Guid.Empty;
  }
}
