// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model.UltraGridBulkCrudDataModel`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model;

public abstract class UltraGridBulkCrudDataModel<TDisplayItem> : 
  UltraGridDataBulkEditModel<TDisplayItem>,
  IUltraGridDataModel<TDisplayItem>,
  IUltraGridDataModel,
  IValidateModel,
  IMvcModel,
  IValidate,
  IEditCollection<TDisplayItem>,
  ISaveModel,
  ISave
  where TDisplayItem : IDatabaseSaveModel
{
  private List<TDisplayItem> _displayItems;

  protected List<TDisplayItem> DisplayItemList
  {
    get
    {
      if (this._displayItems == null)
        this.Load();
      return this._displayItems;
    }
  }

  public event Action<TDisplayItem> ItemAdded;

  public event Action<TDisplayItem> ItemRemoved;

  public override TDisplayItem[] DisplayItems => this.DisplayItemList.ToArray();

  public override void Load()
  {
    this._displayItems = ((IEnumerable<TDisplayItem>) this.GetDisplayItems()).ToList<TDisplayItem>();
  }

  public void AddNewItem()
  {
    TDisplayItem displayItem = this.GetNew();
    if ((object) displayItem == null)
      throw new InvalidOperationException("GetNew() must not return null.");
    this.DisplayItemList.Add(displayItem);
    Action<TDisplayItem> itemAdded = this.ItemAdded;
    if (itemAdded == null)
      return;
    itemAdded(displayItem);
  }

  public void RemoveItem(TDisplayItem item)
  {
    if (!this.DisplayItemList.Remove(item))
      throw new InvalidOperationException("Cannot remove an item that doesn't exist!");
    Action<TDisplayItem> itemRemoved = this.ItemRemoved;
    if (itemRemoved == null)
      return;
    itemRemoved(item);
  }

  public override void ResetChanges()
  {
    foreach (TDisplayItem displayItem in ((IEnumerable<TDisplayItem>) this.DisplayItems).Where<TDisplayItem>((Func<TDisplayItem, bool>) (item => item.IsNew)))
      this.RemoveItem(displayItem);
    base.ResetChanges();
  }

  protected abstract TDisplayItem GetNew();
}
