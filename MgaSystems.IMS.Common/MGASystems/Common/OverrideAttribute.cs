// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.OverrideAttribute
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;

#nullable disable
namespace MGASystems.Common;

[AttributeUsage(AttributeTargets.Class)]
public sealed class OverrideAttribute : Attribute
{
  private string _typeName;

  public OverrideAttribute(Type type)
  {
    this._typeName = (object) type != null ? type.FullName : throw new ArgumentNullException(nameof (type));
  }

  public OverrideAttribute(string typeName) => this._typeName = typeName;

  public string TypeNameToOverride => this._typeName;

  public override bool Match(object obj) => obj is OverrideAttribute;
}
