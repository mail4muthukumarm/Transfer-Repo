// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.GenericCheckBox
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

public class GenericCheckBox : BaseReportControl
{
  private IContainer components;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("chk")]
  internal virtual CheckBox chk { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.chk = new CheckBox();
    this.SuspendLayout();
    this.lblDescription.Name = "lblDescription";
    this.chk.Location = new Point(88, 10);
    this.chk.Name = "chk";
    this.chk.Size = new Size(296, 16 /*0x10*/);
    this.chk.TabIndex = 2;
    this.Controls.Add((Control) this.chk);
    this.Name = nameof (GenericCheckBox);
    this.Size = new Size(392, 32 /*0x20*/);
    this.Controls.SetChildIndex((Control) this.chk, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.ResumeLayout(false);
  }

  public GenericCheckBox(string LabelText, string CheckboxText)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    this.chk.Text = CheckboxText;
    this.InitialSize = this.Size;
  }

  public GenericCheckBox(string LabelText, string CheckboxText, bool StartAsChecked)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    this.chk.Text = CheckboxText;
    if (StartAsChecked)
      this.chk.Checked = true;
    this.InitialSize = this.Size;
  }

  public override void Compress()
  {
    this.chk.Top = 0;
    this.lblDescription.Height = this.chk.Height;
    this.lblDescription.Top = 0;
    this.Height = this.chk.Height;
  }

  public override object Value
  {
    get => (object) this.chk.Checked;
    set => this.chk.Checked = Conversions.ToBoolean(value);
  }
}
