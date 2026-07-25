// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptPolicyInquiryReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptPolicyInquiryReport : MGAReport, IReport
{
  private TextBox TextBox9;
  private Label Label6;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label7;
  private Label Label8;
  private TextBox txtInvoiceNum;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private SubReport SubReport;
  private Label Label;
  private TextBox TextBox;
  private TextBox TextBox10;
  private TextBox TextBox11;
  private TextBox TextBox12;
  private TextBox TextBox13;
  private readonly DataSet _ds;
  private int _invoiceNum;

  private virtual ReportHeader ReportHeader
  {
    get => this._ReportHeader;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportHeader_Format);
      ReportHeader reportHeader1 = this._ReportHeader;
      if (reportHeader1 != null)
        ((Section) reportHeader1).Format -= eventHandler;
      this._ReportHeader = value;
      ReportHeader reportHeader2 = this._ReportHeader;
      if (reportHeader2 == null)
        return;
      ((Section) reportHeader2).Format += eventHandler;
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

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextPolicyNumber")]
  internal virtual TextBox TextPolicyNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextNamedInsured")]
  internal virtual TextBox TextNamedInsured { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptPolicyInquiryReport()
  {
    this.ReportStart += new EventHandler(this.rptPolicyInquiryReport_ReportStart);
    this.InitializeComponent();
  }

  public rptPolicyInquiryReport(DataSet ds)
  {
    this.ReportStart += new EventHandler(this.rptPolicyInquiryReport_ReportStart);
    this.InitializeComponent();
    this._ds = ds;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptPolicyInquiryReport));
    this.Detail = new Detail();
    this.txtInvoiceNum = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.SubReport = new SubReport();
    this.ReportHeader = new ReportHeader();
    this.TextBox9 = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.Label = new Label();
    this.TextBox = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.PageHeader = new PageHeader();
    this.Label6 = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.Label9 = new Label();
    this.TextPolicyNumber = new TextBox();
    this.Label10 = new Label();
    this.TextNamedInsured = new TextBox();
    ((ISupportInitialize) this.txtInvoiceNum).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.TextPolicyNumber).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.TextNamedInsured).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.txtInvoiceNum,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.SubReport
    });
    ((Section) this.Detail).Height = 0.4784722f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.txtInvoiceNum).Border.BottomColor = Color.Black;
    ((ARControl) this.txtInvoiceNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).Border.LeftColor = Color.Black;
    ((ARControl) this.txtInvoiceNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).Border.RightColor = Color.Black;
    ((ARControl) this.txtInvoiceNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).Border.TopColor = Color.Black;
    ((ARControl) this.txtInvoiceNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).DataField = "InvoiceNum";
    ((ARControl) this.txtInvoiceNum).Height = 0.125f;
    ((ARControl) this.txtInvoiceNum).Left = 0.0f;
    ((ARControl) this.txtInvoiceNum).Name = "txtInvoiceNum";
    this.txtInvoiceNum.Style = "background-color: Yellow; font-size: 9pt; vertical-align: middle; ";
    this.txtInvoiceNum.Text = " ";
    ((ARControl) this.txtInvoiceNum).Top = 1f / 16f;
    ((ARControl) this.txtInvoiceNum).Visible = false;
    ((ARControl) this.txtInvoiceNum).Width = 0.7395833f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "OfficeInvoiceNum";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 0.01041669f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 9pt; vertical-align: middle; ";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 0.7395833f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "InvoiceDate";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 0.75f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "font-size: 9pt; vertical-align: middle; ";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.875f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "DueDate";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 1.635417f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "font-size: 9pt; vertical-align: middle; ";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 0.8020833f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "GrossPremium";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 39f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "text-align: right; font-size: 9pt; vertical-align: middle; ";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 1.125f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "Fees";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 57f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "text-align: right; font-size: 9pt; vertical-align: middle; ";
    this.TextBox5.Text = " ";
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 1f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "NetBilled";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 73f / 16f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "text-align: right; font-size: 8pt; vertical-align: middle; ";
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 17f / 16f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "AmtPTD";
    ((ARControl) this.TextBox7).Height = 0.125f;
    ((ARControl) this.TextBox7).Left = 5.625f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "text-align: right; font-size: 8pt; vertical-align: middle; ";
    this.TextBox7.Text = " ";
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 1.041667f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "Surplus";
    ((ARControl) this.TextBox8).Height = 0.125f;
    ((ARControl) this.TextBox8).Left = 107f / 16f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "text-align: right; font-size: 8pt; vertical-align: middle; ";
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 17f / 16f;
    ((ARControl) this.SubReport).Border.BottomColor = Color.Black;
    ((ARControl) this.SubReport).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport).Border.LeftColor = Color.Black;
    ((ARControl) this.SubReport).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport).Border.RightColor = Color.Black;
    ((ARControl) this.SubReport).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport).Border.TopColor = Color.Black;
    ((ARControl) this.SubReport).Border.TopStyle = (BorderLineStyle) 0;
    this.SubReport.CloseBorder = false;
    ((ARControl) this.SubReport).Height = 0.125f;
    ((ARControl) this.SubReport).Left = 0.375f;
    ((ARControl) this.SubReport).Name = "SubReport";
    this.SubReport.Report = (SectionReport) null;
    ((ARControl) this.SubReport).Top = 0.25f;
    ((ARControl) this.SubReport).Width = 7.25f;
    ((Section) this.ReportHeader).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.TextBox9,
      (ARControl) this.Label9,
      (ARControl) this.TextPolicyNumber,
      (ARControl) this.Label10,
      (ARControl) this.TextNamedInsured
    });
    this.ReportHeader.Height = 0.75f;
    ((Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.TextBox9).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Height = 0.25f;
    ((ARControl) this.TextBox9).Left = 0.0f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.Style = "ddo-char-set: 0; text-align: center; font-size: 14.25pt; ";
    this.TextBox9.Text = "Policy Inquiry Report";
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 123f / 16f;
    ((Section) this.ReportFooter).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.Label,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13
    });
    this.ReportFooter.Height = 0.3333333f;
    ((Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.Label).Border.BottomColor = Color.Black;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Border.LeftColor = Color.Black;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightColor = Color.Black;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopColor = Color.Black;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Height = 0.25f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 1f / 16f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "text-align: right; font-weight: bold; vertical-align: middle; ";
    this.Label.Text = "Grand Totals:";
    ((ARControl) this.Label).Top = 0.125f;
    ((ARControl) this.Label).Width = 1.052083f;
    ((ARControl) this.TextBox).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "Fees";
    ((ARControl) this.TextBox).Height = 0.125f;
    ((ARControl) this.TextBox).Left = 57f / 16f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = resourceManager.GetString("TextBox.OutputFormat");
    this.TextBox.Style = "text-align: right; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.TextBox.SummaryType = (SummaryType) 1;
    this.TextBox.Text = " ";
    ((ARControl) this.TextBox).Top = 0.125f;
    ((ARControl) this.TextBox).Width = 1f;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "NetBilled";
    ((ARControl) this.TextBox10).Height = 0.125f;
    ((ARControl) this.TextBox10).Left = 73f / 16f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = resourceManager.GetString("TextBox10.OutputFormat");
    this.TextBox10.Style = "text-align: right; font-weight: bold; font-size: 8pt; vertical-align: middle; ";
    this.TextBox10.SummaryType = (SummaryType) 1;
    this.TextBox10.Text = " ";
    ((ARControl) this.TextBox10).Top = 0.125f;
    ((ARControl) this.TextBox10).Width = 1.052083f;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "AmtPTD";
    ((ARControl) this.TextBox11).Height = 0.125f;
    ((ARControl) this.TextBox11).Left = 5.614583f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "text-align: right; font-weight: bold; font-size: 8pt; vertical-align: middle; ";
    this.TextBox11.SummaryType = (SummaryType) 1;
    this.TextBox11.Text = " ";
    ((ARControl) this.TextBox11).Top = 0.125f;
    ((ARControl) this.TextBox11).Width = 1.125f;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "Surplus";
    ((ARControl) this.TextBox12).Height = 0.125f;
    ((ARControl) this.TextBox12).Left = 6.739583f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "text-align: right; font-weight: bold; font-size: 8pt; vertical-align: middle; ";
    this.TextBox12.SummaryType = (SummaryType) 1;
    this.TextBox12.Text = " ";
    ((ARControl) this.TextBox12).Top = 0.125f;
    ((ARControl) this.TextBox12).Width = 1f;
    ((ARControl) this.TextBox13).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "GrossPremium";
    ((ARControl) this.TextBox13).Height = 0.125f;
    ((ARControl) this.TextBox13).Left = 2.427083f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = resourceManager.GetString("TextBox13.OutputFormat");
    this.TextBox13.Style = "text-align: right; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.TextBox13.SummaryType = (SummaryType) 1;
    this.TextBox13.Text = " ";
    ((ARControl) this.TextBox13).Top = 0.125f;
    ((ARControl) this.TextBox13).Width = 1.125f;
    ((Section) this.PageHeader).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.Label6,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label7,
      (ARControl) this.Label8
    });
    this.PageHeader.Height = 0.3222222f;
    ((Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Height = 0.25f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 0.0f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label6.Text = "Invoice #";
    ((ARControl) this.Label6).Top = 1f / 16f;
    ((ARControl) this.Label6).Width = 0.75f;
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Height = 0.25f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.75f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label1.Text = "Invoice Date";
    ((ARControl) this.Label1).Top = 1f / 16f;
    ((ARControl) this.Label1).Width = 0.875f;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Height = 0.25f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 1.625f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label2.Text = "Due Date";
    ((ARControl) this.Label2).Top = 1f / 16f;
    ((ARControl) this.Label2).Width = 13f / 16f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Height = 0.25f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 39f / 16f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "text-align: right; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label3.Text = "Gross Premium";
    ((ARControl) this.Label3).Top = 1f / 16f;
    ((ARControl) this.Label3).Width = 1.125f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Height = 0.25f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 57f / 16f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "text-align: right; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label4.Text = "Fees";
    ((ARControl) this.Label4).Top = 1f / 16f;
    ((ARControl) this.Label4).Width = 1f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Height = 0.25f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 73f / 16f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "text-align: right; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label5.Text = "Net Billed";
    ((ARControl) this.Label5).Top = 1f / 16f;
    ((ARControl) this.Label5).Width = 17f / 16f;
    ((ARControl) this.Label7).Border.BottomColor = Color.Black;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.LeftColor = Color.Black;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightColor = Color.Black;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopColor = Color.Black;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Height = 0.25f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 5.625f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "text-align: right; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label7.Text = "Amt PTD";
    ((ARControl) this.Label7).Top = 1f / 16f;
    ((ARControl) this.Label7).Width = 17f / 16f;
    ((ARControl) this.Label8).Border.BottomColor = Color.Black;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Border.LeftColor = Color.Black;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightColor = Color.Black;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopColor = Color.Black;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Height = 0.25f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 107f / 16f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "text-align: right; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label8.Text = "Surplus";
    ((ARControl) this.Label8).Top = 1f / 16f;
    ((ARControl) this.Label8).Width = 17f / 16f;
    this.PageFooter.Height = 0.2388889f;
    ((Section) this.PageFooter).Name = "PageFooter";
    this.GroupHeader1.Height = 0.25f;
    ((Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupFooter1.Height = 0.25f;
    ((Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.Label9).Border.BottomColor = Color.Black;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftColor = Color.Black;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightColor = Color.Black;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopColor = Color.Black;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 0.0f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-weight: bold; ";
    this.Label9.Text = "Policy Number:";
    ((ARControl) this.Label9).Top = 5f / 16f;
    ((ARControl) this.Label9).Width = 19f / 16f;
    ((ARControl) this.TextPolicyNumber).Border.BottomColor = Color.Black;
    ((ARControl) this.TextPolicyNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextPolicyNumber).Border.LeftColor = Color.Black;
    ((ARControl) this.TextPolicyNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextPolicyNumber).Border.RightColor = Color.Black;
    ((ARControl) this.TextPolicyNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextPolicyNumber).Border.TopColor = Color.Black;
    ((ARControl) this.TextPolicyNumber).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextPolicyNumber).Height = 3f / 16f;
    ((ARControl) this.TextPolicyNumber).Left = 19f / 16f;
    ((ARControl) this.TextPolicyNumber).Name = "TextPolicyNumber";
    this.TextPolicyNumber.Style = "";
    ((ARControl) this.TextPolicyNumber).Top = 5f / 16f;
    ((ARControl) this.TextPolicyNumber).Width = 95f / 16f;
    ((ARControl) this.Label10).Border.BottomColor = Color.Black;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftColor = Color.Black;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightColor = Color.Black;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopColor = Color.Black;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 0.0f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-weight: bold; ";
    this.Label10.Text = "Named Insured:";
    ((ARControl) this.Label10).Top = 0.5f;
    ((ARControl) this.Label10).Width = 19f / 16f;
    ((ARControl) this.TextNamedInsured).Border.BottomColor = Color.Black;
    ((ARControl) this.TextNamedInsured).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextNamedInsured).Border.LeftColor = Color.Black;
    ((ARControl) this.TextNamedInsured).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextNamedInsured).Border.RightColor = Color.Black;
    ((ARControl) this.TextNamedInsured).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextNamedInsured).Border.TopColor = Color.Black;
    ((ARControl) this.TextNamedInsured).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextNamedInsured).Height = 3f / 16f;
    ((ARControl) this.TextNamedInsured).Left = 19f / 16f;
    ((ARControl) this.TextNamedInsured).Name = "TextNamedInsured";
    this.TextNamedInsured.Style = "";
    ((ARControl) this.TextNamedInsured).Top = 0.5f;
    ((ARControl) this.TextNamedInsured).Width = 95f / 16f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.854167f;
    this.Sections.Add((Section) this.ReportHeader);
    this.Sections.Add((Section) this.PageHeader);
    this.Sections.Add((Section) this.GroupHeader1);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.GroupFooter1);
    this.Sections.Add((Section) this.PageFooter);
    this.Sections.Add((Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtInvoiceNum).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.TextPolicyNumber).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.TextNamedInsured).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls => (BaseReportControl[]) null;

  private void Detail_Format(object sender, EventArgs e)
  {
    this.SubReport.Report = (SectionReport) new rptPolicyInquiry_Sub(new DataView(this._ds.Tables[1], "InvoiceNum =" + Conversions.ToString(Conversions.ToInteger(this.txtInvoiceNum.Text)), "", DataViewRowState.CurrentRows));
  }

  private void rptPolicyInquiryReport_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) this._ds.Tables[0];
  }

  private void ReportHeader_Format(object sender, EventArgs e)
  {
    this._invoiceNum = Conversions.ToInteger(this._ds.Tables[0].Rows[0]["InvoiceNum"]);
    if (string.IsNullOrEmpty(DefaultDatabase.ConnectionString))
      DefaultDatabase.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.TextPolicyNumber.Text = Utility.IsNull<string>((object) DefaultDatabase.ExecuteScalar(CommandType.Text, "Select TOP 1 tblQuotes.PolicyNumber From tblFin_Invoices INNER JOIN tblQuotes ON tblFin_Invoices.QuoteID = tblQuotes.QuoteID Where invoiceNum=@invoiceNum ORDER BY tblFin_Invoices.InvoiceNum DESC", new object[2]
    {
      (object) "@invoiceNum",
      (object) this._invoiceNum
    }).ToString(), string.Empty);
    string str1 = Utility.IsNull<string>((object) DefaultDatabase.ExecuteScalar(CommandType.Text, "Select TOP 1 tblQuotes.InsuredPolicyName From tblFin_Invoices INNER JOIN tblQuotes ON tblFin_Invoices.QuoteID = tblQuotes.QuoteID Where invoiceNum=@invoiceNum ORDER BY tblFin_Invoices.InvoiceNum DESC", new object[2]
    {
      (object) "@invoiceNum",
      (object) this._invoiceNum
    }).ToString(), string.Empty);
    string str2 = Utility.IsNull<string>((object) DefaultDatabase.ExecuteScalar(CommandType.Text, "Select TOP 1 tblQuotes.InsuredDBA From tblFin_Invoices INNER JOIN tblQuotes ON tblFin_Invoices.QuoteID = tblQuotes.QuoteID Where invoiceNum=@invoiceNum ORDER BY tblFin_Invoices.InvoiceNum DESC", new object[2]
    {
      (object) "@invoiceNum",
      (object) this._invoiceNum
    }).ToString(), string.Empty);
    if (string.IsNullOrEmpty(str2))
      this.TextNamedInsured.Text = str1;
    else
      this.TextNamedInsured.Text = $"{str1} DBA: {str2}";
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    DataTable source = new DataTable();
    source.Columns.Add("Invoice", typeof (int));
    source.Columns.Add("Invoice Date", typeof (DateTime));
    source.Columns.Add("Due Date", typeof (DateTime));
    source.Columns.Add("Gross Premium", typeof (Decimal));
    source.Columns.Add("Fees", typeof (Decimal));
    source.Columns.Add("Net Billed", typeof (Decimal));
    source.Columns.Add("Amt PTD", typeof (Decimal));
    source.Columns.Add("Surplus", typeof (Decimal));
    source.Columns.Add("Transact #", typeof (int));
    source.Columns.Add("Post Date", typeof (DateTime));
    source.Columns.Add("Transaction Description", typeof (string));
    source.Columns.Add("User Name", typeof (string));
    source.Columns.Add("Income Appl.", typeof (Decimal));
    source.Columns.Add("Cash Applied", typeof (Decimal));
    source.Columns.Add("Check Number", typeof (string));
    try
    {
      foreach (DataRow row in this._ds.Tables[0].Rows)
      {
        DataView dataView = new DataView(this._ds.Tables[1], "InvoiceNum =" + Conversions.ToString(Conversions.ToInteger(row["InvoiceNum"])), "", DataViewRowState.CurrentRows);
        try
        {
          foreach (DataRowView dataRowView in dataView)
            source.Rows.Add(row["OfficeInvoiceNum"], row["InvoiceDate"], row["DueDate"], row["GrossPremium"], row["Fees"], row["NetBilled"], row["AmtPTD"], row["Surplus"], dataRowView["TransactNum"], dataRowView["postDate"], dataRowView["Transdescription"], dataRowView["user"], dataRowView["incomeapplied"], dataRowView["cashapplied"], dataRowView["Check Number"]);
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ExcelExport.ToExcel(source, SaveFileTo);
  }
}
