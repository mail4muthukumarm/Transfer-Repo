// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptEquipmentBreakdownQuote
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

[AutomationReport("{EB2D7566-3441-4a28-B47D-30180DDFBA06}", Enums.AutomationDocGroups.PolicyDoc, "IMS Equipment Breakdown Quote", "IMS quote document for equipment breakdown.")]
public class rptEquipmentBreakdownQuote : SectionReport, IQuoteDocument
{
  private SubReport srHeader;
  private TextBox TextBox10;
  private Label Label2;
  private Label Label;
  private Label Label1;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private TextBox TextBox;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox TextBox11;
  private TextBox TextBox12;
  private TextBox TextBox13;
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

  public rptEquipmentBreakdownQuote()
  {
    this.ReportStart += new EventHandler(this.rptEquipmentBreakdownQuote_ReportStart);
    this.ReportEnd += new EventHandler(this.rptPropertyQuote_ReportEnd);
    this.InitializeComponent();
  }

  public rptEquipmentBreakdownQuote(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptEquipmentBreakdownQuote_ReportStart);
    this.ReportEnd += new EventHandler(this.rptPropertyQuote_ReportEnd);
    this.InitializeComponent();
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptEquipmentBreakdownQuote));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.srHeader = new SubReport();
    this.TextBox10 = new TextBox();
    this.Label2 = new Label();
    this.Label = new Label();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.TextBox = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.srFooter = new SubReport();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[22]
    {
      (ARControl) this.TextBox10,
      (ARControl) this.Label2,
      (ARControl) this.Label,
      (ARControl) this.Label1,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13
    });
    ((Section) this.Detail).Height = 2.613889f;
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
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "CoveredLocations";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 11f);
    this.TextBox10.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox10 = this.TextBox10;
    object obj2 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) textBox10).Location = pointF2;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = (string) null;
    ((ARControl) this.TextBox10).Size = new SizeF(6f, 3f / 16f);
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj3 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label2).Location = pointF3;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1.875f, 3f / 16f);
    this.Label2.Text = "Covered Location(s):";
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
    ((ARControl) this.Label).Size = new SizeF(2.75f, 3f / 16f);
    this.Label.Text = "Property Damage Limit Per Accident:";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj5 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label1).Location = pointF5;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(2.75f, 3f / 16f);
    this.Label1.Text = "Business Income Interruption:";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj6 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label3).Location = pointF6;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(2.75f, 3f / 16f);
    this.Label3.Text = "Extra Expense:";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj7 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label4).Location = pointF7;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(2.75f, 3f / 16f);
    this.Label4.Text = "Off Prem. Service Interruption:";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj8 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label5).Location = pointF8;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(2.75f, 3f / 16f);
    this.Label5.Text = "Expediting Expenses:";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj9 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label6).Location = pointF9;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(2.75f, 3f / 16f);
    this.Label6.Text = "Ammonia Contamination:";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj10 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label7).Location = pointF10;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(2.75f, 3f / 16f);
    this.Label7.Text = "Water Damage:";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj11 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label8).Location = pointF11;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(2.75f, 3f / 16f);
    this.Label8.Text = "Deductibles:";
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "ScheduleOfUnderlying";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj12 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) textBox).Location = pointF12;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(0.125f, 3f / 16f);
    this.TextBox.Text = "$";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "ScheduleOfUnderlying";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj13 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox1).Location = pointF13;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(0.125f, 3f / 16f);
    this.TextBox1.Text = "$";
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "ScheduleOfUnderlying";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj14 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox2).Location = pointF14;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(0.125f, 3f / 16f);
    this.TextBox2.Text = "$";
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "ScheduleOfUnderlying";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj15 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox3).Location = pointF15;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(0.125f, 3f / 16f);
    this.TextBox3.Text = "$";
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "PolicyLimitPerAccident";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 11f);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj16 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) textBox5).Location = pointF16;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox5).Size = new SizeF(5f, 3f / 16f);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "BusinessInterruption";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 11f);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj17 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox6).Location = pointF17;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = (string) null;
    ((ARControl) this.TextBox6).Size = new SizeF(5.125f, 3f / 16f);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "ExtraExpense";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 11f);
    this.TextBox7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox7 = this.TextBox7;
    object obj18 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox7).Location = pointF18;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = (string) null;
    ((ARControl) this.TextBox7).Size = new SizeF(5.125f, 3f / 16f);
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "OffPremService";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 11f);
    this.TextBox8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox8 = this.TextBox8;
    object obj19 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) textBox8).Location = pointF19;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = (string) null;
    ((ARControl) this.TextBox8).Size = new SizeF(5.125f, 3f / 16f);
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "ExpeditingExp";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 11f);
    this.TextBox9.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox9 = this.TextBox9;
    object obj20 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) textBox9).Location = pointF20;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox9).Size = new SizeF(5f, 3f / 16f);
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "AmmoniaCont";
    this.TextBox11.DistinctField = (string) null;
    this.TextBox11.Font = new Font("Arial", 11f);
    this.TextBox11.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox11 = this.TextBox11;
    object obj21 = componentResourceManager.GetObject("TextBox11.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox11).Location = pointF21;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox11).Size = new SizeF(5f, 3f / 16f);
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "WaterDamage";
    this.TextBox12.DistinctField = (string) null;
    this.TextBox12.Font = new Font("Arial", 11f);
    this.TextBox12.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox12 = this.TextBox12;
    object obj22 = componentResourceManager.GetObject("TextBox12.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) textBox12).Location = pointF22;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox12).Size = new SizeF(5f, 3f / 16f);
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "Deductibles";
    this.TextBox13.DistinctField = (string) null;
    this.TextBox13.Font = new Font("Arial", 11f);
    this.TextBox13.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox13 = this.TextBox13;
    object obj23 = componentResourceManager.GetObject("TextBox13.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) textBox13).Location = pointF23;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = (string) null;
    ((ARControl) this.TextBox13).Size = new SizeF(5.125f, 0.5f);
    ((ARControl) this.srFooter).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.TopStyle = (BorderLineStyle) 0;
    this.srFooter.CloseBorder = false;
    SubReport srFooter = this.srFooter;
    object obj24 = componentResourceManager.GetObject("srFooter.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) srFooter).Location = pointF24;
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
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
  }

  private void rptEquipmentBreakdownQuote_ReportStart(object sender, EventArgs e)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(nameof (rptEquipmentBreakdownQuote), new object[2]
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
