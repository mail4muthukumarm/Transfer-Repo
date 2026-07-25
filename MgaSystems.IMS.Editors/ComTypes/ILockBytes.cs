// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.ILockBytes
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

[Guid("0000000A-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
internal interface ILockBytes
{
  void ReadAt([MarshalAs(UnmanagedType.U8), In] long ulOffset, [Out] IntPtr pv, [MarshalAs(UnmanagedType.U4), In] int cb, [MarshalAs(UnmanagedType.LPArray), Out] int[] pcbRead);

  void WriteAt([MarshalAs(UnmanagedType.U8), In] long ulOffset, IntPtr pv, [MarshalAs(UnmanagedType.U4), In] int cb, [MarshalAs(UnmanagedType.LPArray), Out] int[] pcbWritten);

  void Flush();

  void SetSize([MarshalAs(UnmanagedType.U8), In] long cb);

  void LockRegion([MarshalAs(UnmanagedType.U8), In] long libOffset, [MarshalAs(UnmanagedType.U8), In] long cb, [MarshalAs(UnmanagedType.U4), In] int dwLockType);

  void UnlockRegion([MarshalAs(UnmanagedType.U8), In] long libOffset, [MarshalAs(UnmanagedType.U8), In] long cb, [MarshalAs(UnmanagedType.U4), In] int dwLockType);

  void Stat([Out] STATSTG pstatstg, [MarshalAs(UnmanagedType.U4), In] int grfStatFlag);
}
