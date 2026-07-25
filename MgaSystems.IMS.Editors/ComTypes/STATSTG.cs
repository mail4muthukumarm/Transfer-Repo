// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.STATSTG
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

[StructLayout(LayoutKind.Sequential)]
internal class STATSTG
{
  [MarshalAs(UnmanagedType.LPWStr)]
  public string pwcsName;
  public int type;
  [MarshalAs(UnmanagedType.I8)]
  public long cbSize;
  [MarshalAs(UnmanagedType.I8)]
  public long mtime;
  [MarshalAs(UnmanagedType.I8)]
  public long ctime;
  [MarshalAs(UnmanagedType.I8)]
  public long atime;
  [MarshalAs(UnmanagedType.I4)]
  public int grfMode;
  [MarshalAs(UnmanagedType.I4)]
  public int grfLocksSupported;
  public int clsid_data1;
  [MarshalAs(UnmanagedType.I2)]
  public short clsid_data2;
  [MarshalAs(UnmanagedType.I2)]
  public short clsid_data3;
  [MarshalAs(UnmanagedType.U1)]
  public byte clsid_b0;
  [MarshalAs(UnmanagedType.U1)]
  public byte clsid_b1;
  [MarshalAs(UnmanagedType.U1)]
  public byte clsid_b2;
  [MarshalAs(UnmanagedType.U1)]
  public byte clsid_b3;
  [MarshalAs(UnmanagedType.U1)]
  public byte clsid_b4;
  [MarshalAs(UnmanagedType.U1)]
  public byte clsid_b5;
  [MarshalAs(UnmanagedType.U1)]
  public byte clsid_b6;
  [MarshalAs(UnmanagedType.U1)]
  public byte clsid_b7;
  [MarshalAs(UnmanagedType.I4)]
  public int grfStateBits;
  [MarshalAs(UnmanagedType.I4)]
  public int reserved;
}
