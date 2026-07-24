// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Forms.SingleStackForm`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Forms;

public abstract class SingleStackForm<TDisplayItem, TController>(TController controller) : 
  ToolbarForm<TController, IControlStackView, IControlStackObjectAdapterModel<TDisplayItem>>(controller: controller)
  where TDisplayItem : class
  where TController : class, IControlStackController<IControlStackObjectAdapterModel<TDisplayItem>>, ITopControlController
{
  protected virtual Action<TDisplayItem> SaveAction => (Action<TDisplayItem>) (_ => { });

  protected virtual Action<TDisplayItem> ResetAction { get; } = (Action<TDisplayItem>) (_ => { });

  protected abstract TDisplayItem GetDisplayItem();

  protected override IControlStackObjectAdapterModel<TDisplayItem> CreateModel()
  {
    return (IControlStackObjectAdapterModel<TDisplayItem>) new ControlStackObjectAdapterModel<TDisplayItem>(new Func<TDisplayItem>(this.GetDisplayItem), this.SaveAction, this.ResetAction);
  }

  protected override IControlStackView CreateView() => (IControlStackView) new ControlStackView();

  protected override void ChildBeforeLoad()
  {
    base.ChildBeforeLoad();
    this.Controller.FormatControls();
  }
}
