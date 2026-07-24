// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses.DisplayOptionStackOption`3
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses;

[Obsolete]
public abstract class DisplayOptionStackOption<TDisplayItem, TDisplayField, TControl> : 
  NamedValueSackOptionSetting<TDisplayItem, TControl>
  where TControl : Control
{
  protected Func<TDisplayItem, TDisplayField> GetValueFunc { get; }

  protected DisplayOptionStackOption(
    string displayText,
    Func<TDisplayItem, TDisplayField> getValueFunc)
    : base(displayText)
  {
    this.GetValueFunc = getValueFunc ?? throw new ArgumentNullException(nameof (getValueFunc));
  }

  protected sealed override void ChildSetDisplayValue(TDisplayItem item)
  {
    this.ChildSetControlValue(this.GetValueFunc(item));
  }

  protected abstract void ChildSetControlValue(TDisplayField value);
}
