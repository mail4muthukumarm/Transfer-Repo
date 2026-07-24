// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.Controller.SearchSelectController`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.Controller;

[Override(typeof (ISearchSelectController))]
public abstract class SearchSelectController<TDisplayItem> : 
  WrappedUltraGridController<TDisplayItem, ISearchSelectModel<TDisplayItem>, ISearchSelectView>,
  ISearchSelectController<TDisplayItem>,
  IWrappedUltraGridController<TDisplayItem>,
  IWrappedUltraGridController,
  IMvcController,
  ISearchSelectController,
  ISaveDataController
{
  private Func<string, TDisplayItem, bool> _searchFunction;

  protected SearchSelectController(Func<string, TDisplayItem, bool> searchFunction)
  {
    this.GridAdapter.RowDoubleClicked += new Action<object>(this.GridAdapter_RowDoubleClicked);
    this.GridAdapter.SelectedObjectInGridChanged += new EventHandler(this.GridAdapter_SelectedObjectInGridChanged);
    this._searchFunction = searchFunction ?? throw new ArgumentNullException(nameof (searchFunction));
  }

  private void GridAdapter_SelectedObjectInGridChanged(object sender, EventArgs e)
  {
    TDisplayItem selectedObjectInGrid = (TDisplayItem) this.GridAdapter.SelectedObjectInGrid;
    if ((object) selectedObjectInGrid == null)
      this.Model.ClearSelection();
    else
      this.Model.SelectedItem = selectedObjectInGrid;
  }

  private void GridAdapter_RowDoubleClicked(object obj) => this.RequestSave();

  public override void RequestSetSelected(object value)
  {
    base.RequestSetSelected(value);
    if (value == null)
      this.Model.ClearSelection();
    else
      this.Model.SelectedItem = (TDisplayItem) value;
  }

  public void RequestReset() => this.View.RequestCloseForm(DialogResult.Abort);

  public void RequestSave()
  {
    try
    {
      this.Model.ValidateData();
    }
    catch (DataValidationException ex)
    {
      int num = (int) MessageBox.Show(ex.Message, "Could not set new selection.");
      return;
    }
    this.View.RequestCloseForm(DialogResult.OK);
  }

  public void RequestSetFilter(string text)
  {
    if (text == string.Empty)
    {
      this.RequestClearFilter();
    }
    else
    {
      this.GridAdapter.TopLevelTable.SetFilter((Func<TDisplayItem, bool>) (item => this.FilterFunction(item, text)));
      this.Model.SearchText = text;
    }
  }

  private bool FilterFunction(TDisplayItem item, string text) => this._searchFunction(text, item);

  public void RequestClearFilter()
  {
    this.GridAdapter.TopLevelTable.SetFilter((Func<TDisplayItem, bool>) (item => true));
    this.Model.SearchText = string.Empty;
  }
}
