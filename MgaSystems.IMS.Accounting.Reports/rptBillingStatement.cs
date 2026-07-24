// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptBillingStatement
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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{6B6BD1A2-3196-44e6-AE07-0AECA924AF74}", "Billing Statement", "Billing Statement Report.", "General")]
public sealed class rptBillingStatement : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{6B6BD1A2-3196-44e6-AE07-0AECA924AF74}";
  private Guid _OfficeLocationGuid;
  private Guid _CompanyLocationGuid;
  private Guid _ProducerGuid;
  private DateTime _datFrom;
  private DateTime _datTo;
  private Label lblCompany;
  private Label Label1;
  private Label lblDate;
  private Label lblCompanyNetDue;
  private Label Label7;
  private Label Label9;
  private Label Label14;
  private Label Label17;
  private Label Label18;
  private Label Label22;
  private Label Label23;
  private Label Label13;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label15;
  private Label Label20;
  private Label Label21;
  private Label lblInsured;
  private TextBox TextBox27;
  private TextBox TextBox6;
  private TextBox TextBox8;
  private TextBox TextBox17;
  private TextBox TextBox21;
  private TextBox TextBox22;
  private TextBox txtAmountPaid;
  private TextBox TextBox16;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox15;
  private TextBox TextBox18;
  private TextBox TextBox26;
  private TextBox txtDueDate;
  private CheckBox CheckBox1;
  private Line Line2;
  private Label Label11;
  private TextBox TextBox11;
  private TextBox TextBox13;
  private TextBox TextBox23;
  private TextBox TextBox28;
  private TextBox txtAmountPaidTotal;
  private Line Line1;

  public rptBillingStatement()
  {
    this.ReportStart += new EventHandler(this.rptMonthlyReconciliation_ReportStart);
  }

  public rptBillingStatement(
    Guid OfficeLocationGUID,
    Guid CompanyLocationGuid,
    Guid ProducerGuid,
    DateTime datFrom,
    DateTime datTo)
  {
    this.ReportStart += new EventHandler(this.rptMonthlyReconciliation_ReportStart);
    this.InitializeComponent();
    this._datFrom = datFrom;
    this._datTo = datTo;
    this._OfficeLocationGuid = OfficeLocationGUID;
    this._CompanyLocationGuid = CompanyLocationGuid;
    this._ProducerGuid = ProducerGuid;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptBillingStatement));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.lblCompany = new Label();
    this.Label1 = new Label();
    this.lblDate = new Label();
    this.lblCompanyNetDue = new Label();
    this.Label7 = new Label();
    this.Label9 = new Label();
    this.Label14 = new Label();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.Label22 = new Label();
    this.Label23 = new Label();
    this.Label13 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label15 = new Label();
    this.Label20 = new Label();
    this.Label21 = new Label();
    this.lblInsured = new Label();
    this.TextBox27 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox17 = new TextBox();
    this.TextBox21 = new TextBox();
    this.TextBox22 = new TextBox();
    this.txtAmountPaid = new TextBox();
    this.TextBox16 = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox15 = new TextBox();
    this.TextBox18 = new TextBox();
    this.TextBox26 = new TextBox();
    this.txtDueDate = new TextBox();
    this.CheckBox1 = new CheckBox();
    this.Line2 = new Line();
    this.Label11 = new Label();
    this.TextBox11 = new TextBox();
    this.TextBox13 = new TextBox();
    this.TextBox23 = new TextBox();
    this.TextBox28 = new TextBox();
    this.txtAmountPaidTotal = new TextBox();
    this.Line1 = new Line();
    ((ISupportInitialize) this.lblCompany).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.lblDate).BeginInit();
    ((ISupportInitialize) this.lblCompanyNetDue).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.Label22).BeginInit();
    ((ISupportInitialize) this.Label23).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label20).BeginInit();
    ((ISupportInitialize) this.Label21).BeginInit();
    ((ISupportInitialize) this.lblInsured).BeginInit();
    ((ISupportInitialize) this.TextBox27).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox17).BeginInit();
    ((ISupportInitialize) this.TextBox21).BeginInit();
    ((ISupportInitialize) this.TextBox22).BeginInit();
    ((ISupportInitialize) this.txtAmountPaid).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.TextBox18).BeginInit();
    ((ISupportInitialize) this.TextBox26).BeginInit();
    ((ISupportInitialize) this.txtDueDate).BeginInit();
    ((ISupportInitialize) this.CheckBox1).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.TextBox23).BeginInit();
    ((ISupportInitialize) this.TextBox28).BeginInit();
    ((ISupportInitialize) this.txtAmountPaidTotal).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[19]
    {
      (ARControl) this.TextBox27,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox17,
      (ARControl) this.TextBox21,
      (ARControl) this.TextBox22,
      (ARControl) this.txtAmountPaid,
      (ARControl) this.TextBox16,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox15,
      (ARControl) this.TextBox18,
      (ARControl) this.TextBox26,
      (ARControl) this.txtDueDate,
      (ARControl) this.CheckBox1,
      (ARControl) this.Line2
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.5f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.lblCompany,
      (ARControl) this.Label1,
      (ARControl) this.lblDate
    });
    this.ReportHeader.Height = 0.6666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[18]
    {
      (ARControl) this.lblCompanyNetDue,
      (ARControl) this.Label7,
      (ARControl) this.Label9,
      (ARControl) this.Label14,
      (ARControl) this.Label17,
      (ARControl) this.Label18,
      (ARControl) this.Label22,
      (ARControl) this.Label23,
      (ARControl) this.Label13,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label15,
      (ARControl) this.Label20,
      (ARControl) this.Label21,
      (ARControl) this.lblInsured
    });
    this.PageHeader.Height = 0.5201389f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.GroupHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.Label11,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox13,
      (ARControl) this.TextBox23,
      (ARControl) this.TextBox28,
      (ARControl) this.txtAmountPaidTotal,
      (ARControl) this.Line1
    });
    this.GroupFooter1.Height = 0.2291667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.lblCompany.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblCompany).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCompany).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCompany).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCompany).Border.TopStyle = (BorderLineStyle) 0;
    this.lblCompany.Font = new Font("Arial", 12f);
    this.lblCompany.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblCompany.HyperLink = (string) null;
    Label lblCompany = this.lblCompany;
    object obj1 = componentResourceManager.GetObject("lblCompany.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) lblCompany).Location = pointF1;
    ((ARControl) this.lblCompany).Name = "lblCompany";
    ((ARControl) this.lblCompany).Size = new SizeF(7.875f, 0.25f);
    this.lblCompany.Text = "[Company]";
    this.Label1.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 10f);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj2 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label1).Location = pointF2;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(7.875f, 3f / 16f);
    this.Label1.Text = "Billing Statement";
    this.lblDate.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.TopStyle = (BorderLineStyle) 0;
    this.lblDate.Font = new Font("Arial", 10f);
    this.lblDate.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblDate.HyperLink = (string) null;
    Label lblDate = this.lblDate;
    object obj3 = componentResourceManager.GetObject("lblDate.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) lblDate).Location = pointF3;
    ((ARControl) this.lblDate).Name = "lblDate";
    ((ARControl) this.lblDate).Size = new SizeF(7.875f, 3f / 16f);
    this.lblDate.Text = "Month Ending";
    this.lblCompanyNetDue.Alignment = (TextAlignment) 2;
    this.lblCompanyNetDue.BackColor = Color.WhiteSmoke;
    ((ARControl) this.lblCompanyNetDue).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblCompanyNetDue).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.lblCompanyNetDue).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblCompanyNetDue).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblCompanyNetDue).Border.TopStyle = (BorderLineStyle) 0;
    this.lblCompanyNetDue.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCompanyNetDue.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblCompanyNetDue.HyperLink = (string) null;
    Label lblCompanyNetDue = this.lblCompanyNetDue;
    object obj4 = componentResourceManager.GetObject("lblCompanyNetDue.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) lblCompanyNetDue).Location = pointF4;
    ((ARControl) this.lblCompanyNetDue).Name = "lblCompanyNetDue";
    ((ARControl) this.lblCompanyNetDue).Size = new SizeF(27f / 16f, 0.25f);
    this.lblCompanyNetDue.Text = "Net Due [Company]";
    this.lblCompanyNetDue.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label7.Alignment = (TextAlignment) 2;
    this.Label7.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj5 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label7).Location = pointF5;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(0.75f, 0.25f);
    this.Label7.Text = "Premium";
    this.Label7.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label9.Alignment = (TextAlignment) 2;
    this.Label9.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj6 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label9).Location = pointF6;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(0.625f, 0.25f);
    this.Label9.Text = "Fees";
    this.Label9.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label14.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    this.Label14.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label14.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label14.HyperLink = (string) null;
    Label label14 = this.Label14;
    object obj7 = componentResourceManager.GetObject("Label14.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label14).Location = pointF7;
    ((ARControl) this.Label14).Name = "Label14";
    ((ARControl) this.Label14).Size = new SizeF(9f / 16f, 0.25f);
    this.Label14.Text = "Transaction";
    this.Label14.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label17.Alignment = (TextAlignment) 2;
    this.Label17.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label17).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label17).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label17).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Border.TopStyle = (BorderLineStyle) 0;
    this.Label17.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label17.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label17.HyperLink = (string) null;
    Label label17 = this.Label17;
    object obj8 = componentResourceManager.GetObject("Label17.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label17).Location = pointF8;
    ((ARControl) this.Label17).Name = "Label17";
    ((ARControl) this.Label17).Size = new SizeF(7f / 16f, 0.25f);
    this.Label17.Text = "Comm %";
    this.Label17.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label18.Alignment = (TextAlignment) 2;
    this.Label18.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label18).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label18).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label18).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Border.TopStyle = (BorderLineStyle) 0;
    this.Label18.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label18.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label18.HyperLink = (string) null;
    Label label18 = this.Label18;
    object obj9 = componentResourceManager.GetObject("Label18.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label18).Location = pointF9;
    ((ARControl) this.Label18).Name = "Label18";
    ((ARControl) this.Label18).Size = new SizeF(13f / 16f, 0.25f);
    this.Label18.Text = "Producer Comm";
    this.Label18.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label22.Alignment = (TextAlignment) 1;
    this.Label22.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label22).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label22).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label22).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label22).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label22).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label22).Border.TopStyle = (BorderLineStyle) 0;
    this.Label22.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label22.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label22.HyperLink = (string) null;
    Label label22 = this.Label22;
    object obj10 = componentResourceManager.GetObject("Label22.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label22).Location = pointF10;
    ((ARControl) this.Label22).Name = "Label22";
    ((ARControl) this.Label22).Size = new SizeF(9f / 16f, 0.25f);
    this.Label22.Text = "Printed";
    this.Label22.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label23.Alignment = (TextAlignment) 2;
    this.Label23.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label23).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label23).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label23).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label23).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label23).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label23).Border.TopStyle = (BorderLineStyle) 0;
    this.Label23.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label23.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label23.HyperLink = (string) null;
    Label label23 = this.Label23;
    object obj11 = componentResourceManager.GetObject("Label23.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label23).Location = pointF11;
    ((ARControl) this.Label23).Name = "Label23";
    ((ARControl) this.Label23).Size = new SizeF(0.75f, 0.25f);
    this.Label23.Text = "Amount Paid";
    this.Label23.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label13.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    this.Label13.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label13.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj12 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label13).Location = pointF12;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(9f / 16f, 0.25f);
    this.Label13.Text = "Billing";
    this.Label13.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label2.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 1;
    this.Label2.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj13 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label2).Location = pointF13;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1.125f, 3f / 16f);
    this.Label2.Text = "Agency Acctg MO";
    this.Label2.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label3.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 1;
    this.Label3.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj14 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) label3).Location = pointF14;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(19f / 16f, 3f / 16f);
    this.Label3.Text = "Policy #";
    this.Label3.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label4.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label4).Border.BottomColor = Color.FromArgb(0, 0, 0);
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 1;
    this.Label4.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj15 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) label4).Location = pointF15;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(7f / 16f, 0.25f);
    this.Label4.Text = "End #";
    this.Label4.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label5.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 1;
    this.Label5.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj16 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) label5).Location = pointF16;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label5.Text = "Effective";
    this.Label5.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label6.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 1;
    this.Label6.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj17 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) label6).Location = pointF17;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label6.Text = "Expiration";
    this.Label6.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label15.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label15).Border.BottomColor = Color.FromArgb(0, 0, 0);
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label15).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label15).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label15).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 1;
    this.Label15.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label15.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label15.HyperLink = (string) null;
    Label label15 = this.Label15;
    object obj18 = componentResourceManager.GetObject("Label15.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) label15).Location = pointF18;
    ((ARControl) this.Label15).Name = "Label15";
    ((ARControl) this.Label15).Size = new SizeF(11f / 16f, 0.25f);
    this.Label15.Text = "Type";
    this.Label15.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label20.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label20).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label20).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label20).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label20).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label20).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label20).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label20).Border.TopStyle = (BorderLineStyle) 1;
    this.Label20.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label20.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label20.HyperLink = (string) null;
    Label label20 = this.Label20;
    object obj19 = componentResourceManager.GetObject("Label20.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) label20).Location = pointF19;
    ((ARControl) this.Label20).Name = "Label20";
    ((ARControl) this.Label20).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label20.Text = "Invoice #";
    this.Label20.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label21.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label21).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label21).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label21).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label21).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label21).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label21).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label21).Border.TopStyle = (BorderLineStyle) 1;
    this.Label21.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label21.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label21.HyperLink = (string) null;
    Label label21 = this.Label21;
    object obj20 = componentResourceManager.GetObject("Label21.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) label21).Location = pointF20;
    ((ARControl) this.Label21).Name = "Label21";
    ((ARControl) this.Label21).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label21.Text = "Due";
    this.Label21.VerticalAlignment = (VerticalTextAlignment) 2;
    this.lblInsured.BackColor = Color.WhiteSmoke;
    ((ARControl) this.lblInsured).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.lblInsured).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblInsured).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.lblInsured).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblInsured).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.lblInsured).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblInsured).Border.TopStyle = (BorderLineStyle) 1;
    this.lblInsured.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblInsured.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblInsured.HyperLink = (string) null;
    Label lblInsured = this.lblInsured;
    object obj21 = componentResourceManager.GetObject("lblInsured.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) lblInsured).Location = pointF21;
    ((ARControl) this.lblInsured).Name = "lblInsured";
    ((ARControl) this.lblInsured).Size = new SizeF(53f / 16f, 3f / 16f);
    this.lblInsured.Text = "Insured";
    this.lblInsured.VerticalAlignment = (VerticalTextAlignment) 2;
    this.TextBox27.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox27).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox27).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox27).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox27).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox27).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox27).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox27).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox27).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox27).DataField = "CompanyNetDue";
    this.TextBox27.DistinctField = (string) null;
    this.TextBox27.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox27.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox27 = this.TextBox27;
    object obj22 = componentResourceManager.GetObject("TextBox27.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) textBox27).Location = pointF22;
    ((ARControl) this.TextBox27).Name = "TextBox27";
    this.TextBox27.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox27).Size = new SizeF(27f / 16f, 3f / 16f);
    this.TextBox27.VerticalAlignment = (VerticalTextAlignment) 2;
    this.TextBox6.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "Premium";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj23 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) textBox6).Location = pointF23;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox6).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox6.VerticalAlignment = (VerticalTextAlignment) 2;
    this.TextBox8.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).DataField = "PayableFees";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox8 = this.TextBox8;
    object obj24 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) textBox8).Location = pointF24;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox8).Size = new SizeF(0.625f, 3f / 16f);
    this.TextBox8.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.TextBox17).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox17).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox17).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).DataField = "TransactionDate";
    this.TextBox17.DistinctField = (string) null;
    this.TextBox17.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox17.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox17 = this.TextBox17;
    object obj25 = componentResourceManager.GetObject("TextBox17.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) textBox17).Location = pointF25;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox17).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox17.VerticalAlignment = (VerticalTextAlignment) 2;
    this.TextBox21.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox21).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox21).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).DataField = "CommPercent";
    this.TextBox21.DistinctField = (string) null;
    this.TextBox21.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox21.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox21 = this.TextBox21;
    object obj26 = componentResourceManager.GetObject("TextBox21.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) textBox21).Location = pointF26;
    ((ARControl) this.TextBox21).Name = "TextBox21";
    this.TextBox21.OutputFormat = "###0.00%;(###0.00%)";
    ((ARControl) this.TextBox21).Size = new SizeF(7f / 16f, 3f / 16f);
    this.TextBox21.VerticalAlignment = (VerticalTextAlignment) 2;
    this.TextBox22.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox22).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox22).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox22).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox22).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox22).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox22).DataField = "ProducerComm";
    this.TextBox22.DistinctField = (string) null;
    this.TextBox22.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox22.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox22 = this.TextBox22;
    object obj27 = componentResourceManager.GetObject("TextBox22.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) textBox22).Location = pointF27;
    ((ARControl) this.TextBox22).Name = "TextBox22";
    this.TextBox22.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox22).Size = new SizeF(13f / 16f, 3f / 16f);
    this.TextBox22.VerticalAlignment = (VerticalTextAlignment) 2;
    this.txtAmountPaid.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtAmountPaid).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.txtAmountPaid).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtAmountPaid).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtAmountPaid).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtAmountPaid).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtAmountPaid).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtAmountPaid).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtAmountPaid).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtAmountPaid).DataField = "AmountPaid";
    this.txtAmountPaid.DistinctField = (string) null;
    this.txtAmountPaid.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtAmountPaid.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtAmountPaid = this.txtAmountPaid;
    object obj28 = componentResourceManager.GetObject("txtAmountPaid.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) txtAmountPaid).Location = pointF28;
    ((ARControl) this.txtAmountPaid).Name = "txtAmountPaid";
    this.txtAmountPaid.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtAmountPaid).Size = new SizeF(0.75f, 3f / 16f);
    this.txtAmountPaid.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.TextBox16).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox16).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox16).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox16).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).DataField = "InvoiceDate";
    this.TextBox16.DistinctField = (string) null;
    this.TextBox16.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox16.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox16 = this.TextBox16;
    object obj29 = componentResourceManager.GetObject("TextBox16.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) textBox16).Location = pointF29;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox16).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox16.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "TransactionDate";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj30 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) textBox1).Location = pointF30;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "MMM-yy";
    ((ARControl) this.TextBox1).Size = new SizeF(1.125f, 3f / 16f);
    this.TextBox1.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "PolicyNumber";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj31 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) textBox2).Location = pointF31;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(19f / 16f, 3f / 16f);
    this.TextBox2.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "EndorsementNum";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj32 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF32 = obj32 != null ? (PointF) obj32 : new PointF();
    ((ARControl) textBox3).Location = pointF32;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(7f / 16f, 3f / 16f);
    this.TextBox3.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "EffectiveDate";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj33 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF33 = obj33 != null ? (PointF) obj33 : new PointF();
    ((ARControl) textBox4).Location = pointF33;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox4).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox4.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "ExpirationDate";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj34 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF34 = obj34 != null ? (PointF) obj34 : new PointF();
    ((ARControl) textBox5).Location = pointF34;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox5).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox5.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.TextBox15).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox15).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox15).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox15).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox15).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox15).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox15).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox15).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox15).DataField = "Insured";
    this.TextBox15.DistinctField = (string) null;
    this.TextBox15.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox15.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox15 = this.TextBox15;
    object obj35 = componentResourceManager.GetObject("TextBox15.Location");
    PointF pointF35 = obj35 != null ? (PointF) obj35 : new PointF();
    ((ARControl) textBox15).Location = pointF35;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.OutputFormat = (string) null;
    ((ARControl) this.TextBox15).Size = new SizeF(53f / 16f, 3f / 16f);
    this.TextBox15.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.TextBox18).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox18).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox18).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox18).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox18).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox18).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox18).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox18).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox18).DataField = "TransactionType";
    this.TextBox18.DistinctField = (string) null;
    this.TextBox18.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox18.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox18 = this.TextBox18;
    object obj36 = componentResourceManager.GetObject("TextBox18.Location");
    PointF pointF36 = obj36 != null ? (PointF) obj36 : new PointF();
    ((ARControl) textBox18).Location = pointF36;
    ((ARControl) this.TextBox18).Name = "TextBox18";
    this.TextBox18.OutputFormat = (string) null;
    ((ARControl) this.TextBox18).Size = new SizeF(11f / 16f, 3f / 16f);
    this.TextBox18.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.TextBox26).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox26).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox26).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox26).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox26).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox26).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox26).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox26).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox26).DataField = "OfficeInvoiceNum";
    this.TextBox26.DistinctField = (string) null;
    this.TextBox26.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox26.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox26 = this.TextBox26;
    object obj37 = componentResourceManager.GetObject("TextBox26.Location");
    PointF pointF37 = obj37 != null ? (PointF) obj37 : new PointF();
    ((ARControl) textBox26).Location = pointF37;
    ((ARControl) this.TextBox26).Name = "TextBox26";
    this.TextBox26.OutputFormat = (string) null;
    ((ARControl) this.TextBox26).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox26.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.txtDueDate).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDueDate).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDueDate).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDueDate).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDueDate).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDueDate).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDueDate).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.txtDueDate).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDueDate).DataField = "DueDate";
    this.txtDueDate.DistinctField = (string) null;
    this.txtDueDate.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtDueDate.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtDueDate = this.txtDueDate;
    object obj38 = componentResourceManager.GetObject("txtDueDate.Location");
    PointF pointF38 = obj38 != null ? (PointF) obj38 : new PointF();
    ((ARControl) txtDueDate).Location = pointF38;
    ((ARControl) this.txtDueDate).Name = "txtDueDate";
    this.txtDueDate.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtDueDate).Size = new SizeF(9f / 16f, 3f / 16f);
    this.txtDueDate.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.CheckBox1).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.CheckBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.CheckBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.CheckBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.CheckBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.CheckBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.CheckBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.CheckBox1).Border.TopStyle = (BorderLineStyle) 1;
    this.CheckBox1.CheckAlignment = ContentAlignment.MiddleCenter;
    ((ARControl) this.CheckBox1).DataField = "Printed";
    this.CheckBox1.Font = new Font("Arial", 6.75f);
    this.CheckBox1.ForeColor = Color.FromArgb(0, 0, 0);
    CheckBox checkBox1 = this.CheckBox1;
    object obj39 = componentResourceManager.GetObject("CheckBox1.Location");
    PointF pointF39 = obj39 != null ? (PointF) obj39 : new PointF();
    ((ARControl) checkBox1).Location = pointF39;
    ((ARControl) this.CheckBox1).Name = "CheckBox1";
    ((ARControl) this.CheckBox1).Size = new SizeF(9f / 16f, 3f / 16f);
    this.CheckBox1.Text = "";
    this.Line2.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line2.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line2.Border.RightStyle = (BorderLineStyle) 0;
    this.Line2.Border.TopStyle = (BorderLineStyle) 0;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    this.Line2.X1 = 0.0f;
    this.Line2.X2 = 7.875f;
    this.Line2.Y1 = 7f / 16f;
    this.Line2.Y2 = 7f / 16f;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    this.Label11.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label11.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj40 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF40 = obj40 != null ? (PointF) obj40 : new PointF();
    ((ARControl) label11).Location = pointF40;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(1f, 0.125f);
    this.Label11.Text = "Grand Totals";
    this.TextBox11.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "Premium";
    this.TextBox11.DistinctField = (string) null;
    this.TextBox11.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox11.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox11 = this.TextBox11;
    object obj41 = componentResourceManager.GetObject("TextBox11.Location");
    PointF pointF41 = obj41 != null ? (PointF) obj41 : new PointF();
    ((ARControl) textBox11).Location = pointF41;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox11).Size = new SizeF(0.75f, 0.125f);
    this.TextBox11.SummaryGroup = "GroupHeader1";
    this.TextBox11.SummaryRunning = (SummaryRunning) 1;
    this.TextBox11.SummaryType = (SummaryType) 1;
    this.TextBox11.Text = " ";
    this.TextBox13.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "PayableFees";
    this.TextBox13.DistinctField = (string) null;
    this.TextBox13.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox13.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox13 = this.TextBox13;
    object obj42 = componentResourceManager.GetObject("TextBox13.Location");
    PointF pointF42 = obj42 != null ? (PointF) obj42 : new PointF();
    ((ARControl) textBox13).Location = pointF42;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox13).Size = new SizeF(0.625f, 0.125f);
    this.TextBox13.SummaryGroup = "GroupHeader1";
    this.TextBox13.SummaryRunning = (SummaryRunning) 1;
    this.TextBox13.SummaryType = (SummaryType) 1;
    this.TextBox13.Text = " ";
    this.TextBox23.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox23).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).DataField = "ProducerComm";
    this.TextBox23.DistinctField = (string) null;
    this.TextBox23.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox23.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox23 = this.TextBox23;
    object obj43 = componentResourceManager.GetObject("TextBox23.Location");
    PointF pointF43 = obj43 != null ? (PointF) obj43 : new PointF();
    ((ARControl) textBox23).Location = pointF43;
    ((ARControl) this.TextBox23).Name = "TextBox23";
    this.TextBox23.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox23).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox23.SummaryGroup = "GroupHeader1";
    this.TextBox23.SummaryRunning = (SummaryRunning) 2;
    this.TextBox23.SummaryType = (SummaryType) 1;
    this.TextBox28.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox28).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).DataField = "CompanyNetDue";
    this.TextBox28.DistinctField = (string) null;
    this.TextBox28.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox28.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox28 = this.TextBox28;
    object obj44 = componentResourceManager.GetObject("TextBox28.Location");
    PointF pointF44 = obj44 != null ? (PointF) obj44 : new PointF();
    ((ARControl) textBox28).Location = pointF44;
    ((ARControl) this.TextBox28).Name = "TextBox28";
    this.TextBox28.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox28).Size = new SizeF(27f / 16f, 0.125f);
    this.TextBox28.SummaryGroup = "GroupHeader1";
    this.TextBox28.SummaryRunning = (SummaryRunning) 1;
    this.TextBox28.SummaryType = (SummaryType) 1;
    this.TextBox28.Text = " ";
    this.txtAmountPaidTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtAmountPaidTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmountPaidTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmountPaidTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmountPaidTotal).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmountPaidTotal).DataField = "AmountPaid";
    this.txtAmountPaidTotal.DistinctField = (string) null;
    this.txtAmountPaidTotal.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtAmountPaidTotal.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtAmountPaidTotal = this.txtAmountPaidTotal;
    object obj45 = componentResourceManager.GetObject("txtAmountPaidTotal.Location");
    PointF pointF45 = obj45 != null ? (PointF) obj45 : new PointF();
    ((ARControl) txtAmountPaidTotal).Location = pointF45;
    ((ARControl) this.txtAmountPaidTotal).Name = "txtAmountPaidTotal";
    this.txtAmountPaidTotal.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtAmountPaidTotal).Size = new SizeF(0.75f, 0.125f);
    this.txtAmountPaidTotal.SummaryGroup = "GroupHeader1";
    this.txtAmountPaidTotal.SummaryRunning = (SummaryRunning) 1;
    this.txtAmountPaidTotal.SummaryType = (SummaryType) 1;
    this.txtAmountPaidTotal.Text = " ";
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    this.Line1.X1 = 1.125f;
    this.Line1.X2 = 1.125f;
    this.Line1.Y1 = 0.0f;
    this.Line1.Y2 = 0.0f;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperName = "";
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.lblCompany).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.lblDate).EndInit();
    ((ISupportInitialize) this.lblCompanyNetDue).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.Label22).EndInit();
    ((ISupportInitialize) this.Label23).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label20).EndInit();
    ((ISupportInitialize) this.Label21).EndInit();
    ((ISupportInitialize) this.lblInsured).EndInit();
    ((ISupportInitialize) this.TextBox27).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox17).EndInit();
    ((ISupportInitialize) this.TextBox21).EndInit();
    ((ISupportInitialize) this.TextBox22).EndInit();
    ((ISupportInitialize) this.txtAmountPaid).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.TextBox18).EndInit();
    ((ISupportInitialize) this.TextBox26).EndInit();
    ((ISupportInitialize) this.txtDueDate).EndInit();
    ((ISupportInitialize) this.CheckBox1).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.TextBox23).EndInit();
    ((ISupportInitialize) this.TextBox28).EndInit();
    ((ISupportInitialize) this.txtAmountPaidTotal).EndInit();
  }

  private void rptMonthlyReconciliation_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.lblCompany.Text = Database.Instance.QueryText.PerformScalarQuery($"SELECT TOP 1 Location FROM tblClientOffices WHERE OfficeGUID = '{this._OfficeLocationGuid.ToString()}'").ToString();
    this.lblDate.Text = $"Report from {this._datFrom.ToShortDateString()} to {this._datTo.ToShortDateString()}";
    SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    DataTable dataTable = new DataTable();
    try
    {
      selectCommand.CommandText = "[spFin_rptBillingStatement]";
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.CommandTimeout = 0;
      selectCommand.Connection = sqlConnection;
      selectCommand.Parameters.AddWithValue("@OfficeLocationGuid", (object) this._OfficeLocationGuid);
      if (!this._CompanyLocationGuid.Equals(Guid.Empty))
        selectCommand.Parameters.AddWithValue("@CompanyLocationGuid", (object) this._CompanyLocationGuid);
      if (!this._ProducerGuid.Equals(Guid.Empty))
        selectCommand.Parameters.AddWithValue("@ProducerGuid", (object) this._ProducerGuid);
      selectCommand.Parameters.AddWithValue("@datFrom", (object) this._datFrom);
      selectCommand.Parameters.AddWithValue("@datTo", (object) this._datTo);
      sqlDataAdapter.Fill(dataTable);
      dataTable.Columns.Add("PremiumDue", typeof (Decimal));
      dataTable.Columns.Add("CommPercent", typeof (Decimal));
      dataTable.Columns.Add("ProducerComm", typeof (Decimal));
      dataTable.Columns.Add("CompanyNetDue", typeof (Decimal));
      try
      {
        foreach (DataRow row in dataTable.Rows)
        {
          row["PremiumDue"] = (object) Decimal.Add(Decimal.Subtract(Conversions.ToDecimal(row["Premium"]), Conversions.ToDecimal(row["GrossComm"])), Conversions.ToDecimal(row["PayableFees"]));
          row["ProducerComm"] = (object) Decimal.Subtract(Conversions.ToDecimal(row["GrossComm"]), Conversions.ToDecimal(row["MGAComm"]));
          row["CommPercent"] = Decimal.Compare(Conversions.ToDecimal(row["Premium"]), 0M) != 0 ? (object) Decimal.Divide(Conversions.ToDecimal(row["ProducerComm"]), Conversions.ToDecimal(row["Premium"])) : (object) 0;
          row["CompanyNetDue"] = (object) Decimal.Add(Decimal.Subtract(Conversions.ToDecimal(row["Premium"]), Conversions.ToDecimal(row["ProducerComm"])), Conversions.ToDecimal(row["PayableFees"]));
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.DataSource = (object) new DataView(dataTable, "", "OfficeInvoiceNum", DataViewRowState.CurrentRows);
    }
    finally
    {
      sqlConnection.Close();
      sqlConnection.Dispose();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
      dataTable.Dispose();
    }
    this.ShowPageNumbers();
    this.ShowPrintDateAndTime();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      BaseReportControl[] getReportControls = new BaseReportControl[4]
      {
        (BaseReportControl) new AccountingOfficeLocations("Office", false),
        (BaseReportControl) new CompanyLocations("Company", true),
        (BaseReportControl) new Producers("Producer", true),
        null
      };
      DateTime now = DateAndTime.Now;
      DateTime date1 = now.Date;
      now = DateAndTime.Now;
      DateTime date2 = now.Date;
      getReportControls[3] = (BaseReportControl) new DateRangePicker("Invoice Date", date1, date2, false);
      return getReportControls;
    }
  }

  private void PageHeader_BeforePrint(object sender, EventArgs e)
  {
    this.lblCompanyNetDue.Text = "Net Due " + this.lblCompany.Text;
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual PageHeader PageHeader
  {
    get => this._PageHeader;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PageHeader_BeforePrint);
      PageHeader pageHeader1 = this._PageHeader;
      if (pageHeader1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) pageHeader1).BeforePrint -= eventHandler;
      this._PageHeader = value;
      PageHeader pageHeader2 = this._PageHeader;
      if (pageHeader2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) pageHeader2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
