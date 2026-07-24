// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Data.ChargeCodeGLAccountMappingRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data.CommonInterface;
using MGASystems.Data.Repository.ColumnAttribute;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Data;

[Override(typeof (IChargeCodeGLAccountMappingRepository))]
public class ChargeCodeGLAccountMappingRepository : 
  EditRepositoryBase<ChargeCodeGLAccountMappingDto, int>,
  IChargeCodeGLAccountMappingRepository,
  IUpdateReadRepository<ChargeCodeGLAccountMappingDto, int>,
  IUpdateReadRepository,
  IGetByIdRepository,
  IExecuteTransaction,
  IUpdateRepository,
  IGetByIdRepository<ChargeCodeGLAccountMappingDto, int>,
  IUpdateRepository<ChargeCodeGLAccountMappingDto, int>,
  ICreateRepository<ChargeCodeGLAccountMappingDto, int>,
  ICreateRepository,
  IGetAllRepository<ChargeCodeGLAccountMappingDto, int>,
  IGetAllRepository
{
  public ChargeCodeGLAccountMappingRepository()
    : base(new Action<string>(CurrentUser.Instance.LogAction))
  {
  }

  public ChargeCodeGLAccountMappingRepository(
    Action<string> logAction,
    DataNamesMapper<ChargeCodeGLAccountMappingDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base(logAction, dataNamesMapper, databaseAccess)
  {
  }

  protected override string UpdateProcedureName
  {
    get => "[dbo].[spFin_PolicyChargesOfficeAccounts_Update]";
  }

  protected override string GetByIdProcedureName
  {
    get => "[dbo].[spFin_PolicyChargesOfficeAccounts_GetById]";
  }

  protected override string GetAllProcedureName
  {
    get => "[dbo].[spFin_PolicyChargesOfficeAccounts_GetAll]";
  }

  protected virtual string InsertProcedureName
  {
    get => "[dbo].[spFin_PolicyChargesOfficeAccounts_Insert]";
  }

  public int Insert(ChargeCodeGLAccountMappingDto dto)
  {
    return ((BaseRepository<ChargeCodeGLAccountMappingDto, int>) this).BaseInsert(dto, this.InsertProcedureName, this.GetInsertParams(dto), "InsertedId");
  }

  private object[] GetInsertParams(ChargeCodeGLAccountMappingDto dto)
  {
    return new object[8]
    {
      (object) "@OfficeId",
      (object) dto.OfficeId,
      (object) "@GLAccountId",
      (object) dto.GlAccountId,
      (object) "@ChargeCode",
      (object) dto.ChargeCode,
      (object) "@UserGuid",
      (object) dto.LastModifiedUser
    };
  }

  public object Insert(object dto)
  {
    return dto is ChargeCodeGLAccountMappingDto dto1 ? (object) this.Insert(dto1) : throw new ArgumentException(BaseDataAccess<ChargeCodeGLAccountMappingDto, int>.GetTypeExceptionText(nameof (dto)));
  }

  protected override object[] GetGetByIdParams(int identifier)
  {
    return new object[2]
    {
      (object) "@Id",
      (object) identifier
    };
  }

  protected override object[] GetUpdateParams(ChargeCodeGLAccountMappingDto dto)
  {
    return ((IEnumerable<object>) this.GetInsertParams(dto)).Concat<object>((IEnumerable<object>) ((ReadOnlyRepositoryBase<ChargeCodeGLAccountMappingDto, int>) this).GetGetByIdParams(((UniqueObject<int>) dto).UniqueIdentifier)).ToArray<object>();
  }

  protected override void ValidateId(int identifier)
  {
    ((BaseDataAccess<ChargeCodeGLAccountMappingDto, int>) this).ValidateIntegerId(identifier);
  }

  protected override int ConvertToTypedId(object insertResultColumnValue)
  {
    return ((BaseRepository<ChargeCodeGLAccountMappingDto, int>) this).ConvertToInt(insertResultColumnValue);
  }
}
