// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.AccountingReportControls.Producers_Checked
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using MGASystems.IMS.Reporting.ReportControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports.AccountingReportControls;

public class Producers_Checked : Producers
{
  private IContainer components;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual CheckBox chk
  {
    get => this._chk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chk_CheckedChanged);
      CheckBox chk1 = this._chk;
      if (chk1 != null)
        chk1.CheckedChanged -= eventHandler;
      this._chk = value;
      CheckBox chk2 = this._chk;
      if (chk2 == null)
        return;
      chk2.CheckedChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.chk = new CheckBox();
    ((ISupportInitialize) this.combo).BeginInit();
    this.SuspendLayout();
    ((Control) this.combo).Location = new Point(88, 27);
    this.lblDescription.Size = new Size(88, 53);
    this.chk.Checked = true;
    this.chk.CheckState = CheckState.Checked;
    this.chk.Location = new Point(88, 6);
    this.chk.Name = "chk";
    this.chk.Size = new Size(296, 16 /*0x10*/);
    this.chk.TabIndex = 2;
    this.chk.Text = "Show {0}";
    this.Controls.Add((Control) this.chk);
    this.Name = nameof (Producers_Checked);
    this.Size = new Size(392, 53);
    this.Value = (object) "";
    this.Controls.SetChildIndex((Control) this.chk, 0);
    this.Controls.SetChildIndex((Control) this.combo, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.combo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public Producers_Checked(string LabelText, bool ShowAll)
    : base(LabelText, ShowAll)
  {
    this.InitializeComponent();
    this.chk.Text = string.Format(this.chk.Text, (object) LabelText);
    this.InitialSize = this.Size;
  }

  private void chk_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.combo).Enabled = this.chk.Checked;
  }

  public override object Value
  {
    get
    {
      return (object) new object[2]
      {
        (object) this.chk.Checked,
        this.combo.Value
      };
    }
    set
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(value)) || Information.IsNothing(RuntimeHelpers.GetObjectValue(value)) || Operators.CompareString(value.ToString(), "", false) == 0)
        return;
      object[] objArray = (object[]) value;
      this.chk.Checked = (bool) objArray[0];
      this.combo.Value = RuntimeHelpers.GetObjectValue(objArray[1]);
    }
  }

  public override void Compress()
  {
    this.chk.Top = 0;
    ((Control) this.combo).Top = this.chk.Height;
    this.lblDescription.Height = checked (this.chk.Height + ((Control) this.combo).Height);
    this.lblDescription.Top = 0;
    this.Height = checked (this.chk.Height + ((Control) this.combo).Height);
  }
}
