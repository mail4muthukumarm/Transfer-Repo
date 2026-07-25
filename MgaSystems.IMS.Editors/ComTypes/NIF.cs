// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.NIF
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

[Flags]
internal enum NIF
{
  NIF_MESSAGE = 1,
  NIF_ICON = 2,
  NIF_TIP = 4,
  NIF_STATE = 8,
  NIF_INFO = 16, // 0x00000010
  NIF_GUID = 32, // 0x00000020
}
