// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller.WrappedUltraGridDatabaseBulkCrudController`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.Utility;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller;

public abstract class WrappedUltraGridDatabaseBulkCrudController<TDisplayItem, TModel> : 
  WrappedUltraGridDatabaseBulkEditController<TDisplayItem, TModel>,
  IAddDeleteController
  where TDisplayItem : IDatabaseSaveModel
  where TModel : class, IUltraGridDataModel<TDisplayItem>, ISave, IEditCollection<TDisplayItem>
{
  private BindingList<TDisplayItem> _displayItems;

  public override IEnumerable<TDisplayItem> GetDisplayItems()
  {
    return (IEnumerable<TDisplayItem>) this.DisplayItems;
  }

  public void RequestAddNew() => this.Model.AddNewItem();

  public void RequestDeleteSelected()
  {
    if (this.GridAdapter.SelectedObjectInGrid is TDisplayItem selectedObjectInGrid)
    {
      if (!selectedObjectInGrid.CanDelete())
      {
        this.View.DisplayOkMessageBox("This object cannot be deleted at this time. This is likely due to it being referenced elsewhere in the database. Please contact your system administrator if you believe this is a mistake.", "Cannot Delete");
      }
      else
      {
        if (!this.View.DisplayYesNo("Deleting Records cannot be undone.\nContinue?", "Confirm Delete"))
          return;
        selectedObjectInGrid.DeleteFromDatabase();
        this.Model.RemoveItem(selectedObjectInGrid);
      }
    }
    else
      this.View.DisplayOkMessageBox($"Must select a {typeof (TDisplayItem).Name} to delete.", "Invalid Selection", MessageBoxIcon.Hand);
  }

  protected override void ChildWireUp()
  {
    base.ChildWireUp();
    this.Model.ItemAdded += new Action<TDisplayItem>(this.Model_ItemAdded);
    this.Model.ItemRemoved += new Action<TDisplayItem>(this.Model_ItemRemoved);
  }

  protected override void ChildUnWireUp()
  {
    base.ChildUnWireUp();
    this.Model.ItemAdded -= new Action<TDisplayItem>(this.Model_ItemAdded);
    this.Model.ItemRemoved -= new Action<TDisplayItem>(this.Model_ItemRemoved);
  }

  protected BindingList<TDisplayItem> DisplayItems
  {
    get
    {
      if (this._displayItems == null)
        this.Load();
      return this._displayItems;
    }
  }

  private void Load()
  {
    this._displayItems = new BindingList<TDisplayItem>((IList<TDisplayItem>) ((IEnumerable<TDisplayItem>) this.Model.DisplayItems).ToList<TDisplayItem>());
    this._displayItems.AllowNew = true;
    this._displayItems.AllowRemove = true;
    this._displayItems.RaiseListChangedEvents = true;
    this._displayItems.AllowEdit = false;
  }

  private void Model_ItemRemoved(TDisplayItem displayItem) => this.DisplayItems.Remove(displayItem);

  private void Model_ItemAdded(TDisplayItem displayItem)
  {
    this.DisplayItems.Add(displayItem);
    this.GridAdapter.MoveRowToTopOfTable((object) displayItem);
    this.GridAdapter.SelectedObjectInGrid = (object) displayItem;
  }
}
