// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_Claimant
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

[Override(typeof (Claimant))]
internal class Fortegra_Claimant : Claimant
{
  public Fortegra_Claimant(Claim owner)
    : base(owner)
  {
  }

  public Fortegra_Claimant(
    Claim owner,
    Guid claimantGuid,
    Guid enteredByUserGuid,
    string enteredByUserName,
    DateTime enteredOn,
    Guid modifiedByUserGuid,
    string modifiedByUserName,
    DateTime lastModified)
    : base(owner, claimantGuid, enteredByUserGuid, enteredByUserName, enteredOn, modifiedByUserGuid, modifiedByUserName, lastModified)
  {
  }

  protected override void CloseReserves(DateTime closeDate)
  {
    List<Fortegra_ReservePayment> fortegraReservePaymentList = new List<Fortegra_ReservePayment>();
    List<int> intList1 = new List<int>();
    foreach (Fortegra_ReservePayment reservesAndPayment1 in (Collection<PaymentReserve>) this.ReservesAndPayments)
    {
      Decimal paymentAmount = 0M;
      int? reservePaymentId = reservesAndPayment1.ReservePaymentId;
      int num1 = reservePaymentId.Value;
      if (reservesAndPayment1.EntryType == PaymentReserveType.Reserve)
      {
        reservePaymentId = reservesAndPayment1.ReservePaymentId;
        if (reservePaymentId.HasValue && !intList1.Contains(num1))
        {
          intList1.Add(num1);
          foreach (Fortegra_ReservePayment reservesAndPayment2 in (Collection<PaymentReserve>) this.ReservesAndPayments)
          {
            if (reservesAndPayment2.EntryType == PaymentReserveType.Reserve && reservesAndPayment1.IsMatchingPayment((PaymentReserve) reservesAndPayment2))
            {
              List<int> intList2 = intList1;
              reservePaymentId = reservesAndPayment2.ReservePaymentId;
              int num2 = reservePaymentId.Value;
              intList2.Add(num2);
              paymentAmount += reservesAndPayment2.ReservePaymentAmount;
            }
          }
          Fortegra_ReservePayment fortegraReservePayment = reservesAndPayment1.FromClaimReservePayment(reservesAndPayment1);
          fortegraReservePaymentList.Add(fortegraReservePayment.BringDownReserve(paymentAmount, closeDate));
        }
      }
    }
    foreach (Fortegra_ReservePayment fortegraReservePayment in fortegraReservePaymentList)
    {
      if (fortegraReservePayment.ReservePaymentAmount != 0M)
        this.ReservesAndPayments.Add((PaymentReserve) fortegraReservePayment);
    }
  }

  public override void LoadReservesPayments()
  {
    this.ReservesAndPayments.Clear();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.Fortegra_spClaims_GetClaimantReservesPayments", new object[4]
    {
      (object) "@ClaimId",
      (object) this.Owner.ClaimId,
      (object) "@ClaimantGuid",
      (object) this.ClaimantGuid
    });
    DataTable source = DefaultDatabase.ExecuteDataTable("dbo.Fortegra_GetCustomReservePaymentData", new object[2]
    {
      (object) "@claimantGuid",
      (object) this.ClaimantGuid
    });
    if (dataTable == null || dataTable.Rows.Count <= 0)
      return;
    foreach (DataRow row1 in (InternalDataCollectionBase) dataTable.Rows)
    {
      Fortegra_ReservePayment fortegraReservePayment = new Fortegra_ReservePayment(row1.Field<int>("ResPayId"), row1.Field<int>("ClaimId"), this.ClaimantGuid, row1.Field<DateTime>("DateCreated"), row1.Field<Guid>("CreatedbyGuid"), row1.Field<string>("CreatedBy"), row1.Field<bool>("IsPayment") ? PaymentReserveType.Payment : PaymentReserveType.Reserve, row1.Field<bool>("IsRecoveryType"), !Utility.IsNull(row1["PaymentReturn"]) && row1.Field<bool>("PaymentReturn"), row1["PaymentReturn_ResPayId"].Equals((object) DBNull.Value) ? new int?() : row1.Field<int?>("PaymentReturn_ResPayId"), row1.Field<int>("TransactNum"));
      fortegraReservePayment.CoverageTypeId = row1.Field<int?>("CoverageTypeId");
      fortegraReservePayment.CoverageType = Convert.ToString(row1.Field<object>("CoverageType"));
      fortegraReservePayment.CoverageTypeDescriptionId = row1.Field<int?>("CoverageTypeDescriptionId");
      fortegraReservePayment.CoverageTypeDescription = Convert.ToString(row1.Field<object>("CoverageTypeDescription"));
      fortegraReservePayment.ReservePaymentTypeId = row1.Field<int>("ResPayTypeId");
      fortegraReservePayment.ReservePaymentType = Convert.ToString(row1.Field<object>("ResPayType"));
      fortegraReservePayment.ReservePaymentSubTypeId = row1.Field<int?>("ResPaySubTypeId");
      fortegraReservePayment.ReservePaymentSubType = Convert.ToString(row1.Field<object>("ResPaySubType"));
      fortegraReservePayment.ReservePaymentAmount = row1.Field<Decimal>("ResPayAmount");
      fortegraReservePayment.Comments = Convert.ToString(row1.Field<object>("Comments"));
      if (row1["PayeeGuid"] != DBNull.Value)
      {
        fortegraReservePayment.PayeeGuid = row1.Field<Guid>("PayeeGuid");
        fortegraReservePayment.PayeeName = row1["PayeeName"].ToString();
      }
      fortegraReservePayment.IsPaymentReduction = row1.Field<bool>("IsPaymentReduction");
      fortegraReservePayment.IsVoid = row1.Field<bool>("Void");
      if (source != null)
      {
        foreach (DataRow row2 in source.AsEnumerable())
        {
          if (row2.Field<int>("ResPayId") == row1.Field<int>("ResPayId"))
          {
            row2["ChildLineGuid"].ToString();
            fortegraReservePayment.ChildLineGuid = row2.Field<Guid>("ChildLineGuid");
            fortegraReservePayment.ChildLineDesc = row2["ChildLineDesc"].ToString();
          }
        }
      }
      this.ReservesAndPayments.Add((PaymentReserve) fortegraReservePayment);
    }
  }
}
