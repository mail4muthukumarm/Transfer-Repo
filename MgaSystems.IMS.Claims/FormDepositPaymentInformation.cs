// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormDepositPaymentInformation
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormDepositPaymentInformation : FormBase
{
  private Claimant _currentClaimant;
  private PaymentReserve _currentPayment;
  private PaymentReserve _reserve;
  private PaymentReserve _payment;
  private int _bankGLAccount;
  private int _transactNum;
  private IContainer components;
  private UltraLabel labelStatus;
  private UltraLabel lblStatus;
  private UltraLabel labelCheckNumber;
  private UltraLabel lblCheckNumber;
  private UltraLabel labelCheckDate;
  private UltraLabel lblCheckDate;
  private UltraLabel labelBankName;
  private UltraLabel lblBankName;
  private UltraLabel labelPayeeName;
  private UltraLabel lblPayeeName;
  private MGAButton buttonVoidCheck;
  private Label label1;
  private UltraLabel labelAccountingTransactionNumber;
  private UltraLabel ultraLabel2;
  private UltraLabel labelClaimsStatus;
  private UltraLabel ultraLabel3;
  private UltraLabel labelReservePaymentId;
  private UltraLabel ultraLabel4;

  protected Claimant CurrentClaimant => this._currentClaimant;

  protected PaymentReserve CurrentPayment => this._currentPayment;

  protected PaymentReserve Reserve => this._reserve;

  protected PaymentReserve Payment => this._payment;

  protected int BankGLAccount => this._bankGLAccount;

  protected int TransactionNumber => this._transactNum;

  public FormDepositPaymentInformation(Claimant claimant, PaymentReserve currentPayment)
  {
    this.InitializeComponent();
    this._currentClaimant = claimant;
    this._currentPayment = currentPayment;
    this.LoadCheckInformation();
  }

  private void LoadCheckInformation()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spClaims_GetPaymentDepositInformation", new object[2]
    {
      (object) "@resPayId",
      (object) this._currentPayment.ReservePaymentId
    });
    ((Control) this.labelReservePaymentId).Text = this._currentPayment.ReservePaymentId.ToString();
    if (dataTable.Rows.Count == 0)
      return;
    ((Control) this.labelPayeeName).Text = dataTable.Rows[0]["PayeeName"].ToString();
    ((Control) this.labelBankName).Text = dataTable.Rows[0]["BankName"].ToString();
    ((Control) this.labelCheckDate).Text = ((DateTime) dataTable.Rows[0]["CheckDate"]).ToShortDateString();
    ((Control) this.labelCheckNumber).Text = dataTable.Rows[0]["CheckNumber"].ToString();
    ((Control) this.labelStatus).Text = dataTable.Rows[0]["Status"].ToString();
    ((Control) this.labelClaimsStatus).Text = dataTable.Rows[0]["ClaimStatus"].ToString();
    this._transactNum = int.Parse(dataTable.Rows[0]["transactNum"].ToString());
    this._bankGLAccount = int.Parse(dataTable.Rows[0]["CheckAcctId"].ToString());
    ((Control) this.labelAccountingTransactionNumber).Text = this._transactNum.ToString();
  }

  protected virtual void VoidClaimPayment(bool addReserve)
  {
    this.CreateReservePayment();
    this._currentPayment.SetVoidStatus(true);
    this._currentClaimant.ReservesAndPayments.Add(this._payment);
    if (addReserve)
      this._currentClaimant.ReservesAndPayments.Add(this._reserve);
    this._currentClaimant.Owner.AddPaymentCreatedExpense();
    this._currentClaimant.Owner.AddActivity(new ClaimActivity(Utility.ClaimActivityType.PaymentVoided, DateTime.Now, CurrentUser.Instance.UserGUID, CurrentUser.Instance.DisplayName, Utility.ClaimStatus.Open));
    CurrentUser.Instance.LogAction($"Voided claim payment for reserve payment ID: {this._currentPayment.ReservePaymentId}");
    this._currentClaimant.Owner.Save();
  }

  private void CreateReservePayment()
  {
    this._reserve = new PaymentReserve(PaymentReserveType.Reserve, this._currentPayment.ReservePaymentTypeId, this._currentPayment.ReservePaymentType, this._currentPayment.ReservePaymentSubTypeId, this._currentPayment.ReservePaymentSubType, this._currentPayment.CoverageTypeId, this._currentPayment.CoverageType, this._currentPayment.CoverageTypeDescriptionId, this._currentPayment.CoverageTypeDescription, this._currentPayment.Comments, this._currentPayment.ReservePaymentAmount, Guid.Empty, string.Empty, this._currentPayment.IsRecovery);
    this._reserve.IsPaymentReduction = true;
    this._payment = new PaymentReserve(PaymentReserveType.Payment, this._currentPayment.ReservePaymentTypeId, this._currentPayment.ReservePaymentType, this._currentPayment.ReservePaymentSubTypeId, this._currentPayment.ReservePaymentSubType, this._currentPayment.CoverageTypeId, this._currentPayment.CoverageType, this._currentPayment.CoverageTypeDescriptionId, this._currentPayment.CoverageTypeDescription, this._currentPayment.Comments, this._currentPayment.ReservePaymentAmount * -1M, this._currentPayment.PayeeGuid, this._currentPayment.PayeeName, this._currentPayment.IsRecovery);
    this._payment.IsVoid = true;
    this._payment.IsPayeeClaimant = this._currentPayment.IsPayeeClaimant;
    this._payment.IsPayeeInsured = this._currentPayment.IsPayeeInsured;
    this._payment.PayeeAddress1 = this._currentPayment.PayeeAddress1;
    this._payment.PayeeAddress2 = this._currentPayment.PayeeAddress2;
    this._payment.PayeeCity = this._currentPayment.PayeeCity;
    this._payment.PayeeState = this._currentPayment.PayeeState;
    this._payment.PayeeZipCode = this._currentPayment.PayeeZipCode;
    this._payment.PayeeZipCodeExtension = this._currentPayment.PayeeZipCodeExtension;
    this._payment.PayeeIsInternational = this._currentPayment.PayeeIsInternational;
    this._payment.PayeeInternationalZipCode = this._currentPayment.PayeeInternationalZipCode;
    this._payment.PayeeISOCountryCode = this._currentPayment.PayeeISOCountryCode;
    this._payment.PayeeFEIN = this._currentPayment.PayeeFEIN;
    this._payment.PayeeSSN = this._currentPayment.PayeeSSN;
    this._payment.PayeeEmail = this._currentPayment.PayeeEmail;
    this._payment.PayeeIs1099 = this._currentPayment.PayeeIs1099;
    this._payment.IsPayeeDefenseAttorney = this._currentPayment.IsPayeeDefenseAttorney;
    this._payment.IsPayeeClaimantAttorney = this._currentPayment.IsPayeeClaimantAttorney;
  }

  protected virtual void buttonVoidCheck_Click(object sender, EventArgs e)
  {
    if (((Control) this.labelClaimsStatus).Text.Contains("Voided"))
    {
      int num1 = (int) MessageBox.Show("The transaction has already been voided/reversed in claims.", "No Action Required!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (this.TransactionNumber == -1)
    {
      int num2 = (int) MessageBox.Show(Resources.VOIDPAYMENT_TRANSCATIONNOTFOUND, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (MessageBox.Show(Resources.VOIDPAYMENTDEPOSIT_CLAIMWARNING, Resources.VOIDPAYMENTDEPOSIT_CLAIMHEADER, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        return;
      this.VoidClaimPayment(true);
      this.Close();
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    this.labelStatus = new UltraLabel();
    this.lblStatus = new UltraLabel();
    this.labelCheckNumber = new UltraLabel();
    this.lblCheckNumber = new UltraLabel();
    this.labelCheckDate = new UltraLabel();
    this.lblCheckDate = new UltraLabel();
    this.labelBankName = new UltraLabel();
    this.lblBankName = new UltraLabel();
    this.labelPayeeName = new UltraLabel();
    this.lblPayeeName = new UltraLabel();
    this.buttonVoidCheck = new MGAButton();
    this.label1 = new Label();
    this.labelAccountingTransactionNumber = new UltraLabel();
    this.ultraLabel2 = new UltraLabel();
    this.labelClaimsStatus = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    this.labelReservePaymentId = new UltraLabel();
    this.ultraLabel4 = new UltraLabel();
    ((ISupportInitialize) this.buttonVoidCheck).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    ((AppearanceBase) appearance1).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance1).TextVAlignAsString = "Middle";
    ((ControlBase) this.labelStatus).Appearance = (AppearanceBase) appearance1;
    ((Control) this.labelStatus).Dock = DockStyle.Top;
    ((Control) this.labelStatus).Location = new Point(0, 318);
    ((Control) this.labelStatus).Name = "labelStatus";
    ((Control) this.labelStatus).Size = new Size(326, 22);
    ((Control) this.labelStatus).TabIndex = 16 /*0x10*/;
    ((Control) this.labelStatus).Text = "N/A";
    ((AppearanceBase) appearance2).BackColor = Color.Transparent;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance2).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblStatus).Appearance = (AppearanceBase) appearance2;
    ((Control) this.lblStatus).Dock = DockStyle.Top;
    ((Control) this.lblStatus).Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    ((Control) this.lblStatus).Location = new Point(0, 296);
    ((Control) this.lblStatus).Name = "lblStatus";
    ((Control) this.lblStatus).Size = new Size(326, 22);
    ((Control) this.lblStatus).TabIndex = 11;
    ((Control) this.lblStatus).Text = "Accounting Status";
    ((AppearanceBase) appearance3).BackColor = Color.Transparent;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance3).TextVAlignAsString = "Middle";
    ((ControlBase) this.labelCheckNumber).Appearance = (AppearanceBase) appearance3;
    ((Control) this.labelCheckNumber).Dock = DockStyle.Top;
    ((Control) this.labelCheckNumber).Location = new Point(0, 274);
    ((Control) this.labelCheckNumber).Name = "labelCheckNumber";
    ((Control) this.labelCheckNumber).Size = new Size(326, 22);
    ((Control) this.labelCheckNumber).TabIndex = 17;
    ((Control) this.labelCheckNumber).Text = "N/A";
    ((AppearanceBase) appearance4).BackColor = Color.Transparent;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance4).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblCheckNumber).Appearance = (AppearanceBase) appearance4;
    ((Control) this.lblCheckNumber).Dock = DockStyle.Top;
    ((Control) this.lblCheckNumber).Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    ((Control) this.lblCheckNumber).Location = new Point(0, 252);
    ((Control) this.lblCheckNumber).Name = "lblCheckNumber";
    ((Control) this.lblCheckNumber).Size = new Size(326, 22);
    ((Control) this.lblCheckNumber).TabIndex = 12;
    ((Control) this.lblCheckNumber).Text = "Check Number";
    ((AppearanceBase) appearance5).BackColor = Color.Transparent;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance5).TextVAlignAsString = "Middle";
    ((ControlBase) this.labelCheckDate).Appearance = (AppearanceBase) appearance5;
    ((Control) this.labelCheckDate).Dock = DockStyle.Top;
    ((Control) this.labelCheckDate).Location = new Point(0, 230);
    ((Control) this.labelCheckDate).Name = "labelCheckDate";
    ((Control) this.labelCheckDate).Size = new Size(326, 22);
    ((Control) this.labelCheckDate).TabIndex = 18;
    ((Control) this.labelCheckDate).Text = "N/A";
    ((AppearanceBase) appearance6).BackColor = Color.Transparent;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance6).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblCheckDate).Appearance = (AppearanceBase) appearance6;
    ((Control) this.lblCheckDate).Dock = DockStyle.Top;
    ((Control) this.lblCheckDate).Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    ((Control) this.lblCheckDate).Location = new Point(0, 208 /*0xD0*/);
    ((Control) this.lblCheckDate).Name = "lblCheckDate";
    ((Control) this.lblCheckDate).Size = new Size(326, 22);
    ((Control) this.lblCheckDate).TabIndex = 13;
    ((Control) this.lblCheckDate).Text = "Check Date";
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance7).TextVAlignAsString = "Middle";
    ((ControlBase) this.labelBankName).Appearance = (AppearanceBase) appearance7;
    ((Control) this.labelBankName).Dock = DockStyle.Top;
    ((Control) this.labelBankName).Location = new Point(0, 186);
    ((Control) this.labelBankName).Name = "labelBankName";
    ((Control) this.labelBankName).Size = new Size(326, 22);
    ((Control) this.labelBankName).TabIndex = 19;
    ((Control) this.labelBankName).Text = "N/A";
    ((AppearanceBase) appearance8).BackColor = Color.Transparent;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance8).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblBankName).Appearance = (AppearanceBase) appearance8;
    ((Control) this.lblBankName).Dock = DockStyle.Top;
    ((Control) this.lblBankName).Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    ((Control) this.lblBankName).Location = new Point(0, 164);
    ((Control) this.lblBankName).Name = "lblBankName";
    ((Control) this.lblBankName).Size = new Size(326, 22);
    ((Control) this.lblBankName).TabIndex = 14;
    ((Control) this.lblBankName).Text = "Bank Name";
    ((AppearanceBase) appearance9).BackColor = Color.Transparent;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance9).TextVAlignAsString = "Middle";
    ((ControlBase) this.labelPayeeName).Appearance = (AppearanceBase) appearance9;
    ((Control) this.labelPayeeName).Dock = DockStyle.Top;
    ((Control) this.labelPayeeName).Location = new Point(0, 142);
    ((Control) this.labelPayeeName).Name = "labelPayeeName";
    ((Control) this.labelPayeeName).Size = new Size(326, 22);
    ((Control) this.labelPayeeName).TabIndex = 15;
    ((Control) this.labelPayeeName).Text = "N/A";
    ((AppearanceBase) appearance10).BackColor = Color.Transparent;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance10).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblPayeeName).Appearance = (AppearanceBase) appearance10;
    ((Control) this.lblPayeeName).Dock = DockStyle.Top;
    ((Control) this.lblPayeeName).Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    ((Control) this.lblPayeeName).Location = new Point(0, 120);
    ((Control) this.lblPayeeName).Name = "lblPayeeName";
    ((Control) this.lblPayeeName).Size = new Size(326, 22);
    ((Control) this.lblPayeeName).TabIndex = 10;
    ((Control) this.lblPayeeName).Text = "Payee Name";
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance11).Image = (object) Resources.DeleteClaimSmall;
    ((AppearanceBase) appearance11).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance11).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonVoidCheck).Appearance = (AppearanceBase) appearance11;
    ((Control) this.buttonVoidCheck).Location = new Point(62, 387);
    ((Control) this.buttonVoidCheck).Name = "buttonVoidCheck";
    ((Control) this.buttonVoidCheck).Size = new Size(207, 32 /*0x20*/);
    ((Control) this.buttonVoidCheck).TabIndex = 20;
    ((Control) this.buttonVoidCheck).Text = "Bounced Check / Reverse Deposit";
    ((UltraControlBase) this.buttonVoidCheck).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonVoidCheck).Click += new EventHandler(this.buttonVoidCheck_Click);
    this.label1.BackColor = Color.Gainsboro;
    this.label1.Dock = DockStyle.Top;
    this.label1.Font = new Font("Tahoma", 16f, FontStyle.Bold);
    this.label1.ForeColor = Color.Gray;
    this.label1.Location = new Point(0, 0);
    this.label1.Name = "label1";
    this.label1.Size = new Size(326, 32 /*0x20*/);
    this.label1.TabIndex = 21;
    this.label1.Text = "DEPOSIT";
    this.label1.TextAlign = ContentAlignment.MiddleCenter;
    ((AppearanceBase) appearance12).BackColor = Color.Transparent;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance12).TextVAlignAsString = "Middle";
    ((ControlBase) this.labelAccountingTransactionNumber).Appearance = (AppearanceBase) appearance12;
    ((Control) this.labelAccountingTransactionNumber).Dock = DockStyle.Top;
    ((Control) this.labelAccountingTransactionNumber).Location = new Point(0, 98);
    ((Control) this.labelAccountingTransactionNumber).Name = "labelAccountingTransactionNumber";
    ((Control) this.labelAccountingTransactionNumber).Size = new Size(326, 22);
    ((Control) this.labelAccountingTransactionNumber).TabIndex = 23;
    ((Control) this.labelAccountingTransactionNumber).Text = "N/A";
    ((AppearanceBase) appearance13).BackColor = Color.Transparent;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance13).TextVAlignAsString = "Middle";
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance13;
    ((Control) this.ultraLabel2).Dock = DockStyle.Top;
    ((Control) this.ultraLabel2).Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    ((Control) this.ultraLabel2).Location = new Point(0, 76);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(326, 22);
    ((Control) this.ultraLabel2).TabIndex = 22;
    ((Control) this.ultraLabel2).Text = "Accounting Transaction Number";
    ((AppearanceBase) appearance14).BackColor = Color.Transparent;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance14).TextVAlignAsString = "Middle";
    ((ControlBase) this.labelClaimsStatus).Appearance = (AppearanceBase) appearance14;
    ((Control) this.labelClaimsStatus).Dock = DockStyle.Top;
    ((Control) this.labelClaimsStatus).Location = new Point(0, 362);
    ((Control) this.labelClaimsStatus).Name = "labelClaimsStatus";
    ((Control) this.labelClaimsStatus).Size = new Size(326, 22);
    ((Control) this.labelClaimsStatus).TabIndex = 25;
    ((Control) this.labelClaimsStatus).Text = "N/A";
    ((AppearanceBase) appearance15).BackColor = Color.Transparent;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance15).TextVAlignAsString = "Middle";
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance15;
    ((Control) this.ultraLabel3).Dock = DockStyle.Top;
    ((Control) this.ultraLabel3).Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    ((Control) this.ultraLabel3).Location = new Point(0, 340);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(326, 22);
    ((Control) this.ultraLabel3).TabIndex = 24;
    ((Control) this.ultraLabel3).Text = "Claims Status";
    ((AppearanceBase) appearance16).BackColor = Color.Transparent;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance16).TextVAlignAsString = "Middle";
    ((ControlBase) this.labelReservePaymentId).Appearance = (AppearanceBase) appearance16;
    ((Control) this.labelReservePaymentId).Dock = DockStyle.Top;
    ((Control) this.labelReservePaymentId).Location = new Point(0, 54);
    ((Control) this.labelReservePaymentId).Name = "labelReservePaymentId";
    ((Control) this.labelReservePaymentId).Size = new Size(326, 22);
    ((Control) this.labelReservePaymentId).TabIndex = 27;
    ((Control) this.labelReservePaymentId).Text = "N/A";
    ((AppearanceBase) appearance17).BackColor = Color.Transparent;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance17).TextVAlignAsString = "Middle";
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance17;
    ((Control) this.ultraLabel4).Dock = DockStyle.Top;
    ((Control) this.ultraLabel4).Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    ((Control) this.ultraLabel4).Location = new Point(0, 32 /*0x20*/);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(326, 22);
    ((Control) this.ultraLabel4).TabIndex = 26;
    ((Control) this.ultraLabel4).Text = "Reserve/Payment ID";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(326, 431);
    this.Controls.Add((Control) this.labelClaimsStatus);
    this.Controls.Add((Control) this.ultraLabel3);
    this.Controls.Add((Control) this.buttonVoidCheck);
    this.Controls.Add((Control) this.labelStatus);
    this.Controls.Add((Control) this.lblStatus);
    this.Controls.Add((Control) this.labelCheckNumber);
    this.Controls.Add((Control) this.lblCheckNumber);
    this.Controls.Add((Control) this.labelCheckDate);
    this.Controls.Add((Control) this.lblCheckDate);
    this.Controls.Add((Control) this.labelBankName);
    this.Controls.Add((Control) this.lblBankName);
    this.Controls.Add((Control) this.labelPayeeName);
    this.Controls.Add((Control) this.lblPayeeName);
    this.Controls.Add((Control) this.labelAccountingTransactionNumber);
    this.Controls.Add((Control) this.ultraLabel2);
    this.Controls.Add((Control) this.labelReservePaymentId);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Controls.Add((Control) this.label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormDepositPaymentInformation);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Deposit Payment Information";
    ((ISupportInitialize) this.buttonVoidCheck).EndInit();
    this.ResumeLayout(false);
  }
}
