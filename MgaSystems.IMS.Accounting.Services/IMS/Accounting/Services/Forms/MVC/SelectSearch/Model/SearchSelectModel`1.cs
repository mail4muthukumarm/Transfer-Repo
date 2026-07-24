// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.Model.SearchSelectModel`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.Model;

[Override(typeof (ISearchSelectModel))]
public class SearchSelectModel<TDisplayItem> : 
  BasicUltraGridDataModel<TDisplayItem>,
  ISearchSelectModel<TDisplayItem>,
  IUltraGridDataModel<TDisplayItem>,
  IUltraGridDataModel,
  IValidateModel,
  IMvcModel,
  IValidate,
  ISearchSelectModel
  where TDisplayItem : class
{
  private TDisplayItem _selectedItem;
  private string _searchText;

  public SearchSelectModel(
    TDisplayItem[] displayItems,
    TDisplayItem selectedItem,
    bool mustHaveSelection)
    : base(displayItems)
  {
    this.MustHaveSelection = mustHaveSelection;
    this._selectedItem = selectedItem;
  }

  public bool MustHaveSelection { get; }

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
      this._selectedItem = value;
      this.NotifyObservers();
    }
  }

  object ISearchSelectModel.SelectedItem
  {
    get => (object) this.SelectedItem;
    set
    {
      this.SelectedItem = value is TDisplayItem displayItem ? displayItem : throw new InvalidOperationException("object must be of type " + typeof (TDisplayItem).Name);
    }
  }

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
    if (this.HasSelectedItem())
      return;
    validationResult.Add((IDataValidationResult) new InvalidDataValidationResult("Must Select an Item!"));
  }

  public string SearchText
  {
    get => this._searchText;
    set
    {
      this._searchText = value;
      this.NotifyObservers();
    }
  }

  public bool HasSelectedItem() => (object) this._selectedItem != null;

  public void ClearSelection()
  {
    if (!this.HasSelectedItem())
      return;
    this._selectedItem = default (TDisplayItem);
    this.NotifyObservers();
  }
}
