// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.AccountingReportControls.DepositPostDatePicker
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using MGASystems.IMS.Reporting.ReportControls;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports.AccountingReportControls;

public sealed class DepositPostDatePicker : BaseReportControl
{
  private IContainer components;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("rbDepositDate")]
  internal virtual RadioButton rbDepositDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbPostDate")]
  internal virtual RadioButton rbPostDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.rbDepositDate = new RadioButton();
    this.rbPostDate = new RadioButton();
    this.SuspendLayout();
    this.rbDepositDate.Checked = true;
    this.rbDepositDate.Location = new Point(88, 0);
    this.rbDepositDate.Name = "rbDepositDate";
    this.rbDepositDate.Size = new Size(104, 32 /*0x20*/);
    this.rbDepositDate.TabIndex = 1;
    this.rbDepositDate.TabStop = true;
    this.rbDepositDate.Text = "Deposit Date";
    this.rbPostDate.Location = new Point(192 /*0xC0*/, 0);
    this.rbPostDate.Name = "rbPostDate";
    this.rbPostDate.Size = new Size(104, 32 /*0x20*/);
    this.rbPostDate.TabIndex = 2;
    this.rbPostDate.Text = "Post Date";
    this.Controls.Add((Control) this.rbPostDate);
    this.Controls.Add((Control) this.rbDepositDate);
    this.Name = nameof (DepositPostDatePicker);
    this.Size = new Size(296, 32 /*0x20*/);
    this.Controls.SetChildIndex((Control) this.rbDepositDate, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.rbPostDate, 0);
    this.ResumeLayout(false);
  }

  public DepositPostDatePicker(string LabelText)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get => (object) this.rbDepositDate.Checked;
    set
    {
      if ((bool) value)
      {
        this.rbDepositDate.Checked = true;
        this.rbPostDate.Checked = false;
      }
      else
      {
        this.rbDepositDate.Checked = false;
        this.rbPostDate.Checked = true;
      }
    }
  }

  public override void Compress()
  {
    this.rbDepositDate.Top = 0;
    this.rbPostDate.Top = 0;
    this.rbDepositDate.Height = 20;
    this.rbPostDate.Height = 20;
    this.lblDescription.Height = 20;
    this.lblDescription.Top = 0;
    this.Height = 20;
  }
}
