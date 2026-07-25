// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.STGMEDIUM
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

[StructLayout(LayoutKind.Sequential)]
internal class STGMEDIUM
{
  public int tymed;
  public IntPtr unionmember;
  public IntPtr pUnkForRelease;
}
