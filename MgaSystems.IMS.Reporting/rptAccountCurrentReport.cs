// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptAccountCurrentReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{5C3D9FE1-1A53-44cb-AB4F-E424F18707A9}", "Account Current Report", "Shows accounts by client office and billing date range.", "General")]
public class rptAccountCurrentReport : MGAReport, IReport
{
  private Guid _OfficeGuid;
  private DateTime _BillingDateFrom;
  private DateTime _BillingDateTo;
  private DateTime _EffectiveDateFrom;
  private DateTime _EffectiveDateTo;
  private DateTime _DueDateFrom;
  private DateTime _DueDateTo;
  private Guid _entityGuid;
  private string _BillingTypes;
  private Label Label7;
  private TextBox txtClientOffice;
  private TextBox txtDateRange;
  private TextBox txtCompanies;
  private Label Label;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label8;
  private Label Label9;
  private TextBox TextBox;
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
  private Label Label10;

  public rptAccountCurrentReport()
  {
    this.ReportStart += new EventHandler(this.rptAccountCurrentReport_ReportStart);
    this.InitializeComponent();
  }

  public rptAccountCurrentReport(
    Guid OfficeGuid,
    DateTime BillingDateFrom,
    DateTime BillingDateTo,
    DateTime EffectiveDateFrom,
    DateTime EffectiveDateTo,
    DateTime DueDateFrom,
    DateTime DueDateTo,
    Guid EntityGuid,
    string BillingTypes)
  {
    this.ReportStart += new EventHandler(this.rptAccountCurrentReport_ReportStart);
    this.InitializeComponent();
    this._OfficeGuid = OfficeGuid;
    this._BillingDateFrom = BillingDateFrom;
    this._BillingDateTo = BillingDateTo;
    this._EffectiveDateFrom = EffectiveDateFrom;
    this._EffectiveDateTo = EffectiveDateTo;
    this._DueDateFrom = DueDateFrom;
    this._DueDateTo = DueDateTo;
    this._entityGuid = EntityGuid;
    this._BillingTypes = BillingTypes;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptAccountCurrentReport));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.Label7 = new Label();
    this.txtClientOffice = new TextBox();
    this.txtDateRange = new TextBox();
    this.txtCompanies = new TextBox();
    this.Label = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.TextBox = new TextBox();
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
    this.Label10 = new Label();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.txtClientOffice).BeginInit();
    ((ISupportInitialize) this.txtDateRange).BeginInit();
    ((ISupportInitialize) this.txtCompanies).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
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
    ((ISupportInitialize) this.Label10).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.TextBox,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 3f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Label7,
      (ARControl) this.txtClientOffice,
      (ARControl) this.txtDateRange,
      (ARControl) this.txtCompanies
    });
    this.ReportHeader.Height = 1.353472f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.Label10
    });
    this.ReportFooter.Height = 0.1451389f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.Label,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label8,
      (ARControl) this.Label9
    });
    this.PageHeader.Height = 0.2909722f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.Label7.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 14f);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj1 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label7).Location = pointF1;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(7.875f, 0.25f);
    this.Label7.Text = "Account Current Report";
    this.txtClientOffice.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtClientOffice).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtClientOffice).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtClientOffice).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtClientOffice).Border.TopStyle = (BorderLineStyle) 0;
    this.txtClientOffice.DistinctField = (string) null;
    this.txtClientOffice.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtClientOffice.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtClientOffice = this.txtClientOffice;
    object obj2 = componentResourceManager.GetObject("txtClientOffice.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtClientOffice).Location = pointF2;
    ((ARControl) this.txtClientOffice).Name = "txtClientOffice";
    this.txtClientOffice.OutputFormat = (string) null;
    ((ARControl) this.txtClientOffice).Size = new SizeF(7.875f, 3f / 16f);
    this.txtDateRange.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtDateRange).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateRange).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateRange).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateRange).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDateRange.DistinctField = (string) null;
    this.txtDateRange.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtDateRange.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtDateRange = this.txtDateRange;
    object obj3 = componentResourceManager.GetObject("txtDateRange.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) txtDateRange).Location = pointF3;
    ((ARControl) this.txtDateRange).Name = "txtDateRange";
    this.txtDateRange.OutputFormat = (string) null;
    ((ARControl) this.txtDateRange).Size = new SizeF(7.875f, 3f / 16f);
    this.txtCompanies.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtCompanies).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompanies).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompanies).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompanies).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCompanies.DistinctField = (string) null;
    this.txtCompanies.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCompanies.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCompanies = this.txtCompanies;
    object obj4 = componentResourceManager.GetObject("txtCompanies.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) txtCompanies).Location = pointF4;
    ((ARControl) this.txtCompanies).Name = "txtCompanies";
    this.txtCompanies.OutputFormat = (string) null;
    ((ARControl) this.txtCompanies).Size = new SizeF(7.875f, 3f / 16f);
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj5 = componentResourceManager.GetObject("Label.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label).Location = pointF5;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(19f / 16f, 5f / 16f);
    this.Label.Text = "Policy Number";
    this.Label.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj6 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label1).Location = pointF6;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(27f / 16f, 5f / 16f);
    this.Label1.Text = "Named Insured";
    this.Label1.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj7 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label2).Location = pointF7;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(0.625f, 5f / 16f);
    this.Label2.Text = "Effective";
    this.Label2.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj8 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label3).Location = pointF8;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(0.625f, 5f / 16f);
    this.Label3.Text = "Expiration";
    this.Label3.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label4.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj9 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label4).Location = pointF9;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(0.75f, 5f / 16f);
    this.Label4.Text = "Company Commission";
    this.Label4.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label5.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj10 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label5).Location = pointF10;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(0.75f, 5f / 16f);
    this.Label5.Text = "Gross Premium";
    this.Label5.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label6.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj11 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label6).Location = pointF11;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(0.75f, 5f / 16f);
    this.Label6.Text = "Net Due Carrier";
    this.Label6.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label8.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj12 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label8).Location = pointF12;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(0.75f, 5f / 16f);
    this.Label8.Text = "Payable Fees";
    this.Label8.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label9.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj13 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label9).Location = pointF13;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(0.75f, 5f / 16f);
    this.Label9.Text = "Gross Commission";
    this.Label9.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.TextBox).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).DataField = "PolicyNumber";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj14 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox).Location = pointF14;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(19f / 16f, 0.125f);
    this.TextBox.Text = " ";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "InsuredPolicyName";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj15 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox1).Location = pointF15;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(27f / 16f, 0.125f);
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "EffectiveDate";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj16 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) textBox2).Location = pointF16;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox2).Size = new SizeF(0.625f, 0.125f);
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "ExpirationDate";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj17 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox3).Location = pointF17;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox3).Size = new SizeF(0.625f, 0.125f);
    this.TextBox3.Text = " ";
    this.TextBox4.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "CompanyCommission";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj18 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox4).Location = pointF18;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox4).Size = new SizeF(0.75f, 0.125f);
    this.TextBox4.Text = " ";
    this.TextBox5.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "PayableFees";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj19 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) textBox5).Location = pointF19;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox5).Size = new SizeF(0.75f, 0.125f);
    this.TextBox5.Text = " ";
    this.TextBox6.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "GrossCommission";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj20 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) textBox6).Location = pointF20;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox6).Size = new SizeF(0.75f, 0.125f);
    this.TextBox6.Text = " ";
    this.TextBox7.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "GrossPremium";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox7 = this.TextBox7;
    object obj21 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox7).Location = pointF21;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox7).Size = new SizeF(0.75f, 0.125f);
    this.TextBox7.Text = " ";
    this.TextBox8.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).DataField = "NetDueCarrier";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox8 = this.TextBox8;
    object obj22 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) textBox8).Location = pointF22;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox8).Size = new SizeF(0.75f, 0.125f);
    this.TextBox8.Text = " ";
    this.TextBox9.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).DataField = "NetDueCarrier";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox9.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox9 = this.TextBox9;
    object obj23 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) textBox9).Location = pointF23;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox9).Size = new SizeF(0.75f, 0.125f);
    this.TextBox9.SummaryRunning = (SummaryRunning) 2;
    this.TextBox9.SummaryType = (SummaryType) 1;
    this.TextBox9.Text = " ";
    this.TextBox10.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).DataField = "GrossCommission";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox10.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox10 = this.TextBox10;
    object obj24 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) textBox10).Location = pointF24;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox10).Size = new SizeF(0.75f, 0.125f);
    this.TextBox10.SummaryRunning = (SummaryRunning) 2;
    this.TextBox10.SummaryType = (SummaryType) 1;
    this.TextBox10.Text = " ";
    this.TextBox11.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).DataField = "PayableFees";
    this.TextBox11.DistinctField = (string) null;
    this.TextBox11.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox11.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox11 = this.TextBox11;
    object obj25 = componentResourceManager.GetObject("TextBox11.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) textBox11).Location = pointF25;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox11).Size = new SizeF(0.75f, 0.125f);
    this.TextBox11.SummaryRunning = (SummaryRunning) 2;
    this.TextBox11.SummaryType = (SummaryType) 1;
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
    ((ARControl) this.TextBox12).DataField = "GrossPremium";
    this.TextBox12.DistinctField = (string) null;
    this.TextBox12.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox12.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox12 = this.TextBox12;
    object obj26 = componentResourceManager.GetObject("TextBox12.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) textBox12).Location = pointF26;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox12).Size = new SizeF(0.75f, 0.125f);
    this.TextBox12.SummaryRunning = (SummaryRunning) 2;
    this.TextBox12.SummaryType = (SummaryType) 1;
    this.TextBox12.Text = " ";
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj27 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) label10).Location = pointF27;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(13f / 16f, 0.125f);
    this.Label10.Text = "Grand Totals:";
    this.Label10.VerticalAlignment = (VerticalTextAlignment) 1;
    this.PageSettings.Margins.Bottom = 0.5f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.txtClientOffice).EndInit();
    ((ISupportInitialize) this.txtDateRange).EndInit();
    ((ISupportInitialize) this.txtCompanies).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
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
    ((ISupportInitialize) this.Label10).EndInit();
  }

  private void rptAccountCurrentReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    if (!this._OfficeGuid.Equals(Guid.Empty))
      this.txtClientOffice.Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "select Location from tblClientOffices WITH (NOLOCK) where OfficeGuid=@OfficeGuid", new object[2]
      {
        (object) "@OfficeGuid",
        (object) this._OfficeGuid
      });
    else
      this.txtClientOffice.Text = "All Offices";
    this.txtDateRange.Text = $"{this._BillingDateFrom.ToString("MM/dd/yyyy")} - {this._BillingDateTo.ToString("MM/dd/yyyy")}";
    if (!this._entityGuid.Equals(Guid.Empty))
    {
      string Left = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.GetEntityType(@EG)", new object[2]
      {
        (object) "@EG",
        (object) this._entityGuid
      });
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "CO", false) == 0)
        this.txtCompanies.Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "select CompanyName from tblCompanies WITH (NOLOCK) where CompanyGuid=@CompanyGuid", new object[2]
        {
          (object) "@CompanyGuid",
          (object) this._entityGuid
        });
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "CL", false) == 0)
      {
        TextBox txtCompanies;
        string str = (txtCompanies = this.txtCompanies).Text + DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "select LocationName from tblCompanyLocations WITH (NOLOCK) where CompanyLocationGuid=@CompanyLocationGuid", new object[2]
        {
          (object) "@CompanyLocationGuid",
          (object) this._entityGuid
        });
        txtCompanies.Text = str;
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "CG", false) == 0)
        this.txtCompanies.Text = "CompanyGroup - " + DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "select CompanyGroupName from tblCompanyGroups WITH (NOLOCK) where CompanyGroupGUID=@CompanyGroupGuid", new object[2]
        {
          (object) "@CompanyGroupGuid",
          (object) this._entityGuid
        });
    }
    ArrayList arrayList = new ArrayList();
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@BillingDateFrom",
      (object) this._BillingDateFrom
    });
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@BillingDateTo",
      (object) this._BillingDateTo
    });
    if (!this._EffectiveDateFrom.Equals(DateTime.MinValue))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@EffectiveDateFrom",
        (object) this._EffectiveDateFrom
      });
    if (!this._EffectiveDateTo.Equals(DateTime.MinValue))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@EffectiveDateTo",
        (object) this._EffectiveDateTo
      });
    if (!this._DueDateFrom.Equals(DateTime.MinValue))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@DueDateFrom",
        (object) this._DueDateFrom
      });
    if (!this._DueDateTo.Equals(DateTime.MinValue))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@DueDateTo",
        (object) this._DueDateTo
      });
    if (!this._OfficeGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@OfficeGuid",
        (object) this._OfficeGuid
      });
    if (!this._entityGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@EntityGuid",
        (object) this._entityGuid
      });
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@BillingTypes",
      (object) this._BillingTypes
    });
    this.DataSource = (object) DefaultDatabase.ExecuteDataTable("rptAccountCurrent", arrayList.ToArray());
  }

  private void Detail_Format(object sender, EventArgs e) => this.SetDetailControlsHeight();

  public override bool IsThreaded => true;

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[6]
      {
        (BaseReportControl) new OfficeLocations("Office", true, false),
        (BaseReportControl) new DateRangePicker("Billing Date", false),
        (BaseReportControl) new DateRangePicker("Effective Date", true),
        (BaseReportControl) new DateRangePicker("Due Date", true),
        (BaseReportControl) new EntitySelection("Search Entity", false, true),
        (BaseReportControl) new BillingTypesListBox("Billing Types", true)
      };
    }
  }

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

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
