// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.HorizontalSplit.ComplexFormat.SearchClearField.SearchClearFieldEntry`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.BaseClasses;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.HorizontalSplit.ComplexFormat.SearchClearField;

public class SearchClearFieldEntry<TDisplayItem, TField> : 
  HorizontalNamedValueControlStackEntry<TDisplayItem, TField, SearchClearFieldControl>
{
  private readonly Func<TField, string> _getDisplayValueForField;
  private readonly Func<TField, TField> _searchFunc;

  public SearchClearFieldEntry(
    string displayText,
    int valueControlMaxWidth,
    Func<TDisplayItem, TField> getValueFromDisplayItemFunc,
    Action<TField> setDisplayItemValueAction,
    Func<TField, string> getDisplayValueForField,
    Func<TField, TField> searchFunc)
    : base(displayText, valueControlMaxWidth, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
    this._getDisplayValueForField = getDisplayValueForField ?? throw new ArgumentNullException(nameof (getDisplayValueForField));
    this._searchFunc = searchFunc ?? throw new ArgumentNullException(nameof (searchFunc));
  }

  public SearchClearFieldEntry(
    string uniqueIdentifier,
    string displayText,
    int valueControlMaxWidth,
    Func<TDisplayItem, TField> getValueFromDisplayItemFunc,
    Action<TField> setDisplayItemValueAction,
    Func<TField, string> getDisplayValueForField,
    Func<TField, TField> searchFunc)
    : base(uniqueIdentifier, displayText, valueControlMaxWidth, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
    this._getDisplayValueForField = getDisplayValueForField ?? throw new ArgumentNullException(nameof (getDisplayValueForField));
    this._searchFunc = searchFunc ?? throw new ArgumentNullException(nameof (searchFunc));
  }

  protected override SearchClearFieldControl ChildCreateValueControl()
  {
    return new SearchClearFieldControl()
    {
      GetDisplayTextFromValue = (Func<object, string>) (o => this._getDisplayValueForField((TField) o)),
      SearchAction = (Func<object, object>) (o => (object) this._searchFunc((TField) o))
    };
  }

  protected override void ChildSetControlValue(TField value)
  {
    this.ValueControl.SetValue((object) value);
  }

  protected override TField GetControlValue() => (TField) this.ValueControl.Value;

  protected override void SetUpValueChangedEvent(
    SearchClearFieldControl valueControl,
    EventHandler onValueChanged)
  {
    valueControl.FieldValueChanged += onValueChanged;
  }
}
