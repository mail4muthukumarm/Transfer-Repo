// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.Model.IPendingApprovalSettlementModel
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.Utility;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.Model;

public interface IPendingApprovalSettlementModel : 
  ITrackChanges,
  IValidateModel,
  IMvcModel,
  IValidate,
  ISave
{
  string PayeeName { get; }

  string PayeeBank { get; }

  string RoutingNumber { get; }

  int TransactionNumber { get; }

  int? VoidingTransactionNumber { get; }

  string CreateByUserName { get; }

  double PaymentAmount { get; }

  int InvoiceIncludedCount { get; }

  string ApproveRejectedBy { get; }

  bool UserApprove { get; set; }

  bool UserReject { get; set; }

  bool IsRejected { get; }

  bool IsApproved { get; }

  DateTime StatusDate { get; }

  string PaymentMethodName { get; }

  DateTime CreateDate { get; }
}
