// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.DateRangeOption`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.Utility;
using MGASystems.IMS.Accounting.Services.Forms.Controls;
using MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options;

[Obsolete]
public class DateRangeOption<TDisplayItem>(
  string displayText,
  Func<TDisplayItem, DateSpan> getValueFunc,
  Action<TDisplayItem, DateSpan> setValueAction) : 
  EditOptionStackOption<TDisplayItem, DateSpan, DateSpanPicker>(displayText, getValueFunc, setValueAction)
{
  protected override DateSpanPicker ChildCreateValueControl() => new DateSpanPicker();

  protected override void ChildSetControlValue(DateSpan value)
  {
    this.ValueControl.DateSpan = value;
  }

  protected override DateSpan GetControlValue() => this.ValueControl.DateSpan;
}
