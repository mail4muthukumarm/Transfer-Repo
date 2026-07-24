// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.adrconnect.SendOrdersCompletedEventArgs
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common.adrconnect;

[GeneratedCode("System.Web.Services", "4.6.1586.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class SendOrdersCompletedEventArgs : AsyncCompletedEventArgs
{
  private object[] results;

  internal SendOrdersCompletedEventArgs(
    object[] results,
    Exception exception,
    bool cancelled,
    object userState)
    : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
  {
    this.results = results;
  }

  public SendOrdersResponseEntity Result
  {
    get
    {
      this.RaiseExceptionIfNecessary();
      return (SendOrdersResponseEntity) this.results[0];
    }
  }
}
