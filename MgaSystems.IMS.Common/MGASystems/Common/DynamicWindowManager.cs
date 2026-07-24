// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DynamicWindowManager
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public class DynamicWindowManager
{
  public static Form CreateForm(string windowKey, object context)
  {
    return RuntimeHelpers.GetObjectValue(((Type.GetType("Mga.Wpf.Ims.Windows.DynamicWindowManager, Mga.Wpf.Ims") ?? throw new InvalidOperationException("Could not access dynamic window manager")).GetMethod(nameof (CreateForm)) ?? throw new InvalidOperationException("Could not access method CreateForm dynamic window manager")).Invoke((object) null, new object[2]
    {
      (object) windowKey,
      context
    })) as Form;
  }

  public static void Show(string windowKey, object context)
  {
    ((Type.GetType("Mga.Wpf.Ims.Windows.DynamicWindowManager, Mga.Wpf.Ims") ?? throw new InvalidOperationException("Could not access dynamic window manager")).GetMethod(nameof (Show)) ?? throw new InvalidOperationException("Could not access method CreateForm dynamic window manager")).Invoke((object) null, new object[2]
    {
      (object) windowKey,
      context
    });
  }
}
