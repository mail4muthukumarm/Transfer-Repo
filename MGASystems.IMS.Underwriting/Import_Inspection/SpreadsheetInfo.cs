// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Import_Inspection.SpreadsheetInfo
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Mga.Wpf.Ims.Data;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Data.Binding;
using MGASystems.IMS.Policies;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.Import_Inspection;

public abstract class SpreadsheetInfo : BindingObject
{
  [NotificationProperty]
  public virtual ObservableCollection<SpreadsheetColumn> ColumnList { get; set; }

  public Worksheet SelectedWorksheet { get; set; }

  public IEnumerable<SuggestItemsSource> SuggestColumns { get; }

  public string FileName { get; set; }

  public Dictionary<string, int> ColumnIndex { get; set; }

  public static SpreadsheetInfo Create(string fileName)
  {
    return NotifyProxyTypeManager.Allocate<SpreadsheetInfo>(new object[1]
    {
      (object) fileName
    });
  }

  public SpreadsheetInfo(string fileName)
  {
    this.FileName = fileName;
    this.ColumnIndex = new Dictionary<string, int>();
    Workbook workbook = new Workbook(fileName);
    Worksheet worksheet = (Worksheet) null;
    if (workbook.Worksheets.Count > 1)
    {
      using (SelectWorksheet selectWorksheet = new SelectWorksheet(workbook))
      {
        selectWorksheet.ShowInTaskbar = false;
        if (selectWorksheet.ShowDialog() == DialogResult.OK)
          worksheet = selectWorksheet.SelectedSheet;
      }
    }
    else
    {
      if (workbook.Worksheets.Count != 1)
        throw new InvalidOperationException("Workbook contains no worksheets!");
      worksheet = workbook.Worksheets[0];
    }
    this.SelectedWorksheet = worksheet;
    this.ColumnList = new ObservableCollection<SpreadsheetColumn>();
    for (int index = 0; index <= worksheet.Cells.MaxColumn; ++index)
      this.ColumnList.Add(SpreadsheetColumn.Create(worksheet.Cells[0, index].Value.ToString(), worksheet.Cells[0, index].Value.ToString()));
    this.SuggestColumns = this.ColumnList.Select<SpreadsheetColumn, SuggestItemsSource>((Func<SpreadsheetColumn, SuggestItemsSource>) (item => new SuggestItemsSource(item.ColumnID, item.ColumnName, (object) SpreadsheetColumn.Create(item.ColumnID, item.ColumnName), item.ColumnName)));
  }

  public ObservableCollection<SearchObject> GetListForSearch()
  {
    ObservableCollection<SearchObject> listForSearch = new ObservableCollection<SearchObject>();
    foreach (SpreadsheetColumn column in (Collection<SpreadsheetColumn>) this.ColumnList)
      listForSearch.Add(SearchObject.Create(0, column.ColumnName, (object) column));
    return listForSearch;
  }
}
