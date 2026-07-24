// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.TabOrderTracker
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.View;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View;

public class TabOrderTracker
{
  public virtual int NextTabIndex { get; private set; }

  public TabOrderTracker(int startingIndex = 0)
  {
    this.NextTabIndex = startingIndex >= 0 ? startingIndex : throw new ArgumentException("startingTab must be >= 0.");
  }

  public virtual void AssignNextTabIndexToControl(Control control)
  {
    control.TabStop = true;
    control.TabIndex = this.NextTabIndex++;
  }

  public virtual void AssignNextTabIndexToControl(IMvcView view)
  {
    this.AssignNextTabIndexToControl((Control) view);
  }
}
