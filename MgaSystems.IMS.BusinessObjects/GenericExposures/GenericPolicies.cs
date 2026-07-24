// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericExposures.GenericPolicies
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.BusinessObjects.GenericExposures.PolicyEntityTypes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

#nullable disable
namespace MGASystems.BusinessObjects.GenericExposures;

public abstract class GenericPolicies : INotifyPropertyChanged
{
  private BindingList<IPolicyData> _policies;

  public event PropertyChangedEventHandler PropertyChanged;

  public BindingList<IPolicyData> Policies
  {
    get
    {
      this._policies.AllowEdit = false;
      return this._policies;
    }
  }

  protected void AddPolicy(IPolicyData policy)
  {
    if (this._policies == null)
      this._policies = new BindingList<IPolicyData>();
    if (this._policies.Contains(policy))
      throw new InvalidOperationException($"Item already exists in the collection. QuoteID: {policy.QuoteID}; QuoteGUID: {policy.QuoteGuid}; Description: {policy.Description}");
    this._policies.Add(policy);
    // ISSUE: reference to a compiler-generated field
    PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
    if (propertyChangedEvent == null)
      return;
    propertyChangedEvent((object) this, new PropertyChangedEventArgs(nameof (GenericPolicies)));
  }

  public string QueryPolicyData(int QuoteID, PolicyDataTypeElement policyDataTypeElement)
  {
    string str = "";
    IPolicyData policyData = (IPolicyData) null;
    try
    {
      foreach (IPolicyData policy in (Collection<IPolicyData>) this.Policies)
      {
        if (policy.QuoteID == QuoteID)
        {
          policyData = policy;
          break;
        }
      }
    }
    finally
    {
      IEnumerator<IPolicyData> enumerator;
      enumerator?.Dispose();
    }
    if (policyData != null)
    {
      try
      {
        foreach (PolicyDataElement policyDataElement in (Collection<PolicyDataElement>) policyData.PolicyDataElements)
        {
          if (policyDataElement.DataElementType == policyDataTypeElement)
            str = policyDataElement.Description;
        }
      }
      finally
      {
        IEnumerator<PolicyDataElement> enumerator;
        enumerator?.Dispose();
      }
    }
    return str;
  }

  public string QueryPolicyEntityData(
    int QuoteID,
    Guid EntityGuid,
    PolicyEntityType EntityType,
    PolicyEntityTypeElement EntityTypeElement)
  {
    string str = "";
    IPolicyData policyData = (IPolicyData) null;
    try
    {
      foreach (IPolicyData policy in (Collection<IPolicyData>) this.Policies)
      {
        if (policy.QuoteID == QuoteID)
        {
          policyData = policy;
          break;
        }
      }
    }
    finally
    {
      IEnumerator<IPolicyData> enumerator;
      enumerator?.Dispose();
    }
    if (policyData != null)
    {
      IPolicyEntity policyEntity1 = (IPolicyEntity) null;
      try
      {
        foreach (IPolicyEntity policyEntity2 in (Collection<IPolicyEntity>) policyData.PolicyEntities)
        {
          if (policyEntity2.EntityGuid == EntityGuid & policyEntity2.EntityType == EntityType)
          {
            policyEntity1 = policyEntity2;
            break;
          }
        }
      }
      finally
      {
        IEnumerator<IPolicyEntity> enumerator;
        enumerator?.Dispose();
      }
      if (policyEntity1 != null)
      {
        try
        {
          foreach (PolicyEntityElement policyEntityElement in (Collection<PolicyEntityElement>) policyEntity1.PolicyEntityElements)
          {
            if (policyEntityElement.ElementType == EntityTypeElement)
            {
              str = policyEntityElement.Description;
              break;
            }
          }
        }
        finally
        {
          IEnumerator<PolicyEntityElement> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    return str;
  }
}
