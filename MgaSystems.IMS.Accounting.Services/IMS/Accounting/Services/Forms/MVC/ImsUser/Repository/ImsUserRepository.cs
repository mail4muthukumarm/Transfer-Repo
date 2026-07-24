// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ImsUser.Repository.ImsUserRepository
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common;
using MGASystems.Data.Repository.ColumnAttribute;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ImsUser.Repository;

[Override(typeof (IImsUserRepository))]
public class ImsUserRepository : 
  ReadOnlyRepositoryBase<ImsUserDto, Guid>,
  IImsUserRepository,
  IGetAllRepository<ImsUserDto, Guid>,
  IGetAllRepository,
  IExecuteTransaction,
  IGetByIdRepository<ImsUserDto, Guid>,
  IGetByIdRepository
{
  public ImsUserRepository()
    : base((Action<string>) (s => CurrentUser.Instance.LogAction(s)))
  {
  }

  public ImsUserRepository(
    Action<string> logAction,
    DataNamesMapper<ImsUserDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base(logAction, dataNamesMapper, databaseAccess)
  {
  }

  protected override string GetByIdProcedureName => "Users_GetById";

  protected override string GetAllProcedureName => "Users_GetAll";

  protected override object[] GetGetByIdParams(Guid identifier)
  {
    return new object[2]
    {
      (object) "@UserGuid",
      (object) identifier
    };
  }

  protected override void ValidateId(Guid identifier)
  {
    ((BaseDataAccess<ImsUserDto, Guid>) this).ValidateGuidId(identifier);
  }
}
