// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.DataAccess.ActiveUser.ActiveUserRepository
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Data.Repository.ColumnAttribute;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.DataAccess.ActiveUser;

public class ActiveUserRepository : BaseDataAccess<ActiveUserDto, Guid>, IActiveUserRepository
{
  public ActiveUserRepository()
    : base((Action<string>) (s => CurrentUser.Instance.LogAction(s)))
  {
  }

  public ActiveUserRepository(
    Action<string> logAction,
    DataNamesMapper<ActiveUserDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base(logAction, dataNamesMapper, databaseAccess)
  {
  }

  public ActiveUserDto[] GetActiveUsersForGlCompanyId(int glCompanyId)
  {
    return this.MapQueryMultiResult("spFin_GetActiveUsers", new object[2]
    {
      (object) "@glcompanyid",
      (object) glCompanyId
    });
  }

  protected virtual void ValidateId(Guid identifier) => this.ValidateGuidId(identifier);
}
