// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Extensions.InvokeExtensions
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.ExceptionServices;

#nullable disable
namespace MGASystems.Common.Extensions;

public static class InvokeExtensions
{
  public static void BetterInvoke(this ISynchronizeInvoke control, Action action)
  {
    control.BetterInvoke<object>((Func<object>) (() =>
    {
      action();
      return (object) null;
    }));
  }

  public static object BetterInvoke(
    this ISynchronizeInvoke control,
    Delegate action,
    params object[] args)
  {
    return control.BetterInvoke<object>((Func<object>) (() => action.DynamicInvoke(args)));
  }

  public static T BetterInvoke<T>(this ISynchronizeInvoke control, Func<T> func)
  {
    Exception exception = (Exception) null;
    T obj = (T) control.Invoke((Delegate) (() =>
    {
      try
      {
        return func();
      }
      catch (TargetInvocationException ex)
      {
        exception = ex.InnerException ?? (Exception) ex;
        return default (T);
      }
      catch (Exception ex)
      {
        exception = ex;
        return default (T);
      }
    }), (object[]) null);
    if (exception == null)
      return obj;
    ExceptionDispatchInfo.Capture(exception).Throw();
    return obj;
  }
}
