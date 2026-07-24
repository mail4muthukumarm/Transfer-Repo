// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.BankAccount.BankAccountRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data.Repository.ColumnAttribute;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.BankAccount;

[Override(typeof (IBankAccountRepository))]
public class BankAccountRepository : 
  GetAllOnlyRepositoryBase<BankAccountDto, BankAccountKey>,
  IBankAccountRepository,
  IGetAllRepository<BankAccountDto, BankAccountKey>,
  IGetAllRepository,
  IExecuteTransaction
{
  public BankAccountRepository()
    : base(new Action<string>(CurrentUser.Instance.LogAction))
  {
  }

  public BankAccountRepository(
    Action<string> logAction,
    DataNamesMapper<BankAccountDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base(logAction, dataNamesMapper, databaseAccess)
  {
  }

  protected override string GetAllProcedureName => "[dbo].[spFin_BankAccount_GetAll]";

  protected override void ValidateId(BankAccountKey identifier)
  {
  }
}
