// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.DataCaptureClientApi
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NSwag", "13.8.2.0 (NJsonSchema v10.2.1.0 (Newtonsoft.Json v11.0.0.0))")]
public class DataCaptureClientApi
{
  private string _baseUrl = "";
  private HttpClient _httpClient;
  private Lazy<JsonSerializerSettings> _settings;

  public DataCaptureClientApi(string baseUrl, HttpClient httpClient)
  {
    this.BaseUrl = baseUrl;
    this._httpClient = httpClient;
    this._settings = new Lazy<JsonSerializerSettings>(new Func<JsonSerializerSettings>(this.CreateSerializerSettings));
  }

  private JsonSerializerSettings CreateSerializerSettings() => new JsonSerializerSettings();

  public string BaseUrl
  {
    get => this._baseUrl;
    set => this._baseUrl = value;
  }

  protected JsonSerializerSettings JsonSerializerSettings => this._settings.Value;

  public Task<AuthResponse> AuthenticateAsync(AuthRequest body)
  {
    return this.AuthenticateAsync(body, CancellationToken.None);
  }

  public async Task<AuthResponse> AuthenticateAsync(
    AuthRequest body,
    CancellationToken cancellationToken)
  {
    StringBuilder stringBuilder1 = new StringBuilder();
    StringBuilder stringBuilder2 = stringBuilder1;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder2.Append(str1).Append("/Authenticate");
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    AuthResponse authResponse;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        StringContent stringContent = new StringContent(JsonConvert.SerializeObject((object) body, this._settings.Value));
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));
        request_.RequestUri = new Uri(stringBuilder1.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((Func<KeyValuePair<string, IEnumerable<string>>, string>) (h_ => h_.Key), (Func<KeyValuePair<string, IEnumerable<string>>, IEnumerable<string>>) (h_ => h_.Value));
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          if (status_ == 200)
          {
            DataCaptureClientApi.ObjectResponseResult<AuthResponse> objectResponseResult = await this.ReadObjectResponseAsync<AuthResponse>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
            authResponse = objectResponseResult.Object != null ? objectResponseResult.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
          else
          {
            string str2;
            if (response_.Content == null)
              str2 = (string) null;
            else
              str2 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
            string response = str2;
            throw new ApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return authResponse;
  }

  public Task<AcordDataCapturedResults> OCRFileDataAndParseToNetRateRequestAsync(
    OCRNetRateRequestInput body)
  {
    return this.OCRFileDataAndParseToNetRateRequestAsync(body, CancellationToken.None);
  }

  public async Task<AcordDataCapturedResults> OCRFileDataAndParseToNetRateRequestAsync(
    OCRNetRateRequestInput body,
    CancellationToken cancellationToken)
  {
    StringBuilder stringBuilder1 = new StringBuilder();
    StringBuilder stringBuilder2 = stringBuilder1;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder2.Append(str1).Append("/DataCapture/OCRFileDataAndParseToNetRateRequest");
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    AcordDataCapturedResults rateRequestAsync;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        StringContent stringContent = new StringContent(JsonConvert.SerializeObject((object) body, this._settings.Value));
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));
        request_.RequestUri = new Uri(stringBuilder1.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((Func<KeyValuePair<string, IEnumerable<string>>, string>) (h_ => h_.Key), (Func<KeyValuePair<string, IEnumerable<string>>, IEnumerable<string>>) (h_ => h_.Value));
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              DataCaptureClientApi.ObjectResponseResult<AcordDataCapturedResults> objectResponseResult1 = await this.ReadObjectResponseAsync<AcordDataCapturedResults>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              rateRequestAsync = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 401:
              DataCaptureClientApi.ObjectResponseResult<ProblemDetails> objectResponseResult2 = await this.ReadObjectResponseAsync<ProblemDetails>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<ProblemDetails>("Unauthorized Access.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            default:
              string str2;
              if (response_.Content == null)
                str2 = (string) null;
              else
                str2 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str2;
              throw new ApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return rateRequestAsync;
  }

  public Task<string> OCRFileDataAndParseToNetRateRequestXmlAsync(OCRNetRateRequestInput body)
  {
    return this.OCRFileDataAndParseToNetRateRequestXmlAsync(body, CancellationToken.None);
  }

  public async Task<string> OCRFileDataAndParseToNetRateRequestXmlAsync(
    OCRNetRateRequestInput body,
    CancellationToken cancellationToken)
  {
    StringBuilder stringBuilder1 = new StringBuilder();
    StringBuilder stringBuilder2 = stringBuilder1;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder2.Append(str1).Append("/DataCapture/OCRFileDataAndParseToNetRateRequest");
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    string rateRequestXmlAsync;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        StringContent stringContent = new StringContent(JsonConvert.SerializeObject((object) body, this._settings.Value));
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/xml"));
        request_.RequestUri = new Uri(stringBuilder1.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((Func<KeyValuePair<string, IEnumerable<string>>, string>) (h_ => h_.Key), (Func<KeyValuePair<string, IEnumerable<string>>, IEnumerable<string>>) (h_ => h_.Value));
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              if (response_ == null || response_.Content == null)
                throw new ApiException("Response was null which was not expected.", status_, "", (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              rateRequestXmlAsync = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              break;
            case 401:
              DataCaptureClientApi.ObjectResponseResult<ProblemDetails> objectResponseResult = await this.ReadObjectResponseAsync<ProblemDetails>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<ProblemDetails>("Unauthorized Access.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
            default:
              string str2;
              if (response_.Content == null)
                str2 = (string) null;
              else
                str2 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str2;
              throw new ApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return rateRequestXmlAsync;
  }

  public Task<BaseResponse> OCRFileDataQueueAsync(OCRQueueRequestInput body)
  {
    return this.OCRFileDataQueueAsync(body, CancellationToken.None);
  }

  public async Task<BaseResponse> OCRFileDataQueueAsync(
    OCRQueueRequestInput body,
    CancellationToken cancellationToken)
  {
    StringBuilder stringBuilder1 = new StringBuilder();
    StringBuilder stringBuilder2 = stringBuilder1;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder2.Append(str1).Append("/DataCapture/OCRFileDataQueue");
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    BaseResponse baseResponse;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        StringContent stringContent = new StringContent(JsonConvert.SerializeObject((object) body, this._settings.Value));
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));
        request_.RequestUri = new Uri(stringBuilder1.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((Func<KeyValuePair<string, IEnumerable<string>>, string>) (h_ => h_.Key), (Func<KeyValuePair<string, IEnumerable<string>>, IEnumerable<string>>) (h_ => h_.Value));
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              DataCaptureClientApi.ObjectResponseResult<BaseResponse> objectResponseResult1 = await this.ReadObjectResponseAsync<BaseResponse>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              baseResponse = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 401:
              DataCaptureClientApi.ObjectResponseResult<ProblemDetails> objectResponseResult2 = await this.ReadObjectResponseAsync<ProblemDetails>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<ProblemDetails>("Unauthorized", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            default:
              string str2;
              if (response_.Content == null)
                str2 = (string) null;
              else
                str2 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str2;
              throw new ApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return baseResponse;
  }

  public Task<ClarionDoor_ServiceResponse> RenewalAsync(string jsonBody)
  {
    return this.RenewalAsync(jsonBody, CancellationToken.None);
  }

  public async Task<ClarionDoor_ServiceResponse> RenewalAsync(
    string jsonBody,
    CancellationToken cancellationToken)
  {
    StringBuilder stringBuilder1 = new StringBuilder();
    StringBuilder stringBuilder2 = stringBuilder1;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder2.Append(str1).Append("/ClarionDoor/Renewal");
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    ClarionDoor_ServiceResponse doorServiceResponse;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        StringContent stringContent = new StringContent(jsonBody);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));
        request_.RequestUri = new Uri(stringBuilder1.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((Func<KeyValuePair<string, IEnumerable<string>>, string>) (h_ => h_.Key), (Func<KeyValuePair<string, IEnumerable<string>>, IEnumerable<string>>) (h_ => h_.Value));
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              DataCaptureClientApi.ObjectResponseResult<ClarionDoor_ServiceResponse> objectResponseResult1 = await this.ReadObjectResponseAsync<ClarionDoor_ServiceResponse>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              doorServiceResponse = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 401:
              DataCaptureClientApi.ObjectResponseResult<ProblemDetails> objectResponseResult2 = await this.ReadObjectResponseAsync<ProblemDetails>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<ProblemDetails>("Unauthorized", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            default:
              string str2;
              if (response_.Content == null)
                str2 = (string) null;
              else
                str2 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str2;
              throw new ApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return doorServiceResponse;
  }

  public Task<ClarionDoor_ServiceResponse> CancellationAsync(string jsonBody)
  {
    return this.CancellationAsync(jsonBody, CancellationToken.None);
  }

  public async Task<ClarionDoor_ServiceResponse> CancellationAsync(
    string jsonBody,
    CancellationToken cancellationToken)
  {
    StringBuilder stringBuilder1 = new StringBuilder();
    StringBuilder stringBuilder2 = stringBuilder1;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder2.Append(str1).Append("/ClarionDoor/Cancellation");
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    ClarionDoor_ServiceResponse doorServiceResponse;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        StringContent stringContent = new StringContent(jsonBody);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));
        request_.RequestUri = new Uri(stringBuilder1.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((Func<KeyValuePair<string, IEnumerable<string>>, string>) (h_ => h_.Key), (Func<KeyValuePair<string, IEnumerable<string>>, IEnumerable<string>>) (h_ => h_.Value));
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              DataCaptureClientApi.ObjectResponseResult<ClarionDoor_ServiceResponse> objectResponseResult1 = await this.ReadObjectResponseAsync<ClarionDoor_ServiceResponse>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              doorServiceResponse = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 401:
              DataCaptureClientApi.ObjectResponseResult<ProblemDetails> objectResponseResult2 = await this.ReadObjectResponseAsync<ProblemDetails>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<ProblemDetails>("Unauthorized", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            default:
              string str2;
              if (response_.Content == null)
                str2 = (string) null;
              else
                str2 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str2;
              throw new ApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return doorServiceResponse;
  }

  public Task<ClarionDoor_ServiceResponse> ReinstatementAsync(string jsonBody)
  {
    return this.ReinstatementAsync(jsonBody, CancellationToken.None);
  }

  public async Task<ClarionDoor_ServiceResponse> ReinstatementAsync(
    string jsonBody,
    CancellationToken cancellationToken)
  {
    StringBuilder stringBuilder1 = new StringBuilder();
    StringBuilder stringBuilder2 = stringBuilder1;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder2.Append(str1).Append("/ClarionDoor/Reinstatement");
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    ClarionDoor_ServiceResponse doorServiceResponse;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        StringContent stringContent = new StringContent(jsonBody);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));
        request_.RequestUri = new Uri(stringBuilder1.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((Func<KeyValuePair<string, IEnumerable<string>>, string>) (h_ => h_.Key), (Func<KeyValuePair<string, IEnumerable<string>>, IEnumerable<string>>) (h_ => h_.Value));
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              DataCaptureClientApi.ObjectResponseResult<ClarionDoor_ServiceResponse> objectResponseResult1 = await this.ReadObjectResponseAsync<ClarionDoor_ServiceResponse>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              doorServiceResponse = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 401:
              DataCaptureClientApi.ObjectResponseResult<ProblemDetails> objectResponseResult2 = await this.ReadObjectResponseAsync<ProblemDetails>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<ProblemDetails>("Unauthorized", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            default:
              string str2;
              if (response_.Content == null)
                str2 = (string) null;
              else
                str2 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str2;
              throw new ApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return doorServiceResponse;
  }

  public Task<ClarionDoor_ServiceResponse> EndorsementAsync(string jsonBody)
  {
    return this.EndorsementAsync(jsonBody, CancellationToken.None);
  }

  public async Task<ClarionDoor_ServiceResponse> EndorsementAsync(
    string jsonBody,
    CancellationToken cancellationToken)
  {
    StringBuilder stringBuilder1 = new StringBuilder();
    StringBuilder stringBuilder2 = stringBuilder1;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder2.Append(str1).Append("/ClarionDoor/Endorsement");
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    ClarionDoor_ServiceResponse doorServiceResponse;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        StringContent stringContent = new StringContent(jsonBody);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));
        request_.RequestUri = new Uri(stringBuilder1.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((Func<KeyValuePair<string, IEnumerable<string>>, string>) (h_ => h_.Key), (Func<KeyValuePair<string, IEnumerable<string>>, IEnumerable<string>>) (h_ => h_.Value));
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              DataCaptureClientApi.ObjectResponseResult<ClarionDoor_ServiceResponse> objectResponseResult1 = await this.ReadObjectResponseAsync<ClarionDoor_ServiceResponse>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              doorServiceResponse = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 401:
              DataCaptureClientApi.ObjectResponseResult<ProblemDetails> objectResponseResult2 = await this.ReadObjectResponseAsync<ProblemDetails>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<ProblemDetails>("Unauthorized", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            default:
              string str2;
              if (response_.Content == null)
                str2 = (string) null;
              else
                str2 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str2;
              throw new ApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return doorServiceResponse;
  }

  public Task<ClarionDoor_ServiceResponse> GetClarionDoorResponseAsync(string jsonBody)
  {
    return this.GetClarionDoorResponseAsync(jsonBody, CancellationToken.None);
  }

  public async Task<ClarionDoor_ServiceResponse> GetClarionDoorResponseAsync(
    string jsonBody,
    CancellationToken cancellationToken)
  {
    StringBuilder stringBuilder1 = new StringBuilder();
    StringBuilder stringBuilder2 = stringBuilder1;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder2.Append(str1).Append("/ClarionDoor/GetClarionDoorResponse");
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    ClarionDoor_ServiceResponse doorResponseAsync;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        StringContent stringContent = new StringContent(jsonBody);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));
        request_.RequestUri = new Uri(stringBuilder1.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((Func<KeyValuePair<string, IEnumerable<string>>, string>) (h_ => h_.Key), (Func<KeyValuePair<string, IEnumerable<string>>, IEnumerable<string>>) (h_ => h_.Value));
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              DataCaptureClientApi.ObjectResponseResult<ClarionDoor_ServiceResponse> objectResponseResult1 = await this.ReadObjectResponseAsync<ClarionDoor_ServiceResponse>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              doorResponseAsync = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 401:
              DataCaptureClientApi.ObjectResponseResult<ProblemDetails> objectResponseResult2 = await this.ReadObjectResponseAsync<ProblemDetails>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<ProblemDetails>("Unauthorized", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            default:
              string str2;
              if (response_.Content == null)
                str2 = (string) null;
              else
                str2 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str2;
              throw new ApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return doorResponseAsync;
  }

  public bool ReadResponseAsString { get; set; }

  protected virtual async Task<DataCaptureClientApi.ObjectResponseResult<T>> ReadObjectResponseAsync<T>(
    HttpResponseMessage response,
    IReadOnlyDictionary<string, IEnumerable<string>> headers)
  {
    if (response == null || response.Content == null)
      return new DataCaptureClientApi.ObjectResponseResult<T>(default (T), string.Empty);
    if (this.ReadResponseAsString)
    {
      string str = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
      try
      {
        return new DataCaptureClientApi.ObjectResponseResult<T>(JsonConvert.DeserializeObject<T>(str, this.JsonSerializerSettings), str);
      }
      catch (JsonException ex)
      {
        throw new ApiException($"Could not deserialize the response body string as {typeof (T).FullName}.", (int) response.StatusCode, str, headers, (Exception) ex);
      }
    }
    else
    {
      try
      {
        using (Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
        {
          using (StreamReader streamReader = new StreamReader(stream))
          {
            using (JsonTextReader jsonTextReader = new JsonTextReader((TextReader) streamReader))
              return new DataCaptureClientApi.ObjectResponseResult<T>(JsonSerializer.Create(this.JsonSerializerSettings).Deserialize<T>((JsonReader) jsonTextReader), string.Empty);
          }
        }
      }
      catch (JsonException ex)
      {
        throw new ApiException($"Could not deserialize the response body stream as {typeof (T).FullName}.", (int) response.StatusCode, string.Empty, headers, (Exception) ex);
      }
    }
  }

  private string ConvertToString(object value, CultureInfo cultureInfo)
  {
    switch (value)
    {
      case null:
        return (string) null;
      case Enum _:
        string name = Enum.GetName(value.GetType(), value);
        if (name != null)
        {
          FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
          if (!(declaredField != (FieldInfo) null) || !(declaredField.GetCustomAttribute(typeof (EnumMemberAttribute)) is EnumMemberAttribute customAttribute))
            return Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), (IFormatProvider) cultureInfo));
          return customAttribute.Value == null ? name : customAttribute.Value;
        }
        break;
      case bool flag:
        return Convert.ToString(flag, (IFormatProvider) cultureInfo).ToLowerInvariant();
      case byte[] _:
        return Convert.ToBase64String((byte[]) value);
      default:
        if (value.GetType().IsArray)
          return string.Join(",", ((Array) value).OfType<object>().Select<object, string>((Func<object, string>) (o => this.ConvertToString(o, cultureInfo))));
        break;
    }
    return Convert.ToString(value, (IFormatProvider) cultureInfo) ?? string.Empty;
  }

  protected struct ObjectResponseResult<T>(T responseObject, string responseText)
  {
    public T Object { get; } = responseObject;

    public string Text { get; } = responseText;
  }
}
