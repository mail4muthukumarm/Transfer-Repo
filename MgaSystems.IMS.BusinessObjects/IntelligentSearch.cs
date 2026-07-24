// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.IntelligentSearch
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.BusinessObjects.OFAC.IST;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.Services;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.BusinessObjects;

public class IntelligentSearch : OfacSearchSetting<WsIstWatch[]>
{
  static IntelligentSearch()
  {
    IntelligentSearch.SearchRulebase = true;
    IntelligentSearch.ExcludeVessels = true;
    IntelligentSearch.IncludeAlias = true;
    IntelligentSearch.ExtendedSearch = true;
    IntelligentSearch.SanctionedCountriesSearch = false;
  }

  public IntelligentSearch()
    : base(1)
  {
  }

  public string SearchList => this.GetConfigurationSetting<string>(nameof (SearchList), "11011");

  public int ScoreThreshold
  {
    get => this.GetConfigurationSetting<int?>(nameof (ScoreThreshold), new int?(80 /*0x50*/)).Value;
  }

  public string SearchRange => this.GetConfigurationSetting<string>(nameof (SearchRange), "1");

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

  public static bool SearchRulebase { get; set; }

  public static bool ExcludeVessels { get; set; }

  public static bool IncludeAlias { get; set; }

  public static bool ExtendedSearch { get; set; }

  public static bool SanctionedCountriesSearch { get; set; }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "TryAddValue is internally used for setting a new field/column in datastore. Coopting it to simplify setting configuration.")]
  protected override bool LoadConfigurationSettings()
  {
    bool flag;
    try
    {
      if (this.HasValue("SearchList") && this.HasValue("ScoreThreshold") && this.HasValue("SearchRange") && this.HasValue("RemoveCharsFromName") && this.HasValue("ClearExpireDays"))
      {
        flag = true;
      }
      else
      {
        XElement xelement = XElement.Parse(this.ServiceConfiguration);
        this.TryAddValue<string>("SearchList", (string) xelement.Element((XName) "SearchList"));
        this.TryAddValue<int?>("ScoreThreshold", (int?) xelement.Element((XName) "ScoreThreshold"));
        this.TryAddValue<string>("SearchRange", (string) xelement.Element((XName) "SearchRange"));
        this.TryAddValue<bool?>("RemoveCharsFromName", (bool?) xelement.Element((XName) "RemoveCharsFromName"));
        this.TryAddValue<int?>("ClearExpireDays", (int?) xelement.Element((XName) "ClearExpireDays"));
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

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "We do not care about return of RefreshData. We simply try and get latest values.")]
  public override bool IsValid
  {
    get
    {
      bool isValid;
      try
      {
        isValid = base.IsValid && !string.IsNullOrEmpty(this.ServiceUsername) && !string.IsNullOrEmpty(this.ServicePassword);
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
      throw new InvalidOperationException("IntelligentSearch settings do not exist.");
    if (this.SearchesRemaining == 0)
      throw new InvalidOperationException("No Searches Remaining");
    string input = criteria.ValidCriteria() ? criteria.PolicyName : throw new InvalidOperationException("OFAC search criteria not valid.");
    if (this.RemoveCharsFromName)
      input = Regex.Replace(input, "['/%]", string.Empty);
    OfacSystem.OfacResult ofacResult = (OfacSystem.OfacResult) null;
    ISTWatchWebService istWatchWebService1 = new ISTWatchWebService();
    try
    {
      if (!string.IsNullOrEmpty(this.ServiceURL))
        istWatchWebService1.Url = this.ServiceURL;
      ISTWatchWebService istWatchWebService2 = istWatchWebService1;
      string serviceUsername = this.ServiceUsername;
      string servicePassword = this.ServicePassword;
      string name1 = input;
      string street = criteria.Address ?? string.Empty;
      string city = criteria.City ?? string.Empty;
      string country = criteria.IsoCountryCode ?? string.Empty;
      string score_threshold = this.ScoreThreshold.ToString();
      string searchList = this.SearchList;
      bool flag = IntelligentSearch.SearchRulebase;
      string search_rulebase = flag.ToString();
      flag = IntelligentSearch.ExcludeVessels;
      string exclude_vessel = flag.ToString();
      flag = IntelligentSearch.IncludeAlias;
      string include_alias = flag.ToString();
      flag = IntelligentSearch.ExtendedSearch;
      string extended_search = flag.ToString();
      string searchRange = this.SearchRange;
      flag = IntelligentSearch.SanctionedCountriesSearch;
      string sanct_countries_search = flag.ToString();
      WsIstWatch[] wsIstWatchArray = this.ClientProcessResult(istWatchWebService2.wsISTWatch(serviceUsername, servicePassword, name1, street, city, country, score_threshold, "5", searchList, search_rulebase, exclude_vessel, include_alias, extended_search, searchRange, sanct_countries_search));
      WsIstWatch wsIstWatch = ((IEnumerable<WsIstWatch>) wsIstWatchArray).FirstOrDefault<WsIstWatch>();
      int result;
      if (!string.IsNullOrEmpty(wsIstWatch?.SearchesLeft) && int.TryParse(wsIstWatch?.SearchesLeft, out result))
        this.SearchesRemaining = result == this.SearchesRemaining ? 0 : result;
      XmlAttributeOverrides overrides = new XmlAttributeOverrides();
      overrides.Add(typeof (WsIstWatch), new XmlAttributes()
      {
        XmlType = new XmlTypeAttribute("OfacResult")
      });
      overrides.Add(typeof (WsIstWatch), "m_errors", new XmlAttributes()
      {
        XmlIgnore = true
      });
      string localXml = wsIstWatchArray.SerializeToLocalXml(overrides, rootName: "OfacResults");
      try
      {
        XElement xelement = XElement.Parse(localXml);
        XName name2 = (XName) "OfacResults";
        IEnumerable<XElement> source1 = xelement.Elements((XName) "OfacResult");
        Func<XElement, XElement> selector1;
        // ISSUE: reference to a compiler-generated field
        if (IntelligentSearch._Closure\u0024__.\u0024I35\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector1 = IntelligentSearch._Closure\u0024__.\u0024I35\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          IntelligentSearch._Closure\u0024__.\u0024I35\u002D0 = selector1 = (Func<XElement, XElement>) ([SpecialName] (resNode) =>
          {
            XName name3 = (XName) "OfacResult";
            IEnumerable<XElement> source2 = resNode.Descendants();
            Func<XElement, string> keySelector;
            // ISSUE: reference to a compiler-generated field
            if (IntelligentSearch._Closure\u0024__.\u0024I35\u002D1 != null)
            {
              // ISSUE: reference to a compiler-generated field
              keySelector = IntelligentSearch._Closure\u0024__.\u0024I35\u002D1;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              IntelligentSearch._Closure\u0024__.\u0024I35\u002D1 = keySelector = (Func<XElement, string>) ([SpecialName] (trn) => trn.Name.LocalName);
            }
            IOrderedEnumerable<XElement> source3 = source2.OrderBy<XElement, string>(keySelector);
            Func<XElement, XElement> selector2;
            // ISSUE: reference to a compiler-generated field
            if (IntelligentSearch._Closure\u0024__.\u0024I35\u002D2 != null)
            {
              // ISSUE: reference to a compiler-generated field
              selector2 = IntelligentSearch._Closure\u0024__.\u0024I35\u002D2;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              IntelligentSearch._Closure\u0024__.\u0024I35\u002D2 = selector2 = (Func<XElement, XElement>) ([SpecialName] (trn) => new XElement((XName) trn.Name.LocalName.ToUpper(), (object) trn.Value));
            }
            IEnumerable<XElement> content = source3.Select<XElement, XElement>(selector2);
            return new XElement(name3, (object) content);
          });
        }
        IEnumerable<XElement> content1 = source1.Select<XElement, XElement>(selector1);
        localXml = new XElement(name2, (object) content1).ToString();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.SilentHandleError(ex);
        ProjectData.ClearProjectError();
      }
      ofacResult = new OfacSystem.OfacResult()
      {
        OfacTypeID = this.OfacTypeID,
        OfacXml = localXml,
        ErrorDescription = wsIstWatch?.ErrorDesc,
        ReturnCode = wsIstWatch?.ReturnCodes,
        ReturnScore = wsIstWatch?.Score ?? "0",
        SearchCriteria = criteria
      };
      ofacResult.OfacHit = this.IsOfacHit(wsIstWatchArray);
      return ofacResult;
    }
    catch (WebException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      WebException webException = ex;
      if (ofacResult == null)
        ofacResult = new OfacSystem.OfacResult();
      using (Stream responseStream = webException.Response?.GetResponseStream())
      {
        if (responseStream != null)
        {
          using (StreamReader streamReader = new StreamReader(responseStream))
            ofacResult.OfacXml = new XElement((XName) "OfacResults", (object) new XElement((XName) "OfacResult", new object[3]
            {
              (object) new XElement((XName) "ERRORDESC", (object) streamReader.ReadToEnd()),
              (object) new XElement((XName) "ERRORMSG", (object) webException.Message),
              (object) new XElement((XName) "RETURNCODES", (object) "-1")
            })).ToString();
        }
      }
      throw;
    }
    finally
    {
      istWatchWebService1?.Dispose();
      IntelligentSearch.SearchRulebase = true;
      IntelligentSearch.ExcludeVessels = true;
      IntelligentSearch.IncludeAlias = true;
      IntelligentSearch.ExtendedSearch = true;
      IntelligentSearch.SanctionedCountriesSearch = false;
      this.LogOfacSearch((Func<string>) ([SpecialName] () => SoapListenerExtension.LastRequestXML ?? criteria.SerializeCriteria()), (Func<string>) ([SpecialName] () => ofacResult?.OfacXml));
    }
  }

  public override bool IsOfacSearchValid(OfacSystem.OfacStatus ofacSearch)
  {
    bool flag;
    if (this.ClearExpireDays > 0)
    {
      DateTime? clearDate = ofacSearch.ClearDate;
      if (clearDate.HasValue)
      {
        DateTime now = DateTime.Now;
        clearDate = ofacSearch.ClearDate;
        DateTime dateTime = clearDate.Value;
        if ((now - dateTime).TotalDays > (double) this.ClearExpireDays)
        {
          flag = false;
          goto label_5;
        }
      }
    }
    flag = true;
label_5:
    return flag;
  }

  protected override bool IsOfacHit(WsIstWatch[] result)
  {
    int result1 = 0;
    return int.TryParse(((IEnumerable<WsIstWatch>) result).FirstOrDefault<WsIstWatch>()?.Score ?? "0", out result1) && result1 >= this.OfacHitThreshold;
  }

  public override string OfacHitMessage(OfacSystem.OfacStatus ofacSearch)
  {
    return $"The {ofacSearch.EntityType} OFAC score of {ofacSearch.HitScore} is above the system score of {this.OfacHitThreshold}";
  }
}
