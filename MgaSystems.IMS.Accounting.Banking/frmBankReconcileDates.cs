// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.frmBankReconcileDates
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public sealed class frmBankReconcileDates : Form
{
  private IContainer components;

  public frmBankReconcileDates() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual Button btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      Button btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        btnCancel1.Click -= eventHandler;
      this._btnCancel = value;
      Button btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      btnCancel2.Click += eventHandler;
    }
  }

  internal virtual Button btnOK
  {
    get => this._btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOK_Click);
      Button btnOk1 = this._btnOK;
      if (btnOk1 != null)
        btnOk1.Click -= eventHandler;
      this._btnOK = value;
      Button btnOk2 = this._btnOK;
      if (btnOk2 == null)
        return;
      btnOk2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtDateFrom")]
  internal virtual DateTimePicker dtDateFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtDateTo")]
  internal virtual DateTimePicker dtDateTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.btnCancel = new Button();
    this.btnOK = new Button();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.dtDateFrom = new DateTimePicker();
    this.dtDateTo = new DateTimePicker();
    this.SuspendLayout();
    this.btnCancel.Location = new Point(96 /*0x60*/, 64 /*0x40*/);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.TabIndex = 0;
    this.btnCancel.Text = "Cancel";
    this.btnOK.Location = new Point(8, 64 /*0x40*/);
    this.btnOK.Name = "btnOK";
    this.btnOK.TabIndex = 1;
    this.btnOK.Text = "Ok";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(61, 16 /*0x10*/);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "From Date:";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(8, 32 /*0x20*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(47, 16 /*0x10*/);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "To Date:";
    this.dtDateFrom.CustomFormat = "MM/dd/yyyy";
    this.dtDateFrom.Format = DateTimePickerFormat.Custom;
    this.dtDateFrom.Location = new Point(88, 8);
    this.dtDateFrom.Name = "dtDateFrom";
    this.dtDateFrom.Size = new Size(88, 20);
    this.dtDateFrom.TabIndex = 4;
    this.dtDateTo.CustomFormat = "MM/dd/yyyy";
    this.dtDateTo.Format = DateTimePickerFormat.Custom;
    this.dtDateTo.Location = new Point(88, 32 /*0x20*/);
    this.dtDateTo.Name = "dtDateTo";
    this.dtDateTo.Size = new Size(88, 20);
    this.dtDateTo.TabIndex = 5;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(186, 96 /*0x60*/);
    this.ControlBox = false;
    this.Controls.Add((Control) this.dtDateTo);
    this.Controls.Add((Control) this.dtDateFrom);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.btnCancel);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmBankReconcileDates);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Reconciliation Dates";
    this.ResumeLayout(false);
  }

  public DateTime FromDate => this.dtDateFrom.Value;

  public DateTime ToDate => this.dtDateTo.Value;

  private void btnOK_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm())
    {
      int num = (int) MessageBox.Show("The 'To' date must be greater then the 'From' date!", "Invalid Dates!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }

  private bool VerifyForm() => DateTime.Compare(this.dtDateFrom.Value, this.dtDateTo.Value) < 0;

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }
}
