// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.MGAExcelReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using System.Diagnostics;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class MGAExcelReport : MGAReport
{
  public virtual void Export()
  {
    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
    {
      if (ReportingExcelExport.ExcelExportFormatPreference() == 6)
      {
        saveFileDialog.DefaultExt = ".xlsx";
        saveFileDialog.Filter = "Excel Files(*.xlsx)|*.xlsx|Excel File 97-2003 (*.xls)|*.xls";
      }
      else
      {
        saveFileDialog.DefaultExt = ".xls";
        saveFileDialog.Filter = "Excel File 97-2003 (*.xls)|*.xls";
      }
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      string fileName = saveFileDialog.FileName;
      this.DoExport(fileName);
      Process.Start(fileName);
    }
  }

  protected virtual void DoExport(string excelFileName)
  {
  }
}
