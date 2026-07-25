// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.InstallmentBilling.TaggedEventArgs
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies.InstallmentBilling;

public sealed class TaggedEventArgs : EventArgs
{
  private object _tag;

  public TaggedEventArgs(object tag) => this._tag = RuntimeHelpers.GetObjectValue(tag);

  public object Tag
  {
    get => this._tag;
    set => this._tag = RuntimeHelpers.GetObjectValue(value);
  }
}
