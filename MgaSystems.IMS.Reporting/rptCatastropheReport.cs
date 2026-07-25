// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptCatastropheReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{04DE3A4D-724C-4ea4-8A20-995FED5E21B4}", "NetRate CAT Report", "NetRate CAT - Property Information Data Request", "General")]
public class rptCatastropheReport : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{04DE3A4D-724C-4ea4-8A20-995FED5E21B4}";
  private readonly DateTime _AsOfDate;
  private readonly string _Companies;
  private readonly string _Lines;
  private DataSet _ds;

  public rptCatastropheReport()
  {
    this.ReportStart += new EventHandler(this.rptCatastropheReport_ReportStart);
  }

  public rptCatastropheReport(DateTime AsOfDate, string Companies, string Lines)
  {
    this.ReportStart += new EventHandler(this.rptCatastropheReport_ReportStart);
    this.InitializeComponent();
    this._AsOfDate = AsOfDate;
    this._Companies = Companies;
    this._Lines = Lines;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptCatastropheReport));
    this.Detail = new Detail();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Height = 0.0f;
    ((Section) this.Detail).Name = "Detail";
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((Section) this.Detail);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this).EndInit();
  }

  private void rptCatastropheReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this._ds = DefaultDatabase.ExecuteDataSet(CommandType.StoredProcedure, nameof (rptCatastropheReport), 0, (CommandArgumentType) 0, new object[8]
    {
      (object) "@AsOfDate",
      (object) this._AsOfDate,
      (object) "@CompanyGuids",
      (object) this._Companies,
      (object) "@LineGuid",
      (object) DBNull.Value,
      (object) "@LineGuids",
      (object) this._Lines
    });
    this.DataSource = (object) this._ds.Tables[0];
    rptGridReport rptGridReport = new rptGridReport(this._ds.Tables[0], 2, $"Catastrophe Report for {RuntimeHelpers.GetObjectValue(this._ds.Tables[1].Rows[0]["CompanyNames"])} - {RuntimeHelpers.GetObjectValue(this._ds.Tables[1].Rows[0]["LineName"])} as of {this._AsOfDate.ToShortDateString()}");
    rptGridReport.Run();
    this.Document.Pages.Clear();
    this.PrintWidth = rptGridReport.PrintWidth;
    this.PageSettings.PaperWidth = rptGridReport.PageSettings.PaperWidth;
    this.Document.Pages.AddRange(rptGridReport.Document.Pages);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new DatePicker("As Of Date", DateTime.Now, false),
        (BaseReportControl) new GenericListBox("Carrier(s)", "SELECT CompanyName As Display, CompanyGuid As Value FROM tblCompanies ORDER BY Display", "Value", "Display", true, typeof (Guid), true, true, 100),
        (BaseReportControl) new GenericListBox("Line(s)", "SELECT LineName As Display, LineGuid As Value FROM lstLines ORDER BY Display", "Value", "Display", true, typeof (Guid), true, true, 100)
      };
    }
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._ds.Tables[0], SaveFileTo);
  }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
