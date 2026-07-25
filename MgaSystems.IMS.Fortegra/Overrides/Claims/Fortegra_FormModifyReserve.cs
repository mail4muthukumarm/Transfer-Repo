// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_FormModifyReserve
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

[Override(typeof (FormModifyReserve))]
public class Fortegra_FormModifyReserve : FormModifyReserve
{
  private Guid _childLineGuid;
  private string _childLineName;
  private IContainer components;
  protected Label label14;
  protected MGATextBox textChildLine;

  public Fortegra_FormModifyReserve() => this.InitializeComponent();

  public Fortegra_FormModifyReserve(
    Guid claimantGuid,
    string claimNumber,
    string claimantName,
    string reservePaymentType,
    string reservePaymentSubType,
    string coverageType,
    string coverageTypeDescription,
    Guid childLineGuid,
    string childLineName,
    int resPayTypeId,
    int resPaySubTypeId,
    int coverageTypeId,
    int coverageTypeDescriptionId,
    Decimal totalReserves,
    Decimal totalPayments,
    Decimal remainingReserve,
    ref Claimant claimant)
    : base(claimantGuid, claimNumber, claimantName, reservePaymentType, reservePaymentSubType, coverageType, coverageTypeDescription, resPayTypeId, resPaySubTypeId, coverageTypeId, coverageTypeDescriptionId, totalReserves, totalPayments, remainingReserve, ref claimant)
  {
    this.InitializeComponent();
    this._childLineName = childLineName;
    this._childLineGuid = childLineGuid;
  }

  private void Fortegra_FormModifyReserve_Load(object sender, EventArgs e)
  {
    ((TextEditorControlBase) this.textChildLine).Value = (object) this._childLineName;
  }

  protected override void SaveModification()
  {
    if (MessageBox.Show($"This will change the remaining reserve from {((Control) this.textRemainingReserve).Text}, to {((Decimal) this.maskNewReserveAmt.Value).ToString("c")}. This change can only be done by adjusting the reserve again. Continue?", "Change Remaining Reserve?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    try
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
      {
        try
        {
          int num = (int) DefaultDatabase.ExecuteScalar("spClaims_InsertReservePayment", new object[32 /*0x20*/]
          {
            (object) "@ClaimId",
            (object) this._claimant.Owner.ClaimId.Value,
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
            (object) this.dateTimeReserveDate.DateTime
          });
          this.SaveCustomReservePaymentData(num);
          this.OnModifyReserveSaved(num, this._amt);
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

  private void SaveCustomReservePaymentData(int returnedResPayId)
  {
    DefaultDatabase.ExecuteNonQuery("Fortegra_InsertCustomReservePaymentData", new object[6]
    {
      (object) "@ResPayId",
      (object) returnedResPayId,
      (object) "@ChildLineGuid",
      (object) this._childLineGuid,
      (object) "@PaymentTypeId",
      (object) this._resPayTypeId
    });
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.label14 = new Label();
    this.textChildLine = new MGATextBox();
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
    ((ISupportInitialize) this.textComments).BeginInit();
    ((ISupportInitialize) this.dateTimeReserveDate).BeginInit();
    ((ISupportInitialize) this.maskNewReserveAmt).BeginInit();
    ((ISupportInitialize) this.textChildLine).BeginInit();
    this.SuspendLayout();
    this.label5.Location = new Point(13, 197);
    this.label6.Location = new Point(13, 174);
    this.label9.Location = new Point(13, 220);
    ((Control) this.textTotalReserves).Location = new Point(153, 174);
    ((Control) this.textTotalPayments).Location = new Point(153, 197);
    ((Control) this.textRemainingReserve).Location = new Point(153, 220);
    this.label10.Location = new Point(13, 287);
    ((Control) this.buttonCancel).Location = new Point(299, 410);
    ((Control) this.buttonSave).Location = new Point(195, 410);
    this.label11.Location = new Point(10, 253);
    this.label12.Location = new Point(13, 310);
    ((Control) this.textComments).Location = new Point(153, 310);
    this.label13.Location = new Point(13, 265);
    ((Control) this.dateTimeReserveDate).Location = new Point(153, 262);
    ((Control) this.dateTimeReserveDate).Margin = new Padding(2);
    ((Control) this.maskNewReserveAmt).Location = new Point(153, 287);
    ((Control) this.maskNewReserveAmt).Margin = new Padding(2);
    this.label14.AutoSize = true;
    this.label14.BackColor = Color.Transparent;
    this.label14.Location = new Point(13, 151);
    this.label14.Name = "label14";
    this.label14.Size = new Size(64 /*0x40*/, 13);
    this.label14.TabIndex = 27;
    this.label14.Text = "Line (Child):";
    ((AppearanceBase) appearance).BackColor = Color.White;
    ((AppearanceBase) appearance).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textChildLine).Appearance = (AppearanceBase) appearance;
    ((Control) this.textChildLine).BackColor = Color.White;
    ((Control) this.textChildLine).Location = new Point(153, 151);
    this.textChildLine.MGAStyle = MGAStyles.Blue;
    ((Control) this.textChildLine).Name = "textChildLine";
    ((EditorButtonControlBase) this.textChildLine).ReadOnly = true;
    ((Control) this.textChildLine).Size = new Size(244, 20);
    ((Control) this.textChildLine).TabIndex = 28;
    ((Control) this.textChildLine).TabStop = false;
    ((UltraControlBase) this.textChildLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textChildLine).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(404, 446);
    this.Controls.Add((Control) this.textChildLine);
    this.Controls.Add((Control) this.label14);
    this.Margin = new Padding(2);
    this.Name = nameof (Fortegra_FormModifyReserve);
    this.ShowIcon = false;
    this.Text = "Modify Reserve (Fortegra)";
    this.Load += new EventHandler(this.Fortegra_FormModifyReserve_Load);
    this.Controls.SetChildIndex((Control) this.label1, 0);
    this.Controls.SetChildIndex((Control) this.label2, 0);
    this.Controls.SetChildIndex((Control) this.label3, 0);
    this.Controls.SetChildIndex((Control) this.label4, 0);
    this.Controls.SetChildIndex((Control) this.label7, 0);
    this.Controls.SetChildIndex((Control) this.label8, 0);
    this.Controls.SetChildIndex((Control) this.textClaimNumber, 0);
    this.Controls.SetChildIndex((Control) this.textClaimantName, 0);
    this.Controls.SetChildIndex((Control) this.textReserveType, 0);
    this.Controls.SetChildIndex((Control) this.textReserveSubType, 0);
    this.Controls.SetChildIndex((Control) this.textCoverageType, 0);
    this.Controls.SetChildIndex((Control) this.textCoverageDescription, 0);
    this.Controls.SetChildIndex((Control) this.label5, 0);
    this.Controls.SetChildIndex((Control) this.label6, 0);
    this.Controls.SetChildIndex((Control) this.label9, 0);
    this.Controls.SetChildIndex((Control) this.textTotalReserves, 0);
    this.Controls.SetChildIndex((Control) this.textTotalPayments, 0);
    this.Controls.SetChildIndex((Control) this.textRemainingReserve, 0);
    this.Controls.SetChildIndex((Control) this.label10, 0);
    this.Controls.SetChildIndex((Control) this.buttonCancel, 0);
    this.Controls.SetChildIndex((Control) this.buttonSave, 0);
    this.Controls.SetChildIndex((Control) this.label11, 0);
    this.Controls.SetChildIndex((Control) this.maskNewReserveAmt, 0);
    this.Controls.SetChildIndex((Control) this.label12, 0);
    this.Controls.SetChildIndex((Control) this.textComments, 0);
    this.Controls.SetChildIndex((Control) this.label13, 0);
    this.Controls.SetChildIndex((Control) this.dateTimeReserveDate, 0);
    this.Controls.SetChildIndex((Control) this.label14, 0);
    this.Controls.SetChildIndex((Control) this.textChildLine, 0);
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
    ((ISupportInitialize) this.textComments).EndInit();
    ((ISupportInitialize) this.dateTimeReserveDate).EndInit();
    ((ISupportInitialize) this.maskNewReserveAmt).EndInit();
    ((ISupportInitialize) this.textChildLine).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
