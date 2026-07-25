// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.Controller.MvcControllerBase`2
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.View;
using System;

#nullable disable
namespace MGASystems.Common.MVC.BaseClasses.Controller;

public abstract class MvcControllerBase<TModel, TView> : 
  IMvcController<TModel, TView>,
  IMvcController
  where TModel : class, IMvcModel
  where TView : class, IMvcView
{
  private TModel _model;
  private TView _view;

  protected TModel Model
  {
    get
    {
      if (!this.IsWiredUp())
        throw new InvalidOperationException("Must be wired up to access the Model.");
      return this._model;
    }
  }

  protected TView View
  {
    get
    {
      if (!this.IsWiredUp())
        throw new InvalidOperationException("Must be wired up to access the View.");
      return this._view;
    }
  }

  public void WireUp(TModel model, TView view)
  {
    if (this.IsWiredUp())
      throw new InvalidOperationException("Cannot wire up controller if it alread is.");
    this._model = model ?? throw new ArgumentNullException(nameof (model));
    this._view = view ?? throw new ArgumentNullException(nameof (view));
    this.ChildWireUp();
  }

  public void WireUp(object model, object view) => this.WireUp((TModel) model, (TView) view);

  public void UnWireUp()
  {
    if (!this.IsWiredUp())
      throw new InvalidOperationException("Cannot un-wire up controller if it isn't wired up.");
    this.ChildUnWireUp();
    this._model = default (TModel);
    this._view = default (TView);
  }

  public bool IsWiredUp() => (object) this._model != null && (object) this._view != null;

  public void SetViewFocus() => this.View.SetFocus();

  public void UnSetViewFocus() => this.View.UnSetFocus();

  protected virtual void ChildWireUp()
  {
  }

  protected virtual void ChildUnWireUp()
  {
  }
}
