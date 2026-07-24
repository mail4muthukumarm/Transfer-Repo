// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Envelopes.EnvelopeLayout
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Envelopes;

public sealed class EnvelopeLayout : UserControl
{
  private IContainer components;
  private Envelope _envelope;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (EnvelopeLayout);
    this.Size = new Size(288, 152);
  }

  public EnvelopeLayout()
  {
    this.Paint += new PaintEventHandler(this.EnvelopeLayout_Paint);
    this.InitializeComponent();
  }

  public Envelope Envelope
  {
    get => this._envelope;
    set => this._envelope = value;
  }

  private void EnvelopeLayout_Paint(object sender, PaintEventArgs e)
  {
    if (this._envelope == null || (double) this._envelope.Width <= 0.0 || (double) this._envelope.Height <= 0.0)
      return;
    float num1 = 12f;
    float width = (float) ((double) this._envelope.Width * (double) num1 + 3.0);
    float height = (float) ((double) this._envelope.Height * (double) num1 + 3.0);
    Decimal d1 = 0M;
    Decimal d2 = 0M;
    if ((double) this.Width < (double) width)
      d1 = new Decimal((float) this.Width / width);
    if ((double) this.Height < (double) height)
      d2 = new Decimal((float) this.Height / height);
    if (Decimal.Compare(d1, d2) > 0)
    {
      width *= Convert.ToSingle(d1);
      height *= Convert.ToSingle(d1);
    }
    else if (Decimal.Compare(d1, d2) < 0)
    {
      width *= Convert.ToSingle(d2);
      height *= Convert.ToSingle(d2);
    }
    int num2 = (int) Math.Round((double) this._envelope.DeliveryAddress.fromTop + (double) height * 0.5);
    int x1_1 = (int) Math.Round((double) this._envelope.DeliveryAddress.fromLeft * ((double) num1 / 0.75));
    int num3 = (int) Math.Round((double) this._envelope.ReturnAddress.fromTop + (double) height * 0.1);
    int x1_2 = (int) Math.Round((double) this._envelope.ReturnAddress.fromLeft * ((double) num1 / 1.75));
    int num4 = (int) Math.Round((double) num1 / 3.0);
    e.Graphics.FillRectangle(Brushes.Black, 3f, 3f, width, height);
    e.Graphics.FillRectangle(Brushes.White, 0.0f, 0.0f, width, height);
    e.Graphics.DrawRectangle(Pens.Black, 0.0f, 0.0f, width, height);
    e.Graphics.FillRectangle(Brushes.Black, width - width / 10f, height / 20f, width / 12f, height / 5f);
    e.Graphics.DrawLine(Pens.DarkGray, x1_1, num2, (int) Math.Round((double) x1_1 + (double) width * 0.25), num2);
    e.Graphics.DrawLine(Pens.DarkGray, x1_1, num2 + 1 * num4, (int) Math.Round((double) x1_1 + (double) width * 0.25), num2 + 1 * num4);
    e.Graphics.DrawLine(Pens.DarkGray, x1_1, num2 + 2 * num4, (int) Math.Round((double) x1_1 + (double) width * 0.25), num2 + 2 * num4);
    e.Graphics.DrawLine(Pens.DarkGray, x1_2, num3, (int) Math.Round((double) x1_2 + (double) width * 0.2), num3);
    e.Graphics.DrawLine(Pens.DarkGray, x1_2, num3 + 1 * num4, (int) Math.Round((double) x1_2 + (double) width * 0.2), num3 + 1 * num4);
    e.Graphics.DrawLine(Pens.DarkGray, x1_2, num3 + 2 * num4, (int) Math.Round((double) x1_2 + (double) width * 0.2), num3 + 2 * num4);
  }
}
