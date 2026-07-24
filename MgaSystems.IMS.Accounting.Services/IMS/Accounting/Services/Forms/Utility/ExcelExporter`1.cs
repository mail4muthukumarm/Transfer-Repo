// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.Utility.ExcelExporter`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.AsposeFacade.Cells;
using MGASystems.Data.Repository.ToDataTable;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.Utility;

public class ExcelExporter<TObject> : IExcelExporter
{
  private IEnumerable<IDataTableColumnMapping<TObject>> _mappings { get; }

  public ExcelExporter(
    IEnumerable<IDataTableColumnMapping<TObject>> mappings)
  {
    this._mappings = mappings ?? throw new ArgumentNullException(nameof (mappings));
  }

  public void Export(IEnumerable<object> objects, bool openAfterExport)
  {
    this.Export(objects.Select<object, TObject>((Func<object, TObject>) (x => (TObject) x)), openAfterExport);
  }

  public void Export(IEnumerable<TObject> objects, bool openAfterExport)
  {
    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
    {
      ExcelExporter<TObject>.SetDialogFileConstraints(saveFileDialog);
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      string fileName = saveFileDialog.FileName;
      ExcelExport.ToExcel(ObjectToDataTable.ToDataTable<TObject>(objects, this._mappings), fileName);
      if (!openAfterExport)
        return;
      Process.Start(fileName);
    }
  }

  private static void SetDialogFileConstraints(SaveFileDialog saveFileDialog)
  {
    if (ExcelExporter<TObject>.GetExcelExportFormatPreference() == 6)
    {
      saveFileDialog.DefaultExt = ".xlsx";
      saveFileDialog.Filter = "Excel Files(*.xlsx)|*.xlsx|Excel File 97-2003 (*.xls)|*.xls";
    }
    else
    {
      saveFileDialog.DefaultExt = ".xls";
      saveFileDialog.Filter = "Excel File 97-2003 (*.xls)|*.xls";
    }
  }

  private static FileFormatType GetExcelExportFormatPreference()
  {
    int preferenceInt = Preferences.GetPreferenceInt("Reports.Override.ForceExportAsXls");
    return preferenceInt < 0 ? (SystemSettings.GetSetting<bool>("ForceExportAsXls", false) ? (FileFormatType) 5 : (FileFormatType) 6) : (preferenceInt >= 0 ? (FileFormatType) 5 : (FileFormatType) 6);
  }
}
