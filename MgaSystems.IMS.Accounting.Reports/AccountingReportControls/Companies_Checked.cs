// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.AccountingReportControls.Companies_Checked
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using MGASystems.IMS.Reporting.ReportControls;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports.AccountingReportControls;

public class Companies_Checked : GenericListBox
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
    ((ISupportInitialize) this.clbGeneric).BeginInit();
    this.SuspendLayout();
    this.clbGeneric.Location = new Point(88, 24);
    this.lblDescription.Size = new Size(88, 94);
    this.chk.Checked = true;
    this.chk.CheckState = CheckState.Checked;
    this.chk.Location = new Point(88, 3);
    this.chk.Name = "chk";
    this.chk.Size = new Size(296, 16 /*0x10*/);
    this.chk.TabIndex = 2;
    this.chk.Text = "Show {0}";
    this.Controls.Add((Control) this.chk);
    this.Name = nameof (Companies_Checked);
    this.Size = new Size(392, 94);
    this.Controls.SetChildIndex((Control) this.chk, 0);
    this.Controls.SetChildIndex((Control) this.clbGeneric, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.clbGeneric).EndInit();
    this.ResumeLayout(false);
  }

  public Companies_Checked(string LabelText, bool ShowAll)
    : base(LabelText, "SELECT CompanyName, CompanyGuid FROM tblCompanies ORDER BY CompanyName", "CompanyGuid", "CompanyName", ShowAll)
  {
    this.InitializeComponent();
    this.chk.Text = string.Format(this.chk.Text, (object) LabelText);
    this.InitialSize = this.Size;
  }

  public Companies_Checked(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption,
    Type ReturnType)
    : base(LabelText, SQLText, ValueMember, DisplayMember, ShowAllOption, ReturnType)
  {
    this.InitializeComponent();
    this.chk.Text = string.Format(this.chk.Text, (object) LabelText);
    this.InitialSize = this.Size;
  }

  public Companies_Checked(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption,
    Type ReturnType,
    bool CheckAllItem)
    : base(LabelText, SQLText, ValueMember, DisplayMember, ShowAllOption, ReturnType, CheckAllItem)
  {
    this.InitializeComponent();
    this.chk.Text = string.Format(this.chk.Text, (object) LabelText);
    this.InitialSize = this.Size;
  }

  public Companies_Checked(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption,
    Type ReturnType,
    bool CheckAllItem,
    bool ReturnAll)
    : base(LabelText, SQLText, ValueMember, DisplayMember, ShowAllOption, ReturnType, CheckAllItem, ReturnAll)
  {
    this.InitializeComponent();
    this.chk.Text = string.Format(this.chk.Text, (object) LabelText);
    this.InitialSize = this.Size;
  }

  private void chk_CheckedChanged(object sender, EventArgs e)
  {
    this.clbGeneric.Enabled = this.chk.Checked;
  }

  public override object Value
  {
    get
    {
      return (object) new object[2]
      {
        (object) this.chk.Checked,
        base.Value
      };
    }
    set
    {
      object[] objArray = (object[]) value;
      this.chk.Checked = (bool) objArray[0];
      base.Value = RuntimeHelpers.GetObjectValue(objArray[1]);
    }
  }

  public override void Compress()
  {
    this.chk.Top = 0;
    this.clbGeneric.Top = this.chk.Height;
    this.lblDescription.Height = checked (this.chk.Height + this.clbGeneric.Height);
    this.lblDescription.Top = 0;
    this.Height = checked (this.chk.Height + this.clbGeneric.Height);
  }
}
