// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ComboBoxBindingFix
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[StandardModule]
[Obsolete("We should no longer be using Combobox's.  They are replaced with MgaComboBox's.")]
public sealed class ComboBoxBindingFix
{
  public static void ResetCombo(ComboBox combo)
  {
    if (combo == null)
      throw new ArgumentNullException(nameof (combo));
    combo.SelectedIndex = -1;
    combo.SelectedIndex = -1;
  }

  public static void ResetCombo(Control containerControl)
  {
    if (containerControl == null)
      throw new ArgumentNullException(nameof (containerControl));
    if (containerControl is ComboBox)
      ComboBoxBindingFix.ResetCombo(containerControl);
    try
    {
      foreach (Control control in containerControl.Controls)
        ComboBoxBindingFix.ResetCombo(control);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
