// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.ChargeCode.ChargeCodeRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data.Repository.ColumnAttribute;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.ChargeCode;

[Override(typeof (IChargeCodeRepository))]
public class ChargeCodeRepository : 
  ReadOnlyRepositoryBase<ChargeCodeDto, int>,
  IChargeCodeRepository,
  IReadRepository<ChargeCodeDto, int>,
  IGetAllRepository<ChargeCodeDto, int>,
  IGetAllRepository,
  IExecuteTransaction,
  IGetByIdRepository<ChargeCodeDto, int>,
  IGetByIdRepository
{
  public ChargeCodeRepository()
    : base(new Action<string>(CurrentUser.Instance.LogAction))
  {
  }

  public ChargeCodeRepository(
    Action<string> logAction,
    DataNamesMapper<ChargeCodeDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base(logAction, dataNamesMapper, databaseAccess)
  {
  }

  protected override string GetByIdProcedureName => "[dbo].[spFin_ChargeCode_GetById]";

  protected override string GetAllProcedureName => "[dbo].[spFin_ChargeCode_GetAll]";

  protected virtual string GetAllFeesProcedureName => "[dbo].[spFin_ChargeCode_GetAllFees]";

  public IEnumerable<ChargeCodeDto> GetAllFees()
  {
    return (IEnumerable<ChargeCodeDto>) ((BaseDataAccess<ChargeCodeDto, int>) this).MapQueryMultiResult(this.GetAllFeesProcedureName);
  }

  protected override object[] GetGetByIdParams(int identifier)
  {
    return new object[2]
    {
      (object) "@Id",
      (object) identifier
    };
  }

  protected override void ValidateId(int identifier)
  {
    ((BaseDataAccess<ChargeCodeDto, int>) this).ValidateIntegerId(identifier);
  }
}
