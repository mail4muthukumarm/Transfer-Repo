// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.TextBoxOption`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinEditors;
using MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses;
using MGASystems.Tools;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options;

[Obsolete]
public class TextBoxOption<TDisplayItem>(
  string displayText,
  Func<TDisplayItem, string> getValueFunc,
  Action<TDisplayItem, string> setValueAction) : 
  EditOptionStackOption<TDisplayItem, string, MGATextBox>(displayText, getValueFunc, setValueAction)
{
  protected override MGATextBox ChildCreateValueControl()
  {
    MGATextBox valueControl = new MGATextBox();
    ((Control) valueControl).Width = 167;
    ((Control) valueControl).Height = 20;
    valueControl.MGAStyle = MGAStyles.Blue;
    return valueControl;
  }

  protected override void ChildSetControlValue(string value)
  {
    ((TextEditorControlBase) this.ValueControl).Value = (object) value;
  }

  protected override string GetControlValue()
  {
    return ((TextEditorControlBase) this.ValueControl).Value as string;
  }
}
