// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SecureHotkeyResourceAttribute
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.Common;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public sealed class SecureHotkeyResourceAttribute : SecureResourceAttribute
{
  public SecureHotkeyResourceAttribute(
    string uniqueIdentifier,
    string name,
    string description,
    string securityGroup)
    : base(uniqueIdentifier, name, description, securityGroup)
  {
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public SecureHotkeyResourceAttribute()
  {
  }
}
