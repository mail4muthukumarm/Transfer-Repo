// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptPayablesSummaryReport
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
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

public sealed class rptPayablesSummaryReport : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{BA366670-46B5-4ae0-89AF-405128E05D60}";
  private Guid _OfficeGUID;
  private DateTime _datFrom;
  private DateTime _datTo;
  private bool _showVoids;
  private rptPayablesSummaryReport_checks _PremiumChecks;
  private rptPayablesSummaryReport_checks _ReturnPremiumChecks;
  private rptPayablesSummaryReport_checks _OtherChecks;
  private rptPayablesSummaryReport_checks _ExchangeUnAccountedRefundChecks;
  private Label lblTitle;
  private Label lblSubTitle;
  private Label Label17;
  private SubReport srExchangeUnAccountedRefundChecks;
  private Label Label16;
  private SubReport srOtherChecks;
  private Label Label15;
  private SubReport srPremiumChecks;
  private Label Label1;
  private SubReport srReturnPremiumChecks;
  private TextBox txtTotal_CheckAmount;
  private TextBox txtTotal_Commission;
  private Label Label14;
  private TextBox txtTotal_NetBilled;

  public rptPayablesSummaryReport()
  {
    this.ReportStart += new EventHandler(this.rptPayablesSummaryReport);
    this.Disposed += new EventHandler(this.rptPayablesSummaryReport_Disposed);
  }

  public rptPayablesSummaryReport(
    Guid OfficeGUID,
    bool showVoids,
    DateTime datFrom,
    DateTime datTo)
  {
    this.ReportStart += new EventHandler(this.rptPayablesSummaryReport);
    this.Disposed += new EventHandler(this.rptPayablesSummaryReport_Disposed);
    this.InitializeComponent();
    this._OfficeGUID = OfficeGUID;
    this._datFrom = datFrom;
    this._datTo = datTo;
    this._showVoids = showVoids;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MGASystems.IMS.Accounting.Reports.rptPayablesSummaryReport));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.ghOtherChecks = new GroupHeader();
    this.gfOtherChecks = new GroupFooter();
    this.ghExchangeUnAccountedRefundChecks = new GroupHeader();
    this.gfExchangeUnAccountedRefundChecks = new GroupFooter();
    this.ghReturnPremiumChecks = new GroupHeader();
    this.gfReturnPremiumChecks = new GroupFooter();
    this.ghPremiumChecks = new GroupHeader();
    this.gfPremiumChecks = new GroupFooter();
    this.lblTitle = new Label();
    this.lblSubTitle = new Label();
    this.Label15 = new Label();
    this.srPremiumChecks = new SubReport();
    this.Label1 = new Label();
    this.srReturnPremiumChecks = new SubReport();
    this.Label17 = new Label();
    this.srExchangeUnAccountedRefundChecks = new SubReport();
    this.Label16 = new Label();
    this.srOtherChecks = new SubReport();
    this.txtTotal_CheckAmount = new TextBox();
    this.txtTotal_Commission = new TextBox();
    this.Label14 = new Label();
    this.txtTotal_NetBilled = new TextBox();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.lblSubTitle).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.txtTotal_CheckAmount).BeginInit();
    ((ISupportInitialize) this.txtTotal_Commission).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.txtTotal_NetBilled).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.lblTitle,
      (ARControl) this.lblSubTitle
    });
    this.ReportHeader.Height = 0.5104167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.txtTotal_CheckAmount,
      (ARControl) this.txtTotal_Commission,
      (ARControl) this.Label14,
      (ARControl) this.txtTotal_NetBilled
    });
    this.ReportFooter.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.ghOtherChecks.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghOtherChecks).Name = "ghOtherChecks";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfOtherChecks).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label16,
      (ARControl) this.srOtherChecks
    });
    this.gfOtherChecks.Height = 0.6f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfOtherChecks).Name = "gfOtherChecks";
    this.ghExchangeUnAccountedRefundChecks.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghExchangeUnAccountedRefundChecks).Name = "ghExchangeUnAccountedRefundChecks";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfExchangeUnAccountedRefundChecks).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label17,
      (ARControl) this.srExchangeUnAccountedRefundChecks
    });
    this.gfExchangeUnAccountedRefundChecks.Height = 0.6f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfExchangeUnAccountedRefundChecks).Name = "gfExchangeUnAccountedRefundChecks";
    this.ghReturnPremiumChecks.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghReturnPremiumChecks).Name = "ghReturnPremiumChecks";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfReturnPremiumChecks).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label1,
      (ARControl) this.srReturnPremiumChecks
    });
    this.gfReturnPremiumChecks.Height = 0.6f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfReturnPremiumChecks).Name = "gfReturnPremiumChecks";
    this.ghPremiumChecks.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghPremiumChecks).Name = "ghPremiumChecks";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfPremiumChecks).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label15,
      (ARControl) this.srPremiumChecks
    });
    this.gfPremiumChecks.Height = 0.6f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfPremiumChecks).Name = "gfPremiumChecks";
    this.lblTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.lblTitle.Font = new Font("Arial", 14.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTitle.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblTitle.HyperLink = (string) null;
    Label lblTitle = this.lblTitle;
    object obj1 = componentResourceManager.GetObject("lblTitle.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) lblTitle).Location = pointF1;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    ((ARControl) this.lblTitle).Size = new SizeF(9.5f, 0.25f);
    this.lblTitle.Text = "Payables Summary Report";
    this.lblSubTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblSubTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSubTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSubTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSubTitle).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSubTitle).DataField = "company";
    this.lblSubTitle.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblSubTitle.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblSubTitle.HyperLink = (string) null;
    Label lblSubTitle = this.lblSubTitle;
    object obj2 = componentResourceManager.GetObject("lblSubTitle.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) lblSubTitle).Location = pointF2;
    ((ARControl) this.lblSubTitle).Name = "lblSubTitle";
    ((ARControl) this.lblSubTitle).Size = new SizeF(9.5f, 3f / 16f);
    this.lblSubTitle.Text = "";
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 0;
    this.Label15.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label15.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label15.HyperLink = (string) null;
    Label label15 = this.Label15;
    object obj3 = componentResourceManager.GetObject("Label15.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label15).Location = pointF3;
    ((ARControl) this.Label15).Name = "Label15";
    ((ARControl) this.Label15).Size = new SizeF(3f, 3f / 16f);
    this.Label15.Text = "Premium Checks";
    ((ARControl) this.srPremiumChecks).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srPremiumChecks).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srPremiumChecks).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srPremiumChecks).Border.TopStyle = (BorderLineStyle) 0;
    this.srPremiumChecks.CloseBorder = false;
    SubReport srPremiumChecks = this.srPremiumChecks;
    object obj4 = componentResourceManager.GetObject("srPremiumChecks.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) srPremiumChecks).Location = pointF4;
    ((ARControl) this.srPremiumChecks).Name = "srPremiumChecks";
    this.srPremiumChecks.Report = (SectionReport) null;
    ((ARControl) this.srPremiumChecks).Size = new SizeF(9.5f, 3f / 16f);
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj5 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label1).Location = pointF5;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(3f, 3f / 16f);
    this.Label1.Text = "Return Premium Checks";
    ((ARControl) this.srReturnPremiumChecks).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srReturnPremiumChecks).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srReturnPremiumChecks).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srReturnPremiumChecks).Border.TopStyle = (BorderLineStyle) 0;
    this.srReturnPremiumChecks.CloseBorder = false;
    SubReport returnPremiumChecks = this.srReturnPremiumChecks;
    object obj6 = componentResourceManager.GetObject("srReturnPremiumChecks.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) returnPremiumChecks).Location = pointF6;
    ((ARControl) this.srReturnPremiumChecks).Name = "srReturnPremiumChecks";
    this.srReturnPremiumChecks.Report = (SectionReport) null;
    ((ARControl) this.srReturnPremiumChecks).Size = new SizeF(9.5f, 3f / 16f);
    ((ARControl) this.Label17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.TopStyle = (BorderLineStyle) 0;
    this.Label17.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label17.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label17.HyperLink = (string) null;
    Label label17 = this.Label17;
    object obj7 = componentResourceManager.GetObject("Label17.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label17).Location = pointF7;
    ((ARControl) this.Label17).Name = "Label17";
    ((ARControl) this.Label17).Size = new SizeF(3f, 3f / 16f);
    this.Label17.Text = "Exchange / UnAccounted Refund Checks";
    ((ARControl) this.srExchangeUnAccountedRefundChecks).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srExchangeUnAccountedRefundChecks).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srExchangeUnAccountedRefundChecks).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srExchangeUnAccountedRefundChecks).Border.TopStyle = (BorderLineStyle) 0;
    this.srExchangeUnAccountedRefundChecks.CloseBorder = false;
    SubReport accountedRefundChecks = this.srExchangeUnAccountedRefundChecks;
    object obj8 = componentResourceManager.GetObject("srExchangeUnAccountedRefundChecks.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) accountedRefundChecks).Location = pointF8;
    ((ARControl) this.srExchangeUnAccountedRefundChecks).Name = "srExchangeUnAccountedRefundChecks";
    this.srExchangeUnAccountedRefundChecks.Report = (SectionReport) null;
    ((ARControl) this.srExchangeUnAccountedRefundChecks).Size = new SizeF(9.5f, 3f / 16f);
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 0;
    this.Label16.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label16.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label16.HyperLink = (string) null;
    Label label16 = this.Label16;
    object obj9 = componentResourceManager.GetObject("Label16.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label16).Location = pointF9;
    ((ARControl) this.Label16).Name = "Label16";
    ((ARControl) this.Label16).Size = new SizeF(3f, 3f / 16f);
    this.Label16.Text = "Other Checks";
    ((ARControl) this.srOtherChecks).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srOtherChecks).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srOtherChecks).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srOtherChecks).Border.TopStyle = (BorderLineStyle) 0;
    this.srOtherChecks.CloseBorder = false;
    SubReport srOtherChecks = this.srOtherChecks;
    object obj10 = componentResourceManager.GetObject("srOtherChecks.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) srOtherChecks).Location = pointF10;
    ((ARControl) this.srOtherChecks).Name = "srOtherChecks";
    this.srOtherChecks.Report = (SectionReport) null;
    ((ARControl) this.srOtherChecks).Size = new SizeF(9.5f, 3f / 16f);
    this.txtTotal_CheckAmount.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtTotal_CheckAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal_CheckAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal_CheckAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal_CheckAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal_CheckAmount).DataField = "Check Amount";
    this.txtTotal_CheckAmount.DistinctField = (string) null;
    this.txtTotal_CheckAmount.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtTotal_CheckAmount.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox totalCheckAmount = this.txtTotal_CheckAmount;
    object obj11 = componentResourceManager.GetObject("txtTotal_CheckAmount.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) totalCheckAmount).Location = pointF11;
    ((ARControl) this.txtTotal_CheckAmount).Name = "txtTotal_CheckAmount";
    this.txtTotal_CheckAmount.OutputFormat = "#,##0.00";
    ((ARControl) this.txtTotal_CheckAmount).Size = new SizeF(13f / 16f, 3f / 16f);
    this.txtTotal_CheckAmount.Text = " ";
    this.txtTotal_Commission.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtTotal_Commission).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal_Commission).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal_Commission).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal_Commission).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal_Commission).DataField = "Gross Commission";
    this.txtTotal_Commission.DistinctField = (string) null;
    this.txtTotal_Commission.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtTotal_Commission.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtTotalCommission = this.txtTotal_Commission;
    object obj12 = componentResourceManager.GetObject("txtTotal_Commission.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) txtTotalCommission).Location = pointF12;
    ((ARControl) this.txtTotal_Commission).Name = "txtTotal_Commission";
    this.txtTotal_Commission.OutputFormat = "#,##0.00";
    ((ARControl) this.txtTotal_Commission).Size = new SizeF(13f / 16f, 3f / 16f);
    this.txtTotal_Commission.Text = " ";
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    this.Label14.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label14.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label14.HyperLink = (string) null;
    Label label14 = this.Label14;
    object obj13 = componentResourceManager.GetObject("Label14.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label14).Location = pointF13;
    ((ARControl) this.Label14).Name = "Label14";
    ((ARControl) this.Label14).Size = new SizeF(0.5f, 3f / 16f);
    this.Label14.Text = "Totals:";
    this.txtTotal_NetBilled.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtTotal_NetBilled).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal_NetBilled).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal_NetBilled).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal_NetBilled).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotal_NetBilled).DataField = "Net";
    this.txtTotal_NetBilled.DistinctField = (string) null;
    this.txtTotal_NetBilled.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtTotal_NetBilled.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtTotalNetBilled = this.txtTotal_NetBilled;
    object obj14 = componentResourceManager.GetObject("txtTotal_NetBilled.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) txtTotalNetBilled).Location = pointF14;
    ((ARControl) this.txtTotal_NetBilled).Name = "txtTotal_NetBilled";
    this.txtTotal_NetBilled.OutputFormat = "#,##0.00";
    ((ARControl) this.txtTotal_NetBilled).Size = new SizeF(0.875f, 3f / 16f);
    this.txtTotal_NetBilled.Text = " ";
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 9.5f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghOtherChecks);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghExchangeUnAccountedRefundChecks);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghReturnPremiumChecks);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghPremiumChecks);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfPremiumChecks);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfReturnPremiumChecks);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfExchangeUnAccountedRefundChecks);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfOtherChecks);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.lblSubTitle).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.txtTotal_CheckAmount).EndInit();
    ((ISupportInitialize) this.txtTotal_Commission).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.txtTotal_NetBilled).EndInit();
  }

  private void rptPayablesSummaryReport(object sender, EventArgs e)
  {
    SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    DataSet dataSet = new DataSet();
    this.lblTitle.Text = $"Payables Summary Report  ({this._datFrom.ToShortDateString()} - {this._datTo.ToShortDateString()})";
    selectCommand.CommandText = "[spFin_rptPayablesSummaryReport]";
    selectCommand.CommandType = CommandType.StoredProcedure;
    selectCommand.Connection = sqlConnection;
    selectCommand.Parameters.AddWithValue("@officeguid", (object) this._OfficeGUID);
    selectCommand.Parameters.AddWithValue("@showVoids", (object) Conversions.ToInteger(Interaction.IIf(this._showVoids, (object) 1, (object) 0)));
    selectCommand.Parameters.AddWithValue("@fromdate", (object) this._datFrom);
    selectCommand.Parameters.AddWithValue("@todate", (object) this._datTo);
    try
    {
      sqlDataAdapter.Fill(dataSet);
    }
    finally
    {
      sqlConnection.Dispose();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
    dataSet.Tables[0].TableName = "company";
    dataSet.Tables[1].TableName = "data";
    DataView dv1 = new DataView(dataSet.Tables["data"], "TransDescID = 'D'", "", DataViewRowState.CurrentRows);
    if (dv1.Count > 0)
    {
      this._PremiumChecks = new rptPayablesSummaryReport_checks(dv1);
      this.srPremiumChecks.Report = (SectionReport) this._PremiumChecks;
    }
    else
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfPremiumChecks).Visible = false;
    DataView dv2 = new DataView(dataSet.Tables["data"], "TransDescID = 'R'", "", DataViewRowState.CurrentRows);
    if (dv2.Count > 0)
    {
      this._ReturnPremiumChecks = new rptPayablesSummaryReport_checks(dv2);
      this.srReturnPremiumChecks.Report = (SectionReport) this._ReturnPremiumChecks;
    }
    else
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfReturnPremiumChecks).Visible = false;
    DataView dv3 = new DataView(dataSet.Tables["data"], "TransDescID = 'S'", "", DataViewRowState.CurrentRows);
    if (dv3.Count > 0)
    {
      this._OtherChecks = new rptPayablesSummaryReport_checks(dv3);
      this.srOtherChecks.Report = (SectionReport) this._OtherChecks;
    }
    else
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfOtherChecks).Visible = false;
    DataView dv4 = new DataView(dataSet.Tables["data"], "TransDescID = 'B' OR TransDescID = 'J'", "", DataViewRowState.CurrentRows);
    if (dv4.Count > 0)
    {
      this._ExchangeUnAccountedRefundChecks = new rptPayablesSummaryReport_checks(dv4);
      this.srExchangeUnAccountedRefundChecks.Report = (SectionReport) this._ExchangeUnAccountedRefundChecks;
    }
    else
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfExchangeUnAccountedRefundChecks).Visible = false;
    this.txtTotal_CheckAmount.Value = RuntimeHelpers.GetObjectValue(dataSet.Tables["data"].Compute("SUM([Check Amount])", ""));
    this.txtTotal_Commission.Value = RuntimeHelpers.GetObjectValue(dataSet.Tables["data"].Compute("SUM([Gross Commission])", ""));
    this.txtTotal_NetBilled.Value = RuntimeHelpers.GetObjectValue(dataSet.Tables["data"].Compute("SUM(Net)", ""));
    if (dataSet.Tables["data"].Rows.Count > 0)
      this.DataSource = (object) dataSet.Tables["company"];
    else
      this.DataSource = (object) null;
    this.SetStandardMargins();
    this.ShowPageNumbers();
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      BaseReportControl[] getReportControls = new BaseReportControl[3]
      {
        (BaseReportControl) new AccountingOfficeLocations("Office", false),
        (BaseReportControl) new GenericComboBox("Show Voids", 100, 100, typeof (bool), new object[4]
        {
          (object) "No",
          (object) false,
          (object) "Yes",
          (object) true
        }),
        null
      };
      DateTime now = DateAndTime.Now;
      DateTime date1 = now.Date;
      now = DateAndTime.Now;
      DateTime date2 = now.Date;
      getReportControls[2] = (BaseReportControl) new DateRangePicker("", date1, date2, false);
      return getReportControls;
    }
  }

  private void rptPayablesSummaryReport_Disposed(object sender, EventArgs e)
  {
    if (this._PremiumChecks != null)
      this._PremiumChecks.Dispose();
    if (this._ReturnPremiumChecks != null)
      this._ReturnPremiumChecks.Dispose();
    if (this._OtherChecks != null)
      this._OtherChecks.Dispose();
    if (this._ExchangeUnAccountedRefundChecks == null)
      return;
    this._ExchangeUnAccountedRefundChecks.Dispose();
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghReturnPremiumChecks")]
  private virtual GroupHeader ghReturnPremiumChecks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghPremiumChecks")]
  private virtual GroupHeader ghPremiumChecks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghOtherChecks")]
  private virtual GroupHeader ghOtherChecks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghExchangeUnAccountedRefundChecks")]
  private virtual GroupHeader ghExchangeUnAccountedRefundChecks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("gfExchangeUnAccountedRefundChecks")]
  private virtual GroupFooter gfExchangeUnAccountedRefundChecks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfOtherChecks")]
  private virtual GroupFooter gfOtherChecks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfPremiumChecks")]
  private virtual GroupFooter gfPremiumChecks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfReturnPremiumChecks")]
  private virtual GroupFooter gfReturnPremiumChecks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
