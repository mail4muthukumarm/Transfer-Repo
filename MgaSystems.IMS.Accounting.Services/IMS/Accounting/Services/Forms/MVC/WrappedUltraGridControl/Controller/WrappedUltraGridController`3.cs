// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller.WrappedUltraGridController`3
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.View;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller;

public abstract class WrappedUltraGridController<TDisplayItem, TModel, TGridView> : 
  MvcControllerBase<TModel, TGridView>,
  IWrappedUltraGridController<TDisplayItem>,
  IWrappedUltraGridController,
  IMvcController
  where TModel : class, IUltraGridDataModel<TDisplayItem>
  where TGridView : class, IWrappedUltraGridView
{
  private IUltraGridAdapter<TDisplayItem> _gridAdapter;

  public event Action<object> GridSelectedObjectChanged;

  protected IUltraGridAdapter<TDisplayItem> GridAdapter
  {
    get
    {
      if (this._gridAdapter == null)
        this._gridAdapter = this.CreateGridAdapter();
      return this._gridAdapter;
    }
  }

  public IEnumerable<TDisplayItem> VisibleDisplayItems
  {
    get
    {
      return ((IEnumerable<TDisplayItem>) this.Model.DisplayItems).Where<TDisplayItem>((Func<TDisplayItem, bool>) (item => this.GridAdapter.TopLevelTable.IsObjectVisibleAsRow((object) item)));
    }
  }

  public object GetSelected() => this.GridAdapter.SelectedObjectInGrid;

  public void ClearSelected() => this.GridAdapter.ClearSelected();

  public void SetTopLevelFilter(Func<TDisplayItem, bool> filter)
  {
    if (filter == null)
      throw new ArgumentNullException(nameof (filter));
    this.GridAdapter.TopLevelTable.SetFilter(filter);
  }

  public void WireUpGridAdapter(UltraGrid wrappedUltraGrid)
  {
    this.GridAdapter.ApplySettingsToGrid(wrappedUltraGrid);
  }

  public void ReMapObjectsToRows() => this.GridAdapter.ReMapObjectsToRows();

  public virtual void RequestSetSelected(object selected)
  {
    this.GridAdapter.SelectedObjectInGrid = selected;
  }

  public virtual IEnumerable<TDisplayItem> GetDisplayItems()
  {
    return (IEnumerable<TDisplayItem>) this.Model.DisplayItems;
  }

  public void InitializeListeners() => this.GridAdapter.InitializeListerners();

  protected abstract IUltraGridAdapter<TDisplayItem> ChildCreateGridAdapter();

  private IUltraGridAdapter<TDisplayItem> CreateGridAdapter()
  {
    IUltraGridAdapter<TDisplayItem> gridAdapter = this.ChildCreateGridAdapter();
    gridAdapter.SelectedObjectInGridChanged += new EventHandler(this.SelectedObjectChanged);
    return gridAdapter;
  }

  private void SelectedObjectChanged(object sender, EventArgs e)
  {
    if (!(sender is IUltraGridAdapter<TDisplayItem> ultraGridAdapter))
      return;
    Action<object> selectedObjectChanged = this.GridSelectedObjectChanged;
    if (selectedObjectChanged == null)
      return;
    selectedObjectChanged(ultraGridAdapter.SelectedObjectInGrid);
  }

  IEnumerable IWrappedUltraGridController.GetDisplayItems() => (IEnumerable) this.GetDisplayItems();
}
