// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.BindPolicy.frmBindPolicyDebugInfo
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.BindPolicy;

public sealed class frmBindPolicyDebugInfo : Form
{
  private IContainer components;
  private TextBox txtDebug;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.txtDebug = new TextBox();
    this.SuspendLayout();
    this.txtDebug.Dock = DockStyle.Fill;
    this.txtDebug.Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtDebug.Location = new Point(0, 0);
    this.txtDebug.Multiline = true;
    this.txtDebug.Name = "txtDebug";
    this.txtDebug.ScrollBars = ScrollBars.Vertical;
    this.txtDebug.Size = new Size(568, 446);
    this.txtDebug.TabIndex = 0;
    this.txtDebug.Text = "";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(568, 446);
    this.Controls.Add((Control) this.txtDebug);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
    this.Name = nameof (frmBindPolicyDebugInfo);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Bind Policy - Debug Info";
    this.ResumeLayout(false);
  }

  public frmBindPolicyDebugInfo(string debugText)
  {
    this.InitializeComponent();
    this.txtDebug.Text = debugText;
  }
}
