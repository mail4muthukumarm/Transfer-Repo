// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.UpdateServices.GetAvailableUpdatesCompletedEventArgs
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

#nullable disable
namespace MGASystems.Common.UpdateServices;

[GeneratedCode("System.Web.Services", "4.8.9032.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class GetAvailableUpdatesCompletedEventArgs : AsyncCompletedEventArgs
{
  private object[] results;

  internal GetAvailableUpdatesCompletedEventArgs(
    object[] results,
    Exception exception,
    bool cancelled,
    object userState)
    : base(exception, cancelled, userState)
  {
    this.results = results;
  }

  public FileInformation[] Result
  {
    get
    {
      this.RaiseExceptionIfNecessary();
      return (FileInformation[]) this.results[0];
    }
  }
}
