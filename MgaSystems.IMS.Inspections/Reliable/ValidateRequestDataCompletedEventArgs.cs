// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.Reliable.ValidateRequestDataCompletedEventArgs
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.Reliable;

[GeneratedCode("System.Web.Services", "4.6.1586.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class ValidateRequestDataCompletedEventArgs : AsyncCompletedEventArgs
{
  private object[] results;

  internal ValidateRequestDataCompletedEventArgs(
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

  public string ErrorMessage
  {
    get
    {
      this.RaiseExceptionIfNecessary();
      return Conversions.ToString(this.results[1]);
    }
  }
}
