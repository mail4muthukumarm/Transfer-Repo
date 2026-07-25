// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ValidateEventArgs
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Tools;

public sealed class ValidateEventArgs : EventArgs
{
  private bool _isValid;
  private object _value;

  public ValidateEventArgs(object value)
  {
    this._isValid = true;
    this._value = RuntimeHelpers.GetObjectValue(value);
  }

  public object Value => this._value;

  public bool IsValid
  {
    get => this._isValid;
    set => this._isValid = value;
  }
}
