// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.RadioSelection
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

public class RadioSelection : BaseReportControl
{
  private object _RadioOneValue;
  private object _RadioTwoValue;
  private IContainer components;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("RadioOne")]
  internal virtual RadioButton RadioOne { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("RadioTwo")]
  internal virtual RadioButton RadioTwo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.RadioOne = new RadioButton();
    this.RadioTwo = new RadioButton();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 42);
    this.RadioOne.Location = new Point(88, 6);
    this.RadioOne.Name = "RadioOne";
    this.RadioOne.Size = new Size(304, 16 /*0x10*/);
    this.RadioOne.TabIndex = 1;
    this.RadioOne.Text = "RadioButton1";
    this.RadioTwo.Location = new Point(88, 22);
    this.RadioTwo.Name = "RadioTwo";
    this.RadioTwo.Size = new Size(304, 16 /*0x10*/);
    this.RadioTwo.TabIndex = 2;
    this.RadioTwo.Text = "RadioButton2";
    this.Controls.Add((Control) this.RadioTwo);
    this.Controls.Add((Control) this.RadioOne);
    this.Name = nameof (RadioSelection);
    this.Size = new Size(392, 44);
    this.Controls.SetChildIndex((Control) this.RadioOne, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.RadioTwo, 0);
    this.ResumeLayout(false);
  }

  public RadioSelection(
    string LabelText,
    string RadioOneText,
    object RadioOneValue,
    string RadioTwoText,
    object RadioTwoValue,
    RadioSelection.ButtonLayout LayoutStyle)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    this.RadioOne.Text = RadioOneText;
    this.RadioTwo.Text = RadioTwoText;
    this._RadioOneValue = RuntimeHelpers.GetObjectValue(RadioOneValue);
    this._RadioTwoValue = RuntimeHelpers.GetObjectValue(RadioTwoValue);
    // ISSUE: reference to a compiler-generated field
    this._RadioOne.Checked = true;
    if (LayoutStyle == RadioSelection.ButtonLayout.Horizontal)
    {
      this.RadioOne.Width = 152;
      this.RadioOne.Height = 32 /*0x20*/;
      this.RadioOne.Left = 88;
      this.RadioOne.Top = 0;
      this.RadioTwo.Width = 152;
      this.RadioTwo.Height = 32 /*0x20*/;
      this.RadioTwo.Left = 240 /*0xF0*/;
      this.RadioTwo.Top = 0;
    }
    else
    {
      this.RadioOne.Width = 304;
      this.RadioOne.Height = 16 /*0x10*/;
      this.RadioOne.Left = 88;
      this.RadioOne.Top = 0;
      this.RadioTwo.Width = 304;
      this.RadioTwo.Height = 16 /*0x10*/;
      this.RadioTwo.Left = 88;
      this.RadioTwo.Top = 16 /*0x10*/;
    }
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get => !this.RadioTwo.Checked ? this._RadioOneValue : this._RadioTwoValue;
    set
    {
      if (Operators.CompareString(value.ToString(), this._RadioOneValue.ToString(), false) == 0)
      {
        this.RadioOne.Checked = true;
        this.RadioTwo.Checked = false;
      }
      else
      {
        this.RadioOne.Checked = false;
        this.RadioTwo.Checked = true;
      }
    }
  }

  public override void Compress()
  {
    this.RadioOne.Top = 0;
    this.RadioTwo.Top = this.RadioOne.Height;
    this.lblDescription.Height = this.RadioTwo.Top + this.RadioTwo.Height;
    this.lblDescription.Top = 0;
    this.Height = this.lblDescription.Height;
  }

  public enum ButtonLayout
  {
    Vertical,
    Horizontal,
  }
}
