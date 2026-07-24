// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Utilities
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using MGASystems.Common.DataAccess;
using Microsoft.VisualBasic;
using System;
using System.Globalization;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses;

public class Utilities
{
  public const string EXPENSE_RIGHTS = "{A425EB6C-9B4D-46d9-BF1F-D0903E3B2798}";
  public const string EXPENSEAUTOMATIONACCOUNT_RIGHTS = "{98D8D393-D2D3-4a91-943C-FDD3D369B3E9}";

  private Utilities()
  {
  }

  internal static bool ExpenseCategoryExists(string CategoryName)
  {
    return (int) Database.Instance.QuerySP.PerformScalarQuery("spFin_ExpenseCategoryExists", (object) "@CategoryName", (object) CategoryName) > 0;
  }

  public static bool IsDecimal(string val)
  {
    if (!Information.IsNumeric((object) val))
      return false;
    try
    {
      Decimal num = 0M;
      num = Decimal.Parse(val, NumberStyles.Currency);
      return true;
    }
    catch (FormatException ex)
    {
      return false;
    }
  }

  internal static bool InvoicePaymentExists(Guid entityGuid, string invoiceNumber)
  {
    return Database.Instance.QueryText.PerformScalarQueryInt("SELECT dbo.VerifyOperatingInvoicePaymentMade(@EntityGuid, @InvoiceNum)", (object) "@EntityGuid", (object) entityGuid, (object) "@InvoiceNum", (object) invoiceNumber) == 1;
  }

  public enum SchedulingType
  {
    Daily,
    Weekly,
    TwoWeeks,
    Monthly,
    BiMonthly,
    TwoMonths,
    Quarterly,
    SemiAnnually,
    Annually,
    None,
  }

  [Flags]
  public enum OccurenceDays
  {
    None = 0,
    Sunday = 2,
    Monday = 4,
    Tuesday = 8,
    Wednesday = 16, // 0x00000010
    Thursday = 32, // 0x00000020
    Friday = 64, // 0x00000040
    Saturday = 128, // 0x00000080
    All = Saturday | Friday | Thursday | Wednesday | Tuesday | Monday | Sunday, // 0x000000FE
  }

  public enum PurchaseOrderPaymentType
  {
    AutoSchedule,
    ManualSchedule,
    PayNow,
    PayNowPrePaid,
    PayLater,
  }

  public enum ExpenseScheduleJournalType
  {
    Accrued,
    Prepaid,
  }

  public enum AnalysisReportType
  {
    BreakoutByExpense,
    BreakoutByExpenseCategory,
    CostCenterExpense,
    CostCenterExpenseIncome,
    EntityExpenses,
    OfficeLocationExpense,
    OfficeLocationExpenseIncome,
    UnderwriterExpenseIncome,
  }

  public enum AnalysisChartType
  {
    BarChart,
    BarChartWithSeries,
    PieChart,
  }
}
