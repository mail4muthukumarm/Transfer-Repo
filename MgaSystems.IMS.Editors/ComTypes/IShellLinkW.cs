// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.IShellLinkW
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System;
using System.Runtime.InteropServices;
using System.Text;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("000214F9-0000-0000-C000-000000000046")]
[ComImport]
internal interface IShellLinkW
{
  void GetPath([MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder pszFile, int cchMaxPath, int pfd, STGM fFlags);

  void GetIDList(out IntPtr ppidl);

  void SetIDList(IntPtr pidl);

  void GetDescription([MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder pszName, int cchMaxName);

  void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);

  void GetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder pszDir, int cchMaxPath);

  void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);

  void GetArguments([MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder pszArgs, int cchMaxPath);

  void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);

  void GetHotkey(out short pwHotkey);

  void SetHotkey(short wHotkey);

  void GetShowCmd(out int piShowCmd);

  void SetShowCmd(int iShowCmd);

  void GetIconLocation([MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder pszIconPath, int cchIconPath, out int piIcon);

  void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);

  void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, int dwReserved);

  void Resolve(IntPtr hwnd, int fFlags);

  void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
}
