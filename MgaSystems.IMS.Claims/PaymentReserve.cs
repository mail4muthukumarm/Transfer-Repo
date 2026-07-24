// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.PaymentReserve
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

#nullable disable
namespace MGASystems.IMS.Claims;

public class PaymentReserve
{
  private PaymentReserveType _entryType;
  private int? _reservePaymentId;
  private int? _claimId;
  private Guid _claimantGuid;
  private int? _coverageTypeId;
  private string _coverageType;
  private int? _coverageTypeDescriptionId;
  private string _coverageTypeDescription;
  private int _reservePaymentTypeId;
  private string _reservePaymentType;
  private int? _reservePaymentSubTypeId;
  private string _reservePaymentSubType;
  private Decimal _reservePaymentAmount;
  private DateTime _dateCreated;
  private Guid _createdByGuid;
  private string _createdBy;
  private string _comments;
  private bool _isPayeeClaimant;
  private bool _isPayeeInsured;
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
  private DateTime _datePaid;
  private string _paidBy;
  protected Utility.CollectionItemStatus _status;
  private bool _isVoid;
  private bool _isPaymentReduction;
  private string _recoveryCheckNumber;
  private bool _isRecovery;
  private bool _isPaymentReturn;
  private int? _paymentReturn_reservePaymentId;
  private string _additionalPayees;
  private ClaimAddress _overridePayeeAddress;
  private List<string> _associatedDocuments;

  public PaymentReserve(PaymentReserveType entryType) => this._entryType = entryType;

  public PaymentReserve(
    int reservePaymentId,
    int claimId,
    Guid claimantGuid,
    DateTime dateCreated,
    Guid createdByGuid,
    string createdBy,
    PaymentReserveType entryType,
    bool isRecovery,
    bool isPaymentReturn,
    int? paymentReturn_ReservePaymentId)
  {
    this._reservePaymentId = new int?(reservePaymentId);
    this._claimId = new int?(claimId);
    this._claimantGuid = claimantGuid;
    this._entryType = entryType;
    this._createdBy = createdBy;
    this._createdByGuid = createdByGuid;
    this._dateCreated = dateCreated;
    this._status = Utility.CollectionItemStatus.Unchanged;
    this._isRecovery = isRecovery;
    this._isPaymentReturn = isPaymentReturn;
    this._paymentReturn_reservePaymentId = paymentReturn_ReservePaymentId;
  }

  public PaymentReserve(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    string comments,
    Decimal reservePaymentAmount)
  {
    this.InitializeObject(entryType, reservePaymentTypeId, reservePaymentType, new int?(), string.Empty, new int?(), string.Empty, new int?(), string.Empty, comments, reservePaymentAmount, Guid.Empty, string.Empty, false, false, new int?());
  }

  public PaymentReserve(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    string comments,
    Decimal reservePaymentAmount,
    Guid payeeGuid,
    string payeeName)
  {
    this.InitializeObject(entryType, reservePaymentTypeId, reservePaymentType, new int?(), string.Empty, new int?(), string.Empty, new int?(), string.Empty, comments, reservePaymentAmount, payeeGuid, payeeName, false, false, new int?());
  }

  public PaymentReserve(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    int? reservePaymentSubTypeId,
    string reservePaymentSubType,
    string comments,
    Decimal reservePaymentAmount)
  {
    this.InitializeObject(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, new int?(), string.Empty, new int?(), string.Empty, comments, reservePaymentAmount, Guid.Empty, string.Empty, false, false, new int?());
  }

  public PaymentReserve(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    int? reservePaymentSubTypeId,
    string reservePaymentSubType,
    string comments,
    Decimal reservePaymentAmount,
    Guid payeeGuid,
    string payeeName)
  {
    this.InitializeObject(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, new int?(), string.Empty, new int?(), string.Empty, comments, reservePaymentAmount, payeeGuid, payeeName, false, false, new int?());
  }

  public PaymentReserve(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    int? reservePaymentSubTypeId,
    string reservePaymentSubType,
    int? coverageTypeId,
    string coverageType,
    string comments,
    Decimal reservePaymentAmount)
  {
    this.InitializeObject(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, coverageTypeId, coverageType, new int?(), string.Empty, comments, reservePaymentAmount, Guid.Empty, string.Empty, false, false, new int?());
  }

  public PaymentReserve(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    int? reservePaymentSubTypeId,
    string reservePaymentSubType,
    int? coverageTypeId,
    string coverageType,
    int? coverageTypeDescriptionId,
    string coverageTypeDescription,
    string comments,
    Decimal reservePaymentAmount)
  {
    this.InitializeObject(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, coverageTypeId, coverageType, coverageTypeDescriptionId, coverageTypeDescription, comments, reservePaymentAmount, Guid.Empty, string.Empty, false, false, new int?());
  }

  public PaymentReserve(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    int? reservePaymentSubTypeId,
    string reservePaymentSubType,
    int? coverageTypeId,
    string coverageType,
    string comments,
    Decimal reservePaymentAmount,
    Guid payeeGuid,
    string payeeName)
  {
    this.InitializeObject(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, coverageTypeId, coverageType, new int?(), string.Empty, comments, reservePaymentAmount, payeeGuid, payeeName, false, false, new int?());
  }

  public PaymentReserve(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    int? reservePaymentSubTypeId,
    string reservePaymentSubType,
    int? coverageTypeId,
    string coverageType,
    int? coverageTypeDescriptionId,
    string coverageTypeDescription,
    string comments,
    Decimal reservePaymentAmount,
    Guid payeeGuid,
    string payeeName,
    bool isRecoveryType)
  {
    this.InitializeObject(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, coverageTypeId, coverageType, coverageTypeDescriptionId, coverageTypeDescription, comments, reservePaymentAmount, payeeGuid, payeeName, isRecoveryType, false, new int?());
  }

  public PaymentReserve(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    int? reservePaymentSubTypeId,
    string reservePaymentSubType,
    int? coverageTypeId,
    string coverageType,
    int? coverageTypeDescriptionId,
    string coverageTypeDescription,
    string comments,
    Decimal reservePaymentAmount,
    Guid payeeGuid,
    string payeeName,
    bool isRecoveryType,
    bool isPaymentReturn,
    int? paymentReturn_ReservePaymentId)
  {
    this.InitializeObject(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, coverageTypeId, coverageType, coverageTypeDescriptionId, coverageTypeDescription, comments, reservePaymentAmount, payeeGuid, payeeName, isRecoveryType, isPaymentReturn, paymentReturn_ReservePaymentId);
  }

  public PaymentReserveType EntryType => this._entryType;

  public int? ReservePaymentId => this._reservePaymentId;

  public int? ClaimId => this._claimId;

  public Guid ClaimantGuid => this._claimantGuid;

  public int? CoverageTypeId
  {
    get => this._coverageTypeId;
    set => this._coverageTypeId = value;
  }

  public string CoverageType
  {
    get => this._coverageType;
    set => this._coverageType = value;
  }

  public int? CoverageTypeDescriptionId
  {
    get => this._coverageTypeDescriptionId;
    set => this._coverageTypeDescriptionId = value;
  }

  public string CoverageTypeDescription
  {
    get => this._coverageTypeDescription;
    set => this._coverageTypeDescription = value;
  }

  public int ReservePaymentTypeId
  {
    get => this._reservePaymentTypeId;
    set => this._reservePaymentTypeId = value;
  }

  public string ReservePaymentType
  {
    get => this._reservePaymentType;
    set => this._reservePaymentType = value;
  }

  public int? ReservePaymentSubTypeId
  {
    get => this._reservePaymentSubTypeId;
    set => this._reservePaymentSubTypeId = value;
  }

  public string ReservePaymentSubType
  {
    get => this._reservePaymentSubType;
    set => this._reservePaymentSubType = value;
  }

  public Decimal ReservePaymentAmount
  {
    get => this._reservePaymentAmount;
    set => this._reservePaymentAmount = value;
  }

  public DateTime DateCreated
  {
    get => this._dateCreated;
    set => this._dateCreated = value;
  }

  public Guid CreatedByGuid => this._createdByGuid;

  public string CreatedBy => this._createdBy;

  public string Comments
  {
    get => this._comments;
    set => this._comments = value;
  }

  public bool IsPayeeClaimant
  {
    get => this._isPayeeClaimant;
    set => this._isPayeeClaimant = value;
  }

  public bool IsPayeeInsured
  {
    get => this._isPayeeInsured;
    set => this._isPayeeInsured = value;
  }

  public Guid PayeeGuid
  {
    get => this._payeeGuid;
    set => this._payeeGuid = value;
  }

  public string PayeeName
  {
    get => this._payeeName;
    set => this._payeeName = value;
  }

  public string PayeeAddress1
  {
    get => this._payeeAddress1;
    set => this._payeeAddress1 = value;
  }

  public string PayeeAddress2
  {
    get => this._payeeAddress2;
    set => this._payeeAddress2 = value;
  }

  public string PayeeCity
  {
    get => this._payeeCity;
    set => this._payeeCity = value;
  }

  public string PayeeState
  {
    get => this._payeeState;
    set => this._payeeState = value;
  }

  public string PayeeZipCode
  {
    get => this._payeeZipCode;
    set => this._payeeZipCode = value;
  }

  public string PayeeZipCodeExtension
  {
    get => this._payeeZipCodeExtension;
    set => this._payeeZipCodeExtension = value;
  }

  public bool PayeeIsInternational
  {
    get => this._payeeIsInternational;
    set => this._payeeIsInternational = value;
  }

  public string PayeeInternationalZipCode
  {
    get => this._payeeInternationalZipCode;
    set => this._payeeInternationalZipCode = value;
  }

  public string PayeeISOCountryCode
  {
    get => this._payeeISOCountryCode;
    set => this._payeeISOCountryCode = value;
  }

  public string PayeeEmail
  {
    get => this._payeeEmail;
    set => this._payeeEmail = value;
  }

  public string PayeeFEIN
  {
    get => this._payeeFEIN;
    set => this._payeeFEIN = value;
  }

  public string PayeeSSN
  {
    get => this._payeeSSN;
    set => this._payeeSSN = value;
  }

  public bool PayeeIs1099
  {
    get => this._payeeIs1099;
    set => this._payeeIs1099 = value;
  }

  public DateTime DatePaid => this._datePaid;

  public string PaidBy => this._paidBy;

  public Utility.CollectionItemStatus Status => this._status;

  public bool IsVoid
  {
    get => this._isVoid;
    set => this._isVoid = value;
  }

  public bool IsPaymentReduction
  {
    get => this._isPaymentReduction;
    set => this._isPaymentReduction = value;
  }

  public string RecoveryCheckNumber
  {
    get => this._recoveryCheckNumber;
    set => this._recoveryCheckNumber = value;
  }

  public bool IsRecovery
  {
    get => this._isRecovery;
    set => this._isRecovery = value;
  }

  public bool IsPaymentReturn
  {
    get => this._isPaymentReturn;
    set => this._isPaymentReturn = value;
  }

  public int? PaymentReturn_ReservePaymentId
  {
    get => this._paymentReturn_reservePaymentId;
    set => this._paymentReturn_reservePaymentId = value;
  }

  public string AdditionalPayees
  {
    get => this._additionalPayees;
    set => this._additionalPayees = value;
  }

  public bool IsPayeeDefenseAttorney { get; set; }

  public bool IsPayeeClaimantAttorney { get; set; }

  public ClaimAddress OverridePayeeAddress
  {
    get
    {
      if (this._overridePayeeAddress == null)
        this._overridePayeeAddress = new ClaimAddress();
      return this._overridePayeeAddress;
    }
    set => this._overridePayeeAddress = value;
  }

  public List<string> AssociatedDocuments
  {
    get
    {
      if (this._associatedDocuments == null)
        this._associatedDocuments = new List<string>();
      return this._associatedDocuments;
    }
  }

  public int? PaymentResPayId { get; set; }

  private void InitializeObject(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    int? reservePaymentSubTypeId,
    string reservePaymentSubType,
    int? coverageTypeId,
    string coverageType,
    int? coverageTypeDescriptionId,
    string coverageTypeDescription,
    string comments,
    Decimal reservePaymentAmount,
    Guid payeeGuid,
    string payeeName,
    bool isRecovery,
    bool isPaymentReturn,
    int? paymentReturn_ReservePaymentId)
  {
    this._entryType = entryType;
    this._reservePaymentTypeId = reservePaymentTypeId;
    this._reservePaymentType = reservePaymentType;
    this._reservePaymentSubTypeId = reservePaymentSubTypeId;
    this._reservePaymentSubType = reservePaymentSubType;
    this._coverageTypeId = coverageTypeId;
    this._coverageType = coverageType;
    this._coverageTypeDescriptionId = coverageTypeDescriptionId;
    this._coverageTypeDescription = coverageTypeDescription;
    this._comments = comments;
    this._reservePaymentAmount = reservePaymentAmount;
    this._payeeGuid = payeeGuid;
    this._payeeName = payeeName;
    this._dateCreated = DateTime.Now;
    this._createdByGuid = CurrentUser.Instance.UserGUID;
    this._createdBy = CurrentUser.Instance.DisplayName;
    this._isRecovery = isRecovery;
    this._isPaymentReturn = isPaymentReturn;
    this._paymentReturn_reservePaymentId = paymentReturn_ReservePaymentId;
    this._status = Utility.CollectionItemStatus.New;
  }

  public void Save(int claimId, Guid claimantGuid)
  {
    this._claimantGuid = claimantGuid;
    this._claimId = new int?(claimId);
    if (this.Status == Utility.CollectionItemStatus.Unchanged)
      return;
    int? reservePaymentId = this.ReservePaymentId;
    if (reservePaymentId.HasValue)
    {
      reservePaymentId = this.ReservePaymentId;
      int num = 0;
      if (!(reservePaymentId.GetValueOrDefault() <= num & reservePaymentId.HasValue))
        goto label_8;
    }
    if (!this.IsPaymentReduction)
    {
      this.SaveNew();
      if (this.EntryType == PaymentReserveType.Reserve)
      {
        if (this.IsPaymentReduction)
          return;
        Messaging.SendBroadcastMessage(new Guid("{395AB552-44F5-4ca6-AAAF-7D5E07A8F726}"), (object) Utility.GetClaimGuid(claimId));
        return;
      }
      Messaging.SendBroadcastMessage(new Guid("{AE832DAE-49F6-4c57-BED9-3B19A0FBDCDC}"), (object) Utility.GetClaimGuid(claimId));
      return;
    }
label_8:
    this.UpdateExisting();
  }

  public void SetVoidStatus(bool value)
  {
    this._isVoid = value;
    this._status = Utility.CollectionItemStatus.Updated;
  }

  protected virtual void SaveNew() => this.SaveNew("spClaims_InsertReservePayment");

  protected virtual void SaveNew(string procedureName)
  {
    this.SaveNew(procedureName, (object[]) null);
  }

  protected virtual void SaveNew(string procedureName, params object[] sprocAddedArgs)
  {
    try
    {
      if (sprocAddedArgs != null && sprocAddedArgs.Length != 0 && sprocAddedArgs.Length % 2 != 0)
        throw new ArgumentException("Additional parameter array should have an even number of items.");
      object[] objArray = new object[58];
      objArray[0] = (object) "@ClaimId";
      objArray[1] = (object) this.ClaimId.Value;
      objArray[2] = (object) "@ClaimantGuid";
      objArray[3] = (object) this.ClaimantGuid;
      objArray[4] = (object) "@CoverageTypeId";
      int? nullable = this.CoverageTypeId;
      objArray[5] = (object) (nullable.HasValue ? (SqlInt32) nullable.GetValueOrDefault() : SqlInt32.Null);
      objArray[6] = (object) "@CoverageTypeDescriptionId";
      nullable = this.CoverageTypeDescriptionId;
      objArray[7] = (object) (nullable.HasValue ? (SqlInt32) nullable.GetValueOrDefault() : SqlInt32.Null);
      objArray[8] = (object) "@ResPayTypeId";
      objArray[9] = (object) this.ReservePaymentTypeId;
      objArray[10] = (object) "@ResPaySubTypeId";
      nullable = this.ReservePaymentSubTypeId;
      objArray[11] = (object) (nullable.HasValue ? (SqlInt32) nullable.GetValueOrDefault() : SqlInt32.Null);
      objArray[12] = (object) "@ResPayAmount";
      objArray[13] = (object) this.ReservePaymentAmount;
      objArray[14] = (object) "@CreatedByGuid";
      objArray[15] = (object) CurrentUser.Instance.UserGUID;
      objArray[16 /*0x10*/] = (object) "@Comments";
      objArray[17] = (object) this.Comments;
      objArray[18] = (object) "@IsPayment";
      objArray[19] = (object) (this.EntryType == PaymentReserveType.Payment);
      objArray[20] = (object) "@payeeGuid";
      objArray[21] = (object) (this.EntryType != PaymentReserveType.Payment ? SqlGuid.Null : (SqlGuid) this.PayeeGuid);
      objArray[22] = (object) "@payeeName";
      objArray[23] = (object) (this.EntryType != PaymentReserveType.Payment ? SqlString.Null : (SqlString) this.PayeeName);
      objArray[24] = (object) "@IsPayeeClaimant";
      objArray[25] = (object) this.IsPayeeClaimant;
      objArray[26] = (object) "@IsPayeeInsured";
      objArray[27] = (object) this.IsPayeeInsured;
      objArray[28] = (object) "@IsRecovery";
      objArray[29] = (object) this.IsRecovery;
      objArray[30] = (object) "@RecoveryCheckNumber";
      objArray[31 /*0x1F*/] = (object) this.RecoveryCheckNumber;
      objArray[32 /*0x20*/] = (object) "@Void";
      objArray[33] = (object) this.IsVoid;
      objArray[34] = (object) "@PaymentReturn";
      objArray[35] = (object) this.IsPaymentReturn;
      objArray[36] = (object) "@PaymentReturn_ResPayId";
      objArray[37] = (object) this.PaymentReturn_ReservePaymentId;
      objArray[38] = (object) "@AdditionalPayees";
      objArray[39] = (object) this.AdditionalPayees;
      objArray[40] = (object) "@Override_Address1";
      objArray[41] = (object) this.OverridePayeeAddress.Address1;
      objArray[42] = (object) "@Override_Address2";
      objArray[43] = (object) this.OverridePayeeAddress.Address2;
      objArray[44] = (object) "@Override_City";
      objArray[45] = (object) this.OverridePayeeAddress.City;
      objArray[46] = (object) "@Override_State";
      objArray[47] = (object) this.OverridePayeeAddress.State;
      objArray[48 /*0x30*/] = (object) "@Override_ZipCode";
      objArray[49] = (object) this.OverridePayeeAddress.ZipCode;
      objArray[50] = (object) "@Override_ISOCountryCode";
      objArray[51] = (object) this.OverridePayeeAddress.IsoCountryCode;
      objArray[52] = (object) "@date";
      objArray[53] = (object) this.DateCreated;
      objArray[54] = (object) "@IsPayeeDefenseAttorney";
      objArray[55] = (object) this.IsPayeeDefenseAttorney;
      objArray[56] = (object) "@IsPayeeClaimantAttorney";
      objArray[57] = (object) this.IsPayeeClaimantAttorney;
      object[] array = objArray;
      if (sprocAddedArgs != null && sprocAddedArgs.Length != 0)
      {
        int length = array.Length;
        Array.Resize<object>(ref array, array.Length + sprocAddedArgs.Length);
        sprocAddedArgs.CopyTo((Array) array, length);
      }
      this._reservePaymentId = new int?((int) DefaultDatabase.ExecuteScalar(procedureName, array));
      if (this.IsVoid || this.EntryType != PaymentReserveType.Payment || this.IsPayeeClaimant || this.IsPayeeInsured)
        return;
      DefaultDatabase.ExecuteNonQuery("dbo.spClaims_InsertClaimPayee", new object[38]
      {
        (object) "@ResPayId",
        (object) this.ReservePaymentId,
        (object) "@InsuredGuid",
        (object) SqlGuid.Null,
        (object) "@IsInsured",
        (object) this.IsPayeeInsured,
        (object) "@PayeeName",
        (object) this.PayeeName,
        (object) "@Address1",
        (object) this.PayeeAddress1,
        (object) "@Address2",
        (object) this.PayeeAddress2,
        (object) "@City",
        (object) this.PayeeCity,
        (object) "@State",
        (object) this.PayeeState,
        (object) "@ZipCode",
        (object) this.PayeeZipCode,
        (object) "@ZipCodeExtension",
        (object) this.PayeeZipCodeExtension,
        (object) "@IsInternational",
        (object) this.PayeeIsInternational,
        (object) "@InternationalZipCode",
        (object) this.PayeeInternationalZipCode,
        (object) "@ISOCountryCode",
        (object) this.PayeeISOCountryCode,
        (object) "@Email",
        (object) SqlString.Null,
        (object) "@FEIN",
        (object) this.PayeeFEIN,
        (object) "@SSN",
        (object) this.PayeeSSN,
        (object) "@Is1099",
        (object) this.PayeeIs1099,
        (object) "@OFACValidated",
        (object) SqlDateTime.Null,
        (object) "@OFACResponse",
        (object) SqlString.Null
      });
    }
    catch (Exception ex)
    {
      this._reservePaymentId = new int?();
      throw ex;
    }
  }

  protected virtual void UpdateExisting()
  {
    object[] objArray = new object[30];
    objArray[0] = (object) "@ResPayId";
    objArray[1] = (object) this.ReservePaymentId;
    objArray[2] = (object) "@CoverageTypeId";
    int? nullable = this.CoverageTypeId;
    objArray[3] = (object) (nullable.HasValue ? (SqlInt32) nullable.GetValueOrDefault() : SqlInt32.Null);
    objArray[4] = (object) "@CoverageTypeDescriptionId";
    nullable = this.CoverageTypeDescriptionId;
    objArray[5] = (object) (nullable.HasValue ? (SqlInt32) nullable.GetValueOrDefault() : SqlInt32.Null);
    objArray[6] = (object) "@ResPayTypeId";
    objArray[7] = (object) this.ReservePaymentTypeId;
    objArray[8] = (object) "@ResPaySubTypeId";
    nullable = this.ReservePaymentSubTypeId;
    objArray[9] = (object) (nullable.HasValue ? (SqlInt32) nullable.GetValueOrDefault() : SqlInt32.Null);
    objArray[10] = (object) "@ResPayAmount";
    objArray[11] = (object) this.ReservePaymentAmount;
    objArray[12] = (object) "@Comments";
    objArray[13] = (object) this.Comments;
    objArray[14] = (object) "@Void";
    objArray[15] = (object) this.IsVoid;
    objArray[16 /*0x10*/] = (object) "@AdditionalPayees";
    objArray[17] = (object) this.AdditionalPayees;
    objArray[18] = (object) "@Override_Address1";
    objArray[19] = (object) this.OverridePayeeAddress.Address1;
    objArray[20] = (object) "@Override_Address2";
    objArray[21] = (object) this.OverridePayeeAddress.Address2;
    objArray[22] = (object) "@Override_City";
    objArray[23] = (object) this.OverridePayeeAddress.City;
    objArray[24] = (object) "@Override_State";
    objArray[25] = (object) this.OverridePayeeAddress.State;
    objArray[26] = (object) "@Override_ZipCode";
    objArray[27] = (object) this.OverridePayeeAddress.ZipCode;
    objArray[28] = (object) "@Override_ISOCountryCode";
    objArray[29] = (object) this.OverridePayeeAddress.IsoCountryCode;
    DefaultDatabase.ExecuteScalar("spClaims_UpdateReservePayment", objArray);
  }

  private void LoadReservePayment()
  {
  }

  public virtual bool IsMatchingPayment(PaymentReserve payment)
  {
    if (payment.ReservePaymentTypeId == this.ReservePaymentTypeId)
    {
      int? nullable1 = payment.ReservePaymentSubTypeId;
      int? paymentSubTypeId = this.ReservePaymentSubTypeId;
      if (nullable1.GetValueOrDefault() == paymentSubTypeId.GetValueOrDefault() & nullable1.HasValue == paymentSubTypeId.HasValue)
      {
        int? nullable2 = payment.CoverageTypeId;
        nullable1 = this.CoverageTypeId;
        if (nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() & nullable2.HasValue == nullable1.HasValue)
        {
          nullable1 = payment.CoverageTypeDescriptionId;
          nullable2 = this.CoverageTypeDescriptionId;
          if (nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() & nullable1.HasValue == nullable2.HasValue)
          {
            nullable2 = payment.ReservePaymentId;
            nullable1 = this.ReservePaymentId;
            return !(nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() & nullable2.HasValue == nullable1.HasValue);
          }
        }
      }
    }
    return false;
  }

  public PaymentReserve BringDownReserve(Decimal paymentAmount)
  {
    if (this.EntryType != PaymentReserveType.Reserve)
      throw new InvalidReservePaymentTypeException(Resources.INVALID_RESERVEPAYMENT_EXCEPTION1);
    PaymentReserve objectAs = ObjectFactory.Instance.CreateObjectAs<PaymentReserve>((object) this.EntryType, (object) this.ReservePaymentTypeId, (object) this.ReservePaymentType, (object) this.ReservePaymentSubTypeId, (object) this.ReservePaymentSubType, (object) this.CoverageTypeId, (object) this.CoverageType, (object) this.CoverageTypeDescriptionId, (object) this.CoverageTypeDescription, (object) this.Comments, (object) this.ReservePaymentAmount);
    objectAs.ReservePaymentAmount = (objectAs.ReservePaymentAmount + paymentAmount) * -1M;
    return objectAs;
  }

  public PaymentReserve BringDownReserve(Decimal paymentAmount, DateTime closeDate)
  {
    if (this.EntryType != PaymentReserveType.Reserve)
      throw new InvalidReservePaymentTypeException(Resources.INVALID_RESERVEPAYMENT_EXCEPTION1);
    PaymentReserve objectAs = ObjectFactory.Instance.CreateObjectAs<PaymentReserve>((object) this.EntryType, (object) this.ReservePaymentTypeId, (object) this.ReservePaymentType, (object) this.ReservePaymentSubTypeId, (object) this.ReservePaymentSubType, (object) this.CoverageTypeId, (object) this.CoverageType, (object) this.CoverageTypeDescriptionId, (object) this.CoverageTypeDescription, (object) this.Comments, (object) this.ReservePaymentAmount);
    objectAs.DateCreated = closeDate;
    objectAs.ReservePaymentAmount = (objectAs.ReservePaymentAmount + paymentAmount) * -1M;
    return objectAs;
  }
}
