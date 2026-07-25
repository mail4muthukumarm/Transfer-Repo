// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.IDropTargetHelper
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

[ComVisible(true)]
[Guid("4657278B-411B-11D2-839A-00C04FD918D0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface IDropTargetHelper
{
  void DragEnter([In] IntPtr hwndTarget, [MarshalAs(UnmanagedType.Interface), In] IDataObject dataObject, [In] ref POINTSTRUCT pt, [In] int effect);

  void DragLeave();

  void DragOver([In] ref POINTSTRUCT pt, [In] int effect);

  void Drop([MarshalAs(UnmanagedType.Interface), In] IDataObject dataObject, [In] ref POINTSTRUCT pt, [In] int effect);

  void Show([In] bool show);
}
