// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.BindPolicy.frmCreatingInvoicesPleaseWait
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win.Misc.CommonControls;
using Infragistics.Win.UltraWinProgressBar;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.BindPolicy;

public sealed class frmCreatingInvoicesPleaseWait : Form
{
  private IContainer components;
  private Panel Panel1;

  public frmCreatingInvoicesPleaseWait() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("progress")]
  internal virtual UltraProgressBar progress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.Panel1 = new Panel();
    this.progress = new UltraProgressBar();
    AnimationControl animationControl = new AnimationControl();
    Label label = new Label();
    this.Panel1.SuspendLayout();
    this.SuspendLayout();
    animationControl.AnimationSource = (AnimationType) 160 /*0xA0*/;
    animationControl.AutoCenter = true;
    animationControl.AutoPlay = true;
    animationControl.BorderStyle = BorderStyle.None;
    ((Control) animationControl).Location = new Point(7, 64 /*0x40*/);
    ((Control) animationControl).Name = "AnimationControl1";
    ((Control) animationControl).Size = new Size(488, 56);
    ((Control) animationControl).TabIndex = 0;
    label.AutoSize = true;
    label.Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label.Location = new Point(126, 24);
    label.Name = "Label1";
    label.Size = new Size(246, 19);
    label.TabIndex = 1;
    label.Text = "Creating Invoices... Please Wait...";
    this.Panel1.BorderStyle = BorderStyle.FixedSingle;
    this.Panel1.Controls.Add((Control) this.progress);
    this.Panel1.Controls.Add((Control) label);
    this.Panel1.Controls.Add((Control) animationControl);
    this.Panel1.Dock = DockStyle.Fill;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(504, 161);
    this.Panel1.TabIndex = 2;
    ((Control) this.progress).Location = new Point(11, 126);
    ((Control) this.progress).Name = "progress";
    ((Control) this.progress).Size = new Size(480, 17);
    ((Control) this.progress).TabIndex = 3;
    this.progress.Text = "[Formatted]";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(504, 161);
    this.Controls.Add((Control) this.Panel1);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (frmCreatingInvoicesPleaseWait);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmCreatingInvoicesPleaseWait);
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.ResumeLayout(false);
  }

  internal void SetText(string text) => this.progress.Text = text;

  internal void SetProgressBarMax(int maximum) => this.progress.Maximum = maximum;

  internal void MoveProgress()
  {
    UltraProgressBar progress;
    int num = (progress = this.progress).Value + 1;
    progress.Value = num;
  }
}
