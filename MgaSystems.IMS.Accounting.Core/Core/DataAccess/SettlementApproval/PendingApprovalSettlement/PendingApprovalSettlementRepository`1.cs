// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlement.PendingApprovalSettlementRepository`1
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.Repository.ColumnAttribute;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlement;

public abstract class PendingApprovalSettlementRepository<TPendingApprovalSettlementDto> : 
  BaseRepository<TPendingApprovalSettlementDto, int>,
  IPendingApprovalSettlementRepository<TPendingApprovalSettlementDto>,
  IPendingApprovalSettlementRepository
  where TPendingApprovalSettlementDto : PendingApprovalSettlementDto, new()
{
  private const string _actionContext = "Settlement Approval";
  private const string _markTransactionPendingProcedureName = "[dbo].[spFin_PendingApprovalSettlement_MarkTransactionPending]";
  private const string _markTransactionApprovedProcedureName = "[dbo].[spFin_PendingApprovalSettlement_MarkTransactionApproved]";
  private const string _markTransactionRejectedProcedureName = "[dbo].[spFin_PendingApprovalSettlement_MarkTransactionRejected]";
  private const string _markTransactionBypassProcedureName = "[dbo].[spFin_PendingApprovalSettlement_MarkTransactionBypass]";

  protected virtual string GetPendingAndRecentTransactionsProcedureName
  {
    get
    {
      return !MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("EnableMultiACHSettings") ? "[dbo].[spFin_PendingApprovalSettlement_GetPendingAndRecentTransactions]" : "[dbo].[spFin_PendingApprovalSettlement_GetPendingAndRecentTransactions_ACH_Multi]";
    }
  }

  protected PendingApprovalSettlementRepository()
    : base((Action<string>) (s => CurrentUser.Instance.LogAction(s, "Settlement Approval")))
  {
  }

  protected PendingApprovalSettlementRepository(
    Action<string> logAction,
    DataNamesMapper<TPendingApprovalSettlementDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base(logAction, dataNamesMapper, databaseAccess)
  {
  }

  public IEnumerable<TPendingApprovalSettlementDto> GetPendingAndRecentTransactions()
  {
    return (IEnumerable<TPendingApprovalSettlementDto>) ((BaseDataAccess<TPendingApprovalSettlementDto, int>) this).MapQueryMultiResult(this.GetPendingAndRecentTransactionsProcedureName);
  }

  IEnumerable<PendingApprovalSettlementDto> IPendingApprovalSettlementRepository.GetPendingAndRecentTransactions()
  {
    return (IEnumerable<PendingApprovalSettlementDto>) this.GetPendingAndRecentTransactions();
  }

  public void MarkTransactionRejected(int transactionNumber)
  {
    ((BaseDataAccess<TPendingApprovalSettlementDto, int>) this).DataAccess.ExecuteNonQuery("[dbo].[spFin_PendingApprovalSettlement_MarkTransactionRejected]", new object[2]
    {
      (object) "@TransactionNumber",
      (object) transactionNumber
    });
    ((BaseDataAccess<TPendingApprovalSettlementDto, int>) this).Log($"Rejected transaction {transactionNumber}.");
  }

  public void MarkTransactionApproved(int transactionNumber)
  {
    ((BaseDataAccess<TPendingApprovalSettlementDto, int>) this).DataAccess.ExecuteNonQuery("[dbo].[spFin_PendingApprovalSettlement_MarkTransactionApproved]", new object[2]
    {
      (object) "@TransactionNumber",
      (object) transactionNumber
    });
    ((BaseDataAccess<TPendingApprovalSettlementDto, int>) this).Log($"Approved transaction {transactionNumber}.");
  }

  public void MarkTransactionPending(int transactionNumber)
  {
    ((BaseDataAccess<TPendingApprovalSettlementDto, int>) this).DataAccess.ExecuteNonQuery("[dbo].[spFin_PendingApprovalSettlement_MarkTransactionPending]", new object[2]
    {
      (object) "@TransactionNumber",
      (object) transactionNumber
    });
    ((BaseDataAccess<TPendingApprovalSettlementDto, int>) this).Log($"Submitted transaction {transactionNumber} for approval.");
  }

  public void MarkTransactionBypass(int transactionNumber)
  {
    ((BaseDataAccess<TPendingApprovalSettlementDto, int>) this).DataAccess.ExecuteNonQuery("[dbo].[spFin_PendingApprovalSettlement_MarkTransactionBypass]", new object[2]
    {
      (object) "@TransactionNumber",
      (object) transactionNumber
    });
    ((BaseDataAccess<TPendingApprovalSettlementDto, int>) this).Log($"Marked transaction {transactionNumber} to bypass approval.");
  }

  protected override void ValidateId(int identifier)
  {
    ((BaseDataAccess<TPendingApprovalSettlementDto, int>) this).ValidateIntegerId(identifier);
  }

  public virtual DateTime GetPostDateForGlCompanyIdAccountingPeriod(
    DateTime transactionCreateDate,
    string glCompanyId)
  {
    return DefaultDatabase.ExecuteFunction<bool>("dbo.IsAccountingPeriodValid_GlCompany", new object[4]
    {
      (object) "@TransactionDate",
      (object) transactionCreateDate,
      (object) "@GlCompanyId",
      (object) glCompanyId
    }) ? transactionCreateDate : DateTime.Now;
  }
}
