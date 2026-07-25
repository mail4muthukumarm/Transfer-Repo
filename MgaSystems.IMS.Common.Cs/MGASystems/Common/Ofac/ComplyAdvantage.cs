// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.OFAC.ComplyAdvantage
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.Attributes;
using MGASystems.Common.ComplyAdvantage.Data;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data.DataEncryption;
using MGASystems.Data.DataMapping;
using MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.Controller;
using MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.Common.OFAC;

public class ComplyAdvantage : OfacSetting<ResultData>
{
  private const int ComplyAdvantageOfacTypeId = 5;
  private const Decimal DefaultFuzziness = 0M;
  private static readonly TimeSpan defaultMaxAgeDays = TimeSpan.FromDays(90.0);
  private static readonly IEncrypt encryptor = (IEncrypt) new CoffeeTripleDesEncrypter();

  public ComplyAdvantage()
    : base(5)
  {
  }

  public static HashSet<string> GoodStatuses => SearchData.GoodStatuses;

  [OfacConfiguration]
  public TimeSpan MaxAgeDays
  {
    get
    {
      return this.GetConfigurationSetting<TimeSpan>(nameof (MaxAgeDays), MGASystems.Common.OFAC.ComplyAdvantage.defaultMaxAgeDays);
    }
  }

  [OfacConfiguration]
  public bool RefreshExpiredSearch
  {
    get => this.GetConfigurationSetting<bool>(nameof (RefreshExpiredSearch), false);
  }

  [OfacConfiguration]
  public Decimal Fuzziness => this.GetConfigurationSetting<Decimal>(nameof (Fuzziness), 0M);

  [OfacConfiguration]
  public string NotificationTo
  {
    get => this.GetConfigurationSetting<string>(nameof (NotificationTo), (string) null);
  }

  [OfacConfiguration]
  public string NotificationMailServer
  {
    get => this.GetConfigurationSetting<string>(nameof (NotificationMailServer), (string) null);
  }

  [OfacConfiguration]
  public string NotificationUserName
  {
    get => this.GetConfigurationSetting<string>(nameof (NotificationUserName), (string) null);
  }

  [OfacConfiguration]
  public string NotificationPassword
  {
    get => this.GetConfigurationSetting<string>(nameof (NotificationPassword), (string) null);
  }

  protected override bool ValidSearchAge(OfacSystem.OfacStatus ofacSearch)
  {
    return (!this.RefreshExpiredSearch || !(DateTime.Now - ofacSearch.LogDate > this.MaxAgeDays)) && base.ValidSearchAge(ofacSearch);
  }

  public string ApiKey => this.ServicePassword;

  public override bool IsValid
  {
    get
    {
      return base.IsValid && !string.IsNullOrEmpty(this.ServiceURL) && !string.IsNullOrEmpty(this.ApiKey);
    }
  }

  protected override bool LoadConfigurationSettings()
  {
    try
    {
      if (!this.HasValues("MaxAgeDays", "RefreshExpiredSearch"))
      {
        XElement xelement = XElement.Parse(this.ServiceConfiguration);
        TimeSpan? nullable1 = new TimeSpan?();
        int? nullable2 = (int?) xelement.Element((XName) "MaxAgeDays");
        if (nullable2.HasValue)
        {
          nullable2.GetValueOrDefault();
          nullable1 = new TimeSpan?(MGASystems.Common.OFAC.ComplyAdvantage.defaultMaxAgeDays);
        }
        this.TryAddValue<TimeSpan?>("MaxAgeDays", nullable1);
        this.TryAddValue<bool?>("RefreshExpiredSearch", (bool?) xelement.Element((XName) "RefreshExpiredSearch"));
        this.TryAddValue<Decimal?>("Fuzziness", (Decimal?) xelement.Element((XName) "Fuzziness"));
        this.TryAddValue<string>("NotificationTo", (string) xelement.Element((XName) "NotificationTo"));
        this.TryAddValue<string>("NotificationMailServer", (string) xelement.Element((XName) "NotificationMailServer"));
        this.TryAddValue<string>("NotificationUserName", (string) xelement.Element((XName) "NotificationUserName"));
        this.TryAddValue<string>("NotificationPassword", (string) xelement.Element((XName) "NotificationPassword"));
      }
      return base.LoadConfigurationSettings();
    }
    catch
    {
      return false;
    }
  }

  public override OfacSystem.OfacResult CheckOfac(OfacSystem.OfacCriteria criteria)
  {
    if (!this.IsValid)
      throw new InvalidOperationException(this.OfacName + " settings do not exist.");
    if (!criteria.ValidCriteria())
      throw new InvalidOperationException("OFAC search criteria not valid.");
    try
    {
      IProgress<Exception> exceptionHandler = (IProgress<Exception>) new Progress<Exception>(new Action<Exception>(((MappedObject<OfacSetting<ResultData>>) this).SilentHandleError));
      return this.CheckOfacAsync(criteria, exceptionHandler: exceptionHandler).GetAwaiter().GetResult();
    }
    catch (Exception ex)
    {
      ex.Data[(object) "Criteria"] = (object) JsonConvert.SerializeObject((object) criteria);
      base.SilentHandleError(ex);
      return new OfacSystem.OfacResult()
      {
        OfacTypeID = this.OfacTypeID,
        OfacXml = JsonConvert.DeserializeXNode(JsonConvert.SerializeObject((object) ex), "OFAC").ToString(SaveOptions.DisableFormatting),
        ErrorDescription = ex.Message,
        ReturnCode = "-1",
        ReturnScore = "0",
        SearchCriteria = criteria
      };
    }
  }

  public async Task<OfacSystem.OfacResult> CheckOfacAsync(
    OfacSystem.OfacCriteria criteria,
    IProgress<string> progressHandler = null,
    IProgress<Exception> exceptionHandler = null,
    CancellationToken cancellationToken = default (CancellationToken))
  {
    string requestJson = (string) null;
    string responseJson = (string) null;
    SearchesController searchesController = new SearchesController(this.ServiceURL, this.ApiKey, progressHandler, exceptionHandler).SetRequestJsonlListener((Action<string>) (request => requestJson = request)).SetResponseJsonListener((Action<string>) (response => responseJson = response));
    OfacSystem.OfacResult ofacResult;
    try
    {
      MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.SearchRequest searchRequest = this.CreateSearchRequest(criteria);
      cancellationToken.ThrowIfCancellationRequested();
      MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.SearchResult searchResult = await searchesController.Search(searchRequest).ConfigureAwait(false);
      cancellationToken.ThrowIfCancellationRequested();
      ResultData data = searchResult?.Content?.Data;
      this.ClientProcessResult(data);
      ofacResult = new OfacSystem.OfacResult()
      {
        OfacTypeID = this.OfacTypeID,
        OfacXml = JsonConvert.DeserializeXNode(string.IsNullOrEmpty(responseJson) ? JsonConvert.SerializeObject((object) searchResult) : responseJson, "SearchResults")?.ToString(SaveOptions.DisableFormatting),
        ErrorDescription = searchResult.Error,
        ReturnCode = $"{data.ID}",
        ReturnScore = $"{this.GetReturnScore(data)}",
        SearchCriteria = criteria,
        OfacHit = this.IsOfacHit(data)
      };
    }
    finally
    {
      this.LogOfacSearch((Func<string>) (() => new XElement((XName) "RequestJson", (object) requestJson).ToString(SaveOptions.DisableFormatting)), (Func<string>) (() => new XElement((XName) "ResponseJson", (object) responseJson).ToString(SaveOptions.DisableFormatting)));
    }
    return ofacResult;
  }

  protected virtual MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.SearchRequest CreateSearchRequest(
    OfacSystem.OfacCriteria criteria)
  {
    return new MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.SearchRequest()
    {
      ClientRef = string.Join(":", (object) criteria.EntityType, (object) criteria.EntityGuid, (object) criteria.ParentGuid).TrimEnd(':'),
      SearchTerm = criteria.PolicyName,
      Fuzziness = new Decimal?(this.Fuzziness),
      Filters = MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.SearchFilters.DefaultFilters,
      ShareUrl = true
    };
  }

  public override OfacSystem.OfacCriteria GetSettingSearchCriteria(IOfacSearchEntity entity)
  {
    OfacSystem.OfacCriteria settingSearchCriteria = new OfacSystem.OfacCriteria(entity);
    if (entity.IsIndividual)
    {
      settingSearchCriteria.FirstName = string.Join(" ", entity.FirstName, entity.MiddleName).TrimEnd();
      settingSearchCriteria.LastName = entity.LastName;
    }
    else
      settingSearchCriteria.LastName = entity.BusinessName;
    return settingSearchCriteria;
  }

  protected override bool IsOfacHit(ResultData result)
  {
    if (result == null || result.TotalHits < 1 || MGASystems.Common.OFAC.ComplyAdvantage.GoodStatuses.Contains(result.MatchStatus))
      return false;
    this.SendComplianceHitNotification(result);
    return true;
  }

  protected override int GetReturnScore(ResultData result)
  {
    if (result == null || result.TotalHits < 1 || MGASystems.Common.OFAC.ComplyAdvantage.GoodStatuses.Contains(result.MatchStatus))
      return 0;
    return result.TotalHits > 0 ? 100 : 90;
  }

  protected virtual void SendComplianceHitNotification(ResultData result)
  {
    if (string.IsNullOrEmpty(this.NotificationTo) || string.IsNullOrEmpty(this.NotificationMailServer))
      return;
    string address = CurrentUser.Instance.Email.Address;
    string notificationTo = this.NotificationTo;
    string notificationMailServer = this.NotificationMailServer;
    string notificationUserName = this.NotificationUserName;
    string emailPassword = this.NotificationPassword;
    string emailUsername = notificationUserName;
    string str1 = notificationMailServer;
    string emailTo = notificationTo;
    string str2 = address;
    Uri result1;
    if ((string.IsNullOrEmpty(emailUsername) || string.IsNullOrEmpty(emailPassword)) && Uri.TryCreate(str1, UriKind.Absolute, out result1))
    {
      if (!result1.Port.ValueIn<int>(465, 587, 2525))
        return;
    }
    if (!string.IsNullOrEmpty(emailPassword))
    {
      try
      {
        MGASystems.Common.OFAC.ComplyAdvantage.encryptor.Decrypt(emailPassword);
      }
      catch
      {
        emailPassword = MGASystems.Common.OFAC.ComplyAdvantage.encryptor.Encrypt(emailPassword);
      }
    }
    try
    {
      string emailBody = $"Search term: {result.SearchTerm}\n\n{result.ShareUrl}";
      string emailSubject = $"CA sanctions match: '{result.SearchTerm}'";
      new UserEmail(str1, emailUsername, emailPassword, str2, (string) null, false).SendMail(str2, emailTo, emailSubject, emailBody);
    }
    catch (Exception ex)
    {
      base.SilentHandleError(ex);
    }
  }

  public override bool IsOfacSearchCleared(OfacSystem.OfacStatus ofacSearch)
  {
    if (!ofacSearch.IsOfacCleared)
    {
      string returnCode = ofacSearch.ReturnCode;
      long result1;
      if (returnCode != null && long.TryParse(returnCode, out result1))
      {
        if (result1 > 1L)
        {
          try
          {
            ResultData result2 = this.GetSearchAsync(result1).Result;
            bool flag = !this.IsOfacHit(result2);
            if ((1 & (flag ? 1 : 0)) != 0)
              OfacSystem.Instance.ClearOfacHit(ofacSearch.EntityGuid, ofacSearch.ParentEntityGuid, new Guid?(CurrentUser.Instance.UserGUID), new DateTime?(CurrentUser.ServerTime), "Cleard in ComplyAdvantage", clearNotes: $"Last Updated: {result2.UpdatedAt:s}");
            return (ofacSearch.ClearOverride = new bool?(flag)).Value;
          }
          catch (AggregateException ex1)
          {
            AggregateException ex2 = ex1.Flatten();
            ex2.Data.Add((object) "Messages", (object) ex2.InnerExceptions.Select<Exception, string>(new Func<Exception, string>(MGASystems.Common.ExceptionExtensions.RecursiveMessage)).ToList<string>());
            ErrorHandler.SilentLogError((Exception) ex2);
          }
        }
      }
    }
    return base.IsOfacSearchCleared(ofacSearch);
  }

  public async Task<ResultData> GetSearchAsync(
    long searchId,
    IProgress<string> progressHandler = null,
    IProgress<Exception> exceptionHandler = null,
    CancellationToken cancellationToken = default (CancellationToken))
  {
    string responseJson = (string) null;
    ResultData data;
    try
    {
      data = (await new SearchesController(this.ServiceURL, this.ApiKey, progressHandler, exceptionHandler).SetResponseJsonListener((Action<string>) (response => responseJson = response)).GetSearch(searchId.ToString()).ConfigureAwait(false))?.Content?.Data;
    }
    finally
    {
      this.LogOfacSearch((Func<string>) (() => new XElement((XName) "SearchID", (object) searchId).ToString(SaveOptions.DisableFormatting)), (Func<string>) (() => new XElement((XName) "SearchResponseJson", (object) responseJson).ToString(SaveOptions.DisableFormatting)));
    }
    return data;
  }
}
