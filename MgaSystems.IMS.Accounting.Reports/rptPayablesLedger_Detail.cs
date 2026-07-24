// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptPayablesLedger_Detail
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptPayablesLedger_Detail : SectionReport
{
  private Label Label10;
  private Label Label2;
  private Label Label8;
  private Label Label9;
  private Label Label5;
  private Label Label4;
  private Label Label3;
  private Label Label1;
  private TextBox EffectiveDateOfPolicy1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private CheckBox CheckBox1;
  private TextBox invoiceDate1;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private Label Label6;
  private Label Label7;
  private TextBox TextBox9;
  private TextBox openingAR1;
  private TextBox openingAR2;

  public rptPayablesLedger_Detail() => this.InitializeComponent();

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptPayablesLedger_Detail));
    this.Detail = new Detail();
    this.TextBox10 = new TextBox();
    this.EffectiveDateOfPolicy1 = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.CheckBox1 = new CheckBox();
    this.invoiceDate1 = new TextBox();
    this.TextBox11 = new TextBox();
    this.CheckBox2 = new CheckBox();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.Label7 = new Label();
    this.TextBox9 = new TextBox();
    this.openingAR1 = new TextBox();
    this.openingAR2 = new TextBox();
    this.TextBox13 = new TextBox();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.Label10 = new Label();
    this.Label2 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label1 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.GroupFooter1 = new GroupFooter();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.Label6 = new Label();
    this.TextBox12 = new TextBox();
    this.Label14 = new Label();
    this.TextBox14 = new TextBox();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.EffectiveDateOfPolicy1).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.CheckBox1).BeginInit();
    ((ISupportInitialize) this.invoiceDate1).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.CheckBox2).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.openingAR1).BeginInit();
    ((ISupportInitialize) this.openingAR2).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[12]
    {
      (ARControl) this.TextBox10,
      (ARControl) this.EffectiveDateOfPolicy1,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.CheckBox1,
      (ARControl) this.invoiceDate1,
      (ARControl) this.TextBox11,
      (ARControl) this.CheckBox2,
      (ARControl) this.TextBox14
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1458333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox10).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).DataField = "PolicyNumber";
    ((ARControl) this.TextBox10).Height = 3f / 16f;
    ((ARControl) this.TextBox10).Left = 0.5833333f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.Style = "ddo-char-set: 0; font-size: 8pt; font-family: Tahoma; ";
    this.TextBox10.Text = " ";
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 1.083333f;
    ((ARControl) this.EffectiveDateOfPolicy1).Border.BottomColor = Color.Black;
    ((ARControl) this.EffectiveDateOfPolicy1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.EffectiveDateOfPolicy1).Border.LeftColor = Color.Black;
    ((ARControl) this.EffectiveDateOfPolicy1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.EffectiveDateOfPolicy1).Border.RightColor = Color.Black;
    ((ARControl) this.EffectiveDateOfPolicy1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.EffectiveDateOfPolicy1).Border.TopColor = Color.Black;
    ((ARControl) this.EffectiveDateOfPolicy1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.EffectiveDateOfPolicy1).DataField = "dueDate";
    ((ARControl) this.EffectiveDateOfPolicy1).Height = 3f / 16f;
    ((ARControl) this.EffectiveDateOfPolicy1).Left = 139f / 32f;
    ((ARControl) this.EffectiveDateOfPolicy1).Name = "EffectiveDateOfPolicy1";
    this.EffectiveDateOfPolicy1.OutputFormat = resourceManager.GetString("EffectiveDateOfPolicy1.OutputFormat");
    this.EffectiveDateOfPolicy1.Style = "ddo-char-set: 0; font-size: 8pt; font-family: Tahoma; ";
    this.EffectiveDateOfPolicy1.Text = (string) null;
    ((ARControl) this.EffectiveDateOfPolicy1).Top = 0.0f;
    ((ARControl) this.EffectiveDateOfPolicy1).Width = 0.6458333f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "invoiceNumber";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "ddo-char-set: 0; font-size: 8pt; font-family: Tahoma; ";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 0.5833333f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "openingAp";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 6.791667f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "ddo-char-set: 0; text-align: right; font-size: 8pt; font-family: Tahoma; ";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 31f / 32f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "APPtd";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 8.552083f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "ddo-char-set: 0; text-align: right; font-size: 8pt; font-family: Tahoma; ";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 0.7874016f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "closingBalance";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 299f / 32f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "ddo-char-set: 0; text-align: right; font-size: 8pt; font-family: Tahoma; ";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 33f / 32f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "invoiceDate";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 3.583333f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "ddo-char-set: 0; font-size: 8pt; font-family: Tahoma; ";
    this.TextBox5.Text = " ";
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 0.7604167f;
    ((ARControl) this.CheckBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.CheckBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.CheckBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.CheckBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.CheckBox1).Border.RightColor = Color.Black;
    ((ARControl) this.CheckBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.CheckBox1).Border.TopColor = Color.Black;
    ((ARControl) this.CheckBox1).Border.TopStyle = (BorderLineStyle) 1;
    this.CheckBox1.CheckAlignment = ContentAlignment.MiddleCenter;
    ((ARControl) this.CheckBox1).DataField = "Printed";
    ((ARControl) this.CheckBox1).Height = 3f / 16f;
    ((ARControl) this.CheckBox1).Left = 5.635417f;
    ((ARControl) this.CheckBox1).Name = "CheckBox1";
    this.CheckBox1.Style = "font-size: 8pt; font-family: Tahoma; ";
    this.CheckBox1.Text = "";
    ((ARControl) this.CheckBox1).Top = 0.0f;
    ((ARControl) this.CheckBox1).Width = 15f / 32f;
    ((ARControl) this.invoiceDate1).Border.BottomColor = Color.Black;
    ((ARControl) this.invoiceDate1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.invoiceDate1).Border.LeftColor = Color.Black;
    ((ARControl) this.invoiceDate1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.invoiceDate1).Border.RightColor = Color.Black;
    ((ARControl) this.invoiceDate1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.invoiceDate1).Border.TopColor = Color.Black;
    ((ARControl) this.invoiceDate1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.invoiceDate1).DataField = "EffectiveDateOfPolicy";
    ((ARControl) this.invoiceDate1).Height = 3f / 16f;
    ((ARControl) this.invoiceDate1).Left = 4.989583f;
    ((ARControl) this.invoiceDate1).Name = "invoiceDate1";
    this.invoiceDate1.OutputFormat = resourceManager.GetString("invoiceDate1.OutputFormat");
    this.invoiceDate1.Style = "ddo-char-set: 0; font-size: 8pt; font-family: Tahoma; ";
    this.invoiceDate1.Text = (string) null;
    ((ARControl) this.invoiceDate1).Top = 0.0f;
    ((ARControl) this.invoiceDate1).Width = 0.6458333f;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).DataField = "Billings";
    ((ARControl) this.TextBox11).Height = 3f / 16f;
    ((ARControl) this.TextBox11).Left = 7.760417f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "ddo-char-set: 0; text-align: right; font-size: 8pt; font-family: Tahoma; ";
    this.TextBox11.Text = " ";
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 0.7874016f;
    ((ARControl) this.CheckBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.CheckBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.CheckBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.CheckBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.CheckBox2).Border.RightColor = Color.Black;
    ((ARControl) this.CheckBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.CheckBox2).Border.TopColor = Color.Black;
    ((ARControl) this.CheckBox2).Border.TopStyle = (BorderLineStyle) 1;
    this.CheckBox2.CheckAlignment = ContentAlignment.MiddleCenter;
    ((ARControl) this.CheckBox2).DataField = "IsInstallmentInvoice";
    ((ARControl) this.CheckBox2).Height = 3f / 16f;
    ((ARControl) this.CheckBox2).Left = 6.104167f;
    ((ARControl) this.CheckBox2).Name = "CheckBox2";
    this.CheckBox2.Style = "font-size: 8pt; font-family: Tahoma; ";
    this.CheckBox2.Text = "";
    ((ARControl) this.CheckBox2).Top = 0.0f;
    ((ARControl) this.CheckBox2).Width = 11f / 16f;
    this.ReportHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Label7,
      (ARControl) this.TextBox9,
      (ARControl) this.openingAR1,
      (ARControl) this.openingAR2,
      (ARControl) this.TextBox13
    });
    this.ReportFooter.Height = 0.2708333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.Label7).Border.BottomColor = Color.Black;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftColor = Color.Black;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightColor = Color.Black;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopColor = Color.Black;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 0.0f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.Label7.Text = "Grand Total:";
    ((ARControl) this.Label7).Top = 1f / 16f;
    ((ARControl) this.Label7).Width = 6.791667f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "openingAp";
    ((ARControl) this.TextBox9).Height = 3f / 16f;
    ((ARControl) this.TextBox9).Left = 6.791667f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.TextBox9.SummaryGroup = "GroupHeader1";
    this.TextBox9.SummaryRunning = (SummaryRunning) 2;
    this.TextBox9.SummaryType = (SummaryType) 1;
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 1f / 16f;
    ((ARControl) this.TextBox9).Width = 31f / 32f;
    ((ARControl) this.openingAR1).Border.BottomColor = Color.Black;
    ((ARControl) this.openingAR1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.openingAR1).Border.LeftColor = Color.Black;
    ((ARControl) this.openingAR1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.openingAR1).Border.RightColor = Color.Black;
    ((ARControl) this.openingAR1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.openingAR1).Border.TopColor = Color.Black;
    ((ARControl) this.openingAR1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.openingAR1).DataField = "APPtd";
    ((ARControl) this.openingAR1).Height = 3f / 16f;
    ((ARControl) this.openingAR1).Left = 8.552083f;
    ((ARControl) this.openingAR1).Name = "openingAR1";
    this.openingAR1.OutputFormat = resourceManager.GetString("openingAR1.OutputFormat");
    this.openingAR1.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.openingAR1.SummaryGroup = "GroupHeader1";
    this.openingAR1.SummaryRunning = (SummaryRunning) 2;
    this.openingAR1.SummaryType = (SummaryType) 1;
    this.openingAR1.Text = (string) null;
    ((ARControl) this.openingAR1).Top = 1f / 16f;
    ((ARControl) this.openingAR1).Width = 0.7874016f;
    ((ARControl) this.openingAR2).Border.BottomColor = Color.Black;
    ((ARControl) this.openingAR2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.openingAR2).Border.LeftColor = Color.Black;
    ((ARControl) this.openingAR2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.openingAR2).Border.RightColor = Color.Black;
    ((ARControl) this.openingAR2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.openingAR2).Border.TopColor = Color.Black;
    ((ARControl) this.openingAR2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.openingAR2).DataField = "closingBalance";
    ((ARControl) this.openingAR2).Height = 3f / 16f;
    ((ARControl) this.openingAR2).Left = 299f / 32f;
    ((ARControl) this.openingAR2).Name = "openingAR2";
    this.openingAR2.OutputFormat = resourceManager.GetString("openingAR2.OutputFormat");
    this.openingAR2.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.openingAR2.SummaryGroup = "GroupHeader1";
    this.openingAR2.SummaryRunning = (SummaryRunning) 2;
    this.openingAR2.SummaryType = (SummaryType) 1;
    this.openingAR2.Text = (string) null;
    ((ARControl) this.openingAR2).Top = 1f / 16f;
    ((ARControl) this.openingAR2).Width = 33f / 32f;
    ((ARControl) this.TextBox13).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "Billings";
    ((ARControl) this.TextBox13).Height = 3f / 16f;
    ((ARControl) this.TextBox13).Left = 7.760417f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = resourceManager.GetString("TextBox13.OutputFormat");
    this.TextBox13.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.TextBox13.SummaryGroup = "GroupHeader1";
    this.TextBox13.SummaryRunning = (SummaryRunning) 2;
    this.TextBox13.SummaryType = (SummaryType) 1;
    this.TextBox13.Text = (string) null;
    ((ARControl) this.TextBox13).Top = 1f / 16f;
    ((ARControl) this.TextBox13).Width = 0.7874016f;
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[12]
    {
      (ARControl) this.Label10,
      (ARControl) this.Label2,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label5,
      (ARControl) this.Label4,
      (ARControl) this.Label3,
      (ARControl) this.Label1,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14
    });
    this.GroupHeader1.DataField = "invMonth";
    this.GroupHeader1.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupHeader1.RepeatStyle = (RepeatStyle) 1;
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
    ((ARControl) this.Label10).Left = 139f / 32f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.Label10.Text = "Due Date";
    ((ARControl) this.Label10).Top = 0.0f;
    ((ARControl) this.Label10).Width = 0.6458333f;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 3.583333f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.Label2.Text = "Invoice Date";
    ((ARControl) this.Label2).Top = 0.0f;
    ((ARControl) this.Label2).Width = 0.7604167f;
    ((ARControl) this.Label8).Border.BottomColor = Color.Black;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftColor = Color.Black;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightColor = Color.Black;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopColor = Color.Black;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 4.989583f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.Label8.Text = "Eff. Date";
    ((ARControl) this.Label8).Top = 0.0f;
    ((ARControl) this.Label8).Width = 0.6458333f;
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
    ((ARControl) this.Label9).Left = 5.635417f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.Label9.Text = "Printed";
    ((ARControl) this.Label9).Top = 0.0f;
    ((ARControl) this.Label9).Width = 15f / 32f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 299f / 32f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.Label5.Text = "Closing Balance";
    ((ARControl) this.Label5).Top = 0.0f;
    ((ARControl) this.Label5).Width = 33f / 32f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 8.552083f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.Label4.Text = "A/P Paid";
    ((ARControl) this.Label4).Top = 0.0f;
    ((ARControl) this.Label4).Width = 0.7874016f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 6.791667f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.Label3.Text = "Opening Balance";
    ((ARControl) this.Label3).Top = 0.0f;
    ((ARControl) this.Label3).Width = 31f / 32f;
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.Label1.Text = "Invoice #";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 0.5833333f;
    ((ARControl) this.Label11).Border.BottomColor = Color.Black;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftColor = Color.Black;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightColor = Color.Black;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopColor = Color.Black;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 0.5833333f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.Label11.Text = "Policy #";
    ((ARControl) this.Label11).Top = 0.0f;
    ((ARControl) this.Label11).Width = 1.083333f;
    ((ARControl) this.Label12).Border.BottomColor = Color.Black;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftColor = Color.Black;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightColor = Color.Black;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopColor = Color.Black;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 7.760417f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.Label12.Text = "Billings";
    ((ARControl) this.Label12).Top = 0.0f;
    ((ARControl) this.Label12).Width = 0.7874016f;
    ((ARControl) this.Label13).Border.BottomColor = Color.Black;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftColor = Color.Black;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightColor = Color.Black;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopColor = Color.Black;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 6.104167f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.Label13.Text = "Installment";
    ((ARControl) this.Label13).Top = 0.0f;
    ((ARControl) this.Label13).Width = 11f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.Label6,
      (ARControl) this.TextBox12
    });
    this.GroupFooter1.Height = 0.1770833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "closingBalance";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 299f / 32f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.TextBox6.SummaryGroup = "GroupHeader1";
    this.TextBox6.SummaryRunning = (SummaryRunning) 1;
    this.TextBox6.SummaryType = (SummaryType) 3;
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 33f / 32f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "APPtd";
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 8.552083f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.TextBox7.SummaryGroup = "GroupHeader1";
    this.TextBox7.SummaryRunning = (SummaryRunning) 1;
    this.TextBox7.SummaryType = (SummaryType) 3;
    this.TextBox7.Text = " ";
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 0.7874016f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "OpeningAp";
    ((ARControl) this.TextBox8).Height = 3f / 16f;
    ((ARControl) this.TextBox8).Left = 6.791667f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.TextBox8.SummaryGroup = "GroupHeader1";
    this.TextBox8.SummaryRunning = (SummaryRunning) 1;
    this.TextBox8.SummaryType = (SummaryType) 3;
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 31f / 32f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 0.0f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.Label6.Text = "Sub-Total:";
    ((ARControl) this.Label6).Top = 0.0f;
    ((ARControl) this.Label6).Width = 6.791667f;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "Billings";
    ((ARControl) this.TextBox12).Height = 3f / 16f;
    ((ARControl) this.TextBox12).Left = 7.760417f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.TextBox12.SummaryGroup = "GroupHeader1";
    this.TextBox12.SummaryRunning = (SummaryRunning) 1;
    this.TextBox12.SummaryType = (SummaryType) 3;
    this.TextBox12.Text = " ";
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 0.7874016f;
    ((ARControl) this.Label14).Border.BottomColor = Color.Black;
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.LeftColor = Color.Black;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightColor = Color.Black;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopColor = Color.Black;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Height = 3f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 1.666667f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8pt; font-family: Tahoma; ";
    this.Label14.Text = "Insured";
    ((ARControl) this.Label14).Top = 0.0f;
    ((ARControl) this.Label14).Width = 1.916667f;
    ((ARControl) this.TextBox14).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox14).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox14).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox14).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).DataField = "insured";
    ((ARControl) this.TextBox14).Height = 3f / 16f;
    ((ARControl) this.TextBox14).Left = 1.666667f;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.Style = "ddo-char-set: 0; font-size: 8pt; font-family: Tahoma; ";
    this.TextBox14.Text = " ";
    ((ARControl) this.TextBox14).Top = 0.0f;
    ((ARControl) this.TextBox14).Width = 1.916667f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.2f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.2f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.EffectiveDateOfPolicy1).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.CheckBox1).EndInit();
    ((ISupportInitialize) this.invoiceDate1).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.CheckBox2).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.openingAR1).EndInit();
    ((ISupportInitialize) this.openingAR2).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox10")]
  private virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  private virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox13")]
  private virtual TextBox TextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox12")]
  private virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CheckBox2")]
  private virtual CheckBox CheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox14")]
  private virtual TextBox TextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  private virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
