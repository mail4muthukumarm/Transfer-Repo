// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.GeocodeService.ReverseGeocodeCompletedEventArgs
// Assembly: MgaSystems.IMS.WebIntegration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 82DEE314-E11A-4163-B1B3-C42062AE6494
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.WebIntegration.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

#nullable disable
namespace MgaSystems.IMS.WebIntegration.GeocodeService;

[GeneratedCode("System.Web.Services", "4.7.2046.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class ReverseGeocodeCompletedEventArgs : AsyncCompletedEventArgs
{
  private object[] results;

  internal ReverseGeocodeCompletedEventArgs(
    object[] results,
    Exception exception,
    bool cancelled,
    object userState)
    : base(exception, cancelled, userState)
  {
    this.results = results;
  }

  public GeocodeResponse Result
  {
    get
    {
      this.RaiseExceptionIfNecessary();
      return (GeocodeResponse) this.results[0];
    }
  }
}
