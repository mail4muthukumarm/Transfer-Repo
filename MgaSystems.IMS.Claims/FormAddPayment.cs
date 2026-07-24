// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormAddPayment
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinListView;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.IMS.BusinessClasses;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormAddPayment : FormAddReserve
{
  protected PaymentReserve _currentReserve;
  protected FormSelectPayee.PayeeType _payeeType;
  protected bool _isRecovery;
  protected bool _isPaymentReturn;
  protected FormClaimant _ownerForm;
  private List<string> _associatedDocuments = new List<string>();
  protected string _insuredAddressSetting = "INSUREDPAYEE_GETADDRESS";
  private Guid _payeeGuid;
  private string _payeeName;
  private string _payeeAddress1;
  private string _payeeAddress2;
  private string _payeeCity;
  private string _payeeState;
  private string _payeeZipCode;
  private string _payeeZipCodeExtension;
  private bool _payeeIsInternational;
  private string _payeeInternationalZipCode;
  private string _payeeISOCountryCode;
  private string _payeeEmail;
  private string _payeeFEIN;
  private string _payeeSSN;
  private bool _payeeIs1099;
  private IContainer components;
  private UltraLabel ultraLabel7;
  private UltraLabel ultraLabel9;
  protected UltraLabel ultraLabel8;
  protected MGATextBox textRecoveryCheckNumber;
  protected internal MGATextBox textMultiplePayees;
  protected internal AddressResolver_MULTI addressResolverOverride;
  protected MGATextBox textPayee;
  protected MGAButton buttonAddDocument;
  protected MGAButton mgaViewDocuments;
  protected UltraListView listBoxDocuments;
  protected MGAButton buttonSearchPayee;

  public FormAddPayment() => this.InitializeComponent();

  public FormAddPayment(Claimant claimant, PaymentReserve currentReserve, bool isPaymentReturn)
    : base(claimant)
  {
    this.InitializeComponent();
    this.InitializeFormComplete += new FormAddReserve.InitializeFormCompletedHandler(this.FormAddPayment_InitializeFormComplete);
    this._currentReserve = currentReserve;
    this._isPaymentReturn = isPaymentReturn;
    this.DisplayCurrentReserve();
    this._isRecovery = this._currentReserve.IsRecovery;
    ((Control) this.textRecoveryCheckNumber).Enabled = this._isRecovery || this._isPaymentReturn;
  }

  public FormAddPayment(
    Claimant claimant,
    PaymentReserve currentReserve,
    bool isPaymentReturn,
    FormClaimant ownerForm)
    : base(claimant)
  {
    this.InitializeComponent();
    this.InitializeFormComplete += new FormAddReserve.InitializeFormCompletedHandler(this.FormAddPayment_InitializeFormComplete);
    this._ownerForm = ownerForm;
    this._currentReserve = currentReserve;
    this._isPaymentReturn = isPaymentReturn;
    this.DisplayCurrentReserve();
    this._isRecovery = this._currentReserve.IsRecovery;
    ((Control) this.textRecoveryCheckNumber).Enabled = this._isRecovery || this._isPaymentReturn;
  }

  public FormAddPayment(Claimant claimant)
    : base(claimant)
  {
    this.InitializeComponent();
  }

  public void FormAddPayment_InitializeFormComplete(object sender, EventArgs e)
  {
    this.SetAddressResolverProperties();
    this.DisplayCurrentReserve();
    this._isRecovery = this._currentReserve.IsRecovery;
    ((Control) this.textRecoveryCheckNumber).Enabled = this._isRecovery || this._isPaymentReturn;
  }

  protected Guid PayeeGuid
  {
    get => this._payeeGuid;
    set => this._payeeGuid = value;
  }

  protected string PayeeName
  {
    get => this._payeeName;
    set => this._payeeName = value;
  }

  protected string PayeeAddress1
  {
    get => this._payeeAddress1;
    set => this._payeeAddress1 = value;
  }

  protected string PayeeAddress2
  {
    get => this._payeeAddress2;
    set => this._payeeAddress2 = value;
  }

  protected string PayeeCity
  {
    get => this._payeeCity;
    set => this._payeeCity = value;
  }

  protected string PayeeState
  {
    get => this._payeeState;
    set => this._payeeState = value;
  }

  protected string PayeeZipCode
  {
    get => this._payeeZipCode;
    set => this._payeeZipCode = value;
  }

  protected string PayeeZipCodeExtension
  {
    get => this._payeeZipCodeExtension;
    set => this._payeeZipCodeExtension = value;
  }

  protected bool PayeeIsInternational
  {
    get => this._payeeIsInternational;
    set => this._payeeIsInternational = value;
  }

  protected string PayeeInternationalZipCode
  {
    get => this._payeeInternationalZipCode;
    set => this._payeeInternationalZipCode = value;
  }

  protected string PayeeISOCountryCode
  {
    get => this._payeeISOCountryCode;
    set => this._payeeISOCountryCode = value;
  }

  protected string PayeeEmail
  {
    get => this._payeeEmail;
    set => this._payeeEmail = value;
  }

  protected string PayeeFEIN
  {
    get => this._payeeFEIN;
    set => this._payeeFEIN = value;
  }

  protected string PayeeSSN
  {
    get => this._payeeSSN;
    set => this._payeeSSN = value;
  }

  protected bool PayeeIs1099
  {
    get => this._payeeIs1099;
    set => this._payeeIs1099 = value;
  }

  public FormClaimant OwnerForm
  {
    get => this._ownerForm;
    set => this._ownerForm = value;
  }

  protected internal virtual bool ValidateForm(Decimal overrideAmount)
  {
    if (!base.ValidateForm())
      return false;
    if (string.IsNullOrEmpty(this._payeeName))
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_PAYEEREQUIRED_ERROR, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!this._isRecovery && !this._isPaymentReturn && Decimal.Parse(((Control) this.textAmount).Text) < 0M)
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_AMOUNTLESSTHANZERO_ERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (Math.Abs(Decimal.Parse(((Control) this.textAmount).Text)) > Math.Abs(this._currentReserve.ReservePaymentAmount + overrideAmount + this._currentClaimant.GetReserveTotal(this._currentReserve, false)))
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_PAYMENTWILLEXCEEDRESERVE, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    Decimal result;
    if (!Decimal.TryParse(((Control) this.textAmount).Text, NumberStyles.Any, (IFormatProvider) null, out result))
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_INVALIDAMOUNT_ERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    return this.CheckReserveLevel(result);
  }

  protected override bool ValidateForm()
  {
    if (!this.ValidateForm_Payment())
      return false;
    if (string.IsNullOrEmpty(this._payeeName))
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_PAYEEREQUIRED_ERROR, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this._isRecovery || this._isPaymentReturn)
    {
      if ((!this._isRecovery || !this._isPaymentReturn) && Decimal.Parse(((Control) this.textAmount).Text, NumberStyles.Any) > 0M)
      {
        int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_AMOUNTGREATERTHANZERO_ERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    else if (Decimal.Parse(((Control) this.textAmount).Text, NumberStyles.Any) < 0M)
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_AMOUNTLESSTHANZERO_ERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (Math.Abs(Decimal.Parse(((Control) this.textAmount).Text, NumberStyles.Any)) > Math.Abs(this._currentReserve.ReservePaymentAmount + this._currentClaimant.GetReserveTotal(this._currentReserve, false)))
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_PAYMENTWILLEXCEEDRESERVE, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    Decimal result;
    if (!Decimal.TryParse(((Control) this.textAmount).Text, NumberStyles.Any, (IFormatProvider) null, out result))
    {
      int num = (int) MessageBox.Show(Resources.RESERVEPAYMENT_INVALIDAMOUNT_ERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    return this.CheckReserveLevel(result);
  }

  protected internal override void CreateReservePayment()
  {
    this._reserve = new PaymentReserve(PaymentReserveType.Reserve, (int) ((UltraCombo) this.comboReserveType).Value, ((Control) this.comboReserveType).Text, ((UltraDropDownBase) this.comboReserveSubType).SelectedRow == null ? new int?() : (int?) ((UltraCombo) this.comboReserveSubType).Value, ((UltraDropDownBase) this.comboReserveSubType).SelectedRow == null ? string.Empty : ((Control) this.comboReserveSubType).Text, ((UltraDropDownBase) this.comboCoverageType).SelectedRow == null ? new int?() : (int?) ((UltraCombo) this.comboCoverageType).Value, ((UltraDropDownBase) this.comboCoverageType).SelectedRow == null ? string.Empty : ((Control) this.comboCoverageType).Text, ((UltraDropDownBase) this.comboCoverageSubType).SelectedRow == null ? new int?() : (int?) ((UltraCombo) this.comboCoverageSubType).Value, ((UltraDropDownBase) this.comboCoverageSubType).SelectedRow == null ? string.Empty : ((Control) this.comboCoverageSubType).Text, ((Control) this.textComments).Text, Decimal.Parse(((Control) this.textAmount).Text, NumberStyles.Any) * -1M, Guid.Empty, string.Empty, (bool) ((UltraDropDownBase) this.comboReserveType).SelectedRow.Cells["IsRecoveryType"].Value, false, new int?());
    this._reserve.IsPaymentReduction = true;
    this._reserve.DateCreated = ((UltraDateTimeEditor) this.dateTimeReserveDate).DateTime;
    this._payment = new PaymentReserve(PaymentReserveType.Payment, (int) ((UltraCombo) this.comboReserveType).Value, ((Control) this.comboReserveType).Text, ((UltraDropDownBase) this.comboReserveSubType).SelectedRow == null ? new int?() : (int?) ((UltraCombo) this.comboReserveSubType).Value, ((UltraDropDownBase) this.comboReserveSubType).SelectedRow == null ? string.Empty : ((Control) this.comboReserveSubType).Text, ((UltraDropDownBase) this.comboCoverageType).SelectedRow == null ? new int?() : (int?) ((UltraCombo) this.comboCoverageType).Value, ((UltraDropDownBase) this.comboCoverageType).SelectedRow == null ? string.Empty : ((Control) this.comboCoverageType).Text, ((UltraDropDownBase) this.comboCoverageSubType).SelectedRow == null ? new int?() : (int?) ((UltraCombo) this.comboCoverageSubType).Value, ((UltraDropDownBase) this.comboCoverageSubType).SelectedRow == null ? string.Empty : ((Control) this.comboCoverageSubType).Text, ((Control) this.textComments).Text, Decimal.Parse(((Control) this.textAmount).Text, NumberStyles.Any), this.PayeeGuid, this.PayeeName, (bool) ((UltraDropDownBase) this.comboReserveType).SelectedRow.Cells["IsRecoveryType"].Value, this._isPaymentReturn, this._isPaymentReturn ? this._currentReserve.ReservePaymentId : new int?());
    this._payment.IsPaymentReduction = false;
    this._payment.DateCreated = ((UltraDateTimeEditor) this.dateTimeReserveDate).DateTime;
    this._payment.IsPayeeClaimant = this._payeeType == FormSelectPayee.PayeeType.Claimant;
    this._payment.IsPayeeInsured = this._payeeType == FormSelectPayee.PayeeType.Insured;
    this._payment.PayeeAddress1 = this.PayeeAddress1;
    this._payment.PayeeAddress2 = this.PayeeAddress2;
    this._payment.PayeeCity = this.PayeeCity;
    this._payment.PayeeState = this.PayeeState;
    this._payment.PayeeZipCode = this.PayeeZipCode;
    this._payment.PayeeZipCodeExtension = this.PayeeZipCodeExtension;
    this._payment.PayeeIsInternational = this.PayeeIsInternational;
    this._payment.PayeeInternationalZipCode = this.PayeeInternationalZipCode;
    this._payment.PayeeISOCountryCode = this.PayeeISOCountryCode;
    this._payment.PayeeFEIN = this.PayeeFEIN;
    this._payment.PayeeSSN = this.PayeeSSN;
    this._payment.PayeeEmail = this.PayeeEmail;
    this._payment.PayeeIs1099 = this.PayeeIs1099;
    this._payment.IsRecovery = this._isRecovery;
    this._payment.RecoveryCheckNumber = ((Control) this.textRecoveryCheckNumber).Text;
    this._payment.IsPayeeDefenseAttorney = this._payeeType == FormSelectPayee.PayeeType.DefenseAttorney;
    this._payment.IsPayeeClaimantAttorney = this._payeeType == FormSelectPayee.PayeeType.ClaimantAttorney;
    this._payment.AdditionalPayees = ((Control) this.textMultiplePayees).Text;
    if (!string.IsNullOrEmpty(this.addressResolverOverride.Address1))
    {
      this._payment.OverridePayeeAddress.Address1 = this.addressResolverOverride.Address1;
      this._payment.OverridePayeeAddress.Address2 = this.addressResolverOverride.Address2;
      this._payment.OverridePayeeAddress.City = this.addressResolverOverride.City;
      this._payment.OverridePayeeAddress.State = this.addressResolverOverride.State;
      this._payment.OverridePayeeAddress.ZipCode = this.addressResolverOverride.ZipCode;
      this._payment.OverridePayeeAddress.ZipCodeExtension = this.addressResolverOverride.ZipCodeExtension;
      this._payment.OverridePayeeAddress.IsoCountryCode = this.addressResolverOverride.ISOCountryCode;
      this._payment.OverridePayeeAddress.ZipCode = this.addressResolverOverride.ZipCode;
    }
    this.AddPaymentDocuments(this._payment);
  }

  protected override bool CheckReserveLevel(Decimal amt)
  {
    if (!SystemSettings.KeyExists("CLAIMS_CHECKRESERVELEVEL") || !SystemSettings.GetBoolSetting("CLAIMS_CHECKRESERVELEVEL") || Utility.GetReserveLevelGuid(amt))
      return true;
    int num = (int) MessageBox.Show("You do not have rights to create a payment for this amount, please contact your system administrator for more information.", "Invalid Payment Amount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected void AddPaymentDocuments(PaymentReserve _payment)
  {
    for (int index = 0; index < this._associatedDocuments.Count; ++index)
      _payment.AssociatedDocuments.Add(this._associatedDocuments[index]);
    this._associatedDocuments.Clear();
  }

  protected virtual Address GetAddress(Guid entityGuid) => Utility.GetEntityAddress(entityGuid);

  protected override void Save()
  {
    if (!this.ValidateForm())
      return;
    this.CreateReservePayment();
    this._currentClaimant.ReservesAndPayments.Add(this._payment);
    this._currentClaimant.ReservesAndPayments.Add(this._reserve);
    this._currentClaimant.Owner.AddPaymentCreatedExpense();
    this._currentClaimant.Owner.AddActivity(new ClaimActivity(Utility.ClaimActivityType.PaymentCreated, DateTime.Now, CurrentUser.Instance.UserGUID, CurrentUser.Instance.DisplayName, (Utility.ClaimStatus) this._currentClaimant.StatusId));
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void DisplayCurrentReserve()
  {
    ((UltraCombo) this.comboReserveType).Value = (object) this._currentReserve.ReservePaymentTypeId;
    if (this._currentReserve.ReservePaymentSubTypeId.HasValue)
      ((UltraCombo) this.comboReserveSubType).Value = (object) this._currentReserve.ReservePaymentSubTypeId;
    if (this._currentReserve.CoverageTypeId.HasValue)
      ((UltraCombo) this.comboCoverageType).Value = (object) this._currentReserve.CoverageTypeId;
    if (!this._currentReserve.CoverageTypeDescriptionId.HasValue)
      return;
    ((UltraCombo) this.comboCoverageSubType).Value = (object) this._currentReserve.CoverageTypeDescriptionId;
  }

  public event EventHandler PayeeSelected;

  protected void OnPayeeSelected()
  {
    if (this.PayeeSelected == null)
      return;
    this.PayeeSelected((object) this, new EventArgs());
  }

  private void buttonSearchPayee_Click(object sender, EventArgs e) => this.SelectPayee();

  private void SetAddressResolverProperties()
  {
    this.addressResolverOverride.WebserviceUrl = AddressResolverSettings.AddressResolverURL;
    this.addressResolverOverride.UserID = AddressResolverSettings.AddressResolveUserName;
    this.addressResolverOverride.Password = AddressResolverSettings.AddressResolverPassword;
  }

  protected virtual FormSelectPayee GetSelectPayeeForm()
  {
    return (FormSelectPayee) ObjectFactory.Instance.CreateForm(typeof (FormSelectPayee), new object[2]
    {
      (object) this._currentClaimant.LegalInformation.HasClaimantAttorney,
      (object) this._currentClaimant.LegalInformation.HasDefenseAttorney
    });
  }

  protected virtual void SelectPayee()
  {
    using (FormSelectPayee selectPayeeForm = this.GetSelectPayeeForm())
    {
      if (selectPayeeForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        this._payeeType = selectPayeeForm.SelectedPayeeType;
        switch (selectPayeeForm.SelectedPayeeType)
        {
          case FormSelectPayee.PayeeType.Claimant:
            if (this._currentClaimant.ClaimantInformation == null || string.IsNullOrEmpty(this._currentClaimant.ClaimantInformation.FirstName) || string.IsNullOrEmpty(this._currentClaimant.ClaimantInformation.CorporationName))
              this._ownerForm.CreateClaimant();
            this._payeeGuid = this._currentClaimant.ClaimantGuid;
            this._payeeName = this._currentClaimant.DisplayName;
            this._payeeAddress1 = this._currentClaimant.PrimaryAddress.Address1;
            this._payeeAddress2 = this._currentClaimant.PrimaryAddress.Address2;
            this._payeeCity = this._currentClaimant.PrimaryAddress.City;
            this._payeeState = this._currentClaimant.PrimaryAddress.State;
            this._payeeZipCode = this._currentClaimant.PrimaryAddress.ZipCode;
            this._payeeISOCountryCode = this._currentClaimant.PrimaryAddress.IsoCountryCode;
            break;
          case FormSelectPayee.PayeeType.ClaimantAttorney:
            this._payeeGuid = this._currentClaimant.LegalInformation.ClaimantAttorneyGuid;
            this._payeeName = string.IsNullOrEmpty(this._currentClaimant.LegalInformation.ClaimantLawFirm) ? this._currentClaimant.LegalInformation.ClaimantAttorney : this._currentClaimant.LegalInformation.ClaimantLawFirm;
            this._payeeAddress1 = this._currentClaimant.LegalInformation.ClaimantAttorneyAddress.Address1;
            this._payeeAddress2 = this._currentClaimant.LegalInformation.ClaimantAttorneyAddress.Address2;
            this._payeeCity = this._currentClaimant.LegalInformation.ClaimantAttorneyAddress.City;
            this._payeeState = this._currentClaimant.LegalInformation.ClaimantAttorneyAddress.State;
            this._payeeZipCode = this._currentClaimant.LegalInformation.ClaimantAttorneyAddress.ZipCode;
            this._payeeZipCodeExtension = this._currentClaimant.LegalInformation.ClaimantAttorneyAddress.ZipCodeExtension;
            this._payeeISOCountryCode = this._currentClaimant.LegalInformation.ClaimantAttorneyAddress.IsoCountryCode;
            this._payeeIsInternational = this._currentClaimant.LegalInformation.ClaimantAttorneyAddress.IsInternational;
            if (!this._payeeIsInternational)
            {
              this._payeeZipCode = this._currentClaimant.LegalInformation.ClaimantAttorneyAddress.ZipCode;
              this._payeeZipCodeExtension = this._currentClaimant.LegalInformation.ClaimantAttorneyAddress.ZipCodeExtension;
            }
            else
              this._payeeInternationalZipCode = this._currentClaimant.LegalInformation.ClaimantAttorneyAddress.ZipCode;
            this._payeeFEIN = this._currentClaimant.LegalInformation.ClaimantAttorneyFeinSsn;
            break;
          case FormSelectPayee.PayeeType.DefenseAttorney:
            this._payeeGuid = this._currentClaimant.LegalInformation.DefenseAttorneyGuid;
            this._payeeName = string.IsNullOrEmpty(this._currentClaimant.LegalInformation.DefenseFirm) ? this._currentClaimant.LegalInformation.DefenseAttorney : this._currentClaimant.LegalInformation.DefenseFirm;
            this._payeeAddress1 = this._currentClaimant.LegalInformation.DefenseAttorneyAddress.Address1;
            this._payeeAddress2 = this._currentClaimant.LegalInformation.DefenseAttorneyAddress.Address2;
            this._payeeCity = this._currentClaimant.LegalInformation.DefenseAttorneyAddress.City;
            this._payeeState = this._currentClaimant.LegalInformation.DefenseAttorneyAddress.State;
            this._payeeZipCode = this._currentClaimant.LegalInformation.DefenseAttorneyAddress.ZipCode;
            this._payeeZipCodeExtension = this._currentClaimant.LegalInformation.DefenseAttorneyAddress.ZipCodeExtension;
            this._payeeISOCountryCode = this._currentClaimant.LegalInformation.DefenseAttorneyAddress.IsoCountryCode;
            this._payeeIsInternational = this._currentClaimant.LegalInformation.DefenseAttorneyAddress.IsInternational;
            if (!this._payeeIsInternational)
            {
              this._payeeZipCode = this._currentClaimant.LegalInformation.DefenseAttorneyAddress.ZipCode;
              this._payeeZipCodeExtension = this._currentClaimant.LegalInformation.DefenseAttorneyAddress.ZipCodeExtension;
            }
            else
              this._payeeInternationalZipCode = this._currentClaimant.LegalInformation.DefenseAttorneyAddress.ZipCode;
            this._payeeFEIN = this._currentClaimant.LegalInformation.DefenseAttorneyFeinSsn;
            break;
          case FormSelectPayee.PayeeType.Insured:
            DataRow insuredInformation = Utility.GetClaimantInsuredInformation(this._currentClaimant.Owner.ControlNumber);
            if (insuredInformation != null)
            {
              this._payeeGuid = new Guid(insuredInformation["InsuredGuid"].ToString());
              this._payeeName = string.IsNullOrEmpty(insuredInformation["CorporationName"].ToString()) ? $"{insuredInformation["FirstName"].ToString()} {insuredInformation["LastName"].ToString()}" : insuredInformation["CorporationName"].ToString();
              if (SystemSettings.KeyExists(this._insuredAddressSetting) && SystemSettings.GetBoolSetting(this._insuredAddressSetting))
              {
                if (insuredInformation["address1"] != DBNull.Value && !string.IsNullOrEmpty(insuredInformation["address1"].ToString()))
                  this._payeeAddress1 = insuredInformation["address1"].ToString();
                if (insuredInformation["address2"] != DBNull.Value && !string.IsNullOrEmpty(insuredInformation["address2"].ToString()))
                  this._payeeAddress2 = insuredInformation["address2"].ToString();
                if (insuredInformation["city"] != DBNull.Value && !string.IsNullOrEmpty(insuredInformation["city"].ToString()))
                  this._payeeCity = insuredInformation["city"].ToString();
                if (insuredInformation["state"] != DBNull.Value && !string.IsNullOrEmpty(insuredInformation["state"].ToString()))
                  this._payeeState = insuredInformation["state"].ToString();
                if (insuredInformation["zip"] != DBNull.Value && !string.IsNullOrEmpty(insuredInformation["zip"].ToString()))
                  this._payeeZipCode = insuredInformation["zip"].ToString();
                if (insuredInformation["isocountrycode"] != DBNull.Value && !string.IsNullOrEmpty(insuredInformation["isocountrycode"].ToString()))
                {
                  this._payeeISOCountryCode = insuredInformation["isocountrycode"].ToString();
                  break;
                }
                break;
              }
              break;
            }
            break;
          case FormSelectPayee.PayeeType.Other:
            this._payeeGuid = selectPayeeForm.PayeeGuid;
            this._payeeName = selectPayeeForm.PayeeName;
            Address address = this.GetAddress(selectPayeeForm.PayeeGuid);
            this._payeeAddress1 = address.Address1;
            this._payeeAddress2 = address.Address2;
            this._payeeCity = address.City;
            this._payeeState = address.State;
            this._payeeZipCode = address.ZipCode;
            this._payeeZipCodeExtension = address.ZipCodeExtension;
            this._payeeISOCountryCode = address.IsoCountryCode;
            this._payeeIsInternational = address.IsInternational;
            this._payeeISOCountryCode = address.IsoCountryCode;
            this._payeeIsInternational = address.IsInternational;
            break;
        }
      }
      ((Control) this.textPayee).Text = this.PayeeName;
      ((TextEditorControlBase) this.textMultiplePayees).MaxLength = 500 - (((Control) this.textPayee).Text.Length + 2);
      this.CheckPayeeOFACStatus();
      this.OnPayeeSelected();
    }
  }

  protected void CheckPayeeOFACStatus()
  {
    if (Utility.PerformOFACCheck(new ClaimOFACEntity(this._payeeGuid, "MGASystems.IMS.Claims.FormClaims")
    {
      CorporationName = this._payeeName,
      DBAName = string.Empty,
      FirstName = string.Empty,
      MiddleName = string.Empty,
      LastName = string.Empty,
      FEINSSN = this._payeeSSN,
      ISOCountryCode = this._currentClaimant.PrimaryAddress.IsoCountryCode,
      Address1 = this._payeeAddress1,
      Address2 = this._payeeAddress2,
      City = this._payeeCity,
      State = this._payeeState,
      ZipCode = this._payeeZipCode,
      ParentEntityGuid = new Guid?()
    }))
    {
      int num = (int) MessageBox.Show("The system has deteced an OFAC hit on the selected payee. Payments cannot be made to this payee until approved by compliance.", "Payee Suspended!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((Control) this.buttonSave).Enabled = false;
    }
    else
      ((Control) this.buttonSave).Enabled = true;
  }

  private void buttonAddDocument_Click(object sender, EventArgs e)
  {
    OpenFileDialog openFileDialog = new OpenFileDialog();
    openFileDialog.Multiselect = true;
    if (openFileDialog.ShowDialog() != DialogResult.OK)
      return;
    try
    {
      if (openFileDialog.FileNames.Length == 0)
        return;
      for (int index = 0; index < openFileDialog.FileNames.Length; ++index)
        this._associatedDocuments.Add(openFileDialog.FileNames[index]);
    }
    finally
    {
      this.DisplayDocumentCount();
    }
  }

  private void DisplayDocumentCount()
  {
    ((Control) this.buttonAddDocument).Text = $"{this._associatedDocuments.Count} Documents";
  }

  private void mgaViewDocuments_Click(object sender, EventArgs e)
  {
    if (this._associatedDocuments.Count == 0)
      return;
    if (((Control) this.listBoxDocuments).Visible)
    {
      ((Control) this.listBoxDocuments).Visible = false;
    }
    else
    {
      this.DisplaySelectedDocuments();
      ((Control) this.listBoxDocuments).Visible = true;
    }
  }

  private void DisplaySelectedDocuments()
  {
    string empty = string.Empty;
    this.listBoxDocuments.Items.Clear();
    for (int index = 0; index < this._associatedDocuments.Count; ++index)
    {
      string associatedDocument = this._associatedDocuments[index];
      this.listBoxDocuments.Items.Add(associatedDocument, (object) associatedDocument);
    }
  }

  private void listBoxDocuments_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Delete)
      return;
    if (((DisposableObjectCollectionBase) this.listBoxDocuments.CheckedItems).Count == 0)
    {
      int num = (int) MessageBox.Show("You have not selected any items to be deleted", "Nothing Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (MessageBox.Show("Are you sure you wish to delete the selected documents?", "Delete Selected Documents?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      for (int index = 0; index < ((DisposableObjectCollectionBase) this.listBoxDocuments.CheckedItems).Count; ++index)
      {
        this._associatedDocuments.Remove(((KeyedSubObjectBase) ((UltraListViewStateSpecificItemsCollectionBase) this.listBoxDocuments.CheckedItems)[index]).Key);
        this.OnDocumentDeleted(((KeyedSubObjectBase) ((UltraListViewStateSpecificItemsCollectionBase) this.listBoxDocuments.CheckedItems)[index]).Key);
      }
      this.DisplaySelectedDocuments();
      this.DisplayDocumentCount();
    }
  }

  public event FormAddPayment.DocumentDeletedHandler DocumentDeleted;

  protected virtual void OnDocumentDeleted(string documentKey)
  {
    FormAddPayment.DocumentDeletedHandler documentDeleted = this.DocumentDeleted;
    if (documentDeleted == null)
      return;
    documentDeleted((object) this, new DocumentDeleteEventArgs(documentKey));
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
    this.ultraLabel7 = new UltraLabel();
    this.textPayee = new MGATextBox();
    this.buttonSearchPayee = new MGAButton();
    this.ultraLabel8 = new UltraLabel();
    this.textRecoveryCheckNumber = new MGATextBox();
    this.textMultiplePayees = new MGATextBox();
    this.ultraLabel9 = new UltraLabel();
    this.addressResolverOverride = new AddressResolver_MULTI();
    this.buttonAddDocument = new MGAButton();
    this.mgaViewDocuments = new MGAButton();
    this.listBoxDocuments = new UltraListView();
    ((ISupportInitialize) this.comboCoverageType).BeginInit();
    ((ISupportInitialize) this.comboReserveType).BeginInit();
    ((ISupportInitialize) this.comboReserveSubType).BeginInit();
    ((ISupportInitialize) this.comboCoverageSubType).BeginInit();
    ((ISupportInitialize) this.textComments).BeginInit();
    ((ISupportInitialize) this.textAmount).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.coverageTypeDescriptionsBindingSource).BeginInit();
    ((ISupportInitialize) this.reserveTypesBindingSource).BeginInit();
    ((ISupportInitialize) this.dsReservePaymentTypes1BindingSource).BeginInit();
    ((ISupportInitialize) this.reserveSubTypesBindingSource).BeginInit();
    ((ISupportInitialize) this.coverageTypesBindingSource).BeginInit();
    ((ISupportInitialize) this.reserveTypesBindingSource1).BeginInit();
    this.dsReservePaymentTypes1.BeginInit();
    this.dsCoverageTypes1.BeginInit();
    ((ISupportInitialize) this.dateTimeReserveDate).BeginInit();
    ((ISupportInitialize) this.textPayee).BeginInit();
    ((ISupportInitialize) this.buttonSearchPayee).BeginInit();
    ((ISupportInitialize) this.textRecoveryCheckNumber).BeginInit();
    ((ISupportInitialize) this.textMultiplePayees).BeginInit();
    ((ISupportInitialize) this.buttonAddDocument).BeginInit();
    ((ISupportInitialize) this.mgaViewDocuments).BeginInit();
    ((ISupportInitialize) this.listBoxDocuments).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.comboCoverageType).DataSource = (object) this.dsCoverageTypes1.CoverageTypes;
    ((Control) this.comboCoverageType).Enabled = false;
    ((Control) this.comboCoverageType).Location = new Point(137, 86);
    ((Control) this.comboCoverageType).TabIndex = 8;
    ((Control) this.ultraLabel1).Location = new Point(5, 32 /*0x20*/);
    ((Control) this.ultraLabel1).TabIndex = 3;
    ((Control) this.ultraLabel2).Location = new Point(5, 59);
    ((Control) this.ultraLabel2).TabIndex = 5;
    ((Control) this.ultraLabel3).Location = new Point(5, 86);
    ((Control) this.ultraLabel3).TabIndex = 7;
    ((Control) this.ultraLabel4).Location = new Point(5, 113);
    ((Control) this.ultraLabel4).TabIndex = 9;
    ((Control) this.ultraLabel5).Location = new Point(5, 140);
    ((Control) this.ultraLabel5).TabIndex = 11;
    ((Control) this.ultraLabel6).Location = new Point(5, 256 /*0x0100*/);
    ((Control) this.ultraLabel6).TabIndex = 13;
    ((UltraGridBase) this.comboReserveType).DataSource = (object) this.dsReservePaymentTypes1.ReserveTypes;
    ((Control) this.comboReserveType).Enabled = false;
    ((Control) this.comboReserveType).Location = new Point(137, 33);
    ((Control) this.comboReserveType).TabIndex = 4;
    ((UltraGridBase) this.comboReserveSubType).DataSource = (object) this.dsReservePaymentTypes1.ReserveSubTypes;
    ((Control) this.comboReserveSubType).Enabled = false;
    ((Control) this.comboReserveSubType).Location = new Point(137, 59);
    ((Control) this.comboReserveSubType).TabIndex = 6;
    ((UltraGridBase) this.comboCoverageSubType).DataSource = (object) this.dsCoverageTypes1.CoverageTypeDescriptions;
    ((Control) this.comboCoverageSubType).Enabled = false;
    ((Control) this.comboCoverageSubType).Location = new Point(137, 113);
    ((Control) this.comboCoverageSubType).TabIndex = 10;
    ((Control) this.textComments).Location = new Point(137, 140);
    ((Control) this.textComments).Size = new Size(276, 84);
    ((Control) this.textComments).TabIndex = 12;
    ((Control) this.textAmount).Location = new Point(137, 256 /*0x0100*/);
    ((Control) this.textAmount).TabIndex = 14;
    ((Control) this.buttonSave).Location = new Point(651, 323);
    ((Control) this.buttonSave).TabIndex = 20;
    ((Control) this.buttonCancel).Location = new Point(744, 323);
    ((Control) this.buttonCancel).TabIndex = 21;
    ((Control) this.lblDate).Location = new Point(6, 230);
    ((Control) this.dateTimeReserveDate).Location = new Point(137, 230);
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel7).Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraLabel7).AutoSize = true;
    ((Control) this.ultraLabel7).Location = new Point(3, 6);
    ((Control) this.ultraLabel7).Name = "ultraLabel7";
    ((Control) this.ultraLabel7).Size = new Size(38, 15);
    ((Control) this.ultraLabel7).TabIndex = 0;
    ((Control) this.ultraLabel7).Text = "Payee:";
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPayee).Appearance = (AppearanceBase) appearance2;
    ((Control) this.textPayee).BackColor = Color.White;
    ((Control) this.textPayee).Location = new Point(137, 6);
    this.textPayee.MGAStyle = (MGAStyles) 2;
    ((Control) this.textPayee).Name = "textPayee";
    ((EditorButtonControlBase) this.textPayee).ReadOnly = true;
    ((Control) this.textPayee).Size = new Size(251, 20);
    ((Control) this.textPayee).TabIndex = 1;
    ((UltraControlBase) this.textPayee).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPayee).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).Image = (object) Resources.SearchClaimSmall;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearchPayee).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonSearchPayee).Location = new Point(394, 6);
    ((Control) this.buttonSearchPayee).Name = "buttonSearchPayee";
    ((Control) this.buttonSearchPayee).Size = new Size(21, 21);
    ((Control) this.buttonSearchPayee).TabIndex = 2;
    ((UltraControlBase) this.buttonSearchPayee).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSearchPayee).Click += new EventHandler(this.buttonSearchPayee_Click);
    ((AppearanceBase) appearance4).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance4;
    ((Control) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Location = new Point(5, 286);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(99, 15);
    ((Control) this.ultraLabel8).TabIndex = 15;
    ((Control) this.ultraLabel8).Text = "Recovery Check #:";
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textRecoveryCheckNumber).Appearance = (AppearanceBase) appearance5;
    ((Control) this.textRecoveryCheckNumber).BackColor = Color.White;
    ((Control) this.textRecoveryCheckNumber).Enabled = false;
    ((Control) this.textRecoveryCheckNumber).Location = new Point(137, 283);
    this.textRecoveryCheckNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.textRecoveryCheckNumber).Name = "textRecoveryCheckNumber";
    ((Control) this.textRecoveryCheckNumber).Size = new Size(138, 20);
    ((Control) this.textRecoveryCheckNumber).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.textRecoveryCheckNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textRecoveryCheckNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textMultiplePayees).Appearance = (AppearanceBase) appearance6;
    ((Control) this.textMultiplePayees).BackColor = Color.White;
    ((Control) this.textMultiplePayees).Location = new Point(550, 7);
    ((TextEditorControlBase) this.textMultiplePayees).MaxLength = 500;
    this.textMultiplePayees.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.textMultiplePayees).Multiline = true;
    ((Control) this.textMultiplePayees).Name = "textMultiplePayees";
    ((Control) this.textMultiplePayees).Size = new Size(276, 134);
    ((Control) this.textMultiplePayees).TabIndex = 18;
    ((UltraControlBase) this.textMultiplePayees).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textMultiplePayees).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel9).Appearance = (AppearanceBase) appearance7;
    ((Control) this.ultraLabel9).AutoSize = true;
    ((Control) this.ultraLabel9).Location = new Point(427, 7);
    ((Control) this.ultraLabel9).Name = "ultraLabel9";
    ((Control) this.ultraLabel9).Size = new Size(96 /*0x60*/, 15);
    ((Control) this.ultraLabel9).TabIndex = 17;
    ((Control) this.ultraLabel9).Text = "Additional Payees:";
    this.addressResolverOverride.Address1 = "";
    this.addressResolverOverride.Address2 = "";
    ((Control) this.addressResolverOverride).BackColor = Color.Transparent;
    this.addressResolverOverride.City = "";
    this.addressResolverOverride.County = "";
    ((Control) this.addressResolverOverride).Font = new Font("Tahoma", 8f);
    ((Control) this.addressResolverOverride).ForeColor = Color.Black;
    this.addressResolverOverride.ISOCountryCode = "";
    this.addressResolverOverride.ISOCountryCodeMember = "";
    this.addressResolverOverride.ISOCountryList = (object) null;
    this.addressResolverOverride.ISOCountryNameMember = "";
    ((Control) this.addressResolverOverride).Location = new Point(423, 139);
    this.addressResolverOverride.MGAStyle = (MGAStyles) 2;
    ((Control) this.addressResolverOverride).Name = "addressResolverOverride";
    this.addressResolverOverride.Password = (string) null;
    ((Control) this.addressResolverOverride).Size = new Size(303, 152);
    this.addressResolverOverride.State = "";
    ((Control) this.addressResolverOverride).TabIndex = 19;
    this.addressResolverOverride.TextAlign = ContentAlignment.TopLeft;
    this.addressResolverOverride.UserID = (string) null;
    this.addressResolverOverride.WebserviceUrl = (string) null;
    this.addressResolverOverride.ZipCode = "";
    this.addressResolverOverride.ZipCodeExtension = "";
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(190, 210, (int) byte.MaxValue);
    ((AppearanceBase) appearance8).BackColor2 = Color.White;
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance8).BorderColor = Color.SlateGray;
    ((AppearanceBase) appearance8).Image = (object) Resources.attach;
    ((AppearanceBase) appearance8).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonAddDocument).Appearance = (AppearanceBase) appearance8;
    this.buttonAddDocument.ButtonStyle = (UIElementButtonStyle) 21;
    ((Control) this.buttonAddDocument).Location = new Point(137, 309);
    ((Control) this.buttonAddDocument).Name = "buttonAddDocument";
    ((Control) this.buttonAddDocument).Size = new Size(115, 23);
    ((Control) this.buttonAddDocument).TabIndex = 22;
    ((Control) this.buttonAddDocument).Text = "Documents";
    ((UltraControlBase) this.buttonAddDocument).UseAppStyling = false;
    ((UltraControlBase) this.buttonAddDocument).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.buttonAddDocument).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonAddDocument).Click += new EventHandler(this.buttonAddDocument_Click);
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(190, 210, (int) byte.MaxValue);
    ((AppearanceBase) appearance9).BackColor2 = Color.White;
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance9).BorderColor = Color.SlateGray;
    ((AppearanceBase) appearance9).Image = (object) Resources.eye;
    ((AppearanceBase) appearance9).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.mgaViewDocuments).Appearance = (AppearanceBase) appearance9;
    this.mgaViewDocuments.ButtonStyle = (UIElementButtonStyle) 21;
    ((Control) this.mgaViewDocuments).Location = new Point((int) byte.MaxValue, 309);
    ((Control) this.mgaViewDocuments).Name = "mgaViewDocuments";
    ((Control) this.mgaViewDocuments).Size = new Size(20, 23);
    ((Control) this.mgaViewDocuments).TabIndex = 23;
    ((UltraControlBase) this.mgaViewDocuments).UseAppStyling = false;
    ((UltraControlBase) this.mgaViewDocuments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaViewDocuments).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.mgaViewDocuments).Click += new EventHandler(this.mgaViewDocuments_Click);
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(190, 210, (int) byte.MaxValue);
    ((AppearanceBase) appearance10).BackColor2 = Color.White;
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 36;
    ((AppearanceBase) appearance10).BorderColor = Color.SteelBlue;
    this.listBoxDocuments.Appearance = (AppearanceBase) appearance10;
    this.listBoxDocuments.ItemSettings.AllowEdit = (DefaultableBoolean) 2;
    this.listBoxDocuments.ItemSettings.DefaultImage = (Image) Resources.attach;
    ((AppearanceBase) appearance11).BackColor = Color.Orange;
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    this.listBoxDocuments.ItemSettings.SelectedAppearance = (AppearanceBase) appearance11;
    ((Control) this.listBoxDocuments).Location = new Point(282, 113);
    ((Control) this.listBoxDocuments).Name = "listBoxDocuments";
    ((Control) this.listBoxDocuments).Size = new Size(284, 218);
    ((Control) this.listBoxDocuments).TabIndex = 24;
    ((Control) this.listBoxDocuments).Text = "ultraListView1";
    ((UltraControlBase) this.listBoxDocuments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.listBoxDocuments).UseOsThemes = (DefaultableBoolean) 2;
    this.listBoxDocuments.View = (UltraListViewStyle) 2;
    ((UltraListViewListSettingsBase) this.listBoxDocuments.ViewSettingsList).CheckBoxStyle = (CheckBoxStyle) 1;
    this.listBoxDocuments.ViewSettingsList.MultiColumn = false;
    ((Control) this.listBoxDocuments).Visible = false;
    ((Control) this.listBoxDocuments).KeyDown += new KeyEventHandler(this.listBoxDocuments_KeyDown);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(838, 371);
    this.Controls.Add((Control) this.listBoxDocuments);
    this.Controls.Add((Control) this.mgaViewDocuments);
    this.Controls.Add((Control) this.buttonAddDocument);
    this.Controls.Add((Control) this.textMultiplePayees);
    this.Controls.Add((Control) this.addressResolverOverride);
    this.Controls.Add((Control) this.ultraLabel9);
    this.Controls.Add((Control) this.textRecoveryCheckNumber);
    this.Controls.Add((Control) this.ultraLabel8);
    this.Controls.Add((Control) this.buttonSearchPayee);
    this.Controls.Add((Control) this.textPayee);
    this.Controls.Add((Control) this.ultraLabel7);
    this.Name = nameof (FormAddPayment);
    this.Text = "Claims - Add Payment";
    this.Controls.SetChildIndex((Control) this.dateTimeReserveDate, 0);
    this.Controls.SetChildIndex((Control) this.lblDate, 0);
    this.Controls.SetChildIndex((Control) this.comboReserveType, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel1, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel2, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel3, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel4, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel5, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel6, 0);
    this.Controls.SetChildIndex((Control) this.comboReserveSubType, 0);
    this.Controls.SetChildIndex((Control) this.comboCoverageType, 0);
    this.Controls.SetChildIndex((Control) this.comboCoverageSubType, 0);
    this.Controls.SetChildIndex((Control) this.textComments, 0);
    this.Controls.SetChildIndex((Control) this.textAmount, 0);
    this.Controls.SetChildIndex((Control) this.buttonSave, 0);
    this.Controls.SetChildIndex((Control) this.buttonCancel, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel7, 0);
    this.Controls.SetChildIndex((Control) this.textPayee, 0);
    this.Controls.SetChildIndex((Control) this.buttonSearchPayee, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel8, 0);
    this.Controls.SetChildIndex((Control) this.textRecoveryCheckNumber, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel9, 0);
    this.Controls.SetChildIndex((Control) this.addressResolverOverride, 0);
    this.Controls.SetChildIndex((Control) this.textMultiplePayees, 0);
    this.Controls.SetChildIndex((Control) this.buttonAddDocument, 0);
    this.Controls.SetChildIndex((Control) this.mgaViewDocuments, 0);
    this.Controls.SetChildIndex((Control) this.listBoxDocuments, 0);
    ((ISupportInitialize) this.comboCoverageType).EndInit();
    ((ISupportInitialize) this.comboReserveType).EndInit();
    ((ISupportInitialize) this.comboReserveSubType).EndInit();
    ((ISupportInitialize) this.comboCoverageSubType).EndInit();
    ((ISupportInitialize) this.textComments).EndInit();
    ((ISupportInitialize) this.textAmount).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.coverageTypeDescriptionsBindingSource).EndInit();
    ((ISupportInitialize) this.reserveTypesBindingSource).EndInit();
    ((ISupportInitialize) this.dsReservePaymentTypes1BindingSource).EndInit();
    ((ISupportInitialize) this.reserveSubTypesBindingSource).EndInit();
    ((ISupportInitialize) this.coverageTypesBindingSource).EndInit();
    ((ISupportInitialize) this.reserveTypesBindingSource1).EndInit();
    this.dsReservePaymentTypes1.EndInit();
    this.dsCoverageTypes1.EndInit();
    ((ISupportInitialize) this.dateTimeReserveDate).EndInit();
    ((ISupportInitialize) this.textPayee).EndInit();
    ((ISupportInitialize) this.buttonSearchPayee).EndInit();
    ((ISupportInitialize) this.textRecoveryCheckNumber).EndInit();
    ((ISupportInitialize) this.textMultiplePayees).EndInit();
    ((ISupportInitialize) this.buttonAddDocument).EndInit();
    ((ISupportInitialize) this.mgaViewDocuments).EndInit();
    ((ISupportInitialize) this.listBoxDocuments).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public delegate void DocumentDeletedHandler(object sender, DocumentDeleteEventArgs e);
}
