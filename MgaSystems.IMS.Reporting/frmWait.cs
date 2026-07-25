// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.frmWait
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class frmWait : Form
{
  private IContainer components;
  private Label Label1;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.Label1 = new Label();
    this.SuspendLayout();
    this.Label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.Label1.BorderStyle = BorderStyle.FixedSingle;
    this.Label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(0, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(328, 40);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Waiting...";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(328, 40);
    this.Controls.Add((Control) this.Label1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (frmWait);
    this.Text = nameof (frmWait);
    this.ResumeLayout(false);
  }

  public frmWait(string waitingText)
  {
    this.InitializeComponent();
    this.Label1.Text = waitingText;
  }
}
