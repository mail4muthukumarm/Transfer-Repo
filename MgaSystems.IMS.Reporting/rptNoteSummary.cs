// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptNoteSummary
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.IMS.Reporting.ReportControls;
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
public class rptNoteSummary : MGAReport, IReport
{
  private DataTable _dt;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Detail1")]
  private virtual Detail Detail1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptNoteSummary));
    this.Detail1 = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.ReportHeader1 = new ReportHeader();
    this.Label1 = new Label();
    this.ReportFooter1 = new ReportFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail1.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 0.4f;
    this.Detail1.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.TextBox1).DataField = "Header";
    ((ARControl) this.TextBox1).Height = 0.2f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-weight: bold; ddo-char-set: 1";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 7.983f;
    ((ARControl) this.TextBox2).DataField = "Body";
    ((ARControl) this.TextBox2).Height = 0.2f;
    ((ARControl) this.TextBox2).Left = 0.0f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.2f;
    ((ARControl) this.TextBox2).Width = 7.983f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.Label1
    });
    this.ReportHeader1.Height = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1).Name = "ReportHeader1";
    ((ARControl) this.Label1).Height = 0.344f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 14pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
    this.Label1.Text = "Note Summary Report";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 7.983f;
    this.ReportFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1).Name = "ReportFooter1";
    this.GroupHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupFooter1.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.983001f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("ReportHeader1")]
  private virtual ReportHeader ReportHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter1")]
  private virtual ReportFooter ReportFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptNoteSummary() => this.ReportStart += new EventHandler(this.rptNoteSummary_ReportStart);

  public rptNoteSummary(DataTable dt)
  {
    this.ReportStart += new EventHandler(this.rptNoteSummary_ReportStart);
    this.InitializeComponent();
    this._dt = dt;
  }

  private void rptNoteSummary_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) this._dt;
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls => new BaseReportControl[0];
}
