// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlementDecision.PendingApprovalSettlementDecisionDto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlementDecision;

public class PendingApprovalSettlementDecisionDto : DtoBase<int>
{
  public PendingApprovalSettlementDecisionDto()
  {
  }

  public PendingApprovalSettlementDecisionDto(
    int id,
    int transactionNumber,
    string userName,
    bool isApproved)
  {
    this.Id = id;
    this.TransactionNumber = transactionNumber;
    this.UserName = userName;
    this.IsApproved = isApproved;
  }

  public override int UniqueIdentifier => this.Id;

  [TableFieldMapping("Id")]
  public virtual int Id { get; set; }

  [TableFieldMapping("TransactionNumber")]
  public virtual int TransactionNumber { get; set; }

  [TableFieldMapping("CreateUserGuid")]
  public virtual Guid CreateUserGuid { get; set; }

  [TableFieldMapping("Name_FirstLast")]
  public virtual string UserName { get; set; }

  [TableFieldMapping("CreateDate")]
  public virtual DateTime CreateDate { get; set; }

  [TableFieldMapping("ApprovedRejected")]
  public virtual bool IsApproved { get; set; }
}
