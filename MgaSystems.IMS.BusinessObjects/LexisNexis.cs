// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.LexisNexis
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.LexisNexis;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.BusinessObjects;

public class LexisNexis : OfacSearchSetting<SearchResults>
{
  public LexisNexis()
    : base(4)
  {
  }

  public string BaseUrl
  {
    get
    {
      return !string.IsNullOrEmpty(this.ServiceURL) ? this.ServiceURL : "https://bridgerstaging.lexisnexis.com/LN.WebServices";
    }
  }

  public bool RemoveCharsFromName
  {
    get
    {
      return this.GetConfigurationSetting<bool?>(nameof (RemoveCharsFromName), new bool?(false)).Value;
    }
  }

  public int ClearExpireDays
  {
    get => this.GetConfigurationSetting<int?>(nameof (ClearExpireDays), new int?(0)).Value;
  }

  public string ClientID => this.GetConfigurationSetting<string>(nameof (ClientID), "");

  public string XApiKey => this.GetConfigurationSetting<string>(nameof (XApiKey), "");

  public string ForceSearchList
  {
    get => this.GetConfigurationSetting<string>(nameof (ForceSearchList), "List Screening");
  }

  public int HitThreshold
  {
    get
    {
      return this.GetConfigurationSetting<int?>(nameof (HitThreshold), new int?(this.OfacHitThreshold)).Value;
    }
  }

  protected override bool LoadConfigurationSettings()
  {
    bool flag;
    try
    {
      if (this.HasValue("RemoveCharsFromName") && this.HasValue("ClearExpireDays") && this.HasValue("ClientID") && this.HasValue("XApiKey") && this.HasValue("ForceSearchList") && this.HasValue("HitThreshold"))
      {
        flag = true;
      }
      else
      {
        XElement xelement = XElement.Parse(this.ServiceConfiguration);
        this.TryAddValue<bool?>("RemoveCharsFromName", (bool?) xelement.Element((XName) "RemoveCharsFromName"));
        this.TryAddValue<int?>("ClearExpireDays", (int?) xelement.Element((XName) "ClearExpireDays"));
        this.TryAddValue<string>("ClientID", (string) xelement.Element((XName) "ClientID"));
        this.TryAddValue<string>("XApiKey", (string) xelement.Element((XName) "XApiKey"));
        this.TryAddValue<string>("ForceSearchList", (string) xelement.Element((XName) "ForceSearchList"));
        this.TryAddValue<int?>("HitThreshold", (int?) xelement.Element((XName) "HitThreshold"));
        flag = true;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public override bool IsValid
  {
    get
    {
      bool isValid;
      try
      {
        isValid = base.IsValid && !string.IsNullOrEmpty(this.ServiceUsername) && !string.IsNullOrEmpty(this.ServicePassword) && !string.IsNullOrEmpty(this.ClientID) && !string.IsNullOrEmpty(this.XApiKey);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        isValid = false;
        ProjectData.ClearProjectError();
      }
      return isValid;
    }
  }

  public override OfacSystem.OfacResult CheckOfac(OfacSystem.OfacCriteria criteria)
  {
    if (!this.IsValid)
      throw new InvalidOperationException($"{this.OfacName} settings do not exist.");
    if (this.SearchesRemaining == 0)
      throw new InvalidOperationException("No Searches Remaining");
    if (!criteria.ValidCriteria())
      throw new InvalidOperationException("OFAC search criteria not valid.");
    OfacSystem.OfacResult ofacResult;
    try
    {
      ofacResult = this.CheckOfacAsync(criteria, CancellationToken.None).Result;
    }
    catch (AggregateException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      AggregateException ex2 = ex1;
      XElement xelement1 = new XElement((XName) "OFAC");
      List<string> values = new List<string>();
      try
      {
        foreach (Exception innerException in ex2.Flatten().InnerExceptions)
        {
          if (innerException is ApiException apiException)
          {
            Dictionary<string, string> dictionary = new Dictionary<string, string>((IDictionary<string, string>) JsonConvert.DeserializeObject<Dictionary<string, string>>(apiException.Response), (IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
            if (dictionary.ContainsKey("Message"))
              values.Add(dictionary["Message"]);
            else
              values.Add(apiException.Response);
            XElement xelement2 = xelement1;
            XName name = (XName) (apiException.StatusCode == 401 ? "LoginFailed" : "ApiError");
            object content1;
            if (dictionary == null)
            {
              content1 = (object) null;
            }
            else
            {
              Dictionary<string, string> source = dictionary;
              Func<KeyValuePair<string, string>, XElement> selector;
              // ISSUE: reference to a compiler-generated field
              if (MGASystems.BusinessObjects.LexisNexis._Closure\u0024__.\u0024I18\u002D0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                selector = MGASystems.BusinessObjects.LexisNexis._Closure\u0024__.\u0024I18\u002D0;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                MGASystems.BusinessObjects.LexisNexis._Closure\u0024__.\u0024I18\u002D0 = selector = (Func<KeyValuePair<string, string>, XElement>) ([SpecialName] (kvp) => new XElement((XName) kvp.Key, (object) kvp.Value));
              }
              content1 = (object) source.Select<KeyValuePair<string, string>, XElement>(selector);
            }
            if (content1 == null)
              content1 = (object) new XElement[2]
              {
                new XElement((XName) "Response", (object) apiException.Response),
                new XElement((XName) "StatusCode", (object) apiException.StatusCode)
              };
            XElement content2 = new XElement(name, content1);
            xelement2.Add((object) content2);
          }
          else
          {
            values.Add(innerException.Message);
            xelement1.Add((object) JsonConvert.DeserializeXNode(JsonConvert.SerializeObject((object) innerException), "Error").Root);
          }
        }
      }
      finally
      {
        IEnumerator<Exception> enumerator;
        enumerator?.Dispose();
      }
      ex2.Data.Add((object) "Criteria", (object) JsonConvert.SerializeObject((object) criteria, (Formatting) 0));
      ErrorHandler.SilentLogError((Exception) ex2);
      ofacResult = new OfacSystem.OfacResult()
      {
        OfacTypeID = this.OfacTypeID,
        OfacXml = xelement1.ToString(),
        ErrorDescription = string.Join(";", (IEnumerable<string>) values),
        ReturnCode = "-1",
        ReturnScore = "0",
        SearchCriteria = criteria
      };
      ProjectData.ClearProjectError();
    }
    return ofacResult;
  }

  public async Task<OfacSystem.OfacResult> CheckOfacAsync(
    OfacSystem.OfacCriteria criteria,
    CancellationToken cancelToken)
  {
    BridgerClientApi bridgerClientApi = new BridgerClientApi(this.BaseUrl, this.XApiKey)
    {
      ReadResponseAsString = true
    };
    if (bridgerClientApi.ClientToken == null)
    {
      OAuth2Token oauth2Token = await bridgerClientApi.IssueAsync(this.ClientID, this.ServiceUsername, this.ServicePassword, CancellationToken.None).ConfigureAwait(false);
    }
    cancelToken.ThrowIfCancellationRequested();
    string content1 = (string) null;
    bridgerClientApi.RequestJsonCreated = (Action<string>) ([SpecialName] (reqjs) => content1 = reqjs);
    string content2 = (string) null;
    bridgerClientApi.ResponseJsonCreated = (Action<string>) ([SpecialName] (respjs) => content2 = respjs);
    EntitySearchRequest entitySearchRequest = new EntitySearchRequest()
    {
      ClientContext = this.CreateClientContext(criteria),
      SearchConfiguration = this.CreateSearchConfiguration(criteria),
      SearchInput = this.CreateSearchInput(criteria)
    };
    cancelToken.ThrowIfCancellationRequested();
    OfacSystem.OfacResult ofacResult1;
    try
    {
      SearchResults result = this.ClientProcessResult(await bridgerClientApi.SearchAsync(entitySearchRequest, cancelToken).ConfigureAwait(false));
      OfacSystem.OfacResult ofacResult2 = new OfacSystem.OfacResult();
      ofacResult2.OfacTypeID = this.OfacTypeID;
      ofacResult2.OfacXml = JsonConvert.DeserializeXNode(string.IsNullOrEmpty(content2) ? JsonConvert.SerializeObject((object) result) : content2, "SearchResults")?.ToString(SaveOptions.DisableFormatting);
      ofacResult2.ErrorDescription = result.Message;
      OfacSystem.OfacResult ofacResult3 = ofacResult2;
      long? nullable1;
      if (result == null)
      {
        nullable1 = new long?();
      }
      else
      {
        ICollection<ResultRecord> records = result.Records;
        nullable1 = records != null ? records.FirstOrDefault<ResultRecord>()?.ResultID : new long?();
      }
      string str1 = $"{nullable1.GetValueOrDefault()}";
      ofacResult3.ReturnCode = str1;
      OfacSystem.OfacResult ofacResult4 = ofacResult2;
      int? nullable2;
      if (result == null)
      {
        nullable2 = new int?();
      }
      else
      {
        ICollection<ResultRecord> records = result.Records;
        if (records == null)
        {
          nullable2 = new int?();
        }
        else
        {
          Func<ResultRecord, IEnumerable<WLMatch>> selector1;
          // ISSUE: reference to a compiler-generated field
          if (MGASystems.BusinessObjects.LexisNexis._Closure\u0024__.\u0024I19\u002D2 != null)
          {
            // ISSUE: reference to a compiler-generated field
            selector1 = MGASystems.BusinessObjects.LexisNexis._Closure\u0024__.\u0024I19\u002D2;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            MGASystems.BusinessObjects.LexisNexis._Closure\u0024__.\u0024I19\u002D2 = selector1 = (Func<ResultRecord, IEnumerable<WLMatch>>) ([SpecialName] (rr) =>
            {
              if (rr == null)
                return (IEnumerable<WLMatch>) null;
              WatchlistResults watchlist = rr.Watchlist;
              return watchlist == null ? (IEnumerable<WLMatch>) null : (IEnumerable<WLMatch>) watchlist.Matches;
            });
          }
          IEnumerable<WLMatch> source = records.SelectMany<ResultRecord, WLMatch>(selector1);
          Func<WLMatch, int?> selector2;
          // ISSUE: reference to a compiler-generated field
          if (MGASystems.BusinessObjects.LexisNexis._Closure\u0024__.\u0024I19\u002D3 != null)
          {
            // ISSUE: reference to a compiler-generated field
            selector2 = MGASystems.BusinessObjects.LexisNexis._Closure\u0024__.\u0024I19\u002D3;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            MGASystems.BusinessObjects.LexisNexis._Closure\u0024__.\u0024I19\u002D3 = selector2 = (Func<WLMatch, int?>) ([SpecialName] (m) => m?.EntityScore);
          }
          nullable2 = source.Max<WLMatch>(selector2);
        }
      }
      string str2 = $"{nullable2.GetValueOrDefault()}";
      ofacResult4.ReturnScore = str2;
      ofacResult2.SearchCriteria = criteria;
      ofacResult2.OfacHit = this.IsOfacHit(result);
      ofacResult1 = ofacResult2;
    }
    finally
    {
      if (this.LoggingEnabled)
      {
        try
        {
          DefaultDatabase.ExecuteNonQuery("dbo.OFAC_LogSearch", new object[6]
          {
            (object) "@ofacTypeID",
            (object) this.OfacTypeID,
            (object) "@request",
            (object) new XElement((XName) "RequestJson", (object) content1).ToString(SaveOptions.DisableFormatting),
            (object) "@response",
            (object) new XElement((XName) "ResponseJson", (object) content2).ToString(SaveOptions.DisableFormatting)
          });
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ErrorHandler.SilentLogError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }
    return ofacResult1;
  }

  protected virtual ClientContext CreateClientContext(OfacSystem.OfacCriteria criteria)
  {
    ClientContext clientContext1 = new ClientContext();
    clientContext1.ClientID = this.ClientID;
    ClientContext clientContext2 = clientContext1;
    CurrentUser instance = CurrentUser.Instance;
    string str = $"{(instance != null ? instance.UserID : -1)}:{DateTime.UtcNow:yyyyMMddHHss}:{criteria?.EntityGuid}";
    clientContext2.ClientReference = str;
    return clientContext1;
  }

  protected virtual SearchConfiguration CreateSearchConfiguration(OfacSystem.OfacCriteria criteria)
  {
    return new SearchConfiguration()
    {
      PredefinedSearchName = this.ForceSearchList,
      WriteResultsToDatabase = new bool?(true),
      AssignResultTo = new AssignmentInfo()
      {
        Division = "Default Division",
        EmailNotification = new bool?(true),
        Type = new AssignmentInfoType?(AssignmentInfoType.Role),
        RolesOrUsers = (ICollection<string>) new List<string>()
        {
          "Administrator"
        }
      }
    };
  }

  protected virtual SearchInput CreateSearchInput(OfacSystem.OfacCriteria criteria)
  {
    return this.CreateSearchInputFromCriterias(criteria);
  }

  protected virtual SearchInput CreateSearchInputFromCriterias(
    params OfacSystem.OfacCriteria[] criterias)
  {
    return new SearchInput()
    {
      BlockID = "1",
      Records = this.CreateRecordsCollection(criterias)
    };
  }

  protected virtual ICollection<InputRecord> CreateRecordsCollection(
    params OfacSystem.OfacCriteria[] criterias)
  {
    List<InputRecord> list = ((IEnumerable<OfacSystem.OfacCriteria>) criterias).SelectMany<OfacSystem.OfacCriteria, InputRecord>(new Func<OfacSystem.OfacCriteria, IEnumerable<InputRecord>>(this.CreateCorrespondingSearchRecords)).ToList<InputRecord>();
    if (list.Count > 1)
    {
      int num = list.Count - 1;
      for (int index = 0; index <= num; ++index)
        list[index].RecordID = new long?((long) (index + 1));
    }
    return (ICollection<InputRecord>) list;
  }

  protected virtual ICollection<InputRecord> CreateCorrespondingSearchRecords(
    OfacSystem.OfacCriteria criteria)
  {
    return (ICollection<InputRecord>) new List<InputRecord>()
    {
      this.CreateSearchRecord(criteria)
    };
  }

  protected virtual InputRecord CreateSearchRecord(OfacSystem.OfacCriteria criteria)
  {
    InputRecord searchRecord = new InputRecord();
    Dictionary<string, string> data = criteria.Data;
    // ISSUE: explicit non-virtual call
    if ((data != null ? (__nonvirtual (data.ContainsKey("RecordJson")) ? 1 : 0) : 0) != 0)
      searchRecord = JsonConvert.DeserializeObject<InputRecord>(criteria.Data["RecordJson"]);
    else if (criteria.EntityType.Equals("Vessel"))
    {
      InputEntity inputEntity = new InputEntity()
      {
        Name = new InputName()
        {
          Full = criteria.PolicyName
        },
        EntityType = new InputEntityEntityType?(InputEntityEntityType.Vessel)
      };
      if (!string.IsNullOrEmpty(criteria.IsoCountryCode))
      {
        InputAddress inputAddress = new InputAddress()
        {
          Country = criteria.IsoCountryCode,
          Type = new InputAddressType?(InputAddressType.Current)
        };
        inputEntity.Addresses = (ICollection<InputAddress>) new List<InputAddress>()
        {
          inputAddress
        };
      }
      string str = (string) null;
      if (data.TryGetValue("IMONumber", out str))
        inputEntity.IDs = (ICollection<InputID>) new List<InputID>()
        {
          new InputID()
          {
            Number = str,
            Type = new InputIDType?(InputIDType.IMO)
          }
        };
      searchRecord.Entity = inputEntity;
    }
    else if (!string.IsNullOrEmpty(criteria.PolicyName))
    {
      InputEntity inputEntity = new InputEntity()
      {
        EntityType = new InputEntityEntityType?(InputEntityEntityType.Individual)
      };
      string str = (string) null;
      // ISSUE: explicit non-virtual call
      if ((data != null ? (__nonvirtual (data.TryGetValue("SearchEntityType", out str)) ? 1 : 0) : 0) != 0 && Enum.IsDefined(typeof (InputEntityEntityType), (object) str))
        inputEntity.EntityType = new InputEntityEntityType?((InputEntityEntityType) Enum.Parse(typeof (InputEntityEntityType), str));
      else if (string.IsNullOrEmpty(criteria.FirstName))
        inputEntity.EntityType = new InputEntityEntityType?(InputEntityEntityType.Business);
      inputEntity.Gender = new InputEntityGender?(InputEntityGender.Unknown);
      inputEntity.Name = new InputName()
      {
        Full = criteria.PolicyName
      };
      DateTime result;
      if (!string.IsNullOrEmpty(criteria.DateOfBirth) && DateTime.TryParse(criteria.DateOfBirth, out result))
      {
        InputAdditionalInfo inputAdditionalInfo = new InputAdditionalInfo()
        {
          Date = new Date()
          {
            Unparsed = criteria.DateOfBirth,
            Day = new int?(result.Day),
            Month = new int?(result.Month),
            Year = new int?(result.Year)
          },
          Type = new InputAdditionalInfoType?(InputAdditionalInfoType.DOB)
        };
        inputEntity.AdditionalInfo = (ICollection<InputAdditionalInfo>) new List<InputAdditionalInfo>()
        {
          inputAdditionalInfo
        };
      }
      if (!string.IsNullOrEmpty(criteria.IsoCountryCode))
      {
        InputAddress inputAddress = new InputAddress()
        {
          Street1 = criteria.Address,
          Street2 = criteria.Address2,
          City = criteria.City,
          PostalCode = criteria.ZipCode,
          Country = criteria.IsoCountryCode,
          Type = new InputAddressType?(InputAddressType.Current)
        };
        if (string.IsNullOrEmpty(inputAddress.Street2) && !string.IsNullOrEmpty(inputAddress.Street1) && inputAddress.Street1.IndexOf(Environment.NewLine) > -1)
        {
          string[] source = inputAddress.Street1.Split(new string[1]
          {
            Environment.NewLine
          }, StringSplitOptions.RemoveEmptyEntries);
          inputAddress.Street1 = ((IEnumerable<string>) source).FirstOrDefault<string>();
          inputAddress.Street2 = string.Join(", ", ((IEnumerable<string>) source).Skip<string>(1));
        }
        inputEntity.Addresses = (ICollection<InputAddress>) new List<InputAddress>()
        {
          inputAddress
        };
      }
      searchRecord.Entity = inputEntity;
    }
    if (searchRecord.Entity != null)
      this.AttachAdditionalInfo(searchRecord.Entity, criteria);
    return searchRecord;
  }

  protected virtual void AttachAdditionalInfo(InputEntity record, OfacSystem.OfacCriteria criteria)
  {
    List<InputAdditionalInfo> inputAdditionalInfoList1 = new List<InputAdditionalInfo>();
    List<InputAdditionalInfo> inputAdditionalInfoList2 = inputAdditionalInfoList1;
    InputAdditionalInfo inputAdditionalInfo1 = new InputAdditionalInfo();
    inputAdditionalInfo1.Type = new InputAdditionalInfoType?(InputAdditionalInfoType.Other);
    inputAdditionalInfo1.Label = "User";
    InputAdditionalInfo inputAdditionalInfo2 = inputAdditionalInfo1;
    MDIControls instance = MDIControls.Instance;
    string str = (instance != null ? (instance.BlackBoxMode ? 1 : 0) : 0) != 0 ? "Webservice" : CurrentUser.Instance.DisplayName;
    inputAdditionalInfo2.Value = str;
    InputAdditionalInfo inputAdditionalInfo3 = inputAdditionalInfo1;
    inputAdditionalInfoList2.Add(inputAdditionalInfo3);
    List<InputAdditionalInfo> inputAdditionalInfoList3 = inputAdditionalInfoList1;
    bool? blackBoxMode = MDIControls.Instance?.BlackBoxMode;
    bool? nullable = blackBoxMode.HasValue ? new bool?(!blackBoxMode.GetValueOrDefault()) : blackBoxMode;
    if ((!nullable.HasValue || nullable.GetValueOrDefault()) && MDIControls.Instance?.MDIParent?.ActiveMdiChild != null && nullable.HasValue && MDIControls.Instance.MDIParent.ActiveMdiChild is IRecreatableEntity activeMdiChild)
    {
      inputAdditionalInfoList3.Add(new InputAdditionalInfo()
      {
        Type = new InputAdditionalInfoType?(InputAdditionalInfoType.Other),
        Label = "Context",
        Value = activeMdiChild.EntityName
      });
      if (activeMdiChild.HasControlGUID)
      {
        Quote quote = Quote.FromControlGuid(activeMdiChild.ControlGUID);
        inputAdditionalInfoList3.Add(new InputAdditionalInfo()
        {
          Type = new InputAdditionalInfoType?(InputAdditionalInfoType.Other),
          Label = "Underwriter",
          Value = quote.Underwriter?.Name_FirstLast
        });
      }
    }
    record.AdditionalInfo = (ICollection<InputAdditionalInfo>) inputAdditionalInfoList3;
  }

  public override bool IsOfacSearchValid(OfacSystem.OfacStatus ofacSearch)
  {
    if (this.ClearExpireDays > 0)
    {
      DateTime? clearDate = ofacSearch.ClearDate;
      if (clearDate.HasValue)
      {
        DateTime now = DateTime.Now;
        clearDate = ofacSearch.ClearDate;
        DateTime dateTime = clearDate.Value;
        return (now - dateTime).TotalDays <= (double) this.ClearExpireDays;
      }
    }
    return true;
  }

  protected override bool IsOfacHit(SearchResults result)
  {
    if (result == null)
      return false;
    ICollection<ResultRecord> records = result.Records;
    if (records == null)
      return false;
    Func<ResultRecord, IEnumerable<WLMatch>> selector;
    // ISSUE: reference to a compiler-generated field
    if (MGASystems.BusinessObjects.LexisNexis._Closure\u0024__.\u0024I29\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = MGASystems.BusinessObjects.LexisNexis._Closure\u0024__.\u0024I29\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      MGASystems.BusinessObjects.LexisNexis._Closure\u0024__.\u0024I29\u002D0 = selector = (Func<ResultRecord, IEnumerable<WLMatch>>) ([SpecialName] (rr) => (IEnumerable<WLMatch>) rr.Watchlist.Matches);
    }
    return records.SelectMany<ResultRecord, WLMatch>(selector).Any<WLMatch>((Func<WLMatch, bool>) ([SpecialName] (m) => ((int?) m?.EntityScore).GetValueOrDefault() >= this.HitThreshold));
  }
}
