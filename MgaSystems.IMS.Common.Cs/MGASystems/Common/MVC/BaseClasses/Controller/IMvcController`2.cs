// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.Controller.IMvcController`2
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.View;

#nullable disable
namespace MGASystems.Common.MVC.BaseClasses.Controller;

public interface IMvcController<TModel, TView> : IMvcController
  where TModel : IMvcModel
  where TView : IMvcView
{
  void WireUp(TModel model, TView view);
}
