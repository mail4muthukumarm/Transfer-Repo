// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.BouncingProgress
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public sealed class BouncingProgress : UserControl
{
  private Color _bounceColor;
  private bool _forwardFlag;
  private int _startPosition;
  private BorderStyle _borderStyle;
  private Color _borderColor;
  private IContainer components;

  public BouncingProgress()
  {
    this._bounceColor = Color.FromKnownColor(KnownColor.Highlight);
    this._forwardFlag = true;
    this._borderStyle = BorderStyle.Fixed3D;
    this._borderColor = Color.DarkGray;
    this.InitializeComponent();
    this.SetStyle(ControlStyles.ResizeRedraw, true);
    this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
    this.SetStyle(ControlStyles.UserPaint, true);
    this.SetStyle(ControlStyles.DoubleBuffer, true);
    this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
    this.Invalidate();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual Timer Timer1
  {
    get => this._Timer1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
      Timer timer1_1 = this._Timer1;
      if (timer1_1 != null)
        timer1_1.Tick -= eventHandler;
      this._Timer1 = value;
      Timer timer1_2 = this._Timer1;
      if (timer1_2 == null)
        return;
      timer1_2.Tick += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.Timer1 = new Timer(this.components);
    this.Timer1.Interval = 1;
    this.Name = "UserControl1";
    this.Size = new Size(160 /*0xA0*/, 24);
  }

  [Description("Border style that is drawn around control.")]
  [Category("Custom")]
  public BorderStyle Border
  {
    get => this._borderStyle;
    set
    {
      this._borderStyle = value;
      this.Invalidate();
    }
  }

  [Description("Border color used to draw fixed single border.")]
  [Category("Custom")]
  public Color BorderColor
  {
    get => this._borderColor;
    set
    {
      this._borderColor = value;
      this.Invalidate();
    }
  }

  [Description("Boolean value that determines if the control is bouncing.")]
  [Category("Custom")]
  public bool Bounce
  {
    get => this.Timer1.Enabled;
    set
    {
      if (!value)
      {
        this._startPosition = 0;
        this._forwardFlag = true;
        this.Invalidate();
      }
      this.Timer1.Enabled = value;
      this.Invalidate();
    }
  }

  [Description("Color of the bouncer.")]
  [Category("Custom")]
  public Color BounceColor
  {
    get => this._bounceColor;
    set => this._bounceColor = value;
  }

  private void Draw3DBorder(Graphics g)
  {
    Pen pen1 = new Pen(Color.FromKnownColor(KnownColor.ControlDark));
    Pen pen2 = new Pen(Color.FromKnownColor(KnownColor.ControlLight));
    int num = 1;
    Graphics graphics1 = g;
    Pen pen3 = pen1;
    Rectangle clientRectangle1 = this.ClientRectangle;
    int left1 = clientRectangle1.Left;
    clientRectangle1 = this.ClientRectangle;
    int top1 = clientRectangle1.Top;
    Point pt1_1 = new Point(left1, top1);
    clientRectangle1 = this.ClientRectangle;
    int x1 = clientRectangle1.Width - num;
    clientRectangle1 = this.ClientRectangle;
    int top2 = clientRectangle1.Top;
    Point pt2_1 = new Point(x1, top2);
    graphics1.DrawLine(pen3, pt1_1, pt2_1);
    Graphics graphics2 = g;
    Pen pen4 = pen1;
    Rectangle clientRectangle2 = this.ClientRectangle;
    int left2 = clientRectangle2.Left;
    clientRectangle2 = this.ClientRectangle;
    int top3 = clientRectangle2.Top;
    Point pt1_2 = new Point(left2, top3);
    clientRectangle2 = this.ClientRectangle;
    int left3 = clientRectangle2.Left;
    clientRectangle2 = this.ClientRectangle;
    int y1 = clientRectangle2.Height - num;
    Point pt2_2 = new Point(left3, y1);
    graphics2.DrawLine(pen4, pt1_2, pt2_2);
    Graphics graphics3 = g;
    Pen pen5 = pen2;
    Rectangle clientRectangle3 = this.ClientRectangle;
    int left4 = clientRectangle3.Left;
    clientRectangle3 = this.ClientRectangle;
    int y2 = clientRectangle3.Height - num;
    Point pt1_3 = new Point(left4, y2);
    clientRectangle3 = this.ClientRectangle;
    int x2 = clientRectangle3.Width - num;
    clientRectangle3 = this.ClientRectangle;
    int y3 = clientRectangle3.Height - num;
    Point pt2_3 = new Point(x2, y3);
    graphics3.DrawLine(pen5, pt1_3, pt2_3);
    Graphics graphics4 = g;
    Pen pen6 = pen2;
    Rectangle clientRectangle4 = this.ClientRectangle;
    int x3 = clientRectangle4.Width - num;
    clientRectangle4 = this.ClientRectangle;
    int top4 = clientRectangle4.Top;
    Point pt1_4 = new Point(x3, top4);
    clientRectangle4 = this.ClientRectangle;
    int x4 = clientRectangle4.Width - num;
    clientRectangle4 = this.ClientRectangle;
    int y4 = clientRectangle4.Height - num;
    Point pt2_4 = new Point(x4, y4);
    graphics4.DrawLine(pen6, pt1_4, pt2_4);
    pen1.Dispose();
    pen2.Dispose();
  }

  private void DrawFixedBorder(Graphics g)
  {
    Pen pen1 = new Pen(this._borderColor);
    int num = 1;
    Graphics graphics1 = g;
    Pen pen2 = pen1;
    Rectangle clientRectangle1 = this.ClientRectangle;
    int left1 = clientRectangle1.Left;
    clientRectangle1 = this.ClientRectangle;
    int top1 = clientRectangle1.Top;
    Point pt1_1 = new Point(left1, top1);
    clientRectangle1 = this.ClientRectangle;
    int x1 = clientRectangle1.Width - num;
    clientRectangle1 = this.ClientRectangle;
    int top2 = clientRectangle1.Top;
    Point pt2_1 = new Point(x1, top2);
    graphics1.DrawLine(pen2, pt1_1, pt2_1);
    Graphics graphics2 = g;
    Pen pen3 = pen1;
    Rectangle clientRectangle2 = this.ClientRectangle;
    int left2 = clientRectangle2.Left;
    clientRectangle2 = this.ClientRectangle;
    int top3 = clientRectangle2.Top;
    Point pt1_2 = new Point(left2, top3);
    clientRectangle2 = this.ClientRectangle;
    int left3 = clientRectangle2.Left;
    clientRectangle2 = this.ClientRectangle;
    int y1 = clientRectangle2.Height - num;
    Point pt2_2 = new Point(left3, y1);
    graphics2.DrawLine(pen3, pt1_2, pt2_2);
    Graphics graphics3 = g;
    Pen pen4 = pen1;
    Rectangle clientRectangle3 = this.ClientRectangle;
    int left4 = clientRectangle3.Left;
    clientRectangle3 = this.ClientRectangle;
    int y2 = clientRectangle3.Height - num;
    Point pt1_3 = new Point(left4, y2);
    clientRectangle3 = this.ClientRectangle;
    int x2 = clientRectangle3.Width - num;
    clientRectangle3 = this.ClientRectangle;
    int y3 = clientRectangle3.Height - num;
    Point pt2_3 = new Point(x2, y3);
    graphics3.DrawLine(pen4, pt1_3, pt2_3);
    Graphics graphics4 = g;
    Pen pen5 = pen1;
    Rectangle clientRectangle4 = this.ClientRectangle;
    int x3 = clientRectangle4.Width - num;
    clientRectangle4 = this.ClientRectangle;
    int top4 = clientRectangle4.Top;
    Point pt1_4 = new Point(x3, top4);
    clientRectangle4 = this.ClientRectangle;
    int x4 = clientRectangle4.Width - num;
    clientRectangle4 = this.ClientRectangle;
    int y4 = clientRectangle4.Height - num;
    Point pt2_4 = new Point(x4, y4);
    graphics4.DrawLine(pen5, pt1_4, pt2_4);
    pen1.Dispose();
  }

  protected override void OnResize(EventArgs e)
  {
    this._startPosition = (int) Math.Round(0.0 - (double) this.Width / 2.0);
    this.Invalidate();
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    using (Pen pen1 = new Pen(this.BackColor))
    {
      try
      {
        if (this.Timer1.Enabled)
        {
          Rectangle rect = new Rectangle(this._startPosition, e.ClipRectangle.Y, (int) Math.Round((double) e.ClipRectangle.Width / 2.0), e.ClipRectangle.Height);
          LinearGradientBrush linearGradientBrush = (LinearGradientBrush) null;
          try
          {
            if (rect.Width > 0)
            {
              if (rect.Height > 0)
              {
                linearGradientBrush = !this._forwardFlag ? new LinearGradientBrush(rect, this._bounceColor, this.BackColor, LinearGradientMode.Horizontal) : new LinearGradientBrush(rect, this.BackColor, this._bounceColor, LinearGradientMode.Horizontal);
                e.Graphics.FillRectangle((Brush) linearGradientBrush, rect);
              }
            }
          }
          finally
          {
            linearGradientBrush?.Dispose();
          }
          if (this._forwardFlag)
          {
            Graphics graphics = e.Graphics;
            Pen pen2 = pen1;
            int startPosition1 = this._startPosition;
            Rectangle clipRectangle = e.ClipRectangle;
            int y = clipRectangle.Y;
            int startPosition2 = this._startPosition;
            clipRectangle = e.ClipRectangle;
            int height = clipRectangle.Height;
            graphics.DrawLine(pen2, startPosition1, y, startPosition2, height);
          }
        }
        else
          e.Graphics.DrawRectangle(pen1, e.ClipRectangle);
        if (this._borderStyle == BorderStyle.Fixed3D)
        {
          this.Draw3DBorder(e.Graphics);
        }
        else
        {
          if (this._borderStyle != BorderStyle.FixedSingle)
            return;
          this.DrawFixedBorder(e.Graphics);
        }
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void Timer1_Tick(object sender, EventArgs e)
  {
    if (this._startPosition >= this.Width)
      this._forwardFlag = false;
    else if ((double) this._startPosition + (double) this.Width / 2.0 <= 0.0)
      this._forwardFlag = true;
    if (this._forwardFlag)
    {
      // ISSUE: variable of a reference type
      int& local;
      // ISSUE: explicit reference operation
      int num = ^(local = ref this._startPosition) + 1;
      local = num;
    }
    else
    {
      // ISSUE: variable of a reference type
      int& local;
      // ISSUE: explicit reference operation
      int num = ^(local = ref this._startPosition) - 1;
      local = num;
    }
    this.Invalidate();
  }
}
