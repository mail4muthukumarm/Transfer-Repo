// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.IEnumSTATSTG
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

[Guid("0000000d-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
internal interface IEnumSTATSTG
{
  [MethodImpl(MethodImplOptions.PreserveSig)]
  uint Next(uint celt, [MarshalAs(UnmanagedType.LPArray), Out] System.Runtime.InteropServices.ComTypes.STATSTG[] rgelt, out uint pceltFetched);

  void Skip(uint celt);

  void Reset();

  [return: MarshalAs(UnmanagedType.Interface)]
  IEnumSTATSTG Clone();
}
