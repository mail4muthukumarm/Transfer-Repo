// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.AccountsPayable.rptPaymentSummary
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
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports.AccountsPayable;

public sealed class rptPaymentSummary : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{6C25D810-672C-4c13-B461-3A4AB33846F0}";
  private rptPaymentSummary_AppliedCredits _srAppliedCredits;
  private rptPaymentSummary_Detail _srDetails;
  private rptPaymentSummary_AdditionalItems _srAdditionalItems;
  private int _CheckOrTransactionNum;
  private int _BankAcctID;
  private bool _UseTransactionNum;
  private Label lblOfficeLocation;
  private Label lblPayee;
  private Label lblDate;
  private Label lblCheck;
  private TextBox txtPayee;
  private TextBox txtCheck;
  private TextBox txtDate;
  private SubReport srInvoices;
  private Label lblApplied;
  private SubReport srAppliedCredits;
  private Label Label2;
  private TextBox txtTotalPremium;
  private Label Label1;
  private SubReport srAdditionalItems;
  private Label lblTotalCheckAmount;
  private TextBox txtTotalCheckAmount;

  public rptPaymentSummary()
  {
    this.ReportStart += new EventHandler(this.rptPaymentSummary_ReportStart);
    this.Disposed += new EventHandler(this.rptPaymentSummary_Disposed);
    this._CheckOrTransactionNum = -1;
    this._BankAcctID = -1;
    this._UseTransactionNum = false;
  }

  public rptPaymentSummary(int BankAcctID, int ByCheckOrTransaction, int CheckOrTransactionNum)
  {
    this.ReportStart += new EventHandler(this.rptPaymentSummary_ReportStart);
    this.Disposed += new EventHandler(this.rptPaymentSummary_Disposed);
    this._CheckOrTransactionNum = -1;
    this._BankAcctID = -1;
    this._UseTransactionNum = false;
    this.InitializeComponent();
    if (ByCheckOrTransaction == 1)
      this._UseTransactionNum = true;
    this._BankAcctID = BankAcctID;
    this._CheckOrTransactionNum = CheckOrTransactionNum;
  }

  public rptPaymentSummary(int TransactionNum)
  {
    this.ReportStart += new EventHandler(this.rptPaymentSummary_ReportStart);
    this.Disposed += new EventHandler(this.rptPaymentSummary_Disposed);
    this._CheckOrTransactionNum = -1;
    this._BankAcctID = -1;
    this._UseTransactionNum = false;
    this.InitializeComponent();
    this._UseTransactionNum = true;
    this._CheckOrTransactionNum = TransactionNum;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptPaymentSummary));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.ghTotalCheckAmount = new GroupHeader();
    this.gfTotalCheckAmount = new GroupFooter();
    this.ghAdditionalItems = new GroupHeader();
    this.gfAdditionalItems = new GroupFooter();
    this.ghTotalPremium = new GroupHeader();
    this.gfTotalPremium = new GroupFooter();
    this.ghAppliedCredits = new GroupHeader();
    this.gfAppliedCredits = new GroupFooter();
    this.lblOfficeLocation = new Label();
    this.lblPayee = new Label();
    this.lblDate = new Label();
    this.lblCheck = new Label();
    this.txtPayee = new TextBox();
    this.txtCheck = new TextBox();
    this.txtDate = new TextBox();
    this.srInvoices = new SubReport();
    this.lblApplied = new Label();
    this.srAppliedCredits = new SubReport();
    this.Label2 = new Label();
    this.txtTotalPremium = new TextBox();
    this.Label1 = new Label();
    this.srAdditionalItems = new SubReport();
    this.lblTotalCheckAmount = new Label();
    this.txtTotalCheckAmount = new TextBox();
    ((ISupportInitialize) this.lblOfficeLocation).BeginInit();
    ((ISupportInitialize) this.lblPayee).BeginInit();
    ((ISupportInitialize) this.lblDate).BeginInit();
    ((ISupportInitialize) this.lblCheck).BeginInit();
    ((ISupportInitialize) this.txtPayee).BeginInit();
    ((ISupportInitialize) this.txtCheck).BeginInit();
    ((ISupportInitialize) this.txtDate).BeginInit();
    ((ISupportInitialize) this.lblApplied).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.txtTotalPremium).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.lblTotalCheckAmount).BeginInit();
    ((ISupportInitialize) this.txtTotalCheckAmount).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srInvoices
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 5f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.lblOfficeLocation,
      (ARControl) this.lblPayee,
      (ARControl) this.lblDate,
      (ARControl) this.lblCheck,
      (ARControl) this.txtPayee,
      (ARControl) this.txtCheck,
      (ARControl) this.txtDate
    });
    this.ReportHeader.Height = 21f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.ghTotalCheckAmount.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTotalCheckAmount).Name = "ghTotalCheckAmount";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTotalCheckAmount).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.lblTotalCheckAmount,
      (ARControl) this.txtTotalCheckAmount
    });
    this.gfTotalCheckAmount.Height = 0.1763889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTotalCheckAmount).Name = "gfTotalCheckAmount";
    this.ghAdditionalItems.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAdditionalItems).Name = "ghAdditionalItems";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAdditionalItems).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label1,
      (ARControl) this.srAdditionalItems
    });
    this.gfAdditionalItems.Height = 0.5f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAdditionalItems).Name = "gfAdditionalItems";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAdditionalItems).Visible = false;
    this.ghTotalPremium.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTotalPremium).Name = "ghTotalPremium";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTotalPremium).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label2,
      (ARControl) this.txtTotalPremium
    });
    this.gfTotalPremium.Height = 0.1763889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTotalPremium).Name = "gfTotalPremium";
    this.ghAppliedCredits.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAppliedCredits).Name = "ghAppliedCredits";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAppliedCredits).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.lblApplied,
      (ARControl) this.srAppliedCredits
    });
    this.gfAppliedCredits.Height = 0.5104167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAppliedCredits).Name = "gfAppliedCredits";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAppliedCredits).Visible = false;
    this.lblOfficeLocation.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblOfficeLocation).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblOfficeLocation).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblOfficeLocation).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblOfficeLocation).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblOfficeLocation).DataField = "CompanyLocation";
    this.lblOfficeLocation.Font = new Font("Arial", 18f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblOfficeLocation.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblOfficeLocation.HyperLink = (string) null;
    Label lblOfficeLocation = this.lblOfficeLocation;
    object obj1 = componentResourceManager.GetObject("lblOfficeLocation.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) lblOfficeLocation).Location = pointF1;
    ((ARControl) this.lblOfficeLocation).Name = "lblOfficeLocation";
    ((ARControl) this.lblOfficeLocation).Size = new SizeF(7f, 0.375f);
    this.lblOfficeLocation.Text = "[Office Location]";
    ((ARControl) this.lblPayee).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayee).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayee).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayee).Border.TopStyle = (BorderLineStyle) 0;
    this.lblPayee.Font = new Font("Arial", 8f);
    this.lblPayee.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblPayee.HyperLink = (string) null;
    Label lblPayee = this.lblPayee;
    object obj2 = componentResourceManager.GetObject("lblPayee.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) lblPayee).Location = pointF2;
    ((ARControl) this.lblPayee).Name = "lblPayee";
    ((ARControl) this.lblPayee).Size = new SizeF(0.75f, 3f / 16f);
    this.lblPayee.Text = "PAYEE:";
    ((ARControl) this.lblDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.TopStyle = (BorderLineStyle) 0;
    this.lblDate.Font = new Font("Arial", 8f);
    this.lblDate.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblDate.HyperLink = (string) null;
    Label lblDate = this.lblDate;
    object obj3 = componentResourceManager.GetObject("lblDate.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) lblDate).Location = pointF3;
    ((ARControl) this.lblDate).Name = "lblDate";
    ((ARControl) this.lblDate).Size = new SizeF(0.75f, 3f / 16f);
    this.lblDate.Text = "DATE:";
    ((ARControl) this.lblCheck).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCheck).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCheck).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCheck).Border.TopStyle = (BorderLineStyle) 0;
    this.lblCheck.Font = new Font("Arial", 8f);
    this.lblCheck.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblCheck.HyperLink = (string) null;
    Label lblCheck = this.lblCheck;
    object obj4 = componentResourceManager.GetObject("lblCheck.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) lblCheck).Location = pointF4;
    ((ARControl) this.lblCheck).Name = "lblCheck";
    ((ARControl) this.lblCheck).Size = new SizeF(0.75f, 3f / 16f);
    this.lblCheck.Text = "CHECK #";
    ((ARControl) this.txtPayee).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayee).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayee).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayee).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPayee).DataField = "Payee";
    this.txtPayee.DistinctField = (string) null;
    this.txtPayee.Font = new Font("Arial", 8f);
    this.txtPayee.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtPayee = this.txtPayee;
    object obj5 = componentResourceManager.GetObject("txtPayee.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) txtPayee).Location = pointF5;
    ((ARControl) this.txtPayee).Name = "txtPayee";
    this.txtPayee.OutputFormat = (string) null;
    ((ARControl) this.txtPayee).Size = new SizeF(4.25f, 7f / 16f);
    ((ARControl) this.txtCheck).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCheck).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheck).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheck).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheck).DataField = "CheckNum";
    this.txtCheck.DistinctField = (string) null;
    this.txtCheck.Font = new Font("Arial", 8f);
    this.txtCheck.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCheck = this.txtCheck;
    object obj6 = componentResourceManager.GetObject("txtCheck.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) txtCheck).Location = pointF6;
    ((ARControl) this.txtCheck).Name = "txtCheck";
    this.txtCheck.OutputFormat = (string) null;
    ((ARControl) this.txtCheck).Size = new SizeF(1f, 3f / 16f);
    ((ARControl) this.txtDate).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate).DataField = "CheckDate";
    this.txtDate.DistinctField = (string) null;
    this.txtDate.Font = new Font("Arial", 8f);
    this.txtDate.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtDate = this.txtDate;
    object obj7 = componentResourceManager.GetObject("txtDate.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) txtDate).Location = pointF7;
    ((ARControl) this.txtDate).Name = "txtDate";
    this.txtDate.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtDate).Size = new SizeF(1f, 3f / 16f);
    ((ARControl) this.srInvoices).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srInvoices).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srInvoices).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srInvoices).Border.TopStyle = (BorderLineStyle) 0;
    this.srInvoices.CloseBorder = false;
    SubReport srInvoices = this.srInvoices;
    object obj8 = componentResourceManager.GetObject("srInvoices.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) srInvoices).Location = pointF8;
    ((ARControl) this.srInvoices).Name = "srInvoices";
    this.srInvoices.Report = (SectionReport) null;
    ((ARControl) this.srInvoices).Size = new SizeF(6.99f, 0.188f);
    ((ARControl) this.lblApplied).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblApplied).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblApplied).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblApplied).Border.TopStyle = (BorderLineStyle) 0;
    this.lblApplied.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.lblApplied.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblApplied.HyperLink = (string) null;
    Label lblApplied = this.lblApplied;
    object obj9 = componentResourceManager.GetObject("lblApplied.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) lblApplied).Location = pointF9;
    ((ARControl) this.lblApplied).Name = "lblApplied";
    ((ARControl) this.lblApplied).Size = new SizeF(2f, 3f / 16f);
    this.lblApplied.Text = "Applied Credits";
    ((ARControl) this.srAppliedCredits).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srAppliedCredits).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srAppliedCredits).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srAppliedCredits).Border.TopStyle = (BorderLineStyle) 0;
    this.srAppliedCredits.CloseBorder = false;
    SubReport srAppliedCredits = this.srAppliedCredits;
    object obj10 = componentResourceManager.GetObject("srAppliedCredits.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) srAppliedCredits).Location = pointF10;
    ((ARControl) this.srAppliedCredits).Name = "srAppliedCredits";
    this.srAppliedCredits.Report = (SectionReport) null;
    ((ARControl) this.srAppliedCredits).Size = new SizeF(6.99f, 0.188f);
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj11 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label2).Location = pointF11;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(23f / 16f, 3f / 16f);
    this.Label2.Text = "Sub Total:";
    this.Label2.VerticalAlignment = (VerticalTextAlignment) 2;
    this.txtTotalPremium.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtTotalPremium).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalPremium).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalPremium).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalPremium).Border.TopStyle = (BorderLineStyle) 0;
    this.txtTotalPremium.DistinctField = (string) null;
    this.txtTotalPremium.Font = new Font("Arial", 8f);
    this.txtTotalPremium.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtTotalPremium = this.txtTotalPremium;
    object obj12 = componentResourceManager.GetObject("txtTotalPremium.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) txtTotalPremium).Location = pointF12;
    ((ARControl) this.txtTotalPremium).Name = "txtTotalPremium";
    this.txtTotalPremium.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtTotalPremium).Size = new SizeF(15f / 16f, 3f / 16f);
    this.txtTotalPremium.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj13 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label1).Location = pointF13;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(2f, 3f / 16f);
    this.Label1.Text = "Additional Items";
    ((ARControl) this.srAdditionalItems).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srAdditionalItems).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srAdditionalItems).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srAdditionalItems).Border.TopStyle = (BorderLineStyle) 0;
    this.srAdditionalItems.CloseBorder = false;
    SubReport srAdditionalItems = this.srAdditionalItems;
    object obj14 = componentResourceManager.GetObject("srAdditionalItems.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) srAdditionalItems).Location = pointF14;
    ((ARControl) this.srAdditionalItems).Name = "srAdditionalItems";
    this.srAdditionalItems.Report = (SectionReport) null;
    ((ARControl) this.srAdditionalItems).Size = new SizeF(6.99f, 0.188f);
    ((ARControl) this.lblTotalCheckAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTotalCheckAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTotalCheckAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTotalCheckAmount).Border.TopStyle = (BorderLineStyle) 0;
    this.lblTotalCheckAmount.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblTotalCheckAmount.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblTotalCheckAmount.HyperLink = (string) null;
    Label totalCheckAmount1 = this.lblTotalCheckAmount;
    object obj15 = componentResourceManager.GetObject("lblTotalCheckAmount.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) totalCheckAmount1).Location = pointF15;
    ((ARControl) this.lblTotalCheckAmount).Name = "lblTotalCheckAmount";
    ((ARControl) this.lblTotalCheckAmount).Size = new SizeF(23f / 16f, 3f / 16f);
    this.lblTotalCheckAmount.Text = "Total Check Amount:";
    this.lblTotalCheckAmount.VerticalAlignment = (VerticalTextAlignment) 2;
    this.txtTotalCheckAmount.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtTotalCheckAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalCheckAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalCheckAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalCheckAmount).Border.TopStyle = (BorderLineStyle) 0;
    this.txtTotalCheckAmount.DistinctField = (string) null;
    this.txtTotalCheckAmount.Font = new Font("Arial", 8f);
    this.txtTotalCheckAmount.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox totalCheckAmount2 = this.txtTotalCheckAmount;
    object obj16 = componentResourceManager.GetObject("txtTotalCheckAmount.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) totalCheckAmount2).Location = pointF16;
    ((ARControl) this.txtTotalCheckAmount).Name = "txtTotalCheckAmount";
    this.txtTotalCheckAmount.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtTotalCheckAmount).Size = new SizeF(15f / 16f, 3f / 16f);
    this.txtTotalCheckAmount.VerticalAlignment = (VerticalTextAlignment) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTotalCheckAmount);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAdditionalItems);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTotalPremium);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAppliedCredits);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAppliedCredits);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTotalPremium);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAdditionalItems);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTotalCheckAmount);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.lblOfficeLocation).EndInit();
    ((ISupportInitialize) this.lblPayee).EndInit();
    ((ISupportInitialize) this.lblDate).EndInit();
    ((ISupportInitialize) this.lblCheck).EndInit();
    ((ISupportInitialize) this.txtPayee).EndInit();
    ((ISupportInitialize) this.txtCheck).EndInit();
    ((ISupportInitialize) this.txtDate).EndInit();
    ((ISupportInitialize) this.lblApplied).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.txtTotalPremium).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.lblTotalCheckAmount).EndInit();
    ((ISupportInitialize) this.txtTotalCheckAmount).EndInit();
  }

  private void rptPaymentSummary_ReportStart(object sender, EventArgs e)
  {
    SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    DataSet dataSet = new DataSet();
    try
    {
      selectCommand.CommandText = "[spFin_rptPaymentSummary]";
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Connection = sqlConnection;
      if (this._BankAcctID != -1)
        selectCommand.Parameters.AddWithValue("@GLAcctID", (object) this._BankAcctID);
      if (this._UseTransactionNum)
        selectCommand.Parameters.AddWithValue("@TRANSACTIONNUMBER", (object) this._CheckOrTransactionNum);
      else
        selectCommand.Parameters.AddWithValue("@CHECKNUMBER", (object) this._CheckOrTransactionNum);
      sqlDataAdapter.Fill(dataSet);
      dataSet.Tables[0].TableName = "HeaderInfo";
      dataSet.Tables[1].TableName = "Invoices";
      dataSet.Tables[2].TableName = "AppliedCredits";
      dataSet.Tables[3].TableName = "AdditionalItems";
      string empty = string.Empty;
      try
      {
        foreach (DataRow row in dataSet.Tables["AppliedCredits"].Rows)
        {
          if (dataSet.Tables["Invoices"].Select($"InvoiceNum = '{RuntimeHelpers.GetObjectValue(row["InvoiceNum"])}'").Length == 0)
            dataSet.Tables["Invoices"].Rows.Add(row["OfficeInvoiceNum"], row["InvoiceNum"], row["PolicyNumber"], row["InsuredName"], (object) 0, (object) 0, (object) 0, row["CreditAmount"], row["InvoiceNum"], row["ChargeCode"], row["CompanyLineGuid"]);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (DataRow row in dataSet.Tables["Invoices"].Rows)
        {
          if (dataSet.Tables["AppliedCredits"].Select($"InvoiceNum = '{RuntimeHelpers.GetObjectValue(row["InvoiceNum"])}' AND ChargeCode = '{RuntimeHelpers.GetObjectValue(row["ChargeCode"])}' AND CompanyLineGuid = '{RuntimeHelpers.GetObjectValue(row["CompanyLineGuid"])}'").Length > 0)
          {
            row["NetPremium"] = (object) Decimal.Subtract(Conversions.ToDecimal(row["NetPremium"]), Database.IsNull(RuntimeHelpers.GetObjectValue(dataSet.Tables["AppliedCredits"].Compute("SUM(CREDITAMOUNT)", string.Format("InvoiceNum = '{0}'", RuntimeHelpers.GetObjectValue(row["InvoiceNum"]), RuntimeHelpers.GetObjectValue(row["ChargeCode"])))), 0M));
            row["Commission"] = (object) Decimal.Add(Conversions.ToDecimal(row["Commission"]), Database.IsNull(RuntimeHelpers.GetObjectValue(dataSet.Tables["AppliedCredits"].Compute("SUM(Commission)", string.Format("InvoiceNum = '{0}'", RuntimeHelpers.GetObjectValue(row["InvoiceNum"]), RuntimeHelpers.GetObjectValue(row["ChargeCode"])))), 0M));
            row["GrossPremium"] = (object) Decimal.Add(Conversions.ToDecimal(row["GrossPremium"]), Database.IsNull(RuntimeHelpers.GetObjectValue(dataSet.Tables["AppliedCredits"].Compute("SUM(GrossPremium)", string.Format("InvoiceNum = '{0}'", RuntimeHelpers.GetObjectValue(row["InvoiceNum"]), RuntimeHelpers.GetObjectValue(row["ChargeCode"])))), 0M));
          }
          else
            empty += $"(InvoiceNum <> '{RuntimeHelpers.GetObjectValue(row["InvoiceNum"])}') AND ";
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (empty.Length > 0)
      {
        string filter = empty.Remove(checked (empty.Length - 4), 4);
        Decimal.Multiply(Database.IsNull(RuntimeHelpers.GetObjectValue(dataSet.Tables["AppliedCredits"].Compute("SUM(CreditAmount)", filter)), 0M), -1M);
      }
      this.DataSource = (object) dataSet.Tables["HeaderInfo"];
      Decimal d2;
      Decimal d1_1;
      if (dataSet.Tables["Invoices"].Rows.Count > 0)
      {
        this._srDetails = new rptPaymentSummary_Detail(dataSet.Tables["Invoices"]);
        this.srInvoices.Report = (SectionReport) this._srDetails;
        Decimal d1_2;
        d2 = Decimal.Add(d1_2, Conversions.ToDecimal(dataSet.Tables["Invoices"].Compute("SUM(NETPREMIUM)", "")));
        Decimal d1_3;
        d1_1 = Decimal.Add(d1_3, d2);
      }
      if (dataSet.Tables["AppliedCredits"].Rows.Count > 0)
      {
        ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAppliedCredits).Visible = true;
        this._srAppliedCredits = new rptPaymentSummary_AppliedCredits(dataSet.Tables["AppliedCredits"]);
        this.srAppliedCredits.Report = (SectionReport) this._srAppliedCredits;
        d2 = Conversions.ToDecimal(dataSet.Tables["AppliedCredits"].Compute("SUM(CREDITAMOUNT)", ""));
        d1_1 = Decimal.Add(d1_1, d2);
      }
      if (dataSet.Tables["AdditionalItems"].Rows.Count > 0)
      {
        ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAdditionalItems).Visible = true;
        this._srAdditionalItems = new rptPaymentSummary_AdditionalItems(dataSet.Tables["AdditionalItems"]);
        this.srAdditionalItems.Report = (SectionReport) this._srAdditionalItems;
        d1_1 = Decimal.Add(d1_1, Conversions.ToDecimal(dataSet.Tables["AdditionalItems"].Compute("SUM(AMOUNT)", "")));
      }
      this.txtTotalCheckAmount.Value = (object) d1_1;
      this.txtTotalPremium.Value = (object) d2;
      this.SetStandardMargins();
      this.ShowPageNumbers();
    }
    finally
    {
      sqlConnection.Close();
      sqlConnection.Dispose();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    int num1 = checked (((CollectionBase) ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls).Count - 1);
    int num2 = 0;
    while (num2 <= num1)
    {
      ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls[num2].Height = ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height;
      checked { ++num2; }
    }
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new BankList("Bank"),
        (BaseReportControl) new GenericComboBox("Lookup By", 125, 125, typeof (int), new object[4]
        {
          (object) "Check Number",
          (object) 0,
          (object) "Transaction Number",
          (object) 1
        }),
        (BaseReportControl) new TextInput("Check/Transaction Number", true, true)
      };
    }
  }

  private void rptPaymentSummary_Disposed(object sender, EventArgs e)
  {
    if (this._srDetails != null)
      this._srDetails.Dispose();
    if (this._srAppliedCredits != null)
      this._srAppliedCredits.Dispose();
    if (this.srInvoices.Report != null)
      this.srInvoices.Report.Dispose();
    if (this.srAppliedCredits.Report == null)
      return;
    this.srAppliedCredits.Report.Dispose();
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghTotalCheckAmount")]
  private virtual GroupHeader ghTotalCheckAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghAdditionalItems")]
  private virtual GroupHeader ghAdditionalItems { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghTotalPremium")]
  private virtual GroupHeader ghTotalPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghAppliedCredits")]
  private virtual GroupHeader ghAppliedCredits { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("gfAppliedCredits")]
  private virtual GroupFooter gfAppliedCredits { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfTotalPremium")]
  private virtual GroupFooter gfTotalPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfAdditionalItems")]
  private virtual GroupFooter gfAdditionalItems { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfTotalCheckAmount")]
  private virtual GroupFooter gfTotalCheckAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
