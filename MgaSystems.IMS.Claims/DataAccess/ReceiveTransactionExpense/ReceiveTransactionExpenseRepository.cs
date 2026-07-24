// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.DataAccess.ReceiveTransactionExpense.ReceiveTransactionExpenseRepository
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data;
using System.Collections.Generic;
using System.Data.Common;

#nullable disable
namespace MGASystems.IMS.Claims.DataAccess.ReceiveTransactionExpense;

public static class ReceiveTransactionExpenseRepository
{
  public static void Insert(ReceiveTransactionExpenseDto dto, int transactionNumber)
  {
    DefaultDatabase.ExecuteNonQuery("spClaims_ReceiveExpense", new object[14]
    {
      (object) "@TransactNum",
      (object) transactionNumber,
      (object) "@UserGuid",
      (object) dto.UserGuid,
      (object) "@ClaimId",
      (object) dto.ClaimId,
      (object) "@UAExpenseId",
      (object) dto.UAExpenseId,
      (object) "@Amount",
      (object) dto.Amount,
      (object) "@EntityGuid",
      (object) dto.EntityGuid,
      (object) "@BankAccount",
      dto.BankAccount
    });
  }

  public static void InsertBulk(
    IEnumerable<ReceiveTransactionExpenseDto> dtos,
    int transactionNumber)
  {
    foreach (ReceiveTransactionExpenseDto dto in dtos)
      ReceiveTransactionExpenseRepository.Insert(dto, transactionNumber);
  }

  public static void TransactionInsertBulk(
    IEnumerable<ReceiveTransactionExpenseDto> dtos,
    int transactionNumber,
    DbTransaction activeTransaction)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: method pointer
    DefaultDatabase.EnlistTransaction(activeTransaction, new ExecuteHandler((object) new ReceiveTransactionExpenseRepository.\u003C\u003Ec__DisplayClass2_0()
    {
      dtos = dtos,
      transactionNumber = transactionNumber
    }, __methodptr(\u003CTransactionInsertBulk\u003Eb__0)));
  }

  public static void TransactionInsert(
    ReceiveTransactionExpenseDto dto,
    int transactionNumber,
    DbTransaction activeTransaction)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: method pointer
    DefaultDatabase.EnlistTransaction(activeTransaction, new ExecuteHandler((object) new ReceiveTransactionExpenseRepository.\u003C\u003Ec__DisplayClass3_0()
    {
      dto = dto,
      transactionNumber = transactionNumber
    }, __methodptr(\u003CTransactionInsert\u003Eb__0)));
  }
}
