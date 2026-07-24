// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reporting.Reports.Documents.rptAdvancedToBroker
// Assembly: MGASystems.IMS.Accounting.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 725B9A25-3FF1-4B2E-9ECA-9E17C2CAE78A
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Accounting.Reporting.dll

using DDCssLib;
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
namespace MGASystems.IMS.Accounting.Reporting.Reports.Documents;

[SecureReportResource("{643AAD27-AC19-4DF1-A206-A2F8FAB89CDC}", "Advanced to Broker Report", "Advanced to Broker Report", "Accounting")]
public class rptAdvancedToBroker : MGAExcelReport, IReport
{
  private DateTime _postDateFrom;
  private DateTime _postDateTo;
  private bool _flagShowAdvancedOnly;
  private DataSet _ds;
  private Detail detail;

  public rptAdvancedToBroker() => this.InitializeComponent();

  public rptAdvancedToBroker(DateTime PostDateFrom, DateTime PostDateTo, bool FlagShowAdvancedOnly)
  {
    this.InitializeComponent();
    this._postDateFrom = PostDateFrom;
    this._postDateTo = PostDateTo;
    this._flagShowAdvancedOnly = FlagShowAdvancedOnly;
  }

  Type IReport.getLaunchForm => (Type) null;

  BaseReportControl[] IReport.getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new DateRangePicker("Post Date", true),
        (BaseReportControl) new GenericCheckBox("", "Show Advanced Only")
      };
    }
  }

  private void rptAdvancedToBroker_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    ArrayList arrayList = new ArrayList();
    if (!this._postDateFrom.Equals(DateTime.MinValue))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@PostDateFrom",
        (object) this._postDateFrom
      });
    if (!this._postDateTo.Equals(DateTime.MinValue))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@PostDateTo",
        (object) this._postDateTo
      });
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@FlagShowAdvancedOnly",
      (object) this._flagShowAdvancedOnly
    });
    this._ds = DefaultDatabase.ExecuteDataSet(CommandType.StoredProcedure, "spFin_rptAdvancedToBroker", 0, (CommandArgumentType) 0, arrayList.ToArray());
    this.DataSource = (object) this._ds.Tables[0];
  }

  public override bool IsThreaded => true;

  protected override void DoExport(string saveFileTo)
  {
    ExcelExport.ToExcel(this._ds, saveFileTo);
    Process.Start(saveFileTo);
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptAdvancedToBroker));
    this.detail = new Detail();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.detail).Height = 0.0f;
    ((Section) this.detail).Name = "detail";
    ((Section) this.detail).Visible = false;
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.Sections.Add((Section) this.detail);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    this.ReportStart += new EventHandler(this.rptAdvancedToBroker_ReportStart);
    ((ISupportInitialize) this).EndInit();
  }
}
