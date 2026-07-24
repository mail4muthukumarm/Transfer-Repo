// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.FullWidth.FullWidthMultiLineTextBox`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinEditors;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.BaseClasses;
using MGASystems.IMS.Accounting.Services.Forms.MVC.MultiLineEdit;
using MGASystems.Tools;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.FullWidth;

public class FullWidthMultiLineTextBox<TDisplayItem> : 
  FullWidthNamedValueControlStackEntry<TDisplayItem, string, MGATextBox>
{
  public FullWidthMultiLineTextBox(
    string displayText,
    int valueControlMaxWidth,
    int valueControlHeight,
    Func<TDisplayItem, string> getValueFromDisplayItemFunc,
    Action<string> setDisplayItemValueAction,
    bool alignTextWithHorizontalControls = true)
    : base(displayText, valueControlMaxWidth, valueControlHeight, alignTextWithHorizontalControls, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
  }

  public FullWidthMultiLineTextBox(
    string uniqueIdentifier,
    string displayText,
    int valueControlMaxWidth,
    int valueControlHeight,
    bool alignTextWithHorizontalControls,
    Func<TDisplayItem, string> getValueFromDisplayItemFunc,
    Action<string> setDisplayItemValueAction)
    : base(uniqueIdentifier, displayText, valueControlMaxWidth, valueControlHeight, alignTextWithHorizontalControls, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
  }

  protected override void ChildSetControlValue(string value)
  {
    ((TextEditorControlBase) this.ValueControl).Value = (object) value;
  }

  protected override string GetControlValue()
  {
    return ((TextEditorControlBase) this.ValueControl).Value as string;
  }

  protected override MGATextBox ChildCreateValueControl()
  {
    MGATextBox valueControl = new MGATextBox();
    ((Control) valueControl).Width = 167;
    ((Control) valueControl).Height = 30;
    valueControl.MGAStyle = MGAStyles.Blue;
    valueControl.Multiline = true;
    ((Control) valueControl).ContextMenu = this.CreateContextMenu();
    return valueControl;
  }

  protected override void SetUpValueChangedEvent(
    MGATextBox valueControl,
    EventHandler onValueChanged)
  {
    ((Control) valueControl).TextChanged += onValueChanged;
  }

  private ContextMenu CreateContextMenu()
  {
    ContextMenu contextMenu = new ContextMenu();
    MenuItem menuItem = new MenuItem("Open in Large Editor");
    menuItem.Click += new EventHandler(this.OpenInEditorOption_Click);
    contextMenu.MenuItems.Add(menuItem);
    return contextMenu;
  }

  private void OpenInEditorOption_Click(object sender, EventArgs e)
  {
    int num = (int) new MultiLineTextEditForm((Func<string>) (() => ((Control) this.ValueControl).Text), (Action<string>) (s => ((Control) this.ValueControl).Text = s), 600, 600, this.DisplayText + " Edit").ShowDialog((IWin32Window) ((Control) this.ValueControl).FindForm());
  }
}
