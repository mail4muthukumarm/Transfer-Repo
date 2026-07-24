// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Functions.ScreenCapture
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.Functions;

[StandardModule]
public sealed class ScreenCapture
{
  [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern IntPtr GetDesktopWindow();

  [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern IntPtr GetWindowDC(IntPtr hwnd);

  [DllImport("Gdi32", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern ulong BitBlt(
    IntPtr hDestDC,
    int x,
    int y,
    int nWidth,
    int nHeight,
    IntPtr hSrcDC,
    int xSrc,
    int ySrc,
    int dwRop);

  public static Image GetDesktopImage()
  {
    Rectangle bounds = Screen.PrimaryScreen.Bounds;
    int width = bounds.Width;
    bounds = Screen.PrimaryScreen.Bounds;
    int height = bounds.Height;
    Image image = (Image) new Bitmap(width, height);
    using (Graphics graphics = Graphics.FromImage(image))
    {
      IntPtr hdc = graphics.GetHdc();
      IntPtr windowDc = ScreenCapture.GetWindowDC(ScreenCapture.GetDesktopWindow());
      long num = (long) ScreenCapture.BitBlt(hdc, 0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, windowDc, 0, 0, 13369376);
      graphics.ReleaseHdc(hdc);
    }
    return image;
  }
}
