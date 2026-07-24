// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.BankAccountPaymentType.BankAccountPaymentTypeRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.Repository.ColumnAttribute;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.BankAccountPaymentType;

public class BankAccountPaymentTypeRepository : 
  BaseRepository<BankAccountPaymentTypeDto, int>,
  IBankAccountPaymentTypeRepository,
  IExecuteTransaction
{
  public BankAccountPaymentTypeRepository()
    : base((Action<string>) (s => CurrentUser.Instance.LogAction(s)))
  {
  }

  public BankAccountPaymentTypeRepository(
    Action<string> logAction,
    DataNamesMapper<BankAccountPaymentTypeDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base(logAction, dataNamesMapper, databaseAccess)
  {
  }

  public BankAccountPaymentTypeDto[] GetForEntity(Guid entityGuid)
  {
    BankAccountPaymentTypeDto[] forEntity = ((BaseDataAccess<BankAccountPaymentTypeDto, int>) this).MapQueryMultiResult("dbo.spFin_BankAccountPaymentType_GetForEntityGuid", new object[2]
    {
      (object) "@EntityGuid",
      (object) entityGuid
    });
    if (forEntity.Length != 0)
      return forEntity;
    return ((BaseDataAccess<BankAccountPaymentTypeDto, int>) this).MapQueryMultiResult("dbo.spFin_BankAccountPaymentType_GetForEntityGuid", new object[2]
    {
      (object) "@EntityGuid",
      (object) DefaultDatabase.ExecuteFunction<Guid>("dbo.GetTopLevelEntity", new object[2]
      {
        (object) "@entityGuid",
        (object) entityGuid
      })
    });
  }

  protected override void ValidateId(int identifier)
  {
    ((BaseDataAccess<BankAccountPaymentTypeDto, int>) this).ValidateIntegerId(identifier);
  }
}
