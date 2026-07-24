// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ThreadingFunctions.MessageBox
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.ErrorHandling;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.ThreadingFunctions;

[StandardModule]
public sealed class MessageBox
{
  public static void Show(
    string text,
    string caption,
    MessageBoxButtons buttons,
    MessageBoxIcon icon)
  {
    MessageBox.Show(text, caption, buttons, icon, MessageBoxDefaultButton.Button1);
  }

  public static void Show(
    string text,
    string caption,
    MessageBoxButtons buttons,
    MessageBoxIcon icon,
    MessageBoxDefaultButton defaultButton)
  {
    MDIControls instance = MDIControls.Instance;
    if ((instance != null ? (instance.BlackBoxMode ? 1 : 0) : 0) != 0)
      ErrorHandler.SilentHandleError(new Exception($"[BlackBox] ({caption}) {text}"));
    else if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new MessageBox.ShowHandler(MessageBox.Show), (object) text, (object) caption, (object) buttons, (object) icon, (object) defaultButton);
    }
    else
    {
      int num = (int) System.Windows.Forms.MessageBox.Show(text, caption, buttons, icon, defaultButton);
    }
  }

  public delegate void ShowHandler(
    string text,
    string caption,
    MessageBoxButtons buttons,
    MessageBoxIcon icon,
    MessageBoxDefaultButton defaultButton);
}
