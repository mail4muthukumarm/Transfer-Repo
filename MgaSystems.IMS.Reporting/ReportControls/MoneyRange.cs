// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.MoneyRange
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class MoneyRange : BaseReportControl
{
  private IContainer components;
  private bool _Optional;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("txtFrom")]
  internal virtual TextBox txtFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTo")]
  internal virtual TextBox txtTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.txtFrom = new TextBox();
    this.txtTo = new TextBox();
    this.Label1 = new Label();
    this.SuspendLayout();
    this.txtFrom.Location = new Point(88, 6);
    this.txtFrom.Name = "txtFrom";
    this.txtFrom.Size = new Size(100, 20);
    this.txtFrom.TabIndex = 1;
    this.txtTo.Location = new Point(224 /*0xE0*/, 6);
    this.txtTo.Name = "txtTo";
    this.txtTo.Size = new Size(100, 20);
    this.txtTo.TabIndex = 2;
    this.Label1.Location = new Point(200, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(16 /*0x10*/, 30);
    this.Label1.TabIndex = 3;
    this.Label1.Text = "to";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtTo);
    this.Controls.Add((Control) this.txtFrom);
    this.Name = nameof (MoneyRange);
    this.Size = new Size(336, 32 /*0x20*/);
    this.Controls.SetChildIndex((Control) this.txtFrom, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.txtTo, 0);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public MoneyRange(string Description)
    : this(Description, false)
  {
    this.InitialSize = this.Size;
  }

  public MoneyRange(string Description, bool InputOptional)
  {
    this._Optional = false;
    this.InitializeComponent();
    this._Optional = InputOptional;
    this.Description = Description;
    this.InitialSize = this.Size;
  }

  public override string InputErrorMessage
  {
    get
    {
      return !this._Optional || this.txtTo.Text.Trim().Length != 0 || this.txtFrom.Text.Trim().Length != 0 ? (Strings.Trim(this.txtFrom.Text).Length == 0 || Strings.Trim(this.txtTo.Text).Length == 0 ? "Both Fields are required." : (!Versioned.IsNumeric((object) this.txtFrom.Text) || !Versioned.IsNumeric((object) this.txtTo.Text) ? "Input must be numeric." : (Decimal.Compare(Conversions.ToDecimal(this.txtFrom.Text), Conversions.ToDecimal(this.txtTo.Text)) <= 0 ? string.Empty : "Invalid Range"))) : string.Empty;
    }
  }

  public override object Value
  {
    get
    {
      Decimal num1 = 0M;
      Decimal num2 = 0M;
      if (Strings.Trim(this.txtFrom.Text).Length > 0)
        num1 = Conversions.ToDecimal(this.txtFrom.Text);
      if (Strings.Trim(this.txtFrom.Text).Length > 0)
        num2 = Conversions.ToDecimal(this.txtTo.Text);
      return (object) new object[2]
      {
        (object) num1,
        (object) num2
      };
    }
    set
    {
      object[] objArray = (object[]) value;
      this.txtFrom.Text = objArray[0] != null ? Conversions.ToString((Decimal) objArray[0]) : (string) null;
      if (objArray[1] == null)
        this.txtTo.Text = (string) null;
      else
        this.txtTo.Text = Conversions.ToString((Decimal) objArray[1]);
    }
  }

  public override void Compress()
  {
    this.txtFrom.Top = 0;
    this.txtTo.Top = 0;
    this.lblDescription.Top = 0;
    this.Label1.Top = 0;
    this.lblDescription.Height = this.txtTo.Height;
    this.Label1.Height = this.txtTo.Height;
    this.Height = this.txtTo.Height;
  }
}
