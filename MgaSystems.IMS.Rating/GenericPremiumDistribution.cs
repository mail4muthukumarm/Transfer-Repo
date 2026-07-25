// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.GenericPremiumDistribution
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.BusinessObjects;
using MGASystems.Common.Enums;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class GenericPremiumDistribution
{
  private Guid _quoteGuid;
  private Quote _quote;

  public GenericPremiumDistribution(Guid quoteGuid)
  {
    this._quoteGuid = quoteGuid;
    this._quote = new Quote(quoteGuid);
  }

  public Dictionary<string, GenericPremiumCharges> GetPremiumCharges()
  {
    Dictionary<string, GenericPremiumCharges> premiumCharges = new Dictionary<string, GenericPremiumCharges>();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT StateID, ChargeCode, AnnualAmount, EndorsementCalcType, BillAmount, Factor  FROM tblGenericPremiumDistribution WHERE QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) this._quoteGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        string endCalcTyype = row["EndorsementCalcType"].ToString();
        string key = $"{row["StateID"].ToString()}/{row["ChargeCode"].ToString()}";
        Decimal num1 = 0M;
        Decimal num2 = 0M;
        if (row["BillAmount"] != DBNull.Value)
          num1 = Conversions.ToDecimal(row["BillAmount"]);
        if (row["AnnualAmount"] != DBNull.Value)
          num2 = Conversions.ToDecimal(row["AnnualAmount"]);
        if (premiumCharges.ContainsKey(key))
        {
          GenericPremiumCharges genericPremiumCharges = premiumCharges[key];
          genericPremiumCharges.BilledAmount = Decimal.Add(genericPremiumCharges.BilledAmount, num1);
          genericPremiumCharges.AnnualAmount = Decimal.Add(genericPremiumCharges.AnnualAmount, num2);
        }
        else
        {
          Decimal factor = 1M;
          if (row["Factor"] != DBNull.Value)
            factor = Conversions.ToDecimal(row["Factor"]);
          GenericPremiumCharges genericPremiumCharges = new GenericPremiumCharges(row["StateID"].ToString(), Conversions.ToInteger(row["ChargeCode"]), num2, endCalcTyype, factor, num1);
          premiumCharges.Add(key, genericPremiumCharges);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return premiumCharges;
  }

  public List<GenericCancellationPremiumCharges> GetCancellationPremiumCharges()
  {
    if (this._quote.QuoteStatus != QuoteStatus.PendingCancellation)
      throw new InvalidOperationException("ProcessCancellationPremiumCharges should be only invoked on pending cancellations");
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetGenericCancellationPremiumChargeData", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid
    });
    List<GenericCancellationPremiumCharges> cancellationPremiumChargesList = new List<GenericCancellationPremiumCharges>();
    List<GenericCancellationPremiumCharges> cancellationPremiumCharges1;
    if (dataTable.Rows.Count == 0)
    {
      cancellationPremiumCharges1 = cancellationPremiumChargesList;
    }
    else
    {
      int num = this._quote.IsEndorsement ? 1 : 0;
      DateTime expirationDate = this._quote.ExpirationDate;
      int days = this._quote.ExpirationDate.Subtract(this._quote.EffectiveDate).Days;
      DateTime endorsementEffective = this._quote.EndorsementEffective;
      try
      {
        foreach (DataRow row in dataTable.Rows)
        {
          GenericCancellationPremiumCharges cancellationPremiumCharges2 = new GenericCancellationPremiumCharges(row["StateID"].ToString(), Conversions.ToInteger(row["ChargeCode"]), Conversions.ToDecimal(row["AnnualAmount"]), Conversions.ToDecimal(row["FinalPremium"]));
          cancellationPremiumChargesList.Add(cancellationPremiumCharges2);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      cancellationPremiumCharges1 = cancellationPremiumChargesList;
    }
    return cancellationPremiumCharges1;
  }
}
