// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAGridProps
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;

#nullable disable
namespace MGASystems.Tools;

[Flags]
public enum MGAGridProps
{
  None = 0,
  SetAppearances = 1,
  AutoColumnSizingOn = 2,
  AllowDeleting = 4,
  AllowUpdating = 8,
  RowSelect = 16, // 0x00000010
  HideRowSelectors = 32, // 0x00000020
  SetBorderStyle = 64, // 0x00000040
  Flat = 128, // 0x00000080
  All = Flat | SetBorderStyle | HideRowSelectors | RowSelect | AllowUpdating | AllowDeleting | AutoColumnSizingOn | SetAppearances, // 0x000000FF
}
