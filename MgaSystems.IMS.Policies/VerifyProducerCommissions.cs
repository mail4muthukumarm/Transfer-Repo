// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.VerifyProducerCommissions
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.BusinessObjects;
using MGASystems.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies;

public sealed class VerifyProducerCommissions
{
  private Guid _quoteGuid;
  private readonly Dictionary<Guid, QuoteDetailCommission> _dict;

  public VerifyProducerCommissions(Guid quoteGuid)
  {
    this._dict = new Dictionary<Guid, QuoteDetailCommission>();
    this._quoteGuid = quoteGuid;
    Quote quote = new Quote(quoteGuid);
    ProducerLocation producerLocation = new ProducerLocation(quote.SubmissionGroup.ProducerLocationGuid);
    bool flag = quote.PolicyTypeID == 2;
    int policyTypeId = quote.PolicyTypeID;
    DateTime effectiveDate = quote.EffectiveDate;
    Guid quotingLocationGuid = quote.QuotingLocationGuid;
    try
    {
      foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, "select QuoteDetailID, ProgramID, CompanyLineGuid, ProducerCommission, CompanyCommission from tblQuoteDetails with (nolock) where QuoteGuid=@QG", new object[2]
      {
        (object) "@QG",
        (object) this._quoteGuid
      }).Rows)
      {
        object obj = (object) null;
        CompanyLine companyLine = new CompanyLine(row.Field<Guid>("CompanyLineGuid"));
        if (!row.IsNull("ProgramID"))
          obj = (object) row.Field<int>("ProgramID");
        QuoteDetailCommission detailCommission = new QuoteDetailCommission()
        {
          CurrentProducerCommission = row.IsNull("ProducerCommission") ? 0M : row.Field<Decimal>("ProducerCommission"),
          CompanyCommission = row.IsNull("CompanyCommission") ? 0M : row.Field<Decimal>("CompanyCommission"),
          CalculatedProducerCommission = producerLocation.GetCommission(row.Field<Guid>("CompanyLineGuid"), flag, effectiveDate, (SqlTransaction) null, (object) policyTypeId, RuntimeHelpers.GetObjectValue(obj), quotingLocationGuid)
        };
        detailCommission.CommissionsEqual = Decimal.Compare(detailCommission.CurrentProducerCommission, detailCommission.CalculatedProducerCommission) == 0;
        detailCommission.CompanyLineState = companyLine.CompanyLineState;
        detailCommission.QuoteDetailID = row.Field<int>("QuoteDetailID");
        this._dict.Add(row.Field<Guid>("CompanyLineGuid"), detailCommission);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public bool HasUnequalCommission()
  {
    bool flag;
    try
    {
      foreach (KeyValuePair<Guid, QuoteDetailCommission> keyValuePair in this._dict)
      {
        if (!keyValuePair.Value.CommissionsEqual)
        {
          flag = true;
          goto label_6;
        }
      }
    }
    finally
    {
      Dictionary<Guid, QuoteDetailCommission>.Enumerator enumerator;
      enumerator.Dispose();
    }
    flag = false;
label_6:
    return flag;
  }

  public Dictionary<Guid, QuoteDetailCommission> GatherProducerCommissions() => this._dict;

  public void QuoteDetailProducerCommissionsUpdate()
  {
    try
    {
      foreach (KeyValuePair<Guid, QuoteDetailCommission> keyValuePair in this._dict)
      {
        if (!keyValuePair.Value.CommissionsEqual)
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "Update tblQuoteDetails set ProducerCommission = @PC where QuoteDetailID = @QD", new object[4]
          {
            (object) "@PC",
            (object) keyValuePair.Value.CalculatedProducerCommission,
            (object) "@QD",
            (object) keyValuePair.Value.QuoteDetailID
          });
      }
    }
    finally
    {
      Dictionary<Guid, QuoteDetailCommission>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }
}
