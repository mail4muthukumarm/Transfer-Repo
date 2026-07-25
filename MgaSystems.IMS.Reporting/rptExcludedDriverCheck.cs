// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptExcludedDriverCheck
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
[ClearanceContextMenu("Excluded Driver Check", "Reports", ClearanceContextMenuLevelEnum.Quote)]
public class rptExcludedDriverCheck : MGAReport, IReport
{
  private readonly Guid _QuoteGuid;
  private DataTable dt;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptExcludedDriverCheck));
    this.PageHeader = new PageHeader();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label = new Label();
    this.TextBox1 = new TextBox();
    this.Label6 = new Label();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.Detail = new Detail();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.PageHeader).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label,
      (ARControl) this.TextBox1,
      (ARControl) this.Label6,
      (ARControl) this.Label8,
      (ARControl) this.Label7
    });
    this.PageHeader.Height = 0.9265f;
    ((Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Height = 0.2705f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 4.489f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label1.Text = "Policy #";
    ((ARControl) this.Label1).Top = 0.6350001f;
    ((ARControl) this.Label1).Width = 1.229f;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Height = 0.2705f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 3.905001f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 9pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.Label2.Text = "Control #";
    ((ARControl) this.Label2).Top = 0.6350001f;
    ((ARControl) this.Label2).Width = 0.58f;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Height = 0.2705f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 1.772f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label3.Text = "License #";
    ((ARControl) this.Label3).Top = 0.6350001f;
    ((ARControl) this.Label3).Width = 0.875f;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Height = 0.2705f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 3.215016f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label4.Text = "DOB";
    ((ARControl) this.Label4).Top = 0.6350001f;
    ((ARControl) this.Label4).Width = 0.6879847f;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Height = 0.2705f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 0.0f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label5.Text = "First Name";
    ((ARControl) this.Label5).Top = 0.6350001f;
    ((ARControl) this.Label5).Width = 0.886f;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.0f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 12pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.Label.Text = "Excluded Driver Check";
    ((ARControl) this.Label).Top = 0.0f;
    ((ARControl) this.Label).Width = 6.448f;
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 9.75pt; font-weight: normal; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.25f;
    ((ARControl) this.TextBox1).Width = 6.448f;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Height = 0.2705f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 5.722f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label6.Text = "Driver ID";
    ((ARControl) this.Label6).Top = 0.6350001f;
    ((ARControl) this.Label6).Width = 0.6870003f;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Height = 0.2705f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 0.886f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label8.Text = "Last Name";
    ((ARControl) this.Label8).Top = 0.6350001f;
    ((ARControl) this.Label8).Width = 0.886f;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Height = 0.2705f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 2.642f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 9pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.Label7.Text = "State ID";
    ((ARControl) this.Label7).Top = 0.6350001f;
    ((ARControl) this.Label7).Width = 0.5729997f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox2,
      (ARControl) this.textBox3,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9
    });
    ((Section) this.Detail).Height = 0.1971667f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox4).DataField = "LicenseNumber";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 1.772f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 0.875f;
    ((ARControl) this.TextBox5).DataField = "DOB";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 3.215016f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "font-size: 8.25pt; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 0.6879847f;
    ((ARControl) this.TextBox6).DataField = "FirstName";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 0.0f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 0.886f;
    ((ARControl) this.TextBox2).DataField = "controlno";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 3.905001f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "font-size: 8.25pt; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.58f;
    ((ARControl) this.textBox3).DataField = "PolicyNumber";
    ((ARControl) this.textBox3).Height = 3f / 16f;
    ((ARControl) this.textBox3).Left = 4.489f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox3.Text = (string) null;
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 1.229f;
    ((ARControl) this.TextBox7).DataField = "LastName";
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 0.886f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 0.886f;
    ((ARControl) this.TextBox8).DataField = "driverID";
    ((ARControl) this.TextBox8).Height = 3f / 16f;
    ((ARControl) this.TextBox8).Left = 5.722f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox8.Text = (string) null;
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 0.6870003f;
    ((ARControl) this.TextBox9).DataField = "StateID";
    ((ARControl) this.TextBox9).Height = 3f / 16f;
    ((ARControl) this.TextBox9).Left = 2.642f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 0.5729997f;
    this.PageFooter.Height = 0.0f;
    ((Section) this.PageFooter).Name = "PageFooter";
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 6.479167f;
    this.Sections.Add((Section) this.PageHeader);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.PageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label")]
  private virtual Label Label { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  private virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox3")]
  private virtual TextBox textBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  private virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  private virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox9")]
  private virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptExcludedDriverCheck()
  {
    this.ReportStart += new EventHandler(this.rptExcludedDriverCheck_ReportStart);
    this.dt = new DataTable();
    this.InitializeComponent();
  }

  public rptExcludedDriverCheck(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptExcludedDriverCheck_ReportStart);
    this.dt = new DataTable();
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid;
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls => (BaseReportControl[]) null;

  private void rptExcludedDriverCheck_ReportStart(object sender, EventArgs e)
  {
    this.dt = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "GetExcludedDriverForPolicy", 0, (CommandArgumentType) 0, new object[2]
    {
      (object) "@QuoteGuid",
      Interaction.IIf(!this._QuoteGuid.Equals(Guid.Empty), (object) this._QuoteGuid, (object) DBNull.Value)
    });
    this.DataSource = (object) this.dt;
    Quote quote = new Quote(this._QuoteGuid);
    this.TextBox1.Text = $"Insured: {quote.InsuredPolicyName};";
    if (Information.IsNothing((object) quote.PolicyNumber) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(quote.PolicyNumber, "", false) == 0)
      return;
    this.TextBox1.Text = $"{this.TextBox1.Text} Policy No: {quote.PolicyNumber}";
  }

  public override void ExportToExcel(string SaveFileTo) => ExcelExport.ToExcel(this.dt, SaveFileTo);
}
