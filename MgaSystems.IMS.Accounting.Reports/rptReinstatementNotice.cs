// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptReinstatementNotice
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptReinstatementNotice : SectionReport
{
  private int _QuoteID;
  private Image _signature;
  private Label Label2;
  private Label Label3;
  private TextBox TextBox1;
  private Label Label1;
  private TextBox TextBox2;
  private Label Label4;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private Label Label5;
  private TextBox TextBox5;
  private Label Label6;
  private TextBox TextBox6;
  private Label Label7;
  private TextBox TextBox7;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private TextBox TextBox8;
  private Label Label11;
  private TextBox TextBox9;
  private Picture Picture1;
  private Label Label12;
  private TextBox txtQuoteId;
  private TextBox TextBox11;
  private TextBox TextBox12;
  private TextBox TextBox13;

  public rptReinstatementNotice()
  {
    this.PageStart += new EventHandler(this.rptReinstatementNotice_PageStart);
    this.InitializeComponent();
  }

  public rptReinstatementNotice(int QuoteID)
  {
    this.PageStart += new EventHandler(this.rptReinstatementNotice_PageStart);
    this.InitializeComponent();
    this._QuoteID = QuoteID;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptReinstatementNotice));
    this.Detail = new Detail();
    this.Label15 = new Label();
    this.Label14 = new Label();
    this.Label13 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.TextBox1 = new TextBox();
    this.Label1 = new Label();
    this.TextBox2 = new TextBox();
    this.Label4 = new Label();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.Label5 = new Label();
    this.TextBox5 = new TextBox();
    this.Label6 = new Label();
    this.TextBox6 = new TextBox();
    this.Label7 = new Label();
    this.TextBox7 = new TextBox();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.TextBox8 = new TextBox();
    this.Label11 = new Label();
    this.TextBox9 = new TextBox();
    this.Picture1 = new Picture();
    this.Label12 = new Label();
    this.txtQuoteId = new TextBox();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.Picture1).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.txtQuoteId).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).BackColor = Color.FromArgb(211, 211, 211);
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[26]
    {
      (ARControl) this.Label15,
      (ARControl) this.Label14,
      (ARControl) this.Label13,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.TextBox1,
      (ARControl) this.Label1,
      (ARControl) this.TextBox2,
      (ARControl) this.Label4,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.TextBox6,
      (ARControl) this.Label7,
      (ARControl) this.TextBox7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.TextBox8,
      (ARControl) this.Label11,
      (ARControl) this.TextBox9,
      (ARControl) this.Picture1,
      (ARControl) this.Label12,
      (ARControl) this.txtQuoteId,
      (ARControl) this.TextBox5
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 6.5f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    this.Label15.BackColor = Color.White;
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 0;
    this.Label15.Font = new Font("Arial", 10f);
    this.Label15.HyperLink = (string) null;
    Label label15 = this.Label15;
    object obj1 = componentResourceManager.GetObject("Label15.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label15).Location = pointF1;
    ((ARControl) this.Label15).Name = "Label15";
    ((ARControl) this.Label15).Size = new SizeF(5f, 17f / 16f);
    this.Label15.Text = "";
    this.Label14.BackColor = Color.White;
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    this.Label14.Font = new Font("Arial", 10f);
    this.Label14.HyperLink = (string) null;
    Label label14 = this.Label14;
    object obj2 = componentResourceManager.GetObject("Label14.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label14).Location = pointF2;
    ((ARControl) this.Label14).Name = "Label14";
    ((ARControl) this.Label14).Size = new SizeF(5f, 17f / 16f);
    this.Label14.Text = "";
    this.Label13.BackColor = Color.White;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    this.Label13.Font = new Font("Arial", 10f);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj3 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label13).Location = pointF3;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(5f, 17f / 16f);
    this.Label13.Text = "";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 11f, System.Drawing.FontStyle.Bold);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj4 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label2).Location = pointF4;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1f, 0.375f);
    this.Label2.Text = "Insurance Company";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 11f, System.Drawing.FontStyle.Bold);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj5 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label3).Location = pointF5;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(1.125f, 0.25f);
    this.Label3.Text = "Policy Number";
    this.TextBox1.BackColor = Color.White;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "CompanyName";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj6 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) textBox1).Location = pointF6;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(87f / 16f, 0.375f);
    this.TextBox1.Text = " ";
    this.Label1.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj7 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label1).Location = pointF7;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(7.875f, 3f / 16f);
    this.Label1.Text = "REINSTATEMENT NOTICE";
    this.TextBox2.BackColor = Color.White;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "PolicyNumber";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox2 = this.TextBox2;
    object obj8 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox2).Location = pointF8;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(2.875f, 0.5f);
    this.TextBox2.Text = " ";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 11f, System.Drawing.FontStyle.Bold);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj9 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label4).Location = pointF9;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(33f / 16f, 0.25f);
    this.Label4.Text = "Reinstatement is effective";
    this.TextBox3.BackColor = Color.White;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "EffectiveDate";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox3 = this.TextBox3;
    object obj10 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox3).Location = pointF10;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox3).Size = new SizeF(17f / 16f, 3f / 16f);
    this.TextBox3.Text = " ";
    this.TextBox4.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    TextBox textBox4 = this.TextBox4;
    object obj11 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox4).Location = pointF11;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "h:mm tt STD";
    ((ARControl) this.TextBox4).Size = new SizeF(17f / 16f, 3f / 16f);
    this.TextBox4.Text = "12:01 AM STD";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 11f, System.Drawing.FontStyle.Bold);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj12 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label5).Location = pointF12;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(5f, 3f / 16f);
    this.Label5.Text = "Insured's Name and Address";
    this.TextBox5.BackColor = Color.White;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "Insured";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox5 = this.TextBox5;
    object obj13 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox5).Location = pointF13;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = (string) null;
    ((ARControl) this.TextBox5).Size = new SizeF(4.375f, 17f / 16f);
    this.TextBox5.Text = " ";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 11f, System.Drawing.FontStyle.Bold);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj14 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) label6).Location = pointF14;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(5f, 3f / 16f);
    this.Label6.Text = "Producer's Name and Address";
    this.TextBox6.BackColor = Color.White;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "Producer";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox6 = this.TextBox6;
    object obj15 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox6).Location = pointF15;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = (string) null;
    ((ARControl) this.TextBox6).Size = new SizeF(4.375f, 17f / 16f);
    this.TextBox6.Text = " ";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 11f, System.Drawing.FontStyle.Bold);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj16 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) label7).Location = pointF16;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(5f, 3f / 16f);
    this.Label7.Text = "Mortgagee/Loss Payee and Address";
    this.TextBox7.BackColor = Color.White;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "Mortgagee";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox7 = this.TextBox7;
    object obj17 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox7).Location = pointF17;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = (string) null;
    ((ARControl) this.TextBox7).Size = new SizeF(4.375f, 17f / 16f);
    this.TextBox7.Text = " ";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 11f, System.Drawing.FontStyle.Bold);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj18 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) label8).Location = pointF18;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(1.75f, 9f / 16f);
    this.Label8.Text = "Please disregard the Notice of Cancellation previously sent to you.";
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 11f, System.Drawing.FontStyle.Bold);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj19 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) label9).Location = pointF19;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(1.75f, 9f / 16f);
    this.Label9.Text = "Your Policy has been reinstated on the date and time shown above.";
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 11f, System.Drawing.FontStyle.Bold);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj20 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) label10).Location = pointF20;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(0.5f, 3f / 16f);
    this.Label10.Text = "Date:";
    this.TextBox8.BackColor = Color.White;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "PrintDate";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox8 = this.TextBox8;
    object obj21 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox8).Location = pointF21;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox8).Size = new SizeF(17f / 16f, 3f / 16f);
    this.TextBox8.Text = " ";
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    this.Label11.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj22 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) label11).Location = pointF22;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(0.625f, 3f / 16f);
    this.Label11.Text = "Issued by:";
    this.TextBox9.BackColor = Color.White;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "Office";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox9 = this.TextBox9;
    object obj23 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) textBox9).Location = pointF23;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = (string) null;
    ((ARControl) this.TextBox9).Size = new SizeF(111f / 16f, 3f / 16f);
    this.TextBox9.Text = (string) null;
    this.Picture1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    ((ARControl) this.Picture1).Border.BottomStyle = (BorderLineStyle) 13;
    ((ARControl) this.Picture1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Picture1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Picture1).Border.TopStyle = (BorderLineStyle) 0;
    this.Picture1.Image = (Image) null;
    this.Picture1.ImageData = (Stream) null;
    this.Picture1.LineColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    this.Picture1.LineWeight = 0.0f;
    Picture picture1 = this.Picture1;
    object obj24 = componentResourceManager.GetObject("Picture1.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) picture1).Location = pointF24;
    ((ARControl) this.Picture1).Name = "Picture1";
    ((ARControl) this.Picture1).Size = new SizeF(39f / 16f, 0.625f);
    this.Label12.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj25 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) label12).Location = pointF25;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(39f / 16f, 3f / 16f);
    this.Label12.Text = "Authorized Representative";
    ((ARControl) this.txtQuoteId).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtQuoteId).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtQuoteId).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtQuoteId).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtQuoteId).DataField = "QuoteId";
    this.txtQuoteId.DistinctField = (string) null;
    this.txtQuoteId.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtQuoteId = this.txtQuoteId;
    object obj26 = componentResourceManager.GetObject("txtQuoteId.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) txtQuoteId).Location = pointF26;
    ((ARControl) this.txtQuoteId).Name = "txtQuoteId";
    this.txtQuoteId.OutputFormat = (string) null;
    ((ARControl) this.txtQuoteId).Size = new SizeF(1f, 0.2f);
    this.txtQuoteId.Text = (string) null;
    ((ARControl) this.txtQuoteId).Visible = false;
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.GroupHeader1.DataField = "RecordCount";
    this.GroupHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13
    });
    this.GroupFooter1.Height = 0.9881945f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.GroupFooter1.NewPage = (NewPage) 2;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "ControlNum";
    this.TextBox11.DistinctField = (string) null;
    this.TextBox11.Font = new Font("Arial", 8f);
    TextBox textBox11 = this.TextBox11;
    object obj27 = componentResourceManager.GetObject("TextBox11.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) textBox11).Location = pointF27;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = (string) null;
    ((ARControl) this.TextBox11).Size = new SizeF(1f, 3f / 16f);
    this.TextBox11.Text = (string) null;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "Initiass";
    this.TextBox12.DistinctField = (string) null;
    this.TextBox12.Font = new Font("Arial", 8f);
    TextBox textBox12 = this.TextBox12;
    object obj28 = componentResourceManager.GetObject("TextBox12.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) textBox12).Location = pointF28;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = (string) null;
    ((ARControl) this.TextBox12).Size = new SizeF(1f, 3f / 16f);
    this.TextBox12.Text = (string) null;
    this.TextBox13.Alignment = (TextAlignment) 1;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "Copy";
    this.TextBox13.DistinctField = (string) null;
    this.TextBox13.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox13 = this.TextBox13;
    object obj29 = componentResourceManager.GetObject("TextBox13.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) textBox13).Location = pointF29;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = (string) null;
    ((ARControl) this.TextBox13).Size = new SizeF(7.875f, 0.2f);
    this.TextBox13.Text = (string) null;
    this.PageSettings.Margins.Bottom = 0.3f;
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
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.Picture1).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.txtQuoteId).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
  }

  private void Detail_Format(object sender, EventArgs e)
  {
  }

  private Image GetQuoteUserSignature(int QuoteID, string ConnectionString)
  {
    Image quoteUserSignature = (Image) null;
    SqlCommand sqlCommand1 = new SqlCommand("spFin_GetQuoteIdUserSignature", new SqlConnection(ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@quoteid", (object) QuoteID);
      sqlCommand2.Connection.Open();
      byte[] buffer = (byte[]) sqlCommand2.ExecuteScalar();
      if (buffer != null && buffer.Length != 0)
      {
        quoteUserSignature = (Image) new Bitmap((Stream) new MemoryStream(buffer));
        ((Bitmap) quoteUserSignature).MakeTransparent(((Bitmap) quoteUserSignature).GetPixel(0, 0));
      }
      return quoteUserSignature;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw ex;
    }
    finally
    {
      if (sqlCommand1 != null && sqlCommand1.Connection != null)
      {
        if (sqlCommand1.Connection.State != ConnectionState.Closed)
          sqlCommand1.Connection.Close();
        sqlCommand1.Connection.Dispose();
        sqlCommand1.Connection = (SqlConnection) null;
        sqlCommand1.Dispose();
      }
    }
  }

  private void rptReinstatementNotice_PageStart(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtQuoteId.Text, "", false) != 0 && Versioned.IsNumeric((object) this.txtQuoteId.Text))
      this._signature = this.GetQuoteUserSignature(Conversions.ToInteger(this.txtQuoteId.Text), CurrentUser.Instance.ConnectionString);
    if (this._signature != null)
      this.Picture1.Image = this._signature;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TextBox13.Text, "(Retailer Copy)", false) == 0)
      ((ARControl) this.TextBox6).DataField = "Retailer";
    else
      ((ARControl) this.TextBox6).DataField = "Producer";
  }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
