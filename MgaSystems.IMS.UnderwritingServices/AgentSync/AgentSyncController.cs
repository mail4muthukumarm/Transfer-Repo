// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.AgentSync.AgentSyncController
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.AgentSync.Models;
using MgaSystems.IMS.UnderwritingServices.AgentSync.ServiceObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.AgentSync;

public class AgentSyncController
{
  private static readonly HttpClient _httpClient = new HttpClient();
  private string _authorizationUri;
  private MgaSystems.IMS.UnderwritingServices.AgentSync.ServiceObjects.Token _authToken;
  private string _clientId;
  private string _clientSecret;
  private Action<Exception> _errorHandlingAction;
  private Action<string> _logAction;
  private Uri _serviceUri;

  public bool Initialized { get; set; }

  public void CheckControllerInitialized()
  {
    if (!this.Initialized)
      throw new InvalidOperationException("Cannot invoke API methods without first initializing the controller.");
  }

  public async Task<string> GetAddressesAsync(string addressUrl)
  {
    return await this.GetAddressesAsync(this._serviceUri, addressUrl);
  }

  public async Task<string> GetAddressesAsync(Uri endpointAddress, string addressUrl)
  {
    return await this.GetJsonResultAsync(new UriBuilder(new Uri(endpointAddress, addressUrl)).Uri.AbsoluteUri);
  }

  public async Task<string> GetAppointmentsAsync(string npns)
  {
    return await this.GetAppointmentsAsync(this._serviceUri, npns);
  }

  public async Task<string> GetAppointmentsAsync(Uri serviceUri, string npn)
  {
    UriBuilder uriBuilder = new UriBuilder(new Uri(serviceUri, "query"));
    uriBuilder.SetSalesforceQuery(UriBuilderExtensions.SalesforceQueryType.GetAppointmentsByNPN, npn);
    return await this.GetJsonResultAsync(uriBuilder.Uri.AbsoluteUri);
  }

  public async Task<MgaSystems.IMS.UnderwritingServices.AgentSync.ServiceObjects.Token> GetAuthorizationTokenAsync(
    APIContext context)
  {
    return await this.GetAuthorizationTokenAsync(context, this._authorizationUri);
  }

  public async Task<MgaSystems.IMS.UnderwritingServices.AgentSync.ServiceObjects.Token> GetAuthorizationTokenAsync(
    APIContext context,
    string authorizationUri)
  {
    return await this.InternalGetAuthorizationTokenAsync(context, authorizationUri);
  }

  public async Task<string> GetContactInfosAsync(string npns)
  {
    return await this.GetContactInfosAsync(this._serviceUri, npns);
  }

  public async Task<string> GetContactInfosAsync(Uri serviceUri, string npns)
  {
    UriBuilder uriBuilder = new UriBuilder(new Uri(serviceUri, "query"));
    uriBuilder.SetSalesforceQuery(UriBuilderExtensions.SalesforceQueryType.GetContactByNpn, npns);
    return await this.GetJsonResultAsync(uriBuilder.Uri.AbsoluteUri);
  }

  public string GetEncodedClientCredentials(string clientId, string clientSecret)
  {
    Action<string> logAction1 = this._logAction;
    if (logAction1 != null)
      logAction1("Generating encoded client credentials...");
    try
    {
      return Convert.ToBase64String(Encoding.ASCII.GetBytes($"{clientId}:{clientSecret}"));
    }
    catch (Exception ex)
    {
      Action<string> logAction2 = this._logAction;
      if (logAction2 != null)
        logAction2("Error encoding client credentials. " + ex.Message);
      Action<Exception> errorHandlingAction = this._errorHandlingAction;
      if (errorHandlingAction != null)
        errorHandlingAction(ex);
    }
    return string.Empty;
  }

  public async Task<string> GetJsonResultAsync(string endpointUri)
  {
    this.CheckControllerInitialized();
    if (string.IsNullOrEmpty(endpointUri))
      throw new ArgumentException("Invalid endpoint address. Must provide a valid endpoint address for AgentSync service.");
    Action<string> logAction1 = this._logAction;
    if (logAction1 != null)
      logAction1("Generating auth token for service call...");
    this._authToken = await this.GetAuthorizationTokenAsync(APIContext.Sync);
    if (!this._authToken.Initialized)
    {
      Action<string> logAction2 = this._logAction;
      if (logAction2 != null)
        logAction2("Valid authentication token was not returned from the service.");
      throw new Exception("Authorization token has not been properly generated.");
    }
    Action<string> logAction3 = this._logAction;
    if (logAction3 != null)
      logAction3("Generating request...");
    try
    {
      AgentSyncController._httpClient.DefaultRequestHeaders.Clear();
      AgentSyncController._httpClient.DefaultRequestHeaders.ConnectionClose = new bool?(true);
      using (HttpRequestMessage syncRequest = new HttpRequestMessage(HttpMethod.Get, endpointUri))
      {
        syncRequest.Headers.Authorization = new AuthenticationHeaderValue(this._authToken.TokenType, this._authToken.AccessToken);
        Action<string> logAction4 = this._logAction;
        if (logAction4 != null)
          logAction4("Executing request for " + endpointUri);
        using (HttpResponseMessage syncResponse = await AgentSyncController._httpClient.SendAsync(syncRequest))
        {
          syncResponse.EnsureSuccessStatusCode();
          return await syncResponse.Content.ReadAsStringAsync();
        }
      }
    }
    catch (HttpRequestException ex)
    {
      Action<string> logAction5 = this._logAction;
      if (logAction5 != null)
        logAction5("Synchronization service returned a non-success status code. " + ex.Message);
      Action<Exception> errorHandlingAction = this._errorHandlingAction;
      if (errorHandlingAction != null)
        errorHandlingAction((Exception) ex);
    }
    catch (Exception ex)
    {
      Action<string> logAction6 = this._logAction;
      if (logAction6 != null)
        logAction6("Error occurred executing sync service. " + ex.Message);
      Action<Exception> errorHandlingAction = this._errorHandlingAction;
      if (errorHandlingAction != null)
        errorHandlingAction(ex);
    }
    return string.Empty;
  }

  public async Task<string> GetLicensesAsync(string npns)
  {
    return await this.GetLicensesAsync(this._serviceUri, npns);
  }

  public async Task<string> GetLicensesAsync(Uri serviceUri, string npn)
  {
    UriBuilder uriBuilder = new UriBuilder(new Uri(serviceUri, "query"));
    uriBuilder.SetSalesforceQuery(UriBuilderExtensions.SalesforceQueryType.GetLicenseByNPN, npn);
    return await this.GetJsonResultAsync(uriBuilder.Uri.AbsoluteUri);
  }

  public async Task<string> GetLicensesByStateAsync(string npn, string state)
  {
    return await this.GetLicensesByStateAsync(this._serviceUri, npn, state);
  }

  public async Task<string> GetLOAAsync(string npns)
  {
    return await this.GetLOAAsync(this._serviceUri, npns);
  }

  public async Task<string> GetLOAAsync(Uri serviceUri, string npn)
  {
    UriBuilder uriBuilder = new UriBuilder(new Uri(serviceUri, "query"));
    uriBuilder.SetSalesforceQuery(UriBuilderExtensions.SalesforceQueryType.GetLOAbyNpn, npn);
    return await this.GetJsonResultAsync(uriBuilder.Uri.AbsoluteUri);
  }

  public async Task<string> GetNIPRAsync(string npns)
  {
    return await this.GetNIPRAsync(this._serviceUri, npns);
  }

  public void Initialize(
    string clientId,
    string clientSecret,
    string authorizationUri,
    Action<string> logAction,
    Action<Exception> errorHandlingAction)
  {
    this.Initialize(clientId, clientSecret, authorizationUri, (string) null, logAction, errorHandlingAction);
  }

  public void Initialize(
    string clientId,
    string clientSecret,
    string authorizationUri,
    string baseServiceUri,
    Action<string> logAction,
    Action<Exception> errorHandlingAction)
  {
    this._clientId = clientId;
    this._clientSecret = clientSecret;
    this._authorizationUri = authorizationUri;
    this._serviceUri = new Uri(baseServiceUri);
    this._logAction = logAction;
    this._errorHandlingAction = errorHandlingAction;
    this.Initialized = true;
    Action<string> logAction1 = this._logAction;
    if (logAction1 == null)
      return;
    logAction1("AgentSyncController initialized.");
  }

  public string ResolveApiContextToString(APIContext context)
  {
    switch (context)
    {
      case APIContext.ComplianceCheck:
        return "https://api.agentsync.io/compliance_check";
      case APIContext.NPNLookup:
        return "https://api.agentsync.io/npn_lookup";
      case APIContext.Sync:
        return "https://api.agentsync.io/sync";
      default:
        return string.Empty;
    }
  }

  public async Task<string> RunComplianceCheckAsync(string npn)
  {
    return await this.RunComplianceCheckByStateAsync(npn, (string) null);
  }

  public async Task<string> RunComplianceCheckByStateAsync(string npn, string states)
  {
    this._authToken = await this.GetAuthorizationTokenAsync(APIContext.ComplianceCheck);
    if (!this._authToken.Initialized)
    {
      Action<string> logAction = this._logAction;
      if (logAction != null)
        logAction("Provided authorization token was invalid. Compliance check could not be processed.");
      return string.Empty;
    }
    UriBuilder uriBuilder = new UriBuilder(new Uri(this._serviceUri, "/services/data/v60.0/sobjects/Account/agentsync__NPN__c/" + npn));
    try
    {
      using (HttpRequestMessage complianceRequest = new HttpRequestMessage(HttpMethod.Get, uriBuilder.Uri.AbsoluteUri))
      {
        complianceRequest.Headers.Authorization = new AuthenticationHeaderValue(this._authToken.TokenType, this._authToken.AccessToken);
        using (HttpResponseMessage responseMessage = await AgentSyncController._httpClient.SendAsync(complianceRequest))
        {
          responseMessage.EnsureSuccessStatusCode();
          return await responseMessage.Content.ReadAsStringAsync();
        }
      }
    }
    catch (Exception ex)
    {
      Action<string> logAction = this._logAction;
      if (logAction != null)
        logAction("Error invoking the Compliance Check service: " + ex.Message);
      Action<Exception> errorHandlingAction = this._errorHandlingAction;
      if (errorHandlingAction != null)
        errorHandlingAction(ex);
      return string.Empty;
    }
  }

  public async Task<string> SyncAgentsAsync(DateTime fromDate)
  {
    return await this.SyncAgentsAsync(fromDate, this._serviceUri);
  }

  public async Task<string> SyncAgentsAsync(DateTime fromDate, Uri serviceUri)
  {
    this.CheckControllerInitialized();
    if (string.IsNullOrEmpty(serviceUri.AbsoluteUri))
      throw new ArgumentException("Invalid endpoint address. Must provide a valid endpoint address for Sync service.", nameof (serviceUri));
    $"{fromDate:yyyy-MM-dd}";
    Action<string> logAction1 = this._logAction;
    if (logAction1 != null)
      logAction1("Generating auth token for sync service...");
    this._authToken = await this.GetAuthorizationTokenAsync(APIContext.Sync);
    if (!this._authToken.Initialized)
    {
      Action<string> logAction2 = this._logAction;
      if (logAction2 != null)
        logAction2("Valid authentication token was not returned from the service.");
      throw new Exception("Authorization token has not been properly generated.");
    }
    Action<string> logAction3 = this._logAction;
    if (logAction3 != null)
      logAction3("Generating sync request...");
    try
    {
      AgentSyncController._httpClient.DefaultRequestHeaders.Clear();
      AgentSyncController._httpClient.DefaultRequestHeaders.ConnectionClose = new bool?(true);
      UriBuilder uriBuilder = new UriBuilder(new Uri(serviceUri, "query"));
      uriBuilder.SetSalesforceQuery(UriBuilderExtensions.SalesforceQueryType.GetAllContacts, (string) null);
      using (HttpRequestMessage syncRequest = new HttpRequestMessage(HttpMethod.Get, uriBuilder.Uri))
      {
        syncRequest.Headers.Authorization = new AuthenticationHeaderValue(this._authToken.TokenType, this._authToken.AccessToken);
        Action<string> logAction4 = this._logAction;
        if (logAction4 != null)
          logAction4($"Executing sync request for records updated since {fromDate}");
        using (HttpResponseMessage syncResponse = await AgentSyncController._httpClient.SendAsync(syncRequest))
        {
          syncResponse.EnsureSuccessStatusCode();
          return await syncResponse.Content.ReadAsStringAsync();
        }
      }
    }
    catch (HttpRequestException ex)
    {
      Action<string> logAction5 = this._logAction;
      if (logAction5 != null)
        logAction5("Synchronization service returned a non-success status code. " + ex.Message);
      Action<Exception> errorHandlingAction = this._errorHandlingAction;
      if (errorHandlingAction != null)
        errorHandlingAction((Exception) ex);
    }
    catch (Exception ex)
    {
      Action<string> logAction6 = this._logAction;
      if (logAction6 != null)
        logAction6("Error occurred executing sync service. " + ex.Message);
      Action<Exception> errorHandlingAction = this._errorHandlingAction;
      if (errorHandlingAction != null)
        errorHandlingAction(ex);
    }
    return string.Empty;
  }

  public async Task<ComplianceResult> VerifyComplianceCheckAsync(string npn)
  {
    return await this.VerifyComplianceCheckByStateAsync(npn, (string) null);
  }

  public async Task<ComplianceResult> VerifyComplianceCheckByStateAsync(string npn, string states)
  {
    string str = await this.RunComplianceCheckByStateAsync(npn, states);
    return string.IsNullOrEmpty(str) ? (ComplianceResult) null : JsonConvert.DeserializeObject<ComplianceResult>(str);
  }

  private async Task<string> GetLicensesByStateAsync(Uri serviceUri, string npn, string state)
  {
    UriBuilder uriBuilder = new UriBuilder(new Uri(serviceUri, "query"));
    uriBuilder.SetSalesforceQuery(UriBuilderExtensions.SalesforceQueryType.GetLicenseByNPNState, npn, state);
    return await this.GetJsonResultAsync(uriBuilder.Uri.AbsoluteUri);
  }

  private async Task<string> GetNIPRAsync(Uri serviceUri, string npn)
  {
    UriBuilder uriBuilder = new UriBuilder(new Uri(serviceUri, "query"));
    uriBuilder.SetSalesforceQuery(UriBuilderExtensions.SalesforceQueryType.GetNIPRByNPN, npn);
    return await this.GetJsonResultAsync(uriBuilder.Uri.AbsoluteUri);
  }

  private async Task<MgaSystems.IMS.UnderwritingServices.AgentSync.ServiceObjects.Token> InternalGetAuthorizationTokenAsync(
    APIContext context,
    string authorizationUri)
  {
    this.CheckControllerInitialized();
    if (this._authToken == null || !this._authToken.Initialized)
    {
      Action<string> logAction = this._logAction;
      if (logAction != null)
        logAction("The current authorization token has not been properly initialized.");
    }
    else
    {
      DateTime now = DateTime.Now;
      DateTime? expiry = this._authToken?.Expiry;
      if ((expiry.HasValue ? (now < expiry.GetValueOrDefault() ? 1 : 0) : 0) != 0 && this._authToken.Context == context)
      {
        this._logAction("Token has not expired. Continuing with active token...");
        return this._authToken;
      }
    }
    Action<string> logAction1 = this._logAction;
    if (logAction1 != null)
      logAction1("Executing authentication service for new token...");
    MgaSystems.IMS.UnderwritingServices.AgentSync.ServiceObjects.Token token;
    try
    {
      AgentSyncController._httpClient.DefaultRequestHeaders.Clear();
      AgentSyncController._httpClient.DefaultRequestHeaders.ConnectionClose = new bool?(true);
      using (HttpRequestMessage authRequest = new HttpRequestMessage(HttpMethod.Post, authorizationUri))
      {
        authRequest.Headers.Authorization = new AuthenticationHeaderValue("Basic", this.GetEncodedClientCredentials(this._clientId, this._clientSecret));
        authRequest.Content = (HttpContent) new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>) new List<KeyValuePair<string, string>>()
        {
          new KeyValuePair<string, string>("grant_type", "client_credentials")
        });
        using (HttpResponseMessage response = await AgentSyncController._httpClient.SendAsync(authRequest))
        {
          response.EnsureSuccessStatusCode();
          token = JsonConvert.DeserializeObject<MgaSystems.IMS.UnderwritingServices.AgentSync.ServiceObjects.Token>(await response.Content.ReadAsStringAsync());
          token.Initialized = true;
          token.Expiry = DateTime.Now.AddSeconds((double) token.ExpiresIn);
          token.Context = context;
        }
      }
    }
    catch (HttpRequestException ex)
    {
      Action<string> logAction2 = this._logAction;
      if (logAction2 != null)
        logAction2("Authorization service returned a non-success status code. " + ex.Message);
      Action<Exception> errorHandlingAction = this._errorHandlingAction;
      if (errorHandlingAction != null)
        errorHandlingAction((Exception) ex);
      token = new MgaSystems.IMS.UnderwritingServices.AgentSync.ServiceObjects.Token();
    }
    catch (Exception ex)
    {
      Action<string> logAction3 = this._logAction;
      if (logAction3 != null)
        logAction3("Error occurred executing sync service. " + ex.Message);
      Action<Exception> errorHandlingAction = this._errorHandlingAction;
      if (errorHandlingAction != null)
        errorHandlingAction(ex);
      token = new MgaSystems.IMS.UnderwritingServices.AgentSync.ServiceObjects.Token();
    }
    return this._authToken = token;
  }
}
