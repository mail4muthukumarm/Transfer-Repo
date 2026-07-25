// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptProducerStatement
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{63D71AD8-4B50-4d84-A085-5403F474F7F2}", "Producer Statement", "Shows money due as of a specific date.", "General")]
public class rptProducerStatement : MGAReport, IReport
{
  private TextBox txtTitle;
  private Label lblDateRange;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox Balance1;
  private Guid _ProducerGuid;
  private DateTime _AsOfDate;

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

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptProducerStatement));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.txtTitle = new TextBox();
    this.lblDateRange = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.Balance1 = new TextBox();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.lblDateRange).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.Balance1).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1145833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtTitle,
      (ARControl) this.lblDateRange
    });
    this.ReportHeader.Height = 9f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.Balance1
    });
    this.ReportFooter.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6
    });
    this.PageHeader.Height = 0.1763889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.txtTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.txtTitle.DistinctField = (string) null;
    this.txtTitle.Font = new Font("Arial", 14f);
    this.txtTitle.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtTitle = this.txtTitle;
    object obj1 = componentResourceManager.GetObject("txtTitle.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) txtTitle).Location = pointF1;
    ((ARControl) this.txtTitle).Name = "txtTitle";
    this.txtTitle.OutputFormat = (string) null;
    ((ARControl) this.txtTitle).Size = new SizeF(7.875f, 0.25f);
    this.txtTitle.Text = "Producer Statement for {0}";
    this.lblDateRange.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblDateRange).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDateRange).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDateRange).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDateRange).Border.TopStyle = (BorderLineStyle) 0;
    this.lblDateRange.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblDateRange.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblDateRange.HyperLink = (string) null;
    Label lblDateRange = this.lblDateRange;
    object obj2 = componentResourceManager.GetObject("lblDateRange.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) lblDateRange).Location = pointF2;
    ((ARControl) this.lblDateRange).Name = "lblDateRange";
    ((ARControl) this.lblDateRange).Size = new SizeF(7.875f, 3f / 16f);
    this.lblDateRange.Text = "As Of {0}";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 8f);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj3 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label1).Location = pointF3;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(1f, 3f / 16f);
    this.Label1.Text = "Invoice #";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 8f);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj4 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label2).Location = pointF4;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(25f / 16f, 3f / 16f);
    this.Label2.Text = "Policy #";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 8f);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj5 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label3).Location = pointF5;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(47f / 16f, 3f / 16f);
    this.Label3.Text = "Insured";
    this.Label4.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 8f);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj6 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label4).Location = pointF6;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label4.Text = "Invoice Date";
    this.Label5.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 8f);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj7 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label5).Location = pointF7;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label5.Text = "Due Date";
    this.Label6.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 8f);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj8 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label6).Location = pointF8;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(1f, 3f / 16f);
    this.Label6.Text = "Remaining Due";
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
    this.TextBox1.Font = new Font("Arial", 8f);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj9 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) textBox1).Location = pointF9;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(1f, 0.125f);
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "PolicyNum";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 8f);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj10 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox2).Location = pointF10;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(25f / 16f, 0.125f);
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "Insured";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 8f);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj11 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox3).Location = pointF11;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(47f / 16f, 0.125f);
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "InvoiceDate";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 8f);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj12 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) textBox4).Location = pointF12;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox4).Size = new SizeF(11f / 16f, 0.125f);
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "DueDate";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 8f);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj13 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox5).Location = pointF13;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox5).Size = new SizeF(11f / 16f, 0.125f);
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
    ((ARControl) this.TextBox6).DataField = "Balance";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 8f);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj14 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox6).Location = pointF14;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox6).Size = new SizeF(1f, 0.125f);
    this.TextBox6.Text = " ";
    this.Balance1.Alignment = (TextAlignment) 2;
    ((ARControl) this.Balance1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Balance1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Balance1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Balance1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Balance1).DataField = "Balance";
    this.Balance1.DistinctField = (string) null;
    this.Balance1.Font = new Font("Arial", 8f);
    this.Balance1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox balance1 = this.Balance1;
    object obj15 = componentResourceManager.GetObject("Balance1.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) balance1).Location = pointF15;
    ((ARControl) this.Balance1).Name = "Balance1";
    this.Balance1.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.Balance1).Size = new SizeF(1.875f, 3f / 16f);
    this.Balance1.SummaryRunning = (SummaryRunning) 2;
    this.Balance1.SummaryType = (SummaryType) 1;
    this.Balance1.Text = " ";
    this.PageSettings.Margins.Bottom = 0.3f;
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
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.lblDateRange).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.Balance1).EndInit();
  }

  public rptProducerStatement()
  {
    this.ReportStart += new EventHandler(this.rptProducerStatement_ReportStart);
  }

  public rptProducerStatement(Guid ProducerGuid, DateTime AsOfDate)
  {
    this.ReportStart += new EventHandler(this.rptProducerStatement_ReportStart);
    this.InitializeComponent();
    this._ProducerGuid = ProducerGuid;
    this._AsOfDate = AsOfDate;
  }

  private void rptProducerStatement_ReportStart(object sender, EventArgs e)
  {
    this.SetProgressbarMaximum(100);
    this.SetStatusText("Retrieving Data...");
    this.IncreaseProgressbar(10);
    if (!this.CurrentUserGuid.Equals((object) string.Empty) && SystemSettings.KeyExists("CheckQuotingOfficeGuid") && SystemSettings.GetBoolSetting("CheckQuotingOfficeGuid"))
      this.DataSource = (object) DefaultDatabase.ExecuteDataTable("dbo.rptProducerStatement", new object[6]
      {
        (object) "@ProducerGuid",
        (object) this._ProducerGuid,
        (object) "@AsOfDate",
        (object) this._AsOfDate,
        (object) "@CurrentUserGuid",
        (object) this.CurrentUserGuid
      });
    else
      this.DataSource = (object) DefaultDatabase.ExecuteDataTable("dbo.rptProducerStatement", new object[4]
      {
        (object) "@ProducerGuid",
        (object) this._ProducerGuid,
        (object) "@AsOfDate",
        (object) this._AsOfDate
      });
    this.IncreaseProgressbar(80 /*0x50*/);
    this.SetStatusText("Formatting...");
    this.txtTitle.Text = string.Format(this.txtTitle.Text, (object) DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT TOP 1 ProducerName FROM dbo.tblProducers WHERE ProducerGuid = @ProducerGuid", new object[2]
    {
      (object) "@ProducerGuid",
      (object) this._ProducerGuid
    }));
    this.lblDateRange.Text = string.Format(this.lblDateRange.Text, (object) this._AsOfDate.ToString("MM/dd/yyyy"));
    this.IncreaseProgressbar(5);
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  public override bool IsThreaded => true;

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new Producers("Producer", false),
        (BaseReportControl) new DatePicker("Invoice Date", DateAndTime.Now.Date, false)
      };
    }
  }
}
