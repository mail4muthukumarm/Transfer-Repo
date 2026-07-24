// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.ucBankDeposit
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using MGASystems.IMS.Accounting.Banking.Forms;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public sealed class ucBankDeposit : UserControl
{
  private IContainer components;

  public ucBankDeposit() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual Button Button1
  {
    get => this._Button1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button1_Click);
      Button button1_1 = this._Button1;
      if (button1_1 != null)
        button1_1.Click -= eventHandler;
      this._Button1 = value;
      Button button1_2 = this._Button1;
      if (button1_2 == null)
        return;
      button1_2.Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.Button1 = new Button();
    this.SuspendLayout();
    this.Button1.Location = new Point(496, 80 /*0x50*/);
    this.Button1.Name = "Button1";
    this.Button1.TabIndex = 0;
    this.Button1.Text = "Button1";
    this.Controls.Add((Control) this.Button1);
    this.Name = nameof (ucBankDeposit);
    this.Size = new Size(696, 680);
    this.ResumeLayout(false);
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    frmBankDeposit frmBankDeposit = new frmBankDeposit(1);
    try
    {
      int num = (int) frmBankDeposit.ShowDialog();
    }
    finally
    {
      frmBankDeposit.Dispose();
    }
  }
}
