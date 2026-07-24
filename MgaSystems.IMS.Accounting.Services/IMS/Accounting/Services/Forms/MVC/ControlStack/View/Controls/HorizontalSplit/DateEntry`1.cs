// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.HorizontalSplit.DateEntry`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.BaseClasses;
using MGASystems.Tools;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.HorizontalSplit;

public class DateEntry<TDisplayItem> : 
  HorizontalNamedValueControlStackEntry<TDisplayItem, DateTime?, MGADateTimePicker>
{
  public DateEntry(
    string displayText,
    int valueControlWidth,
    Func<TDisplayItem, DateTime?> getValueFromDisplayItemFunc,
    Action<DateTime?> setDisplayItemValueAction)
    : base(displayText, valueControlWidth, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
  }

  public DateEntry(
    string uniqueIdentifier,
    string displayText,
    int valueControlMaxWidth,
    Func<TDisplayItem, DateTime?> getValueFromDisplayItemFunc,
    Action<DateTime?> setDisplayItemValueAction)
    : base(uniqueIdentifier, displayText, valueControlMaxWidth, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
  }

  protected override MGADateTimePicker ChildCreateValueControl()
  {
    MGADateTimePicker valueControl = new MGADateTimePicker();
    valueControl.MGAStyle = MGAStyles.Blue;
    ((Control) valueControl).Width = 100;
    ((Control) valueControl).Height = 21;
    return valueControl;
  }

  protected override void ChildSetControlValue(DateTime? displayField)
  {
    this.ValueControl.Value = (object) displayField;
  }

  protected override DateTime? GetControlValue() => new DateTime?(this.ValueControl.DateTime);

  protected override void SetUpValueChangedEvent(
    MGADateTimePicker valueControl,
    EventHandler onValueChanged)
  {
    valueControl.ValueChanged += onValueChanged;
  }
}
