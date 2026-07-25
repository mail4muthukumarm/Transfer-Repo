// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.InsCipher.BaseController`1
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.InsCipher;

public abstract class BaseController<TController> : RestServiceBase<TController> where TController : RestServiceBase<TController>
{
  internal const string ResponseContentErrorKey = "BaseController.ResponseContent";

  protected string ApiKey { get; }

  protected JsonSerializerSettings JsonSettings { get; } = new JsonSerializerSettings();

  protected BaseController(
    string applicationUri,
    string apiKey,
    IProgress<string> logAction,
    IProgress<Exception> errorHandlingAction)
    : base(applicationUri, logAction, errorHandlingAction)
  {
    this.ApiKey = !string.IsNullOrEmpty(apiKey) ? apiKey : throw new ArgumentException("API key required", nameof (apiKey));
  }

  protected async Task<TResponse> CallController<TRequest, TResponse>(
    TRequest request,
    HttpMethod method,
    Uri endpointUrl,
    Func<Exception, TResponse> buildError = null,
    [CallerMemberName] string operation = null)
    where TResponse : class
  {
    string responseContent = (string) null;
    try
    {
      Action<string> urlCreatedAction = this.UrlCreatedAction;
      if (urlCreatedAction != null)
        urlCreatedAction(endpointUrl.ToString());
      using (HttpRequestMessage apiRequest = new HttpRequestMessage(method, endpointUrl))
      {
        apiRequest.Headers.Add("apikey", this.ApiKey);
        if ((object) (TRequest) request != null && !((object) (TRequest) request is IgnoreType))
        {
          string content = JsonConvert.SerializeObject((object) (TRequest) request);
          Action<string> requestJsonAction = this.RequestJsonAction;
          if (requestJsonAction != null)
            requestJsonAction(content);
          apiRequest.Content = (HttpContent) new StringContent(content, Encoding.UTF8, "application/json");
          this.LogProgress?.Report($"Created a {operation} request: {content}");
        }
        else
          this.LogProgress?.Report($"Created a {operation} request");
        using (HttpResponseMessage response = await RestServiceBase<TController>.ServiceClient.SendAsync(apiRequest).ConfigureAwait(false))
        {
          responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
          response.EnsureSuccessStatusCode();
          Action<string> responseJsonAction = this.ResponseJsonAction;
          if (responseJsonAction != null)
            responseJsonAction(responseContent);
          this.LogProgress?.Report($"Received a valid {operation} response. Content: {responseContent}");
          return JsonConvert.DeserializeObject<TResponse>(responseContent, this.JsonSettings);
        }
      }
    }
    catch (Exception ex)
    {
      ex.Data[(object) "BaseController.ResponseContent"] = (object) responseContent;
      this.ErrorProgress?.Report(ex);
      this.LogProgress?.Report($"{operation} request failed: {ex.Message}");
      return buildError(ex);
    }
  }
}
