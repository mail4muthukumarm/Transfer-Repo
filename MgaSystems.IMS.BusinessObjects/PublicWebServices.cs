// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.PublicWebServices
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.BusinessObjects.OFAC.PWS;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.Common.Services;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.BusinessObjects;

public class PublicWebServices : OfacSearchSetting<XDocument>
{
  public PublicWebServices()
    : base(2)
  {
  }

  public string ClientReferenceNumber
  {
    get => this.GetConfigurationSetting<string>(nameof (ClientReferenceNumber), (string) null);
  }

  public bool RemoveCharsFromName
  {
    get
    {
      return this.GetConfigurationSetting<bool?>(nameof (RemoveCharsFromName), new bool?(false)).Value;
    }
  }

  public int SearchValidDays
  {
    get => this.GetConfigurationSetting<int?>(nameof (SearchValidDays), new int?(0)).Value;
  }

  protected override bool LoadConfigurationSettings()
  {
    bool flag;
    try
    {
      if (this.HasValue("ClientReferenceNumber") && this.HasValue("RemoveCharsFromName") && this.HasValue("SearchValidDays"))
      {
        flag = true;
      }
      else
      {
        XElement xelement = XElement.Parse(this.ServiceConfiguration);
        this.TryAddValue<string>("ClientReferenceNumber", (string) xelement.Element((XName) "ClientReferenceNumber"));
        this.TryAddValue<bool?>("RemoveCharsFromName", (bool?) xelement.Element((XName) "RemoveCharsFromName"));
        this.TryAddValue<int?>("SearchValidDays", (int?) xelement.Element((XName) "SearchValidDays"));
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
        isValid = base.IsValid && !string.IsNullOrEmpty(this.ServiceUsername) && !string.IsNullOrEmpty(this.ServicePassword) && !string.IsNullOrEmpty(this.ClientReferenceNumber);
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
      throw new InvalidOperationException("Public Web Services (OFAC) settings do not exist.");
    if (!criteria.ValidCriteria())
      throw new InvalidOperationException("OFAC search criteria not valid.");
    string base64String1 = Convert.ToBase64String(Encoding.UTF8.GetBytes(this.ServiceUsername));
    string base64String2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(this.ServicePassword));
    if (this.RemoveCharsFromName)
    {
      if (!string.IsNullOrEmpty(criteria.FirstName))
        criteria.FirstName = Regex.Replace(criteria.FirstName, "['/%]", string.Empty);
      if (!string.IsNullOrEmpty(criteria.LastName))
        criteria.LastName = Regex.Replace(criteria.LastName, "['/%]", string.Empty);
    }
    OfacSystem.OfacResult ofacResult = (OfacSystem.OfacResult) null;
    PPWebServicePublic webServicePublic = (PPWebServicePublic) null;
    try
    {
      webServicePublic = new PPWebServicePublic();
      if (!string.IsNullOrEmpty(this.ServiceURL))
        webServicePublic.Url = this.ServiceURL;
      string text = webServicePublic.ClientSearchValidateUserAndBatchParamWS(base64String1, base64String2, criteria.LastName ?? string.Empty, criteria.FirstName ?? string.Empty, criteria.Address ?? string.Empty, criteria.City ?? string.Empty, criteria.State ?? string.Empty, criteria.ZipCode ?? string.Empty, criteria.IsoCountryCode ?? string.Empty, this.ClientReferenceNumber, string.Empty, string.Empty, criteria.DateOfBirth ?? string.Empty);
      ofacResult = new OfacSystem.OfacResult()
      {
        OfacTypeID = this.OfacTypeID,
        OfacXml = text,
        SearchCriteria = criteria,
        ReturnCode = "-1",
        ReturnScore = "-1"
      };
      XDocument result = (XDocument) null;
      try
      {
        result = XDocument.Parse(text);
        result = this.ClientProcessResult(result);
        ofacResult.OfacXml = result.ToString(SaveOptions.None);
        ofacResult.ErrorDescription = result.Descendants((XName) "ReturnMessage").FirstOrDefault<XElement>().Value;
        ofacResult.ReturnCode = result.Descendants((XName) "ReturnCode").FirstOrDefault<XElement>()?.Value ?? "-1";
        OfacSystem.OfacResult ofacResult1 = ofacResult;
        IEnumerable<XElement> source = result.Descendants((XName) "IDS_SCORE");
        Func<XElement, int?> selector;
        // ISSUE: reference to a compiler-generated field
        if (PublicWebServices._Closure\u0024__.\u0024I10\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = PublicWebServices._Closure\u0024__.\u0024I10\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          PublicWebServices._Closure\u0024__.\u0024I10\u002D0 = selector = (Func<XElement, int?>) ([SpecialName] (xe) => (int?) xe);
        }
        string str = (source.Max<XElement>(selector) ?? 0).ToString();
        ofacResult1.ReturnScore = str;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        ofacResult.ErrorDescription = $"{ofacResult.ErrorDescription}; Failed to parse OFAC results due to error: {exception.Message}".TrimStart(';', ' ');
        ProjectData.ClearProjectError();
      }
      ofacResult.OfacHit = this.IsOfacHit(result);
      return ofacResult;
    }
    finally
    {
      webServicePublic?.Dispose();
      this.LogOfacSearch((Func<string>) ([SpecialName] () => SoapListenerExtension.LastRequestXML ?? criteria.SerializeCriteria()), (Func<string>) ([SpecialName] () => ofacResult?.OfacXml));
    }
  }

  public override bool IsOfacSearchValid(OfacSystem.OfacStatus ofacSearch)
  {
    bool flag;
    if (this.SearchValidDays > 0)
    {
      DateTime? clearDate = ofacSearch.ClearDate;
      if (clearDate.HasValue)
      {
        DateTime now = DateTime.Now;
        clearDate = ofacSearch.ClearDate;
        DateTime dateTime = clearDate.Value;
        if ((now - dateTime).TotalDays > (double) this.SearchValidDays)
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

  protected override bool IsOfacHit(XDocument result)
  {
    return !((result != null ? result.Descendants((XName) "ReturnCode").FirstOrDefault<XElement>()?.Value : (string) null) ?? "-1").ValueIn<string>("100", "-1");
  }
}
