// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.Model.PendingApprovalSettlementModel
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data.Repository.Interface;
using MGASystems.IMS.Accounting.Core.DataAccess.PaymentMethod;
using MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlement;
using MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlementDecision;
using MGASystems.IMS.Accounting.Core.DataAccess.VoidTransaction;
using MGASystems.IMS.Accounting.Services.Utility;
using MGASystems.IMS.Accounting.SharedForms;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.Model;

[Override(typeof (IPendingApprovalSettlementModel))]
public class PendingApprovalSettlementModel : 
  ValidateModelBase,
  IPendingApprovalSettlementModel,
  ITrackChanges,
  IValidateModel,
  IMvcModel,
  IValidate,
  ISave
{
  private bool _hasChanges;
  private bool _userApprove;
  private bool _userReject;
  private readonly IPendingApprovalSettlementDecisionRepository _decisionRepository;
  private readonly VoidTransactionRepository _voidTransactionRepository;
  private readonly CurrentUserProvider _currentUserProvider;
  private List<PendingApprovalSettlementDecisionDto> _decisions;

  protected IPaymentMethodRepository PaymentMethodRepo { get; }

  protected PendingApprovalSettlementDto BackingDto { get; }

  protected IPendingApprovalSettlementRepository PendingSettlementRepository { get; }

  public string PayeeName => this.BackingDto.PayeeName;

  public string PayeeBank => this.BackingDto.BankName;

  public string RoutingNumber
  {
    get
    {
      return !string.IsNullOrWhiteSpace(this.BackingDto.RoutingNumber) ? new Encryption().DecryptTripleDes(this.BackingDto.RoutingNumber) : (string) null;
    }
  }

  public int TransactionNumber => this.BackingDto.TransactionNumber;

  public int? VoidingTransactionNumber => new int?(this.BackingDto.VoidedByTransactionNumber);

  public string CreateByUserName => this.BackingDto.CreatedByUserName;

  public double PaymentAmount => this.BackingDto.PaymentAmount;

  public int InvoiceIncludedCount => this.BackingDto.InvoiceCount;

  public string PaymentMethodName
  {
    get
    {
      return ((IGetByIdRepository<PaymentMethodDto, char>) this.PaymentMethodRepo).GetById(this.BackingDto.PaymentMethodId).Name;
    }
  }

  public string ApproveRejectedBy
  {
    get
    {
      return this._decisions.FirstOrDefault<PendingApprovalSettlementDecisionDto>()?.UserName ?? string.Empty;
    }
  }

  public bool UserApprove
  {
    get => this._userApprove;
    set
    {
      this._userApprove = value;
      if (this._userApprove)
        this._userReject = false;
      this.NotifyObservers();
    }
  }

  public bool UserReject
  {
    get => this._userReject;
    set
    {
      this._userReject = value;
      if (this.UserReject)
        this._userApprove = false;
      this.NotifyObservers();
    }
  }

  public bool IsRejected => this.BackingDto.IsRejected;

  public bool IsApproved => this.BackingDto.IsApproved;

  public DateTime CreateDate => this.BackingDto.CreatedDate;

  public DateTime StatusDate => this.BackingDto.StatusDate;

  public object UniqueIdentifier => (object) this.TransactionNumber;

  public PendingApprovalSettlementModel(
    IPendingApprovalSettlementDecisionRepository decisionRepository,
    IPendingApprovalSettlementRepository pendingSettlementRepository,
    PendingApprovalSettlementDto pendingSettlementDto,
    PendingApprovalSettlementDecisionDto[] approvalDtos,
    VoidTransactionRepository voidTransactionRepository,
    CurrentUserProvider currentUserProvider,
    IPaymentMethodRepository paymentMethodRepository)
  {
    this._decisionRepository = decisionRepository ?? throw new ArgumentNullException(nameof (decisionRepository));
    this.PendingSettlementRepository = pendingSettlementRepository ?? throw new ArgumentNullException(nameof (pendingSettlementRepository));
    this.BackingDto = pendingSettlementDto ?? throw new ArgumentNullException(nameof (pendingSettlementDto));
    this._voidTransactionRepository = voidTransactionRepository ?? throw new ArgumentNullException(nameof (voidTransactionRepository));
    this._currentUserProvider = currentUserProvider ?? throw new ArgumentNullException(nameof (currentUserProvider));
    this.PaymentMethodRepo = paymentMethodRepository ?? throw new ArgumentNullException(nameof (paymentMethodRepository));
    this.ValidateApprovalDtos(approvalDtos);
    this._decisions = (approvalDtos != null ? ((IEnumerable<PendingApprovalSettlementDecisionDto>) approvalDtos).ToList<PendingApprovalSettlementDecisionDto>() : (List<PendingApprovalSettlementDecisionDto>) null) ?? throw new ArgumentNullException(nameof (approvalDtos));
    this.UserApprove = this.IsApproved;
    this.UserReject = this.IsRejected;
  }

  public PendingApprovalSettlementModel(
    IPendingApprovalSettlementDecisionRepository decisionRepository,
    IPendingApprovalSettlementRepository pendingSettlementRepository,
    PendingApprovalSettlementDto pendingSettlementDto,
    PendingApprovalSettlementDecisionDto[] approvalDtos)
    : this(decisionRepository, pendingSettlementRepository, pendingSettlementDto, approvalDtos, new VoidTransactionRepository(), new CurrentUserProvider(), (IPaymentMethodRepository) ObjectFactory.Instance.CreateObjectAs<IPaymentMethodRepositoryCache>())
  {
  }

  public bool HasChanges() => this._hasChanges;

  public void MarkChanged() => this._hasChanges = true;

  public virtual void ResetChanges()
  {
    this.UserApprove = this.IsApproved;
    this.UserReject = this.IsRejected;
    this._hasChanges = false;
  }

  public virtual void SaveChanges()
  {
    if (this.SkipSave() || !this.UserApprove && !this.UserReject)
      return;
    this.CreateTransactionStatusStamp();
    this.SetTransactionStatus();
  }

  protected bool SkipSave()
  {
    if (this.UserApprove && this.IsApproved)
      return true;
    return this.UserReject && this.IsRejected;
  }

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
    if (this._currentUserProvider.UserGuid.Equals(this.BackingDto.CreateByUserGuid) && (this.UserApprove || this.UserReject))
      validationResult.Add((IDataValidationResult) new InvalidDataValidationResult($"- Transaction #{this.TransactionNumber}: You cannot approve or reject a settlement that you created."));
    if (!this.UserApprove || !this.UserReject)
      return;
    validationResult.Add((IDataValidationResult) new InvalidDataValidationResult($"- Transaction #{this.TransactionNumber}: You cannot both approve and reject a settlement."));
  }

  private void ValidateApprovalDtos(
    PendingApprovalSettlementDecisionDto[] approvalDtos)
  {
    PendingApprovalSettlementDecisionDto settlementDecisionDto = ((IEnumerable<PendingApprovalSettlementDecisionDto>) approvalDtos).FirstOrDefault<PendingApprovalSettlementDecisionDto>((Func<PendingApprovalSettlementDecisionDto, bool>) (approval => approval.TransactionNumber != this.BackingDto.TransactionNumber));
    if (settlementDecisionDto != null)
      throw new ArgumentException($"Cannot add an approval for transaction #{settlementDecisionDto.TransactionNumber} to pending transaction #{this.BackingDto.TransactionNumber}");
  }

  private void WriteVoid(int transactionNumber, DateTime createDate, string generalLedgerCompanyId)
  {
    formVoidTransaction formVoidTransaction = new formVoidTransaction(transactionNumber);
    DateTime accountingPeriod = this.PendingSettlementRepository.GetPostDateForGlCompanyIdAccountingPeriod(createDate, generalLedgerCompanyId);
    this._voidTransactionRepository.VoidTransaction(transactionNumber, accountingPeriod, "Rejected via settlement approval", new Action<int, int>(formVoidTransaction.PublicBeforeVoidCommitted));
  }

  private PendingApprovalSettlementDecisionDto CreateApprovalDto(bool isApproved)
  {
    return new PendingApprovalSettlementDecisionDto()
    {
      TransactionNumber = this.BackingDto.TransactionNumber,
      CreateUserGuid = this._currentUserProvider.UserGuid,
      IsApproved = isApproved,
      UserName = this._currentUserProvider.DisplayName
    };
  }

  private void CreateTransactionStatusStamp()
  {
    PendingApprovalSettlementDecisionDto approvalDto = this.CreateApprovalDto(this.UserApprove);
    approvalDto.Id = ((ICreateRepository<PendingApprovalSettlementDecisionDto, int>) this._decisionRepository).Insert(approvalDto);
    this._decisions.Add(approvalDto);
  }

  private void SetTransactionStatus()
  {
    if (this.UserReject)
    {
      this.WriteVoid(this.TransactionNumber, this.CreateDate, this.BackingDto.GeneralLedgerCompanyId);
      this.PendingSettlementRepository.MarkTransactionRejected(this.BackingDto.TransactionNumber);
      this.BackingDto.IsRejected = true;
      this.BackingDto.IsApproved = false;
    }
    else
    {
      if (!this.UserApprove)
        return;
      this.PendingSettlementRepository.MarkTransactionApproved(this.BackingDto.TransactionNumber);
      this.BackingDto.IsApproved = true;
      this.BackingDto.IsRejected = false;
    }
  }
}
