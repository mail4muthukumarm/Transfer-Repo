// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.DragDrop.UnsafeNativeMethods
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using MGASystems.ExtendedEditors.ComTypes;
using System;
using System.Runtime.InteropServices;
using System.Text;

#nullable disable
namespace MGASystems.ExtendedEditors.DragDrop;

internal static class UnsafeNativeMethods
{
  public const int CF_HDROP = 15;

  [DllImport("user32")]
  public static extern int GetCursorPos(ref POINTSTRUCT lpPoint);

  [DllImport("shell32.dll", CharSet = CharSet.Auto)]
  public static extern uint DragQueryFile(IntPtr hDrop, uint iFile, StringBuilder buffer, int cch);

  [DllImport("KERNEL32.DLL", SetLastError = true)]
  internal static extern IntPtr GlobalLock(HandleRef hGlobal);

  [DllImport("KERNEL32.DLL", SetLastError = true)]
  [return: MarshalAs(UnmanagedType.Bool)]
  internal static extern bool GlobalUnlock(HandleRef hGlobal);

  [DllImport("ole32.dll")]
  internal static extern int RegisterDragDrop(IntPtr hwnd, IOleDropTarget pDropTarget);

  [DllImport("OLE32.DLL")]
  internal static extern void ReleaseStgMedium(STGMEDIUM pmedium);

  [DllImport("ole32.dll")]
  internal static extern int RevokeDragDrop(IntPtr hwnd);

  [DllImport("ole32.dll", PreserveSig = false)]
  internal static extern ILockBytes CreateILockBytesOnHGlobal(IntPtr hGlobal, [MarshalAs(UnmanagedType.Bool)] bool fDeleteOnRelease);

  [DllImport("OLE32.DLL", CharSet = CharSet.Auto, PreserveSig = false)]
  internal static extern IntPtr GetHGlobalFromILockBytes(ILockBytes pLockBytes);

  [DllImport("OLE32.DLL", CharSet = CharSet.Unicode, PreserveSig = false)]
  internal static extern IStorage StgCreateDocfileOnILockBytes(
    ILockBytes plkbyt,
    uint grfMode,
    uint reserved);
}
