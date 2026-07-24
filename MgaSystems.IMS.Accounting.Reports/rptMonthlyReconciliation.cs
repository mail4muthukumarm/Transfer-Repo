// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptMonthlyReconciliation
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{680ADB02-BFBB-4b28-BE15-C31020D037E4}", "Monthly Reconciliation", "Monthly Reconciliation Report.", "General")]
public sealed class rptMonthlyReconciliation : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{680ADB02-BFBB-4b28-BE15-C31020D037E4}";
  private Guid _OfficeLocationGUID;
  private Guid _CompanyLocationGUID;
  private DateTime _DateFrom;
  private DateTime _DateTo;
  private Guid _ProducerGuid;
  private DataTable _dtResults;
  private DataTable _expDt;
  private const int _reportFontSize = 10;
  private const int _reportHeaderFontSize = 13;
  private Workbook _wkb;
  private Worksheet _wks;
  private int _rowIndex;
  private Label lblCompany;
  private Label Label1;
  private Label lblDate;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private Label Label12;
  private Label Label13;
  private Label Label14;
  private Label Label15;
  private Label Label16;
  private Label Label17;
  private Label Label18;
  private Label Label19;
  private Label Label20;
  private Label lblCompanyNetDue;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox TextBox15;
  private TextBox TextBox16;
  private TextBox TextBox17;
  private TextBox TextBox18;
  private TextBox TextBox19;
  private TextBox TextBox21;
  private TextBox TextBox22;
  private TextBox TextBox24;
  private TextBox TextBox26;
  private TextBox TextBox27;
  private Label Label11;
  private TextBox TextBox11;
  private TextBox TextBox12;
  private TextBox TextBox13;
  private TextBox TextBox14;
  private TextBox TextBox20;
  private TextBox TextBox23;
  private TextBox TextBox25;
  private TextBox TextBox28;

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  public rptMonthlyReconciliation()
  {
    this.ReportStart += new EventHandler(this.rptMonthlyReconciliation_ReportStart);
    this._dtResults = new DataTable();
    this._expDt = new DataTable();
    this._wkb = new Workbook();
    this._rowIndex = 0;
  }

  public rptMonthlyReconciliation(
    Guid OfficeLocationGUID,
    Guid CompanyLocationGUID,
    Guid ProducerGuid,
    DateTime DateFrom,
    DateTime DateTo)
  {
    this.ReportStart += new EventHandler(this.rptMonthlyReconciliation_ReportStart);
    this._dtResults = new DataTable();
    this._expDt = new DataTable();
    this._wkb = new Workbook();
    this._rowIndex = 0;
    this.InitializeComponent();
    this._DateFrom = DateFrom;
    this._DateTo = DateTo;
    this._ProducerGuid = ProducerGuid;
    this._OfficeLocationGUID = OfficeLocationGUID;
    this._CompanyLocationGUID = CompanyLocationGUID;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptMonthlyReconciliation));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox15 = new TextBox();
    this.TextBox16 = new TextBox();
    this.TextBox17 = new TextBox();
    this.TextBox18 = new TextBox();
    this.TextBox19 = new TextBox();
    this.TextBox21 = new TextBox();
    this.TextBox22 = new TextBox();
    this.TextBox24 = new TextBox();
    this.TextBox26 = new TextBox();
    this.TextBox27 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.lblCompany = new Label();
    this.Label1 = new Label();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.lblDate = new Label();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.Label19 = new Label();
    this.Label20 = new Label();
    this.lblCompanyNetDue = new Label();
    this.GroupFooter1 = new GroupFooter();
    this.Label11 = new Label();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.TextBox14 = new TextBox();
    this.TextBox20 = new TextBox();
    this.TextBox23 = new TextBox();
    this.TextBox25 = new TextBox();
    this.TextBox28 = new TextBox();
    this.lblProducer = new Label();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.TextBox17).BeginInit();
    ((ISupportInitialize) this.TextBox18).BeginInit();
    ((ISupportInitialize) this.TextBox19).BeginInit();
    ((ISupportInitialize) this.TextBox21).BeginInit();
    ((ISupportInitialize) this.TextBox22).BeginInit();
    ((ISupportInitialize) this.TextBox24).BeginInit();
    ((ISupportInitialize) this.TextBox26).BeginInit();
    ((ISupportInitialize) this.TextBox27).BeginInit();
    ((ISupportInitialize) this.lblCompany).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.lblDate).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.Label19).BeginInit();
    ((ISupportInitialize) this.Label20).BeginInit();
    ((ISupportInitialize) this.lblCompanyNetDue).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.TextBox20).BeginInit();
    ((ISupportInitialize) this.TextBox23).BeginInit();
    ((ISupportInitialize) this.TextBox25).BeginInit();
    ((ISupportInitialize) this.TextBox28).BeginInit();
    ((ISupportInitialize) this.lblProducer).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[19]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox15,
      (ARControl) this.TextBox16,
      (ARControl) this.TextBox17,
      (ARControl) this.TextBox18,
      (ARControl) this.TextBox19,
      (ARControl) this.TextBox21,
      (ARControl) this.TextBox22,
      (ARControl) this.TextBox24,
      (ARControl) this.TextBox26,
      (ARControl) this.TextBox27
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.125f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "TransactionDate";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 0.625f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "PolicyNumber";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 0.625f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.75f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "EndorsementNum";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 3.25f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 0.375f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "EffectiveDate";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 4.375f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 9f / 16f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "ExpirationDate";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 79f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 9f / 16f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "Premium";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 6.625f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 0.75f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "GrossComm";
    ((ARControl) this.TextBox7).Height = 0.125f;
    ((ARControl) this.TextBox7).Left = 8f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 0.75f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).DataField = "PayableFees";
    ((ARControl) this.TextBox8).Height = 0.125f;
    ((ARControl) this.TextBox8).Left = 10.25f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.TextBox8.Text = (string) null;
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 0.75f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).DataField = "Balance";
    ((ARControl) this.TextBox9).Height = 0.125f;
    ((ARControl) this.TextBox9).Left = 12.5f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 0.875f;
    ((ARControl) this.TextBox15).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox15).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox15).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox15).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox15).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox15).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox15).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox15).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox15).DataField = "Insured";
    ((ARControl) this.TextBox15).Height = 0.125f;
    ((ARControl) this.TextBox15).Left = 1.375f;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox15.Text = (string) null;
    ((ARControl) this.TextBox15).Top = 0.0f;
    ((ARControl) this.TextBox15).Width = 21f / 16f;
    ((ARControl) this.TextBox16).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox16).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox16).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox16).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).DataField = "InvoiceDate";
    ((ARControl) this.TextBox16).Height = 0.125f;
    ((ARControl) this.TextBox16).Left = 5.5f;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = resourceManager.GetString("TextBox16.OutputFormat");
    this.TextBox16.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox16.Text = (string) null;
    ((ARControl) this.TextBox16).Top = 0.0f;
    ((ARControl) this.TextBox16).Width = 9f / 16f;
    ((ARControl) this.TextBox17).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).DataField = "TransactionDate";
    ((ARControl) this.TextBox17).Height = 0.125f;
    ((ARControl) this.TextBox17).Left = 97f / 16f;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.OutputFormat = resourceManager.GetString("TextBox17.OutputFormat");
    this.TextBox17.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox17.Text = (string) null;
    ((ARControl) this.TextBox17).Top = 0.0f;
    ((ARControl) this.TextBox17).Width = 9f / 16f;
    ((ARControl) this.TextBox18).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox18).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox18).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox18).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox18).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox18).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox18).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox18).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox18).DataField = "TransactionType";
    ((ARControl) this.TextBox18).Height = 0.125f;
    ((ARControl) this.TextBox18).Left = 3.625f;
    ((ARControl) this.TextBox18).Name = "TextBox18";
    this.TextBox18.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox18.Text = (string) null;
    ((ARControl) this.TextBox18).Top = 0.0f;
    ((ARControl) this.TextBox18).Width = 0.75f;
    ((ARControl) this.TextBox19).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).DataField = "MGAComm";
    ((ARControl) this.TextBox19).Height = 0.125f;
    ((ARControl) this.TextBox19).Left = 9.5f;
    ((ARControl) this.TextBox19).Name = "TextBox19";
    this.TextBox19.OutputFormat = resourceManager.GetString("TextBox19.OutputFormat");
    this.TextBox19.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.TextBox19.Text = (string) null;
    ((ARControl) this.TextBox19).Top = 0.0f;
    ((ARControl) this.TextBox19).Width = 0.75f;
    ((ARControl) this.TextBox21).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).DataField = "CommPercent";
    ((ARControl) this.TextBox21).Height = 0.125f;
    ((ARControl) this.TextBox21).Left = 7.375f;
    ((ARControl) this.TextBox21).Name = "TextBox21";
    this.TextBox21.OutputFormat = resourceManager.GetString("TextBox21.OutputFormat");
    this.TextBox21.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.TextBox21.Text = (string) null;
    ((ARControl) this.TextBox21).Top = 0.0f;
    ((ARControl) this.TextBox21).Width = 0.625f;
    ((ARControl) this.TextBox22).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox22).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox22).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox22).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox22).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).DataField = "ProducerComm";
    ((ARControl) this.TextBox22).Height = 0.125f;
    ((ARControl) this.TextBox22).Left = 8.75f;
    ((ARControl) this.TextBox22).Name = "TextBox22";
    this.TextBox22.OutputFormat = resourceManager.GetString("TextBox22.OutputFormat");
    this.TextBox22.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.TextBox22.Text = (string) null;
    ((ARControl) this.TextBox22).Top = 0.0f;
    ((ARControl) this.TextBox22).Width = 0.75f;
    ((ARControl) this.TextBox24).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox24).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox24).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox24).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox24).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox24).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox24).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox24).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox24).DataField = "MGAFees";
    ((ARControl) this.TextBox24).Height = 0.125f;
    ((ARControl) this.TextBox24).Left = 11f;
    ((ARControl) this.TextBox24).Name = "TextBox24";
    this.TextBox24.OutputFormat = resourceManager.GetString("TextBox24.OutputFormat");
    this.TextBox24.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.TextBox24.Text = (string) null;
    ((ARControl) this.TextBox24).Top = 0.0f;
    ((ARControl) this.TextBox24).Width = 0.75f;
    ((ARControl) this.TextBox26).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox26).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox26).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox26).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox26).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox26).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox26).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox26).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox26).DataField = "OfficeInvoiceNum";
    ((ARControl) this.TextBox26).Height = 0.125f;
    ((ARControl) this.TextBox26).Left = 43f / 16f;
    ((ARControl) this.TextBox26).Name = "TextBox26";
    this.TextBox26.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox26.Text = (string) null;
    ((ARControl) this.TextBox26).Top = 0.0f;
    ((ARControl) this.TextBox26).Width = 9f / 16f;
    ((ARControl) this.TextBox27).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox27).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox27).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox27).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox27).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox27).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox27).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox27).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox27).DataField = "CompanyNetDue";
    ((ARControl) this.TextBox27).Height = 0.125f;
    ((ARControl) this.TextBox27).Left = 11.75f;
    ((ARControl) this.TextBox27).Name = "TextBox27";
    this.TextBox27.OutputFormat = resourceManager.GetString("TextBox27.OutputFormat");
    this.TextBox27.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.TextBox27.Text = (string) null;
    ((ARControl) this.TextBox27).Top = 0.0f;
    ((ARControl) this.TextBox27).Width = 0.75f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.lblCompany,
      (ARControl) this.Label1,
      (ARControl) this.lblProducer
    });
    this.ReportHeader.Height = 19f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
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
    this.lblCompany.Style = "text-align: center; font-size: 12pt; ";
    this.lblCompany.Text = "[Company]";
    ((ARControl) this.lblCompany).Top = 0.0f;
    ((ARControl) this.lblCompany).Width = 13.375f;
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "text-align: center; ";
    this.Label1.Text = "Monthly Reconciliation";
    ((ARControl) this.Label1).Top = 0.4166667f;
    ((ARControl) this.Label1).Width = 13.375f;
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.lblDate
    });
    this.PageHeader.Height = 0.1763889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.lblDate).Border.BottomColor = Color.Black;
    ((ARControl) this.lblDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.LeftColor = Color.Black;
    ((ARControl) this.lblDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.RightColor = Color.Black;
    ((ARControl) this.lblDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.TopColor = Color.Black;
    ((ARControl) this.lblDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Height = 3f / 16f;
    this.lblDate.HyperLink = (string) null;
    ((ARControl) this.lblDate).Left = 0.0f;
    ((ARControl) this.lblDate).Name = "lblDate";
    this.lblDate.Style = "text-align: center; ";
    this.lblDate.Text = "Month Ending";
    ((ARControl) this.lblDate).Top = 0.0f;
    ((ARControl) this.lblDate).Width = 13.375f;
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[19]
    {
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label15,
      (ARControl) this.Label16,
      (ARControl) this.Label17,
      (ARControl) this.Label18,
      (ARControl) this.Label19,
      (ARControl) this.Label20,
      (ARControl) this.lblCompanyNetDue
    });
    this.GroupHeader1.Height = 0.5506945f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupHeader1.RepeatStyle = (RepeatStyle) 1;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 0.375f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.0f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label2.Text = "Agency Acctg MO";
    ((ARControl) this.Label2).Top = 3f / 16f;
    ((ARControl) this.Label2).Width = 0.625f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 0.625f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label3.Text = "Policy #";
    ((ARControl) this.Label3).Top = 0.375f;
    ((ARControl) this.Label3).Width = 0.75f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 3.25f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label4.Text = "End #";
    ((ARControl) this.Label4).Top = 0.375f;
    ((ARControl) this.Label4).Width = 0.375f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 4.375f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label5.Text = "Effective";
    ((ARControl) this.Label5).Top = 0.375f;
    ((ARControl) this.Label5).Width = 9f / 16f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 79f / 16f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label6.Text = "Expiration";
    ((ARControl) this.Label6).Top = 0.375f;
    ((ARControl) this.Label6).Width = 9f / 16f;
    ((ARControl) this.Label7).Border.BottomColor = Color.Black;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftColor = Color.Black;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightColor = Color.Black;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopColor = Color.Black;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 6.625f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label7.Text = "Premium";
    ((ARControl) this.Label7).Top = 0.375f;
    ((ARControl) this.Label7).Width = 0.75f;
    ((ARControl) this.Label8).Border.BottomColor = Color.Black;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftColor = Color.Black;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightColor = Color.Black;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopColor = Color.Black;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 8f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label8.Text = "Gross Comm";
    ((ARControl) this.Label8).Top = 0.375f;
    ((ARControl) this.Label8).Width = 0.75f;
    ((ARControl) this.Label9).Border.BottomColor = Color.Black;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftColor = Color.Black;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightColor = Color.Black;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopColor = Color.Black;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 10.25f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label9.Text = "Payables Fees";
    ((ARControl) this.Label9).Top = 0.375f;
    ((ARControl) this.Label9).Width = 0.75f;
    ((ARControl) this.Label10).Border.BottomColor = Color.Black;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftColor = Color.Black;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightColor = Color.Black;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopColor = Color.Black;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 12.5f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label10.Text = "Net Due Carrier";
    ((ARControl) this.Label10).Top = 0.375f;
    ((ARControl) this.Label10).Width = 0.875f;
    ((ARControl) this.Label12).Border.BottomColor = Color.Black;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftColor = Color.Black;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightColor = Color.Black;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopColor = Color.Black;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 1.375f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label12.Text = "Insured";
    ((ARControl) this.Label12).Top = 0.375f;
    ((ARControl) this.Label12).Width = 21f / 16f;
    ((ARControl) this.Label13).Border.BottomColor = Color.Black;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftColor = Color.Black;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightColor = Color.Black;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopColor = Color.Black;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 5.5f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label13.Text = "Billing";
    ((ARControl) this.Label13).Top = 0.375f;
    ((ARControl) this.Label13).Width = 9f / 16f;
    ((ARControl) this.Label14).Border.BottomColor = Color.Black;
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.LeftColor = Color.Black;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightColor = Color.Black;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopColor = Color.Black;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Height = 3f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 97f / 16f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label14.Text = "Transaction";
    ((ARControl) this.Label14).Top = 0.375f;
    ((ARControl) this.Label14).Width = 9f / 16f;
    ((ARControl) this.Label15).Border.BottomColor = Color.Black;
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.LeftColor = Color.Black;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.RightColor = Color.Black;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.TopColor = Color.Black;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Height = 3f / 16f;
    this.Label15.HyperLink = (string) null;
    ((ARControl) this.Label15).Left = 3.625f;
    ((ARControl) this.Label15).Name = "Label15";
    this.Label15.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label15.Text = "Type";
    ((ARControl) this.Label15).Top = 0.375f;
    ((ARControl) this.Label15).Width = 0.75f;
    ((ARControl) this.Label16).Border.BottomColor = Color.Black;
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.LeftColor = Color.Black;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.RightColor = Color.Black;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.TopColor = Color.Black;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Height = 3f / 16f;
    this.Label16.HyperLink = (string) null;
    ((ARControl) this.Label16).Left = 9.5f;
    ((ARControl) this.Label16).Name = "Label16";
    this.Label16.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label16.Text = "Earned Comm";
    ((ARControl) this.Label16).Top = 0.375f;
    ((ARControl) this.Label16).Width = 0.75f;
    ((ARControl) this.Label17).Border.BottomColor = Color.Black;
    ((ARControl) this.Label17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.LeftColor = Color.Black;
    ((ARControl) this.Label17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.RightColor = Color.Black;
    ((ARControl) this.Label17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.TopColor = Color.Black;
    ((ARControl) this.Label17).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Height = 3f / 16f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 7.375f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label17.Text = "Comm %";
    ((ARControl) this.Label17).Top = 0.375f;
    ((ARControl) this.Label17).Width = 0.625f;
    ((ARControl) this.Label18).Border.BottomColor = Color.Black;
    ((ARControl) this.Label18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.LeftColor = Color.Black;
    ((ARControl) this.Label18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.RightColor = Color.Black;
    ((ARControl) this.Label18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.TopColor = Color.Black;
    ((ARControl) this.Label18).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Height = 0.25f;
    this.Label18.HyperLink = (string) null;
    ((ARControl) this.Label18).Left = 8.75f;
    ((ARControl) this.Label18).Name = "Label18";
    this.Label18.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label18.Text = "Producer Comm";
    ((ARControl) this.Label18).Top = 5f / 16f;
    ((ARControl) this.Label18).Width = 0.75f;
    ((ARControl) this.Label19).Border.BottomColor = Color.Black;
    ((ARControl) this.Label19).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.LeftColor = Color.Black;
    ((ARControl) this.Label19).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.RightColor = Color.Black;
    ((ARControl) this.Label19).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.TopColor = Color.Black;
    ((ARControl) this.Label19).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Height = 3f / 16f;
    this.Label19.HyperLink = (string) null;
    ((ARControl) this.Label19).Left = 11f;
    ((ARControl) this.Label19).Name = "Label19";
    this.Label19.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label19.Text = "Earned Fees";
    ((ARControl) this.Label19).Top = 0.375f;
    ((ARControl) this.Label19).Width = 0.75f;
    ((ARControl) this.Label20).Border.BottomColor = Color.Black;
    ((ARControl) this.Label20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label20).Border.LeftColor = Color.Black;
    ((ARControl) this.Label20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label20).Border.RightColor = Color.Black;
    ((ARControl) this.Label20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label20).Border.TopColor = Color.Black;
    ((ARControl) this.Label20).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label20).Height = 3f / 16f;
    this.Label20.HyperLink = (string) null;
    ((ARControl) this.Label20).Left = 43f / 16f;
    ((ARControl) this.Label20).Name = "Label20";
    this.Label20.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label20.Text = "Invoice #";
    ((ARControl) this.Label20).Top = 0.375f;
    ((ARControl) this.Label20).Width = 9f / 16f;
    ((ARControl) this.lblCompanyNetDue).Border.BottomColor = Color.Black;
    ((ARControl) this.lblCompanyNetDue).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCompanyNetDue).Border.LeftColor = Color.Black;
    ((ARControl) this.lblCompanyNetDue).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCompanyNetDue).Border.RightColor = Color.Black;
    ((ARControl) this.lblCompanyNetDue).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCompanyNetDue).Border.TopColor = Color.Black;
    ((ARControl) this.lblCompanyNetDue).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCompanyNetDue).Height = 9f / 16f;
    this.lblCompanyNetDue.HyperLink = (string) null;
    ((ARControl) this.lblCompanyNetDue).Left = 11.75f;
    ((ARControl) this.lblCompanyNetDue).Name = "lblCompanyNetDue";
    this.lblCompanyNetDue.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.lblCompanyNetDue.Text = "[Company] Net Due";
    ((ARControl) this.lblCompanyNetDue).Top = 0.0f;
    ((ARControl) this.lblCompanyNetDue).Width = 0.75f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.Label11,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13,
      (ARControl) this.TextBox14,
      (ARControl) this.TextBox20,
      (ARControl) this.TextBox23,
      (ARControl) this.TextBox25,
      (ARControl) this.TextBox28
    });
    this.GroupFooter1.Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.Label11).Border.BottomColor = Color.Black;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftColor = Color.Black;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightColor = Color.Black;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopColor = Color.Black;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Height = 0.125f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 0.0f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; ";
    this.Label11.Text = "Grand Totals";
    ((ARControl) this.Label11).Top = 0.0f;
    ((ARControl) this.Label11).Width = 1f;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "Premium";
    ((ARControl) this.TextBox11).Height = 0.125f;
    ((ARControl) this.TextBox11).Left = 6.625f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; ";
    this.TextBox11.SummaryGroup = "GroupHeader1";
    this.TextBox11.SummaryRunning = (SummaryRunning) 1;
    this.TextBox11.SummaryType = (SummaryType) 1;
    this.TextBox11.Text = " ";
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 0.75f;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "GrossComm";
    ((ARControl) this.TextBox12).Height = 0.125f;
    ((ARControl) this.TextBox12).Left = 8f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; ";
    this.TextBox12.SummaryGroup = "GroupHeader1";
    this.TextBox12.SummaryRunning = (SummaryRunning) 1;
    this.TextBox12.SummaryType = (SummaryType) 1;
    this.TextBox12.Text = " ";
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 0.75f;
    ((ARControl) this.TextBox13).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "PayableFees";
    ((ARControl) this.TextBox13).Height = 0.125f;
    ((ARControl) this.TextBox13).Left = 10.25f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = resourceManager.GetString("TextBox13.OutputFormat");
    this.TextBox13.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; ";
    this.TextBox13.SummaryGroup = "GroupHeader1";
    this.TextBox13.SummaryRunning = (SummaryRunning) 1;
    this.TextBox13.SummaryType = (SummaryType) 1;
    this.TextBox13.Text = " ";
    ((ARControl) this.TextBox13).Top = 0.0f;
    ((ARControl) this.TextBox13).Width = 0.75f;
    ((ARControl) this.TextBox14).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).DataField = "Balance";
    ((ARControl) this.TextBox14).Height = 0.125f;
    ((ARControl) this.TextBox14).Left = 12.5f;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.OutputFormat = resourceManager.GetString("TextBox14.OutputFormat");
    this.TextBox14.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; ";
    this.TextBox14.SummaryGroup = "GroupHeader1";
    this.TextBox14.SummaryRunning = (SummaryRunning) 1;
    this.TextBox14.SummaryType = (SummaryType) 1;
    this.TextBox14.Text = " ";
    ((ARControl) this.TextBox14).Top = 0.0f;
    ((ARControl) this.TextBox14).Width = 0.875f;
    ((ARControl) this.TextBox20).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox20).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).DataField = "MGAComm";
    ((ARControl) this.TextBox20).Height = 0.125f;
    ((ARControl) this.TextBox20).Left = 9.5f;
    ((ARControl) this.TextBox20).Name = "TextBox20";
    this.TextBox20.OutputFormat = resourceManager.GetString("TextBox20.OutputFormat");
    this.TextBox20.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; ";
    this.TextBox20.SummaryGroup = "GroupHeader1";
    this.TextBox20.SummaryRunning = (SummaryRunning) 2;
    this.TextBox20.SummaryType = (SummaryType) 1;
    this.TextBox20.Text = (string) null;
    ((ARControl) this.TextBox20).Top = 0.0f;
    ((ARControl) this.TextBox20).Width = 0.75f;
    ((ARControl) this.TextBox23).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox23).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox23).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox23).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox23).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).DataField = "ProducerComm";
    ((ARControl) this.TextBox23).Height = 0.125f;
    ((ARControl) this.TextBox23).Left = 8.75f;
    ((ARControl) this.TextBox23).Name = "TextBox23";
    this.TextBox23.OutputFormat = resourceManager.GetString("TextBox23.OutputFormat");
    this.TextBox23.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; ";
    this.TextBox23.SummaryGroup = "GroupHeader1";
    this.TextBox23.SummaryRunning = (SummaryRunning) 2;
    this.TextBox23.SummaryType = (SummaryType) 1;
    this.TextBox23.Text = (string) null;
    ((ARControl) this.TextBox23).Top = 0.0f;
    ((ARControl) this.TextBox23).Width = 0.75f;
    ((ARControl) this.TextBox25).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox25).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox25).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox25).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox25).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).DataField = "MGAFees";
    ((ARControl) this.TextBox25).Height = 0.125f;
    ((ARControl) this.TextBox25).Left = 11f;
    ((ARControl) this.TextBox25).Name = "TextBox25";
    this.TextBox25.OutputFormat = resourceManager.GetString("TextBox25.OutputFormat");
    this.TextBox25.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; ";
    this.TextBox25.SummaryGroup = "GroupHeader1";
    this.TextBox25.SummaryRunning = (SummaryRunning) 1;
    this.TextBox25.SummaryType = (SummaryType) 1;
    this.TextBox25.Text = " ";
    ((ARControl) this.TextBox25).Top = 0.0f;
    ((ARControl) this.TextBox25).Width = 0.75f;
    ((ARControl) this.TextBox28).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox28).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox28).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox28).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox28).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).DataField = "CompanyNetDue";
    ((ARControl) this.TextBox28).Height = 0.125f;
    ((ARControl) this.TextBox28).Left = 11.75f;
    ((ARControl) this.TextBox28).Name = "TextBox28";
    this.TextBox28.OutputFormat = resourceManager.GetString("TextBox28.OutputFormat");
    this.TextBox28.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; ";
    this.TextBox28.SummaryGroup = "GroupHeader1";
    this.TextBox28.SummaryRunning = (SummaryRunning) 1;
    this.TextBox28.SummaryType = (SummaryType) 1;
    this.TextBox28.Text = " ";
    ((ARControl) this.TextBox28).Top = 0.0f;
    ((ARControl) this.TextBox28).Width = 0.75f;
    ((ARControl) this.lblProducer).Border.BottomColor = Color.Black;
    ((ARControl) this.lblProducer).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblProducer).Border.LeftColor = Color.Black;
    ((ARControl) this.lblProducer).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblProducer).Border.RightColor = Color.Black;
    ((ARControl) this.lblProducer).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblProducer).Border.TopColor = Color.Black;
    ((ARControl) this.lblProducer).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblProducer).Height = 3f / 16f;
    this.lblProducer.HyperLink = (string) null;
    ((ARControl) this.lblProducer).Left = 0.0f;
    ((ARControl) this.lblProducer).Name = "lblProducer";
    this.lblProducer.Style = "text-align: center; ";
    this.lblProducer.Text = "";
    ((ARControl) this.lblProducer).Top = 0.25f;
    ((ARControl) this.lblProducer).Width = 13.375f;
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.5f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 14f;
    this.PageSettings.PaperKind = PaperKind.Legal;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 13.38542f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.TextBox17).EndInit();
    ((ISupportInitialize) this.TextBox18).EndInit();
    ((ISupportInitialize) this.TextBox19).EndInit();
    ((ISupportInitialize) this.TextBox21).EndInit();
    ((ISupportInitialize) this.TextBox22).EndInit();
    ((ISupportInitialize) this.TextBox24).EndInit();
    ((ISupportInitialize) this.TextBox26).EndInit();
    ((ISupportInitialize) this.TextBox27).EndInit();
    ((ISupportInitialize) this.lblCompany).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.lblDate).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.Label19).EndInit();
    ((ISupportInitialize) this.Label20).EndInit();
    ((ISupportInitialize) this.lblCompanyNetDue).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.TextBox20).EndInit();
    ((ISupportInitialize) this.TextBox23).EndInit();
    ((ISupportInitialize) this.TextBox25).EndInit();
    ((ISupportInitialize) this.TextBox28).EndInit();
    ((ISupportInitialize) this.lblProducer).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void rptMonthlyReconciliation_ReportStart(object sender, EventArgs e)
  {
    this.lblCompany.Text = Database.Instance.QueryText.PerformScalarQuery($"SELECT TOP 1 Location FROM tblClientOffices WHERE OfficeGUID = '{this._OfficeLocationGUID.ToString()}'").ToString();
    this.lblProducer.Text = this._ProducerGuid.Equals(Guid.Empty) ? "" : "Producer: " + Database.Instance.QueryText.PerformScalarQuery($"SELECT TOP 1 dbo.tblProducers.ProducerName FROM dbo.tblProducers WHERE dbo.tblProducers.ProducerGUID = '{this._ProducerGuid.ToString()}'").ToString();
    this.lblCompanyNetDue.Text = this.lblCompany.Text + " Net Due";
    this.lblDate.Text = DateTime.Compare(this._DateFrom, DateTime.MinValue) == 0 || DateTime.Compare(this._DateTo, DateTime.MinValue) != 0 ? (DateTime.Compare(this._DateTo, DateTime.MinValue) == 0 || DateTime.Compare(this._DateFrom, DateTime.MinValue) != 0 ? (DateTime.Compare(this._DateFrom, DateTime.MinValue) == 0 || DateTime.Compare(this._DateTo, DateTime.MinValue) == 0 ? "" : $"Transactions between {this._DateFrom.ToShortDateString()} and {this._DateTo.ToShortDateString()}") : "Transactions prior to " + this._DateTo.ToShortDateString()) : "Transactions after " + this._DateFrom.ToShortDateString();
    ArrayList arrayList = new ArrayList();
    if (!this._CompanyLocationGUID.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@CompanyLocationGuid",
        (object) this._CompanyLocationGUID
      });
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@OfficeLocationGuid",
      (object) this._OfficeLocationGUID
    });
    if (DateTime.Compare(this._DateFrom, DateTime.MinValue) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@DateFrom",
        (object) this._DateFrom
      });
    if (DateTime.Compare(this._DateTo, DateTime.MinValue) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@DateTo",
        (object) this._DateTo
      });
    if (!(this._ProducerGuid == Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@ProducerGuid",
        (object) this._ProducerGuid
      });
    this._dtResults = Database.Instance.QuerySP.PerformTableQuery("[spFin_rptMonthlyReconciliation]", arrayList.ToArray());
    this._dtResults.Columns.Add("PremiumDue", typeof (Decimal));
    this._dtResults.Columns.Add("CommPercent", typeof (Decimal));
    this._dtResults.Columns.Add("ProducerComm", typeof (Decimal));
    this._dtResults.Columns.Add("CompanyNetDue", typeof (Decimal));
    this._dtResults.Columns.Add("AgencyAcctgMO", typeof (DateTime));
    try
    {
      foreach (DataRow row in this._dtResults.Rows)
      {
        row["PremiumDue"] = (object) Decimal.Add(Decimal.Subtract(Conversions.ToDecimal(row["Premium"]), Conversions.ToDecimal(row["GrossComm"])), Conversions.ToDecimal(row["PayableFees"]));
        row["CommPercent"] = Decimal.Compare(Conversions.ToDecimal(row["Premium"]), 0M) != 0 ? (object) Decimal.Divide(Conversions.ToDecimal(row["GrossComm"]), Conversions.ToDecimal(row["Premium"])) : (object) 0;
        row["ProducerComm"] = (object) Decimal.Subtract(Conversions.ToDecimal(row["GrossComm"]), Conversions.ToDecimal(row["MGAComm"]));
        row["CompanyNetDue"] = (object) Decimal.Add(Decimal.Subtract(Conversions.ToDecimal(row["Premium"]), Conversions.ToDecimal(row["ProducerComm"])), Conversions.ToDecimal(row["MGAFees"]));
        row["AgencyAcctgMO"] = RuntimeHelpers.GetObjectValue(row["TransactionDate"]);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.DataSource = (object) new DataView(this._dtResults, "", "PolicyNumber", DataViewRowState.CurrentRows);
    this.ShowPageNumbers();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[4]
      {
        (BaseReportControl) new AccountingOfficeLocations("Office", false),
        (BaseReportControl) new CompanyLocations("Company", true),
        (BaseReportControl) new Producers("Producer", true),
        (BaseReportControl) new DateRangePicker("Transaction", true)
      };
    }
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string saveFileTo)
  {
    DataView dataView = new DataView();
    this._expDt = new DataView(this._dtResults, "", "PolicyNumber", DataViewRowState.CurrentRows).ToTable(false, "AgencyAcctgMO", "PolicyNumber", "Insured", "OfficeInvoiceNum", "EndorsementNum", "TransactionType", "EffectiveDate", "ExpirationDate", "InvoiceDate", "TransactionDate", "Premium", "CommPercent", "GrossComm", "ProducerComm", "MGAComm", "PayableFees", "MGAFees", "CompanyNetDue", "Balance");
    this._wks = this._wkb.Worksheets[0];
    this._wks.Name = "Monthly Reconciliation";
    this._wks.Cells.StandardWidth = 14.0;
    this.PrintColumnHeaders();
    this.PrintDetailLines();
    this.PrintTotalLine();
    this.PrintReportHeader();
    this._wkb.Save(saveFileTo);
    Process.Start(saveFileTo);
  }

  private void PrintColumnHeaders()
  {
    int num1 = 0;
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) this._expDt.Columns)
      {
        Cell cell = this._wks.Cells[this._rowIndex, num1];
        cell.SetStyle(this.GetStyle(cell.GetStyle(), rptMonthlyReconciliation.FontStyle.ColumnHeader));
        switch (num1)
        {
          case 0:
            cell.PutValue("Agency Acctg MO");
            break;
          case 1:
            cell.PutValue("Policy #");
            break;
          case 2:
            cell.PutValue("Insured");
            break;
          case 3:
            cell.PutValue("Invoice #");
            break;
          case 4:
            cell.PutValue("End #");
            break;
          case 5:
            cell.PutValue("Type");
            break;
          case 6:
            cell.PutValue("Effective");
            break;
          case 7:
            cell.PutValue("Expiration");
            break;
          case 8:
            cell.PutValue("Billing");
            break;
          case 9:
            cell.PutValue("Transaction");
            break;
          case 10:
            cell.PutValue("Premium");
            break;
          case 11:
            cell.PutValue("Comm %");
            break;
          case 12:
            cell.PutValue("Gross Comm");
            break;
          case 13:
            cell.PutValue("Producer Comm");
            break;
          case 14:
            cell.PutValue("Earned Comm");
            break;
          case 15:
            cell.PutValue("Payable Fees");
            break;
          case 16 /*0x10*/:
            cell.PutValue("Earned Fees");
            break;
          case 17:
            cell.PutValue(this.lblCompanyNetDue.Text);
            break;
          case 18:
            cell.PutValue("Net Due Carrier");
            break;
        }
        checked { ++num1; }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num2 = checked (^(local = ref this._rowIndex) + 1);
    local = num2;
  }

  private void PrintDetailLines()
  {
    try
    {
      foreach (DataRow row in this._expDt.Rows)
      {
        int num1 = checked (this._expDt.Columns.Count - 1);
        int columnIndex = 0;
        while (columnIndex <= num1)
        {
          Cell cell = this._wks.Cells[this._rowIndex, columnIndex];
          switch (columnIndex)
          {
            case 0:
              cell.SetStyle(this.GetStyle(cell.GetStyle(), rptMonthlyReconciliation.FontStyle.DetailDateMMMYYValue));
              break;
            case 6:
            case 7:
            case 8:
            case 9:
              cell.SetStyle(this.GetStyle(cell.GetStyle(), rptMonthlyReconciliation.FontStyle.DetailDateValue));
              break;
            case 10:
            case 12:
            case 13:
            case 14:
            case 15:
            case 16 /*0x10*/:
            case 17:
            case 18:
              cell.SetStyle(this.GetStyle(cell.GetStyle(), rptMonthlyReconciliation.FontStyle.DetailMoneyValue));
              break;
            case 11:
              cell.SetStyle(this.GetStyle(cell.GetStyle(), rptMonthlyReconciliation.FontStyle.DetailPctValue));
              break;
            default:
              cell.SetStyle(this.GetStyle(cell.GetStyle(), rptMonthlyReconciliation.FontStyle.DetailPlain));
              break;
          }
          cell.PutValue(RuntimeHelpers.GetObjectValue(row[columnIndex]));
          checked { ++columnIndex; }
        }
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num2 = checked (^(local = ref this._rowIndex) + 1);
        local = num2;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void PrintTotalLine()
  {
    checked { this._rowIndex += 2; }
    int num1 = checked (this._expDt.Columns.Count - 1);
    int num2 = 0;
    while (num2 <= num1)
    {
      Cell cell = this._wks.Cells[this._rowIndex, num2];
      cell.SetStyle(this.GetStyle(cell.GetStyle(), rptMonthlyReconciliation.FontStyle.GrandTotal));
      switch (num2)
      {
        case 10:
          Decimal num3 = Conversions.ToDecimal(this._expDt.Compute("SUM(Premium)", ""));
          cell.PutValue(num3);
          break;
        case 12:
          Decimal num4 = Conversions.ToDecimal(this._expDt.Compute("SUM(GrossComm)", ""));
          cell.PutValue(num4);
          break;
        case 13:
          Decimal num5 = Conversions.ToDecimal(this._expDt.Compute("SUM(ProducerComm)", ""));
          cell.PutValue(num5);
          break;
        case 14:
          Decimal num6 = Conversions.ToDecimal(this._expDt.Compute("SUM(MGAComm)", ""));
          cell.PutValue(num6);
          break;
        case 15:
          Decimal num7 = Conversions.ToDecimal(this._expDt.Compute("SUM(PayableFees)", ""));
          cell.PutValue(num7);
          break;
        case 16 /*0x10*/:
          Decimal num8 = Conversions.ToDecimal(this._expDt.Compute("SUM(MGAFees)", ""));
          cell.PutValue(num8);
          break;
        case 17:
          Decimal num9 = Conversions.ToDecimal(this._expDt.Compute("SUM(CompanyNetDue)", ""));
          cell.PutValue(num9);
          break;
        case 18:
          Decimal num10 = Conversions.ToDecimal(this._expDt.Compute("SUM(Balance)", ""));
          cell.PutValue(num10);
          break;
      }
      checked { ++num2; }
    }
  }

  private void PrintReportHeader()
  {
    this._wks.Cells.InsertRow(0);
    this._wks.Cells.InsertRow(0);
    Cell cell = this._wks.Cells[0, 0];
    cell.SetStyle(this.GetStyle(cell.GetStyle(), rptMonthlyReconciliation.FontStyle.ReportHeader));
    cell.PutValue("Monthly Reconciliation");
  }

  private Style GetStyle(Style style, rptMonthlyReconciliation.FontStyle myFontStyle)
  {
    switch (myFontStyle)
    {
      case rptMonthlyReconciliation.FontStyle.ColumnHeader:
        style.Font.IsBold = true;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.HorizontalAlignment = (TextAlignmentType) 7;
        break;
      case rptMonthlyReconciliation.FontStyle.DetailPlain:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        break;
      case rptMonthlyReconciliation.FontStyle.DetailMoneyValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 7;
        break;
      case rptMonthlyReconciliation.FontStyle.DetailPctValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 10;
        break;
      case rptMonthlyReconciliation.FontStyle.DetailDateValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 14;
        break;
      case rptMonthlyReconciliation.FontStyle.DetailDateMMMYYValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 17;
        break;
      case rptMonthlyReconciliation.FontStyle.ReportHeader:
        style.Font.IsBold = true;
        style.Font.Size = 13;
        style.Font.Name = "Arial";
        style.HorizontalAlignment = (TextAlignmentType) 7;
        break;
      case rptMonthlyReconciliation.FontStyle.GrandTotal:
        style.Font.IsBold = true;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 7;
        break;
    }
    return style;
  }

  [field: AccessedThroughProperty("lblProducer")]
  private virtual Label lblProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private enum FontStyle
  {
    ColumnHeader,
    DetailPlain,
    DetailMoneyValue,
    DetailPctValue,
    DetailDateValue,
    DetailDateMMMYYValue,
    ReportHeader,
    GrandTotal,
  }
}
