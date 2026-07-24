// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ObjectInfo
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Diagnostics;

#nullable disable
namespace MGASystems.Common;

[DebuggerDisplay("Base: {BaseClass}, Object: {ObjectName}")]
[Serializable]
public sealed class ObjectInfo
{
  private string _objectName;
  private string _baseClass;
  private string _assemblyName;

  public ObjectInfo(string objectName, string baseClass, string assemblyName)
  {
    this._objectName = objectName;
    this._baseClass = baseClass;
    this._assemblyName = assemblyName;
  }

  public string AssemblyName
  {
    get => this._assemblyName;
    internal set => this._assemblyName = value;
  }

  public string BaseClass
  {
    set => this._baseClass = value;
    get => this._baseClass;
  }

  public string ObjectName
  {
    get => this._objectName;
    internal set => this._objectName = value;
  }
}
