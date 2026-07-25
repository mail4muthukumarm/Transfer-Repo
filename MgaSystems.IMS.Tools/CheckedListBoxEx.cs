// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.CheckedListBoxEx
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public class CheckedListBoxEx : CheckedListBox
{
  private const int WM_NCPAINT = 133;
  private const int DCX_WINDOW = 1;
  private const int DCX_PARENTCLIP = 32 /*0x20*/;
  private const int SWP_NOACTIVATE = 16 /*0x10*/;
  private const int SWP_FRAMECHANGED = 32 /*0x20*/;
  private const int SWP_NOZORDER = 4;
  private const int SWP_NOSIZE = 1;
  private const int SWP_NOMOVE = 2;
  private Color _borderColor;

  [DefaultValue(typeof (Color), "Black")]
  public Color BorderColor
  {
    get => this._borderColor;
    set
    {
      this._borderColor = value;
      CheckedListBoxEx.SetWindowPos(this.Handle, IntPtr.Zero, 0, 0, 0, 0, 55);
    }
  }

  [SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")]
  [DllImport("user32.dll")]
  private static extern IntPtr GetDCEx(IntPtr hWnd, IntPtr hrgnClip, int flags);

  [SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")]
  [DllImport("user32.dll")]
  private static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

  [SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")]
  [DllImport("user32.dll")]
  private static extern bool SetWindowPos(
    IntPtr hWnd,
    IntPtr hWndInsertAfter,
    int X,
    int Y,
    int cx,
    int cy,
    int uFlags);

  public CheckedListBoxEx() => this._borderColor = Color.Black;
}
