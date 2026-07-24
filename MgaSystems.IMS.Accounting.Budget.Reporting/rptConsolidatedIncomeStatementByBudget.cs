// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Budget.Reporting.rptConsolidatedIncomeStatementByBudget
// Assembly: MGASystems.IMS.Accounting.Budget.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2F70404E-A856-4350-950F-177768D5941D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Budget.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Budget.Reporting;

[SecureReportResource("{B0029D2B-4491-4321-948E-C6DE88DD967E}", "Consolidated Income Statement By Budget", "Consolidated Income Statement By Budget", "Budget")]
public class rptConsolidatedIncomeStatementByBudget : MGAReport, IReport
{
  private string _glCompanyids;
  private DateTime _dateFrom;
  private DateTime _dateTo;
  private bool _originalBudgetFlag;
  private Decimal _totIncomeCMActual;
  private Decimal _totIncomeCMBudget;
  private Decimal _totIncomeCMPriorYear;
  private Decimal _totIncomeYTDActual;
  private Decimal _totIncomeYTDBudget;
  private Decimal _totIncomeYTDPriorYear;
  private Decimal _totExpensesCMActual;
  private Decimal _totExpensesCMBudget;
  private Decimal _totExpensesCMPriorYear;
  private Decimal _totExpensesYTDActual;
  private Decimal _totExpensesYTDBudget;
  private Decimal _totExpensesYTDPriorYear;
  private DataSet _ds;
  private const int _reportFontSize = 8;
  private const int _headerFontSize = 12;
  private const int _ixCM_Actual = 0;
  private const int _ixCM_Budget = 1;
  private const int _ixCM_PriorYear = 2;
  private const int _ixCM_ActVsBud = 3;
  private const int _ixCM_ActVsBudPct = 4;
  private const int _ixCM_ActVsPY = 5;
  private const int _ixCM_ActVsPYPct = 6;
  private const int _ixAcctClassName = 7;
  private const int _ixAcctTypeDesc = 8;
  private const int _ixFullName = 9;
  private const int _ixYTD_Actual = 10;
  private const int _ixYTD_Budget = 11;
  private const int _ixYTD_PriorYear = 12;
  private const int _ixYTD_ActVsBud = 13;
  private const int _ixYTD_ActVsBudPct = 14;
  private const int _ixYTD_ActVsPY = 15;
  private const int _ixYTD_ActVsPYPct = 16 /*0x10*/;
  private Workbook _wkb = new Workbook();
  private Worksheet _wks;
  private int _rowIndex;
  private Detail detail;
  private TextBox textBox1;
  private TextBox textBox2;
  private TextBox textBox3;
  private TextBox textBox4;
  private TextBox textBox5;
  private TextBox textBox6;
  private TextBox textBox7;
  private TextBox textBox8;
  private TextBox textBox9;
  private TextBox textBox10;
  private TextBox textBox11;
  private TextBox textBox12;
  private TextBox textBox13;
  private TextBox textBox14;
  private TextBox textBox15;
  private ReportHeader reportHeader1;
  private ReportFooter reportFooter1;
  private GroupHeader ghAcctClass;
  private GroupFooter gfAcctClass;
  private GroupHeader ghAcctType;
  private GroupFooter gfAcctType;
  private TextBox txtGhAcctClassName;
  private TextBox textBox16;
  private TextBox txtGfATCurrentMonth_ActualAmount;
  private TextBox txtGfATCurrentMonth_Budget;
  private TextBox txtGfATCurrentMonth_PYActual;
  private TextBox textBox21;
  private TextBox txtGfATCurrentMonth_ActVBudgetPerct;
  private TextBox textBox23;
  private TextBox txtGfATCurrentMonth_PYActVActualPerct;
  private TextBox txtGfATYTD_Actual;
  private TextBox txtGfATYTD_Budget;
  private TextBox txtGfATYTD_PYActual;
  private TextBox textBox29;
  private TextBox txtGfATYTD_ActVBudgetPerct;
  private TextBox textBox31;
  private TextBox txtGfATYTD_PYActVActualPerct;
  private TextBox textBox25;
  private TextBox textBox33;
  private TextBox txtGfACCurrentMonth_ActualAmount;
  private TextBox txtGfACCurrentMonth_Budget;
  private TextBox txtGfACCurrentMonth_PYActual;
  private TextBox textBox37;
  private TextBox txtGfACCurrentMonth_ActVBudgetPerct;
  private TextBox textBox39;
  private TextBox txtGfACCurrentMonth_PYActVActualPerct;
  private TextBox txtGfACYTD_Actual;
  private TextBox txtGfACYTD_Budget;
  private TextBox txtGfACYTD_PYActual;
  private TextBox textBox44;
  private TextBox txtGfACYTD_ActVBudgetPerct;
  private TextBox textBox46;
  private TextBox txtGfACYTD_PYActVActualPerct;
  private TextBox textBox48;
  private TextBox textBox49;
  private TextBox txtRfCurrentMonth_ActualAmount;
  private TextBox txtRfCurrentMonth_Budget;
  private TextBox txtRfCurrentMonth_PYActual;
  private TextBox txtRfCurrentMonth_ActVBudget;
  private TextBox txtRfCurrentMonth_ActVBudgetPerct;
  private TextBox txtRfCurrentMonth_PYActVActual;
  private TextBox txtRfCurrentMonth_PYActVActualPerct;
  private TextBox txtRfYTD_Actual;
  private TextBox txtRfYTD_Budget;
  private TextBox txtRfYTD_PYActual;
  private TextBox txtRfYTD_ActVBudget;
  private TextBox txtRfYTD_ActVBudgetPerct;
  private TextBox txtRfYTD_PYActVActual;
  private TextBox txtRfYTD_PYActVActualPerct;
  private TextBox textBox65;
  private PageHeader pageHeader1;
  private PageFooter pageFooter1;
  private Label label2;
  private Label labPeriodEnding;
  private Label label5;
  private Label label6;
  private Label label7;
  private Label label8;
  private Label label9;
  private Label label10;
  private Label label11;
  private Label label12;
  private Label label13;
  private Label label14;
  private Label label15;
  private Label label16;
  private Label label17;
  private Label label18;
  private Label label1;
  private Label labPHRunDateRange;
  private GroupHeader ghAcctTypePct;
  private GroupFooter gfAcctTypePct;
  private GroupHeader ghAcctClassPct;
  private GroupFooter gfAcctClassPct;
  private TextBox txtGfAcctTypePct_CM_ActualPct;
  private TextBox textBox19;
  private TextBox txtGfAcctTypePct_CM_BudgetPct;
  private TextBox txtGfAcctTypePct_CM_PriorYearPct;
  private TextBox txtGfAcctTypePct_YTD_ActualPct;
  private TextBox txtGfAcctTypePct_YTD_BudgetPct;
  private TextBox txtGfAcctTypePct_YTD_PriorYearPct;
  private TextBox txtGfAcctClassPct_CM_ActualPct;
  private TextBox textBox20;
  private TextBox txtGfAcctClassPct_CM_BudgetPct;
  private TextBox txtGfAcctClassPct_CM_PriorYearPct;
  private TextBox txtGfAcctClassPct_YTD_ActualPct;
  private TextBox txtGfAcctClassPct_YTD_BudgetPct;
  private TextBox txtGfAcctClassPct_YTD_PriorYearPct;
  private TextBox txtRF_CurrentMonth_PremActual;
  private TextBox txtRF_CurrentMonth_PremBudget;
  private TextBox txtRF_CurrentMonth_PremPYActual;
  private TextBox txtRF_CurrentMonth_PremActVBudget;
  private TextBox txtRF_CurrentMonth_PremActVBudgetPerct;
  private TextBox txtRF_CurrentMonth_PremPYActVActual;
  private TextBox txtRF_CurrentMonth_PremPYActVActualPerct;
  private TextBox txtRF_YTD_PremActual;
  private TextBox txtRF_YTD_PremBudget;
  private TextBox txtRF_YTD_PremPYActual;
  private TextBox txtRF_YTD_PremActVBudget;
  private TextBox txtRF_YTD_PremActVBudgetPerct;
  private TextBox txtRF_YTD_PremPYActVActual;
  private TextBox txtRF_YTD_PremPYActVActualPerct;
  private TextBox textBox42;
  private TextBox txtClientOfficeNames;

  public rptConsolidatedIncomeStatementByBudget() => this.InitializeComponent();

  public rptConsolidatedIncomeStatementByBudget(
    string glCompanyIds,
    DateTime dateFrom,
    DateTime dateTo,
    bool originalBudgetFlag)
  {
    this.InitializeComponent();
    this._glCompanyids = glCompanyIds;
    this._dateFrom = dateFrom;
    this._dateTo = dateTo;
    this._originalBudgetFlag = originalBudgetFlag;
  }

  private void rptConsolidatedIncomeStatementByBudget_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.HidePrintDateAndTime();
    this._ds = DefaultDatabase.ExecuteDataSet("spFin_rptConsolidatedIncomeStatementByBudget", new object[8]
    {
      (object) "@GlCompanyIds",
      (object) this._glCompanyids,
      (object) "@DateFrom",
      (object) this._dateFrom,
      (object) "@DateTo",
      (object) this._dateTo,
      (object) "@originalBudget",
      (object) this._originalBudgetFlag
    });
    this.DataSource = (object) this._ds.Tables[0];
    this.calcTotalIncomeExpenses();
  }

  Type IReport.getLaunchForm => (Type) null;

  BaseReportControl[] IReport.getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new GenericListBox("Office Locations", $"spFin_GetOfficeLocations @userguid='{CurrentUser.Instance.UserGUID.ToString()}'", "ID", "Office Location", false, typeof (int), false, false, 300),
        (BaseReportControl) new DateRangePicker("Date Range", false),
        (BaseReportControl) new GenericCheckBox("Budget", "Original Budget", true)
      };
    }
  }

  private void reportHeader1_Format(object sender, EventArgs e)
  {
    this.txtClientOfficeNames.Value = this._ds.Tables[1].Rows[0]["ClientOfficeNamesNewLine"];
    this.labPeriodEnding.Value = this._ds.Tables[1].Rows[0]["PeriodEnding"];
    this.labPHRunDateRange.Text = string.Format("{0:MMM d, yyyy} thru {1:MMM d, yyyy}", (object) this._dateFrom, (object) this._dateTo);
  }

  private void gfAcctType_Format(object sender, EventArgs e)
  {
    this.txtGfATCurrentMonth_ActVBudgetPerct.Value = !(Decimal.Parse(this.txtGfATCurrentMonth_Budget.Text) == 0M) ? (object) Math.Abs(Decimal.Round((Decimal.Parse(this.txtGfATCurrentMonth_Budget.Text) - Decimal.Parse(this.txtGfATCurrentMonth_ActualAmount.Text)) / Decimal.Parse(this.txtGfATCurrentMonth_Budget.Text), 2)) : (object) 0;
    this.txtGfATCurrentMonth_PYActVActualPerct.Value = !(Decimal.Parse(this.txtGfATCurrentMonth_PYActual.Text) == 0M) ? (object) Math.Abs(Decimal.Round((Decimal.Parse(this.txtGfATCurrentMonth_PYActual.Text) - Decimal.Parse(this.txtGfATCurrentMonth_ActualAmount.Text)) / Decimal.Parse(this.txtGfATCurrentMonth_PYActual.Text), 2)) : (object) 0;
    this.txtGfATYTD_ActVBudgetPerct.Value = !(Decimal.Parse(this.txtGfATYTD_Budget.Text) == 0M) ? (object) Math.Abs(Decimal.Round((Decimal.Parse(this.txtGfATYTD_Budget.Text) - Decimal.Parse(this.txtGfATYTD_Actual.Text)) / Decimal.Parse(this.txtGfATYTD_Budget.Text), 2)) : (object) 0;
    if (Decimal.Parse(this.txtGfATYTD_PYActual.Text) == 0M)
      this.txtGfATYTD_PYActVActualPerct.Value = (object) 0;
    else
      this.txtGfATYTD_PYActVActualPerct.Value = (object) Math.Abs(Decimal.Round((Decimal.Parse(this.txtGfATYTD_PYActual.Text) - Decimal.Parse(this.txtGfATYTD_Actual.Text)) / Decimal.Parse(this.txtGfATYTD_PYActual.Text), 2));
  }

  private void gfAcctClass_Format(object sender, EventArgs e)
  {
    this.txtGfACCurrentMonth_ActVBudgetPerct.Value = !(Decimal.Parse(this.txtGfACCurrentMonth_Budget.Text) == 0M) ? (object) Math.Abs(Decimal.Round((Decimal.Parse(this.txtGfACCurrentMonth_Budget.Text) - Decimal.Parse(this.txtGfACCurrentMonth_ActualAmount.Text)) / Decimal.Parse(this.txtGfACCurrentMonth_Budget.Text), 2)) : (object) 0;
    this.txtGfACCurrentMonth_PYActVActualPerct.Value = !(Decimal.Parse(this.txtGfACCurrentMonth_PYActual.Text) == 0M) ? (object) Math.Abs(Decimal.Round((Decimal.Parse(this.txtGfACCurrentMonth_PYActual.Text) - Decimal.Parse(this.txtGfACCurrentMonth_ActualAmount.Text)) / Decimal.Parse(this.txtGfACCurrentMonth_PYActual.Text), 2)) : (object) 0;
    this.txtGfACYTD_ActVBudgetPerct.Value = !(Decimal.Parse(this.txtGfACYTD_Budget.Text) == 0M) ? (object) Math.Abs(Decimal.Round((Decimal.Parse(this.txtGfACYTD_Budget.Text) - Decimal.Parse(this.txtGfACYTD_Actual.Text)) / Decimal.Parse(this.txtGfACYTD_Budget.Text), 2)) : (object) 0;
    if (Decimal.Parse(this.txtGfACYTD_PYActual.Text) == 0M)
      this.txtGfACYTD_PYActVActualPerct.Value = (object) 0;
    else
      this.txtGfACYTD_PYActVActualPerct.Value = (object) Math.Abs(Decimal.Round((Decimal.Parse(this.txtGfACYTD_PYActual.Text) - Decimal.Parse(this.txtGfACYTD_Actual.Text)) / Decimal.Parse(this.txtGfACYTD_PYActual.Text), 2));
  }

  private void reportFooter1_Format(object sender, EventArgs e)
  {
    this.txtRfCurrentMonth_ActualAmount.Value = (object) (this._totIncomeCMActual - this._totExpensesCMActual);
    this.txtRfCurrentMonth_Budget.Value = (object) (this._totIncomeCMBudget - this._totExpensesCMBudget);
    this.txtRfCurrentMonth_PYActual.Value = (object) (this._totIncomeCMPriorYear - this._totExpensesCMPriorYear);
    this.txtRfCurrentMonth_ActVBudget.Value = (object) (Decimal.Parse(this.txtRfCurrentMonth_Budget.Text) - Decimal.Parse(this.txtRfCurrentMonth_ActualAmount.Text));
    this.txtRfCurrentMonth_PYActVActual.Value = (object) (Decimal.Parse(this.txtRfCurrentMonth_PYActual.Text) - Decimal.Parse(this.txtRfCurrentMonth_ActualAmount.Text));
    this.txtRfYTD_Actual.Value = (object) (this._totIncomeYTDActual - this._totExpensesYTDActual);
    this.txtRfYTD_Budget.Value = (object) (this._totIncomeYTDBudget - this._totExpensesYTDBudget);
    this.txtRfYTD_PYActual.Value = (object) (this._totIncomeYTDPriorYear - this._totExpensesYTDPriorYear);
    this.txtRfYTD_ActVBudget.Value = (object) (Decimal.Parse(this.txtRfYTD_Budget.Text) - Decimal.Parse(this.txtRfYTD_Actual.Text));
    this.txtRfYTD_PYActVActual.Value = (object) (Decimal.Parse(this.txtRfYTD_PYActual.Text) - Decimal.Parse(this.txtRfYTD_Actual.Text));
    this.txtRfCurrentMonth_ActVBudgetPerct.Value = !(Decimal.Parse(this.txtRfCurrentMonth_Budget.Text) == 0M) ? (object) Math.Abs(Decimal.Round((Decimal.Parse(this.txtRfCurrentMonth_Budget.Text) - Decimal.Parse(this.txtRfCurrentMonth_ActualAmount.Text)) / Decimal.Parse(this.txtRfCurrentMonth_Budget.Text), 2)) : (object) 0;
    this.txtRfCurrentMonth_PYActVActualPerct.Value = !(Decimal.Parse(this.txtRfCurrentMonth_PYActual.Text) == 0M) ? (object) Math.Abs(Decimal.Round((Decimal.Parse(this.txtRfCurrentMonth_PYActual.Text) - Decimal.Parse(this.txtRfCurrentMonth_ActualAmount.Text)) / Decimal.Parse(this.txtRfCurrentMonth_PYActual.Text), 2)) : (object) 0;
    this.txtRfYTD_ActVBudgetPerct.Value = !(Decimal.Parse(this.txtRfYTD_Budget.Text) == 0M) ? (object) Math.Abs(Decimal.Round((Decimal.Parse(this.txtRfYTD_Budget.Text) - Decimal.Parse(this.txtRfYTD_Actual.Text)) / Decimal.Parse(this.txtRfYTD_Budget.Text), 2)) : (object) 0;
    this.txtRfYTD_PYActVActualPerct.Value = !(Decimal.Parse(this.txtRfYTD_PYActual.Text) == 0M) ? (object) Math.Abs(Decimal.Round((Decimal.Parse(this.txtRfYTD_PYActual.Text) - Decimal.Parse(this.txtRfYTD_Actual.Text)) / Decimal.Parse(this.txtRfYTD_PYActual.Text), 2)) : (object) 0;
    this.txtRF_CurrentMonth_PremActual.Value = this._ds.Tables[2].Rows[0]["CurrentMonth_PremActual"];
    this.txtRF_CurrentMonth_PremBudget.Value = this._ds.Tables[2].Rows[0]["CurrentMonth_PremBudget"];
    this.txtRF_CurrentMonth_PremPYActual.Value = this._ds.Tables[2].Rows[0]["CurrentMonth_PremPYActual"];
    this.txtRF_CurrentMonth_PremActVBudget.Value = this._ds.Tables[2].Rows[0]["CurrentMonth_PremActVBudget"];
    this.txtRF_CurrentMonth_PremActVBudgetPerct.Value = this._ds.Tables[2].Rows[0]["CurrentMonth_PremActVBudgetPerct"];
    this.txtRF_CurrentMonth_PremPYActVActual.Value = this._ds.Tables[2].Rows[0]["CurrentMonth_PremPYActVActual"];
    this.txtRF_CurrentMonth_PremPYActVActualPerct.Value = this._ds.Tables[2].Rows[0]["CurrentMonth_PremPYActVActualPerct"];
    this.txtRF_YTD_PremActual.Value = this._ds.Tables[2].Rows[0]["YTD_PremActual"];
    this.txtRF_YTD_PremBudget.Value = this._ds.Tables[2].Rows[0]["YTD_PremBudget"];
    this.txtRF_YTD_PremPYActual.Value = this._ds.Tables[2].Rows[0]["YTD_PremPYActual"];
    this.txtRF_YTD_PremActVBudget.Value = this._ds.Tables[2].Rows[0]["YTD_PremActVBudget"];
    this.txtRF_YTD_PremActVBudgetPerct.Value = this._ds.Tables[2].Rows[0]["YTD_PremActVBudgetPerct"];
    this.txtRF_YTD_PremPYActVActual.Value = this._ds.Tables[2].Rows[0]["YTD_PremPYActVActual"];
    this.txtRF_YTD_PremPYActVActualPerct.Value = this._ds.Tables[2].Rows[0]["YTD_PremPYActVActualPerct"];
  }

  private void gfAcctTypePct_Format(object sender, EventArgs e)
  {
    if (this.txtGhAcctClassName.Text == "Expenses")
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypePct).Visible = true;
    this.txtGfAcctTypePct_CM_ActualPct.Value = !(this._totIncomeCMActual == 0M) ? (object) (Decimal.Parse(this.txtGfATCurrentMonth_ActualAmount.Text) / this._totIncomeCMActual) : (object) 0;
    this.txtGfAcctTypePct_CM_BudgetPct.Value = !(this._totIncomeCMBudget == 0M) ? (object) (Decimal.Parse(this.txtGfATCurrentMonth_Budget.Text) / this._totIncomeCMBudget) : (object) 0;
    this.txtGfAcctTypePct_CM_PriorYearPct.Value = !(this._totIncomeCMPriorYear == 0M) ? (object) (Decimal.Parse(this.txtGfATCurrentMonth_PYActual.Text) / this._totIncomeCMPriorYear) : (object) 0;
    this.txtGfAcctTypePct_YTD_ActualPct.Value = !(this._totIncomeYTDActual == 0M) ? (object) (Decimal.Parse(this.txtGfATYTD_Actual.Text) / this._totIncomeYTDActual) : (object) 0;
    this.txtGfAcctTypePct_YTD_BudgetPct.Value = !(this._totIncomeYTDBudget == 0M) ? (object) (Decimal.Parse(this.txtGfATYTD_Budget.Text) / this._totIncomeYTDBudget) : (object) 0;
    if (this._totIncomeYTDPriorYear == 0M)
      this.txtGfAcctTypePct_YTD_PriorYearPct.Value = (object) 0;
    else
      this.txtGfAcctTypePct_YTD_PriorYearPct.Value = (object) (Decimal.Parse(this.txtGfATYTD_PYActual.Text) / this._totIncomeYTDPriorYear);
  }

  private void gfAcctClassPct_Format(object sender, EventArgs e)
  {
    if (this.txtGhAcctClassName.Text == "Expenses")
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassPct).Visible = true;
    this.txtGfAcctClassPct_CM_ActualPct.Value = !(this._totIncomeCMActual == 0M) ? (object) (Decimal.Parse(this.txtGfACCurrentMonth_ActualAmount.Text) / this._totIncomeCMActual) : (object) 0;
    this.txtGfAcctClassPct_CM_BudgetPct.Value = !(this._totIncomeCMBudget == 0M) ? (object) (Decimal.Parse(this.txtGfACCurrentMonth_Budget.Text) / this._totIncomeCMBudget) : (object) 0;
    this.txtGfAcctClassPct_CM_PriorYearPct.Value = !(this._totIncomeCMPriorYear == 0M) ? (object) (Decimal.Parse(this.txtGfACCurrentMonth_PYActual.Text) / this._totIncomeCMPriorYear) : (object) 0;
    this.txtGfAcctClassPct_YTD_ActualPct.Value = !(this._totIncomeYTDActual == 0M) ? (object) (Decimal.Parse(this.txtGfACYTD_Actual.Text) / this._totIncomeYTDActual) : (object) 0;
    this.txtGfAcctClassPct_YTD_BudgetPct.Value = !(this._totIncomeYTDBudget == 0M) ? (object) (Decimal.Parse(this.txtGfACYTD_Budget.Text) / this._totIncomeYTDBudget) : (object) 0;
    if (this._totIncomeYTDPriorYear == 0M)
      this.txtGfAcctClassPct_YTD_PriorYearPct.Value = (object) 0;
    else
      this.txtGfAcctClassPct_YTD_PriorYearPct.Value = (object) (Decimal.Parse(this.txtGfACYTD_PYActual.Text) / this._totIncomeYTDPriorYear);
  }

  private void calcTotalIncomeExpenses()
  {
    this._totIncomeCMActual = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_ActualAmount)", "AcctClassName = 'Income'");
    this._totIncomeCMBudget = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_Budget)", "AcctClassName = 'Income'");
    this._totIncomeCMPriorYear = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_PYActual)", "AcctClassName = 'Income'");
    this._totIncomeYTDActual = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_Actual)", "AcctClassName = 'Income'");
    this._totIncomeYTDBudget = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_Budget)", "AcctClassName = 'Income'");
    this._totIncomeYTDPriorYear = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_PYActual)", "AcctClassName = 'Income'");
    this._totExpensesCMActual = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_ActualAmount)", "AcctClassName = 'Expenses'");
    this._totExpensesCMBudget = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_Budget)", "AcctClassName = 'Expenses'");
    this._totExpensesCMPriorYear = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_PYActual)", "AcctClassName = 'Expenses'");
    this._totExpensesYTDActual = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_Actual)", "AcctClassName = 'Expenses'");
    this._totExpensesYTDBudget = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_Budget)", "AcctClassName = 'Expenses'");
    this._totExpensesYTDPriorYear = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_PYActual)", "AcctClassName = 'Expenses'");
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string saveFileTo)
  {
    this._wks = this._wkb.Worksheets[0];
    this._wks.Name = "Cons Budget Income Stmt";
    DataTable table = this._ds.Tables[0].DefaultView.ToTable(true, "AcctClassName");
    DataView defaultView = this._ds.Tables[0].DefaultView;
    foreach (DataRow row1 in (InternalDataCollectionBase) table.Rows)
    {
      this.PrintAcctClassName(row1["AcctClassName"].ToString());
      defaultView.RowFilter = $"AcctClassName = '{row1["AcctClassName"]}'";
      foreach (DataRow row2 in (InternalDataCollectionBase) defaultView.ToTable(true, "AcctTypeDescription").Rows)
      {
        this.PrintAcctTypeDesc(row2["AcctTypeDescription"].ToString());
        this.PrintDetailLine(row2["AcctTypeDescription"].ToString());
        this.PrintAcctTypeSubtotLine(row1["AcctClassName"].ToString(), row2["AcctTypeDescription"].ToString());
      }
      this.PrintAcctClassSubtotLine(row1["AcctClassName"].ToString());
    }
    this.PrintGrandTotalLine();
    this.PrintPremiumsLine();
    this.PrintReportHeaders();
    this._wkb.Save(saveFileTo);
    Process.Start(saveFileTo);
  }

  private void PrintDetailLine(string AcctTypeDescription)
  {
    DataView defaultView = this._ds.Tables[0].DefaultView;
    defaultView.RowFilter = $"AcctTypeDescription = '{AcctTypeDescription}'";
    foreach (DataRow row in (InternalDataCollectionBase) defaultView.ToTable().Rows)
    {
      Cell cell1 = this._wks.Cells[this._rowIndex, 0];
      cell1.SetStyle(this.GetStyle(cell1.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailMoneyValue));
      cell1.PutValue(Decimal.Parse(row["CurrentMonth_ActualAmount"].ToString()));
      Cell cell2 = this._wks.Cells[this._rowIndex, 1];
      cell2.SetStyle(this.GetStyle(cell2.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailMoneyValue));
      cell2.PutValue(Decimal.Parse(row["CurrentMonth_Budget"].ToString()));
      Cell cell3 = this._wks.Cells[this._rowIndex, 2];
      cell3.SetStyle(this.GetStyle(cell3.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailMoneyValue));
      cell3.PutValue(Decimal.Parse(row["CurrentMonth_PYActual"].ToString()));
      Cell cell4 = this._wks.Cells[this._rowIndex, 3];
      cell4.SetStyle(this.GetStyle(cell4.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailMoneyValue));
      cell4.PutValue(Decimal.Parse(row["CurrentMonth_ActVBudget"].ToString()));
      Cell cell5 = this._wks.Cells[this._rowIndex, 4];
      cell5.SetStyle(this.GetStyle(cell5.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailPctValue));
      cell5.PutValue(Decimal.Parse(row["CurrentMonth_ActVBudgetPerct"].ToString()));
      Cell cell6 = this._wks.Cells[this._rowIndex, 5];
      cell6.SetStyle(this.GetStyle(cell6.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailMoneyValue));
      cell6.PutValue(Decimal.Parse(row["CurrentMonth_PYActVActual"].ToString()));
      Cell cell7 = this._wks.Cells[this._rowIndex, 6];
      cell7.SetStyle(this.GetStyle(cell7.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailPctValue));
      cell7.PutValue(Decimal.Parse(row["CurrentMonth_PYActVActualPerct"].ToString()));
      Cell cell8 = this._wks.Cells[this._rowIndex, 9];
      cell8.SetStyle(this.GetStyle(cell8.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailPlain));
      cell8.PutValue(row["FullName"].ToString());
      Cell cell9 = this._wks.Cells[this._rowIndex, 10];
      cell9.SetStyle(this.GetStyle(cell9.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailMoneyValue));
      cell9.PutValue(Decimal.Parse(row["YTD_Actual"].ToString()));
      Cell cell10 = this._wks.Cells[this._rowIndex, 11];
      cell10.SetStyle(this.GetStyle(cell10.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailMoneyValue));
      cell10.PutValue(Decimal.Parse(row["YTD_Budget"].ToString()));
      Cell cell11 = this._wks.Cells[this._rowIndex, 12];
      cell11.SetStyle(this.GetStyle(cell11.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailMoneyValue));
      cell11.PutValue(Decimal.Parse(row["YTD_PYActual"].ToString()));
      Cell cell12 = this._wks.Cells[this._rowIndex, 13];
      cell12.SetStyle(this.GetStyle(cell12.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailMoneyValue));
      cell12.PutValue(Decimal.Parse(row["YTD_ActVBudget"].ToString()));
      Cell cell13 = this._wks.Cells[this._rowIndex, 14];
      cell13.SetStyle(this.GetStyle(cell13.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailPctValue));
      cell13.PutValue(Decimal.Parse(row["YTD_ActVBudgetPerct"].ToString()));
      Cell cell14 = this._wks.Cells[this._rowIndex, 15];
      cell14.SetStyle(this.GetStyle(cell14.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailMoneyValue));
      cell14.PutValue(Decimal.Parse(row["YTD_PYActVActual"].ToString()));
      Cell cell15 = this._wks.Cells[this._rowIndex, 16 /*0x10*/];
      cell15.SetStyle(this.GetStyle(cell15.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailPctValue));
      cell15.PutValue(Decimal.Parse(row["YTD_PYActVActualPerct"].ToString()));
      ++this._rowIndex;
    }
  }

  private void PrintAcctTypeSubtotLine(string AcctClassName, string AcctTypeDescription)
  {
    Decimal num1 = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_ActualAmount)", $"AcctTypeDescription = '{AcctTypeDescription}'");
    Decimal num2 = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_Budget)", $"AcctTypeDescription = '{AcctTypeDescription}'");
    Decimal num3 = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_PYActual)", $"AcctTypeDescription = '{AcctTypeDescription}'");
    Decimal num4 = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_ActVBudget)", $"AcctTypeDescription = '{AcctTypeDescription}'");
    Decimal num5 = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_PYActVActual)", $"AcctTypeDescription = '{AcctTypeDescription}'");
    Decimal num6 = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_Actual)", $"AcctTypeDescription = '{AcctTypeDescription}'");
    Decimal num7 = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_Budget)", $"AcctTypeDescription = '{AcctTypeDescription}'");
    Decimal num8 = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_PYActual)", $"AcctTypeDescription = '{AcctTypeDescription}'");
    Decimal num9 = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_ActVBudget)", $"AcctTypeDescription = '{AcctTypeDescription}'");
    Decimal num10 = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_PYActVActual)", $"AcctTypeDescription = '{AcctTypeDescription}'");
    Decimal num11 = !(num2 == 0M) ? Math.Abs(Decimal.Round((num2 - num1) / num2, 2)) : 0M;
    Decimal num12 = !(num3 == 0M) ? Math.Abs(Decimal.Round((num3 - num1) / num3, 2)) : 0M;
    Decimal num13 = !(num7 == 0M) ? Math.Abs(Decimal.Round((num7 - num6) / num7, 2)) : 0M;
    Decimal num14 = !(num8 == 0M) ? Math.Abs(Decimal.Round((num8 - num6) / num8, 2)) : 0M;
    Cell cell1 = this._wks.Cells[this._rowIndex, 0];
    cell1.SetStyle(this.GetStyle(cell1.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotMoneyValue));
    cell1.PutValue(num1);
    Cell cell2 = this._wks.Cells[this._rowIndex, 1];
    cell2.SetStyle(this.GetStyle(cell2.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotMoneyValue));
    cell2.PutValue(num2);
    Cell cell3 = this._wks.Cells[this._rowIndex, 2];
    cell3.SetStyle(this.GetStyle(cell3.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotMoneyValue));
    cell3.PutValue(num3);
    Cell cell4 = this._wks.Cells[this._rowIndex, 3];
    cell4.SetStyle(this.GetStyle(cell4.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotMoneyValue));
    cell4.PutValue(num4);
    Cell cell5 = this._wks.Cells[this._rowIndex, 4];
    cell5.SetStyle(this.GetStyle(cell5.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotPctValue));
    cell5.PutValue(num11);
    Cell cell6 = this._wks.Cells[this._rowIndex, 5];
    cell6.SetStyle(this.GetStyle(cell6.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotMoneyValue));
    cell6.PutValue(num5);
    Cell cell7 = this._wks.Cells[this._rowIndex, 6];
    cell7.SetStyle(this.GetStyle(cell7.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotPctValue));
    cell7.PutValue(num12);
    Cell cell8 = this._wks.Cells[this._rowIndex, 8];
    cell8.SetStyle(this.GetStyle(cell8.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotPlain));
    cell8.PutValue("Total");
    Cell cell9 = this._wks.Cells[this._rowIndex, 9];
    cell9.SetStyle(this.GetStyle(cell9.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotPlain));
    cell9.PutValue(AcctTypeDescription);
    Cell cell10 = this._wks.Cells[this._rowIndex, 10];
    cell10.SetStyle(this.GetStyle(cell10.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotMoneyValue));
    cell10.PutValue(num6);
    Cell cell11 = this._wks.Cells[this._rowIndex, 11];
    cell11.SetStyle(this.GetStyle(cell11.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotMoneyValue));
    cell11.PutValue(num7);
    Cell cell12 = this._wks.Cells[this._rowIndex, 12];
    cell12.SetStyle(this.GetStyle(cell12.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotMoneyValue));
    cell12.PutValue(num8);
    Cell cell13 = this._wks.Cells[this._rowIndex, 13];
    cell13.SetStyle(this.GetStyle(cell13.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotMoneyValue));
    cell13.PutValue(num9);
    Cell cell14 = this._wks.Cells[this._rowIndex, 14];
    cell14.SetStyle(this.GetStyle(cell14.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotPctValue));
    cell14.PutValue(num13);
    Cell cell15 = this._wks.Cells[this._rowIndex, 15];
    cell15.SetStyle(this.GetStyle(cell15.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotMoneyValue));
    cell15.PutValue(num10);
    Cell cell16 = this._wks.Cells[this._rowIndex, 16 /*0x10*/];
    cell16.SetStyle(this.GetStyle(cell16.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotPctValue));
    cell16.PutValue(num14);
    ++this._rowIndex;
    if (!(AcctClassName == "Expenses"))
      return;
    Decimal num15 = !(this._totIncomeCMActual == 0M) ? num1 / this._totIncomeCMActual : 0M;
    Decimal num16 = !(this._totIncomeCMBudget == 0M) ? num2 / this._totIncomeCMBudget : 0M;
    Decimal num17 = !(this._totIncomeCMPriorYear == 0M) ? num3 / this._totIncomeCMPriorYear : 0M;
    Decimal num18 = !(this._totIncomeYTDActual == 0M) ? num6 / this._totIncomeYTDActual : 0M;
    Decimal num19 = !(this._totIncomeYTDBudget == 0M) ? num7 / this._totIncomeYTDBudget : 0M;
    Decimal num20 = !(this._totIncomeYTDPriorYear == 0M) ? num8 / this._totIncomeYTDPriorYear : 0M;
    Cell cell17 = this._wks.Cells[this._rowIndex, 0];
    cell17.SetStyle(this.GetStyle(cell17.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PercentOfIncome));
    cell17.PutValue(num15);
    Cell cell18 = this._wks.Cells[this._rowIndex, 1];
    cell18.SetStyle(this.GetStyle(cell18.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PercentOfIncome));
    cell18.PutValue(num16);
    Cell cell19 = this._wks.Cells[this._rowIndex, 2];
    cell19.SetStyle(this.GetStyle(cell19.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PercentOfIncome));
    cell19.PutValue(num17);
    Cell cell20 = this._wks.Cells[this._rowIndex, 8];
    cell20.SetStyle(this.GetStyle(cell20.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotPlain));
    cell20.PutValue("% of income");
    Cell cell21 = this._wks.Cells[this._rowIndex, 10];
    cell21.SetStyle(this.GetStyle(cell21.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PercentOfIncome));
    cell21.PutValue(num18);
    Cell cell22 = this._wks.Cells[this._rowIndex, 11];
    cell22.SetStyle(this.GetStyle(cell22.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PercentOfIncome));
    cell22.PutValue(num19);
    Cell cell23 = this._wks.Cells[this._rowIndex, 12];
    cell23.SetStyle(this.GetStyle(cell23.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PercentOfIncome));
    cell23.PutValue(num20);
    ++this._rowIndex;
  }

  private void PrintAcctClassSubtotLine(string AcctClassName)
  {
    Decimal num1 = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_ActualAmount)", $"AcctClassName = '{AcctClassName}'");
    Decimal num2 = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_Budget)", $"AcctClassName = '{AcctClassName}'");
    Decimal num3 = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_PYActual)", $"AcctClassName = '{AcctClassName}'");
    Decimal num4 = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_ActVBudget)", $"AcctClassName = '{AcctClassName}'");
    Decimal num5 = (Decimal) this._ds.Tables[0].Compute("SUM(CurrentMonth_PYActVActual)", $"AcctClassName = '{AcctClassName}'");
    Decimal num6 = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_Actual)", $"AcctClassName = '{AcctClassName}'");
    Decimal num7 = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_Budget)", $"AcctClassName = '{AcctClassName}'");
    Decimal num8 = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_PYActual)", $"AcctClassName = '{AcctClassName}'");
    Decimal num9 = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_ActVBudget)", $"AcctClassName = '{AcctClassName}'");
    Decimal num10 = (Decimal) this._ds.Tables[0].Compute("SUM(YTD_PYActVActual)", $"AcctClassName = '{AcctClassName}'");
    Decimal num11 = !(num2 == 0M) ? Math.Abs(Decimal.Round((num2 - num1) / num2, 2)) : 0M;
    Decimal num12 = !(num3 == 0M) ? Math.Abs(Decimal.Round((num3 - num1) / num3, 2)) : 0M;
    Decimal num13 = !(num7 == 0M) ? Math.Abs(Decimal.Round((num7 - num6) / num7, 2)) : 0M;
    Decimal num14 = !(num8 == 0M) ? Math.Abs(Decimal.Round((num8 - num6) / num8, 2)) : 0M;
    Cell cell1 = this._wks.Cells[this._rowIndex, 0];
    cell1.SetStyle(this.GetStyle(cell1.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotMoneyValue));
    cell1.PutValue(num1);
    Cell cell2 = this._wks.Cells[this._rowIndex, 1];
    cell2.SetStyle(this.GetStyle(cell2.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotMoneyValue));
    cell2.PutValue(num2);
    Cell cell3 = this._wks.Cells[this._rowIndex, 2];
    cell3.SetStyle(this.GetStyle(cell3.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotMoneyValue));
    cell3.PutValue(num3);
    Cell cell4 = this._wks.Cells[this._rowIndex, 3];
    cell4.SetStyle(this.GetStyle(cell4.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotMoneyValue));
    cell4.PutValue(num4);
    Cell cell5 = this._wks.Cells[this._rowIndex, 4];
    cell5.SetStyle(this.GetStyle(cell5.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotPctValue));
    cell5.PutValue(num11);
    Cell cell6 = this._wks.Cells[this._rowIndex, 5];
    cell6.SetStyle(this.GetStyle(cell6.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotMoneyValue));
    cell6.PutValue(num5);
    Cell cell7 = this._wks.Cells[this._rowIndex, 6];
    cell7.SetStyle(this.GetStyle(cell7.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotPctValue));
    cell7.PutValue(num12);
    Cell cell8 = this._wks.Cells[this._rowIndex, 8];
    cell8.SetStyle(this.GetStyle(cell8.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotPlain));
    cell8.PutValue("Total");
    Cell cell9 = this._wks.Cells[this._rowIndex, 9];
    cell9.SetStyle(this.GetStyle(cell9.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotPlain));
    cell9.PutValue(AcctClassName);
    Cell cell10 = this._wks.Cells[this._rowIndex, 10];
    cell10.SetStyle(this.GetStyle(cell10.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotMoneyValue));
    cell10.PutValue(num6);
    Cell cell11 = this._wks.Cells[this._rowIndex, 11];
    cell11.SetStyle(this.GetStyle(cell11.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotMoneyValue));
    cell11.PutValue(num7);
    Cell cell12 = this._wks.Cells[this._rowIndex, 12];
    cell12.SetStyle(this.GetStyle(cell12.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotMoneyValue));
    cell12.PutValue(num8);
    Cell cell13 = this._wks.Cells[this._rowIndex, 13];
    cell13.SetStyle(this.GetStyle(cell13.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotMoneyValue));
    cell13.PutValue(num9);
    Cell cell14 = this._wks.Cells[this._rowIndex, 14];
    cell14.SetStyle(this.GetStyle(cell14.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotPctValue));
    cell14.PutValue(num13);
    Cell cell15 = this._wks.Cells[this._rowIndex, 15];
    cell15.SetStyle(this.GetStyle(cell15.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotMoneyValue));
    cell15.PutValue(num10);
    Cell cell16 = this._wks.Cells[this._rowIndex, 16 /*0x10*/];
    cell16.SetStyle(this.GetStyle(cell16.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotPctValue));
    cell16.PutValue(num14);
    ++this._rowIndex;
    if (!(AcctClassName == "Expenses"))
      return;
    Decimal num15 = !(this._totIncomeCMActual == 0M) ? num1 / this._totIncomeCMActual : 0M;
    Decimal num16 = !(this._totIncomeCMBudget == 0M) ? num2 / this._totIncomeCMBudget : 0M;
    Decimal num17 = !(this._totIncomeCMPriorYear == 0M) ? num3 / this._totIncomeCMPriorYear : 0M;
    Decimal num18 = !(this._totIncomeYTDActual == 0M) ? num6 / this._totIncomeYTDActual : 0M;
    Decimal num19 = !(this._totIncomeYTDBudget == 0M) ? num7 / this._totIncomeYTDBudget : 0M;
    Decimal num20 = !(this._totIncomeYTDPriorYear == 0M) ? num8 / this._totIncomeYTDPriorYear : 0M;
    Cell cell17 = this._wks.Cells[this._rowIndex, 0];
    cell17.SetStyle(this.GetStyle(cell17.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PercentOfIncome));
    cell17.PutValue(num15);
    Cell cell18 = this._wks.Cells[this._rowIndex, 1];
    cell18.SetStyle(this.GetStyle(cell18.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PercentOfIncome));
    cell18.PutValue(num16);
    Cell cell19 = this._wks.Cells[this._rowIndex, 2];
    cell19.SetStyle(this.GetStyle(cell19.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PercentOfIncome));
    cell19.PutValue(num17);
    Cell cell20 = this._wks.Cells[this._rowIndex, 8];
    cell20.SetStyle(this.GetStyle(cell20.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotPlain));
    cell20.PutValue("% of income");
    Cell cell21 = this._wks.Cells[this._rowIndex, 10];
    cell21.SetStyle(this.GetStyle(cell21.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PercentOfIncome));
    cell21.PutValue(num18);
    Cell cell22 = this._wks.Cells[this._rowIndex, 11];
    cell22.SetStyle(this.GetStyle(cell22.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PercentOfIncome));
    cell22.PutValue(num19);
    Cell cell23 = this._wks.Cells[this._rowIndex, 12];
    cell23.SetStyle(this.GetStyle(cell23.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PercentOfIncome));
    cell23.PutValue(num20);
    ++this._rowIndex;
  }

  private void PrintGrandTotalLine()
  {
    Decimal num1 = this._totIncomeCMActual - this._totExpensesCMActual;
    Decimal num2 = this._totIncomeCMBudget - this._totExpensesCMBudget;
    Decimal num3 = this._totIncomeCMPriorYear - this._totExpensesCMPriorYear;
    Decimal num4 = num2 - num1;
    Decimal num5 = num3 - num1;
    Decimal num6 = this._totIncomeYTDActual - this._totExpensesYTDActual;
    Decimal num7 = this._totIncomeYTDBudget - this._totExpensesYTDBudget;
    Decimal num8 = this._totIncomeYTDPriorYear - this._totExpensesYTDPriorYear;
    Decimal num9 = num7 - num6;
    Decimal num10 = num8 - num6;
    Decimal num11 = !(num2 == 0M) ? Math.Abs(Decimal.Round((num2 - num1) / num2, 2)) : 0M;
    Decimal num12 = !(num3 == 0M) ? Math.Abs(Decimal.Round((num3 - num1) / num3, 2)) : 0M;
    Decimal num13 = !(num7 == 0M) ? Math.Abs(Decimal.Round((num7 - num6) / num7, 2)) : 0M;
    Decimal num14 = !(num8 == 0M) ? Math.Abs(Decimal.Round((num8 - num6) / num8, 2)) : 0M;
    Cell cell1 = this._wks.Cells[this._rowIndex, 0];
    cell1.SetStyle(this.GetStyle(cell1.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalMoneyValue));
    cell1.PutValue(num1);
    Cell cell2 = this._wks.Cells[this._rowIndex, 1];
    cell2.SetStyle(this.GetStyle(cell2.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalMoneyValue));
    cell2.PutValue(num2);
    Cell cell3 = this._wks.Cells[this._rowIndex, 2];
    cell3.SetStyle(this.GetStyle(cell3.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalMoneyValue));
    cell3.PutValue(num3);
    Cell cell4 = this._wks.Cells[this._rowIndex, 3];
    cell4.SetStyle(this.GetStyle(cell4.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalMoneyValue));
    cell4.PutValue(num4);
    Cell cell5 = this._wks.Cells[this._rowIndex, 4];
    cell5.SetStyle(this.GetStyle(cell5.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalPctValue));
    cell5.PutValue(num11);
    Cell cell6 = this._wks.Cells[this._rowIndex, 5];
    cell6.SetStyle(this.GetStyle(cell6.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalMoneyValue));
    cell6.PutValue(num5);
    Cell cell7 = this._wks.Cells[this._rowIndex, 6];
    cell7.SetStyle(this.GetStyle(cell7.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalPctValue));
    cell7.PutValue(num12);
    Cell cell8 = this._wks.Cells[this._rowIndex, 8];
    cell8.SetStyle(this.GetStyle(cell8.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalPlain));
    cell8.PutValue("Profit/(Loss)");
    Cell cell9 = this._wks.Cells[this._rowIndex, 10];
    cell9.SetStyle(this.GetStyle(cell9.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalMoneyValue));
    cell9.PutValue(num6);
    Cell cell10 = this._wks.Cells[this._rowIndex, 11];
    cell10.SetStyle(this.GetStyle(cell10.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalMoneyValue));
    cell10.PutValue(num7);
    Cell cell11 = this._wks.Cells[this._rowIndex, 12];
    cell11.SetStyle(this.GetStyle(cell11.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalMoneyValue));
    cell11.PutValue(num8);
    Cell cell12 = this._wks.Cells[this._rowIndex, 13];
    cell12.SetStyle(this.GetStyle(cell12.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalMoneyValue));
    cell12.PutValue(num9);
    Cell cell13 = this._wks.Cells[this._rowIndex, 14];
    cell13.SetStyle(this.GetStyle(cell13.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalPctValue));
    cell13.PutValue(num13);
    Cell cell14 = this._wks.Cells[this._rowIndex, 15];
    cell14.SetStyle(this.GetStyle(cell14.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalMoneyValue));
    cell14.PutValue(num10);
    Cell cell15 = this._wks.Cells[this._rowIndex, 16 /*0x10*/];
    cell15.SetStyle(this.GetStyle(cell15.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalPctValue));
    cell15.PutValue(num14);
    ++this._rowIndex;
  }

  private void PrintPremiumsLine()
  {
    ++this._rowIndex;
    Cell cell1 = this._wks.Cells[this._rowIndex, 0];
    cell1.SetStyle(this.GetStyle(cell1.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsMoneyValue));
    cell1.PutValue(Decimal.Parse(this._ds.Tables[2].Rows[0]["CurrentMonth_PremActual"].ToString()));
    Cell cell2 = this._wks.Cells[this._rowIndex, 1];
    cell2.SetStyle(this.GetStyle(cell2.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsMoneyValue));
    cell2.PutValue(Decimal.Parse(this._ds.Tables[2].Rows[0]["CurrentMonth_PremBudget"].ToString()));
    Cell cell3 = this._wks.Cells[this._rowIndex, 2];
    cell3.SetStyle(this.GetStyle(cell3.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsMoneyValue));
    cell3.PutValue(Decimal.Parse(this._ds.Tables[2].Rows[0]["CurrentMonth_PremPYActual"].ToString()));
    Cell cell4 = this._wks.Cells[this._rowIndex, 3];
    cell4.SetStyle(this.GetStyle(cell4.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsMoneyValue));
    cell4.PutValue(Decimal.Parse(this._ds.Tables[2].Rows[0]["CurrentMonth_PremActVBudget"].ToString()));
    Cell cell5 = this._wks.Cells[this._rowIndex, 4];
    cell5.SetStyle(this.GetStyle(cell5.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsPctValue));
    cell5.PutValue(Decimal.Parse(this._ds.Tables[2].Rows[0]["CurrentMonth_PremActVBudgetPerct"].ToString()));
    Cell cell6 = this._wks.Cells[this._rowIndex, 5];
    cell6.SetStyle(this.GetStyle(cell6.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsMoneyValue));
    cell6.PutValue(Decimal.Parse(this._ds.Tables[2].Rows[0]["CurrentMonth_PremPYActVActual"].ToString()));
    Cell cell7 = this._wks.Cells[this._rowIndex, 6];
    cell7.SetStyle(this.GetStyle(cell7.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsPctValue));
    cell7.PutValue(Decimal.Parse(this._ds.Tables[2].Rows[0]["CurrentMonth_PremPYActVActualPerct"].ToString()));
    Cell cell8 = this._wks.Cells[this._rowIndex, 8];
    cell8.SetStyle(this.GetStyle(cell8.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsPlain));
    cell8.PutValue("Premiums");
    Cell cell9 = this._wks.Cells[this._rowIndex, 10];
    cell9.SetStyle(this.GetStyle(cell9.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsMoneyValue));
    cell9.PutValue(Decimal.Parse(this._ds.Tables[2].Rows[0]["YTD_PremActual"].ToString()));
    Cell cell10 = this._wks.Cells[this._rowIndex, 11];
    cell10.SetStyle(this.GetStyle(cell10.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsMoneyValue));
    cell10.PutValue(Decimal.Parse(this._ds.Tables[2].Rows[0]["YTD_PremBudget"].ToString()));
    Cell cell11 = this._wks.Cells[this._rowIndex, 12];
    cell11.SetStyle(this.GetStyle(cell11.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsMoneyValue));
    cell11.PutValue(Decimal.Parse(this._ds.Tables[2].Rows[0]["YTD_PremPYActual"].ToString()));
    Cell cell12 = this._wks.Cells[this._rowIndex, 13];
    cell12.SetStyle(this.GetStyle(cell12.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsMoneyValue));
    cell12.PutValue(Decimal.Parse(this._ds.Tables[2].Rows[0]["YTD_PremActVBudget"].ToString()));
    Cell cell13 = this._wks.Cells[this._rowIndex, 14];
    cell13.SetStyle(this.GetStyle(cell13.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsPctValue));
    cell13.PutValue(Decimal.Parse(this._ds.Tables[2].Rows[0]["YTD_PremActVBudgetPerct"].ToString()));
    Cell cell14 = this._wks.Cells[this._rowIndex, 15];
    cell14.SetStyle(this.GetStyle(cell14.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsMoneyValue));
    cell14.PutValue(Decimal.Parse(this._ds.Tables[2].Rows[0]["YTD_PremPYActVActual"].ToString()));
    Cell cell15 = this._wks.Cells[this._rowIndex, 16 /*0x10*/];
    cell15.SetStyle(this.GetStyle(cell15.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsPctValue));
    cell15.PutValue(Decimal.Parse(this._ds.Tables[2].Rows[0]["YTD_PremPYActVActualPerct"].ToString()));
    ++this._rowIndex;
  }

  private void PrintAcctClassName(string AcctClassName)
  {
    Cell cell = this._wks.Cells[this._rowIndex, 7];
    cell.SetStyle(this.GetStyle(cell.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotPlain));
    cell.PutValue(AcctClassName);
    ++this._rowIndex;
  }

  private void PrintAcctTypeDesc(string AcctTypeDescription)
  {
    Cell cell = this._wks.Cells[this._rowIndex, 8];
    cell.SetStyle(this.GetStyle(cell.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotPlain));
    cell.PutValue(AcctTypeDescription);
    ++this._rowIndex;
  }

  private void PrintReportHeaders()
  {
    this._wks.Cells.InsertRow(0);
    Cell cell1 = this._wks.Cells[0, 0];
    cell1.SetStyle(this.GetStyle(cell1.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader));
    cell1.PutValue("Actual");
    Cell cell2 = this._wks.Cells[0, 1];
    cell2.SetStyle(this.GetStyle(cell2.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader));
    cell2.PutValue("Budget");
    Cell cell3 = this._wks.Cells[0, 2];
    cell3.SetStyle(this.GetStyle(cell3.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader));
    cell3.PutValue("Prior Year");
    Cell cell4 = this._wks.Cells[0, 3];
    cell4.SetStyle(this.GetStyle(cell4.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader));
    cell4.PutValue("Act vs Bud");
    Cell cell5 = this._wks.Cells[0, 4];
    cell5.SetStyle(this.GetStyle(cell5.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader));
    cell5.PutValue("%");
    Cell cell6 = this._wks.Cells[0, 5];
    cell6.SetStyle(this.GetStyle(cell6.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader));
    cell6.PutValue("Act vs PY");
    Cell cell7 = this._wks.Cells[0, 6];
    cell7.SetStyle(this.GetStyle(cell7.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader));
    cell7.PutValue("%");
    Cell cell8 = this._wks.Cells[0, 10];
    cell8.SetStyle(this.GetStyle(cell8.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader));
    cell8.PutValue("Actual");
    Cell cell9 = this._wks.Cells[0, 11];
    cell9.SetStyle(this.GetStyle(cell9.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader));
    cell9.PutValue("Budget");
    Cell cell10 = this._wks.Cells[0, 12];
    cell10.SetStyle(this.GetStyle(cell10.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader));
    cell10.PutValue("Prior Year");
    Cell cell11 = this._wks.Cells[0, 13];
    cell11.SetStyle(this.GetStyle(cell11.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader));
    cell11.PutValue("Act vs Bud");
    Cell cell12 = this._wks.Cells[0, 14];
    cell12.SetStyle(this.GetStyle(cell12.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader));
    cell12.PutValue("%");
    Cell cell13 = this._wks.Cells[0, 15];
    cell13.SetStyle(this.GetStyle(cell13.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader));
    cell13.PutValue("Act vs PY");
    Cell cell14 = this._wks.Cells[0, 16 /*0x10*/];
    cell14.SetStyle(this.GetStyle(cell14.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader));
    cell14.PutValue("%");
    this._wks.Cells.InsertRow(0);
    Cell cell15 = this._wks.Cells[0, 3];
    cell15.SetStyle(this.GetStyle(cell15.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotPlain));
    cell15.PutValue("Current Month");
    Cell cell16 = this._wks.Cells[0, 13];
    cell16.SetStyle(this.GetStyle(cell16.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotPlain));
    cell16.PutValue(string.Format("{0:MMM d, yyyy} thru {1:MMM d, yyyy}", (object) this._dateFrom, (object) this._dateTo));
    this._wks.Cells.InsertRow(0);
    this._wks.Cells.InsertRow(0);
    Cell cell17 = this._wks.Cells[0, 0];
    cell17.SetStyle(this.GetStyle(cell17.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.DetailPlain));
    cell17.PutValue(this._ds.Tables[1].Rows[0]["PeriodEnding"].ToString());
    this._wks.Cells.InsertRow(0);
    Cell cell18 = this._wks.Cells[0, 0];
    cell18.SetStyle(this.GetStyle(cell18.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ReportHeader));
    cell18.PutValue("Consolidated Income Statement");
    this._wks.Cells.InsertRow(0);
    Cell cell19 = this._wks.Cells[0, 0];
    cell19.SetStyle(this.GetStyle(cell19.GetStyle(), rptConsolidatedIncomeStatementByBudget.FontStyle.ReportHeader));
    cell19.PutValue(this._ds.Tables[1].Rows[0]["ClientOfficeNamesComma"].ToString());
  }

  private Style GetStyle(
    Style style,
    rptConsolidatedIncomeStatementByBudget.FontStyle fontStyle)
  {
    switch (fontStyle)
    {
      case rptConsolidatedIncomeStatementByBudget.FontStyle.ReportHeader:
        style.Font.IsBold = true;
        style.Font.Size = 12;
        style.Font.Name = "Arial";
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.ColumnHeader:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.HorizontalAlignment = (TextAlignmentType) 1;
        style.Borders[(BorderType) 4].Color = Color.Black;
        style.Borders[(BorderType) 4].LineStyle = (CellBorderType) 1;
        style.Borders[(BorderType) 8].Color = Color.Black;
        style.Borders[(BorderType) 8].LineStyle = (CellBorderType) 1;
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalPlain:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalMoneyValue:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.Number = 3;
        style.Borders[(BorderType) 4].Color = Color.Black;
        style.Borders[(BorderType) 4].LineStyle = (CellBorderType) 1;
        style.Borders[(BorderType) 8].Color = Color.Black;
        style.Borders[(BorderType) 8].LineStyle = (CellBorderType) 6;
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.GrandTotalPctValue:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.Number = 9;
        style.Borders[(BorderType) 4].Color = Color.Black;
        style.Borders[(BorderType) 4].LineStyle = (CellBorderType) 1;
        style.Borders[(BorderType) 8].Color = Color.Black;
        style.Borders[(BorderType) 8].LineStyle = (CellBorderType) 6;
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotPlain:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotMoneyValue:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.Number = 3;
        style.Borders[(BorderType) 4].Color = Color.Black;
        style.Borders[(BorderType) 4].LineStyle = (CellBorderType) 1;
        style.Borders[(BorderType) 8].Color = Color.Black;
        style.Borders[(BorderType) 8].LineStyle = (CellBorderType) 1;
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.AcctClassSubtotPctValue:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.Number = 9;
        style.Borders[(BorderType) 4].Color = Color.Black;
        style.Borders[(BorderType) 4].LineStyle = (CellBorderType) 1;
        style.Borders[(BorderType) 8].Color = Color.Black;
        style.Borders[(BorderType) 8].LineStyle = (CellBorderType) 1;
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotPlain:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotMoneyValue:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.Number = 3;
        style.Borders[(BorderType) 4].Color = Color.Black;
        style.Borders[(BorderType) 4].LineStyle = (CellBorderType) 1;
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.AcctTypeSubtotPctValue:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.Number = 9;
        style.Borders[(BorderType) 4].Color = Color.Black;
        style.Borders[(BorderType) 4].LineStyle = (CellBorderType) 1;
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.DetailPlain:
        style.Font.IsBold = false;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.DetailMoneyValue:
        style.Font.IsBold = false;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.Number = 3;
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.DetailPctValue:
        style.Font.IsBold = false;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.Number = 9;
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.PercentOfIncome:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.Number = 9;
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsPlain:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsMoneyValue:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.Number = 3;
        break;
      case rptConsolidatedIncomeStatementByBudget.FontStyle.PremiumsPctValue:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.Number = 9;
        break;
    }
    return style;
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptConsolidatedIncomeStatementByBudget));
    this.detail = new Detail();
    this.textBox1 = new TextBox();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.textBox6 = new TextBox();
    this.textBox7 = new TextBox();
    this.textBox8 = new TextBox();
    this.textBox9 = new TextBox();
    this.textBox10 = new TextBox();
    this.textBox11 = new TextBox();
    this.textBox12 = new TextBox();
    this.textBox13 = new TextBox();
    this.textBox14 = new TextBox();
    this.textBox15 = new TextBox();
    this.reportHeader1 = new ReportHeader();
    this.reportFooter1 = new ReportFooter();
    this.txtRfCurrentMonth_ActualAmount = new TextBox();
    this.txtRfCurrentMonth_Budget = new TextBox();
    this.txtRfCurrentMonth_PYActual = new TextBox();
    this.txtRfCurrentMonth_ActVBudget = new TextBox();
    this.txtRfCurrentMonth_ActVBudgetPerct = new TextBox();
    this.txtRfCurrentMonth_PYActVActual = new TextBox();
    this.txtRfCurrentMonth_PYActVActualPerct = new TextBox();
    this.txtRfYTD_Actual = new TextBox();
    this.txtRfYTD_Budget = new TextBox();
    this.txtRfYTD_PYActual = new TextBox();
    this.txtRfYTD_ActVBudget = new TextBox();
    this.txtRfYTD_ActVBudgetPerct = new TextBox();
    this.txtRfYTD_PYActVActual = new TextBox();
    this.txtRfYTD_PYActVActualPerct = new TextBox();
    this.textBox65 = new TextBox();
    this.txtRF_CurrentMonth_PremActual = new TextBox();
    this.txtRF_CurrentMonth_PremBudget = new TextBox();
    this.txtRF_CurrentMonth_PremPYActual = new TextBox();
    this.txtRF_CurrentMonth_PremActVBudget = new TextBox();
    this.txtRF_CurrentMonth_PremActVBudgetPerct = new TextBox();
    this.txtRF_CurrentMonth_PremPYActVActual = new TextBox();
    this.txtRF_CurrentMonth_PremPYActVActualPerct = new TextBox();
    this.txtRF_YTD_PremActual = new TextBox();
    this.txtRF_YTD_PremBudget = new TextBox();
    this.txtRF_YTD_PremPYActual = new TextBox();
    this.txtRF_YTD_PremActVBudget = new TextBox();
    this.txtRF_YTD_PremActVBudgetPerct = new TextBox();
    this.txtRF_YTD_PremPYActVActual = new TextBox();
    this.txtRF_YTD_PremPYActVActualPerct = new TextBox();
    this.textBox42 = new TextBox();
    this.ghAcctClass = new GroupHeader();
    this.txtGhAcctClassName = new TextBox();
    this.gfAcctClass = new GroupFooter();
    this.txtGfACCurrentMonth_ActualAmount = new TextBox();
    this.txtGfACCurrentMonth_Budget = new TextBox();
    this.txtGfACCurrentMonth_PYActual = new TextBox();
    this.textBox37 = new TextBox();
    this.txtGfACCurrentMonth_ActVBudgetPerct = new TextBox();
    this.textBox39 = new TextBox();
    this.txtGfACCurrentMonth_PYActVActualPerct = new TextBox();
    this.txtGfACYTD_Actual = new TextBox();
    this.txtGfACYTD_Budget = new TextBox();
    this.txtGfACYTD_PYActual = new TextBox();
    this.textBox44 = new TextBox();
    this.txtGfACYTD_ActVBudgetPerct = new TextBox();
    this.textBox46 = new TextBox();
    this.txtGfACYTD_PYActVActualPerct = new TextBox();
    this.textBox48 = new TextBox();
    this.textBox49 = new TextBox();
    this.ghAcctType = new GroupHeader();
    this.textBox16 = new TextBox();
    this.gfAcctType = new GroupFooter();
    this.txtGfATCurrentMonth_ActualAmount = new TextBox();
    this.txtGfATCurrentMonth_Budget = new TextBox();
    this.txtGfATCurrentMonth_PYActual = new TextBox();
    this.textBox21 = new TextBox();
    this.txtGfATCurrentMonth_ActVBudgetPerct = new TextBox();
    this.textBox23 = new TextBox();
    this.txtGfATCurrentMonth_PYActVActualPerct = new TextBox();
    this.txtGfATYTD_Actual = new TextBox();
    this.txtGfATYTD_Budget = new TextBox();
    this.txtGfATYTD_PYActual = new TextBox();
    this.textBox29 = new TextBox();
    this.txtGfATYTD_ActVBudgetPerct = new TextBox();
    this.textBox31 = new TextBox();
    this.txtGfATYTD_PYActVActualPerct = new TextBox();
    this.textBox25 = new TextBox();
    this.textBox33 = new TextBox();
    this.pageHeader1 = new PageHeader();
    this.label2 = new Label();
    this.labPeriodEnding = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label9 = new Label();
    this.label10 = new Label();
    this.label11 = new Label();
    this.label12 = new Label();
    this.label13 = new Label();
    this.label14 = new Label();
    this.label15 = new Label();
    this.label16 = new Label();
    this.label17 = new Label();
    this.label18 = new Label();
    this.label1 = new Label();
    this.labPHRunDateRange = new Label();
    this.txtClientOfficeNames = new TextBox();
    this.pageFooter1 = new PageFooter();
    this.ghAcctTypePct = new GroupHeader();
    this.gfAcctTypePct = new GroupFooter();
    this.txtGfAcctTypePct_CM_ActualPct = new TextBox();
    this.textBox19 = new TextBox();
    this.txtGfAcctTypePct_CM_BudgetPct = new TextBox();
    this.txtGfAcctTypePct_CM_PriorYearPct = new TextBox();
    this.txtGfAcctTypePct_YTD_ActualPct = new TextBox();
    this.txtGfAcctTypePct_YTD_BudgetPct = new TextBox();
    this.txtGfAcctTypePct_YTD_PriorYearPct = new TextBox();
    this.ghAcctClassPct = new GroupHeader();
    this.gfAcctClassPct = new GroupFooter();
    this.txtGfAcctClassPct_CM_ActualPct = new TextBox();
    this.textBox20 = new TextBox();
    this.txtGfAcctClassPct_CM_BudgetPct = new TextBox();
    this.txtGfAcctClassPct_CM_PriorYearPct = new TextBox();
    this.txtGfAcctClassPct_YTD_ActualPct = new TextBox();
    this.txtGfAcctClassPct_YTD_BudgetPct = new TextBox();
    this.txtGfAcctClassPct_YTD_PriorYearPct = new TextBox();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((ISupportInitialize) this.textBox10).BeginInit();
    ((ISupportInitialize) this.textBox11).BeginInit();
    ((ISupportInitialize) this.textBox12).BeginInit();
    ((ISupportInitialize) this.textBox13).BeginInit();
    ((ISupportInitialize) this.textBox14).BeginInit();
    ((ISupportInitialize) this.textBox15).BeginInit();
    ((ISupportInitialize) this.txtRfCurrentMonth_ActualAmount).BeginInit();
    ((ISupportInitialize) this.txtRfCurrentMonth_Budget).BeginInit();
    ((ISupportInitialize) this.txtRfCurrentMonth_PYActual).BeginInit();
    ((ISupportInitialize) this.txtRfCurrentMonth_ActVBudget).BeginInit();
    ((ISupportInitialize) this.txtRfCurrentMonth_ActVBudgetPerct).BeginInit();
    ((ISupportInitialize) this.txtRfCurrentMonth_PYActVActual).BeginInit();
    ((ISupportInitialize) this.txtRfCurrentMonth_PYActVActualPerct).BeginInit();
    ((ISupportInitialize) this.txtRfYTD_Actual).BeginInit();
    ((ISupportInitialize) this.txtRfYTD_Budget).BeginInit();
    ((ISupportInitialize) this.txtRfYTD_PYActual).BeginInit();
    ((ISupportInitialize) this.txtRfYTD_ActVBudget).BeginInit();
    ((ISupportInitialize) this.txtRfYTD_ActVBudgetPerct).BeginInit();
    ((ISupportInitialize) this.txtRfYTD_PYActVActual).BeginInit();
    ((ISupportInitialize) this.txtRfYTD_PYActVActualPerct).BeginInit();
    ((ISupportInitialize) this.textBox65).BeginInit();
    ((ISupportInitialize) this.txtRF_CurrentMonth_PremActual).BeginInit();
    ((ISupportInitialize) this.txtRF_CurrentMonth_PremBudget).BeginInit();
    ((ISupportInitialize) this.txtRF_CurrentMonth_PremPYActual).BeginInit();
    ((ISupportInitialize) this.txtRF_CurrentMonth_PremActVBudget).BeginInit();
    ((ISupportInitialize) this.txtRF_CurrentMonth_PremActVBudgetPerct).BeginInit();
    ((ISupportInitialize) this.txtRF_CurrentMonth_PremPYActVActual).BeginInit();
    ((ISupportInitialize) this.txtRF_CurrentMonth_PremPYActVActualPerct).BeginInit();
    ((ISupportInitialize) this.txtRF_YTD_PremActual).BeginInit();
    ((ISupportInitialize) this.txtRF_YTD_PremBudget).BeginInit();
    ((ISupportInitialize) this.txtRF_YTD_PremPYActual).BeginInit();
    ((ISupportInitialize) this.txtRF_YTD_PremActVBudget).BeginInit();
    ((ISupportInitialize) this.txtRF_YTD_PremActVBudgetPerct).BeginInit();
    ((ISupportInitialize) this.txtRF_YTD_PremPYActVActual).BeginInit();
    ((ISupportInitialize) this.txtRF_YTD_PremPYActVActualPerct).BeginInit();
    ((ISupportInitialize) this.textBox42).BeginInit();
    ((ISupportInitialize) this.txtGhAcctClassName).BeginInit();
    ((ISupportInitialize) this.txtGfACCurrentMonth_ActualAmount).BeginInit();
    ((ISupportInitialize) this.txtGfACCurrentMonth_Budget).BeginInit();
    ((ISupportInitialize) this.txtGfACCurrentMonth_PYActual).BeginInit();
    ((ISupportInitialize) this.textBox37).BeginInit();
    ((ISupportInitialize) this.txtGfACCurrentMonth_ActVBudgetPerct).BeginInit();
    ((ISupportInitialize) this.textBox39).BeginInit();
    ((ISupportInitialize) this.txtGfACCurrentMonth_PYActVActualPerct).BeginInit();
    ((ISupportInitialize) this.txtGfACYTD_Actual).BeginInit();
    ((ISupportInitialize) this.txtGfACYTD_Budget).BeginInit();
    ((ISupportInitialize) this.txtGfACYTD_PYActual).BeginInit();
    ((ISupportInitialize) this.textBox44).BeginInit();
    ((ISupportInitialize) this.txtGfACYTD_ActVBudgetPerct).BeginInit();
    ((ISupportInitialize) this.textBox46).BeginInit();
    ((ISupportInitialize) this.txtGfACYTD_PYActVActualPerct).BeginInit();
    ((ISupportInitialize) this.textBox48).BeginInit();
    ((ISupportInitialize) this.textBox49).BeginInit();
    ((ISupportInitialize) this.textBox16).BeginInit();
    ((ISupportInitialize) this.txtGfATCurrentMonth_ActualAmount).BeginInit();
    ((ISupportInitialize) this.txtGfATCurrentMonth_Budget).BeginInit();
    ((ISupportInitialize) this.txtGfATCurrentMonth_PYActual).BeginInit();
    ((ISupportInitialize) this.textBox21).BeginInit();
    ((ISupportInitialize) this.txtGfATCurrentMonth_ActVBudgetPerct).BeginInit();
    ((ISupportInitialize) this.textBox23).BeginInit();
    ((ISupportInitialize) this.txtGfATCurrentMonth_PYActVActualPerct).BeginInit();
    ((ISupportInitialize) this.txtGfATYTD_Actual).BeginInit();
    ((ISupportInitialize) this.txtGfATYTD_Budget).BeginInit();
    ((ISupportInitialize) this.txtGfATYTD_PYActual).BeginInit();
    ((ISupportInitialize) this.textBox29).BeginInit();
    ((ISupportInitialize) this.txtGfATYTD_ActVBudgetPerct).BeginInit();
    ((ISupportInitialize) this.textBox31).BeginInit();
    ((ISupportInitialize) this.txtGfATYTD_PYActVActualPerct).BeginInit();
    ((ISupportInitialize) this.textBox25).BeginInit();
    ((ISupportInitialize) this.textBox33).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.labPeriodEnding).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.label9).BeginInit();
    ((ISupportInitialize) this.label10).BeginInit();
    ((ISupportInitialize) this.label11).BeginInit();
    ((ISupportInitialize) this.label12).BeginInit();
    ((ISupportInitialize) this.label13).BeginInit();
    ((ISupportInitialize) this.label14).BeginInit();
    ((ISupportInitialize) this.label15).BeginInit();
    ((ISupportInitialize) this.label16).BeginInit();
    ((ISupportInitialize) this.label17).BeginInit();
    ((ISupportInitialize) this.label18).BeginInit();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.labPHRunDateRange).BeginInit();
    ((ISupportInitialize) this.txtClientOfficeNames).BeginInit();
    ((ISupportInitialize) this.txtGfAcctTypePct_CM_ActualPct).BeginInit();
    ((ISupportInitialize) this.textBox19).BeginInit();
    ((ISupportInitialize) this.txtGfAcctTypePct_CM_BudgetPct).BeginInit();
    ((ISupportInitialize) this.txtGfAcctTypePct_CM_PriorYearPct).BeginInit();
    ((ISupportInitialize) this.txtGfAcctTypePct_YTD_ActualPct).BeginInit();
    ((ISupportInitialize) this.txtGfAcctTypePct_YTD_BudgetPct).BeginInit();
    ((ISupportInitialize) this.txtGfAcctTypePct_YTD_PriorYearPct).BeginInit();
    ((ISupportInitialize) this.txtGfAcctClassPct_CM_ActualPct).BeginInit();
    ((ISupportInitialize) this.textBox20).BeginInit();
    ((ISupportInitialize) this.txtGfAcctClassPct_CM_BudgetPct).BeginInit();
    ((ISupportInitialize) this.txtGfAcctClassPct_CM_PriorYearPct).BeginInit();
    ((ISupportInitialize) this.txtGfAcctClassPct_YTD_ActualPct).BeginInit();
    ((ISupportInitialize) this.txtGfAcctClassPct_YTD_BudgetPct).BeginInit();
    ((ISupportInitialize) this.txtGfAcctClassPct_YTD_PriorYearPct).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Controls.AddRange(new ARControl[15]
    {
      (ARControl) this.textBox1,
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5,
      (ARControl) this.textBox6,
      (ARControl) this.textBox7,
      (ARControl) this.textBox8,
      (ARControl) this.textBox9,
      (ARControl) this.textBox10,
      (ARControl) this.textBox11,
      (ARControl) this.textBox12,
      (ARControl) this.textBox13,
      (ARControl) this.textBox14,
      (ARControl) this.textBox15
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 0.2083333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((ARControl) this.textBox1).DataField = "CurrentMonth_ActualAmount";
    ((ARControl) this.textBox1).Height = 0.1979167f;
    ((ARControl) this.textBox1).Left = 0.0f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.OutputFormat = resourceManager.GetString("textBox1.OutputFormat");
    this.textBox1.Style = "font-size: 7pt; text-align: right";
    this.textBox1.Text = (string) null;
    ((ARControl) this.textBox1).Top = 0.0f;
    ((ARControl) this.textBox1).Width = 0.563f;
    ((ARControl) this.textBox2).DataField = "CurrentMonth_Budget";
    ((ARControl) this.textBox2).Height = 0.1979167f;
    ((ARControl) this.textBox2).Left = 9f / 16f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.OutputFormat = resourceManager.GetString("textBox2.OutputFormat");
    this.textBox2.Style = "font-size: 7pt; text-align: right";
    this.textBox2.Text = (string) null;
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 0.563f;
    ((ARControl) this.textBox3).DataField = "CurrentMonth_PYActual";
    ((ARControl) this.textBox3).Height = 0.1979167f;
    ((ARControl) this.textBox3).Left = 1.125f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.OutputFormat = resourceManager.GetString("textBox3.OutputFormat");
    this.textBox3.Style = "font-size: 7pt; text-align: right";
    this.textBox3.Text = (string) null;
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 0.563f;
    ((ARControl) this.textBox4).DataField = "CurrentMonth_ActVBudget";
    ((ARControl) this.textBox4).Height = 0.1979167f;
    ((ARControl) this.textBox4).Left = 27f / 16f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.OutputFormat = resourceManager.GetString("textBox4.OutputFormat");
    this.textBox4.Style = "font-size: 7pt; text-align: right";
    this.textBox4.Text = (string) null;
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 0.563f;
    ((ARControl) this.textBox5).DataField = "CurrentMonth_ActVBudgetPerct";
    ((ARControl) this.textBox5).Height = 3f / 16f;
    ((ARControl) this.textBox5).Left = 2.25f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.OutputFormat = resourceManager.GetString("textBox5.OutputFormat");
    this.textBox5.Style = "font-size: 7pt; text-align: right";
    this.textBox5.Text = (string) null;
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 0.5f;
    ((ARControl) this.textBox6).DataField = "CurrentMonth_PYActVActual";
    ((ARControl) this.textBox6).Height = 0.1979167f;
    ((ARControl) this.textBox6).Left = 2.75f;
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.OutputFormat = resourceManager.GetString("textBox6.OutputFormat");
    this.textBox6.Style = "font-size: 7pt; text-align: right";
    this.textBox6.Text = (string) null;
    ((ARControl) this.textBox6).Top = 0.0f;
    ((ARControl) this.textBox6).Width = 0.563f;
    ((ARControl) this.textBox7).DataField = "CurrentMonth_PYActVActualPerct";
    ((ARControl) this.textBox7).Height = 3f / 16f;
    ((ARControl) this.textBox7).Left = 53f / 16f;
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.OutputFormat = resourceManager.GetString("textBox7.OutputFormat");
    this.textBox7.Style = "font-size: 7pt; text-align: right";
    this.textBox7.Text = (string) null;
    ((ARControl) this.textBox7).Top = 0.0f;
    ((ARControl) this.textBox7).Width = 0.5f;
    ((ARControl) this.textBox8).DataField = "FullName";
    ((ARControl) this.textBox8).Height = 3f / 16f;
    ((ARControl) this.textBox8).Left = 67f / 16f;
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.OutputFormat = resourceManager.GetString("textBox8.OutputFormat");
    this.textBox8.Style = "font-size: 7pt; text-align: left";
    this.textBox8.Text = (string) null;
    ((ARControl) this.textBox8).Top = 0.0f;
    ((ARControl) this.textBox8).Width = 37f / 16f;
    ((ARControl) this.textBox9).DataField = "YTD_Actual";
    ((ARControl) this.textBox9).Height = 0.1979167f;
    ((ARControl) this.textBox9).Left = 105f / 16f;
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.OutputFormat = resourceManager.GetString("textBox9.OutputFormat");
    this.textBox9.Style = "font-size: 7pt; text-align: right";
    this.textBox9.Text = (string) null;
    ((ARControl) this.textBox9).Top = 0.0f;
    ((ARControl) this.textBox9).Width = 0.563f;
    ((ARControl) this.textBox10).DataField = "YTD_Budget";
    ((ARControl) this.textBox10).Height = 0.1979167f;
    ((ARControl) this.textBox10).Left = 7.125f;
    ((ARControl) this.textBox10).Name = "textBox10";
    this.textBox10.OutputFormat = resourceManager.GetString("textBox10.OutputFormat");
    this.textBox10.Style = "font-size: 7pt; text-align: right";
    this.textBox10.Text = (string) null;
    ((ARControl) this.textBox10).Top = 0.0f;
    ((ARControl) this.textBox10).Width = 0.563f;
    ((ARControl) this.textBox11).DataField = "YTD_PYActual";
    ((ARControl) this.textBox11).Height = 0.1979167f;
    ((ARControl) this.textBox11).Left = 123f / 16f;
    ((ARControl) this.textBox11).Name = "textBox11";
    this.textBox11.OutputFormat = resourceManager.GetString("textBox11.OutputFormat");
    this.textBox11.Style = "font-size: 7pt; text-align: right";
    this.textBox11.Text = (string) null;
    ((ARControl) this.textBox11).Top = 0.0f;
    ((ARControl) this.textBox11).Width = 0.563f;
    ((ARControl) this.textBox12).DataField = "YTD_ActVBudget";
    ((ARControl) this.textBox12).Height = 0.1979167f;
    ((ARControl) this.textBox12).Left = 8.25f;
    ((ARControl) this.textBox12).Name = "textBox12";
    this.textBox12.OutputFormat = resourceManager.GetString("textBox12.OutputFormat");
    this.textBox12.Style = "font-size: 7pt; text-align: right";
    this.textBox12.Text = (string) null;
    ((ARControl) this.textBox12).Top = 0.0f;
    ((ARControl) this.textBox12).Width = 0.563f;
    ((ARControl) this.textBox13).DataField = "YTD_ActVBudgetPerct";
    ((ARControl) this.textBox13).Height = 3f / 16f;
    ((ARControl) this.textBox13).Left = 141f / 16f;
    ((ARControl) this.textBox13).Name = "textBox13";
    this.textBox13.OutputFormat = resourceManager.GetString("textBox13.OutputFormat");
    this.textBox13.Style = "font-size: 7pt; text-align: right";
    this.textBox13.Text = (string) null;
    ((ARControl) this.textBox13).Top = 0.0f;
    ((ARControl) this.textBox13).Width = 0.5f;
    ((ARControl) this.textBox14).DataField = "YTD_PYActVActual";
    ((ARControl) this.textBox14).Height = 0.1979167f;
    ((ARControl) this.textBox14).Left = 149f / 16f;
    ((ARControl) this.textBox14).Name = "textBox14";
    this.textBox14.OutputFormat = resourceManager.GetString("textBox14.OutputFormat");
    this.textBox14.Style = "font-size: 7pt; text-align: right";
    this.textBox14.Text = (string) null;
    ((ARControl) this.textBox14).Top = 0.0f;
    ((ARControl) this.textBox14).Width = 0.563f;
    ((ARControl) this.textBox15).DataField = "YTD_PYActVActualPerct";
    ((ARControl) this.textBox15).Height = 3f / 16f;
    ((ARControl) this.textBox15).Left = 9.875f;
    ((ARControl) this.textBox15).Name = "textBox15";
    this.textBox15.OutputFormat = resourceManager.GetString("textBox15.OutputFormat");
    this.textBox15.Style = "font-size: 7pt; text-align: right";
    this.textBox15.Text = (string) null;
    ((ARControl) this.textBox15).Top = 0.0f;
    ((ARControl) this.textBox15).Width = 0.5f;
    this.reportHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Name = "reportHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Format += new EventHandler(this.reportHeader1_Format);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Controls.AddRange(new ARControl[30]
    {
      (ARControl) this.txtRfCurrentMonth_ActualAmount,
      (ARControl) this.txtRfCurrentMonth_Budget,
      (ARControl) this.txtRfCurrentMonth_PYActual,
      (ARControl) this.txtRfCurrentMonth_ActVBudget,
      (ARControl) this.txtRfCurrentMonth_ActVBudgetPerct,
      (ARControl) this.txtRfCurrentMonth_PYActVActual,
      (ARControl) this.txtRfCurrentMonth_PYActVActualPerct,
      (ARControl) this.txtRfYTD_Actual,
      (ARControl) this.txtRfYTD_Budget,
      (ARControl) this.txtRfYTD_PYActual,
      (ARControl) this.txtRfYTD_ActVBudget,
      (ARControl) this.txtRfYTD_ActVBudgetPerct,
      (ARControl) this.txtRfYTD_PYActVActual,
      (ARControl) this.txtRfYTD_PYActVActualPerct,
      (ARControl) this.textBox65,
      (ARControl) this.txtRF_CurrentMonth_PremActual,
      (ARControl) this.txtRF_CurrentMonth_PremBudget,
      (ARControl) this.txtRF_CurrentMonth_PremPYActual,
      (ARControl) this.txtRF_CurrentMonth_PremActVBudget,
      (ARControl) this.txtRF_CurrentMonth_PremActVBudgetPerct,
      (ARControl) this.txtRF_CurrentMonth_PremPYActVActual,
      (ARControl) this.txtRF_CurrentMonth_PremPYActVActualPerct,
      (ARControl) this.txtRF_YTD_PremActual,
      (ARControl) this.txtRF_YTD_PremBudget,
      (ARControl) this.txtRF_YTD_PremPYActual,
      (ARControl) this.txtRF_YTD_PremActVBudget,
      (ARControl) this.txtRF_YTD_PremActVBudgetPerct,
      (ARControl) this.txtRF_YTD_PremPYActVActual,
      (ARControl) this.txtRF_YTD_PremPYActVActualPerct,
      (ARControl) this.textBox42
    });
    this.reportFooter1.Height = 0.5520833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Name = "reportFooter1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Format += new EventHandler(this.reportFooter1_Format);
    ((ARControl) this.txtRfCurrentMonth_ActualAmount).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtRfCurrentMonth_ActualAmount).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRfCurrentMonth_ActualAmount).Height = 0.1979167f;
    ((ARControl) this.txtRfCurrentMonth_ActualAmount).Left = 0.0f;
    ((ARControl) this.txtRfCurrentMonth_ActualAmount).Name = "txtRfCurrentMonth_ActualAmount";
    this.txtRfCurrentMonth_ActualAmount.OutputFormat = resourceManager.GetString("txtRfCurrentMonth_ActualAmount.OutputFormat");
    this.txtRfCurrentMonth_ActualAmount.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRfCurrentMonth_ActualAmount.Text = (string) null;
    ((ARControl) this.txtRfCurrentMonth_ActualAmount).Top = 0.0f;
    ((ARControl) this.txtRfCurrentMonth_ActualAmount).Width = 0.563f;
    ((ARControl) this.txtRfCurrentMonth_Budget).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtRfCurrentMonth_Budget).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRfCurrentMonth_Budget).Height = 0.1979167f;
    ((ARControl) this.txtRfCurrentMonth_Budget).Left = 9f / 16f;
    ((ARControl) this.txtRfCurrentMonth_Budget).Name = "txtRfCurrentMonth_Budget";
    this.txtRfCurrentMonth_Budget.OutputFormat = resourceManager.GetString("txtRfCurrentMonth_Budget.OutputFormat");
    this.txtRfCurrentMonth_Budget.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRfCurrentMonth_Budget.Text = (string) null;
    ((ARControl) this.txtRfCurrentMonth_Budget).Top = 0.0f;
    ((ARControl) this.txtRfCurrentMonth_Budget).Width = 0.563f;
    ((ARControl) this.txtRfCurrentMonth_PYActual).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtRfCurrentMonth_PYActual).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRfCurrentMonth_PYActual).Height = 0.1979167f;
    ((ARControl) this.txtRfCurrentMonth_PYActual).Left = 1.125f;
    ((ARControl) this.txtRfCurrentMonth_PYActual).Name = "txtRfCurrentMonth_PYActual";
    this.txtRfCurrentMonth_PYActual.OutputFormat = resourceManager.GetString("txtRfCurrentMonth_PYActual.OutputFormat");
    this.txtRfCurrentMonth_PYActual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRfCurrentMonth_PYActual.Text = (string) null;
    ((ARControl) this.txtRfCurrentMonth_PYActual).Top = 0.0f;
    ((ARControl) this.txtRfCurrentMonth_PYActual).Width = 0.563f;
    ((ARControl) this.txtRfCurrentMonth_ActVBudget).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtRfCurrentMonth_ActVBudget).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRfCurrentMonth_ActVBudget).Height = 0.1979167f;
    ((ARControl) this.txtRfCurrentMonth_ActVBudget).Left = 27f / 16f;
    ((ARControl) this.txtRfCurrentMonth_ActVBudget).Name = "txtRfCurrentMonth_ActVBudget";
    this.txtRfCurrentMonth_ActVBudget.OutputFormat = resourceManager.GetString("txtRfCurrentMonth_ActVBudget.OutputFormat");
    this.txtRfCurrentMonth_ActVBudget.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRfCurrentMonth_ActVBudget.Text = (string) null;
    ((ARControl) this.txtRfCurrentMonth_ActVBudget).Top = 0.0f;
    ((ARControl) this.txtRfCurrentMonth_ActVBudget).Width = 0.563f;
    ((ARControl) this.txtRfCurrentMonth_ActVBudgetPerct).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtRfCurrentMonth_ActVBudgetPerct).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRfCurrentMonth_ActVBudgetPerct).Height = 0.2f;
    ((ARControl) this.txtRfCurrentMonth_ActVBudgetPerct).Left = 2.25f;
    ((ARControl) this.txtRfCurrentMonth_ActVBudgetPerct).Name = "txtRfCurrentMonth_ActVBudgetPerct";
    this.txtRfCurrentMonth_ActVBudgetPerct.OutputFormat = resourceManager.GetString("txtRfCurrentMonth_ActVBudgetPerct.OutputFormat");
    this.txtRfCurrentMonth_ActVBudgetPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRfCurrentMonth_ActVBudgetPerct.Text = (string) null;
    ((ARControl) this.txtRfCurrentMonth_ActVBudgetPerct).Top = 0.0f;
    ((ARControl) this.txtRfCurrentMonth_ActVBudgetPerct).Width = 0.5f;
    ((ARControl) this.txtRfCurrentMonth_PYActVActual).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtRfCurrentMonth_PYActVActual).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRfCurrentMonth_PYActVActual).Height = 0.1979167f;
    ((ARControl) this.txtRfCurrentMonth_PYActVActual).Left = 2.75f;
    ((ARControl) this.txtRfCurrentMonth_PYActVActual).Name = "txtRfCurrentMonth_PYActVActual";
    this.txtRfCurrentMonth_PYActVActual.OutputFormat = resourceManager.GetString("txtRfCurrentMonth_PYActVActual.OutputFormat");
    this.txtRfCurrentMonth_PYActVActual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRfCurrentMonth_PYActVActual.Text = (string) null;
    ((ARControl) this.txtRfCurrentMonth_PYActVActual).Top = 0.0f;
    ((ARControl) this.txtRfCurrentMonth_PYActVActual).Width = 0.563f;
    ((ARControl) this.txtRfCurrentMonth_PYActVActualPerct).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtRfCurrentMonth_PYActVActualPerct).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRfCurrentMonth_PYActVActualPerct).Height = 0.2f;
    ((ARControl) this.txtRfCurrentMonth_PYActVActualPerct).Left = 53f / 16f;
    ((ARControl) this.txtRfCurrentMonth_PYActVActualPerct).Name = "txtRfCurrentMonth_PYActVActualPerct";
    this.txtRfCurrentMonth_PYActVActualPerct.OutputFormat = resourceManager.GetString("txtRfCurrentMonth_PYActVActualPerct.OutputFormat");
    this.txtRfCurrentMonth_PYActVActualPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRfCurrentMonth_PYActVActualPerct.Text = (string) null;
    ((ARControl) this.txtRfCurrentMonth_PYActVActualPerct).Top = 0.0f;
    ((ARControl) this.txtRfCurrentMonth_PYActVActualPerct).Width = 0.5f;
    ((ARControl) this.txtRfYTD_Actual).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtRfYTD_Actual).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRfYTD_Actual).Height = 0.1979167f;
    ((ARControl) this.txtRfYTD_Actual).Left = 105f / 16f;
    ((ARControl) this.txtRfYTD_Actual).Name = "txtRfYTD_Actual";
    this.txtRfYTD_Actual.OutputFormat = resourceManager.GetString("txtRfYTD_Actual.OutputFormat");
    this.txtRfYTD_Actual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRfYTD_Actual.Text = (string) null;
    ((ARControl) this.txtRfYTD_Actual).Top = 0.0f;
    ((ARControl) this.txtRfYTD_Actual).Width = 0.563f;
    ((ARControl) this.txtRfYTD_Budget).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtRfYTD_Budget).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRfYTD_Budget).Height = 0.1979167f;
    ((ARControl) this.txtRfYTD_Budget).Left = 7.125f;
    ((ARControl) this.txtRfYTD_Budget).Name = "txtRfYTD_Budget";
    this.txtRfYTD_Budget.OutputFormat = resourceManager.GetString("txtRfYTD_Budget.OutputFormat");
    this.txtRfYTD_Budget.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRfYTD_Budget.Text = (string) null;
    ((ARControl) this.txtRfYTD_Budget).Top = 0.0f;
    ((ARControl) this.txtRfYTD_Budget).Width = 0.563f;
    ((ARControl) this.txtRfYTD_PYActual).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtRfYTD_PYActual).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRfYTD_PYActual).Height = 0.1979167f;
    ((ARControl) this.txtRfYTD_PYActual).Left = 123f / 16f;
    ((ARControl) this.txtRfYTD_PYActual).Name = "txtRfYTD_PYActual";
    this.txtRfYTD_PYActual.OutputFormat = resourceManager.GetString("txtRfYTD_PYActual.OutputFormat");
    this.txtRfYTD_PYActual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRfYTD_PYActual.Text = (string) null;
    ((ARControl) this.txtRfYTD_PYActual).Top = 0.0f;
    ((ARControl) this.txtRfYTD_PYActual).Width = 0.563f;
    ((ARControl) this.txtRfYTD_ActVBudget).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtRfYTD_ActVBudget).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRfYTD_ActVBudget).Height = 0.1979167f;
    ((ARControl) this.txtRfYTD_ActVBudget).Left = 8.25f;
    ((ARControl) this.txtRfYTD_ActVBudget).Name = "txtRfYTD_ActVBudget";
    this.txtRfYTD_ActVBudget.OutputFormat = resourceManager.GetString("txtRfYTD_ActVBudget.OutputFormat");
    this.txtRfYTD_ActVBudget.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRfYTD_ActVBudget.Text = (string) null;
    ((ARControl) this.txtRfYTD_ActVBudget).Top = 0.0f;
    ((ARControl) this.txtRfYTD_ActVBudget).Width = 0.563f;
    ((ARControl) this.txtRfYTD_ActVBudgetPerct).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtRfYTD_ActVBudgetPerct).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRfYTD_ActVBudgetPerct).Height = 0.2f;
    ((ARControl) this.txtRfYTD_ActVBudgetPerct).Left = 141f / 16f;
    ((ARControl) this.txtRfYTD_ActVBudgetPerct).Name = "txtRfYTD_ActVBudgetPerct";
    this.txtRfYTD_ActVBudgetPerct.OutputFormat = resourceManager.GetString("txtRfYTD_ActVBudgetPerct.OutputFormat");
    this.txtRfYTD_ActVBudgetPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRfYTD_ActVBudgetPerct.Text = (string) null;
    ((ARControl) this.txtRfYTD_ActVBudgetPerct).Top = 0.0f;
    ((ARControl) this.txtRfYTD_ActVBudgetPerct).Width = 0.5f;
    ((ARControl) this.txtRfYTD_PYActVActual).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtRfYTD_PYActVActual).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRfYTD_PYActVActual).Height = 0.1979167f;
    ((ARControl) this.txtRfYTD_PYActVActual).Left = 149f / 16f;
    ((ARControl) this.txtRfYTD_PYActVActual).Name = "txtRfYTD_PYActVActual";
    this.txtRfYTD_PYActVActual.OutputFormat = resourceManager.GetString("txtRfYTD_PYActVActual.OutputFormat");
    this.txtRfYTD_PYActVActual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRfYTD_PYActVActual.Text = (string) null;
    ((ARControl) this.txtRfYTD_PYActVActual).Top = 0.0f;
    ((ARControl) this.txtRfYTD_PYActVActual).Width = 0.563f;
    ((ARControl) this.txtRfYTD_PYActVActualPerct).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtRfYTD_PYActVActualPerct).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtRfYTD_PYActVActualPerct).Height = 0.2f;
    ((ARControl) this.txtRfYTD_PYActVActualPerct).Left = 9.875f;
    ((ARControl) this.txtRfYTD_PYActVActualPerct).Name = "txtRfYTD_PYActVActualPerct";
    this.txtRfYTD_PYActVActualPerct.OutputFormat = resourceManager.GetString("txtRfYTD_PYActVActualPerct.OutputFormat");
    this.txtRfYTD_PYActVActualPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRfYTD_PYActVActualPerct.Text = (string) null;
    ((ARControl) this.txtRfYTD_PYActVActualPerct).Top = 0.0f;
    ((ARControl) this.txtRfYTD_PYActVActualPerct).Width = 0.5f;
    ((ARControl) this.textBox65).Height = 3f / 16f;
    ((ARControl) this.textBox65).Left = 65f / 16f;
    ((ARControl) this.textBox65).Name = "textBox65";
    this.textBox65.OutputFormat = resourceManager.GetString("textBox65.OutputFormat");
    this.textBox65.Style = "font-size: 7pt; font-weight: bold; text-align: left";
    this.textBox65.Text = "Profit / (Loss)";
    ((ARControl) this.textBox65).Top = 0.0f;
    ((ARControl) this.textBox65).Width = 15f / 16f;
    ((ARControl) this.txtRF_CurrentMonth_PremActual).Height = 0.1979167f;
    ((ARControl) this.txtRF_CurrentMonth_PremActual).Left = 0.0f;
    ((ARControl) this.txtRF_CurrentMonth_PremActual).Name = "txtRF_CurrentMonth_PremActual";
    this.txtRF_CurrentMonth_PremActual.OutputFormat = resourceManager.GetString("txtRF_CurrentMonth_PremActual.OutputFormat");
    this.txtRF_CurrentMonth_PremActual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRF_CurrentMonth_PremActual.Text = (string) null;
    ((ARControl) this.txtRF_CurrentMonth_PremActual).Top = 5f / 16f;
    ((ARControl) this.txtRF_CurrentMonth_PremActual).Width = 0.563f;
    ((ARControl) this.txtRF_CurrentMonth_PremBudget).Height = 0.1979167f;
    ((ARControl) this.txtRF_CurrentMonth_PremBudget).Left = 9f / 16f;
    ((ARControl) this.txtRF_CurrentMonth_PremBudget).Name = "txtRF_CurrentMonth_PremBudget";
    this.txtRF_CurrentMonth_PremBudget.OutputFormat = resourceManager.GetString("txtRF_CurrentMonth_PremBudget.OutputFormat");
    this.txtRF_CurrentMonth_PremBudget.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRF_CurrentMonth_PremBudget.Text = (string) null;
    ((ARControl) this.txtRF_CurrentMonth_PremBudget).Top = 5f / 16f;
    ((ARControl) this.txtRF_CurrentMonth_PremBudget).Width = 0.563f;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActual).Height = 0.1979167f;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActual).Left = 1.125f;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActual).Name = "txtRF_CurrentMonth_PremPYActual";
    this.txtRF_CurrentMonth_PremPYActual.OutputFormat = resourceManager.GetString("txtRF_CurrentMonth_PremPYActual.OutputFormat");
    this.txtRF_CurrentMonth_PremPYActual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRF_CurrentMonth_PremPYActual.Text = (string) null;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActual).Top = 5f / 16f;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActual).Width = 0.563f;
    ((ARControl) this.txtRF_CurrentMonth_PremActVBudget).Height = 0.1979167f;
    ((ARControl) this.txtRF_CurrentMonth_PremActVBudget).Left = 27f / 16f;
    ((ARControl) this.txtRF_CurrentMonth_PremActVBudget).Name = "txtRF_CurrentMonth_PremActVBudget";
    this.txtRF_CurrentMonth_PremActVBudget.OutputFormat = resourceManager.GetString("txtRF_CurrentMonth_PremActVBudget.OutputFormat");
    this.txtRF_CurrentMonth_PremActVBudget.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRF_CurrentMonth_PremActVBudget.Text = (string) null;
    ((ARControl) this.txtRF_CurrentMonth_PremActVBudget).Top = 5f / 16f;
    ((ARControl) this.txtRF_CurrentMonth_PremActVBudget).Width = 0.563f;
    ((ARControl) this.txtRF_CurrentMonth_PremActVBudgetPerct).Height = 0.2f;
    ((ARControl) this.txtRF_CurrentMonth_PremActVBudgetPerct).Left = 2.25f;
    ((ARControl) this.txtRF_CurrentMonth_PremActVBudgetPerct).Name = "txtRF_CurrentMonth_PremActVBudgetPerct";
    this.txtRF_CurrentMonth_PremActVBudgetPerct.OutputFormat = resourceManager.GetString("txtRF_CurrentMonth_PremActVBudgetPerct.OutputFormat");
    this.txtRF_CurrentMonth_PremActVBudgetPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRF_CurrentMonth_PremActVBudgetPerct.Text = (string) null;
    ((ARControl) this.txtRF_CurrentMonth_PremActVBudgetPerct).Top = 5f / 16f;
    ((ARControl) this.txtRF_CurrentMonth_PremActVBudgetPerct).Width = 0.5f;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActVActual).Height = 0.1979167f;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActVActual).Left = 2.75f;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActVActual).Name = "txtRF_CurrentMonth_PremPYActVActual";
    this.txtRF_CurrentMonth_PremPYActVActual.OutputFormat = resourceManager.GetString("txtRF_CurrentMonth_PremPYActVActual.OutputFormat");
    this.txtRF_CurrentMonth_PremPYActVActual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRF_CurrentMonth_PremPYActVActual.Text = (string) null;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActVActual).Top = 5f / 16f;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActVActual).Width = 0.563f;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActVActualPerct).Height = 0.2f;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActVActualPerct).Left = 53f / 16f;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActVActualPerct).Name = "txtRF_CurrentMonth_PremPYActVActualPerct";
    this.txtRF_CurrentMonth_PremPYActVActualPerct.OutputFormat = resourceManager.GetString("txtRF_CurrentMonth_PremPYActVActualPerct.OutputFormat");
    this.txtRF_CurrentMonth_PremPYActVActualPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRF_CurrentMonth_PremPYActVActualPerct.Text = (string) null;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActVActualPerct).Top = 5f / 16f;
    ((ARControl) this.txtRF_CurrentMonth_PremPYActVActualPerct).Width = 0.5f;
    ((ARControl) this.txtRF_YTD_PremActual).Height = 0.1979167f;
    ((ARControl) this.txtRF_YTD_PremActual).Left = 105f / 16f;
    ((ARControl) this.txtRF_YTD_PremActual).Name = "txtRF_YTD_PremActual";
    this.txtRF_YTD_PremActual.OutputFormat = resourceManager.GetString("txtRF_YTD_PremActual.OutputFormat");
    this.txtRF_YTD_PremActual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRF_YTD_PremActual.Text = (string) null;
    ((ARControl) this.txtRF_YTD_PremActual).Top = 5f / 16f;
    ((ARControl) this.txtRF_YTD_PremActual).Width = 0.563f;
    ((ARControl) this.txtRF_YTD_PremBudget).Height = 0.1979167f;
    ((ARControl) this.txtRF_YTD_PremBudget).Left = 7.125f;
    ((ARControl) this.txtRF_YTD_PremBudget).Name = "txtRF_YTD_PremBudget";
    this.txtRF_YTD_PremBudget.OutputFormat = resourceManager.GetString("txtRF_YTD_PremBudget.OutputFormat");
    this.txtRF_YTD_PremBudget.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRF_YTD_PremBudget.Text = (string) null;
    ((ARControl) this.txtRF_YTD_PremBudget).Top = 5f / 16f;
    ((ARControl) this.txtRF_YTD_PremBudget).Width = 0.563f;
    ((ARControl) this.txtRF_YTD_PremPYActual).Height = 0.1979167f;
    ((ARControl) this.txtRF_YTD_PremPYActual).Left = 123f / 16f;
    ((ARControl) this.txtRF_YTD_PremPYActual).Name = "txtRF_YTD_PremPYActual";
    this.txtRF_YTD_PremPYActual.OutputFormat = resourceManager.GetString("txtRF_YTD_PremPYActual.OutputFormat");
    this.txtRF_YTD_PremPYActual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRF_YTD_PremPYActual.Text = (string) null;
    ((ARControl) this.txtRF_YTD_PremPYActual).Top = 5f / 16f;
    ((ARControl) this.txtRF_YTD_PremPYActual).Width = 0.563f;
    ((ARControl) this.txtRF_YTD_PremActVBudget).Height = 0.1979167f;
    ((ARControl) this.txtRF_YTD_PremActVBudget).Left = 8.25f;
    ((ARControl) this.txtRF_YTD_PremActVBudget).Name = "txtRF_YTD_PremActVBudget";
    this.txtRF_YTD_PremActVBudget.OutputFormat = resourceManager.GetString("txtRF_YTD_PremActVBudget.OutputFormat");
    this.txtRF_YTD_PremActVBudget.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRF_YTD_PremActVBudget.Text = (string) null;
    ((ARControl) this.txtRF_YTD_PremActVBudget).Top = 5f / 16f;
    ((ARControl) this.txtRF_YTD_PremActVBudget).Width = 0.563f;
    ((ARControl) this.txtRF_YTD_PremActVBudgetPerct).Height = 0.2f;
    ((ARControl) this.txtRF_YTD_PremActVBudgetPerct).Left = 141f / 16f;
    ((ARControl) this.txtRF_YTD_PremActVBudgetPerct).Name = "txtRF_YTD_PremActVBudgetPerct";
    this.txtRF_YTD_PremActVBudgetPerct.OutputFormat = resourceManager.GetString("txtRF_YTD_PremActVBudgetPerct.OutputFormat");
    this.txtRF_YTD_PremActVBudgetPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRF_YTD_PremActVBudgetPerct.Text = (string) null;
    ((ARControl) this.txtRF_YTD_PremActVBudgetPerct).Top = 5f / 16f;
    ((ARControl) this.txtRF_YTD_PremActVBudgetPerct).Width = 0.5f;
    ((ARControl) this.txtRF_YTD_PremPYActVActual).Height = 0.1979167f;
    ((ARControl) this.txtRF_YTD_PremPYActVActual).Left = 149f / 16f;
    ((ARControl) this.txtRF_YTD_PremPYActVActual).Name = "txtRF_YTD_PremPYActVActual";
    this.txtRF_YTD_PremPYActVActual.OutputFormat = resourceManager.GetString("txtRF_YTD_PremPYActVActual.OutputFormat");
    this.txtRF_YTD_PremPYActVActual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRF_YTD_PremPYActVActual.Text = (string) null;
    ((ARControl) this.txtRF_YTD_PremPYActVActual).Top = 5f / 16f;
    ((ARControl) this.txtRF_YTD_PremPYActVActual).Width = 0.563f;
    ((ARControl) this.txtRF_YTD_PremPYActVActualPerct).Height = 0.2f;
    ((ARControl) this.txtRF_YTD_PremPYActVActualPerct).Left = 9.875f;
    ((ARControl) this.txtRF_YTD_PremPYActVActualPerct).Name = "txtRF_YTD_PremPYActVActualPerct";
    this.txtRF_YTD_PremPYActVActualPerct.OutputFormat = resourceManager.GetString("txtRF_YTD_PremPYActVActualPerct.OutputFormat");
    this.txtRF_YTD_PremPYActVActualPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtRF_YTD_PremPYActVActualPerct.Text = (string) null;
    ((ARControl) this.txtRF_YTD_PremPYActVActualPerct).Top = 5f / 16f;
    ((ARControl) this.txtRF_YTD_PremPYActVActualPerct).Width = 0.5f;
    ((ARControl) this.textBox42).Height = 3f / 16f;
    ((ARControl) this.textBox42).Left = 65f / 16f;
    ((ARControl) this.textBox42).Name = "textBox42";
    this.textBox42.OutputFormat = resourceManager.GetString("textBox42.OutputFormat");
    this.textBox42.Style = "font-size: 7pt; font-weight: bold; text-align: left";
    this.textBox42.Text = "Premiums";
    ((ARControl) this.textBox42).Top = 5f / 16f;
    ((ARControl) this.textBox42).Width = 15f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClass).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtGhAcctClassName
    });
    this.ghAcctClass.DataField = "AcctClassName";
    this.ghAcctClass.Height = 0.2083333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClass).Name = "ghAcctClass";
    ((ARControl) this.txtGhAcctClassName).DataField = "AcctClassName";
    ((ARControl) this.txtGhAcctClassName).Height = 3f / 16f;
    ((ARControl) this.txtGhAcctClassName).Left = 63f / 16f;
    ((ARControl) this.txtGhAcctClassName).Name = "txtGhAcctClassName";
    this.txtGhAcctClassName.OutputFormat = resourceManager.GetString("txtGhAcctClassName.OutputFormat");
    this.txtGhAcctClassName.Style = "font-size: 7pt; font-weight: bold; text-align: left";
    this.txtGhAcctClassName.Text = (string) null;
    ((ARControl) this.txtGhAcctClassName).Top = 0.0f;
    ((ARControl) this.txtGhAcctClassName).Width = 41f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClass).Controls.AddRange(new ARControl[16 /*0x10*/]
    {
      (ARControl) this.txtGfACCurrentMonth_ActualAmount,
      (ARControl) this.txtGfACCurrentMonth_Budget,
      (ARControl) this.txtGfACCurrentMonth_PYActual,
      (ARControl) this.textBox37,
      (ARControl) this.txtGfACCurrentMonth_ActVBudgetPerct,
      (ARControl) this.textBox39,
      (ARControl) this.txtGfACCurrentMonth_PYActVActualPerct,
      (ARControl) this.txtGfACYTD_Actual,
      (ARControl) this.txtGfACYTD_Budget,
      (ARControl) this.txtGfACYTD_PYActual,
      (ARControl) this.textBox44,
      (ARControl) this.txtGfACYTD_ActVBudgetPerct,
      (ARControl) this.textBox46,
      (ARControl) this.txtGfACYTD_PYActVActualPerct,
      (ARControl) this.textBox48,
      (ARControl) this.textBox49
    });
    this.gfAcctClass.Height = 7f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClass).Name = "gfAcctClass";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClass).Format += new EventHandler(this.gfAcctClass_Format);
    ((ARControl) this.txtGfACCurrentMonth_ActualAmount).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACCurrentMonth_ActualAmount).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACCurrentMonth_ActualAmount).DataField = "CurrentMonth_ActualAmount";
    ((ARControl) this.txtGfACCurrentMonth_ActualAmount).Height = 0.1979167f;
    ((ARControl) this.txtGfACCurrentMonth_ActualAmount).Left = 0.0f;
    ((ARControl) this.txtGfACCurrentMonth_ActualAmount).Name = "txtGfACCurrentMonth_ActualAmount";
    this.txtGfACCurrentMonth_ActualAmount.OutputFormat = resourceManager.GetString("txtGfACCurrentMonth_ActualAmount.OutputFormat");
    this.txtGfACCurrentMonth_ActualAmount.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfACCurrentMonth_ActualAmount.SummaryGroup = "ghAcctClass";
    this.txtGfACCurrentMonth_ActualAmount.SummaryRunning = (SummaryRunning) 1;
    this.txtGfACCurrentMonth_ActualAmount.SummaryType = (SummaryType) 3;
    this.txtGfACCurrentMonth_ActualAmount.Text = (string) null;
    ((ARControl) this.txtGfACCurrentMonth_ActualAmount).Top = 0.0f;
    ((ARControl) this.txtGfACCurrentMonth_ActualAmount).Width = 0.563f;
    ((ARControl) this.txtGfACCurrentMonth_Budget).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACCurrentMonth_Budget).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACCurrentMonth_Budget).DataField = "CurrentMonth_Budget";
    ((ARControl) this.txtGfACCurrentMonth_Budget).Height = 0.1979167f;
    ((ARControl) this.txtGfACCurrentMonth_Budget).Left = 9f / 16f;
    ((ARControl) this.txtGfACCurrentMonth_Budget).Name = "txtGfACCurrentMonth_Budget";
    this.txtGfACCurrentMonth_Budget.OutputFormat = resourceManager.GetString("txtGfACCurrentMonth_Budget.OutputFormat");
    this.txtGfACCurrentMonth_Budget.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfACCurrentMonth_Budget.SummaryGroup = "ghAcctClass";
    this.txtGfACCurrentMonth_Budget.SummaryRunning = (SummaryRunning) 1;
    this.txtGfACCurrentMonth_Budget.SummaryType = (SummaryType) 3;
    this.txtGfACCurrentMonth_Budget.Text = (string) null;
    ((ARControl) this.txtGfACCurrentMonth_Budget).Top = 0.0f;
    ((ARControl) this.txtGfACCurrentMonth_Budget).Width = 0.563f;
    ((ARControl) this.txtGfACCurrentMonth_PYActual).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACCurrentMonth_PYActual).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACCurrentMonth_PYActual).DataField = "CurrentMonth_PYActual";
    ((ARControl) this.txtGfACCurrentMonth_PYActual).Height = 0.1979167f;
    ((ARControl) this.txtGfACCurrentMonth_PYActual).Left = 1.125f;
    ((ARControl) this.txtGfACCurrentMonth_PYActual).Name = "txtGfACCurrentMonth_PYActual";
    this.txtGfACCurrentMonth_PYActual.OutputFormat = resourceManager.GetString("txtGfACCurrentMonth_PYActual.OutputFormat");
    this.txtGfACCurrentMonth_PYActual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfACCurrentMonth_PYActual.SummaryGroup = "ghAcctClass";
    this.txtGfACCurrentMonth_PYActual.SummaryRunning = (SummaryRunning) 1;
    this.txtGfACCurrentMonth_PYActual.SummaryType = (SummaryType) 3;
    this.txtGfACCurrentMonth_PYActual.Text = (string) null;
    ((ARControl) this.txtGfACCurrentMonth_PYActual).Top = 0.0f;
    ((ARControl) this.txtGfACCurrentMonth_PYActual).Width = 0.563f;
    ((ARControl) this.textBox37).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox37).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox37).DataField = "CurrentMonth_ActVBudget";
    ((ARControl) this.textBox37).Height = 0.1979167f;
    ((ARControl) this.textBox37).Left = 27f / 16f;
    ((ARControl) this.textBox37).Name = "textBox37";
    this.textBox37.OutputFormat = resourceManager.GetString("textBox37.OutputFormat");
    this.textBox37.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.textBox37.SummaryGroup = "ghAcctClass";
    this.textBox37.SummaryRunning = (SummaryRunning) 1;
    this.textBox37.SummaryType = (SummaryType) 3;
    this.textBox37.Text = (string) null;
    ((ARControl) this.textBox37).Top = 0.0f;
    ((ARControl) this.textBox37).Width = 0.563f;
    ((ARControl) this.txtGfACCurrentMonth_ActVBudgetPerct).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACCurrentMonth_ActVBudgetPerct).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACCurrentMonth_ActVBudgetPerct).Height = 0.2f;
    ((ARControl) this.txtGfACCurrentMonth_ActVBudgetPerct).Left = 2.25f;
    ((ARControl) this.txtGfACCurrentMonth_ActVBudgetPerct).Name = "txtGfACCurrentMonth_ActVBudgetPerct";
    this.txtGfACCurrentMonth_ActVBudgetPerct.OutputFormat = resourceManager.GetString("txtGfACCurrentMonth_ActVBudgetPerct.OutputFormat");
    this.txtGfACCurrentMonth_ActVBudgetPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfACCurrentMonth_ActVBudgetPerct.Text = (string) null;
    ((ARControl) this.txtGfACCurrentMonth_ActVBudgetPerct).Top = 0.0f;
    ((ARControl) this.txtGfACCurrentMonth_ActVBudgetPerct).Width = 0.5f;
    ((ARControl) this.textBox39).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox39).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox39).DataField = "CurrentMonth_PYActVActual";
    ((ARControl) this.textBox39).Height = 0.1979167f;
    ((ARControl) this.textBox39).Left = 2.75f;
    ((ARControl) this.textBox39).Name = "textBox39";
    this.textBox39.OutputFormat = resourceManager.GetString("textBox39.OutputFormat");
    this.textBox39.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.textBox39.SummaryGroup = "ghAcctClass";
    this.textBox39.SummaryRunning = (SummaryRunning) 1;
    this.textBox39.SummaryType = (SummaryType) 3;
    this.textBox39.Text = (string) null;
    ((ARControl) this.textBox39).Top = 0.0f;
    ((ARControl) this.textBox39).Width = 0.563f;
    ((ARControl) this.txtGfACCurrentMonth_PYActVActualPerct).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACCurrentMonth_PYActVActualPerct).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACCurrentMonth_PYActVActualPerct).Height = 0.2f;
    ((ARControl) this.txtGfACCurrentMonth_PYActVActualPerct).Left = 53f / 16f;
    ((ARControl) this.txtGfACCurrentMonth_PYActVActualPerct).Name = "txtGfACCurrentMonth_PYActVActualPerct";
    this.txtGfACCurrentMonth_PYActVActualPerct.OutputFormat = resourceManager.GetString("txtGfACCurrentMonth_PYActVActualPerct.OutputFormat");
    this.txtGfACCurrentMonth_PYActVActualPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfACCurrentMonth_PYActVActualPerct.Text = (string) null;
    ((ARControl) this.txtGfACCurrentMonth_PYActVActualPerct).Top = 0.0f;
    ((ARControl) this.txtGfACCurrentMonth_PYActVActualPerct).Width = 0.5f;
    ((ARControl) this.txtGfACYTD_Actual).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACYTD_Actual).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACYTD_Actual).DataField = "YTD_Actual";
    ((ARControl) this.txtGfACYTD_Actual).Height = 0.1979167f;
    ((ARControl) this.txtGfACYTD_Actual).Left = 105f / 16f;
    ((ARControl) this.txtGfACYTD_Actual).Name = "txtGfACYTD_Actual";
    this.txtGfACYTD_Actual.OutputFormat = resourceManager.GetString("txtGfACYTD_Actual.OutputFormat");
    this.txtGfACYTD_Actual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfACYTD_Actual.SummaryGroup = "ghAcctClass";
    this.txtGfACYTD_Actual.SummaryRunning = (SummaryRunning) 1;
    this.txtGfACYTD_Actual.SummaryType = (SummaryType) 3;
    this.txtGfACYTD_Actual.Text = (string) null;
    ((ARControl) this.txtGfACYTD_Actual).Top = 0.0f;
    ((ARControl) this.txtGfACYTD_Actual).Width = 0.563f;
    ((ARControl) this.txtGfACYTD_Budget).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACYTD_Budget).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACYTD_Budget).DataField = "YTD_Budget";
    ((ARControl) this.txtGfACYTD_Budget).Height = 0.1979167f;
    ((ARControl) this.txtGfACYTD_Budget).Left = 7.125f;
    ((ARControl) this.txtGfACYTD_Budget).Name = "txtGfACYTD_Budget";
    this.txtGfACYTD_Budget.OutputFormat = resourceManager.GetString("txtGfACYTD_Budget.OutputFormat");
    this.txtGfACYTD_Budget.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfACYTD_Budget.SummaryGroup = "ghAcctClass";
    this.txtGfACYTD_Budget.SummaryRunning = (SummaryRunning) 1;
    this.txtGfACYTD_Budget.SummaryType = (SummaryType) 3;
    this.txtGfACYTD_Budget.Text = (string) null;
    ((ARControl) this.txtGfACYTD_Budget).Top = 0.0f;
    ((ARControl) this.txtGfACYTD_Budget).Width = 0.563f;
    ((ARControl) this.txtGfACYTD_PYActual).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACYTD_PYActual).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACYTD_PYActual).DataField = "YTD_PYActual";
    ((ARControl) this.txtGfACYTD_PYActual).Height = 0.1979167f;
    ((ARControl) this.txtGfACYTD_PYActual).Left = 123f / 16f;
    ((ARControl) this.txtGfACYTD_PYActual).Name = "txtGfACYTD_PYActual";
    this.txtGfACYTD_PYActual.OutputFormat = resourceManager.GetString("txtGfACYTD_PYActual.OutputFormat");
    this.txtGfACYTD_PYActual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfACYTD_PYActual.SummaryGroup = "ghAcctClass";
    this.txtGfACYTD_PYActual.SummaryRunning = (SummaryRunning) 1;
    this.txtGfACYTD_PYActual.SummaryType = (SummaryType) 3;
    this.txtGfACYTD_PYActual.Text = (string) null;
    ((ARControl) this.txtGfACYTD_PYActual).Top = 0.0f;
    ((ARControl) this.txtGfACYTD_PYActual).Width = 0.563f;
    ((ARControl) this.textBox44).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox44).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox44).DataField = "YTD_ActVBudget";
    ((ARControl) this.textBox44).Height = 0.1979167f;
    ((ARControl) this.textBox44).Left = 8.25f;
    ((ARControl) this.textBox44).Name = "textBox44";
    this.textBox44.OutputFormat = resourceManager.GetString("textBox44.OutputFormat");
    this.textBox44.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.textBox44.SummaryGroup = "ghAcctClass";
    this.textBox44.SummaryRunning = (SummaryRunning) 1;
    this.textBox44.SummaryType = (SummaryType) 3;
    this.textBox44.Text = (string) null;
    ((ARControl) this.textBox44).Top = 0.0f;
    ((ARControl) this.textBox44).Width = 0.563f;
    ((ARControl) this.txtGfACYTD_ActVBudgetPerct).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACYTD_ActVBudgetPerct).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACYTD_ActVBudgetPerct).Height = 0.2f;
    ((ARControl) this.txtGfACYTD_ActVBudgetPerct).Left = 141f / 16f;
    ((ARControl) this.txtGfACYTD_ActVBudgetPerct).Name = "txtGfACYTD_ActVBudgetPerct";
    this.txtGfACYTD_ActVBudgetPerct.OutputFormat = resourceManager.GetString("txtGfACYTD_ActVBudgetPerct.OutputFormat");
    this.txtGfACYTD_ActVBudgetPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfACYTD_ActVBudgetPerct.Text = (string) null;
    ((ARControl) this.txtGfACYTD_ActVBudgetPerct).Top = 0.0f;
    ((ARControl) this.txtGfACYTD_ActVBudgetPerct).Width = 0.5f;
    ((ARControl) this.textBox46).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox46).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox46).DataField = "YTD_PYActVActual";
    ((ARControl) this.textBox46).Height = 0.1979167f;
    ((ARControl) this.textBox46).Left = 149f / 16f;
    ((ARControl) this.textBox46).Name = "textBox46";
    this.textBox46.OutputFormat = resourceManager.GetString("textBox46.OutputFormat");
    this.textBox46.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.textBox46.SummaryGroup = "ghAcctClass";
    this.textBox46.SummaryRunning = (SummaryRunning) 1;
    this.textBox46.SummaryType = (SummaryType) 3;
    this.textBox46.Text = (string) null;
    ((ARControl) this.textBox46).Top = 0.0f;
    ((ARControl) this.textBox46).Width = 0.563f;
    ((ARControl) this.txtGfACYTD_PYActVActualPerct).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACYTD_PYActVActualPerct).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfACYTD_PYActVActualPerct).Height = 0.2f;
    ((ARControl) this.txtGfACYTD_PYActVActualPerct).Left = 9.875f;
    ((ARControl) this.txtGfACYTD_PYActVActualPerct).Name = "txtGfACYTD_PYActVActualPerct";
    this.txtGfACYTD_PYActVActualPerct.OutputFormat = resourceManager.GetString("txtGfACYTD_PYActVActualPerct.OutputFormat");
    this.txtGfACYTD_PYActVActualPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfACYTD_PYActVActualPerct.Text = (string) null;
    ((ARControl) this.txtGfACYTD_PYActVActualPerct).Top = 0.0f;
    ((ARControl) this.txtGfACYTD_PYActVActualPerct).Width = 0.5f;
    ((ARControl) this.textBox48).DataField = "AcctClassName";
    ((ARControl) this.textBox48).Height = 3f / 16f;
    ((ARControl) this.textBox48).Left = 4.375f;
    ((ARControl) this.textBox48).Name = "textBox48";
    this.textBox48.OutputFormat = resourceManager.GetString("textBox48.OutputFormat");
    this.textBox48.Style = "font-size: 7pt; font-weight: bold; text-align: left";
    this.textBox48.Text = (string) null;
    ((ARControl) this.textBox48).Top = 0.0f;
    ((ARControl) this.textBox48).Width = 2.125f;
    ((ARControl) this.textBox49).Height = 3f / 16f;
    ((ARControl) this.textBox49).Left = 65f / 16f;
    ((ARControl) this.textBox49).Name = "textBox49";
    this.textBox49.OutputFormat = resourceManager.GetString("textBox49.OutputFormat");
    this.textBox49.Style = "font-size: 7pt; font-weight: bold; text-align: left";
    this.textBox49.Text = "Total";
    ((ARControl) this.textBox49).Top = 0.0f;
    ((ARControl) this.textBox49).Width = 5f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctType).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.textBox16
    });
    this.ghAcctType.DataField = "AcctTypeDescription";
    this.ghAcctType.Height = 0.2083333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctType).Name = "ghAcctType";
    ((ARControl) this.textBox16).DataField = "AcctTypeDescription";
    ((ARControl) this.textBox16).Height = 3f / 16f;
    ((ARControl) this.textBox16).Left = 65f / 16f;
    ((ARControl) this.textBox16).Name = "textBox16";
    this.textBox16.OutputFormat = resourceManager.GetString("textBox16.OutputFormat");
    this.textBox16.Style = "font-size: 7pt; font-weight: bold; text-align: left";
    this.textBox16.Text = (string) null;
    ((ARControl) this.textBox16).Top = 0.0f;
    ((ARControl) this.textBox16).Width = 39f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctType).Controls.AddRange(new ARControl[16 /*0x10*/]
    {
      (ARControl) this.txtGfATCurrentMonth_ActualAmount,
      (ARControl) this.txtGfATCurrentMonth_Budget,
      (ARControl) this.txtGfATCurrentMonth_PYActual,
      (ARControl) this.textBox21,
      (ARControl) this.txtGfATCurrentMonth_ActVBudgetPerct,
      (ARControl) this.textBox23,
      (ARControl) this.txtGfATCurrentMonth_PYActVActualPerct,
      (ARControl) this.txtGfATYTD_Actual,
      (ARControl) this.txtGfATYTD_Budget,
      (ARControl) this.txtGfATYTD_PYActual,
      (ARControl) this.textBox29,
      (ARControl) this.txtGfATYTD_ActVBudgetPerct,
      (ARControl) this.textBox31,
      (ARControl) this.txtGfATYTD_PYActVActualPerct,
      (ARControl) this.textBox25,
      (ARControl) this.textBox33
    });
    this.gfAcctType.Height = 0.1979167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctType).Name = "gfAcctType";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctType).Format += new EventHandler(this.gfAcctType_Format);
    ((ARControl) this.txtGfATCurrentMonth_ActualAmount).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfATCurrentMonth_ActualAmount).DataField = "CurrentMonth_ActualAmount";
    ((ARControl) this.txtGfATCurrentMonth_ActualAmount).Height = 0.1979167f;
    ((ARControl) this.txtGfATCurrentMonth_ActualAmount).Left = 0.0f;
    ((ARControl) this.txtGfATCurrentMonth_ActualAmount).Name = "txtGfATCurrentMonth_ActualAmount";
    this.txtGfATCurrentMonth_ActualAmount.OutputFormat = resourceManager.GetString("txtGfATCurrentMonth_ActualAmount.OutputFormat");
    this.txtGfATCurrentMonth_ActualAmount.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfATCurrentMonth_ActualAmount.SummaryGroup = "ghAcctType";
    this.txtGfATCurrentMonth_ActualAmount.SummaryRunning = (SummaryRunning) 1;
    this.txtGfATCurrentMonth_ActualAmount.SummaryType = (SummaryType) 3;
    this.txtGfATCurrentMonth_ActualAmount.Text = (string) null;
    ((ARControl) this.txtGfATCurrentMonth_ActualAmount).Top = 0.0f;
    ((ARControl) this.txtGfATCurrentMonth_ActualAmount).Width = 0.563f;
    ((ARControl) this.txtGfATCurrentMonth_Budget).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfATCurrentMonth_Budget).DataField = "CurrentMonth_Budget";
    ((ARControl) this.txtGfATCurrentMonth_Budget).Height = 0.1979167f;
    ((ARControl) this.txtGfATCurrentMonth_Budget).Left = 9f / 16f;
    ((ARControl) this.txtGfATCurrentMonth_Budget).Name = "txtGfATCurrentMonth_Budget";
    this.txtGfATCurrentMonth_Budget.OutputFormat = resourceManager.GetString("txtGfATCurrentMonth_Budget.OutputFormat");
    this.txtGfATCurrentMonth_Budget.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfATCurrentMonth_Budget.SummaryGroup = "ghAcctType";
    this.txtGfATCurrentMonth_Budget.SummaryRunning = (SummaryRunning) 1;
    this.txtGfATCurrentMonth_Budget.SummaryType = (SummaryType) 3;
    this.txtGfATCurrentMonth_Budget.Text = (string) null;
    ((ARControl) this.txtGfATCurrentMonth_Budget).Top = 0.0f;
    ((ARControl) this.txtGfATCurrentMonth_Budget).Width = 0.563f;
    ((ARControl) this.txtGfATCurrentMonth_PYActual).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfATCurrentMonth_PYActual).DataField = "CurrentMonth_PYActual";
    ((ARControl) this.txtGfATCurrentMonth_PYActual).Height = 0.1979167f;
    ((ARControl) this.txtGfATCurrentMonth_PYActual).Left = 1.125f;
    ((ARControl) this.txtGfATCurrentMonth_PYActual).Name = "txtGfATCurrentMonth_PYActual";
    this.txtGfATCurrentMonth_PYActual.OutputFormat = resourceManager.GetString("txtGfATCurrentMonth_PYActual.OutputFormat");
    this.txtGfATCurrentMonth_PYActual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfATCurrentMonth_PYActual.SummaryGroup = "ghAcctType";
    this.txtGfATCurrentMonth_PYActual.SummaryRunning = (SummaryRunning) 1;
    this.txtGfATCurrentMonth_PYActual.SummaryType = (SummaryType) 3;
    this.txtGfATCurrentMonth_PYActual.Text = (string) null;
    ((ARControl) this.txtGfATCurrentMonth_PYActual).Top = 0.0f;
    ((ARControl) this.txtGfATCurrentMonth_PYActual).Width = 0.563f;
    ((ARControl) this.textBox21).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox21).DataField = "CurrentMonth_ActVBudget";
    ((ARControl) this.textBox21).Height = 0.1979167f;
    ((ARControl) this.textBox21).Left = 27f / 16f;
    ((ARControl) this.textBox21).Name = "textBox21";
    this.textBox21.OutputFormat = resourceManager.GetString("textBox21.OutputFormat");
    this.textBox21.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.textBox21.SummaryGroup = "ghAcctType";
    this.textBox21.SummaryRunning = (SummaryRunning) 1;
    this.textBox21.SummaryType = (SummaryType) 3;
    this.textBox21.Text = (string) null;
    ((ARControl) this.textBox21).Top = 0.0f;
    ((ARControl) this.textBox21).Width = 0.563f;
    ((ARControl) this.txtGfATCurrentMonth_ActVBudgetPerct).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfATCurrentMonth_ActVBudgetPerct).Height = 0.2f;
    ((ARControl) this.txtGfATCurrentMonth_ActVBudgetPerct).Left = 2.25f;
    ((ARControl) this.txtGfATCurrentMonth_ActVBudgetPerct).Name = "txtGfATCurrentMonth_ActVBudgetPerct";
    this.txtGfATCurrentMonth_ActVBudgetPerct.OutputFormat = resourceManager.GetString("txtGfATCurrentMonth_ActVBudgetPerct.OutputFormat");
    this.txtGfATCurrentMonth_ActVBudgetPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfATCurrentMonth_ActVBudgetPerct.Text = (string) null;
    ((ARControl) this.txtGfATCurrentMonth_ActVBudgetPerct).Top = 0.0f;
    ((ARControl) this.txtGfATCurrentMonth_ActVBudgetPerct).Width = 0.5f;
    ((ARControl) this.textBox23).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox23).DataField = "CurrentMonth_PYActVActual";
    ((ARControl) this.textBox23).Height = 0.1979167f;
    ((ARControl) this.textBox23).Left = 2.75f;
    ((ARControl) this.textBox23).Name = "textBox23";
    this.textBox23.OutputFormat = resourceManager.GetString("textBox23.OutputFormat");
    this.textBox23.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.textBox23.SummaryGroup = "ghAcctType";
    this.textBox23.SummaryRunning = (SummaryRunning) 1;
    this.textBox23.SummaryType = (SummaryType) 3;
    this.textBox23.Text = (string) null;
    ((ARControl) this.textBox23).Top = 0.0f;
    ((ARControl) this.textBox23).Width = 0.563f;
    ((ARControl) this.txtGfATCurrentMonth_PYActVActualPerct).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfATCurrentMonth_PYActVActualPerct).Height = 0.2f;
    ((ARControl) this.txtGfATCurrentMonth_PYActVActualPerct).Left = 53f / 16f;
    ((ARControl) this.txtGfATCurrentMonth_PYActVActualPerct).Name = "txtGfATCurrentMonth_PYActVActualPerct";
    this.txtGfATCurrentMonth_PYActVActualPerct.OutputFormat = resourceManager.GetString("txtGfATCurrentMonth_PYActVActualPerct.OutputFormat");
    this.txtGfATCurrentMonth_PYActVActualPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfATCurrentMonth_PYActVActualPerct.Text = (string) null;
    ((ARControl) this.txtGfATCurrentMonth_PYActVActualPerct).Top = 0.0f;
    ((ARControl) this.txtGfATCurrentMonth_PYActVActualPerct).Width = 0.5f;
    ((ARControl) this.txtGfATYTD_Actual).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfATYTD_Actual).DataField = "YTD_Actual";
    ((ARControl) this.txtGfATYTD_Actual).Height = 0.1979167f;
    ((ARControl) this.txtGfATYTD_Actual).Left = 105f / 16f;
    ((ARControl) this.txtGfATYTD_Actual).Name = "txtGfATYTD_Actual";
    this.txtGfATYTD_Actual.OutputFormat = resourceManager.GetString("txtGfATYTD_Actual.OutputFormat");
    this.txtGfATYTD_Actual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfATYTD_Actual.SummaryGroup = "ghAcctType";
    this.txtGfATYTD_Actual.SummaryRunning = (SummaryRunning) 1;
    this.txtGfATYTD_Actual.SummaryType = (SummaryType) 3;
    this.txtGfATYTD_Actual.Text = (string) null;
    ((ARControl) this.txtGfATYTD_Actual).Top = 0.0f;
    ((ARControl) this.txtGfATYTD_Actual).Width = 0.563f;
    ((ARControl) this.txtGfATYTD_Budget).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfATYTD_Budget).DataField = "YTD_Budget";
    ((ARControl) this.txtGfATYTD_Budget).Height = 0.1979167f;
    ((ARControl) this.txtGfATYTD_Budget).Left = 7.125f;
    ((ARControl) this.txtGfATYTD_Budget).Name = "txtGfATYTD_Budget";
    this.txtGfATYTD_Budget.OutputFormat = resourceManager.GetString("txtGfATYTD_Budget.OutputFormat");
    this.txtGfATYTD_Budget.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfATYTD_Budget.SummaryGroup = "ghAcctType";
    this.txtGfATYTD_Budget.SummaryRunning = (SummaryRunning) 1;
    this.txtGfATYTD_Budget.SummaryType = (SummaryType) 3;
    this.txtGfATYTD_Budget.Text = (string) null;
    ((ARControl) this.txtGfATYTD_Budget).Top = 0.0f;
    ((ARControl) this.txtGfATYTD_Budget).Width = 0.563f;
    ((ARControl) this.txtGfATYTD_PYActual).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfATYTD_PYActual).DataField = "YTD_PYActual";
    ((ARControl) this.txtGfATYTD_PYActual).Height = 0.1979167f;
    ((ARControl) this.txtGfATYTD_PYActual).Left = 123f / 16f;
    ((ARControl) this.txtGfATYTD_PYActual).Name = "txtGfATYTD_PYActual";
    this.txtGfATYTD_PYActual.OutputFormat = resourceManager.GetString("txtGfATYTD_PYActual.OutputFormat");
    this.txtGfATYTD_PYActual.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfATYTD_PYActual.SummaryGroup = "ghAcctType";
    this.txtGfATYTD_PYActual.SummaryRunning = (SummaryRunning) 1;
    this.txtGfATYTD_PYActual.SummaryType = (SummaryType) 3;
    this.txtGfATYTD_PYActual.Text = (string) null;
    ((ARControl) this.txtGfATYTD_PYActual).Top = 0.0f;
    ((ARControl) this.txtGfATYTD_PYActual).Width = 0.563f;
    ((ARControl) this.textBox29).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox29).DataField = "YTD_ActVBudget";
    ((ARControl) this.textBox29).Height = 0.1979167f;
    ((ARControl) this.textBox29).Left = 8.25f;
    ((ARControl) this.textBox29).Name = "textBox29";
    this.textBox29.OutputFormat = resourceManager.GetString("textBox29.OutputFormat");
    this.textBox29.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.textBox29.SummaryGroup = "ghAcctType";
    this.textBox29.SummaryRunning = (SummaryRunning) 1;
    this.textBox29.SummaryType = (SummaryType) 3;
    this.textBox29.Text = (string) null;
    ((ARControl) this.textBox29).Top = 0.0f;
    ((ARControl) this.textBox29).Width = 0.563f;
    ((ARControl) this.txtGfATYTD_ActVBudgetPerct).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfATYTD_ActVBudgetPerct).Height = 0.2f;
    ((ARControl) this.txtGfATYTD_ActVBudgetPerct).Left = 141f / 16f;
    ((ARControl) this.txtGfATYTD_ActVBudgetPerct).Name = "txtGfATYTD_ActVBudgetPerct";
    this.txtGfATYTD_ActVBudgetPerct.OutputFormat = resourceManager.GetString("txtGfATYTD_ActVBudgetPerct.OutputFormat");
    this.txtGfATYTD_ActVBudgetPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfATYTD_ActVBudgetPerct.Text = (string) null;
    ((ARControl) this.txtGfATYTD_ActVBudgetPerct).Top = 0.0f;
    ((ARControl) this.txtGfATYTD_ActVBudgetPerct).Width = 0.5f;
    ((ARControl) this.textBox31).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox31).DataField = "YTD_PYActVActual";
    ((ARControl) this.textBox31).Height = 0.1979167f;
    ((ARControl) this.textBox31).Left = 149f / 16f;
    ((ARControl) this.textBox31).Name = "textBox31";
    this.textBox31.OutputFormat = resourceManager.GetString("textBox31.OutputFormat");
    this.textBox31.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.textBox31.SummaryGroup = "ghAcctType";
    this.textBox31.SummaryRunning = (SummaryRunning) 1;
    this.textBox31.SummaryType = (SummaryType) 3;
    this.textBox31.Text = (string) null;
    ((ARControl) this.textBox31).Top = 0.0f;
    ((ARControl) this.textBox31).Width = 0.563f;
    ((ARControl) this.txtGfATYTD_PYActVActualPerct).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGfATYTD_PYActVActualPerct).Height = 0.2f;
    ((ARControl) this.txtGfATYTD_PYActVActualPerct).Left = 9.875f;
    ((ARControl) this.txtGfATYTD_PYActVActualPerct).Name = "txtGfATYTD_PYActVActualPerct";
    this.txtGfATYTD_PYActVActualPerct.OutputFormat = resourceManager.GetString("txtGfATYTD_PYActVActualPerct.OutputFormat");
    this.txtGfATYTD_PYActVActualPerct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfATYTD_PYActVActualPerct.Text = (string) null;
    ((ARControl) this.txtGfATYTD_PYActVActualPerct).Top = 0.0f;
    ((ARControl) this.txtGfATYTD_PYActVActualPerct).Width = 0.5f;
    ((ARControl) this.textBox25).DataField = "AcctTypeDescription";
    ((ARControl) this.textBox25).Height = 3f / 16f;
    ((ARControl) this.textBox25).Left = 4.375f;
    ((ARControl) this.textBox25).Name = "textBox25";
    this.textBox25.OutputFormat = resourceManager.GetString("textBox25.OutputFormat");
    this.textBox25.Style = "font-size: 7pt; font-weight: bold; text-align: left";
    this.textBox25.Text = (string) null;
    ((ARControl) this.textBox25).Top = 0.0f;
    ((ARControl) this.textBox25).Width = 2.125f;
    ((ARControl) this.textBox33).Height = 3f / 16f;
    ((ARControl) this.textBox33).Left = 65f / 16f;
    ((ARControl) this.textBox33).Name = "textBox33";
    this.textBox33.OutputFormat = resourceManager.GetString("textBox33.OutputFormat");
    this.textBox33.Style = "font-size: 7pt; font-weight: bold; text-align: left";
    this.textBox33.Text = "Total";
    ((ARControl) this.textBox33).Top = 0.0f;
    ((ARControl) this.textBox33).Width = 5f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader1).Controls.AddRange(new ARControl[19]
    {
      (ARControl) this.label2,
      (ARControl) this.labPeriodEnding,
      (ARControl) this.label5,
      (ARControl) this.label6,
      (ARControl) this.label7,
      (ARControl) this.label8,
      (ARControl) this.label9,
      (ARControl) this.label10,
      (ARControl) this.label11,
      (ARControl) this.label12,
      (ARControl) this.label13,
      (ARControl) this.label14,
      (ARControl) this.label15,
      (ARControl) this.label16,
      (ARControl) this.label17,
      (ARControl) this.label18,
      (ARControl) this.label1,
      (ARControl) this.labPHRunDateRange,
      (ARControl) this.txtClientOfficeNames
    });
    this.pageHeader1.Height = 1.427083f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader1).Name = "pageHeader1";
    ((ARControl) this.label2).Height = 3f / 16f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 0.0f;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "font-size: 10pt; font-weight: bold; text-align: center";
    this.label2.Text = "Consolidated Income Statement";
    ((ARControl) this.label2).Top = 0.532f;
    ((ARControl) this.label2).Width = 10.375f;
    ((ARControl) this.labPeriodEnding).Height = 3f / 16f;
    this.labPeriodEnding.HyperLink = (string) null;
    ((ARControl) this.labPeriodEnding).Left = 0.0f;
    ((ARControl) this.labPeriodEnding).Name = "labPeriodEnding";
    this.labPeriodEnding.Style = "font-size: 9pt; font-weight: normal; text-align: center";
    this.labPeriodEnding.Text = "Period Ending";
    ((ARControl) this.labPeriodEnding).Top = 0.7195f;
    ((ARControl) this.labPeriodEnding).Width = 10.375f;
    ((ARControl) this.label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label5).Height = 3f / 16f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 0.0f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label5.Text = "Actual";
    ((ARControl) this.label5).Top = 1.1565f;
    ((ARControl) this.label5).Width = 9f / 16f;
    ((ARControl) this.label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label6).Height = 3f / 16f;
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Left = 9f / 16f;
    ((ARControl) this.label6).Name = "label6";
    this.label6.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label6.Text = "Budget";
    ((ARControl) this.label6).Top = 1.1565f;
    ((ARControl) this.label6).Width = 9f / 16f;
    ((ARControl) this.label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label7).Height = 3f / 16f;
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Left = 1.125f;
    ((ARControl) this.label7).Name = "label7";
    this.label7.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label7.Text = "Prior Year";
    ((ARControl) this.label7).Top = 1.1565f;
    ((ARControl) this.label7).Width = 9f / 16f;
    ((ARControl) this.label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label8).Height = 3f / 16f;
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Left = 27f / 16f;
    ((ARControl) this.label8).Name = "label8";
    this.label8.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label8.Text = "Act vs Bud";
    ((ARControl) this.label8).Top = 1.1565f;
    ((ARControl) this.label8).Width = 9f / 16f;
    ((ARControl) this.label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label9).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label9).Height = 3f / 16f;
    this.label9.HyperLink = (string) null;
    ((ARControl) this.label9).Left = 2.25f;
    ((ARControl) this.label9).Name = "label9";
    this.label9.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label9.Text = "%";
    ((ARControl) this.label9).Top = 1.1565f;
    ((ARControl) this.label9).Width = 0.5f;
    ((ARControl) this.label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label10).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label10).Height = 3f / 16f;
    this.label10.HyperLink = (string) null;
    ((ARControl) this.label10).Left = 2.75f;
    ((ARControl) this.label10).Name = "label10";
    this.label10.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label10.Text = "Act vs PY";
    ((ARControl) this.label10).Top = 1.1565f;
    ((ARControl) this.label10).Width = 9f / 16f;
    ((ARControl) this.label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label11).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label11).Height = 3f / 16f;
    this.label11.HyperLink = (string) null;
    ((ARControl) this.label11).Left = 53f / 16f;
    ((ARControl) this.label11).Name = "label11";
    this.label11.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label11.Text = "%";
    ((ARControl) this.label11).Top = 1.1565f;
    ((ARControl) this.label11).Width = 0.5f;
    ((ARControl) this.label12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label12).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label12).Height = 3f / 16f;
    this.label12.HyperLink = (string) null;
    ((ARControl) this.label12).Left = 105f / 16f;
    ((ARControl) this.label12).Name = "label12";
    this.label12.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label12.Text = "Actual";
    ((ARControl) this.label12).Top = 1.1565f;
    ((ARControl) this.label12).Width = 9f / 16f;
    ((ARControl) this.label13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label13).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label13).Height = 3f / 16f;
    this.label13.HyperLink = (string) null;
    ((ARControl) this.label13).Left = 7.125f;
    ((ARControl) this.label13).Name = "label13";
    this.label13.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label13.Text = "Budget";
    ((ARControl) this.label13).Top = 1.1565f;
    ((ARControl) this.label13).Width = 9f / 16f;
    ((ARControl) this.label14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label14).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label14).Height = 3f / 16f;
    this.label14.HyperLink = (string) null;
    ((ARControl) this.label14).Left = 123f / 16f;
    ((ARControl) this.label14).Name = "label14";
    this.label14.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label14.Text = "Prior Year";
    ((ARControl) this.label14).Top = 1.1565f;
    ((ARControl) this.label14).Width = 9f / 16f;
    ((ARControl) this.label15).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label15).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label15).Height = 3f / 16f;
    this.label15.HyperLink = (string) null;
    ((ARControl) this.label15).Left = 8.25f;
    ((ARControl) this.label15).Name = "label15";
    this.label15.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label15.Text = "Act vs Bud";
    ((ARControl) this.label15).Top = 1.1565f;
    ((ARControl) this.label15).Width = 9f / 16f;
    ((ARControl) this.label16).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label16).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label16).Height = 3f / 16f;
    this.label16.HyperLink = (string) null;
    ((ARControl) this.label16).Left = 141f / 16f;
    ((ARControl) this.label16).Name = "label16";
    this.label16.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label16.Text = "%";
    ((ARControl) this.label16).Top = 1.1565f;
    ((ARControl) this.label16).Width = 0.5f;
    ((ARControl) this.label17).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label17).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label17).Height = 3f / 16f;
    this.label17.HyperLink = (string) null;
    ((ARControl) this.label17).Left = 149f / 16f;
    ((ARControl) this.label17).Name = "label17";
    this.label17.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label17.Text = "Act vs PY";
    ((ARControl) this.label17).Top = 1.1565f;
    ((ARControl) this.label17).Width = 9f / 16f;
    ((ARControl) this.label18).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label18).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label18).Height = 3f / 16f;
    this.label18.HyperLink = (string) null;
    ((ARControl) this.label18).Left = 9.875f;
    ((ARControl) this.label18).Name = "label18";
    this.label18.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label18.Text = "%";
    ((ARControl) this.label18).Top = 1.1565f;
    ((ARControl) this.label18).Width = 0.5f;
    ((ARControl) this.label1).Height = 3f / 16f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 0.0f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.label1.Text = "Current Month";
    ((ARControl) this.label1).Top = 0.9065f;
    ((ARControl) this.label1).Width = 61f / 16f;
    ((ARControl) this.labPHRunDateRange).Height = 3f / 16f;
    this.labPHRunDateRange.HyperLink = (string) null;
    ((ARControl) this.labPHRunDateRange).Left = 105f / 16f;
    ((ARControl) this.labPHRunDateRange).Name = "labPHRunDateRange";
    this.labPHRunDateRange.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.labPHRunDateRange.Text = "";
    ((ARControl) this.labPHRunDateRange).Top = 0.9065f;
    ((ARControl) this.labPHRunDateRange).Width = 61f / 16f;
    ((ARControl) this.txtClientOfficeNames).Height = 0.532f;
    ((ARControl) this.txtClientOfficeNames).Left = 0.0f;
    ((ARControl) this.txtClientOfficeNames).Name = "txtClientOfficeNames";
    this.txtClientOfficeNames.Style = "font-size: 11pt; font-weight: bold; text-align: center";
    this.txtClientOfficeNames.Text = (string) null;
    ((ARControl) this.txtClientOfficeNames).Top = 0.0f;
    ((ARControl) this.txtClientOfficeNames).Width = 10.375f;
    this.pageFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter1).Name = "pageFooter1";
    this.ghAcctTypePct.DataField = "AcctTypeDescription";
    this.ghAcctTypePct.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypePct).Name = "ghAcctTypePct";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypePct).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.txtGfAcctTypePct_CM_ActualPct,
      (ARControl) this.textBox19,
      (ARControl) this.txtGfAcctTypePct_CM_BudgetPct,
      (ARControl) this.txtGfAcctTypePct_CM_PriorYearPct,
      (ARControl) this.txtGfAcctTypePct_YTD_ActualPct,
      (ARControl) this.txtGfAcctTypePct_YTD_BudgetPct,
      (ARControl) this.txtGfAcctTypePct_YTD_PriorYearPct
    });
    this.gfAcctTypePct.Height = 0.2083333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypePct).Name = "gfAcctTypePct";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypePct).Visible = false;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypePct).Format += new EventHandler(this.gfAcctTypePct_Format);
    ((ARControl) this.txtGfAcctTypePct_CM_ActualPct).Height = 3f / 16f;
    ((ARControl) this.txtGfAcctTypePct_CM_ActualPct).Left = 0.0f;
    ((ARControl) this.txtGfAcctTypePct_CM_ActualPct).Name = "txtGfAcctTypePct_CM_ActualPct";
    this.txtGfAcctTypePct_CM_ActualPct.OutputFormat = resourceManager.GetString("txtGfAcctTypePct_CM_ActualPct.OutputFormat");
    this.txtGfAcctTypePct_CM_ActualPct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfAcctTypePct_CM_ActualPct.Text = (string) null;
    ((ARControl) this.txtGfAcctTypePct_CM_ActualPct).Top = 0.0f;
    ((ARControl) this.txtGfAcctTypePct_CM_ActualPct).Width = 9f / 16f;
    ((ARControl) this.textBox19).Height = 3f / 16f;
    ((ARControl) this.textBox19).Left = 65f / 16f;
    ((ARControl) this.textBox19).Name = "textBox19";
    this.textBox19.OutputFormat = resourceManager.GetString("textBox19.OutputFormat");
    this.textBox19.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.textBox19.Text = "% of income";
    ((ARControl) this.textBox19).Top = 0.0f;
    ((ARControl) this.textBox19).Width = 39f / 16f;
    ((ARControl) this.txtGfAcctTypePct_CM_BudgetPct).Height = 3f / 16f;
    ((ARControl) this.txtGfAcctTypePct_CM_BudgetPct).Left = 9f / 16f;
    ((ARControl) this.txtGfAcctTypePct_CM_BudgetPct).Name = "txtGfAcctTypePct_CM_BudgetPct";
    this.txtGfAcctTypePct_CM_BudgetPct.OutputFormat = resourceManager.GetString("txtGfAcctTypePct_CM_BudgetPct.OutputFormat");
    this.txtGfAcctTypePct_CM_BudgetPct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfAcctTypePct_CM_BudgetPct.Text = (string) null;
    ((ARControl) this.txtGfAcctTypePct_CM_BudgetPct).Top = 0.0f;
    ((ARControl) this.txtGfAcctTypePct_CM_BudgetPct).Width = 9f / 16f;
    ((ARControl) this.txtGfAcctTypePct_CM_PriorYearPct).Height = 3f / 16f;
    ((ARControl) this.txtGfAcctTypePct_CM_PriorYearPct).Left = 1.125f;
    ((ARControl) this.txtGfAcctTypePct_CM_PriorYearPct).Name = "txtGfAcctTypePct_CM_PriorYearPct";
    this.txtGfAcctTypePct_CM_PriorYearPct.OutputFormat = resourceManager.GetString("txtGfAcctTypePct_CM_PriorYearPct.OutputFormat");
    this.txtGfAcctTypePct_CM_PriorYearPct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfAcctTypePct_CM_PriorYearPct.Text = (string) null;
    ((ARControl) this.txtGfAcctTypePct_CM_PriorYearPct).Top = 0.0f;
    ((ARControl) this.txtGfAcctTypePct_CM_PriorYearPct).Width = 9f / 16f;
    ((ARControl) this.txtGfAcctTypePct_YTD_ActualPct).Height = 3f / 16f;
    ((ARControl) this.txtGfAcctTypePct_YTD_ActualPct).Left = 105f / 16f;
    ((ARControl) this.txtGfAcctTypePct_YTD_ActualPct).Name = "txtGfAcctTypePct_YTD_ActualPct";
    this.txtGfAcctTypePct_YTD_ActualPct.OutputFormat = resourceManager.GetString("txtGfAcctTypePct_YTD_ActualPct.OutputFormat");
    this.txtGfAcctTypePct_YTD_ActualPct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfAcctTypePct_YTD_ActualPct.Text = (string) null;
    ((ARControl) this.txtGfAcctTypePct_YTD_ActualPct).Top = 0.0f;
    ((ARControl) this.txtGfAcctTypePct_YTD_ActualPct).Width = 9f / 16f;
    ((ARControl) this.txtGfAcctTypePct_YTD_BudgetPct).Height = 3f / 16f;
    ((ARControl) this.txtGfAcctTypePct_YTD_BudgetPct).Left = 7.125f;
    ((ARControl) this.txtGfAcctTypePct_YTD_BudgetPct).Name = "txtGfAcctTypePct_YTD_BudgetPct";
    this.txtGfAcctTypePct_YTD_BudgetPct.OutputFormat = resourceManager.GetString("txtGfAcctTypePct_YTD_BudgetPct.OutputFormat");
    this.txtGfAcctTypePct_YTD_BudgetPct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfAcctTypePct_YTD_BudgetPct.Text = (string) null;
    ((ARControl) this.txtGfAcctTypePct_YTD_BudgetPct).Top = 0.0f;
    ((ARControl) this.txtGfAcctTypePct_YTD_BudgetPct).Width = 9f / 16f;
    ((ARControl) this.txtGfAcctTypePct_YTD_PriorYearPct).Height = 3f / 16f;
    ((ARControl) this.txtGfAcctTypePct_YTD_PriorYearPct).Left = 123f / 16f;
    ((ARControl) this.txtGfAcctTypePct_YTD_PriorYearPct).Name = "txtGfAcctTypePct_YTD_PriorYearPct";
    this.txtGfAcctTypePct_YTD_PriorYearPct.OutputFormat = resourceManager.GetString("txtGfAcctTypePct_YTD_PriorYearPct.OutputFormat");
    this.txtGfAcctTypePct_YTD_PriorYearPct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfAcctTypePct_YTD_PriorYearPct.Text = (string) null;
    ((ARControl) this.txtGfAcctTypePct_YTD_PriorYearPct).Top = 0.0f;
    ((ARControl) this.txtGfAcctTypePct_YTD_PriorYearPct).Width = 9f / 16f;
    this.ghAcctClassPct.DataField = "AcctClassName";
    this.ghAcctClassPct.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassPct).Name = "ghAcctClassPct";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassPct).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.txtGfAcctClassPct_CM_ActualPct,
      (ARControl) this.textBox20,
      (ARControl) this.txtGfAcctClassPct_CM_BudgetPct,
      (ARControl) this.txtGfAcctClassPct_CM_PriorYearPct,
      (ARControl) this.txtGfAcctClassPct_YTD_ActualPct,
      (ARControl) this.txtGfAcctClassPct_YTD_BudgetPct,
      (ARControl) this.txtGfAcctClassPct_YTD_PriorYearPct
    });
    this.gfAcctClassPct.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassPct).Name = "gfAcctClassPct";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassPct).Visible = false;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassPct).Format += new EventHandler(this.gfAcctClassPct_Format);
    ((ARControl) this.txtGfAcctClassPct_CM_ActualPct).Height = 3f / 16f;
    ((ARControl) this.txtGfAcctClassPct_CM_ActualPct).Left = 0.0f;
    ((ARControl) this.txtGfAcctClassPct_CM_ActualPct).Name = "txtGfAcctClassPct_CM_ActualPct";
    this.txtGfAcctClassPct_CM_ActualPct.OutputFormat = resourceManager.GetString("txtGfAcctClassPct_CM_ActualPct.OutputFormat");
    this.txtGfAcctClassPct_CM_ActualPct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfAcctClassPct_CM_ActualPct.Text = (string) null;
    ((ARControl) this.txtGfAcctClassPct_CM_ActualPct).Top = 0.0f;
    ((ARControl) this.txtGfAcctClassPct_CM_ActualPct).Width = 9f / 16f;
    ((ARControl) this.textBox20).Height = 3f / 16f;
    ((ARControl) this.textBox20).Left = 65f / 16f;
    ((ARControl) this.textBox20).Name = "textBox20";
    this.textBox20.OutputFormat = resourceManager.GetString("textBox20.OutputFormat");
    this.textBox20.Style = "font-size: 7pt; font-weight: bold; text-align: center";
    this.textBox20.Text = "% of income";
    ((ARControl) this.textBox20).Top = 0.0f;
    ((ARControl) this.textBox20).Width = 39f / 16f;
    ((ARControl) this.txtGfAcctClassPct_CM_BudgetPct).Height = 3f / 16f;
    ((ARControl) this.txtGfAcctClassPct_CM_BudgetPct).Left = 9f / 16f;
    ((ARControl) this.txtGfAcctClassPct_CM_BudgetPct).Name = "txtGfAcctClassPct_CM_BudgetPct";
    this.txtGfAcctClassPct_CM_BudgetPct.OutputFormat = resourceManager.GetString("txtGfAcctClassPct_CM_BudgetPct.OutputFormat");
    this.txtGfAcctClassPct_CM_BudgetPct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfAcctClassPct_CM_BudgetPct.Text = (string) null;
    ((ARControl) this.txtGfAcctClassPct_CM_BudgetPct).Top = 0.0f;
    ((ARControl) this.txtGfAcctClassPct_CM_BudgetPct).Width = 9f / 16f;
    ((ARControl) this.txtGfAcctClassPct_CM_PriorYearPct).Height = 3f / 16f;
    ((ARControl) this.txtGfAcctClassPct_CM_PriorYearPct).Left = 1.125f;
    ((ARControl) this.txtGfAcctClassPct_CM_PriorYearPct).Name = "txtGfAcctClassPct_CM_PriorYearPct";
    this.txtGfAcctClassPct_CM_PriorYearPct.OutputFormat = resourceManager.GetString("txtGfAcctClassPct_CM_PriorYearPct.OutputFormat");
    this.txtGfAcctClassPct_CM_PriorYearPct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfAcctClassPct_CM_PriorYearPct.Text = (string) null;
    ((ARControl) this.txtGfAcctClassPct_CM_PriorYearPct).Top = 0.0f;
    ((ARControl) this.txtGfAcctClassPct_CM_PriorYearPct).Width = 9f / 16f;
    ((ARControl) this.txtGfAcctClassPct_YTD_ActualPct).Height = 3f / 16f;
    ((ARControl) this.txtGfAcctClassPct_YTD_ActualPct).Left = 105f / 16f;
    ((ARControl) this.txtGfAcctClassPct_YTD_ActualPct).Name = "txtGfAcctClassPct_YTD_ActualPct";
    this.txtGfAcctClassPct_YTD_ActualPct.OutputFormat = resourceManager.GetString("txtGfAcctClassPct_YTD_ActualPct.OutputFormat");
    this.txtGfAcctClassPct_YTD_ActualPct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfAcctClassPct_YTD_ActualPct.Text = (string) null;
    ((ARControl) this.txtGfAcctClassPct_YTD_ActualPct).Top = 0.0f;
    ((ARControl) this.txtGfAcctClassPct_YTD_ActualPct).Width = 9f / 16f;
    ((ARControl) this.txtGfAcctClassPct_YTD_BudgetPct).Height = 3f / 16f;
    ((ARControl) this.txtGfAcctClassPct_YTD_BudgetPct).Left = 7.125f;
    ((ARControl) this.txtGfAcctClassPct_YTD_BudgetPct).Name = "txtGfAcctClassPct_YTD_BudgetPct";
    this.txtGfAcctClassPct_YTD_BudgetPct.OutputFormat = resourceManager.GetString("txtGfAcctClassPct_YTD_BudgetPct.OutputFormat");
    this.txtGfAcctClassPct_YTD_BudgetPct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfAcctClassPct_YTD_BudgetPct.Text = (string) null;
    ((ARControl) this.txtGfAcctClassPct_YTD_BudgetPct).Top = 0.0f;
    ((ARControl) this.txtGfAcctClassPct_YTD_BudgetPct).Width = 9f / 16f;
    ((ARControl) this.txtGfAcctClassPct_YTD_PriorYearPct).Height = 3f / 16f;
    ((ARControl) this.txtGfAcctClassPct_YTD_PriorYearPct).Left = 123f / 16f;
    ((ARControl) this.txtGfAcctClassPct_YTD_PriorYearPct).Name = "txtGfAcctClassPct_YTD_PriorYearPct";
    this.txtGfAcctClassPct_YTD_PriorYearPct.OutputFormat = resourceManager.GetString("txtGfAcctClassPct_YTD_PriorYearPct.OutputFormat");
    this.txtGfAcctClassPct_YTD_PriorYearPct.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGfAcctClassPct_YTD_PriorYearPct.Text = (string) null;
    ((ARControl) this.txtGfAcctClassPct_YTD_PriorYearPct).Top = 0.0f;
    ((ARControl) this.txtGfAcctClassPct_YTD_PriorYearPct).Width = 9f / 16f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassPct);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClass);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypePct);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctType);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctType);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypePct);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClass);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassPct);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    this.ReportStart += new EventHandler(this.rptConsolidatedIncomeStatementByBudget_ReportStart);
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
    ((ISupportInitialize) this.textBox10).EndInit();
    ((ISupportInitialize) this.textBox11).EndInit();
    ((ISupportInitialize) this.textBox12).EndInit();
    ((ISupportInitialize) this.textBox13).EndInit();
    ((ISupportInitialize) this.textBox14).EndInit();
    ((ISupportInitialize) this.textBox15).EndInit();
    ((ISupportInitialize) this.txtRfCurrentMonth_ActualAmount).EndInit();
    ((ISupportInitialize) this.txtRfCurrentMonth_Budget).EndInit();
    ((ISupportInitialize) this.txtRfCurrentMonth_PYActual).EndInit();
    ((ISupportInitialize) this.txtRfCurrentMonth_ActVBudget).EndInit();
    ((ISupportInitialize) this.txtRfCurrentMonth_ActVBudgetPerct).EndInit();
    ((ISupportInitialize) this.txtRfCurrentMonth_PYActVActual).EndInit();
    ((ISupportInitialize) this.txtRfCurrentMonth_PYActVActualPerct).EndInit();
    ((ISupportInitialize) this.txtRfYTD_Actual).EndInit();
    ((ISupportInitialize) this.txtRfYTD_Budget).EndInit();
    ((ISupportInitialize) this.txtRfYTD_PYActual).EndInit();
    ((ISupportInitialize) this.txtRfYTD_ActVBudget).EndInit();
    ((ISupportInitialize) this.txtRfYTD_ActVBudgetPerct).EndInit();
    ((ISupportInitialize) this.txtRfYTD_PYActVActual).EndInit();
    ((ISupportInitialize) this.txtRfYTD_PYActVActualPerct).EndInit();
    ((ISupportInitialize) this.textBox65).EndInit();
    ((ISupportInitialize) this.txtRF_CurrentMonth_PremActual).EndInit();
    ((ISupportInitialize) this.txtRF_CurrentMonth_PremBudget).EndInit();
    ((ISupportInitialize) this.txtRF_CurrentMonth_PremPYActual).EndInit();
    ((ISupportInitialize) this.txtRF_CurrentMonth_PremActVBudget).EndInit();
    ((ISupportInitialize) this.txtRF_CurrentMonth_PremActVBudgetPerct).EndInit();
    ((ISupportInitialize) this.txtRF_CurrentMonth_PremPYActVActual).EndInit();
    ((ISupportInitialize) this.txtRF_CurrentMonth_PremPYActVActualPerct).EndInit();
    ((ISupportInitialize) this.txtRF_YTD_PremActual).EndInit();
    ((ISupportInitialize) this.txtRF_YTD_PremBudget).EndInit();
    ((ISupportInitialize) this.txtRF_YTD_PremPYActual).EndInit();
    ((ISupportInitialize) this.txtRF_YTD_PremActVBudget).EndInit();
    ((ISupportInitialize) this.txtRF_YTD_PremActVBudgetPerct).EndInit();
    ((ISupportInitialize) this.txtRF_YTD_PremPYActVActual).EndInit();
    ((ISupportInitialize) this.txtRF_YTD_PremPYActVActualPerct).EndInit();
    ((ISupportInitialize) this.textBox42).EndInit();
    ((ISupportInitialize) this.txtGhAcctClassName).EndInit();
    ((ISupportInitialize) this.txtGfACCurrentMonth_ActualAmount).EndInit();
    ((ISupportInitialize) this.txtGfACCurrentMonth_Budget).EndInit();
    ((ISupportInitialize) this.txtGfACCurrentMonth_PYActual).EndInit();
    ((ISupportInitialize) this.textBox37).EndInit();
    ((ISupportInitialize) this.txtGfACCurrentMonth_ActVBudgetPerct).EndInit();
    ((ISupportInitialize) this.textBox39).EndInit();
    ((ISupportInitialize) this.txtGfACCurrentMonth_PYActVActualPerct).EndInit();
    ((ISupportInitialize) this.txtGfACYTD_Actual).EndInit();
    ((ISupportInitialize) this.txtGfACYTD_Budget).EndInit();
    ((ISupportInitialize) this.txtGfACYTD_PYActual).EndInit();
    ((ISupportInitialize) this.textBox44).EndInit();
    ((ISupportInitialize) this.txtGfACYTD_ActVBudgetPerct).EndInit();
    ((ISupportInitialize) this.textBox46).EndInit();
    ((ISupportInitialize) this.txtGfACYTD_PYActVActualPerct).EndInit();
    ((ISupportInitialize) this.textBox48).EndInit();
    ((ISupportInitialize) this.textBox49).EndInit();
    ((ISupportInitialize) this.textBox16).EndInit();
    ((ISupportInitialize) this.txtGfATCurrentMonth_ActualAmount).EndInit();
    ((ISupportInitialize) this.txtGfATCurrentMonth_Budget).EndInit();
    ((ISupportInitialize) this.txtGfATCurrentMonth_PYActual).EndInit();
    ((ISupportInitialize) this.textBox21).EndInit();
    ((ISupportInitialize) this.txtGfATCurrentMonth_ActVBudgetPerct).EndInit();
    ((ISupportInitialize) this.textBox23).EndInit();
    ((ISupportInitialize) this.txtGfATCurrentMonth_PYActVActualPerct).EndInit();
    ((ISupportInitialize) this.txtGfATYTD_Actual).EndInit();
    ((ISupportInitialize) this.txtGfATYTD_Budget).EndInit();
    ((ISupportInitialize) this.txtGfATYTD_PYActual).EndInit();
    ((ISupportInitialize) this.textBox29).EndInit();
    ((ISupportInitialize) this.txtGfATYTD_ActVBudgetPerct).EndInit();
    ((ISupportInitialize) this.textBox31).EndInit();
    ((ISupportInitialize) this.txtGfATYTD_PYActVActualPerct).EndInit();
    ((ISupportInitialize) this.textBox25).EndInit();
    ((ISupportInitialize) this.textBox33).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.labPeriodEnding).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.label9).EndInit();
    ((ISupportInitialize) this.label10).EndInit();
    ((ISupportInitialize) this.label11).EndInit();
    ((ISupportInitialize) this.label12).EndInit();
    ((ISupportInitialize) this.label13).EndInit();
    ((ISupportInitialize) this.label14).EndInit();
    ((ISupportInitialize) this.label15).EndInit();
    ((ISupportInitialize) this.label16).EndInit();
    ((ISupportInitialize) this.label17).EndInit();
    ((ISupportInitialize) this.label18).EndInit();
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.labPHRunDateRange).EndInit();
    ((ISupportInitialize) this.txtClientOfficeNames).EndInit();
    ((ISupportInitialize) this.txtGfAcctTypePct_CM_ActualPct).EndInit();
    ((ISupportInitialize) this.textBox19).EndInit();
    ((ISupportInitialize) this.txtGfAcctTypePct_CM_BudgetPct).EndInit();
    ((ISupportInitialize) this.txtGfAcctTypePct_CM_PriorYearPct).EndInit();
    ((ISupportInitialize) this.txtGfAcctTypePct_YTD_ActualPct).EndInit();
    ((ISupportInitialize) this.txtGfAcctTypePct_YTD_BudgetPct).EndInit();
    ((ISupportInitialize) this.txtGfAcctTypePct_YTD_PriorYearPct).EndInit();
    ((ISupportInitialize) this.txtGfAcctClassPct_CM_ActualPct).EndInit();
    ((ISupportInitialize) this.textBox20).EndInit();
    ((ISupportInitialize) this.txtGfAcctClassPct_CM_BudgetPct).EndInit();
    ((ISupportInitialize) this.txtGfAcctClassPct_CM_PriorYearPct).EndInit();
    ((ISupportInitialize) this.txtGfAcctClassPct_YTD_ActualPct).EndInit();
    ((ISupportInitialize) this.txtGfAcctClassPct_YTD_BudgetPct).EndInit();
    ((ISupportInitialize) this.txtGfAcctClassPct_YTD_PriorYearPct).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private enum FontStyle
  {
    ReportHeader,
    ColumnHeader,
    GrandTotalPlain,
    GrandTotalMoneyValue,
    GrandTotalPctValue,
    AcctClassSubtotPlain,
    AcctClassSubtotMoneyValue,
    AcctClassSubtotPctValue,
    AcctTypeSubtotPlain,
    AcctTypeSubtotMoneyValue,
    AcctTypeSubtotPctValue,
    DetailPlain,
    DetailMoneyValue,
    DetailPctValue,
    PercentOfIncome,
    PremiumsPlain,
    PremiumsMoneyValue,
    PremiumsPctValue,
  }
}
