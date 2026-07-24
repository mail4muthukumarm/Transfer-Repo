// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.NativeWindowMethods.API
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.Enums;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.InteropServices;
using System.Text;

#nullable disable
namespace MGASystems.Common.NativeWindowMethods;

[StandardModule]
public sealed class API
{
  public static int LockWindowUpdate(IntPtr hwnd)
  {
    int num;
    return num;
  }

  [DllImport("shell32.dll")]
  public static extern int SHGetFileInfo(
    string pszPath,
    int dwFileAttributes,
    ref Structures.SHFILEINFO psfi,
    int cbFileInfo,
    int uFlags);

  [DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  public static extern int SHGetFolderPath(
    IntPtr hwndOwner,
    int nFolder,
    IntPtr hToken,
    int dwFlags,
    StringBuilder pszPath);

  [DllImport("Shell32")]
  public static extern int SHGetSpecialFolderLocation(
    IntPtr hwndOwner,
    CSIDL nFolder,
    ref IntPtr ppidl);

  [DllImport("shell32", CharSet = CharSet.Auto, SetLastError = true)]
  public static extern IntPtr SHGetFileInfo(
    IntPtr ppidl,
    int dwFileAttributes,
    ref Structures.SHFILEINFO sfi,
    int cbFileInfo,
    SHGFI uFlags);

  [DllImport("user32.dll")]
  public static extern int AnimateWindow(IntPtr hwnd, int time, API.AnimateWindowFlags flags);

  [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
  public static extern int GetShortPathName(
    [MarshalAs(UnmanagedType.LPTStr)] string path,
    [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath,
    int shortPathLength);

  [DllImport("user32.dll")]
  public static extern void SendMessageTimeout(
    IntPtr windowHandle,
    int Msg,
    IntPtr wParam,
    IntPtr lParam,
    SendMessageTimeoutFlags flags,
    int timeout,
    ref IntPtr result);

  [DllImport("gdi32.dll")]
  public static extern int AddFontResource(string lpszFilename);

  [DllImport("gdi32.dll")]
  public static extern bool RemoveFontResource(string lpszFilename);

  [DllImport("user32.dll")]
  public static extern bool EnableMenuItem(int handle, int enableItem, int enable);

  [DllImport("user32.dll")]
  public static extern int GetSystemMenu(int hWnd);

  [DllImport("user32.dll")]
  public static extern int GetSystemMetrics(int smIndex);

  [DllImport("shell32.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern IntPtr ExtractIcon(IntPtr hIcon, string lpszExeFileName, int nIconIndex);

  [DllImport("user32", CallingConvention = CallingConvention.Cdecl)]
  public static extern bool DestroyIcon(IntPtr hIcon);

  [DllImport("shell32.dll")]
  public static extern IntPtr ShellExecute(
    IntPtr hwnd,
    string lpVerb,
    string lpFile,
    string lpParameters,
    string lpDirectory,
    int nShowCmd);

  [DllImport("User32.dll")]
  public static extern int GetWindowLong(int hwnd, int nIndex);

  [DllImport("User32.dll")]
  public static extern int FindWindowEx(int hWnd1, int hWnd2, string lpsz1, string lpsz2);

  [DllImport("User32.dll")]
  public static extern int MoveWindow(
    int hwnd,
    int x,
    int y,
    int nWidth,
    int nHeight,
    int bRepaint);

  [DllImport("User32.dll")]
  public static extern int RegisterWindowMessage(string lpMessage);

  [DllImport("User32.dll")]
  public static extern int GetForegroundWindow();

  [DllImport("User32.dll")]
  public static extern int GetDesktopWindow();

  [DllImport("User32.dll")]
  public static extern int GetWindowRect(int hwnd, ref API.RECT lpRect);

  [DllImport("User32.dll")]
  public static extern bool IsWindow(IntPtr hWnd);

  [DllImport("User32.DLL")]
  public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

  [DllImport("User32.DLL")]
  public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, StringBuilder lParam);

  [Flags]
  public enum AnimateWindowFlags
  {
    AW_HOR_POSITIVE = 1,
    AW_HOR_NEGATIVE = 2,
    AW_VER_POSITIVE = 4,
    AW_VER_NEGATIVE = 8,
    AW_CENTER = 16, // 0x00000010
    AW_HIDE = 65536, // 0x00010000
    AW_ACTIVATE = 131072, // 0x00020000
    AW_SLIDE = 262144, // 0x00040000
    AW_BLEND = 524288, // 0x00080000
  }

  public enum GWL_FLAGS
  {
    GWL_USERDATA = -21, // 0xFFFFFFEB
    GWL_EXSTYLE = -20, // 0xFFFFFFEC
    GWL_STYLE = -16, // 0xFFFFFFF0
    GWL_ID = -12, // 0xFFFFFFF4
    GWL_HWNDPARENT = -8, // 0xFFFFFFF8
    GWL_HINSTANCE = -6, // 0xFFFFFFFA
    GWL_WNDPROC = -4, // 0xFFFFFFFC
  }

  [Flags]
  public enum WindowStyles : long
  {
    WS_OVERLAPPED = 0,
    WS_POPUP = 2147483648, // 0x0000000080000000
    WS_CHILD = 1073741824, // 0x0000000040000000
    WS_MINIMIZE = 536870912, // 0x0000000020000000
    WS_VISIBLE = 268435456, // 0x0000000010000000
    WS_DISABLED = 134217728, // 0x0000000008000000
    WS_CLIPSIBLINGS = 67108864, // 0x0000000004000000
    WS_CLIPCHILDREN = 33554432, // 0x0000000002000000
    WS_MAXIMIZE = 16777216, // 0x0000000001000000
    WS_CAPTION = 12582912, // 0x0000000000C00000
    WS_BORDER = 8388608, // 0x0000000000800000
    WS_DLGFRAME = 4194304, // 0x0000000000400000
    WS_VSCROLL = 2097152, // 0x0000000000200000
    WS_HSCROLL = 1048576, // 0x0000000000100000
    WS_SYSMENU = 524288, // 0x0000000000080000
    WS_THICKFRAME = 262144, // 0x0000000000040000
    WS_GROUP = 131072, // 0x0000000000020000
    WS_TABSTOP = 65536, // 0x0000000000010000
    WS_MINIMIZEBOX = WS_GROUP, // 0x0000000000020000
    WS_MAXIMIZEBOX = WS_TABSTOP, // 0x0000000000010000
    WS_TILED = 0,
    WS_ICONIC = WS_MINIMIZE, // 0x0000000020000000
    WS_SIZEBOX = WS_THICKFRAME, // 0x0000000000040000
    WS_TILEDWINDOW = WS_SIZEBOX | WS_MAXIMIZEBOX | WS_MINIMIZEBOX | WS_SYSMENU | WS_DLGFRAME | WS_BORDER, // 0x0000000000CF0000
    WS_OVERLAPPEDWINDOW = WS_TILEDWINDOW, // 0x0000000000CF0000
    WS_POPUPWINDOW = WS_SYSMENU | WS_BORDER | WS_POPUP, // 0x0000000080880000
    WS_CHILDWINDOW = WS_CHILD, // 0x0000000040000000
  }

  public struct RECT
  {
    public int Left;
    public int Top;
    public int Right;
    public int Bottom;
  }
}
