// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.PendingCancellation
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public class PendingCancellation : SectionReport
{
  private const string lblNoAmountString = "\tIf cancellation is due to nonpayment of premium, payment of overdue premium to us, or your agent or broker will be considered timely if made by cancellation date shown above. If payment has been made, contact your agent or us or broker immediately.";
  private const string lblAmountString = "\tIf cancellation is due to nonpayment of premium, full payment of overdue premium in the amount of {0} to us, or your agent or broker will be considered timely if made by cancellation date shown above. If payment has been made, contact your agent or us or broker immediately.";
  private const string lblReasonSec = "Section 3426 c(1): Nonpayment of premium";
  private const string lblReasonNoSec = "Nonpayment of premium";
  internal PaperSource _paperSource;
  private Shape Shape1;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label11;
  private Label Label12;
  private TextBox txtPolicyType;
  private TextBox txtPolicyNumber;
  private Label Label13;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private Label Label14;
  private TextBox txtMailingDate;
  private TextBox TextBox4;
  private Label Label9;
  private Label Label10;
  private Label lblNoAmount;
  private Label Label15;
  private Label Label16;
  private Label lblReason;
  private TextBox txtWhosCopy;
  private TextBox txtControlNo;
  private TextBox txtUnderwriterInitials;
  private Label Label17;
  private Line Line1;
  private Picture Picture1;
  private Label Label2;
  private Label Label1;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private TextBox txtAgent;
  private TextBox txtInsured;
  private TextBox txtMortgagee;
  private TextBox txtCompanyName;

  public PendingCancellation()
  {
    this.PageStart += new EventHandler(this.PendingCancellation_PageStart);
    this.InitializeComponent();
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PendingCancellation));
    this.Detail = new Detail();
    this.Shape1 = new Shape();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.txtPolicyType = new TextBox();
    this.txtPolicyNumber = new TextBox();
    this.Label13 = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.Label14 = new Label();
    this.txtMailingDate = new TextBox();
    this.TextBox4 = new TextBox();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.lblNoAmount = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.lblReason = new Label();
    this.txtWhosCopy = new TextBox();
    this.txtControlNo = new TextBox();
    this.txtUnderwriterInitials = new TextBox();
    this.Label17 = new Label();
    this.Line1 = new Line();
    this.Picture1 = new Picture();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.txtAgent = new TextBox();
    this.txtInsured = new TextBox();
    this.txtMortgagee = new TextBox();
    this.txtCompanyName = new TextBox();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.txtPolicyType).BeginInit();
    ((ISupportInitialize) this.txtPolicyNumber).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.txtMailingDate).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.lblNoAmount).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.lblReason).BeginInit();
    ((ISupportInitialize) this.txtWhosCopy).BeginInit();
    ((ISupportInitialize) this.txtControlNo).BeginInit();
    ((ISupportInitialize) this.txtUnderwriterInitials).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Picture1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.txtAgent).BeginInit();
    ((ISupportInitialize) this.txtInsured).BeginInit();
    ((ISupportInitialize) this.txtMortgagee).BeginInit();
    ((ISupportInitialize) this.txtCompanyName).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[35]
    {
      (ARControl) this.Shape1,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.txtPolicyType,
      (ARControl) this.txtPolicyNumber,
      (ARControl) this.Label13,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.Label14,
      (ARControl) this.txtMailingDate,
      (ARControl) this.TextBox4,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.lblNoAmount,
      (ARControl) this.Label15,
      (ARControl) this.Label16,
      (ARControl) this.lblReason,
      (ARControl) this.txtWhosCopy,
      (ARControl) this.txtControlNo,
      (ARControl) this.txtUnderwriterInitials,
      (ARControl) this.Label17,
      (ARControl) this.Line1,
      (ARControl) this.Picture1,
      (ARControl) this.Label2,
      (ARControl) this.Label1,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.txtAgent,
      (ARControl) this.txtInsured,
      (ARControl) this.txtMortgagee,
      (ARControl) this.txtCompanyName
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 8.456944f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.Shape1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Shape1).Border.TopStyle = (BorderLineStyle) 0;
    Shape shape1 = this.Shape1;
    object obj1 = componentResourceManager.GetObject("Shape1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) shape1).Location = pointF1;
    ((ARControl) this.Shape1).Name = "Shape1";
    ((ARControl) this.Shape1).Size = new SizeF(101f / 16f, 29f / 16f);
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj2 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label6).Location = pointF2;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(17f / 16f, 3f / 16f);
    this.Label6.Text = "Kind of Policy:";
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj3 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label7).Location = pointF3;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(17f / 16f, 3f / 16f);
    this.Label7.Text = "Policy Number:";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj4 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label8).Location = pointF4;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(4.75f, 3f / 16f);
    this.Label8.Text = "Cancellation, Expiration or Change will take effect at:";
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    this.Label11.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj5 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label11).Location = pointF5;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(19f / 16f, 3f / 16f);
    this.Label11.Text = "Date of Mailing:";
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj6 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label12).Location = pointF6;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(39f / 16f, 3f / 16f);
    this.Label12.Text = "Issued Through Agency or Office at:";
    ((ARControl) this.txtPolicyType).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyType).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyType).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyType).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyType).DataField = "line";
    this.txtPolicyType.DistinctField = (string) null;
    this.txtPolicyType.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPolicyType = this.txtPolicyType;
    object obj7 = componentResourceManager.GetObject("txtPolicyType.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) txtPolicyType).Location = pointF7;
    ((ARControl) this.txtPolicyType).Name = "txtPolicyType";
    this.txtPolicyType.OutputFormat = (string) null;
    ((ARControl) this.txtPolicyType).Size = new SizeF(2.25f, 3f / 16f);
    this.txtPolicyType.Text = "[Policy Type]";
    ((ARControl) this.txtPolicyNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).DataField = "policynumber";
    this.txtPolicyNumber.DistinctField = (string) null;
    this.txtPolicyNumber.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPolicyNumber = this.txtPolicyNumber;
    object obj8 = componentResourceManager.GetObject("txtPolicyNumber.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) txtPolicyNumber).Location = pointF8;
    ((ARControl) this.txtPolicyNumber).Name = "txtPolicyNumber";
    this.txtPolicyNumber.OutputFormat = (string) null;
    ((ARControl) this.txtPolicyNumber).Size = new SizeF(2.25f, 3f / 16f);
    this.txtPolicyNumber.Text = "[Policy Number]";
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    this.Label13.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj9 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label13).Location = pointF9;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label13.Text = "Date:";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "duedate";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj10 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox1).Location = pointF10;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox1).Size = new SizeF(0.875f, 3f / 16f);
    this.TextBox1.Text = "[Cancel Date]";
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox2 = this.TextBox2;
    object obj11 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox2).Location = pointF11;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(15f / 16f, 3f / 16f);
    this.TextBox2.Text = "12:01 A.M.";
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    this.Label14.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label14.HyperLink = (string) null;
    Label label14 = this.Label14;
    object obj12 = componentResourceManager.GetObject("Label14.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label14).Location = pointF12;
    ((ARControl) this.Label14).Name = "Label14";
    ((ARControl) this.Label14).Size = new SizeF(23f / 16f, 3f / 16f);
    this.Label14.Text = "Hour-Standard Time:";
    ((ARControl) this.txtMailingDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMailingDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMailingDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMailingDate).Border.TopStyle = (BorderLineStyle) 0;
    this.txtMailingDate.DistinctField = (string) null;
    this.txtMailingDate.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMailingDate = this.txtMailingDate;
    object obj13 = componentResourceManager.GetObject("txtMailingDate.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) txtMailingDate).Location = pointF13;
    ((ARControl) this.txtMailingDate).Name = "txtMailingDate";
    this.txtMailingDate.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.txtMailingDate).Size = new SizeF(2.125f, 3f / 16f);
    this.txtMailingDate.Text = "[Mailing Date]";
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "officelocation";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox4 = this.TextBox4;
    object obj14 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox4).Location = pointF14;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(2.125f, 9f / 16f);
    this.TextBox4.Text = "[Office Location]";
    this.Label9.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj15 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) label9).Location = pointF15;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(6.375f, 3f / 16f);
    this.Label9.Text = "Generated Automatically";
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj16 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) label10).Location = pointF16;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(6.375f, 15f / 16f);
    this.Label10.Text = componentResourceManager.GetString("Label10.Text");
    ((ARControl) this.lblNoAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblNoAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblNoAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblNoAmount).Border.TopStyle = (BorderLineStyle) 0;
    this.lblNoAmount.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblNoAmount.HyperLink = (string) null;
    Label lblNoAmount = this.lblNoAmount;
    object obj17 = componentResourceManager.GetObject("lblNoAmount.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) lblNoAmount).Location = pointF17;
    ((ARControl) this.lblNoAmount).Name = "lblNoAmount";
    ((ARControl) this.lblNoAmount).Size = new SizeF(6.375f, 0.75f);
    this.lblNoAmount.Text = componentResourceManager.GetString("lblNoAmount.Text");
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 0;
    this.Label15.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label15.HyperLink = (string) null;
    Label label15 = this.Label15;
    object obj18 = componentResourceManager.GetObject("Label15.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) label15).Location = pointF18;
    ((ARControl) this.Label15).Name = "Label15";
    ((ARControl) this.Label15).Size = new SizeF(6.375f, 0.625f);
    this.Label15.Text = componentResourceManager.GetString("Label15.Text");
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 0;
    this.Label16.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    this.Label16.HyperLink = (string) null;
    Label label16 = this.Label16;
    object obj19 = componentResourceManager.GetObject("Label16.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) label16).Location = pointF19;
    ((ARControl) this.Label16).Name = "Label16";
    ((ARControl) this.Label16).Size = new SizeF(1.625f, 3f / 16f);
    this.Label16.Text = "Reason for cancellation:";
    this.lblReason.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblReason).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblReason).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblReason).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblReason).Border.TopStyle = (BorderLineStyle) 0;
    this.lblReason.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblReason.HyperLink = (string) null;
    Label lblReason = this.lblReason;
    object obj20 = componentResourceManager.GetObject("lblReason.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) lblReason).Location = pointF20;
    ((ARControl) this.lblReason).Name = "lblReason";
    ((ARControl) this.lblReason).Size = new SizeF(6.375f, 0.2f);
    this.lblReason.Text = "Nonpayment of premium";
    this.txtWhosCopy.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtWhosCopy).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtWhosCopy).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtWhosCopy).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtWhosCopy).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtWhosCopy).DataField = "printfor";
    this.txtWhosCopy.DistinctField = (string) null;
    this.txtWhosCopy.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtWhosCopy = this.txtWhosCopy;
    object obj21 = componentResourceManager.GetObject("txtWhosCopy.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) txtWhosCopy).Location = pointF21;
    ((ARControl) this.txtWhosCopy).Name = "txtWhosCopy";
    this.txtWhosCopy.OutputFormat = (string) null;
    ((ARControl) this.txtWhosCopy).Size = new SizeF(101f / 16f, 0.2f);
    this.txtWhosCopy.Text = "(MGA Copy)";
    this.txtControlNo.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtControlNo).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtControlNo).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtControlNo).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtControlNo).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtControlNo).DataField = "controlno";
    this.txtControlNo.DistinctField = (string) null;
    this.txtControlNo.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtControlNo = this.txtControlNo;
    object obj22 = componentResourceManager.GetObject("txtControlNo.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) txtControlNo).Location = pointF22;
    ((ARControl) this.txtControlNo).Name = "txtControlNo";
    this.txtControlNo.OutputFormat = (string) null;
    ((ARControl) this.txtControlNo).Size = new SizeF(1f, 0.1375001f);
    this.txtControlNo.Text = "TextBox5";
    this.txtUnderwriterInitials.Alignment = (TextAlignment) 3;
    ((ARControl) this.txtUnderwriterInitials).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnderwriterInitials).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnderwriterInitials).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnderwriterInitials).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnderwriterInitials).DataField = "initials";
    this.txtUnderwriterInitials.DistinctField = (string) null;
    this.txtUnderwriterInitials.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox underwriterInitials = this.txtUnderwriterInitials;
    object obj23 = componentResourceManager.GetObject("txtUnderwriterInitials.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) underwriterInitials).Location = pointF23;
    ((ARControl) this.txtUnderwriterInitials).Name = "txtUnderwriterInitials";
    this.txtUnderwriterInitials.OutputFormat = (string) null;
    ((ARControl) this.txtUnderwriterInitials).Size = new SizeF(1f, 0.1375001f);
    this.txtUnderwriterInitials.Text = "TextBox6";
    this.Label17.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.TopStyle = (BorderLineStyle) 0;
    this.Label17.Font = new Font("Arial", 7f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label17.HyperLink = (string) null;
    Label label17 = this.Label17;
    object obj24 = componentResourceManager.GetObject("Label17.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) label17).Location = pointF24;
    ((ARControl) this.Label17).Name = "Label17";
    ((ARControl) this.Label17).Size = new SizeF(2.625f, 0.1374998f);
    this.Label17.Text = "Authorized Signature";
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    this.Line1.X1 = 3.75f;
    this.Line1.X2 = 103f / 16f;
    this.Line1.Y1 = 121f / 16f;
    this.Line1.Y2 = 121f / 16f;
    ((ARControl) this.Picture1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Picture1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Picture1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Picture1).Border.TopStyle = (BorderLineStyle) 0;
    this.Picture1.Image = (Image) null;
    this.Picture1.ImageData = (Stream) null;
    this.Picture1.LineColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    this.Picture1.LineWeight = 0.0f;
    Picture picture1 = this.Picture1;
    object obj25 = componentResourceManager.GetObject("Picture1.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) picture1).Location = pointF25;
    ((ARControl) this.Picture1).Name = "Picture1";
    ((ARControl) this.Picture1).Size = new SizeF(43f / 16f, 0.375f);
    this.Label2.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 11f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj26 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) label2).Location = pointF26;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(6.375f, 0.2f);
    this.Label2.Text = "Notice of Cancellation of Insurance";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj27 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) label1).Location = pointF27;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(27f / 16f, 3f / 16f);
    this.Label1.Text = "Insurance Company:";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj28 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) label3).Location = pointF28;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(2.25f, 3f / 16f);
    this.Label3.Text = "Name and Address of Insured:";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj29 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) label4).Location = pointF29;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(2.25f, 3f / 16f);
    this.Label4.Text = "Producer/Agent:";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj30 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) label5).Location = pointF30;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(2.25f, 3f / 16f);
    this.Label5.Text = "Mortgagee:";
    ((ARControl) this.txtAgent).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgent).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgent).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgent).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAgent).DataField = "producer";
    this.txtAgent.DistinctField = (string) null;
    this.txtAgent.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAgent = this.txtAgent;
    object obj31 = componentResourceManager.GetObject("txtAgent.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) txtAgent).Location = pointF31;
    ((ARControl) this.txtAgent).Name = "txtAgent";
    this.txtAgent.OutputFormat = (string) null;
    ((ARControl) this.txtAgent).Size = new SizeF(2.25f, 9f / 16f);
    this.txtAgent.Text = "[Agent]";
    ((ARControl) this.txtInsured).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).DataField = "insured";
    this.txtInsured.DistinctField = (string) null;
    this.txtInsured.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtInsured = this.txtInsured;
    object obj32 = componentResourceManager.GetObject("txtInsured.Location");
    PointF pointF32 = obj32 != null ? (PointF) obj32 : new PointF();
    ((ARControl) txtInsured).Location = pointF32;
    ((ARControl) this.txtInsured).Name = "txtInsured";
    this.txtInsured.OutputFormat = (string) null;
    ((ARControl) this.txtInsured).Size = new SizeF(2.25f, 0.5f);
    this.txtInsured.Text = "[Insured]";
    ((ARControl) this.txtMortgagee).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMortgagee).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMortgagee).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMortgagee).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMortgagee).DataField = "mortgagee";
    this.txtMortgagee.DistinctField = (string) null;
    this.txtMortgagee.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMortgagee = this.txtMortgagee;
    object obj33 = componentResourceManager.GetObject("txtMortgagee.Location");
    PointF pointF33 = obj33 != null ? (PointF) obj33 : new PointF();
    ((ARControl) txtMortgagee).Location = pointF33;
    ((ARControl) this.txtMortgagee).Name = "txtMortgagee";
    this.txtMortgagee.OutputFormat = (string) null;
    ((ARControl) this.txtMortgagee).Size = new SizeF(2.25f, 0.5f);
    this.txtMortgagee.Text = "[Mortgagee]";
    ((ARControl) this.txtCompanyName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompanyName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompanyName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompanyName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompanyName).DataField = "company";
    this.txtCompanyName.DistinctField = (string) null;
    this.txtCompanyName.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtCompanyName = this.txtCompanyName;
    object obj34 = componentResourceManager.GetObject("txtCompanyName.Location");
    PointF pointF34 = obj34 != null ? (PointF) obj34 : new PointF();
    ((ARControl) txtCompanyName).Location = pointF34;
    ((ARControl) this.txtCompanyName).Name = "txtCompanyName";
    this.txtCompanyName.OutputFormat = (string) null;
    ((ARControl) this.txtCompanyName).Size = new SizeF(5f, 3f / 16f);
    this.txtCompanyName.Text = "[Company Name]";
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.PageSettings.Margins.Bottom = 0.2f;
    this.PageSettings.Margins.Left = 0.2f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.txtPolicyType).EndInit();
    ((ISupportInitialize) this.txtPolicyNumber).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.txtMailingDate).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.lblNoAmount).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.lblReason).EndInit();
    ((ISupportInitialize) this.txtWhosCopy).EndInit();
    ((ISupportInitialize) this.txtControlNo).EndInit();
    ((ISupportInitialize) this.txtUnderwriterInitials).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Picture1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.txtAgent).EndInit();
    ((ISupportInitialize) this.txtInsured).EndInit();
    ((ISupportInitialize) this.txtMortgagee).EndInit();
    ((ISupportInitialize) this.txtCompanyName).EndInit();
  }

  private void PendingCancellation_PageStart(object sender, EventArgs e)
  {
    this.txtMailingDate.Value = (object) DateTime.Now;
    if (Information.IsDBNull((object) this.Fields["mortgagee"]))
      this.txtMortgagee.Value = (object) "";
    this.lblReason.Text = Operators.CompareString(this.Fields["stateid"].Value.ToString(), "NY", false) != 0 ? "Nonpayment of premium" : "Section 3426 c(1): Nonpayment of premium";
    if (this._paperSource == null)
      return;
    ((PrintDocument) this.Document.Printer).PrinterSettings.DefaultPageSettings.PaperSource = this._paperSource;
  }

  public void SetPaperSource(PaperSource ps) => this._paperSource = ps;

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
