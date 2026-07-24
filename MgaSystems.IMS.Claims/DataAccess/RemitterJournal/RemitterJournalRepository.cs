// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.DataAccess.RemitterJournal.RemitterJournalRepository
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data;
using System.Data.Common;

#nullable disable
namespace MGASystems.IMS.Claims.DataAccess.RemitterJournal;

public class RemitterJournalRepository
{
  public static void Insert(RemitterJournalDto journalDto, int transactionNumber)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_InsertRemitterJournal", new object[16 /*0x10*/]
    {
      (object) "@transactnum",
      (object) transactionNumber,
      (object) "@receivedDate",
      (object) journalDto.ReceiveDate,
      (object) "@depositDate",
      (object) journalDto.DepositDate,
      (object) "@checkNumber",
      (object) journalDto.CheckNumber,
      (object) "@remitterGuid",
      (object) journalDto.RemitterGuid,
      (object) "@amount",
      (object) journalDto.Amount,
      (object) "@comments",
      (object) journalDto.Comments,
      (object) "@remittedFrom",
      journalDto.RemittedFrom
    });
  }

  public static void TransactionInsert(
    RemitterJournalDto journalDto,
    int transactionNumber,
    DbTransaction activeTransaction)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: method pointer
    DefaultDatabase.EnlistTransaction(activeTransaction, new ExecuteHandler((object) new RemitterJournalRepository.\u003C\u003Ec__DisplayClass1_0()
    {
      journalDto = journalDto,
      transactionNumber = transactionNumber
    }, __methodptr(\u003CTransactionInsert\u003Eb__0)));
  }
}
