// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.IOleDataObject
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

[Guid("0000010E-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[SuppressUnmanagedCodeSecurity]
[ComImport]
internal interface IOleDataObject
{
  [MethodImpl(MethodImplOptions.PreserveSig)]
  int OleGetData(FORMATETC pFormatetc, [Out] STGMEDIUM pMedium);

  [MethodImpl(MethodImplOptions.PreserveSig)]
  int OleGetDataHere(FORMATETC pFormatetc, [In, Out] STGMEDIUM pMedium);

  [MethodImpl(MethodImplOptions.PreserveSig)]
  int OleQueryGetData(FORMATETC pFormatetc);

  [MethodImpl(MethodImplOptions.PreserveSig)]
  int OleGetCanonicalFormatEtc(FORMATETC pformatectIn, [Out] FORMATETC pformatetcOut);

  [MethodImpl(MethodImplOptions.PreserveSig)]
  int OleSetData(FORMATETC pFormatectIn, STGMEDIUM pmedium, int fRelease);

  [return: MarshalAs(UnmanagedType.Interface)]
  IEnumFORMATETC OleEnumFormatEtc([MarshalAs(UnmanagedType.U4), In] int dwDirection);

  [MethodImpl(MethodImplOptions.PreserveSig)]
  int OleDAdvise(FORMATETC pFormatetc, [MarshalAs(UnmanagedType.U4), In] int advf, [MarshalAs(UnmanagedType.Interface), In] object pAdvSink, [MarshalAs(UnmanagedType.LPArray), Out] int[] pdwConnection);

  [MethodImpl(MethodImplOptions.PreserveSig)]
  int OleDUnadvise([MarshalAs(UnmanagedType.U4), In] int dwConnection);

  [MethodImpl(MethodImplOptions.PreserveSig)]
  int OleEnumDAdvise([MarshalAs(UnmanagedType.LPArray), Out] object[] ppenumAdvise);
}
