// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.NativeWindowMethods.FileInfoEx
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.Enums;
using MGASystems.Common.NativeWindowMethods.SafeAPICalls;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

#nullable disable
namespace MGASystems.Common.NativeWindowMethods;

[StandardModule]
public sealed class FileInfoEx
{
  private const int CSIDL_BITBUCKET = 10;
  private static Dictionary<string, Icon> specialFolderIconCache = new Dictionary<string, Icon>();
  private static Dictionary<string, Icon> iconCache = new Dictionary<string, Icon>();

  public static Icon GetIcon(string sFileName) => FileInfoEx.GetIcon(sFileName, 272);

  private static string SpecialFolderPath(int specialFolder)
  {
    int dwFlags = 0;
    IntPtr zero = IntPtr.Zero;
    StringBuilder pszPath = new StringBuilder(260);
    API.SHGetFolderPath(IntPtr.Zero, specialFolder, IntPtr.Zero, dwFlags, pszPath);
    return pszPath.ToString();
  }

  public static Icon GetSmallIcon(string sFileName) => FileInfoEx.GetIcon(sFileName, 273);

  public static Icon GetSpecialFolderIcon(CSIDL csidl, bool small, bool open)
  {
    string key = $"{csidl.ToString()}{small.ToString()}{open.ToString()}";
    if (!FileInfoEx.specialFolderIconCache.ContainsKey(key))
    {
      IntPtr zero = IntPtr.Zero;
      Structures.SHFILEINFO sfi = new Structures.SHFILEINFO();
      API.SHGetSpecialFolderLocation(IntPtr.Zero, csidl, ref zero);
      SHGFI uFlags = SHGFI.ICON | SHGFI.PIDL | SHGFI.SYSICONINDEX;
      if (open)
        uFlags |= SHGFI.OPENICON;
      if (small)
        uFlags |= SHGFI.SMALLICON;
      API.SHGetFileInfo(zero, 0, ref sfi, Marshal.SizeOf(typeof (Structures.SHFILEINFO)), uFlags);
      Marshal.FreeCoTaskMem(zero);
      Icon icon = (Icon) Icon.FromHandle(sfi.hIcon).Clone();
      API.DestroyIcon(sfi.hIcon);
      FileInfoEx.specialFolderIconCache.Add(key, icon);
    }
    return FileInfoEx.specialFolderIconCache[key];
  }

  public static Icon GetLargeIcon(string sFileName) => FileInfoEx.GetIcon(sFileName, 272);

  private static Icon GetIcon(string sFileName, int uFlags)
  {
    string path = sFileName;
    if (!string.IsNullOrEmpty(path))
      path = $"dummy.{Path.GetExtension(path)}";
    string key = $"{path}{uFlags.ToString()}";
    if (!FileInfoEx.iconCache.ContainsKey(key))
    {
      Structures.SHFILEINFO psfi = new Structures.SHFILEINFO();
      SafeAPI.GetFileInfo(sFileName, 128 /*0x80*/, ref psfi, Marshal.SizeOf<Structures.SHFILEINFO>(psfi), uFlags);
      Icon icon = Icon.FromHandle(psfi.hIcon);
      FileInfoEx.iconCache.Add(key, icon);
    }
    return FileInfoEx.iconCache[key];
  }

  public static Icon GetOpeningApplicationIcon(string fileName)
  {
    string pathFromFileName = FileInfoEx.GetOpeningAppPathFromFileName(fileName);
    return pathFromFileName == null || pathFromFileName.Length == 0 ? SystemIcons.Application : SafeAPI.GetIconFromFile(pathFromFileName) ?? SystemIcons.Application;
  }

  private static string GetOpeningAppPathFromFileName(string fileName)
  {
    string pathFromFileName;
    if (new FileInfo(fileName).Extension.Length == 0)
    {
      pathFromFileName = string.Empty;
    }
    else
    {
      RegistryKey registryKey1 = (RegistryKey) null;
      RegistryKey registryKey2 = (RegistryKey) null;
      try
      {
        string name1 = fileName.Substring(fileName.LastIndexOf("."));
        registryKey1 = Registry.ClassesRoot.OpenSubKey(name1, false);
        string name2 = $"{Conversions.ToString(registryKey1.GetValue((string) null))}\\shell\\open\\command";
        registryKey2 = Registry.ClassesRoot.OpenSubKey(name2, false);
        if (registryKey2 != null)
        {
          string[] strArray1 = Conversions.ToString(registryKey2.GetValue((string) null)).Split(" ,".ToCharArray());
          string Left = string.Empty;
          string[] strArray2 = strArray1;
          int index = 0;
          while (index < strArray2.Length)
          {
            string str = strArray2[index];
            if (str.IndexOf("\\") != -1)
              Left = $"{Left}{str} ";
            else if (Operators.CompareString(Left, string.Empty, false) != 0)
              break;
            checked { ++index; }
          }
          string path = Left.Replace("\"", string.Empty);
          pathFromFileName = !File.Exists(path) ? string.Empty : path;
          goto label_18;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        pathFromFileName = string.Empty;
        ProjectData.ClearProjectError();
        goto label_18;
      }
      finally
      {
        registryKey1?.Close();
        registryKey2?.Close();
      }
      pathFromFileName = string.Empty;
    }
label_18:
    return pathFromFileName;
  }

  public static string GetOpeningApplicationName(string fileName)
  {
    string pathFromFileName = FileInfoEx.GetOpeningAppPathFromFileName(fileName);
    string openingApplicationName;
    if (pathFromFileName.Length == 0)
    {
      openingApplicationName = "Unknown application";
    }
    else
    {
      try
      {
        openingApplicationName = FileVersionInfo.GetVersionInfo(pathFromFileName).FileDescription;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        openingApplicationName = "Unknown application";
        ProjectData.ClearProjectError();
      }
    }
    return openingApplicationName;
  }

  public static string GetTypeName(string sFileName)
  {
    Structures.SHFILEINFO psfi = new Structures.SHFILEINFO();
    int uFlags = 1040;
    SafeAPI.GetFileInfo(sFileName, 128 /*0x80*/, ref psfi, Marshal.SizeOf<Structures.SHFILEINFO>(psfi), uFlags);
    return psfi.szTypeName;
  }
}
