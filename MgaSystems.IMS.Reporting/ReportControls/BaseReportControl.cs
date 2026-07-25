// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.BaseReportControl
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class BaseReportControl : UserControl
{
  private IContainer components;
  private Size _InitialSize;

  public BaseReportControl()
  {
    this._InitialSize = new Size();
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("lblDescription")]
  protected virtual Label lblDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.lblDescription = new Label();
    this.SuspendLayout();
    this.lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblDescription.Location = new Point(0, 0);
    this.lblDescription.Name = "lblDescription";
    this.lblDescription.Size = new Size(88, 32 /*0x20*/);
    this.lblDescription.TabIndex = 0;
    this.lblDescription.Text = "[Description]";
    this.lblDescription.TextAlign = ContentAlignment.MiddleLeft;
    this.Controls.Add((Control) this.lblDescription);
    this.Name = nameof (BaseReportControl);
    this.Size = new Size(248, 32 /*0x20*/);
    this.ResumeLayout(false);
  }

  public string Description
  {
    get => this.lblDescription.Text;
    set => this.lblDescription.Text = value;
  }

  public int InitialHeight
  {
    get => this._InitialSize.Height;
    set => this._InitialSize.Height = value;
  }

  public int InitialWidth
  {
    get => this._InitialSize.Width;
    set => this._InitialSize.Width = value;
  }

  public Size InitialSize
  {
    get => this._InitialSize;
    set => this._InitialSize = value;
  }

  public bool IsInputValid
  {
    get => Operators.CompareString(this.InputErrorMessage, string.Empty, false) == 0;
  }

  public virtual string InputErrorMessage => string.Empty;

  public virtual object Value
  {
    get => (object) string.Empty;
    set
    {
    }
  }

  public virtual void Compress()
  {
  }

  public virtual void AdjustWidth(int NewWidth)
  {
    this.MaximumSize = new Size(NewWidth, this.Size.Height);
    this.Width = NewWidth;
  }
}
