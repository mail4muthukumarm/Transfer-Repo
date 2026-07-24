// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericBusinessObject.GenericBusinessObject
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.BusinessObjects.GenericExposures;
using MGASystems.BusinessObjects.GenericExposures.PolicyEntityTypes;
using MGASystems.Data;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects.GenericBusinessObject;

public class GenericBusinessObject : GenericPolicies
{
  private int _quoteID;

  public GenericBusinessObject(int quoteID)
  {
    this._quoteID = quoteID;
    this.FillPolicies();
  }

  protected virtual void CustomizeGenericData(ref DataSet ds)
  {
  }

  private void FillPolicies()
  {
    DataSet ds = DefaultDatabase.ExecuteDataSet("GetGenericBusinessObjectData", new object[2]
    {
      (object) "@QuoteID",
      (object) this._quoteID
    });
    this.CustomizeGenericData(ref ds);
    DataView dataView1 = new DataView(ds.Tables[0]);
    DataView dataView2 = new DataView(ds.Tables[1]);
    DataView dataView3 = new DataView(ds.Tables[2]);
    DataView dataView4 = new DataView(ds.Tables[3]);
    DataView dataView5 = new DataView(ds.Tables[4]);
    DataView dataView6 = new DataView(ds.Tables[5]);
    DataView dataView7 = new DataView(ds.Tables[6]);
    DataView dataView8 = new DataView(ds.Tables[7]);
    DataView dataView9 = new DataView(ds.Tables[8]);
    try
    {
      foreach (DataRow row1 in dataView1.ToTable().Rows)
      {
        string Description = $"{row1["InsuredPolicyName"].ToString()} (ControlNo: {row1["ControlNo"].ToString()})";
        Guid QuoteGuid = (Guid) row1["QuoteGuid"];
        int QuoteID = (int) row1["QuoteID"];
        MGASystems.BusinessObjects.GenericBusinessObject.GenericBusinessObject genericBusinessObject = this;
        ref MGASystems.BusinessObjects.GenericBusinessObject.GenericBusinessObject local = ref genericBusinessObject;
        GenericPolicyData policy = new GenericPolicyData(Description, QuoteGuid, QuoteID, ref local);
        policy.AddPolicyDataElement(PolicyDataTypeElement.InsuredPolicyName, row1["InsuredPolicyName"].ToString());
        policy.AddPolicyDataElement(PolicyDataTypeElement.EffectiveDate, row1["EffectiveDate"].ToString());
        policy.AddPolicyDataElement(PolicyDataTypeElement.ExpirationDate, row1["ExpirationDate"].ToString());
        policy.AddPolicyDataElement(PolicyDataTypeElement.TransactionCreatedDate, row1["TransactionCreationDate"].ToString());
        policy.AddPolicyDataElement(PolicyDataTypeElement.PolicyType, row1["PolicyType"].ToString());
        policy.AddPolicyDataElement(PolicyDataTypeElement.TransactionType, row1["TransactionType"].ToString());
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row1["PolicyNumber"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row1["PolicyNumber"].ToString(), string.Empty, false) != 0)
          policy.AddPolicyDataElement(PolicyDataTypeElement.PolicyNumber, row1["PolicyNumber"].ToString());
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row1["EndorsementEffectiveDate"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row1["EndorsementEffectiveDate"].ToString(), string.Empty, false) != 0)
          policy.AddPolicyDataElement(PolicyDataTypeElement.EndorsementEffectiveDate, row1["EndorsementEffectiveDate"].ToString());
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row1["CancellationDate"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row1["CancellationDate"].ToString(), string.Empty, false) != 0)
          policy.AddPolicyDataElement(PolicyDataTypeElement.CancellationDate, row1["CancellationDate"].ToString());
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row1["DateBound"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row1["DateBound"].ToString(), string.Empty, false) != 0)
          policy.AddPolicyDataElement(PolicyDataTypeElement.DateBound, row1["DateBound"].ToString());
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row1["DateIssued"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row1["DateIssued"].ToString(), string.Empty, false) != 0)
          policy.AddPolicyDataElement(PolicyDataTypeElement.DateIssued, row1["DateIssued"].ToString());
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row1["EndorsementNumber"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row1["EndorsementNumber"].ToString(), string.Empty, false) != 0)
          policy.AddPolicyDataElement(PolicyDataTypeElement.EndorsementNumber, row1["EndorsementNumber"].ToString());
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row1["ExpiringPolicyNumber"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row1["ExpiringPolicyNumber"].ToString(), string.Empty, false) != 0)
          policy.AddPolicyDataElement(PolicyDataTypeElement.ExpiringPolicyNumber, row1["ExpiringPolicyNumber"].ToString());
        dataView2.RowFilter = $"QuoteID = {RuntimeHelpers.GetObjectValue(row1["QuoteID"])}";
        if (dataView2.Count > 0)
        {
          try
          {
            foreach (DataRow row2 in dataView2.ToTable().Rows)
              policy.AddPolicyEntity(row2, (Guid) row1["QuoteGuid"], PolicyEntityType.Insured);
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        dataView3.RowFilter = $"QuoteID = {RuntimeHelpers.GetObjectValue(row1["QuoteID"])}";
        if (dataView3.Count > 0)
        {
          try
          {
            foreach (DataRow row3 in dataView3.ToTable().Rows)
              policy.AddPolicyEntity(row3, (Guid) row3["CompanyLocationGuid"], PolicyEntityType.CompanyLocation);
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        dataView4.RowFilter = $"QuoteID = {RuntimeHelpers.GetObjectValue(row1["QuoteID"])}";
        if (dataView4.Count > 0)
        {
          try
          {
            foreach (DataRow row4 in dataView4.ToTable().Rows)
              policy.AddPolicyEntity(row4, (Guid) row4["CompanyGuid"], PolicyEntityType.Company);
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        dataView7.RowFilter = $"QuoteID = {RuntimeHelpers.GetObjectValue(row1["QuoteID"])}";
        if (dataView7.Count > 0)
        {
          try
          {
            foreach (DataRow row5 in dataView7.ToTable().Rows)
              policy.AddPolicyEntity(row5, (Guid) row5["QuotingLocationGuid"], PolicyEntityType.QuotingLocation);
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        dataView8.RowFilter = $"QuoteID = {RuntimeHelpers.GetObjectValue(row1["QuoteID"])}";
        if (dataView8.Count > 0)
        {
          try
          {
            foreach (DataRow row6 in dataView8.ToTable().Rows)
              policy.AddPolicyEntity(row6, (Guid) row6["IssuingLocationGuid"], PolicyEntityType.IssuingLocation);
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        dataView8.RowFilter = $"QuoteID = {RuntimeHelpers.GetObjectValue(row1["QuoteID"])}";
        if (dataView8.Count > 0)
        {
          try
          {
            foreach (DataRow row7 in dataView8.ToTable().Rows)
              policy.AddPolicyEntity(row7, (Guid) row7["IssuingLocationGuid"], PolicyEntityType.IssuingLocation);
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        dataView9.RowFilter = $"QuoteID = {RuntimeHelpers.GetObjectValue(row1["QuoteID"])}";
        if (dataView9.Count > 0)
        {
          try
          {
            foreach (DataRow row8 in dataView9.ToTable().Rows)
              policy.AddPolicyEntity(row8, (Guid) row8["AdditionalInterestGuid"], PolicyEntityType.AdditionalInterest);
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        this.AddPolicy((IPolicyData) policy);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
