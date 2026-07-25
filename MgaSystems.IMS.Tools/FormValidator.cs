// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.FormValidator
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[StandardModule]
public sealed class FormValidator
{
  [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
  public static bool ValidateForm(Form form)
  {
    bool cancel = false;
    FormValidator.ValidateControl((Control) form, ref cancel);
    return !cancel;
  }

  public static bool ValidateControl(Control control)
  {
    bool cancel = false;
    FormValidator.ValidateControl(control, ref cancel);
    return !cancel;
  }

  public static void ValidateControl(Control control, ref bool cancel)
  {
    if (control == null)
      throw new ArgumentNullException(nameof (control));
    CancelEventArgs cancelEventArgs = new CancelEventArgs();
    object[] parameters = new object[1]
    {
      (object) cancelEventArgs
    };
    control.GetType().GetMethod("OnValidating", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Invoke((object) control, parameters);
    if (!cancel && cancelEventArgs.Cancel)
      cancel = true;
    try
    {
      foreach (Control control1 in control.Controls)
        FormValidator.ValidateControl(control1, ref cancel);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
