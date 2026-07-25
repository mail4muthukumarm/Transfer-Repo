// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.IOleDropTarget
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

[Guid("00000122-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
internal interface IOleDropTarget
{
  [MethodImpl(MethodImplOptions.PreserveSig)]
  int OleDragEnter([MarshalAs(UnmanagedType.Interface), In] object pDataObj, [MarshalAs(UnmanagedType.U4), In] int grfKeyState, [MarshalAs(UnmanagedType.U8), In] long pt, [In, Out] ref int pdwEffect);

  [MethodImpl(MethodImplOptions.PreserveSig)]
  int OleDragOver([MarshalAs(UnmanagedType.U4), In] int grfKeyState, [MarshalAs(UnmanagedType.U8), In] long pt, [In, Out] ref int pdwEffect);

  [MethodImpl(MethodImplOptions.PreserveSig)]
  int OleDragLeave();

  [MethodImpl(MethodImplOptions.PreserveSig)]
  int OleDrop([MarshalAs(UnmanagedType.Interface), In] object pDataObj, [MarshalAs(UnmanagedType.U4), In] int grfKeyState, [MarshalAs(UnmanagedType.U8), In] long pt, [In, Out] ref int pdwEffect);
}
