// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Utility.LastEdit.LastEditData
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Utility.LastEdit;

public class LastEditData : ILastEditData
{
  public LastEditData(DateTime? modifiedDate, Guid modifiedUserGuid, string modifiedUserName)
  {
    this.ModifiedDate = modifiedDate;
    this.ModifiedUserGuid = new Guid?(modifiedUserGuid);
    this.UserName = modifiedUserName;
  }

  public LastEditData()
  {
    this.ModifiedDate = new DateTime?();
    this.ModifiedUserGuid = new Guid?();
    this.UserName = (string) null;
  }

  public DateTime? ModifiedDate { get; }

  public Guid? ModifiedUserGuid { get; }

  public string UserName { get; }

  public Guid GetCurrentUserGuid() => CurrentUser.Instance.UserGUID;
}
