// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.NativeWindowMethods.Structures
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.Common.NativeWindowMethods;

[StandardModule]
public sealed class Structures
{
  public struct SHFILEINFO
  {
    public IntPtr hIcon;
    public int iIcon;
    public int dwAttributes;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szDisplayName;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80 /*0x50*/)]
    public string szTypeName;
  }
}
