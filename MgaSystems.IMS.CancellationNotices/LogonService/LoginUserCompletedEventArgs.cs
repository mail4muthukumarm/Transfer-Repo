// Decompiled with JetBrains decompiler
// Type: CancellationNotices.LogonService.LoginUserCompletedEventArgs
// Assembly: MgaSystems.IMS.CancellationNotices, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 212B4515-7BA8-45EF-B7D5-4974627BD234
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.CancellationNotices.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace CancellationNotices.LogonService;

[GeneratedCode("System.Web.Services", "4.7.2556.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class LoginUserCompletedEventArgs : AsyncCompletedEventArgs
{
  private object[] results;

  internal LoginUserCompletedEventArgs(
    object[] results,
    Exception exception,
    bool cancelled,
    object userState)
    : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
  {
    this.results = results;
  }

  public Guid Result
  {
    get
    {
      this.RaiseExceptionIfNecessary();
      object result = this.results[0];
      return result == null ? new Guid() : (Guid) result;
    }
  }
}
