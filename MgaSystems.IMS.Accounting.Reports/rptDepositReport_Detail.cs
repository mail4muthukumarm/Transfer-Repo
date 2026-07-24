// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptDepositReport_Detail
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptDepositReport_Detail : SectionReport
{
  private Decimal CheckTotal;
  private Font strikeFont;
  private Font noStrikeFont;
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
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox TextBox10;
  private CheckBox CheckBox1;
  private TextBox TextBox11;
  private TextBox TextBox12;
  private Line Line1;
  private Line Line2;
  private Line Line3;
  private Line Line4;
  private Line Line5;
  private Line Line6;
  private Line Line7;
  private Line Line8;
  private Line Line9;
  private Line Line10;
  private Line Line11;
  private Line Line12;
  private TextBox txtCheckAmountTotal;
  private TextBox txtAPTotal;
  private TextBox txtIncomeTotal;
  private TextBox txtARTotal;
  private TextBox txtUnAcctTotal;
  private TextBox txtExchTotal;
  private TextBox txtExpenseTotal;
  private TextBox txtTransferTotal;

  public rptDepositReport_Detail()
  {
    this.strikeFont = new Font("Arial", 8f, FontStyle.Strikeout);
    this.noStrikeFont = new Font("Arial", 8f);
    this.InitializeComponent();
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptDepositReport_Detail));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
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
    this.Line12 = new Line();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.CheckBox1 = new CheckBox();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.Line1 = new Line();
    this.Line2 = new Line();
    this.Line3 = new Line();
    this.Line4 = new Line();
    this.Line5 = new Line();
    this.Line6 = new Line();
    this.Line7 = new Line();
    this.Line8 = new Line();
    this.Line9 = new Line();
    this.Line10 = new Line();
    this.Line11 = new Line();
    this.txtCheckAmountTotal = new TextBox();
    this.txtAPTotal = new TextBox();
    this.txtIncomeTotal = new TextBox();
    this.txtARTotal = new TextBox();
    this.txtUnAcctTotal = new TextBox();
    this.txtExchTotal = new TextBox();
    this.txtExpenseTotal = new TextBox();
    this.txtTransferTotal = new TextBox();
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
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.CheckBox1).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.txtCheckAmountTotal).BeginInit();
    ((ISupportInitialize) this.txtAPTotal).BeginInit();
    ((ISupportInitialize) this.txtIncomeTotal).BeginInit();
    ((ISupportInitialize) this.txtARTotal).BeginInit();
    ((ISupportInitialize) this.txtUnAcctTotal).BeginInit();
    ((ISupportInitialize) this.txtExchTotal).BeginInit();
    ((ISupportInitialize) this.txtExpenseTotal).BeginInit();
    ((ISupportInitialize) this.txtTransferTotal).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[23]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.CheckBox1,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.Line1,
      (ARControl) this.Line2,
      (ARControl) this.Line3,
      (ARControl) this.Line4,
      (ARControl) this.Line5,
      (ARControl) this.Line6,
      (ARControl) this.Line7,
      (ARControl) this.Line8,
      (ARControl) this.Line9,
      (ARControl) this.Line10,
      (ARControl) this.Line11
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[14]
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
      (ARControl) this.Line12
    });
    this.ReportHeader.Height = 0.4472222f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.txtCheckAmountTotal,
      (ARControl) this.txtAPTotal,
      (ARControl) this.txtIncomeTotal,
      (ARControl) this.txtARTotal,
      (ARControl) this.txtUnAcctTotal,
      (ARControl) this.txtExchTotal,
      (ARControl) this.txtExpenseTotal,
      (ARControl) this.txtTransferTotal
    });
    this.ReportFooter.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj1 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label1).Location = pointF1;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(0.75f, 3f / 16f);
    this.Label1.Text = "Check Date";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj2 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label2).Location = pointF2;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1f, 3f / 16f);
    this.Label2.Text = "Payee";
    this.Label3.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj3 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label3).Location = pointF3;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(0.375f, 0.2f);
    this.Label3.Text = "Void?";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj4 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label4).Location = pointF4;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(0.625f, 3f / 16f);
    this.Label4.Text = "Check #";
    this.Label5.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj5 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label5).Location = pointF5;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(15f / 16f, 3f / 16f);
    this.Label5.Text = "Check Amt.";
    this.Label6.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj6 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label6).Location = pointF6;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label6.Text = "Income Amt.";
    this.Label7.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj7 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label7).Location = pointF7;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label7.Text = "A/P Amt.";
    this.Label8.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj8 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label8).Location = pointF8;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(0.75f, 3f / 16f);
    this.Label8.Text = "A/R Amt.";
    this.Label9.Alignment = (TextAlignment) 2;
    this.Label9.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj9 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label9).Location = pointF9;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label9.Text = "Un-Acct Amt.";
    this.Label10.Alignment = (TextAlignment) 2;
    this.Label10.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj10 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label10).Location = pointF10;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label10.Text = "Exch. Amt.";
    this.Label11.Alignment = (TextAlignment) 2;
    this.Label11.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    this.Label11.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label11.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj11 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label11).Location = pointF11;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(0.75f, 3f / 16f);
    this.Label11.Text = "Exp. Amt.";
    this.Label12.Alignment = (TextAlignment) 2;
    this.Label12.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label12.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj12 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label12).Location = pointF12;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(0.875f, 3f / 16f);
    this.Label12.Text = "Transfer Amt.";
    this.Label13.Alignment = (TextAlignment) 1;
    this.Label13.BackColor = Color.WhiteSmoke;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    this.Label13.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label13.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj13 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label13).Location = pointF13;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(3.25f, 3f / 16f);
    this.Label13.Text = "OTHER";
    this.Line12.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line12.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line12.Border.RightStyle = (BorderLineStyle) 0;
    this.Line12.Border.TopStyle = (BorderLineStyle) 0;
    this.Line12.LineWeight = 1f;
    ((ARControl) this.Line12).Name = "Line12";
    this.Line12.X1 = 10.5f;
    this.Line12.X2 = 0.0f;
    this.Line12.Y1 = 0.4270833f;
    this.Line12.Y2 = 0.4270833f;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "checkDate";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj14 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox1).Location = pointF14;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox1).Size = new SizeF(11f / 16f, 0.125f);
    this.TextBox1.Text = "TextBox1";
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "payeeName";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj15 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox2).Location = pointF15;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(2.25f, 0.125f);
    this.TextBox2.Text = "TextBox2";
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "checkNumber";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj16 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) textBox4).Location = pointF16;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(0.75f, 0.125f);
    this.TextBox5.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "checkAmt";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj17 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox5).Location = pointF17;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox5).Size = new SizeF(15f / 16f, 0.125f);
    this.TextBox5.Text = "0.00";
    this.TextBox6.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "incomeAmt";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj18 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox6).Location = pointF18;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox6).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox6.Text = "0.00";
    this.TextBox7.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "apAmt";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox7 = this.TextBox7;
    object obj19 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) textBox7).Location = pointF19;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox7).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox7.Text = "0.00";
    this.TextBox8.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "arAmt";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox8 = this.TextBox8;
    object obj20 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) textBox8).Location = pointF20;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox8).Size = new SizeF(0.75f, 0.125f);
    this.TextBox8.Text = "0.00";
    this.TextBox9.Alignment = (TextAlignment) 2;
    this.TextBox9.BackColor = Color.WhiteSmoke;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "unAcctAmt";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox9.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox9 = this.TextBox9;
    object obj21 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox9).Location = pointF21;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox9).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox9.Text = "0.00";
    this.TextBox10.Alignment = (TextAlignment) 2;
    this.TextBox10.BackColor = Color.WhiteSmoke;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "exchAmt";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox10.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox10 = this.TextBox10;
    object obj22 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) textBox10).Location = pointF22;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox10).Size = new SizeF(13f / 16f, 0.125f);
    this.TextBox10.Text = "0.00";
    ((ARControl) this.CheckBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.CheckBox1).Border.TopStyle = (BorderLineStyle) 0;
    this.CheckBox1.CheckAlignment = ContentAlignment.TopCenter;
    ((ARControl) this.CheckBox1).DataField = "void";
    this.CheckBox1.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.CheckBox1.ForeColor = Color.FromArgb(0, 0, 0);
    CheckBox checkBox1 = this.CheckBox1;
    object obj23 = componentResourceManager.GetObject("CheckBox1.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) checkBox1).Location = pointF23;
    ((ARControl) this.CheckBox1).Name = "CheckBox1";
    ((ARControl) this.CheckBox1).Size = new SizeF(3f / 16f, 0.125f);
    this.CheckBox1.Text = "";
    this.TextBox11.Alignment = (TextAlignment) 2;
    this.TextBox11.BackColor = Color.WhiteSmoke;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "expAmt";
    this.TextBox11.DistinctField = (string) null;
    this.TextBox11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox11.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox11 = this.TextBox11;
    object obj24 = componentResourceManager.GetObject("TextBox11.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) textBox11).Location = pointF24;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox11).Size = new SizeF(0.75f, 0.125f);
    this.TextBox11.Text = "0.00";
    this.TextBox12.Alignment = (TextAlignment) 2;
    this.TextBox12.BackColor = Color.WhiteSmoke;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "transferAmt";
    this.TextBox12.DistinctField = (string) null;
    this.TextBox12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox12.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox12 = this.TextBox12;
    object obj25 = componentResourceManager.GetObject("TextBox12.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) textBox12).Location = pointF25;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox12).Size = new SizeF(0.875f, 0.125f);
    this.TextBox12.Text = "0.00";
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    this.Line1.LineColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    this.Line1.X1 = 1f / 16f;
    this.Line1.X2 = 169f / 16f;
    this.Line1.Y1 = 0.125f;
    this.Line1.Y2 = 0.125f;
    this.Line2.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line2.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line2.Border.RightStyle = (BorderLineStyle) 0;
    this.Line2.Border.TopStyle = (BorderLineStyle) 0;
    this.Line2.LineColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    this.Line2.X1 = 10.5f;
    this.Line2.X2 = 10.5f;
    this.Line2.Y1 = 0.0f;
    this.Line2.Y2 = 0.125f;
    this.Line3.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line3.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line3.Border.RightStyle = (BorderLineStyle) 0;
    this.Line3.Border.TopStyle = (BorderLineStyle) 0;
    this.Line3.LineColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    this.Line3.X1 = 7.25f;
    this.Line3.X2 = 7.25f;
    this.Line3.Y1 = 0.0f;
    this.Line3.Y2 = 0.125f;
    this.Line4.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line4.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line4.Border.RightStyle = (BorderLineStyle) 0;
    this.Line4.Border.TopStyle = (BorderLineStyle) 0;
    this.Line4.LineColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Line4.LineWeight = 1f;
    ((ARControl) this.Line4).Name = "Line4";
    this.Line4.X1 = 129f / 16f;
    this.Line4.X2 = 129f / 16f;
    this.Line4.Y1 = 0.0f;
    this.Line4.Y2 = 0.125f;
    this.Line5.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line5.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line5.Border.RightStyle = (BorderLineStyle) 0;
    this.Line5.Border.TopStyle = (BorderLineStyle) 0;
    this.Line5.LineColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Line5.LineWeight = 1f;
    ((ARControl) this.Line5).Name = "Line5";
    this.Line5.X1 = 8.875f;
    this.Line5.X2 = 8.875f;
    this.Line5.Y1 = 0.0f;
    this.Line5.Y2 = 0.125f;
    this.Line6.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line6.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line6.Border.RightStyle = (BorderLineStyle) 0;
    this.Line6.Border.TopStyle = (BorderLineStyle) 0;
    this.Line6.LineColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Line6.LineWeight = 1f;
    ((ARControl) this.Line6).Name = "Line6";
    this.Line6.X1 = 9.625f;
    this.Line6.X2 = 9.625f;
    this.Line6.Y1 = 0.0f;
    this.Line6.Y2 = 0.125f;
    this.Line7.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line7.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line7.Border.RightStyle = (BorderLineStyle) 0;
    this.Line7.Border.TopStyle = (BorderLineStyle) 0;
    this.Line7.LineColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Line7.LineWeight = 1f;
    ((ARControl) this.Line7).Name = "Line7";
    this.Line7.X1 = 6.5f;
    this.Line7.X2 = 6.5f;
    this.Line7.Y1 = 0.0f;
    this.Line7.Y2 = 0.125f;
    this.Line8.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line8.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line8.Border.RightStyle = (BorderLineStyle) 0;
    this.Line8.Border.TopStyle = (BorderLineStyle) 0;
    this.Line8.LineColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Line8.LineWeight = 1f;
    ((ARControl) this.Line8).Name = "Line8";
    this.Line8.X1 = 91f / 16f;
    this.Line8.X2 = 91f / 16f;
    this.Line8.Y1 = 0.0f;
    this.Line8.Y2 = 0.125f;
    this.Line9.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line9.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line9.Border.RightStyle = (BorderLineStyle) 0;
    this.Line9.Border.TopStyle = (BorderLineStyle) 0;
    this.Line9.LineColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Line9.LineWeight = 1f;
    ((ARControl) this.Line9).Name = "Line9";
    this.Line9.X1 = 79f / 16f;
    this.Line9.X2 = 79f / 16f;
    this.Line9.Y1 = 0.0f;
    this.Line9.Y2 = 0.125f;
    this.Line10.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line10.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line10.Border.RightStyle = (BorderLineStyle) 0;
    this.Line10.Border.TopStyle = (BorderLineStyle) 0;
    this.Line10.LineColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Line10.LineWeight = 1f;
    ((ARControl) this.Line10).Name = "Line10";
    this.Line10.X1 = 3.875f;
    this.Line10.X2 = 3.875f;
    this.Line10.Y1 = 0.0f;
    this.Line10.Y2 = 0.125f;
    this.Line11.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line11.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line11.Border.RightStyle = (BorderLineStyle) 0;
    this.Line11.Border.TopStyle = (BorderLineStyle) 0;
    this.Line11.LineColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Line11.LineWeight = 1f;
    ((ARControl) this.Line11).Name = "Line11";
    this.Line11.X1 = 11f / 16f;
    this.Line11.X2 = 11f / 16f;
    this.Line11.Y1 = 0.0f;
    this.Line11.Y2 = 0.125f;
    this.txtCheckAmountTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCheckAmountTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmountTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmountTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCheckAmountTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCheckAmountTotal.DistinctField = (string) null;
    this.txtCheckAmountTotal.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtCheckAmountTotal.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox checkAmountTotal = this.txtCheckAmountTotal;
    object obj26 = componentResourceManager.GetObject("txtCheckAmountTotal.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) checkAmountTotal).Location = pointF26;
    ((ARControl) this.txtCheckAmountTotal).Name = "txtCheckAmountTotal";
    this.txtCheckAmountTotal.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtCheckAmountTotal).Size = new SizeF(15f / 16f, 3f / 16f);
    this.txtAPTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtAPTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAPTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAPTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAPTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtAPTotal.DistinctField = (string) null;
    this.txtAPTotal.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtAPTotal.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtApTotal = this.txtAPTotal;
    object obj27 = componentResourceManager.GetObject("txtAPTotal.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) txtApTotal).Location = pointF27;
    ((ARControl) this.txtAPTotal).Name = "txtAPTotal";
    this.txtAPTotal.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtAPTotal).Size = new SizeF(13f / 16f, 3f / 16f);
    this.txtAPTotal.Text = " ";
    this.txtIncomeTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtIncomeTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtIncomeTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtIncomeTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtIncomeTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtIncomeTotal.DistinctField = (string) null;
    this.txtIncomeTotal.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtIncomeTotal.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtIncomeTotal = this.txtIncomeTotal;
    object obj28 = componentResourceManager.GetObject("txtIncomeTotal.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) txtIncomeTotal).Location = pointF28;
    ((ARControl) this.txtIncomeTotal).Name = "txtIncomeTotal";
    this.txtIncomeTotal.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtIncomeTotal).Size = new SizeF(13f / 16f, 3f / 16f);
    this.txtIncomeTotal.Text = " ";
    this.txtARTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtARTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtARTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtARTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtARTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtARTotal.DistinctField = (string) null;
    this.txtARTotal.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtARTotal.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtArTotal = this.txtARTotal;
    object obj29 = componentResourceManager.GetObject("txtARTotal.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) txtArTotal).Location = pointF29;
    ((ARControl) this.txtARTotal).Name = "txtARTotal";
    this.txtARTotal.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtARTotal).Size = new SizeF(0.75f, 3f / 16f);
    this.txtARTotal.Text = " ";
    this.txtUnAcctTotal.Alignment = (TextAlignment) 2;
    this.txtUnAcctTotal.BackColor = Color.WhiteSmoke;
    ((ARControl) this.txtUnAcctTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnAcctTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnAcctTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnAcctTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtUnAcctTotal.DistinctField = (string) null;
    this.txtUnAcctTotal.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtUnAcctTotal.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtUnAcctTotal = this.txtUnAcctTotal;
    object obj30 = componentResourceManager.GetObject("txtUnAcctTotal.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) txtUnAcctTotal).Location = pointF30;
    ((ARControl) this.txtUnAcctTotal).Name = "txtUnAcctTotal";
    this.txtUnAcctTotal.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtUnAcctTotal).Size = new SizeF(13f / 16f, 3f / 16f);
    this.txtUnAcctTotal.Text = " ";
    this.txtExchTotal.Alignment = (TextAlignment) 2;
    this.txtExchTotal.BackColor = Color.WhiteSmoke;
    ((ARControl) this.txtExchTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExchTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExchTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExchTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtExchTotal.DistinctField = (string) null;
    this.txtExchTotal.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtExchTotal.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtExchTotal = this.txtExchTotal;
    object obj31 = componentResourceManager.GetObject("txtExchTotal.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) txtExchTotal).Location = pointF31;
    ((ARControl) this.txtExchTotal).Name = "txtExchTotal";
    this.txtExchTotal.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtExchTotal).Size = new SizeF(13f / 16f, 3f / 16f);
    this.txtExchTotal.Text = " ";
    this.txtExpenseTotal.Alignment = (TextAlignment) 2;
    this.txtExpenseTotal.BackColor = Color.WhiteSmoke;
    ((ARControl) this.txtExpenseTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExpenseTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExpenseTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExpenseTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtExpenseTotal.DistinctField = (string) null;
    this.txtExpenseTotal.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtExpenseTotal.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtExpenseTotal = this.txtExpenseTotal;
    object obj32 = componentResourceManager.GetObject("txtExpenseTotal.Location");
    PointF pointF32 = obj32 != null ? (PointF) obj32 : new PointF();
    ((ARControl) txtExpenseTotal).Location = pointF32;
    ((ARControl) this.txtExpenseTotal).Name = "txtExpenseTotal";
    this.txtExpenseTotal.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtExpenseTotal).Size = new SizeF(13f / 16f, 3f / 16f);
    this.txtExpenseTotal.Text = " ";
    this.txtTransferTotal.Alignment = (TextAlignment) 2;
    this.txtTransferTotal.BackColor = Color.WhiteSmoke;
    ((ARControl) this.txtTransferTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransferTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransferTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransferTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.txtTransferTotal.DistinctField = (string) null;
    this.txtTransferTotal.Font = new Font("Arial", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtTransferTotal.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtTransferTotal = this.txtTransferTotal;
    object obj33 = componentResourceManager.GetObject("txtTransferTotal.Location");
    PointF pointF33 = obj33 != null ? (PointF) obj33 : new PointF();
    ((ARControl) txtTransferTotal).Location = pointF33;
    ((ARControl) this.txtTransferTotal).Name = "txtTransferTotal";
    this.txtTransferTotal.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtTransferTotal).Size = new SizeF(13f / 16f, 3f / 16f);
    this.txtTransferTotal.Text = " ";
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.2f;
    this.PageSettings.Margins.Left = 0.2f;
    this.PageSettings.Margins.Right = 0.2f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperName = "";
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 337f / 32f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
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
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.CheckBox1).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.txtCheckAmountTotal).EndInit();
    ((ISupportInitialize) this.txtAPTotal).EndInit();
    ((ISupportInitialize) this.txtIncomeTotal).EndInit();
    ((ISupportInitialize) this.txtARTotal).EndInit();
    ((ISupportInitialize) this.txtUnAcctTotal).EndInit();
    ((ISupportInitialize) this.txtExchTotal).EndInit();
    ((ISupportInitialize) this.txtExpenseTotal).EndInit();
    ((ISupportInitialize) this.txtTransferTotal).EndInit();
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (this.CheckBox1.Checked)
    {
      this.TextBox5.Font = this.strikeFont;
      this.TextBox6.Font = this.strikeFont;
      this.TextBox7.Font = this.strikeFont;
      this.TextBox8.Font = this.strikeFont;
      this.TextBox9.Font = this.strikeFont;
      this.TextBox10.Font = this.strikeFont;
      this.TextBox11.Font = this.strikeFont;
      this.TextBox12.Font = this.strikeFont;
    }
    else
    {
      this.TextBox5.Font = this.noStrikeFont;
      this.TextBox6.Font = this.noStrikeFont;
      this.TextBox7.Font = this.noStrikeFont;
      this.TextBox8.Font = this.noStrikeFont;
      this.TextBox9.Font = this.noStrikeFont;
      this.TextBox10.Font = this.noStrikeFont;
      this.TextBox11.Font = this.noStrikeFont;
      this.TextBox12.Font = this.noStrikeFont;
    }
  }

  private void ReportFooter_Format(object sender, EventArgs e)
  {
    DataTable dataSource = (DataTable) this.DataSource;
    this.txtCheckAmountTotal.Value = RuntimeHelpers.GetObjectValue(dataSource.Compute("Sum(checkAmt)", "void=0"));
    this.txtIncomeTotal.Value = RuntimeHelpers.GetObjectValue(dataSource.Compute("Sum(incomeAmt)", "void=0"));
    this.txtAPTotal.Value = RuntimeHelpers.GetObjectValue(dataSource.Compute("Sum(apAmt)", "void=0"));
    this.txtARTotal.Value = RuntimeHelpers.GetObjectValue(dataSource.Compute("Sum(arAmt)", "void=0"));
    this.txtUnAcctTotal.Value = RuntimeHelpers.GetObjectValue(dataSource.Compute("Sum(unAcctAmt)", "void=0"));
    this.txtExchTotal.Value = RuntimeHelpers.GetObjectValue(dataSource.Compute("Sum(exchAmt)", "void=0"));
    this.txtExpenseTotal.Value = RuntimeHelpers.GetObjectValue(dataSource.Compute("Sum(expAmt)", "void=0"));
    this.txtTransferTotal.Value = RuntimeHelpers.GetObjectValue(dataSource.Compute("Sum(transferAmt)", "void=0"));
  }

  protected override void Dispose(bool disposing)
  {
    this.strikeFont.Dispose();
    this.noStrikeFont.Dispose();
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

  private virtual ReportFooter ReportFooter
  {
    get => this._ReportFooter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportFooter_Format);
      ReportFooter reportFooter1 = this._ReportFooter;
      if (reportFooter1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter1).Format -= eventHandler;
      this._ReportFooter = value;
      ReportFooter reportFooter2 = this._ReportFooter;
      if (reportFooter2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter2).Format += eventHandler;
    }
  }
}
