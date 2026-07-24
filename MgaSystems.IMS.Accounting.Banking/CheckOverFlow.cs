// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.CheckOverFlow
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public sealed class CheckOverFlow : SectionReport
{
  private Label lblCheckNumber;
  private Label lblPayee;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label5;
  private TextBox txtPolicyTerm;
  private TextBox txtCommissionPercent;
  private TextBox txtNetPremium;
  private TextBox grosspremium1;
  private TextBox txtGrossPremium;
  private TextBox TextBox1;
  private TextBox txtPolicyNumber;
  private TextBox txtInsuredName;
  private Label lblFeeBlocker;
  private TextBox txtChargetype;
  private TextBox grosspremium2;
  private Label lblFee;
  private TextBox paidNow1;
  private TextBox paidNow2;

  public CheckOverFlow() => this.InitializeComponent();

  public CheckOverFlow(DataTable dataTbl, string Payee, string CheckNumber)
  {
    this.InitializeComponent();
    this.DataSource = (object) dataTbl;
    this.lblCheckNumber.Text = "Check Number:\t" + CheckNumber;
    this.lblPayee.Text = Payee;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CheckOverFlow));
    this.Detail = new Detail();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.lblCheckNumber = new Label();
    this.lblPayee = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label5 = new Label();
    this.txtPolicyTerm = new TextBox();
    this.txtCommissionPercent = new TextBox();
    this.txtNetPremium = new TextBox();
    this.grosspremium1 = new TextBox();
    this.txtGrossPremium = new TextBox();
    this.TextBox1 = new TextBox();
    this.txtPolicyNumber = new TextBox();
    this.txtInsuredName = new TextBox();
    this.lblFeeBlocker = new Label();
    this.txtChargetype = new TextBox();
    this.grosspremium2 = new TextBox();
    this.lblFee = new Label();
    this.paidNow1 = new TextBox();
    this.paidNow2 = new TextBox();
    ((ISupportInitialize) this.lblCheckNumber).BeginInit();
    ((ISupportInitialize) this.lblPayee).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.txtPolicyTerm).BeginInit();
    ((ISupportInitialize) this.txtCommissionPercent).BeginInit();
    ((ISupportInitialize) this.txtNetPremium).BeginInit();
    ((ISupportInitialize) this.grosspremium1).BeginInit();
    ((ISupportInitialize) this.txtGrossPremium).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.txtPolicyNumber).BeginInit();
    ((ISupportInitialize) this.txtInsuredName).BeginInit();
    ((ISupportInitialize) this.lblFeeBlocker).BeginInit();
    ((ISupportInitialize) this.txtChargetype).BeginInit();
    ((ISupportInitialize) this.grosspremium2).BeginInit();
    ((ISupportInitialize) this.lblFee).BeginInit();
    ((ISupportInitialize) this.paidNow1).BeginInit();
    ((ISupportInitialize) this.paidNow2).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[12]
    {
      (ARControl) this.txtPolicyTerm,
      (ARControl) this.txtCommissionPercent,
      (ARControl) this.txtNetPremium,
      (ARControl) this.grosspremium1,
      (ARControl) this.txtGrossPremium,
      (ARControl) this.TextBox1,
      (ARControl) this.txtPolicyNumber,
      (ARControl) this.txtInsuredName,
      (ARControl) this.lblFeeBlocker,
      (ARControl) this.txtChargetype,
      (ARControl) this.grosspremium2,
      (ARControl) this.lblFee
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.lblCheckNumber,
      (ARControl) this.lblPayee
    });
    this.PageHeader.Height = 0.2909722f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label5
    });
    this.GroupHeader1.Height = 0.1145833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupHeader1.RepeatStyle = (RepeatStyle) 1;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.paidNow1,
      (ARControl) this.paidNow2
    });
    this.GroupFooter1.Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.lblCheckNumber.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblCheckNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCheckNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCheckNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCheckNumber).Border.TopStyle = (BorderLineStyle) 0;
    this.lblCheckNumber.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheckNumber.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblCheckNumber.HyperLink = (string) null;
    Label lblCheckNumber = this.lblCheckNumber;
    object obj1 = componentResourceManager.GetObject("lblCheckNumber.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) lblCheckNumber).Location = pointF1;
    ((ARControl) this.lblCheckNumber).Name = "lblCheckNumber";
    ((ARControl) this.lblCheckNumber).Size = new SizeF(31f / 16f, 3f / 16f);
    this.lblCheckNumber.Text = "lblCheckNumber";
    ((ARControl) this.lblPayee).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayee).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayee).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblPayee).Border.TopStyle = (BorderLineStyle) 0;
    this.lblPayee.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblPayee.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblPayee.HyperLink = (string) null;
    Label lblPayee = this.lblPayee;
    object obj2 = componentResourceManager.GetObject("lblPayee.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) lblPayee).Location = pointF2;
    ((ARControl) this.lblPayee).Name = "lblPayee";
    ((ARControl) this.lblPayee).Size = new SizeF(3.75f, 0.25f);
    this.lblPayee.Text = "lblPayee";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj3 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label1).Location = pointF3;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(1f, 0.125f);
    this.Label1.Text = "Insured Name";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj4 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label2).Location = pointF4;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(0.875f, 0.125f);
    this.Label2.Text = "Policy Number";
    this.Label3.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj5 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label3).Location = pointF5;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(15f / 16f, 0.125f);
    this.Label3.Text = "Gross Premium";
    this.Label4.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj6 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label4).Location = pointF6;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(0.75f, 0.125f);
    this.Label4.Text = "Paid Previous";
    this.Label6.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj7 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label6).Location = pointF7;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(13f / 16f, 0.125f);
    this.Label6.Text = "Balance";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj8 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label7).Location = pointF8;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(11f / 16f, 0.125f);
    this.Label7.Text = "Description";
    this.Label8.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj9 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label8).Location = pointF9;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(9f / 16f, 0.125f);
    this.Label8.Text = "Comm %";
    this.Label9.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj10 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label9).Location = pointF10;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(15f / 16f, 0.125f);
    this.Label9.Text = "Gross Comm.";
    this.Label5.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj11 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label5).Location = pointF11;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(0.625f, 0.125f);
    this.Label5.Text = "Paid Now";
    this.txtPolicyTerm.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtPolicyTerm).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyTerm).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyTerm).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyTerm).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyTerm).DataField = "Balance";
    this.txtPolicyTerm.DistinctField = (string) null;
    this.txtPolicyTerm.Font = new Font("Arial", 7f);
    this.txtPolicyTerm.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtPolicyTerm = this.txtPolicyTerm;
    object obj12 = componentResourceManager.GetObject("txtPolicyTerm.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) txtPolicyTerm).Location = pointF12;
    ((ARControl) this.txtPolicyTerm).Name = "txtPolicyTerm";
    this.txtPolicyTerm.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtPolicyTerm).Size = new SizeF(0.7708333f, 0.125f);
    this.txtCommissionPercent.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCommissionPercent).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCommissionPercent).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCommissionPercent).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCommissionPercent).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCommissionPercent).DataField = "paidNow";
    this.txtCommissionPercent.DistinctField = (string) null;
    this.txtCommissionPercent.Font = new Font("Arial", 7f);
    this.txtCommissionPercent.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox commissionPercent = this.txtCommissionPercent;
    object obj13 = componentResourceManager.GetObject("txtCommissionPercent.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) commissionPercent).Location = pointF13;
    ((ARControl) this.txtCommissionPercent).Name = "txtCommissionPercent";
    this.txtCommissionPercent.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtCommissionPercent).Size = new SizeF(0.75f, 0.125f);
    this.txtCommissionPercent.Text = " ";
    this.txtNetPremium.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtNetPremium).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtNetPremium).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtNetPremium).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtNetPremium).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtNetPremium).DataField = "prevpaid";
    this.txtNetPremium.DistinctField = (string) null;
    this.txtNetPremium.Font = new Font("Arial", 7f);
    this.txtNetPremium.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtNetPremium = this.txtNetPremium;
    object obj14 = componentResourceManager.GetObject("txtNetPremium.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) txtNetPremium).Location = pointF14;
    ((ARControl) this.txtNetPremium).Name = "txtNetPremium";
    this.txtNetPremium.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtNetPremium).Size = new SizeF(0.75f, 0.125f);
    this.txtNetPremium.Text = " ";
    this.grosspremium1.Alignment = (TextAlignment) 2;
    ((ARControl) this.grosspremium1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspremium1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspremium1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspremium1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspremium1).DataField = "commissionpercentage";
    this.grosspremium1.DistinctField = (string) null;
    this.grosspremium1.Font = new Font("Arial", 7f);
    this.grosspremium1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox grosspremium1 = this.grosspremium1;
    object obj15 = componentResourceManager.GetObject("grosspremium1.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) grosspremium1).Location = pointF15;
    ((ARControl) this.grosspremium1).Name = "grosspremium1";
    this.grosspremium1.OutputFormat = "0.00%";
    ((ARControl) this.grosspremium1).Size = new SizeF(9f / 16f, 0.125f);
    this.grosspremium1.Text = " ";
    this.txtGrossPremium.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtGrossPremium).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrossPremium).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrossPremium).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrossPremium).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtGrossPremium).DataField = "grosspremium";
    this.txtGrossPremium.DistinctField = (string) null;
    this.txtGrossPremium.Font = new Font("Arial", 7f);
    this.txtGrossPremium.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtGrossPremium = this.txtGrossPremium;
    object obj16 = componentResourceManager.GetObject("txtGrossPremium.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) txtGrossPremium).Location = pointF16;
    ((ARControl) this.txtGrossPremium).Name = "txtGrossPremium";
    this.txtGrossPremium.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtGrossPremium).Size = new SizeF(0.75f, 0.125f);
    this.txtGrossPremium.Text = " ";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "Description";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj17 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox1).Location = pointF17;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(0.875f, 0.125f);
    ((ARControl) this.txtPolicyNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).DataField = "policynumber";
    this.txtPolicyNumber.DistinctField = (string) null;
    this.txtPolicyNumber.Font = new Font("Arial", 7f);
    this.txtPolicyNumber.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtPolicyNumber = this.txtPolicyNumber;
    object obj18 = componentResourceManager.GetObject("txtPolicyNumber.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) txtPolicyNumber).Location = pointF18;
    ((ARControl) this.txtPolicyNumber).Name = "txtPolicyNumber";
    this.txtPolicyNumber.OutputFormat = (string) null;
    ((ARControl) this.txtPolicyNumber).Size = new SizeF(1.125f, 0.125f);
    this.txtPolicyNumber.Text = " ";
    ((ARControl) this.txtInsuredName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsuredName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsuredName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsuredName).Border.TopStyle = (BorderLineStyle) 0;
    this.txtInsuredName.CanGrow = false;
    ((ARControl) this.txtInsuredName).DataField = "insuredname";
    this.txtInsuredName.DistinctField = (string) null;
    this.txtInsuredName.Font = new Font("Arial", 7f);
    this.txtInsuredName.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtInsuredName = this.txtInsuredName;
    object obj19 = componentResourceManager.GetObject("txtInsuredName.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) txtInsuredName).Location = pointF19;
    ((ARControl) this.txtInsuredName).Name = "txtInsuredName";
    this.txtInsuredName.OutputFormat = (string) null;
    ((ARControl) this.txtInsuredName).Size = new SizeF(21f / 16f, 0.125f);
    this.txtInsuredName.WordWrap = false;
    this.lblFeeBlocker.Alignment = (TextAlignment) 1;
    this.lblFeeBlocker.BackColor = Color.White;
    ((ARControl) this.lblFeeBlocker).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblFeeBlocker).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblFeeBlocker).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblFeeBlocker).Border.TopStyle = (BorderLineStyle) 0;
    this.lblFeeBlocker.Font = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblFeeBlocker.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblFeeBlocker.HyperLink = (string) null;
    Label lblFeeBlocker = this.lblFeeBlocker;
    object obj20 = componentResourceManager.GetObject("lblFeeBlocker.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) lblFeeBlocker).Location = pointF20;
    ((ARControl) this.lblFeeBlocker).Name = "lblFeeBlocker";
    ((ARControl) this.lblFeeBlocker).Size = new SizeF(27f / 32f, 0.125f);
    this.lblFeeBlocker.Text = "";
    this.lblFeeBlocker.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.txtChargetype).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtChargetype).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtChargetype).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtChargetype).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtChargetype).DataField = "chargeType";
    this.txtChargetype.DistinctField = (string) null;
    this.txtChargetype.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtChargetype.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtChargetype = this.txtChargetype;
    object obj21 = componentResourceManager.GetObject("txtChargetype.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) txtChargetype).Location = pointF21;
    ((ARControl) this.txtChargetype).Name = "txtChargetype";
    this.txtChargetype.OutputFormat = (string) null;
    ((ARControl) this.txtChargetype).Size = new SizeF(1f, 0.2f);
    ((ARControl) this.txtChargetype).Visible = false;
    this.grosspremium2.Alignment = (TextAlignment) 2;
    ((ARControl) this.grosspremium2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspremium2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspremium2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspremium2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspremium2).DataField = "grossCommission";
    this.grosspremium2.DistinctField = (string) null;
    this.grosspremium2.Font = new Font("Arial", 7f);
    this.grosspremium2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox grosspremium2 = this.grosspremium2;
    object obj22 = componentResourceManager.GetObject("grosspremium2.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) grosspremium2).Location = pointF22;
    ((ARControl) this.grosspremium2).Name = "grosspremium2";
    this.grosspremium2.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.grosspremium2).Size = new SizeF(0.75f, 0.125f);
    this.grosspremium2.Text = " ";
    this.lblFee.Alignment = (TextAlignment) 1;
    this.lblFee.BackColor = Color.White;
    ((ARControl) this.lblFee).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblFee).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblFee).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblFee).Border.TopStyle = (BorderLineStyle) 0;
    this.lblFee.Font = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblFee.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblFee.HyperLink = (string) null;
    Label lblFee = this.lblFee;
    object obj23 = componentResourceManager.GetObject("lblFee.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) lblFee).Location = pointF23;
    ((ARControl) this.lblFee).Name = "lblFee";
    ((ARControl) this.lblFee).Size = new SizeF(45f / 16f, 0.125f);
    this.lblFee.Text = "Fee";
    this.lblFee.VerticalAlignment = (VerticalTextAlignment) 1;
    this.paidNow1.Alignment = (TextAlignment) 2;
    ((ARControl) this.paidNow1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.paidNow1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.paidNow1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.paidNow1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.paidNow1).DataField = "paidNow";
    this.paidNow1.DistinctField = (string) null;
    this.paidNow1.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.paidNow1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox paidNow1 = this.paidNow1;
    object obj24 = componentResourceManager.GetObject("paidNow1.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) paidNow1).Location = pointF24;
    ((ARControl) this.paidNow1).Name = "paidNow1";
    this.paidNow1.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.paidNow1).Size = new SizeF(31f / 16f, 0.125f);
    this.paidNow1.SummaryGroup = "GroupHeader1";
    this.paidNow1.SummaryRunning = (SummaryRunning) 2;
    this.paidNow1.SummaryType = (SummaryType) 1;
    this.paidNow1.Text = " ";
    this.paidNow2.Alignment = (TextAlignment) 2;
    ((ARControl) this.paidNow2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.paidNow2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.paidNow2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.paidNow2).Border.TopStyle = (BorderLineStyle) 0;
    this.paidNow2.DistinctField = (string) null;
    this.paidNow2.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.paidNow2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox paidNow2 = this.paidNow2;
    object obj25 = componentResourceManager.GetObject("paidNow2.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) paidNow2).Location = pointF25;
    ((ARControl) this.paidNow2).Name = "paidNow2";
    this.paidNow2.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.paidNow2).Size = new SizeF(31f / 16f, 0.125f);
    this.paidNow2.Text = " Check Total:";
    this.PageSettings.Margins.Bottom = 0.2f;
    this.PageSettings.Margins.Left = 0.2f;
    this.PageSettings.Margins.Right = 0.2f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.802083f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    ((ISupportInitialize) this.lblCheckNumber).EndInit();
    ((ISupportInitialize) this.lblPayee).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.txtPolicyTerm).EndInit();
    ((ISupportInitialize) this.txtCommissionPercent).EndInit();
    ((ISupportInitialize) this.txtNetPremium).EndInit();
    ((ISupportInitialize) this.grosspremium1).EndInit();
    ((ISupportInitialize) this.txtGrossPremium).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.txtPolicyNumber).EndInit();
    ((ISupportInitialize) this.txtInsuredName).EndInit();
    ((ISupportInitialize) this.lblFeeBlocker).EndInit();
    ((ISupportInitialize) this.txtChargetype).EndInit();
    ((ISupportInitialize) this.grosspremium2).EndInit();
    ((ISupportInitialize) this.lblFee).EndInit();
    ((ISupportInitialize) this.paidNow1).EndInit();
    ((ISupportInitialize) this.paidNow2).EndInit();
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtChargetype.Text, "F", false) == 0)
    {
      ((ARControl) this.lblFee).Visible = true;
      ((ARControl) this.lblFeeBlocker).Visible = true;
    }
    else
    {
      ((ARControl) this.lblFee).Visible = false;
      ((ARControl) this.lblFeeBlocker).Visible = false;
    }
  }

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
