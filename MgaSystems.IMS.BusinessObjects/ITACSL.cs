// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.ITACSL
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
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

public class ITACSL : OfacSearchSetting<ITACSL.Data.TradeOfac>
{
  static ITACSL() => ITACSL.SearchList = ITACSL.Data.ListSource.All;

  public ITACSL()
    : base(3)
  {
  }

  public string BaseUrl
  {
    get => !string.IsNullOrEmpty(this.ServiceURL) ? this.ServiceURL : "https://data.trade.gov";
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

  public string ServiceEndpoint
  {
    get
    {
      return this.GetConfigurationSetting<string>(nameof (ServiceEndpoint), "/consolidated_screening_list/v1/search");
    }
  }

  public static ITACSL.Data.ListSource SearchList { get; set; }

  public override bool IsValid
  {
    get
    {
      bool isValid;
      try
      {
        isValid = base.IsValid && !string.IsNullOrEmpty(this.ServicePassword);
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

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Ignoring return value, just used to populate the underlying store.")]
  protected override bool LoadConfigurationSettings()
  {
    bool flag;
    try
    {
      if (this.HasValue("RemoveCharsFromName") && this.HasValue("ClearExpireDays") && this.HasValue("ServiceEndpoint"))
      {
        flag = true;
      }
      else
      {
        XElement xelement = XElement.Parse(this.ServiceConfiguration);
        this.TryAddValue<bool?>("RemoveCharsFromName", (bool?) xelement.Element((XName) "RemoveCharsFromName"));
        this.TryAddValue<int?>("ClearExpireDays", (int?) xelement.Element((XName) "ClearExpireDays"));
        string str = (string) xelement.Element((XName) "ServiceEndpoint");
        this.TryAddValue<string>("ServiceEndpoint", string.IsNullOrEmpty(str) ? (string) null : str);
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

  public override OfacSystem.OfacResult CheckOfac(OfacSystem.OfacCriteria criteria)
  {
    if (!this.IsValid)
      throw new InvalidOperationException($"{this.OfacName} settings do not exist.");
    if (this.SearchesRemaining == 0)
      throw new InvalidOperationException("No Searches Remaining");
    if (!criteria.ValidCriteria())
      throw new InvalidOperationException("OFAC search criteria not valid.");
    OfacSystem.OfacResult ofacResult = (OfacSystem.OfacResult) null;
    string str = (string) null;
    string str1 = (string) null;
    try
    {
      Dictionary<string, string> queryDict = new Dictionary<string, string>();
      this.ConfigureQueryParameters(criteria, queryDict);
      ITACSL.Data.TradeOfac result = (ITACSL.Data.TradeOfac) null;
      Dictionary<string, string> source = queryDict;
      Func<KeyValuePair<string, string>, string> selector;
      // ISSUE: reference to a compiler-generated field
      if (ITACSL._Closure\u0024__.\u0024I17\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = ITACSL._Closure\u0024__.\u0024I17\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        ITACSL._Closure\u0024__.\u0024I17\u002D0 = selector = (Func<KeyValuePair<string, string>, string>) ([SpecialName] (kvp) => $"{kvp.Key}={Uri.EscapeDataString(kvp.Value)}");
      }
      string str2 = string.Join("&", source.Select<KeyValuePair<string, string>, string>(selector));
      try
      {
        using (WebClient webClient = new WebClient())
        {
          str = $"{this.BaseUrl.AppendUrlParts(this.ServiceEndpoint)}?{str2}";
          webClient.Headers.Add("subscription-key", this.ServicePassword);
          str1 = webClient.DownloadString(str);
          result = JsonConvert.DeserializeObject<ITACSL.Data.TradeOfac>(str1);
          result = this.ClientProcessResult(result);
        }
      }
      catch (WebException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        WebException webException = ex1;
        ITACSL.Data.TradeOfac tradeOfac = result;
        if (tradeOfac == null)
          tradeOfac = new ITACSL.Data.TradeOfac()
          {
            total = 0
          };
        result = tradeOfac;
        try
        {
          using (StreamReader streamReader = new StreamReader(webException.Response.GetResponseStream()))
            result.ErrorDescription = $"Error: {streamReader.ReadToEnd()}";
        }
        catch (Exception ex2)
        {
          ProjectData.SetProjectError(ex2);
          Exception ex3 = ex2;
          result.ErrorDescription = $"{webException.Message} ({ex3.Message})";
          ErrorHandler.SilentHandleError(ex3);
          ProjectData.ClearProjectError();
        }
        ProjectData.ClearProjectError();
      }
      OfacSystem.OfacResult ofacResult1 = new OfacSystem.OfacResult();
      ofacResult1.OfacTypeID = this.OfacTypeID;
      ofacResult1.OfacXml = JsonConvert.DeserializeXNode(!string.IsNullOrEmpty(str1) ? str1 : JsonConvert.SerializeObject((object) result), "TradeOfac").ToString(SaveOptions.DisableFormatting);
      ofacResult1.ErrorDescription = result.ErrorDescription;
      OfacSystem.OfacResult ofacResult2 = ofacResult1;
      int? returnCode;
      int? nullable = returnCode = result.ReturnCode;
      string str3 = $"{(nullable.HasValue ? returnCode.GetValueOrDefault() : (string.IsNullOrEmpty(result.ErrorDescription) ? 1 : -1))}";
      ofacResult2.ReturnCode = str3;
      OfacSystem.OfacResult ofacResult3 = ofacResult1;
      int? returnScore;
      nullable = returnScore = result.ReturnScore;
      int num;
      if (!nullable.HasValue)
      {
        ITACSL.Data.Result[] results = result.results;
        num = results != null ? results.Length : 0;
      }
      else
        num = returnScore.GetValueOrDefault();
      string str4 = $"{num}";
      ofacResult3.ReturnScore = str4;
      ofacResult1.SearchCriteria = criteria;
      ofacResult = ofacResult1;
      ofacResult.OfacHit = this.IsOfacHit(result);
      return ofacResult;
    }
    finally
    {
      ITACSL.SearchList = ITACSL.Data.ListSource.All;
      this.LogOfacSearch((Func<string>) ([SpecialName] () => new XElement((XName) "Get", (object) new XElement((XName) "Url", (object) str)).ToString()), (Func<string>) ([SpecialName] () => ofacResult?.OfacXml));
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

  protected virtual void ConfigureQueryParameters(
    OfacSystem.OfacCriteria criteria,
    Dictionary<string, string> queryDict)
  {
    string input = criteria.PolicyName;
    if (this.RemoveCharsFromName)
      input = Regex.Replace(input, "['/%]", string.Empty);
    queryDict["name"] = input;
    if (ITACSL.SearchList == ITACSL.Data.ListSource.All)
      return;
    Dictionary<string, string> dictionary = queryDict;
    IEnumerable<ITACSL.Data.ListSource> source = System.Enum.GetValues(typeof (ITACSL.Data.ListSource)).OfType<ITACSL.Data.ListSource>();
    Func<ITACSL.Data.ListSource, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (ITACSL._Closure\u0024__.\u0024I19\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = ITACSL._Closure\u0024__.\u0024I19\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      ITACSL._Closure\u0024__.\u0024I19\u002D0 = predicate = (Func<ITACSL.Data.ListSource, bool>) ([SpecialName] (ls) => ITACSL.SearchList.HasFlag((System.Enum) ls));
    }
    string str = string.Join<ITACSL.Data.ListSource>(",", source.Where<ITACSL.Data.ListSource>(predicate));
    dictionary["sources"] = str;
  }

  protected override bool IsOfacHit(ITACSL.Data.TradeOfac result)
  {
    return result.ReturnScore.GetValueOrDefault() > 0;
  }

  [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Used JSON deserialization. Property names must match JSON values, otherwise we must annotate all properties with the JSON property name.")]
  public class Data
  {
    [Flags]
    public enum ListSource
    {
      DPL = 1,
      EL = 2,
      MEU = 4,
      UVL = 8,
      ISN = 16, // 0x00000010
      DTC = 32, // 0x00000020
      CAP = 64, // 0x00000040
      FSE = 128, // 0x00000080
      MBS = 256, // 0x00000100
      PLC = 512, // 0x00000200
      SSI = 1024, // 0x00000400
      SDN = 2048, // 0x00000800
      All = SDN | SSI | PLC | MBS | FSE | CAP | DTC | ISN | UVL | MEU | EL | DPL, // 0x00000FFF
    }

    public class SourcesUsed
    {
      public int count { get; set; }

      public string value { get; set; }
    }

    public class Address
    {
      public string address { get; set; }

      public string city { get; set; }

      public string state { get; set; }

      public string postal_code { get; set; }

      public string country { get; set; }
    }

    public class Identification
    {
      public string country { get; set; }

      public string expiration_date { get; set; }

      public string issue_date { get; set; }

      public string number { get; set; }

      public string type { get; set; }
    }

    public class Result
    {
      public string id { get; set; }

      public string name { get; set; }

      [XmlArrayItem("alt_name")]
      public string[] alt_names { get; set; }

      [XmlArrayItem("citizenship")]
      public string[] citizenships { get; set; }

      [XmlArrayItem("date_of_birth")]
      public string[] dates_of_birth { get; set; }

      public string entity_number { get; set; }

      [XmlArrayItem("nationality")]
      public string[] nationalities { get; set; }

      [XmlArrayItem("place_of_birth")]
      public string[] places_of_birth { get; set; }

      [XmlArrayItem("program")]
      public string[] programs { get; set; }

      public string remarks { get; set; }

      public string source { get; set; }

      public string source_information_url { get; set; }

      public string source_list_url { get; set; }

      public string title { get; set; }

      public string type { get; set; }

      [XmlArrayItem("address")]
      public ITACSL.Data.Address[] addresses { get; set; }

      [XmlArrayItem("identification")]
      public ITACSL.Data.Identification[] ids { get; set; }

      public string call_sign { get; set; }

      public string country { get; set; }

      public string end_date { get; set; }

      public string federal_register_notice { get; set; }

      public string gross_registered_tonnage { get; set; }

      public string gross_tonnage { get; set; }

      public string license_policy { get; set; }

      public string license_requirement { get; set; }

      public string standard_order { get; set; }

      public string start_date { get; set; }

      public string vessel_flag { get; set; }

      public string vessel_owner { get; set; }

      public string vessel_type { get; set; }
    }

    public class TradeOfac
    {
      public TradeOfac() => this.results = Array.Empty<ITACSL.Data.Result>();

      public int total { get; set; }

      [XmlArrayItem("source")]
      public ITACSL.Data.SourcesUsed[] sources { get; set; }

      [XmlArrayItem("result")]
      public ITACSL.Data.Result[] results { get; set; }

      [XmlIgnore]
      public string ErrorDescription { get; set; }

      [XmlIgnore]
      public int? ReturnCode { get; set; }

      [XmlIgnore]
      public int? ReturnScore { get; set; }
    }
  }
}
