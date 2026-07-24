// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.Model.SelectableValueModel`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data.CommonInterface;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.Model;

[Obsolete("Use MvcComboBox")]
public class SelectableValueModel<TNamedValue, TIdentifier> : 
  ValidateModelBase,
  ISelectableValueModel<TNamedValue, TIdentifier>,
  ISelectableValueModel,
  IValidateModel,
  IMvcModel,
  IValidate
  where TNamedValue : INamedValue<TIdentifier>
{
  private bool _useAn;
  private TIdentifier _selectedValue;

  public virtual TIdentifier DefaultValue { get; }

  public string FriendlyModelName { get; }

  public TIdentifier SelectedValue
  {
    get => this._selectedValue;
    set
    {
      this.CheckSelectableValuesContains(value);
      this._selectedValue = value;
      this.NotifyObservers();
    }
  }

  public TNamedValue SelectedNamedValue
  {
    get
    {
      return this.SelectableValues.Single<TNamedValue>((Func<TNamedValue, bool>) (value => value.UniqueIdentifier.Equals((object) this.SelectedValue)));
    }
  }

  public IEnumerable<TNamedValue> SelectableValues { get; }

  public SelectableValueModel(
    IEnumerable<TNamedValue> selectableValues,
    TIdentifier selectedValue,
    TIdentifier defaultValue,
    string friendlyModelName,
    bool useAn)
  {
    this.SelectableValues = selectableValues ?? throw new ArgumentNullException(nameof (selectableValues));
    this.ValidateSelectableValues();
    this.CheckSelectableValuesContains(defaultValue);
    this.DefaultValue = defaultValue;
    this._selectedValue = selectedValue;
    this.FriendlyModelName = friendlyModelName ?? throw new ArgumentNullException(nameof (friendlyModelName));
    this._useAn = useAn;
  }

  public virtual bool HasValue() => !this.SelectedValue.Equals((object) this.DefaultValue);

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
    validationResult.ValidateHasSelection(this.HasValue(), this.FriendlyModelName, this._useAn);
  }

  private void ValidateSelectableValues()
  {
    if (this.SelectableValues.Any<TNamedValue>((Func<TNamedValue, bool>) (v => (object) v == null)))
      throw new ArgumentException("Selectable values may not contain a null value.");
    foreach (TNamedValue selectableValue in this.SelectableValues)
    {
      TNamedValue value = selectableValue;
      if (this.SelectableValues.Where<TNamedValue>((Func<TNamedValue, bool>) (v => v.UniqueIdentifier.Equals((object) value.UniqueIdentifier))).Count<TNamedValue>() > 1)
        throw new ArgumentException($"Selectable Values must not contain any duplicate IDs. Found duplicate: {value.UniqueIdentifier}");
    }
  }

  private void CheckSelectableValuesContains(TIdentifier value)
  {
    if (!this.SelectableValues.Select<TNamedValue, TIdentifier>((Func<TNamedValue, TIdentifier>) (v => v.UniqueIdentifier)).Contains<TIdentifier>(value))
      throw new InvalidOperationException("Must be a value that's contained inside the SelectableValues set.");
  }

  object ISelectableValueModel.SelectedValue
  {
    get => (object) this.SelectedValue;
    set
    {
      this.SelectedValue = value is TIdentifier identifier ? identifier : throw new InvalidOperationException("SelectedValue must be of type " + typeof (TIdentifier).Name);
    }
  }

  IEnumerable<INamedValue> ISelectableValueModel.SelectableValues
  {
    get
    {
      return this.SelectableValues.Select<TNamedValue, INamedValue>((Func<TNamedValue, INamedValue>) (v => (INamedValue) (object) v));
    }
  }

  INamedValue ISelectableValueModel.SelectedNamedValue
  {
    get => (INamedValue) (object) this.SelectedNamedValue;
  }
}
