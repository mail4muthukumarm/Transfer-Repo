// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.UserInterface.SelectSearchForm`3
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.UserInterface;

public abstract class SelectSearchForm<TDisplayItem, TController, TModel> : 
  ToolbarForm<TController, ISearchSelectView, TModel>
  where TController : class, ISearchSelectController<TDisplayItem>, ITopControlController
  where TModel : class, ISearchSelectModel<TDisplayItem>
{
  protected override ISearchSelectView CreateView() => (ISearchSelectView) new SearchSelectView();

  protected override TController CreateController() => this.ChildCreateController();

  protected override TModel CreateModel() => this.ChildCreateModel();

  protected abstract TController ChildCreateController();

  protected abstract TModel ChildCreateModel();

  protected override void InitializeListeners() => this.Controller.InitializeListeners();

  protected SelectSearchForm()
    : base()
  {
  }
}
