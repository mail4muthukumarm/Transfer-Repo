// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.UserControlBase
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public class UserControlBase : UserControl
{
  private bool disableCustomDrawing;

  public UserControlBase()
  {
    this.disableCustomDrawing = SystemInformation.TerminalServerSession || this.DesignMode;
    if (this.disableCustomDrawing)
      return;
    this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
    this.SetStyle(ControlStyles.UserPaint, true);
    this.SetStyle(ControlStyles.ResizeRedraw, true);
    this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    if (this.disableCustomDrawing)
    {
      base.OnPaint(e);
    }
    else
    {
      using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(191, 219, (int) byte.MaxValue), Color.White, LinearGradientMode.ForwardDiagonal))
      {
        linearGradientBrush.SetBlendTriangularShape(0.05f, 1f);
        e.Graphics.FillRectangle((Brush) linearGradientBrush, linearGradientBrush.Rectangle);
      }
    }
  }
}
