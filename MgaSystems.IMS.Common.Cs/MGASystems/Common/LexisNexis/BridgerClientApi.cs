// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.BridgerClientApi
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace MGASystems.Common.LexisNexis;

public class BridgerClientApi
{
  private static HttpClient _httpClient = new HttpClient()
  {
    Timeout = TimeSpan.FromMinutes(3.0)
  };
  private static HashSet<string> ClientServicePoints = new HashSet<string>();
  public static OAuth2Token CachedToken = (OAuth2Token) null;
  protected Lazy<JsonSerializerSettings> _settings;

  public BridgerClientApi(string baseUrl, string xApiKey)
  {
    if (!string.IsNullOrEmpty(baseUrl))
      this.BaseUrl = baseUrl;
    this.XApiKey = xApiKey;
    this.ClientToken = BridgerClientApi.CachedToken;
    Uri result;
    if (Uri.TryCreate(this.BaseUrl, UriKind.Absolute, out result))
    {
      string components = result.GetComponents(UriComponents.SchemeAndServer, UriFormat.Unescaped);
      if (components != null && !BridgerClientApi.ClientServicePoints.Contains(components))
      {
        ServicePoint servicePoint = ServicePointManager.FindServicePoint(new Uri(components));
        servicePoint.ConnectionLeaseTimeout = (int) TimeSpan.FromMinutes(5.0).TotalMilliseconds;
        servicePoint.ConnectionLimit = 10;
        BridgerClientApi.ClientServicePoints.Add(components);
      }
    }
    this._settings = new Lazy<JsonSerializerSettings>(new Func<JsonSerializerSettings>(this.CreateSerializerSettings));
  }

  protected JsonSerializerSettings CreateSerializerSettings()
  {
    JsonSerializerSettings settings = new JsonSerializerSettings();
    this.UpdateJsonSerializerSettings(settings);
    return settings;
  }

  public string BaseUrl { get; private set; } = "https://bridgerstaging.lexisnexis.com/LN.WebServices";

  public OAuth2Token ClientToken { get; private set; }

  public string XApiKey { get; private set; }

  public HttpClient HttpClient => BridgerClientApi._httpClient;

  protected JsonSerializerSettings JsonSerializerSettings => this._settings.Value;

  protected virtual void UpdateJsonSerializerSettings(JsonSerializerSettings settings)
  {
  }

  protected virtual void PrepareRequest(
    HttpClient client,
    HttpRequestMessage request,
    StringBuilder urlBuilder)
  {
  }

  protected virtual void PrepareRequest(HttpClient client, HttpRequestMessage request, string url)
  {
    this.ClientToken = this.ClientToken ?? BridgerClientApi.CachedToken;
    if (string.IsNullOrEmpty(this.XApiKey))
      throw new ArgumentNullException("Missing X-API-Key", "XApiKey");
    if (this.ClientToken == null)
      throw new InvalidOperationException("Missing authentication; Authenticate using BridgerClientApi.IssueAsync first.");
    request.Headers.Authorization = new AuthenticationHeaderValue(BridgerClientApi.CachedToken.Token_type, BridgerClientApi.CachedToken.Access_token);
    request.Headers.Add("X-API-Key", this.XApiKey);
  }

  public Action<string> RequestJsonCreated { get; set; }

  public Action<string> ResponseJsonCreated { get; set; }

  protected virtual void ProcessResponse(HttpClient client, HttpResponseMessage response)
  {
  }

  protected string ConvertToString(object value, CultureInfo cultureInfo)
  {
    switch (value)
    {
      case null:
        return (string) null;
      case System.Enum _:
        string name = System.Enum.GetName(value.GetType(), value);
        if (name != null)
        {
          FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
          if (!(declaredField != (FieldInfo) null) || !(declaredField.GetCustomAttribute(typeof (EnumMemberAttribute)) is EnumMemberAttribute customAttribute))
            return Convert.ToString(Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), (IFormatProvider) cultureInfo));
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

  public bool ReadResponseAsString { get; set; } = true;

  protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(
    HttpResponseMessage response,
    IReadOnlyDictionary<string, IEnumerable<string>> headers)
  {
    if (response == null || response.Content == null)
      return new ObjectResponseResult<T>(default (T), string.Empty);
    if (this.ReadResponseAsString)
    {
      string str = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
      try
      {
        Action<string> responseJsonCreated = this.ResponseJsonCreated;
        if (responseJsonCreated != null)
          responseJsonCreated(str);
        return !(typeof (T) == typeof (string)) || str == null || str.StartsWith("\"") || str.EndsWith("\"") ? new ObjectResponseResult<T>(JsonConvert.DeserializeObject<T>(str, this.JsonSerializerSettings), str) : new ObjectResponseResult<T>((T) str, str);
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
              return new ObjectResponseResult<T>(JsonSerializer.Create(this.JsonSerializerSettings).Deserialize<T>((JsonReader) jsonTextReader), string.Empty);
          }
        }
      }
      catch (JsonException ex)
      {
        throw new ApiException($"Could not deserialize the response body stream as {typeof (T).FullName}.", (int) response.StatusCode, string.Empty, headers, (Exception) ex);
      }
    }
  }

  public Task<FileResponse> PhotoAsync(long id) => this.PhotoAsync(id, CancellationToken.None);

  public async Task<FileResponse> PhotoAsync(long id, CancellationToken cancellationToken)
  {
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/Entity/Photo/{id}");
    urlBuilder.Replace("{id}", Uri.EscapeDataString(this.ConvertToString((object) id, CultureInfo.InvariantCulture)));
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    FileResponse fileResponse;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("image/png"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          if (status_ == 200 || status_ == 206)
          {
            fileResponse = (FileResponse) null;
          }
          else
          {
            if (status_ == 500)
            {
              string response;
              if (response_.Content == null)
                response = string.Empty;
              else
                response = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              throw new ApiException("InternalServerError", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
            }
            string str3;
            if (response_.Content == null)
              str3 = (string) null;
            else
              str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
            string response1 = str3;
            throw new ApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response1, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
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
    return fileResponse;
  }

  public Task<long> ResultRecordAsync(AddResultRecordRequest addResultRequest)
  {
    return this.ResultRecordAsync(addResultRequest, CancellationToken.None);
  }

  public async Task<long> ResultRecordAsync(
    AddResultRecordRequest addResultRequest,
    CancellationToken cancellationToken)
  {
    if (addResultRequest == null)
      throw new ArgumentNullException(nameof (addResultRequest));
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/ListMaintenance/ResultRecord");
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    long num1;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        string content = JsonConvert.SerializeObject((object) addResultRequest, this._settings.Value);
        Action<string> requestJsonCreated = this.RequestJsonCreated;
        if (requestJsonCreated != null)
          requestJsonCreated(content);
        StringContent stringContent = new StringContent(content);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("PUT");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              ObjectResponseResult<long> objectResponseResult1 = await this.ReadObjectResponseAsync<long>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              long num2 = objectResponseResult1.Object;
              num1 = objectResponseResult1.Object;
              break;
            case 400:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("BadRequest", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult3 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult3.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult3.Object, (Exception) null);
            default:
              string str3;
              if (response_.Content == null)
                str3 = (string) null;
              else
                str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str3;
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
    return num1;
  }

  public Task<ICollection<ListInfo>> SearchListsAsync(SearchListsRequest searchListsRequest)
  {
    return this.SearchListsAsync(searchListsRequest, CancellationToken.None);
  }

  public async Task<ICollection<ListInfo>> SearchListsAsync(
    SearchListsRequest searchListsRequest,
    CancellationToken cancellationToken)
  {
    if (searchListsRequest == null)
      throw new ArgumentNullException(nameof (searchListsRequest));
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/ListMaintenance/SearchLists");
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    ICollection<ListInfo> listInfos;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        string content = JsonConvert.SerializeObject((object) searchListsRequest, this._settings.Value);
        Action<string> requestJsonCreated = this.RequestJsonCreated;
        if (requestJsonCreated != null)
          requestJsonCreated(content);
        StringContent stringContent = new StringContent(content);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              ObjectResponseResult<ICollection<ListInfo>> objectResponseResult1 = await this.ReadObjectResponseAsync<ICollection<ListInfo>>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              listInfos = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 400:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("BadRequest", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult3 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult3.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult3.Object, (Exception) null);
            default:
              string str3;
              if (response_.Content == null)
                str3 = (string) null;
              else
                str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str3;
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
    return listInfos;
  }

  public Task<bool> IndexListAsync(IndexListRequest indexListRequest)
  {
    return this.IndexListAsync(indexListRequest, CancellationToken.None);
  }

  public async Task<bool> IndexListAsync(
    IndexListRequest indexListRequest,
    CancellationToken cancellationToken)
  {
    if (indexListRequest == null)
      throw new ArgumentNullException(nameof (indexListRequest));
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/ListMaintenance/IndexList");
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    bool flag;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        string content = JsonConvert.SerializeObject((object) indexListRequest, this._settings.Value);
        Action<string> requestJsonCreated = this.RequestJsonCreated;
        if (requestJsonCreated != null)
          requestJsonCreated(content);
        StringContent stringContent = new StringContent(content);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              ObjectResponseResult<bool> objectResponseResult1 = await this.ReadObjectResponseAsync<bool>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              int num = objectResponseResult1.Object ? 1 : 0;
              flag = objectResponseResult1.Object;
              break;
            case 400:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("BadRequest", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult3 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult3.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult3.Object, (Exception) null);
            default:
              string str3;
              if (response_.Content == null)
                str3 = (string) null;
              else
                str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str3;
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
    return flag;
  }

  public Task<long> AddListAsync(AddListRequest addListRequest)
  {
    return this.AddListAsync(addListRequest, CancellationToken.None);
  }

  public async Task<long> AddListAsync(
    AddListRequest addListRequest,
    CancellationToken cancellationToken)
  {
    if (addListRequest == null)
      throw new ArgumentNullException(nameof (addListRequest));
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/ListMaintenance/AddList");
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    long num1;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        string content = JsonConvert.SerializeObject((object) addListRequest, this._settings.Value);
        Action<string> requestJsonCreated = this.RequestJsonCreated;
        if (requestJsonCreated != null)
          requestJsonCreated(content);
        StringContent stringContent = new StringContent(content);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              ObjectResponseResult<long> objectResponseResult1 = await this.ReadObjectResponseAsync<long>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              long num2 = objectResponseResult1.Object;
              num1 = objectResponseResult1.Object;
              break;
            case 400:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("BadRequest", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult3 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult3.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult3.Object, (Exception) null);
            default:
              string str3;
              if (response_.Content == null)
                str3 = (string) null;
              else
                str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str3;
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
    return num1;
  }

  public Task<bool> DeleteListAsync(long id) => this.DeleteListAsync(id, CancellationToken.None);

  public async Task<bool> DeleteListAsync(long id, CancellationToken cancellationToken)
  {
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/ListMaintenance/DeleteList/{id}");
    urlBuilder.Replace("{id}", Uri.EscapeDataString(this.ConvertToString((object) id, CultureInfo.InvariantCulture)));
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    bool flag;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("DELETE");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              ObjectResponseResult<bool> objectResponseResult1 = await this.ReadObjectResponseAsync<bool>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              int num = objectResponseResult1.Object ? 1 : 0;
              flag = objectResponseResult1.Object;
              break;
            case 400:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("BadRequest", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult3 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult3.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult3.Object, (Exception) null);
            default:
              string str3;
              if (response_.Content == null)
                str3 = (string) null;
              else
                str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str3;
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
    return flag;
  }

  public Task<bool> UpdateListAsync(UpdateListRequest updateListRequest)
  {
    return this.UpdateListAsync(updateListRequest, CancellationToken.None);
  }

  public async Task<bool> UpdateListAsync(
    UpdateListRequest updateListRequest,
    CancellationToken cancellationToken)
  {
    if (updateListRequest == null)
      throw new ArgumentNullException(nameof (updateListRequest));
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/ListMaintenance/UpdateList");
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    bool flag;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        string content = JsonConvert.SerializeObject((object) updateListRequest, this._settings.Value);
        Action<string> requestJsonCreated = this.RequestJsonCreated;
        if (requestJsonCreated != null)
          requestJsonCreated(content);
        StringContent stringContent = new StringContent(content);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              ObjectResponseResult<bool> objectResponseResult1 = await this.ReadObjectResponseAsync<bool>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              int num = objectResponseResult1.Object ? 1 : 0;
              flag = objectResponseResult1.Object;
              break;
            case 400:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("BadRequest", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult3 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult3.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult3.Object, (Exception) null);
            default:
              string str3;
              if (response_.Content == null)
                str3 = (string) null;
              else
                str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str3;
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
    return flag;
  }

  public Task<ListInfo> ListAsync(long id) => this.ListAsync(id, CancellationToken.None);

  public async Task<ListInfo> ListAsync(long id, CancellationToken cancellationToken)
  {
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/ListMaintenance/List/{id}");
    urlBuilder.Replace("{id}", Uri.EscapeDataString(this.ConvertToString((object) id, CultureInfo.InvariantCulture)));
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    ListInfo listInfo;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              ObjectResponseResult<ListInfo> objectResponseResult1 = await this.ReadObjectResponseAsync<ListInfo>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              listInfo = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 400:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("BadRequest", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult3 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult3.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult3.Object, (Exception) null);
            default:
              string str3;
              if (response_.Content == null)
                str3 = (string) null;
              else
                str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str3;
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
    return listInfo;
  }

  public Task<SearchResults> SearchAsync(EntitySearchRequest entitySearchRequest)
  {
    return this.SearchAsync(entitySearchRequest, CancellationToken.None);
  }

  public async Task<SearchResults> SearchAsync(
    EntitySearchRequest entitySearchRequest,
    CancellationToken cancellationToken)
  {
    if (entitySearchRequest == null)
      throw new ArgumentNullException(nameof (entitySearchRequest));
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/Lists/Search");
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    SearchResults searchResults;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        string content = JsonConvert.SerializeObject((object) entitySearchRequest, this._settings.Value);
        Action<string> requestJsonCreated = this.RequestJsonCreated;
        if (requestJsonCreated != null)
          requestJsonCreated(content);
        StringContent stringContent = new StringContent(content);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              ObjectResponseResult<SearchResults> objectResponseResult1 = await this.ReadObjectResponseAsync<SearchResults>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              searchResults = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 400:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("BadRequest", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult3 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult3.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult3.Object, (Exception) null);
            default:
              string str3;
              if (response_.Content == null)
                str3 = (string) null;
              else
                str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str3;
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
    return searchResults;
  }

  public Task<ICollection<DataFileInfo>> DataFilesAsync(ClientContext context)
  {
    return this.DataFilesAsync(context, CancellationToken.None);
  }

  public async Task<ICollection<DataFileInfo>> DataFilesAsync(
    ClientContext context,
    CancellationToken cancellationToken)
  {
    if (context == null)
      throw new ArgumentNullException(nameof (context));
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/Lists/DataFiles");
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    ICollection<DataFileInfo> dataFileInfos;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        string content = JsonConvert.SerializeObject((object) context, this._settings.Value);
        Action<string> requestJsonCreated = this.RequestJsonCreated;
        if (requestJsonCreated != null)
          requestJsonCreated(content);
        StringContent stringContent = new StringContent(content);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              ObjectResponseResult<ICollection<DataFileInfo>> objectResponseResult1 = await this.ReadObjectResponseAsync<ICollection<DataFileInfo>>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              dataFileInfos = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 400:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("BadRequest", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            case 401:
              ObjectResponseResult<string> objectResponseResult3 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult3.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("Unauthorized", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult3.Object, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult4 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult4.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult4.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult4.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult4.Object, (Exception) null);
            default:
              string str3;
              if (response_.Content == null)
                str3 = (string) null;
              else
                str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str3;
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
    return dataFileInfos;
  }

  public Task<ICollection<ResultRecord>> RecordsAsync(ResultRecordsRequest resultRecordsRequest)
  {
    return this.RecordsAsync(resultRecordsRequest, CancellationToken.None);
  }

  public async Task<ICollection<ResultRecord>> RecordsAsync(
    ResultRecordsRequest resultRecordsRequest,
    CancellationToken cancellationToken)
  {
    if (resultRecordsRequest == null)
      throw new ArgumentNullException(nameof (resultRecordsRequest));
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/Results/Records");
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    ICollection<ResultRecord> resultRecords;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        string content = JsonConvert.SerializeObject((object) resultRecordsRequest, this._settings.Value);
        Action<string> requestJsonCreated = this.RequestJsonCreated;
        if (requestJsonCreated != null)
          requestJsonCreated(content);
        StringContent stringContent = new StringContent(content);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              ObjectResponseResult<ICollection<ResultRecord>> objectResponseResult1 = await this.ReadObjectResponseAsync<ICollection<ResultRecord>>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              resultRecords = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 400:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("BadRequest", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult3 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult3.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult3.Object, (Exception) null);
            default:
              string str3;
              if (response_.Content == null)
                str3 = (string) null;
              else
                str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str3;
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
    return resultRecords;
  }

  public Task<ICollection<RunInfo>> SearchRunsAsync(ResultRunsRequest resultRunsRequestequest)
  {
    return this.SearchRunsAsync(resultRunsRequestequest, CancellationToken.None);
  }

  public async Task<ICollection<RunInfo>> SearchRunsAsync(
    ResultRunsRequest resultRunsRequestequest,
    CancellationToken cancellationToken)
  {
    if (resultRunsRequestequest == null)
      throw new ArgumentNullException(nameof (resultRunsRequestequest));
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/Results/SearchRuns");
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    ICollection<RunInfo> runInfos;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        string content = JsonConvert.SerializeObject((object) resultRunsRequestequest, this._settings.Value);
        Action<string> requestJsonCreated = this.RequestJsonCreated;
        if (requestJsonCreated != null)
          requestJsonCreated(content);
        StringContent stringContent = new StringContent(content);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              ObjectResponseResult<ICollection<RunInfo>> objectResponseResult1 = await this.ReadObjectResponseAsync<ICollection<RunInfo>>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              runInfos = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 400:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("BadRequest", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult3 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult3.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult3.Object, (Exception) null);
            default:
              string str3;
              if (response_.Content == null)
                str3 = (string) null;
              else
                str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str3;
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
    return runInfos;
  }

  public Task<SearchRecordResults> SearchRecordsAsync(
    SearchResultRecordsRequest searchResultRecordsRequest)
  {
    return this.SearchRecordsAsync(searchResultRecordsRequest, CancellationToken.None);
  }

  public async Task<SearchRecordResults> SearchRecordsAsync(
    SearchResultRecordsRequest searchResultRecordsRequest,
    CancellationToken cancellationToken)
  {
    if (searchResultRecordsRequest == null)
      throw new ArgumentNullException(nameof (searchResultRecordsRequest));
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/Results/SearchRecords");
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    SearchRecordResults searchRecordResults;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        string content = JsonConvert.SerializeObject((object) searchResultRecordsRequest, this._settings.Value);
        Action<string> requestJsonCreated = this.RequestJsonCreated;
        if (requestJsonCreated != null)
          requestJsonCreated(content);
        StringContent stringContent = new StringContent(content);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              ObjectResponseResult<SearchRecordResults> objectResponseResult1 = await this.ReadObjectResponseAsync<SearchRecordResults>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              searchRecordResults = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 400:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("BadRequest", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult3 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult3.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult3.Object, (Exception) null);
            default:
              string str3;
              if (response_.Content == null)
                str3 = (string) null;
              else
                str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str3;
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
    return searchRecordResults;
  }

  public Task<bool> SetRecordStateAsync(SetRecordStateRequest setRecordStateRequest)
  {
    return this.SetRecordStateAsync(setRecordStateRequest, CancellationToken.None);
  }

  public async Task<bool> SetRecordStateAsync(
    SetRecordStateRequest setRecordStateRequest,
    CancellationToken cancellationToken)
  {
    if (setRecordStateRequest == null)
      throw new ArgumentNullException(nameof (setRecordStateRequest));
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/Results/SetRecordState");
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    bool flag;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        string content = JsonConvert.SerializeObject((object) setRecordStateRequest, this._settings.Value);
        Action<string> requestJsonCreated = this.RequestJsonCreated;
        if (requestJsonCreated != null)
          requestJsonCreated(content);
        StringContent stringContent = new StringContent(content);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              ObjectResponseResult<bool> objectResponseResult1 = await this.ReadObjectResponseAsync<bool>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              int num = objectResponseResult1.Object ? 1 : 0;
              flag = objectResponseResult1.Object;
              break;
            case 400:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("BadRequest", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult3 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult3.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult3.Object, (Exception) null);
            default:
              string str3;
              if (response_.Content == null)
                str3 = (string) null;
              else
                str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str3;
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
    return flag;
  }

  public Task<RunInfo> RunInfoAsync(long id) => this.RunInfoAsync(id, CancellationToken.None);

  public async Task<RunInfo> RunInfoAsync(long id, CancellationToken cancellationToken)
  {
    StringBuilder urlBuilder = new StringBuilder();
    StringBuilder stringBuilder = urlBuilder;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder.Append(str1).Append("/api/Results/RunInfo/{id}");
    urlBuilder.Replace("{id}", Uri.EscapeDataString(this.ConvertToString((object) id, CultureInfo.InvariantCulture)));
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    RunInfo runInfo;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        this.PrepareRequest(client_, request_, urlBuilder);
        string str2 = urlBuilder.ToString();
        request_.RequestUri = new Uri(str2, UriKind.RelativeOrAbsolute);
        this.PrepareRequest(client_, request_, str2);
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
          this.ProcessResponse(client_, response_);
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              ObjectResponseResult<RunInfo> objectResponseResult1 = await this.ReadObjectResponseAsync<RunInfo>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              runInfo = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 400:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("BadRequest", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult3 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult3.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult3.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult3.Object, (Exception) null);
            default:
              string str3;
              if (response_.Content == null)
                str3 = (string) null;
              else
                str3 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str3;
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
    return runInfo;
  }

  public Task<OAuth2Token> IssueAsync(string clientID, string userID, string password)
  {
    return this.IssueAsync(clientID, userID, password, CancellationToken.None);
  }

  public async Task<OAuth2Token> IssueAsync(
    string clientID,
    string userID,
    string password,
    CancellationToken cancellationToken)
  {
    StringBuilder stringBuilder1 = new StringBuilder();
    StringBuilder stringBuilder2 = stringBuilder1;
    string str1;
    if (this.BaseUrl == null)
      str1 = "";
    else
      str1 = this.BaseUrl.TrimEnd('/');
    stringBuilder2.Append(str1).Append("/api/Token/Issue");
    HttpClient client_ = this.HttpClient;
    bool disposeClient_ = false;
    OAuth2Token oauth2Token;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Content = (HttpContent) new StringContent(string.Empty, Encoding.UTF8, "application/json");
        request_.Method = new HttpMethod("POST");
        request_.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientID}/{userID}:{password}")));
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
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
              ObjectResponseResult<OAuth2Token> objectResponseResult1 = await this.ReadObjectResponseAsync<OAuth2Token>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              BridgerClientApi.CachedToken = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new ApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              DateTime? expireDate = (DateTime?) BridgerClientApi.CachedToken?.ExpireDate;
              if (expireDate.HasValue)
              {
                expireDate.GetValueOrDefault();
                Task.Delay(BridgerClientApi.CachedToken.ExpireDate.Value - DateTime.Now).ContinueWith<OAuth2Token>((Func<Task, OAuth2Token>) (t => BridgerClientApi.CachedToken = (OAuth2Token) null));
              }
              oauth2Token = objectResponseResult1.Object;
              break;
            case 401:
              string response1;
              if (response_.Content == null)
                response1 = string.Empty;
              else
                response1 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              throw new ApiException("Unauthorized", status_, response1, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
            case 500:
              ObjectResponseResult<string> objectResponseResult2 = await this.ReadObjectResponseAsync<string>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new ApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new ApiException<string>("InternalServerError", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            default:
              string str2;
              if (response_.Content == null)
                str2 = (string) null;
              else
                str2 = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response2 = str2;
              throw new ApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response2, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
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
    return oauth2Token;
  }
}
