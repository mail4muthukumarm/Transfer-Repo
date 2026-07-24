// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlementDecision.IPendingApprovalSettlementDecisionRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlementDecision;

public interface IPendingApprovalSettlementDecisionRepository : 
  ICreateRepository<PendingApprovalSettlementDecisionDto, int>,
  ICreateRepository,
  IExecuteTransaction,
  IGetAllRepository<PendingApprovalSettlementDecisionDto, int>,
  IGetAllRepository,
  IGetByIdRepository<PendingApprovalSettlementDecisionDto, int>,
  IGetByIdRepository
{
  PendingApprovalSettlementDecisionDto[] GetAllOnAndAfterDate(DateTime oldestCreateDate);

  PendingApprovalSettlementDecisionDto[] GetForTransactionNumber(int transactionNumber);
}
