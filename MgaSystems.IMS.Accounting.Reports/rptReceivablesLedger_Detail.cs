// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptReceivablesLedger_Detail
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.IMS.Reporting;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptReceivablesLedger_Detail : MGAReport
{
  private Label Label;
  private Label Label10;
  private Label Label9;
  private Label Label8;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private TextBox TextBox;
  private TextBox TextBox2;
  private TextBox EffectiveDateOfPolicy1;
  private TextBox invoiceDate1;
  private TextBox TextBox1;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private CheckBox CheckBox1;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private Label Label6;
  private Label Label7;
  private TextBox TextBox9;
  private TextBox openingAR1;
  private TextBox openingAR2;

  public rptReceivablesLedger_Detail()
  {
    this.ReportStart += new EventHandler(this.rptReceivablesLedger_Detail_ReportStart);
    this.ReportHeader = (ReportHeader) null;
    this.PageHeader = (PageHeader) null;
    this.GroupHeader1 = (GroupHeader) null;
    this.Detail = (Detail) null;
    this.GroupFooter1 = (GroupFooter) null;
    this.PageFooter = (PageFooter) null;
    this.ReportFooter = (ReportFooter) null;
    this.Label = (Label) null;
    this.Label10 = (Label) null;
    this.Label9 = (Label) null;
    this.Label8 = (Label) null;
    this.Label1 = (Label) null;
    this.Label2 = (Label) null;
    this.Label3 = (Label) null;
    this.Label4 = (Label) null;
    this.Label5 = (Label) null;
    this.TextBox = (TextBox) null;
    this.TextBox2 = (TextBox) null;
    this.EffectiveDateOfPolicy1 = (TextBox) null;
    this.invoiceDate1 = (TextBox) null;
    this.TextBox1 = (TextBox) null;
    this.TextBox3 = (TextBox) null;
    this.TextBox4 = (TextBox) null;
    this.TextBox5 = (TextBox) null;
    this.CheckBox1 = (CheckBox) null;
    this.TextBox6 = (TextBox) null;
    this.TextBox7 = (TextBox) null;
    this.TextBox8 = (TextBox) null;
    this.Label6 = (Label) null;
    this.Label7 = (Label) null;
    this.TextBox9 = (TextBox) null;
    this.openingAR1 = (TextBox) null;
    this.openingAR2 = (TextBox) null;
    this.InitializeComponent();
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.Detail_Format);
      EventHandler eventHandler2 = new EventHandler(this.Detail_BeforePrint);
      Detail detail1 = this._Detail;
      if (detail1 != null)
      {
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).Format -= eventHandler1;
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).BeforePrint -= eventHandler2;
      }
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).Format += eventHandler1;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).BeforePrint += eventHandler2;
    }
  }

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

  [field: AccessedThroughProperty("TextBox12")]
  private virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  private virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox13")]
  private virtual TextBox TextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptReceivablesLedger_Detail));
    this.Detail = new Detail();
    this.TextBox10 = new TextBox();
    this.TextBox2 = new TextBox();
    this.EffectiveDateOfPolicy1 = new TextBox();
    this.invoiceDate1 = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.CheckBox1 = new CheckBox();
    this.TextBox = new TextBox();
    this.TextBox13 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.Label7 = new Label();
    this.TextBox9 = new TextBox();
    this.openingAR1 = new TextBox();
    this.openingAR2 = new TextBox();
    this.TextBox12 = new TextBox();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.Label = new Label();
    this.Label10 = new Label();
    this.Label9 = new Label();
    this.Label8 = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.GroupFooter1 = new GroupFooter();
    this.Label6 = new Label();
    this.TextBox11 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.EffectiveDateOfPolicy1).BeginInit();
    ((ISupportInitialize) this.invoiceDate1).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.CheckBox1).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.openingAR1).BeginInit();
    ((ISupportInitialize) this.openingAR2).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox2,
      (ARControl) this.EffectiveDateOfPolicy1,
      (ARControl) this.invoiceDate1,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.CheckBox1,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox13
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).DataField = "Billings";
    ((ARControl) this.TextBox10).Height = 3f / 16f;
    ((ARControl) this.TextBox10).Left = 119f / 16f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = resourceManager.GetString("TextBox10.OutputFormat");
    this.TextBox10.Style = "font-family: Tahoma; font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.TextBox10.Text = " ";
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 15f / 16f;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "openingAR";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 6.375f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "font-family: Tahoma; font-size: 8pt; text-align: right; ddo-char-set: 0";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 17f / 16f;
    ((ARControl) this.EffectiveDateOfPolicy1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.EffectiveDateOfPolicy1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.EffectiveDateOfPolicy1).DataField = "dueDate";
    ((ARControl) this.EffectiveDateOfPolicy1).Height = 3f / 16f;
    ((ARControl) this.EffectiveDateOfPolicy1).Left = 69f / 16f;
    ((ARControl) this.EffectiveDateOfPolicy1).Name = "EffectiveDateOfPolicy1";
    this.EffectiveDateOfPolicy1.OutputFormat = resourceManager.GetString("EffectiveDateOfPolicy1.OutputFormat");
    this.EffectiveDateOfPolicy1.Style = "font-family: Tahoma; font-size: 8pt; ddo-char-set: 0";
    this.EffectiveDateOfPolicy1.Text = " ";
    ((ARControl) this.EffectiveDateOfPolicy1).Top = 0.0f;
    ((ARControl) this.EffectiveDateOfPolicy1).Width = 0.75f;
    ((ARControl) this.invoiceDate1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.invoiceDate1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.invoiceDate1).DataField = "EffectiveDateOfPolicy";
    ((ARControl) this.invoiceDate1).Height = 3f / 16f;
    ((ARControl) this.invoiceDate1).Left = 81f / 16f;
    ((ARControl) this.invoiceDate1).Name = "invoiceDate1";
    this.invoiceDate1.OutputFormat = resourceManager.GetString("invoiceDate1.OutputFormat");
    this.invoiceDate1.Style = "font-family: Tahoma; font-size: 8pt; ddo-char-set: 0";
    this.invoiceDate1.Text = " ";
    ((ARControl) this.invoiceDate1).Top = 0.0f;
    ((ARControl) this.invoiceDate1).Width = 0.75f;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "invoiceNumber";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 45f / 16f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-family: Tahoma; font-size: 8pt; ddo-char-set: 0";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 0.625f;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "ARReceived";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 8.375f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "font-family: Tahoma; font-size: 8pt; text-align: right; ddo-char-set: 0";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 17f / 16f;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "closingBalance";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 151f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "font-family: Tahoma; font-size: 8pt; text-align: right; ddo-char-set: 0";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 15f / 16f;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "invoiceDate";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 55f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "font-family: Tahoma; font-size: 8pt; ddo-char-set: 0";
    this.TextBox5.Text = " ";
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 0.875f;
    ((ARControl) this.CheckBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.CheckBox1).Border.RightStyle = (BorderLineStyle) 1;
    this.CheckBox1.CheckAlignment = ContentAlignment.TopCenter;
    ((ARControl) this.CheckBox1).DataField = "Printed";
    ((ARControl) this.CheckBox1).Height = 3f / 16f;
    ((ARControl) this.CheckBox1).Left = 93f / 16f;
    ((ARControl) this.CheckBox1).Name = "CheckBox1";
    this.CheckBox1.Style = "font-family: Tahoma; font-size: 8pt";
    this.CheckBox1.Text = "";
    ((ARControl) this.CheckBox1).Top = 0.0f;
    ((ARControl) this.CheckBox1).Width = 9f / 16f;
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).DataField = "PolicyNumber";
    ((ARControl) this.TextBox).Height = 3f / 16f;
    ((ARControl) this.TextBox).Left = 1f / 16f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-family: Tahoma; font-size: 8pt; ddo-char-set: 0";
    this.TextBox.Text = " ";
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 21f / 16f;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox13).DataField = "InsuredPolicyName";
    ((ARControl) this.TextBox13).Height = 3f / 16f;
    ((ARControl) this.TextBox13).Left = 1.375f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.Style = "font-family: Tahoma; font-size: 8pt; ddo-char-set: 0";
    this.TextBox13.Text = " ";
    ((ARControl) this.TextBox13).Top = 0.0f;
    ((ARControl) this.TextBox13).Width = 23f / 16f;
    this.ReportHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Label7,
      (ARControl) this.TextBox9,
      (ARControl) this.openingAR1,
      (ARControl) this.openingAR2,
      (ARControl) this.TextBox12
    });
    this.ReportFooter.Height = 0.1666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 1f / 16f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.Label7.Text = "Grand Total:";
    ((ARControl) this.Label7).Top = 0.0f;
    ((ARControl) this.Label7).Width = 101f / 16f;
    ((ARControl) this.TextBox9).DataField = "openingAR";
    ((ARControl) this.TextBox9).Height = 3f / 16f;
    ((ARControl) this.TextBox9).Left = 6.375f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox9.SummaryGroup = "GroupHeader1";
    this.TextBox9.SummaryRunning = (SummaryRunning) 2;
    this.TextBox9.SummaryType = (SummaryType) 1;
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 17f / 16f;
    ((ARControl) this.openingAR1).DataField = "ARReceived";
    ((ARControl) this.openingAR1).Height = 3f / 16f;
    ((ARControl) this.openingAR1).Left = 8.375f;
    ((ARControl) this.openingAR1).Name = "openingAR1";
    this.openingAR1.OutputFormat = resourceManager.GetString("openingAR1.OutputFormat");
    this.openingAR1.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.openingAR1.SummaryGroup = "GroupHeader1";
    this.openingAR1.SummaryRunning = (SummaryRunning) 2;
    this.openingAR1.SummaryType = (SummaryType) 1;
    this.openingAR1.Text = (string) null;
    ((ARControl) this.openingAR1).Top = 0.0f;
    ((ARControl) this.openingAR1).Width = 17f / 16f;
    ((ARControl) this.openingAR2).DataField = "closingBalance";
    ((ARControl) this.openingAR2).Height = 3f / 16f;
    ((ARControl) this.openingAR2).Left = 151f / 16f;
    ((ARControl) this.openingAR2).Name = "openingAR2";
    this.openingAR2.OutputFormat = resourceManager.GetString("openingAR2.OutputFormat");
    this.openingAR2.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.openingAR2.SummaryGroup = "GroupHeader1";
    this.openingAR2.SummaryRunning = (SummaryRunning) 2;
    this.openingAR2.SummaryType = (SummaryType) 1;
    this.openingAR2.Text = (string) null;
    ((ARControl) this.openingAR2).Top = 0.0f;
    ((ARControl) this.openingAR2).Width = 15f / 16f;
    ((ARControl) this.TextBox12).DataField = "Billings";
    ((ARControl) this.TextBox12).Height = 3f / 16f;
    ((ARControl) this.TextBox12).Left = 119f / 16f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "font-family: Tahoma; font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox12.SummaryGroup = "GroupHeader1";
    this.TextBox12.SummaryRunning = (SummaryRunning) 1;
    this.TextBox12.SummaryType = (SummaryType) 1;
    this.TextBox12.Text = " ";
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 15f / 16f;
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.Label,
      (ARControl) this.Label10,
      (ARControl) this.Label9,
      (ARControl) this.Label8,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label11,
      (ARControl) this.Label12
    });
    this.GroupHeader1.DataField = "InvMonth";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupHeader1.RepeatStyle = (RepeatStyle) 1;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 1f / 16f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label.Text = "Policy #";
    ((ARControl) this.Label).Top = 1f / 16f;
    ((ARControl) this.Label).Width = 21f / 16f;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 69f / 16f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label10.Text = "Due Date";
    ((ARControl) this.Label10).Top = 1f / 16f;
    ((ARControl) this.Label10).Width = 0.75f;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 93f / 16f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.Label9.Text = "Printed";
    ((ARControl) this.Label9).Top = 1f / 16f;
    ((ARControl) this.Label9).Width = 9f / 16f;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 81f / 16f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label8.Text = "Eff. Date";
    ((ARControl) this.Label8).Top = 1f / 16f;
    ((ARControl) this.Label8).Width = 0.75f;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 45f / 16f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label1.Text = "Invoice #";
    ((ARControl) this.Label1).Top = 1f / 16f;
    ((ARControl) this.Label1).Width = 0.625f;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 55f / 16f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label2.Text = "Post Date";
    ((ARControl) this.Label2).Top = 1f / 16f;
    ((ARControl) this.Label2).Width = 0.875f;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 6.375f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.Label3.Text = "Opening Balance";
    ((ARControl) this.Label3).Top = 1f / 16f;
    ((ARControl) this.Label3).Width = 17f / 16f;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 8.375f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.Label4.Text = "A/R Received";
    ((ARControl) this.Label4).Top = 1f / 16f;
    ((ARControl) this.Label4).Width = 17f / 16f;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 151f / 16f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.Label5.Text = "Closing Balance";
    ((ARControl) this.Label5).Top = 1f / 16f;
    ((ARControl) this.Label5).Width = 15f / 16f;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 119f / 16f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.Label11.Text = "Billings";
    ((ARControl) this.Label11).Top = 1f / 16f;
    ((ARControl) this.Label11).Width = 15f / 16f;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 1.375f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label12.Text = "Insured's Name";
    ((ARControl) this.Label12).Top = 1f / 16f;
    ((ARControl) this.Label12).Width = 23f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Label6,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8
    });
    this.GroupFooter1.Height = 5f / 32f;
    this.GroupFooter1.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 1f / 16f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.Label6.Text = "Sub-Total:";
    ((ARControl) this.Label6).Top = 0.0f;
    ((ARControl) this.Label6).Width = 101f / 16f;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).DataField = "Billings";
    ((ARControl) this.TextBox11).Height = 3f / 16f;
    ((ARControl) this.TextBox11).Left = 119f / 16f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "font-family: Tahoma; font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox11.SummaryGroup = "GroupHeader1";
    this.TextBox11.SummaryRunning = (SummaryRunning) 1;
    this.TextBox11.SummaryType = (SummaryType) 3;
    this.TextBox11.Text = " ";
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 15f / 16f;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "closingBalance";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 151f / 16f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox6.SummaryGroup = "GroupHeader1";
    this.TextBox6.SummaryRunning = (SummaryRunning) 1;
    this.TextBox6.SummaryType = (SummaryType) 3;
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 15f / 16f;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "ARReceived";
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 8.375f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox7.SummaryGroup = "GroupHeader1";
    this.TextBox7.SummaryRunning = (SummaryRunning) 1;
    this.TextBox7.SummaryType = (SummaryType) 3;
    this.TextBox7.Text = " ";
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 17f / 16f;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).DataField = "OpeningAR";
    ((ARControl) this.TextBox8).Height = 3f / 16f;
    ((ARControl) this.TextBox8).Left = 6.375f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox8.SummaryGroup = "GroupHeader1";
    this.TextBox8.SummaryRunning = (SummaryRunning) 1;
    this.TextBox8.SummaryType = (SummaryType) 3;
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 17f / 16f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.4f;
    this.PageSettings.Margins.Left = 0.2f;
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
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.EffectiveDateOfPolicy1).EndInit();
    ((ISupportInitialize) this.invoiceDate1).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.CheckBox1).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.openingAR1).EndInit();
    ((ISupportInitialize) this.openingAR2).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void rptReceivablesLedger_Detail_ReportStart(object sender, EventArgs e)
  {
  }

  private void Detail_Format(object sender, EventArgs e)
  {
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();
}
