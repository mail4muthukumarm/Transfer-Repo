// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.IStorage
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0000000B-0000-0000-C000-000000000046")]
[ComImport]
internal interface IStorage
{
  [return: MarshalAs(UnmanagedType.Interface)]
  IStream CreateStream([MarshalAs(UnmanagedType.BStr), In] string pwcsName, [MarshalAs(UnmanagedType.U4), In] int grfMode, [MarshalAs(UnmanagedType.U4), In] int reserved1, [MarshalAs(UnmanagedType.U4), In] int reserved2);

  [return: MarshalAs(UnmanagedType.Interface)]
  IStream OpenStream([MarshalAs(UnmanagedType.BStr), In] string pwcsName, IntPtr reserved1, [MarshalAs(UnmanagedType.U4), In] int grfMode, [MarshalAs(UnmanagedType.U4), In] int reserved2);

  [return: MarshalAs(UnmanagedType.Interface)]
  IStorage CreateStorage([MarshalAs(UnmanagedType.BStr), In] string pwcsName, [MarshalAs(UnmanagedType.U4), In] int grfMode, [MarshalAs(UnmanagedType.U4), In] int reserved1, [MarshalAs(UnmanagedType.U4), In] int reserved2);

  [return: MarshalAs(UnmanagedType.Interface)]
  IStorage OpenStorage(
    [MarshalAs(UnmanagedType.BStr), In] string pwcsName,
    IntPtr pstgPriority,
    [MarshalAs(UnmanagedType.U4), In] int grfMode,
    IntPtr snbExclude,
    [MarshalAs(UnmanagedType.U4), In] int reserved);

  void CopyTo(int ciidExclude, [MarshalAs(UnmanagedType.LPArray), In] Guid[] pIIDExclude, IntPtr snbExclude, [MarshalAs(UnmanagedType.Interface), In] IStorage stgDest);

  void MoveElementTo([MarshalAs(UnmanagedType.BStr), In] string pwcsName, [MarshalAs(UnmanagedType.Interface), In] IStorage stgDest, [MarshalAs(UnmanagedType.BStr), In] string pwcsNewName, [MarshalAs(UnmanagedType.U4), In] int grfFlags);

  void Commit(int grfCommitFlags);

  void Revert();

  void EnumElements([MarshalAs(UnmanagedType.U4), In] int reserved1, IntPtr reserved2, [MarshalAs(UnmanagedType.U4), In] int reserved3, [MarshalAs(UnmanagedType.Interface)] out object ppVal);

  void DestroyElement([MarshalAs(UnmanagedType.BStr), In] string pwcsName);

  void RenameElement([MarshalAs(UnmanagedType.BStr), In] string pwcsOldName, [MarshalAs(UnmanagedType.BStr), In] string pwcsNewName);

  void SetElementTimes([MarshalAs(UnmanagedType.BStr), In] string pwcsName, [In] System.Runtime.InteropServices.ComTypes.FILETIME pctime, [In] System.Runtime.InteropServices.ComTypes.FILETIME patime, [In] System.Runtime.InteropServices.ComTypes.FILETIME pmtime);

  void SetClass([In] ref Guid clsid);

  void SetStateBits(int grfStateBits, int grfMask);

  void Stat([Out] System.Runtime.InteropServices.ComTypes.STATSTG pStatStg, int grfStatFlag);
}
