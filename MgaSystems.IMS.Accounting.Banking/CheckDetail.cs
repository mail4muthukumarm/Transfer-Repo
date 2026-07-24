// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.CheckDetail
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public sealed class CheckDetail : SectionReport
{
  private int Transactnum;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label lblSeeCheckDetail;
  private TextBox txtInsuredName;
  private TextBox txtPolicyNumber;
  private TextBox txtGrossPremium;
  private TextBox txtNetPremium;
  private TextBox txtCommissionPercent;
  private TextBox txtPolicyTerm;
  private TextBox TextBox1;
  private TextBox grosspremium1;
  private Label lblFeeBlocker;
  private TextBox txtChargetype;
  private TextBox grosspremium2;
  private Label lblFee;

  public CheckDetail()
  {
    this.ReportStart += new EventHandler(this.CheckDetail_ReportStart);
    this.InitializeComponent();
  }

  public CheckDetail(int trx)
  {
    this.ReportStart += new EventHandler(this.CheckDetail_ReportStart);
    this.InitializeComponent();
    this.Transactnum = trx;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CheckDetail));
    this.Detail = new Detail();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.lblSeeCheckDetail = new Label();
    this.txtInsuredName = new TextBox();
    this.txtPolicyNumber = new TextBox();
    this.txtGrossPremium = new TextBox();
    this.txtNetPremium = new TextBox();
    this.txtCommissionPercent = new TextBox();
    this.txtPolicyTerm = new TextBox();
    this.TextBox1 = new TextBox();
    this.grosspremium1 = new TextBox();
    this.lblFeeBlocker = new Label();
    this.txtChargetype = new TextBox();
    this.grosspremium2 = new TextBox();
    this.lblFee = new Label();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.lblSeeCheckDetail).BeginInit();
    ((ISupportInitialize) this.txtInsuredName).BeginInit();
    ((ISupportInitialize) this.txtPolicyNumber).BeginInit();
    ((ISupportInitialize) this.txtGrossPremium).BeginInit();
    ((ISupportInitialize) this.txtNetPremium).BeginInit();
    ((ISupportInitialize) this.txtCommissionPercent).BeginInit();
    ((ISupportInitialize) this.txtPolicyTerm).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.grosspremium1).BeginInit();
    ((ISupportInitialize) this.lblFeeBlocker).BeginInit();
    ((ISupportInitialize) this.txtChargetype).BeginInit();
    ((ISupportInitialize) this.grosspremium2).BeginInit();
    ((ISupportInitialize) this.lblFee).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.lblSeeCheckDetail,
      (ARControl) this.txtInsuredName,
      (ARControl) this.txtPolicyNumber,
      (ARControl) this.txtGrossPremium,
      (ARControl) this.txtNetPremium,
      (ARControl) this.txtCommissionPercent,
      (ARControl) this.txtPolicyTerm,
      (ARControl) this.TextBox1,
      (ARControl) this.grosspremium1,
      (ARControl) this.lblFeeBlocker,
      (ARControl) this.txtChargetype,
      (ARControl) this.grosspremium2,
      (ARControl) this.lblFee
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9
    });
    this.GroupHeader1.Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupFooter1.Height = 0.7069445f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj1 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label1).Location = pointF1;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(1f, 0.2f);
    this.Label1.Text = "Insured Name";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj2 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label2).Location = pointF2;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(13f / 16f, 0.125f);
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
    object obj3 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label3).Location = pointF3;
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
    object obj4 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label4).Location = pointF4;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(0.875f, 0.125f);
    this.Label4.Text = "Paid Previous";
    this.Label5.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj5 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label5).Location = pointF5;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(0.625f, 0.125f);
    this.Label5.Text = "Paid Now";
    this.Label6.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj6 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label6).Location = pointF6;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(0.5f, 0.125f);
    this.Label6.Text = "Balance";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 7f, FontStyle.Bold);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj7 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label7).Location = pointF7;
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
    object obj8 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label8).Location = pointF8;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(0.5f, 3f / 16f);
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
    object obj9 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label9).Location = pointF9;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(15f / 16f, 0.125f);
    this.Label9.Text = "Gross Comm.";
    this.lblSeeCheckDetail.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblSeeCheckDetail).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSeeCheckDetail).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSeeCheckDetail).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblSeeCheckDetail).Border.TopStyle = (BorderLineStyle) 0;
    this.lblSeeCheckDetail.Font = new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblSeeCheckDetail.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblSeeCheckDetail.HyperLink = (string) null;
    Label lblSeeCheckDetail = this.lblSeeCheckDetail;
    object obj10 = componentResourceManager.GetObject("lblSeeCheckDetail.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) lblSeeCheckDetail).Location = pointF10;
    ((ARControl) this.lblSeeCheckDetail).Name = "lblSeeCheckDetail";
    ((ARControl) this.lblSeeCheckDetail).Size = new SizeF((float) sbyte.MaxValue / 16f, 61f / 16f);
    this.lblSeeCheckDetail.Text = "Please see check detail page..";
    this.lblSeeCheckDetail.VerticalAlignment = (VerticalTextAlignment) 1;
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
    object obj11 = componentResourceManager.GetObject("txtInsuredName.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) txtInsuredName).Location = pointF11;
    ((ARControl) this.txtInsuredName).Name = "txtInsuredName";
    this.txtInsuredName.OutputFormat = (string) null;
    ((ARControl) this.txtInsuredName).Size = new SizeF(1.25f, 0.125f);
    this.txtInsuredName.WordWrap = false;
    ((ARControl) this.txtPolicyNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.TopStyle = (BorderLineStyle) 0;
    this.txtPolicyNumber.CanGrow = false;
    ((ARControl) this.txtPolicyNumber).DataField = "policynumber";
    this.txtPolicyNumber.DistinctField = (string) null;
    this.txtPolicyNumber.Font = new Font("Arial", 7f);
    this.txtPolicyNumber.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtPolicyNumber = this.txtPolicyNumber;
    object obj12 = componentResourceManager.GetObject("txtPolicyNumber.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) txtPolicyNumber).Location = pointF12;
    ((ARControl) this.txtPolicyNumber).Name = "txtPolicyNumber";
    this.txtPolicyNumber.OutputFormat = (string) null;
    ((ARControl) this.txtPolicyNumber).Size = new SizeF(17f / 16f, 0.125f);
    this.txtPolicyNumber.Text = " ";
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
    object obj13 = componentResourceManager.GetObject("txtGrossPremium.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) txtGrossPremium).Location = pointF13;
    ((ARControl) this.txtGrossPremium).Name = "txtGrossPremium";
    this.txtGrossPremium.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtGrossPremium).Size = new SizeF(0.875f, 0.125f);
    this.txtGrossPremium.Text = " ";
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
    object obj15 = componentResourceManager.GetObject("txtCommissionPercent.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) commissionPercent).Location = pointF15;
    ((ARControl) this.txtCommissionPercent).Name = "txtCommissionPercent";
    this.txtCommissionPercent.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtCommissionPercent).Size = new SizeF(11f / 16f, 0.125f);
    this.txtCommissionPercent.Text = " ";
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
    object obj16 = componentResourceManager.GetObject("txtPolicyTerm.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) txtPolicyTerm).Location = pointF16;
    ((ARControl) this.txtPolicyTerm).Name = "txtPolicyTerm";
    this.txtPolicyTerm.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtPolicyTerm).Size = new SizeF(0.8333333f, 0.125f);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox1.CanGrow = false;
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
    ((ARControl) this.TextBox1).Size = new SizeF(0.75f, 0.125f);
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
    object obj18 = componentResourceManager.GetObject("grosspremium1.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) grosspremium1).Location = pointF18;
    ((ARControl) this.grosspremium1).Name = "grosspremium1";
    this.grosspremium1.OutputFormat = "0.00%";
    ((ARControl) this.grosspremium1).Size = new SizeF(0.5f, 0.125f);
    this.grosspremium1.Text = " ";
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
    object obj19 = componentResourceManager.GetObject("lblFeeBlocker.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) lblFeeBlocker).Location = pointF19;
    ((ARControl) this.lblFeeBlocker).Name = "lblFeeBlocker";
    ((ARControl) this.lblFeeBlocker).Size = new SizeF(23f / 32f, 0.125f);
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
    object obj20 = componentResourceManager.GetObject("txtChargetype.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) txtChargetype).Location = pointF20;
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
    object obj21 = componentResourceManager.GetObject("grosspremium2.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) grosspremium2).Location = pointF21;
    ((ARControl) this.grosspremium2).Name = "grosspremium2";
    this.grosspremium2.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.grosspremium2).Size = new SizeF(0.875f, 0.125f);
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
    object obj22 = componentResourceManager.GetObject("lblFee.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) lblFee).Location = pointF22;
    ((ARControl) this.lblFee).Name = "lblFee";
    ((ARControl) this.lblFee).Size = new SizeF(3.125f, 0.125f);
    this.lblFee.Text = "Fee";
    this.lblFee.VerticalAlignment = (VerticalTextAlignment) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.729167f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.lblSeeCheckDetail).EndInit();
    ((ISupportInitialize) this.txtInsuredName).EndInit();
    ((ISupportInitialize) this.txtPolicyNumber).EndInit();
    ((ISupportInitialize) this.txtGrossPremium).EndInit();
    ((ISupportInitialize) this.txtNetPremium).EndInit();
    ((ISupportInitialize) this.txtCommissionPercent).EndInit();
    ((ISupportInitialize) this.txtPolicyTerm).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.grosspremium1).EndInit();
    ((ISupportInitialize) this.lblFeeBlocker).EndInit();
    ((ISupportInitialize) this.txtChargetype).EndInit();
    ((ISupportInitialize) this.grosspremium2).EndInit();
    ((ISupportInitialize) this.lblFee).EndInit();
  }

  private void CheckDetail_ReportStart(object sender, EventArgs e)
  {
    this.ShowParameterUI = false;
    SqlCommand selectCommand = new SqlCommand("spFin_GetCheckDetails", new SqlConnection(CurrentUser.Instance.ConnectionString));
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    DataSet dataSet = new DataSet();
    try
    {
      sqlDataAdapter.SelectCommand.Parameters.Clear();
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@transactnum", (object) this.Transactnum);
      sqlDataAdapter.Fill(dataSet);
      if (dataSet.Tables[0].Rows.Count <= 20)
      {
        ((ARControl) this.lblSeeCheckDetail).Visible = false;
        ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Visible = true;
        this.DataSource = (object) dataSet.Tables[0];
      }
      else
      {
        ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Visible = false;
        ((ARControl) this.lblSeeCheckDetail).Visible = true;
      }
    }
    finally
    {
      selectCommand.Connection.Close();
      selectCommand.Connection.Dispose();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
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
}
