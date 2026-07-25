// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.SR
// Assembly: MgaSystems.IMS.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: A5FACEA8-628E-4FEB-97EB-CBBA0F666906
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Security.dll

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Security;

internal class SR
{
  private static ResourceManager _rm;
  private const string RESNAME = "MGASystems.IMS.Security.Strings";

  private SR()
  {
  }

  private static ResourceManager ResMan
  {
    get
    {
      if (SR._rm == null)
        SR._rm = new ResourceManager("MGASystems.IMS.Security.Strings", Assembly.GetExecutingAssembly());
      return SR._rm;
    }
  }

  public static string GetString(string id)
  {
    return SR.ResMan.GetString(id, Thread.CurrentThread.CurrentCulture);
  }

  public static string GetString(string id, object arg0, object arg1, object arg2)
  {
    return string.Format((IFormatProvider) Thread.CurrentThread.CurrentCulture, SR.ResMan.GetString(id, Thread.CurrentThread.CurrentCulture), RuntimeHelpers.GetObjectValue(arg0), RuntimeHelpers.GetObjectValue(arg1), RuntimeHelpers.GetObjectValue(arg2));
  }
}
