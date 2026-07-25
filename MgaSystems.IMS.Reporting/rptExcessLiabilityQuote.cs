// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptExcessLiabilityQuote
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.AutomationReports;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[AutomationReport("{F6F5769F-8C09-4148-8D15-1673D49EC71A}", Enums.AutomationDocGroups.PolicyDoc, "IMS Excess Liability Quote", "IMS quote document for excess liability.")]
public class rptExcessLiabilityQuote : SectionReport, IQuoteDocument
{
  private SubReport srHeader;
  private Label Label2;
  private TextBox TextBox10;
  private Label Label;
  private TextBox TextBox;
  private Label Label1;
  private TextBox TextBox1;
  private Label Label3;
  private TextBox TextBox2;
  private Label Label4;
  private Label Label5;
  private TextBox TextBox3;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private TextBox TextBox4;
  private Label Label11;
  private Label Label12;
  private TextBox TextBox5;
  private Label Label13;
  private Label Label14;
  private TextBox TextBox6;
  private Label Label15;
  private Label Label16;
  private SubReport srFooter;
  private Guid _QuoteOptionGuid;
  private rptCommonFooter1 _FooterReport;
  private rptCommonHeader1 _HeaderReport;

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptExcessLiabilityQuote()
  {
    this.ReportStart += new EventHandler(this.rptExcessLiabilityQuote_ReportStart);
    this.ReportEnd += new EventHandler(this.rptPropertyQuote_ReportEnd);
    this.InitializeComponent();
  }

  public rptExcessLiabilityQuote(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptExcessLiabilityQuote_ReportStart);
    this.ReportEnd += new EventHandler(this.rptPropertyQuote_ReportEnd);
    this.InitializeComponent();
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptExcessLiabilityQuote));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.srHeader = new SubReport();
    this.Label2 = new Label();
    this.TextBox10 = new TextBox();
    this.Label = new Label();
    this.TextBox = new TextBox();
    this.Label1 = new Label();
    this.TextBox1 = new TextBox();
    this.Label3 = new Label();
    this.TextBox2 = new TextBox();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.TextBox3 = new TextBox();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.TextBox4 = new TextBox();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.TextBox5 = new TextBox();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.TextBox6 = new TextBox();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.srFooter = new SubReport();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[25]
    {
      (ARControl) this.Label2,
      (ARControl) this.TextBox10,
      (ARControl) this.Label,
      (ARControl) this.TextBox,
      (ARControl) this.Label1,
      (ARControl) this.TextBox1,
      (ARControl) this.Label3,
      (ARControl) this.TextBox2,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.TextBox3,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.TextBox4,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.TextBox5,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.TextBox6,
      (ARControl) this.Label15,
      (ARControl) this.Label16
    });
    ((Section) this.Detail).Height = 1.927083f;
    ((Section) this.Detail).Name = "Detail";
    ((Section) this.ReportHeader).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srHeader
    });
    this.ReportHeader.Height = 0.05138889f;
    ((Section) this.ReportHeader).Name = "ReportHeader";
    ((Section) this.ReportFooter).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srFooter
    });
    this.ReportFooter.Height = 0.04166667f;
    ((Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.srHeader).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srHeader).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srHeader).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srHeader).Border.TopStyle = (BorderLineStyle) 0;
    this.srHeader.CloseBorder = false;
    SubReport srHeader = this.srHeader;
    object obj1 = componentResourceManager.GetObject("srHeader.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) srHeader).Location = pointF1;
    ((ARControl) this.srHeader).Name = "srHeader";
    this.srHeader.Report = (SectionReport) null;
    ((ARControl) this.srHeader).Size = new SizeF(7.875f, 1f / 16f);
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj2 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label2).Location = pointF2;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1.875f, 3f / 16f);
    this.Label2.Text = "Covered Location(s):";
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "CoveredLocations";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 11f);
    this.TextBox10.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox10 = this.TextBox10;
    object obj3 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox10).Location = pointF3;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = (string) null;
    ((ARControl) this.TextBox10).Size = new SizeF(6f, 3f / 16f);
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj4 = componentResourceManager.GetObject("Label.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label).Location = pointF4;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label.Text = "Limit:";
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "EachOccurrence";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 11f);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj5 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) textBox).Location = pointF5;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = "#,##0";
    ((ARControl) this.TextBox).Size = new SizeF(21f / 16f, 3f / 16f);
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj6 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label1).Location = pointF6;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(5f, 3f / 16f);
    this.Label1.Text = "Each Occurrence";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "PerOccurrence";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 11f);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj7 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) textBox1).Location = pointF7;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "#,##0";
    ((ARControl) this.TextBox1).Size = new SizeF(19f / 16f, 3f / 16f);
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj8 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label3).Location = pointF8;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(0.125f, 3f / 16f);
    this.Label3.Text = "$";
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "GeneralAggregate";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 11f);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj9 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) textBox2).Location = pointF9;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "#,##0";
    ((ARControl) this.TextBox2).Size = new SizeF(21f / 16f, 3f / 16f);
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj10 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label4).Location = pointF10;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(5f, 3f / 16f);
    this.Label4.Text = "General Aggregate";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj11 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label5).Location = pointF11;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(0.125f, 3f / 16f);
    this.Label5.Text = "$";
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "ProductsCompletedOpAgg";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 11f);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj12 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) textBox3).Location = pointF12;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "#,##0";
    ((ARControl) this.TextBox3).Size = new SizeF(21f / 16f, 3f / 16f);
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj13 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label6).Location = pointF13;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(5f, 3f / 16f);
    this.Label6.Text = "Products-Completed Operations Aggregate";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj14 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) label7).Location = pointF14;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(0.125f, 3f / 16f);
    this.Label7.Text = "$";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj15 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) label8).Location = pointF15;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(27f / 16f, 3f / 16f);
    this.Label8.Text = "Underlying G/L Limits:";
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 11f);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj16 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) label9).Location = pointF16;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(0.125f, 3f / 16f);
    this.Label9.Text = "$";
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 11f);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj17 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) label10).Location = pointF17;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(4f, 3f / 16f);
    this.Label10.Text = "Per Occurrence";
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "GeneralAggregate";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 11f);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj18 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox4).Location = pointF18;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "#,##0";
    ((ARControl) this.TextBox4).Size = new SizeF(19f / 16f, 3f / 16f);
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    this.Label11.Font = new Font("Arial", 11f);
    this.Label11.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj19 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) label11).Location = pointF19;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(0.125f, 3f / 16f);
    this.Label11.Text = "$";
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 11f);
    this.Label12.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj20 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) label12).Location = pointF20;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(4f, 3f / 16f);
    this.Label12.Text = "General Aggregate";
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "ProductsCompletedOps";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 11f);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj21 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox5).Location = pointF21;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "#,##0";
    ((ARControl) this.TextBox5).Size = new SizeF(19f / 16f, 3f / 16f);
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    this.Label13.Font = new Font("Arial", 11f);
    this.Label13.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj22 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) label13).Location = pointF22;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(0.125f, 3f / 16f);
    this.Label13.Text = "$";
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    this.Label14.Font = new Font("Arial", 11f);
    this.Label14.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label14.HyperLink = (string) null;
    Label label14 = this.Label14;
    object obj23 = componentResourceManager.GetObject("Label14.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) label14).Location = pointF23;
    ((ARControl) this.Label14).Name = "Label14";
    ((ARControl) this.Label14).Size = new SizeF(4f, 3f / 16f);
    this.Label14.Text = "Products and Completed Operations";
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "PersonalAdvertising";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 11f);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj24 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) textBox6).Location = pointF24;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = "#,##0";
    ((ARControl) this.TextBox6).Size = new SizeF(19f / 16f, 3f / 16f);
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 0;
    this.Label15.Font = new Font("Arial", 11f);
    this.Label15.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label15.HyperLink = (string) null;
    Label label15 = this.Label15;
    object obj25 = componentResourceManager.GetObject("Label15.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) label15).Location = pointF25;
    ((ARControl) this.Label15).Name = "Label15";
    ((ARControl) this.Label15).Size = new SizeF(0.125f, 3f / 16f);
    this.Label15.Text = "$";
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 0;
    this.Label16.Font = new Font("Arial", 11f);
    this.Label16.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label16.HyperLink = (string) null;
    Label label16 = this.Label16;
    object obj26 = componentResourceManager.GetObject("Label16.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) label16).Location = pointF26;
    ((ARControl) this.Label16).Name = "Label16";
    ((ARControl) this.Label16).Size = new SizeF(4f, 3f / 16f);
    this.Label16.Text = "Personal and Advertising Injury";
    ((ARControl) this.srFooter).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.TopStyle = (BorderLineStyle) 0;
    this.srFooter.CloseBorder = false;
    SubReport srFooter = this.srFooter;
    object obj27 = componentResourceManager.GetObject("srFooter.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) srFooter).Location = pointF27;
    ((ARControl) this.srFooter).Name = "srFooter";
    this.srFooter.Report = (SectionReport) null;
    ((ARControl) this.srFooter).Size = new SizeF(7.875f, 1f / 16f);
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((Section) this.ReportHeader);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.ReportFooter);
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
  }

  private void rptExcessLiabilityQuote_ReportStart(object sender, EventArgs e)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(nameof (rptExcessLiabilityQuote), new object[2]
    {
      (object) "@QuoteOptionGuid",
      (object) this._QuoteOptionGuid
    });
    if (dataTable.Rows.Count <= 0)
      return;
    this.DataSource = (object) dataTable;
    this._HeaderReport = new rptCommonHeader1(this._QuoteOptionGuid, true);
    this.srHeader.Report = (SectionReport) this._HeaderReport;
    this._FooterReport = new rptCommonFooter1(this._QuoteOptionGuid, true);
    this.srFooter.Report = (SectionReport) this._FooterReport;
  }

  private void rptPropertyQuote_ReportEnd(object sender, EventArgs e)
  {
    if (this._FooterReport != null)
      this._FooterReport.Dispose();
    if (this._HeaderReport == null)
      return;
    this._HeaderReport.Dispose();
  }

  public bool RequiresQuoteOptionGuids() => true;

  public void SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
    this._QuoteOptionGuid = quoteOptionGuids[0];
  }
}
