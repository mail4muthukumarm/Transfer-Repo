// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormModifyReserve
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormModifyReserve : FormBase
{
  protected int _resPayTypeId;
  protected Guid _claimantGuid;
  protected string _reservePaymentType;
  protected string _claimNumber;
  protected string _claimantName;
  protected int _resPaySubTypeId;
  protected int _coverageTypeId;
  protected int _coverageTypeDescriptionId;
  protected string _resPaySubType;
  protected string _coverageType;
  protected string _coverageTypeDescription;
  protected Decimal _totalReserves;
  protected Decimal _totalPayments;
  protected Claimant _claimant;
  protected Decimal _amt;
  private IContainer components;
  protected Label label1;
  protected Label label2;
  protected Label label3;
  protected Label label4;
  protected Label label5;
  protected Label label6;
  protected Label label7;
  protected Label label8;
  protected Label label9;
  protected MGATextBox textClaimNumber;
  protected MGATextBox textClaimantName;
  protected MGATextBox textReserveType;
  protected MGATextBox textReserveSubType;
  protected MGATextBox textCoverageType;
  protected MGATextBox textCoverageDescription;
  protected MGATextBox textTotalReserves;
  protected MGATextBox textTotalPayments;
  protected MGATextBox textRemainingReserve;
  protected Label label10;
  protected MGAButton buttonCancel;
  protected MGAButton buttonSave;
  protected Label label11;
  protected Label label12;
  protected MGATextBox textComments;
  protected Label label13;
  protected MGADateTimePicker dateTimeReserveDate;
  protected MGAMaskedEdit maskNewReserveAmt;

  protected Decimal RemainingReserves { get; private set; }

  public FormModifyReserve() => this.InitializeComponent();

  public FormModifyReserve(
    Guid claimantGuid,
    string claimNumber,
    string claimantName,
    string reservePaymentType,
    string reservePaymentSubType,
    string coverageType,
    string coverageTypeDescription,
    int resPayTypeId,
    int resPaySubTypeId,
    int coverageTypeId,
    int coverageTypeDescriptionId,
    Decimal totalReserves,
    Decimal totalPayments,
    Decimal remainingReserve,
    ref Claimant claimant)
  {
    this.InitializeComponent();
    this._claimantGuid = claimantGuid;
    this._claimNumber = claimNumber;
    this._claimantName = claimantName;
    this._resPayTypeId = resPayTypeId;
    this._reservePaymentType = reservePaymentType;
    this._resPaySubTypeId = resPaySubTypeId;
    this._resPaySubType = reservePaymentSubType;
    this._resPaySubTypeId = resPaySubTypeId;
    this._coverageType = coverageType;
    this._coverageTypeId = coverageTypeId;
    this._coverageTypeDescription = coverageTypeDescription;
    this._coverageTypeDescriptionId = coverageTypeDescriptionId;
    this._totalReserves = totalReserves;
    this._totalPayments = totalPayments;
    this.RemainingReserves = remainingReserve;
    this._claimant = claimant;
  }

  private void DisplayData()
  {
    ((Control) this.textClaimNumber).Text = this._claimNumber;
    ((Control) this.textClaimantName).Text = this._claimantName;
    ((Control) this.textReserveType).Text = this._reservePaymentType;
    ((Control) this.textReserveSubType).Text = this._resPaySubType;
    ((Control) this.textCoverageType).Text = this._coverageType;
    ((Control) this.textCoverageDescription).Text = this._coverageTypeDescription;
    ((Control) this.textTotalReserves).Text = this._totalReserves.ToString("c");
    ((Control) this.textTotalPayments).Text = this._totalPayments.ToString("c");
    ((Control) this.textRemainingReserve).Text = this.RemainingReserves.ToString("c");
  }

  private void FormModifyReserve_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.DisplayData();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.Close();
    this.DialogResult = DialogResult.Cancel;
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateModification())
      return;
    this.SaveModification();
  }

  protected virtual void SaveModification()
  {
    if (MessageBox.Show($"This will change the remaining reserve from {((Control) this.textRemainingReserve).Text}, to {((Decimal) ((UltraMaskedEdit) this.maskNewReserveAmt).Value).ToString("c")}. This change can only be done be adjusting the reserve again. Continue?", "Change Remaining Reserve?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    try
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
      {
        try
        {
          int identifier = this._claimant.Owner.ClaimId.Value;
          object reservePaymentId = DefaultDatabase.ExecuteScalar("spClaims_InsertReservePayment", new object[32 /*0x20*/]
          {
            (object) "@ClaimId",
            (object) identifier,
            (object) "@ClaimantGuid",
            (object) this._claimantGuid,
            (object) "@CoverageTypeId",
            (object) (this._coverageTypeId == -1 ? SqlInt32.Null : (SqlInt32) this._coverageTypeId),
            (object) "@CoverageTypeDescriptionId",
            (object) (this._coverageTypeDescriptionId == -1 ? SqlInt32.Null : (SqlInt32) this._coverageTypeDescriptionId),
            (object) "@ResPayTypeId",
            (object) this._resPayTypeId,
            (object) "@ResPaySubTypeId",
            (object) (this._resPaySubTypeId == -1 ? SqlInt32.Null : (SqlInt32) this._resPaySubTypeId),
            (object) "@ResPayAmount",
            (object) this._amt,
            (object) "@CreatedByGuid",
            (object) CurrentUser.Instance.UserGUID,
            (object) "@Comments",
            (object) ((Control) this.textComments).Text,
            (object) "@IsPayment",
            (object) false,
            (object) "@payeeGuid",
            (object) SqlGuid.Null,
            (object) "@payeeName",
            (object) SqlString.Null,
            (object) "@IsPayeeClaimant",
            (object) false,
            (object) "@IsPayeeInsured",
            (object) false,
            (object) "@IsRecovery",
            (object) false,
            (object) "@date",
            (object) ((UltraDateTimeEditor) this.dateTimeReserveDate).DateTime
          });
          CurrentUser.Instance.LogAction("User modified a claim reserve.", identifier, "Claims Action");
          this.OnModifyReserveSaved((int) reservePaymentId, this._amt);
          e.Transaction.Commit();
        }
        catch (Exception ex)
        {
          e.Transaction.Rollback();
          throw;
        }
      }));
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
    catch (Exception ex)
    {
      throw;
    }
  }

  protected virtual bool ValidateModification()
  {
    if (((UltraMaskedEdit) this.maskNewReserveAmt).Value == DBNull.Value)
    {
      int num = (int) MessageBox.Show("You must enter the new remaining reserve amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    Decimal result;
    if (!Decimal.TryParse(((UltraMaskedEdit) this.maskNewReserveAmt).Value.ToString(), NumberStyles.Any, (IFormatProvider) null, out result))
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_INVALIDAMOUNT_ERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    this._amt = result - this.RemainingReserves;
    return this.CheckReserveLevel(this._amt) && this.CheckClaimReserveLevel(this._amt);
  }

  protected virtual bool CheckReserveLevel(Decimal amt)
  {
    if (Utility.GetReserveLevelGuid(amt))
      return true;
    int num = (int) MessageBox.Show("You do not have rights to modify a reserve to this amount, please contact your system administrator for more information.", "Invalid Reserve Amount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected virtual bool CheckClaimReserveLevel(Decimal amt)
  {
    if (Utility.GetClaimReserveLevelGuid(amt + this._claimant.Owner.GetTotalReserves() + this._claimant.Owner.GetExpenseReserves()))
      return true;
    int num = (int) MessageBox.Show("This reserve will exceed your claim level reserve limit. You do not have rights to modify a reserve to this amount, please contact your system administrator for more information.", "Invalid Reserve Amount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected event FormModifyReserve.ModifyReserveSavedHandler ModifyReserveSaved;

  protected void OnModifyReserveSaved(int reservePaymentId, Decimal amount)
  {
    FormModifyReserve.ModifyReserveSavedHandler modifyReserveSaved = this.ModifyReserveSaved;
    if (modifyReserveSaved == null)
      return;
    modifyReserveSaved((object) this, new ModifyReserveSavedEventArgs(reservePaymentId, amount));
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
    this.label1 = new Label();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label9 = new Label();
    this.textClaimNumber = new MGATextBox();
    this.textClaimantName = new MGATextBox();
    this.textReserveType = new MGATextBox();
    this.textReserveSubType = new MGATextBox();
    this.textCoverageType = new MGATextBox();
    this.textCoverageDescription = new MGATextBox();
    this.textTotalReserves = new MGATextBox();
    this.textTotalPayments = new MGATextBox();
    this.textRemainingReserve = new MGATextBox();
    this.label10 = new Label();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.label11 = new Label();
    this.maskNewReserveAmt = new MGAMaskedEdit();
    this.label12 = new Label();
    this.textComments = new MGATextBox();
    this.label13 = new Label();
    this.dateTimeReserveDate = new MGADateTimePicker();
    ((ISupportInitialize) this.textClaimNumber).BeginInit();
    ((ISupportInitialize) this.textClaimantName).BeginInit();
    ((ISupportInitialize) this.textReserveType).BeginInit();
    ((ISupportInitialize) this.textReserveSubType).BeginInit();
    ((ISupportInitialize) this.textCoverageType).BeginInit();
    ((ISupportInitialize) this.textCoverageDescription).BeginInit();
    ((ISupportInitialize) this.textTotalReserves).BeginInit();
    ((ISupportInitialize) this.textTotalPayments).BeginInit();
    ((ISupportInitialize) this.textRemainingReserve).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.maskNewReserveAmt).BeginInit();
    ((ISupportInitialize) this.textComments).BeginInit();
    ((ISupportInitialize) this.dateTimeReserveDate).BeginInit();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(13, 13);
    this.label1.Name = "label1";
    this.label1.Size = new Size(76, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "Claim Number:";
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(13, 36);
    this.label2.Name = "label2";
    this.label2.Size = new Size(82, 13);
    this.label2.TabIndex = 2;
    this.label2.Text = "Claimant Name:";
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(13, 59);
    this.label3.Name = "label3";
    this.label3.Size = new Size(78, 13);
    this.label3.TabIndex = 4;
    this.label3.Text = "Reserve Type:";
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.Transparent;
    this.label4.Location = new Point(13, 82);
    this.label4.Name = "label4";
    this.label4.Size = new Size(100, 13);
    this.label4.TabIndex = 6;
    this.label4.Text = "Reserve Sub-Type:";
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.Transparent;
    this.label5.Location = new Point(13, 174);
    this.label5.Name = "label5";
    this.label5.Size = new Size(85, 13);
    this.label5.TabIndex = 14;
    this.label5.Text = "Total Payments:";
    this.label6.AutoSize = true;
    this.label6.BackColor = Color.Transparent;
    this.label6.Location = new Point(13, 151);
    this.label6.Name = "label6";
    this.label6.Size = new Size(83, 13);
    this.label6.TabIndex = 12;
    this.label6.Text = "Total Reserves:";
    this.label7.AutoSize = true;
    this.label7.BackColor = Color.Transparent;
    this.label7.Location = new Point(13, 128 /*0x80*/);
    this.label7.Name = "label7";
    this.label7.Size = new Size(114, 13);
    this.label7.TabIndex = 10;
    this.label7.Text = "Coverage Description:";
    this.label8.AutoSize = true;
    this.label8.BackColor = Color.Transparent;
    this.label8.Location = new Point(13, 105);
    this.label8.Name = "label8";
    this.label8.Size = new Size(85, 13);
    this.label8.TabIndex = 8;
    this.label8.Text = "Coverage Type:";
    this.label9.AutoSize = true;
    this.label9.BackColor = Color.Transparent;
    this.label9.Location = new Point(13, 197);
    this.label9.Name = "label9";
    this.label9.Size = new Size(108, 13);
    this.label9.TabIndex = 16 /*0x10*/;
    this.label9.Text = "Remaining Reserves:";
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimNumber).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textClaimNumber).BackColor = Color.White;
    ((Control) this.textClaimNumber).Location = new Point(153, 13);
    this.textClaimNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimNumber).Name = "textClaimNumber";
    ((EditorButtonControlBase) this.textClaimNumber).ReadOnly = true;
    ((Control) this.textClaimNumber).Size = new Size(244, 20);
    ((Control) this.textClaimNumber).TabIndex = 1;
    ((Control) this.textClaimNumber).TabStop = false;
    ((UltraControlBase) this.textClaimNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimantName).Appearance = (AppearanceBase) appearance2;
    ((Control) this.textClaimantName).BackColor = Color.White;
    ((Control) this.textClaimantName).Location = new Point(153, 36);
    this.textClaimantName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimantName).Name = "textClaimantName";
    ((EditorButtonControlBase) this.textClaimantName).ReadOnly = true;
    ((Control) this.textClaimantName).Size = new Size(244, 20);
    ((Control) this.textClaimantName).TabIndex = 3;
    ((Control) this.textClaimantName).TabStop = false;
    ((UltraControlBase) this.textClaimantName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimantName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textReserveType).Appearance = (AppearanceBase) appearance3;
    ((Control) this.textReserveType).BackColor = Color.White;
    ((Control) this.textReserveType).Location = new Point(153, 59);
    this.textReserveType.MGAStyle = (MGAStyles) 2;
    ((Control) this.textReserveType).Name = "textReserveType";
    ((EditorButtonControlBase) this.textReserveType).ReadOnly = true;
    ((Control) this.textReserveType).Size = new Size(244, 20);
    ((Control) this.textReserveType).TabIndex = 5;
    ((Control) this.textReserveType).TabStop = false;
    ((UltraControlBase) this.textReserveType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textReserveType).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textReserveSubType).Appearance = (AppearanceBase) appearance4;
    ((Control) this.textReserveSubType).BackColor = Color.White;
    ((Control) this.textReserveSubType).Location = new Point(153, 82);
    this.textReserveSubType.MGAStyle = (MGAStyles) 2;
    ((Control) this.textReserveSubType).Name = "textReserveSubType";
    ((EditorButtonControlBase) this.textReserveSubType).ReadOnly = true;
    ((Control) this.textReserveSubType).Size = new Size(244, 20);
    ((Control) this.textReserveSubType).TabIndex = 7;
    ((Control) this.textReserveSubType).TabStop = false;
    ((UltraControlBase) this.textReserveSubType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textReserveSubType).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCoverageType).Appearance = (AppearanceBase) appearance5;
    ((Control) this.textCoverageType).BackColor = Color.White;
    ((Control) this.textCoverageType).Location = new Point(153, 105);
    this.textCoverageType.MGAStyle = (MGAStyles) 2;
    ((Control) this.textCoverageType).Name = "textCoverageType";
    ((EditorButtonControlBase) this.textCoverageType).ReadOnly = true;
    ((Control) this.textCoverageType).Size = new Size(244, 20);
    ((Control) this.textCoverageType).TabIndex = 9;
    ((Control) this.textCoverageType).TabStop = false;
    ((UltraControlBase) this.textCoverageType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCoverageType).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCoverageDescription).Appearance = (AppearanceBase) appearance6;
    ((Control) this.textCoverageDescription).BackColor = Color.White;
    ((Control) this.textCoverageDescription).Location = new Point(153, 128 /*0x80*/);
    this.textCoverageDescription.MGAStyle = (MGAStyles) 2;
    ((Control) this.textCoverageDescription).Name = "textCoverageDescription";
    ((EditorButtonControlBase) this.textCoverageDescription).ReadOnly = true;
    ((Control) this.textCoverageDescription).Size = new Size(244, 20);
    ((Control) this.textCoverageDescription).TabIndex = 11;
    ((Control) this.textCoverageDescription).TabStop = false;
    ((UltraControlBase) this.textCoverageDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCoverageDescription).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textTotalReserves).Appearance = (AppearanceBase) appearance7;
    ((Control) this.textTotalReserves).BackColor = Color.White;
    ((Control) this.textTotalReserves).Location = new Point(153, 151);
    this.textTotalReserves.MGAStyle = (MGAStyles) 2;
    ((Control) this.textTotalReserves).Name = "textTotalReserves";
    ((EditorButtonControlBase) this.textTotalReserves).ReadOnly = true;
    ((Control) this.textTotalReserves).Size = new Size(106, 20);
    ((Control) this.textTotalReserves).TabIndex = 13;
    ((Control) this.textTotalReserves).TabStop = false;
    ((UltraControlBase) this.textTotalReserves).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textTotalReserves).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textTotalPayments).Appearance = (AppearanceBase) appearance8;
    ((Control) this.textTotalPayments).BackColor = Color.White;
    ((Control) this.textTotalPayments).Location = new Point(153, 174);
    this.textTotalPayments.MGAStyle = (MGAStyles) 2;
    ((Control) this.textTotalPayments).Name = "textTotalPayments";
    ((EditorButtonControlBase) this.textTotalPayments).ReadOnly = true;
    ((Control) this.textTotalPayments).Size = new Size(106, 20);
    ((Control) this.textTotalPayments).TabIndex = 15;
    ((Control) this.textTotalPayments).TabStop = false;
    ((UltraControlBase) this.textTotalPayments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textTotalPayments).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textRemainingReserve).Appearance = (AppearanceBase) appearance9;
    ((Control) this.textRemainingReserve).BackColor = Color.White;
    ((Control) this.textRemainingReserve).Location = new Point(153, 197);
    this.textRemainingReserve.MGAStyle = (MGAStyles) 2;
    ((Control) this.textRemainingReserve).Name = "textRemainingReserve";
    ((EditorButtonControlBase) this.textRemainingReserve).ReadOnly = true;
    ((Control) this.textRemainingReserve).Size = new Size(106, 20);
    ((Control) this.textRemainingReserve).TabIndex = 17;
    ((Control) this.textRemainingReserve).TabStop = false;
    ((UltraControlBase) this.textRemainingReserve).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textRemainingReserve).UseOsThemes = (DefaultableBoolean) 2;
    this.label10.AutoSize = true;
    this.label10.BackColor = Color.Transparent;
    this.label10.Location = new Point(13, 264);
    this.label10.Name = "label10";
    this.label10.Size = new Size(115, 13);
    this.label10.TabIndex = 20;
    this.label10.Text = "New Reserve Amount:";
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance10).Image = (object) Resources.DeleteClaimSmall;
    ((AppearanceBase) appearance10).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance10).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance10;
    ((Control) this.buttonCancel).Location = new Point(299, 387);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(98, 28);
    ((Control) this.buttonCancel).TabIndex = 25;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance11).Image = (object) Resources.Save;
    ((AppearanceBase) appearance11).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance11).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance11;
    ((Control) this.buttonSave).Location = new Point(195, 387);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(98, 28);
    ((Control) this.buttonSave).TabIndex = 24;
    ((Control) this.buttonSave).Text = "Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    this.label11.BackColor = Color.Black;
    this.label11.Location = new Point(10, 230);
    this.label11.Name = "label11";
    this.label11.Size = new Size(390, 1);
    this.label11.TabIndex = 26;
    this.label11.Text = "label11";
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.maskNewReserveAmt).Appearance = (AppearanceBase) appearance12;
    ((UltraMaskedEdit) this.maskNewReserveAmt).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.maskNewReserveAmt).EditAs = (EditAsType) 2;
    ((Control) this.maskNewReserveAmt).Location = new Point(153, 264);
    this.maskNewReserveAmt.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskNewReserveAmt).Name = "maskNewReserveAmt";
    ((UltraMaskedEdit) this.maskNewReserveAmt).NonAutoSizeHeight = 20;
    ((Control) this.maskNewReserveAmt).Size = new Size(100, 21);
    ((Control) this.maskNewReserveAmt).TabIndex = 21;
    ((UltraControlBase) this.maskNewReserveAmt).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskNewReserveAmt).UseOsThemes = (DefaultableBoolean) 2;
    this.label12.AutoSize = true;
    this.label12.BackColor = Color.Transparent;
    this.label12.Location = new Point(13, 287);
    this.label12.Name = "label12";
    this.label12.Size = new Size(56, 13);
    this.label12.TabIndex = 22;
    this.label12.Text = "Comment:";
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComments).Appearance = (AppearanceBase) appearance13;
    ((Control) this.textComments).BackColor = Color.White;
    ((Control) this.textComments).Location = new Point(153, 287);
    this.textComments.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.textComments).Multiline = true;
    ((Control) this.textComments).Name = "textComments";
    ((Control) this.textComments).Size = new Size(244, 94);
    ((Control) this.textComments).TabIndex = 23;
    ((UltraControlBase) this.textComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textComments).UseOsThemes = (DefaultableBoolean) 2;
    this.label13.AutoSize = true;
    this.label13.BackColor = Color.Transparent;
    this.label13.Location = new Point(13, 242);
    this.label13.Name = "label13";
    this.label13.Size = new Size(101, 13);
    this.label13.TabIndex = 18;
    this.label13.Text = "New Reserve Date:";
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeReserveDate).Appearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance15).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance15).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance15).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance15).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance15).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance15).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance15).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeReserveDate).ButtonAppearance = (AppearanceBase) appearance15;
    ((Control) this.dateTimeReserveDate).Location = new Point(153, 239);
    this.dateTimeReserveDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeReserveDate).Name = "dateTimeReserveDate";
    ((Control) this.dateTimeReserveDate).Size = new Size(100, 20);
    ((Control) this.dateTimeReserveDate).TabIndex = 19;
    ((UltraControlBase) this.dateTimeReserveDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeReserveDate).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(404, 422);
    this.ControlBox = false;
    this.Controls.Add((Control) this.dateTimeReserveDate);
    this.Controls.Add((Control) this.label13);
    this.Controls.Add((Control) this.textComments);
    this.Controls.Add((Control) this.label12);
    this.Controls.Add((Control) this.maskNewReserveAmt);
    this.Controls.Add((Control) this.label11);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.label10);
    this.Controls.Add((Control) this.textRemainingReserve);
    this.Controls.Add((Control) this.textTotalPayments);
    this.Controls.Add((Control) this.textTotalReserves);
    this.Controls.Add((Control) this.textCoverageDescription);
    this.Controls.Add((Control) this.textCoverageType);
    this.Controls.Add((Control) this.textReserveSubType);
    this.Controls.Add((Control) this.textReserveType);
    this.Controls.Add((Control) this.textClaimantName);
    this.Controls.Add((Control) this.textClaimNumber);
    this.Controls.Add((Control) this.label9);
    this.Controls.Add((Control) this.label8);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormModifyReserve);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Modify Reserve";
    this.Load += new EventHandler(this.FormModifyReserve_Load);
    ((ISupportInitialize) this.textClaimNumber).EndInit();
    ((ISupportInitialize) this.textClaimantName).EndInit();
    ((ISupportInitialize) this.textReserveType).EndInit();
    ((ISupportInitialize) this.textReserveSubType).EndInit();
    ((ISupportInitialize) this.textCoverageType).EndInit();
    ((ISupportInitialize) this.textCoverageDescription).EndInit();
    ((ISupportInitialize) this.textTotalReserves).EndInit();
    ((ISupportInitialize) this.textTotalPayments).EndInit();
    ((ISupportInitialize) this.textRemainingReserve).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.maskNewReserveAmt).EndInit();
    ((ISupportInitialize) this.textComments).EndInit();
    ((ISupportInitialize) this.dateTimeReserveDate).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected delegate void ModifyReserveSavedHandler(object sender, ModifyReserveSavedEventArgs e);
}
