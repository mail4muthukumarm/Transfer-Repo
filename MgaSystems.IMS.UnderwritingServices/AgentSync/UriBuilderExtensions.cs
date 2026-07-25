// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.AgentSync.UriBuilderExtensions
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;
using System.Collections.Specialized;
using System.Web;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.AgentSync;

public static class UriBuilderExtensions
{
  public static string GetSalesforceQuery(
    this UriBuilderExtensions.SalesforceQueryType queryType,
    string npn,
    string state)
  {
    switch (queryType)
    {
      case UriBuilderExtensions.SalesforceQueryType.GetAllContacts:
        return "SELECT Id, Name, AccountId, CreatedDate, LastModifiedDate, Email, Phone, agentsync__NPN__c, agentsync__DATE_BIRTH__c, agentsync__SSN__c, agentsync__NAME_FIRST__c, agentsync__NAME_MIDDLE__c, agentsync__NAME_LAST__c, agentsync__AgentSync_Status__c, agentsync__AgentSync_Tracking__c, agentsync__AgentSync_Attempt__c, agentsync__AgentSync_Success__c FROM Contact";
      case UriBuilderExtensions.SalesforceQueryType.GetLicenseByNPN:
        return $"SELECT Id, CreatedDate, LastModifiedDate, agentsync__NPN__c, agentsync__Related_Producer_External_Id__c, agentsync__ACTIVE__c, agentsync__LICENSE_NUM__c, agentsync__LICENSE_CLASS__c FROM agentsync__License__c WHERE agentsync__NPN__c = '{npn}'";
      case UriBuilderExtensions.SalesforceQueryType.GetAllAccounts:
        return "SELECT Id, Name, agentsync__NPN__c FROM Account";
      case UriBuilderExtensions.SalesforceQueryType.GetAppointmentsByNPN:
        return $"SELECT Id, CreatedDate, LastModifiedDate, agentsync__Company_Name__c, agentsync__State_Code__c, agentsync__COCODE__c, agentsync__Status__c, agentsync__NPN__c, agentsync__Related_Producer_External_Id__c FROM agentsync__Carrier_Appointment__c WHERE agentsync__NPN__c = '{npn}'";
      case UriBuilderExtensions.SalesforceQueryType.GetContactByNpn:
        return $"SELECT Id, AccountId, CreatedDate, LastModifiedDate, Email, Phone, agentsync__NPN__c, agentsync__DATE_BIRTH__c, agentsync__SSN__c, agentsync__NAME_FIRST__c, agentsync__NAME_MIDDLE__c, agentsync__NAME_LAST__c, agentsync__AgentSync_Status__c, agentsync__AgentSync_Tracking__c, agentsync__AgentSync_Attempt__c, agentsync__AgentSync_Success__c FROM Contact WHERE agentsync__NPN__c = '{npn}'";
      case UriBuilderExtensions.SalesforceQueryType.GetLOAbyNpn:
        return $"SELECT Id, CreatedDate, LastModifiedDate, agentsync__LOA__c, agentsync__Status__c, agentsync__Categories__c, agentsync__State_Code__c FROM agentsync__LINE_OF_AUTHORITY__c WHERE agentsync__NPN__c = '{npn}'";
      case UriBuilderExtensions.SalesforceQueryType.GetNIPRByNPN:
        return $"SELECT Id, CreatedDate, LastModifiedDate, agentsync__ADDR_TYPE__c, agentsync__ADDR_LINE_1__c, agentsync__NAME_CITY__c, agentsync__NAME_STATE__c, agentsync__ZIP__c FROM agentsync__NIPR_Address__c WHERE agentsync__NPN__c = '{npn}'";
      case UriBuilderExtensions.SalesforceQueryType.GetLicenseByNPNState:
        if (state == null)
          throw new ArgumentNullException(nameof (state), "State parameter is required for this query type.");
        return $"SELECT Id, CreatedDate, LastModifiedDate, agentsync__NPN__c, agentsync__Related_Producer_External_Id__c, agentsync__ACTIVE__c, agentsync__LICENSE_NUM__c, agentsync__LICENSE_CLASS__c, agentsync__RESIDENCY_STATUS__c, agentsync__DATE_EXPIRE_LICENSE__c, agentsync__State__c FROM agentsync__License__c WHERE agentsync__NPN__c = '{npn}' AND agentsync__ACTIVE__c = 'Yes' AND agentsync__State__c = '{state}'";
      default:
        throw new ArgumentException("Unsupported Salesforce query type");
    }
  }

  public static UriBuilder SetSalesforceQuery(
    this UriBuilder uriBuilder,
    UriBuilderExtensions.SalesforceQueryType queryType,
    string npn,
    string state = null)
  {
    string salesforceQuery = queryType.GetSalesforceQuery(npn, state);
    NameValueCollection queryString = HttpUtility.ParseQueryString(uriBuilder.Query);
    queryString["q"] = salesforceQuery;
    uriBuilder.Query = queryString.ToString();
    return uriBuilder;
  }

  public enum SalesforceQueryType
  {
    GetAllContacts,
    GetLicenseByNPN,
    GetAllAccounts,
    GetAppointmentsByNPN,
    GetContactByNpn,
    GetLOAbyNpn,
    GetNIPRByNPN,
    GetLicenseByNPNState,
  }
}
