// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.SelectableValueOption`3
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options;

[Obsolete]
public class SelectableValueOption<TDisplayItem, TComboItem, TIdentifier> : 
  EditOptionStackOption<TDisplayItem, TComboItem, DataDrivenComboBoxView>
  where TComboItem : class, INamedValue<TIdentifier>
{
  private readonly TIdentifier _defaultValue;
  private ISelectableValueModel<INamedValue<TIdentifier>, TIdentifier> _selectableValueModel;

  private IEnumerable<TComboItem> _selectableValues { get; }

  public SelectableValueOption(
    string displayText,
    Func<TDisplayItem, TComboItem> getValueFunc,
    Action<TDisplayItem, TComboItem> setValueAction,
    IEnumerable<TComboItem> selectableValues,
    TIdentifier defaultValue)
    : base(displayText, getValueFunc, setValueAction)
  {
    this._selectableValues = selectableValues ?? throw new ArgumentNullException(nameof (selectableValues));
    this._defaultValue = defaultValue;
  }

  protected override DataDrivenComboBoxView ChildCreateValueControl()
  {
    DataDrivenComboBoxView valueControl = new DataDrivenComboBoxView();
    DataDrivenComboBoxController controller = new DataDrivenComboBoxController();
    this._selectableValueModel = (ISelectableValueModel<INamedValue<TIdentifier>, TIdentifier>) new SelectableValueModel<INamedValue<TIdentifier>, TIdentifier>((IEnumerable<INamedValue<TIdentifier>>) this._selectableValues.Select<TComboItem, INamedValue<TIdentifier>>((Func<TComboItem, INamedValue<TIdentifier>>) (x => (INamedValue<TIdentifier>) x)).ToList<INamedValue<TIdentifier>>(), this._defaultValue, this._defaultValue, this.DisplayText, false);
    valueControl.WireUp((IMvcController) controller, (IMvcModel) this._selectableValueModel);
    valueControl.Width = 167;
    valueControl.Height = 20;
    return valueControl;
  }

  protected override void ChildSetControlValue(TComboItem value)
  {
    this._selectableValueModel.SelectedValue = ((IUniqueObject<TIdentifier>) (object) value).UniqueIdentifier;
  }

  protected override TComboItem GetControlValue()
  {
    return this._selectableValueModel.SelectedNamedValue as TComboItem;
  }
}
