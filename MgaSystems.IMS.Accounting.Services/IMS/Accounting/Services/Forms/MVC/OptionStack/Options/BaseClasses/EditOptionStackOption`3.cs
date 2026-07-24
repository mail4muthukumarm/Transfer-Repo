// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses.EditOptionStackOption`3
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses;

[Obsolete]
public abstract class EditOptionStackOption<TDisplayItem, TDisplayField, TControl> : 
  DisplayOptionStackOption<TDisplayItem, TDisplayField, TControl>
  where TControl : Control
{
  protected Action<TDisplayItem, TDisplayField> SetValueAction { get; }

  protected EditOptionStackOption(
    string displayText,
    Func<TDisplayItem, TDisplayField> getValueFunc,
    Action<TDisplayItem, TDisplayField> setValueAction)
    : base(displayText, getValueFunc)
  {
    this.SetValueAction = setValueAction ?? throw new ArgumentNullException(nameof (setValueAction));
  }

  protected override void ChildUpdateDisplayItem(TDisplayItem displayItem)
  {
    TDisplayField controlValue = this.GetControlValue();
    this.SetValueAction(displayItem, controlValue);
  }

  protected abstract TDisplayField GetControlValue();
}
