// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.DataAccess.LossType.LossTypeRepository
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data.Repository.ColumnAttribute;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.DataAccess.LossType;

public class LossTypeRepository : 
  GetAllOnlyRepositoryBase<LossTypeDto, int>,
  ILossTypeRepository,
  IGetAllRepository<LossTypeDto, int>,
  IGetAllRepository,
  IExecuteTransaction
{
  public LossTypeRepository(Action<string> logAction)
    : base(logAction)
  {
  }

  public LossTypeRepository(
    Action<string> logAction,
    DataNamesMapper<LossTypeDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base(logAction, dataNamesMapper, databaseAccess)
  {
  }

  protected virtual string GetAllProcedureName => "spClaims_LossTypeGetAll";

  protected virtual void ValidateId(int identifier)
  {
    ((BaseDataAccess<LossTypeDto, int>) this).ValidateIntegerId(identifier);
  }
}
