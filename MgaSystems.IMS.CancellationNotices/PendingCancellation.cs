// Decompiled with JetBrains decompiler
// Type: CancellationNotices.PendingCancellation
// Assembly: MgaSystems.IMS.CancellationNotices, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 212B4515-7BA8-45EF-B7D5-4974627BD234
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.CancellationNotices.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace CancellationNotices;

public class PendingCancellation : SectionReport
{
  private const string _ceaseMsg = "\tYou are hereby notified in accordance with the terms and conditions of the captioned policy, and in accordance with the law that your insurance will cease at and from the hour and date stated above.";
  private const string lblNoAmountString = "\tIf cancellation is due to nonpayment of premium, payment of overdue premium to us, or your agent or broker will be considered timely if made by cancellation date shown above. If payment has been made, contact your agent or us or broker immediately.";
  private const string lblAmountString = "\tIf cancellation is due to nonpayment of premium, full payment of overdue premium in the amount of {0} to us, or your agent or broker will be considered timely if made by cancellation date shown above. If payment has been made, contact your agent or us or broker immediately.";
  private const string lblReasonSec = "Section 3426 c(1): Nonpayment of premium";
  private const string lblReasonNoSec = "Nonpayment of premium";
  private PaperSource _paperSource;
  private Image _signature;
  private string _connectionString;
  private string _stateid;
  private Shape Shape1;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label11;
  private TextBox txtPolicyType;
  private TextBox txtPolicyNumber;
  private Label Label13;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private Label Label14;
  private TextBox txtMailingDate;
  private Label Label9;
  private Label lblCeaseMsg;
  private Label lblNoAmount;
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
  private TextBox txtRecBalance;
  private TextBox txtQuoteId;
  private Label lblStateId;

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader2")]
  private virtual GroupHeader GroupHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter2")]
  private virtual GroupFooter GroupFooter2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader3")]
  private virtual GroupHeader GroupHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter3")]
  private virtual GroupFooter GroupFooter3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CommentDescriptionLabel")]
  private virtual Label CommentDescriptionLabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CommentDescription")]
  private virtual Label CommentDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public PaperSource PaperSource
  {
    get => this._paperSource;
    set => this._paperSource = value;
  }

  public PendingCancellation()
  {
    this.PageStart += new EventHandler(this.PendingCancellation_PageStart);
    this.ReportStart += new EventHandler(this.PendingCancellation_ReportStart);
    this._stateid = "";
    this.InitializeComponent();
  }

  public PendingCancellation(string ConnectionString)
  {
    this.PageStart += new EventHandler(this.PendingCancellation_PageStart);
    this.ReportStart += new EventHandler(this.PendingCancellation_ReportStart);
    this._stateid = "";
    this.InitializeComponent();
    this._connectionString = ConnectionString;
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
    this.txtPolicyType = new TextBox();
    this.txtPolicyNumber = new TextBox();
    this.Label13 = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.Label14 = new Label();
    this.txtMailingDate = new TextBox();
    this.Label9 = new Label();
    this.lblCeaseMsg = new Label();
    this.lblNoAmount = new Label();
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
    this.txtRecBalance = new TextBox();
    this.txtQuoteId = new TextBox();
    this.lblStateId = new Label();
    this.Label12 = new Label();
    this.TextBox3 = new TextBox();
    this.CommentDescriptionLabel = new Label();
    this.CommentDescription = new Label();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.GroupHeader2 = new GroupHeader();
    this.GroupFooter2 = new GroupFooter();
    this.GroupHeader3 = new GroupHeader();
    this.GroupFooter3 = new GroupFooter();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.txtPolicyType).BeginInit();
    ((ISupportInitialize) this.txtPolicyNumber).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.txtMailingDate).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.lblCeaseMsg).BeginInit();
    ((ISupportInitialize) this.lblNoAmount).BeginInit();
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
    ((ISupportInitialize) this.txtRecBalance).BeginInit();
    ((ISupportInitialize) this.txtQuoteId).BeginInit();
    ((ISupportInitialize) this.lblStateId).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.CommentDescriptionLabel).BeginInit();
    ((ISupportInitialize) this.CommentDescription).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.Detail).Controls.AddRange(new ARControl[39]
    {
      (ARControl) this.Shape1,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label11,
      (ARControl) this.txtPolicyType,
      (ARControl) this.txtPolicyNumber,
      (ARControl) this.Label13,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.Label14,
      (ARControl) this.txtMailingDate,
      (ARControl) this.Label9,
      (ARControl) this.lblCeaseMsg,
      (ARControl) this.lblNoAmount,
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
      (ARControl) this.txtCompanyName,
      (ARControl) this.txtRecBalance,
      (ARControl) this.txtQuoteId,
      (ARControl) this.lblStateId,
      (ARControl) this.Label12,
      (ARControl) this.TextBox3,
      (ARControl) this.CommentDescriptionLabel,
      (ARControl) this.CommentDescription
    });
    ((Section) this.Detail).Height = 10.01042f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.Shape1).Height = 29f / 16f;
    ((ARControl) this.Shape1).Left = 7f / 16f;
    ((ARControl) this.Shape1).Name = "Shape1";
    this.Shape1.RoundingRadius = new CornersRadius(new float?(9.999999f), new float?(), new float?(), new float?(), new float?());
    ((ARControl) this.Shape1).Top = 57f / 16f;
    ((ARControl) this.Shape1).Width = 7.125f;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 0.75f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.Label6.Text = "Kind of Policy:";
    ((ARControl) this.Label6).Top = 3.625f;
    ((ARControl) this.Label6).Width = 17f / 16f;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 0.75f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.Label7.Text = "Policy Number:";
    ((ARControl) this.Label7).Top = 61f / 16f;
    ((ARControl) this.Label7).Width = 17f / 16f;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 0.75f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.Label8.Text = "Cancellation, Expiration or Change will take effect at:";
    ((ARControl) this.Label8).Top = 4f;
    ((ARControl) this.Label8).Width = 4.75f;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 0.75f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.Label11.Text = "Date of Mailing:";
    ((ARControl) this.Label11).Top = 4.5f;
    ((ARControl) this.Label11).Width = 19f / 16f;
    ((ARControl) this.txtPolicyType).DataField = "line";
    ((ARControl) this.txtPolicyType).Height = 3f / 16f;
    ((ARControl) this.txtPolicyType).Left = 29f / 16f;
    ((ARControl) this.txtPolicyType).Name = "txtPolicyType";
    this.txtPolicyType.Style = "font-size: 9pt; ddo-char-set: 0";
    this.txtPolicyType.Text = "[Policy Type]";
    ((ARControl) this.txtPolicyType).Top = 3.625f;
    ((ARControl) this.txtPolicyType).Width = 2.25f;
    ((ARControl) this.txtPolicyNumber).DataField = "policynumber";
    ((ARControl) this.txtPolicyNumber).Height = 3f / 16f;
    ((ARControl) this.txtPolicyNumber).Left = 29f / 16f;
    ((ARControl) this.txtPolicyNumber).Name = "txtPolicyNumber";
    this.txtPolicyNumber.Style = "font-size: 9pt; ddo-char-set: 0";
    this.txtPolicyNumber.Text = "[Policy Number]";
    ((ARControl) this.txtPolicyNumber).Top = 61f / 16f;
    ((ARControl) this.txtPolicyNumber).Width = 2.25f;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 27f / 16f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.Label13.Text = "Date:";
    ((ARControl) this.Label13).Top = 4.25f;
    ((ARControl) this.Label13).Width = 9f / 16f;
    ((ARControl) this.TextBox1).DataField = "duedate";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 2.25f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = componentResourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Style = "font-size: 9pt; ddo-char-set: 0";
    this.TextBox1.Text = "[Cancel Date]";
    ((ARControl) this.TextBox1).Top = 4.25f;
    ((ARControl) this.TextBox1).Width = 0.875f;
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 91f / 16f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 9pt; ddo-char-set: 0";
    this.TextBox2.Text = "12:01 A.M.";
    ((ARControl) this.TextBox2).Top = 4.25f;
    ((ARControl) this.TextBox2).Width = 15f / 16f;
    ((ARControl) this.Label14).Height = 3f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 4.25f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.Label14.Text = "Hour-Standard Time:";
    ((ARControl) this.Label14).Top = 4.25f;
    ((ARControl) this.Label14).Width = 23f / 16f;
    ((ARControl) this.txtMailingDate).DataField = "MailingDate";
    ((ARControl) this.txtMailingDate).Height = 3f / 16f;
    ((ARControl) this.txtMailingDate).Left = 2f;
    ((ARControl) this.txtMailingDate).Name = "txtMailingDate";
    this.txtMailingDate.OutputFormat = componentResourceManager.GetString("txtMailingDate.OutputFormat");
    this.txtMailingDate.Style = "font-size: 9pt; ddo-char-set: 0";
    this.txtMailingDate.Text = (string) null;
    ((ARControl) this.txtMailingDate).Top = 4.5f;
    ((ARControl) this.txtMailingDate).Width = 2.125f;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 1f / 16f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-weight: bold; text-align: center; ddo-char-set: 0";
    this.Label9.Text = "Generated Automatically";
    ((ARControl) this.Label9).Top = 95f / 16f;
    ((ARControl) this.Label9).Width = 7.625f;
    ((ARControl) this.lblCeaseMsg).Height = 15f / 16f;
    this.lblCeaseMsg.HyperLink = (string) null;
    ((ARControl) this.lblCeaseMsg).Left = 0.375f;
    ((ARControl) this.lblCeaseMsg).Name = "lblCeaseMsg";
    this.lblCeaseMsg.Style = "ddo-char-set: 0";
    this.lblCeaseMsg.Text = componentResourceManager.GetString("lblCeaseMsg.Text");
    ((ARControl) this.lblCeaseMsg).Top = 103f / 16f;
    ((ARControl) this.lblCeaseMsg).Width = 115f / 16f;
    ((ARControl) this.lblNoAmount).Height = 0.75f;
    this.lblNoAmount.HyperLink = (string) null;
    ((ARControl) this.lblNoAmount).Left = 0.375f;
    ((ARControl) this.lblNoAmount).Name = "lblNoAmount";
    this.lblNoAmount.Style = "ddo-char-set: 0";
    this.lblNoAmount.Text = componentResourceManager.GetString("lblNoAmount.Text");
    ((ARControl) this.lblNoAmount).Top = 113f / 16f;
    ((ARControl) this.lblNoAmount).Width = 115f / 16f;
    ((ARControl) this.Label16).Height = 3f / 16f;
    this.Label16.HyperLink = (string) null;
    ((ARControl) this.Label16).Left = 3f / 16f;
    ((ARControl) this.Label16).Name = "Label16";
    this.Label16.Style = "font-size: 9pt; font-weight: bold; text-decoration: underline; ddo-char-set: 0";
    this.Label16.Text = "Reason for cancellation:";
    ((ARControl) this.Label16).Top = (float) sbyte.MaxValue / 16f;
    ((ARControl) this.Label16).Width = 1.625f;
    ((ARControl) this.lblReason).Height = 0.3125002f;
    this.lblReason.HyperLink = (string) null;
    ((ARControl) this.lblReason).Left = 0.188f;
    ((ARControl) this.lblReason).Name = "lblReason";
    this.lblReason.Style = "font-size: 12pt; text-align: center; ddo-char-set: 0";
    this.lblReason.Text = "Nonpayment of premium";
    ((ARControl) this.lblReason).Top = 8.125f;
    ((ARControl) this.lblReason).Width = 7.625f;
    ((ARControl) this.txtWhosCopy).DataField = "printfor";
    ((ARControl) this.txtWhosCopy).Height = 0.2f;
    ((ARControl) this.txtWhosCopy).Left = 0.125f;
    ((ARControl) this.txtWhosCopy).Name = "txtWhosCopy";
    this.txtWhosCopy.Style = "font-size: 9pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.txtWhosCopy.Text = "(MGA Copy)";
    ((ARControl) this.txtWhosCopy).Top = 9.75f;
    ((ARControl) this.txtWhosCopy).Width = 123f / 16f;
    ((ARControl) this.txtControlNo).DataField = "controlno";
    ((ARControl) this.txtControlNo).Height = 0.1375001f;
    ((ARControl) this.txtControlNo).Left = 7f / 16f;
    ((ARControl) this.txtControlNo).Name = "txtControlNo";
    this.txtControlNo.Style = "font-size: 7pt; text-align: center; ddo-char-set: 0";
    this.txtControlNo.Text = "TextBox5";
    ((ARControl) this.txtControlNo).Top = 157f / 16f;
    ((ARControl) this.txtControlNo).Width = 1f;
    ((ARControl) this.txtUnderwriterInitials).DataField = "initials";
    ((ARControl) this.txtUnderwriterInitials).Height = 0.1375001f;
    ((ARControl) this.txtUnderwriterInitials).Left = 21f / 16f;
    ((ARControl) this.txtUnderwriterInitials).Name = "txtUnderwriterInitials";
    this.txtUnderwriterInitials.Style = "font-size: 7pt; text-align: justify; ddo-char-set: 0";
    this.txtUnderwriterInitials.Text = "TextBox6";
    ((ARControl) this.txtUnderwriterInitials).Top = 157f / 16f;
    ((ARControl) this.txtUnderwriterInitials).Width = 1f;
    ((ARControl) this.Label17).Height = 0.1374998f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 81f / 16f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "font-size: 7pt; text-align: center; ddo-char-set: 0";
    this.Label17.Text = "Authorized Signature";
    ((ARControl) this.Label17).Top = 9.5f;
    ((ARControl) this.Label17).Width = 2.625f;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 5f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 9.5f;
    ((ARControl) this.Line1).Width = 43f / 16f;
    this.Line1.X1 = 5f;
    this.Line1.X2 = 123f / 16f;
    this.Line1.Y1 = 9.5f;
    this.Line1.Y2 = 9.5f;
    this.Picture1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    ((ARControl) this.Picture1).Height = 0.5f;
    this.Picture1.ImageData = (Stream) null;
    ((ARControl) this.Picture1).Left = 5f;
    this.Picture1.LineColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    ((ARControl) this.Picture1).Name = "Picture1";
    this.Picture1.SizeMode = (SizeModes) 1;
    ((ARControl) this.Picture1).Top = 9f;
    ((ARControl) this.Picture1).Width = 43f / 16f;
    ((ARControl) this.Label2).Height = 0.2f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.062f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 11pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.Label2.Text = "Notice of Cancellation of Insurance";
    ((ARControl) this.Label2).Top = 0.25f;
    ((ARControl) this.Label2).Width = 7.75f;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.437f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.Label1.Text = "Insurance Company:";
    ((ARControl) this.Label1).Top = 11f / 16f;
    ((ARControl) this.Label1).Width = 27f / 16f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 0.437f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.Label3.Text = "Name and Address of Insured:";
    ((ARControl) this.Label3).Top = 1f;
    ((ARControl) this.Label3).Width = 3.563f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 5f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.Label4.Text = "Producer/Agent:";
    ((ARControl) this.Label4).Top = 1f;
    ((ARControl) this.Label4).Width = 2.812f;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 0.437f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.Label5.Text = "Mortgagee:";
    ((ARControl) this.Label5).Top = 2.062f;
    ((ARControl) this.Label5).Width = 7.375f;
    ((ARControl) this.txtAgent).DataField = "producer";
    ((ARControl) this.txtAgent).Height = 13f / 16f;
    ((ARControl) this.txtAgent).Left = 5f;
    ((ARControl) this.txtAgent).Name = "txtAgent";
    this.txtAgent.Style = "font-size: 9pt; ddo-char-set: 0";
    this.txtAgent.Text = "[Agent]";
    ((ARControl) this.txtAgent).Top = 19f / 16f;
    ((ARControl) this.txtAgent).Width = 2.812f;
    ((ARControl) this.txtInsured).DataField = "insured";
    ((ARControl) this.txtInsured).Height = 13f / 16f;
    ((ARControl) this.txtInsured).Left = 0.437f;
    ((ARControl) this.txtInsured).Name = "txtInsured";
    this.txtInsured.Style = "font-size: 9pt; ddo-char-set: 0";
    this.txtInsured.Text = "[Insured]";
    ((ARControl) this.txtInsured).Top = 19f / 16f;
    ((ARControl) this.txtInsured).Width = 3.563f;
    ((ARControl) this.txtMortgagee).DataField = "mortgagee";
    ((ARControl) this.txtMortgagee).Height = 19f / 16f;
    ((ARControl) this.txtMortgagee).Left = 0.437f;
    ((ARControl) this.txtMortgagee).Name = "txtMortgagee";
    this.txtMortgagee.Style = "font-size: 9pt; ddo-char-set: 0";
    this.txtMortgagee.Text = "[Mortgagee]";
    ((ARControl) this.txtMortgagee).Top = 2.2495f;
    ((ARControl) this.txtMortgagee).Width = 7.375f;
    ((ARControl) this.txtCompanyName).DataField = "company";
    ((ARControl) this.txtCompanyName).Height = 3f / 16f;
    ((ARControl) this.txtCompanyName).Left = 1.9995f;
    ((ARControl) this.txtCompanyName).Name = "txtCompanyName";
    this.txtCompanyName.Style = "font-size: 9pt; ddo-char-set: 0";
    this.txtCompanyName.Text = "[Company Name]";
    ((ARControl) this.txtCompanyName).Top = 11f / 16f;
    ((ARControl) this.txtCompanyName).Width = 5.25f;
    ((ARControl) this.txtRecBalance).DataField = "receivablebalance";
    ((ARControl) this.txtRecBalance).Height = 0.2f;
    ((ARControl) this.txtRecBalance).Left = 5.187f;
    ((ARControl) this.txtRecBalance).Name = "txtRecBalance";
    this.txtRecBalance.Style = "background-color: Red; ddo-char-set: 0";
    this.txtRecBalance.Text = "TextBox5";
    ((ARControl) this.txtRecBalance).Top = 0.0f;
    ((ARControl) this.txtRecBalance).Visible = false;
    ((ARControl) this.txtRecBalance).Width = 1f;
    ((ARControl) this.txtQuoteId).DataField = "quoteid";
    ((ARControl) this.txtQuoteId).Height = 0.2f;
    ((ARControl) this.txtQuoteId).Left = 3.687f;
    ((ARControl) this.txtQuoteId).Name = "txtQuoteId";
    this.txtQuoteId.Style = "background-color: Red; ddo-char-set: 0";
    this.txtQuoteId.Text = (string) null;
    ((ARControl) this.txtQuoteId).Top = 0.0f;
    ((ARControl) this.txtQuoteId).Visible = false;
    ((ARControl) this.txtQuoteId).Width = 1f;
    ((ARControl) this.lblStateId).DataField = "stateid";
    ((ARControl) this.lblStateId).Height = 0.2f;
    this.lblStateId.HyperLink = (string) null;
    ((ARControl) this.lblStateId).Left = 0.5f;
    ((ARControl) this.lblStateId).Name = "lblStateId";
    this.lblStateId.Style = "ddo-char-set: 0";
    this.lblStateId.Text = "";
    ((ARControl) this.lblStateId).Top = 151f / 16f;
    ((ARControl) this.lblStateId).Visible = false;
    ((ARControl) this.lblStateId).Width = 1f;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 0.75f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.Label12.Text = "Issued Through Agency or Office at:";
    ((ARControl) this.Label12).Top = 4.75f;
    ((ARControl) this.Label12).Width = 2.25f;
    ((ARControl) this.TextBox3).DataField = "officelocation";
    ((ARControl) this.TextBox3).Height = 0.5620003f;
    ((ARControl) this.TextBox3).Left = 3.125f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 9pt; ddo-char-set: 0";
    this.TextBox3.Text = "[Office Location]";
    ((ARControl) this.TextBox3).Top = 4.75f;
    ((ARControl) this.TextBox3).Width = 4.375f;
    ((ARControl) this.CommentDescriptionLabel).Height = 3f / 16f;
    this.CommentDescriptionLabel.HyperLink = (string) null;
    ((ARControl) this.CommentDescriptionLabel).Left = 0.188f;
    ((ARControl) this.CommentDescriptionLabel).Name = "CommentDescriptionLabel";
    this.CommentDescriptionLabel.Style = "font-size: 9pt; font-weight: bold; text-decoration: underline; ddo-char-set: 0";
    this.CommentDescriptionLabel.Text = "Description:";
    ((ARControl) this.CommentDescriptionLabel).Top = 8.437f;
    ((ARControl) this.CommentDescriptionLabel).Width = 0.908f;
    ((ARControl) this.CommentDescription).Height = 0.4090006f;
    this.CommentDescription.HyperLink = (string) null;
    ((ARControl) this.CommentDescription).Left = 1.096f;
    ((ARControl) this.CommentDescription).Name = "CommentDescription";
    this.CommentDescription.Style = "ddo-char-set: 0";
    this.CommentDescription.Text = "";
    ((ARControl) this.CommentDescription).Top = 8.437f;
    ((ARControl) this.CommentDescription).Visible = false;
    ((ARControl) this.CommentDescription).Width = 6.467f;
    this.PageHeader.Height = 0.0f;
    ((Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((Section) this.PageFooter).Name = "PageFooter";
    this.GroupHeader1.DataField = "PrintFor";
    this.GroupHeader1.Height = 0.0f;
    ((Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupFooter1.Height = 0.0f;
    ((Section) this.GroupFooter1).Name = "GroupFooter1";
    this.GroupFooter1.NewPage = (NewPage) 2;
    this.GroupHeader2.DataField = "Mortgagee";
    this.GroupHeader2.Height = 0.0f;
    ((Section) this.GroupHeader2).Name = "GroupHeader2";
    this.GroupFooter2.Height = 0.0f;
    ((Section) this.GroupFooter2).Name = "GroupFooter2";
    this.GroupFooter2.NewPage = (NewPage) 2;
    this.GroupHeader3.DataField = "invoicenum";
    this.GroupHeader3.Height = 0.0f;
    ((Section) this.GroupHeader3).Name = "GroupHeader3";
    this.GroupFooter3.Height = 0.0f;
    ((Section) this.GroupFooter3).Name = "GroupFooter3";
    this.GroupFooter3.NewPage = (NewPage) 2;
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.2f;
    this.PageSettings.Margins.Left = 0.2f;
    this.PageSettings.Margins.Right = 0.2f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.864583f;
    this.Sections.Add((Section) this.PageHeader);
    this.Sections.Add((Section) this.GroupHeader3);
    this.Sections.Add((Section) this.GroupHeader1);
    this.Sections.Add((Section) this.GroupHeader2);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.GroupFooter2);
    this.Sections.Add((Section) this.GroupFooter1);
    this.Sections.Add((Section) this.GroupFooter3);
    this.Sections.Add((Section) this.PageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.txtPolicyType).EndInit();
    ((ISupportInitialize) this.txtPolicyNumber).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.txtMailingDate).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.lblCeaseMsg).EndInit();
    ((ISupportInitialize) this.lblNoAmount).EndInit();
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
    ((ISupportInitialize) this.txtRecBalance).EndInit();
    ((ISupportInitialize) this.txtQuoteId).EndInit();
    ((ISupportInitialize) this.lblStateId).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.CommentDescriptionLabel).EndInit();
    ((ISupportInitialize) this.CommentDescription).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void PendingCancellation_PageStart(object sender, EventArgs e)
  {
    this.lblCeaseMsg.Text = "\tYou are hereby notified in accordance with the terms and conditions of the captioned policy, and in accordance with the law that your insurance will cease at and from the hour and date stated above.";
    if (Information.IsDBNull((object) this.Fields["mortgagee"]))
      this.txtMortgagee.Value = (object) "";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._stateid, "", false) == 0)
      this._stateid = this.Fields["stateid"].Value.ToString();
    this.lblReason.Text = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._stateid, "NY", false) != 0 ? "Nonpayment of premium" : "Section 3426 c(1): Nonpayment of premium";
    this.lblNoAmount.Text = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._stateid, "NY", false) != 0 ? "\tIf cancellation is due to nonpayment of premium, payment of overdue premium to us, or your agent or broker will be considered timely if made by cancellation date shown above. If payment has been made, contact your agent or us or broker immediately." : $"\tIf cancellation is due to nonpayment of premium, full payment of overdue premium in the amount of {Strings.Format((object) this.txtRecBalance.Text, "Currency")} to us, or your agent or broker will be considered timely if made by cancellation date shown above. If payment has been made, contact your agent or us or broker immediately.";
    if (this._paperSource != null)
      ((PrintDocument) this.Document.Printer).PrinterSettings.DefaultPageSettings.PaperSource = this._paperSource;
    this._signature = this.GetQuoteUserSignature(Conversions.ToInteger(this.txtQuoteId.Text), this._connectionString);
    if (this._signature == null)
      return;
    this.Picture1.Image = this._signature;
  }

  public void SetPaperSource(PaperSource ps) => this._paperSource = ps;

  private Image GetQuoteUserSignature(int QuoteID, string ConnectionString)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_GetQuoteIdUserSignature", new SqlConnection(ConnectionString));
    Image quoteUserSignature;
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@quoteid", (object) QuoteID);
      sqlCommand2.Connection.Open();
      object objectValue = RuntimeHelpers.GetObjectValue(sqlCommand2.ExecuteScalar());
      if (objectValue != null && !objectValue.Equals((object) DBNull.Value))
      {
        byte[] buffer = (byte[]) objectValue;
        if (buffer != null && buffer.Length != 0)
        {
          Image image = (Image) new Bitmap((Stream) new MemoryStream(buffer));
          ((Bitmap) image).MakeTransparent(((Bitmap) image).GetPixel(0, 0));
          quoteUserSignature = image;
          goto label_12;
        }
      }
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
    quoteUserSignature = (Image) null;
label_12:
    return quoteUserSignature;
  }

  private void PendingCancellation_ReportStart(object sender, EventArgs e)
  {
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
        ((Section) detail1).Format -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((Section) detail2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (SystemSettings.KeyExists("UseNOCDescription") && SystemSettings.GetBoolSetting("UseNOCDescription"))
    {
      ((ARControl) this.CommentDescriptionLabel).Visible = true;
      ((ARControl) this.CommentDescription).Visible = true;
      this.CommentDescription.Text = DefaultDatabase.ExecuteScalar("dbo.spFin_GetNoticeDescription", new object[2]
      {
        (object) "@QuoteId",
        (object) this.txtQuoteId.Text
      }).ToString();
    }
    else
    {
      ((ARControl) this.CommentDescriptionLabel).Visible = false;
      ((ARControl) this.CommentDescription).Visible = false;
    }
  }
}
