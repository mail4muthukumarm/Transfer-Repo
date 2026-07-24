// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Reports.VoidedChecksReport
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Claims.Reports;

[SecureReportResource("{D3CAD7FD-DE8F-42F1-92FB-420F68ADA2CE}", "Claims Voided Checks Report", "Claims Voided Checks Report", "Claims")]
public class VoidedChecksReport : MGAExcelReport, IReport
{
  private DateTime _postDateFrom;
  private DateTime _postDateTo;
  private DataSet _ds;
  private Detail detail;

  public VoidedChecksReport() => this.InitializeComponent();

  public VoidedChecksReport(DateTime PostDateFrom, DateTime PostDateTo)
  {
    this.InitializeComponent();
    this._postDateFrom = PostDateFrom;
    this._postDateTo = PostDateTo;
  }

  Type IReport.getLaunchForm => (Type) null;

  BaseReportControl[] IReport.getReportControls
  {
    get
    {
      return new BaseReportControl[1]
      {
        (BaseReportControl) new DateRangePicker("Post Date", false)
      };
    }
  }

  private void VoidedChecksReport_ReportStart(object sender, EventArgs e)
  {
    ((MGAReport) this).BouncingProgress(true);
    ArrayList arrayList = new ArrayList();
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@PostDateFrom",
      (object) this._postDateFrom
    });
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@PostDateTo",
      (object) this._postDateTo
    });
    this._ds = DefaultDatabase.ExecuteDataSet(CommandType.StoredProcedure, "spClaims_rptVoidedChecks", 0, (CommandArgumentType) 0, arrayList.ToArray());
    ((SectionReport) this).DataSource = (object) this._ds.Tables[0];
  }

  public virtual bool IsThreaded => true;

  protected virtual void DoExport(string saveFileTo)
  {
    ExcelExport.ToExcel(this._ds, saveFileTo);
    Process.Start(saveFileTo);
  }

  protected virtual void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    ((MGAReport) this).Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (VoidedChecksReport));
    this.detail = new Detail();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.detail).Height = 0.0f;
    ((Section) this.detail).Name = "detail";
    ((Section) this.detail).Visible = false;
    ((SectionReport) this).MasterReport = false;
    ((SectionReport) this).PageSettings.PaperHeight = 11f;
    ((SectionReport) this).PageSettings.PaperWidth = 8.5f;
    ((SectionReport) this).Sections.Add((Section) this.detail);
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((SectionReport) this).ReportStart += new EventHandler(this.VoidedChecksReport_ReportStart);
    ((ISupportInitialize) this).EndInit();
  }
}
