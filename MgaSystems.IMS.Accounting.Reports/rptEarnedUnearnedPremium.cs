// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptEarnedUnearnedPremium
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
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
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{74A616D9-1189-49b8-9237-7D96EFB44405}", "Earned/Unearned Premium", "Shows unearned commission by line of business", "General")]
[SecureResource("{AF335BE3-2CF6-4f85-B19F-412D5341A454}", "Earned/Unearned Premium Report User Access", "Allows user to run report for any/all users.", "Reports")]
[SecureResource("{5576AAD8-2477-45d1-A0BD-422457488141}", "Earned/Unearned Premium Report Issuing Office Access", "Allows user to run report for any/all issuing offices.", "Reports")]
public sealed class rptEarnedUnearnedPremium : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{74A616D9-1189-49b8-9237-7D96EFB44405}";
  internal const string SecurityIDAllUsers = "{AF335BE3-2CF6-4f85-B19F-412D5341A454}";
  internal const string SecurityIDAllOffices = "{5576AAD8-2477-45d1-A0BD-422457488141}";
  private DateTime _asOfDate;
  private DateTime _fromDate;
  private DateTime _toDate;
  private int _dateRangeType;
  private string _dateRangeText;
  private Guid _underwriterGuid;
  private Guid _producerGuid;
  private int _policyTypeID;
  private int _UnderWriterItemCount;
  private int _MonthlyItemCount;
  private int _TotalItemCount;
  private Guid _inhouseProducerGuid;
  private Guid _companyGuid;
  private Guid _companyLocationGuid;
  private Guid _lineGuid;
  private bool _showAllOffices;
  private int _issuingOfficeID;
  private Guid _ProducerLocationGuid;
  private DataTable _dt;
  private DataSet ds;
  private DataTable _dtToSave;
  private Label Label;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private TextBox TextBox8;
  private TextBox TextBox1;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private Label Label13;
  private Label Label14;
  private Label Label16;
  private TextBox TextBox16;
  private TextBox TextBox19;
  private TextBox TextBox20;
  private TextBox TextBox21;
  private TextBox TextBox22;
  private TextBox TextBox23;
  private TextBox TextBox24;
  private Label Label11;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;

  public rptEarnedUnearnedPremium()
  {
    this.ReportStart += new EventHandler(this.rptEarnedUnearnedPremium_ReportStart);
    this._UnderWriterItemCount = 0;
    this._MonthlyItemCount = 0;
    this._TotalItemCount = 0;
    this.ds = new DataSet();
    this.InitializeComponent();
  }

  public rptEarnedUnearnedPremium(
    DateTime asOfDate,
    DateTime fromDate,
    DateTime toDate,
    int dateRangeType,
    Guid underwriterGuid,
    Guid inhouseProducerGuid,
    Guid producerGuid,
    int PolicyTypeID,
    Guid companyGuid,
    Guid companyLocationGuid,
    Guid LineGuid,
    int IssuingOfficeID,
    bool ShowAllOffices,
    Guid ProducerLocationGuid)
  {
    this.ReportStart += new EventHandler(this.rptEarnedUnearnedPremium_ReportStart);
    this._UnderWriterItemCount = 0;
    this._MonthlyItemCount = 0;
    this._TotalItemCount = 0;
    this.ds = new DataSet();
    this.InitializeComponent();
    this._asOfDate = asOfDate;
    this._fromDate = fromDate;
    this._toDate = toDate;
    switch (dateRangeType)
    {
      case 0:
        this._dateRangeText = "Billing";
        break;
      case 1:
        this._dateRangeText = "Effective";
        break;
      default:
        this._dateRangeText = "";
        break;
    }
    this._dateRangeType = dateRangeType;
    this._underwriterGuid = underwriterGuid;
    this._producerGuid = producerGuid;
    this._policyTypeID = PolicyTypeID;
    this._inhouseProducerGuid = inhouseProducerGuid;
    this._companyGuid = companyGuid;
    this._companyLocationGuid = companyLocationGuid;
    this._lineGuid = LineGuid;
    this._issuingOfficeID = IssuingOfficeID;
    this._showAllOffices = ShowAllOffices;
    this._ProducerLocationGuid = ProducerLocationGuid;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptEarnedUnearnedPremium));
    this.Detail = new Detail();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.PageHeader = new PageHeader();
    this.Label = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.TextBox8 = new TextBox();
    this.TextBox1 = new TextBox();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label16 = new Label();
    this.TextBox16 = new TextBox();
    this.TextBox19 = new TextBox();
    this.TextBox20 = new TextBox();
    this.TextBox21 = new TextBox();
    this.TextBox22 = new TextBox();
    this.TextBox23 = new TextBox();
    this.TextBox24 = new TextBox();
    this.Label11 = new Label();
    this.PageFooter = new PageFooter();
    this.ghYear = new GroupHeader();
    this.TextBox2 = new TextBox();
    this.gfYear = new GroupFooter();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.TextBox14 = new TextBox();
    this.Label17 = new Label();
    this.ghMonth = new GroupHeader();
    this.TextBox3 = new TextBox();
    this.TextBox = new TextBox();
    this.gfMonth = new GroupFooter();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.Label15 = new Label();
    this.ReportHeader1 = new ReportHeader();
    this.ReportFooter1 = new ReportFooter();
    this.TextBox15 = new TextBox();
    this.TextBox17 = new TextBox();
    this.TextBox18 = new TextBox();
    this.Label18 = new Label();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.TextBox19).BeginInit();
    ((ISupportInitialize) this.TextBox20).BeginInit();
    ((ISupportInitialize) this.TextBox21).BeginInit();
    ((ISupportInitialize) this.TextBox22).BeginInit();
    ((ISupportInitialize) this.TextBox23).BeginInit();
    ((ISupportInitialize) this.TextBox24).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.TextBox17).BeginInit();
    ((ISupportInitialize) this.TextBox18).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1451389f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "LineName";
    ((ARControl) this.TextBox4).Height = 0.15f;
    ((ARControl) this.TextBox4).Left = 3.375f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "ddo-char-set: 0; ";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 2.188f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "Written";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 89f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "ddo-char-set: 0; text-align: right; ";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 23f / 16f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "Earned";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 7f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "ddo-char-set: 0; text-align: right; ";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 23f / 16f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "Unearned";
    ((ARControl) this.TextBox7).Height = 0.125f;
    ((ARControl) this.TextBox7).Left = 135f / 16f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "ddo-char-set: 0; text-align: right; ";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 23f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[24]
    {
      (ARControl) this.Label,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox1,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label16,
      (ARControl) this.TextBox16,
      (ARControl) this.TextBox19,
      (ARControl) this.TextBox20,
      (ARControl) this.TextBox21,
      (ARControl) this.TextBox22,
      (ARControl) this.TextBox23,
      (ARControl) this.TextBox24,
      (ARControl) this.Label11
    });
    this.PageHeader.Height = 1.697222f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label).Border.BottomColor = Color.Black;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftColor = Color.Black;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightColor = Color.Black;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopColor = Color.Black;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Height = 0.25f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.0f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "ddo-char-set: 0; text-align: center; font-size: 14.25pt; ";
    this.Label.Text = "Unearned Premium";
    ((ARControl) this.Label).Top = 0.0f;
    ((ARControl) this.Label).Width = 10.375f;
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 27f / 16f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.Label1.Text = "Year";
    ((ARControl) this.Label1).Top = 1.5f;
    ((ARControl) this.Label1).Width = 11f / 16f;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 2.375f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.Label2.Text = "Month";
    ((ARControl) this.Label2).Top = 1.5f;
    ((ARControl) this.Label2).Width = 1f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 3.375f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.Label3.Text = "Line";
    ((ARControl) this.Label3).Top = 1.5f;
    ((ARControl) this.Label3).Width = 35f / 16f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 89f / 16f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; ";
    this.Label4.Text = "Written";
    ((ARControl) this.Label4).Top = 1.5f;
    ((ARControl) this.Label4).Width = 23f / 16f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 7f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; ";
    this.Label5.Text = "Earned";
    ((ARControl) this.Label5).Top = 1.5f;
    ((ARControl) this.Label5).Width = 23f / 16f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 135f / 16f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; ";
    this.Label6.Text = "Unearned";
    ((ARControl) this.Label6).Top = 1.5f;
    ((ARControl) this.Label6).Width = 23f / 16f;
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
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "ddo-char-set: 0; text-align: center; font-size: 12pt; ";
    this.TextBox8.Text = (string) null;
    ((ARControl) this.TextBox8).Top = 0.5f;
    ((ARControl) this.TextBox8).Width = 10.375f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Height = 0.25f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Style = "ddo-char-set: 0; text-align: center; font-size: 12pt; ";
    this.TextBox1.Text = "As of:";
    ((ARControl) this.TextBox1).Top = 0.25f;
    ((ARControl) this.TextBox1).Width = 10.375f;
    ((ARControl) this.Label7).Border.BottomColor = Color.Black;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.LeftColor = Color.Black;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightColor = Color.Black;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopColor = Color.Black;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 0.0f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label7.Text = "Producer";
    ((ARControl) this.Label7).Top = 15f / 16f;
    ((ARControl) this.Label7).Width = 1f;
    ((ARControl) this.Label8).Border.BottomColor = Color.Black;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Border.LeftColor = Color.Black;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightColor = Color.Black;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopColor = Color.Black;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 39f / 16f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label8.Text = "Inhouse Producer";
    ((ARControl) this.Label8).Top = 15f / 16f;
    ((ARControl) this.Label8).Width = 1.75f;
    ((ARControl) this.Label9).Border.BottomColor = Color.Black;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Border.LeftColor = Color.Black;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightColor = Color.Black;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopColor = Color.Black;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 67f / 16f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label9.Text = "Underwriter";
    ((ARControl) this.Label9).Top = 15f / 16f;
    ((ARControl) this.Label9).Width = 23f / 16f;
    ((ARControl) this.Label10).Border.BottomColor = Color.Black;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Border.LeftColor = Color.Black;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightColor = Color.Black;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopColor = Color.Black;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 1f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label10.Text = "Producer Location";
    ((ARControl) this.Label10).Top = 15f / 16f;
    ((ARControl) this.Label10).Width = 23f / 16f;
    ((ARControl) this.Label13).Border.BottomColor = Color.Black;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Border.LeftColor = Color.Black;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightColor = Color.Black;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopColor = Color.Black;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 5.625f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label13.Text = "Company";
    ((ARControl) this.Label13).Top = 15f / 16f;
    ((ARControl) this.Label13).Width = 1.625f;
    ((ARControl) this.Label14).Border.BottomColor = Color.Black;
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Border.LeftColor = Color.Black;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightColor = Color.Black;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopColor = Color.Black;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Height = 3f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 143f / 16f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label14.Text = "Issuing Office";
    ((ARControl) this.Label14).Top = 15f / 16f;
    ((ARControl) this.Label14).Width = 23f / 16f;
    ((ARControl) this.Label16).Border.BottomColor = Color.Black;
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label16).Border.LeftColor = Color.Black;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.RightColor = Color.Black;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.TopColor = Color.Black;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Height = 3f / 16f;
    this.Label16.HyperLink = (string) null;
    ((ARControl) this.Label16).Left = 7.25f;
    ((ARControl) this.Label16).Name = "Label16";
    this.Label16.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label16.Text = "Company Location";
    ((ARControl) this.Label16).Top = 15f / 16f;
    ((ARControl) this.Label16).Width = 27f / 16f;
    ((ARControl) this.TextBox16).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox16).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).Height = 3f / 16f;
    ((ARControl) this.TextBox16).Left = 39f / 16f;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox16.Text = (string) null;
    ((ARControl) this.TextBox16).Top = 1.125f;
    ((ARControl) this.TextBox16).Width = 1.75f;
    ((ARControl) this.TextBox19).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox19).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox19).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox19).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox19).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Height = 3f / 16f;
    ((ARControl) this.TextBox19).Left = 0.0f;
    ((ARControl) this.TextBox19).Name = "TextBox19";
    this.TextBox19.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox19.Text = (string) null;
    ((ARControl) this.TextBox19).Top = 1.125f;
    ((ARControl) this.TextBox19).Width = 1f;
    ((ARControl) this.TextBox20).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox20).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox20).Height = 3f / 16f;
    ((ARControl) this.TextBox20).Left = 1f;
    ((ARControl) this.TextBox20).Name = "TextBox20";
    this.TextBox20.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox20.Text = (string) null;
    ((ARControl) this.TextBox20).Top = 1.125f;
    ((ARControl) this.TextBox20).Width = 23f / 16f;
    ((ARControl) this.TextBox21).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox21).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox21).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox21).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox21).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Height = 3f / 16f;
    ((ARControl) this.TextBox21).Left = 67f / 16f;
    ((ARControl) this.TextBox21).Name = "TextBox21";
    this.TextBox21.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox21.Text = (string) null;
    ((ARControl) this.TextBox21).Top = 1.125f;
    ((ARControl) this.TextBox21).Width = 23f / 16f;
    ((ARControl) this.TextBox22).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox22).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox22).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox22).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox22).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).Height = 3f / 16f;
    ((ARControl) this.TextBox22).Left = 5.625f;
    ((ARControl) this.TextBox22).Name = "TextBox22";
    this.TextBox22.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox22.Text = (string) null;
    ((ARControl) this.TextBox22).Top = 1.125f;
    ((ARControl) this.TextBox22).Width = 1.625f;
    ((ARControl) this.TextBox23).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox23).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox23).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox23).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox23).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox23).Height = 3f / 16f;
    ((ARControl) this.TextBox23).Left = 7.25f;
    ((ARControl) this.TextBox23).Name = "TextBox23";
    this.TextBox23.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox23.Text = (string) null;
    ((ARControl) this.TextBox23).Top = 1.125f;
    ((ARControl) this.TextBox23).Width = 27f / 16f;
    ((ARControl) this.TextBox24).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox24).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox24).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox24).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox24).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox24).Height = 3f / 16f;
    ((ARControl) this.TextBox24).Left = 143f / 16f;
    ((ARControl) this.TextBox24).Name = "TextBox24";
    this.TextBox24.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox24.Text = (string) null;
    ((ARControl) this.TextBox24).Top = 1.125f;
    ((ARControl) this.TextBox24).Width = 23f / 16f;
    ((ARControl) this.Label11).Border.BottomColor = Color.Black;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.LeftColor = Color.Black;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightColor = Color.Black;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopColor = Color.Black;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 0.0f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "ddo-char-set: 0; ";
    this.Label11.Text = "";
    ((ARControl) this.Label11).Top = 1.5f;
    ((ARControl) this.Label11).Width = 27f / 16f;
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghYear).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.TextBox2
    });
    this.ghYear.DataField = "Effective_Year";
    this.ghYear.Height = 5f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghYear).Name = "ghYear";
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "Effective_Year";
    ((ARControl) this.TextBox2).Height = 0.15f;
    ((ARControl) this.TextBox2).Left = 27f / 16f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "ddo-char-set: 0; ";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.688f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfYear).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13,
      (ARControl) this.TextBox14,
      (ARControl) this.Label17
    });
    this.gfYear.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfYear).Name = "gfYear";
    ((ARControl) this.TextBox12).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "Written";
    ((ARControl) this.TextBox12).Height = 0.125f;
    ((ARControl) this.TextBox12).Left = 89f / 16f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "ddo-char-set: 0; text-align: right; ";
    this.TextBox12.SummaryGroup = "ghYear";
    this.TextBox12.SummaryRunning = (SummaryRunning) 1;
    this.TextBox12.SummaryType = (SummaryType) 3;
    this.TextBox12.Text = (string) null;
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 23f / 16f;
    ((ARControl) this.TextBox13).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "Earned";
    ((ARControl) this.TextBox13).Height = 0.125f;
    ((ARControl) this.TextBox13).Left = 7f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = resourceManager.GetString("TextBox13.OutputFormat");
    this.TextBox13.Style = "ddo-char-set: 0; text-align: right; ";
    this.TextBox13.SummaryGroup = "ghYear";
    this.TextBox13.SummaryRunning = (SummaryRunning) 1;
    this.TextBox13.SummaryType = (SummaryType) 3;
    this.TextBox13.Text = (string) null;
    ((ARControl) this.TextBox13).Top = 0.0f;
    ((ARControl) this.TextBox13).Width = 23f / 16f;
    ((ARControl) this.TextBox14).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).DataField = "Unearned";
    ((ARControl) this.TextBox14).Height = 0.125f;
    ((ARControl) this.TextBox14).Left = 135f / 16f;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.OutputFormat = resourceManager.GetString("TextBox14.OutputFormat");
    this.TextBox14.Style = "ddo-char-set: 0; text-align: right; ";
    this.TextBox14.SummaryGroup = "ghYear";
    this.TextBox14.SummaryRunning = (SummaryRunning) 1;
    this.TextBox14.SummaryType = (SummaryType) 3;
    this.TextBox14.Text = (string) null;
    ((ARControl) this.TextBox14).Top = 0.0f;
    ((ARControl) this.TextBox14).Width = 23f / 16f;
    ((ARControl) this.Label17).Border.BottomColor = Color.Black;
    ((ARControl) this.Label17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.LeftColor = Color.Black;
    ((ARControl) this.Label17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.RightColor = Color.Black;
    ((ARControl) this.Label17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.TopColor = Color.Black;
    ((ARControl) this.Label17).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Height = 0.1979167f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 4.375f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "text-align: right; font-weight: bold; ";
    this.Label17.Text = "Year Total";
    ((ARControl) this.Label17).Top = 0.0f;
    ((ARControl) this.Label17).Width = 1f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghMonth).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox
    });
    this.ghMonth.DataField = "Effective_Month";
    this.ghMonth.Height = 5f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghMonth).Name = "ghMonth";
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "MonthWord";
    ((ARControl) this.TextBox3).Height = 0.15f;
    ((ARControl) this.TextBox3).Left = 2.375f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "ddo-char-set: 0; ";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 1f;
    ((ARControl) this.TextBox).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "Effective_Month";
    ((ARControl) this.TextBox).Height = 1f / 16f;
    ((ARControl) this.TextBox).Left = 0.0f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "ddo-char-set: 0; background-color: Yellow; ";
    this.TextBox.Text = (string) null;
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Visible = false;
    ((ARControl) this.TextBox).Width = 0.75f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfMonth).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.Label15
    });
    this.gfMonth.Height = 0.1979167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfMonth).Name = "gfMonth";
    ((ARControl) this.TextBox9).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "Written";
    ((ARControl) this.TextBox9).Height = 0.125f;
    ((ARControl) this.TextBox9).Left = 89f / 16f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "ddo-char-set: 0; text-align: right; ";
    this.TextBox9.SummaryGroup = "ghMonth";
    this.TextBox9.SummaryRunning = (SummaryRunning) 1;
    this.TextBox9.SummaryType = (SummaryType) 3;
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 23f / 16f;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "Earned";
    ((ARControl) this.TextBox10).Height = 0.125f;
    ((ARControl) this.TextBox10).Left = 7f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = resourceManager.GetString("TextBox10.OutputFormat");
    this.TextBox10.Style = "ddo-char-set: 0; text-align: right; ";
    this.TextBox10.SummaryGroup = "ghMonth";
    this.TextBox10.SummaryRunning = (SummaryRunning) 1;
    this.TextBox10.SummaryType = (SummaryType) 3;
    this.TextBox10.Text = (string) null;
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 23f / 16f;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "Unearned";
    ((ARControl) this.TextBox11).Height = 0.125f;
    ((ARControl) this.TextBox11).Left = 135f / 16f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "ddo-char-set: 0; text-align: right; ";
    this.TextBox11.SummaryGroup = "ghMonth";
    this.TextBox11.SummaryRunning = (SummaryRunning) 1;
    this.TextBox11.SummaryType = (SummaryType) 3;
    this.TextBox11.Text = (string) null;
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 23f / 16f;
    ((ARControl) this.Label15).Border.BottomColor = Color.Black;
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.LeftColor = Color.Black;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.RightColor = Color.Black;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.TopColor = Color.Black;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Height = 0.1979167f;
    this.Label15.HyperLink = (string) null;
    ((ARControl) this.Label15).Left = 4.375f;
    ((ARControl) this.Label15).Name = "Label15";
    this.Label15.Style = "text-align: right; font-weight: bold; ";
    this.Label15.Text = "Month Total";
    ((ARControl) this.Label15).Top = 0.0f;
    ((ARControl) this.Label15).Width = 1f;
    this.ReportHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1).Name = "ReportHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.TextBox15,
      (ARControl) this.TextBox17,
      (ARControl) this.TextBox18,
      (ARControl) this.Label18
    });
    this.ReportFooter1.Height = 7f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1).Name = "ReportFooter1";
    ((ARControl) this.TextBox15).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).DataField = "Written";
    ((ARControl) this.TextBox15).Height = 0.125f;
    ((ARControl) this.TextBox15).Left = 89f / 16f;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.OutputFormat = resourceManager.GetString("TextBox15.OutputFormat");
    this.TextBox15.Style = "ddo-char-set: 0; text-align: right; ";
    this.TextBox15.SummaryRunning = (SummaryRunning) 2;
    this.TextBox15.SummaryType = (SummaryType) 1;
    this.TextBox15.Text = (string) null;
    ((ARControl) this.TextBox15).Top = 0.0f;
    ((ARControl) this.TextBox15).Width = 23f / 16f;
    ((ARControl) this.TextBox17).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox17).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).DataField = "Earned";
    ((ARControl) this.TextBox17).Height = 0.125f;
    ((ARControl) this.TextBox17).Left = 7f;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.OutputFormat = resourceManager.GetString("TextBox17.OutputFormat");
    this.TextBox17.Style = "ddo-char-set: 0; text-align: right; ";
    this.TextBox17.SummaryRunning = (SummaryRunning) 2;
    this.TextBox17.SummaryType = (SummaryType) 1;
    this.TextBox17.Text = (string) null;
    ((ARControl) this.TextBox17).Top = 0.0f;
    ((ARControl) this.TextBox17).Width = 23f / 16f;
    ((ARControl) this.TextBox18).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox18).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).DataField = "Unearned";
    ((ARControl) this.TextBox18).Height = 0.125f;
    ((ARControl) this.TextBox18).Left = 135f / 16f;
    ((ARControl) this.TextBox18).Name = "TextBox18";
    this.TextBox18.OutputFormat = resourceManager.GetString("TextBox18.OutputFormat");
    this.TextBox18.Style = "ddo-char-set: 0; text-align: right; ";
    this.TextBox18.SummaryRunning = (SummaryRunning) 2;
    this.TextBox18.SummaryType = (SummaryType) 1;
    this.TextBox18.Text = (string) null;
    ((ARControl) this.TextBox18).Top = 0.0f;
    ((ARControl) this.TextBox18).Width = 23f / 16f;
    ((ARControl) this.Label18).Border.BottomColor = Color.Black;
    ((ARControl) this.Label18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.LeftColor = Color.Black;
    ((ARControl) this.Label18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.RightColor = Color.Black;
    ((ARControl) this.Label18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.TopColor = Color.Black;
    ((ARControl) this.Label18).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Height = 0.1979167f;
    this.Label18.HyperLink = (string) null;
    ((ARControl) this.Label18).Left = 4.375f;
    ((ARControl) this.Label18).Name = "Label18";
    this.Label18.Style = "text-align: right; font-weight: bold; ";
    this.Label18.Text = "Grand Total";
    ((ARControl) this.Label18).Top = 0.0f;
    ((ARControl) this.Label18).Width = 1f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghYear);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghMonth);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfMonth);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfYear);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.TextBox19).EndInit();
    ((ISupportInitialize) this.TextBox20).EndInit();
    ((ISupportInitialize) this.TextBox21).EndInit();
    ((ISupportInitialize) this.TextBox22).EndInit();
    ((ISupportInitialize) this.TextBox23).EndInit();
    ((ISupportInitialize) this.TextBox24).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.TextBox17).EndInit();
    ((ISupportInitialize) this.TextBox18).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void rptEarnedUnearnedPremium_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.HidePrintDateAndTime();
    SqlConnection sqlConnection = new SqlConnection(Database.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    selectCommand.CommandText = nameof (rptEarnedUnearnedPremium);
    selectCommand.CommandType = CommandType.StoredProcedure;
    selectCommand.CommandTimeout = 0;
    selectCommand.Connection = sqlConnection;
    selectCommand.Parameters.AddWithValue("@AsOfDate", (object) this._asOfDate);
    this.TextBox1.Value = (object) $"As Of: {this._asOfDate.ToShortDateString()}";
    if (DateTime.Compare(this._fromDate, DateTime.MinValue) != 0)
    {
      selectCommand.Parameters.AddWithValue("@FromDate", (object) this._fromDate);
      TextBox textBox8;
      string str = (textBox8 = this.TextBox8).Text + $" {this._dateRangeText} Date After {this._fromDate.Date.ToString("MM/dd/yyyy")}";
      textBox8.Text = str;
    }
    if (DateTime.Compare(this._toDate, DateTime.MinValue) != 0)
    {
      selectCommand.Parameters.AddWithValue("@toDate", (object) this._toDate);
      TextBox textBox8;
      string str = (textBox8 = this.TextBox8).Text + $" {this._dateRangeText} Date To {this._toDate.Date.ToString("MM/dd/yyyy")}";
      textBox8.Text = str;
    }
    if (this._dateRangeType != -1)
      selectCommand.Parameters.AddWithValue("@dateRangeType", (object) (this._dateRangeType != 0));
    if (!this._underwriterGuid.Equals(Guid.Empty))
      selectCommand.Parameters.AddWithValue("@underwriterGuid", (object) this._underwriterGuid);
    if (!this._inhouseProducerGuid.Equals(Guid.Empty))
      selectCommand.Parameters.AddWithValue("@inHouseProducerGuid", (object) this._inhouseProducerGuid);
    if (!this._producerGuid.Equals(Guid.Empty))
      selectCommand.Parameters.AddWithValue("@producerGuid", (object) this._producerGuid);
    if (this._policyTypeID != -1)
      selectCommand.Parameters.AddWithValue("@policyTypeID", (object) this._policyTypeID);
    if (!this._companyGuid.Equals(Guid.Empty))
      selectCommand.Parameters.AddWithValue("@companyGuid", (object) this._companyGuid);
    if (!this._companyLocationGuid.Equals(Guid.Empty))
      selectCommand.Parameters.AddWithValue("@companyLocationGuid", (object) this._companyLocationGuid);
    if (!this._lineGuid.Equals(Guid.Empty))
      selectCommand.Parameters.AddWithValue("@lineGuid", (object) this._lineGuid);
    selectCommand.Parameters.AddWithValue("@ShowAllOffices", (object) this._showAllOffices);
    if (this._issuingOfficeID != -1)
      selectCommand.Parameters.AddWithValue("@IssuingOfficeID", (object) this._issuingOfficeID);
    if (!this._ProducerLocationGuid.Equals(Guid.Empty))
      selectCommand.Parameters.AddWithValue("@ProducerLocationGuid", (object) this._ProducerLocationGuid);
    try
    {
      sqlDataAdapter.Fill(this.ds);
    }
    finally
    {
      sqlConnection.Dispose();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
    this._dt = this.ds.Tables[0];
    this._dt.Columns.Add("MonthWord", typeof (string));
    this._dt.Columns.Add("Unearned", typeof (Decimal));
    try
    {
      foreach (DataRow row in this._dt.Rows)
      {
        row["Unearned"] = (object) Decimal.Subtract((Decimal) row["Written"], (Decimal) row["Earned"]);
        row["MonthWord"] = (object) Conversions.ToDate($"{RuntimeHelpers.GetObjectValue(row["Effective_Month"])}/01/{RuntimeHelpers.GetObjectValue(row["Effective_Year"])}").ToString("MMMM");
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (this.ds.Tables[1].Rows.Count > 0)
    {
      this.TextBox21.Value = RuntimeHelpers.GetObjectValue(this.ds.Tables[1].Rows[0][0]);
      this.TextBox16.Value = RuntimeHelpers.GetObjectValue(this.ds.Tables[1].Rows[0][1]);
      this.TextBox19.Value = RuntimeHelpers.GetObjectValue(this.ds.Tables[1].Rows[0][2]);
      this.TextBox22.Value = RuntimeHelpers.GetObjectValue(this.ds.Tables[1].Rows[0][3]);
      this.TextBox23.Value = RuntimeHelpers.GetObjectValue(this.ds.Tables[1].Rows[0][4]);
      this.TextBox20.Value = RuntimeHelpers.GetObjectValue(this.ds.Tables[1].Rows[0][5]);
      this.TextBox24.Value = RuntimeHelpers.GetObjectValue(this.ds.Tables[1].Rows[0][6]);
    }
    this.DataSource = (object) this._dt;
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[12]
      {
        (BaseReportControl) new DatePicker("As Of Date", DateTime.Now, false),
        (BaseReportControl) new EffectiveOrBillingDateRange(),
        (BaseReportControl) (!SecurityManager.Instance.AssertPermission("{AF335BE3-2CF6-4f85-B19F-412D5341A454}") ? new Underwriters("Underwriter", CurrentUser.Instance.UserGUID) : new Underwriters("Underwriter", true)),
        (BaseReportControl) new Underwriters("Inhouse Producer", true),
        (BaseReportControl) new Producers("Producer", true),
        (BaseReportControl) new GenericComboBox("Policy Type", "(SELECT -1 AS PolicyTypeID, 'All Types' AS Description, -1 AS SORT) UNION (SELECT PolicyTypeID, Description, 0 AS SORT FROM lstPolicyTypes) ORDER BY SORT, Description", "PolicyTypeID", "Description", typeof (int)),
        (BaseReportControl) new Companies("Company", true, new Guid[0]),
        (BaseReportControl) new CompanyLocations("Company Location", true),
        (BaseReportControl) new CompanyLines("Line", true),
        (BaseReportControl) (!SecurityManager.Instance.AssertPermission("{5576AAD8-2477-45d1-A0BD-422457488141}") ? new OfficeLocations("Issuing Office", CurrentUser.Instance.UserGUID, true) : new OfficeLocations("Issuing Office", true, true)),
        (BaseReportControl) new GenericCheckBox("", "Show All Office Locations for this Company"),
        (BaseReportControl) new ProducerLocations("Producer Location", true)
      };
    }
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    this._dtToSave = new DataTable();
    this._dtToSave.Columns.Add("Year");
    this._dtToSave.Columns.Add("Month");
    this._dtToSave.Columns.Add("Line");
    this._dtToSave.Columns.Add("Written");
    this._dtToSave.Columns.Add("Earned");
    this._dtToSave.Columns.Add("Unearned");
    this._dtToSave.Columns["Written"].DataType = typeof (Decimal);
    this._dtToSave.Columns["Earned"].DataType = typeof (Decimal);
    this._dtToSave.Columns["Unearned"].DataType = typeof (Decimal);
    try
    {
      foreach (DataRow row in this._dt.Rows)
        this._dtToSave.Rows.Add(row[1], row[6], row[4], row[2], row[3], row[7]);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.ds.Tables[2].Clone();
    DataTable dataTable = this.ds.Tables[2].Copy();
    ExcelExport.ToExcel(new DataSet()
    {
      Tables = {
        this._dtToSave,
        dataTable
      }
    }, SaveFileTo);
    this._dtToSave.Dispose();
  }

  public override bool IsThreaded => true;

  [field: AccessedThroughProperty("TextBox9")]
  private virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox10")]
  private virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox12")]
  private virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox13")]
  private virtual TextBox TextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox14")]
  private virtual TextBox TextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  private virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader1")]
  internal virtual ReportHeader ReportHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter1")]
  internal virtual ReportFooter ReportFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox15")]
  private virtual TextBox TextBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox17")]
  private virtual TextBox TextBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox18")]
  private virtual TextBox TextBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghYear")]
  private virtual GroupHeader ghYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghMonth")]
  private virtual GroupHeader ghMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfMonth")]
  private virtual GroupFooter gfMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfYear")]
  private virtual GroupFooter gfYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
