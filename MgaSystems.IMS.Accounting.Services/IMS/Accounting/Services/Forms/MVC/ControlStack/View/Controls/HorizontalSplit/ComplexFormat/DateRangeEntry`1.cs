// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.HorizontalSplit.ComplexFormat.DateRangeEntry`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.Utility;
using MGASystems.IMS.Accounting.Services.Forms.Controls;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.BaseClasses;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.HorizontalSplit.ComplexFormat;

public class DateRangeEntry<TDisplayItem> : 
  HorizontalNamedValueControlStackEntry<TDisplayItem, DateSpan, DateSpanPicker>
{
  public DateRangeEntry(
    string displayText,
    int valueControlWidth,
    Func<TDisplayItem, DateSpan> getValueFromDisplayItemFunc,
    Action<DateSpan> setDisplayItemValueAction)
    : base(displayText, valueControlWidth, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
  }

  public DateRangeEntry(
    string identifier,
    string displayText,
    int valueControlWidth,
    Func<TDisplayItem, DateSpan> getValueFromDisplayItemFunc,
    Action<DateSpan> setDisplayItemValueAction)
    : base(identifier, displayText, valueControlWidth, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
  }

  protected override DateSpanPicker ChildCreateValueControl() => new DateSpanPicker();

  protected override void ChildSetControlValue(DateSpan value)
  {
    this.ValueControl.DateSpan = value;
  }

  protected override DateSpan GetControlValue() => this.ValueControl.DateSpan;

  protected override void SetUpValueChangedEvent(
    DateSpanPicker valueControl,
    EventHandler onValueChanged)
  {
    valueControl.ValueChanged += onValueChanged;
  }
}
