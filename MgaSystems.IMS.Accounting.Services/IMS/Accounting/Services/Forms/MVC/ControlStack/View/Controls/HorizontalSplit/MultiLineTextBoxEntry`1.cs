// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.HorizontalSplit.MultiLineTextBoxEntry`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.MultiLineEdit;
using MGASystems.Tools;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.HorizontalSplit;

public class MultiLineTextBoxEntry<TDisplayItem> : SingleLineTextBoxEntry<TDisplayItem>
{
  public int Height { get; }

  public MultiLineTextBoxEntry(
    string displayText,
    int valueControlWidth,
    int height,
    Func<TDisplayItem, string> getValueFromDisplayItemFunc,
    Action<string> setDisplayItemValueAction)
    : base(displayText, valueControlWidth, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
    this.Height = height;
  }

  public MultiLineTextBoxEntry(
    string identifier,
    string displayText,
    int valueControlWidth,
    int height,
    Func<TDisplayItem, string> getValueFromDisplayItemFunc,
    Action<string> setDisplayItemValueAction)
    : base(identifier, displayText, valueControlWidth, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
    this.Height = height;
  }

  protected override MGATextBox ChildCreateValueControl()
  {
    MGATextBox valueControl = base.ChildCreateValueControl();
    valueControl.Multiline = true;
    ((Control) valueControl).Height = this.Height;
    ((Control) valueControl).Width = 200;
    ((Control) valueControl).ContextMenu = this.CreateContextMenu();
    return valueControl;
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
