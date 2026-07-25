// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptHitRatio
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
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{AD904992-11B5-4c1d-ACFA-1B7EBDAA7553}", "Hit Ratio", "Shows premiums, submissions, quotes, binders and ratios on per quoting location.", "General")]
public class rptHitRatio : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{AD904992-11B5-4c1d-ACFA-1B7EBDAA7553}";
  private Label lblTitle;
  private TextBox txtOffice;
  private Label Label13;
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
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private readonly Guid _companyGuid;
  private readonly string _producerGuids;
  private readonly Guid _underwriterGuid;
  private readonly Guid _lineOfBusiness;
  private readonly bool _IncludeProducers;

  [field: AccessedThroughProperty("Label14")]
  private virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  private virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox10")]
  private virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  private virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptHitRatio() => this.ReportStart += new EventHandler(this.rptHitRatio_ReportStart);

  public rptHitRatio(
    Guid CompanyGuid,
    string ProducerGuids,
    Guid UnderwriterGuid,
    Guid LineOfBusiness)
  {
    this.ReportStart += new EventHandler(this.rptHitRatio_ReportStart);
    this.InitializeComponent();
    this._companyGuid = CompanyGuid;
    this._producerGuids = ProducerGuids;
    this._underwriterGuid = UnderwriterGuid;
    this._lineOfBusiness = LineOfBusiness;
  }

  public rptHitRatio(
    Guid CompanyGuid,
    string ProducerGuids,
    bool IncludeProducers,
    Guid UnderwriterGuid,
    Guid LineOfBusiness)
  {
    this.ReportStart += new EventHandler(this.rptHitRatio_ReportStart);
    this.InitializeComponent();
    this._companyGuid = CompanyGuid;
    this._producerGuids = ProducerGuids;
    this._underwriterGuid = UnderwriterGuid;
    this._lineOfBusiness = LineOfBusiness;
    this._IncludeProducers = IncludeProducers;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptHitRatio));
    this.Detail = new Detail();
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
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.lblTitle = new Label();
    this.ReportFooter = new ReportFooter();
    this.GroupHeader1 = new GroupHeader();
    this.txtOffice = new TextBox();
    this.Label13 = new Label();
    this.GroupFooter1 = new GroupFooter();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
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
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.txtOffice).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[25]
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
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.Label14,
      (ARControl) this.Label15,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 4.009722f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj1 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label1).Location = pointF1;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(33f / 16f, 3f / 16f);
    this.Label1.Text = "Total Premium Quoted:";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj2 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label2).Location = pointF2;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(33f / 16f, 3f / 16f);
    this.Label2.Text = "Average Premium Bound:";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj3 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label3).Location = pointF3;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(33f / 16f, 3f / 16f);
    this.Label3.Text = "Average Premium Issued:";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj4 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label4).Location = pointF4;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(33f / 16f, 3f / 16f);
    this.Label4.Text = "# Of Submissions:";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj5 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label5).Location = pointF5;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(33f / 16f, 3f / 16f);
    this.Label5.Text = "# Of Quotes:";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj6 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label6).Location = pointF6;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(33f / 16f, 3f / 16f);
    this.Label6.Text = "# Of Binders:";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj7 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label7).Location = pointF7;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(33f / 16f, 3f / 16f);
    this.Label7.Text = "Quote to Binder Hit Ratio:";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj8 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label8).Location = pointF8;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(33f / 16f, 3f / 16f);
    this.Label8.Text = "Submission to Quote Hit Ratio:";
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj9 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label9).Location = pointF9;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(33f / 16f, 3f / 16f);
    this.Label9.Text = "Submission to Binder Hit Ratio:";
    ((ARControl) this.Label10).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj10 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label10).Location = pointF10;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(7.5f, 3f / 16f);
    this.Label10.Text = "Premium Summary";
    ((ARControl) this.Label11).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    this.Label11.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj11 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label11).Location = pointF11;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(7.5f, 3f / 16f);
    this.Label11.Text = "Volume Summary";
    ((ARControl) this.Label12).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj12 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label12).Location = pointF12;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(7.5f, 3f / 16f);
    this.Label12.Text = "Ratio Summary";
    this.TextBox1.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "TotalPremiumQuoted";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj13 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox1).Location = pointF13;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox1).Size = new SizeF(1.75f, 3f / 16f);
    this.TextBox1.Text = " ";
    this.TextBox2.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "AveragePremiumBound";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox2 = this.TextBox2;
    object obj14 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox2).Location = pointF14;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox2).Size = new SizeF(1.75f, 3f / 16f);
    this.TextBox2.Text = " ";
    this.TextBox3.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "AveragePremiumIssued";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox3 = this.TextBox3;
    object obj15 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox3).Location = pointF15;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox3).Size = new SizeF(1.75f, 3f / 16f);
    this.TextBox3.Text = " ";
    this.TextBox4.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "NumberOfSubmissions";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox4 = this.TextBox4;
    object obj16 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) textBox4).Location = pointF16;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "#,##0";
    ((ARControl) this.TextBox4).Size = new SizeF(1.75f, 3f / 16f);
    this.TextBox4.Text = " ";
    this.TextBox5.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "NumberOfBinders";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox5 = this.TextBox5;
    object obj17 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox5).Location = pointF17;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "#,##0";
    ((ARControl) this.TextBox5).Size = new SizeF(1.75f, 3f / 16f);
    this.TextBox5.Text = " ";
    this.TextBox6.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "NumberOfQuotes";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox6 = this.TextBox6;
    object obj18 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox6).Location = pointF18;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = "#,##0";
    ((ARControl) this.TextBox6).Size = new SizeF(1.75f, 3f / 16f);
    this.TextBox6.Text = " ";
    this.TextBox7.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "QuoteToBinderHitRatio";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox7 = this.TextBox7;
    object obj19 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) textBox7).Location = pointF19;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = "0.00%";
    ((ARControl) this.TextBox7).Size = new SizeF(1.75f, 3f / 16f);
    this.TextBox7.Text = " ";
    this.TextBox8.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "SubmissionToQuoteHitRatio";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox8 = this.TextBox8;
    object obj20 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) textBox8).Location = pointF20;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = "0.00%";
    ((ARControl) this.TextBox8).Size = new SizeF(1.75f, 3f / 16f);
    this.TextBox8.Text = " ";
    this.TextBox9.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "SubmissionToBinderHitRatio";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox9 = this.TextBox9;
    object obj21 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox9).Location = pointF21;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = "0.00%";
    ((ARControl) this.TextBox9).Size = new SizeF(1.75f, 3f / 16f);
    this.TextBox9.Text = " ";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.lblTitle
    });
    this.ReportHeader.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    this.lblTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.lblTitle.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTitle.HyperLink = (string) null;
    Label lblTitle = this.lblTitle;
    object obj22 = componentResourceManager.GetObject("lblTitle.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) lblTitle).Location = pointF22;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    ((ARControl) this.lblTitle).Size = new SizeF(7.875f, 0.25f);
    this.lblTitle.Text = "Hit Ratio Report";
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtOffice,
      (ARControl) this.Label13
    });
    this.GroupHeader1.Height = 11f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((ARControl) this.txtOffice).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOffice).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOffice).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOffice).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOffice).DataField = "Title";
    this.txtOffice.DistinctField = (string) null;
    this.txtOffice.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtOffice = this.txtOffice;
    object obj23 = componentResourceManager.GetObject("txtOffice.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) txtOffice).Location = pointF23;
    ((ARControl) this.txtOffice).Name = "txtOffice";
    this.txtOffice.OutputFormat = (string) null;
    ((ARControl) this.txtOffice).Size = new SizeF(6.25f, 3f / 16f);
    this.txtOffice.Text = (string) null;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    this.Label13.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj24 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) label13).Location = pointF24;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(1f, 3f / 16f);
    this.Label13.Text = "Results for:";
    this.GroupFooter1.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    this.Label14.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label14.HyperLink = (string) null;
    Label label14 = this.Label14;
    object obj25 = componentResourceManager.GetObject("Label14.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) label14).Location = pointF25;
    ((ARControl) this.Label14).Name = "Label14";
    ((ARControl) this.Label14).Size = new SizeF(33f / 16f, 3f / 16f);
    this.Label14.Text = "Total Premium Bound:";
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 0;
    this.Label15.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label15.HyperLink = (string) null;
    Label label15 = this.Label15;
    object obj26 = componentResourceManager.GetObject("Label15.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) label15).Location = pointF26;
    ((ARControl) this.Label15).Name = "Label15";
    ((ARControl) this.Label15).Size = new SizeF(33f / 16f, 3f / 16f);
    this.Label15.Text = "Total Premium Issued:";
    this.TextBox10.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "TotalPremiumBound";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox10 = this.TextBox10;
    object obj27 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) textBox10).Location = pointF27;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox10).Size = new SizeF(1.75f, 3f / 16f);
    this.TextBox10.Text = " ";
    this.TextBox11.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "TotalPremiumIssued";
    this.TextBox11.DistinctField = (string) null;
    this.TextBox11.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox11 = this.TextBox11;
    object obj28 = componentResourceManager.GetObject("TextBox11.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) textBox11).Location = pointF28;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox11).Size = new SizeF(1.75f, 3f / 16f);
    this.TextBox11.Text = " ";
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
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
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.txtOffice).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
  }

  private void rptHitRatio_ReportStart(object sender, EventArgs e)
  {
    ArrayList arrayList = new ArrayList();
    if (!this._companyGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@CompanyGuid",
        (object) this._companyGuid
      });
    if (this._producerGuids.Length > 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@ProducerGuids",
        (object) this._producerGuids
      });
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@IncludeProducers",
      Interaction.IIf(this._IncludeProducers, (object) 1, (object) 0)
    });
    if (!this._underwriterGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@UnderwriterGuid",
        (object) this._underwriterGuid
      });
    if (!this._lineOfBusiness.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@LineGuid",
        (object) this._lineOfBusiness
      });
    if (SystemSettings.KeyExists("CheckQuotingOfficeGuid") && SystemSettings.GetBoolSetting("CheckQuotingOfficeGuid") && !this.CurrentUserGuid.Equals((object) string.Empty))
    {
      arrayList.Add((object) "@CurrentUserGuid");
      arrayList.Add((object) this.CurrentUserGuid);
    }
    this.DataSource = (object) DefaultDatabase.ExecuteDataTable(nameof (rptHitRatio), arrayList.ToArray());
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[4]
      {
        (BaseReportControl) new Companies("Company", true, new Guid[0]),
        (BaseReportControl) new Producers_Multi_Ex("Producer(s)"),
        (BaseReportControl) new Underwriters("Underwriter", true),
        (BaseReportControl) new CompanyLines("Company Line", true)
      };
    }
  }
}
