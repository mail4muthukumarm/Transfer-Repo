// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claimant
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ComplyAdvantage;
using MGASystems.Data;
using MGASystems.IMS.BusinessClasses;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class Claimant : INotifyChanges
{
  private Claim _owner;
  private int _claimId;
  private string _userDefinedClaimantId;
  private Guid _claimantGuid;
  private Guid _lineGuid;
  private DateTime? _dateReported;
  private bool _isInsured;
  private ClaimAddress _primaryAddress;
  private ClaimAddress _mailingAddress;
  private EntityInformation _claimantInformation;
  private int? _managedCareId;
  private Guid _outsideAdjusterGuid;
  private int? _settlementId;
  private int? _lossTypeId;
  private int? _accidentTypeId;
  private DateTime? _dateDenied;
  private int _statusId;
  private string _emailAddress;
  private string _outsideInvestigator;
  private DateTime? _outsideInvestigatorHireDate;
  private bool _isSettled;
  private NotificationCollection<PaymentReserve> _paymentsAndReserves;
  private ClaimantLegalInformation _legalInformation;
  private Guid _enteredByUserGuid;
  private string _enteredByUserName;
  private DateTime _enteredOn;
  private Guid _modifiedByUserGuid;
  private string _modifiedByUserName;
  private DateTime _lastModified;
  private Claimant.ClaimantState _editState;
  private string _claimantComments;
  private bool _medicareEligible;
  private MedicareEligibilityData _eligibilityData;
  private bool _hasChanges;

  public Claimant(Claim owner)
  {
    this._owner = owner;
    if (this._owner.ClaimId.HasValue)
      this._claimId = this._owner.ClaimId.Value;
    this._editState = Claimant.ClaimantState.New;
    this._enteredByUserGuid = CurrentUser.Instance.UserGUID;
    this._enteredByUserName = CurrentUser.Instance.DisplayName;
    this._enteredOn = DateTime.Now;
    this._modifiedByUserGuid = CurrentUser.Instance.UserGUID;
    this._modifiedByUserName = CurrentUser.Instance.DisplayName;
    this._lastModified = DateTime.Now;
  }

  public Claimant(
    Claim owner,
    Guid claimantGuid,
    Guid enteredByUserGuid,
    string enteredByUserName,
    DateTime enteredOn,
    Guid modifiedByUserGuid,
    string modifiedByUserName,
    DateTime lastModified)
  {
    this._owner = owner;
    if (this._owner.ClaimId.HasValue)
      this._claimId = this._owner.ClaimId.Value;
    this._editState = Claimant.ClaimantState.None;
    this._claimantGuid = claimantGuid;
    this._enteredByUserGuid = enteredByUserGuid;
    this._enteredByUserName = enteredByUserName;
    this._enteredOn = enteredOn;
    this._modifiedByUserGuid = modifiedByUserGuid;
    this._modifiedByUserName = modifiedByUserName;
    this._lastModified = lastModified;
    this.LoadReservesPayments();
  }

  public Claim Owner => this._owner;

  public int ClaimId
  {
    get => this._claimId;
    set => this._claimId = value;
  }

  public string UserDefinedClaimantId
  {
    get => this._userDefinedClaimantId;
    set => this._userDefinedClaimantId = value;
  }

  public Guid ClaimantGuid => this._claimantGuid;

  public bool MedicareEligible
  {
    get => this._medicareEligible;
    set => this._medicareEligible = value;
  }

  public Guid LineGuid
  {
    get => this._lineGuid;
    set => this._lineGuid = value;
  }

  public DateTime? DateReported
  {
    get => this._dateReported;
    set => this._dateReported = value;
  }

  public bool IsInsured
  {
    get => this._isInsured;
    set => this._isInsured = value;
  }

  public ClaimAddress PrimaryAddress
  {
    get
    {
      if (this._primaryAddress == null)
        this._primaryAddress = new ClaimAddress();
      return this._primaryAddress;
    }
    set => this._primaryAddress = value;
  }

  public ClaimAddress MailingAddress
  {
    get
    {
      if (this._mailingAddress == null)
        this._mailingAddress = new ClaimAddress();
      return this._mailingAddress;
    }
    set => this._mailingAddress = value;
  }

  public EntityInformation ClaimantInformation
  {
    get
    {
      if (this._claimantInformation == null)
        this._claimantInformation = new EntityInformation();
      return this._claimantInformation;
    }
    set => this._claimantInformation = value;
  }

  public NotificationCollection<PaymentReserve> ReservesAndPayments
  {
    get
    {
      if (this._paymentsAndReserves == null)
        this._paymentsAndReserves = new NotificationCollection<PaymentReserve>();
      return this._paymentsAndReserves;
    }
  }

  public int? ManagedCareId
  {
    get => this._managedCareId;
    set => this._managedCareId = value;
  }

  public Guid OutsideAdjusterGuid
  {
    get => this._outsideAdjusterGuid;
    set => this._outsideAdjusterGuid = value;
  }

  public int? AccidentTypeId
  {
    get => this._accidentTypeId;
    set => this._accidentTypeId = value;
  }

  public int? SettlementTypeId
  {
    get => this._settlementId;
    set => this._settlementId = value;
  }

  public int? LossTypeId
  {
    get => this._lossTypeId;
    set => this._lossTypeId = value;
  }

  public string OutsideInvestigator
  {
    get => this._outsideInvestigator;
    set => this._outsideInvestigator = value;
  }

  public DateTime? OutsideInvestigatorHireDate
  {
    get => this._outsideInvestigatorHireDate;
    set => this._outsideInvestigatorHireDate = value;
  }

  public bool IsSettled
  {
    get => this._isSettled;
    set => this._isSettled = value;
  }

  public int StatusId
  {
    get => this._statusId;
    set => this._statusId = value;
  }

  public ClaimantLegalInformation LegalInformation
  {
    get
    {
      if (this._legalInformation == null)
        this._legalInformation = new ClaimantLegalInformation();
      return this._legalInformation;
    }
    set => this._legalInformation = value;
  }

  public DateTime? DateDenied
  {
    get => this._dateDenied;
    set => this._dateDenied = value;
  }

  public string EmailAddress
  {
    get => this._emailAddress;
    set => this._emailAddress = value;
  }

  public Guid EnteredByUserGuid => this._enteredByUserGuid;

  public string EnteredByUserName => this._enteredByUserName;

  public DateTime EnteredOn => this._enteredOn;

  public Guid ModifiedByUserGuid => this._modifiedByUserGuid;

  public string ModifiedByUserName => this._modifiedByUserName;

  public DateTime LastModified => this._lastModified;

  public string DisplayName
  {
    get
    {
      if (!string.IsNullOrEmpty(this.ClaimantInformation.CorporationName))
        return this.ClaimantInformation.CorporationName;
      return this.ClaimantInformation != null && !string.IsNullOrEmpty(this.ClaimantInformation.FirstName) ? this.ClaimantInformation.FirstName.PadRight(this.ClaimantInformation.FirstName.Length + 1, " ".ToCharArray()[0]) + this.ClaimantInformation.LastName : string.Empty;
    }
  }

  public Claimant.ClaimantState EditState
  {
    get => this._editState;
    set => this._editState = value;
  }

  public string ClaimantComments
  {
    get => this._claimantComments;
    set => this._claimantComments = value;
  }

  public bool HasReserves => this._paymentsAndReserves.Count != 0;

  public virtual bool IsOpen => this._statusId == 0;

  public bool HasMailingAddress
  {
    get
    {
      bool flag = this.MailingAddress.NumberManager.Added.Count > 0 || this.MailingAddress.NumberManager.Updated.Count > 0;
      return ((!string.IsNullOrEmpty(this.MailingAddress.Address1) || !string.IsNullOrEmpty(this.MailingAddress.Address2) || !string.IsNullOrEmpty(this.MailingAddress.ZipCode) || !string.IsNullOrEmpty(this.MailingAddress.ZipCodeExtension) || !string.IsNullOrEmpty(this.MailingAddress.City) ? 1 : (this.MailingAddress.State == null ? 0 : (this.MailingAddress.State.Trim().Length > 0 ? 1 : 0))) | (flag ? 1 : 0)) != 0;
    }
  }

  public MedicareEligibilityData EligibilityData
  {
    get
    {
      if (this._eligibilityData == null)
        this._eligibilityData = new MedicareEligibilityData();
      return this._eligibilityData;
    }
    set => this._eligibilityData = value;
  }

  public bool VerifyClaimant()
  {
    return Utility.VerifyAddress((MGASystems.IMS.BusinessClasses.Address) this.PrimaryAddress) && (!this.HasMailingAddress || Utility.VerifyAddress((MGASystems.IMS.BusinessClasses.Address) this.MailingAddress));
  }

  public virtual void LoadReservesPayments()
  {
    this.ReservesAndPayments.Clear();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spClaims_GetClaimantReservesPayments", new object[4]
    {
      (object) "@ClaimId",
      (object) this.Owner.ClaimId,
      (object) "@ClaimantGuid",
      (object) this.ClaimantGuid
    });
    if (dataTable == null || dataTable.Rows.Count == 0)
      return;
    foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
    {
      PaymentReserve paymentReserve = new PaymentReserve((int) row["ResPayId"], (int) row["ClaimId"], this.ClaimantGuid, (DateTime) row["DateCreated"], new Guid(row["CreatedbyGuid"].ToString()), row["CreatedBy"].ToString(), (bool) row["IsPayment"] ? PaymentReserveType.Payment : PaymentReserveType.Reserve, (bool) row["IsRecoveryType"], !row["PaymentReturn"].Equals((object) DBNull.Value) && (bool) row["PaymentReturn"], row["PaymentReturn_ResPayId"].Equals((object) DBNull.Value) ? new int?() : (int?) row["PaymentReturn_ResPayId"]);
      if (row["CoverageTypeId"] != DBNull.Value)
        paymentReserve.CoverageTypeId = (int?) row["CoverageTypeId"];
      paymentReserve.CoverageType = row["CoverageType"] == DBNull.Value ? string.Empty : row["CoverageType"].ToString();
      if (row["CoverageTypeDescriptionId"] != DBNull.Value)
        paymentReserve.CoverageTypeDescriptionId = (int?) row["CoverageTypeDescriptionId"];
      paymentReserve.CoverageTypeDescription = row["CoverageTypeDescription"] == DBNull.Value ? string.Empty : row["CoverageTypeDescription"].ToString();
      paymentReserve.ReservePaymentTypeId = (int) row["ResPayTypeId"];
      paymentReserve.ReservePaymentType = row["ResPayType"].ToString();
      if (row["ResPaySubTypeId"] != DBNull.Value)
        paymentReserve.ReservePaymentSubTypeId = (int?) row["ResPaySubTypeId"];
      paymentReserve.ReservePaymentSubType = row["ResPaySubType"] == DBNull.Value ? string.Empty : row["ResPaySubType"].ToString();
      paymentReserve.ReservePaymentAmount = (Decimal) row["ResPayAmount"];
      paymentReserve.Comments = row["Comments"] == DBNull.Value ? string.Empty : row["Comments"].ToString();
      if (row["PayeeGuid"] != DBNull.Value)
      {
        paymentReserve.PayeeGuid = new Guid(row["PayeeGuid"].ToString());
        paymentReserve.PayeeName = row["PayeeName"].ToString();
      }
      paymentReserve.IsPaymentReduction = (bool) row["IsPaymentReduction"];
      paymentReserve.IsVoid = (bool) row["Void"];
      this.ReservesAndPayments.Add(paymentReserve);
    }
  }

  protected virtual void CloseReserves() => this.CloseReserves(DateTime.Now);

  protected virtual void CloseReserves(DateTime closeDate)
  {
    List<PaymentReserve> paymentReserveList = new List<PaymentReserve>();
    List<int> intList1 = new List<int>();
    foreach (PaymentReserve reservesAndPayment1 in (Collection<PaymentReserve>) this.ReservesAndPayments)
    {
      Decimal paymentAmount = 0M;
      if (reservesAndPayment1.EntryType == PaymentReserveType.Reserve)
      {
        int? reservePaymentId = reservesAndPayment1.ReservePaymentId;
        if (reservePaymentId.HasValue)
        {
          List<int> intList2 = intList1;
          reservePaymentId = reservesAndPayment1.ReservePaymentId;
          int num1 = reservePaymentId.Value;
          if (!intList2.Contains(num1))
          {
            List<int> intList3 = intList1;
            reservePaymentId = reservesAndPayment1.ReservePaymentId;
            int num2 = reservePaymentId.Value;
            intList3.Add(num2);
            foreach (PaymentReserve reservesAndPayment2 in (Collection<PaymentReserve>) this.ReservesAndPayments)
            {
              if (reservesAndPayment2.EntryType == PaymentReserveType.Reserve && reservesAndPayment1.IsMatchingPayment(reservesAndPayment2))
              {
                List<int> intList4 = intList1;
                reservePaymentId = reservesAndPayment2.ReservePaymentId;
                int num3 = reservePaymentId.Value;
                intList4.Add(num3);
                paymentAmount += reservesAndPayment2.ReservePaymentAmount;
              }
            }
            paymentReserveList.Add(reservesAndPayment1.BringDownReserve(paymentAmount, closeDate));
          }
        }
      }
    }
    foreach (PaymentReserve paymentReserve in paymentReserveList)
    {
      if (paymentReserve.ReservePaymentAmount != 0M)
        this.ReservesAndPayments.Add(paymentReserve);
    }
  }

  internal Decimal GetReserveTotal(PaymentReserve pr, bool paymentTotal)
  {
    Decimal reserveTotal = 0M;
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.ReservesAndPayments)
    {
      if (paymentTotal)
      {
        if (reservesAndPayment.EntryType == PaymentReserveType.Payment && pr.IsMatchingPayment(reservesAndPayment))
          reserveTotal += reservesAndPayment.ReservePaymentAmount;
      }
      else if (reservesAndPayment.EntryType == PaymentReserveType.Reserve && pr.IsMatchingPayment(reservesAndPayment))
        reserveTotal += reservesAndPayment.ReservePaymentAmount;
    }
    return reserveTotal;
  }

  protected virtual void AfterSaveClaimantComplete()
  {
  }

  public void Save(int claimId)
  {
    try
    {
      if (!this.VerifyClaimant())
        return;
      this.ClaimId = claimId;
      int primaryAddressId = this.SavePrimaryAddress();
      int? mailingAddressId = new int?();
      if (this.HasMailingAddress)
        mailingAddressId = new int?(this.SaveMailingAddress());
      this._claimantGuid = this.SaveClaimant(primaryAddressId, mailingAddressId);
      this.DoOFACCheck();
      this.SaveClaimantLegal();
      this.SaveEligibilityData();
      this.SaveReservesPayments();
      if (!this.OnBeforeSaveClaimantCommitted())
        throw new ClaimantSaveCustomDataFailedException("The system is unable to save the custom data.");
      this.OnBeforeClaimantSaved();
      Messaging.SendBroadcastMessage(new Guid("{C9573B52-04AF-47e7-AAED-62586FCB3576}"), (object) Utility.GetClaimGuid(claimId));
      this._editState = Claimant.ClaimantState.None;
      SanctionsChecker.Default?.CheckCompliance(this.DisplayName, this._claimantGuid);
    }
    catch (Exception ex)
    {
      throw;
    }
  }

  private Guid SaveClaimant(int primaryAddressId, int? mailingAddressId)
  {
    object[] objArray = new object[60];
    objArray[0] = (object) "@ClaimId";
    objArray[1] = (object) this.ClaimId;
    objArray[2] = (object) "@UserDef_ClaimantId";
    objArray[3] = (object) this.UserDefinedClaimantId;
    objArray[4] = (object) "@DateReported";
    objArray[5] = (object) this.DateReported;
    objArray[6] = (object) "@DateDenied";
    DateTime? nullable1 = this.DateDenied;
    objArray[7] = (object) (nullable1.HasValue ? (SqlDateTime) nullable1.GetValueOrDefault() : SqlDateTime.Null);
    objArray[8] = (object) "@IsInsured";
    objArray[9] = (object) this.IsInsured;
    objArray[10] = (object) "@CorporationName";
    objArray[11] = (object) (string.IsNullOrEmpty(this.ClaimantInformation.CorporationName) ? SqlString.Null : (SqlString) this.ClaimantInformation.CorporationName);
    objArray[12] = (object) "@FirstName";
    objArray[13] = (object) (string.IsNullOrEmpty(this.ClaimantInformation.FirstName) ? SqlString.Null : (SqlString) this.ClaimantInformation.FirstName);
    objArray[14] = (object) "@MiddleName";
    objArray[15] = (object) (string.IsNullOrEmpty(this.ClaimantInformation.MiddleName) ? SqlString.Null : (SqlString) this.ClaimantInformation.MiddleName);
    objArray[16 /*0x10*/] = (object) "@LastName";
    objArray[17] = (object) (string.IsNullOrEmpty(this.ClaimantInformation.LastName) ? SqlString.Null : (SqlString) this.ClaimantInformation.LastName);
    objArray[18] = (object) "@AddressId";
    objArray[19] = (object) primaryAddressId;
    objArray[20] = (object) "@MailingAddressId";
    int? nullable2 = mailingAddressId;
    objArray[21] = (object) (nullable2.HasValue ? (SqlInt32) nullable2.GetValueOrDefault() : SqlInt32.Null);
    objArray[22] = (object) "@Gender";
    objArray[23] = (object) this.ClaimantInformation.Gender;
    objArray[24] = (object) "@SSN";
    objArray[25] = (object) (string.IsNullOrEmpty(this.ClaimantInformation.SocialSecurityNumber) ? SqlString.Null : (SqlString) this.ClaimantInformation.SocialSecurityNumber);
    objArray[26] = (object) "@DOB";
    nullable1 = this.ClaimantInformation.DateOfBirth;
    objArray[27] = (object) (nullable1.HasValue ? (SqlDateTime) nullable1.GetValueOrDefault() : SqlDateTime.Null);
    objArray[28] = (object) "@FEIN";
    objArray[29] = (object) (string.IsNullOrEmpty(this.ClaimantInformation.Fein) ? SqlString.Null : (SqlString) this.ClaimantInformation.Fein);
    objArray[30] = (object) "@EmailAddress";
    objArray[31 /*0x1F*/] = (object) (string.IsNullOrEmpty(this.EmailAddress) ? SqlString.Null : (SqlString) this.EmailAddress);
    objArray[32 /*0x20*/] = (object) "@EnteredBy";
    objArray[33] = (object) CurrentUser.Instance.UserGUID;
    objArray[34] = (object) "@ModifiedBy";
    objArray[35] = (object) CurrentUser.Instance.UserGUID;
    objArray[36] = (object) "@ManagedCareId";
    nullable2 = this.ManagedCareId;
    objArray[37] = (object) (nullable2.HasValue ? (SqlInt32) nullable2.GetValueOrDefault() : SqlInt32.Null);
    objArray[38] = (object) "@LossTypeId";
    nullable2 = this.LossTypeId;
    objArray[39] = (object) (nullable2.HasValue ? (SqlInt32) nullable2.GetValueOrDefault() : SqlInt32.Null);
    objArray[40] = (object) "@AccidentTypeId";
    nullable2 = this.AccidentTypeId;
    objArray[41] = (object) (nullable2.HasValue ? (SqlInt32) nullable2.GetValueOrDefault() : SqlInt32.Null);
    objArray[42] = (object) "@StatusId";
    objArray[43] = (object) this.StatusId;
    objArray[44] = (object) "@OutsideInvestigator";
    objArray[45] = (object) (string.IsNullOrEmpty(this.OutsideInvestigator) ? SqlString.Null : (SqlString) this.OutsideInvestigator);
    objArray[46] = (object) "@OutsideInvestigatorHireDate";
    nullable1 = this.OutsideInvestigatorHireDate;
    objArray[47] = (object) (nullable1.HasValue ? (SqlDateTime) nullable1.GetValueOrDefault() : SqlDateTime.Null);
    objArray[48 /*0x30*/] = (object) "@IsSettled";
    objArray[49] = (object) this.IsSettled;
    objArray[50] = (object) "@SettlementTypeId";
    objArray[51] = (object) this.SettlementTypeId;
    objArray[52] = (object) "@ClaimantComments";
    objArray[53] = (object) this.ClaimantComments;
    objArray[54] = (object) "@OutsideAdjusterGuid";
    Guid outsideAdjusterGuid = this.OutsideAdjusterGuid;
    objArray[55] = (object) (this.OutsideAdjusterGuid.Equals(Guid.Empty) ? SqlGuid.Null : (SqlGuid) this.OutsideAdjusterGuid);
    objArray[56] = (object) "@OFACValidated";
    objArray[57] = (object) SqlDateTime.Null;
    objArray[58] = (object) "@OFACResponse";
    objArray[59] = (object) SqlString.Null;
    return new Guid(DefaultDatabase.ExecuteScalar("spClaims_InsertClaimant", objArray).ToString());
  }

  protected virtual void DoOFACCheck()
  {
    if (!Utility.PerformOFACCheck(new ClaimOFACEntity(this.ClaimantGuid, "MGASystems.IMS.Claims.FormClaims")
    {
      CorporationName = this.ClaimantInformation.CorporationName,
      DBAName = string.Empty,
      FirstName = this.ClaimantInformation.FirstName,
      MiddleName = this.ClaimantInformation.MiddleName,
      LastName = this.ClaimantInformation.LastName,
      FEINSSN = string.IsNullOrEmpty(this.ClaimantInformation.Fein) ? this.ClaimantInformation.SocialSecurityNumber : this.ClaimantInformation.Fein,
      ISOCountryCode = this.PrimaryAddress.IsoCountryCode,
      Address1 = this.PrimaryAddress.Address1,
      Address2 = this.PrimaryAddress.Address2,
      City = this.PrimaryAddress.City,
      State = this.PrimaryAddress.State,
      ZipCode = this.PrimaryAddress.ZipCode,
      ParentEntityGuid = new Guid?()
    }))
      return;
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append("The system has found an OFAC hit on the entity specified.");
    stringBuilder.Append(" The claimant will be saved, however you will not be able to post any payments or reserves against this claimant until they have cleared compliance.");
    stringBuilder.AppendLine("Please contact your system administrator with any questions.");
    int num = (int) MessageBox.Show(stringBuilder.ToString(), "OFAC Hit Detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    this.OnClaimantOFACHitDetected();
  }

  public event EventHandler<EventArgs> ClaimantOFACHitDetected;

  protected void OnClaimantOFACHitDetected()
  {
    EventHandler<EventArgs> claimantOfacHitDetected = this.ClaimantOFACHitDetected;
    if (claimantOfacHitDetected == null)
      return;
    claimantOfacHitDetected((object) this, new EventArgs());
  }

  private int SavePrimaryAddress() => Utility.SaveAddress(this.PrimaryAddress);

  private int SaveMailingAddress() => Utility.SaveAddress(this.MailingAddress);

  private void SaveClaimantLegal()
  {
    if (this.LegalInformation == null)
      return;
    ClaimantLegalInformation legalInformation = this.LegalInformation;
    DataTable dataTable1 = new DataTable();
    object[] objArray = new object[70];
    objArray[0] = (object) "@ClaimantGuid";
    objArray[1] = (object) this.ClaimantGuid;
    objArray[2] = (object) "@UserGuid";
    objArray[3] = (object) CurrentUser.Instance.UserGUID;
    objArray[4] = (object) "@DefenseFirm";
    objArray[5] = (object) (string.IsNullOrEmpty(legalInformation.DefenseFirm) ? SqlString.Null : (SqlString) legalInformation.DefenseFirm);
    objArray[6] = (object) "@DefenseAttorney";
    objArray[7] = (object) (string.IsNullOrEmpty(legalInformation.DefenseAttorney) ? SqlString.Null : (SqlString) legalInformation.DefenseAttorney);
    objArray[8] = (object) "@DefenseAttorneyFEINSSN";
    objArray[9] = (object) (string.IsNullOrEmpty(legalInformation.DefenseAttorneyFeinSsn) ? SqlString.Null : (SqlString) legalInformation.DefenseAttorneyFeinSsn);
    objArray[10] = (object) "@ClaimantAttorneyFirm";
    objArray[11] = (object) (string.IsNullOrEmpty(legalInformation.ClaimantLawFirm) ? SqlString.Null : (SqlString) legalInformation.ClaimantLawFirm);
    objArray[12] = (object) "@ClaimantAttorney";
    objArray[13] = (object) (string.IsNullOrEmpty(legalInformation.ClaimantAttorney) ? SqlString.Null : (SqlString) legalInformation.ClaimantAttorney);
    objArray[14] = (object) "@ClaimantAttorneyFEINSSN";
    objArray[15] = (object) (string.IsNullOrEmpty(legalInformation.ClaimantAttorneyFeinSsn) ? SqlString.Null : (SqlString) legalInformation.ClaimantAttorneyFeinSsn);
    objArray[16 /*0x10*/] = (object) "@Judge";
    objArray[17] = (object) (string.IsNullOrEmpty(legalInformation.Judge) ? SqlString.Null : (SqlString) legalInformation.Judge);
    objArray[18] = (object) "@PublishedDecision";
    objArray[19] = (object) legalInformation.PublishedDecision;
    objArray[20] = (object) "@SuitServed";
    objArray[21] = (object) legalInformation.SuitServed;
    objArray[22] = (object) "@DateSuitServed";
    DateTime? nullable = legalInformation.DateServed;
    objArray[23] = (object) (nullable.HasValue ? (SqlDateTime) nullable.GetValueOrDefault() : SqlDateTime.Null);
    objArray[24] = (object) "@DateSuitAnswered";
    nullable = legalInformation.DateAnswered;
    objArray[25] = (object) (nullable.HasValue ? (SqlDateTime) nullable.GetValueOrDefault() : SqlDateTime.Null);
    objArray[26] = (object) "@Defense_ISOCountryCode";
    objArray[27] = (object) (legalInformation.DefenseAttorneyAddress != null ? (SqlString) legalInformation.DefenseAttorneyAddress.IsoCountryCode : SqlString.Null);
    objArray[28] = (object) "@Defense_Address1";
    objArray[29] = (object) (legalInformation.DefenseAttorneyAddress != null ? (SqlString) legalInformation.DefenseAttorneyAddress.Address1 : SqlString.Null);
    objArray[30] = (object) "@Defense_Address2";
    objArray[31 /*0x1F*/] = (object) (legalInformation.DefenseAttorneyAddress != null ? (string.IsNullOrEmpty(legalInformation.DefenseAttorneyAddress.Address2) ? SqlString.Null : (SqlString) legalInformation.DefenseAttorneyAddress.Address2) : SqlString.Null);
    objArray[32 /*0x20*/] = (object) "@Defense_City";
    objArray[33] = (object) (legalInformation.DefenseAttorneyAddress != null ? (string.IsNullOrEmpty(legalInformation.DefenseAttorneyAddress.City) ? SqlString.Null : (SqlString) legalInformation.DefenseAttorneyAddress.City) : SqlString.Null);
    objArray[34] = (object) "@Defense_State";
    objArray[35] = (object) (legalInformation.DefenseAttorneyAddress != null ? (string.IsNullOrEmpty(legalInformation.DefenseAttorneyAddress.State) ? SqlString.Null : (SqlString) legalInformation.DefenseAttorneyAddress.State) : SqlString.Null);
    objArray[36] = (object) "@Defense_ZipCode";
    objArray[37] = (object) (legalInformation.DefenseAttorneyAddress == null || legalInformation.DefenseAttorneyAddress.IsInternational ? SqlString.Null : (string.IsNullOrEmpty(legalInformation.DefenseAttorneyAddress.ZipCode) ? SqlString.Null : (SqlString) legalInformation.DefenseAttorneyAddress.ZipCode));
    objArray[38] = (object) "@Defense_ZipCodeExtension";
    objArray[39] = (object) (legalInformation.DefenseAttorneyAddress != null ? (string.IsNullOrEmpty(legalInformation.DefenseAttorneyAddress.ZipCodeExtension) ? SqlString.Null : (SqlString) legalInformation.DefenseAttorneyAddress.ZipCodeExtension) : SqlString.Null);
    objArray[40] = (object) "@Defense_IsInternational";
    objArray[41] = (object) (bool) (legalInformation.DefenseAttorneyAddress != null ? (legalInformation.DefenseAttorneyAddress.IsInternational ? 1 : 0) : 0);
    objArray[42] = (object) "@Defense_InternationalZipCode";
    objArray[43] = (object) (legalInformation.DefenseAttorneyAddress == null || !legalInformation.DefenseAttorneyAddress.IsInternational ? SqlString.Null : (string.IsNullOrEmpty(legalInformation.DefenseAttorneyAddress.ZipCode) ? SqlString.Null : (SqlString) legalInformation.DefenseAttorneyAddress.ZipCode));
    objArray[44] = (object) "@ClaimantAttorney_ISOCountryCode";
    objArray[45] = (object) (legalInformation.ClaimantAttorneyAddress != null ? (SqlString) legalInformation.ClaimantAttorneyAddress.IsoCountryCode : SqlString.Null);
    objArray[46] = (object) "@ClaimantAttorney_Address1";
    objArray[47] = (object) (legalInformation.ClaimantAttorneyAddress != null ? (SqlString) legalInformation.ClaimantAttorneyAddress.Address1 : SqlString.Null);
    objArray[48 /*0x30*/] = (object) "@ClaimantAttorney_Address2";
    objArray[49] = (object) (legalInformation.ClaimantAttorneyAddress != null ? (string.IsNullOrEmpty(legalInformation.ClaimantAttorneyAddress.Address2) ? SqlString.Null : (SqlString) legalInformation.ClaimantAttorneyAddress.Address2) : SqlString.Null);
    objArray[50] = (object) "@ClaimantAttorney_City";
    objArray[51] = (object) (legalInformation.ClaimantAttorneyAddress != null ? (string.IsNullOrEmpty(legalInformation.ClaimantAttorneyAddress.City) ? SqlString.Null : (SqlString) legalInformation.ClaimantAttorneyAddress.City) : SqlString.Null);
    objArray[52] = (object) "@ClaimantAttorney_State";
    objArray[53] = (object) (legalInformation.ClaimantAttorneyAddress != null ? (string.IsNullOrEmpty(legalInformation.ClaimantAttorneyAddress.State) ? SqlString.Null : (SqlString) legalInformation.ClaimantAttorneyAddress.State) : SqlString.Null);
    objArray[54] = (object) "@ClaimantAttorney_ZipCode";
    objArray[55] = (object) (legalInformation.ClaimantAttorneyAddress == null || legalInformation.ClaimantAttorneyAddress.IsInternational ? SqlString.Null : (string.IsNullOrEmpty(legalInformation.ClaimantAttorneyAddress.ZipCode) ? SqlString.Null : (SqlString) legalInformation.ClaimantAttorneyAddress.ZipCode));
    objArray[56] = (object) "@ClaimantAttorney_ZipCodeExtension";
    objArray[57] = (object) (legalInformation.ClaimantAttorneyAddress != null ? (string.IsNullOrEmpty(legalInformation.ClaimantAttorneyAddress.ZipCodeExtension) ? SqlString.Null : (SqlString) legalInformation.ClaimantAttorneyAddress.ZipCodeExtension) : SqlString.Null);
    objArray[58] = (object) "@ClaimantAttorney_IsInternational";
    objArray[59] = (object) (bool) (legalInformation.ClaimantAttorneyAddress != null ? (legalInformation.ClaimantAttorneyAddress.IsInternational ? 1 : 0) : 0);
    objArray[60] = (object) "@ClaimantAttorney_InternationalZipCode";
    objArray[61] = (object) (legalInformation.ClaimantAttorneyAddress == null || !legalInformation.ClaimantAttorneyAddress.IsInternational ? SqlString.Null : (string.IsNullOrEmpty(legalInformation.ClaimantAttorneyAddress.ZipCode) ? SqlString.Null : (SqlString) legalInformation.ClaimantAttorneyAddress.ZipCode));
    objArray[62] = (object) "@DefenseAttorneyGuid";
    objArray[63 /*0x3F*/] = (object) (legalInformation.DefenseAttorney.Length <= 0 && legalInformation.DefenseFirm.Length <= 0 || !(legalInformation.DefenseAttorneyGuid == Guid.Empty) ? this.LegalInformation.DefenseAttorneyGuid : Guid.NewGuid());
    objArray[64 /*0x40*/] = (object) "@ClaimantAttorneyGuid";
    objArray[65] = (object) (legalInformation.ClaimantAttorney.Length <= 0 && legalInformation.ClaimantLawFirm.Length <= 0 || !(legalInformation.ClaimantAttorneyGuid == Guid.Empty) ? this.LegalInformation.ClaimantAttorneyGuid : Guid.NewGuid());
    objArray[66] = (object) "@DefenseFirmEntityType";
    objArray[67] = legalInformation.DefenseFirmEntityType == ClaimantLegalInformation.EntityType.Individual ? (object) "I" : (object) "C";
    objArray[68] = (object) "@ClaimantAttorneyEntityType";
    objArray[69] = legalInformation.ClaimantAttorneyEntityType == ClaimantLegalInformation.EntityType.Individual ? (object) "I" : (object) "C";
    DataTable dataTable2 = DefaultDatabase.ExecuteDataTable("spClaims_SaveClaimantLegal", objArray);
    if (Utility.IsNull<int>(dataTable2.Rows[0]["ClaimantAttorneyAddressId"], -1) != -1 && legalInformation.ClaimantAttorneyAddress != null)
      legalInformation.ClaimantAttorneyAddress.NumberManager.SaveChanges((int) dataTable2.Rows[0]["ClaimantAttorneyAddressId"]);
    if (Utility.IsNull<int>(dataTable2.Rows[0]["DefenseAttorneyAddressId"], -1) == -1 || legalInformation.DefenseAttorneyAddress == null)
      return;
    legalInformation.DefenseAttorneyAddress.NumberManager.SaveChanges((int) dataTable2.Rows[0]["DefenseAttorneyAddressId"]);
  }

  private void SaveEligibilityData()
  {
    if (this.EligibilityData == null || !SystemSettings.KeyExists("Claims.ShowVeriskTab") || !SystemSettings.GetBoolSetting("Claims.ShowVeriskTab"))
      return;
    object[] objArray = new object[26];
    objArray[0] = (object) "@ClaimantGuid";
    objArray[1] = (object) this.ClaimantGuid;
    objArray[2] = (object) "@ExhaustDate";
    DateTime? nullable1 = this.EligibilityData.ExhaustDate;
    objArray[3] = (object) (nullable1.HasValue ? (SqlDateTime) nullable1.GetValueOrDefault() : SqlDateTime.Null);
    objArray[4] = (object) "@FundingDelayedDate";
    nullable1 = this.EligibilityData.FundingDelayedDate;
    objArray[5] = (object) (nullable1.HasValue ? (SqlDateTime) nullable1.GetValueOrDefault() : SqlDateTime.Null);
    objArray[6] = (object) "@ICDCode";
    objArray[7] = (object) (string.IsNullOrEmpty(this.EligibilityData.ICDCode) ? SqlString.Null : (SqlString) this.EligibilityData.ICDCode);
    objArray[8] = (object) "@InjuredPartyDeathDate";
    nullable1 = this.EligibilityData.InjuredPartyDeathDate;
    objArray[9] = (object) (nullable1.HasValue ? (SqlDateTime) nullable1.GetValueOrDefault() : SqlDateTime.Null);
    objArray[10] = (object) "@InjuredPartyHICNMBI";
    objArray[11] = (object) (string.IsNullOrEmpty(this.EligibilityData.InjuredPartyHICNMBI) ? SqlString.Null : (SqlString) this.EligibilityData.InjuredPartyHICNMBI);
    objArray[12] = (object) "@InsuranceTypeId";
    int? nullable2 = this.EligibilityData.InsuranceTypeId;
    objArray[13] = (object) (nullable2.HasValue ? (SqlInt32) nullable2.GetValueOrDefault() : SqlInt32.Null);
    objArray[14] = (object) "@MedicareApprovalId";
    nullable2 = this.EligibilityData.MedicareApprovalId;
    objArray[15] = (object) (nullable2.HasValue ? (SqlInt32) nullable2.GetValueOrDefault() : SqlInt32.Null);
    objArray[16 /*0x10*/] = (object) "@MedicareApprovalComments";
    objArray[17] = (object) (string.IsNullOrEmpty(this.EligibilityData.MedicareApprovalComments) ? SqlString.Null : (SqlString) this.EligibilityData.MedicareApprovalComments);
    objArray[18] = (object) "@NoFaultPolicyLimit";
    objArray[19] = (object) this.EligibilityData.NoFaultPolicyLimit;
    objArray[20] = (object) "@ORMIndicatorId";
    nullable2 = this.EligibilityData.ORMIndicatorId;
    objArray[21] = (object) (nullable2.HasValue ? (SqlInt32) nullable2.GetValueOrDefault() : SqlInt32.Null);
    objArray[22] = (object) "@ORMTerminationDate";
    nullable1 = this.EligibilityData.ORMTerminationDate;
    objArray[23] = (object) (nullable1.HasValue ? (SqlDateTime) nullable1.GetValueOrDefault() : SqlDateTime.Null);
    objArray[24] = (object) "@RepresentativeTypeId";
    nullable2 = this.EligibilityData.RepresentativeTypeId;
    objArray[25] = (object) (nullable2.HasValue ? (SqlInt32) nullable2.GetValueOrDefault() : SqlInt32.Null);
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "Verisk_SaveMedicareEligibilityData", objArray);
  }

  private void SaveReservesPayments()
  {
    int num = -1;
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.ReservesAndPayments)
    {
      if (reservesAndPayment.IsPaymentReduction)
        reservesAndPayment.PaymentResPayId = new int?(num);
      PaymentReserve paymentReserve = reservesAndPayment;
      int? nullable = this.Owner.ClaimId;
      int claimId = nullable.Value;
      Guid claimantGuid = this.ClaimantGuid;
      paymentReserve.Save(claimId, claimantGuid);
      if (reservesAndPayment.EntryType == PaymentReserveType.Payment)
      {
        nullable = reservesAndPayment.ReservePaymentId;
        num = nullable.Value;
      }
      if (reservesAndPayment.AssociatedDocuments.Count != 0)
      {
        object obj = (object) null;
        Guid empty = Guid.Empty;
        DocSupportCache docSupportCache = new DocSupportCache(true, false, this.ClaimantGuid, this.DisplayName, this.DisplayName, typeof (FormClaims).ToString(), true, Quote.FromControlNo(this.Owner.ControlNumber).ControlGuid);
        for (int index = 0; index < reservesAndPayment.AssociatedDocuments.Count; ++index)
        {
          Guid guid;
          if (index == 0)
          {
            guid = DocumentManager.FileAddWithBind(reservesAndPayment.AssociatedDocuments[index], -1, string.Empty, (ISupportDocumentSystem) docSupportCache, false);
            obj = DefaultDatabase.ExecuteScalar(CommandType.Text, "select folderid from tblDocumentStore where DocumentStoreGuid = @docGuid", new object[2]
            {
              (object) "@docGuid",
              (object) guid
            });
          }
          else
            guid = obj == null || obj == DBNull.Value ? DocumentManager.FileAddWithBind(reservesAndPayment.AssociatedDocuments[index], -1, reservesAndPayment.AssociatedDocuments[index], (ISupportDocumentSystem) docSupportCache, false) : DocumentManager.FileAddWithBind(reservesAndPayment.AssociatedDocuments[index], (int) obj, reservesAndPayment.AssociatedDocuments[index], (ISupportDocumentSystem) docSupportCache, false);
          DefaultDatabase.ExecuteNonQuery("spClaims_InsertReservePaymentDocumentAssociation", new object[6]
          {
            (object) "@documentGuid",
            (object) guid,
            (object) "@claimantGuid",
            (object) this.ClaimantGuid,
            (object) "@resPayId",
            (object) reservesAndPayment.ReservePaymentId
          });
        }
      }
    }
  }

  internal void Update()
  {
    int? mailingAddressId = new int?();
    if (!this.VerifyClaimant())
      return;
    this.UpdatePrimaryAddress();
    int? addressId = this.MailingAddress.AddressId;
    int num = 0;
    if (addressId.GetValueOrDefault() > num & addressId.HasValue)
    {
      mailingAddressId = this.MailingAddress.AddressId;
      this.UpdateMailingAddress();
    }
    else
      mailingAddressId = new int?(this.SaveMailingAddress());
    this.UpdateHeader(mailingAddressId);
    this.SaveClaimantLegal();
    this.SaveEligibilityData();
    this.SaveReservesPayments();
    if (!this.OnBeforeSaveClaimantCommitted())
      throw new ClaimantSaveCustomDataFailedException("The system is unable to save the custom data.");
    this._editState = Claimant.ClaimantState.None;
    this.OnBeforeClaimantSaved();
  }

  private void UpdateHeader(int? mailingAddressId)
  {
    object[] objArray = new object[54];
    objArray[0] = (object) "@ClaimantGuid";
    objArray[1] = (object) this.ClaimantGuid;
    objArray[2] = (object) "@UserGuid";
    objArray[3] = (object) CurrentUser.Instance.UserGUID;
    objArray[4] = (object) "@UserDef_ClaimantId";
    objArray[5] = (object) this.UserDefinedClaimantId;
    objArray[6] = (object) "@DateReported";
    objArray[7] = (object) this.DateReported;
    objArray[8] = (object) "@DateDenied";
    DateTime? nullable1 = this.DateDenied;
    objArray[9] = (object) (nullable1.HasValue ? (SqlDateTime) nullable1.GetValueOrDefault() : SqlDateTime.Null);
    objArray[10] = (object) "@IsInsured";
    objArray[11] = (object) this.IsInsured;
    objArray[12] = (object) "@CorporationName";
    objArray[13] = (object) (string.IsNullOrEmpty(this.ClaimantInformation.CorporationName) ? SqlString.Null : (SqlString) this.ClaimantInformation.CorporationName);
    objArray[14] = (object) "@FirstName";
    objArray[15] = (object) (string.IsNullOrEmpty(this.ClaimantInformation.FirstName) ? SqlString.Null : (SqlString) this.ClaimantInformation.FirstName);
    objArray[16 /*0x10*/] = (object) "@MiddleName";
    objArray[17] = (object) (string.IsNullOrEmpty(this.ClaimantInformation.MiddleName) ? SqlString.Null : (SqlString) this.ClaimantInformation.MiddleName);
    objArray[18] = (object) "@LastName";
    objArray[19] = (object) (string.IsNullOrEmpty(this.ClaimantInformation.LastName) ? SqlString.Null : (SqlString) this.ClaimantInformation.LastName);
    objArray[20] = (object) "@Gender";
    objArray[21] = (object) this.ClaimantInformation.Gender;
    objArray[22] = (object) "@SSN";
    objArray[23] = (object) (string.IsNullOrEmpty(this.ClaimantInformation.SocialSecurityNumber) ? SqlString.Null : (SqlString) this.ClaimantInformation.SocialSecurityNumber);
    objArray[24] = (object) "@DOB";
    nullable1 = this.ClaimantInformation.DateOfBirth;
    objArray[25] = (object) (nullable1.HasValue ? (SqlDateTime) nullable1.GetValueOrDefault() : SqlDateTime.Null);
    objArray[26] = (object) "@FEIN";
    objArray[27] = (object) (string.IsNullOrEmpty(this.ClaimantInformation.Fein) ? SqlString.Null : (SqlString) this.ClaimantInformation.Fein);
    objArray[28] = (object) "@EmailAddress";
    objArray[29] = (object) (string.IsNullOrEmpty(this.EmailAddress) ? SqlString.Null : (SqlString) this.EmailAddress);
    objArray[30] = (object) "@ManagedCareId";
    int? nullable2 = this.ManagedCareId;
    objArray[31 /*0x1F*/] = (object) (nullable2.HasValue ? (SqlInt32) nullable2.GetValueOrDefault() : SqlInt32.Null);
    objArray[32 /*0x20*/] = (object) "@LossTypeId";
    nullable2 = this.LossTypeId;
    objArray[33] = (object) (nullable2.HasValue ? (SqlInt32) nullable2.GetValueOrDefault() : SqlInt32.Null);
    objArray[34] = (object) "@AccidentTypeId";
    nullable2 = this.AccidentTypeId;
    objArray[35] = (object) (nullable2.HasValue ? (SqlInt32) nullable2.GetValueOrDefault() : SqlInt32.Null);
    objArray[36] = (object) "@StatusId";
    objArray[37] = (object) this.StatusId;
    objArray[38] = (object) "@OutsideInvestigator";
    objArray[39] = (object) (string.IsNullOrEmpty(this.OutsideInvestigator) ? SqlString.Null : (SqlString) this.OutsideInvestigator);
    objArray[40] = (object) "@OutsideInvestigatorHireDate";
    nullable1 = this.OutsideInvestigatorHireDate;
    objArray[41] = (object) (nullable1.HasValue ? (SqlDateTime) nullable1.GetValueOrDefault() : SqlDateTime.Null);
    objArray[42] = (object) "@IsSettled";
    objArray[43] = (object) this.IsSettled;
    objArray[44] = (object) "@SettlementTypeId";
    objArray[45] = (object) this.SettlementTypeId;
    objArray[46] = (object) "@ClaimantComments";
    objArray[47] = (object) this.ClaimantComments;
    objArray[48 /*0x30*/] = (object) "@OutsideAdjusterGuid";
    Guid outsideAdjusterGuid = this.OutsideAdjusterGuid;
    objArray[49] = (object) (this.OutsideAdjusterGuid.Equals(Guid.Empty) ? SqlGuid.Null : (SqlGuid) this.OutsideAdjusterGuid);
    objArray[50] = (object) "@MedicareEligible";
    objArray[51] = (object) this.MedicareEligible;
    objArray[52] = (object) "@MailingAddressId";
    objArray[53] = (object) mailingAddressId;
    DefaultDatabase.ExecuteNonQuery("spClaims_UpdateClaimant", objArray);
  }

  private void UpdatePrimaryAddress()
  {
    Utility.UpdateClaimantAddress(this.PrimaryAddress, "spClaims_UpdateClaimantPrimaryAddress", this.ClaimantGuid);
  }

  private void UpdateMailingAddress()
  {
    Utility.UpdateClaimantAddress(this.MailingAddress, "spClaims_UpdateClaimantMailingAddress", this.ClaimantGuid);
  }

  public int CountReserves()
  {
    int num = 0;
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.ReservesAndPayments)
    {
      if (reservesAndPayment.EntryType == PaymentReserveType.Reserve)
        ++num;
    }
    return num;
  }

  public int CountPayments()
  {
    int num = 0;
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.ReservesAndPayments)
    {
      if (reservesAndPayment.EntryType == PaymentReserveType.Payment)
        ++num;
    }
    return num;
  }

  public virtual void CloseClaim(bool takeDownReserves)
  {
    this._statusId = 1;
    if (takeDownReserves)
      this.CloseReserves();
    this.Owner.AddActivity(new ClaimActivity(Utility.ClaimActivityType.ClaimClosed, DateTime.Now, CurrentUser.Instance.UserGUID, CurrentUser.Instance.DisplayName, this.ClaimantGuid, this.DisplayName, Utility.ClaimStatus.Closed));
    Messaging.SendBroadcastMessage(new Guid("{258FBE46-67CB-4059-8D07-E3E014CA210E}"), (object) Utility.GetClaimGuid(this.ClaimId));
    this.EditState = Claimant.ClaimantState.Updated;
    this.OnClaimStatusChanged();
  }

  public virtual void CloseClaim(bool takeDownReserves, DateTime closeDate)
  {
    this._statusId = 1;
    if (takeDownReserves)
      this.CloseReserves(closeDate);
    this.Owner.AddActivity(new ClaimActivity(Utility.ClaimActivityType.ClaimClosed, DateTime.Now, CurrentUser.Instance.UserGUID, CurrentUser.Instance.DisplayName, this.ClaimantGuid, this.DisplayName, Utility.ClaimStatus.Closed));
    Messaging.SendBroadcastMessage(new Guid("{258FBE46-67CB-4059-8D07-E3E014CA210E}"), (object) Utility.GetClaimGuid(this.ClaimId));
    this.EditState = Claimant.ClaimantState.Updated;
    this.OnClaimStatusChanged();
  }

  protected internal virtual void OpenClaim()
  {
    this._statusId = 0;
    this.Owner.AddActivity(new ClaimActivity(Utility.ClaimActivityType.ClaimReopened, DateTime.Now, CurrentUser.Instance.UserGUID, CurrentUser.Instance.DisplayName, this.ClaimantGuid, this.DisplayName, Utility.ClaimStatus.Open));
    this.EditState = Claimant.ClaimantState.Updated;
    Messaging.SendBroadcastMessage(new Guid("{2369F1BA-5534-4DF7-8A1D-E72C370BB90B}"), (object) Utility.GetClaimGuid(this._claimId));
    this.OnClaimStatusChanged();
  }

  public virtual Decimal ReserveTotal()
  {
    Decimal num = 0M;
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.ReservesAndPayments)
    {
      if (reservesAndPayment.EntryType == PaymentReserveType.Reserve && reservesAndPayment.ReservePaymentType.ToUpper() != "EXPENSE")
        num += reservesAndPayment.ReservePaymentAmount;
    }
    return num;
  }

  public virtual Decimal ExpenseTotal()
  {
    Decimal num = 0M;
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.ReservesAndPayments)
    {
      if (reservesAndPayment.EntryType == PaymentReserveType.Reserve && reservesAndPayment.ReservePaymentType.ToUpper() == "EXPENSE")
        num += reservesAndPayment.ReservePaymentAmount;
    }
    return num;
  }

  public virtual Decimal ExpenseTotalIncurred()
  {
    Decimal num = 0M;
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.ReservesAndPayments)
    {
      if (reservesAndPayment.EntryType == PaymentReserveType.Reserve && reservesAndPayment.ReservePaymentType.ToUpper() == "EXPENSE" && !reservesAndPayment.IsPaymentReduction)
        num += reservesAndPayment.ReservePaymentAmount;
    }
    return num;
  }

  public virtual Decimal PaymentTotal()
  {
    Decimal num = 0M;
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.ReservesAndPayments)
    {
      if (reservesAndPayment.EntryType == PaymentReserveType.Payment)
        num += reservesAndPayment.ReservePaymentAmount;
    }
    return num;
  }

  public virtual Decimal IndemnityPaymentTotal()
  {
    Decimal num = 0M;
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.ReservesAndPayments)
    {
      if (reservesAndPayment.EntryType == PaymentReserveType.Payment && reservesAndPayment.ReservePaymentType.ToUpper() != "EXPENSE")
        num += reservesAndPayment.ReservePaymentAmount;
    }
    return num;
  }

  public virtual Decimal NonExpensePaymentTotal()
  {
    Decimal num = 0M;
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.ReservesAndPayments)
    {
      if (reservesAndPayment.EntryType == PaymentReserveType.Payment && reservesAndPayment.ReservePaymentType.ToUpper() != "EXPENSE")
        num += reservesAndPayment.ReservePaymentAmount;
    }
    return num;
  }

  public virtual Decimal AllocatedExpensePaymentTotal()
  {
    Decimal num = 0M;
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.ReservesAndPayments)
    {
      if (reservesAndPayment.EntryType == PaymentReserveType.Payment && reservesAndPayment.ReservePaymentType.ToUpper() == "EXPENSE")
        num += reservesAndPayment.ReservePaymentAmount;
    }
    return num;
  }

  public PaymentReserve GetReservePayment(int reservePaymentId)
  {
    PaymentReserve reservePayment = (PaymentReserve) null;
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.ReservesAndPayments)
    {
      int? reservePaymentId1 = reservesAndPayment.ReservePaymentId;
      if (reservePaymentId1.HasValue)
      {
        reservePaymentId1 = reservesAndPayment.ReservePaymentId;
        if (reservePaymentId1.Value == reservePaymentId)
        {
          reservePayment = reservesAndPayment;
          break;
        }
      }
    }
    return reservePayment;
  }

  internal event EventHandler<EventArgs> ClaimantStatusChanged;

  public event EventHandler<CancelEventArgs> BeforeSaveClaimantCommitted;

  public bool OnBeforeSaveClaimantCommitted()
  {
    CancelEventArgs e = new CancelEventArgs();
    if (this.BeforeSaveClaimantCommitted == null)
      return true;
    this.BeforeSaveClaimantCommitted((object) this, e);
    return !e.Cancel;
  }

  public event EventHandler<ClaimantSavedEventArgs> BeforeClaimantSaved;

  public void OnBeforeClaimantSaved()
  {
    ClaimantSavedEventArgs e = new ClaimantSavedEventArgs(this._claimantGuid);
    EventHandler<ClaimantSavedEventArgs> beforeClaimantSaved = this.BeforeClaimantSaved;
    if (beforeClaimantSaved == null)
      return;
    beforeClaimantSaved((object) this, e);
  }

  protected void OnClaimStatusChanged()
  {
    if (this.ClaimantStatusChanged == null)
      return;
    this.ClaimantStatusChanged((object) this, new EventArgs());
  }

  bool INotifyChanges.HasChanges
  {
    get => this._hasChanges;
    set => this._hasChanges = value;
  }

  public void SetOwner(Claim c) => this._owner = c;

  public enum ClaimantState
  {
    None,
    New,
    Updated,
    UpdatedNew,
  }
}
