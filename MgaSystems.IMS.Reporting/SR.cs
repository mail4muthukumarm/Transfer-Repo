// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.SR
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Reporting;

internal class SR
{
  private static ResourceManager _rm;
  private const string RESNAME = "MGASystems.IMS.Reporting.strings";

  private SR()
  {
  }

  private static ResourceManager ResMan
  {
    get
    {
      if (SR._rm == null)
        SR._rm = new ResourceManager("MGASystems.IMS.Reporting.strings", Assembly.GetExecutingAssembly());
      return SR._rm;
    }
  }

  public static string GetString(string id)
  {
    return SR.ResMan.GetString(id, Thread.CurrentThread.CurrentCulture);
  }

  public static string GetString(string id, params object[] args)
  {
    return string.Format((IFormatProvider) Thread.CurrentThread.CurrentCulture, SR.ResMan.GetString(id, Thread.CurrentThread.CurrentCulture), args);
  }

  public static string GetString(string id, object arg0)
  {
    return string.Format((IFormatProvider) Thread.CurrentThread.CurrentCulture, SR.ResMan.GetString(id, Thread.CurrentThread.CurrentCulture), RuntimeHelpers.GetObjectValue(arg0));
  }

  public static string GetString(string id, object arg0, object arg1)
  {
    return string.Format((IFormatProvider) Thread.CurrentThread.CurrentCulture, SR.ResMan.GetString(id, Thread.CurrentThread.CurrentCulture), RuntimeHelpers.GetObjectValue(arg0), RuntimeHelpers.GetObjectValue(arg1));
  }

  public static string GetString(string id, object arg0, object arg1, object arg2)
  {
    return string.Format((IFormatProvider) Thread.CurrentThread.CurrentCulture, SR.ResMan.GetString(id, Thread.CurrentThread.CurrentCulture), RuntimeHelpers.GetObjectValue(arg0), RuntimeHelpers.GetObjectValue(arg1), RuntimeHelpers.GetObjectValue(arg2));
  }
}
