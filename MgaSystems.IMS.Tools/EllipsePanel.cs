// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.EllipsePanel
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (Panel))]
public sealed class EllipsePanel : Panel
{
  private int _cornerOffset;
  private Color _penColor;
  private int _borderWidth;

  public EllipsePanel()
  {
    this._cornerOffset = 10;
    this._penColor = Color.Black;
    this._borderWidth = 1;
    this.SetStyle(ControlStyles.ResizeRedraw, true);
  }

  private static void DrawRoundRect(
    Graphics g,
    Pen p,
    float x,
    float y,
    float width,
    float height,
    float radius)
  {
    GraphicsPath path = (GraphicsPath) null;
    try
    {
      path = EllipsePanel.CreateBorderPath(x, y, width, height, radius);
      g.DrawPath(p, path);
    }
    finally
    {
      path?.Dispose();
    }
  }

  private static GraphicsPath CreateBorderPath(
    float x,
    float y,
    float width,
    float height,
    float radius)
  {
    GraphicsPath borderPath = new GraphicsPath();
    borderPath.AddLine(x + radius, y, (float) ((double) x + (double) width - (double) radius * 2.0), y);
    borderPath.AddArc((float) ((double) x + (double) width - (double) radius * 2.0), y, radius * 2f, radius * 2f, 270f, 90f);
    borderPath.AddLine(x + width, y + radius, x + width, (float) ((double) y + (double) height - (double) radius * 2.0));
    borderPath.AddArc((float) ((double) x + (double) width - (double) radius * 2.0), (float) ((double) y + (double) height - (double) radius * 2.0), radius * 2f, radius * 2f, 0.0f, 90f);
    borderPath.AddLine((float) ((double) x + (double) width - (double) radius * 2.0), y + height, x + radius, y + height);
    borderPath.AddArc(x, (float) ((double) y + (double) height - (double) radius * 2.0), radius * 2f, radius * 2f, 90f, 90f);
    borderPath.AddLine(x, (float) ((double) y + (double) height - (double) radius * 2.0), x, y + radius);
    borderPath.AddArc(x, y, radius * 2f, radius * 2f, 180f, 90f);
    borderPath.CloseFigure();
    return borderPath;
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    Rectangle clientRectangle = this.ClientRectangle;
    if (clientRectangle.Width <= 0 || clientRectangle.Height <= 0)
    {
      base.OnPaint(e);
    }
    else
    {
      Pen p = (Pen) null;
      try
      {
        p = new Pen(this._penColor, (float) this._borderWidth);
        int radius = this._cornerOffset;
        int num = this._cornerOffset * 2;
        if (clientRectangle.Width <= num || clientRectangle.Height <= num)
          radius = (int) Math.Round((double) Math.Min(clientRectangle.Width, clientRectangle.Height) / 2.0);
        if (radius > 0)
          EllipsePanel.DrawRoundRect(e.Graphics, p, (float) clientRectangle.X, (float) clientRectangle.Y, (float) (clientRectangle.Width - 1), (float) (clientRectangle.Height - 1), (float) radius);
        base.OnPaint(e);
      }
      finally
      {
        p.Dispose();
      }
    }
  }

  [Category("Appearance")]
  [Description("Gets/Sets the border color used to draw the outline of the panel")]
  [DefaultValue(typeof (Color), "Black")]
  public Color BorderColor
  {
    get => this._penColor;
    set
    {
      if (this._penColor.Equals((object) value))
        return;
      this._penColor = value;
      this.Refresh();
    }
  }

  [Category("Appearance")]
  [Description("Gets/Sets size of the rounded edges")]
  [DefaultValue(10)]
  public int CornerOffset
  {
    get => this._cornerOffset;
    set
    {
      if (this._cornerOffset == value || value <= 0)
        return;
      this._cornerOffset = value;
      this.UpdateRegion();
      this.Refresh();
    }
  }

  [Category("Appearance")]
  [Description("Gets/Sets the width of the Border pen")]
  [DefaultValue(1)]
  public int BorderWidth
  {
    get => this._borderWidth;
    set
    {
      if (this._borderWidth == value || value <= 0)
        return;
      this._borderWidth = value;
      this.Refresh();
    }
  }

  private void UpdateRegion()
  {
    Rectangle clientRectangle = this.ClientRectangle;
    if (clientRectangle.Height < 1 && clientRectangle.Width < 1)
      return;
    Region region1 = this.Region;
    GraphicsPath path = (GraphicsPath) null;
    int radius = this._cornerOffset;
    int num = this._cornerOffset * 2;
    if (clientRectangle.Width <= num || clientRectangle.Height <= num)
      radius = (int) Math.Round((double) Math.Min(clientRectangle.Width, clientRectangle.Height) / 2.0);
    if (radius <= 0)
      return;
    Region region2;
    try
    {
      path = EllipsePanel.CreateBorderPath((float) (clientRectangle.X - 1), (float) (clientRectangle.Y - 1), (float) (clientRectangle.Width + 1), (float) (clientRectangle.Height + 1), (float) radius);
      region2 = new Region(path);
    }
    finally
    {
      path?.Dispose();
    }
    this.Region = region2;
    region1?.Dispose();
  }

  protected override void OnSizeChanged(EventArgs e)
  {
    base.OnSizeChanged(e);
    this.UpdateRegion();
  }
}
