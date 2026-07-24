// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.MGAWebServicesLogon.GetUserInfoCompletedEventArgs
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects.MGAWebServicesLogon;

[GeneratedCode("System.Web.Services", "4.7.2053.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class GetUserInfoCompletedEventArgs : AsyncCompletedEventArgs
{
  private object[] results;

  internal GetUserInfoCompletedEventArgs(
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
