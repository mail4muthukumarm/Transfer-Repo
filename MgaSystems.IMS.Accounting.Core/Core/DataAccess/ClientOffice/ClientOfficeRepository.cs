// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.ClientOffice.ClientOfficeRepository
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
namespace MGASystems.IMS.Accounting.Core.DataAccess.ClientOffice;

[Override(typeof (IClientOfficeRepository))]
public class ClientOfficeRepository : 
  ReadOnlyRepositoryBase<ClientOfficeDto, int>,
  IClientOfficeRepository,
  IReadRepository<ClientOfficeDto, int>,
  IGetAllRepository<ClientOfficeDto, int>,
  IGetAllRepository,
  IExecuteTransaction,
  IGetByIdRepository<ClientOfficeDto, int>,
  IGetByIdRepository
{
  public ClientOfficeRepository()
    : base(new Action<string>(CurrentUser.Instance.LogAction))
  {
  }

  public ClientOfficeRepository(
    Action<string> logAction,
    DataNamesMapper<ClientOfficeDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base(logAction, dataNamesMapper, databaseAccess)
  {
  }

  protected override string GetByIdProcedureName => "[dbo].[spFin_ClientOffice_GetById]";

  protected override string GetAllProcedureName => "[dbo].[spFin_ClientOffice_GetAll]";

  protected virtual string GetAllAccountingOfficesProcedureName
  {
    get => "[dbo].[spFin_ClientOffice_GetAllAccountingOffices]";
  }

  public IEnumerable<ClientOfficeDto> GetAllAccountingOffices()
  {
    return (IEnumerable<ClientOfficeDto>) ((BaseDataAccess<ClientOfficeDto, int>) this).MapQueryMultiResult(this.GetAllAccountingOfficesProcedureName);
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
    ((BaseDataAccess<ClientOfficeDto, int>) this).ValidateIntegerId(identifier);
  }
}
