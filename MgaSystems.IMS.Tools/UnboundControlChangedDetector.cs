// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.UnboundControlChangedDetector
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[Obsolete("There should not be a need for this class anymore.")]
public sealed class UnboundControlChangedDetector
{
  private Dictionary<Control, object> _controlList;

  public UnboundControlChangedDetector(Form form)
  {
    this._controlList = new Dictionary<Control, object>();
    this.ReInitalize(form);
  }

  public void ReInitalize(Form form)
  {
    this._controlList.Clear();
    this.LoadControls(form.Controls);
  }

  [SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
  private void LoadControls(Control.ControlCollection controls)
  {
    try
    {
      foreach (Control control in controls)
      {
        object obj;
        switch (control)
        {
          case DateTimePicker _:
            obj = (object) ((DateTimePicker) control).Value;
            break;
          case ComboBox _:
            obj = RuntimeHelpers.GetObjectValue(((ListControl) control).SelectedValue);
            break;
          case UltraCombo _:
            obj = RuntimeHelpers.GetObjectValue(((UltraCombo) control).Value);
            break;
          default:
            obj = (object) control.Text;
            break;
        }
        this._controlList.Add(control, RuntimeHelpers.GetObjectValue(obj));
        this.LoadControls(control.Controls);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public bool HasChanges(Form form)
  {
    return form != null ? this.VerifyControls(form.Controls) : throw new ArgumentNullException(nameof (form));
  }

  [SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
  private bool VerifyControls(Control.ControlCollection controls)
  {
    bool flag;
    try
    {
      foreach (Control control in controls)
      {
        object objectValue = RuntimeHelpers.GetObjectValue(this._controlList[control]);
        if (objectValue != null)
        {
          object obj;
          switch (control)
          {
            case DateTimePicker _:
              obj = (object) ((DateTimePicker) control).Value;
              break;
            case ComboBox _:
              obj = RuntimeHelpers.GetObjectValue(((ListControl) control).SelectedValue);
              break;
            case UltraCombo _:
              obj = RuntimeHelpers.GetObjectValue(((UltraCombo) control).Value);
              break;
            default:
              obj = (object) control.Text;
              break;
          }
          if (!objectValue.Equals(RuntimeHelpers.GetObjectValue(obj)))
          {
            flag = true;
            goto label_16;
          }
          if (this.VerifyControls(control.Controls))
          {
            flag = true;
            goto label_16;
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    flag = false;
label_16:
    return flag;
  }
}
