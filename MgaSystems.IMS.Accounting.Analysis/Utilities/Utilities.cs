// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.Utilities.Utilities
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using MGASystems.Data;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.Utilities;

internal class Utilities
{
  public const string GENERATECHART_RIGHTS = "{860DAF67-CA5C-49D7-A155-10C21F3356D9}";
  public const string ADDACCOUNT_RIGHTS = "{78462800-A74A-459A-88AC-95B26E0E2ED9}";
  public const string VIEWACCOUNTTREE_RIGHTS = "{76B43C61-475D-492E-B06C-6D79EF73DBF6}";
  public const string FISCALCONFIGURATION_RIGHTS = "{97119C1B-26C5-4B58-9C1B-7482E982C9F2}";
  public const string JOURNALENTRY_RIGHTS = "{BF14C079-3A6A-46D0-A99F-22C27CD69224}";
  public const string VIEWBANK_RIGHTS = "{D04F6EB4-46FA-4CE6-A431-C7B5ABD21297}";
  public const string DELETEACCOUNT_RIGHTS = "{966528FB-2AB4-4057-A083-E2706EF1B3A6}";
  public const string ACCTCLASS_RIGHTS = "{11E1B254-4DD3-4AC2-A029-F5A8DDF31BA6}";
  public const string AUTOMATIONEXCEPTION_RIGHTS = "{08DB4861-647F-4EBD-9563-0EB7A3282969}";

  internal static bool BankAccountExists(string bankName)
  {
    return (bool) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GLMaster_BankAccountExists(@bankAccountName)", new object[2]
    {
      (object) "@BankAccountName",
      (object) bankName
    });
  }

  internal static bool AccountIsAutomationAccount(int glAccountId)
  {
    return (bool) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.IsAutomationAccount(@GLAcctId)", new object[2]
    {
      (object) "@GLAcctId",
      (object) glAccountId
    });
  }

  internal static List<int> GetGlAccountIds(int glMasterId)
  {
    List<int> glAccountIds = new List<int>();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spFin_GLMasterGetAccountIds", new object[2]
    {
      (object) "@GLMasterId",
      (object) glMasterId
    });
    for (int index = 0; index < dataTable.Rows.Count; ++index)
      glAccountIds.Add((int) dataTable.Rows[index]["GlAcctId"]);
    return glAccountIds;
  }

  internal static void UpdateGLFinancialType(string glAccountNumber, int financialTypeId)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_GLMasterUpdateFinancialType", new object[4]
    {
      (object) "@AccountNumber",
      (object) glAccountNumber,
      (object) "@GLFinancialTypeID",
      (object) financialTypeId
    });
  }

  internal static bool AccountNumToClassIsValid(
    int glFinancialAccountNumber,
    int glAccountNumber,
    int glCompanyId)
  {
    return (bool) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.VerifyAcctNumToClass(@GLFinancialAccountNumber,@GLAccountNumber, @GLCompanyId)", new object[6]
    {
      (object) "@GLFinancialAccountNumber",
      (object) glFinancialAccountNumber,
      (object) "@GLAccountNumber",
      (object) glAccountNumber,
      (object) "@GLCompanyId",
      (object) glCompanyId
    });
  }
}
