// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyBusinessObjects.UnbindEventArgs
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using System;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyBusinessObjects;

public class UnbindEventArgs : EventArgs
{
  private bool _success;

  public bool Success
  {
    get => this._success;
    set => this._success = value;
  }
}
