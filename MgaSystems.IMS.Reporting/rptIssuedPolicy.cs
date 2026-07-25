// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptIssuedPolicy
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{B2696831-3019-4d3d-8D81-0E05F2EF0D84}", "Issued Policy Report", "Shows policies based on a date range and company location", "General")]
public class rptIssuedPolicy : MGAReport, IReport
{
  private Label lblTitle;
  private TextBox TextBox;
  private TextBox TextBox1;
  private Label Label7;
  private Label Label2;
  private Label Label6;
  private Label Label3;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private Label Label4;
  private Label Label5;
  private Label Label;
  private TextBox TextBox5;
  private TextBox TextBox4;
  private TextBox Issued;
  private TextBox BusinessType1;
  private TextBox BusinessType;
  private TextBox TextBox3;
  private TextBox Insured;
  private TextBox TextBox2;
  private TextBox PolicyNum;
  private TextBox TextBox6;
  private readonly DateTime _FromDate;
  private readonly DateTime _ToDate;
  private readonly Guid _CompanyLocationGuid;

  [field: AccessedThroughProperty("TextBox7")]
  private virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptIssuedPolicy()
  {
    this.ReportStart += new EventHandler(this.rptIssuedPolicy_ReportStart);
    this.InitializeComponent();
  }

  public rptIssuedPolicy(Guid CompanyLocationGuid, DateTime FromDate, DateTime ToDate)
  {
    this.ReportStart += new EventHandler(this.rptIssuedPolicy_ReportStart);
    this.InitializeComponent();
    this._FromDate = FromDate;
    this._ToDate = ToDate;
    this._CompanyLocationGuid = CompanyLocationGuid;
    this.TextBox1.Text = $"{this._FromDate.ToShortDateString()} - {this._ToDate.ToShortDateString()}";
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptIssuedPolicy));
    this.Detail = new Detail();
    this.TextBox5 = new TextBox();
    this.TextBox4 = new TextBox();
    this.Issued = new TextBox();
    this.BusinessType1 = new TextBox();
    this.BusinessType = new TextBox();
    this.TextBox3 = new TextBox();
    this.Insured = new TextBox();
    this.TextBox2 = new TextBox();
    this.PolicyNum = new TextBox();
    this.TextBox6 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.lblTitle = new Label();
    this.TextBox = new TextBox();
    this.TextBox1 = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.Label7 = new Label();
    this.Label2 = new Label();
    this.Label6 = new Label();
    this.Label3 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label = new Label();
    this.PageFooter = new PageFooter();
    this.TextBox7 = new TextBox();
    this.Label1 = new Label();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.Issued).BeginInit();
    ((ISupportInitialize) this.BusinessType1).BeginInit();
    ((ISupportInitialize) this.BusinessType).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.Insured).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.PolicyNum).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox4,
      (ARControl) this.Issued,
      (ARControl) this.BusinessType1,
      (ARControl) this.BusinessType,
      (ARControl) this.TextBox3,
      (ARControl) this.Insured,
      (ARControl) this.TextBox2,
      (ARControl) this.PolicyNum,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1145833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "EffectiveDate";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox5 = this.TextBox5;
    object obj1 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) textBox5).Location = pointF1;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox5).Size = new SizeF(0.75f, 0.125f);
    this.TextBox5.Text = " ";
    this.TextBox5.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "DateSubmitted";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox4 = this.TextBox4;
    object obj2 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) textBox4).Location = pointF2;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox4).Size = new SizeF(0.75f, 0.125f);
    this.TextBox4.Text = " ";
    this.TextBox4.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.Issued).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Issued).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Issued).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Issued).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Issued).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Issued).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Issued).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Issued).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Issued).DataField = "DateIssued";
    this.Issued.DistinctField = (string) null;
    this.Issued.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox issued = this.Issued;
    object obj3 = componentResourceManager.GetObject("Issued.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) issued).Location = pointF3;
    ((ARControl) this.Issued).Name = "Issued";
    this.Issued.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.Issued).Size = new SizeF(0.75f, 0.125f);
    this.Issued.Text = " ";
    this.Issued.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.BusinessType1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.BusinessType1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.BusinessType1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.BusinessType1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.BusinessType1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.BusinessType1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.BusinessType1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.BusinessType1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.BusinessType1).DataField = "Description";
    this.BusinessType1.DistinctField = (string) null;
    this.BusinessType1.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox businessType1 = this.BusinessType1;
    object obj4 = componentResourceManager.GetObject("BusinessType1.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) businessType1).Location = pointF4;
    ((ARControl) this.BusinessType1).Name = "BusinessType1";
    this.BusinessType1.OutputFormat = (string) null;
    ((ARControl) this.BusinessType1).Size = new SizeF(15f / 16f, 0.125f);
    this.BusinessType1.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.BusinessType).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.BusinessType).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.BusinessType).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.BusinessType).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.BusinessType).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.BusinessType).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.BusinessType).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.BusinessType).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.BusinessType).DataField = "BusinessType";
    this.BusinessType.DistinctField = (string) null;
    this.BusinessType.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox businessType = this.BusinessType;
    object obj5 = componentResourceManager.GetObject("BusinessType.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) businessType).Location = pointF5;
    ((ARControl) this.BusinessType).Name = "BusinessType";
    this.BusinessType.OutputFormat = (string) null;
    ((ARControl) this.BusinessType).Size = new SizeF(13f / 16f, 0.125f);
    this.BusinessType.Text = " ";
    this.BusinessType.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "Underwriter";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox3 = this.TextBox3;
    object obj6 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) textBox3).Location = pointF6;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(19f / 16f, 0.125f);
    this.TextBox3.Text = " ";
    this.TextBox3.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.Insured).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured).DataField = "InsuredPolicyName";
    this.Insured.DistinctField = (string) null;
    this.Insured.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox insured = this.Insured;
    object obj7 = componentResourceManager.GetObject("Insured.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) insured).Location = pointF7;
    ((ARControl) this.Insured).Name = "Insured";
    this.Insured.OutputFormat = (string) null;
    ((ARControl) this.Insured).Size = new SizeF(1.375f, 0.125f);
    this.Insured.Text = " ";
    this.Insured.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "ProducerName";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox2 = this.TextBox2;
    object obj8 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox2).Location = pointF8;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(1.3745f, 0.125f);
    this.TextBox2.Text = " ";
    this.TextBox2.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.PolicyNum).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.PolicyNum).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.PolicyNum).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.PolicyNum).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.PolicyNum).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.PolicyNum).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.PolicyNum).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.PolicyNum).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.PolicyNum).DataField = "PolicyNumber";
    this.PolicyNum.DistinctField = (string) null;
    this.PolicyNum.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox policyNum = this.PolicyNum;
    object obj9 = componentResourceManager.GetObject("PolicyNum.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) policyNum).Location = pointF9;
    ((ARControl) this.PolicyNum).Name = "PolicyNum";
    this.PolicyNum.OutputFormat = (string) null;
    ((ARControl) this.PolicyNum).Size = new SizeF(17f / 16f, 0.125f);
    this.PolicyNum.Text = (string) null;
    this.PolicyNum.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "DateBound";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox6 = this.TextBox6;
    object obj10 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox6).Location = pointF10;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox6).Size = new SizeF(11f / 16f, 0.125f);
    this.TextBox6.VerticalAlignment = (VerticalTextAlignment) 1;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.lblTitle,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox1
    });
    this.ReportHeader.Height = 0.7604167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    this.lblTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.lblTitle.Font = new Font("Arial", 14f);
    this.lblTitle.HyperLink = (string) null;
    Label lblTitle = this.lblTitle;
    object obj11 = componentResourceManager.GetObject("lblTitle.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) lblTitle).Location = pointF11;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    ((ARControl) this.lblTitle).Size = new SizeF(10.4f, 0.25f);
    this.lblTitle.Text = "Issued Policy Report";
    this.TextBox.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox = this.TextBox;
    object obj12 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) textBox).Location = pointF12;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(10.4f, 0.2f);
    this.TextBox.Text = (string) null;
    this.TextBox1.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj13 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox1).Location = pointF13;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(10.4f, 0.2f);
    this.TextBox1.Text = (string) null;
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.Label7,
      (ARControl) this.Label2,
      (ARControl) this.Label6,
      (ARControl) this.Label3,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label,
      (ARControl) this.Label1
    });
    this.PageHeader.Height = 0.1770833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj14 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) label7).Location = pointF14;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(17f / 16f, 3f / 16f);
    this.Label7.Text = "Policy #";
    this.Label7.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj15 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) label2).Location = pointF15;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1.375f, 3f / 16f);
    this.Label2.Text = "Producer";
    this.Label2.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj16 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) label6).Location = pointF16;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(1.375f, 3f / 16f);
    this.Label6.Text = "Insured";
    this.Label6.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj17 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) label3).Location = pointF17;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(19f / 16f, 3f / 16f);
    this.Label3.Text = "Underwriter";
    this.Label3.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj18 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) label8).Location = pointF18;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label8.Text = "Business Type";
    this.Label8.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj19 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) label9).Location = pointF19;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(0.875f, 3f / 16f);
    this.Label9.Text = "Status";
    this.Label9.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj20 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) label10).Location = pointF20;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(0.75f, 3f / 16f);
    this.Label10.Text = "Issued";
    this.Label10.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj21 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) label4).Location = pointF21;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(0.75f, 3f / 16f);
    this.Label4.Text = "Submitted";
    this.Label4.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj22 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) label5).Location = pointF22;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(0.75f, 0.188f);
    this.Label5.Text = "Effective";
    this.Label5.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj23 = componentResourceManager.GetObject("Label.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) label).Location = pointF23;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label.Text = "Bound Date";
    this.Label.VerticalAlignment = (VerticalTextAlignment) 2;
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "DateCreated";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox7 = this.TextBox7;
    object obj24 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) textBox7).Location = pointF24;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = "M/d/yyyy";
    ((ARControl) this.TextBox7).Size = new SizeF(11f / 16f, 0.125f);
    this.TextBox7.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj25 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) label1).Location = pointF25;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(0.75f, 3f / 16f);
    this.Label1.Text = "Date Created";
    this.Label1.VerticalAlignment = (VerticalTextAlignment) 2;
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
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.Issued).EndInit();
    ((ISupportInitialize) this.BusinessType1).EndInit();
    ((ISupportInitialize) this.BusinessType).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.Insured).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.PolicyNum).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
  }

  private void rptIssuedPolicy_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Format += new EventHandler(this.Detail_Format);
    this.TextBox.Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "Select LocationName From tblCompanyLocations WHERE CompanyLocationGuid = @CompanyLocationGuid", new object[2]
    {
      (object) "@CompanyLocationGuid",
      (object) this._CompanyLocationGuid
    });
    this.DataSource = (object) DefaultDatabase.ExecuteDataTable(nameof (rptIssuedPolicy), new object[6]
    {
      (object) "@FromDate",
      (object) this._FromDate,
      (object) "@ToDate",
      (object) this._ToDate,
      (object) "@CompanyLocationGuid",
      (object) this._CompanyLocationGuid
    });
  }

  private void Detail_Format(object sender, EventArgs e) => this.SetDetailControlsHeight();

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new CompanyLocations("Location", false, 420),
        (BaseReportControl) new DateRangePicker("Date Range", false)
      };
    }
  }

  public override bool IsThreaded => true;
}
