// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_FormPaymentCheckInformation
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using MGASystems.Common;
using MGASystems.IMS.Claims;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

[Override(typeof (FormPaymentCheckInformation))]
public class Fortegra_FormPaymentCheckInformation : FormPaymentCheckInformation
{
  private Fortegra_ReservePayment _fortegraReserve;
  private Fortegra_ReservePayment _fortegraPayment;
  private Fortegra_ReservePayment _currentFortegraPayment;
  private IContainer components;

  public Fortegra_FormPaymentCheckInformation() => this.InitializeComponent();

  public Fortegra_FormPaymentCheckInformation(Claimant claimant, PaymentReserve currentPayment)
    : base(claimant, currentPayment)
  {
    this._currentFortegraPayment = (Fortegra_ReservePayment) currentPayment;
    this.InitializeComponent();
  }

  protected override void VoidClaimPayment(bool addReserve)
  {
    this.CreateReservePayment();
    this._currentFortegraPayment.SetVoidStatus(true);
    this.CurrentClaimant.ReservesAndPayments.Add((PaymentReserve) this._fortegraPayment);
    if (addReserve)
      this.CurrentClaimant.ReservesAndPayments.Add((PaymentReserve) this._fortegraReserve);
    this.CurrentClaimant.Owner.AddPaymentCreatedExpense();
    this.CurrentClaimant.Owner.AddActivity(new ClaimActivity(Utility.ClaimActivityType.PaymentVoided, DateTime.Now, CurrentUser.Instance.UserGUID, CurrentUser.Instance.DisplayName, Utility.ClaimStatus.Open));
    CurrentUser.Instance.LogAction($"Voided claim payment for reserve payment ID: {this._currentFortegraPayment.ReservePaymentId}");
    this.CurrentClaimant.EditState = Claimant.ClaimantState.Updated;
    this.CurrentClaimant.Owner.Save();
  }

  protected override void CreateReservePayment()
  {
    this._fortegraReserve = new Fortegra_ReservePayment(PaymentReserveType.Reserve, this._currentFortegraPayment.ReservePaymentTypeId, this._currentFortegraPayment.ReservePaymentType, this._currentFortegraPayment.ReservePaymentSubTypeId, this._currentFortegraPayment.ReservePaymentSubType, this._currentFortegraPayment.CoverageTypeId, this._currentFortegraPayment.CoverageType, this._currentFortegraPayment.CoverageTypeDescriptionId, this._currentFortegraPayment.CoverageTypeDescription, this._currentFortegraPayment.Comments, this._currentFortegraPayment.ReservePaymentAmount, Guid.Empty, string.Empty, this._currentFortegraPayment.IsRecovery);
    this._fortegraReserve.IsPaymentReduction = true;
    this._fortegraReserve.ChildLineGuid = this._currentFortegraPayment.ChildLineGuid;
    this._fortegraReserve.ChildLineDesc = this._currentFortegraPayment.ChildLineDesc;
    this._fortegraPayment = new Fortegra_ReservePayment(PaymentReserveType.Payment, this._currentFortegraPayment.ReservePaymentTypeId, this._currentFortegraPayment.ReservePaymentType, this._currentFortegraPayment.ReservePaymentSubTypeId, this._currentFortegraPayment.ReservePaymentSubType, this._currentFortegraPayment.CoverageTypeId, this._currentFortegraPayment.CoverageType, this._currentFortegraPayment.CoverageTypeDescriptionId, this._currentFortegraPayment.CoverageTypeDescription, this._currentFortegraPayment.Comments, this._currentFortegraPayment.ReservePaymentAmount * -1M, this._currentFortegraPayment.PayeeGuid, this._currentFortegraPayment.PayeeName, this._currentFortegraPayment.IsRecovery);
    this._fortegraPayment.IsVoid = true;
    this._fortegraPayment.IsPayeeClaimant = this._currentFortegraPayment.IsPayeeClaimant;
    this._fortegraPayment.IsPayeeInsured = this._currentFortegraPayment.IsPayeeInsured;
    this._fortegraPayment.PayeeAddress1 = this._currentFortegraPayment.PayeeAddress1;
    this._fortegraPayment.PayeeAddress2 = this._currentFortegraPayment.PayeeAddress2;
    this._fortegraPayment.PayeeCity = this._currentFortegraPayment.PayeeCity;
    this._fortegraPayment.PayeeState = this._currentFortegraPayment.PayeeState;
    this._fortegraPayment.PayeeZipCode = this._currentFortegraPayment.PayeeZipCode;
    this._fortegraPayment.PayeeZipCodeExtension = this._currentFortegraPayment.PayeeZipCodeExtension;
    this._fortegraPayment.PayeeIsInternational = this._currentFortegraPayment.PayeeIsInternational;
    this._fortegraPayment.PayeeInternationalZipCode = this._currentFortegraPayment.PayeeInternationalZipCode;
    this._fortegraPayment.PayeeISOCountryCode = this._currentFortegraPayment.PayeeISOCountryCode;
    this._fortegraPayment.PayeeFEIN = this._currentFortegraPayment.PayeeFEIN;
    this._fortegraPayment.PayeeSSN = this._currentFortegraPayment.PayeeSSN;
    this._fortegraPayment.PayeeEmail = this._currentFortegraPayment.PayeeEmail;
    this._fortegraPayment.PayeeIs1099 = this._currentFortegraPayment.PayeeIs1099;
    this._fortegraPayment.IsPayeeDefenseAttorney = this._currentFortegraPayment.IsPayeeDefenseAttorney;
    this._fortegraPayment.IsPayeeClaimantAttorney = this._currentFortegraPayment.IsPayeeClaimantAttorney;
    this._fortegraPayment.ChildLineGuid = this._currentFortegraPayment.ChildLineGuid;
    this._fortegraPayment.ChildLineDesc = this._currentFortegraPayment.ChildLineDesc;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ((ISupportInitialize) this.buttonVoidCheck).BeginInit();
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(302, 441);
    this.Name = nameof (Fortegra_FormPaymentCheckInformation);
    this.Text = "Payment Check Information (Fortegra)";
    ((ISupportInitialize) this.buttonVoidCheck).EndInit();
    this.ResumeLayout(false);
  }
}
