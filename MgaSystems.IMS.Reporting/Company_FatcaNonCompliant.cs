// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.Company_FatcaNonCompliant
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing.Printing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{9C4333FA-38FF-490B-9186-EF9CB248329F}", "Company FATCA Non-Compliant", "exporting Company FTACA Non-Compliant record(s)", "General")]
public class Company_FatcaNonCompliant : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{9C4333FA-38FF-490B-9186-EF9CB248329F}";
  private string _ProducerGuids;
  private string _ProducerLocations;
  private string _ProducerLocationRegions;
  private Guid _UnderwriterGuid;
  private Guid _InHouseProducerGuid;
  private DateTime _DateSubmittedFrom;
  private DateTime _DateSubmittedTo;
  private DateTime _DateEffectiveFrom;
  private DateTime _DateEffectiveTo;
  private DataTable _dt;
  private int _failSafePreviousRecordCount;
  private int _QuoteStatusID;
  private Guid _CompanyLocationGuid;
  private Guid _IntermediaryGuid;
  private Guid _QuotingOfficeLocation;
  private string _IssuingOfficeLocations;
  private Guid _CompanyGroupGuid;
  private int _PolicyTypeID;
  private int _CostCenterID;
  private bool _excelOnly;
  private string _StateID;
  private string _LineGuid;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dt, SaveFileTo);
  }

  [field: AccessedThroughProperty("Label22")]
  private virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (Company_FatcaNonCompliant));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.Label22 = new Label();
    ((ISupportInitialize) this.Label22).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.25f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.Label22
    });
    this.ReportHeader.Height = 0.5104167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    this.ReportFooter.Height = 0.1666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.Label22).Height = 0.1458333f;
    this.Label22.HyperLink = (string) null;
    ((ARControl) this.Label22).Left = 2.062f;
    ((ARControl) this.Label22).Name = "Label22";
    this.Label22.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label22.Text = "Company Fatca Non Compliant";
    ((ARControl) this.Label22).Top = 0.125f;
    ((ARControl) this.Label22).Width = 4.563001f;
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
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label22).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public Company_FatcaNonCompliant()
  {
    this.ReportStart += new EventHandler(this.Company_FatcaNonCompliant_ReportStart);
    this._dt = new DataTable();
    this._failSafePreviousRecordCount = 0;
  }

  public Company_FatcaNonCompliant(DateTime DateEffectiveFrom, DateTime DateEffectiveTo)
  {
    this.ReportStart += new EventHandler(this.Company_FatcaNonCompliant_ReportStart);
    this._dt = new DataTable();
    this._failSafePreviousRecordCount = 0;
    this.InitializeComponent();
    this._DateEffectiveFrom = DateEffectiveFrom;
    this._DateEffectiveTo = DateEffectiveTo;
  }

  private void Company_FatcaNonCompliant_ReportStart(object sender, EventArgs e)
  {
    using (DbConnection dbConnection = DefaultDatabase.CreateDbConnection())
    {
      using (DbCommand command = DefaultDatabase.CreateCommand("[rptCompany_FatcaNonCompliant]", dbConnection))
      {
        command.CommandType = CommandType.StoredProcedure;
        command.CommandTimeout = 0;
        if (DateTime.Compare(this._DateEffectiveFrom, DateTime.MinValue) != 0)
          DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@EffectiveDateFrom", (object) this._DateEffectiveFrom);
        if (DateTime.Compare(this._DateEffectiveTo, DateTime.MinValue) != 0)
          DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@EffectiveDateTo", (object) this._DateEffectiveTo);
        using (DbDataAdapter dataAdapter = DefaultDatabase.CreateDataAdapter(command))
        {
          try
          {
            DefaultDatabase.DataAdapterFill(dataAdapter, this._dt);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
            ProjectData.ClearProjectError();
          }
        }
      }
    }
    this.DataSource = (object) this._dt;
  }

  public override bool IsThreaded => true;

  public override bool ExcelOnly => true;

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[1]
      {
        (BaseReportControl) new DateRangePicker("Effective", true)
      };
    }
  }
}
