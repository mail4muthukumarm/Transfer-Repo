// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.FormBase
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public class FormBase : Form
{
  private bool disableCustomDrawing;

  public FormBase()
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
    if (this.disableCustomDrawing || this.ClientRectangle.Width == 0 || this.ClientRectangle.Height == 0)
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

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormBase));
    this.SuspendLayout();
    this.ClientSize = new Size(284, 262);
    this.Font = new Font("Tahoma", 8.25f);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormBase);
    this.ResumeLayout(false);
  }

  protected Control FindControl(string name)
  {
    Control control1;
    try
    {
      foreach (Control control2 in this.Controls)
      {
        if (Operators.CompareString(control2.Name, name, false) == 0)
        {
          control1 = control2;
          goto label_8;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    control1 = (Control) null;
label_8:
    return control1;
  }
}
