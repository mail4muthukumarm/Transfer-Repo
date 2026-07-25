// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_ReservePayment
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims;
using MgaSystems.Ims.Fortegra.Properties;
using System;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

[Override(typeof (PaymentReserve))]
public class Fortegra_ReservePayment : PaymentReserve
{
  internal Guid ChildLineGuid { get; set; }

  internal string ChildLineDesc { get; set; }

  internal int PaymentTypeId { get; set; }

  internal int TransactNum { get; set; }

  public Fortegra_ReservePayment(PaymentReserveType entryType)
    : base(entryType)
  {
  }

  public Fortegra_ReservePayment(
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
    : base(reservePaymentId, claimId, claimantGuid, dateCreated, createdByGuid, createdBy, entryType, isRecovery, isPaymentReturn, paymentReturn_ReservePaymentId)
  {
  }

  public Fortegra_ReservePayment(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    string comments,
    Decimal reservePaymentAmount)
    : base(entryType, reservePaymentTypeId, reservePaymentType, comments, reservePaymentAmount)
  {
  }

  public Fortegra_ReservePayment(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    string comments,
    Decimal reservePaymentAmount,
    Guid payeeGuid,
    string payeeName)
    : base(entryType, reservePaymentTypeId, reservePaymentType, comments, reservePaymentAmount, payeeGuid, payeeName)
  {
  }

  public Fortegra_ReservePayment(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    int? reservePaymentSubTypeId,
    string reservePaymentSubType,
    string comments,
    Decimal reservePaymentAmount)
    : base(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, comments, reservePaymentAmount)
  {
  }

  public Fortegra_ReservePayment(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    int? reservePaymentSubTypeId,
    string reservePaymentSubType,
    string comments,
    Decimal reservePaymentAmount,
    Guid payeeGuid,
    string payeeName)
    : base(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, comments, reservePaymentAmount, payeeGuid, payeeName)
  {
  }

  public Fortegra_ReservePayment(
    PaymentReserveType entryType,
    int reservePaymentTypeId,
    string reservePaymentType,
    int? reservePaymentSubTypeId,
    string reservePaymentSubType,
    int? coverageTypeId,
    string coverageType,
    string comments,
    Decimal reservePaymentAmount)
    : base(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, coverageTypeId, coverageType, comments, reservePaymentAmount)
  {
  }

  public Fortegra_ReservePayment(
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
    : base(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, coverageTypeId, coverageType, coverageTypeDescriptionId, coverageTypeDescription, comments, reservePaymentAmount)
  {
  }

  public Fortegra_ReservePayment(
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
    : base(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, coverageTypeId, coverageType, comments, reservePaymentAmount, payeeGuid, payeeName)
  {
  }

  public Fortegra_ReservePayment(
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
    : base(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, coverageTypeId, coverageType, coverageTypeDescriptionId, coverageTypeDescription, comments, reservePaymentAmount, payeeGuid, payeeName, isRecoveryType)
  {
  }

  public Fortegra_ReservePayment(
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
    : base(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, coverageTypeId, coverageType, coverageTypeDescriptionId, coverageTypeDescription, comments, reservePaymentAmount, payeeGuid, payeeName, isRecoveryType, isPaymentReturn, paymentReturn_ReservePaymentId)
  {
  }

  public Fortegra_ReservePayment(
    int reservePaymentId,
    int claimId,
    Guid claimantGuid,
    DateTime dateCreated,
    Guid createdByGuid,
    string createdBy,
    PaymentReserveType entryType,
    bool isRecovery,
    bool isPaymentReturn,
    int? paymentReturn_ReservePaymentId,
    int transactNum)
    : base(reservePaymentId, claimId, claimantGuid, dateCreated, createdByGuid, createdBy, entryType, isRecovery, isPaymentReturn, paymentReturn_ReservePaymentId)
  {
    this.TransactNum = transactNum;
  }

  public Fortegra_ReservePayment(
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
    bool IsRecoveryType,
    Guid childLineGuid,
    string childLineDescription)
    : base(entryType, reservePaymentTypeId, reservePaymentType, reservePaymentSubTypeId, reservePaymentSubType, coverageTypeId, coverageType, coverageTypeDescriptionId, coverageTypeDescription, comments, reservePaymentAmount, Guid.Empty, string.Empty, IsRecoveryType, false, new int?())
  {
    this.ChildLineGuid = childLineGuid;
    this.ChildLineDesc = childLineDescription;
  }

  public override bool IsMatchingPayment(PaymentReserve payment)
  {
    Fortegra_ReservePayment fortegraReservePayment = (Fortegra_ReservePayment) payment;
    if (fortegraReservePayment.ReservePaymentTypeId == this.ReservePaymentTypeId)
    {
      int? paymentSubTypeId = fortegraReservePayment.ReservePaymentSubTypeId;
      int? nullable1 = this.ReservePaymentSubTypeId;
      if (paymentSubTypeId.GetValueOrDefault() == nullable1.GetValueOrDefault() & paymentSubTypeId.HasValue == nullable1.HasValue)
      {
        nullable1 = fortegraReservePayment.CoverageTypeId;
        int? nullable2 = this.CoverageTypeId;
        if (nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() & nullable1.HasValue == nullable2.HasValue)
        {
          nullable2 = fortegraReservePayment.CoverageTypeDescriptionId;
          nullable1 = this.CoverageTypeDescriptionId;
          if (nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() & nullable2.HasValue == nullable1.HasValue)
          {
            nullable1 = fortegraReservePayment.ReservePaymentId;
            nullable2 = this.ReservePaymentId;
            if (!(nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() & nullable1.HasValue == nullable2.HasValue))
              return fortegraReservePayment.ChildLineDesc == this.ChildLineDesc;
          }
        }
      }
    }
    return false;
  }

  protected override void SaveNew()
  {
    base.SaveNew();
    this.SetChildLine();
  }

  protected override void SaveNew(string procedureName, params object[] sprocAddedArgs)
  {
    base.SaveNew(procedureName, sprocAddedArgs);
    this.SetChildLine();
  }

  public Fortegra_ReservePayment BringDownReserve(Decimal paymentAmount, DateTime closeDate)
  {
    if (this.EntryType != PaymentReserveType.Reserve)
      throw new InvalidReservePaymentTypeException(Resources.INVALID_RESERVEPAYMENT_EXCEPTION1);
    Fortegra_ReservePayment fortegraReservePayment = new Fortegra_ReservePayment(this.EntryType, this.ReservePaymentTypeId, this.ReservePaymentType, this.ReservePaymentSubTypeId, this.ReservePaymentSubType, this.CoverageTypeId, this.CoverageType, this.CoverageTypeDescriptionId, this.CoverageTypeDescription, this.Comments, this.ReservePaymentAmount, this.IsRecovery, this.ChildLineGuid, this.ChildLineDesc);
    fortegraReservePayment.DateCreated = closeDate;
    fortegraReservePayment.ReservePaymentAmount = (fortegraReservePayment.ReservePaymentAmount + paymentAmount) * -1M;
    return fortegraReservePayment;
  }

  public Fortegra_ReservePayment FromClaimReservePayment(Fortegra_ReservePayment value)
  {
    return new Fortegra_ReservePayment(value.EntryType, value.ReservePaymentTypeId, value.ReservePaymentType, value.ReservePaymentSubTypeId, value.ReservePaymentSubType, value.CoverageTypeId, value.CoverageType, value.CoverageTypeDescriptionId, value.CoverageTypeDescription, value.Comments, value.ReservePaymentAmount, value.IsRecovery, value.ChildLineGuid, value.ChildLineDesc);
  }

  private void SetChildLine()
  {
    DefaultDatabase.ExecuteNonQuery("Fortegra_InsertCustomReservePaymentData", new object[6]
    {
      (object) "@ResPayId",
      (object) this.ReservePaymentId,
      (object) "@ChildLineGuid",
      (object) this.ChildLineGuid,
      (object) "@PaymentTypeId",
      (object) this.PaymentTypeId
    });
  }
}
