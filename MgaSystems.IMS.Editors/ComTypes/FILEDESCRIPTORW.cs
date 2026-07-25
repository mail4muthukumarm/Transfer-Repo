// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.FILEDESCRIPTORW
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal sealed class FILEDESCRIPTORW
{
  public uint dwFlags;
  public Guid clsid;
  public SIZEL sizel;
  public POINTL pointl;
  public uint dwFileAttributes;
  public System.Runtime.InteropServices.ComTypes.FILETIME ftCreationTime;
  public System.Runtime.InteropServices.ComTypes.FILETIME ftLastAccessTime;
  public System.Runtime.InteropServices.ComTypes.FILETIME ftLastWriteTime;
  public uint nFileSizeHigh;
  public uint nFileSizeLow;
  [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
  public string cFileName;
}
