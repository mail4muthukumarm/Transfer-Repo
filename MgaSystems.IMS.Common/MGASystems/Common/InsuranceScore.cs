// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.InsuranceScore
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Data;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public class InsuranceScore : IScoreProx
{
  private readonly string _url;
  private readonly string _un;
  private readonly string _pw;
  private readonly Guid _entityGuid;
  private string _content;
  private string _responseString;

  public bool IsBlockBoxMode { get; set; }

  public string Response => this._content;

  public InsuranceScore(Guid entityGuid)
  {
    this._url = string.Empty;
    this._un = string.Empty;
    this._pw = string.Empty;
    this._content = string.Empty;
    this._responseString = string.Empty;
    this.IsBlockBoxMode = false;
    this._entityGuid = entityGuid;
    if (SystemSettings.KeyExists("InsuranceScore.URL"))
      this._url = SystemSettings.GetStringSetting("InsuranceScore.URL");
    if (SystemSettings.KeyExists("InsuranceScore.UserName"))
      this._un = SystemSettings.GetStringSetting("InsuranceScore.UserName");
    if (!SystemSettings.KeyExists("InsuranceScore.Password"))
      return;
    this._pw = SystemSettings.GetStringSetting("InsuranceScore.Password");
  }

  public static int GetScore(Guid entityGuid)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 Score FROM tblInsuranceScoresResult r WITH (NOLOCK) INNER JOIN tblInsuranceScores s WITH (NOLOCK) ON r.InsuranceScoreGuid = s.InsuranceScoreGuid WHERE r.EntityGuid = @EG AND r.Score IS NOT NULL AND s.Valid = 1 ORDER BY r.ID DESC", new object[2]
    {
      (object) "@EG",
      (object) entityGuid
    }));
    return Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? int.MinValue : Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue));
  }

  public static bool IsStateExcluded(string stateID)
  {
    return SystemSettings.KeyExists("InsuranceScore.ExcludedStates") && SystemSettings.GetStringSetting("InsuranceScore.ExcludedStates").Contains(stateID);
  }

  public static bool ImplementsInsuranceScore()
  {
    return SystemSettings.KeyExists("Insureds.ImplementInsuredScores") && SystemSettings.GetBoolSetting("Insureds.ImplementInsuredScores");
  }

  public static int ScoreThreshold()
  {
    return !SystemSettings.KeyExists("InsuranceScore.Threshold") ? int.MinValue : Convert.ToInt32(SystemSettings.GetNumericSetting("InsuranceScore.Threshold"));
  }

  private bool ValidCredentials()
  {
    bool flag;
    if (string.IsNullOrEmpty(this._url) || string.IsNullOrEmpty(this._un) || string.IsNullOrEmpty(this._pw))
    {
      if (this.IsBlockBoxMode)
        throw new InvalidOperationException("Missing credentials");
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
    bool flag1;
    if (!this.ValidCredentials())
    {
      flag1 = false;
    }
    else
    {
      bool flag2 = false;
      DataRow entityInfo = this.GetEntityInfo("SELECT TOP 1 i.Name, i.DOB, il.Address1, il.Address2, il.City,il.State,il.ZipCode FROM tblinsureds i WITH (NOLOCK) INNER JOIN tblInsuredLocations il WITH (NOLOCK) on il.InsuredGUID = i.InsuredGUID WHERE i.InsuredGUID = @IG AND il.LocationTypeID = 1");
      InsuranceScoreProxy insuranceScoreProxy = new InsuranceScoreProxy();
      insuranceScoreProxy.name = entityInfo.Field<string>("Name");
      if (!entityInfo.IsNull("DOB"))
      {
        insuranceScoreProxy.dateOfBirth = entityInfo.Field<DateTime>("DOB");
        insuranceScoreProxy.dateOfBirth = new DateTime(insuranceScoreProxy.dateOfBirth.Year, insuranceScoreProxy.dateOfBirth.Month, insuranceScoreProxy.dateOfBirth.Day);
      }
      if (!entityInfo.IsNull("Address1"))
        insuranceScoreProxy.address1 = entityInfo.Field<string>("Address1");
      if (!entityInfo.IsNull("Address2"))
        insuranceScoreProxy.address2 = entityInfo.Field<string>("Address2");
      if (!entityInfo.IsNull("City"))
        insuranceScoreProxy.city = entityInfo.Field<string>("City");
      if (!entityInfo.IsNull("State"))
        insuranceScoreProxy.state = entityInfo.Field<string>("State");
      if (!entityInfo.IsNull("ZipCode"))
        insuranceScoreProxy.zip = entityInfo.Field<string>("ZipCode");
      using (HttpClient httpClient = new HttpClient())
      {
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, this._url);
        request.Content = (HttpContent) new StringContent(JsonConvert.SerializeObject((object) insuranceScoreProxy), Encoding.UTF8, "application/json");
        string base64String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{this._un}:{this._pw}"));
        request.Headers.Add("Authorization", "Basic " + base64String);
        HttpResponseMessage result = httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result;
        if (result.IsSuccessStatusCode)
        {
          flag2 = true;
          this._content = result.Content.ReadAsStringAsync().Result;
        }
        else
          this._responseString = result.ReasonPhrase;
      }
      if (flag2)
      {
        CurrentUser.Instance.LogAction("Invoke insurance score service successfully.", this._entityGuid);
        this.PushResponse();
      }
      else
      {
        CurrentUser.Instance.LogAction("Invoke insurance score service  - Not Successful.", this._entityGuid);
        this.FailedRequest();
      }
      if (!this.IsBlockBoxMode)
      {
        if (flag2)
        {
          int num1 = (int) MessageBox.Show("Insurance score service runs successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          int num2 = (int) MessageBox.Show("Insurance score service fails", "Insurance Score Service Fails", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      flag1 = flag2;
    }
    return flag1;
  }

  private void FailedRequest()
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblInsuranceScores(EntityGuid, InsuranceScoreGuid, Valid, Response ) VALUES(@EntityGuid, @InsuranceScoreGuid, @Valid, @Response)", new object[8]
    {
      (object) "@EntityGuid",
      (object) this._entityGuid,
      (object) "@InsuranceScoreGuid",
      (object) Guid.NewGuid(),
      (object) "@Valid",
      (object) false,
      (object) "@Response",
      (object) this._responseString
    });
  }

  private void PushResponse()
  {
    string tagsValueString1 = XMLFunctions.GetTagsValueString(this._content, "<admin>", "</admin>");
    object objectValue1 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<product_group>", "</product_group>"));
    object objectValue2 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<pnc_account>", "</pnc_account>"));
    object objectValue3 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<pnc_account_name>", "</pnc_account_name>"));
    RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<product_reference>", "</product_reference>"));
    object objectValue4 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<report_type>", "</report_type>"));
    object objectValue5 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<status>", "</status>"));
    object objectValue6 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<ownership>", "</ownership>"));
    object objectValue7 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<report_code>", "</report_code>"));
    object objectValue8 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<report_description>", "</report_description>"));
    object objectValue9 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<purpose>", "</purpose>"));
    object objectValue10 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<date_request_ordered>", "</date_request_ordered>"));
    object objectValue11 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<date_request_received>", "</date_request_received>"));
    object objectValue12 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<date_request_completed>", "</date_request_completed>"));
    object objectValue13 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<time_report_processed>", "</time_report_processed>"));
    object objectValue14 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<multiple_scores_ordered>", "</multiple_scores_ordered>"));
    string tagsValueString2 = XMLFunctions.GetTagsValueString(tagsValueString1, "<report>", "</report>");
    object objectValue15 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString2, "<sequence>", "</sequence>"));
    object objectValue16 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString2, "<count>", "</count>"));
    object objectValue17 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<lj_source>", "</lj_source>"));
    object objectValue18 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(tagsValueString1, "<lj_status>", "</lj_status>"));
    Guid guid = Guid.NewGuid();
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblInsuranceScores (EntityGuid, InsuranceScoreGuid, Valid, RequestXml, product_group, pnc_account, pnc_account_name, report_type ,status, ownership, report_code, report_description,purpose, date_request_ordered,date_request_received,date_request_completed,time_report_processed,multiple_scores_ordered, report_sequence, report_count, lj_source, lj_status) VALUES(@EntityGuid, @InsuranceScoreGuid, @Valid, @RequestXml, @product_group, @pnc_account, @pnc_account_name, @report_type ,@status, @ownership, @report_code, @report_description, @purpose,  @date_request_ordered, @date_request_received, @date_request_completed, @time_report_processed, @multiple_scores_ordered, @report_sequence,  @report_count, @lj_source, @lj_status)", new object[44]
    {
      (object) "@EntityGuid",
      (object) this._entityGuid,
      (object) "@InsuranceScoreGuid",
      (object) guid,
      (object) "@Valid",
      (object) true,
      (object) "@product_group",
      objectValue1,
      (object) "@pnc_account",
      objectValue2,
      (object) "@pnc_account_name",
      objectValue3,
      (object) "@report_type",
      objectValue4,
      (object) "@status",
      objectValue5,
      (object) "@ownership",
      objectValue6,
      (object) "@report_code",
      objectValue7,
      (object) "@report_description",
      objectValue8,
      (object) "@purpose",
      objectValue9,
      (object) "@date_request_ordered",
      objectValue10,
      (object) "@date_request_received",
      objectValue11,
      (object) "@date_request_completed",
      objectValue12,
      (object) "@time_report_processed",
      objectValue13,
      (object) "@multiple_scores_ordered",
      objectValue14,
      (object) "@report_sequence",
      objectValue15,
      (object) "@report_count",
      objectValue16,
      (object) "@lj_source",
      objectValue17,
      (object) "@lj_status",
      objectValue18,
      (object) "@RequestXml",
      (object) this._content
    });
    string xmlString = XMLFunctions.GetTagsValueString(XMLFunctions.GetTagsValueString(this._content, "<alerts_scoring>", "</alerts_scoring>"), "<scoring>", "</scoring>", true);
    while (xmlString.Contains("<score>") && xmlString.Contains("</score>"))
    {
      object objectValue19 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(xmlString, "<score>", "</score>"));
      object objectValue20 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(xmlString, "<model_label>", "</model_label>"));
      object objectValue21 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(xmlString, "<classification>", "</classification>"));
      object objectValue22 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(xmlString, "<model_id>", "</model_id>"));
      xmlString = xmlString.Replace("<score>", string.Empty).Replace("</score>", string.Empty);
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblInsuranceScoresResult (EntityGuid, InsuranceScoreGuid, score, model_label, classification, model_id) VALUES(@EntityGuid, @InsuranceScoreGuid, @score, @model_label, @classification, @model_id)", new object[12]
      {
        (object) "@EntityGuid",
        (object) this._entityGuid,
        (object) "@InsuranceScoreGuid",
        (object) guid,
        (object) "@score",
        objectValue19,
        (object) "@model_label",
        objectValue20,
        (object) "@classification",
        objectValue21,
        (object) "@model_id",
        objectValue22
      });
    }
  }

  public static string GetStatus(Guid entityGuid)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 lj_status FROM tblInsuranceScores WITH (NOLOCK) WHERE EntityGuid = @EG ORDER BY ID DESC", new object[2]
    {
      (object) "@EG",
      (object) entityGuid
    }));
    return Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? string.Empty : objectValue.ToString();
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
