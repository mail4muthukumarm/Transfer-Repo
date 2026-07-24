// Decompiled with JetBrains decompiler
// Type: CancellationNotices.DocumentFunctions.GetFolderListCompletedEventArgs
// Assembly: MgaSystems.IMS.CancellationNotices, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 212B4515-7BA8-45EF-B7D5-4974627BD234
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.CancellationNotices.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace CancellationNotices.DocumentFunctions;

[GeneratedCode("System.Web.Services", "4.7.2556.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class GetFolderListCompletedEventArgs : AsyncCompletedEventArgs
{
  private object[] results;

  internal GetFolderListCompletedEventArgs(
    object[] results,
    Exception exception,
    bool cancelled,
    object userState)
    : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
  {
    this.results = results;
  }

  public DataSet Result
  {
    get
    {
      this.RaiseExceptionIfNecessary();
      return (DataSet) this.results[0];
    }
  }
}
