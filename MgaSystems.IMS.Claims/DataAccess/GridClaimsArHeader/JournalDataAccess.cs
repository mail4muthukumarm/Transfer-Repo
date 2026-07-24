// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.DataAccess.GridClaimsArHeader.JournalDataAccess
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data;
using System.Data.Common;

#nullable disable
namespace MGASystems.IMS.Claims.DataAccess.GridClaimsArHeader;

public static class JournalDataAccess
{
  public static int InsertClaimsExpense(ReceiveExpenseHeaderDto dto)
  {
    return DefaultDatabase.ExecuteScalar<int>("spClaims_ReceiveExpenseHeader", new object[12]
    {
      (object) "@PostDate",
      (object) dto.PostDate,
      (object) "@transdescid",
      (object) dto.TransDescId,
      (object) "@journalentrytype",
      (object) dto.JournalEntryType,
      (object) "@comments",
      (object) dto.Comments,
      (object) "@UserGuid",
      (object) dto.CurrentUserGuid,
      (object) "@GLCompanyID",
      (object) dto.GlCompanyId
    });
  }

  public static int TransactionInsertClaimsExpense(
    ReceiveExpenseHeaderDto dto,
    DbTransaction activeTransaction)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    JournalDataAccess.\u003C\u003Ec__DisplayClass1_0 cDisplayClass10 = new JournalDataAccess.\u003C\u003Ec__DisplayClass1_0();
    // ISSUE: reference to a compiler-generated field
    cDisplayClass10.dto = dto;
    // ISSUE: reference to a compiler-generated field
    cDisplayClass10.result = 0;
    // ISSUE: method pointer
    DefaultDatabase.EnlistTransaction(activeTransaction, new ExecuteHandler((object) cDisplayClass10, __methodptr(\u003CTransactionInsertClaimsExpense\u003Eb__0)));
    // ISSUE: reference to a compiler-generated field
    return cDisplayClass10.result;
  }
}
