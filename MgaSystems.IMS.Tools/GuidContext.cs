// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.GuidContext
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.Tools;

[SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
[Flags]
public enum GuidContext
{
  Group = 0,
  Permission = 1,
  User = 2,
  Note = User | Permission, // 0x00000003
  None = 4,
}
