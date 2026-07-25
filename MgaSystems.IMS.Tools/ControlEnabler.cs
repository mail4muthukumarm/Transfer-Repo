// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ControlEnabler
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
public sealed class ControlEnabler
{
  public static void EnableControl(
    Control control,
    Type mustBeType,
    bool enable,
    Control[] excludes)
  {
    if (control == null)
      throw new ArgumentNullException(nameof (control));
    if (excludes != null)
    {
      Control[] controlArray = excludes;
      int index = 0;
      while (index < controlArray.Length)
      {
        Control control1 = controlArray[index];
        if (control == control1)
          return;
        checked { ++index; }
      }
    }
    if ((object) mustBeType != null && !ControlEnabler.TypeSupports(control.GetType(), mustBeType))
      return;
    control.Enabled = enable;
    try
    {
      foreach (Control control2 in control.Controls)
        ControlEnabler.EnableControl(control2, mustBeType, enable, excludes);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public static void EnableControl(Control control, Type mustBeType, bool enable)
  {
    if (control == null)
      throw new ArgumentNullException(nameof (control));
    ControlEnabler.EnableControl(control, mustBeType, enable, (Control[]) null);
    try
    {
      foreach (Control control1 in control.Controls)
        ControlEnabler.EnableControl(control1, mustBeType, enable, (Control[]) null);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public static void EnableControl(Control control, bool enable)
  {
    ControlEnabler.EnableControl(control, (Type) null, enable);
  }

  public static void EnableControl(Control control, Control[] excludes, bool enable)
  {
    ControlEnabler.EnableControl(control, (Type) null, enable, excludes);
  }

  private static bool TypeSupports(Type derivedType, Type baseType)
  {
    return baseType.IsClass && derivedType.IsClass && (derivedType.IsSubclassOf(baseType) || derivedType.Equals(baseType)) || baseType.IsInterface && (object) derivedType.GetInterface(baseType.FullName) != null;
  }
}
