// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.DateOption`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses;
using MGASystems.Tools;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options;

[Obsolete]
public class DateOption<TDisplayItem>(
  string displayText,
  Func<TDisplayItem, DateTime> getValueFunc,
  Action<TDisplayItem, DateTime> setValueAction) : 
  EditOptionStackOption<TDisplayItem, DateTime, MGADateTimePicker>(displayText, getValueFunc, setValueAction)
{
  protected override MGADateTimePicker ChildCreateValueControl()
  {
    MGADateTimePicker valueControl = new MGADateTimePicker();
    valueControl.MGAStyle = MGAStyles.Blue;
    ((Control) valueControl).Width = 100;
    ((Control) valueControl).Height = 21;
    return valueControl;
  }

  protected override void ChildSetControlValue(DateTime displayField)
  {
    this.ValueControl.DateTime = displayField;
  }

  protected override DateTime GetControlValue() => this.ValueControl.DateTime;
}
