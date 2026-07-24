// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptFinancials_IncomeStatement
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.Export.Excel.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Viewer.Win;
using MGASystems.Data;
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
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{0EDBE26E-6675-42d9-8D3A-9F8E5E3F1FE8}", "Income Statement", "Income Statement", "Financials")]
public class rptFinancials_IncomeStatement : MGAReport, IReport
{
  private readonly int _CompanyID;
  private readonly int _CostCenterID;
  private readonly string _ComparisonType;
  private DateTime _dateFrom;
  private DateTime _priorTo;
  private DataTable _dt;
  private readonly string _formatType;
  private string _glAccountIDs;
  private bool _summaryView;
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
  private TextBox AcctTypeID;
  private SubReport srDetails;
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
  private TextBox txtTotAmount;
  private TextBox txtTotCompareAmount;
  private TextBox txtTotChangeAmount;
  private Line Line3;
  private Line Line4;
  private Line Line5;
  private TextBox TextBox8;

  public rptFinancials_IncomeStatement()
  {
    this.ReportStart += new EventHandler(this.rptFinancials_IncomeStatement_ReportStart);
    this._CostCenterID = 0;
    this.InitializeComponent();
  }

  public rptFinancials_IncomeStatement(
    int CompanyID,
    string ComparisonType,
    DateTime DateFrom,
    DateTime PriorTo)
  {
    this.ReportStart += new EventHandler(this.rptFinancials_IncomeStatement_ReportStart);
    this._CostCenterID = 0;
    this.InitializeComponent();
    this._CompanyID = CompanyID;
    this._ComparisonType = ComparisonType;
    this._dateFrom = DateFrom;
    this._priorTo = PriorTo;
  }

  public rptFinancials_IncomeStatement(
    int CompanyID,
    int CostCenterId,
    string ComparisonType,
    DateTime DateFrom,
    DateTime PriorTo,
    string reportType)
  {
    this.ReportStart += new EventHandler(this.rptFinancials_IncomeStatement_ReportStart);
    this._CostCenterID = 0;
    this.InitializeComponent();
    this._CompanyID = CompanyID;
    this._CostCenterID = CostCenterId;
    this._ComparisonType = ComparisonType;
    this._dateFrom = DateFrom;
    this._priorTo = PriorTo;
    this._formatType = reportType;
  }

  public rptFinancials_IncomeStatement(
    DataTable dtIncomeStatement,
    string ComparisonType,
    DateTime DateFrom,
    DateTime PriorTo)
  {
    this.ReportStart += new EventHandler(this.rptFinancials_IncomeStatement_ReportStart);
    this._CostCenterID = 0;
    this.InitializeComponent();
    this._dt = dtIncomeStatement;
    this._ComparisonType = ComparisonType;
    this._priorTo = PriorTo;
    this._dateFrom = DateFrom;
    this._CostCenterID = 0;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptFinancials_IncomeStatement));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.Label9 = new Label();
    this.txtDate = new TextBox();
    this.lblCompany = new Label();
    this.textCostCenter = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.txtTotAmount = new TextBox();
    this.txtTotCompareAmount = new TextBox();
    this.txtTotChangeAmount = new TextBox();
    this.Line3 = new Line();
    this.Line4 = new Line();
    this.Line5 = new Line();
    this.TextBox8 = new TextBox();
    this.PageHeader = new PageHeader();
    this.lblBucket1 = new Label();
    this.lblBucket2 = new Label();
    this.lblBucket3 = new Label();
    this.PageFooter = new PageFooter();
    this.ghAcctClassName = new GroupHeader();
    this.txtAcctClassName = new TextBox();
    this.OrderMaster = new TextBox();
    this.gfAcctClassName = new GroupFooter();
    this.TextBox6 = new TextBox();
    this.txtBucket1_AcctClassName_Total = new TextBox();
    this.txtBucket2_AcctClassName_Total = new TextBox();
    this.txtBucket3_AcctClassName_Total = new TextBox();
    this.Line = new Line();
    this.Line1 = new Line();
    this.Line2 = new Line();
    this.TextBox1 = new TextBox();
    this.ghAcctTypeDescription = new GroupHeader();
    this.txtAcctTypeDescription = new TextBox();
    this.AcctTypeID = new TextBox();
    this.gfAcctTypeDescription = new GroupFooter();
    this.TextBox2 = new TextBox();
    this.txtBucket1_AcctTypeDescription_Total = new TextBox();
    this.txtBucket2_AcctTypeDescription_Total = new TextBox();
    this.txtBucket3_AcctTypeDescription_Total = new TextBox();
    this.TextBox = new TextBox();
    this.ghFullName = new GroupHeader();
    this.gfFullName = new GroupFooter();
    this.srDetails = new SubReport();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.txtDate).BeginInit();
    ((ISupportInitialize) this.lblCompany).BeginInit();
    ((ISupportInitialize) this.textCostCenter).BeginInit();
    ((ISupportInitialize) this.txtTotAmount).BeginInit();
    ((ISupportInitialize) this.txtTotCompareAmount).BeginInit();
    ((ISupportInitialize) this.txtTotChangeAmount).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.lblBucket1).BeginInit();
    ((ISupportInitialize) this.lblBucket2).BeginInit();
    ((ISupportInitialize) this.lblBucket3).BeginInit();
    ((ISupportInitialize) this.txtAcctClassName).BeginInit();
    ((ISupportInitialize) this.OrderMaster).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.txtBucket1_AcctClassName_Total).BeginInit();
    ((ISupportInitialize) this.txtBucket2_AcctClassName_Total).BeginInit();
    ((ISupportInitialize) this.txtBucket3_AcctClassName_Total).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.txtAcctTypeDescription).BeginInit();
    ((ISupportInitialize) this.AcctTypeID).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.txtBucket1_AcctTypeDescription_Total).BeginInit();
    ((ISupportInitialize) this.txtBucket2_AcctTypeDescription_Total).BeginInit();
    ((ISupportInitialize) this.txtBucket3_AcctTypeDescription_Total).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).CanShrink = true;
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.0f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Label9,
      (ARControl) this.txtDate,
      (ARControl) this.lblCompany,
      (ARControl) this.textCostCenter
    });
    this.ReportHeader.Height = 0.9479167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.Label9).Border.BottomColor = Color.Black;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftColor = Color.Black;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightColor = Color.Black;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopColor = Color.Black;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Height = 0.25f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 0.0f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "text-align: center; font-weight: bold; font-size: 14pt; ";
    this.Label9.Text = "Income Statement";
    ((ARControl) this.Label9).Top = 0.25f;
    ((ARControl) this.Label9).Width = 10.375f;
    ((ARControl) this.txtDate).Border.BottomColor = Color.Black;
    ((ARControl) this.txtDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate).Border.LeftColor = Color.Black;
    ((ARControl) this.txtDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate).Border.RightColor = Color.Black;
    ((ARControl) this.txtDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate).Border.TopColor = Color.Black;
    ((ARControl) this.txtDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate).Height = 3f / 16f;
    ((ARControl) this.txtDate).Left = 0.0f;
    ((ARControl) this.txtDate).Name = "txtDate";
    this.txtDate.Style = "ddo-char-set: 0; text-align: center; ";
    this.txtDate.Text = "{0} - {1}";
    ((ARControl) this.txtDate).Top = 0.5f;
    ((ARControl) this.txtDate).Width = 10.375f;
    ((ARControl) this.lblCompany).Border.BottomColor = Color.Black;
    ((ARControl) this.lblCompany).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCompany).Border.LeftColor = Color.Black;
    ((ARControl) this.lblCompany).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCompany).Border.RightColor = Color.Black;
    ((ARControl) this.lblCompany).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCompany).Border.TopColor = Color.Black;
    ((ARControl) this.lblCompany).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCompany).Height = 0.25f;
    this.lblCompany.HyperLink = (string) null;
    ((ARControl) this.lblCompany).Left = 0.0f;
    ((ARControl) this.lblCompany).Name = "lblCompany";
    this.lblCompany.Style = "text-align: center; font-weight: bold; font-size: 14pt; ";
    this.lblCompany.Text = "";
    ((ARControl) this.lblCompany).Top = 0.0f;
    ((ARControl) this.lblCompany).Width = 10.375f;
    ((ARControl) this.textCostCenter).Border.BottomColor = Color.Black;
    ((ARControl) this.textCostCenter).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textCostCenter).Border.LeftColor = Color.Black;
    ((ARControl) this.textCostCenter).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textCostCenter).Border.RightColor = Color.Black;
    ((ARControl) this.textCostCenter).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textCostCenter).Border.TopColor = Color.Black;
    ((ARControl) this.textCostCenter).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textCostCenter).Height = 3f / 16f;
    ((ARControl) this.textCostCenter).Left = 0.0f;
    ((ARControl) this.textCostCenter).Name = "textCostCenter";
    this.textCostCenter.Style = "ddo-char-set: 0; text-align: center; ";
    this.textCostCenter.Text = (string) null;
    ((ARControl) this.textCostCenter).Top = 11f / 16f;
    ((ARControl) this.textCostCenter).Width = 10.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).CanShrink = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.txtTotAmount,
      (ARControl) this.txtTotCompareAmount,
      (ARControl) this.txtTotChangeAmount,
      (ARControl) this.Line3,
      (ARControl) this.Line4,
      (ARControl) this.Line5,
      (ARControl) this.TextBox8
    });
    this.ReportFooter.Height = 0.5506945f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.txtTotAmount).Border.BottomColor = Color.Black;
    ((ARControl) this.txtTotAmount).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtTotAmount).Border.LeftColor = Color.Black;
    ((ARControl) this.txtTotAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotAmount).Border.RightColor = Color.Black;
    ((ARControl) this.txtTotAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotAmount).Border.TopColor = Color.Black;
    ((ARControl) this.txtTotAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotAmount).Height = 3f / 16f;
    ((ARControl) this.txtTotAmount).Left = 4.625f;
    ((ARControl) this.txtTotAmount).Name = "txtTotAmount";
    this.txtTotAmount.OutputFormat = resourceManager.GetString("txtTotAmount.OutputFormat");
    this.txtTotAmount.Style = "text-align: right; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.txtTotAmount.SummaryRunning = (SummaryRunning) 2;
    this.txtTotAmount.SummaryType = (SummaryType) 1;
    this.txtTotAmount.Text = " ";
    ((ARControl) this.txtTotAmount).Top = 5f / 16f;
    ((ARControl) this.txtTotAmount).Width = 1.875f;
    ((ARControl) this.txtTotCompareAmount).Border.BottomColor = Color.Black;
    ((ARControl) this.txtTotCompareAmount).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtTotCompareAmount).Border.LeftColor = Color.Black;
    ((ARControl) this.txtTotCompareAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotCompareAmount).Border.RightColor = Color.Black;
    ((ARControl) this.txtTotCompareAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotCompareAmount).Border.TopColor = Color.Black;
    ((ARControl) this.txtTotCompareAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotCompareAmount).Height = 3f / 16f;
    ((ARControl) this.txtTotCompareAmount).Left = 105f / 16f;
    ((ARControl) this.txtTotCompareAmount).Name = "txtTotCompareAmount";
    this.txtTotCompareAmount.OutputFormat = resourceManager.GetString("txtTotCompareAmount.OutputFormat");
    this.txtTotCompareAmount.Style = "text-align: right; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.txtTotCompareAmount.SummaryRunning = (SummaryRunning) 2;
    this.txtTotCompareAmount.SummaryType = (SummaryType) 1;
    this.txtTotCompareAmount.Text = " ";
    ((ARControl) this.txtTotCompareAmount).Top = 5f / 16f;
    ((ARControl) this.txtTotCompareAmount).Width = 1.875f;
    ((ARControl) this.txtTotChangeAmount).Border.BottomColor = Color.Black;
    ((ARControl) this.txtTotChangeAmount).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtTotChangeAmount).Border.LeftColor = Color.Black;
    ((ARControl) this.txtTotChangeAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotChangeAmount).Border.RightColor = Color.Black;
    ((ARControl) this.txtTotChangeAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotChangeAmount).Border.TopColor = Color.Black;
    ((ARControl) this.txtTotChangeAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotChangeAmount).Height = 3f / 16f;
    ((ARControl) this.txtTotChangeAmount).Left = 8.5f;
    ((ARControl) this.txtTotChangeAmount).Name = "txtTotChangeAmount";
    this.txtTotChangeAmount.OutputFormat = resourceManager.GetString("txtTotChangeAmount.OutputFormat");
    this.txtTotChangeAmount.Style = "text-align: right; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.txtTotChangeAmount.SummaryRunning = (SummaryRunning) 2;
    this.txtTotChangeAmount.SummaryType = (SummaryType) 1;
    this.txtTotChangeAmount.Text = " ";
    ((ARControl) this.txtTotChangeAmount).Top = 5f / 16f;
    ((ARControl) this.txtTotChangeAmount).Width = 1.875f;
    this.Line3.Border.BottomColor = Color.Black;
    this.Line3.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line3.Border.LeftColor = Color.Black;
    this.Line3.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line3.Border.RightColor = Color.Black;
    this.Line3.Border.RightStyle = (BorderLineStyle) 0;
    this.Line3.Border.TopColor = Color.Black;
    this.Line3.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line3).Height = 0.0f;
    ((ARControl) this.Line3).Left = 4.625f;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    ((ARControl) this.Line3).Top = 17f / 32f;
    ((ARControl) this.Line3).Width = 1.875f;
    this.Line3.X1 = 4.625f;
    this.Line3.X2 = 6.5f;
    this.Line3.Y1 = 17f / 32f;
    this.Line3.Y2 = 17f / 32f;
    this.Line4.Border.BottomColor = Color.Black;
    this.Line4.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line4.Border.LeftColor = Color.Black;
    this.Line4.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line4.Border.RightColor = Color.Black;
    this.Line4.Border.RightStyle = (BorderLineStyle) 0;
    this.Line4.Border.TopColor = Color.Black;
    this.Line4.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line4).Height = 0.0f;
    ((ARControl) this.Line4).Left = 105f / 16f;
    this.Line4.LineWeight = 1f;
    ((ARControl) this.Line4).Name = "Line4";
    ((ARControl) this.Line4).Top = 17f / 32f;
    ((ARControl) this.Line4).Width = 1.875f;
    this.Line4.X1 = 105f / 16f;
    this.Line4.X2 = 135f / 16f;
    this.Line4.Y1 = 17f / 32f;
    this.Line4.Y2 = 17f / 32f;
    this.Line5.Border.BottomColor = Color.Black;
    this.Line5.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line5.Border.LeftColor = Color.Black;
    this.Line5.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line5.Border.RightColor = Color.Black;
    this.Line5.Border.RightStyle = (BorderLineStyle) 0;
    this.Line5.Border.TopColor = Color.Black;
    this.Line5.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line5).Height = 0.0f;
    ((ARControl) this.Line5).Left = 8.5f;
    this.Line5.LineWeight = 1f;
    ((ARControl) this.Line5).Name = "Line5";
    ((ARControl) this.Line5).Top = 17f / 32f;
    ((ARControl) this.Line5).Width = 1.875f;
    this.Line5.X1 = 8.5f;
    this.Line5.X2 = 10.375f;
    this.Line5.Y1 = 17f / 32f;
    this.Line5.Y2 = 17f / 32f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Height = 0.25f;
    ((ARControl) this.TextBox8).Left = 0.0f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "ddo-char-set: 0; font-weight: bold; font-size: 11.25pt; vertical-align: bottom; ";
    this.TextBox8.Text = "Profit / (Loss)";
    ((ARControl) this.TextBox8).Top = 0.25f;
    ((ARControl) this.TextBox8).Width = 1.875f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.lblBucket1,
      (ARControl) this.lblBucket2,
      (ARControl) this.lblBucket3
    });
    this.PageHeader.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.lblBucket1).Border.BottomColor = Color.Black;
    ((ARControl) this.lblBucket1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBucket1).Border.LeftColor = Color.Black;
    ((ARControl) this.lblBucket1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBucket1).Border.RightColor = Color.Black;
    ((ARControl) this.lblBucket1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBucket1).Border.TopColor = Color.Black;
    ((ARControl) this.lblBucket1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBucket1).Height = 3f / 16f;
    this.lblBucket1.HyperLink = (string) null;
    ((ARControl) this.lblBucket1).Left = 4.625f;
    ((ARControl) this.lblBucket1).Name = "lblBucket1";
    this.lblBucket1.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.lblBucket1.Text = " ";
    ((ARControl) this.lblBucket1).Top = 0.0f;
    ((ARControl) this.lblBucket1).Width = 1.875f;
    ((ARControl) this.lblBucket2).Border.BottomColor = Color.Black;
    ((ARControl) this.lblBucket2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBucket2).Border.LeftColor = Color.Black;
    ((ARControl) this.lblBucket2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBucket2).Border.RightColor = Color.Black;
    ((ARControl) this.lblBucket2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBucket2).Border.TopColor = Color.Black;
    ((ARControl) this.lblBucket2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBucket2).Height = 3f / 16f;
    this.lblBucket2.HyperLink = (string) null;
    ((ARControl) this.lblBucket2).Left = 105f / 16f;
    ((ARControl) this.lblBucket2).Name = "lblBucket2";
    this.lblBucket2.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.lblBucket2.Text = " ";
    ((ARControl) this.lblBucket2).Top = 0.0f;
    ((ARControl) this.lblBucket2).Width = 1.875f;
    ((ARControl) this.lblBucket3).Border.BottomColor = Color.Black;
    ((ARControl) this.lblBucket3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBucket3).Border.LeftColor = Color.Black;
    ((ARControl) this.lblBucket3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBucket3).Border.RightColor = Color.Black;
    ((ARControl) this.lblBucket3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBucket3).Border.TopColor = Color.Black;
    ((ARControl) this.lblBucket3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBucket3).Height = 3f / 16f;
    this.lblBucket3.HyperLink = (string) null;
    ((ARControl) this.lblBucket3).Left = 8.5f;
    ((ARControl) this.lblBucket3).Name = "lblBucket3";
    this.lblBucket3.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.lblBucket3.Text = " $ Change";
    ((ARControl) this.lblBucket3).Top = 0.0f;
    ((ARControl) this.lblBucket3).Width = 1.875f;
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName).CanShrink = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtAcctClassName,
      (ARControl) this.OrderMaster
    });
    this.ghAcctClassName.DataField = "OrderMaster";
    this.ghAcctClassName.Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName).Name = "ghAcctClassName";
    ((ARControl) this.txtAcctClassName).Border.BottomColor = Color.Black;
    ((ARControl) this.txtAcctClassName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctClassName).Border.LeftColor = Color.Black;
    ((ARControl) this.txtAcctClassName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctClassName).Border.RightColor = Color.Black;
    ((ARControl) this.txtAcctClassName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctClassName).Border.TopColor = Color.Black;
    ((ARControl) this.txtAcctClassName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctClassName).DataField = "AcctClassName";
    ((ARControl) this.txtAcctClassName).Height = 0.125f;
    ((ARControl) this.txtAcctClassName).Left = 0.0f;
    ((ARControl) this.txtAcctClassName).Name = "txtAcctClassName";
    this.txtAcctClassName.Style = "font-weight: bold; font-size: 8pt; ";
    this.txtAcctClassName.Text = (string) null;
    ((ARControl) this.txtAcctClassName).Top = 0.0f;
    ((ARControl) this.txtAcctClassName).Width = 4.625f;
    ((ARControl) this.OrderMaster).Border.BottomColor = Color.Black;
    ((ARControl) this.OrderMaster).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.OrderMaster).Border.LeftColor = Color.Black;
    ((ARControl) this.OrderMaster).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.OrderMaster).Border.RightColor = Color.Black;
    ((ARControl) this.OrderMaster).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.OrderMaster).Border.TopColor = Color.Black;
    ((ARControl) this.OrderMaster).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.OrderMaster).DataField = "OrderMaster";
    ((ARControl) this.OrderMaster).Height = 1f / 16f;
    ((ARControl) this.OrderMaster).Left = 0.0f;
    ((ARControl) this.OrderMaster).Name = "OrderMaster";
    this.OrderMaster.Style = "background-color: Yellow; font-size: 1pt; ";
    this.OrderMaster.Text = (string) null;
    ((ARControl) this.OrderMaster).Top = 0.0f;
    ((ARControl) this.OrderMaster).Visible = false;
    ((ARControl) this.OrderMaster).Width = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassName).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.TextBox6,
      (ARControl) this.txtBucket1_AcctClassName_Total,
      (ARControl) this.txtBucket2_AcctClassName_Total,
      (ARControl) this.txtBucket3_AcctClassName_Total,
      (ARControl) this.Line,
      (ARControl) this.Line1,
      (ARControl) this.Line2,
      (ARControl) this.TextBox1
    });
    this.gfAcctClassName.Height = 7f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassName).Name = "gfAcctClassName";
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "AcctClassName";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 7f / 16f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 67f / 16f;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Border.BottomColor = Color.Black;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Border.LeftColor = Color.Black;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Border.RightColor = Color.Black;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Border.TopColor = Color.Black;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Left = 4.625f;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Name = "txtBucket1_AcctClassName_Total";
    this.txtBucket1_AcctClassName_Total.OutputFormat = resourceManager.GetString("txtBucket1_AcctClassName_Total.OutputFormat");
    this.txtBucket1_AcctClassName_Total.Style = "text-align: right; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.txtBucket1_AcctClassName_Total.Text = " ";
    ((ARControl) this.txtBucket1_AcctClassName_Total).Top = 0.0f;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Width = 1.875f;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Border.BottomColor = Color.Black;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Border.LeftColor = Color.Black;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Border.RightColor = Color.Black;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Border.TopColor = Color.Black;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Left = 105f / 16f;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Name = "txtBucket2_AcctClassName_Total";
    this.txtBucket2_AcctClassName_Total.OutputFormat = resourceManager.GetString("txtBucket2_AcctClassName_Total.OutputFormat");
    this.txtBucket2_AcctClassName_Total.Style = "text-align: right; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.txtBucket2_AcctClassName_Total.Text = " ";
    ((ARControl) this.txtBucket2_AcctClassName_Total).Top = 0.0f;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Width = 1.875f;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Border.BottomColor = Color.Black;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Border.LeftColor = Color.Black;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Border.RightColor = Color.Black;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Border.TopColor = Color.Black;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Left = 8.5f;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Name = "txtBucket3_AcctClassName_Total";
    this.txtBucket3_AcctClassName_Total.OutputFormat = resourceManager.GetString("txtBucket3_AcctClassName_Total.OutputFormat");
    this.txtBucket3_AcctClassName_Total.Style = "text-align: right; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.txtBucket3_AcctClassName_Total.Text = " ";
    ((ARControl) this.txtBucket3_AcctClassName_Total).Top = 0.0f;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Width = 1.875f;
    this.Line.Border.BottomColor = Color.Black;
    this.Line.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line.Border.LeftColor = Color.Black;
    this.Line.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line.Border.RightColor = Color.Black;
    this.Line.Border.RightStyle = (BorderLineStyle) 0;
    this.Line.Border.TopColor = Color.Black;
    this.Line.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line).Height = 0.0f;
    ((ARControl) this.Line).Left = 4.625f;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    ((ARControl) this.Line).Top = 7f / 32f;
    ((ARControl) this.Line).Width = 1.875f;
    this.Line.X1 = 4.625f;
    this.Line.X2 = 6.5f;
    this.Line.Y1 = 7f / 32f;
    this.Line.Y2 = 7f / 32f;
    this.Line1.Border.BottomColor = Color.Black;
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftColor = Color.Black;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightColor = Color.Black;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopColor = Color.Black;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 105f / 16f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 7f / 32f;
    ((ARControl) this.Line1).Width = 1.875f;
    this.Line1.X1 = 105f / 16f;
    this.Line1.X2 = 135f / 16f;
    this.Line1.Y1 = 7f / 32f;
    this.Line1.Y2 = 7f / 32f;
    this.Line2.Border.BottomColor = Color.Black;
    this.Line2.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line2.Border.LeftColor = Color.Black;
    this.Line2.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line2.Border.RightColor = Color.Black;
    this.Line2.Border.RightStyle = (BorderLineStyle) 0;
    this.Line2.Border.TopColor = Color.Black;
    this.Line2.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line2).Height = 0.0f;
    ((ARControl) this.Line2).Left = 8.5f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 7f / 32f;
    ((ARControl) this.Line2).Width = 1.875f;
    this.Line2.X1 = 8.5f;
    this.Line2.X2 = 10.375f;
    this.Line2.Y1 = 7f / 32f;
    this.Line2.Y2 = 7f / 32f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.TextBox1.Text = "TOTAL";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 7f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription).CanShrink = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtAcctTypeDescription,
      (ARControl) this.AcctTypeID
    });
    this.ghAcctTypeDescription.DataField = "AcctTypeID";
    this.ghAcctTypeDescription.Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription).Name = "ghAcctTypeDescription";
    ((ARControl) this.txtAcctTypeDescription).Border.BottomColor = Color.Black;
    ((ARControl) this.txtAcctTypeDescription).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctTypeDescription).Border.LeftColor = Color.Black;
    ((ARControl) this.txtAcctTypeDescription).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctTypeDescription).Border.RightColor = Color.Black;
    ((ARControl) this.txtAcctTypeDescription).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctTypeDescription).Border.TopColor = Color.Black;
    ((ARControl) this.txtAcctTypeDescription).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctTypeDescription).DataField = "AcctTypeDescription";
    ((ARControl) this.txtAcctTypeDescription).Height = 0.125f;
    ((ARControl) this.txtAcctTypeDescription).Left = 3f / 16f;
    ((ARControl) this.txtAcctTypeDescription).Name = "txtAcctTypeDescription";
    this.txtAcctTypeDescription.Style = "font-weight: bold; font-size: 8pt; ";
    this.txtAcctTypeDescription.Text = (string) null;
    ((ARControl) this.txtAcctTypeDescription).Top = 0.0f;
    ((ARControl) this.txtAcctTypeDescription).Width = 71f / 16f;
    ((ARControl) this.AcctTypeID).Border.BottomColor = Color.Black;
    ((ARControl) this.AcctTypeID).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.AcctTypeID).Border.LeftColor = Color.Black;
    ((ARControl) this.AcctTypeID).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.AcctTypeID).Border.RightColor = Color.Black;
    ((ARControl) this.AcctTypeID).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.AcctTypeID).Border.TopColor = Color.Black;
    ((ARControl) this.AcctTypeID).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.AcctTypeID).DataField = "AcctTypeID";
    ((ARControl) this.AcctTypeID).Height = 1f / 16f;
    ((ARControl) this.AcctTypeID).Left = 0.0f;
    ((ARControl) this.AcctTypeID).Name = "AcctTypeID";
    this.AcctTypeID.Style = "background-color: Yellow; font-size: 1pt; ";
    this.AcctTypeID.Text = (string) null;
    ((ARControl) this.AcctTypeID).Top = 0.0f;
    ((ARControl) this.AcctTypeID).Visible = false;
    ((ARControl) this.AcctTypeID).Width = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).CanShrink = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.txtBucket1_AcctTypeDescription_Total,
      (ARControl) this.txtBucket2_AcctTypeDescription_Total,
      (ARControl) this.txtBucket3_AcctTypeDescription_Total,
      (ARControl) this.TextBox
    });
    this.gfAcctTypeDescription.Height = 0.1666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).Name = "gfAcctTypeDescription";
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "AcctTypeDescription";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 0.5f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 4.125f;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Border.BottomColor = Color.Black;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Border.LeftColor = Color.Black;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Border.RightColor = Color.Black;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Border.TopColor = Color.Black;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Left = 4.625f;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Name = "txtBucket1_AcctTypeDescription_Total";
    this.txtBucket1_AcctTypeDescription_Total.OutputFormat = resourceManager.GetString("txtBucket1_AcctTypeDescription_Total.OutputFormat");
    this.txtBucket1_AcctTypeDescription_Total.Style = "text-align: right; font-size: 8pt; vertical-align: bottom; ";
    this.txtBucket1_AcctTypeDescription_Total.Text = " ";
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Top = 0.0f;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Width = 1.875f;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Border.BottomColor = Color.Black;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Border.LeftColor = Color.Black;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Border.RightColor = Color.Black;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Border.TopColor = Color.Black;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Left = 105f / 16f;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Name = "txtBucket2_AcctTypeDescription_Total";
    this.txtBucket2_AcctTypeDescription_Total.OutputFormat = resourceManager.GetString("txtBucket2_AcctTypeDescription_Total.OutputFormat");
    this.txtBucket2_AcctTypeDescription_Total.Style = "text-align: right; font-size: 8pt; vertical-align: bottom; ";
    this.txtBucket2_AcctTypeDescription_Total.Text = " ";
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Top = 0.0f;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Width = 1.875f;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Border.BottomColor = Color.Black;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Border.LeftColor = Color.Black;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Border.RightColor = Color.Black;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Border.TopColor = Color.Black;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Left = 8.5f;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Name = "txtBucket3_AcctTypeDescription_Total";
    this.txtBucket3_AcctTypeDescription_Total.OutputFormat = resourceManager.GetString("txtBucket3_AcctTypeDescription_Total.OutputFormat");
    this.txtBucket3_AcctTypeDescription_Total.Style = "text-align: right; font-size: 8pt; vertical-align: bottom; ";
    this.txtBucket3_AcctTypeDescription_Total.Text = " ";
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Top = 0.0f;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Width = 1.875f;
    ((ARControl) this.TextBox).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Height = 3f / 16f;
    ((ARControl) this.TextBox).Left = 3f / 16f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.TextBox.Text = "Total";
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 5f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghFullName).CanShrink = true;
    this.ghFullName.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghFullName).Name = "ghFullName";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfFullName).CanShrink = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfFullName).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srDetails
    });
    this.gfFullName.Height = 0.1034722f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfFullName).Name = "gfFullName";
    ((ARControl) this.srDetails).Border.BottomColor = Color.Black;
    ((ARControl) this.srDetails).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srDetails).Border.LeftColor = Color.Black;
    ((ARControl) this.srDetails).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srDetails).Border.RightColor = Color.Black;
    ((ARControl) this.srDetails).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srDetails).Border.TopColor = Color.Black;
    ((ARControl) this.srDetails).Border.TopStyle = (BorderLineStyle) 0;
    this.srDetails.CloseBorder = false;
    ((ARControl) this.srDetails).Height = 0.125f;
    ((ARControl) this.srDetails).Left = 0.0f;
    ((ARControl) this.srDetails).Name = "srDetails";
    this.srDetails.Report = (SectionReport) null;
    ((ARControl) this.srDetails).Top = 0.0f;
    ((ARControl) this.srDetails).Width = 10.375f;
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
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghFullName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfFullName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.txtDate).EndInit();
    ((ISupportInitialize) this.lblCompany).EndInit();
    ((ISupportInitialize) this.textCostCenter).EndInit();
    ((ISupportInitialize) this.txtTotAmount).EndInit();
    ((ISupportInitialize) this.txtTotCompareAmount).EndInit();
    ((ISupportInitialize) this.txtTotChangeAmount).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.lblBucket1).EndInit();
    ((ISupportInitialize) this.lblBucket2).EndInit();
    ((ISupportInitialize) this.lblBucket3).EndInit();
    ((ISupportInitialize) this.txtAcctClassName).EndInit();
    ((ISupportInitialize) this.OrderMaster).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.txtBucket1_AcctClassName_Total).EndInit();
    ((ISupportInitialize) this.txtBucket2_AcctClassName_Total).EndInit();
    ((ISupportInitialize) this.txtBucket3_AcctClassName_Total).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.txtAcctTypeDescription).EndInit();
    ((ISupportInitialize) this.AcctTypeID).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.txtBucket1_AcctTypeDescription_Total).EndInit();
    ((ISupportInitialize) this.txtBucket2_AcctTypeDescription_Total).EndInit();
    ((ISupportInitialize) this.txtBucket3_AcctTypeDescription_Total).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void rptFinancials_IncomeStatement_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    if (this._dt == null)
    {
      if (this._CostCenterID == 0)
        this._dt = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spFin_rptFinancials_IncomeStatement", 300, (CommandArgumentType) 0, new object[8]
        {
          (object) "@GlCompanyID",
          (object) this._CompanyID,
          (object) "@ComparisonType",
          (object) this._ComparisonType,
          (object) "@DateFrom",
          (object) this._dateFrom,
          (object) "@PriorTo",
          (object) this._priorTo
        });
      else
        this._dt = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spFin_rptIncomeStatementByCostCenter", 300, (CommandArgumentType) 0, new object[10]
        {
          (object) "@GlCompanyID",
          (object) this._CompanyID,
          (object) "@CostCenterId",
          (object) this._CostCenterID,
          (object) "@ComparisonType",
          (object) this._ComparisonType,
          (object) "@DateFrom",
          (object) this._dateFrom,
          (object) "@PriorTo",
          (object) this._priorTo
        });
    }
    if (this._dt.Rows.Count <= 0)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._ComparisonType, "M", false) == 0)
    {
      this.lblBucket1.Text = this._priorTo.ToString("MM/dd/yyyy");
      this.lblBucket2.Text = Conversions.ToDate(this._dt.Rows[0]["CompareDate"]).ToString("MM/dd/yyyy");
    }
    else
    {
      this.lblBucket1.Text = this._priorTo.ToString("MM/dd/yyyy");
      this.lblBucket2.Text = Conversions.ToDate(this._dt.Rows[0]["CompareDate"]).ToString("MM/dd/yyyy");
    }
    this.lblCompany.Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT TOP 1 Location FROM tblClientOffices WHERE OfficeID = @officeID", new object[2]
    {
      (object) "@officeID",
      (object) this._CompanyID
    });
    this.txtDate.Text = string.Format(this.txtDate.Text, (object) this._dateFrom.ToString("MM/dd/yyyy"), (object) this._priorTo.ToString("MM/dd/yyyy"));
    if (this._CostCenterID == 0)
      this.textCostCenter.Text = "All Cost Centers";
    else
      this.textCostCenter.Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT TOP 1 GroupName FROM tblEntityGroups WHERE GroupID = @groupID", new object[2]
      {
        (object) "@groupID",
        (object) this._CostCenterID
      });
    this.DataSource = (object) new DataView(this._dt, "RollUpTo IS NULL", "OrderMaster", DataViewRowState.CurrentRows);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfFullName).Format += new EventHandler(this.gfFullName_Format);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName).BeforePrint += new EventHandler(this.ghAcctClassName_BeforePrint);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).BeforePrint += new EventHandler(this.gfAcctTypeDescription_BeforePrint);
  }

  private void gfFullName_Format(object sender, EventArgs e)
  {
    if (this.AcctTypeID.Value == null)
      return;
    this.srDetails.Report = (SectionReport) new rptFinancials_IncomeStatement_detail(new DataView(this._dt, $"(AcctTypeID = {RuntimeHelpers.GetObjectValue(this.AcctTypeID.Value)}) AND (OrderMaster = {RuntimeHelpers.GetObjectValue(this.OrderMaster.Value)}) AND (RollUpTo IS NULL)", "", DataViewRowState.CurrentRows));
  }

  private void ghAcctClassName_BeforePrint(object sender, EventArgs e)
  {
    if (this.OrderMaster.Value == null)
      return;
    this.txtBucket1_AcctClassName_Total.Value = RuntimeHelpers.GetObjectValue(this._dt.Compute("SUM(Amount)", $"OrderMaster={RuntimeHelpers.GetObjectValue(this.OrderMaster.Value)}"));
    this.txtBucket2_AcctClassName_Total.Value = RuntimeHelpers.GetObjectValue(this._dt.Compute("SUM(CompareAmount)", $"OrderMaster={RuntimeHelpers.GetObjectValue(this.OrderMaster.Value)}"));
    this.txtBucket3_AcctClassName_Total.Value = RuntimeHelpers.GetObjectValue(this._dt.Compute("SUM(ChangeAmount)", $"OrderMaster={RuntimeHelpers.GetObjectValue(this.OrderMaster.Value)}"));
  }

  private void gfAcctTypeDescription_BeforePrint(object sender, EventArgs e)
  {
    if (this.AcctTypeID.Value == null)
      return;
    this.txtBucket1_AcctTypeDescription_Total.Value = RuntimeHelpers.GetObjectValue(this._dt.Compute("SUM(Amount)", $"AcctTypeID={RuntimeHelpers.GetObjectValue(this.AcctTypeID.Value)}"));
    this.txtBucket2_AcctTypeDescription_Total.Value = RuntimeHelpers.GetObjectValue(this._dt.Compute("SUM(CompareAmount)", $"AcctTypeID={RuntimeHelpers.GetObjectValue(this.AcctTypeID.Value)}"));
    this.txtBucket3_AcctTypeDescription_Total.Value = RuntimeHelpers.GetObjectValue(this._dt.Compute("SUM(ChangeAmount)", $"AcctTypeID={RuntimeHelpers.GetObjectValue(this.AcctTypeID.Value)}"));
  }

  private void ReportFooter_BeforePrint(object sender, EventArgs e)
  {
    this.txtTotAmount.Value = (object) Decimal.Subtract(!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this._dt.Compute("SUM(Amount)", "OrderMaster = 1"))) ? Conversions.ToDecimal(this._dt.Compute("SUM(Amount)", "OrderMaster = 1")) : 0M, !Information.IsDBNull(RuntimeHelpers.GetObjectValue(this._dt.Compute("SUM(Amount)", "OrderMaster = 2"))) ? Conversions.ToDecimal(this._dt.Compute("SUM(Amount)", "OrderMaster = 2")) : 0M);
    this.txtTotCompareAmount.Value = (object) Decimal.Subtract(!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this._dt.Compute("SUM(CompareAmount)", "OrderMaster = 1"))) ? Conversions.ToDecimal(this._dt.Compute("SUM(CompareAmount)", "OrderMaster = 1")) : 0M, !Information.IsDBNull(RuntimeHelpers.GetObjectValue(this._dt.Compute("SUM(CompareAmount)", "OrderMaster = 2"))) ? Conversions.ToDecimal(this._dt.Compute("SUM(CompareAmount)", "OrderMaster = 2")) : 0M);
    this.txtTotChangeAmount.Value = (object) Decimal.Subtract(!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this._dt.Compute("SUM(ChangeAmount)", "OrderMaster = 1"))) ? Conversions.ToDecimal(this._dt.Compute("SUM(ChangeAmount)", "OrderMaster = 1")) : 0M, !Information.IsDBNull(RuntimeHelpers.GetObjectValue(this._dt.Compute("SUM(ChangeAmount)", "OrderMaster = 2"))) ? Conversions.ToDecimal(this._dt.Compute("SUM(ChangeAmount)", "OrderMaster = 2")) : 0M);
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._formatType, "Y", false) == 0)
    {
      XlsExport xlsExport = (XlsExport) null;
      try
      {
        xlsExport = new XlsExport();
        xlsExport.FileFormat = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Path.GetExtension(SaveFileTo).ToLower(), ".xlsx", false) != 0 ? (FileFormat) 0 : (FileFormat) 2;
        xlsExport.Export(this.Document, SaveFileTo);
      }
      finally
      {
        ((Component) xlsExport)?.Dispose();
      }
    }
    else
      ExcelExport.ToExcel(this._dt, SaveFileTo);
  }

  public override void Hyperlink(object sender, HyperLinkEventArgs e)
  {
    this._glAccountIDs = e.HyperLink;
    this._summaryView = false;
    this._entityGuid = Guid.Empty;
    this._excelOnly = false;
    rptAccountTransactionLedger rpt = new rptAccountTransactionLedger(this._CompanyID, this._CostCenterID, this._glAccountIDs, this._dateFrom, this._priorTo, this._entityGuid, this._summaryView, this._excelOnly);
    rpt.Run();
    rpt.Document.Name = $"Account Transaction Ledger - {e.HyperLink}";
    ReportFactory.Instance.ShowReport((SectionReport) rpt);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[5]
      {
        (BaseReportControl) new OfficeOptionalCostCenter("Office"),
        (BaseReportControl) new RadioSelection("Comparison", "Monthly", (object) "M", "Yearly", (object) "Y", RadioSelection.ButtonLayout.Vertical),
        (BaseReportControl) new DatePicker("Date From", DateAndTime.Now, false),
        (BaseReportControl) new DatePicker("Date To", DateAndTime.Now, false),
        (BaseReportControl) new RadioSelection("Exported File With Formatting", "Yes", (object) "Y", "No", (object) "N", RadioSelection.ButtonLayout.Vertical)
      };
    }
  }

  [field: AccessedThroughProperty("textCostCenter")]
  private virtual TextBox textCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("OrderMaster")]
  private virtual TextBox OrderMaster { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghAcctClassName")]
  private virtual GroupHeader ghAcctClassName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghAcctTypeDescription")]
  private virtual GroupHeader ghAcctTypeDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghFullName")]
  private virtual GroupHeader ghFullName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfFullName")]
  private virtual GroupFooter gfFullName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfAcctTypeDescription")]
  private virtual GroupFooter gfAcctTypeDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfAcctClassName")]
  private virtual GroupFooter gfAcctClassName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual ReportFooter ReportFooter
  {
    get => this._ReportFooter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportFooter_BeforePrint);
      ReportFooter reportFooter1 = this._ReportFooter;
      if (reportFooter1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter1).BeforePrint -= eventHandler;
      this._ReportFooter = value;
      ReportFooter reportFooter2 = this._ReportFooter;
      if (reportFooter2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter2).BeforePrint += eventHandler;
    }
  }
}
