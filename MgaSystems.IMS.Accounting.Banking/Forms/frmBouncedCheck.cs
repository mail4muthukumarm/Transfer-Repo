// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmBouncedCheck
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinSchedule;
using Infragistics.Win.UltraWinSchedule.CalendarCombo;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Banking.Services;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

[SecureResource("{17ADC292-7269-4a90-AF7A-7B0200571153}", "Bounce Check Rights", "Determines whether the user will have rights to bounce a check in the bank management screen.", "Accounting")]
public class frmBouncedCheck : FormBase
{
  private IContainer components;
  private int _depositId;
  private string _bankName;
  private DateTime _depositDate;
  private string _accountNumber;
  private string _depositStatus;

  public frmBouncedCheck()
  {
    this.Load += new EventHandler(this.frmBouncedCheck_Load);
    this.InitializeComponent();
  }

  public frmBouncedCheck(
    int DepositId,
    string BankName,
    DateTime DepositDate,
    string AccountNumber,
    string DepositStatus)
  {
    this.Load += new EventHandler(this.frmBouncedCheck_Load);
    this.InitializeComponent();
    this._depositId = DepositId;
    this._bankName = BankName;
    this._depositDate = DepositDate;
    this._accountNumber = AccountNumber;
    this._depositStatus = DepositStatus;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  protected virtual UltraButton btnClose
  {
    get => this._btnClose;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnClose_Click);
      UltraButton btnClose1 = this._btnClose;
      if (btnClose1 != null)
        ((Control) btnClose1).Click -= eventHandler;
      this._btnClose = value;
      UltraButton btnClose2 = this._btnClose;
      if (btnClose2 == null)
        return;
      ((Control) btnClose2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  protected virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  protected virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  protected virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridCashReceipts")]
  protected virtual UltraGrid gridCashReceipts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBankName")]
  protected virtual Label lblBankName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBankAccountNumber")]
  protected virtual Label lblBankAccountNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDepositDate")]
  protected virtual Label lblDepositDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDepositStatus")]
  protected virtual Label lblDepositStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lTransactionDate")]
  internal virtual Label lTransactionDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dateOfBouncedCheck")]
  internal virtual UltraCalendarCombo dateOfBouncedCheck { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraButton btnBounceCheck
  {
    get => this._btnBounceCheck;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnBounceCheck_Click);
      UltraButton btnBounceCheck1 = this._btnBounceCheck;
      if (btnBounceCheck1 != null)
        ((Control) btnBounceCheck1).Click -= eventHandler;
      this._btnBounceCheck = value;
      UltraButton btnBounceCheck2 = this._btnBounceCheck;
      if (btnBounceCheck2 == null)
        return;
      ((Control) btnBounceCheck2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBouncedCheck));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    DateButton dateButton = new DateButton();
    this.btnClose = new UltraButton();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label5 = new Label();
    this.lblBankName = new Label();
    this.lblBankAccountNumber = new Label();
    this.lblDepositDate = new Label();
    this.lblDepositStatus = new Label();
    this.gridCashReceipts = new UltraGrid();
    this.btnBounceCheck = new UltraButton();
    this.lTransactionDate = new Label();
    this.dateOfBouncedCheck = new UltraCalendarCombo();
    ((ISupportInitialize) this.gridCashReceipts).BeginInit();
    ((ISupportInitialize) this.dateOfBouncedCheck).BeginInit();
    this.SuspendLayout();
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    ((ControlBase) this.btnClose).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnClose).Location = new Point(389, 378);
    ((Control) this.btnClose).Name = "btnClose";
    ((Control) this.btnClose).Size = new Size(75, 26);
    ((Control) this.btnClose).TabIndex = 0;
    ((ControlBase) this.btnClose).Text = "Cancel";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(9, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(73, 13);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "Bank Name:";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(9, 32 /*0x20*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(103, 13);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Account Number:";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(9, 56);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(83, 13);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Deposit Date:";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.Location = new Point(9, 80 /*0x50*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(107, 13);
    this.Label5.TabIndex = 6;
    this.Label5.Text = "Deposited Status:";
    this.lblBankName.AutoSize = true;
    this.lblBankName.BackColor = Color.Transparent;
    this.lblBankName.Location = new Point(121, 8);
    this.lblBankName.Name = "lblBankName";
    this.lblBankName.Size = new Size(68, 13);
    this.lblBankName.TabIndex = 7;
    this.lblBankName.Text = "[Bank Name]";
    this.lblBankAccountNumber.AutoSize = true;
    this.lblBankAccountNumber.BackColor = Color.Transparent;
    this.lblBankAccountNumber.Location = new Point(121, 32 /*0x20*/);
    this.lblBankAccountNumber.Name = "lblBankAccountNumber";
    this.lblBankAccountNumber.Size = new Size(120, 13);
    this.lblBankAccountNumber.TabIndex = 8;
    this.lblBankAccountNumber.Text = "[Bank Account Number]";
    this.lblDepositDate.AutoSize = true;
    this.lblDepositDate.BackColor = Color.Transparent;
    this.lblDepositDate.Location = new Point(121, 56);
    this.lblDepositDate.Name = "lblDepositDate";
    this.lblDepositDate.Size = new Size(77, 13);
    this.lblDepositDate.TabIndex = 9;
    this.lblDepositDate.Text = "[Deposit Date]";
    this.lblDepositStatus.AutoSize = true;
    this.lblDepositStatus.BackColor = Color.Transparent;
    this.lblDepositStatus.Location = new Point(121, 80 /*0x50*/);
    this.lblDepositStatus.Name = "lblDepositStatus";
    this.lblDepositStatus.Size = new Size(85, 13);
    this.lblDepositStatus.TabIndex = 10;
    this.lblDepositStatus.Text = "[Deposit Status]";
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridCashReceipts).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridCashReceipts).Location = new Point(8, 140);
    ((Control) this.gridCashReceipts).Name = "gridCashReceipts";
    ((Control) this.gridCashReceipts).Size = new Size(456, 232);
    ((Control) this.gridCashReceipts).TabIndex = 11;
    ((UltraControlBase) this.gridCashReceipts).UseOsThemes = (DefaultableBoolean) 2;
    appearance11.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance11.Image"));
    ((ControlBase) this.btnBounceCheck).Appearance = (AppearanceBase) appearance11;
    ((Control) this.btnBounceCheck).Location = new Point(280, 378);
    ((Control) this.btnBounceCheck).Name = "btnBounceCheck";
    ((Control) this.btnBounceCheck).Size = new Size(104, 26);
    ((Control) this.btnBounceCheck).TabIndex = 12;
    ((ControlBase) this.btnBounceCheck).Text = "Bounce Check";
    this.lTransactionDate.AutoSize = true;
    this.lTransactionDate.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lTransactionDate.Location = new Point(9, 106);
    this.lTransactionDate.Name = "lTransactionDate";
    this.lTransactionDate.Size = new Size(107, 13);
    this.lTransactionDate.TabIndex = 13;
    this.lTransactionDate.Text = "Transaction Date:";
    this.dateOfBouncedCheck.AllowNull = false;
    this.dateOfBouncedCheck.DateButtons.Add(dateButton);
    ((Control) this.dateOfBouncedCheck).Location = new Point(124, 103);
    ((Control) this.dateOfBouncedCheck).Name = "dateOfBouncedCheck";
    this.dateOfBouncedCheck.NonAutoSizeHeight = 21;
    ((Control) this.dateOfBouncedCheck).Size = new Size(216, 21);
    ((Control) this.dateOfBouncedCheck).TabIndex = 14;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(479, 409);
    this.ControlBox = false;
    this.Controls.Add((Control) this.dateOfBouncedCheck);
    this.Controls.Add((Control) this.lTransactionDate);
    this.Controls.Add((Control) this.gridCashReceipts);
    this.Controls.Add((Control) this.btnClose);
    this.Controls.Add((Control) this.btnBounceCheck);
    this.Controls.Add((Control) this.lblDepositStatus);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lblDepositDate);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.lblBankName);
    this.Controls.Add((Control) this.lblBankAccountNumber);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (frmBouncedCheck);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Deposit Check Bounced";
    ((ISupportInitialize) this.gridCashReceipts).EndInit();
    ((ISupportInitialize) this.dateOfBouncedCheck).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void frmBouncedCheck_Load(object sender, EventArgs e)
  {
    this.lblBankName.Text = this._bankName;
    this.lblBankAccountNumber.Text = this._accountNumber;
    this.lblDepositDate.Text = Strings.Format((object) this._depositDate, "Long Date");
    this.lblDepositStatus.Text = this._depositStatus;
    if (this.DesignMode)
      return;
    this.LoadCashReceipts();
    this.ChildLoad();
  }

  protected virtual void LoadCashReceipts()
  {
    ((UltraGridBase) this.gridCashReceipts).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetBankDepositDetail", new object[2]
    {
      (object) "@depositId",
      (object) this._depositId
    });
    UltraGridBand band = ((UltraGridBase) this.gridCashReceipts).DisplayLayout.Bands[0];
    UltraGridColumn column1 = band.Columns["transactnum"];
    ((HeaderBase) column1.Header).Caption = "Transaction #";
    column1.Header.VisiblePosition = 0;
    column1.Width = 82;
    column1.Hidden = true;
    UltraGridColumn column2 = band.Columns["postDate"];
    column2.Header.VisiblePosition = 1;
    column2.Hidden = true;
    column2.Width = 91;
    UltraGridColumn column3 = band.Columns["checkNumber"];
    ((HeaderBase) column3.Header).Caption = "Check #";
    column3.Header.VisiblePosition = 2;
    ((HeaderBase) column3.Header).Appearance.TextHAlignAsString = "Left";
    UltraGridColumn column4 = band.Columns["Remitter"];
    ((HeaderBase) column4.Header).Appearance.TextHAlignAsString = "Left";
    column4.Header.VisiblePosition = 3;
    column4.Width = 278;
    UltraGridColumn column5 = band.Columns["Amount"];
    ((HeaderBase) column5.Header).Appearance.TextHAlignAsString = "Right";
    column5.CellAppearance.TextHAlignAsString = "Right";
    column5.Format = "c";
    column5.Width = 92;
  }

  protected virtual void ChildLoad()
  {
  }

  protected virtual void Save()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridCashReceipts).Rows)
    {
      if (row.Selected)
      {
        try
        {
          this.ChildSave(this.BounceCheck(Conversions.ToInteger(row.Cells["transactnum"].Value), Conversions.ToDate(this.dateOfBouncedCheck.Value)));
        }
        catch (SqlException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) MessageBox.Show("An error has occurred while trying to bounce the specified cash receipt.\r\n\r\n" + ex.Errors[0].Message, "Can Not Bounce Check!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ProjectData.ClearProjectError();
        }
        this.Close();
        break;
      }
    }
  }

  protected virtual void ChildSave(int voidingTransactiounNum)
  {
  }

  protected virtual int BounceCheck(int transactionNumber, DateTime transactionDate)
  {
    return BankingServices.BounceCheck(transactionNumber, transactionDate);
  }

  private void btnClose_Click(object sender, EventArgs e) => this.Close();

  private void btnBounceCheck_Click(object sender, EventArgs e) => this.Save();
}
