// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptPolicyInvoiceListing
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptPolicyInvoiceListing : MGAReport
{
  private Guid _quoteGuid;
  private Label Label;
  private TextBox txtHeader_PolicyNumber;
  private Label Label10;
  private Label Label11;
  private TextBox txtHeader_Insured;
  private TextBox txtHeader_Producer;
  private Line Line;
  private Line Line1;
  private Label Label1;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label7;
  private Label Label6;
  private Label Label8;
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
  private Label Label9;

  public rptPolicyInvoiceListing()
  {
    this.ReportStart += new EventHandler(this.rptPolicyInvoiceListing_ReportStart);
    this.InitializeComponent();
  }

  public rptPolicyInvoiceListing(Guid q)
  {
    this.ReportStart += new EventHandler(this.rptPolicyInvoiceListing_ReportStart);
    this.InitializeComponent();
    this._quoteGuid = q;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptPolicyInvoiceListing));
    this.Detail = new Detail();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.Label = new Label();
    this.txtHeader_PolicyNumber = new TextBox();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.txtHeader_Insured = new TextBox();
    this.txtHeader_Producer = new TextBox();
    this.Line = new Line();
    this.Line1 = new Line();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label7 = new Label();
    this.Label6 = new Label();
    this.Label8 = new Label();
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
    this.Label9 = new Label();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.txtHeader_PolicyNumber).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.txtHeader_Insured).BeginInit();
    ((ISupportInitialize) this.txtHeader_Producer).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
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
    ((ISupportInitialize) this.Label9).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1145833f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.Label,
      (ARControl) this.txtHeader_PolicyNumber,
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.txtHeader_Insured,
      (ARControl) this.txtHeader_Producer,
      (ARControl) this.Line,
      (ARControl) this.Line1
    });
    this.PageHeader.Height = 1.708333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label7,
      (ARControl) this.Label6,
      (ARControl) this.Label8
    });
    this.GroupHeader1.Height = 0.1666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupHeader1.RepeatStyle = (RepeatStyle) 1;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.Label9
    });
    this.GroupFooter1.Height = 5f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.Label.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 18f);
    this.Label.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj1 = componentResourceManager.GetObject("Label.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label).Location = pointF1;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(7.875f, 5f / 16f);
    this.Label.Text = "Policy Invoice Listing";
    ((ARControl) this.txtHeader_PolicyNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_PolicyNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_PolicyNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_PolicyNumber).Border.TopStyle = (BorderLineStyle) 0;
    this.txtHeader_PolicyNumber.DistinctField = (string) null;
    this.txtHeader_PolicyNumber.Font = new Font("Arial", 12f, FontStyle.Bold);
    this.txtHeader_PolicyNumber.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox headerPolicyNumber = this.txtHeader_PolicyNumber;
    object obj2 = componentResourceManager.GetObject("txtHeader_PolicyNumber.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) headerPolicyNumber).Location = pointF2;
    ((ARControl) this.txtHeader_PolicyNumber).Name = "txtHeader_PolicyNumber";
    this.txtHeader_PolicyNumber.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_PolicyNumber).Size = new SizeF(125f / 16f, 0.25f);
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 1;
    this.Label10.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj3 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label10).Location = pointF3;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(61f / 16f, 3f / 16f);
    this.Label10.Text = "Insured:";
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 1;
    this.Label11.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label11.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj4 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label11).Location = pointF4;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(61f / 16f, 3f / 16f);
    this.Label11.Text = "Producer:";
    ((ARControl) this.txtHeader_Insured).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Insured).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtHeader_Insured).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtHeader_Insured).Border.TopStyle = (BorderLineStyle) 0;
    this.txtHeader_Insured.DistinctField = (string) null;
    this.txtHeader_Insured.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_Insured.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtHeaderInsured = this.txtHeader_Insured;
    object obj5 = componentResourceManager.GetObject("txtHeader_Insured.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) txtHeaderInsured).Location = pointF5;
    ((ARControl) this.txtHeader_Insured).Name = "txtHeader_Insured";
    this.txtHeader_Insured.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_Insured).Size = new SizeF(61f / 16f, 0.625f);
    ((ARControl) this.txtHeader_Producer).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader_Producer).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtHeader_Producer).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtHeader_Producer).Border.TopStyle = (BorderLineStyle) 0;
    this.txtHeader_Producer.DistinctField = (string) null;
    this.txtHeader_Producer.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtHeader_Producer.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtHeaderProducer = this.txtHeader_Producer;
    object obj6 = componentResourceManager.GetObject("txtHeader_Producer.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) txtHeaderProducer).Location = pointF6;
    ((ARControl) this.txtHeader_Producer).Name = "txtHeader_Producer";
    this.txtHeader_Producer.OutputFormat = (string) null;
    ((ARControl) this.txtHeader_Producer).Size = new SizeF(61f / 16f, 0.625f);
    this.Line.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line.Border.RightStyle = (BorderLineStyle) 0;
    this.Line.Border.TopStyle = (BorderLineStyle) 0;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    this.Line.X1 = 1f / 16f;
    this.Line.X2 = 3.875f;
    this.Line.Y1 = 1.625f;
    this.Line.Y2 = 1.625f;
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    this.Line1.X1 = 4f;
    this.Line1.X2 = 125f / 16f;
    this.Line1.Y1 = 1.625f;
    this.Line1.Y2 = 1.625f;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 1;
    this.Label1.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj7 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label1).Location = pointF7;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(53f / 16f, 3f / 16f);
    this.Label1.Text = "Description";
    this.Label3.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 1;
    this.Label3.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj8 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label3).Location = pointF8;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(0.625f, 3f / 16f);
    this.Label3.Text = "Invoice #";
    this.Label4.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 1;
    this.Label4.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj9 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label4).Location = pointF9;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label4.Text = "Amount";
    this.Label5.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 1;
    this.Label5.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj10 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label5).Location = pointF10;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label5.Text = "Paid";
    this.Label7.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 1;
    this.Label7.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj11 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label7).Location = pointF11;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label7.Text = "Amount Due";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 1;
    this.Label6.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj12 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label6).Location = pointF12;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(0.75f, 3f / 16f);
    this.Label6.Text = "Issued";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 1;
    this.Label8.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj13 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label8).Location = pointF13;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(0.75f, 3f / 16f);
    this.Label8.Text = "Due";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "Description";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 8f);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj14 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox1).Location = pointF14;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(53f / 16f, 0.125f);
    this.TextBox2.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "OfficeInvoiceNum";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 8f);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj15 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox2).Location = pointF15;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(0.625f, 0.125f);
    this.TextBox3.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "InvoiceAmount";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 8f);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj16 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) textBox3).Location = pointF16;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox3).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox4.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "Received";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 8f);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj17 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox4).Location = pointF17;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox4).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox5.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "AmountDue";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 8f);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj18 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox5).Location = pointF18;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox5).Size = new SizeF(13f / 16f, 0.125f);
    ((ARControl) this.TextBox6).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "DateIssued";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 8f);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj19 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) textBox6).Location = pointF19;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = (string) null;
    ((ARControl) this.TextBox6).Size = new SizeF(0.75f, 0.125f);
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "DueDate";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 8f);
    this.TextBox7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox7 = this.TextBox7;
    object obj20 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) textBox7).Location = pointF20;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = (string) null;
    ((ARControl) this.TextBox7).Size = new SizeF(0.75f, 0.125f);
    this.TextBox8.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "InvoiceAmount";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 9f);
    this.TextBox8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox8 = this.TextBox8;
    object obj21 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox8).Location = pointF21;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox8).Size = new SizeF(13f / 16f, 3f / 16f);
    this.TextBox8.SummaryRunning = (SummaryRunning) 2;
    this.TextBox8.SummaryType = (SummaryType) 1;
    this.TextBox9.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "Received";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 9f);
    this.TextBox9.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox9 = this.TextBox9;
    object obj22 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) textBox9).Location = pointF22;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox9).Size = new SizeF(13f / 16f, 3f / 16f);
    this.TextBox9.SummaryRunning = (SummaryRunning) 2;
    this.TextBox9.SummaryType = (SummaryType) 1;
    this.TextBox10.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "AmountDue";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 9f);
    this.TextBox10.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox10 = this.TextBox10;
    object obj23 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) textBox10).Location = pointF23;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox10).Size = new SizeF(13f / 16f, 3f / 16f);
    this.TextBox10.SummaryRunning = (SummaryRunning) 2;
    this.TextBox10.SummaryType = (SummaryType) 1;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj24 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) label9).Location = pointF24;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label9.Text = "TOTALS:";
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.txtHeader_PolicyNumber).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.txtHeader_Insured).EndInit();
    ((ISupportInitialize) this.txtHeader_Producer).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
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
    ((ISupportInitialize) this.Label9).EndInit();
  }

  private void rptPolicyInvoiceListing_ReportStart(object sender, EventArgs e)
  {
    DataSet ds = new DataSet();
    using (SqlConnection sqlConnection = new SqlConnection(Database.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand())
      {
        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand))
        {
          selectCommand.CommandText = "[rptPolicyInvoiceListing]";
          selectCommand.CommandType = CommandType.StoredProcedure;
          selectCommand.Connection = sqlConnection;
          selectCommand.Parameters.AddWithValue("@QuoteGuid", (object) this._quoteGuid);
          try
          {
            Database.SafeDataAdapterFill(dataAdapter, ds);
          }
          finally
          {
            sqlConnection.Dispose();
            selectCommand.Dispose();
            dataAdapter.Dispose();
          }
          if (ds.Tables.Count < 2)
            return;
          DataRow row = ds.Tables[0].Rows[0];
          this.txtHeader_Insured.Text = row["Insured"].ToString();
          this.txtHeader_PolicyNumber.Text = row["PolicyNumber"].ToString();
          this.txtHeader_Producer.Text = row["Producer"].ToString();
          this.DataSource = (object) ds.Tables[1];
        }
      }
    }
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
