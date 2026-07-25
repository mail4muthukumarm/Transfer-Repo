// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.Exl
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

public class Exl
{
  private RRIRequest _ds;
  private Quote _quote;
  private string _baseAddress;
  private int _BizUnitId;
  private int _VenderID;
  private string _userName;
  private string _pw;
  private int _productLineID;

  public Exl(RRIRequest ds, Quote quote)
  {
    this._baseAddress = "https://uat.connect.webapi.ositrac.com";
    this._BizUnitId = 1059049;
    this._userName = "cust_NextWave";
    this._pw = "4B932aa506";
    this._ds = ds;
    this._quote = quote;
  }

  public bool ValidCredentials()
  {
    bool flag;
    if (SystemSettings.KeyExists("ExlInspectionUserName"))
    {
      this._userName = SystemSettings.GetStringSetting("ExlInspectionUserName");
      if (SystemSettings.KeyExists("ExlInspectionPassword"))
        this._pw = SystemSettings.GetStringSetting("ExlInspectionPassword");
      if (SystemSettings.KeyExists("ExlInspectionUrl"))
      {
        this._baseAddress = SystemSettings.GetStringSetting("ExlInspectionUrl");
        if (SystemSettings.KeyExists("ExlInspectionBizUnitID"))
        {
          this._BizUnitId = Convert.ToInt32(SystemSettings.GetNumericSetting("ExlInspectionBizUnitID"));
          if (SystemSettings.KeyExists("ExlInspectionVenderID"))
          {
            this._VenderID = Convert.ToInt32(SystemSettings.GetNumericSetting("ExlInspectionVenderID"));
            if (SystemSettings.KeyExists("ExlInspectionProductLineID"))
            {
              this._productLineID = Convert.ToInt32(SystemSettings.GetNumericSetting("ExlInspectionProductLineID"));
              string str = this._quote.ProducerLocation.Phone;
              if (str.Replace(" ", string.Empty).Length == 0)
                str = this._quote.ProducerContactPhone;
              if (str.Replace(" ", string.Empty).Length == 0)
              {
                int num = (int) MessageBox.Show("Agent phone is a required field when sending Excl inspection requests", "Missing Agent Phone #", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                flag = false;
              }
              else if (!this._quote.Underwriter.HasEmail)
              {
                int num = (int) MessageBox.Show("Underwriter email is a required field when sending Excl inspection requests", "Missing Underwriter Email", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                flag = false;
              }
              else
                flag = true;
            }
            else
            {
              int num = (int) MessageBox.Show("Missing Excl Inspection credential - Product Line ID", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              flag = false;
            }
          }
          else
          {
            int num = (int) MessageBox.Show("Missing Excl Inspection credential - VenderID", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
          }
        }
        else
        {
          int num = (int) MessageBox.Show("Missing Excl Inspection credential - BizUnitID", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Missing Excl Inspection credential - Base Address URL", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
      }
    }
    else
    {
      int num = (int) MessageBox.Show("Missing Excl Inspection credential - User Name", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    return flag;
  }

  private string GetExlAccessToken()
  {
    string exlAccessToken = string.Empty;
    object obj = (object) new
    {
      Name = ((this._userName ?? "") ?? ""),
      Password = ((this._pw ?? "") ?? "")
    };
    new HttpClientHandler().UseDefaultCredentials = true;
    using (HttpClient httpClient = new HttpClient())
    {
      HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, this._baseAddress + "/Oauth2/access_token")
      {
        Content = (HttpContent) new StringContent(JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(obj)), Encoding.UTF8, "application/json")
      };
      request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
      HttpResponseMessage result = httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead).Result;
      if (result.IsSuccessStatusCode)
        exlAccessToken = JsonConvert.DeserializeObject<ADFSToken>(result.Content.ReadAsStringAsync().Result).AccessToken;
    }
    return exlAccessToken;
  }

  public bool PostOrder(string reportValue, string supplementsValue)
  {
    string exlAccessToken = this.GetExlAccessToken();
    string requestUri = this._baseAddress + "/orderRC";
    string str1 = "TBD";
    string insuredPolicyName = this._quote.InsuredPolicyName;
    string str2 = $"{this._quote.ProducerContactLast}, {this._quote.ProducerContactFirst}";
    string producerContactPhone = this._quote.ProducerContactPhone;
    string locationName = this._quote.ProducerLocation.LocationName;
    string producerName = this._quote.ProducerName;
    string str3 = this._quote.ProducerLocation.Phone;
    string email = this._quote.ProducerLocation.Email;
    string str4 = $"{this._quote.Underwriter.LastName}, {this._quote.Underwriter.FirstName}";
    string phone = this._quote.Underwriter.Phone;
    string str5 = string.Empty;
    if (str3.Replace(" ", string.Empty).Length == 0)
      str3 = this._quote.ProducerContactPhone;
    if (this._quote.Underwriter.HasEmail)
      str5 = this._quote.Underwriter.Email;
    if (this._quote.HasPolicyNumber)
      str1 = this._quote.PolicyNumber;
    string empty = string.Empty;
    try
    {
      foreach (RRIRequest.LocationRow row in this._ds.Location.Rows)
      {
        using (HttpClient httpClient = new HttpClient())
        {
          httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", exlAccessToken);
          HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, requestUri);
          OrderDTO orderDto1 = new OrderDTO();
          OrderDTO orderDto2 = orderDto1;
          orderDto2.BizUnitId = this._BizUnitId;
          orderDto2.VendorID = this._VenderID;
          orderDto2.ProdLineId = this._productLineID;
          orderDto2.ReasonForSurvey = 1;
          DateTime result1;
          orderDto2.DueDate = !DateTime.TryParse(row.Due_Date, out result1) ? DateTime.Now.AddDays(30.0) : result1;
          orderDto2.PolicyNumber = str1;
          orderDto2.InsuredName = insuredPolicyName;
          orderDto2.SecondaryName = insuredPolicyName;
          orderDto2.SurveyAddress1 = row.Location_Address1;
          if (!row.IsLocation_Address2Null())
            orderDto2.SurveyAddress2 = row.Location_Address2;
          orderDto2.SurveyCity = row.Location_City;
          orderDto2.SurveyState = row.Location_State;
          if (!row.IsLocation_ZipcodeNull())
            orderDto2.SurveyZip = row.Location_Zipcode.Replace("-", string.Empty).Replace(" ", string.Empty);
          orderDto2.ContactName = str2;
          orderDto2.ContactPhone = producerContactPhone.Replace(" ", string.Empty).Length <= 0 ? "123-123-4567" : producerContactPhone;
          orderDto2.Agency = locationName;
          orderDto2.AgentName = producerName;
          if (str3.Replace(" ", string.Empty).Length > 0)
            orderDto2.AgentPhone = str3;
          if (email.Replace(" ", string.Empty).Length > 0)
            orderDto2.AgentEmailAddress = email;
          orderDto2.Underwriter = str4;
          orderDto2.UnderwriterPhone = phone.Replace(" ", string.Empty).Length <= 0 ? "123-123-4567" : phone;
          if (str5.Replace(" ", string.Empty).Length > 0)
            orderDto2.UnderwriterEmail = str5;
          orderDto2.EmailAddress = "nothing@gmail.com";
          orderDto2.AdditionalNotes = string.Empty;
          if (!string.IsNullOrEmpty(reportValue))
            orderDto2.AdditionalNotes += reportValue;
          if (!string.IsNullOrEmpty(supplementsValue))
            orderDto2.AdditionalNotes = $"{orderDto2.AdditionalNotes} {supplementsValue}";
          if (!this._ds.Location[0].IsSpecial_InstructionsNull())
            orderDto2.AdditionalNotes = $"{orderDto2.AdditionalNotes} {this._ds.Location[0].Special_Instructions}";
          orderDto2.TypeOfOperation = "Inspection";
          orderDto2.Guid = Guid.NewGuid();
          request.Content = (HttpContent) new StringContent(JsonConvert.SerializeObject((object) orderDto1), Encoding.UTF8, "application/json");
          try
          {
            HttpResponseMessage result2 = httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result;
            if (result2.IsSuccessStatusCode)
            {
              string action = "Successfully request via 'Exl'. Result - " + result2.Content.ReadAsStringAsync().Result;
              if (action.Length > 2000)
                action = action.Substring(0, 1999);
              CurrentUser.Instance.LogAction(action, this._quote.QuoteGuid);
            }
            else
            {
              int num = (int) MessageBox.Show("Requests failed", "Requests failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              throw new InvalidOperationException("Exl Request Failed. Contact Tech Support for a review of this error.");
            }
          }
          catch (HttpRequestException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            string message = ex.InnerException.Message;
            ProjectData.ClearProjectError();
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return true;
  }
}
