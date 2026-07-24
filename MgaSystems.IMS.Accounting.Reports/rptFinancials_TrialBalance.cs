// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptFinancials_TrialBalance
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Viewer.Win;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{8DC8C92F-A794-44d5-B353-09FB7FE14876}", "Trial Balance", "The trial balance report will allow you to check the state of your accounts for a specific financial period.", "Financials")]
public sealed class rptFinancials_TrialBalance : MGAReport, IReport, ISupportReportDatabase
{
  private DateTime _DateFrom;
  private DateTime _DateTo;
  private int _GLCompanyID;
  private string _CostCenterIDs;
  private string _GLAccounts;
  private DataSet _ds;
  private int _CostCenterID;
  private string _GLAccountIDs;
  private bool _SummaryView;
  private Guid _entityGuid;
  private bool _excelOnly;
  private Database _database;
  private Label Label5;
  private TextBox txtClientOffice;
  private TextBox txtTrialBalancePeriod;
  private TextBox txtAcctClassName;
  private TextBox Current_AcctTypeDescription;
  private TextBox Current_AcctClassName;
  private TextBox txtAcctTypeDescription;
  private Label Label3;
  private Label Label4;
  private TextBox AcctClassName3;
  private TextBox TextBox1;
  private TextBox txtAcctTypeTotal;
  private TextBox AcctClassName1;
  private TextBox AcctClassName2;
  private TextBox txtAccountClassTotal;
  private Label Label6;
  private TextBox TextBox2;

  [field: AccessedThroughProperty("txtAmount")]
  private virtual TextBox txtAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Current_GlAcctID")]
  private virtual TextBox Current_GlAcctID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("srNext")]
  private virtual SubReport srNext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAcct")]
  private virtual TextBox txtAcct { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Current_ControlAcct")]
  private virtual TextBox Current_ControlAcct { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Current_RollUpTo")]
  private virtual TextBox Current_RollUpTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptFinancials_TrialBalance()
  {
    this.ReportStart += new EventHandler(this.rptFinancials_TrialBalance_ReportStart);
    this._CostCenterID = 0;
  }

  public rptFinancials_TrialBalance(
    DateTime DateFrom,
    DateTime DateTo,
    int GLCompanyID,
    string CostCenterIDs)
  {
    this.ReportStart += new EventHandler(this.rptFinancials_TrialBalance_ReportStart);
    this._CostCenterID = 0;
    this.InitializeComponent();
    this._DateFrom = DateFrom;
    this._DateTo = DateTo;
    this._GLCompanyID = GLCompanyID;
    this._CostCenterIDs = CostCenterIDs;
  }

  public rptFinancials_TrialBalance(
    DataSet trailBalanceData,
    int GLCompanyId,
    DateTime DateFrom,
    DateTime DateTo)
  {
    this.ReportStart += new EventHandler(this.rptFinancials_TrialBalance_ReportStart);
    this._CostCenterID = 0;
    this.InitializeComponent();
    this._ds = trailBalanceData;
    this._DateFrom = DateFrom;
    this._DateTo = DateTo;
    this._GLCompanyID = GLCompanyId;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptFinancials_TrialBalance));
    this.Detail = new Detail();
    this.txtAmount = new TextBox();
    this.Current_GlAcctID = new TextBox();
    this.srNext = new SubReport();
    this.txtAcct = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.Current_ControlAcct = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.Label6 = new Label();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.PageHeader = new PageHeader();
    this.Label5 = new Label();
    this.txtClientOffice = new TextBox();
    this.txtTrialBalancePeriod = new TextBox();
    this.txtCostCenter = new TextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label7 = new Label();
    this.PageFooter = new PageFooter();
    this.ghAccountClass = new GroupHeader();
    this.txtAcctClassName = new TextBox();
    this.gfAccountClass = new GroupFooter();
    this.AcctClassName1 = new TextBox();
    this.AcctClassName2 = new TextBox();
    this.txtAccountClassTotal = new TextBox();
    this.txtAccountClassTotal_Total = new TextBox();
    this.txtAccountClassTotal_BalForward = new TextBox();
    this.ghAcctTypeDescription = new GroupHeader();
    this.Current_AcctTypeDescription = new TextBox();
    this.Current_AcctClassName = new TextBox();
    this.txtAcctTypeDescription = new TextBox();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.gfAcctTypeDescription = new GroupFooter();
    this.AcctClassName3 = new TextBox();
    this.TextBox1 = new TextBox();
    this.txtAcctTypeTotal = new TextBox();
    this.txtAcctTypeTotal_Total = new TextBox();
    this.txtAcctTypeTotal_BalForward = new TextBox();
    this.Current_RollUpTo = new TextBox();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.Current_GlAcctID).BeginInit();
    ((ISupportInitialize) this.txtAcct).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.Current_ControlAcct).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.txtClientOffice).BeginInit();
    ((ISupportInitialize) this.txtTrialBalancePeriod).BeginInit();
    ((ISupportInitialize) this.txtCostCenter).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.txtAcctClassName).BeginInit();
    ((ISupportInitialize) this.AcctClassName1).BeginInit();
    ((ISupportInitialize) this.AcctClassName2).BeginInit();
    ((ISupportInitialize) this.txtAccountClassTotal).BeginInit();
    ((ISupportInitialize) this.txtAccountClassTotal_Total).BeginInit();
    ((ISupportInitialize) this.txtAccountClassTotal_BalForward).BeginInit();
    ((ISupportInitialize) this.Current_AcctTypeDescription).BeginInit();
    ((ISupportInitialize) this.Current_AcctClassName).BeginInit();
    ((ISupportInitialize) this.txtAcctTypeDescription).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.AcctClassName3).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.txtAcctTypeTotal).BeginInit();
    ((ISupportInitialize) this.txtAcctTypeTotal_Total).BeginInit();
    ((ISupportInitialize) this.txtAcctTypeTotal_BalForward).BeginInit();
    ((ISupportInitialize) this.Current_RollUpTo).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.txtAmount,
      (ARControl) this.Current_GlAcctID,
      (ARControl) this.srNext,
      (ARControl) this.txtAcct,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.Current_ControlAcct,
      (ARControl) this.Current_RollUpTo
    });
    ((Section) this.Detail).Height = 0.1875001f;
    this.Detail.KeepTogether = true;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.txtAmount).DataField = "Amount";
    ((ARControl) this.txtAmount).Height = 3f / 16f;
    ((ARControl) this.txtAmount).Left = 5.25f;
    ((ARControl) this.txtAmount).Name = "txtAmount";
    this.txtAmount.OutputFormat = resourceManager.GetString("txtAmount.OutputFormat");
    this.txtAmount.Style = "text-align: right; ddo-char-set: 0";
    this.txtAmount.Text = (string) null;
    ((ARControl) this.txtAmount).Top = 0.0f;
    ((ARControl) this.txtAmount).Width = 21f / 16f;
    ((ARControl) this.Current_GlAcctID).DataField = "GlAcctId";
    ((ARControl) this.Current_GlAcctID).Height = 1f / 16f;
    ((ARControl) this.Current_GlAcctID).Left = 0.0f;
    ((ARControl) this.Current_GlAcctID).Name = "Current_GlAcctID";
    this.Current_GlAcctID.Style = "background-color: Yellow; ddo-char-set: 0";
    this.Current_GlAcctID.Text = (string) null;
    ((ARControl) this.Current_GlAcctID).Top = 0.0f;
    ((ARControl) this.Current_GlAcctID).Visible = false;
    ((ARControl) this.Current_GlAcctID).Width = 0.5f;
    this.srNext.CloseBorder = false;
    ((ARControl) this.srNext).Height = 0.0f;
    ((ARControl) this.srNext).Left = 0.0f;
    ((ARControl) this.srNext).Name = "srNext";
    this.srNext.Report = (SectionReport) null;
    ((ARControl) this.srNext).Top = 3f / 16f;
    ((ARControl) this.srNext).Width = 7.875f;
    ((ARControl) this.txtAcct).DataField = "FullName";
    ((ARControl) this.txtAcct).Height = 3f / 16f;
    ((ARControl) this.txtAcct).Left = 0.365f;
    ((ARControl) this.txtAcct).Name = "txtAcct";
    this.txtAcct.Style = "ddo-char-set: 0";
    this.txtAcct.Text = (string) null;
    ((ARControl) this.txtAcct).Top = 0.0f;
    ((ARControl) this.txtAcct).Width = 3.5f;
    ((ARControl) this.TextBox5).DataField = "Total";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 105f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "text-align: right; ddo-char-set: 0";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 21f / 16f;
    ((ARControl) this.TextBox6).DataField = "BalForward";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 63f / 16f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "text-align: right; ddo-char-set: 0";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 21f / 16f;
    ((ARControl) this.Current_ControlAcct).DataField = "ControlAcct";
    ((ARControl) this.Current_ControlAcct).Height = 1f / 16f;
    ((ARControl) this.Current_ControlAcct).Left = 1.25f;
    ((ARControl) this.Current_ControlAcct).Name = "Current_ControlAcct";
    this.Current_ControlAcct.Style = "background-color: Yellow; ddo-char-set: 0";
    this.Current_ControlAcct.Text = (string) null;
    ((ARControl) this.Current_ControlAcct).Top = 0.0f;
    ((ARControl) this.Current_ControlAcct).Visible = false;
    ((ARControl) this.Current_ControlAcct).Width = 0.5f;
    this.ReportHeader.Height = 0.0f;
    ((Section) this.ReportHeader).Name = "ReportHeader";
    ((Section) this.ReportFooter).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Label6,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4
    });
    this.ReportFooter.Height = 0.325f;
    ((Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.Label6).Height = 0.2f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 0.0f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 12pt; font-weight: bold";
    this.Label6.Text = "Trial Balance";
    ((ARControl) this.Label6).Top = 0.125f;
    ((ARControl) this.Label6).Width = 23f / 16f;
    ((ARControl) this.TextBox2).DataField = "Amount";
    ((ARControl) this.TextBox2).Height = 0.2f;
    ((ARControl) this.TextBox2).Left = 5.25f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "font-size: 12pt; font-weight: bold; text-align: right";
    this.TextBox2.SummaryRunning = (SummaryRunning) 2;
    this.TextBox2.SummaryType = (SummaryType) 1;
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.125f;
    ((ARControl) this.TextBox2).Width = 1.313f;
    ((ARControl) this.TextBox3).DataField = "Total";
    ((ARControl) this.TextBox3).Height = 0.2f;
    ((ARControl) this.TextBox3).Left = 105f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "font-size: 12pt; font-weight: bold; text-align: right";
    this.TextBox3.SummaryRunning = (SummaryRunning) 2;
    this.TextBox3.SummaryType = (SummaryType) 1;
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.125f;
    ((ARControl) this.TextBox3).Width = 1.313f;
    ((ARControl) this.TextBox4).DataField = "BalForward";
    ((ARControl) this.TextBox4).Height = 0.2f;
    ((ARControl) this.TextBox4).Left = 63f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "font-size: 12pt; font-weight: bold; text-align: right";
    this.TextBox4.SummaryRunning = (SummaryRunning) 2;
    this.TextBox4.SummaryType = (SummaryType) 1;
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.125f;
    ((ARControl) this.TextBox4).Width = 1.313f;
    ((Section) this.PageHeader).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.Label5,
      (ARControl) this.txtClientOffice,
      (ARControl) this.txtTrialBalancePeriod,
      (ARControl) this.txtCostCenter,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label7
    });
    this.PageHeader.Height = 21f / 16f;
    ((Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label5).Height = 0.25f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 0.0f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 16pt; text-align: center";
    this.Label5.Text = "Trial Balance";
    ((ARControl) this.Label5).Top = 0.0f;
    ((ARControl) this.Label5).Width = 7.875f;
    ((ARControl) this.txtClientOffice).Height = 3f / 16f;
    ((ARControl) this.txtClientOffice).Left = 0.0f;
    ((ARControl) this.txtClientOffice).Name = "txtClientOffice";
    this.txtClientOffice.Style = "font-size: 11pt; text-align: center";
    this.txtClientOffice.Text = "[ClientOffice]";
    ((ARControl) this.txtClientOffice).Top = 0.25f;
    ((ARControl) this.txtClientOffice).Width = 7.875f;
    ((ARControl) this.txtTrialBalancePeriod).Height = 3f / 16f;
    ((ARControl) this.txtTrialBalancePeriod).Left = 0.0f;
    ((ARControl) this.txtTrialBalancePeriod).Name = "txtTrialBalancePeriod";
    this.txtTrialBalancePeriod.Style = "font-size: 11pt; text-align: center";
    this.txtTrialBalancePeriod.Text = (string) null;
    ((ARControl) this.txtTrialBalancePeriod).Top = 7f / 16f;
    ((ARControl) this.txtTrialBalancePeriod).Width = 7.875f;
    ((ARControl) this.txtCostCenter).Height = 3f / 16f;
    ((ARControl) this.txtCostCenter).Left = 0.0f;
    ((ARControl) this.txtCostCenter).Name = "txtCostCenter";
    this.txtCostCenter.Style = "font-size: 11pt; text-align: center; vertical-align: middle";
    this.txtCostCenter.Text = "CostCenter";
    ((ARControl) this.txtCostCenter).Top = 0.625f;
    ((ARControl) this.txtCostCenter).Width = 7.875f;
    ((ARControl) this.Label1).Height = 0.188f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 105f / 16f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-weight: bold; text-align: right";
    this.Label1.Text = "Total";
    ((ARControl) this.Label1).Top = 1f;
    ((ARControl) this.Label1).Width = 1.313f;
    ((ARControl) this.Label2).Height = 0.188f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 5.25f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-weight: bold; text-align: right";
    this.Label2.Text = "Amount";
    ((ARControl) this.Label2).Top = 1f;
    ((ARControl) this.Label2).Width = 1.313f;
    ((ARControl) this.Label7).Height = 0.188f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 63f / 16f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-weight: bold; text-align: right";
    this.Label7.Text = "Balance Forward";
    ((ARControl) this.Label7).Top = 1f;
    ((ARControl) this.Label7).Width = 1.313f;
    this.PageFooter.Height = 0.25f;
    ((Section) this.PageFooter).Name = "PageFooter";
    ((Section) this.ghAccountClass).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtAcctClassName
    });
    this.ghAccountClass.DataField = "AcctClassName";
    this.ghAccountClass.Height = 0.3854167f;
    ((Section) this.ghAccountClass).Name = "ghAccountClass";
    ((ARControl) this.txtAcctClassName).DataField = "AcctClassName";
    ((ARControl) this.txtAcctClassName).Height = 3f / 16f;
    ((ARControl) this.txtAcctClassName).Left = 0.0f;
    ((ARControl) this.txtAcctClassName).Name = "txtAcctClassName";
    this.txtAcctClassName.Style = "font-weight: bold; text-align: center";
    this.txtAcctClassName.Text = (string) null;
    ((ARControl) this.txtAcctClassName).Top = 3f / 16f;
    ((ARControl) this.txtAcctClassName).Width = 7.875f;
    ((Section) this.gfAccountClass).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.AcctClassName1,
      (ARControl) this.AcctClassName2,
      (ARControl) this.txtAccountClassTotal,
      (ARControl) this.txtAccountClassTotal_Total,
      (ARControl) this.txtAccountClassTotal_BalForward
    });
    this.gfAccountClass.Height = 0.2083333f;
    ((Section) this.gfAccountClass).Name = "gfAccountClass";
    ((ARControl) this.AcctClassName1).DataField = "AcctClassName";
    ((ARControl) this.AcctClassName1).Height = 3f / 16f;
    ((ARControl) this.AcctClassName1).Left = 0.0f;
    ((ARControl) this.AcctClassName1).Name = "AcctClassName1";
    this.AcctClassName1.Style = "font-weight: bold; text-align: right";
    this.AcctClassName1.Text = (string) null;
    ((ARControl) this.AcctClassName1).Top = 0.0f;
    ((ARControl) this.AcctClassName1).Width = 3f;
    ((ARControl) this.AcctClassName2).Height = 3f / 16f;
    ((ARControl) this.AcctClassName2).Left = 3f;
    ((ARControl) this.AcctClassName2).Name = "AcctClassName2";
    this.AcctClassName2.Style = "font-weight: bold; text-align: right";
    this.AcctClassName2.Text = "Total:";
    ((ARControl) this.AcctClassName2).Top = 0.0f;
    ((ARControl) this.AcctClassName2).Width = 7f / 16f;
    ((ARControl) this.txtAccountClassTotal).DataField = "Amount";
    ((ARControl) this.txtAccountClassTotal).Height = 0.2f;
    ((ARControl) this.txtAccountClassTotal).Left = 5.25f;
    ((ARControl) this.txtAccountClassTotal).Name = "txtAccountClassTotal";
    this.txtAccountClassTotal.OutputFormat = resourceManager.GetString("txtAccountClassTotal.OutputFormat");
    this.txtAccountClassTotal.Style = "text-align: right; ddo-char-set: 0";
    this.txtAccountClassTotal.SummaryGroup = "ghAccountClass";
    this.txtAccountClassTotal.SummaryRunning = (SummaryRunning) 1;
    this.txtAccountClassTotal.SummaryType = (SummaryType) 3;
    this.txtAccountClassTotal.Text = (string) null;
    ((ARControl) this.txtAccountClassTotal).Top = 0.0f;
    ((ARControl) this.txtAccountClassTotal).Width = 1.313f;
    ((ARControl) this.txtAccountClassTotal_Total).DataField = "Total";
    ((ARControl) this.txtAccountClassTotal_Total).Height = 0.2f;
    ((ARControl) this.txtAccountClassTotal_Total).Left = 105f / 16f;
    ((ARControl) this.txtAccountClassTotal_Total).Name = "txtAccountClassTotal_Total";
    this.txtAccountClassTotal_Total.OutputFormat = resourceManager.GetString("txtAccountClassTotal_Total.OutputFormat");
    this.txtAccountClassTotal_Total.Style = "text-align: right; ddo-char-set: 0";
    this.txtAccountClassTotal_Total.SummaryGroup = "ghAccountClass";
    this.txtAccountClassTotal_Total.SummaryRunning = (SummaryRunning) 1;
    this.txtAccountClassTotal_Total.SummaryType = (SummaryType) 3;
    this.txtAccountClassTotal_Total.Text = (string) null;
    ((ARControl) this.txtAccountClassTotal_Total).Top = 0.0f;
    ((ARControl) this.txtAccountClassTotal_Total).Width = 1.313f;
    ((ARControl) this.txtAccountClassTotal_BalForward).DataField = "BalForward";
    ((ARControl) this.txtAccountClassTotal_BalForward).Height = 0.2f;
    ((ARControl) this.txtAccountClassTotal_BalForward).Left = 63f / 16f;
    ((ARControl) this.txtAccountClassTotal_BalForward).Name = "txtAccountClassTotal_BalForward";
    this.txtAccountClassTotal_BalForward.OutputFormat = resourceManager.GetString("txtAccountClassTotal_BalForward.OutputFormat");
    this.txtAccountClassTotal_BalForward.Style = "text-align: right; ddo-char-set: 0";
    this.txtAccountClassTotal_BalForward.SummaryGroup = "ghAccountClass";
    this.txtAccountClassTotal_BalForward.SummaryRunning = (SummaryRunning) 1;
    this.txtAccountClassTotal_BalForward.SummaryType = (SummaryType) 3;
    this.txtAccountClassTotal_BalForward.Text = (string) null;
    ((ARControl) this.txtAccountClassTotal_BalForward).Top = 0.0f;
    ((ARControl) this.txtAccountClassTotal_BalForward).Width = 1.313f;
    ((Section) this.ghAcctTypeDescription).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Current_AcctTypeDescription,
      (ARControl) this.Current_AcctClassName,
      (ARControl) this.txtAcctTypeDescription,
      (ARControl) this.Label3,
      (ARControl) this.Label4
    });
    this.ghAcctTypeDescription.DataField = "AcctTypeDescription";
    this.ghAcctTypeDescription.Height = 0.2083334f;
    ((Section) this.ghAcctTypeDescription).Name = "ghAcctTypeDescription";
    ((ARControl) this.Current_AcctTypeDescription).DataField = "AcctTypeDescription";
    ((ARControl) this.Current_AcctTypeDescription).Height = 1f / 16f;
    ((ARControl) this.Current_AcctTypeDescription).Left = 0.0f;
    ((ARControl) this.Current_AcctTypeDescription).Name = "Current_AcctTypeDescription";
    this.Current_AcctTypeDescription.Style = "background-color: Yellow";
    this.Current_AcctTypeDescription.Text = (string) null;
    ((ARControl) this.Current_AcctTypeDescription).Top = 0.0f;
    ((ARControl) this.Current_AcctTypeDescription).Visible = false;
    ((ARControl) this.Current_AcctTypeDescription).Width = 0.5f;
    ((ARControl) this.Current_AcctClassName).DataField = "AcctClassName";
    ((ARControl) this.Current_AcctClassName).Height = 1f / 16f;
    ((ARControl) this.Current_AcctClassName).Left = 0.5f;
    ((ARControl) this.Current_AcctClassName).Name = "Current_AcctClassName";
    this.Current_AcctClassName.Style = "background-color: Yellow";
    this.Current_AcctClassName.Text = (string) null;
    ((ARControl) this.Current_AcctClassName).Top = 0.0f;
    ((ARControl) this.Current_AcctClassName).Visible = false;
    ((ARControl) this.Current_AcctClassName).Width = 0.5f;
    ((ARControl) this.txtAcctTypeDescription).DataField = "AcctTypeDescription";
    ((ARControl) this.txtAcctTypeDescription).Height = 3f / 16f;
    ((ARControl) this.txtAcctTypeDescription).Left = 0.0f;
    ((ARControl) this.txtAcctTypeDescription).Name = "txtAcctTypeDescription";
    this.txtAcctTypeDescription.Text = (string) null;
    ((ARControl) this.txtAcctTypeDescription).Top = 0.0f;
    ((ARControl) this.txtAcctTypeDescription).Width = 5.625f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 5.875f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-weight: bold; text-align: right";
    this.Label3.Text = "";
    ((ARControl) this.Label3).Top = 0.0f;
    ((ARControl) this.Label3).Width = 2f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 0.0f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-weight: bold; text-align: right";
    this.Label4.Text = "";
    ((ARControl) this.Label4).Top = 0.0f;
    ((ARControl) this.Label4).Width = 0.25f;
    ((Section) this.gfAcctTypeDescription).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.AcctClassName3,
      (ARControl) this.TextBox1,
      (ARControl) this.txtAcctTypeTotal,
      (ARControl) this.txtAcctTypeTotal_Total,
      (ARControl) this.txtAcctTypeTotal_BalForward
    });
    this.gfAcctTypeDescription.Height = 9f / 32f;
    ((Section) this.gfAcctTypeDescription).Name = "gfAcctTypeDescription";
    ((ARControl) this.AcctClassName3).DataField = "AcctTypeDescription";
    ((ARControl) this.AcctClassName3).Height = 3f / 16f;
    ((ARControl) this.AcctClassName3).Left = 0.0f;
    ((ARControl) this.AcctClassName3).Name = "AcctClassName3";
    this.AcctClassName3.Style = "text-align: right";
    this.AcctClassName3.Text = (string) null;
    ((ARControl) this.AcctClassName3).Top = 0.08200002f;
    ((ARControl) this.AcctClassName3).Width = 3f;
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 3f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "text-align: right";
    this.TextBox1.Text = "Total:";
    ((ARControl) this.TextBox1).Top = 0.082f;
    ((ARControl) this.TextBox1).Width = 7f / 16f;
    ((ARControl) this.txtAcctTypeTotal).DataField = "Amount";
    ((ARControl) this.txtAcctTypeTotal).Height = 0.2f;
    ((ARControl) this.txtAcctTypeTotal).Left = 5.25f;
    ((ARControl) this.txtAcctTypeTotal).Name = "txtAcctTypeTotal";
    this.txtAcctTypeTotal.OutputFormat = resourceManager.GetString("txtAcctTypeTotal.OutputFormat");
    this.txtAcctTypeTotal.Style = "text-align: right; ddo-char-set: 0";
    this.txtAcctTypeTotal.SummaryGroup = "ghAcctTypeDescription";
    this.txtAcctTypeTotal.SummaryRunning = (SummaryRunning) 1;
    this.txtAcctTypeTotal.SummaryType = (SummaryType) 3;
    this.txtAcctTypeTotal.Text = (string) null;
    ((ARControl) this.txtAcctTypeTotal).Top = 0.082f;
    ((ARControl) this.txtAcctTypeTotal).Width = 1.313f;
    ((ARControl) this.txtAcctTypeTotal_Total).DataField = "Total";
    ((ARControl) this.txtAcctTypeTotal_Total).Height = 0.2f;
    ((ARControl) this.txtAcctTypeTotal_Total).Left = 105f / 16f;
    ((ARControl) this.txtAcctTypeTotal_Total).Name = "txtAcctTypeTotal_Total";
    this.txtAcctTypeTotal_Total.OutputFormat = resourceManager.GetString("txtAcctTypeTotal_Total.OutputFormat");
    this.txtAcctTypeTotal_Total.Style = "text-align: right; ddo-char-set: 0";
    this.txtAcctTypeTotal_Total.SummaryGroup = "ghAcctTypeDescription";
    this.txtAcctTypeTotal_Total.SummaryRunning = (SummaryRunning) 1;
    this.txtAcctTypeTotal_Total.SummaryType = (SummaryType) 3;
    this.txtAcctTypeTotal_Total.Text = (string) null;
    ((ARControl) this.txtAcctTypeTotal_Total).Top = 0.082f;
    ((ARControl) this.txtAcctTypeTotal_Total).Width = 1.313f;
    ((ARControl) this.txtAcctTypeTotal_BalForward).DataField = "BalForward";
    ((ARControl) this.txtAcctTypeTotal_BalForward).Height = 0.2f;
    ((ARControl) this.txtAcctTypeTotal_BalForward).Left = 63f / 16f;
    ((ARControl) this.txtAcctTypeTotal_BalForward).Name = "txtAcctTypeTotal_BalForward";
    this.txtAcctTypeTotal_BalForward.OutputFormat = resourceManager.GetString("txtAcctTypeTotal_BalForward.OutputFormat");
    this.txtAcctTypeTotal_BalForward.Style = "text-align: right; ddo-char-set: 0";
    this.txtAcctTypeTotal_BalForward.SummaryGroup = "ghAcctTypeDescription";
    this.txtAcctTypeTotal_BalForward.SummaryRunning = (SummaryRunning) 1;
    this.txtAcctTypeTotal_BalForward.SummaryType = (SummaryType) 3;
    this.txtAcctTypeTotal_BalForward.Text = (string) null;
    ((ARControl) this.txtAcctTypeTotal_BalForward).Top = 0.082f;
    ((ARControl) this.txtAcctTypeTotal_BalForward).Width = 1.313f;
    ((ARControl) this.Current_RollUpTo).DataField = "RollUpTo";
    ((ARControl) this.Current_RollUpTo).Height = 1f / 16f;
    ((ARControl) this.Current_RollUpTo).Left = 2.312f;
    ((ARControl) this.Current_RollUpTo).Name = "Current_RollUpTo";
    this.Current_RollUpTo.Style = "background-color: Yellow; ddo-char-set: 0";
    this.Current_RollUpTo.Text = (string) null;
    ((ARControl) this.Current_RollUpTo).Top = 0.0f;
    ((ARControl) this.Current_RollUpTo).Visible = false;
    ((ARControl) this.Current_RollUpTo).Width = 0.5f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.4f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((Section) this.ReportHeader);
    this.Sections.Add((Section) this.PageHeader);
    this.Sections.Add((Section) this.ghAccountClass);
    this.Sections.Add((Section) this.ghAcctTypeDescription);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.gfAcctTypeDescription);
    this.Sections.Add((Section) this.gfAccountClass);
    this.Sections.Add((Section) this.PageFooter);
    this.Sections.Add((Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.Current_GlAcctID).EndInit();
    ((ISupportInitialize) this.txtAcct).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.Current_ControlAcct).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.txtClientOffice).EndInit();
    ((ISupportInitialize) this.txtTrialBalancePeriod).EndInit();
    ((ISupportInitialize) this.txtCostCenter).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.txtAcctClassName).EndInit();
    ((ISupportInitialize) this.AcctClassName1).EndInit();
    ((ISupportInitialize) this.AcctClassName2).EndInit();
    ((ISupportInitialize) this.txtAccountClassTotal).EndInit();
    ((ISupportInitialize) this.txtAccountClassTotal_Total).EndInit();
    ((ISupportInitialize) this.txtAccountClassTotal_BalForward).EndInit();
    ((ISupportInitialize) this.Current_AcctTypeDescription).EndInit();
    ((ISupportInitialize) this.Current_AcctClassName).EndInit();
    ((ISupportInitialize) this.txtAcctTypeDescription).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.AcctClassName3).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.txtAcctTypeTotal).EndInit();
    ((ISupportInitialize) this.txtAcctTypeTotal_Total).EndInit();
    ((ISupportInitialize) this.txtAcctTypeTotal_BalForward).EndInit();
    ((ISupportInitialize) this.Current_RollUpTo).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void rptFinancials_TrialBalance_ReportStart(object sender, EventArgs e)
  {
    if (this._ds == null)
    {
      this._ds = new DataSet();
      using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
      {
        using (SqlCommand selectCommand = new SqlCommand("spFin_rptFinancials_TrialBalance", connection))
        {
          selectCommand.CommandType = CommandType.StoredProcedure;
          selectCommand.CommandTimeout = 0;
          selectCommand.Parameters.AddWithValue("@DateFrom", (object) this._DateFrom);
          selectCommand.Parameters.AddWithValue("@DateTo", (object) this._DateTo);
          selectCommand.Parameters.Add("@GlCompanyID", SqlDbType.Int);
          selectCommand.Parameters["@GlCompanyID"].Value = (object) this._GLCompanyID;
          selectCommand.Parameters.AddWithValue("@CostCenterIDs", (object) this._CostCenterIDs);
          using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
            sqlDataAdapter.Fill(this._ds);
        }
      }
    }
    this.BouncingProgress(true);
    this.txtClientOffice.Text = Database.Instance.QueryText.PerformScalarQueryString("SELECT Location FROM tblClientOffices WHERE OfficeID = " + this._GLCompanyID.ToString());
    this.txtTrialBalancePeriod.Text = $"{this._DateFrom.ToShortDateString()} - {this._DateTo.ToShortDateString()}";
    this.ShowPageNumbers();
    this.ShowPrintDateAndTime();
    this.DataSource = (object) this._ds.Tables[0];
    if (this._ds.Tables[1].Rows.Count <= 0)
      return;
    this.txtCostCenter.Value = (object) this._ds.Tables[1].Rows[0]["CostCenters"].ToString();
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAcct.Text, string.Empty, false) == 0)
      return;
    this.txtAcct.HyperLink = this.Current_GlAcctID.Text.ToString();
  }

  private void gfAcctTypeDescription_Format(object sender, EventArgs e)
  {
  }

  private void gfAccountClass_BeforePrint(object sender, EventArgs e)
  {
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.Current_RollUpTo.Text, "", false) == 0)
      return;
    this.txtAcct.Text = "   " + this.txtAcct.Text;
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new DateRangePicker("Trial Balance Date Range", false),
        (BaseReportControl) new OfficeThenMultiCostCenter("Office", false)
      };
    }
  }

  public override bool IsThreaded => true;

  public Database ReportDatabase
  {
    get => this._database;
    set => this._database = value;
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    DataTable source = new DataTable();
    source.Columns.Add("GL Account", typeof (string));
    source.Columns.Add("Account Name", typeof (string));
    source.Columns.Add("Account Type", typeof (string));
    source.Columns.Add("BalForward", typeof (Decimal));
    source.Columns.Add("Amount", typeof (Decimal));
    source.Columns.Add("Total", typeof (Decimal));
    DataRow[] dataRowArray = this._ds.Tables[0].Select("(NOT Total IS NULL)", "OrderMaster");
    int index = 0;
    while (index < dataRowArray.Length)
    {
      DataRow dataRow = dataRowArray[index];
      string str1 = dataRow["FullName"].ToString();
      int startIndex = checked (str1.IndexOf('-') + 2);
      string str2 = str1.Substring(startIndex, checked (str1.Length - startIndex));
      source.Rows.Add(dataRow["AcctNum"], (object) str2, dataRow["AcctTypeDescription"], (object) Conversions.ToDecimal(dataRow["BalForward"]), (object) Conversions.ToDecimal(dataRow["Amount"]), (object) Conversions.ToDecimal(dataRow["Total"]));
      checked { ++index; }
    }
    ExcelExport.ToExcel(source, SaveFileTo);
  }

  public override void Hyperlink(object sender, HyperLinkEventArgs e)
  {
    this._GLAccountIDs = e.HyperLink;
    this._SummaryView = false;
    this._entityGuid = Guid.Empty;
    this._excelOnly = false;
    rptAccountTransactionLedger rpt = new rptAccountTransactionLedger(this._GLCompanyID, this._CostCenterID, this._GLAccountIDs, this._DateFrom, this._DateTo, this._entityGuid, this._SummaryView, this._excelOnly);
    rpt.Run();
    rpt.Document.Name = $"Account Transaction Ledger - {e.HyperLink}";
    ReportFactory.Instance.ShowReport((SectionReport) rpt);
  }

  [field: AccessedThroughProperty("txtCostCenter")]
  private virtual TextBox txtCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAcctTypeTotal_Total")]
  private virtual TextBox txtAcctTypeTotal_Total { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAcctTypeTotal_BalForward")]
  private virtual TextBox txtAcctTypeTotal_BalForward { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAccountClassTotal_Total")]
  private virtual TextBox txtAccountClassTotal_Total { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAccountClassTotal_BalForward")]
  private virtual TextBox txtAccountClassTotal_BalForward { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  private virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghAccountClass")]
  private virtual GroupHeader ghAccountClass { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghAcctTypeDescription")]
  private virtual GroupHeader ghAcctTypeDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.Detail_BeforePrint);
      EventHandler eventHandler2 = new EventHandler(this.Detail_Format);
      Detail detail1 = this._Detail;
      if (detail1 != null)
      {
        ((Section) detail1).BeforePrint -= eventHandler1;
        ((Section) detail1).Format -= eventHandler2;
      }
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((Section) detail2).BeforePrint += eventHandler1;
      ((Section) detail2).Format += eventHandler2;
    }
  }

  private virtual GroupFooter gfAcctTypeDescription
  {
    get => this._gfAcctTypeDescription;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfAcctTypeDescription_Format);
      GroupFooter acctTypeDescription1 = this._gfAcctTypeDescription;
      if (acctTypeDescription1 != null)
        ((Section) acctTypeDescription1).Format -= eventHandler;
      this._gfAcctTypeDescription = value;
      GroupFooter acctTypeDescription2 = this._gfAcctTypeDescription;
      if (acctTypeDescription2 == null)
        return;
      ((Section) acctTypeDescription2).Format += eventHandler;
    }
  }

  private virtual GroupFooter gfAccountClass
  {
    get => this._gfAccountClass;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfAccountClass_BeforePrint);
      GroupFooter gfAccountClass1 = this._gfAccountClass;
      if (gfAccountClass1 != null)
        ((Section) gfAccountClass1).BeforePrint -= eventHandler;
      this._gfAccountClass = value;
      GroupFooter gfAccountClass2 = this._gfAccountClass;
      if (gfAccountClass2 == null)
        return;
      ((Section) gfAccountClass2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
