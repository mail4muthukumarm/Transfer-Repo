// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlementDecision.PendingApprovalSettlementDecisionRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data.Repository.ColumnAttribute;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlementDecision;

[Override(typeof (IPendingApprovalSettlementDecisionRepository))]
public class PendingApprovalSettlementDecisionRepository : 
  CaiRepositoryBase<PendingApprovalSettlementDecisionDto, int>,
  IPendingApprovalSettlementDecisionRepository,
  ICreateRepository<PendingApprovalSettlementDecisionDto, int>,
  ICreateRepository,
  IExecuteTransaction,
  IGetAllRepository<PendingApprovalSettlementDecisionDto, int>,
  IGetAllRepository,
  IGetByIdRepository<PendingApprovalSettlementDecisionDto, int>,
  IGetByIdRepository
{
  private const string ActionContext = "Settlement Approval - System";
  private static readonly string _getByTransactionNumberProcedureName = "[dbo].[spFin_PendingApprovalSettlementDecision_GetByTransactionNumber]";
  private static readonly string _getAllOnOrAfterDateProcedureName = "[dbo].[spFin_PendingApprovalSettlementDecision_GetAllOnOrAfterDate]";

  protected override string InsertResultColumn => "InsertedId";

  protected override string InsertProcedureName
  {
    get => "[dbo].[spFin_PendingApprovalSettlementDecision_Insert]";
  }

  protected override string GetByIdProcedureName
  {
    get => "[dbo].[spFin_PendingApprovalSettlementDecision_GetById]";
  }

  protected override string GetAllProcedureName
  {
    get => "[dbo].[spFin_PendingApprovalSettlementDecision_GetAll]";
  }

  public PendingApprovalSettlementDecisionRepository()
    : base((Action<string>) (s => CurrentUser.Instance.LogAction(s, "Settlement Approval - System")))
  {
  }

  public PendingApprovalSettlementDecisionRepository(
    Action<string> logAction,
    DataNamesMapper<PendingApprovalSettlementDecisionDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base(logAction, dataNamesMapper, databaseAccess)
  {
  }

  public PendingApprovalSettlementDecisionDto[] GetForTransactionNumber(int transactionNumber)
  {
    return ((BaseDataAccess<PendingApprovalSettlementDecisionDto, int>) this).MapQueryMultiResult(PendingApprovalSettlementDecisionRepository._getByTransactionNumberProcedureName, new object[2]
    {
      (object) "@TransactionNumber",
      (object) transactionNumber
    });
  }

  public PendingApprovalSettlementDecisionDto[] GetAllOnAndAfterDate(DateTime oldestCreateDate)
  {
    return ((BaseDataAccess<PendingApprovalSettlementDecisionDto, int>) this).MapQueryMultiResult(PendingApprovalSettlementDecisionRepository._getAllOnOrAfterDateProcedureName, new object[2]
    {
      (object) "@MinimumDate",
      (object) oldestCreateDate
    });
  }

  protected override object[] GetGetByIdParams(int id)
  {
    return new object[2]{ (object) "@id", (object) id };
  }

  protected override object[] GetInsertParams(PendingApprovalSettlementDecisionDto dto)
  {
    return new object[6]
    {
      (object) "@TransactionNumber",
      (object) dto.TransactionNumber,
      (object) "@ApprovedRejected",
      (object) dto.IsApproved,
      (object) "@CreateUserGuid",
      (object) dto.CreateUserGuid
    };
  }

  protected override void ValidateId(int identifier)
  {
    ((BaseDataAccess<PendingApprovalSettlementDecisionDto, int>) this).ValidateIntegerId(identifier);
  }

  protected override int ConvertToTypedId(object insertResultColumnValue)
  {
    return int.Parse(insertResultColumnValue.ToString());
  }
}
