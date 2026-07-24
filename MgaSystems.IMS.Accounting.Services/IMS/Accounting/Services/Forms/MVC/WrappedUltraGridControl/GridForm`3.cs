// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.GridForm`3
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.View;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl;

public abstract class GridForm<TDisplayItem, TController, TModel> : 
  ToolbarForm<TController, IWrappedUltraGridView, TModel>
  where TController : class, IWrappedUltraGridController<TDisplayItem>, ITopControlController
  where TModel : class, IUltraGridDataModel<TDisplayItem>
{
  protected GridForm(TModel model, TController controller)
    : base(model, (IWrappedUltraGridView) new WrappedUltraGridView(), controller)
  {
  }

  protected GridForm()
    : base(view: (IWrappedUltraGridView) new WrappedUltraGridView())
  {
  }

  protected override void InitializeListeners() => this.Controller.InitializeListeners();
}
