// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlement.IPendingApprovalSettlementRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlement;

public interface IPendingApprovalSettlementRepository
{
  IEnumerable<PendingApprovalSettlementDto> GetPendingAndRecentTransactions();

  void MarkTransactionRejected(int transactionNumber);

  void MarkTransactionApproved(int transactionNumber);

  void MarkTransactionPending(int transactionNumber);

  void MarkTransactionBypass(int transactionNumber);

  DateTime GetPostDateForGlCompanyIdAccountingPeriod(
    DateTime transactionCreateDate,
    string glCompanyId);
}
