// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ControlTextHelper
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
public sealed class ControlTextHelper
{
  private static bool TypeSupports(Type derivedType, Type baseType)
  {
    return baseType.IsClass && derivedType.IsClass && (derivedType.IsSubclassOf(baseType) || derivedType.Equals(baseType)) || baseType.IsInterface && (object) derivedType.GetInterface(baseType.FullName) != null;
  }

  public static void SetControlText(Control control, string text, Type mustbeType)
  {
    if (control == null)
      throw new ArgumentNullException(nameof (control));
    if ((object) mustbeType != null && !ControlTextHelper.TypeSupports(control.GetType(), mustbeType))
      return;
    control.Text = text;
    try
    {
      foreach (Control control1 in control.Controls)
        ControlTextHelper.SetControlText(control1, text, mustbeType);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public static void SetControlTextExcludeParent(Control control, string text, Type mustbeType)
  {
    if (control == null)
      throw new ArgumentNullException(nameof (control));
    try
    {
      foreach (Control control1 in control.Controls)
        ControlTextHelper.SetControlText(control1, text, mustbeType);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
