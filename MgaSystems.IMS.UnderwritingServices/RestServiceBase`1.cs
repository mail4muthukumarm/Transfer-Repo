// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.RestServiceBase`1
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices;

public abstract class RestServiceBase<TIn> where TIn : RestServiceBase<TIn>
{
  protected static readonly HttpClient ServiceClient = new HttpClient();

  protected IProgress<Exception> ErrorProgress { get; }

  protected IProgress<string> LogProgress { get; }

  protected Action<string> UrlCreatedAction { get; private set; }

  protected Action<string> RequestJsonAction { get; private set; }

  protected Action<string> ResponseJsonAction { get; private set; }

  protected string ApplicationUri { get; }

  protected Uri BaseUri { get; }

  public TIn SetUrlListener(Action<string> urlListener)
  {
    this.UrlCreatedAction = urlListener;
    return (TIn) this;
  }

  public TIn SetRequestJsonlListener(Action<string> reqJsonListener)
  {
    this.RequestJsonAction = reqJsonListener;
    return (TIn) this;
  }

  public TIn SetResponseJsonListener(Action<string> respJsonListener)
  {
    this.ResponseJsonAction = respJsonListener;
    return (TIn) this;
  }

  protected RestServiceBase(
    string applicationUri,
    IProgress<string> logAction = null,
    IProgress<Exception> errorHandlingAction = null)
  {
    this.ApplicationUri = !string.IsNullOrEmpty(applicationUri) ? applicationUri : throw new ArgumentException(nameof (applicationUri));
    this.LogProgress = logAction;
    this.ErrorProgress = errorHandlingAction;
    this.BaseUri = new Uri(this.ApplicationUri);
    this.LogProgress?.Report($"{typeof (TIn).Name} successfully initialized. Application Endpoint: {applicationUri}");
  }

  protected async Task<HttpResponseMessage> Send<TRequest>(
    TRequest request,
    HttpMethod method,
    string endpointUrl,
    [CallerMemberName] string operation = null)
  {
    HttpResponseMessage httpResponseMessage;
    try
    {
      Action<string> urlCreatedAction = this.UrlCreatedAction;
      if (urlCreatedAction != null)
        urlCreatedAction(endpointUrl.ToString());
      using (HttpRequestMessage httpRequest = new HttpRequestMessage(method, endpointUrl))
      {
        await this.AuthenticateRequest(httpRequest);
        if ((object) (TRequest) request != null && !((object) (TRequest) request is IgnoreType))
        {
          string content = JsonConvert.SerializeObject((object) (TRequest) request);
          Action<string> requestJsonAction = this.RequestJsonAction;
          if (requestJsonAction != null)
            requestJsonAction(content);
          httpRequest.Content = (HttpContent) new StringContent(content, Encoding.UTF8, "application/json");
          this.LogProgress?.Report($"Created a {operation} request: {content}");
        }
        else
          this.LogProgress?.Report($"Created a {operation} request");
        httpResponseMessage = await RestServiceBase<TIn>.ServiceClient.SendAsync(httpRequest).ConfigureAwait(false);
      }
    }
    catch (Exception ex)
    {
      this.ErrorProgress?.Report(ex);
      this.LogProgress?.Report($"{operation} request failed: {ex.Message}");
      throw;
    }
    return httpResponseMessage;
  }

  protected async Task<string> Call<TRequest>(
    TRequest request,
    HttpMethod method,
    string endpointUrl,
    bool throwOnNonSuccessResponse = true,
    Action<HttpResponseMessage> onResponse = null,
    [CallerMemberName] string operation = null)
  {
    try
    {
      using (HttpResponseMessage response = await this.Send<TRequest>(request, method, endpointUrl, operation).ConfigureAwait(false))
      {
        Action<HttpResponseMessage> action = onResponse;
        if (action != null)
          action(response);
        string str = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        Action<string> responseJsonAction = this.ResponseJsonAction;
        if (responseJsonAction != null)
          responseJsonAction(str);
        response.EnsureSuccessStatusCode();
        this.LogProgress?.Report($"Received a valid {operation} response. Content: {str.Length}");
        return str;
      }
    }
    catch (Exception ex) when (!throwOnNonSuccessResponse)
    {
      string str = JsonConvert.SerializeObject((object) new BaseResult()
      {
        Method = $"{method}",
        Endpoint = endpointUrl.ToString(),
        Error = ex.Message,
        Timestamp = new DateTimeOffset?(DateTimeOffset.Now)
      });
      Action<string> responseJsonAction = this.ResponseJsonAction;
      if (responseJsonAction != null)
        responseJsonAction(str);
      return str;
    }
  }

  protected async Task<TResponse> Call<TRequest, TResponse>(
    TRequest request,
    HttpMethod method,
    string endpointUrl,
    bool throwOnNonSuccessResponse = true,
    Action<HttpResponseMessage> onResponse = null,
    [CallerMemberName] string operation = null)
    where TResponse : BaseResult, new()
  {
    string jsonResponse = (string) null;
    TResponse response;
    try
    {
      jsonResponse = await this.Call<TRequest>(request, method, endpointUrl, throwOnNonSuccessResponse, onResponse, operation).ConfigureAwait(false);
      response = JsonConvert.DeserializeObject<TResponse>(jsonResponse);
    }
    catch (JsonSerializationException ex)
    {
      ((Exception) ex).Data[(object) nameof (TResponse)] = (object) typeof (TResponse).FullName;
      ((Exception) ex).Data[(object) "JsonResponse"] = (object) jsonResponse;
      this.ErrorProgress?.Report((Exception) ex);
      this.LogProgress?.Report($"{operation} failed to deserialize to {typeof (TResponse).Name}: {((Exception) ex).Message}");
      throw;
    }
    jsonResponse = (string) null;
    return response;
  }

  protected async Task<TResponse> Post<TRequest, TResponse>(
    TRequest request,
    string endpointUrl,
    bool throwOnNonSuccessResponse = true,
    Action<HttpResponseMessage> onResponse = null,
    [CallerMemberName] string operation = null)
    where TResponse : BaseResult, new()
  {
    return await this.Call<TRequest, TResponse>(request, HttpMethod.Post, endpointUrl, throwOnNonSuccessResponse, onResponse, operation).ConfigureAwait(false);
  }

  protected async Task<TResponse> Get<TResponse>(
    string endpointUrl,
    bool throwOnNonSuccessResponse = true,
    Action<HttpResponseMessage> onResponse = null,
    [CallerMemberName] string operation = null)
    where TResponse : BaseResult, new()
  {
    return await this.Call<IgnoreType, TResponse>(IgnoreType.Instance, HttpMethod.Get, endpointUrl, throwOnNonSuccessResponse, onResponse, operation).ConfigureAwait(false);
  }

  protected virtual async Task AuthenticateRequest(
    HttpRequestMessage message,
    CancellationToken cancellationToken = default (CancellationToken))
  {
    await Task.CompletedTask.ConfigureAwait(false);
  }
}
