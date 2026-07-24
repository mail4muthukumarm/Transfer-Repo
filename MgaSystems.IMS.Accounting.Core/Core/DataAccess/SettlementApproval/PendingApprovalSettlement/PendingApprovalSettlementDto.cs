// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlement.PendingApprovalSettlementDto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.SettlementApproval.PendingApprovalSettlement;

public class PendingApprovalSettlementDto : DtoBase<int>
{
  public override int UniqueIdentifier => this.TransactionNumber;

  [TableFieldMapping("TransactNum")]
  public virtual int TransactionNumber { get; set; }

  [TableFieldMapping("VoidedBy")]
  public virtual int VoidedByTransactionNumber { get; set; }

  [TableFieldMapping("IsApproved")]
  public virtual bool IsApproved { get; set; }

  [TableFieldMapping("GlCompanyId")]
  public virtual string GeneralLedgerCompanyId { get; set; }

  [TableFieldMapping("IsRejected")]
  public virtual bool IsRejected { get; set; }

  [TableFieldMapping("StatusDate")]
  public virtual DateTime StatusDate { get; set; }

  [TableFieldMapping("PostDate")]
  public virtual DateTime PostDate { get; set; }

  [TableFieldMapping("Created")]
  public virtual DateTime CreatedDate { get; set; }

  [TableFieldMapping("PayeeName")]
  public virtual string PayeeName { get; set; }

  [TableFieldMapping("PayMethodId")]
  public virtual char PaymentMethodId { get; set; }

  [TableFieldMapping("RoutingNumber")]
  public virtual string RoutingNumber { get; set; }

  [TableFieldMapping("BankName")]
  public virtual string BankName { get; set; }

  [TableFieldMapping("Name_FirstLast")]
  public virtual string CreatedByUserName { get; set; }

  [TableFieldMapping("UserGuid")]
  public virtual Guid CreateByUserGuid { get; set; }

  [TableFieldMapping("PaymentAmount")]
  public virtual double PaymentAmount { get; set; }

  [TableFieldMapping("InvoiceCount")]
  public virtual int InvoiceCount { get; set; }
}
