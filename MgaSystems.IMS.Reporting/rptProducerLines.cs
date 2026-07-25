// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptProducerLines
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
[SecureReportResource("{EE3E68DF-8871-4cbf-98EA-4D8D939A75C6}", "Producer Lines report", "Producer Lines report", "General")]
public class rptProducerLines : MGAExcelReport, IReport
{
  private DataSet _ds;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptProducerLines));
    this.PageHeader1 = new PageHeader();
    this.Label1 = new Label();
    this.Detail1 = new Detail();
    this.PageFooter1 = new PageFooter();
    this.ReportInfo1 = new ReportInfo();
    this.ReportHeader1 = new ReportHeader();
    this.ReportFooter1 = new ReportFooter();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.ReportInfo1).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.Label1
    });
    this.PageHeader1.Height = 17f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 0.4895833f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 1.385417f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; text-align: center; font-size: 26.25pt; ";
    this.Label1.Text = "EXPORT TO EXCEL";
    ((ARControl) this.Label1).Top = 0.01041667f;
    ((ARControl) this.Label1).Width = 8.75f;
    this.Detail1.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 0.01041667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.ReportInfo1
    });
    this.PageFooter1.Height = 0.2604167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
    ((ARControl) this.ReportInfo1).Border.BottomColor = Color.Black;
    ((ARControl) this.ReportInfo1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.ReportInfo1).Border.LeftColor = Color.Black;
    ((ARControl) this.ReportInfo1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.ReportInfo1).Border.RightColor = Color.Black;
    ((ARControl) this.ReportInfo1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.ReportInfo1).Border.TopColor = Color.Black;
    ((ARControl) this.ReportInfo1).Border.TopStyle = (BorderLineStyle) 0;
    this.ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
    ((ARControl) this.ReportInfo1).Height = 3f / 16f;
    ((ARControl) this.ReportInfo1).Left = 173f / 16f;
    ((ARControl) this.ReportInfo1).Name = "ReportInfo1";
    this.ReportInfo1.Style = "text-align: right; ";
    ((ARControl) this.ReportInfo1).Top = 1f / 16f;
    ((ARControl) this.ReportInfo1).Width = 2.625f;
    this.ReportHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1).Name = "ReportHeader1";
    this.ReportFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1).Name = "ReportFooter1";
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
    this.PrintWidth = 13.54167f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.ReportInfo1).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("PageHeader1")]
  private virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail1")]
  private virtual Detail Detail1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportInfo1")]
  internal virtual ReportInfo ReportInfo1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader1")]
  internal virtual ReportHeader ReportHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter1")]
  internal virtual ReportFooter ReportFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptProducerLines()
  {
    this.ReportStart += new EventHandler(this.rptProducerLines_ReportStart);
    this.InitializeComponent();
  }

  private void rptProducerLines_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this._ds = new DataSet();
    using (DbConnection dbConnection = DefaultDatabase.CreateDbConnection())
    {
      using (DbCommand command = DefaultDatabase.CreateCommand(nameof (rptProducerLines), dbConnection))
      {
        using (DbDataAdapter dataAdapter = DefaultDatabase.CreateDataAdapter(command))
        {
          command.CommandType = CommandType.StoredProcedure;
          DefaultDatabase.DataAdapterFill(dataAdapter, this._ds);
        }
      }
    }
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls => (BaseReportControl[]) null;

  public override bool IsThreaded => true;

  protected override void DoExport(string SaveFileTo) => ExcelExport.ToExcel(this._ds, SaveFileTo);

  public override bool HasRecords => this._ds.Tables[0].Rows.Count > 1;
}
