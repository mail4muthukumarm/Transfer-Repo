// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.DataAccess.PayeeMissingBankAccountRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data.Repository.ColumnAttribute;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.DataAccess;

[Override(typeof (IPayeeMissingBankAccountRepository))]
public class PayeeMissingBankAccountRepository : 
  GetAllOnlyRepositoryBase<PayeeMissingBankAccountDto, Guid>,
  IPayeeMissingBankAccountRepository,
  IGetAllRepository<PayeeMissingBankAccountDto, Guid>,
  IGetAllRepository,
  IExecuteTransaction
{
  public PayeeMissingBankAccountRepository()
    : base((Action<string>) (s => CurrentUser.Instance.LogAction(s)))
  {
  }

  public PayeeMissingBankAccountRepository(
    Action<string> logAction,
    DataNamesMapper<PayeeMissingBankAccountDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base(logAction, dataNamesMapper, databaseAccess)
  {
  }

  protected override string GetAllProcedureName => "[dbo].[spFin_PayeeMissingBankAccount_GetAll]";

  protected override void ValidateId(Guid identifier)
  {
    ((BaseDataAccess<PayeeMissingBankAccountDto, Guid>) this).ValidateGuidId(identifier);
  }
}
