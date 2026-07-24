// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Banking.Forms.frmBankStartingBalance
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinSchedule;
using Infragistics.Win.UltraWinSchedule.CalendarCombo;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Banking.Services;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Banking.Forms;

public sealed class frmBankStartingBalance : Form
{
  private IContainer components;
  private string _bankName;
  private string _bankAcctNumber;
  private int _bankGLAcct;

  private frmBankStartingBalance()
  {
    this.Load += new EventHandler(this.frmBankStartingBalance_Load);
    this.InitializeComponent();
  }

  public frmBankStartingBalance(string BankName, string BankAccountNumber, int BankGLAccountNumber)
  {
    this.Load += new EventHandler(this.frmBankStartingBalance_Load);
    this.InitializeComponent();
    this._bankName = BankName;
    this._bankAcctNumber = BankAccountNumber;
    this._bankGLAcct = BankGLAccountNumber;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBankName")]
  internal virtual Label lblBankName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblAccountNumber")]
  internal virtual Label lblAccountNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("uccStartingDate")]
  internal virtual UltraCalendarCombo uccStartingDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TextBox txtStartingBalance
  {
    get => this._txtStartingBalance;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtStartingBalance_Leave);
      TextBox txtStartingBalance1 = this._txtStartingBalance;
      if (txtStartingBalance1 != null)
        txtStartingBalance1.Leave -= eventHandler;
      this._txtStartingBalance = value;
      TextBox txtStartingBalance2 = this._txtStartingBalance;
      if (txtStartingBalance2 == null)
        return;
      txtStartingBalance2.Leave += eventHandler;
    }
  }

  internal virtual UltraButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      UltraButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      UltraButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  internal virtual UltraButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      UltraButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      UltraButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    DateButton dateButton = new DateButton();
    Appearance appearance1 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (frmBankStartingBalance));
    Appearance appearance2 = new Appearance();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.lblBankName = new Label();
    this.lblAccountNumber = new Label();
    this.uccStartingDate = new UltraCalendarCombo();
    this.txtStartingBalance = new TextBox();
    this.btnSave = new UltraButton();
    this.btnCancel = new UltraButton();
    ((ISupportInitialize) this.uccStartingDate).BeginInit();
    this.SuspendLayout();
    this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(280, 23);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Bank Name:";
    this.Label1.TextAlign = ContentAlignment.TopCenter;
    this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(8, 128 /*0x80*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(280, 23);
    this.Label2.TabIndex = 9;
    this.Label2.Text = "Starting Balance As Of:";
    this.Label2.TextAlign = ContentAlignment.TopCenter;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(8, 88);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(280, 16 /*0x10*/);
    this.Label3.TabIndex = 8;
    this.Label3.Text = "Starting Balance:";
    this.Label3.TextAlign = ContentAlignment.TopCenter;
    this.Label4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.Location = new Point(8, 48 /*0x30*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(280, 23);
    this.Label4.TabIndex = 6;
    this.Label4.Text = "Account #:";
    this.Label4.TextAlign = ContentAlignment.TopCenter;
    this.lblBankName.Location = new Point(8, 24);
    this.lblBankName.Name = "lblBankName";
    this.lblBankName.Size = new Size(280, 23);
    this.lblBankName.TabIndex = 5;
    this.lblBankName.Text = "Label5";
    this.lblBankName.TextAlign = ContentAlignment.TopCenter;
    this.lblAccountNumber.Location = new Point(8, 64 /*0x40*/);
    this.lblAccountNumber.Name = "lblAccountNumber";
    this.lblAccountNumber.Size = new Size(280, 23);
    this.lblAccountNumber.TabIndex = 7;
    this.lblAccountNumber.Text = "Label5";
    this.lblAccountNumber.TextAlign = ContentAlignment.TopCenter;
    ((UltraMonthViewMultiBase) this.uccStartingDate).BackColor = SystemColors.Window;
    dateButton.Caption = "Today";
    this.uccStartingDate.DateButtons.Add(dateButton);
    ((Control) this.uccStartingDate).Location = new Point(104, 144 /*0x90*/);
    ((Control) this.uccStartingDate).Name = "uccStartingDate";
    this.uccStartingDate.NonAutoSizeHeight = 21;
    ((Control) this.uccStartingDate).Size = new Size(96 /*0x60*/, 21);
    ((Control) this.uccStartingDate).TabIndex = 1;
    this.txtStartingBalance.BorderStyle = BorderStyle.FixedSingle;
    this.txtStartingBalance.Location = new Point(72, 104);
    this.txtStartingBalance.Name = "txtStartingBalance";
    this.txtStartingBalance.Size = new Size(160 /*0xA0*/, 21);
    this.txtStartingBalance.TabIndex = 0;
    this.txtStartingBalance.Text = "";
    this.txtStartingBalance.TextAlign = HorizontalAlignment.Center;
    appearance1.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 1;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnSave).Location = new Point(40, 184);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(100, 23);
    ((Control) this.btnSave).TabIndex = 2;
    ((ControlBase) this.btnSave).Text = "Save";
    appearance2.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance2.Image"));
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnCancel).Location = new Point(152, 184);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(100, 23);
    ((Control) this.btnCancel).TabIndex = 3;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(292, 216);
    this.ControlBox = false;
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.txtStartingBalance);
    this.Controls.Add((Control) this.uccStartingDate);
    this.Controls.Add((Control) this.lblAccountNumber);
    this.Controls.Add((Control) this.lblBankName);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (frmBankStartingBalance);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "             Bank Account Starting Balance";
    ((ISupportInitialize) this.uccStartingDate).EndInit();
    this.ResumeLayout(false);
  }

  private void frmBankStartingBalance_Load(object sender, EventArgs e)
  {
    this.lblBankName.Text = this._bankName;
    this.lblAccountNumber.Text = this._bankAcctNumber;
  }

  private bool VerifyForm()
  {
    bool flag;
    if (Operators.CompareString(this.txtStartingBalance.Text, "", false) == 0 || !Versioned.IsNumeric((object) this.txtStartingBalance.Text))
    {
      int num = (int) MessageBox.Show("You must enter a valid numeric starting balance to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (!Information.IsDate(RuntimeHelpers.GetObjectValue(this.uccStartingDate.Value)))
    {
      int num = (int) MessageBox.Show("You must select a valid starting balance date to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm() || MessageBox.Show("Changes to the bank account starting balance can not be edited. Setting the starting balance is a permanent setting. Do you wish to continue?", "Commit Permanent Change?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
      return;
    this.SaveStartingBalance(Conversions.ToDecimal(this.txtStartingBalance.Text), Conversions.ToDate(this.uccStartingDate.Value));
    int num = (int) MessageBox.Show("Starting balance has been saved successfully!", "Setting Saved!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void DisplayBankStartingBalance()
  {
    Decimal bankStartingBalance = BankingServices.GetBankStartingBalance(this._bankGLAcct);
    if (Decimal.Compare(bankStartingBalance, 0M) != 0)
    {
      this.txtStartingBalance.Text = Strings.Format((object) bankStartingBalance, "Currency");
      this.uccStartingDate.Value = (object) BankingServices.GetBankStartingBalanceDate(this._bankGLAcct);
      this.txtStartingBalance.Enabled = false;
      ((Control) this.uccStartingDate).Enabled = false;
      ((Control) this.btnSave).Enabled = false;
    }
    else
    {
      this.txtStartingBalance.Enabled = true;
      ((Control) this.uccStartingDate).Enabled = true;
      ((Control) this.btnSave).Enabled = true;
    }
  }

  private void SaveStartingBalance(Decimal StartingBalance, DateTime StartingBalanceDate)
  {
    Database.Instance.QuerySP.PerformNonQuery("spFin_InsertBankStartingBalance", (object) "@bankGLAcct", (object) this._bankGLAcct, (object) "@startingBal", (object) StartingBalance, (object) "@startingBalDate", (object) StartingBalanceDate);
  }

  private void txtStartingBalance_Leave(object sender, EventArgs e)
  {
    if (Operators.CompareString(this.txtStartingBalance.Text, "", false) == 0 || !Versioned.IsNumeric((object) this.txtStartingBalance.Text))
      return;
    this.txtStartingBalance.Text = Strings.Format((object) this.txtStartingBalance.Text, "Currency");
  }
}
