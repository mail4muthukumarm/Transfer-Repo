// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptPaymentStatement
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Accounting.Reports.AccountsPayable;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{37747582-4AAE-44da-BC1D-C89D886F8E77}", "Payment Statement", "Detailed statement for a payment transaction.", "Accounting")]
public class rptPaymentStatement : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{37747582-4AAE-44da-BC1D-C89D886F8E77}";
  private int _CheckOrTransactionNum;
  private int _BankAcctID;
  private bool _UseTransactionNum;
  private DataSet _data;
  private DataTable _export;
  private TextBox txtCheckNumber;
  private TextBox txtCheckDate;
  private TextBox txtCompany;
  private Label Label;
  private TextBox txtPayeeAddress;
  private Label Label1;
  private Label Label2;
  private Line Line;
  private Line Line1;
  private Label Label3;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private SubReport SubReport1;
  private TextBox txtGrossTotal;
  private TextBox txtCommTotal;
  private TextBox txtPaidTotal;
  private Label Label10;
  private TextBox txtPaidtoDateTotal;
  private TextBox txtNetDueTotal;
  private SubReport subAdditionalItems;
  private Label Label13;
  private TextBox textCheckTotal;

  [field: AccessedThroughProperty("TxtPostingMemo")]
  private virtual TextBox TxtPostingMemo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptPaymentStatement()
  {
    this.ReportStart += new EventHandler(this.rptPaymentStatement_ReportStart);
    this._CheckOrTransactionNum = -1;
    this._BankAcctID = -1;
    this._UseTransactionNum = false;
    this._data = new DataSet();
    this._export = new DataTable();
    this.InitializeComponent();
  }

  public rptPaymentStatement(int BankAcctID, int ByCheckOrTransaction, int CheckOrTransactionNum)
  {
    this.ReportStart += new EventHandler(this.rptPaymentStatement_ReportStart);
    this._CheckOrTransactionNum = -1;
    this._BankAcctID = -1;
    this._UseTransactionNum = false;
    this._data = new DataSet();
    this._export = new DataTable();
    this.InitializeComponent();
    if (ByCheckOrTransaction == 1)
      this._UseTransactionNum = true;
    this._BankAcctID = BankAcctID;
    this._CheckOrTransactionNum = CheckOrTransactionNum;
  }

  public rptPaymentStatement(int TransactionNum)
  {
    this.ReportStart += new EventHandler(this.rptPaymentStatement_ReportStart);
    this._CheckOrTransactionNum = -1;
    this._BankAcctID = -1;
    this._UseTransactionNum = false;
    this._data = new DataSet();
    this._export = new DataTable();
    this.InitializeComponent();
    this._UseTransactionNum = true;
    this._CheckOrTransactionNum = TransactionNum;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptPaymentStatement));
    this.Detail = new Detail();
    this.SubReport1 = new SubReport();
    this.ReportHeader = new ReportHeader();
    this.txtCheckNumber = new TextBox();
    this.txtCheckDate = new TextBox();
    this.txtCompany = new TextBox();
    this.Label = new Label();
    this.txtPayeeAddress = new TextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Line = new Line();
    this.Line1 = new Line();
    this.ReportFooter = new ReportFooter();
    this.txtGrossTotal = new TextBox();
    this.txtCommTotal = new TextBox();
    this.txtPaidTotal = new TextBox();
    this.Label10 = new Label();
    this.txtPaidtoDateTotal = new TextBox();
    this.txtNetDueTotal = new TextBox();
    this.subAdditionalItems = new SubReport();
    this.Label13 = new Label();
    this.textCheckTotal = new TextBox();
    this.PageHeader = new PageHeader();
    this.Label3 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.PageFooter = new PageFooter();
    this.TxtPostingMemo = new TextBox();
    this.Label4 = new Label();
    ((ISupportInitialize) this.txtCheckNumber).BeginInit();
    ((ISupportInitialize) this.txtCheckDate).BeginInit();
    ((ISupportInitialize) this.txtCompany).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.txtPayeeAddress).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.txtGrossTotal).BeginInit();
    ((ISupportInitialize) this.txtCommTotal).BeginInit();
    ((ISupportInitialize) this.txtPaidTotal).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.txtPaidtoDateTotal).BeginInit();
    ((ISupportInitialize) this.txtNetDueTotal).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.textCheckTotal).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.TxtPostingMemo).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.SubReport1
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    this.SubReport1.CloseBorder = false;
    ((ARControl) this.SubReport1).Height = 0.125f;
    ((ARControl) this.SubReport1).Left = 0.0f;
    ((ARControl) this.SubReport1).Name = "SubReport1";
    this.SubReport1.Report = (SectionReport) null;
    ((ARControl) this.SubReport1).Top = 0.0f;
    ((ARControl) this.SubReport1).Width = 7.9f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.txtCheckNumber,
      (ARControl) this.txtCheckDate,
      (ARControl) this.txtCompany,
      (ARControl) this.Label,
      (ARControl) this.txtPayeeAddress,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Line,
      (ARControl) this.Line1,
      (ARControl) this.TxtPostingMemo,
      (ARControl) this.Label4
    });
    this.ReportHeader.Height = 1.416667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.txtCheckNumber).DataField = "CheckNum";
    ((ARControl) this.txtCheckNumber).Height = 3f / 16f;
    ((ARControl) this.txtCheckNumber).Left = 6.125f;
    ((ARControl) this.txtCheckNumber).Name = "txtCheckNumber";
    this.txtCheckNumber.Style = "font-size: 9pt; ddo-char-set: 0";
    this.txtCheckNumber.Text = (string) null;
    ((ARControl) this.txtCheckNumber).Top = 0.875f;
    ((ARControl) this.txtCheckNumber).Width = 25f / 16f;
    ((ARControl) this.txtCheckDate).DataField = "checkDate";
    ((ARControl) this.txtCheckDate).Height = 3f / 16f;
    ((ARControl) this.txtCheckDate).Left = 6.125f;
    ((ARControl) this.txtCheckDate).Name = "txtCheckDate";
    this.txtCheckDate.OutputFormat = resourceManager.GetString("txtCheckDate.OutputFormat");
    this.txtCheckDate.Style = "font-size: 9pt; ddo-char-set: 0";
    this.txtCheckDate.Text = (string) null;
    ((ARControl) this.txtCheckDate).Top = 0.625f;
    ((ARControl) this.txtCheckDate).Width = 25f / 16f;
    ((ARControl) this.txtCompany).DataField = "CompanyLocation";
    ((ARControl) this.txtCompany).Height = 0.25f;
    ((ARControl) this.txtCompany).Left = 0.0f;
    ((ARControl) this.txtCompany).Name = "txtCompany";
    this.txtCompany.Style = "font-size: 12pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.txtCompany.Text = (string) null;
    ((ARControl) this.txtCompany).Top = 0.0f;
    ((ARControl) this.txtCompany).Width = 125f / 16f;
    ((ARControl) this.Label).Height = 0.2f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.3750001f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 9pt; text-align: right; ddo-char-set: 0";
    this.Label.Text = "Payee:";
    ((ARControl) this.Label).Top = 0.625f;
    ((ARControl) this.Label).Width = 0.5f;
    ((ARControl) this.txtPayeeAddress).DataField = "payee";
    ((ARControl) this.txtPayeeAddress).Height = 0.5f;
    ((ARControl) this.txtPayeeAddress).Left = 0.937f;
    ((ARControl) this.txtPayeeAddress).Name = "txtPayeeAddress";
    this.txtPayeeAddress.Style = "font-size: 9pt; ddo-char-set: 0";
    this.txtPayeeAddress.Text = (string) null;
    ((ARControl) this.txtPayeeAddress).Top = 0.625f;
    ((ARControl) this.txtPayeeAddress).Width = 2.375f;
    ((ARControl) this.Label1).Height = 0.2f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 5.625f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 9pt; text-align: right; ddo-char-set: 0";
    this.Label1.Text = "Date:";
    ((ARControl) this.Label1).Top = 0.625f;
    ((ARControl) this.Label1).Width = 7f / 16f;
    ((ARControl) this.Label2).Height = 0.2f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 87f / 16f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 9pt; text-align: right; ddo-char-set: 0";
    this.Label2.Text = "Check #:";
    ((ARControl) this.Label2).Top = 0.875f;
    ((ARControl) this.Label2).Width = 0.625f;
    ((ARControl) this.Line).Height = 0.0f;
    ((ARControl) this.Line).Left = 6.125f;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    ((ARControl) this.Line).Top = 13f / 16f;
    ((ARControl) this.Line).Width = 25f / 16f;
    this.Line.X1 = 6.125f;
    this.Line.X2 = 123f / 16f;
    this.Line.Y1 = 13f / 16f;
    this.Line.Y2 = 13f / 16f;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 6.125f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 17f / 16f;
    ((ARControl) this.Line1).Width = 25f / 16f;
    this.Line1.X1 = 6.125f;
    this.Line1.X2 = 123f / 16f;
    this.Line1.Y1 = 17f / 16f;
    this.Line1.Y2 = 17f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.txtGrossTotal,
      (ARControl) this.txtCommTotal,
      (ARControl) this.txtPaidTotal,
      (ARControl) this.Label10,
      (ARControl) this.txtPaidtoDateTotal,
      (ARControl) this.txtNetDueTotal,
      (ARControl) this.subAdditionalItems,
      (ARControl) this.Label13,
      (ARControl) this.textCheckTotal
    });
    this.ReportFooter.Height = 0.5104167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.txtGrossTotal).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtGrossTotal).Height = 0.125f;
    ((ARControl) this.txtGrossTotal).Left = 4.125f;
    ((ARControl) this.txtGrossTotal).Name = "txtGrossTotal";
    this.txtGrossTotal.OutputFormat = resourceManager.GetString("txtGrossTotal.OutputFormat");
    this.txtGrossTotal.Style = "font-size: 7pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtGrossTotal.Text = (string) null;
    ((ARControl) this.txtGrossTotal).Top = 0.0f;
    ((ARControl) this.txtGrossTotal).Width = 0.75f;
    ((ARControl) this.txtCommTotal).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCommTotal).Height = 0.125f;
    ((ARControl) this.txtCommTotal).Left = 4.875f;
    ((ARControl) this.txtCommTotal).Name = "txtCommTotal";
    this.txtCommTotal.OutputFormat = resourceManager.GetString("txtCommTotal.OutputFormat");
    this.txtCommTotal.Style = "font-size: 7pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtCommTotal.Text = (string) null;
    ((ARControl) this.txtCommTotal).Top = 0.0f;
    ((ARControl) this.txtCommTotal).Width = 0.75f;
    ((ARControl) this.txtPaidTotal).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPaidTotal).Height = 0.125f;
    ((ARControl) this.txtPaidTotal).Left = 7.125f;
    ((ARControl) this.txtPaidTotal).Name = "txtPaidTotal";
    this.txtPaidTotal.OutputFormat = resourceManager.GetString("txtPaidTotal.OutputFormat");
    this.txtPaidTotal.Style = "font-size: 7pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtPaidTotal.Text = (string) null;
    ((ARControl) this.txtPaidTotal).Top = 0.0f;
    ((ARControl) this.txtPaidTotal).Width = 0.75f;
    ((ARControl) this.Label10).Height = 0.125f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 2.875f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-size: 7pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label10.Text = "Totals:";
    ((ARControl) this.Label10).Top = 0.0f;
    ((ARControl) this.Label10).Width = 1f;
    ((ARControl) this.txtPaidtoDateTotal).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPaidtoDateTotal).Height = 0.125f;
    ((ARControl) this.txtPaidtoDateTotal).Left = 6.375f;
    ((ARControl) this.txtPaidtoDateTotal).Name = "txtPaidtoDateTotal";
    this.txtPaidtoDateTotal.OutputFormat = resourceManager.GetString("txtPaidtoDateTotal.OutputFormat");
    this.txtPaidtoDateTotal.Style = "font-size: 7pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtPaidtoDateTotal.Text = (string) null;
    ((ARControl) this.txtPaidtoDateTotal).Top = 0.0f;
    ((ARControl) this.txtPaidtoDateTotal).Width = 0.75f;
    ((ARControl) this.txtNetDueTotal).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtNetDueTotal).Height = 0.125f;
    ((ARControl) this.txtNetDueTotal).Left = 5.625f;
    ((ARControl) this.txtNetDueTotal).Name = "txtNetDueTotal";
    this.txtNetDueTotal.OutputFormat = resourceManager.GetString("txtNetDueTotal.OutputFormat");
    this.txtNetDueTotal.Style = "font-size: 7pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtNetDueTotal.Text = (string) null;
    ((ARControl) this.txtNetDueTotal).Top = 0.0f;
    ((ARControl) this.txtNetDueTotal).Width = 0.75f;
    this.subAdditionalItems.CloseBorder = false;
    ((ARControl) this.subAdditionalItems).Height = 0.063f;
    ((ARControl) this.subAdditionalItems).Left = 15f / 16f;
    ((ARControl) this.subAdditionalItems).Name = "subAdditionalItems";
    this.subAdditionalItems.Report = (SectionReport) null;
    ((ARControl) this.subAdditionalItems).Top = 0.25f;
    ((ARControl) this.subAdditionalItems).Width = 6.938f;
    ((ARControl) this.Label13).Height = 0.125f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 5.5f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-size: 7pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label13.Text = "Check Total:";
    ((ARControl) this.Label13).Top = 0.375f;
    ((ARControl) this.Label13).Width = 1f;
    ((ARControl) this.textCheckTotal).Height = 0.125f;
    ((ARControl) this.textCheckTotal).Left = 105f / 16f;
    ((ARControl) this.textCheckTotal).Name = "textCheckTotal";
    this.textCheckTotal.OutputFormat = resourceManager.GetString("textCheckTotal.OutputFormat");
    this.textCheckTotal.Style = "font-size: 7pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.textCheckTotal.Text = (string) null;
    ((ARControl) this.textCheckTotal).Top = 0.375f;
    ((ARControl) this.textCheckTotal).Width = 21f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.Label3,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label14,
      (ARControl) this.Label15,
      (ARControl) this.Label16,
      (ARControl) this.Label17,
      (ARControl) this.Label18
    });
    this.PageHeader.Height = 0.1458333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label3).Height = 0.2f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 0.0f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 7pt; font-weight: bold; text-decoration: underline; ddo-char-set: 0";
    this.Label3.Text = "Invoice #";
    ((ARControl) this.Label3).Top = 0.0f;
    ((ARControl) this.Label3).Width = 0.625f;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 2.5f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 7pt; font-weight: bold; text-decoration: underline; ddo-char-set: 0";
    this.Label6.Text = "Line";
    ((ARControl) this.Label6).Top = 0.0f;
    ((ARControl) this.Label6).Width = 1.125f;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 29f / 16f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 7pt; font-weight: bold; text-decoration: underline; ddo-char-set: 0";
    this.Label7.Text = "Policy #";
    ((ARControl) this.Label7).Top = 0.0f;
    ((ARControl) this.Label7).Width = 9f / 16f;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 0.625f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 7pt; font-weight: bold; text-decoration: underline; ddo-char-set: 0";
    this.Label8.Text = "Insured";
    ((ARControl) this.Label8).Top = 0.0f;
    ((ARControl) this.Label8).Width = 17f / 16f;
    ((ARControl) this.Label14).Height = 3f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 4.125f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "font-size: 7pt; font-weight: bold; text-align: right; text-decoration: underline; ddo-char-set: 0";
    this.Label14.Text = "Gross Premium";
    ((ARControl) this.Label14).Top = 0.0f;
    ((ARControl) this.Label14).Width = 13f / 16f;
    ((ARControl) this.Label15).Height = 0.125f;
    this.Label15.HyperLink = (string) null;
    ((ARControl) this.Label15).Left = 115f / 16f;
    ((ARControl) this.Label15).Name = "Label15";
    this.Label15.Style = "font-size: 7pt; font-weight: bold; text-align: right; text-decoration: underline; ddo-char-set: 0";
    this.Label15.Text = "Amt Paid Now";
    ((ARControl) this.Label15).Top = 0.0f;
    ((ARControl) this.Label15).Width = 11f / 16f;
    ((ARControl) this.Label16).Height = 0.125f;
    this.Label16.HyperLink = (string) null;
    ((ARControl) this.Label16).Left = 91f / 16f;
    ((ARControl) this.Label16).Name = "Label16";
    this.Label16.Style = "font-size: 7pt; font-weight: bold; text-align: right; text-decoration: underline; ddo-char-set: 0";
    this.Label16.Text = "Net Due";
    ((ARControl) this.Label16).Top = 0.0f;
    ((ARControl) this.Label16).Width = 0.75f;
    ((ARControl) this.Label17).Height = 0.125f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 103f / 16f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "font-size: 7pt; font-weight: bold; text-align: right; text-decoration: underline; ddo-char-set: 0";
    this.Label17.Text = "Paid To Date";
    ((ARControl) this.Label17).Top = 0.0f;
    ((ARControl) this.Label17).Width = 0.75f;
    ((ARControl) this.Label18).Height = 0.125f;
    this.Label18.HyperLink = (string) null;
    ((ARControl) this.Label18).Left = 79f / 16f;
    ((ARControl) this.Label18).Name = "Label18";
    this.Label18.Style = "font-size: 7pt; font-weight: bold; text-align: right; text-decoration: underline; ddo-char-set: 0";
    this.Label18.Text = "Commission";
    ((ARControl) this.Label18).Top = 0.0f;
    ((ARControl) this.Label18).Width = 0.75f;
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((ARControl) this.TxtPostingMemo).DataField = "PostingMemo";
    ((ARControl) this.TxtPostingMemo).Height = 0.2f;
    ((ARControl) this.TxtPostingMemo).Left = 0.937f;
    ((ARControl) this.TxtPostingMemo).Name = "TxtPostingMemo";
    this.TxtPostingMemo.Style = "font-size: 9pt; ddo-char-set: 0";
    this.TxtPostingMemo.Text = "Sparta March 13 AC wire transfer dated 05/15/13 in the amount of $2,088,866.49 (Sirius $299,573.98 & IMS $1,814,495.60)";
    ((ARControl) this.TxtPostingMemo).Top = 1.187f;
    ((ARControl) this.TxtPostingMemo).Width = 3.687f;
    ((ARControl) this.Label4).Height = 0.2f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 0.0f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 9pt; text-align: right; ddo-char-set: 0";
    this.Label4.Text = "Posting Memo:";
    ((ARControl) this.Label4).Top = 1.187f;
    ((ARControl) this.Label4).Width = 0.8750001f;
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; text-align: left; vertical-align: top; ddo-char-set: 1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: bold", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtCheckNumber).EndInit();
    ((ISupportInitialize) this.txtCheckDate).EndInit();
    ((ISupportInitialize) this.txtCompany).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.txtPayeeAddress).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.txtGrossTotal).EndInit();
    ((ISupportInitialize) this.txtCommTotal).EndInit();
    ((ISupportInitialize) this.txtPaidTotal).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.txtPaidtoDateTotal).EndInit();
    ((ISupportInitialize) this.txtNetDueTotal).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.textCheckTotal).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.TxtPostingMemo).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this).EndInit();
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

  private void rptPaymentStatement_ReportStart(object sender, EventArgs e)
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_rptPaymentStatement", new SqlConnection(CurrentUser.Instance.ConnectionString)));
    try
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.CommandTimeout = 0;
      if (this._BankAcctID != -1)
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@GLAcctID", (object) this._BankAcctID);
      if (this._UseTransactionNum)
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TRANSACTIONNUMBER", (object) this._CheckOrTransactionNum);
      else
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@CHECKNUMBER", (object) this._CheckOrTransactionNum);
      sqlDataAdapter.Fill(this._data);
      this.DataSource = (object) this._data.Tables[0];
      rptPaymentStatement_Invoices statementInvoices = new rptPaymentStatement_Invoices(this._data.Tables[1], this._data.Tables[2]);
      statementInvoices.DataSource = (object) this._data.Tables[1];
      this.SubReport1.Report = (SectionReport) statementInvoices;
      if (this._data.Tables[4].Rows.Count != 0)
      {
        rptPaymentSummary_AdditionalItems summaryAdditionalItems = new rptPaymentSummary_AdditionalItems(this._data.Tables[4]);
        summaryAdditionalItems.DataSource = (object) this._data.Tables[4];
        this.subAdditionalItems.Report = (SectionReport) summaryAdditionalItems;
      }
      if (this._data.Tables[5].Rows.Count == 0)
        return;
      this._export = this._data.Tables[5];
    }
    finally
    {
      if (sqlDataAdapter.SelectCommand.Connection.State != ConnectionState.Closed)
        sqlDataAdapter.SelectCommand.Connection.Close();
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
  }

  private void Detail_Format(object sender, EventArgs e)
  {
  }

  private void ReportFooter_Format(object sender, EventArgs e)
  {
    Decimal d1 = 0M;
    if (this._data != null & this._data.Tables.Count >= 3 & this._data.Tables[2].Rows.Count != 0)
    {
      object objectValue1 = RuntimeHelpers.GetObjectValue(this._data.Tables[2].Compute("Sum(Gross)", ""));
      Decimal num;
      if (objectValue1 != null & objectValue1 != DBNull.Value)
      {
        TextBox txtGrossTotal = this.txtGrossTotal;
        num = Conversions.ToDecimal(objectValue1);
        string str = num.ToString("c");
        txtGrossTotal.Text = str;
      }
      object objectValue2 = RuntimeHelpers.GetObjectValue(this._data.Tables[2].Compute("Sum(Commission)", ""));
      if (objectValue2 != null & objectValue2 != DBNull.Value)
      {
        TextBox txtCommTotal = this.txtCommTotal;
        num = Conversions.ToDecimal(objectValue2);
        string str = num.ToString("c");
        txtCommTotal.Text = str;
      }
      object objectValue3 = RuntimeHelpers.GetObjectValue(this._data.Tables[2].Compute("Sum(Paid)", ""));
      if (objectValue3 != null & objectValue3 != DBNull.Value)
      {
        TextBox txtPaidTotal = this.txtPaidTotal;
        num = Conversions.ToDecimal(objectValue3);
        string str = num.ToString("c");
        txtPaidTotal.Text = str;
      }
      object objectValue4 = RuntimeHelpers.GetObjectValue(this._data.Tables[2].Compute("Sum(netdue)", ""));
      if (objectValue4 != null & objectValue4 != DBNull.Value)
      {
        TextBox txtNetDueTotal = this.txtNetDueTotal;
        num = Conversions.ToDecimal(objectValue4);
        string str = num.ToString("c");
        txtNetDueTotal.Text = str;
      }
      object objectValue5 = RuntimeHelpers.GetObjectValue(this._data.Tables[2].Compute("Sum(ptd)", ""));
      if (objectValue5 != null & objectValue5 != DBNull.Value)
      {
        TextBox txtPaidtoDateTotal = this.txtPaidtoDateTotal;
        num = Conversions.ToDecimal(objectValue5);
        string str = num.ToString("c");
        txtPaidtoDateTotal.Text = str;
      }
      object objectValue6 = RuntimeHelpers.GetObjectValue(this._data.Tables[2].Compute("Sum(Paid)", ""));
      if (objectValue6 != null & objectValue6 != DBNull.Value)
        d1 = Decimal.Add(d1, Conversions.ToDecimal(objectValue6));
    }
    if (this._data != null & this._data.Tables.Count >= 5 & this._data.Tables[4].Rows.Count != 0)
    {
      object objectValue = RuntimeHelpers.GetObjectValue(this._data.Tables[4].Compute("Sum(Amount)", ""));
      if (objectValue != null & objectValue != DBNull.Value)
        d1 = Decimal.Add(d1, Conversions.ToDecimal(objectValue));
    }
    this.textCheckTotal.Text = d1.ToString("c");
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._export, SaveFileTo);
    Process.Start(SaveFileTo);
  }

  [field: AccessedThroughProperty("Label14")]
  private virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  private virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  private virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  private virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  private virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
