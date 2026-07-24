// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.GLAccount.GLAccountRepository
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
namespace MGASystems.IMS.Accounting.Core.DataAccess.GLAccount;

[Override(typeof (IGLAccountRepository))]
public class GLAccountRepository : 
  ReadOnlyRepositoryBase<GLAccountDto, int>,
  IGLAccountRepository,
  IReadRepository<GLAccountDto, int>,
  IGetAllRepository<GLAccountDto, int>,
  IGetAllRepository,
  IExecuteTransaction,
  IGetByIdRepository<GLAccountDto, int>,
  IGetByIdRepository
{
  public GLAccountRepository()
    : base(new Action<string>(CurrentUser.Instance.LogAction))
  {
  }

  public GLAccountRepository(
    Action<string> logAction,
    DataNamesMapper<GLAccountDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base(logAction, dataNamesMapper, databaseAccess)
  {
  }

  protected override string GetByIdProcedureName => "[dbo].[spFin_GLAccount_GetById]";

  protected override string GetAllProcedureName => "[dbo].[spFin_GLAccount_GetAll]";

  protected virtual string GetAllActiveNonControlNonAutomationProcedureName
  {
    get => "[dbo].[spFin_GLAccount_GetAllActiveNonControlNonAutomation]";
  }

  protected virtual string GetAllIncomeProcedureName => "[dbo].[spFin_GLAccount_GetAllIncome]";

  public IEnumerable<GLAccountDto> GetAllActiveNonControlNonAutomationAccounts()
  {
    return (IEnumerable<GLAccountDto>) ((BaseDataAccess<GLAccountDto, int>) this).MapQueryMultiResult(this.GetAllActiveNonControlNonAutomationProcedureName);
  }

  public IEnumerable<GLAccountDto> GetAllIncome()
  {
    return (IEnumerable<GLAccountDto>) ((BaseDataAccess<GLAccountDto, int>) this).MapQueryMultiResult(this.GetAllIncomeProcedureName);
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
    ((BaseDataAccess<GLAccountDto, int>) this).ValidateIntegerId(identifier);
  }
}
