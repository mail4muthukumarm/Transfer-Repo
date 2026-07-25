// Decompiled with JetBrains decompiler
// Type: ThumbnailExtractor.ThumbnailExtractor
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

#nullable disable
namespace ThumbnailExtractor;

public sealed class ThumbnailExtractor
{
  private ThumbnailExtractor()
  {
  }

  private static string PathFromPidl(IntPtr pidl)
  {
    StringBuilder pszPath = new StringBuilder(260, 260);
    return ThumbnailExtractor.ThumbnailExtractor.NativeMethods.SHGetPathFromIDList(pidl, pszPath) == 0 ? string.Empty : pszPath.ToString();
  }

  public static Bitmap GenerateThumbnail(string file)
  {
    return ThumbnailExtractor.ThumbnailExtractor.GenerateThumbnail(file, new Size(100, 100));
  }

  public static Bitmap GenerateThumbnail(string file, Size desiredSize)
  {
    Bitmap thumbnail = (Bitmap) null;
    if (!File.Exists(file))
      throw new FileNotFoundException($"The file '{file}' does not exist", file);
    ThumbnailExtractor.ThumbnailExtractor.IShellFolder o = (ThumbnailExtractor.ThumbnailExtractor.IShellFolder) null;
    try
    {
      o = ThumbnailExtractor.ThumbnailExtractor.GetDesktopFolder();
      if (o != null)
      {
        IntPtr zero1 = IntPtr.Zero;
        int pchEaten = 0;
        int pdwAttributes = 0;
        string directoryName = Path.GetDirectoryName(file);
        IntPtr ppidl = IntPtr.Zero;
        try
        {
          o.ParseDisplayName(IntPtr.Zero, IntPtr.Zero, directoryName, out pchEaten, out ppidl, out pdwAttributes);
          if (ppidl != IntPtr.Zero)
          {
            Guid riid = new Guid("000214E6-0000-0000-C000-000000000046");
            ThumbnailExtractor.ThumbnailExtractor.IShellFolder ppvOut = (ThumbnailExtractor.ThumbnailExtractor.IShellFolder) null;
            try
            {
              o.BindToObject(ppidl, IntPtr.Zero, ref riid, ref ppvOut);
              if (ppvOut != null)
              {
                ThumbnailExtractor.ThumbnailExtractor.IEnumIDList ppenumIDList = (ThumbnailExtractor.ThumbnailExtractor.IEnumIDList) null;
                ppvOut.EnumObjects(IntPtr.Zero, ThumbnailExtractor.ThumbnailExtractor.ESHCONTF.SHCONTF_FOLDERS | ThumbnailExtractor.ThumbnailExtractor.ESHCONTF.SHCONTF_NONFOLDERS, ref ppenumIDList);
                if (ppenumIDList != null)
                {
                  IntPtr zero2 = IntPtr.Zero;
                  int pceltFetched = 0;
                  bool flag = false;
                  while (!flag)
                  {
                    if (ppenumIDList.Next(1, ref zero2, out pceltFetched) != 0)
                    {
                      zero2 = IntPtr.Zero;
                      flag = true;
                    }
                    else
                    {
                      thumbnail = ThumbnailExtractor.ThumbnailExtractor.GetThumbNail(file, zero2, ppvOut, desiredSize);
                      if (thumbnail != null)
                        flag = true;
                    }
                    if (zero2 != IntPtr.Zero)
                      ThumbnailExtractor.ThumbnailExtractor.NativeMethods.CoTaskMemFree(zero2);
                  }
                }
              }
            }
            finally
            {
              if (ppvOut != null)
                Marshal.ReleaseComObject((object) ppvOut);
            }
          }
        }
        finally
        {
          if (ppidl != IntPtr.Zero)
            ThumbnailExtractor.ThumbnailExtractor.NativeMethods.CoTaskMemFree(ppidl);
        }
      }
    }
    finally
    {
      if (o != null)
        Marshal.ReleaseComObject((object) o);
    }
    return thumbnail;
  }

  private static Bitmap GetThumbNail(
    string file,
    IntPtr pidl,
    ThumbnailExtractor.ThumbnailExtractor.IShellFolder item,
    Size desiredSize)
  {
    IntPtr phBmpThumbnail = IntPtr.Zero;
    ThumbnailExtractor.ThumbnailExtractor.IExtractImage o = (ThumbnailExtractor.ThumbnailExtractor.IExtractImage) null;
    try
    {
      if (string.Compare(Path.GetFileName(ThumbnailExtractor.ThumbnailExtractor.PathFromPidl(pidl)), Path.GetFileName(file), true, CultureInfo.CurrentUICulture) == 0)
      {
        ThumbnailExtractor.ThumbnailExtractor.IUnknown ppvOut = (ThumbnailExtractor.ThumbnailExtractor.IUnknown) null;
        int prgfInOut = 0;
        Guid riid = new Guid("BB2E617C-0920-11d1-9A0B-00C04FC2D6C1");
        try
        {
          item.GetUIObjectOf(IntPtr.Zero, 1, ref pidl, ref riid, out prgfInOut, ref ppvOut);
        }
        catch (Exception ex)
        {
          string message = ex.Message;
          return (Bitmap) null;
        }
        o = (ThumbnailExtractor.ThumbnailExtractor.IExtractImage) ppvOut;
        if (o != null)
        {
          ThumbnailExtractor.ThumbnailExtractor.SIZE prgSize = new ThumbnailExtractor.ThumbnailExtractor.SIZE();
          prgSize.cx = desiredSize.Width;
          prgSize.cy = desiredSize.Height;
          StringBuilder pszPathBuffer = new StringBuilder(260, 260);
          int pdwPriority = 0;
          int dwRecClrDepth = 32 /*0x20*/;
          int pdwFlags = 36;
          try
          {
            o.GetLocation(pszPathBuffer, pszPathBuffer.Capacity, ref pdwPriority, ref prgSize, dwRecClrDepth, ref pdwFlags);
          }
          catch
          {
            return (Bitmap) null;
          }
          try
          {
            o.Extract(out phBmpThumbnail);
          }
          catch
          {
            return (Bitmap) null;
          }
          if (phBmpThumbnail != IntPtr.Zero)
            return Image.FromHbitmap(phBmpThumbnail);
        }
      }
    }
    finally
    {
      if (phBmpThumbnail != IntPtr.Zero)
        ThumbnailExtractor.ThumbnailExtractor.NativeMethods.DeleteObject(phBmpThumbnail);
      if (o != null)
        Marshal.ReleaseComObject((object) o);
    }
    return (Bitmap) null;
  }

  private static ThumbnailExtractor.ThumbnailExtractor.IShellFolder GetDesktopFolder()
  {
    ThumbnailExtractor.ThumbnailExtractor.IShellFolder ppshf;
    ThumbnailExtractor.ThumbnailExtractor.NativeMethods.SHGetDesktopFolder(out ppshf);
    return ppshf;
  }

  [Flags]
  private enum ESTRRET
  {
    STRRET_WSTR = 0,
    STRRET_OFFSET = 1,
    STRRET_CSTR = 2,
  }

  [Flags]
  private enum ESHCONTF
  {
    SHCONTF_FOLDERS = 32, // 0x00000020
    SHCONTF_NONFOLDERS = 64, // 0x00000040
    SHCONTF_INCLUDEHIDDEN = 128, // 0x00000080
  }

  [Flags]
  private enum ESHGDN
  {
    SHGDN_NORMAL = 0,
    SHGDN_INFOLDER = 1,
    SHGDN_FORADDRESSBAR = 16384, // 0x00004000
    SHGDN_FORPARSING = 32768, // 0x00008000
  }

  [Flags]
  private enum ESFGAO
  {
    SFGAO_CANCOPY = 1,
    SFGAO_CANMOVE = 2,
    SFGAO_CANLINK = 4,
    SFGAO_CANRENAME = 16, // 0x00000010
    SFGAO_CANDELETE = 32, // 0x00000020
    SFGAO_HASPROPSHEET = 64, // 0x00000040
    SFGAO_DROPTARGET = 256, // 0x00000100
    SFGAO_CAPABILITYMASK = SFGAO_DROPTARGET | SFGAO_HASPROPSHEET | SFGAO_CANDELETE | SFGAO_CANRENAME | SFGAO_CANLINK | SFGAO_CANMOVE | SFGAO_CANCOPY, // 0x00000177
    SFGAO_LINK = 65536, // 0x00010000
    SFGAO_SHARE = 131072, // 0x00020000
    SFGAO_READONLY = 262144, // 0x00040000
    SFGAO_GHOSTED = 524288, // 0x00080000
    SFGAO_DISPLAYATTRMASK = SFGAO_GHOSTED | SFGAO_READONLY | SFGAO_SHARE | SFGAO_LINK, // 0x000F0000
    SFGAO_FILESYSANCESTOR = 268435456, // 0x10000000
    SFGAO_FOLDER = 536870912, // 0x20000000
    SFGAO_FILESYSTEM = 1073741824, // 0x40000000
    SFGAO_HASSUBFOLDER = -2147483648, // 0x80000000
    SFGAO_CONTENTSMASK = SFGAO_HASSUBFOLDER, // 0x80000000
    SFGAO_VALIDATE = 16777216, // 0x01000000
    SFGAO_REMOVABLE = 33554432, // 0x02000000
    SFGAO_COMPRESSED = 67108864, // 0x04000000
  }

  private enum EIEIFLAG
  {
    IEIFLAG_ASYNC = 1,
    IEIFLAG_CACHE = 2,
    IEIFLAG_ASPECT = 4,
    IEIFLAG_OFFLINE = 8,
    IEIFLAG_GLEAM = 16, // 0x00000010
    IEIFLAG_SCREEN = 32, // 0x00000020
    IEIFLAG_ORIGSIZE = 64, // 0x00000040
    IEIFLAG_NOSTAMP = 128, // 0x00000080
    IEIFLAG_NOBORDER = 256, // 0x00000100
    IEIFLAG_QUALITY = 512, // 0x00000200
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Auto)]
  private struct STRRET_CSTR
  {
    public ThumbnailExtractor.ThumbnailExtractor.ESTRRET uType;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 520)]
    public byte[] cStr;
  }

  [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Auto)]
  private struct STRRET_ANY
  {
    [FieldOffset(0)]
    public ThumbnailExtractor.ThumbnailExtractor.ESTRRET uType;
    [FieldOffset(4)]
    public IntPtr pOLEString;
  }

  private struct SIZE
  {
    public int cx;
    public int cy;
  }

  [Guid("00000000-0000-0000-C000-000000000046")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  private interface IUnknown
  {
    [MethodImpl(MethodImplOptions.PreserveSig)]
    IntPtr QueryInterface(ref Guid riid, out IntPtr pVoid);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    IntPtr AddRef();

    [MethodImpl(MethodImplOptions.PreserveSig)]
    IntPtr Release();
  }

  [Guid("000214F2-0000-0000-C000-000000000046")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  private interface IEnumIDList
  {
    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Next(int celt, ref IntPtr rgelt, out int pceltFetched);

    void Skip(int celt);

    void Reset();

    void Clone(ref ThumbnailExtractor.ThumbnailExtractor.IEnumIDList ppenum);
  }

  [Guid("000214E6-0000-0000-C000-000000000046")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  private interface IShellFolder
  {
    void ParseDisplayName(
      IntPtr hwndOwner,
      IntPtr pbcReserved,
      [MarshalAs(UnmanagedType.LPWStr)] string lpszDisplayName,
      out int pchEaten,
      out IntPtr ppidl,
      out int pdwAttributes);

    void EnumObjects(
      IntPtr hwndOwner,
      [MarshalAs(UnmanagedType.U4)] ThumbnailExtractor.ThumbnailExtractor.ESHCONTF grfFlags,
      ref ThumbnailExtractor.ThumbnailExtractor.IEnumIDList ppenumIDList);

    void BindToObject(
      IntPtr pidl,
      IntPtr pbcReserved,
      ref Guid riid,
      ref ThumbnailExtractor.ThumbnailExtractor.IShellFolder ppvOut);

    void BindToStorage(IntPtr pidl, IntPtr pbcReserved, ref Guid riid, IntPtr ppvObj);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int CompareIDs(IntPtr lParam, IntPtr pidl1, IntPtr pidl2);

    void CreateViewObject(IntPtr hwndOwner, ref Guid riid, IntPtr ppvOut);

    void GetAttributesOf(int cidl, IntPtr apidl, [MarshalAs(UnmanagedType.U4)] ref ThumbnailExtractor.ThumbnailExtractor.ESFGAO rgfInOut);

    void GetUIObjectOf(
      IntPtr hwndOwner,
      int cidl,
      ref IntPtr apidl,
      ref Guid riid,
      out int prgfInOut,
      ref ThumbnailExtractor.ThumbnailExtractor.IUnknown ppvOut);

    void GetDisplayNameOf(
      IntPtr pidl,
      [MarshalAs(UnmanagedType.U4)] ThumbnailExtractor.ThumbnailExtractor.ESHGDN uFlags,
      ref ThumbnailExtractor.ThumbnailExtractor.STRRET_CSTR lpName);

    void SetNameOf(
      IntPtr hwndOwner,
      IntPtr pidl,
      [MarshalAs(UnmanagedType.LPWStr)] string lpszName,
      [MarshalAs(UnmanagedType.U4)] ThumbnailExtractor.ThumbnailExtractor.ESHCONTF uFlags,
      ref IntPtr ppidlOut);
  }

  [Guid("BB2E617C-0920-11d1-9A0B-00C04FC2D6C1")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  private interface IExtractImage
  {
    void GetLocation(
      [MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder pszPathBuffer,
      int cch,
      ref int pdwPriority,
      ref ThumbnailExtractor.ThumbnailExtractor.SIZE prgSize,
      int dwRecClrDepth,
      ref int pdwFlags);

    void Extract(out IntPtr phBmpThumbnail);
  }

  private sealed class NativeMethods
  {
    private NativeMethods()
    {
    }

    [DllImport("ole32.dll")]
    internal static extern void CoTaskMemFree(IntPtr pv);

    [DllImport("shell32", CharSet = CharSet.Auto)]
    internal static extern int SHGetDesktopFolder(out ThumbnailExtractor.ThumbnailExtractor.IShellFolder ppshf);

    [DllImport("shell32", CharSet = CharSet.Auto)]
    internal static extern int SHGetPathFromIDList(IntPtr pidl, StringBuilder pszPath);

    [DllImport("gdi32", CharSet = CharSet.Auto)]
    internal static extern int DeleteObject(IntPtr hObject);
  }
}
