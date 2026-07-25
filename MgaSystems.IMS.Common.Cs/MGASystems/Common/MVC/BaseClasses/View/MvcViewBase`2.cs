// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.View.MvcViewBase`2
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Data;
using System;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.MVC.BaseClasses.View;

public class MvcViewBase<TModel, TController> : 
  UserControl,
  IMvcView<TModel, TController>,
  IMvcView,
  IModelObserver,
  IModelObserver<TModel>
  where TModel : class, IMvcModel
  where TController : class, IMvcController
{
  private TModel _model;
  private TController _controller;
  private readonly BlockingRunner _userWaitForAction;
  private readonly BlockingRunner _suppressEventsForAction;
  private readonly BlockingRunner _runInUpdateMode;

  protected TModel Model
  {
    get
    {
      if (!this.IsWiredUp())
        throw new InvalidOperationException("Must be wired up to access the Model.");
      return this._model;
    }
  }

  protected TController Controller
  {
    get
    {
      if (!this.IsWiredUp())
        throw new InvalidOperationException("Must be wired up to access the Controller.");
      return this._controller;
    }
  }

  IWin32Window IMvcView.ParentForm => (IWin32Window) this.ParentForm;

  public MvcViewBase()
  {
    this._userWaitForAction = new BlockingRunner()
    {
      ExitStateAction = (Action) (() => this.Cursor = Cursors.Default),
      RunAction = (Action<Action>) (action =>
      {
        this.Cursor = MgaCursors.WaitCursor;
        Thread thread = new Thread((ThreadStart) (() => action()));
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        thread.Join();
      })
    };
    this._suppressEventsForAction = new BlockingRunner();
    this._runInUpdateMode = new BlockingRunner()
    {
      EnterStateAction = new Action(this.EnterUpdateMode),
      ExitStateAction = new Action(this.ExitUpdateMode)
    };
  }

  protected virtual void ChildUpdateFromModel(TModel model)
  {
  }

  public virtual void Update(object model)
  {
    if (!(model is TModel model1))
      throw new ArgumentException("Cannot set model to someting other than " + typeof (TModel).Name);
    this.Update(model1);
  }

  public void Update(TModel model)
  {
    if ((object) model == null)
      throw new ArgumentNullException(nameof (model));
    if (!this.IsWiredUp())
      throw new InvalidOperationException("Must be wired up inorder to update.");
    this.SuppressEventsForAction((Action) (() => this.ChildUpdateFromModel(model)));
  }

  protected virtual void ChildWireUp()
  {
  }

  public void WireUp(IMvcController controller, IMvcModel model)
  {
    if (controller is TController controller1 && model is TModel model1)
      this.WireUp(controller1, model1);
    else
      throw new ArgumentException($"Controller must be of type {typeof (TController).Name} and Model must be of type {typeof (TModel).Name}.");
  }

  public bool IsWiredUp() => (object) this._controller != null && (object) this._model != null;

  public void WireUp(TController controller, TModel model)
  {
    if (this.IsWiredUp())
      throw new InvalidOperationException("Cannot wire up view if it alread is.");
    this.SuppressEventsForAction((Action) (() =>
    {
      this._model = model ?? throw new ArgumentNullException(nameof (model));
      this._model.AddObserver((IModelObserver) this);
      this._controller = controller ?? throw new ArgumentNullException(nameof (controller));
      this._controller.WireUp((object) model, (object) this);
      this.ChildWireUp();
      this.Invoke((Delegate) (() => this.Update(model)));
    }));
  }

  public virtual void UnWireUp()
  {
    if (!this.IsWiredUp())
      throw new InvalidOperationException("Cannot un-wire up view if it isn't wired up.");
    this.SuppressEventsForAction((Action) (() =>
    {
      this._model.RemoveObserver((IModelObserver) this);
      this._model = default (TModel);
      this._controller.UnWireUp();
      this._controller = default (TController);
      this.ChildUnWireUp();
    }));
  }

  protected virtual void ChildUnWireUp()
  {
  }

  protected void InvokeIfNotSuppressed(Action userInitiatedAction)
  {
    if (userInitiatedAction == null)
      throw new ArgumentNullException(nameof (userInitiatedAction));
    if (this._suppressEventsForAction.IsRunning || (object) this._controller == null)
      return;
    userInitiatedAction();
  }

  protected void SuppressEventsForAction(Action action)
  {
    this._suppressEventsForAction.Run(action);
  }

  protected virtual void EnterUpdateMode()
  {
  }

  protected virtual void ExitUpdateMode()
  {
  }

  public void RunInUpdateMode(Action action)
  {
    if (!this.IsWiredUp())
      throw new InvalidOperationException("Must be wired up inorder to run in update mode.");
    this._runInUpdateMode.Run(action);
  }

  public void DisplayOkMessageBox(string message, string title, MessageBoxIcon icon = MessageBoxIcon.Asterisk)
  {
    if (message == null)
      throw new ArgumentNullException(nameof (message));
    if (title == null)
      throw new ArgumentNullException(nameof (title));
    if (string.IsNullOrWhiteSpace(message))
      throw new ArgumentException("Cannot display Info Message Box with an empty message.");
    if (string.IsNullOrWhiteSpace(title))
      throw new ArgumentException("Cannot display Info Message Box with an empty title.");
    int num = (int) MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
  }

  public void InvokeIfUserConfirms(string message, string title, Action onConfirm)
  {
    if (onConfirm == null)
      throw new ArgumentNullException(nameof (onConfirm));
    if (!this.DisplayYesNo(message, title))
      return;
    onConfirm();
  }

  public bool DisplayYesNo(string message, string title)
  {
    if (message == null)
      throw new ArgumentNullException(nameof (message));
    if (title == null)
      throw new ArgumentNullException(nameof (title));
    if (string.IsNullOrWhiteSpace(message))
      throw new ArgumentException("Cannot display Yes/No Message Box with an empty message.");
    if (string.IsNullOrWhiteSpace(title))
      throw new ArgumentException("Cannot display Yes/No Message Box with an empty title.");
    return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
  }

  public void SetFocus()
  {
    if (!this.IsWiredUp())
      throw new InvalidOperationException("Must be wired up in order to set focus.");
    this.ChildSetFocus();
  }

  protected virtual void ChildSetFocus()
  {
  }

  public void UnSetFocus() => this.ActiveControl = (Control) null;

  public void MakeUserWaitForAction(Action waitOnAction)
  {
    if (!this.IsWiredUp())
      throw new InvalidOperationException("Must be wired up inorder to make user wait on action.");
    this._userWaitForAction.Run(waitOnAction);
  }

  public event Action<IMvcView, DialogResult> RequestClose;

  public void RequestCloseForm(DialogResult result)
  {
    Action<IMvcView, DialogResult> requestClose = this.RequestClose;
    if (requestClose == null)
      return;
    requestClose((IMvcView) this, result);
  }
}
