// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Utilities.Debouncer
// Assembly: MgaSystems.IMS.Accounting.Utilities, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0980F864-5BDB-427E-98EE-09B90661DBB2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Utilities.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

#nullable disable
namespace MGASystems.IMS.Accounting.Utilities;

[StandardModule]
public sealed class Debouncer
{
  private static Dispatcher _dispatcher = Dispatcher.CurrentDispatcher;
  private static DispatcherTimer _timer;

  public static void Debounce(
    int interval,
    Action<object> action,
    object param = null,
    DispatcherPriority priority = DispatcherPriority.ApplicationIdle)
  {
    Debouncer._timer?.Stop();
    Debouncer._timer = (DispatcherTimer) null;
    Debouncer._timer = new DispatcherTimer(TimeSpan.FromMilliseconds((double) interval), priority, (EventHandler) ([SpecialName] (s, e) =>
    {
      if (Debouncer._timer == null)
        return;
      Debouncer._timer?.Stop();
      Debouncer._timer = (DispatcherTimer) null;
      action(RuntimeHelpers.GetObjectValue(param));
    }), Debouncer._dispatcher);
    Debouncer._timer.Start();
  }
}
