// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.CheckBoxOption`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options;

[Obsolete]
public class CheckBoxOption<TDisplayItem>(
  string displayText,
  Func<TDisplayItem, bool> getValueFunc,
  Action<TDisplayItem, bool> setValueAction) : EditOptionStackOption<TDisplayItem, bool, CheckBox>(displayText, getValueFunc, setValueAction)
{
  protected override CheckBox ChildCreateValueControl()
  {
    CheckBox valueControl = new CheckBox();
    valueControl.Width = 21;
    valueControl.Height = 21;
    return valueControl;
  }

  protected override bool GetControlValue() => this.ValueControl.Checked;

  protected override void ChildSetControlValue(bool value) => this.ValueControl.Checked = value;
}
