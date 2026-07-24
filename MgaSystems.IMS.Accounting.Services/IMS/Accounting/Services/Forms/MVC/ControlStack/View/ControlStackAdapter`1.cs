// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.ControlStackAdapter`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.BaseClasses;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View;

public class ControlStackAdapter<TDisplayItem> : 
  IControlStackAdapter<TDisplayItem>,
  IControlStackAdapter
{
  internal ControlStackAdapter(IControlStackEntry<TDisplayItem>[] controlAdapters)
  {
    this.Controls = controlAdapters;
  }

  public IControlStackEntry<TDisplayItem>[] Controls { get; }
}
