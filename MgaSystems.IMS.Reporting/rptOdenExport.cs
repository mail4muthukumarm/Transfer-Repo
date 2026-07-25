// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptOdenExport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
[SecureReportResource("{6C309248-28D9-469a-8177-E8D0539BD3D2}", "Oden Export", "Oden Export to CSV files.", "General")]
public class rptOdenExport : MGAExcelReport, IReport
{
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
    ResourceManager resourceManager = new ResourceManager(typeof (rptOdenExport));
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

  public rptOdenExport()
  {
    this.ReportStart += new EventHandler(this.rptOdenExport_ReportStart);
    this.InitializeComponent();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls => (BaseReportControl[]) null;

  private void rptOdenExport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this._ds = DefaultDatabase.ExecuteDataSet(CommandType.StoredProcedure, "ODEN_CSVTransfer", 0, (CommandArgumentType) 0, new object[0]);
    this._ds.Tables[0].TableName = "Interest Information";
    this._ds.Tables[1].TableName = "InsuredPolicy Information";
    this._ds.Tables[2].TableName = "Producer Information";
    this.DataSource = (object) this._ds.Tables[0];
  }

  public override void Export()
  {
    SaveFileDialog saveFileDialog = new SaveFileDialog();
    string str = "";
    saveFileDialog.Filter = "Comma-separated values file(*.csv)|*.csv|Excel File (*.xls)|*.xls";
    saveFileDialog.DefaultExt = ".csv";
    saveFileDialog.Title = "Select filename for Interest Information";
    if (saveFileDialog.ShowDialog() == DialogResult.OK)
    {
      str = saveFileDialog.FileName;
      this.DoExport(str, this._ds.Tables[0]);
      Process.Start(str);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Path.GetExtension(str), ".xls", false) == 0)
      return;
    saveFileDialog.Title = "Select filename for InsuredPolicy Information";
    if (saveFileDialog.ShowDialog() == DialogResult.OK)
    {
      string fileName = saveFileDialog.FileName;
      this.DoExport(fileName, this._ds.Tables[1]);
      Process.Start(fileName);
    }
    saveFileDialog.Title = "Select filename for Producer Information";
    if (saveFileDialog.ShowDialog() != DialogResult.OK)
      return;
    string fileName1 = saveFileDialog.FileName;
    this.DoExport(fileName1, this._ds.Tables[2]);
    Process.Start(fileName1);
  }

  protected override void DoExport(string excelFileName)
  {
  }

  public void DoExport(string excelFileName, DataTable dt)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Path.GetExtension(excelFileName), ".xls", false) == 0)
    {
      ExcelExport.ToExcel(this._ds, excelFileName);
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Path.GetExtension(excelFileName), ".csv", false) != 0)
        return;
      this.ExportToCSV(excelFileName, dt);
    }
  }

  public void ExportToCSV(string FileName, DataTable dt)
  {
    StringBuilder stringBuilder = new StringBuilder();
    StreamWriter streamWriter = new StreamWriter(FileName, false);
    int num1 = dt.Columns.Count - 1;
    for (int index = 0; index <= num1; ++index)
    {
      stringBuilder.Append(dt.Columns[index].ColumnName);
      stringBuilder.Append(index == dt.Columns.Count - 1 ? "\n" : ",");
    }
    try
    {
      foreach (DataRow row in dt.Rows)
      {
        int num2 = dt.Columns.Count - 1;
        for (int index = 0; index <= num2; ++index)
        {
          if (index > 0)
            stringBuilder.Append(",");
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dt.Columns[index].DataType.ToString(), "System.String", false) == 0)
          {
            stringBuilder.Append("\"");
            stringBuilder.Append(row[index].ToString().Replace("\"", "\"\""));
            stringBuilder.Append("\"");
          }
          else
            stringBuilder.Append(row[index].ToString());
          if (index == dt.Columns.Count - 1)
            stringBuilder.Append("\n");
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    streamWriter.Write(stringBuilder.ToString());
    streamWriter.Flush();
    streamWriter.Dispose();
  }
}
