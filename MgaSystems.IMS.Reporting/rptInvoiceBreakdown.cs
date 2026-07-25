// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptInvoiceBreakdown
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{27918AD6-3928-4322-BD17-34A4582489F8}", "Invoice Break Down", "Shows detailed invoice information.", "General")]
[SecureResource("{C5F8AC88-2124-42c0-8E5C-F214BA9B6772}", "Invoice Break Down Report User Access", "Allows user to run report for any/all users.", "Reports")]
[SecureResource("{18A92635-EA5D-4dc2-96A2-BBF141C8590F}", "Invoice Break Down Report Issuing Office Access", "Allows user to run report for any/all issuing offices.", "Reports")]
public class rptInvoiceBreakdown : MGAReport, IReport
{
  internal const string SecurityIDAllUsers = "{C5F8AC88-2124-42c0-8E5C-F214BA9B6772}";
  internal const string SecurityIDAllOffices = "{18A92635-EA5D-4dc2-96A2-BBF141C8590F}";
  private Label lblTitle;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private Label Label11;
  private Label Label12;
  private Label Label13;
  private Label Label14;
  private Label Label15;
  private Label Label16;
  private Label Label17;
  private Label Label18;
  private Label Label19;
  private Label Label20;
  private Label Label;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox TextBox10;
  private TextBox TextBox11;
  private TextBox TextBox12;
  private TextBox TextBox13;
  private TextBox TextBox14;
  private TextBox TextBox15;
  private TextBox TextBox16;
  private TextBox TextBox17;
  private TextBox TextBox18;
  private TextBox TextBox19;
  private TextBox LineName1;
  private TextBox TextBox;
  private readonly DateTime _billingDateFrom;
  private readonly DateTime _billingDateTo;
  private readonly DateTime _effectiveDateFrom;
  private readonly DateTime _effectiveDateTo;
  private readonly Guid _underwriterGuid;
  private readonly string _producerGuids;
  private readonly int _policyTypeID;
  private readonly Guid _inhouseProducerGuid;
  private readonly Guid _companyGuid;
  private readonly Guid _companyLocationGuid;
  private readonly Guid _lineGuid;
  private readonly int _issuingOfficeID;
  private DataTable _dt;
  private readonly int _Show;
  private readonly string _State;
  private readonly string _SortBy;

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptInvoiceBreakdown()
  {
    this.ReportStart += new EventHandler(this.rptInvoiceBreakdown_ReportStart);
  }

  public rptInvoiceBreakdown(
    DateTime billingDateFrom,
    DateTime billingDateTo,
    DateTime effectiveDateFrom,
    DateTime effectiveDateTo,
    string StateOfIssuance,
    int Show,
    Guid underwriterGuid,
    Guid inhouseProducerGuid,
    string producerGuids,
    int PolicyTypeID,
    Guid companyGuid,
    Guid companyLocationGuid,
    Guid LineGuid,
    int IssuingOfficeID,
    string SortBy)
  {
    this.ReportStart += new EventHandler(this.rptInvoiceBreakdown_ReportStart);
    this.InitializeComponent();
    this._billingDateFrom = billingDateFrom;
    this._billingDateTo = billingDateTo;
    this._effectiveDateFrom = effectiveDateFrom;
    this._effectiveDateTo = effectiveDateTo;
    this._underwriterGuid = underwriterGuid;
    this._producerGuids = producerGuids;
    this._policyTypeID = PolicyTypeID;
    this._inhouseProducerGuid = inhouseProducerGuid;
    this._companyGuid = companyGuid;
    this._lineGuid = LineGuid;
    this._issuingOfficeID = IssuingOfficeID;
    this._State = StateOfIssuance;
    this._Show = Show;
    this._companyLocationGuid = companyLocationGuid;
    this._SortBy = SortBy;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptInvoiceBreakdown));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.lblTitle = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.Label19 = new Label();
    this.Label20 = new Label();
    this.Label = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.TextBox14 = new TextBox();
    this.TextBox15 = new TextBox();
    this.TextBox16 = new TextBox();
    this.TextBox17 = new TextBox();
    this.TextBox18 = new TextBox();
    this.TextBox19 = new TextBox();
    this.LineName1 = new TextBox();
    this.TextBox = new TextBox();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.Label19).BeginInit();
    ((ISupportInitialize) this.Label20).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.TextBox17).BeginInit();
    ((ISupportInitialize) this.TextBox18).BeginInit();
    ((ISupportInitialize) this.TextBox19).BeginInit();
    ((ISupportInitialize) this.LineName1).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[21]
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
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13,
      (ARControl) this.TextBox14,
      (ARControl) this.TextBox15,
      (ARControl) this.TextBox16,
      (ARControl) this.TextBox17,
      (ARControl) this.TextBox18,
      (ARControl) this.TextBox19,
      (ARControl) this.LineName1,
      (ARControl) this.TextBox
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 3f / 16f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.lblTitle
    });
    this.ReportHeader.Height = 9f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[21]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label15,
      (ARControl) this.Label16,
      (ARControl) this.Label17,
      (ARControl) this.Label18,
      (ARControl) this.Label19,
      (ARControl) this.Label20,
      (ARControl) this.Label
    });
    this.PageHeader.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.lblTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.lblTitle.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTitle.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblTitle.HyperLink = (string) null;
    Label lblTitle = this.lblTitle;
    object obj1 = componentResourceManager.GetObject("lblTitle.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) lblTitle).Location = pointF1;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    ((ARControl) this.lblTitle).Size = new SizeF(387f / 16f, 0.25f);
    this.lblTitle.Text = "Invoice Breakdown";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj2 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label1).Location = pointF2;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(0.875f, 3f / 16f);
    this.Label1.Text = "Invoice #";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj3 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label2).Location = pointF3;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(0.625f, 3f / 16f);
    this.Label2.Text = "Billed";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj4 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label3).Location = pointF4;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(0.625f, 3f / 16f);
    this.Label3.Text = "Effective";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj5 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label4).Location = pointF5;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(0.625f, 3f / 16f);
    this.Label4.Text = "Expiration";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj6 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label5).Location = pointF6;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(19f / 16f, 3f / 16f);
    this.Label5.Text = "Policy";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj7 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label6).Location = pointF7;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(2.5f, 3f / 16f);
    this.Label6.Text = "Insured";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj8 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label7).Location = pointF8;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(2.5f, 3f / 16f);
    this.Label7.Text = "Producer";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj9 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label8).Location = pointF9;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(2.5f, 3f / 16f);
    this.Label8.Text = "Carrier";
    this.Label9.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj10 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label9).Location = pointF10;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(0.625f, 3f / 16f);
    this.Label9.Text = "Control #";
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj11 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label10).Location = pointF11;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(25f / 16f, 3f / 16f);
    this.Label10.Text = "Transaction";
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    this.Label11.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label11.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj12 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label11).Location = pointF12;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(33f / 16f, 3f / 16f);
    this.Label11.Text = "LOB";
    this.Label12.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label12.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj13 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label12).Location = pointF13;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(0.875f, 3f / 16f);
    this.Label12.Text = "Amount";
    this.Label13.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    this.Label13.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label13.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj14 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) label13).Location = pointF14;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(0.875f, 3f / 16f);
    this.Label13.Text = "Net Billed";
    this.Label14.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    this.Label14.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label14.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label14.HyperLink = (string) null;
    Label label14 = this.Label14;
    object obj15 = componentResourceManager.GetObject("Label14.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) label14).Location = pointF15;
    ((ARControl) this.Label14).Name = "Label14";
    ((ARControl) this.Label14).Size = new SizeF(0.875f, 3f / 16f);
    this.Label14.Text = "Remitter Comm";
    this.Label15.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 0;
    this.Label15.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label15.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label15.HyperLink = (string) null;
    Label label15 = this.Label15;
    object obj16 = componentResourceManager.GetObject("Label15.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) label15).Location = pointF16;
    ((ARControl) this.Label15).Name = "Label15";
    ((ARControl) this.Label15).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label15.Text = "Remitter %";
    this.Label16.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 0;
    this.Label16.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label16.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label16.HyperLink = (string) null;
    Label label16 = this.Label16;
    object obj17 = componentResourceManager.GetObject("Label16.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) label16).Location = pointF17;
    ((ARControl) this.Label16).Name = "Label16";
    ((ARControl) this.Label16).Size = new SizeF(0.875f, 3f / 16f);
    this.Label16.Text = "Gross Comm";
    this.Label17.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.TopStyle = (BorderLineStyle) 0;
    this.Label17.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label17.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label17.HyperLink = (string) null;
    Label label17 = this.Label17;
    object obj18 = componentResourceManager.GetObject("Label17.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) label17).Location = pointF18;
    ((ARControl) this.Label17).Name = "Label17";
    ((ARControl) this.Label17).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label17.Text = "Gross %";
    this.Label18.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.TopStyle = (BorderLineStyle) 0;
    this.Label18.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label18.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label18.HyperLink = (string) null;
    Label label18 = this.Label18;
    object obj19 = componentResourceManager.GetObject("Label18.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) label18).Location = pointF19;
    ((ARControl) this.Label18).Name = "Label18";
    ((ARControl) this.Label18).Size = new SizeF(0.875f, 3f / 16f);
    this.Label18.Text = "MGA Comm";
    this.Label19.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label19).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.TopStyle = (BorderLineStyle) 0;
    this.Label19.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label19.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label19.HyperLink = (string) null;
    Label label19 = this.Label19;
    object obj20 = componentResourceManager.GetObject("Label19.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) label19).Location = pointF20;
    ((ARControl) this.Label19).Name = "Label19";
    ((ARControl) this.Label19).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label19.Text = "MGA %";
    ((ARControl) this.Label20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label20).Border.TopStyle = (BorderLineStyle) 0;
    this.Label20.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label20.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label20.HyperLink = (string) null;
    Label label20 = this.Label20;
    object obj21 = componentResourceManager.GetObject("Label20.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) label20).Location = pointF21;
    ((ARControl) this.Label20).Name = "Label20";
    ((ARControl) this.Label20).Size = new SizeF(1.75f, 3f / 16f);
    this.Label20.Text = "Charge";
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj22 = componentResourceManager.GetObject("Label.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) label).Location = pointF22;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label.Text = "State";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "OfficeInvoiceNum";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj23 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) textBox1).Location = pointF23;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(0.875f, 3f / 16f);
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "InvoiceDate";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj24 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) textBox2).Location = pointF24;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox2).Size = new SizeF(0.625f, 3f / 16f);
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "EffectiveDate";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj25 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) textBox3).Location = pointF25;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox3).Size = new SizeF(0.625f, 3f / 16f);
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "ExpirationDate";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj26 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) textBox4).Location = pointF26;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox4).Size = new SizeF(0.625f, 3f / 16f);
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "PolicyNumber";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj27 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) textBox5).Location = pointF27;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = (string) null;
    ((ARControl) this.TextBox5).Size = new SizeF(19f / 16f, 3f / 16f);
    this.TextBox5.Text = " ";
    ((ARControl) this.TextBox6).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "InsuredPolicyName";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj28 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) textBox6).Location = pointF28;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = (string) null;
    ((ARControl) this.TextBox6).Size = new SizeF(2.5f, 3f / 16f);
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "ProducerName";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox7 = this.TextBox7;
    object obj29 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) textBox7).Location = pointF29;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = (string) null;
    ((ARControl) this.TextBox7).Size = new SizeF(2.5f, 3f / 16f);
    this.TextBox7.Text = " ";
    ((ARControl) this.TextBox8).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).DataField = "Carrier";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox8 = this.TextBox8;
    object obj30 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) textBox8).Location = pointF30;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = (string) null;
    ((ARControl) this.TextBox8).Size = new SizeF(2.5f, 3f / 16f);
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox9).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).DataField = "ControlNo";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox9.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox9 = this.TextBox9;
    object obj31 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) textBox9).Location = pointF31;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = (string) null;
    ((ARControl) this.TextBox9).Size = new SizeF(0.625f, 3f / 16f);
    this.TextBox9.Text = " ";
    ((ARControl) this.TextBox10).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).DataField = "TransactionType";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox10.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox10 = this.TextBox10;
    object obj32 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF32 = obj32 != null ? (PointF) obj32 : new PointF();
    ((ARControl) textBox10).Location = pointF32;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = (string) null;
    ((ARControl) this.TextBox10).Size = new SizeF(25f / 16f, 3f / 16f);
    this.TextBox10.Text = " ";
    ((ARControl) this.TextBox11).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).DataField = "LineName";
    this.TextBox11.DistinctField = (string) null;
    this.TextBox11.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox11.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox11 = this.TextBox11;
    object obj33 = componentResourceManager.GetObject("TextBox11.Location");
    PointF pointF33 = obj33 != null ? (PointF) obj33 : new PointF();
    ((ARControl) textBox11).Location = pointF33;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = (string) null;
    ((ARControl) this.TextBox11).Size = new SizeF(33f / 16f, 3f / 16f);
    this.TextBox11.Text = " ";
    this.TextBox12.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).DataField = "Amount";
    this.TextBox12.DistinctField = (string) null;
    this.TextBox12.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox12.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox12 = this.TextBox12;
    object obj34 = componentResourceManager.GetObject("TextBox12.Location");
    PointF pointF34 = obj34 != null ? (PointF) obj34 : new PointF();
    ((ARControl) textBox12).Location = pointF34;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox12).Size = new SizeF(0.875f, 3f / 16f);
    this.TextBox12.Text = " ";
    this.TextBox13.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox13).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox13).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox13).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox13).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox13).DataField = "AmtBilled";
    this.TextBox13.DistinctField = (string) null;
    this.TextBox13.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox13.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox13 = this.TextBox13;
    object obj35 = componentResourceManager.GetObject("TextBox13.Location");
    PointF pointF35 = obj35 != null ? (PointF) obj35 : new PointF();
    ((ARControl) textBox13).Location = pointF35;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox13).Size = new SizeF(0.875f, 3f / 16f);
    this.TextBox13.Text = " ";
    this.TextBox14.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox14).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).DataField = "RemitterAmt";
    this.TextBox14.DistinctField = (string) null;
    this.TextBox14.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox14.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox14 = this.TextBox14;
    object obj36 = componentResourceManager.GetObject("TextBox14.Location");
    PointF pointF36 = obj36 != null ? (PointF) obj36 : new PointF();
    ((ARControl) textBox14).Location = pointF36;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox14).Size = new SizeF(0.875f, 3f / 16f);
    this.TextBox14.Text = " ";
    this.TextBox15.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox15).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox15).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox15).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox15).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox15).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox15).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox15).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox15).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox15).DataField = "RemitterPercentRate";
    this.TextBox15.DistinctField = (string) null;
    this.TextBox15.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox15.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox15 = this.TextBox15;
    object obj37 = componentResourceManager.GetObject("TextBox15.Location");
    PointF pointF37 = obj37 != null ? (PointF) obj37 : new PointF();
    ((ARControl) textBox15).Location = pointF37;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    ((ARControl) this.TextBox15).Size = new SizeF(11f / 16f, 3f / 16f);
    this.TextBox15.Text = " ";
    this.TextBox16.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox16).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox16).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox16).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox16).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).DataField = "GrossAmt";
    this.TextBox16.DistinctField = (string) null;
    this.TextBox16.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox16.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox16 = this.TextBox16;
    object obj38 = componentResourceManager.GetObject("TextBox16.Location");
    PointF pointF38 = obj38 != null ? (PointF) obj38 : new PointF();
    ((ARControl) textBox16).Location = pointF38;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox16).Size = new SizeF(0.875f, 3f / 16f);
    this.TextBox16.Text = " ";
    this.TextBox17.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox17).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).DataField = "GrossAmtRate";
    this.TextBox17.DistinctField = (string) null;
    this.TextBox17.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox17.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox17 = this.TextBox17;
    object obj39 = componentResourceManager.GetObject("TextBox17.Location");
    PointF pointF39 = obj39 != null ? (PointF) obj39 : new PointF();
    ((ARControl) textBox17).Location = pointF39;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    ((ARControl) this.TextBox17).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox17.Text = " ";
    this.TextBox18.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox18).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox18).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox18).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox18).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox18).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox18).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox18).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox18).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox18).DataField = "MGAAmt";
    this.TextBox18.DistinctField = (string) null;
    this.TextBox18.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox18.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox18 = this.TextBox18;
    object obj40 = componentResourceManager.GetObject("TextBox18.Location");
    PointF pointF40 = obj40 != null ? (PointF) obj40 : new PointF();
    ((ARControl) textBox18).Location = pointF40;
    ((ARControl) this.TextBox18).Name = "TextBox18";
    this.TextBox18.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox18).Size = new SizeF(0.875f, 3f / 16f);
    this.TextBox18.Text = " ";
    this.TextBox19.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox19).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).DataField = "MGAPercentRate";
    this.TextBox19.DistinctField = (string) null;
    this.TextBox19.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox19.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox19 = this.TextBox19;
    object obj41 = componentResourceManager.GetObject("TextBox19.Location");
    PointF pointF41 = obj41 != null ? (PointF) obj41 : new PointF();
    ((ARControl) textBox19).Location = pointF41;
    ((ARControl) this.TextBox19).Name = "TextBox19";
    ((ARControl) this.TextBox19).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox19.Text = " ";
    ((ARControl) this.LineName1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.LineName1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.LineName1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.LineName1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.LineName1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.LineName1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.LineName1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.LineName1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.LineName1).DataField = "ChargeName";
    this.LineName1.DistinctField = (string) null;
    this.LineName1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.LineName1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox lineName1 = this.LineName1;
    object obj42 = componentResourceManager.GetObject("LineName1.Location");
    PointF pointF42 = obj42 != null ? (PointF) obj42 : new PointF();
    ((ARControl) lineName1).Location = pointF42;
    ((ARControl) this.LineName1).Name = "LineName1";
    this.LineName1.OutputFormat = (string) null;
    ((ARControl) this.LineName1).Size = new SizeF(1.75f, 3f / 16f);
    this.LineName1.Text = " ";
    ((ARControl) this.TextBox).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).DataField = "State";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj43 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF43 = obj43 != null ? (PointF) obj43 : new PointF();
    ((ARControl) textBox).Location = pointF43;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox.Text = " ";
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 25f;
    this.PageSettings.PaperName = "Custom paper";
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 24.19792f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.Label19).EndInit();
    ((ISupportInitialize) this.Label20).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.TextBox17).EndInit();
    ((ISupportInitialize) this.TextBox18).EndInit();
    ((ISupportInitialize) this.TextBox19).EndInit();
    ((ISupportInitialize) this.LineName1).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
  }

  private ArrayList GetParams()
  {
    ArrayList arrayList = new ArrayList();
    if (DateTime.Compare(this._billingDateFrom, DateTime.MinValue) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@BillingDateFrom",
        (object) this._billingDateFrom
      });
    if (DateTime.Compare(this._billingDateTo, DateTime.MinValue) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@BillingDateTo",
        (object) this._billingDateTo
      });
    if (DateTime.Compare(this._effectiveDateFrom, DateTime.MinValue) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@EffectiveDateFrom",
        (object) this._effectiveDateFrom
      });
    if (DateTime.Compare(this._effectiveDateTo, DateTime.MinValue) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@EffectiveDateTo",
        (object) this._effectiveDateTo
      });
    if (!this._underwriterGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@underwriterGuid",
        (object) this._underwriterGuid
      });
    if (!this._inhouseProducerGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@inHouseProducerGuid",
        (object) this._inhouseProducerGuid
      });
    if (this._producerGuids.Length > 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@producerGuids",
        (object) this._producerGuids
      });
    if (!this._companyGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@companyGuid",
        (object) this._companyGuid
      });
    if (!this._companyLocationGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@companyLocationGuid",
        (object) this._companyLocationGuid
      });
    if (!this._lineGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@lineGuid",
        (object) this._lineGuid
      });
    if (this._policyTypeID != -1)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@policyTypeID",
        (object) this._policyTypeID
      });
    if (this._issuingOfficeID != -1)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@IssuingOfficeID",
        (object) this._issuingOfficeID
      });
    if (this._State.Length > 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@StateOfIssuance",
        (object) this._State
      });
    switch (this._Show)
    {
      case 1:
        arrayList.AddRange((ICollection) new object[2]
        {
          (object) "@ShowPremium",
          (object) 1
        });
        arrayList.AddRange((ICollection) new object[2]
        {
          (object) "@ShowFees",
          (object) 0
        });
        break;
      case 2:
        arrayList.AddRange((ICollection) new object[2]
        {
          (object) "@ShowPremium",
          (object) 0
        });
        arrayList.AddRange((ICollection) new object[2]
        {
          (object) "@ShowFees",
          (object) 1
        });
        break;
    }
    return arrayList;
  }

  private void rptInvoiceBreakdown_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this._dt = DefaultDatabase.ExecuteDataTable(nameof (rptInvoiceBreakdown), this.GetParams().ToArray());
    this.DataSource = (object) new DataView(this._dt, "", this._SortBy, DataViewRowState.CurrentRows);
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dt, SaveFileTo);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[13]
      {
        (BaseReportControl) new DateRangePicker("Billing Date", true),
        (BaseReportControl) new DateRangePicker("Effective Date", true),
        (BaseReportControl) new States("State Of Issuance", true),
        (BaseReportControl) new GenericComboBox("Show", 125, 125, typeof (int), new object[6]
        {
          (object) "Premium and Fees",
          (object) 0,
          (object) "Premium",
          (object) 1,
          (object) "Fees",
          (object) 2
        }),
        (BaseReportControl) (!SecurityManager.Instance.AssertPermission("{C5F8AC88-2124-42c0-8E5C-F214BA9B6772}") ? new Underwriters("Underwriter", this.CurrentUserGuid) : new Underwriters("Underwriter", true)),
        (BaseReportControl) new Underwriters("Inhouse Producer", true),
        (BaseReportControl) new Producers_Multi("Producer(s)", true),
        (BaseReportControl) new GenericComboBox("Policy Type", "(SELECT -1 AS PolicyTypeID, 'All Types' AS Description, -1 AS SORT) UNION (SELECT PolicyTypeID, Description, 0 AS SORT FROM lstPolicyTypes) ORDER BY SORT, Description", "PolicyTypeID", "Description", typeof (int)),
        (BaseReportControl) new Companies("Company", true, new Guid[0]),
        (BaseReportControl) new CompanyLocations("Company Location", true, 500),
        (BaseReportControl) new CompanyLines("Line", true),
        (BaseReportControl) (!SecurityManager.Instance.AssertPermission("{C5F8AC88-2124-42c0-8E5C-F214BA9B6772}") ? new OfficeLocations("Issuing Office", this.CurrentUserGuid, true) : new OfficeLocations("Issuing Office", true, true)),
        (BaseReportControl) new OrderBy(new string[40]
        {
          "Invoice #",
          "OfficeInvoiceNum",
          "Billed",
          "InvoiceDate",
          "Effective Date",
          "EffectiveDate",
          "Expiration Date",
          "ExpirationDate",
          "Policy #",
          "PolicyNumber",
          "Insured",
          "InsuredPolicyName",
          "Producer",
          "ProducerName",
          "Carrier",
          "Carrier",
          "Control #",
          "ControlNo",
          "Transaction",
          "TransactionType",
          "LOB",
          "LineName",
          "Charge",
          "ChargeName",
          "Amount",
          "Amount",
          "Net Billed",
          "AmtBilled",
          "Remitter Comm",
          "RemitterAmt",
          "Remitter %",
          "RemitterPercentRate",
          "Gross Comm",
          "GrossAmt",
          "Gross %",
          "GrossAmtRate",
          "MGA Comm",
          "MGAAmt",
          "MGA%",
          "MGAPercentRate"
        })
      };
    }
  }
}
