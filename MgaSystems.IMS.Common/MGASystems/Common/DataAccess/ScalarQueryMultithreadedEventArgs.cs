// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.ScalarQueryMultithreadedEventArgs
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common.DataAccess;

public sealed class ScalarQueryMultithreadedEventArgs : KeyedThreadEventArgs
{
  private object _objResult;

  public ScalarQueryMultithreadedEventArgs(object result, object key)
    : base(RuntimeHelpers.GetObjectValue(key))
  {
    this._objResult = RuntimeHelpers.GetObjectValue(result);
  }

  public object Result => this._objResult;
}
