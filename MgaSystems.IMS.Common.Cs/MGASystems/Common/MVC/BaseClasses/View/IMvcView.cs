// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.View.IMvcView
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.MVC.BaseClasses.View;

public interface IMvcView : IModelObserver
{
  IWin32Window ParentForm { get; }

  void DisplayOkMessageBox(string message, string title, MessageBoxIcon icon = MessageBoxIcon.Asterisk);

  bool DisplayYesNo(string message, string title);

  void InvokeIfUserConfirms(string message, string title, Action onConfirm);

  void WireUp(IMvcController controller, IMvcModel model);

  void UnWireUp();

  bool IsWiredUp();

  void SetFocus();

  void UnSetFocus();

  void MakeUserWaitForAction(Action action);

  void RunInUpdateMode(Action action);

  event Action<IMvcView, DialogResult> RequestClose;

  void RequestCloseForm(DialogResult result);
}
