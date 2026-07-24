// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptAgingDetail
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{40728184-44D2-4bd6-B59A-C0CBB730FDAF}", "Aging Detail Report", "Aging Detail by accounts payable or receivable.", "Accounting")]
public sealed class rptAgingDetail : MGAReport, IReport, ISupportReportDatabase
{
  public const string SecureReportGuid = "{40728184-44D2-4bd6-B59A-C0CBB730FDAF}";
  private string _CostCenterIDs;
  private DateTime _AsOf;
  private string _rpt_Type;
  private int _OfficeID;
  private string _PolicyNumber;
  private int _OfficeInvoiceNumber;
  private Guid _EntityGuid;
  private bool _ShowProducer;
  private Guid _ProducerGuid;
  private Guid _InHouseProducerGuid;
  private bool _ShowCompany;
  private string _CompanyGuids;
  private string _LineGuids;
  private DateTime _DateRangeTo;
  private DateTime _DateRangeFrom;
  private bool _ShowInsured;
  private Guid _InsuredGuid;
  private DataSet _ds;
  private string _DateType;
  private string _BillingType;
  private Label lblTitle;
  private Label lblSubTitle;
  private TextBox TextBox1;
  private Label lblInvoiceNumber;
  private Label lblPolicyNumber;
  private Label lblEffectiveDate;
  private Label lblDueDate;
  private Label lblGrossBilled;
  private Label lblBucket1;
  private Label lblBucket2;
  private Label lblBucket3;
  private Label lblBucket4;
  private Label Label3;
  private Label Label;
  private Label Label4;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox TextBox10;
  private TextBox TextBox11;
  private TextBox bucket13;
  private TextBox TextBox;
  private TextBox TextBox4;
  private TextBox bucket11;
  private TextBox bucket21;
  private TextBox bucket31;
  private TextBox bucket41;
  private TextBox grossBilled1;
  private Label Label1;
  private TextBox bucket14;
  private TextBox bucket12;
  private TextBox bucket22;
  private TextBox bucket32;
  private TextBox bucket42;
  private TextBox grossBilled2;
  private Label Label2;
  private TextBox bucket15;
  private Database _reportDatabase;

  [field: AccessedThroughProperty("TextBox12")]
  private virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox13")]
  private virtual TextBox TextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptAgingDetail()
  {
    this.ReportStart += new EventHandler(this.rptAgingDetail_ReportStart);
    this._ds = new DataSet();
  }

  public rptAgingDetail(
    DateTime AsOf,
    string rpt_Type,
    string PolicyNumber,
    int OfficeInvoiceNumber,
    Guid EntityGuid,
    bool ShowInsured,
    Guid InsuredGuid,
    bool ShowProducer,
    Guid ProducerGuid,
    Guid InHouseProducerGuid,
    bool ShowCompany,
    string CompanyGuids,
    string LineGuids,
    int OfficeID,
    string CostCenterIDs,
    DateTime DateRangeFrom,
    DateTime DateRangeTo,
    string DateType,
    string BillingType)
  {
    this.ReportStart += new EventHandler(this.rptAgingDetail_ReportStart);
    this._ds = new DataSet();
    this.InitializeComponent();
    this._AsOf = AsOf;
    this._rpt_Type = rpt_Type;
    this._OfficeID = OfficeID;
    this._PolicyNumber = PolicyNumber;
    this._OfficeInvoiceNumber = OfficeInvoiceNumber;
    this._EntityGuid = EntityGuid;
    this._ShowProducer = ShowProducer;
    this._ProducerGuid = ProducerGuid;
    this._ShowCompany = ShowCompany;
    this._ShowInsured = ShowInsured;
    this._InsuredGuid = InsuredGuid;
    this._CompanyGuids = CompanyGuids;
    this._LineGuids = LineGuids;
    this._CostCenterIDs = CostCenterIDs;
    this._DateRangeTo = DateRangeTo;
    this._DateRangeFrom = DateRangeFrom;
    this._DateType = DateType;
    this._InHouseProducerGuid = InHouseProducerGuid;
    this._BillingType = BillingType;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptAgingDetail));
    this.Detail = new Detail();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.bucket13 = new TextBox();
    this.TextBox = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.lblTitle = new Label();
    this.lblSubTitle = new Label();
    this.lblBillingType = new Label();
    this.ReportFooter = new ReportFooter();
    this.bucket12 = new TextBox();
    this.bucket22 = new TextBox();
    this.bucket32 = new TextBox();
    this.bucket42 = new TextBox();
    this.grossBilled2 = new TextBox();
    this.Label2 = new Label();
    this.bucket15 = new TextBox();
    this.Label5 = new Label();
    this.txtAgingTotal = new TextBox();
    this.Line1 = new Line();
    this.ghEntity = new GroupHeader();
    this.TextBox1 = new TextBox();
    this.lblInvoiceNumber = new Label();
    this.lblPolicyNumber = new Label();
    this.lblEffectiveDate = new Label();
    this.lblDueDate = new Label();
    this.lblGrossBilled = new Label();
    this.lblBucket1 = new Label();
    this.lblBucket2 = new Label();
    this.lblBucket3 = new Label();
    this.lblBucket4 = new Label();
    this.Label3 = new Label();
    this.Label = new Label();
    this.Label4 = new Label();
    this.gfEntity = new GroupFooter();
    this.bucket11 = new TextBox();
    this.bucket21 = new TextBox();
    this.bucket31 = new TextBox();
    this.bucket41 = new TextBox();
    this.grossBilled1 = new TextBox();
    this.Label1 = new Label();
    this.bucket14 = new TextBox();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.bucket13).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.lblSubTitle).BeginInit();
    ((ISupportInitialize) this.lblBillingType).BeginInit();
    ((ISupportInitialize) this.bucket12).BeginInit();
    ((ISupportInitialize) this.bucket22).BeginInit();
    ((ISupportInitialize) this.bucket32).BeginInit();
    ((ISupportInitialize) this.bucket42).BeginInit();
    ((ISupportInitialize) this.grossBilled2).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.bucket15).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.txtAgingTotal).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.lblInvoiceNumber).BeginInit();
    ((ISupportInitialize) this.lblPolicyNumber).BeginInit();
    ((ISupportInitialize) this.lblEffectiveDate).BeginInit();
    ((ISupportInitialize) this.lblDueDate).BeginInit();
    ((ISupportInitialize) this.lblGrossBilled).BeginInit();
    ((ISupportInitialize) this.lblBucket1).BeginInit();
    ((ISupportInitialize) this.lblBucket2).BeginInit();
    ((ISupportInitialize) this.lblBucket3).BeginInit();
    ((ISupportInitialize) this.lblBucket4).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.bucket11).BeginInit();
    ((ISupportInitialize) this.bucket21).BeginInit();
    ((ISupportInitialize) this.bucket31).BeginInit();
    ((ISupportInitialize) this.bucket41).BeginInit();
    ((ISupportInitialize) this.grossBilled1).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.bucket14).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[14]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.bucket13,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1979167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "OfficeInvoiceNum";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 0.0f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 7pt; vertical-align: middle";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.625f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 0.625f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 7pt; vertical-align: middle";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 25f / 16f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "effectiveDate";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 67f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "font-size: 7pt; vertical-align: middle";
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
    ((ARControl) this.TextBox6).DataField = "dueDate";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 4.75f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "font-size: 7pt; vertical-align: middle";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 9f / 16f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "grossBilled";
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 85f / 16f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "font-size: 7pt; text-align: right; vertical-align: middle";
    this.TextBox7.Text = " ";
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
    ((ARControl) this.TextBox8).DataField = "bucket1";
    ((ARControl) this.TextBox8).Height = 3f / 16f;
    ((ARControl) this.TextBox8).Left = 109f / 16f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "font-size: 7pt; text-align: right; vertical-align: middle";
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 15f / 16f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).DataField = "bucket2";
    ((ARControl) this.TextBox9).Height = 3f / 16f;
    ((ARControl) this.TextBox9).Left = 7.75f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "font-size: 7pt; text-align: right; vertical-align: middle";
    this.TextBox9.Text = " ";
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 15f / 16f;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).DataField = "bucket3";
    ((ARControl) this.TextBox10).Height = 3f / 16f;
    ((ARControl) this.TextBox10).Left = 139f / 16f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = resourceManager.GetString("TextBox10.OutputFormat");
    this.TextBox10.Style = "font-size: 7pt; text-align: right; vertical-align: middle";
    this.TextBox10.Text = " ";
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 15f / 16f;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).DataField = "bucket4";
    ((ARControl) this.TextBox11).Height = 3f / 16f;
    ((ARControl) this.TextBox11).Left = 9.625f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "font-size: 7pt; text-align: right; vertical-align: middle";
    this.TextBox11.Text = (string) null;
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 0.75f;
    ((ARControl) this.bucket13).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.bucket13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.bucket13).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.bucket13).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.bucket13).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.bucket13).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.bucket13).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.bucket13).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.bucket13).DataField = "acctCurrent";
    ((ARControl) this.bucket13).Height = 3f / 16f;
    ((ARControl) this.bucket13).Left = 97f / 16f;
    ((ARControl) this.bucket13).Name = "bucket13";
    this.bucket13.OutputFormat = resourceManager.GetString("bucket13.OutputFormat");
    this.bucket13.Style = "font-size: 7pt; text-align: right; vertical-align: middle";
    this.bucket13.Text = " ";
    ((ARControl) this.bucket13).Top = 0.0f;
    ((ARControl) this.bucket13).Width = 0.75f;
    ((ARControl) this.TextBox).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).DataField = "Producer";
    ((ARControl) this.TextBox).Height = 3f / 16f;
    ((ARControl) this.TextBox).Left = 35f / 16f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-size: 7pt; vertical-align: middle";
    this.TextBox.Text = " ";
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 1f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "Company";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 51f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "font-size: 7pt; vertical-align: middle";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 1f;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).DataField = "policyNumber";
    ((ARControl) this.TextBox12).Height = 3f / 16f;
    ((ARControl) this.TextBox12).Left = 10.312f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.Style = "background-color: Yellow; font-size: 7pt; vertical-align: middle";
    this.TextBox12.Text = " ";
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Visible = false;
    ((ARControl) this.TextBox12).Width = 0.06300068f;
    ((ARControl) this.TextBox13).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox13).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox13).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox13).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox13).DataField = "insuredname";
    ((ARControl) this.TextBox13).Height = 3f / 16f;
    ((ARControl) this.TextBox13).Left = 9.625f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.Style = "background-color: Yellow; font-size: 7pt; vertical-align: middle";
    this.TextBox13.Text = " ";
    ((ARControl) this.TextBox13).Top = 0.0f;
    ((ARControl) this.TextBox13).Visible = false;
    ((ARControl) this.TextBox13).Width = 0.06300068f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.lblTitle,
      (ARControl) this.lblSubTitle,
      (ARControl) this.lblBillingType
    });
    this.ReportHeader.Height = 0.75f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.lblTitle).Height = 3f / 16f;
    this.lblTitle.HyperLink = (string) null;
    ((ARControl) this.lblTitle).Left = 0.0f;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    this.lblTitle.Style = "font-size: 11.25pt; font-weight: bold; ddo-char-set: 0";
    this.lblTitle.Text = "";
    ((ARControl) this.lblTitle).Top = 0.0f;
    ((ARControl) this.lblTitle).Width = 10.375f;
    ((ARControl) this.lblSubTitle).Height = 0.25f;
    this.lblSubTitle.HyperLink = (string) null;
    ((ARControl) this.lblSubTitle).Left = 0.0f;
    ((ARControl) this.lblSubTitle).Name = "lblSubTitle";
    this.lblSubTitle.Style = "font-size: 11.25pt; font-weight: bold; ddo-char-set: 0";
    this.lblSubTitle.Text = "Aging Detail Report as of {0}";
    ((ARControl) this.lblSubTitle).Top = 3f / 16f;
    ((ARControl) this.lblSubTitle).Width = 10.375f;
    ((ARControl) this.lblBillingType).Height = 3f / 16f;
    this.lblBillingType.HyperLink = (string) null;
    ((ARControl) this.lblBillingType).Left = 0.0f;
    ((ARControl) this.lblBillingType).Name = "lblBillingType";
    this.lblBillingType.Style = "font-size: 10pt; ddo-char-set: 0";
    this.lblBillingType.Text = "";
    ((ARControl) this.lblBillingType).Top = 7f / 16f;
    ((ARControl) this.lblBillingType).Width = 10.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.bucket12,
      (ARControl) this.bucket22,
      (ARControl) this.bucket32,
      (ARControl) this.bucket42,
      (ARControl) this.grossBilled2,
      (ARControl) this.Label2,
      (ARControl) this.bucket15,
      (ARControl) this.Label5,
      (ARControl) this.txtAgingTotal,
      (ARControl) this.Line1
    });
    this.ReportFooter.Height = 0.7604167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.bucket12).DataField = "bucket1";
    ((ARControl) this.bucket12).Height = 3f / 16f;
    ((ARControl) this.bucket12).Left = 109f / 16f;
    ((ARControl) this.bucket12).Name = "bucket12";
    this.bucket12.OutputFormat = resourceManager.GetString("bucket12.OutputFormat");
    this.bucket12.Style = "font-size: 8pt; text-align: right; vertical-align: middle";
    this.bucket12.SummaryRunning = (SummaryRunning) 2;
    this.bucket12.SummaryType = (SummaryType) 1;
    this.bucket12.Text = " ";
    ((ARControl) this.bucket12).Top = 0.125f;
    ((ARControl) this.bucket12).Width = 15f / 16f;
    ((ARControl) this.bucket22).DataField = "bucket3";
    ((ARControl) this.bucket22).Height = 3f / 16f;
    ((ARControl) this.bucket22).Left = 139f / 16f;
    ((ARControl) this.bucket22).Name = "bucket22";
    this.bucket22.OutputFormat = resourceManager.GetString("bucket22.OutputFormat");
    this.bucket22.Style = "font-size: 8pt; text-align: right; vertical-align: middle";
    this.bucket22.SummaryRunning = (SummaryRunning) 2;
    this.bucket22.SummaryType = (SummaryType) 1;
    this.bucket22.Text = " ";
    ((ARControl) this.bucket22).Top = 0.125f;
    ((ARControl) this.bucket22).Width = 15f / 16f;
    ((ARControl) this.bucket32).DataField = "bucket2";
    ((ARControl) this.bucket32).Height = 3f / 16f;
    ((ARControl) this.bucket32).Left = 7.75f;
    ((ARControl) this.bucket32).Name = "bucket32";
    this.bucket32.OutputFormat = resourceManager.GetString("bucket32.OutputFormat");
    this.bucket32.Style = "font-size: 8pt; text-align: right; vertical-align: middle";
    this.bucket32.SummaryRunning = (SummaryRunning) 2;
    this.bucket32.SummaryType = (SummaryType) 1;
    this.bucket32.Text = " ";
    ((ARControl) this.bucket32).Top = 0.125f;
    ((ARControl) this.bucket32).Width = 15f / 16f;
    ((ARControl) this.bucket42).DataField = "bucket4";
    ((ARControl) this.bucket42).Height = 3f / 16f;
    ((ARControl) this.bucket42).Left = 9.625f;
    ((ARControl) this.bucket42).Name = "bucket42";
    this.bucket42.OutputFormat = resourceManager.GetString("bucket42.OutputFormat");
    this.bucket42.Style = "font-size: 8pt; text-align: right; vertical-align: middle";
    this.bucket42.SummaryRunning = (SummaryRunning) 2;
    this.bucket42.SummaryType = (SummaryType) 1;
    this.bucket42.Text = " ";
    ((ARControl) this.bucket42).Top = 0.125f;
    ((ARControl) this.bucket42).Width = 0.75f;
    ((ARControl) this.grossBilled2).DataField = "grossBilled";
    ((ARControl) this.grossBilled2).Height = 3f / 16f;
    ((ARControl) this.grossBilled2).Left = 85f / 16f;
    ((ARControl) this.grossBilled2).Name = "grossBilled2";
    this.grossBilled2.OutputFormat = resourceManager.GetString("grossBilled2.OutputFormat");
    this.grossBilled2.Style = "font-size: 8pt; text-align: right; vertical-align: middle";
    this.grossBilled2.SummaryRunning = (SummaryRunning) 2;
    this.grossBilled2.SummaryType = (SummaryType) 1;
    this.grossBilled2.Text = " ";
    ((ARControl) this.grossBilled2).Top = 0.125f;
    ((ARControl) this.grossBilled2).Width = 0.75f;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 67f / 16f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label2.Text = "Grand Total:";
    ((ARControl) this.Label2).Top = 0.125f;
    ((ARControl) this.Label2).Width = 1.125f;
    ((ARControl) this.bucket15).DataField = "acctCurrent";
    ((ARControl) this.bucket15).Height = 3f / 16f;
    ((ARControl) this.bucket15).Left = 97f / 16f;
    ((ARControl) this.bucket15).Name = "bucket15";
    this.bucket15.OutputFormat = resourceManager.GetString("bucket15.OutputFormat");
    this.bucket15.Style = "font-size: 8pt; text-align: right; vertical-align: middle";
    this.bucket15.SummaryRunning = (SummaryRunning) 2;
    this.bucket15.SummaryType = (SummaryType) 1;
    this.bucket15.Text = " ";
    ((ARControl) this.bucket15).Top = 0.125f;
    ((ARControl) this.bucket15).Width = 0.75f;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 113f / 16f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label5.Text = "Aging Grand Total:";
    ((ARControl) this.Label5).Top = 7f / 16f;
    ((ARControl) this.Label5).Width = 1.125f;
    ((ARControl) this.txtAgingTotal).DataField = "bucket4";
    ((ARControl) this.txtAgingTotal).Height = 3f / 16f;
    ((ARControl) this.txtAgingTotal).Left = 131f / 16f;
    ((ARControl) this.txtAgingTotal).Name = "txtAgingTotal";
    this.txtAgingTotal.OutputFormat = resourceManager.GetString("txtAgingTotal.OutputFormat");
    this.txtAgingTotal.Style = "font-size: 8pt; text-align: right; vertical-align: middle";
    this.txtAgingTotal.SummaryRunning = (SummaryRunning) 2;
    this.txtAgingTotal.SummaryType = (SummaryType) 1;
    this.txtAgingTotal.Text = " ";
    ((ARControl) this.txtAgingTotal).Top = 7f / 16f;
    ((ARControl) this.txtAgingTotal).Width = 35f / 16f;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 0.0f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 0.375f;
    ((ARControl) this.Line1).Width = 10.4f;
    this.Line1.X1 = 0.0f;
    this.Line1.X2 = 10.4f;
    this.Line1.Y1 = 0.375f;
    this.Line1.Y2 = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghEntity).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.lblInvoiceNumber,
      (ARControl) this.lblPolicyNumber,
      (ARControl) this.lblEffectiveDate,
      (ARControl) this.lblDueDate,
      (ARControl) this.lblGrossBilled,
      (ARControl) this.lblBucket1,
      (ARControl) this.lblBucket2,
      (ARControl) this.lblBucket3,
      (ARControl) this.lblBucket4,
      (ARControl) this.Label3,
      (ARControl) this.Label,
      (ARControl) this.Label4
    });
    this.ghEntity.DataField = "entityGuid";
    this.ghEntity.Height = 0.375f;
    this.ghEntity.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghEntity).Name = "ghEntity";
    ((ARControl) this.TextBox1).DataField = "remitterPayeeName";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.625f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 9pt; ddo-char-set: 0";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 99f / 16f;
    ((ARControl) this.lblInvoiceNumber).Height = 3f / 16f;
    this.lblInvoiceNumber.HyperLink = (string) null;
    ((ARControl) this.lblInvoiceNumber).Left = 0.0f;
    ((ARControl) this.lblInvoiceNumber).Name = "lblInvoiceNumber";
    this.lblInvoiceNumber.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.lblInvoiceNumber.Text = "Invoice #";
    ((ARControl) this.lblInvoiceNumber).Top = 3f / 16f;
    ((ARControl) this.lblInvoiceNumber).Width = 0.625f;
    ((ARControl) this.lblPolicyNumber).Height = 3f / 16f;
    this.lblPolicyNumber.HyperLink = (string) null;
    ((ARControl) this.lblPolicyNumber).Left = 0.625f;
    ((ARControl) this.lblPolicyNumber).Name = "lblPolicyNumber";
    this.lblPolicyNumber.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.lblPolicyNumber.Text = "Policy #";
    ((ARControl) this.lblPolicyNumber).Top = 3f / 16f;
    ((ARControl) this.lblPolicyNumber).Width = 25f / 16f;
    ((ARControl) this.lblEffectiveDate).Height = 3f / 16f;
    this.lblEffectiveDate.HyperLink = (string) null;
    ((ARControl) this.lblEffectiveDate).Left = 67f / 16f;
    ((ARControl) this.lblEffectiveDate).Name = "lblEffectiveDate";
    this.lblEffectiveDate.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.lblEffectiveDate.Text = "Effective";
    ((ARControl) this.lblEffectiveDate).Top = 3f / 16f;
    ((ARControl) this.lblEffectiveDate).Width = 9f / 16f;
    ((ARControl) this.lblDueDate).Height = 3f / 16f;
    this.lblDueDate.HyperLink = (string) null;
    ((ARControl) this.lblDueDate).Left = 4.75f;
    ((ARControl) this.lblDueDate).Name = "lblDueDate";
    this.lblDueDate.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.lblDueDate.Text = "Due";
    ((ARControl) this.lblDueDate).Top = 3f / 16f;
    ((ARControl) this.lblDueDate).Width = 9f / 16f;
    ((ARControl) this.lblGrossBilled).Height = 3f / 16f;
    this.lblGrossBilled.HyperLink = (string) null;
    ((ARControl) this.lblGrossBilled).Left = 85f / 16f;
    ((ARControl) this.lblGrossBilled).Name = "lblGrossBilled";
    this.lblGrossBilled.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.lblGrossBilled.Text = "Gross Billed";
    ((ARControl) this.lblGrossBilled).Top = 3f / 16f;
    ((ARControl) this.lblGrossBilled).Width = 0.75f;
    ((ARControl) this.lblBucket1).Height = 0.375f;
    this.lblBucket1.HyperLink = (string) null;
    ((ARControl) this.lblBucket1).Left = 109f / 16f;
    ((ARControl) this.lblBucket1).Name = "lblBucket1";
    this.lblBucket1.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.lblBucket1.Text = "Bucket 1";
    ((ARControl) this.lblBucket1).Top = 0.0f;
    ((ARControl) this.lblBucket1).Width = 15f / 16f;
    ((ARControl) this.lblBucket2).Height = 0.375f;
    this.lblBucket2.HyperLink = (string) null;
    ((ARControl) this.lblBucket2).Left = 7.75f;
    ((ARControl) this.lblBucket2).Name = "lblBucket2";
    this.lblBucket2.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.lblBucket2.Text = "Bucket 2";
    ((ARControl) this.lblBucket2).Top = 0.0f;
    ((ARControl) this.lblBucket2).Width = 15f / 16f;
    ((ARControl) this.lblBucket3).Height = 0.375f;
    this.lblBucket3.HyperLink = (string) null;
    ((ARControl) this.lblBucket3).Left = 139f / 16f;
    ((ARControl) this.lblBucket3).Name = "lblBucket3";
    this.lblBucket3.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.lblBucket3.Text = "Bucket 3";
    ((ARControl) this.lblBucket3).Top = 0.0f;
    ((ARControl) this.lblBucket3).Width = 15f / 16f;
    ((ARControl) this.lblBucket4).Height = 0.375f;
    this.lblBucket4.HyperLink = (string) null;
    ((ARControl) this.lblBucket4).Left = 9.625f;
    ((ARControl) this.lblBucket4).Name = "lblBucket4";
    this.lblBucket4.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.lblBucket4.Text = "Bucket 4";
    ((ARControl) this.lblBucket4).Top = 0.0f;
    ((ARControl) this.lblBucket4).Width = 0.75f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 97f / 16f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 7pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.Label3.Text = "Current";
    ((ARControl) this.Label3).Top = 3f / 16f;
    ((ARControl) this.Label3).Width = 0.75f;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 35f / 16f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.Label.Text = "Producer";
    ((ARControl) this.Label).Top = 3f / 16f;
    ((ARControl) this.Label).Width = 1f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 51f / 16f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 7pt; font-weight: bold; vertical-align: bottom";
    this.Label4.Text = "Company";
    ((ARControl) this.Label4).Top = 3f / 16f;
    ((ARControl) this.Label4).Width = 1f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfEntity).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.bucket11,
      (ARControl) this.bucket21,
      (ARControl) this.bucket31,
      (ARControl) this.bucket41,
      (ARControl) this.grossBilled1,
      (ARControl) this.Label1,
      (ARControl) this.bucket14
    });
    this.gfEntity.Height = 0.2083333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfEntity).Name = "gfEntity";
    ((ARControl) this.bucket11).DataField = "bucket1";
    ((ARControl) this.bucket11).Height = 3f / 16f;
    ((ARControl) this.bucket11).Left = 109f / 16f;
    ((ARControl) this.bucket11).Name = "bucket11";
    this.bucket11.OutputFormat = resourceManager.GetString("bucket11.OutputFormat");
    this.bucket11.Style = "font-size: 7pt; text-align: right; vertical-align: middle";
    this.bucket11.SummaryGroup = "ghEntity";
    this.bucket11.SummaryRunning = (SummaryRunning) 1;
    this.bucket11.SummaryType = (SummaryType) 3;
    this.bucket11.Text = " ";
    ((ARControl) this.bucket11).Top = 0.0f;
    ((ARControl) this.bucket11).Width = 15f / 16f;
    ((ARControl) this.bucket21).DataField = "bucket2";
    ((ARControl) this.bucket21).Height = 3f / 16f;
    ((ARControl) this.bucket21).Left = 7.75f;
    ((ARControl) this.bucket21).Name = "bucket21";
    this.bucket21.OutputFormat = resourceManager.GetString("bucket21.OutputFormat");
    this.bucket21.Style = "font-size: 7pt; text-align: right; vertical-align: middle";
    this.bucket21.SummaryGroup = "ghEntity";
    this.bucket21.SummaryRunning = (SummaryRunning) 1;
    this.bucket21.SummaryType = (SummaryType) 3;
    this.bucket21.Text = " ";
    ((ARControl) this.bucket21).Top = 0.0f;
    ((ARControl) this.bucket21).Width = 15f / 16f;
    ((ARControl) this.bucket31).DataField = "bucket3";
    ((ARControl) this.bucket31).Height = 3f / 16f;
    ((ARControl) this.bucket31).Left = 139f / 16f;
    ((ARControl) this.bucket31).Name = "bucket31";
    this.bucket31.OutputFormat = resourceManager.GetString("bucket31.OutputFormat");
    this.bucket31.Style = "font-size: 7pt; text-align: right; vertical-align: middle";
    this.bucket31.SummaryGroup = "ghEntity";
    this.bucket31.SummaryRunning = (SummaryRunning) 1;
    this.bucket31.SummaryType = (SummaryType) 3;
    this.bucket31.Text = " ";
    ((ARControl) this.bucket31).Top = 0.0f;
    ((ARControl) this.bucket31).Width = 15f / 16f;
    ((ARControl) this.bucket41).DataField = "bucket4";
    ((ARControl) this.bucket41).Height = 3f / 16f;
    ((ARControl) this.bucket41).Left = 9.625f;
    ((ARControl) this.bucket41).Name = "bucket41";
    this.bucket41.OutputFormat = resourceManager.GetString("bucket41.OutputFormat");
    this.bucket41.Style = "font-size: 7pt; text-align: right; vertical-align: middle";
    this.bucket41.SummaryGroup = "ghEntity";
    this.bucket41.SummaryRunning = (SummaryRunning) 1;
    this.bucket41.SummaryType = (SummaryType) 3;
    this.bucket41.Text = (string) null;
    ((ARControl) this.bucket41).Top = 0.0f;
    ((ARControl) this.bucket41).Width = 0.75f;
    ((ARControl) this.grossBilled1).DataField = "grossBilled";
    ((ARControl) this.grossBilled1).Height = 3f / 16f;
    ((ARControl) this.grossBilled1).Left = 85f / 16f;
    ((ARControl) this.grossBilled1).Name = "grossBilled1";
    this.grossBilled1.OutputFormat = resourceManager.GetString("grossBilled1.OutputFormat");
    this.grossBilled1.Style = "font-size: 7pt; text-align: right; vertical-align: middle";
    this.grossBilled1.SummaryGroup = "ghEntity";
    this.grossBilled1.SummaryRunning = (SummaryRunning) 1;
    this.grossBilled1.SummaryType = (SummaryType) 3;
    this.grossBilled1.Text = " ";
    ((ARControl) this.grossBilled1).Top = 0.0f;
    ((ARControl) this.grossBilled1).Width = 0.75f;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 67f / 16f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label1.Text = "Sub Total:";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 1.125f;
    ((ARControl) this.bucket14).DataField = "acctCurrent";
    ((ARControl) this.bucket14).Height = 3f / 16f;
    ((ARControl) this.bucket14).Left = 97f / 16f;
    ((ARControl) this.bucket14).Name = "bucket14";
    this.bucket14.OutputFormat = resourceManager.GetString("bucket14.OutputFormat");
    this.bucket14.Style = "font-size: 7pt; text-align: right; vertical-align: middle";
    this.bucket14.SummaryGroup = "ghEntity";
    this.bucket14.SummaryRunning = (SummaryRunning) 1;
    this.bucket14.SummaryType = (SummaryType) 3;
    this.bucket14.Text = " ";
    ((ARControl) this.bucket14).Top = 0.0f;
    ((ARControl) this.bucket14).Width = 0.75f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.4f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghEntity);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfEntity);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.bucket13).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.lblSubTitle).EndInit();
    ((ISupportInitialize) this.lblBillingType).EndInit();
    ((ISupportInitialize) this.bucket12).EndInit();
    ((ISupportInitialize) this.bucket22).EndInit();
    ((ISupportInitialize) this.bucket32).EndInit();
    ((ISupportInitialize) this.bucket42).EndInit();
    ((ISupportInitialize) this.grossBilled2).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.bucket15).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.txtAgingTotal).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.lblInvoiceNumber).EndInit();
    ((ISupportInitialize) this.lblPolicyNumber).EndInit();
    ((ISupportInitialize) this.lblEffectiveDate).EndInit();
    ((ISupportInitialize) this.lblDueDate).EndInit();
    ((ISupportInitialize) this.lblGrossBilled).EndInit();
    ((ISupportInitialize) this.lblBucket1).EndInit();
    ((ISupportInitialize) this.lblBucket2).EndInit();
    ((ISupportInitialize) this.lblBucket3).EndInit();
    ((ISupportInitialize) this.lblBucket4).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.bucket11).EndInit();
    ((ISupportInitialize) this.bucket21).EndInit();
    ((ISupportInitialize) this.bucket31).EndInit();
    ((ISupportInitialize) this.bucket41).EndInit();
    ((ISupportInitialize) this.grossBilled1).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.bucket14).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void rptAgingDetail_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    ArrayList arrayList = new ArrayList();
    this._ds = new DataSet();
    arrayList.Add((object) "@asof_date");
    arrayList.Add((object) this._AsOf);
    arrayList.Add((object) "@rpt_type");
    arrayList.Add((object) this._rpt_Type);
    arrayList.Add((object) "@officeId");
    arrayList.Add((object) this._OfficeID);
    arrayList.Add((object) "@policyNumber");
    arrayList.Add((object) this._PolicyNumber);
    arrayList.Add((object) "@officeInvoiceNum");
    arrayList.Add((object) this._OfficeInvoiceNumber);
    arrayList.Add((object) "@showInsured");
    arrayList.Add((object) this._ShowInsured);
    if (!string.IsNullOrEmpty(this._CompanyGuids))
    {
      arrayList.Add((object) "@CompanyGuids");
      arrayList.Add((object) this._CompanyGuids);
    }
    if (!string.IsNullOrEmpty(this._LineGuids))
    {
      arrayList.Add((object) "@LineGuids");
      arrayList.Add((object) this._LineGuids);
    }
    if (!string.IsNullOrEmpty(this._CostCenterIDs))
    {
      arrayList.Add((object) "@CostCenterIDs");
      arrayList.Add((object) this._CostCenterIDs);
    }
    arrayList.Add((object) "@showCompanies");
    arrayList.Add((object) this._ShowCompany);
    arrayList.Add((object) "@showProducers");
    arrayList.Add((object) this._ShowProducer);
    arrayList.Add((object) "@DateType");
    arrayList.Add((object) this._DateType);
    if (this._ShowProducer && !this._ProducerGuid.Equals(Guid.Empty))
    {
      arrayList.Add((object) "@producerGuid");
      arrayList.Add((object) this._ProducerGuid);
    }
    if (this._ShowInsured && !this._InsuredGuid.Equals(Guid.Empty))
    {
      arrayList.Add((object) "@insuredGuid");
      arrayList.Add((object) this._InsuredGuid);
    }
    if (DateTime.Compare(this._DateRangeFrom, DateTime.MinValue) != 0)
    {
      arrayList.Add((object) "@limiter_from");
      arrayList.Add((object) this._DateRangeFrom);
    }
    if (DateTime.Compare(this._DateRangeTo, DateTime.MinValue) != 0)
    {
      arrayList.Add((object) "@limiter_to");
      arrayList.Add((object) this._DateRangeTo);
    }
    if (!this._EntityGuid.Equals(Guid.Empty))
    {
      arrayList.Add((object) "@EntityGuid");
      arrayList.Add((object) this._EntityGuid);
    }
    arrayList.Add((object) "@InHouseProducerGuid");
    arrayList.Add((object) this._InHouseProducerGuid);
    arrayList.Add((object) "@Remitter");
    arrayList.Add((object) this._BillingType);
    this._ds = this.ReportDatabase.ExecuteDataSet(CommandType.StoredProcedure, "spFin_rptAgingDetail", 9999, (CommandArgumentType) 0, arrayList.ToArray());
    if (this._ds.Tables.Count != 2 || this._ds.Tables[0].Rows.Count <= 0)
      return;
    this.lblSubTitle.Text = string.Format(this.lblSubTitle.Text, (object) this._AsOf.ToShortDateString());
    this.lblTitle.Text = "Accounts " + Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._rpt_Type, "R", false) == 0, (object) "Receivable", (object) "Payable").ToString();
    string billingType = this._BillingType;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(billingType, "*", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(billingType, "B", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(billingType, "I", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(billingType, "C", false) == 0)
            this.lblBillingType.Text = "Billing Type: Direct Bill (Company) only";
        }
        else
          this.lblBillingType.Text = "Billing Type: Direct Bill (MGA) only";
      }
      else
        this.lblBillingType.Text = "Billing Type: Agency Bill only";
    }
    else
      this.lblBillingType.Text = "Billing Type: All";
    this.lblBucket1.Text = this._ds.Tables[0].Rows[0]["period1"].ToString();
    this.lblBucket2.Text = this._ds.Tables[0].Rows[0]["period2"].ToString();
    this.lblBucket3.Text = this._ds.Tables[0].Rows[0]["period3"].ToString();
    this.lblBucket4.Text = this._ds.Tables[0].Rows[0]["period4"].ToString();
    this.DataSource = (object) this._ds.Tables[1];
    this.ShowPageNumbers();
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  private void ReportFooter_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[1].Rows.Count <= 0)
      return;
    this.txtAgingTotal.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.bucket15.Value, this.bucket12.Value), this.bucket32.Value), this.bucket22.Value), this.bucket42.Value);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      string[] strArray = new string[8]
      {
        "All",
        "*",
        "Agency Bill",
        "B",
        "Direct Bill (MGA)",
        "I",
        "Direct Bill (Company)",
        "C"
      };
      BaseReportControl[] getReportControls = new BaseReportControl[14]
      {
        (BaseReportControl) new DatePicker("As Of", DateAndTime.Now.Date, false),
        (BaseReportControl) new GenericComboBox("Type", 125, 125, typeof (string), new object[4]
        {
          (object) "Receivable",
          (object) "R",
          (object) "Payable",
          (object) "P"
        }),
        (BaseReportControl) new TextInput("Policy #", false, false),
        (BaseReportControl) new TextInput("Invoice #", false, true),
        (BaseReportControl) new EntitySelection("Entity", false),
        (BaseReportControl) new Insureds_Checked("Insured", true),
        (BaseReportControl) new Producers_Checked("Producer", true),
        (BaseReportControl) new Underwriters("Inhouse Producer", true),
        (BaseReportControl) new Companies_Checked("Companies", "SELECT CompanyName, CompanyGuid FROM tblCompanies ORDER BY CompanyName", "CompanyGuid", "CompanyName", true, typeof (Guid), true, false),
        (BaseReportControl) new GenericListBox("Line of Business", "SELECT LineName, LineGUID FROM lstLines ORDER BY LineName", "LineGuid", "LineName", true, typeof (Guid), true, false),
        (BaseReportControl) new OfficeThenMultiCostCenter("Offices", false),
        null,
        null,
        null
      };
      DateTime now = DateAndTime.Now;
      DateTime date1 = now.Date;
      now = DateAndTime.Now;
      DateTime date2 = now.Date;
      getReportControls[11] = (BaseReportControl) new OptionalDateRange("Limit by Date Range", date1, date2);
      getReportControls[12] = (BaseReportControl) new GenericComboBox("Date Type", 125, 125, typeof (string), new object[4]
      {
        (object) "Company Due Date",
        (object) "C",
        (object) "Invoice Due Date",
        (object) "I"
      });
      getReportControls[13] = (BaseReportControl) new GenericComboBox("Billing Type", 100, 150, typeof (string), (object[]) strArray);
      return getReportControls;
    }
  }

  public override bool IsThreaded => true;

  public Database ReportDatabase
  {
    get => this._reportDatabase;
    set => this._reportDatabase = value;
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    DataTable dataTable = new DataTable();
    DataTable source = this._ds.Tables[1].Copy();
    source.Columns.Remove("entityGuid");
    source.Columns["bucket1"].ColumnName = this._ds.Tables[0].Rows[0]["period1"].ToString().Replace("\r\n", "");
    source.Columns["bucket2"].ColumnName = this._ds.Tables[0].Rows[0]["period2"].ToString().Replace("\r\n", "");
    source.Columns["bucket3"].ColumnName = this._ds.Tables[0].Rows[0]["period3"].ToString().Replace("\r\n", "");
    source.Columns["bucket4"].ColumnName = this._ds.Tables[0].Rows[0]["period4"].ToString().Replace("\r\n", "");
    ExcelExport.ToExcel(source, SaveFileTo);
  }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAgingTotal")]
  private virtual TextBox txtAgingTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line1")]
  internal virtual Line Line1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBillingType")]
  private virtual Label lblBillingType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghEntity")]
  private virtual GroupHeader ghEntity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("gfEntity")]
  private virtual GroupFooter gfEntity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private void Detail_Format(object sender, EventArgs e)
  {
    this.TextBox3.Text = $"{this.TextBox12.Text} - {this.TextBox13.Text}";
  }
}
