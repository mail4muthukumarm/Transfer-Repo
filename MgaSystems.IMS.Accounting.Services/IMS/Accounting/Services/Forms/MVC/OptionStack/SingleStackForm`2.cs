// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.SingleStackForm`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack;

[Obsolete]
public abstract class SingleStackForm<TDisplayItem, TController>(TController controller) : 
  ToolbarForm<TController, IOptionStackView, IOptionStackModel<TDisplayItem>>((IOptionStackModel<TDisplayItem>) new OptionStackModel<TDisplayItem>(), (IOptionStackView) controller.GetDisplayOptions().CreateView(), controller)
  where TController : class, IOptionStackController<TDisplayItem>
{
  public DialogResult DisplayFor(TDisplayItem displayItem, IWin32Window window)
  {
    this.Model.DisplayItem = displayItem;
    this.View.SetControlValues((object) displayItem);
    return this.ShowDialog(window);
  }
}
