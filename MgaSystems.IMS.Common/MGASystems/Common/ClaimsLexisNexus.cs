// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ClaimsLexisNexus
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.Common;

public class ClaimsLexisNexus : ILexisNexusClaims
{
  private readonly string _url;
  private readonly string _un;
  private readonly string _pw;
  private readonly Guid _entityGuid;
  private string _content;
  private string _responseString;

  public bool IsBlockBoxMode { get; set; }

  public string Response => this._content;

  public string InvalidStatusResponse => this._responseString;

  public ClaimsLexisNexus(Guid entityGuid)
  {
    this._url = string.Empty;
    this._un = string.Empty;
    this._pw = string.Empty;
    this._content = string.Empty;
    this._responseString = string.Empty;
    this.IsBlockBoxMode = false;
    this._entityGuid = entityGuid;
    if (SystemSettings.KeyExists("LexisNexusClaims.URL"))
      this._url = SystemSettings.GetStringSetting("LexisNexusClaims.URL");
    if (SystemSettings.KeyExists("LexisNexusClaims.UserName"))
      this._un = SystemSettings.GetStringSetting("LexisNexusClaims.UserName");
    if (!SystemSettings.KeyExists("LexisNexusClaims.Password"))
      return;
    this._pw = SystemSettings.GetStringSetting("LexisNexusClaims.Password");
  }

  public static bool ImplementsLexisNexusClaims()
  {
    return SystemSettings.KeyExists("ImplementLexisNexusClaims") && SystemSettings.GetBoolSetting("ImplementLexisNexusClaims");
  }

  protected virtual bool ValidCredentials()
  {
    bool flag;
    if (string.IsNullOrEmpty(this._url) || string.IsNullOrEmpty(this._un) || string.IsNullOrEmpty(this._pw))
    {
      if (this.IsBlockBoxMode)
        throw new InvalidOperationException("Missing credentials for Lexis Nexus Claims utility.");
      int num = (int) MessageBox.Show("Missing credentials", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  public bool Submit()
  {
    this._content = string.Empty;
    this._responseString = string.Empty;
    bool flag1;
    if (!this.ValidCredentials())
    {
      flag1 = false;
    }
    else
    {
      bool flag2 = false;
      DataRow entityInfo = this.GetEntityInfo("SELECT TOP 1 i.Name, i.DOB, il.Address1, il.Address2, il.City,il.State,il.ZipCode FROM tblinsureds i WITH (NOLOCK) INNER JOIN tblInsuredLocations il WITH (NOLOCK) on il.InsuredGUID = i.InsuredGUID WHERE i.InsuredGUID = @IG AND il.LocationTypeID = 1");
      LexisNexusClaimsProxy nexusClaimsProxy = new LexisNexusClaimsProxy();
      nexusClaimsProxy.name = entityInfo.Field<string>("Name");
      if (!entityInfo.IsNull("DOB"))
      {
        nexusClaimsProxy.dateOfBirth = entityInfo.Field<DateTime>("DOB");
        nexusClaimsProxy.dateOfBirth = new DateTime(nexusClaimsProxy.dateOfBirth.Year, nexusClaimsProxy.dateOfBirth.Month, nexusClaimsProxy.dateOfBirth.Day);
      }
      if (!entityInfo.IsNull("Address1"))
        nexusClaimsProxy.address1 = entityInfo.Field<string>("Address1");
      if (!entityInfo.IsNull("Address2"))
        nexusClaimsProxy.address2 = entityInfo.Field<string>("Address2");
      if (!entityInfo.IsNull("City"))
        nexusClaimsProxy.city = entityInfo.Field<string>("City");
      if (!entityInfo.IsNull("State"))
        nexusClaimsProxy.state = entityInfo.Field<string>("State");
      if (!entityInfo.IsNull("ZipCode"))
        nexusClaimsProxy.zip = entityInfo.Field<string>("ZipCode");
      using (HttpClient httpClient = new HttpClient())
      {
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, this._url);
        request.Content = (HttpContent) new StringContent(JsonConvert.SerializeObject((object) nexusClaimsProxy), Encoding.UTF8, "application/json");
        string base64String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{this._un}:{this._pw}"));
        request.Headers.Add("Authorization", "Basic " + base64String);
        HttpResponseMessage result = httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result;
        if (result.IsSuccessStatusCode)
        {
          flag2 = true;
          this._content = result.Content.ReadAsStringAsync().Result;
        }
        this._responseString = result.ReasonPhrase;
      }
      if (flag2)
      {
        CurrentUser.Instance.LogAction("Invoke Lexis Nexus Claims service successfully.", this._entityGuid);
        this.PushResponse();
      }
      else
      {
        CurrentUser.Instance.LogAction("Invoke Lexis Nexus Claims service  - Not Successful.", this._entityGuid);
        this.FailedRequest();
      }
      if (!this.IsBlockBoxMode)
      {
        if (flag2)
        {
          int num1 = (int) MessageBox.Show("Lexis Nexus Claims service runs successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          int num2 = (int) MessageBox.Show("Lexis Nexus Claims service fails", "Insurance Score Service Fails", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      flag1 = flag2;
    }
    return flag1;
  }

  protected virtual void FailedRequest()
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblLexisNexusClaims(EntityGuid, ClaimGuid, Valid, Response ) VALUES(@EntityGuid, @ClaimGuid, @Valid, @Response)", new object[8]
    {
      (object) "@EntityGuid",
      (object) this._entityGuid,
      (object) "@ClaimGuid",
      (object) Guid.NewGuid(),
      (object) "@Valid",
      (object) false,
      (object) "@Response",
      (object) this._responseString
    });
  }

  protected virtual void PushResponse()
  {
    string tagsValueString1 = XMLFunctions.GetTagsValueString(this._content, "<admin>", "</admin>");
    object objectValue1 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<product_group>", "</product_group>"));
    object objectValue2 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<product_reference>", "</product_reference>"));
    object objectValue3 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<report_code>", "</report_code>"));
    object objectValue4 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<receipt_date>", "</receipt_date>"));
    object objectValue5 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<date_request_ordered>", "</date_request_ordered>"));
    object objectValue6 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<status>", "</status>"));
    object objectValue7 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(this._content, "<total_risk_claims>", "</total_risk_claims>"));
    Guid guid = Guid.NewGuid();
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblLexisNexusClaims (EntityGuid, ClaimGuid, Valid, TransactionID, product_reference, report_code, receipt_date, date_request_ordered,  status, total_risk_claims, Response, RequestXml, UserGuid ) VALUES(@EntityGuid, @ClaimGuid, @Valid, @TransactionID,  @product_reference, @report_code, @receipt_date, @date_request_ordered, @status, @total_risk_claims, @Response, @RequestXml, @UserGuid )", new object[26]
    {
      (object) "@EntityGuid",
      (object) this._entityGuid,
      (object) "@ClaimGuid",
      (object) guid,
      (object) "@Valid",
      (object) true,
      (object) "@TransactionID",
      objectValue1,
      (object) "@product_reference",
      objectValue2,
      (object) "@report_code",
      objectValue3,
      (object) "@receipt_date",
      objectValue4,
      (object) "@date_request_ordered",
      objectValue5,
      (object) "@status",
      objectValue6,
      (object) "@total_risk_claims",
      objectValue7,
      (object) "@Response",
      (object) this._responseString,
      (object) "@RequestXml",
      (object) this._content,
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    string tagsValueString2 = XMLFunctions.GetTagsValueString(this._content, "<results_dataset>", "</results_dataset>", true);
    XDocument xdocument1 = new XDocument();
    XDocument xdocument2 = XDocument.Parse(tagsValueString2);
    IEnumerable<XElement> source1 = xdocument2.Descendants();
    System.Func<XElement, bool> predicate1;
    // ISSUE: reference to a compiler-generated field
    if (ClaimsLexisNexus._Closure\u0024__.\u0024I19\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate1 = ClaimsLexisNexus._Closure\u0024__.\u0024I19\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      ClaimsLexisNexus._Closure\u0024__.\u0024I19\u002D0 = predicate1 = (System.Func<XElement, bool>) ([SpecialName] (element) => element.Name == (XName) "claim");
    }
    IEnumerable<XElement> source2 = source1.Where<XElement>(predicate1);
    System.Func<XElement, XElement> selector1;
    // ISSUE: reference to a compiler-generated field
    if (ClaimsLexisNexus._Closure\u0024__.\u0024I19\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector1 = ClaimsLexisNexus._Closure\u0024__.\u0024I19\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      ClaimsLexisNexus._Closure\u0024__.\u0024I19\u002D1 = selector1 = (System.Func<XElement, XElement>) ([SpecialName] (element) => element);
    }
    IEnumerable<XElement> source3 = source2.Select<XElement, XElement>(selector1);
    object obj1 = (object) DBNull.Value;
    try
    {
      foreach (XAttribute attribute in source3.Attributes())
      {
        if (attribute.Name.ToString().Equals("number"))
        {
          obj1 = (object) attribute.Value;
          break;
        }
      }
    }
    finally
    {
      IEnumerator<XAttribute> enumerator;
      enumerator?.Dispose();
    }
    object objectValue8 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString2, "<claim_date>", "</claim_date>"));
    object obj2 = (object) DBNull.Value;
    object obj3 = (object) DBNull.Value;
    object obj4 = (object) DBNull.Value;
    IEnumerable<XElement> source4 = xdocument2.Descendants();
    System.Func<XElement, bool> predicate2;
    // ISSUE: reference to a compiler-generated field
    if (ClaimsLexisNexus._Closure\u0024__.\u0024I19\u002D2 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate2 = ClaimsLexisNexus._Closure\u0024__.\u0024I19\u002D2;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      ClaimsLexisNexus._Closure\u0024__.\u0024I19\u002D2 = predicate2 = (System.Func<XElement, bool>) ([SpecialName] (element) => element.Name == (XName) "claimPayment");
    }
    IEnumerable<XElement> source5 = source4.Where<XElement>(predicate2);
    System.Func<XElement, XElement> selector2;
    // ISSUE: reference to a compiler-generated field
    if (ClaimsLexisNexus._Closure\u0024__.\u0024I19\u002D3 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector2 = ClaimsLexisNexus._Closure\u0024__.\u0024I19\u002D3;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      ClaimsLexisNexus._Closure\u0024__.\u0024I19\u002D3 = selector2 = (System.Func<XElement, XElement>) ([SpecialName] (element) => element);
    }
    IEnumerable<XElement> source6 = source5.Select<XElement, XElement>(selector2);
    try
    {
      foreach (XAttribute attribute in source6.Attributes())
      {
        if (attribute.Name.ToString().Equals("cause_of_loss"))
          obj4 = (object) attribute.Value;
        else if (attribute.Name.ToString().Equals("amount_paid"))
          obj3 = (object) attribute.Value;
        else if (attribute.Name.ToString().Equals("disposition"))
          obj2 = (object) attribute.Value;
      }
    }
    finally
    {
      IEnumerator<XAttribute> enumerator;
      enumerator?.Dispose();
    }
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblLexisNexusClaimsResults (EntityGuid, ClaimGuid, claimNumber, claim_date, disposition, amount_paid, cause_of_loss) VALUES(@EntityGuid, @ClaimGuid, @claimNumber, @claim_date, @disposition, @amount_paid, @cause_of_loss)", new object[14]
    {
      (object) "@EntityGuid",
      (object) this._entityGuid,
      (object) "@ClaimGuid",
      (object) guid,
      (object) "@claimNumber",
      obj1,
      (object) "@claim_date",
      objectValue8,
      (object) "@disposition",
      obj2,
      (object) "@amount_paid",
      obj3,
      (object) "@cause_of_loss",
      obj4
    });
  }

  public DataRow GetEntityInfo(string queryText)
  {
    return DefaultDatabase.ExecuteDataRow(CommandType.Text, queryText, new object[2]
    {
      (object) "@IG",
      (object) this._entityGuid
    });
  }
}
