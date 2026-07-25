// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Import_Inspection.SpreadsheetColumn
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using MGASystems.AsposeFacade.Cells;
using MGASystems.Data.Binding;
using MGASystems.IMS.Policies;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.Import_Inspection;

public abstract class SpreadsheetColumn : BindingObject
{
  [NotificationProperty]
  public virtual string ColumnID { get; set; }

  [NotificationProperty]
  public virtual string ColumnName { get; set; }

  public static SpreadsheetColumn Create(string columnID, string columnName)
  {
    return NotifyProxyTypeManager.Allocate<SpreadsheetColumn>(new object[2]
    {
      (object) columnID,
      (object) columnName
    });
  }

  public SpreadsheetColumn(string columnID, string columnName)
  {
    this.ColumnID = columnID;
    this.ColumnName = columnName;
  }

  public static ObservableCollection<SpreadsheetColumn> LoadSpreadsheetColumns(string fileName)
  {
    ObservableCollection<SpreadsheetColumn> observableCollection = new ObservableCollection<SpreadsheetColumn>();
    Workbook workbook = new Workbook(fileName);
    if (workbook.Worksheets.Count > 1)
    {
      using (SelectWorksheet selectWorksheet = new SelectWorksheet(workbook))
      {
        selectWorksheet.ShowInTaskbar = false;
        if (selectWorksheet.ShowDialog() == DialogResult.OK)
        {
          Worksheet selectedSheet = selectWorksheet.SelectedSheet;
        }
      }
    }
    else
    {
      if (workbook.Worksheets.Count != 1)
        throw new InvalidOperationException("Workbook contains no worksheets!");
      Worksheet worksheet = workbook.Worksheets[0];
    }
    return observableCollection;
  }
}
