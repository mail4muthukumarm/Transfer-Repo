// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.AgentSync.Models.ComplianceResult
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.AgentSync.Models;

public class ComplianceResult
{
  public object Account_Billing_Contact_Name__c { get; set; }

  public object Accounting_Billing_Contact_Email__c { get; set; }

  public object AccountSource { get; set; }

  public DateTime agentsync__AgentSync_Attempt__c { get; set; }

  public object agentsync__AgentSync_Audit_Log__c { get; set; }

  public bool agentsync__AgentSync_Internal_Account__c { get; set; }

  public object agentsync__AgentSync_Producer_Assignment__c { get; set; }

  public string agentsync__AgentSync_QueuedJobId__c { get; set; }

  public string agentsync__AgentSync_Status__c { get; set; }

  public string agentsync__AgentSync_Status_Icon__c { get; set; }

  public object agentsync__AgentSync_Success__c { get; set; }

  public string agentsync__AgentSync_Tracking__c { get; set; }

  public string agentsync__AgentSync_Transaction_Type__c { get; set; }

  public string agentsync__ID_FEIN__c { get; set; }

  public string agentsync__NAME_COMPANY__c { get; set; }

  public string agentsync__NPN__c { get; set; }

  public object agentsync__Related_Company__c { get; set; }

  public string agentsync__STATE_DOMICILE__c { get; set; }

  public object AnnualRevenue { get; set; }

  public Attributes attributes { get; set; }

  public object BillingAddress { get; set; }

  public object BillingCity { get; set; }

  public object BillingCountry { get; set; }

  public object BillingGeocodeAccuracy { get; set; }

  public object BillingLatitude { get; set; }

  public object BillingLongitude { get; set; }

  public object BillingPostalCode { get; set; }

  public object BillingState { get; set; }

  public object BillingStreet { get; set; }

  public object Business_Email__c { get; set; }

  public string CreatedById { get; set; }

  public DateTime CreatedDate { get; set; }

  public string DBA__c { get; set; }

  public object Description { get; set; }

  public object Division__c { get; set; }

  public object E_O_Carrier__c { get; set; }

  public object E_O_Expiration_Date__c { get; set; }

  public object E_O_Limits__c { get; set; }

  public object Fax { get; set; }

  public string Id { get; set; }

  public object Industry { get; set; }

  public bool IsCustomerPortal { get; set; }

  public bool IsDeleted { get; set; }

  public bool IsPriorityRecord { get; set; }

  public object Jigsaw { get; set; }

  public object JigsawCompanyId { get; set; }

  public object LastActivityDate { get; set; }

  public string LastModifiedById { get; set; }

  public DateTime LastModifiedDate { get; set; }

  public object LastReferencedDate { get; set; }

  public object LastViewedDate { get; set; }

  public object MasterRecordId { get; set; }

  public bool My_Agency__c { get; set; }

  public string Name { get; set; }

  public object NumberOfEmployees { get; set; }

  public object Onboarded_By__c { get; set; }

  public bool Onboarding_Complete__c { get; set; }

  public string OwnerId { get; set; }

  public object ParentId { get; set; }

  public object Phone { get; set; }

  public string PhotoUrl { get; set; }

  public object Principal_Agent__c { get; set; }

  public string Producer_Code__c { get; set; }

  public object ShippingAddress { get; set; }

  public object ShippingCity { get; set; }

  public object ShippingCountry { get; set; }

  public object ShippingGeocodeAccuracy { get; set; }

  public object ShippingLatitude { get; set; }

  public object ShippingLongitude { get; set; }

  public object ShippingPostalCode { get; set; }

  public object ShippingState { get; set; }

  public object ShippingStreet { get; set; }

  public object SicDesc { get; set; }

  public bool Sole_Proprietorship__c { get; set; }

  public DateTime SystemModstamp { get; set; }

  public object Type { get; set; }

  public object Website { get; set; }
}
