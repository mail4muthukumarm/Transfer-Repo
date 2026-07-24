// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.Model.PendingApprovalSettlementGridModel
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlement;
using MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlementDecision;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.Model;

public class PendingApprovalSettlementGridModel : 
  UltraGridDataBulkEditModel<IPendingApprovalSettlementModel>
{
  private readonly IPendingApprovalSettlementDecisionRepository _decisionRepository = ObjectFactory.Instance.CreateObjectAs<IPendingApprovalSettlementDecisionRepository>();
  private readonly IPendingApprovalSettlementRepository _pendingSettlementRepository = ObjectFactory.Instance.CreateObjectAs<IPendingApprovalSettlementRepository>();

  protected override IPendingApprovalSettlementModel[] GetDisplayItems()
  {
    IEnumerable<PendingApprovalSettlementDto> recentTransactions = this._pendingSettlementRepository.GetPendingAndRecentTransactions();
    PendingApprovalSettlementDecisionDto[] decisionDtos = this.GetDecisionDtos(recentTransactions);
    return recentTransactions.Select<PendingApprovalSettlementDto, IPendingApprovalSettlementModel>((Func<PendingApprovalSettlementDto, IPendingApprovalSettlementModel>) (settlementDto => ObjectFactory.Instance.CreateObjectAs<IPendingApprovalSettlementModel>((object) this._decisionRepository, (object) this._pendingSettlementRepository, (object) settlementDto, (object) ((IEnumerable<PendingApprovalSettlementDecisionDto>) decisionDtos).Where<PendingApprovalSettlementDecisionDto>((Func<PendingApprovalSettlementDecisionDto, bool>) (decision => decision.TransactionNumber == settlementDto.TransactionNumber)).ToArray<PendingApprovalSettlementDecisionDto>()))).ToArray<IPendingApprovalSettlementModel>();
  }

  private PendingApprovalSettlementDecisionDto[] GetDecisionDtos(
    IEnumerable<PendingApprovalSettlementDto> pendingSettlementDtos)
  {
    return this._decisionRepository.GetAllOnAndAfterDate(pendingSettlementDtos.Any<PendingApprovalSettlementDto>() ? pendingSettlementDtos.Min<PendingApprovalSettlementDto, DateTime>((Func<PendingApprovalSettlementDto, DateTime>) (dto => dto.CreatedDate)) : DateTime.Now);
  }
}
