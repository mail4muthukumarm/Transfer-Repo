// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptFinancials_BalanceSheet
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Viewer.Win;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{D9DFACE0-4B6B-4dc7-A370-63B9BC036221}", "Balance Sheet", "Balance Sheet", "Financials")]
public class rptFinancials_BalanceSheet : MGAReport, IReport
{
  private int _CompanyID;
  private string _ComparisonType;
  private DateTime _PriorTo;
  private DataTable _dt;
  private DateTime _DateFrom;
  private int _CostCenterID;
  private string _GLAccountIDs;
  private bool _SummaryView;
  private Guid _entityGuid;
  private bool _excelOnly;
  private Label Label9;
  private TextBox txtDate;
  private Label lblCompany;
  private Label lblBucket1;
  private Label lblBucket2;
  private Label lblBucket3;
  private TextBox txtAcctClassName;
  private TextBox txtAcctTypeDescription;
  private TextBox TextBox2;
  private TextBox txtBucket1_AcctTypeDescription_Total;
  private TextBox txtBucket2_AcctTypeDescription_Total;
  private TextBox txtBucket3_AcctTypeDescription_Total;
  private TextBox TextBox;
  private TextBox TextBox6;
  private TextBox txtBucket1_AcctClassName_Total;
  private TextBox txtBucket2_AcctClassName_Total;
  private TextBox txtBucket3_AcctClassName_Total;
  private Line Line;
  private Line Line1;
  private Line Line2;
  private TextBox TextBox1;
  private TextBox TextBox3;
  private TextBox txtTotAmount;
  private TextBox txtTotCompareAmount;
  private TextBox txtTotChangeAmount;

  [field: AccessedThroughProperty("TextBox4")]
  private virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDtlCompareAmount")]
  private virtual TextBox txtDtlCompareAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDtlChangeAmount")]
  private virtual TextBox txtDtlChangeAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFullName")]
  private virtual TextBox txtFullName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDtlPercentChange")]
  private virtual TextBox txtDtlPercentChange { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtGhAcctTypePercentChange")]
  private virtual TextBox txtGhAcctTypePercentChange { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtGhAcctClassPercentageChange")]
  private virtual TextBox txtGhAcctClassPercentageChange { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line3")]
  private virtual Line Line3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTotChangePercent")]
  private virtual TextBox txtTotChangePercent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GLAcctID")]
  private virtual TextBox GLAcctID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptFinancials_BalanceSheet()
  {
    this.ReportStart += new EventHandler(this.rptFinancials_BalanceSheet_ReportStart);
    this._DateFrom = Conversions.ToDate("1/1/1900");
    this._CostCenterID = 0;
    this.ReportHeader = (ReportHeader) null;
    this.PageHeader = (PageHeader) null;
    this.ghGrandTotal = (GroupHeader) null;
    this.ghAcctClassName = (GroupHeader) null;
    this.ghAcctTypeDescription = (GroupHeader) null;
    this.Detail = (Detail) null;
    this.gfAcctTypeDescription = (GroupFooter) null;
    this.gfAcctClassName = (GroupFooter) null;
    this.gfGrandTotal = (GroupFooter) null;
    this.PageFooter = (PageFooter) null;
    this.ReportFooter = (ReportFooter) null;
    this.Label9 = (Label) null;
    this.txtDate = (TextBox) null;
    this.lblCompany = (Label) null;
    this.lblBucket1 = (Label) null;
    this.lblBucket2 = (Label) null;
    this.lblBucket3 = (Label) null;
    this.txtAcctClassName = (TextBox) null;
    this.txtAcctTypeDescription = (TextBox) null;
    this.TextBox2 = (TextBox) null;
    this.txtBucket1_AcctTypeDescription_Total = (TextBox) null;
    this.txtBucket2_AcctTypeDescription_Total = (TextBox) null;
    this.txtBucket3_AcctTypeDescription_Total = (TextBox) null;
    this.TextBox = (TextBox) null;
    this.TextBox6 = (TextBox) null;
    this.txtBucket1_AcctClassName_Total = (TextBox) null;
    this.txtBucket2_AcctClassName_Total = (TextBox) null;
    this.txtBucket3_AcctClassName_Total = (TextBox) null;
    this.Line = (Line) null;
    this.Line1 = (Line) null;
    this.Line2 = (Line) null;
    this.TextBox1 = (TextBox) null;
    this.TextBox3 = (TextBox) null;
    this.txtTotAmount = (TextBox) null;
    this.txtTotCompareAmount = (TextBox) null;
    this.txtTotChangeAmount = (TextBox) null;
    this.InitializeComponent();
  }

  public rptFinancials_BalanceSheet(int CompanyID, string ComparisonType, DateTime PriorTo)
  {
    this.ReportStart += new EventHandler(this.rptFinancials_BalanceSheet_ReportStart);
    this._DateFrom = Conversions.ToDate("1/1/1900");
    this._CostCenterID = 0;
    this.ReportHeader = (ReportHeader) null;
    this.PageHeader = (PageHeader) null;
    this.ghGrandTotal = (GroupHeader) null;
    this.ghAcctClassName = (GroupHeader) null;
    this.ghAcctTypeDescription = (GroupHeader) null;
    this.Detail = (Detail) null;
    this.gfAcctTypeDescription = (GroupFooter) null;
    this.gfAcctClassName = (GroupFooter) null;
    this.gfGrandTotal = (GroupFooter) null;
    this.PageFooter = (PageFooter) null;
    this.ReportFooter = (ReportFooter) null;
    this.Label9 = (Label) null;
    this.txtDate = (TextBox) null;
    this.lblCompany = (Label) null;
    this.lblBucket1 = (Label) null;
    this.lblBucket2 = (Label) null;
    this.lblBucket3 = (Label) null;
    this.txtAcctClassName = (TextBox) null;
    this.txtAcctTypeDescription = (TextBox) null;
    this.TextBox2 = (TextBox) null;
    this.txtBucket1_AcctTypeDescription_Total = (TextBox) null;
    this.txtBucket2_AcctTypeDescription_Total = (TextBox) null;
    this.txtBucket3_AcctTypeDescription_Total = (TextBox) null;
    this.TextBox = (TextBox) null;
    this.TextBox6 = (TextBox) null;
    this.txtBucket1_AcctClassName_Total = (TextBox) null;
    this.txtBucket2_AcctClassName_Total = (TextBox) null;
    this.txtBucket3_AcctClassName_Total = (TextBox) null;
    this.Line = (Line) null;
    this.Line1 = (Line) null;
    this.Line2 = (Line) null;
    this.TextBox1 = (TextBox) null;
    this.TextBox3 = (TextBox) null;
    this.txtTotAmount = (TextBox) null;
    this.txtTotCompareAmount = (TextBox) null;
    this.txtTotChangeAmount = (TextBox) null;
    this.InitializeComponent();
    this._CompanyID = CompanyID;
    this._ComparisonType = ComparisonType;
    this._PriorTo = PriorTo;
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghGrandTotal")]
  private virtual GroupHeader ghGrandTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghAcctClassName")]
  private virtual GroupHeader ghAcctClassName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghAcctTypeDescription")]
  private virtual GroupHeader ghAcctTypeDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_BeforePrint);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).BeforePrint -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gfAcctTypeDescription")]
  private virtual GroupFooter gfAcctTypeDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfAcctClassName")]
  private virtual GroupFooter gfAcctClassName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfGrandTotal")]
  private virtual GroupFooter gfGrandTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptFinancials_BalanceSheet));
    this.Detail = new Detail();
    this.TextBox4 = new TextBox();
    this.txtDtlCompareAmount = new TextBox();
    this.txtDtlChangeAmount = new TextBox();
    this.txtFullName = new TextBox();
    this.txtDtlPercentChange = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.Label9 = new Label();
    this.txtDate = new TextBox();
    this.lblCompany = new Label();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.lblBucket1 = new Label();
    this.lblBucket2 = new Label();
    this.lblBucket3 = new Label();
    this.Label1 = new Label();
    this.PageFooter = new PageFooter();
    this.ghGrandTotal = new GroupHeader();
    this.gfGrandTotal = new GroupFooter();
    this.TextBox3 = new TextBox();
    this.txtTotAmount = new TextBox();
    this.txtTotCompareAmount = new TextBox();
    this.txtTotChangeAmount = new TextBox();
    this.txtTotChangePercent = new TextBox();
    this.ghAcctClassName = new GroupHeader();
    this.txtAcctClassName = new TextBox();
    this.gfAcctClassName = new GroupFooter();
    this.TextBox6 = new TextBox();
    this.txtBucket1_AcctClassName_Total = new TextBox();
    this.txtBucket2_AcctClassName_Total = new TextBox();
    this.txtBucket3_AcctClassName_Total = new TextBox();
    this.Line = new Line();
    this.Line1 = new Line();
    this.Line2 = new Line();
    this.TextBox1 = new TextBox();
    this.txtGhAcctClassPercentageChange = new TextBox();
    this.Line3 = new Line();
    this.ghAcctTypeDescription = new GroupHeader();
    this.txtAcctTypeDescription = new TextBox();
    this.gfAcctTypeDescription = new GroupFooter();
    this.TextBox2 = new TextBox();
    this.txtBucket1_AcctTypeDescription_Total = new TextBox();
    this.txtBucket2_AcctTypeDescription_Total = new TextBox();
    this.txtBucket3_AcctTypeDescription_Total = new TextBox();
    this.TextBox = new TextBox();
    this.txtGhAcctTypePercentChange = new TextBox();
    this.GLAcctID = new TextBox();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.txtDtlCompareAmount).BeginInit();
    ((ISupportInitialize) this.txtDtlChangeAmount).BeginInit();
    ((ISupportInitialize) this.txtFullName).BeginInit();
    ((ISupportInitialize) this.txtDtlPercentChange).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.txtDate).BeginInit();
    ((ISupportInitialize) this.lblCompany).BeginInit();
    ((ISupportInitialize) this.lblBucket1).BeginInit();
    ((ISupportInitialize) this.lblBucket2).BeginInit();
    ((ISupportInitialize) this.lblBucket3).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.txtTotAmount).BeginInit();
    ((ISupportInitialize) this.txtTotCompareAmount).BeginInit();
    ((ISupportInitialize) this.txtTotChangeAmount).BeginInit();
    ((ISupportInitialize) this.txtTotChangePercent).BeginInit();
    ((ISupportInitialize) this.txtAcctClassName).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.txtBucket1_AcctClassName_Total).BeginInit();
    ((ISupportInitialize) this.txtBucket2_AcctClassName_Total).BeginInit();
    ((ISupportInitialize) this.txtBucket3_AcctClassName_Total).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.txtGhAcctClassPercentageChange).BeginInit();
    ((ISupportInitialize) this.txtAcctTypeDescription).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.txtBucket1_AcctTypeDescription_Total).BeginInit();
    ((ISupportInitialize) this.txtBucket2_AcctTypeDescription_Total).BeginInit();
    ((ISupportInitialize) this.txtBucket3_AcctTypeDescription_Total).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.txtGhAcctTypePercentChange).BeginInit();
    ((ISupportInitialize) this.GLAcctID).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).CanShrink = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.TextBox4,
      (ARControl) this.txtDtlCompareAmount,
      (ARControl) this.txtDtlChangeAmount,
      (ARControl) this.txtFullName,
      (ARControl) this.txtDtlPercentChange,
      (ARControl) this.GLAcctID
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1354167f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox4).DataField = "Amount";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 75f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "font-size: 8pt; text-align: right";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 1.625f;
    ((ARControl) this.txtDtlCompareAmount).DataField = "CompareAmount";
    ((ARControl) this.txtDtlCompareAmount).Height = 0.125f;
    ((ARControl) this.txtDtlCompareAmount).Left = 6.375f;
    ((ARControl) this.txtDtlCompareAmount).Name = "txtDtlCompareAmount";
    this.txtDtlCompareAmount.OutputFormat = resourceManager.GetString("txtDtlCompareAmount.OutputFormat");
    this.txtDtlCompareAmount.Style = "font-size: 8pt; text-align: right";
    this.txtDtlCompareAmount.Text = " ";
    ((ARControl) this.txtDtlCompareAmount).Top = 0.0f;
    ((ARControl) this.txtDtlCompareAmount).Width = 1.625f;
    ((ARControl) this.txtDtlChangeAmount).DataField = "ChangeAmount";
    ((ARControl) this.txtDtlChangeAmount).Height = 0.125f;
    ((ARControl) this.txtDtlChangeAmount).Left = 129f / 16f;
    ((ARControl) this.txtDtlChangeAmount).Name = "txtDtlChangeAmount";
    this.txtDtlChangeAmount.OutputFormat = resourceManager.GetString("txtDtlChangeAmount.OutputFormat");
    this.txtDtlChangeAmount.Style = "font-size: 8pt; text-align: right";
    this.txtDtlChangeAmount.Text = " ";
    ((ARControl) this.txtDtlChangeAmount).Top = 0.0f;
    ((ARControl) this.txtDtlChangeAmount).Width = 1.625f;
    ((ARControl) this.txtFullName).DataField = "FullName";
    ((ARControl) this.txtFullName).Height = 0.125f;
    ((ARControl) this.txtFullName).Left = 0.5f;
    ((ARControl) this.txtFullName).Name = "txtFullName";
    this.txtFullName.Style = "font-size: 8pt; font-weight: bold";
    this.txtFullName.Text = (string) null;
    ((ARControl) this.txtFullName).Top = 0.0f;
    ((ARControl) this.txtFullName).Width = 4.125f;
    ((ARControl) this.txtDtlPercentChange).Height = 0.125f;
    ((ARControl) this.txtDtlPercentChange).Left = 9.75f;
    ((ARControl) this.txtDtlPercentChange).Name = "txtDtlPercentChange";
    this.txtDtlPercentChange.OutputFormat = resourceManager.GetString("txtDtlPercentChange.OutputFormat");
    this.txtDtlPercentChange.Style = "font-size: 8pt; text-align: right";
    this.txtDtlPercentChange.Text = " ";
    ((ARControl) this.txtDtlPercentChange).Top = 0.0f;
    ((ARControl) this.txtDtlPercentChange).Width = 0.625f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label9,
      (ARControl) this.txtDate,
      (ARControl) this.lblCompany
    });
    this.ReportHeader.Height = 23f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.Label9).Height = 0.25f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 0.0f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 14pt; font-weight: bold; text-align: center";
    this.Label9.Text = "Balance Sheet";
    ((ARControl) this.Label9).Top = 0.25f;
    ((ARControl) this.Label9).Width = 10.375f;
    ((ARControl) this.txtDate).Height = 3f / 16f;
    ((ARControl) this.txtDate).Left = 0.0f;
    ((ARControl) this.txtDate).Name = "txtDate";
    this.txtDate.Style = "text-align: center; ddo-char-set: 0";
    this.txtDate.Text = "As of {0}";
    ((ARControl) this.txtDate).Top = 0.5f;
    ((ARControl) this.txtDate).Width = 10.375f;
    ((ARControl) this.lblCompany).Height = 0.25f;
    this.lblCompany.HyperLink = (string) null;
    ((ARControl) this.lblCompany).Left = 0.0f;
    ((ARControl) this.lblCompany).Name = "lblCompany";
    this.lblCompany.Style = "font-size: 14pt; font-weight: bold; text-align: center";
    this.lblCompany.Text = "";
    ((ARControl) this.lblCompany).Top = 0.0f;
    ((ARControl) this.lblCompany).Width = 10.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).CanShrink = true;
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.lblBucket1,
      (ARControl) this.lblBucket2,
      (ARControl) this.lblBucket3,
      (ARControl) this.Label1
    });
    this.PageHeader.Height = 0.1979167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.lblBucket1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBucket1).Height = 3f / 16f;
    this.lblBucket1.HyperLink = (string) null;
    ((ARControl) this.lblBucket1).Left = 75f / 16f;
    ((ARControl) this.lblBucket1).Name = "lblBucket1";
    this.lblBucket1.Style = "font-size: 8pt; font-weight: bold; text-align: center";
    this.lblBucket1.Text = " ";
    ((ARControl) this.lblBucket1).Top = 0.0f;
    ((ARControl) this.lblBucket1).Width = 1.625f;
    ((ARControl) this.lblBucket2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBucket2).Height = 3f / 16f;
    this.lblBucket2.HyperLink = (string) null;
    ((ARControl) this.lblBucket2).Left = 6.375f;
    ((ARControl) this.lblBucket2).Name = "lblBucket2";
    this.lblBucket2.Style = "font-size: 8pt; font-weight: bold; text-align: center";
    this.lblBucket2.Text = " ";
    ((ARControl) this.lblBucket2).Top = 0.0f;
    ((ARControl) this.lblBucket2).Width = 1.625f;
    ((ARControl) this.lblBucket3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBucket3).Height = 3f / 16f;
    this.lblBucket3.HyperLink = (string) null;
    ((ARControl) this.lblBucket3).Left = 129f / 16f;
    ((ARControl) this.lblBucket3).Name = "lblBucket3";
    this.lblBucket3.Style = "font-size: 8pt; font-weight: bold; text-align: center";
    this.lblBucket3.Text = " $ Change";
    ((ARControl) this.lblBucket3).Top = 0.0f;
    ((ARControl) this.lblBucket3).Width = 1.625f;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 9.75f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 8pt; font-weight: bold; text-align: center";
    this.Label1.Text = " % Change";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 0.625f;
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.ghGrandTotal.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghGrandTotal).Name = "ghGrandTotal";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfGrandTotal).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.TextBox3,
      (ARControl) this.txtTotAmount,
      (ARControl) this.txtTotCompareAmount,
      (ARControl) this.txtTotChangeAmount,
      (ARControl) this.txtTotChangePercent
    });
    this.gfGrandTotal.Height = 7f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfGrandTotal).Name = "gfGrandTotal";
    ((ARControl) this.TextBox3).Height = 0.188f;
    ((ARControl) this.TextBox3).Left = 0.0f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.TextBox3.Text = "Total Liabilities and Equity";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 3f;
    ((ARControl) this.txtTotAmount).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtTotAmount).Height = 0.188f;
    ((ARControl) this.txtTotAmount).Left = 75f / 16f;
    ((ARControl) this.txtTotAmount).Name = "txtTotAmount";
    this.txtTotAmount.OutputFormat = resourceManager.GetString("txtTotAmount.OutputFormat");
    this.txtTotAmount.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.txtTotAmount.Text = " ";
    ((ARControl) this.txtTotAmount).Top = 0.0f;
    ((ARControl) this.txtTotAmount).Width = 1.625f;
    ((ARControl) this.txtTotCompareAmount).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtTotCompareAmount).Height = 0.188f;
    ((ARControl) this.txtTotCompareAmount).Left = 6.375f;
    ((ARControl) this.txtTotCompareAmount).Name = "txtTotCompareAmount";
    this.txtTotCompareAmount.OutputFormat = resourceManager.GetString("txtTotCompareAmount.OutputFormat");
    this.txtTotCompareAmount.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.txtTotCompareAmount.Text = " ";
    ((ARControl) this.txtTotCompareAmount).Top = 0.0f;
    ((ARControl) this.txtTotCompareAmount).Width = 1.625f;
    ((ARControl) this.txtTotChangeAmount).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtTotChangeAmount).Height = 0.188f;
    ((ARControl) this.txtTotChangeAmount).Left = 129f / 16f;
    ((ARControl) this.txtTotChangeAmount).Name = "txtTotChangeAmount";
    this.txtTotChangeAmount.OutputFormat = resourceManager.GetString("txtTotChangeAmount.OutputFormat");
    this.txtTotChangeAmount.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.txtTotChangeAmount.Text = " ";
    ((ARControl) this.txtTotChangeAmount).Top = 0.0f;
    ((ARControl) this.txtTotChangeAmount).Width = 1.625f;
    ((ARControl) this.txtTotChangePercent).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtTotChangePercent).Height = 0.188f;
    ((ARControl) this.txtTotChangePercent).Left = 9.75f;
    ((ARControl) this.txtTotChangePercent).Name = "txtTotChangePercent";
    this.txtTotChangePercent.OutputFormat = resourceManager.GetString("txtTotChangePercent.OutputFormat");
    this.txtTotChangePercent.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.txtTotChangePercent.Text = " ";
    ((ARControl) this.txtTotChangePercent).Top = 0.0f;
    ((ARControl) this.txtTotChangePercent).Width = 0.625f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName).CanShrink = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtAcctClassName
    });
    this.ghAcctClassName.DataField = "AcctClassName";
    this.ghAcctClassName.Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName).Name = "ghAcctClassName";
    ((ARControl) this.txtAcctClassName).DataField = "AcctClassName";
    ((ARControl) this.txtAcctClassName).Height = 0.125f;
    ((ARControl) this.txtAcctClassName).Left = 0.0f;
    ((ARControl) this.txtAcctClassName).Name = "txtAcctClassName";
    this.txtAcctClassName.Style = "font-size: 8pt; font-weight: bold";
    this.txtAcctClassName.Text = (string) null;
    ((ARControl) this.txtAcctClassName).Top = 0.0f;
    ((ARControl) this.txtAcctClassName).Width = 4.625f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassName).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.TextBox6,
      (ARControl) this.txtBucket1_AcctClassName_Total,
      (ARControl) this.txtBucket2_AcctClassName_Total,
      (ARControl) this.txtBucket3_AcctClassName_Total,
      (ARControl) this.Line,
      (ARControl) this.Line1,
      (ARControl) this.Line2,
      (ARControl) this.TextBox1,
      (ARControl) this.txtGhAcctClassPercentageChange,
      (ARControl) this.Line3
    });
    this.gfAcctClassName.Height = 0.2291667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassName).Name = "gfAcctClassName";
    ((ARControl) this.TextBox6).DataField = "AcctClassName";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 7f / 16f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 67f / 16f;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtBucket1_AcctClassName_Total).DataField = "Amount";
    ((ARControl) this.txtBucket1_AcctClassName_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Left = 75f / 16f;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Name = "txtBucket1_AcctClassName_Total";
    this.txtBucket1_AcctClassName_Total.OutputFormat = resourceManager.GetString("txtBucket1_AcctClassName_Total.OutputFormat");
    this.txtBucket1_AcctClassName_Total.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.txtBucket1_AcctClassName_Total.SummaryGroup = "ghAcctClassName";
    this.txtBucket1_AcctClassName_Total.SummaryRunning = (SummaryRunning) 1;
    this.txtBucket1_AcctClassName_Total.SummaryType = (SummaryType) 3;
    this.txtBucket1_AcctClassName_Total.Text = " ";
    ((ARControl) this.txtBucket1_AcctClassName_Total).Top = 0.0f;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Width = 1.625f;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtBucket2_AcctClassName_Total).DataField = "CompareAmount";
    ((ARControl) this.txtBucket2_AcctClassName_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Left = 6.375f;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Name = "txtBucket2_AcctClassName_Total";
    this.txtBucket2_AcctClassName_Total.OutputFormat = resourceManager.GetString("txtBucket2_AcctClassName_Total.OutputFormat");
    this.txtBucket2_AcctClassName_Total.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.txtBucket2_AcctClassName_Total.SummaryGroup = "ghAcctClassName";
    this.txtBucket2_AcctClassName_Total.SummaryRunning = (SummaryRunning) 1;
    this.txtBucket2_AcctClassName_Total.SummaryType = (SummaryType) 3;
    this.txtBucket2_AcctClassName_Total.Text = " ";
    ((ARControl) this.txtBucket2_AcctClassName_Total).Top = 0.0f;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Width = 1.625f;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtBucket3_AcctClassName_Total).DataField = "ChangeAmount";
    ((ARControl) this.txtBucket3_AcctClassName_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Left = 129f / 16f;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Name = "txtBucket3_AcctClassName_Total";
    this.txtBucket3_AcctClassName_Total.OutputFormat = resourceManager.GetString("txtBucket3_AcctClassName_Total.OutputFormat");
    this.txtBucket3_AcctClassName_Total.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.txtBucket3_AcctClassName_Total.SummaryGroup = "ghAcctClassName";
    this.txtBucket3_AcctClassName_Total.SummaryRunning = (SummaryRunning) 1;
    this.txtBucket3_AcctClassName_Total.SummaryType = (SummaryType) 3;
    this.txtBucket3_AcctClassName_Total.Text = " ";
    ((ARControl) this.txtBucket3_AcctClassName_Total).Top = 0.0f;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Width = 1.625f;
    ((ARControl) this.Line).Height = 0.0f;
    ((ARControl) this.Line).Left = 75f / 16f;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    ((ARControl) this.Line).Top = 0.22f;
    ((ARControl) this.Line).Width = 1.625f;
    this.Line.X1 = 75f / 16f;
    this.Line.X2 = 101f / 16f;
    this.Line.Y1 = 0.22f;
    this.Line.Y2 = 0.22f;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 6.375f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 0.22f;
    ((ARControl) this.Line1).Width = 1.625f;
    this.Line1.X1 = 6.375f;
    this.Line1.X2 = 8f;
    this.Line1.Y1 = 0.22f;
    this.Line1.Y2 = 0.22f;
    ((ARControl) this.Line2).Height = 0.0f;
    ((ARControl) this.Line2).Left = 129f / 16f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 0.22f;
    ((ARControl) this.Line2).Width = 1.625f;
    this.Line2.X1 = 129f / 16f;
    this.Line2.X2 = 155f / 16f;
    this.Line2.Y1 = 0.22f;
    this.Line2.Y2 = 0.22f;
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.TextBox1.Text = "TOTAL";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 7f / 16f;
    ((ARControl) this.txtGhAcctClassPercentageChange).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtGhAcctClassPercentageChange).Height = 3f / 16f;
    ((ARControl) this.txtGhAcctClassPercentageChange).Left = 9.75f;
    ((ARControl) this.txtGhAcctClassPercentageChange).Name = "txtGhAcctClassPercentageChange";
    this.txtGhAcctClassPercentageChange.OutputFormat = resourceManager.GetString("txtGhAcctClassPercentageChange.OutputFormat");
    this.txtGhAcctClassPercentageChange.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.txtGhAcctClassPercentageChange.Text = (string) null;
    ((ARControl) this.txtGhAcctClassPercentageChange).Top = 0.0f;
    ((ARControl) this.txtGhAcctClassPercentageChange).Width = 0.625f;
    ((ARControl) this.Line3).Height = 0.0f;
    ((ARControl) this.Line3).Left = 9.75f;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    ((ARControl) this.Line3).Top = 0.22f;
    ((ARControl) this.Line3).Width = 0.625f;
    this.Line3.X1 = 9.75f;
    this.Line3.X2 = 10.375f;
    this.Line3.Y1 = 0.22f;
    this.Line3.Y2 = 0.22f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription).CanShrink = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtAcctTypeDescription
    });
    this.ghAcctTypeDescription.DataField = "AcctTypeDescription";
    this.ghAcctTypeDescription.Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription).Name = "ghAcctTypeDescription";
    ((ARControl) this.txtAcctTypeDescription).DataField = "AcctTypeDescription";
    ((ARControl) this.txtAcctTypeDescription).Height = 0.125f;
    ((ARControl) this.txtAcctTypeDescription).Left = 3f / 16f;
    ((ARControl) this.txtAcctTypeDescription).Name = "txtAcctTypeDescription";
    this.txtAcctTypeDescription.Style = "font-size: 8pt; font-weight: bold";
    this.txtAcctTypeDescription.Text = (string) null;
    ((ARControl) this.txtAcctTypeDescription).Top = 0.0f;
    ((ARControl) this.txtAcctTypeDescription).Width = 71f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).CanShrink = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.txtBucket1_AcctTypeDescription_Total,
      (ARControl) this.txtBucket2_AcctTypeDescription_Total,
      (ARControl) this.txtBucket3_AcctTypeDescription_Total,
      (ARControl) this.TextBox,
      (ARControl) this.txtGhAcctTypePercentChange
    });
    this.gfAcctTypeDescription.Height = 0.1979167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).Name = "gfAcctTypeDescription";
    ((ARControl) this.TextBox2).DataField = "AcctTypeDescription";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 0.5f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 4.125f;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).DataField = "Amount";
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Left = 75f / 16f;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Name = "txtBucket1_AcctTypeDescription_Total";
    this.txtBucket1_AcctTypeDescription_Total.OutputFormat = resourceManager.GetString("txtBucket1_AcctTypeDescription_Total.OutputFormat");
    this.txtBucket1_AcctTypeDescription_Total.Style = "font-size: 8pt; text-align: right; vertical-align: bottom";
    this.txtBucket1_AcctTypeDescription_Total.SummaryGroup = "ghAcctTypeDescription";
    this.txtBucket1_AcctTypeDescription_Total.SummaryRunning = (SummaryRunning) 1;
    this.txtBucket1_AcctTypeDescription_Total.SummaryType = (SummaryType) 3;
    this.txtBucket1_AcctTypeDescription_Total.Text = " ";
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Top = 0.0f;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Width = 1.625f;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).DataField = "CompareAmount";
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Left = 6.375f;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Name = "txtBucket2_AcctTypeDescription_Total";
    this.txtBucket2_AcctTypeDescription_Total.OutputFormat = resourceManager.GetString("txtBucket2_AcctTypeDescription_Total.OutputFormat");
    this.txtBucket2_AcctTypeDescription_Total.Style = "font-size: 8pt; text-align: right; vertical-align: bottom";
    this.txtBucket2_AcctTypeDescription_Total.SummaryGroup = "ghAcctTypeDescription";
    this.txtBucket2_AcctTypeDescription_Total.SummaryRunning = (SummaryRunning) 1;
    this.txtBucket2_AcctTypeDescription_Total.SummaryType = (SummaryType) 3;
    this.txtBucket2_AcctTypeDescription_Total.Text = " ";
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Top = 0.0f;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Width = 1.625f;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).DataField = "ChangeAmount";
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Left = 129f / 16f;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Name = "txtBucket3_AcctTypeDescription_Total";
    this.txtBucket3_AcctTypeDescription_Total.OutputFormat = resourceManager.GetString("txtBucket3_AcctTypeDescription_Total.OutputFormat");
    this.txtBucket3_AcctTypeDescription_Total.Style = "font-size: 8pt; text-align: right; vertical-align: bottom";
    this.txtBucket3_AcctTypeDescription_Total.SummaryGroup = "ghAcctTypeDescription";
    this.txtBucket3_AcctTypeDescription_Total.SummaryRunning = (SummaryRunning) 1;
    this.txtBucket3_AcctTypeDescription_Total.SummaryType = (SummaryType) 3;
    this.txtBucket3_AcctTypeDescription_Total.Text = " ";
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Top = 0.0f;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Width = 1.625f;
    ((ARControl) this.TextBox).Height = 3f / 16f;
    ((ARControl) this.TextBox).Left = 3f / 16f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.TextBox.Text = "Total";
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 5f / 16f;
    ((ARControl) this.txtGhAcctTypePercentChange).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGhAcctTypePercentChange).Height = 3f / 16f;
    ((ARControl) this.txtGhAcctTypePercentChange).Left = 9.75f;
    ((ARControl) this.txtGhAcctTypePercentChange).Name = "txtGhAcctTypePercentChange";
    this.txtGhAcctTypePercentChange.OutputFormat = resourceManager.GetString("txtGhAcctTypePercentChange.OutputFormat");
    this.txtGhAcctTypePercentChange.Style = "font-size: 8pt; text-align: right; vertical-align: bottom";
    this.txtGhAcctTypePercentChange.SummaryGroup = "ghAcctTypeDescription";
    this.txtGhAcctTypePercentChange.SummaryRunning = (SummaryRunning) 1;
    this.txtGhAcctTypePercentChange.SummaryType = (SummaryType) 3;
    this.txtGhAcctTypePercentChange.Text = " ";
    ((ARControl) this.txtGhAcctTypePercentChange).Top = 0.0f;
    ((ARControl) this.txtGhAcctTypePercentChange).Width = 0.625f;
    ((ARControl) this.GLAcctID).DataField = "GLAcctID";
    ((ARControl) this.GLAcctID).Height = 1f / 16f;
    ((ARControl) this.GLAcctID).Left = 0.062f;
    ((ARControl) this.GLAcctID).Name = "GLAcctID";
    this.GLAcctID.Style = "background-color: Yellow; font-size: 1pt";
    this.GLAcctID.Text = (string) null;
    ((ARControl) this.GLAcctID).Top = 0.036f;
    ((ARControl) this.GLAcctID).Visible = false;
    ((ARControl) this.GLAcctID).Width = 0.375f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.5f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghGrandTotal);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfGrandTotal);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.txtDtlCompareAmount).EndInit();
    ((ISupportInitialize) this.txtDtlChangeAmount).EndInit();
    ((ISupportInitialize) this.txtFullName).EndInit();
    ((ISupportInitialize) this.txtDtlPercentChange).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.txtDate).EndInit();
    ((ISupportInitialize) this.lblCompany).EndInit();
    ((ISupportInitialize) this.lblBucket1).EndInit();
    ((ISupportInitialize) this.lblBucket2).EndInit();
    ((ISupportInitialize) this.lblBucket3).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.txtTotAmount).EndInit();
    ((ISupportInitialize) this.txtTotCompareAmount).EndInit();
    ((ISupportInitialize) this.txtTotChangeAmount).EndInit();
    ((ISupportInitialize) this.txtTotChangePercent).EndInit();
    ((ISupportInitialize) this.txtAcctClassName).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.txtBucket1_AcctClassName_Total).EndInit();
    ((ISupportInitialize) this.txtBucket2_AcctClassName_Total).EndInit();
    ((ISupportInitialize) this.txtBucket3_AcctClassName_Total).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.txtGhAcctClassPercentageChange).EndInit();
    ((ISupportInitialize) this.txtAcctTypeDescription).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.txtBucket1_AcctTypeDescription_Total).EndInit();
    ((ISupportInitialize) this.txtBucket2_AcctTypeDescription_Total).EndInit();
    ((ISupportInitialize) this.txtBucket3_AcctTypeDescription_Total).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.txtGhAcctTypePercentChange).EndInit();
    ((ISupportInitialize) this.GLAcctID).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void rptFinancials_BalanceSheet_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.HidePrintDateAndTime();
    this._dt = Database.Instance.QuerySP.PerformTableQuery("spFin_rptFinancials_BalanceSheet", (object) "@GlCompanyID", (object) this._CompanyID, (object) "@ComparisonType", (object) this._ComparisonType, (object) "@PriorTo", (object) this._PriorTo);
    if (this._dt.Rows.Count <= 0)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._ComparisonType, "M", false) == 0)
    {
      this.lblBucket1.Text = this._PriorTo.ToString("MM/dd/yyyy");
      this.lblBucket2.Text = Conversions.ToDate(this._dt.Rows[0]["CompareDate"]).ToString("MM/dd/yyyy");
    }
    else
    {
      this.lblBucket1.Text = this._PriorTo.ToString("MM/dd/yyyy");
      this.lblBucket2.Text = Conversions.ToDate(this._dt.Rows[0]["CompareDate"]).ToString("MM/dd/yyyy");
    }
    this.lblCompany.Text = Database.Instance.QueryText.PerformScalarQueryString($"SELECT TOP 1 Location FROM tblClientOffices WHERE OfficeID = {this._CompanyID}");
    this.txtDate.Text = string.Format(this.txtDate.Text, (object) this._PriorTo.ToString("MM/dd/yyyy"));
    this.DataSource = (object) this._dt;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Format += new EventHandler(this.Detail_Format);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).Format += new EventHandler(this.gfAcctTypeDescription_Format);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassName).Format += new EventHandler(this.gfAcctClassName_Format);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfGrandTotal).Format += new EventHandler(this.gfGrandTotal_Format);
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtFullName.Text, string.Empty, false) == 0)
      return;
    this.txtFullName.HyperLink = this.GLAcctID.Text.ToString();
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    this.txtDtlPercentChange.Value = (object) (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.txtDtlCompareAmount.Value, (object) 0, false) ? Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.DivideObject(this.txtDtlChangeAmount.Value, this.txtDtlCompareAmount.Value)) : 0M);
  }

  private void gfAcctTypeDescription_Format(object sender, EventArgs e)
  {
    this.txtGhAcctTypePercentChange.Value = (object) (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.txtBucket2_AcctTypeDescription_Total.Value, (object) 0, false) ? Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.DivideObject(this.txtBucket3_AcctTypeDescription_Total.Value, this.txtBucket2_AcctTypeDescription_Total.Value)) : 0M);
  }

  private void gfAcctClassName_Format(object sender, EventArgs e)
  {
    this.txtGhAcctClassPercentageChange.Value = (object) (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.txtBucket2_AcctClassName_Total.Value, (object) 0, false) ? Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.DivideObject(this.txtBucket3_AcctClassName_Total.Value, this.txtBucket2_AcctClassName_Total.Value)) : 0M);
  }

  private void gfGrandTotal_Format(object sender, EventArgs e)
  {
    this.txtTotAmount.Value = (object) Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this._dt.Compute("SUM(Amount)", "AcctClassName IN ('Liabilities', 'Equity')")));
    this.txtTotCompareAmount.Value = (object) Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this._dt.Compute("SUM(CompareAmount)", "AcctClassName IN ('Liabilities', 'Equity')")));
    this.txtTotChangeAmount.Value = Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(this.txtTotAmount.Value, this.txtTotCompareAmount.Value);
    this.txtTotChangePercent.Value = (object) (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.txtTotCompareAmount.Value, (object) 0, false) ? Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.DivideObject(this.txtTotChangeAmount.Value, this.txtTotCompareAmount.Value)) : 0M);
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dt, SaveFileTo);
  }

  public override void Hyperlink(object sender, HyperLinkEventArgs e)
  {
    this._GLAccountIDs = e.HyperLink;
    this._SummaryView = false;
    this._entityGuid = Guid.Empty;
    this._excelOnly = false;
    rptAccountTransactionLedger rpt = new rptAccountTransactionLedger(this._CompanyID, this._CostCenterID, this._GLAccountIDs, this._DateFrom, this._PriorTo, this._entityGuid, this._SummaryView, this._excelOnly);
    rpt.Run();
    rpt.Document.Name = $"Account Transaction Ledger - {e.HyperLink}";
    ReportFactory.Instance.ShowReport((SectionReport) rpt);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new AccountingOfficeLocations("Office", false, true),
        (BaseReportControl) new RadioSelection("Comparison", "Monthly", (object) "M", "Yearly", (object) "Y", RadioSelection.ButtonLayout.Vertical),
        (BaseReportControl) new DatePicker("Prior To", DateAndTime.Now, false)
      };
    }
  }
}
