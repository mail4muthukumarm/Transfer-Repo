// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ObjectInfoEventArgs
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common;

public sealed class ObjectInfoEventArgs : EventArgs
{
  private object _constructedObject;

  public ObjectInfoEventArgs(object newObject)
  {
    this._constructedObject = RuntimeHelpers.GetObjectValue(newObject);
  }

  public object ConstructedObject
  {
    get => this._constructedObject;
    set => this._constructedObject = RuntimeHelpers.GetObjectValue(value);
  }
}
