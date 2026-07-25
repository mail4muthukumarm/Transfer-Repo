// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ComplyAdvantage.SanctionsChecker
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.ComplyAdvantage.Data;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Caching;
using System.Text;

#nullable disable
namespace MGASystems.Common.ComplyAdvantage;

public class SanctionsChecker
{
  private static readonly HttpClient _client = new HttpClient();
  private static readonly string DefaultCacheKey = typeof (SanctionsChecker).FullName + ".Default";
  private readonly Uri _uri;
  private readonly string _apiKey;
  private readonly TimeSpan _maxAge;
  private readonly bool _refreshExpired;
  private readonly string _notificationTo;
  private readonly Decimal _fuzziness;

  private string SearchesUri => Path.Combine(this._uri.AbsoluteUri, "searches");

  public static SanctionsChecker Default
  {
    get
    {
      if (!(MemoryCache.Default.Get(SanctionsChecker.DefaultCacheKey, (string) null) is SanctionsChecker sanctionsChecker))
      {
        string setting1 = SystemSettings.GetSetting<string>("ComplyAdvantage_URL");
        string setting2 = SystemSettings.GetSetting<string>("ComplyAdvantage_Key");
        if (setting1 == null || setting2 == null)
          return (SanctionsChecker) null;
        Decimal setting3 = SystemSettings.GetSetting<Decimal>("ComplyAdvantage_MaxAgeDays");
        string setting4 = SystemSettings.GetSetting<string>("ComplyAdvantage_NotificationTo");
        Decimal? setting5 = SystemSettings.GetSetting<Decimal?>("ComplyAdvantage_Fuzziness");
        bool? setting6 = SystemSettings.GetSetting<bool?>("ComplyAdvantage.Expired.RefreshSearch");
        sanctionsChecker = new SanctionsChecker(setting1, setting2, TimeSpan.FromDays((double) setting3), setting4, setting5.GetValueOrDefault(), setting6.GetValueOrDefault());
        MemoryCache.Default.AddOrGetExisting(SanctionsChecker.DefaultCacheKey, (object) sanctionsChecker, DateTimeOffset.Now.AddMinutes(15.0), (string) null);
      }
      return sanctionsChecker;
    }
  }

  public SanctionsChecker(
    string url,
    string apiKey,
    TimeSpan maxAge,
    string notificationTo = null,
    Decimal fuzziness = 0M,
    bool deleteExpired = false)
  {
    Uri uri = new Uri(url);
    string str1 = apiKey;
    TimeSpan timeSpan = maxAge;
    string str2 = notificationTo;
    Decimal num = fuzziness;
    bool flag = deleteExpired;
    this._uri = uri;
    this._apiKey = str1;
    this._maxAge = timeSpan;
    this._notificationTo = str2;
    this._fuzziness = num;
    this._refreshExpired = flag;
  }

  public SearchData CreateSearch(SearchRequest request)
  {
    HttpRequestMessage request1 = new HttpRequestMessage(HttpMethod.Post, this.SearchesUri ?? "")
    {
      Content = (HttpContent) new StringContent(JsonConvert.SerializeObject((object) request), Encoding.UTF8, "application/json")
    };
    request1.Headers.Authorization = new AuthenticationHeaderValue("Token", this._apiKey);
    try
    {
      HttpResponseMessage result = SanctionsChecker._client.SendAsync(request1, HttpCompletionOption.ResponseHeadersRead).Result;
      result.EnsureSuccessStatusCode();
      return JsonConvert.DeserializeObject<SearchResult>(result.Content.ReadAsStringAsync().Result).Content.Data;
    }
    catch (AggregateException ex)
    {
      foreach (Exception innerException in ex.InnerExceptions)
        ErrorHandler.SilentHandleError(innerException);
      throw;
    }
  }

  public SearchData CreateSearch(string searchTerm, Decimal fuzziness = 0M)
  {
    SearchData search = this.CreateSearch(new SearchRequest()
    {
      SearchTerm = searchTerm,
      Fuzziness = fuzziness,
      Filters = new SearchFilters(),
      ShareUrl = 1
    });
    search.LastSearched = new DateTimeOffset?(DateTimeOffset.Now);
    return search;
  }

  public SearchData GetSearch(int id)
  {
    HttpResponseMessage result = SanctionsChecker._client.SendAsync(new HttpRequestMessage(HttpMethod.Get, $"{this.SearchesUri}/{id}?share_url=1")
    {
      Headers = {
        Authorization = new AuthenticationHeaderValue("Token", this._apiKey)
      }
    }).Result;
    result.EnsureSuccessStatusCode();
    SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result.Content.ReadAsStringAsync().Result);
    searchResult.Content.Data.LastSearched = new DateTimeOffset?(DateTimeOffset.Now);
    return searchResult.Content.Data;
  }

  public SearchData UpdateSearch(int id, UpdateRequest request)
  {
    HttpRequestMessage request1 = new HttpRequestMessage(new HttpMethod("PATCH"), Path.Combine(this.SearchesUri, id.ToString()))
    {
      Content = (HttpContent) new StringContent(JsonConvert.SerializeObject((object) request))
    };
    request1.Headers.Authorization = new AuthenticationHeaderValue("Token", this._apiKey);
    HttpResponseMessage result = SanctionsChecker._client.SendAsync(request1).Result;
    result.EnsureSuccessStatusCode();
    SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result.Content.ReadAsStringAsync().Result);
    searchResult.Content.Data.LastSearched = new DateTimeOffset?(DateTimeOffset.Now);
    return searchResult.Content.Data;
  }

  public static bool DefaultIsCompliant(string searchTerm, Guid entityGuid)
  {
    return SanctionsChecker.Default == null || SanctionsChecker.Default.CheckCompliance(searchTerm, entityGuid).IsOk();
  }

  public bool IsCompliant(string searchTerm, Guid entityGuid)
  {
    return this.CheckCompliance(searchTerm, entityGuid).IsOk();
  }

  public SearchData CheckCompliance(string searchTerm, Guid entityGuid)
  {
    searchTerm = searchTerm.Trim();
    SearchData searchData = DefaultDatabase.ExecuteMappedObjectSelectMultiple<SearchData>(new System.Func<DataRow, SearchData>(SanctionsChecker.CreateFromDataRow<SearchData>), "where EntityGuid = @insuredGuid and SearchTerm = @searchTerm", new object[4]
    {
      (object) "@insuredGuid",
      (object) entityGuid,
      (object) "@searchTerm",
      (object) searchTerm
    }).SingleOrDefault<SearchData>();
    if (searchData == null)
    {
      searchData = this.CreateSearch(searchTerm, this._fuzziness);
      searchData.EntityGuid = entityGuid;
      DefaultDatabase.ExecuteMappedObject((TableMappingOperation) 1, (object) searchData);
      if (!searchData.IsOk())
        this.SendComplianceHitNotification(searchData);
    }
    else if (!searchData.IsOk() || searchData.OlderThan(this._maxAge))
    {
      if (searchData.IsOk() && this._refreshExpired)
      {
        DefaultDatabase.ExecuteMappedObject((TableMappingOperation) 3, (object) searchData);
        return this.CheckCompliance(searchTerm, entityGuid);
      }
      try
      {
        SearchData search = this.GetSearch(searchData.Id);
        search.EntityGuid = entityGuid;
        DefaultDatabase.ExecuteMappedObject((TableMappingOperation) 2, (object) search);
        searchData = search;
      }
      catch (HttpRequestException ex) when (ex.Message.ContainsNoCase("401 (Unauthorized)"))
      {
        ex.Data.Add((object) "SanctionsChecker.SearchTerm", (object) searchTerm);
        ex.Data.Add((object) "SanctionsChecker.EntityGuid", (object) entityGuid);
        ErrorHandler.SilentHandleError((Exception) ex);
        DefaultDatabase.ExecuteMappedObject((TableMappingOperation) 3, (object) searchData);
        return this.CheckCompliance(searchTerm, entityGuid);
      }
    }
    return searchData;
  }

  private void SendComplianceHitNotification(SearchData searchData)
  {
    if (string.IsNullOrEmpty(this._notificationTo))
      return;
    string address = CurrentUser.Instance.Email.Address;
    string setting1 = SystemSettings.GetSetting<string>("ComplyAdvantage_NotificationMailServer");
    string setting2 = SystemSettings.GetSetting<string>("ComplyAdvantage_NotificationUserName");
    string str = SystemSettings.GetSetting<string>("ComplyAdvantage_NotificationPassword");
    if (string.IsNullOrEmpty(setting1))
      return;
    Uri result;
    if ((string.IsNullOrEmpty(setting2) || string.IsNullOrEmpty(str)) && Uri.TryCreate(setting1, UriKind.Absolute, out result))
    {
      if (!result.Port.ValueIn<int>(465, 587, 2525))
        return;
    }
    if (!string.IsNullOrEmpty(str))
    {
      try
      {
        str = SystemSettings.GetEncryptedSetting(str);
      }
      catch (Exception ex)
      {
        ErrorHandler.SilentLogError(ex);
        return;
      }
    }
    string emailBody = $"Search term: {searchData.SearchTerm}\n\n{searchData.ShareUrl}";
    string emailSubject = $"CA sanctions match: '{searchData.SearchTerm}'";
    new UserEmail(setting1, setting2, str, address, (string) null, false).SendMail(address, this._notificationTo, emailSubject, emailBody);
  }

  private static T CreateFromDataRow<T>(DataRow arg) where T : new()
  {
    Dictionary<string, string> toDestinationMap = SanctionsChecker.GenerateSourceToDestinationMap<T>();
    T fromDataRow = new T();
    foreach (KeyValuePair<string, string> keyValuePair in toDestinationMap)
    {
      PropertyInfo property = typeof (T).GetProperty(keyValuePair.Value);
      if ((PropertyInfo) null != property && property.CanWrite)
      {
        object obj = arg[keyValuePair.Key];
        if (obj is DBNull)
          obj = (object) null;
        property.SetValue((object) fromDataRow, obj);
      }
    }
    return fromDataRow;
  }

  private static Dictionary<string, string> GenerateSourceToDestinationMap<T>()
  {
    Dictionary<string, string> toDestinationMap = new Dictionary<string, string>();
    PropertyInfo[] properties = typeof (T).GetProperties(BindingFlags.Instance | BindingFlags.Public);
    if (!((IEnumerable<PropertyInfo>) properties).Any<PropertyInfo>())
      throw new InvalidOperationException("Must have at least one mapped public property");
    foreach (PropertyInfo propertyInfo in properties)
    {
      if (propertyInfo.GetCustomAttributes(typeof (TableFieldMappingAttribute), true) is TableFieldMappingAttribute[] customAttributes && customAttributes.Length != 0)
      {
        foreach (TableFieldMappingAttribute mappingAttribute in customAttributes)
        {
          if (mappingAttribute.Mode != 1)
          {
            if (string.IsNullOrEmpty(mappingAttribute.FieldName))
              toDestinationMap.Add(propertyInfo.Name, propertyInfo.Name);
            else
              toDestinationMap.Add(mappingAttribute.FieldName, propertyInfo.Name);
          }
        }
      }
    }
    return toDestinationMap;
  }
}
