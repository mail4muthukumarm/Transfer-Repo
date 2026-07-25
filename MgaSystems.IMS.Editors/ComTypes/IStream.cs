// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.IStream
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

[Guid("0000000C-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
internal interface IStream
{
  int Read(IntPtr buf, int len);

  int Write(IntPtr buf, int len);

  [return: MarshalAs(UnmanagedType.I8)]
  long Seek([MarshalAs(UnmanagedType.I8), In] long dlibMove, int dwOrigin);

  void SetSize([MarshalAs(UnmanagedType.I8), In] long libNewSize);

  [return: MarshalAs(UnmanagedType.I8)]
  long CopyTo([MarshalAs(UnmanagedType.Interface), In] IStream pstm, [MarshalAs(UnmanagedType.I8), In] long cb, [MarshalAs(UnmanagedType.LPArray), Out] long[] pcbRead);

  void Commit(int grfCommitFlags);

  void Revert();

  void LockRegion([MarshalAs(UnmanagedType.I8), In] long libOffset, [MarshalAs(UnmanagedType.I8), In] long cb, int dwLockType);

  void UnlockRegion([MarshalAs(UnmanagedType.I8), In] long libOffset, [MarshalAs(UnmanagedType.I8), In] long cb, int dwLockType);

  void Stat([Out] STATSTG pStatstg, int grfStatFlag);

  [return: MarshalAs(UnmanagedType.Interface)]
  IStream Clone();
}
