// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.ControlStackSettings`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.BaseClasses;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.StackEntry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View;

public class ControlStackSettings<TDisplayItem> : 
  IControlStackSettings<TDisplayItem>,
  IControlStackSettings
{
  public IControlStackEntry<TDisplayItem>[] ControlSettings { get; }

  public ControlStackSettings(IControlStackEntry<TDisplayItem>[] settings)
  {
    this.ControlSettings = settings ?? throw new ArgumentNullException(nameof (settings));
  }

  public IControlStackAdapter<TDisplayItem> ApplyToFlowLayout(FlowLayoutPanel controlFlow)
  {
    TabOrderTracker tabOrderTracker = new TabOrderTracker();
    foreach (Control control in ((IEnumerable<IControlStackEntry<TDisplayItem>>) this.ControlSettings).Select<IControlStackEntry<TDisplayItem>, IStackEntryControl>((Func<IControlStackEntry<TDisplayItem>, IStackEntryControl>) (setting => setting.CreatedControl)).ToArray<IStackEntryControl>())
    {
      controlFlow.Controls.Add(control);
      tabOrderTracker.AssignNextTabIndexToControl(control);
    }
    return (IControlStackAdapter<TDisplayItem>) new ControlStackAdapter<TDisplayItem>(this.ControlSettings);
  }
}
