// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.MGAWebServicesLogon.GetEntityDetailsCompletedEventArgs
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects.MGAWebServicesLogon;

[GeneratedCode("System.Web.Services", "4.7.2053.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class GetEntityDetailsCompletedEventArgs : AsyncCompletedEventArgs
{
  private object[] results;

  internal GetEntityDetailsCompletedEventArgs(
    object[] results,
    Exception exception,
    bool cancelled,
    object userState)
    : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
  {
    this.results = results;
  }

  public DataTable Result
  {
    get
    {
      this.RaiseExceptionIfNecessary();
      return (DataTable) this.results[0];
    }
  }
}
