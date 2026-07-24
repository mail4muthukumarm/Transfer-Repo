// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SR
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace MGASystems.Common;

internal class SR
{
  private static ResourceManager _rm;
  private const string RESNAME = "MGASystems.Common.Strings";

  private SR()
  {
  }

  private static ResourceManager ResMan
  {
    get
    {
      if (SR._rm == null)
        SR._rm = new ResourceManager("MGASystems.Common.Strings", Assembly.GetExecutingAssembly());
      return SR._rm;
    }
  }

  public static string GetString(string id)
  {
    return SR.ResMan.GetString(id, Thread.CurrentThread.CurrentCulture);
  }

  public static string GetString(string id, object arg0)
  {
    return string.Format((IFormatProvider) Thread.CurrentThread.CurrentCulture, SR.ResMan.GetString(id, Thread.CurrentThread.CurrentCulture), RuntimeHelpers.GetObjectValue(arg0), (object) "");
  }

  public static string GetString(string id, object arg0, object arg1)
  {
    return string.Format((IFormatProvider) Thread.CurrentThread.CurrentCulture, SR.ResMan.GetString(id, Thread.CurrentThread.CurrentCulture), RuntimeHelpers.GetObjectValue(arg0), RuntimeHelpers.GetObjectValue(arg1));
  }
}
