// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportingExcelExport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.Tools;
using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Reporting;

[Preference("Reports.Override.ForceExportAsXls", -1)]
public class ReportingExcelExport
{
  private ReportingExcelExport()
  {
  }

  public static void ReportingToExcel(DataView source, string filePath)
  {
    if (source == null)
      throw new ArgumentNullException(nameof (source));
    ReportingExcelExport.ReportingToExcel(source.ToTable(), filePath);
  }

  public static void ReportingToExcel(DataTable source, string filePath)
  {
    ReportingExcelExport.ReportingToExcel(source, filePath, (EventHandler<ExportExcelCellCreatedEventArgs>) null);
  }

  public static void ReportingToExcel(
    DataTable source,
    string filePath,
    EventHandler<ExportExcelCellCreatedEventArgs> cellCreatedHandler)
  {
    if (source == null)
      throw new ArgumentNullException(nameof (source));
    ReportingExcelExport.ReportingToExcel(new DataSet()
    {
      Tables = {
        source.Copy()
      }
    }, filePath);
  }

  public static void ReportingToExcel(DataSet source, string filePath)
  {
    ReportingExcelExport.ReportingToExcel(source, filePath, (EventHandler<ExportExcelCellCreatedEventArgs>) null);
  }

  public static void ReportingToExcel(
    DataSet source,
    string filePath,
    EventHandler<ExportExcelCellCreatedEventArgs> cellCreatedHandler)
  {
    if (source == null)
      throw new ArgumentNullException(nameof (source));
    ExcelExport.ToExcel(source, filePath, cellCreatedHandler, ReportingExcelExport.ExcelExportFormatPreference());
  }

  internal static FileFormatType ExcelExportFormatPreference()
  {
    int preferenceInt = Preferences.GetPreferenceInt("Reports.Override.ForceExportAsXls");
    return preferenceInt >= 0 ? (preferenceInt < 0 ? (FileFormatType) 6 : (FileFormatType) 5) : (!MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("ForceExportAsXls", false) ? (FileFormatType) 6 : (FileFormatType) 5);
  }
}
