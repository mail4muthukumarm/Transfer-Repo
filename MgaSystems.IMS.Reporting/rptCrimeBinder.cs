// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptCrimeBinder
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
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

[AutomationReport("{C5920EC4-655F-450c-B06D-9012485E025E}", Enums.AutomationDocGroups.PolicyDoc, "IMS Crime Binder", "IMS binder document for crime.")]
public class rptCrimeBinder : SectionReport, IQuoteDocument
{
  private SubReport srHeader;
  private TextBox TextBox2;
  private TextBox TextBox1;
  private TextBox TextBox;
  private TextBox TextBox3;
  private Label Label;
  private Label Label1;
  private Label Label3;
  private Label Label4;
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
  private TextBox TextBox20;
  private TextBox TextBox21;
  private TextBox TextBox22;
  private TextBox TextBox23;
  private TextBox TextBox24;
  private TextBox TextBox25;
  private TextBox TextBox26;
  private TextBox TextBox27;
  private TextBox TextBox28;
  private TextBox TextBox29;
  private TextBox TextBox30;
  private TextBox TextBox31;
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

  public rptCrimeBinder()
  {
    this.ReportStart += new EventHandler(this.rptCrimeBinder_ReportStart);
    this.ReportEnd += new EventHandler(this.rptPropertyBinder_ReportEnd);
    this.InitializeComponent();
  }

  public rptCrimeBinder(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptCrimeBinder_ReportStart);
    this.ReportEnd += new EventHandler(this.rptPropertyBinder_ReportEnd);
    this.InitializeComponent();
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptCrimeBinder));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.srHeader = new SubReport();
    this.TextBox2 = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox = new TextBox();
    this.TextBox3 = new TextBox();
    this.Label = new Label();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
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
    this.TextBox20 = new TextBox();
    this.TextBox21 = new TextBox();
    this.TextBox22 = new TextBox();
    this.TextBox23 = new TextBox();
    this.TextBox24 = new TextBox();
    this.TextBox25 = new TextBox();
    this.TextBox26 = new TextBox();
    this.TextBox27 = new TextBox();
    this.TextBox28 = new TextBox();
    this.TextBox29 = new TextBox();
    this.TextBox30 = new TextBox();
    this.TextBox31 = new TextBox();
    this.srFooter = new SubReport();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
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
    ((ISupportInitialize) this.TextBox20).BeginInit();
    ((ISupportInitialize) this.TextBox21).BeginInit();
    ((ISupportInitialize) this.TextBox22).BeginInit();
    ((ISupportInitialize) this.TextBox23).BeginInit();
    ((ISupportInitialize) this.TextBox24).BeginInit();
    ((ISupportInitialize) this.TextBox25).BeginInit();
    ((ISupportInitialize) this.TextBox26).BeginInit();
    ((ISupportInitialize) this.TextBox27).BeginInit();
    ((ISupportInitialize) this.TextBox28).BeginInit();
    ((ISupportInitialize) this.TextBox29).BeginInit();
    ((ISupportInitialize) this.TextBox30).BeginInit();
    ((ISupportInitialize) this.TextBox31).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[36]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox3,
      (ARControl) this.Label,
      (ARControl) this.Label1,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
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
      (ARControl) this.TextBox20,
      (ARControl) this.TextBox21,
      (ARControl) this.TextBox22,
      (ARControl) this.TextBox23,
      (ARControl) this.TextBox24,
      (ARControl) this.TextBox25,
      (ARControl) this.TextBox26,
      (ARControl) this.TextBox27,
      (ARControl) this.TextBox28,
      (ARControl) this.TextBox29,
      (ARControl) this.TextBox30,
      (ARControl) this.TextBox31
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 2.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srHeader
    });
    this.ReportHeader.Height = 0.05138889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.srFooter
    });
    this.ReportFooter.Height = 0.04166667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
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
    this.TextBox2.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "EmployeeTheftPrem";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 11f);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj2 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) textBox2).Location = pointF2;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox2).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox2.Text = " ";
    this.TextBox1.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "EmployeeTheftDed";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 11f);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj3 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox1).Location = pointF3;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox1).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox1.Text = " ";
    this.TextBox.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "EmployeeTheftLimit";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 11f);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj4 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) textBox).Location = pointF4;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox.Text = " ";
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj5 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) textBox3).Location = pointF5;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(3f, 3f / 16f);
    this.TextBox3.Text = "Employee Theft";
    this.Label.Alignment = (TextAlignment) 1;
    this.Label.BackColor = Color.Gainsboro;
    ((ARControl) this.Label).Border.BottomColor = Color.FromArgb(128 /*0x80*/, 128 /*0x80*/, 128 /*0x80*/);
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Border.LeftColor = Color.FromArgb(128 /*0x80*/, 128 /*0x80*/, 128 /*0x80*/);
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopColor = Color.FromArgb(128 /*0x80*/, 128 /*0x80*/, 128 /*0x80*/);
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 1;
    this.Label.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj6 = componentResourceManager.GetObject("Label.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label).Location = pointF6;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(3f, 3f / 16f);
    this.Label.Text = "Coverage";
    this.Label1.Alignment = (TextAlignment) 1;
    this.Label1.BackColor = Color.Gainsboro;
    ((ARControl) this.Label1).Border.BottomColor = Color.FromArgb(128 /*0x80*/, 128 /*0x80*/, 128 /*0x80*/);
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.FromArgb(128 /*0x80*/, 128 /*0x80*/, 128 /*0x80*/);
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 1;
    this.Label1.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj7 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label1).Location = pointF7;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(1.625f, 3f / 16f);
    this.Label1.Text = "Limit";
    this.Label3.Alignment = (TextAlignment) 1;
    this.Label3.BackColor = Color.Gainsboro;
    ((ARControl) this.Label3).Border.BottomColor = Color.FromArgb(128 /*0x80*/, 128 /*0x80*/, 128 /*0x80*/);
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.FromArgb(128 /*0x80*/, 128 /*0x80*/, 128 /*0x80*/);
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 1;
    this.Label3.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj8 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label3).Location = pointF8;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(1.625f, 3f / 16f);
    this.Label3.Text = "Deductible";
    this.Label4.Alignment = (TextAlignment) 1;
    this.Label4.BackColor = Color.Gainsboro;
    ((ARControl) this.Label4).Border.BottomColor = Color.FromArgb(128 /*0x80*/, 128 /*0x80*/, 128 /*0x80*/);
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.FromArgb(128 /*0x80*/, 128 /*0x80*/, 128 /*0x80*/);
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.TopColor = Color.FromArgb(128 /*0x80*/, 128 /*0x80*/, 128 /*0x80*/);
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 1;
    this.Label4.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj9 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label4).Location = pointF9;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(1.625f, 3f / 16f);
    this.Label4.Text = "Premium";
    this.TextBox4.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "ForgeryPrem";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 11f);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj10 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox4).Location = pointF10;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox4).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox4.Text = " ";
    this.TextBox5.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "ForgeryDed";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 11f);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj11 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox5).Location = pointF11;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox5).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox5.Text = " ";
    this.TextBox6.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "ForgeryLimit";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 11f);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj12 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) textBox6).Location = pointF12;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox6).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.TextBox7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox7 = this.TextBox7;
    object obj13 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox7).Location = pointF13;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = (string) null;
    ((ARControl) this.TextBox7).Size = new SizeF(3f, 3f / 16f);
    this.TextBox7.Text = "Forgery Or Alteration";
    this.TextBox8.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "MoneyInsidePrem";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 11f);
    this.TextBox8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox8 = this.TextBox8;
    object obj14 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox8).Location = pointF14;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox8).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox8.Text = " ";
    this.TextBox9.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "MoneyInsideDed";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 11f);
    this.TextBox9.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox9 = this.TextBox9;
    object obj15 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox9).Location = pointF15;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox9).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox9.Text = " ";
    this.TextBox10.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "MoneyInsideLimit";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 11f);
    this.TextBox10.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox10 = this.TextBox10;
    object obj16 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) textBox10).Location = pointF16;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox10).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox10.Text = " ";
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox11.DistinctField = (string) null;
    this.TextBox11.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.TextBox11.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox11 = this.TextBox11;
    object obj17 = componentResourceManager.GetObject("TextBox11.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox11).Location = pointF17;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = (string) null;
    ((ARControl) this.TextBox11).Size = new SizeF(3f, 0.375f);
    this.TextBox11.Text = "Inside The Premises - Theft Of Money And Securities";
    this.TextBox12.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "SafeInsidePrem";
    this.TextBox12.DistinctField = (string) null;
    this.TextBox12.Font = new Font("Arial", 11f);
    this.TextBox12.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox12 = this.TextBox12;
    object obj18 = componentResourceManager.GetObject("TextBox12.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox12).Location = pointF18;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox12).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox12.Text = " ";
    this.TextBox13.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "SafeInsideDed";
    this.TextBox13.DistinctField = (string) null;
    this.TextBox13.Font = new Font("Arial", 11f);
    this.TextBox13.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox13 = this.TextBox13;
    object obj19 = componentResourceManager.GetObject("TextBox13.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) textBox13).Location = pointF19;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox13).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox13.Text = " ";
    this.TextBox14.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).DataField = "SafeInsideLimit";
    this.TextBox14.DistinctField = (string) null;
    this.TextBox14.Font = new Font("Arial", 11f);
    this.TextBox14.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox14 = this.TextBox14;
    object obj20 = componentResourceManager.GetObject("TextBox14.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) textBox14).Location = pointF20;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox14).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox14.Text = " ";
    ((ARControl) this.TextBox15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox15.DistinctField = (string) null;
    this.TextBox15.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.TextBox15.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox15 = this.TextBox15;
    object obj21 = componentResourceManager.GetObject("TextBox15.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox15).Location = pointF21;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.OutputFormat = (string) null;
    ((ARControl) this.TextBox15).Size = new SizeF(3f, 0.375f);
    this.TextBox15.Text = "Inside The Premises - Robbery Or Safe Burglary Of Other Property";
    this.TextBox16.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).DataField = "TheftOutsidePrem";
    this.TextBox16.DistinctField = (string) null;
    this.TextBox16.Font = new Font("Arial", 11f);
    this.TextBox16.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox16 = this.TextBox16;
    object obj22 = componentResourceManager.GetObject("TextBox16.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) textBox16).Location = pointF22;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox16).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox16.Text = " ";
    this.TextBox17.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).DataField = "TheftOutsideDed";
    this.TextBox17.DistinctField = (string) null;
    this.TextBox17.Font = new Font("Arial", 11f);
    this.TextBox17.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox17 = this.TextBox17;
    object obj23 = componentResourceManager.GetObject("TextBox17.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) textBox17).Location = pointF23;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox17).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox17.Text = " ";
    this.TextBox18.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).DataField = "TheftOutsideLimit";
    this.TextBox18.DistinctField = (string) null;
    this.TextBox18.Font = new Font("Arial", 11f);
    this.TextBox18.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox18 = this.TextBox18;
    object obj24 = componentResourceManager.GetObject("TextBox18.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) textBox18).Location = pointF24;
    ((ARControl) this.TextBox18).Name = "TextBox18";
    this.TextBox18.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox18).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox18.Text = " ";
    ((ARControl) this.TextBox19).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox19.DistinctField = (string) null;
    this.TextBox19.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.TextBox19.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox19 = this.TextBox19;
    object obj25 = componentResourceManager.GetObject("TextBox19.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) textBox19).Location = pointF25;
    ((ARControl) this.TextBox19).Name = "TextBox19";
    this.TextBox19.OutputFormat = (string) null;
    ((ARControl) this.TextBox19).Size = new SizeF(3f, 3f / 16f);
    this.TextBox19.Text = "Outside The Premises";
    this.TextBox20.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).DataField = "ComputerFraudPrem";
    this.TextBox20.DistinctField = (string) null;
    this.TextBox20.Font = new Font("Arial", 11f);
    this.TextBox20.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox20 = this.TextBox20;
    object obj26 = componentResourceManager.GetObject("TextBox20.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) textBox20).Location = pointF26;
    ((ARControl) this.TextBox20).Name = "TextBox20";
    this.TextBox20.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox20).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox20.Text = " ";
    this.TextBox21.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox21).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).DataField = "ComputerFraudDed";
    this.TextBox21.DistinctField = (string) null;
    this.TextBox21.Font = new Font("Arial", 11f);
    this.TextBox21.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox21 = this.TextBox21;
    object obj27 = componentResourceManager.GetObject("TextBox21.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) textBox21).Location = pointF27;
    ((ARControl) this.TextBox21).Name = "TextBox21";
    this.TextBox21.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox21).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox21.Text = " ";
    this.TextBox22.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox22).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).DataField = "ComputerFraudLimit";
    this.TextBox22.DistinctField = (string) null;
    this.TextBox22.Font = new Font("Arial", 11f);
    this.TextBox22.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox22 = this.TextBox22;
    object obj28 = componentResourceManager.GetObject("TextBox22.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) textBox22).Location = pointF28;
    ((ARControl) this.TextBox22).Name = "TextBox22";
    this.TextBox22.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox22).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox22.Text = " ";
    ((ARControl) this.TextBox23).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox23.DistinctField = (string) null;
    this.TextBox23.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.TextBox23.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox23 = this.TextBox23;
    object obj29 = componentResourceManager.GetObject("TextBox23.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) textBox23).Location = pointF29;
    ((ARControl) this.TextBox23).Name = "TextBox23";
    this.TextBox23.OutputFormat = (string) null;
    ((ARControl) this.TextBox23).Size = new SizeF(3f, 3f / 16f);
    this.TextBox23.Text = "Computer Fraud";
    this.TextBox24.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox24).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).DataField = "FundTransferPrem";
    this.TextBox24.DistinctField = (string) null;
    this.TextBox24.Font = new Font("Arial", 11f);
    this.TextBox24.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox24 = this.TextBox24;
    object obj30 = componentResourceManager.GetObject("TextBox24.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) textBox24).Location = pointF30;
    ((ARControl) this.TextBox24).Name = "TextBox24";
    this.TextBox24.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox24).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox24.Text = " ";
    this.TextBox25.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox25).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).DataField = "FundTransferDed";
    this.TextBox25.DistinctField = (string) null;
    this.TextBox25.Font = new Font("Arial", 11f);
    this.TextBox25.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox25 = this.TextBox25;
    object obj31 = componentResourceManager.GetObject("TextBox25.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) textBox25).Location = pointF31;
    ((ARControl) this.TextBox25).Name = "TextBox25";
    this.TextBox25.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox25).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox25.Text = " ";
    this.TextBox26.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox26).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).DataField = "FundTransferLimit";
    this.TextBox26.DistinctField = (string) null;
    this.TextBox26.Font = new Font("Arial", 11f);
    this.TextBox26.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox26 = this.TextBox26;
    object obj32 = componentResourceManager.GetObject("TextBox26.Location");
    PointF pointF32 = obj32 != null ? (PointF) obj32 : new PointF();
    ((ARControl) textBox26).Location = pointF32;
    ((ARControl) this.TextBox26).Name = "TextBox26";
    this.TextBox26.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox26).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox26.Text = " ";
    ((ARControl) this.TextBox27).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox27.DistinctField = (string) null;
    this.TextBox27.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.TextBox27.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox27 = this.TextBox27;
    object obj33 = componentResourceManager.GetObject("TextBox27.Location");
    PointF pointF33 = obj33 != null ? (PointF) obj33 : new PointF();
    ((ARControl) textBox27).Location = pointF33;
    ((ARControl) this.TextBox27).Name = "TextBox27";
    this.TextBox27.OutputFormat = (string) null;
    ((ARControl) this.TextBox27).Size = new SizeF(3f, 3f / 16f);
    this.TextBox27.Text = "Funds Transfer Fraud";
    this.TextBox28.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox28).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).DataField = "CounterfeitPrem";
    this.TextBox28.DistinctField = (string) null;
    this.TextBox28.Font = new Font("Arial", 11f);
    this.TextBox28.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox28 = this.TextBox28;
    object obj34 = componentResourceManager.GetObject("TextBox28.Location");
    PointF pointF34 = obj34 != null ? (PointF) obj34 : new PointF();
    ((ARControl) textBox28).Location = pointF34;
    ((ARControl) this.TextBox28).Name = "TextBox28";
    this.TextBox28.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox28).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox28.Text = " ";
    this.TextBox29.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox29).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).DataField = "CounterfeitDed";
    this.TextBox29.DistinctField = (string) null;
    this.TextBox29.Font = new Font("Arial", 11f);
    this.TextBox29.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox29 = this.TextBox29;
    object obj35 = componentResourceManager.GetObject("TextBox29.Location");
    PointF pointF35 = obj35 != null ? (PointF) obj35 : new PointF();
    ((ARControl) textBox29).Location = pointF35;
    ((ARControl) this.TextBox29).Name = "TextBox29";
    this.TextBox29.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox29).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox29.Text = " ";
    this.TextBox30.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox30).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).DataField = "CounterfeitLimit";
    this.TextBox30.DistinctField = (string) null;
    this.TextBox30.Font = new Font("Arial", 11f);
    this.TextBox30.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox30 = this.TextBox30;
    object obj36 = componentResourceManager.GetObject("TextBox30.Location");
    PointF pointF36 = obj36 != null ? (PointF) obj36 : new PointF();
    ((ARControl) textBox30).Location = pointF36;
    ((ARControl) this.TextBox30).Name = "TextBox30";
    this.TextBox30.OutputFormat = "$#,##0";
    ((ARControl) this.TextBox30).Size = new SizeF(1.625f, 3f / 16f);
    this.TextBox30.Text = " ";
    ((ARControl) this.TextBox31).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox31.DistinctField = (string) null;
    this.TextBox31.Font = new Font("Arial", 11f, FontStyle.Bold);
    this.TextBox31.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox31 = this.TextBox31;
    object obj37 = componentResourceManager.GetObject("TextBox31.Location");
    PointF pointF37 = obj37 != null ? (PointF) obj37 : new PointF();
    ((ARControl) textBox31).Location = pointF37;
    ((ARControl) this.TextBox31).Name = "TextBox31";
    this.TextBox31.OutputFormat = (string) null;
    ((ARControl) this.TextBox31).Size = new SizeF(3f, 0.375f);
    this.TextBox31.Text = "Money Orders And Counterfeit Paper Currency";
    ((ARControl) this.srFooter).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srFooter).Border.TopStyle = (BorderLineStyle) 0;
    this.srFooter.CloseBorder = false;
    SubReport srFooter = this.srFooter;
    object obj38 = componentResourceManager.GetObject("srFooter.Location");
    PointF pointF38 = obj38 != null ? (PointF) obj38 : new PointF();
    ((ARControl) srFooter).Location = pointF38;
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
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
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
    ((ISupportInitialize) this.TextBox20).EndInit();
    ((ISupportInitialize) this.TextBox21).EndInit();
    ((ISupportInitialize) this.TextBox22).EndInit();
    ((ISupportInitialize) this.TextBox23).EndInit();
    ((ISupportInitialize) this.TextBox24).EndInit();
    ((ISupportInitialize) this.TextBox25).EndInit();
    ((ISupportInitialize) this.TextBox26).EndInit();
    ((ISupportInitialize) this.TextBox27).EndInit();
    ((ISupportInitialize) this.TextBox28).EndInit();
    ((ISupportInitialize) this.TextBox29).EndInit();
    ((ISupportInitialize) this.TextBox30).EndInit();
    ((ISupportInitialize) this.TextBox31).EndInit();
  }

  private void rptCrimeBinder_ReportStart(object sender, EventArgs e)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(nameof (rptCrimeBinder), new object[2]
    {
      (object) "@QuoteOptionGuid",
      (object) this._QuoteOptionGuid
    });
    if (dataTable.Rows.Count <= 0)
      return;
    this.DataSource = (object) dataTable;
    this._HeaderReport = new rptCommonHeader1(this._QuoteOptionGuid, false);
    this.srHeader.Report = (SectionReport) this._HeaderReport;
    this._FooterReport = new rptCommonFooter1(this._QuoteOptionGuid, false);
    this.srFooter.Report = (SectionReport) this._FooterReport;
  }

  private void rptPropertyBinder_ReportEnd(object sender, EventArgs e)
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
