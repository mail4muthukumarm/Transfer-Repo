// Decompiled with JetBrains decompiler
// Type: APreport
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.IMS.Reporting;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Resources;

#nullable disable
public class APreport : MGAReport
{
  private DataView _dv;
  private Detail detail;
  private Container components;
  private TextBox textBox18;
  private PageHeader pageHeader1;
  private PageFooter pageFooter1;
  private Label lblTitle;
  internal Label Label66;
  internal Label label1;
  internal Label label2;
  internal Label label3;
  internal Label label4;
  internal Label label5;
  internal Label label6;
  internal Label label7;
  internal Label label8;
  internal Label label9;
  internal Label label10;
  internal Label label11;
  internal Label label12;
  internal Label label13;
  private TextBox textBox1;
  private TextBox textBox2;
  private TextBox textBox3;
  private TextBox textBox4;
  private TextBox textBox5;
  private TextBox textBox6;
  private TextBox textBox7;
  private TextBox textBox8;
  private TextBox textBox9;
  private TextBox textBox10;
  private TextBox textBox11;
  private TextBox textBox12;
  private TextBox textBox13;

  public APreport() => this.InitializeComponent();

  public APreport(DataView dv)
  {
    this.InitializeComponent();
    this._dv = dv;
  }

  private void APreport_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) this._dv;
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dv, SaveFileTo);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (APreport));
    this.detail = new Detail();
    this.textBox18 = new TextBox();
    this.textBox1 = new TextBox();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.textBox6 = new TextBox();
    this.textBox7 = new TextBox();
    this.textBox8 = new TextBox();
    this.textBox9 = new TextBox();
    this.textBox10 = new TextBox();
    this.textBox11 = new TextBox();
    this.textBox12 = new TextBox();
    this.textBox13 = new TextBox();
    this.pageHeader1 = new PageHeader();
    this.lblTitle = new Label();
    this.label4 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label9 = new Label();
    this.label10 = new Label();
    this.label11 = new Label();
    this.label12 = new Label();
    this.label13 = new Label();
    this.label1 = new Label();
    this.label3 = new Label();
    this.label5 = new Label();
    this.label2 = new Label();
    this.Label66 = new Label();
    this.pageFooter1 = new PageFooter();
    ((ISupportInitialize) this.textBox18).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((ISupportInitialize) this.textBox10).BeginInit();
    ((ISupportInitialize) this.textBox11).BeginInit();
    ((ISupportInitialize) this.textBox12).BeginInit();
    ((ISupportInitialize) this.textBox13).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.label4).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.label9).BeginInit();
    ((ISupportInitialize) this.label10).BeginInit();
    ((ISupportInitialize) this.label11).BeginInit();
    ((ISupportInitialize) this.label12).BeginInit();
    ((ISupportInitialize) this.label13).BeginInit();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.label3).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.Label66).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Controls.AddRange(new ARControl[14]
    {
      (ARControl) this.textBox18,
      (ARControl) this.textBox1,
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5,
      (ARControl) this.textBox6,
      (ARControl) this.textBox7,
      (ARControl) this.textBox8,
      (ARControl) this.textBox9,
      (ARControl) this.textBox10,
      (ARControl) this.textBox11,
      (ARControl) this.textBox12,
      (ARControl) this.textBox13
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 0.2083333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((ARControl) this.textBox18).DataField = "PolicyNumber";
    ((ARControl) this.textBox18).Height = 3f / 16f;
    ((ARControl) this.textBox18).Left = 1f / 16f;
    ((ARControl) this.textBox18).Name = "textBox18";
    this.textBox18.Style = "font-size: 8.25pt; vertical-align: top; white-space: inherit";
    this.textBox18.Text = (string) null;
    ((ARControl) this.textBox18).Top = 0.0f;
    ((ARControl) this.textBox18).Width = 15f / 16f;
    ((ARControl) this.textBox1).DataField = "Payee";
    ((ARControl) this.textBox1).Height = 3f / 16f;
    ((ARControl) this.textBox1).Left = 17f / 16f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.Style = "font-size: 8.25pt; vertical-align: top; white-space: inherit";
    this.textBox1.Text = (string) null;
    ((ARControl) this.textBox1).Top = 0.0f;
    ((ARControl) this.textBox1).Width = 1.375f;
    ((ARControl) this.textBox2).DataField = "OfficeInvoiceNum";
    ((ARControl) this.textBox2).Height = 3f / 16f;
    ((ARControl) this.textBox2).Left = 2.5f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.Style = "font-size: 8.25pt; vertical-align: top; white-space: inherit";
    this.textBox2.Text = (string) null;
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 9f / 16f;
    ((ARControl) this.textBox3).DataField = "InvoiceDate";
    ((ARControl) this.textBox3).Height = 3f / 16f;
    ((ARControl) this.textBox3).Left = 3.125f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.OutputFormat = resourceManager.GetString("textBox3.OutputFormat");
    this.textBox3.Style = "font-size: 8.25pt; text-align: center; vertical-align: top; white-space: inherit";
    this.textBox3.Text = (string) null;
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 0.75f;
    ((ARControl) this.textBox4).DataField = "InsuredPolicyName";
    ((ARControl) this.textBox4).Height = 3f / 16f;
    ((ARControl) this.textBox4).Left = 63f / 16f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.Style = "font-size: 8.25pt; vertical-align: top; white-space: inherit";
    this.textBox4.Text = (string) null;
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 1.375f;
    ((ARControl) this.textBox5).DataField = "ChargeName";
    ((ARControl) this.textBox5).Height = 3f / 16f;
    ((ARControl) this.textBox5).Left = 5.375f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.Style = "font-size: 8.25pt; vertical-align: top; white-space: inherit";
    this.textBox5.Text = (string) null;
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 13f / 16f;
    ((ARControl) this.textBox6).DataField = "EffectiveDate";
    ((ARControl) this.textBox6).Height = 3f / 16f;
    ((ARControl) this.textBox6).Left = 6.25f;
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.OutputFormat = resourceManager.GetString("textBox6.OutputFormat");
    this.textBox6.Style = "font-size: 8.25pt; text-align: center; vertical-align: top; white-space: inherit";
    this.textBox6.Text = (string) null;
    ((ARControl) this.textBox6).Top = 0.0f;
    ((ARControl) this.textBox6).Width = 11f / 16f;
    ((ARControl) this.textBox7).DataField = "ExpirationDate";
    ((ARControl) this.textBox7).Height = 3f / 16f;
    ((ARControl) this.textBox7).Left = 7f;
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.OutputFormat = resourceManager.GetString("textBox7.OutputFormat");
    this.textBox7.Style = "font-size: 8.25pt; vertical-align: top; white-space: inherit";
    this.textBox7.Text = (string) null;
    ((ARControl) this.textBox7).Top = 0.0f;
    ((ARControl) this.textBox7).Width = 0.75f;
    ((ARControl) this.textBox8).DataField = "APApplied";
    ((ARControl) this.textBox8).Height = 3f / 16f;
    ((ARControl) this.textBox8).Left = 12.5f;
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.OutputFormat = resourceManager.GetString("textBox8.OutputFormat");
    this.textBox8.Style = "font-size: 8.25pt; text-align: right; vertical-align: top; white-space: inherit";
    this.textBox8.Text = (string) null;
    ((ARControl) this.textBox8).Top = 0.0f;
    ((ARControl) this.textBox8).Width = 0.875f;
    ((ARControl) this.textBox9).DataField = "Amt Rcvd";
    ((ARControl) this.textBox9).Height = 3f / 16f;
    ((ARControl) this.textBox9).Left = 8.75f;
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.OutputFormat = resourceManager.GetString("textBox9.OutputFormat");
    this.textBox9.Style = "font-size: 8.25pt; text-align: right; vertical-align: top; white-space: inherit";
    this.textBox9.Text = (string) null;
    ((ARControl) this.textBox9).Top = 0.0f;
    ((ARControl) this.textBox9).Width = 0.875f;
    ((ARControl) this.textBox10).DataField = "AmtPtd";
    ((ARControl) this.textBox10).Height = 3f / 16f;
    ((ARControl) this.textBox10).Left = 155f / 16f;
    ((ARControl) this.textBox10).Name = "textBox10";
    this.textBox10.OutputFormat = resourceManager.GetString("textBox10.OutputFormat");
    this.textBox10.Style = "font-size: 8.25pt; text-align: right; vertical-align: top; white-space: inherit";
    this.textBox10.Text = (string) null;
    ((ARControl) this.textBox10).Top = 0.0f;
    ((ARControl) this.textBox10).Width = 0.875f;
    ((ARControl) this.textBox11).DataField = "Net Payable";
    ((ARControl) this.textBox11).Height = 3f / 16f;
    ((ARControl) this.textBox11).Left = 10.625f;
    ((ARControl) this.textBox11).Name = "textBox11";
    this.textBox11.OutputFormat = resourceManager.GetString("textBox11.OutputFormat");
    this.textBox11.Style = "font-size: 8.25pt; text-align: right; vertical-align: top; white-space: inherit";
    this.textBox11.Text = (string) null;
    ((ARControl) this.textBox11).Top = 0.0f;
    ((ARControl) this.textBox11).Width = 0.875f;
    ((ARControl) this.textBox12).DataField = "PropAmt";
    ((ARControl) this.textBox12).Height = 3f / 16f;
    ((ARControl) this.textBox12).Left = 185f / 16f;
    ((ARControl) this.textBox12).Name = "textBox12";
    this.textBox12.OutputFormat = resourceManager.GetString("textBox12.OutputFormat");
    this.textBox12.Style = "font-size: 8.25pt; text-align: right; vertical-align: top; white-space: inherit";
    this.textBox12.Text = (string) null;
    ((ARControl) this.textBox12).Top = 0.0f;
    ((ARControl) this.textBox12).Width = 0.875f;
    ((ARControl) this.textBox13).DataField = "Gross Payable";
    ((ARControl) this.textBox13).Height = 3f / 16f;
    ((ARControl) this.textBox13).Left = 125f / 16f;
    ((ARControl) this.textBox13).Name = "textBox13";
    this.textBox13.OutputFormat = resourceManager.GetString("textBox13.OutputFormat");
    this.textBox13.Style = "font-size: 8.25pt; text-align: right; vertical-align: top; white-space: inherit";
    this.textBox13.Text = (string) null;
    ((ARControl) this.textBox13).Top = 0.0f;
    ((ARControl) this.textBox13).Width = 0.875f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader1).Controls.AddRange(new ARControl[15]
    {
      (ARControl) this.lblTitle,
      (ARControl) this.label4,
      (ARControl) this.label6,
      (ARControl) this.label7,
      (ARControl) this.label8,
      (ARControl) this.label9,
      (ARControl) this.label10,
      (ARControl) this.label11,
      (ARControl) this.label12,
      (ARControl) this.label13,
      (ARControl) this.label1,
      (ARControl) this.label3,
      (ARControl) this.label5,
      (ARControl) this.label2,
      (ARControl) this.Label66
    });
    this.pageHeader1.Height = 0.5833333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader1).Name = "pageHeader1";
    ((ARControl) this.lblTitle).Height = 0.25f;
    this.lblTitle.HyperLink = (string) null;
    ((ARControl) this.lblTitle).Left = 0.25f;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    this.lblTitle.Style = "font-size: 14pt; text-align: center";
    this.lblTitle.Text = "Accounts Payable Report";
    ((ARControl) this.lblTitle).Top = 1f / 16f;
    ((ARControl) this.lblTitle).Width = 209f / 16f;
    ((ARControl) this.label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label4).Height = 3f / 16f;
    this.label4.HyperLink = (string) null;
    ((ARControl) this.label4).Left = 63f / 16f;
    ((ARControl) this.label4).Name = "label4";
    this.label4.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.label4.Text = "Insured";
    ((ARControl) this.label4).Top = 0.375f;
    ((ARControl) this.label4).Width = 1.375f;
    ((ARControl) this.label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label6).Height = 3f / 16f;
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Left = 6.25f;
    ((ARControl) this.label6).Name = "label6";
    this.label6.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.label6.Text = "Effect. Date";
    ((ARControl) this.label6).Top = 0.375f;
    ((ARControl) this.label6).Width = 11f / 16f;
    ((ARControl) this.label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label7).Height = 3f / 16f;
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Left = 7f;
    ((ARControl) this.label7).Name = "label7";
    this.label7.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.label7.Text = "Expire. Date";
    ((ARControl) this.label7).Top = 0.375f;
    ((ARControl) this.label7).Width = 0.75f;
    ((ARControl) this.label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label8).Height = 3f / 16f;
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Left = 125f / 16f;
    ((ARControl) this.label8).Name = "label8";
    this.label8.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.label8.Text = "Gross Payable";
    ((ARControl) this.label8).Top = 0.375f;
    ((ARControl) this.label8).Width = 0.875f;
    ((ARControl) this.label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label9).Height = 3f / 16f;
    this.label9.HyperLink = (string) null;
    ((ARControl) this.label9).Left = 8.75f;
    ((ARControl) this.label9).Name = "label9";
    this.label9.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.label9.Text = "Amt. Rcvd";
    ((ARControl) this.label9).Top = 0.375f;
    ((ARControl) this.label9).Width = 0.875f;
    ((ARControl) this.label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label10).Height = 3f / 16f;
    this.label10.HyperLink = (string) null;
    ((ARControl) this.label10).Left = 155f / 16f;
    ((ARControl) this.label10).Name = "label10";
    this.label10.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.label10.Text = "Amt. PTD";
    ((ARControl) this.label10).Top = 0.375f;
    ((ARControl) this.label10).Width = 0.875f;
    ((ARControl) this.label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label11).Height = 3f / 16f;
    this.label11.HyperLink = (string) null;
    ((ARControl) this.label11).Left = 10.625f;
    ((ARControl) this.label11).Name = "label11";
    this.label11.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.label11.Text = "Net Payable";
    ((ARControl) this.label11).Top = 0.375f;
    ((ARControl) this.label11).Width = 0.875f;
    ((ARControl) this.label12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label12).Height = 3f / 16f;
    this.label12.HyperLink = (string) null;
    ((ARControl) this.label12).Left = 185f / 16f;
    ((ARControl) this.label12).Name = "label12";
    this.label12.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.label12.Text = "Prop Amt. Due";
    ((ARControl) this.label12).Top = 0.375f;
    ((ARControl) this.label12).Width = 0.875f;
    ((ARControl) this.label13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label13).Height = 3f / 16f;
    this.label13.HyperLink = (string) null;
    ((ARControl) this.label13).Left = 12.5f;
    ((ARControl) this.label13).Name = "label13";
    this.label13.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.label13.Text = "Ap Applied";
    ((ARControl) this.label13).Top = 0.375f;
    ((ARControl) this.label13).Width = 0.875f;
    ((ARControl) this.label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label1).Height = 3f / 16f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 17f / 16f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.label1.Text = "Payee";
    ((ARControl) this.label1).Top = 0.375f;
    ((ARControl) this.label1).Width = 1.375f;
    ((ARControl) this.label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label3).Height = 3f / 16f;
    this.label3.HyperLink = (string) null;
    ((ARControl) this.label3).Left = 3.125f;
    ((ARControl) this.label3).Name = "label3";
    this.label3.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.label3.Text = "Invoice Date";
    ((ARControl) this.label3).Top = 0.375f;
    ((ARControl) this.label3).Width = 0.75f;
    ((ARControl) this.label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label5).Height = 3f / 16f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 5.375f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.label5.Text = "Description";
    ((ARControl) this.label5).Top = 0.375f;
    ((ARControl) this.label5).Width = 13f / 16f;
    ((ARControl) this.label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label2).Height = 3f / 16f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 2.5f;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.label2.Text = "Invoice #";
    ((ARControl) this.label2).Top = 0.375f;
    ((ARControl) this.label2).Width = 9f / 16f;
    ((ARControl) this.Label66).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label66).Height = 3f / 16f;
    this.Label66.HyperLink = (string) null;
    ((ARControl) this.Label66).Left = 1f / 16f;
    ((ARControl) this.Label66).Name = "Label66";
    this.Label66.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.Label66.Text = "Policy #";
    ((ARControl) this.Label66).Top = 0.375f;
    ((ARControl) this.Label66).Width = 15f / 16f;
    this.pageFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter1).Name = "pageFooter1";
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 14f;
    this.PageSettings.PaperKind = PaperKind.Legal;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 13.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    this.ReportStart += new EventHandler(this.APreport_ReportStart);
    ((ISupportInitialize) this.textBox18).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
    ((ISupportInitialize) this.textBox10).EndInit();
    ((ISupportInitialize) this.textBox11).EndInit();
    ((ISupportInitialize) this.textBox12).EndInit();
    ((ISupportInitialize) this.textBox13).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.label4).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.label9).EndInit();
    ((ISupportInitialize) this.label10).EndInit();
    ((ISupportInitialize) this.label11).EndInit();
    ((ISupportInitialize) this.label12).EndInit();
    ((ISupportInitialize) this.label13).EndInit();
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.label3).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.Label66).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
