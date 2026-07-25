// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptInvoiceListing
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
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
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{F4FBE761-629B-4d79-8226-1C8EA5F0420B}", "Invoice Listing", "List of invoices for a given date range.", "General")]
public class rptInvoiceListing : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{F4FBE761-629B-4d79-8226-1C8EA5F0420B}";
  private DateTime _DateFrom;
  private DateTime _DateTo;
  private DataTable _dtInvoices;
  private DataTable _dtCommissions;
  private Guid _officeGuid;
  private rptInvoiceListing_commissions _srCommissions;
  private bool _showCommissions;
  private bool _showVoids;
  private bool _showZeros;
  private string _SortOrder;
  private DataView _DataSourceDV;
  private Font _VoidFont;
  private Font _RegularFont;
  private Label lblDateBilled;
  private Label lblCompany;
  private Label lblProducer;
  private Label lblUnderwriter;
  private Label lblEffectiveDate;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label7;
  private Label Label8;
  private Label Label;
  private TextBox InvoiceNum;
  private TextBox txtDateBilled;
  private TextBox txtCompany;
  private TextBox txtProducer;
  private TextBox txtUnderwriter;
  private TextBox txtEffectiveDate;
  private TextBox TextBox1;
  private TextBox PolicyNumber;
  private TextBox Amount;
  private TextBox Underwriter1;
  private TextBox EffectiveDate1;
  private TextBox MGAComm;
  private TextBox Amount1;
  private TextBox TextBox;
  private CheckBox CheckBox;
  private SubReport srCommissions;
  private Line Line1;
  private Line Line2;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private Label Label6;
  private Label Label9;
  private Label Label10;
  private Label Label11;

  [field: AccessedThroughProperty("lblTitle")]
  private virtual Label lblTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDateSpan")]
  private virtual TextBox txtDateSpan { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblClientOfficeName")]
  private virtual Label lblClientOfficeName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportInfo1")]
  private virtual ReportInfo ReportInfo1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportInfo2")]
  private virtual ReportInfo ReportInfo2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptInvoiceListing()
  {
    this.ReportStart += new EventHandler(this.rptInvoiceListing_ReportStart);
  }

  public rptInvoiceListing(
    Guid OfficeGuid,
    DateTime DateFrom,
    DateTime DateTo,
    bool ShowCommissions,
    string SortOrder,
    bool ShowVoids,
    bool ShowZeros)
  {
    this.ReportStart += new EventHandler(this.rptInvoiceListing_ReportStart);
    this.InitializeComponent();
    this._DateFrom = DateFrom;
    this._DateTo = DateTo;
    this._officeGuid = OfficeGuid;
    this._showCommissions = ShowCommissions;
    this._SortOrder = SortOrder;
    this._showVoids = ShowVoids;
    this._showZeros = ShowZeros;
    this._VoidFont = new Font("Arial", 7f, FontStyle.Strikeout, GraphicsUnit.Point);
    this._RegularFont = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptInvoiceListing));
    this.Detail = new Detail();
    this.txtDateBilled = new TextBox();
    this.txtCompany = new TextBox();
    this.txtProducer = new TextBox();
    this.txtUnderwriter = new TextBox();
    this.txtEffectiveDate = new TextBox();
    this.TextBox1 = new TextBox();
    this.PolicyNumber = new TextBox();
    this.Amount = new TextBox();
    this.Underwriter1 = new TextBox();
    this.EffectiveDate1 = new TextBox();
    this.MGAComm = new TextBox();
    this.Amount1 = new TextBox();
    this.TextBox = new TextBox();
    this.CheckBox = new CheckBox();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.Label6 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.PageHeader = new PageHeader();
    this.lblDateBilled = new Label();
    this.lblCompany = new Label();
    this.lblProducer = new Label();
    this.lblUnderwriter = new Label();
    this.lblEffectiveDate = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label = new Label();
    this.lblTitle = new Label();
    this.txtDateSpan = new TextBox();
    this.lblClientOfficeName = new Label();
    this.PageFooter = new PageFooter();
    this.ReportInfo1 = new ReportInfo();
    this.ReportInfo2 = new ReportInfo();
    this.ghCommissionBreakdown = new GroupHeader();
    this.InvoiceNum = new TextBox();
    this.gfCommissionBreakdown = new GroupFooter();
    this.srCommissions = new SubReport();
    this.Line1 = new Line();
    this.Line2 = new Line();
    ((ISupportInitialize) this.txtDateBilled).BeginInit();
    ((ISupportInitialize) this.txtCompany).BeginInit();
    ((ISupportInitialize) this.txtProducer).BeginInit();
    ((ISupportInitialize) this.txtUnderwriter).BeginInit();
    ((ISupportInitialize) this.txtEffectiveDate).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.PolicyNumber).BeginInit();
    ((ISupportInitialize) this.Amount).BeginInit();
    ((ISupportInitialize) this.Underwriter1).BeginInit();
    ((ISupportInitialize) this.EffectiveDate1).BeginInit();
    ((ISupportInitialize) this.MGAComm).BeginInit();
    ((ISupportInitialize) this.Amount1).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.CheckBox).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.lblDateBilled).BeginInit();
    ((ISupportInitialize) this.lblCompany).BeginInit();
    ((ISupportInitialize) this.lblProducer).BeginInit();
    ((ISupportInitialize) this.lblUnderwriter).BeginInit();
    ((ISupportInitialize) this.lblEffectiveDate).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.txtDateSpan).BeginInit();
    ((ISupportInitialize) this.lblClientOfficeName).BeginInit();
    ((ISupportInitialize) this.ReportInfo1).BeginInit();
    ((ISupportInitialize) this.ReportInfo2).BeginInit();
    ((ISupportInitialize) this.InvoiceNum).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[14]
    {
      (ARControl) this.txtDateBilled,
      (ARControl) this.txtCompany,
      (ARControl) this.txtProducer,
      (ARControl) this.txtUnderwriter,
      (ARControl) this.txtEffectiveDate,
      (ARControl) this.TextBox1,
      (ARControl) this.PolicyNumber,
      (ARControl) this.Amount,
      (ARControl) this.Underwriter1,
      (ARControl) this.EffectiveDate1,
      (ARControl) this.MGAComm,
      (ARControl) this.Amount1,
      (ARControl) this.TextBox,
      (ARControl) this.CheckBox
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.125f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.txtDateBilled).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDateBilled).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDateBilled).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDateBilled).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDateBilled).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDateBilled).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDateBilled).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDateBilled).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDateBilled).DataField = "InvoiceDate";
    ((ARControl) this.txtDateBilled).Height = 0.125f;
    ((ARControl) this.txtDateBilled).Left = 6.5f;
    ((ARControl) this.txtDateBilled).Name = "txtDateBilled";
    this.txtDateBilled.OutputFormat = resourceManager.GetString("txtDateBilled.OutputFormat");
    this.txtDateBilled.Style = "font-size: 7pt";
    this.txtDateBilled.Text = (string) null;
    ((ARControl) this.txtDateBilled).Top = 0.0f;
    ((ARControl) this.txtDateBilled).Width = 9f / 16f;
    ((ARControl) this.txtCompany).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCompany).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCompany).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCompany).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCompany).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCompany).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCompany).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtCompany).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCompany).DataField = "CompanyName";
    ((ARControl) this.txtCompany).Height = 0.125f;
    ((ARControl) this.txtCompany).Left = 1.625f;
    ((ARControl) this.txtCompany).Name = "txtCompany";
    this.txtCompany.Style = "font-size: 7pt";
    this.txtCompany.Text = " ";
    ((ARControl) this.txtCompany).Top = 0.0f;
    ((ARControl) this.txtCompany).Width = 1.125f;
    ((ARControl) this.txtProducer).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtProducer).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProducer).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtProducer).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProducer).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtProducer).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProducer).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtProducer).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProducer).DataField = "ProducerName";
    ((ARControl) this.txtProducer).Height = 0.125f;
    ((ARControl) this.txtProducer).Left = 2.75f;
    ((ARControl) this.txtProducer).Name = "txtProducer";
    this.txtProducer.Style = "font-size: 7pt";
    this.txtProducer.Text = " ";
    ((ARControl) this.txtProducer).Top = 0.0f;
    ((ARControl) this.txtProducer).Width = 1f;
    ((ARControl) this.txtUnderwriter).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtUnderwriter).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUnderwriter).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtUnderwriter).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUnderwriter).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtUnderwriter).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUnderwriter).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtUnderwriter).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUnderwriter).DataField = "Underwriter";
    ((ARControl) this.txtUnderwriter).Height = 0.125f;
    ((ARControl) this.txtUnderwriter).Left = 71f / 16f;
    ((ARControl) this.txtUnderwriter).Name = "txtUnderwriter";
    this.txtUnderwriter.Style = "font-size: 7pt";
    this.txtUnderwriter.Text = " ";
    ((ARControl) this.txtUnderwriter).Top = 0.0f;
    ((ARControl) this.txtUnderwriter).Width = 1f;
    ((ARControl) this.txtEffectiveDate).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtEffectiveDate).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffectiveDate).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtEffectiveDate).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffectiveDate).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtEffectiveDate).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffectiveDate).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtEffectiveDate).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffectiveDate).DataField = "EffectiveDate";
    ((ARControl) this.txtEffectiveDate).Height = 0.125f;
    ((ARControl) this.txtEffectiveDate).Left = 7.625f;
    ((ARControl) this.txtEffectiveDate).Name = "txtEffectiveDate";
    this.txtEffectiveDate.OutputFormat = resourceManager.GetString("txtEffectiveDate.OutputFormat");
    this.txtEffectiveDate.Style = "font-size: 7pt";
    this.txtEffectiveDate.Text = " ";
    ((ARControl) this.txtEffectiveDate).Top = 0.0f;
    ((ARControl) this.txtEffectiveDate).Width = 9f / 16f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "OfficeInvoiceNum";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 7pt";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 11f / 16f;
    ((ARControl) this.PolicyNumber).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.PolicyNumber).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.PolicyNumber).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.PolicyNumber).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.PolicyNumber).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.PolicyNumber).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.PolicyNumber).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.PolicyNumber).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.PolicyNumber).DataField = "PolicyNumber";
    ((ARControl) this.PolicyNumber).Height = 0.125f;
    ((ARControl) this.PolicyNumber).Left = 11f / 16f;
    ((ARControl) this.PolicyNumber).Name = "PolicyNumber";
    this.PolicyNumber.Style = "font-size: 7pt";
    this.PolicyNumber.Text = " ";
    ((ARControl) this.PolicyNumber).Top = 0.0f;
    ((ARControl) this.PolicyNumber).Width = 15f / 16f;
    ((ARControl) this.Amount).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Amount).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Amount).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Amount).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Amount).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Amount).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Amount).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Amount).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Amount).DataField = "Amount";
    ((ARControl) this.Amount).Height = 0.125f;
    ((ARControl) this.Amount).Left = 9.625f;
    ((ARControl) this.Amount).Name = "Amount";
    this.Amount.OutputFormat = resourceManager.GetString("Amount.OutputFormat");
    this.Amount.Style = "font-size: 7pt; text-align: right";
    this.Amount.Text = " ";
    ((ARControl) this.Amount).Top = 0.0f;
    ((ARControl) this.Amount).Width = 0.75f;
    ((ARControl) this.Underwriter1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Underwriter1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Underwriter1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Underwriter1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Underwriter1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Underwriter1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Underwriter1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Underwriter1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Underwriter1).DataField = "Insured";
    ((ARControl) this.Underwriter1).Height = 0.125f;
    ((ARControl) this.Underwriter1).Left = 87f / 16f;
    ((ARControl) this.Underwriter1).Name = "Underwriter1";
    this.Underwriter1.Style = "font-size: 7pt";
    this.Underwriter1.Text = " ";
    ((ARControl) this.Underwriter1).Top = 0.0f;
    ((ARControl) this.Underwriter1).Width = 17f / 16f;
    ((ARControl) this.EffectiveDate1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.EffectiveDate1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.EffectiveDate1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.EffectiveDate1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.EffectiveDate1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.EffectiveDate1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.EffectiveDate1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.EffectiveDate1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.EffectiveDate1).DataField = "DueDate";
    ((ARControl) this.EffectiveDate1).Height = 0.125f;
    ((ARControl) this.EffectiveDate1).Left = 113f / 16f;
    ((ARControl) this.EffectiveDate1).Name = "EffectiveDate1";
    this.EffectiveDate1.OutputFormat = resourceManager.GetString("EffectiveDate1.OutputFormat");
    this.EffectiveDate1.Style = "font-size: 7pt";
    this.EffectiveDate1.Text = " ";
    ((ARControl) this.EffectiveDate1).Top = 0.0f;
    ((ARControl) this.EffectiveDate1).Width = 9f / 16f;
    ((ARControl) this.MGAComm).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.MGAComm).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.MGAComm).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.MGAComm).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.MGAComm).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.MGAComm).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.MGAComm).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.MGAComm).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.MGAComm).DataField = "MGAAmt";
    ((ARControl) this.MGAComm).Height = 0.125f;
    ((ARControl) this.MGAComm).Left = 131f / 16f;
    ((ARControl) this.MGAComm).Name = "MGAComm";
    this.MGAComm.OutputFormat = resourceManager.GetString("MGAComm.OutputFormat");
    this.MGAComm.Style = "font-size: 7pt; text-align: right";
    this.MGAComm.Text = (string) null;
    ((ARControl) this.MGAComm).Top = 0.0f;
    ((ARControl) this.MGAComm).Width = 11f / 16f;
    ((ARControl) this.Amount1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Amount1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Amount1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Amount1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Amount1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Amount1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Amount1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Amount1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Amount1).DataField = "GrossPremium";
    ((ARControl) this.Amount1).Height = 0.125f;
    ((ARControl) this.Amount1).Left = 8.875f;
    ((ARControl) this.Amount1).Name = "Amount1";
    this.Amount1.OutputFormat = resourceManager.GetString("Amount1.OutputFormat");
    this.Amount1.Style = "font-size: 7pt; text-align: right";
    this.Amount1.Text = " ";
    ((ARControl) this.Amount1).Top = 0.0f;
    ((ARControl) this.Amount1).Width = 0.75f;
    ((ARControl) this.TextBox).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).DataField = "LineName";
    ((ARControl) this.TextBox).Height = 0.125f;
    ((ARControl) this.TextBox).Left = 3.75f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-size: 7pt";
    this.TextBox.Text = " ";
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 11f / 16f;
    ((ARControl) this.CheckBox).DataField = "Failed";
    ((ARControl) this.CheckBox).Height = 1f / 16f;
    ((ARControl) this.CheckBox).Left = 0.0f;
    ((ARControl) this.CheckBox).Name = "CheckBox";
    this.CheckBox.Style = "background-color: Gold; ddo-char-set: 0";
    this.CheckBox.Text = "";
    ((ARControl) this.CheckBox).Top = 0.0f;
    ((ARControl) this.CheckBox).Visible = false;
    ((ARControl) this.CheckBox).Width = 0.5f;
    this.ReportHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.Label6,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label11
    });
    this.ReportFooter.Height = 9f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 149f / 16f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.375f;
    ((ARControl) this.TextBox2).Width = 17f / 16f;
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 115f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.375f;
    ((ARControl) this.TextBox3).Width = 17f / 16f;
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 8.25f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.375f;
    ((ARControl) this.TextBox4).Width = 17f / 16f;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 0.0f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 11.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label6.Text = "Totals";
    ((ARControl) this.Label6).Top = 3f / 16f;
    ((ARControl) this.Label6).Width = 115f / 16f;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 115f / 16f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.Label9.Text = "MGA Amount";
    ((ARControl) this.Label9).Top = 3f / 16f;
    ((ARControl) this.Label9).Width = 17f / 16f;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 8.25f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.Label10.Text = "Gross Premium";
    ((ARControl) this.Label10).Top = 3f / 16f;
    ((ARControl) this.Label10).Width = 17f / 16f;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 149f / 16f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.Label11.Text = "Amount";
    ((ARControl) this.Label11).Top = 3f / 16f;
    ((ARControl) this.Label11).Width = 17f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[16 /*0x10*/]
    {
      (ARControl) this.lblDateBilled,
      (ARControl) this.lblCompany,
      (ARControl) this.lblProducer,
      (ARControl) this.lblUnderwriter,
      (ARControl) this.lblEffectiveDate,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label,
      (ARControl) this.lblTitle,
      (ARControl) this.txtDateSpan,
      (ARControl) this.lblClientOfficeName
    });
    this.PageHeader.Height = 0.9479167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.lblDateBilled).Height = 3f / 16f;
    this.lblDateBilled.HyperLink = (string) null;
    ((ARControl) this.lblDateBilled).Left = 6.5f;
    ((ARControl) this.lblDateBilled).Name = "lblDateBilled";
    this.lblDateBilled.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.lblDateBilled.Text = "Billed";
    ((ARControl) this.lblDateBilled).Top = 0.698f;
    ((ARControl) this.lblDateBilled).Width = 9f / 16f;
    ((ARControl) this.lblCompany).Height = 3f / 16f;
    this.lblCompany.HyperLink = (string) null;
    ((ARControl) this.lblCompany).Left = 1.625f;
    ((ARControl) this.lblCompany).Name = "lblCompany";
    this.lblCompany.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.lblCompany.Text = "Company";
    ((ARControl) this.lblCompany).Top = 0.698f;
    ((ARControl) this.lblCompany).Width = 1.125f;
    ((ARControl) this.lblProducer).Height = 3f / 16f;
    this.lblProducer.HyperLink = (string) null;
    ((ARControl) this.lblProducer).Left = 2.75f;
    ((ARControl) this.lblProducer).Name = "lblProducer";
    this.lblProducer.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.lblProducer.Text = "Producer";
    ((ARControl) this.lblProducer).Top = 0.698f;
    ((ARControl) this.lblProducer).Width = 1f;
    ((ARControl) this.lblUnderwriter).Height = 3f / 16f;
    this.lblUnderwriter.HyperLink = (string) null;
    ((ARControl) this.lblUnderwriter).Left = 4.438001f;
    ((ARControl) this.lblUnderwriter).Name = "lblUnderwriter";
    this.lblUnderwriter.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.lblUnderwriter.Text = "Underwriter";
    ((ARControl) this.lblUnderwriter).Top = 0.698f;
    ((ARControl) this.lblUnderwriter).Width = 1f;
    ((ARControl) this.lblEffectiveDate).Height = 3f / 16f;
    this.lblEffectiveDate.HyperLink = (string) null;
    ((ARControl) this.lblEffectiveDate).Left = 7.625f;
    ((ARControl) this.lblEffectiveDate).Name = "lblEffectiveDate";
    this.lblEffectiveDate.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.lblEffectiveDate.Text = "Effective";
    ((ARControl) this.lblEffectiveDate).Top = 0.698f;
    ((ARControl) this.lblEffectiveDate).Width = 9f / 16f;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 1f / 1000f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.Label1.Text = "Invoice #";
    ((ARControl) this.Label1).Top = 0.698f;
    ((ARControl) this.Label1).Width = 11f / 16f;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 83f * (float) Math.PI / 379f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.Label2.Text = "Policy #";
    ((ARControl) this.Label2).Top = 0.698f;
    ((ARControl) this.Label2).Width = 15f / 16f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 9.625f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.Label3.Text = "Amount";
    ((ARControl) this.Label3).Top = 0.698f;
    ((ARControl) this.Label3).Width = 0.75f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 5.438001f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.Label4.Text = "Insured";
    ((ARControl) this.Label4).Top = 0.698f;
    ((ARControl) this.Label4).Width = 17f / 16f;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 7.063001f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.Label5.Text = "Due Date";
    ((ARControl) this.Label5).Top = 0.698f;
    ((ARControl) this.Label5).Width = 9f / 16f;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 8.187f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.Label7.Text = "MGA Amount";
    ((ARControl) this.Label7).Top = 0.698f;
    ((ARControl) this.Label7).Width = 11f / 16f;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 8.875f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.Label8.Text = "Gross Prem.";
    ((ARControl) this.Label8).Top = 0.698f;
    ((ARControl) this.Label8).Width = 0.75f;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 3.75f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.Label.Text = "LOB";
    ((ARControl) this.Label).Top = 0.698f;
    ((ARControl) this.Label).Width = 11f / 16f;
    ((ARControl) this.lblTitle).Height = 0.219f;
    this.lblTitle.HyperLink = (string) null;
    ((ARControl) this.lblTitle).Left = 0.0f;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    this.lblTitle.Style = "font-size: 12pt; text-align: center";
    this.lblTitle.Text = "Invoice Listing";
    ((ARControl) this.lblTitle).Top = 0.198f;
    ((ARControl) this.lblTitle).Width = 10.375f;
    ((ARControl) this.txtDateSpan).Height = 0.188f;
    ((ARControl) this.txtDateSpan).Left = 0.0f;
    ((ARControl) this.txtDateSpan).Name = "txtDateSpan";
    this.txtDateSpan.Style = "text-align: center; ddo-char-set: 0";
    this.txtDateSpan.Text = "({0} - {1})";
    ((ARControl) this.txtDateSpan).Top = 0.417f;
    ((ARControl) this.txtDateSpan).Width = 10.375f;
    ((ARControl) this.lblClientOfficeName).Height = 0.198f;
    this.lblClientOfficeName.HyperLink = (string) null;
    ((ARControl) this.lblClientOfficeName).Left = 0.0f;
    ((ARControl) this.lblClientOfficeName).Name = "lblClientOfficeName";
    this.lblClientOfficeName.Style = "font-size: 12pt; font-weight: bold; text-align: center";
    this.lblClientOfficeName.Text = "";
    ((ARControl) this.lblClientOfficeName).Top = 0.0f;
    ((ARControl) this.lblClientOfficeName).Width = 10.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.ReportInfo1,
      (ARControl) this.ReportInfo2
    });
    this.PageFooter.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
    ((ARControl) this.ReportInfo1).Height = 0.2f;
    ((ARControl) this.ReportInfo1).Left = 1f / 1000f;
    ((ARControl) this.ReportInfo1).Name = "ReportInfo1";
    this.ReportInfo1.Style = "font-size: 7pt";
    ((ARControl) this.ReportInfo1).Top = 0.062f;
    ((ARControl) this.ReportInfo1).Width = 3f;
    this.ReportInfo2.FormatString = "{RunDateTime:}";
    ((ARControl) this.ReportInfo2).Height = 0.2f;
    ((ARControl) this.ReportInfo2).Left = 7.375f;
    ((ARControl) this.ReportInfo2).Name = "ReportInfo2";
    this.ReportInfo2.Style = "font-size: 7pt; text-align: right";
    ((ARControl) this.ReportInfo2).Top = 0.062f;
    ((ARControl) this.ReportInfo2).Width = 3f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCommissionBreakdown).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.InvoiceNum
    });
    this.ghCommissionBreakdown.DataField = "InvoiceNum";
    this.ghCommissionBreakdown.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCommissionBreakdown).Name = "ghCommissionBreakdown";
    ((ARControl) this.InvoiceNum).DataField = "InvoiceNum";
    ((ARControl) this.InvoiceNum).Height = 0.075f;
    ((ARControl) this.InvoiceNum).Left = 0.0f;
    ((ARControl) this.InvoiceNum).Name = "InvoiceNum";
    this.InvoiceNum.Style = "background-color: Yellow; ddo-char-set: 0";
    this.InvoiceNum.Text = (string) null;
    ((ARControl) this.InvoiceNum).Top = 0.0f;
    ((ARControl) this.InvoiceNum).Visible = false;
    ((ARControl) this.InvoiceNum).Width = 1f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCommissionBreakdown).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.srCommissions,
      (ARControl) this.Line1,
      (ARControl) this.Line2
    });
    this.gfCommissionBreakdown.Height = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCommissionBreakdown).Name = "gfCommissionBreakdown";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCommissionBreakdown).Visible = false;
    this.srCommissions.CloseBorder = false;
    ((ARControl) this.srCommissions).Height = 0.125f;
    ((ARControl) this.srCommissions).Left = 13f / 16f;
    ((ARControl) this.srCommissions).Name = "srCommissions";
    this.srCommissions.Report = (SectionReport) null;
    ((ARControl) this.srCommissions).Top = 1f / 16f;
    ((ARControl) this.srCommissions).Width = 153f / 16f;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 0.375f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 5f / 32f;
    ((ARControl) this.Line1).Width = 0.125f;
    this.Line1.X1 = 0.375f;
    this.Line1.X2 = 0.5f;
    this.Line1.Y1 = 5f / 32f;
    this.Line1.Y2 = 5f / 32f;
    ((ARControl) this.Line2).Height = 0.125f;
    ((ARControl) this.Line2).Left = 0.375f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 1f / 32f;
    ((ARControl) this.Line2).Width = 0.0f;
    this.Line2.X1 = 0.375f;
    this.Line2.X2 = 0.375f;
    this.Line2.Y1 = 1f / 32f;
    this.Line2.Y2 = 5f / 32f;
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCommissionBreakdown);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCommissionBreakdown);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtDateBilled).EndInit();
    ((ISupportInitialize) this.txtCompany).EndInit();
    ((ISupportInitialize) this.txtProducer).EndInit();
    ((ISupportInitialize) this.txtUnderwriter).EndInit();
    ((ISupportInitialize) this.txtEffectiveDate).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.PolicyNumber).EndInit();
    ((ISupportInitialize) this.Amount).EndInit();
    ((ISupportInitialize) this.Underwriter1).EndInit();
    ((ISupportInitialize) this.EffectiveDate1).EndInit();
    ((ISupportInitialize) this.MGAComm).EndInit();
    ((ISupportInitialize) this.Amount1).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.CheckBox).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.lblDateBilled).EndInit();
    ((ISupportInitialize) this.lblCompany).EndInit();
    ((ISupportInitialize) this.lblProducer).EndInit();
    ((ISupportInitialize) this.lblUnderwriter).EndInit();
    ((ISupportInitialize) this.lblEffectiveDate).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.txtDateSpan).EndInit();
    ((ISupportInitialize) this.lblClientOfficeName).EndInit();
    ((ISupportInitialize) this.ReportInfo1).EndInit();
    ((ISupportInitialize) this.ReportInfo2).EndInit();
    ((ISupportInitialize) this.InvoiceNum).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    if (this.CheckBox.Checked)
    {
      this.TextBox1.Font = this._VoidFont;
      this.TextBox1.ForeColor = Color.Red;
    }
    else
    {
      this.TextBox1.Font = this._RegularFont;
      this.TextBox1.ForeColor = Color.Black;
    }
    this.SetDetailControlsHeight();
  }

  private void gfCommissionBreakdown_Format(object sender, EventArgs e)
  {
    this._srCommissions = new rptInvoiceListing_commissions(new DataView(this._dtCommissions, $"InvoiceNum='{RuntimeHelpers.GetObjectValue(this.InvoiceNum.Value)}'", "Payee", DataViewRowState.CurrentRows));
    this.srCommissions.Report = (SectionReport) this._srCommissions;
  }

  private void rptInvoiceListing_ReportStart(object sender, EventArgs e)
  {
    this.HidePrintDateAndTime();
    this.txtDateSpan.Text = string.Format(this.txtDateSpan.Text, (object) this._DateFrom.ToShortDateString(), (object) this._DateTo.ToShortDateString());
    if (this._officeGuid.Equals(Guid.Empty))
      this.lblClientOfficeName.Text = "All Offices";
    else
      this.lblClientOfficeName.Text = Utility.IsNull<string>((object) DefaultDatabase.ExecuteScalar(CommandType.Text, "Select TOP 1 Location From tblClientOffices Where OfficeGuid=@OfficeGuid", new object[2]
      {
        (object) "@OfficeGuid",
        (object) this._officeGuid
      }).ToString(), string.Empty);
    SqlConnection sqlConnection = new SqlConnection(Database.Instance.ConnectionString);
    SqlCommand sqlCommand = new SqlCommand(nameof (rptInvoiceListing), sqlConnection);
    SqlDataReader sqlDataReader = (SqlDataReader) null;
    sqlCommand.CommandType = CommandType.StoredProcedure;
    if (!this._officeGuid.Equals(Guid.Empty))
      sqlCommand.Parameters.AddWithValue("@OfficeGuid", (object) this._officeGuid);
    sqlCommand.Parameters.AddWithValue("@DateFrom", (object) this._DateFrom);
    sqlCommand.Parameters.AddWithValue("@DateTo", (object) this._DateTo);
    sqlCommand.Parameters.AddWithValue("@ShowVoids", (object) this._showVoids);
    sqlCommand.Parameters.AddWithValue("@ShowZeros", (object) this._showZeros);
    sqlCommand.Parameters.AddWithValue("@GetCount", (object) 1);
    try
    {
      Database.OpenConnection(sqlConnection);
      this.SetProgressbarMaximum(Conversions.ToInteger(sqlCommand.ExecuteScalar()));
      sqlCommand.Parameters.RemoveAt("@GetCount");
      sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SequentialAccess);
      this.SetStatusText("Retrieving Invoices...");
      this._dtInvoices = new DataTable();
      this._dtInvoices.Columns.AddRange(new DataColumn[15]
      {
        new DataColumn("InvoiceDate", typeof (DateTime)),
        new DataColumn("ProducerName"),
        new DataColumn("Underwriter"),
        new DataColumn("EffectiveDate", typeof (DateTime)),
        new DataColumn("OfficeInvoiceNum"),
        new DataColumn("InvoiceNum"),
        new DataColumn("LineName"),
        new DataColumn("CompanyName"),
        new DataColumn("PolicyNumber"),
        new DataColumn("Failed", typeof (bool)),
        new DataColumn("Amount", typeof (Decimal)),
        new DataColumn("Insured"),
        new DataColumn("DueDate", typeof (DateTime)),
        new DataColumn("MGAAmt", typeof (Decimal)),
        new DataColumn("GrossPremium", typeof (Decimal))
      });
      while (sqlDataReader.Read())
      {
        this._dtInvoices.Rows.Add(sqlDataReader["InvoiceDate"], sqlDataReader["ProducerName"], sqlDataReader["Underwriter"], sqlDataReader["EffectiveDate"], sqlDataReader["OfficeInvoiceNum"], sqlDataReader["InvoiceNum"], sqlDataReader["LineName"], sqlDataReader["CompanyName"], sqlDataReader["PolicyNumber"], sqlDataReader["Failed"], sqlDataReader["Amount"], sqlDataReader["Insured"], sqlDataReader["DueDate"], sqlDataReader["MGAAmt"], sqlDataReader["GrossPremium"]);
        this.IncreaseProgressbar(1);
      }
      sqlDataReader.NextResult();
      if (this._showCommissions)
      {
        this.SetStatusText("Retrieving Commissions...");
        this._dtCommissions = new DataTable();
        this._dtCommissions.Columns.AddRange(new DataColumn[5]
        {
          new DataColumn("InvoiceNum"),
          new DataColumn("Payee"),
          new DataColumn("PaymentDesc"),
          new DataColumn("PayeeAmt"),
          new DataColumn("PayeePercentRate")
        });
        while (sqlDataReader.Read())
        {
          this._dtCommissions.Rows.Add(sqlDataReader["InvoiceNum"], sqlDataReader["Payee"], sqlDataReader["PaymentDesc"], sqlDataReader["PayeeAmt"], sqlDataReader["PayeePercentRate"]);
          this.IncreaseProgressbar(1);
        }
        ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCommissionBreakdown).Visible = true;
      }
      else
        ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCommissionBreakdown).Format -= new EventHandler(this.gfCommissionBreakdown_Format);
    }
    finally
    {
      if (sqlConnection != null)
      {
        sqlConnection.Close();
        sqlConnection.Dispose();
      }
      sqlDataReader?.Close();
    }
    if (this._dtInvoices.Rows.Count <= 0)
      return;
    this._DataSourceDV = new DataView(this._dtInvoices, string.Empty, this._SortOrder, DataViewRowState.CurrentRows);
    this.DataSource = (object) this._DataSourceDV;
  }

  private void ReportFooter_Format(object sender, EventArgs e)
  {
    if (this._dtInvoices.Rows.Count <= 0)
      return;
    this.TextBox2.Value = RuntimeHelpers.GetObjectValue(this._DataSourceDV.Table.Compute("SUM(Amount)", "Failed=0"));
    this.TextBox4.Value = RuntimeHelpers.GetObjectValue(this._DataSourceDV.Table.Compute("SUM(GrossPremium)", "Failed=0"));
    this.TextBox3.Value = RuntimeHelpers.GetObjectValue(this._DataSourceDV.Table.Compute("SUM(MGAAmt)", "Failed=0"));
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._DataSourceDV, SaveFileTo);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      BaseReportControl[] getReportControls = new BaseReportControl[6];
      getReportControls[0] = (BaseReportControl) new OfficeLocations("Office", true);
      DateTime now = DateAndTime.Now;
      DateTime date1 = now.Date;
      now = DateAndTime.Now;
      DateTime date2 = now.Date;
      getReportControls[1] = (BaseReportControl) new DateRangePicker("Date Range", date1, date2, false);
      getReportControls[2] = (BaseReportControl) new GenericComboBox("Show Commissions", 75, 75, typeof (bool), new object[4]
      {
        (object) "Yes",
        (object) true,
        (object) "No",
        (object) false
      });
      getReportControls[3] = (BaseReportControl) new OrderBy(new string[24]
      {
        "Invoice #",
        "OfficeInvoiceNum",
        "Policy #",
        "PolicyNumber",
        "Company",
        "CompanyName",
        "Producer",
        "ProducerName",
        "Underwriter",
        "Underwriter",
        "Insured",
        "Insured",
        "Billed",
        "InvoiceDate",
        "Due Date",
        "DueDate",
        "Effective Date",
        "EffectiveDate",
        "MGA Amount",
        "MGAAmt",
        "Gross Premium",
        "GrossPremium",
        "Amount",
        "Amount"
      });
      getReportControls[4] = (BaseReportControl) new GenericCheckBox("", "Show Voids");
      getReportControls[5] = (BaseReportControl) new GenericCheckBox("", "Show $0 Invoices");
      return getReportControls;
    }
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (this.CheckBox.Checked)
    {
      this.TextBox1.Font = this._VoidFont;
      this.TextBox1.ForeColor = Color.Red;
    }
    else
    {
      this.TextBox1.Font = this._RegularFont;
      this.TextBox1.ForeColor = Color.Black;
    }
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghCommissionBreakdown")]
  private virtual GroupHeader ghCommissionBreakdown { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).BeforePrint -= eventHandler1;
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).Format -= eventHandler2;
      }
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).BeforePrint += eventHandler1;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).Format += eventHandler2;
    }
  }

  private virtual GroupFooter gfCommissionBreakdown
  {
    get => this._gfCommissionBreakdown;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfCommissionBreakdown_Format);
      GroupFooter commissionBreakdown1 = this._gfCommissionBreakdown;
      if (commissionBreakdown1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) commissionBreakdown1).Format -= eventHandler;
      this._gfCommissionBreakdown = value;
      GroupFooter commissionBreakdown2 = this._gfCommissionBreakdown;
      if (commissionBreakdown2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) commissionBreakdown2).Format += eventHandler;
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
