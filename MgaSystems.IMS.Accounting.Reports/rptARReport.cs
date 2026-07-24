// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptARReport
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
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
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{011C414A-9D58-479a-BE30-67E0FED18908}", "Daily AR Report", "Generates a Daily AR Report by office location and specified date range.", "General")]
public sealed class rptARReport : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{011C414A-9D58-479a-BE30-67E0FED18908}";
  private DataTable _header;
  private DataTable _details;
  private DataTable _export;
  private DateTime _datFromDate;
  private DateTime _datToDate;
  private bool _UseDepositDate;
  private Guid _OfficeLocationGUID;
  private string _bankacct;
  private Label lblDate;
  private Label lblARReportTitle;
  private Label lblAgencyName;
  private Label lbltoprsp1;
  private Label lbltoprsp2;
  private Label lbltoprsp3;
  private Label lbltoprsp4;
  private Label Label5;
  private Label lbltoprPreBy;
  private Label lbltoprAppBy;
  private Label lbltoprInitials;
  private Label lbltoprDate;
  private TextBox txtRemitter;
  private TextBox checkNumber;
  private Label Label7;
  private TextBox txtPostDate;
  private Label lblBank;
  private TextBox txtBank;
  private TextBox TextBox25;
  private Label Label10;
  private TextBox txtCheckDepositDate;
  private TextBox TextBox32;
  private TextBox transactNum;
  private SubReport srPostings;
  private TextBox txtCheckTotal;
  private Label lblCheckTotal;
  private TextBox TextBox33;
  private TextBox txtRemitterDepositTotal;
  private TextBox txtRemitterPostedTotal;
  private TextBox txtRemitterExchangeTotal;
  private TextBox txtRemitterUnAccountedTotal;
  private TextBox txtRemitterMGACommTotal;
  private TextBox RemitterName;
  private TextBox txtRemitterAPAmountTotal;
  private TextBox TextBox8;
  private TextBox txtDateDepositTotal;
  private TextBox txtDatePostedTotal;
  private TextBox txtDateExchangeTotal;
  private TextBox txtDateUnaccountedTotal;
  private TextBox txtDateMGACommTotal;
  private TextBox DepositDate;
  private TextBox txtDateAPAmountTotal;
  private TextBox currentDepositDate;
  private TextBox currentPostDate;
  private TextBox txtGrandTotal;
  private TextBox txtGrandDepositTotal;
  private TextBox txtGrandMGACommTotal;
  private TextBox txtGrandUnaccountedTotal;
  private TextBox txtGrandExchangeTotal;
  private TextBox txtGrandPostedTotal;
  private TextBox txtGrandAPAmountTotal;

  public rptARReport() => this.ReportStart += new EventHandler(this.rptARReport_ReportStart);

  public rptARReport(
    Guid OfficeLocationGUID,
    bool UseDepositDate,
    DateTime datFromDate,
    DateTime datToDate,
    string bankacct)
  {
    this.ReportStart += new EventHandler(this.rptARReport_ReportStart);
    this.InitializeComponent();
    this._datFromDate = datFromDate;
    this._datToDate = datToDate;
    this._UseDepositDate = UseDepositDate;
    this._OfficeLocationGUID = OfficeLocationGUID;
    this._bankacct = bankacct;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptARReport));
    this.Detail = new Detail();
    this.srPostings = new SubReport();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.txtGrandTotal = new TextBox();
    this.txtGrandDepositTotal = new TextBox();
    this.txtGrandMGACommTotal = new TextBox();
    this.txtGrandUnaccountedTotal = new TextBox();
    this.txtGrandExchangeTotal = new TextBox();
    this.txtGrandPostedTotal = new TextBox();
    this.txtGrandAPAmountTotal = new TextBox();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.ghAll = new GroupHeader();
    this.lblDate = new Label();
    this.lblARReportTitle = new Label();
    this.lblAgencyName = new Label();
    this.lbltoprsp1 = new Label();
    this.lbltoprsp2 = new Label();
    this.lbltoprsp3 = new Label();
    this.lbltoprsp4 = new Label();
    this.Label5 = new Label();
    this.lbltoprPreBy = new Label();
    this.lbltoprAppBy = new Label();
    this.lbltoprInitials = new Label();
    this.lbltoprDate = new Label();
    this.gfAll = new GroupFooter();
    this.ghDate = new GroupHeader();
    this.gfDate = new GroupFooter();
    this.TextBox8 = new TextBox();
    this.txtDateDepositTotal = new TextBox();
    this.txtDatePostedTotal = new TextBox();
    this.txtDateExchangeTotal = new TextBox();
    this.txtDateUnaccountedTotal = new TextBox();
    this.txtDateMGACommTotal = new TextBox();
    this.DepositDate = new TextBox();
    this.txtDateAPAmountTotal = new TextBox();
    this.currentDepositDate = new TextBox();
    this.currentPostDate = new TextBox();
    this.ghRemitter = new GroupHeader();
    this.txtRemitter = new TextBox();
    this.gfRemitter = new GroupFooter();
    this.TextBox33 = new TextBox();
    this.txtRemitterDepositTotal = new TextBox();
    this.txtRemitterPostedTotal = new TextBox();
    this.txtRemitterExchangeTotal = new TextBox();
    this.txtRemitterUnAccountedTotal = new TextBox();
    this.txtRemitterMGACommTotal = new TextBox();
    this.RemitterName = new TextBox();
    this.txtRemitterAPAmountTotal = new TextBox();
    this.ghCheck = new GroupHeader();
    this.checkNumber = new TextBox();
    this.gfCheck = new GroupFooter();
    this.txtCheckTotal = new TextBox();
    this.lblCheckTotal = new Label();
    this.ghTransaction = new GroupHeader();
    this.Label7 = new Label();
    this.txtPostDate = new TextBox();
    this.lblBank = new Label();
    this.txtBank = new TextBox();
    this.TextBox25 = new TextBox();
    this.Label10 = new Label();
    this.txtCheckDepositDate = new TextBox();
    this.TextBox32 = new TextBox();
    this.transactNum = new TextBox();
    this.gfTransaction = new GroupFooter();
    ((ISupportInitialize) this.txtGrandTotal).BeginInit();
    ((ISupportInitialize) this.txtGrandDepositTotal).BeginInit();
    ((ISupportInitialize) this.txtGrandMGACommTotal).BeginInit();
    ((ISupportInitialize) this.txtGrandUnaccountedTotal).BeginInit();
    ((ISupportInitialize) this.txtGrandExchangeTotal).BeginInit();
    ((ISupportInitialize) this.txtGrandPostedTotal).BeginInit();
    ((ISupportInitialize) this.txtGrandAPAmountTotal).BeginInit();
    ((ISupportInitialize) this.lblDate).BeginInit();
    ((ISupportInitialize) this.lblARReportTitle).BeginInit();
    ((ISupportInitialize) this.lblAgencyName).BeginInit();
    ((ISupportInitialize) this.lbltoprsp1).BeginInit();
    ((ISupportInitialize) this.lbltoprsp2).BeginInit();
    ((ISupportInitialize) this.lbltoprsp3).BeginInit();
    ((ISupportInitialize) this.lbltoprsp4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.lbltoprPreBy).BeginInit();
    ((ISupportInitialize) this.lbltoprAppBy).BeginInit();
    ((ISupportInitialize) this.lbltoprInitials).BeginInit();
    ((ISupportInitialize) this.lbltoprDate).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.txtDateDepositTotal).BeginInit();
    ((ISupportInitialize) this.txtDatePostedTotal).BeginInit();
    ((ISupportInitialize) this.txtDateExchangeTotal).BeginInit();
    ((ISupportInitialize) this.txtDateUnaccountedTotal).BeginInit();
    ((ISupportInitialize) this.txtDateMGACommTotal).BeginInit();
    ((ISupportInitialize) this.DepositDate).BeginInit();
    ((ISupportInitialize) this.txtDateAPAmountTotal).BeginInit();
    ((ISupportInitialize) this.currentDepositDate).BeginInit();
    ((ISupportInitialize) this.currentPostDate).BeginInit();
    ((ISupportInitialize) this.txtRemitter).BeginInit();
    ((ISupportInitialize) this.TextBox33).BeginInit();
    ((ISupportInitialize) this.txtRemitterDepositTotal).BeginInit();
    ((ISupportInitialize) this.txtRemitterPostedTotal).BeginInit();
    ((ISupportInitialize) this.txtRemitterExchangeTotal).BeginInit();
    ((ISupportInitialize) this.txtRemitterUnAccountedTotal).BeginInit();
    ((ISupportInitialize) this.txtRemitterMGACommTotal).BeginInit();
    ((ISupportInitialize) this.RemitterName).BeginInit();
    ((ISupportInitialize) this.txtRemitterAPAmountTotal).BeginInit();
    ((ISupportInitialize) this.checkNumber).BeginInit();
    ((ISupportInitialize) this.txtCheckTotal).BeginInit();
    ((ISupportInitialize) this.lblCheckTotal).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.txtPostDate).BeginInit();
    ((ISupportInitialize) this.lblBank).BeginInit();
    ((ISupportInitialize) this.txtBank).BeginInit();
    ((ISupportInitialize) this.TextBox25).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.txtCheckDepositDate).BeginInit();
    ((ISupportInitialize) this.TextBox32).BeginInit();
    ((ISupportInitialize) this.transactNum).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srPostings
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.125f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.srPostings).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srPostings).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srPostings).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srPostings).Border.TopStyle = (BorderLineStyle) 0;
    this.srPostings.CloseBorder = false;
    SubReport srPostings = this.srPostings;
    object obj1 = componentResourceManager.GetObject("srPostings.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) srPostings).Location = pointF1;
    ((ARControl) this.srPostings).Name = "srPostings";
    this.srPostings.Report = (SectionReport) null;
    ((ARControl) this.srPostings).Size = new SizeF(10.375f, 0.125f);
    this.ReportHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).BackColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.txtGrandTotal,
      (ARControl) this.txtGrandDepositTotal,
      (ARControl) this.txtGrandMGACommTotal,
      (ARControl) this.txtGrandUnaccountedTotal,
      (ARControl) this.txtGrandExchangeTotal,
      (ARControl) this.txtGrandPostedTotal,
      (ARControl) this.txtGrandAPAmountTotal
    });
    this.ReportFooter.Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.txtGrandTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtGrandTotal.DistinctField = (string) null;
    this.txtGrandTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox txtGrandTotal = this.txtGrandTotal;
    object obj2 = componentResourceManager.GetObject("txtGrandTotal.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtGrandTotal).Location = pointF2;
    ((ARControl) this.txtGrandTotal).Name = "txtGrandTotal";
    this.txtGrandTotal.OutputFormat = (string) null;
    ((ARControl) this.txtGrandTotal).Size = new SizeF(1.5f, 0.125f);
    this.txtGrandTotal.Text = "Grand Total:";
    this.txtGrandDepositTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtGrandDepositTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandDepositTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandDepositTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandDepositTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtGrandDepositTotal.DistinctField = (string) null;
    this.txtGrandDepositTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox grandDepositTotal = this.txtGrandDepositTotal;
    object obj3 = componentResourceManager.GetObject("txtGrandDepositTotal.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) grandDepositTotal).Location = pointF3;
    ((ARControl) this.txtGrandDepositTotal).Name = "txtGrandDepositTotal";
    this.txtGrandDepositTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtGrandDepositTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtGrandDepositTotal.Text = "Total";
    this.txtGrandMGACommTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtGrandMGACommTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandMGACommTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandMGACommTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandMGACommTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtGrandMGACommTotal.DistinctField = (string) null;
    this.txtGrandMGACommTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox grandMgaCommTotal = this.txtGrandMGACommTotal;
    object obj4 = componentResourceManager.GetObject("txtGrandMGACommTotal.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) grandMgaCommTotal).Location = pointF4;
    ((ARControl) this.txtGrandMGACommTotal).Name = "txtGrandMGACommTotal";
    this.txtGrandMGACommTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtGrandMGACommTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtGrandMGACommTotal.SummaryGroup = "ghAll";
    this.txtGrandMGACommTotal.Text = "Total";
    this.txtGrandUnaccountedTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtGrandUnaccountedTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandUnaccountedTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandUnaccountedTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandUnaccountedTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtGrandUnaccountedTotal.DistinctField = (string) null;
    this.txtGrandUnaccountedTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox unaccountedTotal1 = this.txtGrandUnaccountedTotal;
    object obj5 = componentResourceManager.GetObject("txtGrandUnaccountedTotal.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) unaccountedTotal1).Location = pointF5;
    ((ARControl) this.txtGrandUnaccountedTotal).Name = "txtGrandUnaccountedTotal";
    this.txtGrandUnaccountedTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtGrandUnaccountedTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtGrandUnaccountedTotal.SummaryGroup = "ghAll";
    this.txtGrandUnaccountedTotal.Text = "Total";
    this.txtGrandExchangeTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtGrandExchangeTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandExchangeTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandExchangeTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandExchangeTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtGrandExchangeTotal.DistinctField = (string) null;
    this.txtGrandExchangeTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox grandExchangeTotal = this.txtGrandExchangeTotal;
    object obj6 = componentResourceManager.GetObject("txtGrandExchangeTotal.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) grandExchangeTotal).Location = pointF6;
    ((ARControl) this.txtGrandExchangeTotal).Name = "txtGrandExchangeTotal";
    this.txtGrandExchangeTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtGrandExchangeTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtGrandExchangeTotal.SummaryGroup = "ghAll";
    this.txtGrandExchangeTotal.Text = "Total";
    this.txtGrandPostedTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtGrandPostedTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandPostedTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandPostedTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandPostedTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtGrandPostedTotal.DistinctField = (string) null;
    this.txtGrandPostedTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox grandPostedTotal = this.txtGrandPostedTotal;
    object obj7 = componentResourceManager.GetObject("txtGrandPostedTotal.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) grandPostedTotal).Location = pointF7;
    ((ARControl) this.txtGrandPostedTotal).Name = "txtGrandPostedTotal";
    this.txtGrandPostedTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtGrandPostedTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtGrandPostedTotal.SummaryGroup = "ghAll";
    this.txtGrandPostedTotal.Text = "Total";
    this.txtGrandAPAmountTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtGrandAPAmountTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandAPAmountTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandAPAmountTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrandAPAmountTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtGrandAPAmountTotal.DistinctField = (string) null;
    this.txtGrandAPAmountTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox grandApAmountTotal = this.txtGrandAPAmountTotal;
    object obj8 = componentResourceManager.GetObject("txtGrandAPAmountTotal.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) grandApAmountTotal).Location = pointF8;
    ((ARControl) this.txtGrandAPAmountTotal).Name = "txtGrandAPAmountTotal";
    this.txtGrandAPAmountTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtGrandAPAmountTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtGrandAPAmountTotal.SummaryGroup = "ghAll";
    this.txtGrandAPAmountTotal.Text = "Total";
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAll).Controls.AddRange(new ARControl[12]
    {
      (ARControl) this.lblDate,
      (ARControl) this.lblARReportTitle,
      (ARControl) this.lblAgencyName,
      (ARControl) this.lbltoprsp1,
      (ARControl) this.lbltoprsp2,
      (ARControl) this.lbltoprsp3,
      (ARControl) this.lbltoprsp4,
      (ARControl) this.Label5,
      (ARControl) this.lbltoprPreBy,
      (ARControl) this.lbltoprAppBy,
      (ARControl) this.lbltoprInitials,
      (ARControl) this.lbltoprDate
    });
    this.ghAll.Height = 0.9479167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAll).Name = "ghAll";
    ((ARControl) this.lblDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.TopStyle = (BorderLineStyle) 0;
    this.lblDate.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold);
    this.lblDate.HyperLink = (string) null;
    Label lblDate = this.lblDate;
    object obj9 = componentResourceManager.GetObject("lblDate.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) lblDate).Location = pointF9;
    ((ARControl) this.lblDate).Name = "lblDate";
    ((ARControl) this.lblDate).Size = new SizeF(7.125f, 3f / 16f);
    this.lblDate.Text = "Report Date";
    ((ARControl) this.lblARReportTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblARReportTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblARReportTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblARReportTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.lblARReportTitle.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblARReportTitle.HyperLink = (string) null;
    Label lblArReportTitle = this.lblARReportTitle;
    object obj10 = componentResourceManager.GetObject("lblARReportTitle.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) lblArReportTitle).Location = pointF10;
    ((ARControl) this.lblARReportTitle).Name = "lblARReportTitle";
    ((ARControl) this.lblARReportTitle).Size = new SizeF(7.125f, 0.25f);
    this.lblARReportTitle.Text = "Title";
    ((ARControl) this.lblAgencyName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAgencyName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAgencyName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAgencyName).Border.TopStyle = (BorderLineStyle) 0;
    this.lblAgencyName.Font = new Font("Arial", 18f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblAgencyName.HyperLink = (string) null;
    Label lblAgencyName = this.lblAgencyName;
    object obj11 = componentResourceManager.GetObject("lblAgencyName.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) lblAgencyName).Location = pointF11;
    ((ARControl) this.lblAgencyName).Name = "lblAgencyName";
    ((ARControl) this.lblAgencyName).Size = new SizeF(7.125f, 5f / 16f);
    this.lblAgencyName.Text = "Agency Name";
    ((ARControl) this.lbltoprsp1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprsp1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprsp1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprsp1).Border.TopStyle = (BorderLineStyle) 1;
    this.lbltoprsp1.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lbltoprsp1.HyperLink = (string) null;
    Label lbltoprsp1 = this.lbltoprsp1;
    object obj12 = componentResourceManager.GetObject("lbltoprsp1.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) lbltoprsp1).Location = pointF12;
    ((ARControl) this.lbltoprsp1).Name = "lbltoprsp1";
    ((ARControl) this.lbltoprsp1).Size = new SizeF(11f / 16f, 3f / 16f);
    this.lbltoprsp1.Text = "";
    ((ARControl) this.lbltoprsp2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprsp2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprsp2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprsp2).Border.TopStyle = (BorderLineStyle) 1;
    this.lbltoprsp2.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lbltoprsp2.HyperLink = (string) null;
    Label lbltoprsp2 = this.lbltoprsp2;
    object obj13 = componentResourceManager.GetObject("lbltoprsp2.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) lbltoprsp2).Location = pointF13;
    ((ARControl) this.lbltoprsp2).Name = "lbltoprsp2";
    ((ARControl) this.lbltoprsp2).Size = new SizeF(11f / 16f, 3f / 16f);
    this.lbltoprsp2.Text = "";
    ((ARControl) this.lbltoprsp3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprsp3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprsp3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprsp3).Border.TopStyle = (BorderLineStyle) 1;
    this.lbltoprsp3.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lbltoprsp3.HyperLink = (string) null;
    Label lbltoprsp3 = this.lbltoprsp3;
    object obj14 = componentResourceManager.GetObject("lbltoprsp3.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) lbltoprsp3).Location = pointF14;
    ((ARControl) this.lbltoprsp3).Name = "lbltoprsp3";
    ((ARControl) this.lbltoprsp3).Size = new SizeF(0.625f, 3f / 16f);
    this.lbltoprsp3.Text = "";
    ((ARControl) this.lbltoprsp4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprsp4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprsp4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprsp4).Border.TopStyle = (BorderLineStyle) 1;
    this.lbltoprsp4.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lbltoprsp4.HyperLink = (string) null;
    Label lbltoprsp4 = this.lbltoprsp4;
    object obj15 = componentResourceManager.GetObject("lbltoprsp4.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) lbltoprsp4).Location = pointF15;
    ((ARControl) this.lbltoprsp4).Name = "lbltoprsp4";
    ((ARControl) this.lbltoprsp4).Size = new SizeF(11f / 16f, 3f / 16f);
    this.lbltoprsp4.Text = "";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 1;
    this.Label5.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj16 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) label5).Location = pointF16;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(0.625f, 3f / 16f);
    this.Label5.Text = "";
    this.lbltoprPreBy.Alignment = (TextAlignment) 1;
    ((ARControl) this.lbltoprPreBy).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprPreBy).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprPreBy).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprPreBy).Border.TopStyle = (BorderLineStyle) 1;
    this.lbltoprPreBy.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lbltoprPreBy.HyperLink = (string) null;
    Label lbltoprPreBy = this.lbltoprPreBy;
    object obj17 = componentResourceManager.GetObject("lbltoprPreBy.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) lbltoprPreBy).Location = pointF17;
    ((ARControl) this.lbltoprPreBy).Name = "lbltoprPreBy";
    ((ARControl) this.lbltoprPreBy).Size = new SizeF(11f / 16f, 3f / 16f);
    this.lbltoprPreBy.Text = "Prepared By";
    this.lbltoprPreBy.VerticalAlignment = (VerticalTextAlignment) 1;
    this.lbltoprAppBy.Alignment = (TextAlignment) 1;
    ((ARControl) this.lbltoprAppBy).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprAppBy).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprAppBy).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprAppBy).Border.TopStyle = (BorderLineStyle) 1;
    this.lbltoprAppBy.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lbltoprAppBy.HyperLink = (string) null;
    Label lbltoprAppBy = this.lbltoprAppBy;
    object obj18 = componentResourceManager.GetObject("lbltoprAppBy.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) lbltoprAppBy).Location = pointF18;
    ((ARControl) this.lbltoprAppBy).Name = "lbltoprAppBy";
    ((ARControl) this.lbltoprAppBy).Size = new SizeF(11f / 16f, 3f / 16f);
    this.lbltoprAppBy.Text = "Approved By";
    this.lbltoprAppBy.VerticalAlignment = (VerticalTextAlignment) 1;
    this.lbltoprInitials.Alignment = (TextAlignment) 1;
    ((ARControl) this.lbltoprInitials).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprInitials).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprInitials).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprInitials).Border.TopStyle = (BorderLineStyle) 1;
    this.lbltoprInitials.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lbltoprInitials.HyperLink = (string) null;
    Label lbltoprInitials = this.lbltoprInitials;
    object obj19 = componentResourceManager.GetObject("lbltoprInitials.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) lbltoprInitials).Location = pointF19;
    ((ARControl) this.lbltoprInitials).Name = "lbltoprInitials";
    ((ARControl) this.lbltoprInitials).Size = new SizeF(11f / 16f, 3f / 16f);
    this.lbltoprInitials.Text = "Initials";
    this.lbltoprInitials.VerticalAlignment = (VerticalTextAlignment) 1;
    this.lbltoprDate.Alignment = (TextAlignment) 1;
    ((ARControl) this.lbltoprDate).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprDate).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprDate).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lbltoprDate).Border.TopStyle = (BorderLineStyle) 1;
    this.lbltoprDate.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lbltoprDate.HyperLink = (string) null;
    Label lbltoprDate = this.lbltoprDate;
    object obj20 = componentResourceManager.GetObject("lbltoprDate.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) lbltoprDate).Location = pointF20;
    ((ARControl) this.lbltoprDate).Name = "lbltoprDate";
    ((ARControl) this.lbltoprDate).Size = new SizeF(0.625f, 3f / 16f);
    this.lbltoprDate.Text = "Date";
    this.lbltoprDate.VerticalAlignment = (VerticalTextAlignment) 1;
    this.gfAll.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAll).Name = "gfAll";
    this.ghDate.DataField = "DepositDate";
    this.ghDate.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghDate).Name = "ghDate";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfDate).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.TextBox8,
      (ARControl) this.txtDateDepositTotal,
      (ARControl) this.txtDatePostedTotal,
      (ARControl) this.txtDateExchangeTotal,
      (ARControl) this.txtDateUnaccountedTotal,
      (ARControl) this.txtDateMGACommTotal,
      (ARControl) this.DepositDate,
      (ARControl) this.txtDateAPAmountTotal,
      (ARControl) this.currentDepositDate,
      (ARControl) this.currentPostDate
    });
    this.gfDate.Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfDate).Name = "gfDate";
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox textBox8 = this.TextBox8;
    object obj21 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox8).Location = pointF21;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = (string) null;
    ((ARControl) this.TextBox8).Size = new SizeF(0.875f, 0.125f);
    this.TextBox8.Text = "Total:";
    this.txtDateDepositTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtDateDepositTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateDepositTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateDepositTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateDepositTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDateDepositTotal.DistinctField = (string) null;
    this.txtDateDepositTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox dateDepositTotal = this.txtDateDepositTotal;
    object obj22 = componentResourceManager.GetObject("txtDateDepositTotal.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) dateDepositTotal).Location = pointF22;
    ((ARControl) this.txtDateDepositTotal).Name = "txtDateDepositTotal";
    this.txtDateDepositTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtDateDepositTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtDateDepositTotal.Text = "Total";
    this.txtDatePostedTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtDatePostedTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDatePostedTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDatePostedTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDatePostedTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDatePostedTotal.DistinctField = (string) null;
    this.txtDatePostedTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox txtDatePostedTotal = this.txtDatePostedTotal;
    object obj23 = componentResourceManager.GetObject("txtDatePostedTotal.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) txtDatePostedTotal).Location = pointF23;
    ((ARControl) this.txtDatePostedTotal).Name = "txtDatePostedTotal";
    this.txtDatePostedTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtDatePostedTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtDatePostedTotal.SummaryGroup = "ghDate";
    this.txtDatePostedTotal.Text = "Total";
    this.txtDateExchangeTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtDateExchangeTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateExchangeTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateExchangeTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateExchangeTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDateExchangeTotal.DistinctField = (string) null;
    this.txtDateExchangeTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox dateExchangeTotal = this.txtDateExchangeTotal;
    object obj24 = componentResourceManager.GetObject("txtDateExchangeTotal.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) dateExchangeTotal).Location = pointF24;
    ((ARControl) this.txtDateExchangeTotal).Name = "txtDateExchangeTotal";
    this.txtDateExchangeTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtDateExchangeTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtDateExchangeTotal.SummaryGroup = "ghDate";
    this.txtDateExchangeTotal.Text = "Total";
    this.txtDateUnaccountedTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtDateUnaccountedTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateUnaccountedTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateUnaccountedTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateUnaccountedTotal).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateUnaccountedTotal).DataField = "UnacctAmt";
    this.txtDateUnaccountedTotal.DistinctField = (string) null;
    this.txtDateUnaccountedTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox unaccountedTotal2 = this.txtDateUnaccountedTotal;
    object obj25 = componentResourceManager.GetObject("txtDateUnaccountedTotal.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) unaccountedTotal2).Location = pointF25;
    ((ARControl) this.txtDateUnaccountedTotal).Name = "txtDateUnaccountedTotal";
    this.txtDateUnaccountedTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtDateUnaccountedTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtDateUnaccountedTotal.SummaryGroup = "ghDate";
    this.txtDateUnaccountedTotal.Text = "Total";
    this.txtDateMGACommTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtDateMGACommTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateMGACommTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateMGACommTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateMGACommTotal).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateMGACommTotal).DataField = "IncAmt";
    this.txtDateMGACommTotal.DistinctField = (string) null;
    this.txtDateMGACommTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox dateMgaCommTotal = this.txtDateMGACommTotal;
    object obj26 = componentResourceManager.GetObject("txtDateMGACommTotal.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) dateMgaCommTotal).Location = pointF26;
    ((ARControl) this.txtDateMGACommTotal).Name = "txtDateMGACommTotal";
    this.txtDateMGACommTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtDateMGACommTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtDateMGACommTotal.SummaryGroup = "ghDate";
    this.txtDateMGACommTotal.Text = "Total";
    ((ARControl) this.DepositDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.DepositDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.DepositDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.DepositDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.DepositDate).DataField = "DepositDate";
    this.DepositDate.DistinctField = (string) null;
    this.DepositDate.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox depositDate = this.DepositDate;
    object obj27 = componentResourceManager.GetObject("DepositDate.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) depositDate).Location = pointF27;
    ((ARControl) this.DepositDate).Name = "DepositDate";
    this.DepositDate.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.DepositDate).Size = new SizeF(0.625f, 0.125f);
    this.DepositDate.Text = "Deposit Date";
    this.txtDateAPAmountTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtDateAPAmountTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateAPAmountTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateAPAmountTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateAPAmountTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDateAPAmountTotal.DistinctField = (string) null;
    this.txtDateAPAmountTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox dateApAmountTotal = this.txtDateAPAmountTotal;
    object obj28 = componentResourceManager.GetObject("txtDateAPAmountTotal.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) dateApAmountTotal).Location = pointF28;
    ((ARControl) this.txtDateAPAmountTotal).Name = "txtDateAPAmountTotal";
    this.txtDateAPAmountTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtDateAPAmountTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtDateAPAmountTotal.SummaryGroup = "ghDate";
    this.txtDateAPAmountTotal.Text = "Total";
    this.currentDepositDate.Alignment = (TextAlignment) 2;
    this.currentDepositDate.BackColor = Color.Yellow;
    ((ARControl) this.currentDepositDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentDepositDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentDepositDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentDepositDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentDepositDate).DataField = "DepositDate";
    this.currentDepositDate.DistinctField = (string) null;
    this.currentDepositDate.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox currentDepositDate = this.currentDepositDate;
    object obj29 = componentResourceManager.GetObject("currentDepositDate.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) currentDepositDate).Location = pointF29;
    ((ARControl) this.currentDepositDate).Name = "currentDepositDate";
    this.currentDepositDate.OutputFormat = (string) null;
    ((ARControl) this.currentDepositDate).Size = new SizeF(0.25f, 1f / 16f);
    this.currentDepositDate.Text = (string) null;
    ((ARControl) this.currentDepositDate).Visible = false;
    this.currentPostDate.Alignment = (TextAlignment) 2;
    this.currentPostDate.BackColor = Color.Yellow;
    ((ARControl) this.currentPostDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentPostDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentPostDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentPostDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentPostDate).DataField = "PostDate";
    this.currentPostDate.DistinctField = (string) null;
    this.currentPostDate.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox currentPostDate = this.currentPostDate;
    object obj30 = componentResourceManager.GetObject("currentPostDate.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) currentPostDate).Location = pointF30;
    ((ARControl) this.currentPostDate).Name = "currentPostDate";
    this.currentPostDate.OutputFormat = (string) null;
    ((ARControl) this.currentPostDate).Size = new SizeF(0.25f, 1f / 16f);
    this.currentPostDate.Text = (string) null;
    ((ARControl) this.currentPostDate).Visible = false;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghRemitter).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtRemitter
    });
    this.ghRemitter.DataField = "Remitter";
    this.ghRemitter.Height = 0.2388889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghRemitter).Name = "ghRemitter";
    ((ARControl) this.txtRemitter).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitter).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitter).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitter).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitter).DataField = "Remitter";
    this.txtRemitter.DistinctField = (string) null;
    this.txtRemitter.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold);
    TextBox txtRemitter = this.txtRemitter;
    object obj31 = componentResourceManager.GetObject("txtRemitter.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) txtRemitter).Location = pointF31;
    ((ARControl) this.txtRemitter).Name = "txtRemitter";
    this.txtRemitter.OutputFormat = (string) null;
    ((ARControl) this.txtRemitter).Size = new SizeF(10.375f, 0.25f);
    this.txtRemitter.Text = (string) null;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfRemitter).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.TextBox33,
      (ARControl) this.txtRemitterDepositTotal,
      (ARControl) this.txtRemitterPostedTotal,
      (ARControl) this.txtRemitterExchangeTotal,
      (ARControl) this.txtRemitterUnAccountedTotal,
      (ARControl) this.txtRemitterMGACommTotal,
      (ARControl) this.RemitterName,
      (ARControl) this.txtRemitterAPAmountTotal
    });
    this.gfRemitter.Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfRemitter).Name = "gfRemitter";
    ((ARControl) this.TextBox33).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox33).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox33).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox33).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox33.DistinctField = (string) null;
    this.TextBox33.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox textBox33 = this.TextBox33;
    object obj32 = componentResourceManager.GetObject("TextBox33.Location");
    PointF pointF32 = obj32 != null ? (PointF) obj32 : new PointF();
    ((ARControl) textBox33).Location = pointF32;
    ((ARControl) this.TextBox33).Name = "TextBox33";
    this.TextBox33.OutputFormat = (string) null;
    ((ARControl) this.TextBox33).Size = new SizeF(1.5f, 0.125f);
    this.TextBox33.Text = "Remitter Total:";
    this.txtRemitterDepositTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtRemitterDepositTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterDepositTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterDepositTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterDepositTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtRemitterDepositTotal.DistinctField = (string) null;
    this.txtRemitterDepositTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox remitterDepositTotal = this.txtRemitterDepositTotal;
    object obj33 = componentResourceManager.GetObject("txtRemitterDepositTotal.Location");
    PointF pointF33 = obj33 != null ? (PointF) obj33 : new PointF();
    ((ARControl) remitterDepositTotal).Location = pointF33;
    ((ARControl) this.txtRemitterDepositTotal).Name = "txtRemitterDepositTotal";
    this.txtRemitterDepositTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtRemitterDepositTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtRemitterDepositTotal.Text = "Total";
    this.txtRemitterPostedTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtRemitterPostedTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterPostedTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterPostedTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterPostedTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtRemitterPostedTotal.DistinctField = (string) null;
    this.txtRemitterPostedTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox remitterPostedTotal = this.txtRemitterPostedTotal;
    object obj34 = componentResourceManager.GetObject("txtRemitterPostedTotal.Location");
    PointF pointF34 = obj34 != null ? (PointF) obj34 : new PointF();
    ((ARControl) remitterPostedTotal).Location = pointF34;
    ((ARControl) this.txtRemitterPostedTotal).Name = "txtRemitterPostedTotal";
    this.txtRemitterPostedTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtRemitterPostedTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtRemitterPostedTotal.SummaryGroup = "ghCheck";
    this.txtRemitterPostedTotal.Text = "Total";
    this.txtRemitterExchangeTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtRemitterExchangeTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterExchangeTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterExchangeTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterExchangeTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtRemitterExchangeTotal.DistinctField = (string) null;
    this.txtRemitterExchangeTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox remitterExchangeTotal = this.txtRemitterExchangeTotal;
    object obj35 = componentResourceManager.GetObject("txtRemitterExchangeTotal.Location");
    PointF pointF35 = obj35 != null ? (PointF) obj35 : new PointF();
    ((ARControl) remitterExchangeTotal).Location = pointF35;
    ((ARControl) this.txtRemitterExchangeTotal).Name = "txtRemitterExchangeTotal";
    this.txtRemitterExchangeTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtRemitterExchangeTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtRemitterExchangeTotal.SummaryGroup = "ghCheck";
    this.txtRemitterExchangeTotal.Text = "Total";
    this.txtRemitterUnAccountedTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtRemitterUnAccountedTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterUnAccountedTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterUnAccountedTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterUnAccountedTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtRemitterUnAccountedTotal.DistinctField = (string) null;
    this.txtRemitterUnAccountedTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox unAccountedTotal = this.txtRemitterUnAccountedTotal;
    object obj36 = componentResourceManager.GetObject("txtRemitterUnAccountedTotal.Location");
    PointF pointF36 = obj36 != null ? (PointF) obj36 : new PointF();
    ((ARControl) unAccountedTotal).Location = pointF36;
    ((ARControl) this.txtRemitterUnAccountedTotal).Name = "txtRemitterUnAccountedTotal";
    this.txtRemitterUnAccountedTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtRemitterUnAccountedTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtRemitterUnAccountedTotal.SummaryGroup = "ghCheck";
    this.txtRemitterUnAccountedTotal.Text = "Total";
    this.txtRemitterMGACommTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtRemitterMGACommTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterMGACommTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterMGACommTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterMGACommTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtRemitterMGACommTotal.DistinctField = (string) null;
    this.txtRemitterMGACommTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox remitterMgaCommTotal = this.txtRemitterMGACommTotal;
    object obj37 = componentResourceManager.GetObject("txtRemitterMGACommTotal.Location");
    PointF pointF37 = obj37 != null ? (PointF) obj37 : new PointF();
    ((ARControl) remitterMgaCommTotal).Location = pointF37;
    ((ARControl) this.txtRemitterMGACommTotal).Name = "txtRemitterMGACommTotal";
    this.txtRemitterMGACommTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtRemitterMGACommTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtRemitterMGACommTotal.SummaryGroup = "ghCheck";
    this.txtRemitterMGACommTotal.Text = "Total";
    this.RemitterName.BackColor = Color.Yellow;
    ((ARControl) this.RemitterName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.RemitterName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.RemitterName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.RemitterName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.RemitterName).DataField = "Remitter";
    this.RemitterName.DistinctField = (string) null;
    this.RemitterName.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold);
    TextBox remitterName = this.RemitterName;
    object obj38 = componentResourceManager.GetObject("RemitterName.Location");
    PointF pointF38 = obj38 != null ? (PointF) obj38 : new PointF();
    ((ARControl) remitterName).Location = pointF38;
    ((ARControl) this.RemitterName).Name = "RemitterName";
    this.RemitterName.OutputFormat = (string) null;
    ((ARControl) this.RemitterName).Size = new SizeF(5f / 16f, 1f / 16f);
    this.RemitterName.Text = (string) null;
    ((ARControl) this.RemitterName).Visible = false;
    this.txtRemitterAPAmountTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtRemitterAPAmountTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterAPAmountTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterAPAmountTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRemitterAPAmountTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtRemitterAPAmountTotal.DistinctField = (string) null;
    this.txtRemitterAPAmountTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox remitterApAmountTotal = this.txtRemitterAPAmountTotal;
    object obj39 = componentResourceManager.GetObject("txtRemitterAPAmountTotal.Location");
    PointF pointF39 = obj39 != null ? (PointF) obj39 : new PointF();
    ((ARControl) remitterApAmountTotal).Location = pointF39;
    ((ARControl) this.txtRemitterAPAmountTotal).Name = "txtRemitterAPAmountTotal";
    this.txtRemitterAPAmountTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtRemitterAPAmountTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtRemitterAPAmountTotal.SummaryGroup = "ghCheck";
    this.txtRemitterAPAmountTotal.Text = "Total";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCheck).BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCheck).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.checkNumber
    });
    this.ghCheck.DataField = "CheckNumber";
    this.ghCheck.Height = 0.0f;
    this.ghCheck.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCheck).Name = "ghCheck";
    this.checkNumber.BackColor = Color.Yellow;
    ((ARControl) this.checkNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.checkNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.checkNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.checkNumber).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.checkNumber).DataField = "CheckNumber";
    this.checkNumber.DistinctField = (string) null;
    this.checkNumber.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox checkNumber = this.checkNumber;
    object obj40 = componentResourceManager.GetObject("checkNumber.Location");
    PointF pointF40 = obj40 != null ? (PointF) obj40 : new PointF();
    ((ARControl) checkNumber).Location = pointF40;
    ((ARControl) this.checkNumber).Name = "checkNumber";
    this.checkNumber.OutputFormat = (string) null;
    ((ARControl) this.checkNumber).Size = new SizeF(0.25f, 1f / 16f);
    this.checkNumber.Text = (string) null;
    ((ARControl) this.checkNumber).Visible = false;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCheck).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtCheckTotal,
      (ARControl) this.lblCheckTotal
    });
    this.gfCheck.Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCheck).Name = "gfCheck";
    this.txtCheckTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckTotal.DistinctField = (string) null;
    this.txtCheckTotal.Font = new Font("Arial", 8f);
    TextBox txtCheckTotal = this.txtCheckTotal;
    object obj41 = componentResourceManager.GetObject("txtCheckTotal.Location");
    PointF pointF41 = obj41 != null ? (PointF) obj41 : new PointF();
    ((ARControl) txtCheckTotal).Location = pointF41;
    ((ARControl) this.txtCheckTotal).Name = "txtCheckTotal";
    this.txtCheckTotal.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtCheckTotal).Size = new SizeF(13f / 16f, 0.125f);
    this.txtCheckTotal.SummaryGroup = "ghCheck";
    this.txtCheckTotal.SummaryRunning = (SummaryRunning) 1;
    this.txtCheckTotal.SummaryType = (SummaryType) 3;
    this.txtCheckTotal.Text = "Total";
    ((ARControl) this.lblCheckTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCheckTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCheckTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCheckTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.lblCheckTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblCheckTotal.HyperLink = (string) null;
    Label lblCheckTotal = this.lblCheckTotal;
    object obj42 = componentResourceManager.GetObject("lblCheckTotal.Location");
    PointF pointF42 = obj42 != null ? (PointF) obj42 : new PointF();
    ((ARControl) lblCheckTotal).Location = pointF42;
    ((ARControl) this.lblCheckTotal).Name = "lblCheckTotal";
    ((ARControl) this.lblCheckTotal).Size = new SizeF(89f / 16f, 0.125f);
    this.lblCheckTotal.Text = "Check Total:";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTransaction).BackColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTransaction).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.Label7,
      (ARControl) this.txtPostDate,
      (ARControl) this.lblBank,
      (ARControl) this.txtBank,
      (ARControl) this.TextBox25,
      (ARControl) this.Label10,
      (ARControl) this.txtCheckDepositDate,
      (ARControl) this.TextBox32,
      (ARControl) this.transactNum
    });
    this.ghTransaction.DataField = "TransactNum";
    this.ghTransaction.Height = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTransaction).Name = "ghTransaction";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 8f);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj43 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF43 = obj43 != null ? (PointF) obj43 : new PointF();
    ((ARControl) label7).Location = pointF43;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(9f / 16f, 0.125f);
    this.Label7.Text = "Post Date:";
    ((ARControl) this.txtPostDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPostDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPostDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPostDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPostDate).DataField = "PostDate";
    this.txtPostDate.DistinctField = (string) null;
    this.txtPostDate.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox txtPostDate = this.txtPostDate;
    object obj44 = componentResourceManager.GetObject("txtPostDate.Location");
    PointF pointF44 = obj44 != null ? (PointF) obj44 : new PointF();
    ((ARControl) txtPostDate).Location = pointF44;
    ((ARControl) this.txtPostDate).Name = "txtPostDate";
    this.txtPostDate.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtPostDate).Size = new SizeF(0.625f, 0.125f);
    this.txtPostDate.Text = "00/00/0000";
    ((ARControl) this.lblBank).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBank).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBank).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBank).Border.TopStyle = (BorderLineStyle) 0;
    this.lblBank.Font = new Font("Arial", 8f);
    this.lblBank.HyperLink = (string) null;
    Label lblBank = this.lblBank;
    object obj45 = componentResourceManager.GetObject("lblBank.Location");
    PointF pointF45 = obj45 != null ? (PointF) obj45 : new PointF();
    ((ARControl) lblBank).Location = pointF45;
    ((ARControl) this.lblBank).Name = "lblBank";
    ((ARControl) this.lblBank).Size = new SizeF(0.75f, 0.125f);
    this.lblBank.Text = "Bank:";
    ((ARControl) this.txtBank).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBank).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBank).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBank).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBank).DataField = "BankName";
    this.txtBank.DistinctField = (string) null;
    this.txtBank.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox txtBank = this.txtBank;
    object obj46 = componentResourceManager.GetObject("txtBank.Location");
    PointF pointF46 = obj46 != null ? (PointF) obj46 : new PointF();
    ((ARControl) txtBank).Location = pointF46;
    ((ARControl) this.txtBank).Name = "txtBank";
    this.txtBank.OutputFormat = (string) null;
    ((ARControl) this.txtBank).Size = new SizeF(9.625f, 0.125f);
    this.txtBank.Text = "Bank Name";
    ((ARControl) this.TextBox25).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox25.DistinctField = (string) null;
    this.TextBox25.Font = new Font("Arial", 8f);
    TextBox textBox25 = this.TextBox25;
    object obj47 = componentResourceManager.GetObject("TextBox25.Location");
    PointF pointF47 = obj47 != null ? (PointF) obj47 : new PointF();
    ((ARControl) textBox25).Location = pointF47;
    ((ARControl) this.TextBox25).Name = "TextBox25";
    this.TextBox25.OutputFormat = (string) null;
    ((ARControl) this.TextBox25).Size = new SizeF(0.75f, 0.125f);
    this.TextBox25.Text = "Comments:";
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 8f);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj48 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF48 = obj48 != null ? (PointF) obj48 : new PointF();
    ((ARControl) label10).Location = pointF48;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(0.75f, 0.125f);
    this.Label10.Text = "Deposit Date:";
    ((ARControl) this.txtCheckDepositDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckDepositDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckDepositDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckDepositDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckDepositDate).DataField = "DepositDate";
    this.txtCheckDepositDate.DistinctField = (string) null;
    this.txtCheckDepositDate.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox checkDepositDate = this.txtCheckDepositDate;
    object obj49 = componentResourceManager.GetObject("txtCheckDepositDate.Location");
    PointF pointF49 = obj49 != null ? (PointF) obj49 : new PointF();
    ((ARControl) checkDepositDate).Location = pointF49;
    ((ARControl) this.txtCheckDepositDate).Name = "txtCheckDepositDate";
    this.txtCheckDepositDate.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtCheckDepositDate).Size = new SizeF(0.625f, 0.125f);
    this.txtCheckDepositDate.Text = "00/00/0000";
    ((ARControl) this.TextBox32).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).DataField = "Comments";
    this.TextBox32.DistinctField = (string) null;
    this.TextBox32.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox textBox32 = this.TextBox32;
    object obj50 = componentResourceManager.GetObject("TextBox32.Location");
    PointF pointF50 = obj50 != null ? (PointF) obj50 : new PointF();
    ((ARControl) textBox32).Location = pointF50;
    ((ARControl) this.TextBox32).Name = "TextBox32";
    this.TextBox32.OutputFormat = (string) null;
    ((ARControl) this.TextBox32).Size = new SizeF(9.625f, 0.125f);
    this.TextBox32.Text = (string) null;
    this.transactNum.BackColor = Color.Yellow;
    ((ARControl) this.transactNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.transactNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.transactNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.transactNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.transactNum).DataField = "TransactNum";
    this.transactNum.DistinctField = (string) null;
    this.transactNum.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox transactNum = this.transactNum;
    object obj51 = componentResourceManager.GetObject("transactNum.Location");
    PointF pointF51 = obj51 != null ? (PointF) obj51 : new PointF();
    ((ARControl) transactNum).Location = pointF51;
    ((ARControl) this.transactNum).Name = "transactNum";
    this.transactNum.OutputFormat = (string) null;
    ((ARControl) this.transactNum).Size = new SizeF(0.25f, 1f / 16f);
    this.transactNum.Text = (string) null;
    ((ARControl) this.transactNum).Visible = false;
    this.gfTransaction.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTransaction).Name = "gfTransaction";
    this.PageSettings.Margins.Bottom = 0.4f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.375f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAll);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghDate);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghRemitter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCheck);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTransaction);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTransaction);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCheck);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfRemitter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfDate);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAll);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.txtGrandTotal).EndInit();
    ((ISupportInitialize) this.txtGrandDepositTotal).EndInit();
    ((ISupportInitialize) this.txtGrandMGACommTotal).EndInit();
    ((ISupportInitialize) this.txtGrandUnaccountedTotal).EndInit();
    ((ISupportInitialize) this.txtGrandExchangeTotal).EndInit();
    ((ISupportInitialize) this.txtGrandPostedTotal).EndInit();
    ((ISupportInitialize) this.txtGrandAPAmountTotal).EndInit();
    ((ISupportInitialize) this.lblDate).EndInit();
    ((ISupportInitialize) this.lblARReportTitle).EndInit();
    ((ISupportInitialize) this.lblAgencyName).EndInit();
    ((ISupportInitialize) this.lbltoprsp1).EndInit();
    ((ISupportInitialize) this.lbltoprsp2).EndInit();
    ((ISupportInitialize) this.lbltoprsp3).EndInit();
    ((ISupportInitialize) this.lbltoprsp4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.lbltoprPreBy).EndInit();
    ((ISupportInitialize) this.lbltoprAppBy).EndInit();
    ((ISupportInitialize) this.lbltoprInitials).EndInit();
    ((ISupportInitialize) this.lbltoprDate).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.txtDateDepositTotal).EndInit();
    ((ISupportInitialize) this.txtDatePostedTotal).EndInit();
    ((ISupportInitialize) this.txtDateExchangeTotal).EndInit();
    ((ISupportInitialize) this.txtDateUnaccountedTotal).EndInit();
    ((ISupportInitialize) this.txtDateMGACommTotal).EndInit();
    ((ISupportInitialize) this.DepositDate).EndInit();
    ((ISupportInitialize) this.txtDateAPAmountTotal).EndInit();
    ((ISupportInitialize) this.currentDepositDate).EndInit();
    ((ISupportInitialize) this.currentPostDate).EndInit();
    ((ISupportInitialize) this.txtRemitter).EndInit();
    ((ISupportInitialize) this.TextBox33).EndInit();
    ((ISupportInitialize) this.txtRemitterDepositTotal).EndInit();
    ((ISupportInitialize) this.txtRemitterPostedTotal).EndInit();
    ((ISupportInitialize) this.txtRemitterExchangeTotal).EndInit();
    ((ISupportInitialize) this.txtRemitterUnAccountedTotal).EndInit();
    ((ISupportInitialize) this.txtRemitterMGACommTotal).EndInit();
    ((ISupportInitialize) this.RemitterName).EndInit();
    ((ISupportInitialize) this.txtRemitterAPAmountTotal).EndInit();
    ((ISupportInitialize) this.checkNumber).EndInit();
    ((ISupportInitialize) this.txtCheckTotal).EndInit();
    ((ISupportInitialize) this.lblCheckTotal).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.txtPostDate).EndInit();
    ((ISupportInitialize) this.lblBank).EndInit();
    ((ISupportInitialize) this.txtBank).EndInit();
    ((ISupportInitialize) this.TextBox25).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.txtCheckDepositDate).EndInit();
    ((ISupportInitialize) this.TextBox32).EndInit();
    ((ISupportInitialize) this.transactNum).EndInit();
  }

  private void rptARReport_ReportStart(object sender, EventArgs e)
  {
    this.lblDate.Text = "Report Date: " + DateAndTime.Now.ToShortDateString();
    this.lblAgencyName.Text = Database.Instance.QueryText.PerformScalarQuery($"SELECT TOP 1 Location FROM tblClientOffices WHERE OfficeGUID = '{this._OfficeLocationGUID.ToString()}'").ToString();
    this.SetStatusText("Getting AR Information..");
    SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    DataSet dataSet = new DataSet();
    int integer = Conversions.ToInteger(Database.Instance.QueryText.PerformScalarQuery($"SELECT TOP 1 OfficeID FROM tblClientOffices WHERE OfficeGUID = '{this._OfficeLocationGUID.ToString()}'"));
    selectCommand.CommandText = "[spFin_ReportDailyAR]";
    selectCommand.CommandType = CommandType.StoredProcedure;
    selectCommand.Connection = sqlConnection;
    selectCommand.CommandTimeout = 0;
    selectCommand.Parameters.AddWithValue("@DATEFROM", (object) this._datFromDate.Date);
    selectCommand.Parameters.AddWithValue("@DATETO", (object) this._datToDate.Date);
    selectCommand.Parameters.AddWithValue("@GLCoId", (object) integer);
    selectCommand.Parameters.AddWithValue("@UseDepositDate", (object) this._UseDepositDate);
    if (!string.IsNullOrEmpty(this._bankacct))
      selectCommand.Parameters.AddWithValue("@bankAcctId", (object) this._bankacct);
    try
    {
      sqlDataAdapter.Fill(dataSet);
    }
    finally
    {
      sqlConnection.Close();
      sqlConnection.Dispose();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
    if (dataSet.Tables[0].Rows.Count > 0)
    {
      this._header = dataSet.Tables[0];
      this._details = dataSet.Tables[1];
      this._export = dataSet.Tables[2];
      this.SetStatusText("Preparing Data..");
      this.SetProgressbarMaximum(this._header.Rows.Count);
      if (this._UseDepositDate)
      {
        this.lblARReportTitle.Text = $"Cash Deposit Report - Deposit Date ({this._datFromDate.ToShortDateString()} - {this._datToDate.ToShortDateString()})";
        this.DataSource = (object) new DataView(this._header, "", "DepositDate ASC, Remitter", DataViewRowState.CurrentRows);
      }
      else
      {
        this.lblARReportTitle.Text = $"Cash Deposit Report - Post Date ({this._datFromDate.ToShortDateString()} - {this._datToDate.ToShortDateString()})";
        this.DataSource = (object) new DataView(this._header, "", "PostDate ASC, Remitter", DataViewRowState.CurrentRows);
      }
      this.ShowPageNumbers();
    }
    else
    {
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Format -= new EventHandler(this.Detail_Format);
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCheck).Format -= new EventHandler(this.gfCheck_Format);
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfRemitter).Format -= new EventHandler(this.gfRemitter_Format);
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfDate).Format -= new EventHandler(this.gfDate_Format);
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Format -= new EventHandler(this.ReportFooter_Format);
    }
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._export, SaveFileTo);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      BaseReportControl[] getReportControls = new BaseReportControl[4]
      {
        (BaseReportControl) new AccountingOfficeLocations("Office", false),
        (BaseReportControl) new DepositPostDatePicker("Search By"),
        null,
        null
      };
      DateTime now = DateAndTime.Now;
      DateTime date1 = now.Date;
      now = DateAndTime.Now;
      DateTime date2 = now.Date;
      getReportControls[2] = (BaseReportControl) new DateRangePicker("Date", date1, date2, false);
      getReportControls[3] = (BaseReportControl) new GenericListBox("Bank Account", "Select BankName + ' - ' + BankAcctNum as Display, GLAcctID as Value From tblFin_BankAccounts Order BY Display", "Value", "Display", true, typeof (int), true, false, 100);
      return getReportControls;
    }
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    this.srPostings.Report = (SectionReport) new rptARReport_ARPostings(new DataView(this._details, "transactnum = " + this.transactNum.Text, "", DataViewRowState.CurrentRows));
  }

  private void gfCheck_Format(object sender, EventArgs e)
  {
    string Left = string.Empty;
    DataRow[] dataRowArray = this._header.Select(string.Empty + $"CheckNumber = '{RuntimeHelpers.GetObjectValue(this.checkNumber.Value)}'");
    int index = 0;
    while (index < dataRowArray.Length)
    {
      DataRow dataRow = dataRowArray[index];
      Left = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, string.Empty, false) == 0 ? $"TransactNum IN('{RuntimeHelpers.GetObjectValue(dataRow["TransactNum"])}" : Left + $"', '{RuntimeHelpers.GetObjectValue(dataRow["TransactNum"])} ";
      checked { ++index; }
    }
    this.txtCheckTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(DepositAmt)", Left + "')"));
  }

  private void gfRemitter_Format(object sender, EventArgs e)
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    DataRow[] dataRowArray = this._header.Select((!this._UseDepositDate ? empty2 + $"PostDate = '{RuntimeHelpers.GetObjectValue(this.currentPostDate.Value)}'" : empty2 + $"DepositDate = '{RuntimeHelpers.GetObjectValue(this.currentDepositDate.Value)}'") + $" AND Remitter = '{this.RemitterName.Text.Replace("'", "''")}'");
    int index = 0;
    while (index < dataRowArray.Length)
    {
      DataRow dataRow = dataRowArray[index];
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(empty1, string.Empty, false) != 0)
        empty1 += " OR ";
      empty1 += $"TransactNum='{RuntimeHelpers.GetObjectValue(dataRow["TransactNum"])}'";
      checked { ++index; }
    }
    this.txtRemitterAPAmountTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(APAmount)", empty1));
    this.txtRemitterDepositTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(DepositAmt)", empty1));
    this.txtRemitterExchangeTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(XAmt)", empty1));
    this.txtRemitterMGACommTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(IncAmt)", empty1));
    this.txtRemitterPostedTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(ARAmt)", empty1));
    this.txtRemitterUnAccountedTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(UnacctAmt)", empty1));
    this.IncreaseProgressbar(1);
  }

  private void gfDate_Format(object sender, EventArgs e)
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    DataRow[] dataRowArray = this._header.Select(!this._UseDepositDate ? empty2 + $"PostDate = '{RuntimeHelpers.GetObjectValue(this.currentPostDate.Value)}'" : empty2 + $"DepositDate = '{RuntimeHelpers.GetObjectValue(this.currentDepositDate.Value)}'");
    int index = 0;
    while (index < dataRowArray.Length)
    {
      DataRow dataRow = dataRowArray[index];
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(empty1, string.Empty, false) != 0)
        empty1 += " OR ";
      empty1 += $"TransactNum='{RuntimeHelpers.GetObjectValue(dataRow["TransactNum"])}'";
      checked { ++index; }
    }
    this.txtDateAPAmountTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(APAmount)", empty1));
    this.txtDateDepositTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(DepositAmt)", empty1));
    this.txtDateExchangeTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(XAmt)", empty1));
    this.txtDateMGACommTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(IncAmt)", empty1));
    this.txtDatePostedTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(ARAmt)", empty1));
    this.txtDateUnaccountedTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(UnacctAmt)", empty1));
  }

  private void ReportFooter_Format(object sender, EventArgs e)
  {
    this.txtGrandAPAmountTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(APAmount)", ""));
    this.txtGrandDepositTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(DepositAmt)", ""));
    this.txtGrandExchangeTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(XAmt)", ""));
    this.txtGrandMGACommTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(IncAmt)", ""));
    this.txtGrandPostedTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(ARAmt)", ""));
    this.txtGrandUnaccountedTotal.Value = RuntimeHelpers.GetObjectValue(this._details.Compute("SUM(UnacctAmt)", ""));
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghAll")]
  private virtual GroupHeader ghAll { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghDate")]
  private virtual GroupHeader ghDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghRemitter")]
  private virtual GroupHeader ghRemitter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghCheck")]
  private virtual GroupHeader ghCheck { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghTransaction")]
  private virtual GroupHeader ghTransaction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_Format);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).Format -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gfTransaction")]
  private virtual GroupFooter gfTransaction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual GroupFooter gfCheck
  {
    get => this._gfCheck;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfCheck_Format);
      GroupFooter gfCheck1 = this._gfCheck;
      if (gfCheck1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) gfCheck1).Format -= eventHandler;
      this._gfCheck = value;
      GroupFooter gfCheck2 = this._gfCheck;
      if (gfCheck2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) gfCheck2).Format += eventHandler;
    }
  }

  private virtual GroupFooter gfRemitter
  {
    get => this._gfRemitter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfRemitter_Format);
      GroupFooter gfRemitter1 = this._gfRemitter;
      if (gfRemitter1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) gfRemitter1).Format -= eventHandler;
      this._gfRemitter = value;
      GroupFooter gfRemitter2 = this._gfRemitter;
      if (gfRemitter2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) gfRemitter2).Format += eventHandler;
    }
  }

  private virtual GroupFooter gfDate
  {
    get => this._gfDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfDate_Format);
      GroupFooter gfDate1 = this._gfDate;
      if (gfDate1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) gfDate1).Format -= eventHandler;
      this._gfDate = value;
      GroupFooter gfDate2 = this._gfDate;
      if (gfDate2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) gfDate2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gfAll")]
  private virtual GroupFooter gfAll { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual ReportFooter ReportFooter
  {
    get => this._ReportFooter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportFooter_Format);
      ReportFooter reportFooter1 = this._ReportFooter;
      if (reportFooter1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter1).Format -= eventHandler;
      this._ReportFooter = value;
      ReportFooter reportFooter2 = this._ReportFooter;
      if (reportFooter2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter2).Format += eventHandler;
    }
  }
}
