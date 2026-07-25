// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Risk_Meter.ScreenCapture
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.IMS.Underwriting.Risk_Meter;

public class ScreenCapture
{
  public Image CaptureScreen() => this.CaptureWindow(ScreenCapture.User32.GetDesktopWindow());

  public void CaptureWindowToFile(IntPtr handle, string filename, ImageFormat format)
  {
    this.CaptureWindow(handle).Save(filename, format);
  }

  public Image CaptureWindow(IntPtr handle)
  {
    IntPtr windowDc = ScreenCapture.User32.GetWindowDC(handle);
    ScreenCapture.User32.RECT rect = new ScreenCapture.User32.RECT();
    ScreenCapture.User32.GetWindowRect(handle, ref rect);
    int nWidth = rect.right - rect.left;
    int nHeight = rect.bottom - rect.top;
    IntPtr compatibleDc = ScreenCapture.GDI32.CreateCompatibleDC(windowDc);
    IntPtr compatibleBitmap = ScreenCapture.GDI32.CreateCompatibleBitmap(windowDc, nWidth, nHeight);
    IntPtr hObject = ScreenCapture.GDI32.SelectObject(compatibleDc, compatibleBitmap);
    ScreenCapture.GDI32.BitBlt(compatibleDc, 0, 0, nWidth, nHeight, windowDc, 0, 0, 13369376);
    ScreenCapture.GDI32.SelectObject(compatibleDc, hObject);
    ScreenCapture.GDI32.DeleteDC(compatibleDc);
    ScreenCapture.User32.ReleaseDC(handle, windowDc);
    Bitmap bitmap = Image.FromHbitmap(compatibleBitmap);
    ScreenCapture.GDI32.DeleteObject(compatibleBitmap);
    return (Image) bitmap;
  }

  private class GDI32
  {
    public const int SRCCOPY = 13369376;

    [DllImport("gdi32.dll")]
    public static extern bool BitBlt(
      IntPtr hObject,
      int nXDest,
      int nYDest,
      int nWidth,
      int nHeight,
      IntPtr hObjectSource,
      int nXSrc,
      int nYSrc,
      int dwRop);

    [DllImport("gdi32.dll")]
    public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);

    [DllImport("gdi32.dll")]
    public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

    [DllImport("gdi32.dll")]
    public static extern bool DeleteDC(IntPtr hDC);

    [DllImport("gdi32.dll")]
    public static extern bool DeleteObject(IntPtr hObject);

    [DllImport("gdi32.dll")]
    public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
  }

  private class User32
  {
    [DllImport("user32.dll")]
    public static extern IntPtr GetDesktopWindow();

    [DllImport("user32.dll")]
    public static extern IntPtr GetWindowDC(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

    [DllImport("user32.dll")]
    public static extern IntPtr GetWindowRect(IntPtr hWnd, ref ScreenCapture.User32.RECT rect);

    public struct RECT
    {
      public int left;
      public int top;
      public int right;
      public int bottom;
    }
  }
}
