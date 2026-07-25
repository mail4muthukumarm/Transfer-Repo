// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.LossControlInspection
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

public class LossControlInspection
{
  private readonly Quote _quote;
  private readonly string _un;
  private readonly string _pw;
  private readonly string _url;
  private object _AgencyName;
  private object _AgentContactEmail;
  private object _AgentContactPhone;
  private object _policyNumber;
  private readonly RRIRequest _ds;
  private readonly Guid _quoteGuid;

  public LossControlInspection(Guid quoteGuid, RRIRequest ds)
  {
    this._un = string.Empty;
    this._pw = string.Empty;
    this._url = string.Empty;
    this._AgencyName = (object) null;
    this._AgentContactEmail = (object) null;
    this._AgentContactPhone = (object) null;
    this._policyNumber = (object) null;
    this._quoteGuid = quoteGuid;
    this._quote = new Quote(quoteGuid);
    this._ds = ds;
    this._un = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("Inspections.LossControl360.UserName", string.Empty);
    this._pw = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("Inspections.LossControl360.Password", string.Empty);
    this._url = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("Inspections.LossControl360.url", string.Empty);
    this.IsUsingNetRate = this._quote.UsingNetRate || this.RateAsNetRate;
  }

  public bool IsUsingNetRate { get; set; }

  public bool RateAsNetRate { get; set; }

  public string SurveyType { get; set; }

  private string AgencyContactEmail
  {
    get
    {
      if (this._AgentContactEmail == null)
      {
        this._AgentContactEmail = (object) this._quote.ProducerContactEmail;
        if (string.IsNullOrEmpty(this._AgentContactEmail.ToString()))
          this._AgentContactEmail = (object) this._quote.ProducerLocation.Email;
      }
      return this._AgentContactEmail.ToString();
    }
  }

  private string AgencyContactPhone
  {
    get
    {
      if (this._AgentContactPhone == null)
      {
        this._AgentContactPhone = (object) this._quote.ProducerContactPhone;
        if (this._AgentContactPhone == null || string.IsNullOrEmpty(this._AgentContactPhone.ToString()))
          this._AgentContactPhone = (object) this._quote.ProducerLocation.Phone;
        if (this._AgentContactPhone == null)
          this._AgentContactPhone = (object) string.Empty;
      }
      return this._AgentContactPhone.ToString();
    }
  }

  private string AgencyName
  {
    get
    {
      if (this._AgencyName == null)
      {
        this._AgencyName = (object) (this._quote.ProducerLocation?.LocationName ?? string.Empty);
        if (this._AgencyName.ToString().Length > 50)
          this._AgencyName = (object) this._AgencyName.ToString().Substring(0, 49);
      }
      return this._AgencyName.ToString();
    }
  }

  private string PolicyNumber
  {
    get
    {
      if (this._policyNumber == null)
        this._policyNumber = !this._quote.HasPolicyNumber ? (object) "To be Determined" : (object) this._quote.PolicyNumber;
      return this._policyNumber.ToString();
    }
  }

  private string ProducerContactCell
  {
    get
    {
      return Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select Cell from tblProducerContacts with (nolock) where ProducerContactID = @ID", new object[2]
      {
        (object) "@ID",
        (object) this._quote.SubmissionGroup.ProducerContactID
      })), string.Empty).ToString();
    }
  }

  private string ProducerContactFax
  {
    get
    {
      return Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select Fax from tblProducerContacts with (nolock) where ProducerContactID = @ID", new object[2]
      {
        (object) "@ID",
        (object) this._quote.SubmissionGroup.ProducerContactID
      })), string.Empty).ToString();
    }
  }

  protected virtual string GetLossControlAgencyCode()
  {
    return Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT LocationCode FROM tblProducerlocations WITH (NOLOCK) WHERE ProducerLocationGUID=@PLG", new object[2]
    {
      (object) "@PLG",
      (object) this._quote.ProducerLocation.ProducerLocationGuid
    })), string.Empty).ToString();
  }

  private bool AreValidCredentials()
  {
    bool flag;
    if (this._un.Replace(" ", string.Empty).Length == 0 || this._pw.Replace(" ", string.Empty).Length == 0 || this._url.Replace(" ", string.Empty).Length == 0)
    {
      int num = (int) MessageBox.Show("Loss Control 360 is missing setting and/or credentials.", "Missing Credentials/Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  public virtual bool SendUsingLossControl()
  {
    bool flag1;
    if (!this.AreValidCredentials())
    {
      flag1 = false;
    }
    else
    {
      DateTime dateTime = this._quote.EffectiveDate;
      string str1 = dateTime.ToString("yyyy-MM-ddThh:mm:ss");
      dateTime = this._quote.ExpirationDate;
      string str2 = dateTime.ToString("yyyy-MM-ddThh:mm:ss");
      string str3 = string.Empty;
      Decimal premium = this._quote.Premium;
      if (this._quote.IsImsRenewal)
        str3 = str1;
      string str4 = $"{this._quote.ProducerContactLast}, {this._quote.ProducerContactFirst}";
      string insuredPolicyName = this._quote.InsuredPolicyName;
      List<ImportRequest.Inspection> inspectionList = new List<ImportRequest.Inspection>();
      ImportRequest.PolicyHolder tmpPolicyHolder = new ImportRequest.PolicyHolder()
      {
        CompanyName = this._quote.InsuredPolicyName,
        ContactType = "Insured Contact"
      };
      DataRow row1 = DefaultDatabase.ExecuteDataRow(CommandType.Text, "select top 1 ic.FName as FName, ic.LName as LName, ic.Email as Email, ic.Phone as Phone, ic.Cell as Cell from tblInsuredContacts ic with (nolock) inner join tblInsuredLocations il  with (nolock)  on il.InsuredLocationGuid = ic.InsuredLocationGuid left join tblInsuredSpecialContacts sc  with (nolock)  on sc.InsuredContactGUID = ic.InsuredContactGUID where il.InsuredLocationGuid = @IC and (sc.SpecialContactTypeID is null or sc.SpecialContactTypeID = 177)", new object[2]
      {
        (object) "@IC",
        (object) this._quote.SubmissionGroup.InsuredLocationGuid
      });
      if (row1 != null && !row1.IsNull("FName"))
      {
        tmpPolicyHolder.FirstName = row1.Field<string>("FName");
        if (!row1.IsNull("LName"))
          tmpPolicyHolder.LastName = row1.Field<string>("LName");
        if (!row1.IsNull("Email"))
          tmpPolicyHolder.Email = row1.Field<string>("Email");
        if (!row1.IsNull("Cell"))
          tmpPolicyHolder.CellPhone = row1.Field<string>("Cell");
        tmpPolicyHolder.IsPrimary = true;
      }
      else
      {
        tmpPolicyHolder.CellPhone = this._quote.InsuredMobileNumber;
        tmpPolicyHolder.FirstName = this._quote.SubmissionGroup.Insured.FirstName;
        tmpPolicyHolder.LastName = this._quote.SubmissionGroup.Insured.LastName;
      }
      ImportRequest.Address address = new ImportRequest.Address()
      {
        Country = this._quote.ProducerLocation.CountryCode,
        Street1 = this._quote.ProducerLocation.Address1,
        Street2 = this._quote.ProducerLocation.Address2,
        City = this._quote.ProducerLocation.City,
        Region1 = this._quote.ProducerLocation.State,
        ZipCode = this._quote.ProducerLocation.Zip.Replace(" ", string.Empty)
      };
      ImportRequest.Agent agent = new ImportRequest.Agent()
      {
        AgentAddress = address,
        AgentCode = this.GetLossControlAgencyCode(),
        AgencyName = InspectionRequest.EscapeXMLChars(this.AgencyName),
        Email = this.AgencyContactEmail,
        AgentType = "Producer Agent",
        PhoneNumber = this.AgencyContactPhone
      };
      if (string.IsNullOrEmpty(agent.PhoneNumber))
        agent.PhoneNumber = this._quote.ProducerContactPhone;
      agent.FaxNumber = this._quote.ProducerLocation.Fax;
      if (string.IsNullOrEmpty(agent.FaxNumber))
        agent.FaxNumber = this.ProducerContactFax;
      ImportRequest.Underwriter underwriter = new ImportRequest.Underwriter()
      {
        Company = new OfficeLocation(this._quote.Underwriter.OfficeGuid).LocationName
      };
      if (this._quote.Underwriter.HasEmail)
        underwriter.Email = this._quote.Underwriter.Email;
      underwriter.FirstName = this._quote.Underwriter.FirstName;
      underwriter.LastName = this._quote.Underwriter.LastName;
      underwriter.PhoneNumber = this._quote.Underwriter.Phone;
      underwriter.UnderwriterCode = $"{this._quote.Underwriter.FirstName.Substring(0, 1)} {this._quote.Underwriter.LastName}";
      ImportRequest.IndustryCodes industryCodes = new ImportRequest.IndustryCodes()
      {
        SICCode = this._quote.SIC_Code
      };
      bool setting = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Inspections.LossControl360.PassCarrierID");
      string currency = this.GetCurrency();
      string userName = CurrentUser.Instance.UserName;
      try
      {
        foreach (RRIRequest.LocationRow row2 in this._ds.Location.Rows)
        {
          ImportRequest.Inspection tmpInsp = new ImportRequest.Inspection()
          {
            PolicyNumber = this.PolicyNumber,
            EffectiveDate = str1,
            PolicyExpirationDate = str2,
            DivisionLookupID = this.Division(),
            InspectionTypeLookupID = this.InspectionTypeLookupID()
          };
          if (!row2.IsSpecial_InstructionsNull())
            tmpInsp.OrderNotes = row2.Special_Instructions;
          if (setting)
            tmpInsp.CarrierID = new Guid?(this.GenerateCarrierID());
          if (!string.IsNullOrEmpty(str3))
            tmpInsp.PolicyRenewalDate = str3;
          tmpInsp.Rush = this.IsRush(row2.Location_Id);
          tmpInsp.CurrentPremium = premium;
          tmpInsp.DueDate = row2.Due_Date;
          ImportRequest.Location location = new ImportRequest.Location()
          {
            Country = "USA",
            Street1 = row2.Location_Address1
          };
          if (!row2.IsLocation_Address2Null())
            location.Street2 = row2.Location_Address2;
          location.City = row2.Location_City;
          location.Region1 = row2.Location_State;
          if (!row2.IsLocation_ZipcodeNull())
            location.ZipCode = row2.Location_Zipcode.Replace(" ", string.Empty);
          ImportRequest.Mailing mailing = new ImportRequest.Mailing()
          {
            Country = "USA",
            Street1 = this._quote.InsuredAddress1,
            Street2 = this._quote.InsuredAddress2,
            City = this._quote.InsuredCity,
            ZipCode = this._quote.InsuredZipCode.Replace(" ", string.Empty)
          };
          List<ImportRequest.GenericField> lst = new List<ImportRequest.GenericField>();
          ImportRequest.GenericField genericField1 = new ImportRequest.GenericField();
          genericField1.Key = "Original Due Date";
          genericField1.GenericFieldValueType = "DateTime";
          dateTime = Convert.ToDateTime(row2.Due_Date);
          genericField1.Text = dateTime.ToString("yyyy-MM-ddThh:mm:ss");
          ImportRequest.GenericField genericField2 = genericField1;
          lst.Add(genericField2);
          this.AddGenericFields(lst);
          tmpInsp.GenericFields = lst.ToArray();
          this.AssignContactInfo(row2, tmpPolicyHolder);
          this.AssignCoverageInfo(row2, tmpInsp);
          List<ImportRequest.Building> buildingList = new List<ImportRequest.Building>();
          ImportRequest.Building insp = new ImportRequest.Building()
          {
            Name = "Main Building"
          };
          this.AddForms(insp);
          buildingList.Add(insp);
          List<ImportRequest.Contact> contactList = new List<ImportRequest.Contact>();
          ImportRequest.Contact contact1 = new ImportRequest.Contact();
          if (this._quote.UnderwriterAssistant != null)
          {
            ImportRequest.Contact contact2 = contact1;
            contact2.WorkPhone = this._quote.UnderwriterAssistant.Phone;
            contact2.ContactType = "Underwriting Assistant";
            contact2.Email = !this._quote.UnderwriterAssistant.HasEmail ? string.Empty : this._quote.UnderwriterAssistant.Email;
            contact2.FirstName = this._quote.UnderwriterAssistant.FirstName;
            contact2.LastName = this._quote.UnderwriterAssistant.LastName;
          }
          ImportRequest.Contact contact3 = new ImportRequest.Contact();
          ImportRequest.Contact contact4 = contact3;
          contact4.WorkPhone = this._quote.ProducerContactPhone;
          contact4.ContactType = "Agent";
          contact4.Email = this._quote.ProducerContactEmail;
          contact4.FirstName = this._quote.ProducerContactFirst;
          contact4.LastName = this._quote.ProducerContactLast;
          if (string.IsNullOrEmpty(contact4.WorkPhone))
            contact4.WorkPhone = this.AgencyContactPhone;
          if (string.IsNullOrEmpty(contact4.Email))
            contact4.WorkPhone = this.AgencyContactEmail;
          contactList.Add(contact1);
          contactList.Add(contact3);
          tmpInsp.AdditionalContacts = contactList.ToArray();
          tmpInsp.Location = location;
          tmpInsp.Mailing = mailing;
          tmpInsp.PolicyHolder = tmpPolicyHolder;
          tmpInsp.Agent = agent;
          tmpInsp.Underwriter = underwriter;
          tmpInsp.CurrencyISO = currency;
          tmpInsp.CreatedByUserName = userName;
          tmpInsp.Buildings = buildingList.ToArray();
          tmpInsp.IndustryCodes = industryCodes;
          inspectionList.Add(tmpInsp);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      ImportRequest objectAs = ObjectFactory.Instance.CreateObjectAs<ImportRequest>(typeof (ImportRequest));
      objectAs.Inspections = inspectionList.ToArray();
      string requestXml = this.GetRequestXml(objectAs);
      string action = string.Empty;
      bool flag2 = false;
      string text = string.Empty;
      string str5 = string.Empty;
      using (HttpClient httpClient = new HttpClient())
      {
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.GetToken());
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, this._url)
        {
          Content = (HttpContent) new StringContent(JsonConvert.SerializeObject((object) objectAs), Encoding.UTF8, "application/json")
        };
        try
        {
          HttpResponseMessage result = httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result;
          if (result.IsSuccessStatusCode)
          {
            str5 = result.Content.ReadAsStringAsync().Result;
            flag2 = this.IsSuccess(str5);
            if (flag2)
            {
              action = $"Successfully sent inspection request(s) via 'Loss Control 360'. Result - {str5}";
            }
            else
            {
              string str6 = this.StripError(str5);
              action = $"Inspection inspection request(s) to 'Loss Control 360' unsuccessful. Error - {str5}";
              text = $"Inspection inspection request(s) to 'Loss Control 360' unsuccessful. Error - {str6}";
            }
          }
          else
          {
            flag2 = false;
            text = $"Request(s) to Loss Control 360 failed. {Environment.NewLine}Please contact Tech Support to further address this issue.";
          }
        }
        catch (Exception ex1)
        {
          ProjectData.SetProjectError(ex1);
          Exception ex2 = ex1;
          flag2 = false;
          ErrorHandler.SilentHandleError(ex2);
          text = $"Requests failed with error - {Environment.NewLine}{ex2.Message}";
          ProjectData.ClearProjectError();
        }
      }
      DefaultDatabase.ExecuteNonQuery("LogLossControl360Request", new object[8]
      {
        (object) "@QuoteGuid",
        (object) this._quote.QuoteGuid,
        (object) "RequestXml",
        (object) requestXml,
        (object) "@Response",
        (object) str5,
        (object) "@UserGuid",
        (object) CurrentUser.Instance.UserGUID
      });
      if (!string.IsNullOrEmpty(action))
      {
        if (action.Length > 2000)
          action = action.Substring(0, 1999);
        CurrentUser.Instance.LogAction(action, this._quote.QuoteGuid);
      }
      if (!string.IsNullOrEmpty(text))
      {
        int num = (int) MessageBox.Show(text, "Requests failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      flag1 = flag2;
    }
    return flag1;
  }

  private bool IsRush(int locationID)
  {
    bool? nullable;
    if (!this.IsUsingNetRate)
      nullable = new bool?((DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT Rush FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID = @LI", new object[2]
      {
        (object) "@LI",
        (object) locationID
      }) ? 1 : 0) != 0);
    else
      nullable = new bool?((DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "select Rush FROM tblInspectionsNetRateLocData With (NOLOCK) WHERE LocationID = @LI", new object[2]
      {
        (object) "@LI",
        (object) this._ds.Location[0].Location_Id
      }) ? 1 : 0) != 0);
    return nullable.HasValue && nullable.Value;
  }

  protected virtual string Division()
  {
    return MGASystems.Common.Settings.SystemSettings.GetSetting<string>("Inspections.LossControl360.Division", string.Empty);
  }

  protected virtual string InspectionTypeLookupID()
  {
    return MGASystems.Common.Settings.SystemSettings.GetSetting<string>("Inspections.LossControl360.InspectionTypeLookupID", string.Empty);
  }

  private string GetCurrency()
  {
    return Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select CurrencyCode from tblQuotes2 with (nolock) where QuoteID = @ID", new object[2]
    {
      (object) "@ID",
      (object) this._quote.QuoteID
    })), "USD").ToString();
  }

  private string GetToken()
  {
    string token = string.Empty;
    string setting = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("Inspections.LossControl360.TokenURL", string.Empty);
    if (string.IsNullOrEmpty(setting))
    {
      int num = (int) MessageBox.Show("Missing Inspections.LossControl360.TokenURL setting", "Missing Setting", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      throw new InvalidOperationException($"Missing {"Inspections.LossControl360.TokenURL"} setting ");
    }
    using (HttpClient httpClient = new HttpClient())
    {
      httpClient.DefaultRequestHeaders.Accept.Clear();
      HttpResponseMessage result = httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Post, setting)
      {
        Content = (HttpContent) new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>) new Dictionary<string, string>()
        {
          {
            "client_id",
            this._un
          },
          {
            "client_secret",
            this._pw
          },
          {
            "grant_type",
            "client_credentials"
          }
        })
      }, HttpCompletionOption.ResponseContentRead).Result;
      if (result.IsSuccessStatusCode)
        token = JsonConvert.DeserializeObject<LossControlToken>(result.Content.ReadAsStringAsync().Result).AccessToken;
    }
    return token;
  }

  private bool IsSuccess(string responseString)
  {
    List<Inspectionresult> responses = JsonConvert.DeserializeObject<LossControlResponseList>(responseString).Responses;
    bool flag;
    if (responses.Count == 0)
    {
      flag = false;
    }
    else
    {
      try
      {
        foreach (Inspectionresult inspectionresult in responses)
        {
          if (!inspectionresult.Success)
          {
            flag = false;
            goto label_8;
          }
        }
      }
      finally
      {
        List<Inspectionresult>.Enumerator enumerator;
        enumerator.Dispose();
      }
      flag = true;
    }
label_8:
    return flag;
  }

  private string StripError(string response)
  {
    return LossControlInspection.GetTagsValue(response, "\"Errors\":[\"", "\"],");
  }

  private string GetRequestXml(ImportRequest tmpImportRequest)
  {
    XmlSerializer xmlSerializer = new XmlSerializer(tmpImportRequest.GetType());
    MemoryStream w = new MemoryStream();
    using (XmlTextWriter xmlTextWriter = new XmlTextWriter((Stream) w, Encoding.UTF8))
    {
      xmlTextWriter.Namespaces = true;
      xmlSerializer.Serialize((XmlWriter) xmlTextWriter, (object) tmpImportRequest, InspectionRequest.GetNamespaces());
    }
    w.Close();
    string str1 = Encoding.UTF8.GetString(w.GetBuffer());
    string str2 = str1.Substring(str1.IndexOf(Convert.ToChar(60)));
    return str2.Substring(0, str2.LastIndexOf(Convert.ToChar(62)) + 1);
  }

  private static string GetTagsValue(string xmlString, string openingTag, string closingTag)
  {
    string tagsValue = string.Empty;
    if (xmlString.Contains(openingTag) && xmlString.Contains(closingTag))
    {
      int startIndex = xmlString.IndexOf(openingTag) + openingTag.Length;
      int num = xmlString.IndexOf(closingTag, startIndex);
      tagsValue = xmlString.Substring(startIndex, num - startIndex);
    }
    return tagsValue;
  }

  protected virtual void AddGenericFields(List<ImportRequest.GenericField> lst)
  {
  }

  protected virtual string LossControlGetNetrateEmail(int locationID) => string.Empty;

  private void AssignContactInfo(
    RRIRequest.LocationRow row,
    ImportRequest.PolicyHolder tmpPolicyHolder)
  {
    if (!this.IsUsingNetRate)
    {
      DataRow row1 = DefaultDatabase.ExecuteDataRow(CommandType.Text, "select LocationGuid, DateAdded, County, InspectionContact, ContactEmail, InspectionContactPhone, Comments From tblUnderwritingLocations WITH (NOLOCK) where LocationID = @ID", new object[2]
      {
        (object) "@ID",
        (object) row.Location_Id
      });
      string str1 = string.Empty;
      string empty = string.Empty;
      if (!row1.IsNull("InspectionContact"))
      {
        string str2 = row1.Field<string>("InspectionContact");
        if (str2.Contains(" "))
        {
          string[] strArray = str2.Split(' ');
          str1 = strArray[0];
          empty = strArray[1];
        }
        else
          str1 = str2;
      }
      tmpPolicyHolder.FirstName = str1;
      tmpPolicyHolder.LastName = empty;
      if (!row1.IsNull("ContactEmail"))
      {
        string str3 = row1.Field<string>("ContactEmail");
        if (!string.IsNullOrEmpty(str3))
          tmpPolicyHolder.Email = str3;
      }
      if (!row1.IsNull("InspectionContactPhone"))
      {
        string str4 = row1.Field<string>("InspectionContactPhone");
        if (!string.IsNullOrEmpty(str4))
          tmpPolicyHolder.WorkPhone = str4;
      }
      tmpPolicyHolder.ContactType = "Location Contact";
    }
    else
    {
      RRIRequest.LocationRow row2 = (RRIRequest.LocationRow) null;
      try
      {
        foreach (RRIRequest.LocationRow row3 in this._ds.Location.Rows)
        {
          if (row3.Location_Id == row.Location_Id)
          {
            row2 = row3;
            break;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (row2 == null)
        return;
      tmpPolicyHolder.ContactType = "Location Contact";
      string str5 = string.Empty;
      string empty = string.Empty;
      if (!row2.IsNull("Location_Contact_Name"))
      {
        string str6 = row2.Field<string>("Location_Contact_Name");
        if (str6.Contains(" "))
        {
          string[] strArray = str6.Split(' ');
          str5 = strArray[0];
          empty = strArray[1];
        }
        else
          str5 = str6;
      }
      tmpPolicyHolder.FirstName = str5;
      tmpPolicyHolder.LastName = empty;
      if (!row2.IsNull("Location_Contact_Phone"))
        tmpPolicyHolder.WorkPhone = row2.Field<string>("Location_Contact_Phone");
      string netrateEmail = this.LossControlGetNetrateEmail(row.Location_Id);
      if (string.IsNullOrEmpty(netrateEmail))
        return;
      tmpPolicyHolder.Email = netrateEmail;
    }
  }

  private void AssignCoverageInfo(RRIRequest.LocationRow row, ImportRequest.Inspection tmpInsp)
  {
    string str = this.IsUsingNetRate ? this.GetNetrateCoverage(row.Location_Id) : this.GetBaseCoverage(row.Location_Id);
    if (string.IsNullOrEmpty(str))
      return;
    tmpInsp.Coverages = new List<ImportRequest.Residential>()
    {
      new ImportRequest.Residential() { CoverageAIn = str }
    }.ToArray();
  }

  protected virtual string GetNetrateCoverage(int locationID) => string.Empty;

  protected virtual string GetBaseCoverage(int locationID) => string.Empty;

  protected virtual void AddForms(ImportRequest.Building insp)
  {
  }

  protected virtual Guid GenerateCarrierID() => this._quoteGuid;
}
