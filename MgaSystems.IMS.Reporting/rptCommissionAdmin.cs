// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptCommissionAdmin
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
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
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
[SecureReportResource("{FD2E6EDC-7014-4cb8-BA2F-5E9FFB01B267}", "Commission Admin", "Exports to Excel Producer Lines Commission and Company Line Commission.", "General")]
public class rptCommissionAdmin : MGAExcelReport, IReport
{
  internal const string SecurityIDReportGuid = "{FD2E6EDC-7014-4cb8-BA2F-5E9FFB01B267}";
  private DataSet _ds;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("PageHeader1")]
  private virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail1")]
  private virtual Detail Detail1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptCommissionAdmin));
    this.PageHeader1 = new PageHeader();
    this.Detail1 = new Detail();
    this.PageFooter1 = new PageFooter();
    ((ISupportInitialize) this).BeginInit();
    this.PageHeader1.Height = 0.25f;
    ((Section) this.PageHeader1).Name = "PageHeader1";
    this.Detail1.ColumnSpacing = 0.0f;
    ((Section) this.Detail1).Height = 2f;
    ((Section) this.Detail1).Name = "Detail1";
    this.PageFooter1.Height = 0.25f;
    ((Section) this.PageFooter1).Name = "PageFooter1";
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.Sections.Add((Section) this.PageHeader1);
    this.Sections.Add((Section) this.Detail1);
    this.Sections.Add((Section) this.PageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this).EndInit();
  }

  public rptCommissionAdmin()
  {
    this.ReportStart += new EventHandler(this.rptCommissionAdmin_ReportStart);
    this._ds = new DataSet();
    this.InitializeComponent();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls => (BaseReportControl[]) null;

  private void rptCommissionAdmin_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    using (DbConnection dbConnection = DefaultDatabase.CreateDbConnection())
    {
      using (DbCommand command = DefaultDatabase.CreateCommand(nameof (rptCommissionAdmin), dbConnection))
      {
        command.CommandType = CommandType.StoredProcedure;
        command.CommandTimeout = 0;
        using (DbDataAdapter dataAdapter = DefaultDatabase.CreateDataAdapter(command))
        {
          try
          {
            DefaultDatabase.DataAdapterFill(dataAdapter, this._ds);
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
    this._ds.Tables[0].TableName = "Producer Lines Commission";
    this._ds.Tables[1].TableName = "Company Line Commission";
    this.DataSource = (object) this._ds.Tables[0];
  }

  protected override void DoExport(string SaveFileTo) => ExcelExport.ToExcel(this._ds, SaveFileTo);
}
