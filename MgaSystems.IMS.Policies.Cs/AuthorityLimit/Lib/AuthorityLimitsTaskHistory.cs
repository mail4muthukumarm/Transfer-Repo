// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimitsTaskHistory
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Data;
using System;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.AuthorityLimit.Lib;

public class AuthorityLimitsTaskHistory
{
  public int AuthorityLimitsTaskHistoryID { get; set; }

  public int AuthortityLimitsUserID { get; set; }

  public Guid QuoteGuid { get; set; }

  public Decimal FieldValue { get; set; }

  public long MinValue { get; set; }

  public long MaxValue { get; set; }

  public Guid NoteGuid { get; set; }

  public int? ApprovalDaysOverage { get; set; }

  public bool? SendTaskBind { get; set; }

  public bool? SendTaskQuote { get; set; }

  public AuthorityLimitCheckType CheckType { get; set; }

  public static bool HasTaskBeenSent(
    Guid quoteGuid,
    Decimal? fieldValue,
    long? minValue,
    long? maxValue,
    int authorityLimitsUserID,
    AuthorityLimitCheckType authorityLimitCheckType)
  {
    return authorityLimitCheckType == AuthorityLimitCheckType.Bind ? DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM tblAuthorityLimitsTaskHistory WHERE AuthorityLimitsUserID = @AuthorityLimitsUserID AND QuoteGuid = @QuoteGuid AND FieldValue = @FieldValue AND MinValue = @MinValue AND MaxValue = @MaxValue AND SendTaskBind = 1", new object[10]
    {
      (object) "@AuthorityLimitsUserID",
      (object) authorityLimitsUserID,
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@FieldValue",
      (object) fieldValue,
      (object) "@MinValue",
      (object) minValue,
      (object) "@MaxValue",
      (object) maxValue
    }).Rows.Count > 0 : (authorityLimitCheckType == AuthorityLimitCheckType.PrintQuote ? DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM tblAuthorityLimitsTaskHistory WHERE AuthorityLimitsUserID = @AuthorityLimitsUserID AND QuoteGuid = @QuoteGuid AND FieldValue = @FieldValue AND MinValue = @MinValue AND MaxValue = @MaxValue AND SendTaskQuote = 1", new object[10]
    {
      (object) "@AuthorityLimitsUserID",
      (object) authorityLimitsUserID,
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@FieldValue",
      (object) fieldValue,
      (object) "@MinValue",
      (object) minValue,
      (object) "@MaxValue",
      (object) maxValue
    }).Rows.Count > 0 : DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM tblAuthorityLimitsTaskHistory WHERE AuthorityLimitsUserID = @AuthorityLimitsUserID AND QuoteGuid = @QuoteGuid AND FieldValue = @FieldValue AND MinValue = @MinValue AND MaxValue = @MaxValue", new object[10]
    {
      (object) "@AuthorityLimitsUserID",
      (object) authorityLimitsUserID,
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@FieldValue",
      (object) fieldValue,
      (object) "@MinValue",
      (object) minValue,
      (object) "@MaxValue",
      (object) maxValue
    }).Rows.Count > 0);
  }

  public static bool HasOverageTaskBeenSent(
    Guid quoteGuid,
    Decimal? fieldValue,
    long? minValue,
    long? maxValue,
    int authorityLimitsUserID,
    int daysover,
    AuthorityLimitCheckType authorityLimitCheckType)
  {
    string str = "SELECT * FROM tblAuthorityLimitsTaskHistory WHERE AuthorityLimitsUserID = @AuthorityLimitsUserID AND QuoteGuid = @QuoteGuid AND FieldValue = @FieldValue AND MinValue = @MinValue AND MaxValue = @MaxValue AND ApprovalDaysOverage = @ApprovalDaysOverage";
    switch (authorityLimitCheckType)
    {
      case AuthorityLimitCheckType.Bind:
        str = "SELECT * FROM tblAuthorityLimitsTaskHistory WHERE AuthorityLimitsUserID = @AuthorityLimitsUserID AND QuoteGuid = @QuoteGuid AND FieldValue = @FieldValue AND MinValue = @MinValue AND MaxValue = @MaxValue AND ApprovalDaysOverage = @ApprovalDaysOverage AND SendTaskBind = 1";
        break;
      case AuthorityLimitCheckType.PrintQuote:
        str = "SELECT * FROM tblAuthorityLimitsTaskHistory WHERE AuthorityLimitsUserID = @AuthorityLimitsUserID AND QuoteGuid = @QuoteGuid AND FieldValue = @FieldValue AND MinValue = @MinValue AND MaxValue = @MaxValue AND ApprovalDaysOverage = @ApprovalDaysOverage AND SendTaskQuote = 1";
        break;
    }
    return DefaultDatabase.ExecuteDataTable(CommandType.Text, str, new object[12]
    {
      (object) "@AuthorityLimitsUserID",
      (object) authorityLimitsUserID,
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@FieldValue",
      (object) fieldValue,
      (object) "@MinValue",
      (object) minValue,
      (object) "@MaxValue",
      (object) maxValue,
      (object) "@ApprovalDaysOverage",
      (object) daysover
    }).Rows.Count > 0;
  }

  public void Update()
  {
    if (this.CheckType == AuthorityLimitCheckType.Bind)
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "spUpdateAuthorityLimitsTaskHistory", new object[16 /*0x10*/]
      {
        (object) "@AuthorityLimitsUserID",
        (object) this.AuthortityLimitsUserID,
        (object) "@QuoteGuid",
        (object) this.QuoteGuid,
        (object) "@FieldValue",
        (object) this.FieldValue,
        (object) "@MinValue",
        (object) this.MinValue,
        (object) "@MaxValue",
        (object) this.MaxValue,
        (object) "@NoteGuid",
        (object) this.NoteGuid,
        (object) "@ApprovalDaysOverage",
        (object) this.ApprovalDaysOverage,
        (object) "@SendTaskBind",
        (object) true
      });
    else if (this.CheckType == AuthorityLimitCheckType.PrintQuote)
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "spUpdateAuthorityLimitsTaskHistory", new object[16 /*0x10*/]
      {
        (object) "@AuthorityLimitsUserID",
        (object) this.AuthortityLimitsUserID,
        (object) "@QuoteGuid",
        (object) this.QuoteGuid,
        (object) "@FieldValue",
        (object) this.FieldValue,
        (object) "@MinValue",
        (object) this.MinValue,
        (object) "@MaxValue",
        (object) this.MaxValue,
        (object) "@NoteGuid",
        (object) this.NoteGuid,
        (object) "@ApprovalDaysOverage",
        (object) this.ApprovalDaysOverage,
        (object) "@SendTaskQuote",
        (object) true
      });
    else
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "spUpdateAuthorityLimitsTaskHistory", new object[14]
      {
        (object) "@AuthorityLimitsUserID",
        (object) this.AuthortityLimitsUserID,
        (object) "@QuoteGuid",
        (object) this.QuoteGuid,
        (object) "@FieldValue",
        (object) this.FieldValue,
        (object) "@MinValue",
        (object) this.MinValue,
        (object) "@MaxValue",
        (object) this.MaxValue,
        (object) "@NoteGuid",
        (object) this.NoteGuid,
        (object) "@ApprovalDaysOverage",
        (object) this.ApprovalDaysOverage
      });
  }
}
