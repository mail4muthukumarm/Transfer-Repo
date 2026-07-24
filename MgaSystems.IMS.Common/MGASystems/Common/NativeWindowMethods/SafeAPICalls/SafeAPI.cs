// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.NativeWindowMethods.SafeAPICalls.SafeAPI
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Security;
using System.Security.Permissions;
using System.Text;

#nullable disable
namespace MGASystems.Common.NativeWindowMethods.SafeAPICalls;

[StandardModule]
public sealed class SafeAPI
{
  public static int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    int num;
    try
    {
      securityPermission.Assert();
      num = API.SendMessage(hWnd, Msg, wParam, lParam);
    }
    catch (System.Security.SecurityException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return num;
  }

  public static int SendMessage(IntPtr hWnd, int Msg, int wParam, StringBuilder lParam)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    int num;
    try
    {
      securityPermission.Assert();
      num = API.SendMessage(hWnd, Msg, wParam, lParam);
    }
    catch (System.Security.SecurityException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return num;
  }

  public static bool IsWindow(IntPtr hWnd)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    bool flag;
    try
    {
      securityPermission.Assert();
      flag = API.IsWindow(hWnd);
    }
    catch (System.Security.SecurityException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return flag;
  }

  public static void EnumerateChildWindowsOfClass(
    IntPtr hWndParent,
    string className,
    SafeAPI.EnumerateChildWindowsOfClassHandler handler)
  {
    if (string.IsNullOrEmpty(className) || handler == null || IntPtr.Zero.Equals((object) hWndParent))
      return;
    int hWnd2 = 0;
    do
    {
      hWnd2 = SafeAPI.FindWindowEx(hWndParent.ToInt32(), hWnd2, className, (string) null);
      handler(new IntPtr(hWnd2));
    }
    while (hWnd2 != 0);
  }

  public static void SendMessageTimeout(
    IntPtr hWnd,
    int Msg,
    IntPtr wParam,
    IntPtr lParam,
    SendMessageTimeoutFlags flags,
    int timeout,
    ref IntPtr result)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    try
    {
      securityPermission.Assert();
      API.SendMessageTimeout(hWnd, Msg, wParam, lParam, flags, timeout, ref result);
    }
    catch (System.Security.SecurityException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
  }

  public static bool EnableMenuItem(int handle, int enableItem, int enable)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    bool flag;
    try
    {
      securityPermission.Assert();
      flag = API.EnableMenuItem(handle, enableItem, enable);
    }
    catch (System.Security.SecurityException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return flag;
  }

  public static int AddFontResource(string filename)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    int num;
    try
    {
      securityPermission.Assert();
      num = API.AddFontResource(filename);
    }
    catch (System.Security.SecurityException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return num;
  }

  public static bool RemoveFontResource(string filename)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    bool flag;
    try
    {
      securityPermission.Assert();
      flag = API.RemoveFontResource(filename);
    }
    catch (System.Security.SecurityException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return flag;
  }

  public static int GetSystemMenu(int hWnd)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    int systemMenu;
    try
    {
      securityPermission.Assert();
      systemMenu = API.GetSystemMenu(hWnd);
    }
    catch (System.Security.SecurityException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return systemMenu;
  }

  public static int GetSystemMetrics(int smIndex)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    int systemMetrics;
    try
    {
      securityPermission.Assert();
      systemMetrics = API.GetSystemMetrics(smIndex);
    }
    catch (System.Security.SecurityException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return systemMetrics;
  }

  public static int LockWindowUpdate(IntPtr hwnd)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    int num;
    try
    {
      securityPermission.Assert();
      num = API.LockWindowUpdate(hwnd);
    }
    catch (System.Security.SecurityException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return num;
  }

  public static int AnimateWindow(IntPtr hwnd, int time, API.AnimateWindowFlags flags)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    int num;
    try
    {
      securityPermission.Assert();
      num = API.AnimateWindow(hwnd, time, flags);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return num;
  }

  public static IntPtr ShellExecute(
    IntPtr hwnd,
    string lpVerb,
    string lpFile,
    string lpParameters,
    string lpDirectory,
    int nShowCmd)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    IntPtr num;
    try
    {
      securityPermission.Assert();
      num = API.ShellExecute(hwnd, lpVerb, lpFile, lpParameters, lpDirectory, nShowCmd);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return num;
  }

  public static int GetForegroundWindow()
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    int foregroundWindow;
    try
    {
      securityPermission.Assert();
      foregroundWindow = API.GetForegroundWindow();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return foregroundWindow;
  }

  public static int GetDesktopWindow()
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    int desktopWindow;
    try
    {
      securityPermission.Assert();
      desktopWindow = API.GetDesktopWindow();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return desktopWindow;
  }

  public static int MoveWindow(int hwnd, int x, int y, int nWidth, int nHeight, int bRepaint)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    int num;
    try
    {
      securityPermission.Assert();
      num = API.MoveWindow(hwnd, x, y, nWidth, nHeight, bRepaint);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return num;
  }

  public static int GetWindowLong(int hwnd, API.GWL_FLAGS flags)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    int windowLong;
    try
    {
      securityPermission.Assert();
      windowLong = API.GetWindowLong(hwnd, (int) flags);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return windowLong;
  }

  public static int FindWindowEx(int hWnd1, int hWnd2, string lpsz1, string lpsz2)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    int windowEx;
    try
    {
      securityPermission.Assert();
      windowEx = API.FindWindowEx(hWnd1, hWnd2, lpsz1, lpsz2);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return windowEx;
  }

  public static int GetFileInfo(
    string pszPath,
    int dwFileAttributes,
    ref Structures.SHFILEINFO psfi,
    int cbFileInfo,
    int uFlags)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    int fileInfo;
    try
    {
      securityPermission.Assert();
      fileInfo = API.SHGetFileInfo(pszPath, dwFileAttributes, ref psfi, cbFileInfo, uFlags);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return fileInfo;
  }

  public static string GetShortPathName(string longFileName)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    string empty;
    try
    {
      securityPermission.Assert();
      StringBuilder shortPath = new StringBuilder(80 /*0x50*/);
      API.GetShortPathName(longFileName, shortPath, shortPath.Capacity);
      empty = shortPath.ToString();
      goto label_5;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    empty = string.Empty;
label_5:
    return empty;
  }

  public static Icon GetIconFromFile(string filename)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    Icon iconFromFile;
    try
    {
      securityPermission.Assert();
      iconFromFile = SafeAPI.InternalGetIconFromFile(filename);
      goto label_5;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    iconFromFile = (Icon) null;
label_5:
    return iconFromFile;
  }

  private static Icon InternalGetIconFromFile(string filename)
  {
    IntPtr zero = IntPtr.Zero;
    Icon iconFromFile;
    try
    {
      iconFromFile = Icon.FromHandle(API.ExtractIcon(IntPtr.Zero, filename, 0));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      iconFromFile = (Icon) null;
      ProjectData.ClearProjectError();
    }
    return iconFromFile;
  }

  public static Rectangle GetWindowRect(int hwnd)
  {
    SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
    Rectangle windowRect;
    try
    {
      securityPermission.Assert();
      API.RECT lpRect = new API.RECT();
      API.GetWindowRect(hwnd, ref lpRect);
      windowRect = new Rectangle(lpRect.Left, lpRect.Top, lpRect.Right - lpRect.Left, lpRect.Bottom - lpRect.Top);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CodeAccessPermission.RevertAssert();
    }
    return windowRect;
  }

  public delegate void EnumerateChildWindowsOfClassHandler(IntPtr hWnd);
}
