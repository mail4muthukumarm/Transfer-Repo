// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Verisk.Controller.MvrController
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.Extensions;
using MgaSystems.IMS.UnderwritingServices.Proxy.Verisk.Iix;
using MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Verisk.Controller;

public class MvrController(
  string applicationUri,
  IProgress<string> logAction = null,
  IProgress<Exception> errorHandlingAction = null) : 
  SoapServiceBase<MvrController, SoapAuthPortType, SoapAuthPortTypeClient>(applicationUri, logAction, errorHandlingAction)
{
  private const string NotAvailableResponse = "RESPONSE NOT YET AVAILABLE";
  private SoapServiceBase<MvrController, SoapAuthPortType, SoapAuthPortTypeClient>.MethodAndDataHandler _onRequestString;
  private SoapServiceBase<MvrController, SoapAuthPortType, SoapAuthPortTypeClient>.MethodAndDataHandler _onResponseString;
  private string _defaultUsername;
  private string _defaultPassword;
  private string _defaultAccountId;
  private string _defaultBillingCode;

  public MvrController SetRequestStringListener(
    SoapServiceBase<MvrController, SoapAuthPortType, SoapAuthPortTypeClient>.MethodAndDataHandler listenerAction)
  {
    this._onRequestString = listenerAction;
    return this;
  }

  public MvrController SetResponseStringListener(
    SoapServiceBase<MvrController, SoapAuthPortType, SoapAuthPortTypeClient>.MethodAndDataHandler listenerAction)
  {
    this._onResponseString = listenerAction;
    return this;
  }

  public MvrController SetDefaultCredentials(
    string username = null,
    string password = null,
    string accountId = null,
    string billingCode = null)
  {
    string str1 = username;
    string str2 = password;
    string str3 = accountId;
    string str4 = billingCode;
    this._defaultUsername = str1;
    this._defaultPassword = str2;
    this._defaultAccountId = str3;
    this._defaultBillingCode = str4;
    return this;
  }

  private async Task<string> SendRequest(
    SoapAuthPortType channel,
    string requestString,
    [CallerMemberName] string callingMethod = "SendRequest")
  {
    SoapServiceBase<MvrController, SoapAuthPortType, SoapAuthPortTypeClient>.MethodAndDataHandler onRequestString = this._onRequestString;
    if (onRequestString != null)
      onRequestString(callingMethod, requestString);
    this.LogProgress?.Report(callingMethod + " message built. Calling sendRequest2Async...");
    sendRequest2Response request2Response = await channel.sendRequest2Async(new sendRequest2Request(requestString)).ConfigureAwait(false);
    SoapServiceBase<MvrController, SoapAuthPortType, SoapAuthPortTypeClient>.MethodAndDataHandler onResponseString = this._onResponseString;
    if (onResponseString != null)
      onResponseString(callingMethod, request2Response.@return);
    this.LogProgress?.Report("Response received.");
    return request2Response.@return;
  }

  public async Task<AccountInquiryResponse> GetAccountInquiryAsync(AccountInquiryRequest request)
  {
    this.LogProgress?.Report("Called GetAccountInquiryAsync.");
    string rawResponse = (string) null;
    SoapAuthPortType iixClient = (SoapAuthPortType) null;
    try
    {
      iixClient = (SoapAuthPortType) this.CreateClient(request.UserNameOrDefault(this._defaultUsername), request.UserPasswordOrDefault(this._defaultPassword));
      this.LogProgress?.Report($"SOAP instance {iixClient.GetType().Name} created.");
      rawResponse = await this.SendRequest(iixClient, this.BuildAccountInquiryRequestString(request), nameof (GetAccountInquiryAsync)).ConfigureAwait(false);
      return new AccountInquiryResponse(rawResponse);
    }
    catch (Exception ex)
    {
      this.ErrorProgress?.Report(ex);
      return new AccountInquiryResponse(ex, rawResponse);
    }
    finally
    {
      if (iixClient is IDisposable disposable)
        disposable.Dispose();
    }
  }

  public async Task<DriverReportResponse> SubmitDriverReportAsync(DriverReportRequest request)
  {
    this.LogProgress?.Report("Calling SubmitDriverReportAsync.");
    string rawResponse = (string) null;
    SoapAuthPortType iixClient = (SoapAuthPortType) null;
    try
    {
      iixClient = (SoapAuthPortType) this.CreateClient(request.UserNameOrDefault(this._defaultUsername), request.UserPasswordOrDefault(this._defaultPassword));
      this.LogProgress?.Report($"SOAP instance {iixClient.GetType().Name} created.");
      rawResponse = await this.SendRequest(iixClient, this.BuildDriverReportRequestString(request), nameof (SubmitDriverReportAsync)).ConfigureAwait(false);
      return new DriverReportResponse(rawResponse);
    }
    catch (Exception ex)
    {
      this.ErrorProgress?.Report(ex);
      return new DriverReportResponse(ex, rawResponse);
    }
    finally
    {
      if (iixClient is IDisposable disposable)
        disposable.Dispose();
    }
  }

  private async Task<string> GetReportResponse(
    SoapAuthPortType channel,
    ReportRequest request,
    Func<SoapAuthPortType, string, Task<string>> apiMethodCall,
    int retryCount = 3,
    [CallerMemberName] string callingMethod = "GetReportResponse")
  {
    this.LogProgress?.Report($"Called GetReportResponse from {callingMethod}.");
    this.LogProgress?.Report($"Building {callingMethod} message...");
    string requestString = this.BuildReportRequestString(request).ToString();
    SoapServiceBase<MvrController, SoapAuthPortType, SoapAuthPortTypeClient>.MethodAndDataHandler onRequestString = this._onRequestString;
    if (onRequestString != null)
      onRequestString(callingMethod, requestString);
    this.LogProgress?.Report(callingMethod + " message built. Sending...");
    string response = (string) null;
    for (int apiAttempts = 0; apiAttempts < retryCount; ++apiAttempts)
    {
      response = await apiMethodCall(channel, requestString).ConfigureAwait(false);
      if (string.IsNullOrEmpty(response) || response.IndexOf("RESPONSE NOT YET AVAILABLE", StringComparison.OrdinalIgnoreCase) != -1)
        await Task.Delay(TimeSpan.FromSeconds(3.0)).ConfigureAwait(false);
      else
        break;
    }
    this.LogProgress?.Report("Report received.");
    SoapServiceBase<MvrController, SoapAuthPortType, SoapAuthPortTypeClient>.MethodAndDataHandler onResponseString = this._onResponseString;
    if (onResponseString != null)
      onResponseString(callingMethod, response);
    string reportResponse = response;
    requestString = (string) null;
    response = (string) null;
    return reportResponse;
  }

  public async Task<ReportPdfResponse> GetPdfReportAsync(ReportRequest request, int retryCount = 3)
  {
    this.LogProgress?.Report("Called GetPdfReportAsync.");
    string rawResponse = (string) null;
    SoapAuthPortType iixClient = (SoapAuthPortType) null;
    try
    {
      iixClient = (SoapAuthPortType) this.CreateClient(request.UserNameOrDefault(this._defaultUsername), request.UserPasswordOrDefault(this._defaultPassword));
      this.LogProgress?.Report($"SOAP instance {iixClient.GetType().Name} created. Calling getPdfResponse2...");
      rawResponse = await this.GetReportResponse(iixClient, request, (Func<SoapAuthPortType, string, Task<string>>) (async (iixChannel, requestString) => (await iixChannel.getPdfResponse2Async(new getPdfResponse2Request(requestString)).ConfigureAwait(false)).@return), retryCount, nameof (GetPdfReportAsync)).ConfigureAwait(false);
      return new ReportPdfResponse(rawResponse);
    }
    catch (Exception ex)
    {
      this.ErrorProgress?.Report(ex);
      return new ReportPdfResponse(ex, rawResponse);
    }
    finally
    {
      if (iixClient is IDisposable disposable)
        disposable.Dispose();
    }
  }

  public async Task<ReportXmlResponse> GetXmlReportAsync(ReportRequest request, int retryCount = 3)
  {
    this.LogProgress?.Report("Called GetXmlReportAsync.");
    string rawResponse = (string) null;
    SoapAuthPortType iixClient = (SoapAuthPortType) null;
    try
    {
      iixClient = (SoapAuthPortType) this.CreateClient(request.UserNameOrDefault(this._defaultUsername), request.UserPasswordOrDefault(this._defaultPassword));
      this.LogProgress?.Report($"SOAP instance {iixClient.GetType().Name} created. Calling getXmlResponse2...");
      rawResponse = await this.GetReportResponse(iixClient, request, (Func<SoapAuthPortType, string, Task<string>>) (async (iixChannel, requestString) => (await iixChannel.getXmlResponse2Async(new getXmlResponse2Request(requestString)).ConfigureAwait(false)).@return), retryCount, nameof (GetXmlReportAsync)).ConfigureAwait(false);
      return new ReportXmlResponse(rawResponse);
    }
    catch (Exception ex)
    {
      this.ErrorProgress?.Report(ex);
      return new ReportXmlResponse(ex, rawResponse);
    }
    finally
    {
      if (iixClient is IDisposable disposable)
        disposable.Dispose();
    }
  }

  public async Task<CombinedResponse> SubmitDriverWithXmlReportAsync(
    DriverReportRequest reportRequest,
    int reportRetryCount = 3)
  {
    return await this.SubmitDriverWithReports(reportRequest, reportRetryCount, false, callingMethod: nameof (SubmitDriverWithXmlReportAsync)).ConfigureAwait(false);
  }

  public async Task<CombinedResponse> SubmitDriverWithPdfReportAsync(
    DriverReportRequest reportRequest,
    int reportRetryCount = 3)
  {
    return await this.SubmitDriverWithReports(reportRequest, reportRetryCount, getXml: false, callingMethod: nameof (SubmitDriverWithPdfReportAsync)).ConfigureAwait(false);
  }

  public async Task<CombinedResponse> SubmitDriverWithPdfAndXmlReportsAsync(
    DriverReportRequest reportRequest,
    int reportRetryCount = 3)
  {
    return await this.SubmitDriverWithReports(reportRequest, reportRetryCount, callingMethod: nameof (SubmitDriverWithPdfAndXmlReportsAsync)).ConfigureAwait(false);
  }

  private async Task<CombinedResponse> SubmitDriverWithReports(
    DriverReportRequest reportRequest,
    int reportRetryCount = 3,
    bool getPdf = true,
    bool getXml = true,
    [CallerMemberName] string callingMethod = "SubmitDriverWithReports")
  {
    this.LogProgress?.Report($"Called {callingMethod}.");
    CombinedResponse response = new CombinedResponse();
    SoapAuthPortTypeClient iixClient = (SoapAuthPortTypeClient) null;
    try
    {
      iixClient = this.CreateClient(reportRequest.UserNameOrDefault(this._defaultUsername), reportRequest.UserPasswordOrDefault(this._defaultPassword));
      this.LogProgress?.Report($"SOAP instance {iixClient.GetType().Name} created. Calling SendRequest...");
      response.ReportResponse = new DriverReportResponse(await this.SendRequest((SoapAuthPortType) iixClient, this.BuildDriverReportRequestString(reportRequest), "DriverReportRequest").ConfigureAwait(false));
      if (!response.ReportResponse.IsAcceptResponse)
        ExceptionDispatchInfo.Capture(response.ReportResponse.CreateException ?? new Exception(response.ReportResponse.ResponseDescription)).Throw();
      ReportRequest documentsRequest = ReportRequest.FromMvrRequest(reportRequest, response.ReportResponse.AcceptID.Value);
      ConfiguredTaskAwaitable<string> configuredTaskAwaitable;
      if (getPdf)
      {
        this.LogProgress?.Report("Calling PDF GetReportResponse...");
        configuredTaskAwaitable = this.GetReportResponse((SoapAuthPortType) iixClient, documentsRequest, (Func<SoapAuthPortType, string, Task<string>>) (async (iixChannel, requestString) => (await iixChannel.getPdfResponse2Async(new getPdfResponse2Request(requestString)).ConfigureAwait(false)).@return), reportRetryCount, callingMethod).ConfigureAwait(false);
        response.PdfResponse = new ReportPdfResponse(await configuredTaskAwaitable);
      }
      if (getXml)
      {
        this.LogProgress?.Report("Calling XML GetReportResponse...");
        configuredTaskAwaitable = this.GetReportResponse((SoapAuthPortType) iixClient, documentsRequest, (Func<SoapAuthPortType, string, Task<string>>) (async (iixChannel, requestString) => (await iixChannel.getXmlResponse2Async(new getXmlResponse2Request(requestString)).ConfigureAwait(false)).@return), reportRetryCount, callingMethod).ConfigureAwait(false);
        response.XmlResponse = new ReportXmlResponse(await configuredTaskAwaitable);
      }
      documentsRequest = (ReportRequest) null;
    }
    catch (Exception ex)
    {
      this.ErrorProgress?.Report(ex);
    }
    finally
    {
      ((IDisposable) iixClient)?.Dispose();
    }
    CombinedResponse combinedResponse = response;
    response = (CombinedResponse) null;
    iixClient = (SoapAuthPortTypeClient) null;
    return combinedResponse;
  }

  private string BuildAccountInquiryRequestString(AccountInquiryRequest request)
  {
    return new StringBuilder(37).AppendPad(request.RequestVersion, 2).AppendPad(request.UserNameOrDefault(this._defaultUsername), 3).AppendPad(request.UserPasswordOrDefault(this._defaultPassword), 20).AppendPad(request.AccountIdOrDefault(this._defaultAccountId), 6).AppendPadWith(string.Empty, 3, '0').AppendPad(request.Product, 3).ToString();
  }

  private string BuildDriverReportRequestString(DriverReportRequest request)
  {
    return new StringBuilder(222).AppendPad(request.RequestVersion, 2).AppendPad(request.UserNameOrDefault(this._defaultUsername), 3).AppendPad(request.UserPasswordOrDefault(this._defaultPassword), 20).AppendPad(request.AccountIdOrDefault(this._defaultAccountId), 6).AppendPad(request.BillingCodeOrDefault(this._defaultBillingCode), 3).AppendPad(request.Product, 3).AppendPad($"{request.OrderPurpose}", 1).AppendPad(request.State, 2).AppendPadWith(request.JulianDate, 3, '0').AppendPadWith(request.RecordSequenceNumber, 6, '0').AppendPad(request.CleanDriversLicenseNumber, 19).AppendPad(request.LastName, 20).AppendPad(request.Suffix, 3).AppendPad(request.FirstName, 15).AppendPad(request.MiddleName, 15).AppendPad($"{request.DateOfBirth:MMddyyyy}", 8).AppendPad(request.Gender, 1).AppendPad(request.ClientCode, 8).AppendPad(request.QuoteBack, 40).AppendPad(request.RequestType, 1).AppendPad(request.FormatID, 3).AppendPad(request.RFlag, 1).AppendPad(request.SSN, 9).AppendPad(request.Extension, 30).ToString();
  }

  private string BuildReportRequestString(ReportRequest request)
  {
    return new StringBuilder(47).AppendPad(request.RequestVersion, 2).AppendPad(request.UserNameOrDefault(this._defaultUsername), 3).AppendPad(request.UserPasswordOrDefault(this._defaultPassword), 20).AppendPad(request.AccountIdOrDefault(this._defaultAccountId), 6).AppendPad(request.BillingCodeOrDefault(this._defaultBillingCode), 3).AppendPad(request.Product, 3).Append($"{request.AcceptID:D9}").ToString();
  }
}
