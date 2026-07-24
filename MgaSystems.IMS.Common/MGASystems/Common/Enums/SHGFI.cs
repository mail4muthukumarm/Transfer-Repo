// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Enums.SHGFI
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;

#nullable disable
namespace MGASystems.Common.Enums;

[Flags]
public enum SHGFI
{
  ADDOVERLAYS = 32, // 0x00000020
  ATTR_SPECIFIED = 131072, // 0x00020000
  ATTRIBUTES = 2048, // 0x00000800
  DISPLAYNAME = 512, // 0x00000200
  EXETYPE = 8192, // 0x00002000
  ICON = 256, // 0x00000100
  ICONLOCATION = 4096, // 0x00001000
  LARGEICON = 0,
  LINKOVERLAY = 32768, // 0x00008000
  OPENICON = 2,
  OVERLAYINDEX = 64, // 0x00000040
  PIDL = 8,
  SELECTED = 65536, // 0x00010000
  SHELLICONSIZE = 4,
  SMALLICON = 1,
  SYSICONINDEX = 16384, // 0x00004000
  TYPENAME = 1024, // 0x00000400
  USEFILEATTRIBUTES = 16, // 0x00000010
}
