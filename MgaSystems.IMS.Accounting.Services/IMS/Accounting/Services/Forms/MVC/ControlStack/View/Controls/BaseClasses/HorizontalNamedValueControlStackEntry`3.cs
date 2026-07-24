// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.BaseClasses.HorizontalNamedValueControlStackEntry`3
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.StackEntry;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.BaseClasses;

public abstract class HorizontalNamedValueControlStackEntry<TDisplayItem, TDisplayField, TControl> : 
  NamedValueControlStackEntry<TDisplayItem, TDisplayField, TControl>
  where TControl : Control
{
  protected HorizontalNamedValueControlStackEntry(
    string displayText,
    int valueControlMaxWidth,
    Func<TDisplayItem, TDisplayField> getValueFromDisplayItemFunc,
    Action<TDisplayField> setDisplayItemValueAction)
    : base(displayText, valueControlMaxWidth, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
  }

  protected HorizontalNamedValueControlStackEntry(
    string uniqueIdentifier,
    string displayText,
    int valueControlMaxWidth,
    Func<TDisplayItem, TDisplayField> getValueFromDisplayItemFunc,
    Action<TDisplayField> setDisplayItemValueAction)
    : base(uniqueIdentifier, displayText, valueControlMaxWidth, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
  }

  protected override IStackEntryControl CreateControl()
  {
    return (IStackEntryControl) new HorizontalSplitStackEntryControl((Control) this.ValueControl, this.DisplayText, this.ValueControlMaxWidth);
  }
}
