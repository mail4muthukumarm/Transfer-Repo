// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.BaseClasses.MGABaseForm
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools.BaseClasses;

public class MGABaseForm : Form
{
  private IContainer components;
  private Color _Color1;
  private Color _Color2;
  private float _ColorAngle;

  public MGABaseForm()
  {
    this._Color1 = Color.FromArgb(198, 212, 230);
    this._Color2 = Color.White;
    this._ColorAngle = 30f;
    this.InitializeComponent();
    this.SetStyle(ControlStyles.ResizeRedraw, true);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(292, 266);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (MGABaseForm);
    this.Text = nameof (MGABaseForm);
  }

  public Color Color1
  {
    get => this._Color1;
    set
    {
      this._Color1 = value;
      this.Invalidate();
    }
  }

  public Color Color2
  {
    get => this._Color2;
    set
    {
      this._Color2 = value;
      this.Invalidate();
    }
  }

  public float ColorAngle
  {
    get => this._ColorAngle;
    set
    {
      this._ColorAngle = value;
      this.Invalidate();
    }
  }

  protected override void OnPaintBackground(PaintEventArgs pevent)
  {
    Graphics graphics = pevent.Graphics;
    Rectangle rect1 = new Rectangle(0, 0, this.Width, this.Height);
    LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush(rect1, this._Color1, this._Color2, this._ColorAngle);
    LinearGradientBrush linearGradientBrush2 = linearGradientBrush1;
    Rectangle rect2 = rect1;
    graphics.FillRectangle((Brush) linearGradientBrush2, rect2);
    linearGradientBrush1.Dispose();
  }
}
