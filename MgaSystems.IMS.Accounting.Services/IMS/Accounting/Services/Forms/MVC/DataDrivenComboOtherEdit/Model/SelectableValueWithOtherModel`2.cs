// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Model.SelectableValueWithOtherModel`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.Model;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Model;

public class SelectableValueWithOtherModel<TNamedValue, TIdentifier> : 
  ValidateModelBase,
  ISelectableValueWithOtherModel<TNamedValue, TIdentifier>,
  ISelectableValueWithOtherModel,
  IValidateModel,
  IMvcModel,
  IValidate
  where TNamedValue : INamedValue<TIdentifier>
{
  private TIdentifier _otherValue;
  private string _otherDisplayTextValue;

  public bool IsOtherSelected
  {
    get => this.SelectableValueModel.SelectedValue.Equals((object) this._otherValue);
  }

  public TIdentifier SelectedValue
  {
    get => this.SelectableValueModel.SelectedValue;
    set => this.SelectableValueModel.SelectedValue = value;
  }

  public ISelectableValueModel<TNamedValue, TIdentifier> SelectableValueModel { get; }

  public SelectableValueWithOtherModel(
    string otherDisplayTextValue,
    IEnumerable<TNamedValue> selectableValues,
    string otherTextValue,
    TIdentifier selectedValue,
    TIdentifier defaultValue,
    string friendlyModelName,
    bool useAn)
  {
    this.SelectableValueModel = (ISelectableValueModel<TNamedValue, TIdentifier>) new MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.Model.SelectableValueModel<TNamedValue, TIdentifier>(selectableValues, selectedValue, defaultValue, friendlyModelName, useAn);
    this.DetermineOtherValue(otherTextValue, selectableValues);
    this._otherDisplayTextValue = otherDisplayTextValue ?? throw new ArgumentNullException(nameof (otherDisplayTextValue));
  }

  public string OtherText
  {
    get => !this.IsOtherSelected ? string.Empty : this._otherDisplayTextValue;
    set
    {
      this._otherDisplayTextValue = value ?? throw new InvalidOperationException("Cannot set OtherText to null.");
      this.NotifyObservers();
    }
  }

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
    this.SelectableValueModel.ValidateData(validationResult);
    if (!this.IsOtherSelected)
      return;
    validationResult.ValidateIsNotNullOrEmpty(this.OtherText, "other " + this.SelectableValueModel.FriendlyModelName, true);
  }

  private void DetermineOtherValue(string otherTextValue, IEnumerable<TNamedValue> selectableValues)
  {
    this._otherValue = (selectableValues.FirstOrDefault<TNamedValue>((Func<TNamedValue, bool>) (x => x.Name.Equals(otherTextValue))) ?? throw new InvalidOperationException($"Must have a value matching otherTextValue: '{otherTextValue}'.")).UniqueIdentifier;
  }

  ISelectableValueModel ISelectableValueWithOtherModel.SelectableValueModel
  {
    get => (ISelectableValueModel) this.SelectableValueModel;
  }

  object ISelectableValueWithOtherModel.SelectedValue
  {
    get => (object) this.SelectedValue;
    set
    {
      if (!(value is TIdentifier identifier))
        return;
      this.SelectedValue = identifier;
    }
  }
}
