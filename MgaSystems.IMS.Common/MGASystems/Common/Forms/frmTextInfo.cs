// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Forms.frmTextInfo
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.Forms;

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
    this.txtDebug.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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

  private virtual TextBox txtDebug
  {
    get => this._txtDebug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDebug_KeyDown);
      TextBox txtDebug1 = this._txtDebug;
      if (txtDebug1 != null)
        txtDebug1.KeyDown -= keyEventHandler;
      this._txtDebug = value;
      TextBox txtDebug2 = this._txtDebug;
      if (txtDebug2 == null)
        return;
      txtDebug2.KeyDown += keyEventHandler;
    }
  }

  public frmTextInfo(string showText, string formLabel = "Log Information")
  {
    this.InitializeComponent();
    this.txtDebug.Text = showText;
    this.Text = formLabel;
  }

  private void txtDebug_KeyDown(object sender, KeyEventArgs e)
  {
    if (!e.Control || e.KeyCode != Keys.A)
      return;
    ((TextBoxBase) sender)?.SelectAll();
    e.Handled = true;
  }
}
