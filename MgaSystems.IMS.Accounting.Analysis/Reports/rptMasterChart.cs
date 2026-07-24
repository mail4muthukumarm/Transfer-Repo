// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.Reports.rptMasterChart
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.IMS.Accounting.Analysis.GLMasterAccounts;
using System;
using System.ComponentModel;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.Reports;

public class rptMasterChart : SectionReport
{
  private dsGLAccountMaster _ds;
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private Label label1;
  private Label labelPrintDate;
  private TextBox textBox1;
  private TextBox textBox2;
  private TextBox textBox3;
  private TextBox textBox4;
  private TextBox textBox5;
  private Line line1;

  public rptMasterChart(dsGLAccountMaster ds)
  {
    this.InitializeComponent();
    this._ds = ds;
  }

  private void rptMasterChart_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) this._ds;
    this.DataMember = "MasterAccounts";
  }

  private void pageHeader_Format(object sender, EventArgs e)
  {
    this.labelPrintDate.Text = $"Printed On: {DateTime.Now.ToString()}";
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptMasterChart));
    this.pageHeader = new PageHeader();
    this.label1 = new Label();
    this.labelPrintDate = new Label();
    this.detail = new Detail();
    this.pageFooter = new PageFooter();
    this.textBox1 = new TextBox();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.line1 = new Line();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.labelPrintDate).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.pageHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.label1,
      (ARControl) this.labelPrintDate,
      (ARControl) this.line1
    });
    this.pageHeader.Height = 0.6063333f;
    ((Section) this.pageHeader).Name = "pageHeader";
    ((Section) this.pageHeader).Format += new EventHandler(this.pageHeader_Format);
    ((ARControl) this.label1).Height = 0.325f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 0.0f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "font-size: 14pt; text-align: center; text-justify: auto";
    this.label1.Text = "Master Chart Of Accounts";
    ((ARControl) this.label1).Top = 0.0f;
    ((ARControl) this.label1).Width = 8.292001f;
    ((ARControl) this.labelPrintDate).Height = 0.2f;
    this.labelPrintDate.HyperLink = (string) null;
    ((ARControl) this.labelPrintDate).Left = 0.0f;
    ((ARControl) this.labelPrintDate).Name = "labelPrintDate";
    this.labelPrintDate.Style = "text-align: center";
    this.labelPrintDate.Text = "";
    ((ARControl) this.labelPrintDate).Top = 0.325f;
    ((ARControl) this.labelPrintDate).Width = 8.292001f;
    this.detail.ColumnSpacing = 0.0f;
    ((Section) this.detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.textBox1,
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5
    });
    ((Section) this.detail).Height = 0.2f;
    ((Section) this.detail).Name = "detail";
    this.pageFooter.Height = 0.25f;
    ((Section) this.pageFooter).Name = "pageFooter";
    ((ARControl) this.textBox1).DataField = "GLAccountNumber";
    ((ARControl) this.textBox1).Height = 0.2f;
    ((ARControl) this.textBox1).Left = 0.07300001f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.Style = "font-size: 8pt";
    this.textBox1.Text = "textBox1";
    ((ARControl) this.textBox1).Top = 0.0f;
    ((ARControl) this.textBox1).Width = 1f;
    ((ARControl) this.textBox2).DataField = "GLAccountName";
    ((ARControl) this.textBox2).Height = 0.2f;
    ((ARControl) this.textBox2).Left = 1.073f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.Style = "font-size: 8pt";
    this.textBox2.Text = "textBox2";
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 3.29f;
    ((ARControl) this.textBox3).DataField = "GLAccountShortName";
    ((ARControl) this.textBox3).Height = 0.2f;
    ((ARControl) this.textBox3).Left = 4.363f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.Style = "font-size: 8pt";
    this.textBox3.Text = "textBox2";
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 1.459f;
    ((ARControl) this.textBox4).DataField = "AcctTypeDescription";
    ((ARControl) this.textBox4).Height = 0.2f;
    ((ARControl) this.textBox4).Left = 5.822001f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.Style = "font-size: 8pt";
    this.textBox4.Text = "textBox2";
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 1.251f;
    ((ARControl) this.textBox5).DataField = "AutomationSetting";
    ((ARControl) this.textBox5).Height = 0.2f;
    ((ARControl) this.textBox5).Left = 7.073f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.Style = "font-size: 8pt; text-align: left";
    this.textBox5.Text = "textBox2";
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 1.218999f;
    ((ARControl) this.line1).Height = 0.0f;
    ((ARControl) this.line1).Left = 0.0f;
    this.line1.LineWeight = 1f;
    ((ARControl) this.line1).Name = "line1";
    ((ARControl) this.line1).Top = 0.525f;
    ((ARControl) this.line1).Width = 8.354f;
    this.line1.X1 = 0.0f;
    this.line1.X2 = 8.354f;
    this.line1.Y1 = 0.525f;
    this.line1.Y2 = 0.525f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 8.292001f;
    this.Sections.Add((Section) this.pageHeader);
    this.Sections.Add((Section) this.detail);
    this.Sections.Add((Section) this.pageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    this.ReportStart += new EventHandler(this.rptMasterChart_ReportStart);
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.labelPrintDate).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
