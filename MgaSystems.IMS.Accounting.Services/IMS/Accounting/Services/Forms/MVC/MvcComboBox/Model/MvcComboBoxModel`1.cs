// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.Model.MvcComboBoxModel`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.Model;

public class MvcComboBoxModel<TDisplayItem> : 
  ValidateModelBase,
  IMvcComboBoxModel<TDisplayItem>,
  IMvcComboBoxModel,
  IValidateModel,
  IMvcModel,
  IValidate
  where TDisplayItem : class
{
  private TDisplayItem _selectedItem;
  private List<TDisplayItem> _items;
  private bool _allowNullSelection;
  private readonly string _friendlyName;

  public event EventHandlers.SelectionChangedEventHandler<TDisplayItem> OnSelectionChanged;

  IEnumerable IMvcComboBoxModel.Items
  {
    get => (IEnumerable) this.Items;
    set
    {
      this.Items = value is IEnumerable<TDisplayItem> displayItems ? displayItems : throw new InvalidOperationException("object must be of type " + typeof (TDisplayItem).Name);
    }
  }

  object IMvcComboBoxModel.SelectedItem
  {
    get => (object) this.SelectedItem;
    set
    {
      this.SelectedItem = value is TDisplayItem displayItem ? displayItem : throw new InvalidOperationException("object must be of type " + typeof (TDisplayItem).Name);
    }
  }

  public bool MustHaveSelection
  {
    get => this._allowNullSelection;
    set
    {
      if (this._allowNullSelection == value)
        return;
      this._allowNullSelection = value;
      this.NotifyObservers();
    }
  }

  public bool HasSelectedItem() => (object) this._selectedItem != null;

  public IEnumerable<TDisplayItem> Items
  {
    get => (IEnumerable<TDisplayItem>) this._items.ToArray();
    set
    {
      if (value == null)
        throw new ArgumentNullException(nameof (value));
      this.ValidateItems(value);
      if (this.HasSelectedItem() && !value.Contains<TDisplayItem>(this.SelectedItem))
        this.SetSelection(default (TDisplayItem));
      this._items = value.ToList<TDisplayItem>();
      this.NotifyObservers();
    }
  }

  public TDisplayItem SelectedItem
  {
    get
    {
      if (!this.HasSelectedItem())
        throw new InvalidOperationException("There is no selected item.");
      return this._selectedItem;
    }
    set
    {
      if ((object) value == null)
        throw new InvalidOperationException("Cannot set selected item to null.");
      __Boxed<TDisplayItem> selectedItem = (object) this._selectedItem;
      if ((selectedItem != null ? (!selectedItem.Equals((object) value) ? 1 : 0) : 1) == 0)
        return;
      this.SetSelection(value);
      this.NotifyObservers();
    }
  }

  public MvcComboBoxModel(
    IEnumerable<TDisplayItem> items,
    bool mustHaveSelection,
    string friendlyName = null)
  {
    this.ValidateItems(items);
    this._items = items.ToList<TDisplayItem>() ?? throw new ArgumentNullException(nameof (items));
    this.MustHaveSelection = mustHaveSelection;
    this._friendlyName = friendlyName ?? "Value";
  }

  public void ClearSelection()
  {
    if (!this.HasSelectedItem())
      return;
    this.SetSelection(default (TDisplayItem));
    this.NotifyObservers();
  }

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
    if (!this.MustHaveSelection || this.HasSelectedItem())
      return;
    validationResult.Add((IDataValidationResult) new DoesNotHaveSelectedValueResult(this._friendlyName, false));
  }

  private void ValidateItems(IEnumerable<TDisplayItem> items)
  {
    if (items.Any<TDisplayItem>((Func<TDisplayItem, bool>) (i => (object) i == null)))
      throw new ArgumentException("Combo box items cannot be null.");
    foreach (TDisplayItem displayItem in items)
    {
      TDisplayItem item = displayItem;
      if (items.Count<TDisplayItem>((Func<TDisplayItem, bool>) (i => i.Equals((object) item))) > 1)
        throw new ArgumentException($"Cannot have two of the same display items in a combo box: {item}");
    }
  }

  private void SetSelection(TDisplayItem item)
  {
    EventHandlers.SelectionChangedEventHandler<TDisplayItem> selectionChanged = this.OnSelectionChanged;
    if (selectionChanged != null)
      selectionChanged(this._selectedItem, item);
    this._selectedItem = item;
  }
}
