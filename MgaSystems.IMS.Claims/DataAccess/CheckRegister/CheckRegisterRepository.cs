// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.DataAccess.CheckRegister.CheckRegisterRepository
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data;
using System.Data.Common;

#nullable disable
namespace MGASystems.IMS.Claims.DataAccess.CheckRegister;

public static class CheckRegisterRepository
{
  public static void Insert(CheckRegisterDto checkRegisterDto, int transactionNumber)
  {
    DefaultDatabase.ExecuteScalar<int>("dbo.spFin_InsertCheckRegister", new object[30]
    {
      (object) "@TransactNum",
      (object) transactionNumber,
      (object) "@PaymentMethodId",
      (object) checkRegisterDto.PaymentMethod,
      (object) "@CheckingAccountId",
      checkRegisterDto.CheckingAcountId,
      (object) "@PayeeGuid",
      (object) checkRegisterDto.PayeeGuid,
      (object) "@CheckDate",
      (object) checkRegisterDto.CheckDate,
      (object) "@Comments",
      (object) checkRegisterDto.Comments,
      (object) "@CheckMemo",
      (object) checkRegisterDto.CheckMemo,
      (object) "@PayeeName",
      (object) checkRegisterDto.PayeeName,
      (object) "@PayeeAddress1",
      (object) checkRegisterDto.PayeeAddress1,
      (object) "@PayeeAddress2",
      (object) checkRegisterDto.PayeeAddress2,
      (object) "@PayeeCity",
      (object) checkRegisterDto.PayeeCity,
      (object) "@PayeeState",
      (object) checkRegisterDto.PayeeState,
      (object) "@PayeeZip",
      (object) checkRegisterDto.PayeeZip,
      (object) "@PayeeZipPlus",
      (object) checkRegisterDto.PayeeZipPlus,
      (object) "@CheckName",
      (object) checkRegisterDto.CheckName
    });
  }

  public static void TransactionInsert(
    CheckRegisterDto checkRegisterDto,
    int transactionNumber,
    DbTransaction activeTransaction)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: method pointer
    DefaultDatabase.EnlistTransaction(activeTransaction, new ExecuteHandler((object) new CheckRegisterRepository.\u003C\u003Ec__DisplayClass1_0()
    {
      checkRegisterDto = checkRegisterDto,
      transactionNumber = transactionNumber
    }, __methodptr(\u003CTransactionInsert\u003Eb__0)));
  }
}
