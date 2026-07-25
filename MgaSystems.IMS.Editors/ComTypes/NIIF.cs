// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.NIIF
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

internal enum NIIF
{
  NIIF_NONE = 0,
  NIIF_INFO = 1,
  NIIF_WARNING = 2,
  NIIF_ERROR = 3,
  NIIF_ICON_MASK = 15, // 0x0000000F
  NIIF_NOSOUND = 16, // 0x00000010
}
