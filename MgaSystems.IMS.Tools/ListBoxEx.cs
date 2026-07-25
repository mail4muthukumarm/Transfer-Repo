// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ListBoxEx
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

public class ListBoxEx : ListBox
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
      ListBoxEx.SetWindowPos(this.Handle, IntPtr.Zero, 0, 0, 0, 0, 55);
    }
  }

  [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
  protected override void WndProc(ref Message m)
  {
    base.WndProc(ref m);
    if (this.BorderStyle != BorderStyle.FixedSingle || m.Msg != 133)
      return;
    IntPtr dcEx = ListBoxEx.GetDCEx(m.HWnd, m.WParam, 33);
    if (!dcEx.Equals((object) IntPtr.Zero))
    {
      try
      {
        using (Graphics graphics = Graphics.FromHdc(dcEx))
        {
          Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
          ControlPaint.DrawBorder(graphics, bounds, this._borderColor, ButtonBorderStyle.Solid);
          bounds.Inflate(-1, -1);
        }
        m.Result = new IntPtr(1);
      }
      finally
      {
        ListBoxEx.ReleaseDC(m.HWnd, dcEx);
      }
    }
    this.Invalidate();
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

  public ListBoxEx() => this._borderColor = Color.Black;
}
