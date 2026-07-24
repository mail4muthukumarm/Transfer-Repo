// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reporting.Reports.Documents.rptBankReconciliation_Checks
// Assembly: MGASystems.IMS.Accounting.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 725B9A25-3FF1-4B2E-9ECA-9E17C2CAE78A
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Accounting.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Reporting.Reports.Documents;

public class rptBankReconciliation_Checks : SectionReport
{
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private Label Label7;
  private CheckBox CheckBox;
  private TextBox TextBox2;
  private TextBox TextBox1;
  private TextBox TextBox;
  private TextBox textBox4;
  private GroupHeader groupHeader1;
  private Label Label;
  private Label Label1;
  private Label Label2;
  private Label Label4;
  private Label label5;
  private GroupFooter groupFooter1;
  private Label label8;
  private TextBox textBox6;

  public rptBankReconciliation_Checks() => this.InitializeComponent();

  public rptBankReconciliation_Checks(DataTable dt)
  {
    this.InitializeComponent();
    this.DataSource = (object) dt;
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptBankReconciliation_Checks));
    this.pageHeader = new PageHeader();
    this.Label7 = new Label();
    this.detail = new Detail();
    this.CheckBox = new CheckBox();
    this.TextBox2 = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox = new TextBox();
    this.textBox4 = new TextBox();
    this.pageFooter = new PageFooter();
    this.groupHeader1 = new GroupHeader();
    this.Label = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label4 = new Label();
    this.label5 = new Label();
    this.groupFooter1 = new GroupFooter();
    this.label8 = new Label();
    this.textBox6 = new TextBox();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.CheckBox).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.pageHeader).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.Label7
    });
    this.pageHeader.Height = 0.2086667f;
    ((Section) this.pageHeader).Name = "pageHeader";
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 0.0f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 11.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label7.Text = "Outstanding Check Details";
    ((ARControl) this.Label7).Top = 0.0f;
    ((ARControl) this.Label7).Width = 4.229f;
    ((Section) this.detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.CheckBox,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox,
      (ARControl) this.textBox4
    });
    ((Section) this.detail).Height = 0.1666666f;
    ((Section) this.detail).Name = "detail";
    this.CheckBox.CheckAlignment = ContentAlignment.MiddleCenter;
    ((ARControl) this.CheckBox).DataField = "IsVoided";
    ((ARControl) this.CheckBox).Height = 0.125f;
    ((ARControl) this.CheckBox).Left = 6.823f;
    ((ARControl) this.CheckBox).Name = "CheckBox";
    this.CheckBox.Style = "ddo-char-set: 0";
    this.CheckBox.Text = "";
    ((ARControl) this.CheckBox).Top = 0.026f;
    ((ARControl) this.CheckBox).Width = 3f / 16f;
    ((ARControl) this.TextBox2).DataField = "Payee";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 2.051166f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 9pt; ddo-char-set: 0";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.02083331f;
    ((ARControl) this.TextBox2).Width = 2.5f;
    ((ARControl) this.TextBox1).DataField = "TransDate";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 1.051167f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Style = "font-size: 9pt; ddo-char-set: 0";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.02083331f;
    ((ARControl) this.TextBox1).Width = 1f;
    ((ARControl) this.TextBox).DataField = "Marker";
    ((ARControl) this.TextBox).Height = 0.125f;
    ((ARControl) this.TextBox).Left = 0.02916646f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-size: 9pt; ddo-char-set: 0";
    this.TextBox.Text = (string) null;
    ((ARControl) this.TextBox).Top = 0.02083331f;
    ((ARControl) this.TextBox).Width = 1.021f;
    ((ARControl) this.textBox4).DataField = "Amount";
    ((ARControl) this.textBox4).Height = 0.125f;
    ((ARControl) this.textBox4).Left = 4.551f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.OutputFormat = resourceManager.GetString("textBox4.OutputFormat");
    this.textBox4.Style = "font-size: 9pt; text-align: right; ddo-char-set: 0";
    this.textBox4.Text = (string) null;
    ((ARControl) this.textBox4).Top = 0.02083331f;
    ((ARControl) this.textBox4).Width = 1.868165f;
    this.pageFooter.Height = 0.0f;
    ((Section) this.pageFooter).Name = "pageFooter";
    ((Section) this.groupHeader1).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Label,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label4,
      (ARControl) this.label5
    });
    this.groupHeader1.Height = 0.2605f;
    ((Section) this.groupHeader1).Name = "groupHeader1";
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.03f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 9pt; vertical-align: middle; ddo-char-set: 0";
    this.Label.Text = "Check Number";
    ((ARControl) this.Label).Top = 0.0f;
    ((ARControl) this.Label).Width = 1.021f;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 1.051f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 9pt; vertical-align: middle; ddo-char-set: 0";
    this.Label1.Text = "Check Date";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 1f;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 2.021f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 9pt; vertical-align: middle; ddo-char-set: 0";
    this.Label2.Text = "Payee";
    ((ARControl) this.Label2).Top = 0.0f;
    ((ARControl) this.Label2).Width = 2.5f;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 6.36f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 9pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.Label4.Text = "Voided";
    ((ARControl) this.Label4).Top = 0.0f;
    ((ARControl) this.Label4).Width = 0.625f;
    ((ARControl) this.label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label5).Height = 3f / 16f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 4.521f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "font-size: 9pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.label5.Text = "Amount";
    ((ARControl) this.label5).Top = 0.0f;
    ((ARControl) this.label5).Width = 1.839f;
    ((Section) this.groupFooter1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.label8,
      (ARControl) this.textBox6
    });
    this.groupFooter1.Height = 0.3645833f;
    ((Section) this.groupFooter1).Name = "groupFooter1";
    ((ARControl) this.label8).Height = 0.2495f;
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Left = 3.771f;
    ((ARControl) this.label8).Name = "label8";
    this.label8.Style = "font-size: 9pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.label8.Text = "Total Checks:";
    ((ARControl) this.label8).Top = 0.115f;
    ((ARControl) this.label8).Width = 1.625f;
    ((ARControl) this.textBox6).DataField = "Amount";
    ((ARControl) this.textBox6).Height = 0.2495f;
    ((ARControl) this.textBox6).Left = 5.396f;
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.OutputFormat = resourceManager.GetString("textBox6.OutputFormat");
    this.textBox6.Style = "font-size: 9pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.textBox6.SummaryRunning = (SummaryRunning) 2;
    this.textBox6.SummaryType = (SummaryType) 1;
    this.textBox6.Text = (string) null;
    ((ARControl) this.textBox6).Top = 0.115f;
    ((ARControl) this.textBox6).Width = 1.625f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.895833f;
    this.Sections.Add((Section) this.pageHeader);
    this.Sections.Add((Section) this.groupHeader1);
    this.Sections.Add((Section) this.detail);
    this.Sections.Add((Section) this.groupFooter1);
    this.Sections.Add((Section) this.pageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.CheckBox).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
