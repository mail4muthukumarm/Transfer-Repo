// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.HorizontalSplit.CheckBoxEntry`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.BaseClasses;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.HorizontalSplit;

public class CheckBoxEntry<TDisplayItem> : 
  HorizontalNamedValueControlStackEntry<TDisplayItem, bool, CheckBox>
{
  private static readonly int _checkboxSize = 13;

  public CheckBoxEntry(
    string displayText,
    Func<TDisplayItem, bool> getValueFromDisplayItemFunc,
    Action<bool> setDisplayItemValueAction)
    : base(displayText, CheckBoxEntry<TDisplayItem>._checkboxSize, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
  }

  public CheckBoxEntry(
    string identifier,
    string displayText,
    Func<TDisplayItem, bool> getValueFromDisplayItemFunc,
    Action<bool> setDisplayItemValueAction)
    : base(identifier, displayText, CheckBoxEntry<TDisplayItem>._checkboxSize, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
  }

  protected override CheckBox ChildCreateValueControl()
  {
    CheckBox valueControl = new CheckBox();
    valueControl.Width = CheckBoxEntry<TDisplayItem>._checkboxSize;
    valueControl.Height = CheckBoxEntry<TDisplayItem>._checkboxSize;
    return valueControl;
  }

  protected override bool GetControlValue() => this.ValueControl.Checked;

  protected override void ChildSetControlValue(bool value) => this.ValueControl.Checked = value;

  protected override void SetUpValueChangedEvent(CheckBox valueControl, EventHandler onValueChanged)
  {
    valueControl.CheckedChanged += onValueChanged;
  }
}
