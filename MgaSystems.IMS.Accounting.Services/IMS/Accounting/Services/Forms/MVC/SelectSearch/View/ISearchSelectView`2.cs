// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.View.ISearchSelectView`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.View;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.View;

public interface ISearchSelectView<TModel, TController> : 
  ISearchSelectView,
  IWrappedUltraGridView,
  IMvcView,
  IModelObserver,
  IWrappedUltraGridView<TModel, TController>,
  IMvcView<TModel, TController>,
  IModelObserver<TModel>
  where TModel : IMvcModel
  where TController : IMvcController
{
}
