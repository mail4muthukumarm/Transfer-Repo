// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.BillItNow.Controller.BillItNowController
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.BillItNow.ServiceObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.BillItNow.Controller;

public class BillItNowController
{
  private static readonly HttpClient _httpClient = new HttpClient();
  private readonly string _clientId;
  private readonly string _clientSecret;
  private readonly string _authUri;
  private readonly string _scope;
  private readonly Action<Exception> _errorHandlingAction;
  private readonly Action<string> _logAction;
  private Token _authToken;

  public BillItNowController(
    string clientId,
    string clientSecret,
    string authUri,
    string scope,
    Action<Exception> errorHandlingAction,
    Action<string> logAction)
  {
    this._clientId = clientId;
    this._clientSecret = clientSecret;
    this._errorHandlingAction = errorHandlingAction;
    this._authUri = authUri;
    this._scope = scope;
    this._logAction = logAction;
    Action<string> logAction1 = this._logAction;
    if (logAction1 == null)
      return;
    logAction1("BillItNow Controller successfully initialized. Authentication Endpoint: " + authUri);
  }

  public async Task<Token> GetAuthToken(string authUri, string scope)
  {
    Token authToken;
    try
    {
      using (HttpRequestMessage authRequest = new HttpRequestMessage(HttpMethod.Post, authUri))
      {
        authRequest.Headers.Authorization = new AuthenticationHeaderValue("Basic", this.GetEncodedClientCredentials(this._clientId, this._clientSecret));
        KeyValuePair<string, string>[] nameValueCollection = new KeyValuePair<string, string>[2]
        {
          new KeyValuePair<string, string>("grant_type", "client_credentials"),
          new KeyValuePair<string, string>(nameof (scope), scope)
        };
        authRequest.Content = (HttpContent) new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>) nameValueCollection);
        Action<string> logAction1 = this._logAction;
        if (logAction1 != null)
          logAction1("Created authentication request.");
        using (HttpResponseMessage authResponse = await BillItNowController._httpClient.SendAsync(authRequest))
        {
          string str = await authResponse.Content.ReadAsStringAsync();
          Action<string> logAction2 = this._logAction;
          if (logAction2 != null)
            logAction2("Received authentication response.");
          authToken = JsonConvert.DeserializeObject<Token>(str);
          authToken.Expiry = DateTime.Now.AddSeconds((double) (authToken.ExpiresIn - 60));
          authToken.Initialized = true;
          Action<string> logAction3 = this._logAction;
          if (logAction3 != null)
            logAction3("Authentication token initialized.");
        }
      }
    }
    catch (Exception ex)
    {
      Action<Exception> errorHandlingAction = this._errorHandlingAction;
      if (errorHandlingAction != null)
        errorHandlingAction(ex);
      Action<string> logAction = this._logAction;
      if (logAction != null)
        logAction("Authentication process failed: " + ex.Message);
      authToken = new Token();
    }
    return authToken;
  }

  public async Task<BillItNowPoliciesResponse> GetBillItNowPoliciesResponse(string baseUri)
  {
    BillItNowPoliciesResponse returnResponse = new BillItNowPoliciesResponse();
    bool flag = !this._authToken.Initialized;
    if (flag)
      flag = !await this.GenerateAuthToken(this._authUri, this._scope);
    if (flag)
      throw new Exception("Authorization token not initialized. Be sure to call GenerateAuthToken()");
    if (baseUri == null)
      throw new Exception("Base URI not valid. Be sure to call FormatPolicyEndpointAddress()");
    try
    {
      using (HttpRequestMessage uploadRequest = new HttpRequestMessage(HttpMethod.Get, baseUri))
      {
        uploadRequest.Headers.Authorization = new AuthenticationHeaderValue(this._authToken.TokenType, this._authToken.AccessToken);
        Action<string> logAction1 = this._logAction;
        if (logAction1 != null)
          logAction1("Created a BillItNow Policies information request.");
        using (HttpResponseMessage response = await BillItNowController._httpClient.SendAsync(uploadRequest))
        {
          response.EnsureSuccessStatusCode();
          string str = await response.Content.ReadAsStringAsync();
          Action<string> logAction2 = this._logAction;
          if (logAction2 != null)
            logAction2("Received a valid information response. Content: " + str);
          return JsonConvert.DeserializeObject<BillItNowPoliciesResponse>(str);
        }
      }
    }
    catch (Exception ex)
    {
      Action<Exception> errorHandlingAction = this._errorHandlingAction;
      if (errorHandlingAction != null)
        errorHandlingAction(ex);
      Action<string> logAction = this._logAction;
      if (logAction != null)
        logAction("Policies information request failed: " + ex.Message);
    }
    return returnResponse;
  }

  public async Task<bool> SendBillItNowRenameRequest(string renameUri, string newPolicyNumber)
  {
    bool flag = !this._authToken.Initialized;
    if (flag)
      flag = !await this.GenerateAuthToken(this._authUri, this._scope);
    if (flag)
      throw new Exception("Authorization token not initialized. Be sure to call GenerateAuthToken()");
    if (renameUri == null)
      throw new Exception("Endpoint URI not valid. Be sure to call FormatPolicyRenameEndpointAddress()");
    try
    {
      using (HttpRequestMessage renameRequest = new HttpRequestMessage(HttpMethod.Put, renameUri))
      {
        BillItNowController._httpClient.DefaultRequestHeaders.Clear();
        BillItNowController._httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        string content = JsonConvert.SerializeObject((object) new RenameRequest()
        {
          NewCarrierPolicyId = newPolicyNumber
        });
        renameRequest.Content = (HttpContent) new StringContent(content, Encoding.UTF8, "application/json");
        renameRequest.Headers.Authorization = new AuthenticationHeaderValue(this._authToken.TokenType, this._authToken.AccessToken);
        Action<string> logAction1 = this._logAction;
        if (logAction1 != null)
          logAction1("Created rename request with endpoint " + renameUri);
        Action<string> logAction2 = this._logAction;
        if (logAction2 != null)
          logAction2("Rename request content: " + content);
        Action<string> logAction3 = this._logAction;
        if (logAction3 != null)
          logAction3("Sending rename request to service...");
        using (HttpResponseMessage httpResponseMessage = await BillItNowController._httpClient.SendAsync(renameRequest))
        {
          string result = httpResponseMessage.Content.ReadAsStringAsync().Result;
          if (httpResponseMessage.StatusCode.Equals((object) HttpStatusCode.BadRequest))
          {
            if (result.Contains("does not exist"))
            {
              Action<string> logAction4 = this._logAction;
              if (logAction4 != null)
                logAction4("Service could not reconcile provided policy number with an existing BillItNow policy: " + result);
              Action<Exception> errorHandlingAction = this._errorHandlingAction;
              if (errorHandlingAction != null)
                errorHandlingAction(new Exception("The service could not identify the policy to be updated."));
            }
          }
          else
          {
            httpResponseMessage.EnsureSuccessStatusCode();
            Action<string> logAction5 = this._logAction;
            if (logAction5 != null)
              logAction5("Rename request sent successfully.");
            return true;
          }
        }
      }
    }
    catch (Exception ex)
    {
      Action<Exception> errorHandlingAction = this._errorHandlingAction;
      if (errorHandlingAction != null)
        errorHandlingAction(ex);
      Action<string> logAction = this._logAction;
      if (logAction != null)
        logAction("Rename request failed: " + ex.Message);
    }
    return false;
  }

  public async Task<bool> GenerateAuthToken(string authUri, string scope)
  {
    if (this._authToken == null)
      this._authToken = await this.GetAuthToken(authUri, scope);
    else if (DateTime.Now > this._authToken.Expiry)
    {
      Action<string> logAction = this._logAction;
      if (logAction != null)
        logAction("Current token has expired. Fetching new token...");
      this._authToken = await this.GetAuthToken(authUri, scope);
    }
    return this._authToken.Initialized;
  }

  public string FormatPolicyEndpointAddress(string baseUri, string mgaId, string carrierPolicyId)
  {
    if (baseUri.EndsWith("/"))
      throw new ArgumentException("Base Uri address must not end in a forward slash (/)");
    return $"{baseUri}/{mgaId}/{carrierPolicyId}";
  }

  public string FormatPolicyRenameEndpointAddress(
    string baseUri,
    string mgaId,
    string carrierPolicyId)
  {
    if (baseUri.EndsWith("/"))
      throw new ArgumentException("Base Uri address must not end in a forward slash (/)");
    return this.FormatPolicyEndpointAddress(baseUri, mgaId, carrierPolicyId) + "/rename";
  }

  public string GetEncodedClientCredentials(string clientId, string clientSecret)
  {
    return Convert.ToBase64String(Encoding.ASCII.GetBytes($"{clientId}:{clientSecret}"));
  }
}
