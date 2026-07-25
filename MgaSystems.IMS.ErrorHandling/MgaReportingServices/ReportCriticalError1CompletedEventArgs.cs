// Decompiled with JetBrains decompiler
// Type: MGASystems.ErrorHandling.MgaReportingServices.ReportCriticalError1CompletedEventArgs
// Assembly: MgaSystems.IMS.ErrorHandling, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4686CAD5-B68D-4F03-A647-C480B9E54EB4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.ErrorHandling.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.ErrorHandling.MgaReportingServices;

[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "4.0.30319.17929")]
[DebuggerStepThrough]
public class ReportCriticalError1CompletedEventArgs : AsyncCompletedEventArgs
{
  private object[] results;

  internal ReportCriticalError1CompletedEventArgs(
    object[] results,
    Exception exception,
    bool cancelled,
    object userState)
    : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
  {
    this.results = results;
  }

  public bool Result
  {
    get
    {
      this.RaiseExceptionIfNecessary();
      return Conversions.ToBoolean(this.results[0]);
    }
  }
}
