// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Administration.frmTextInfo
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Administration;

[DesignerGenerated]
public class frmTextInfo : Form
{
  private IContainer components;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
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
    this.txtDebug.Size = new Size(398, 320);
    this.txtDebug.TabIndex = 1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(398, 320);
    this.Controls.Add((Control) this.txtDebug);
    this.Name = nameof (frmTextInfo);
    this.Text = "Text Info";
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("txtDebug")]
  private virtual TextBox txtDebug { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmTextInfo(string showText, string formLabel = "Log Information")
  {
    this.InitializeComponent();
    this.txtDebug.Text = showText;
    this.Text = formLabel;
  }
}
