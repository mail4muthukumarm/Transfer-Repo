// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.BankManagementAccount
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

[DesignerGenerated]
public class BankManagementAccount : UserControl
{
  private IContainer components;
  private int _glAcctId;
  private string _bankName;
  private string _bankAccountNumber;
  private string _glAccountFullName;
  private string _glAccountShortName;
  private bool _selected;
  private int _index;

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
    this.Label1 = new Label();
    this.labelBankName = new Label();
    this.labelBankAccountNumber = new Label();
    this.labelGLAccountName = new Label();
    this.labelGLShortName = new Label();
    this.SuspendLayout();
    this.Label1.BackColor = Color.FromArgb(200, 220, 245);
    this.Label1.Dock = DockStyle.Top;
    this.Label1.Font = new Font("Tahoma", 10f, FontStyle.Bold);
    this.Label1.ForeColor = Color.DimGray;
    this.Label1.Location = new Point(0, 0);
    this.Label1.Margin = new Padding(8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(275, 20);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "CHECKING";
    this.labelBankName.AutoSize = true;
    this.labelBankName.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.labelBankName.Location = new Point(3, 21);
    this.labelBankName.Name = "labelBankName";
    this.labelBankName.Size = new Size(84, 14);
    this.labelBankName.TabIndex = 1;
    this.labelBankName.Text = "[Bank Name]";
    this.labelBankAccountNumber.AutoSize = true;
    this.labelBankAccountNumber.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.labelBankAccountNumber.Location = new Point(3, 41);
    this.labelBankAccountNumber.Name = "labelBankAccountNumber";
    this.labelBankAccountNumber.Size = new Size(153, 14);
    this.labelBankAccountNumber.TabIndex = 2;
    this.labelBankAccountNumber.Text = "[Bank Account Number]";
    this.labelGLAccountName.AutoSize = true;
    this.labelGLAccountName.Font = new Font("Tahoma", 9f);
    this.labelGLAccountName.Location = new Point(3, 61);
    this.labelGLAccountName.Name = "labelGLAccountName";
    this.labelGLAccountName.Size = new Size(116, 14);
    this.labelGLAccountName.TabIndex = 3;
    this.labelGLAccountName.Text = "[GL Account Name]";
    this.labelGLShortName.AutoSize = true;
    this.labelGLShortName.Font = new Font("Tahoma", 9f);
    this.labelGLShortName.Location = new Point(3, 81);
    this.labelGLShortName.Name = "labelGLShortName";
    this.labelGLShortName.Size = new Size(150, 14);
    this.labelGLShortName.TabIndex = 4;
    this.labelGLShortName.Text = "[GL Account Short Name]";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.BorderStyle = BorderStyle.FixedSingle;
    this.Controls.Add((Control) this.labelGLShortName);
    this.Controls.Add((Control) this.labelGLAccountName);
    this.Controls.Add((Control) this.labelBankAccountNumber);
    this.Controls.Add((Control) this.labelBankName);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (BankManagementAccount);
    this.Size = new Size(275, 99);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelBankName")]
  internal virtual Label labelBankName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelBankAccountNumber")]
  internal virtual Label labelBankAccountNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelGLAccountName")]
  internal virtual Label labelGLAccountName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelGLShortName")]
  internal virtual Label labelGLShortName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public event BankManagementAccount.ControlSelectedEventHandler ControlSelected;

  public int GLAccountId => this._glAcctId;

  public string BankName => this._bankName;

  public string BankAccountNumber => this._bankAccountNumber;

  public string GLAccountFullName => this._glAccountFullName;

  public string GLAccountShortName => this._glAccountShortName;

  public bool Selected
  {
    get => this._selected;
    set
    {
      if (this.Selected && value)
        return;
      this._selected = value;
      if (value)
      {
        this.BackColor = Color.LemonChiffon;
        BankManagementAccount.ControlSelectedEventHandler controlSelectedEvent = this.ControlSelectedEvent;
        if (controlSelectedEvent == null)
          return;
        BankManagementAccount.ControlSelectedEventHandler selectedEventHandler = controlSelectedEvent;
        BankManagementAccount managementAccount = this;
        ref BankManagementAccount local = ref managementAccount;
        selectedEventHandler(ref local);
      }
      else
        this.BackColor = Color.White;
    }
  }

  public int Index => this._index;

  public BankManagementAccount()
  {
    this.Click += new EventHandler(this.BankManagementAccount_Click);
    this.InitializeComponent();
  }

  public BankManagementAccount(
    int glAccountId,
    string bankName,
    string bankAccountNumber,
    string glAccountFullName,
    string glAccountShortName,
    int index)
  {
    this.Click += new EventHandler(this.BankManagementAccount_Click);
    this.InitializeComponent();
    this._glAcctId = glAccountId;
    this._bankName = bankName;
    this._bankAccountNumber = bankAccountNumber;
    this._glAccountFullName = glAccountFullName;
    this._glAccountShortName = glAccountShortName;
    this._index = index;
    this._selected = false;
  }

  public void DisplayBankInformation()
  {
    this.labelBankName.Text = this._bankName;
    this.labelBankAccountNumber.Text = this._bankAccountNumber;
    this.labelGLAccountName.Text = this._glAccountFullName;
    this.labelGLShortName.Text = this._glAccountShortName;
  }

  private void BankManagementAccount_Click(object sender, EventArgs e) => this.Selected = true;

  public delegate void ControlSelectedEventHandler(ref BankManagementAccount sender);
}
