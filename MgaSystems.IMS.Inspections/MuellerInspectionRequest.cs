// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.MuellerInspectionRequest
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Policies.Inspections.Mueller;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

public abstract class MuellerInspectionRequest
{
  private readonly Quote _quote;
  private readonly RRIRequest _ds;
  private string _surveyType;
  private int _insCompanyID;

  public MuellerInspectionRequest(RRIRequest ds, Quote quote)
  {
    this._ds = ds;
    this._quote = quote;
  }

  public string SurveyType
  {
    get => this._surveyType;
    set => this._surveyType = value;
  }

  public int InspectionCompanyID
  {
    get => this._insCompanyID;
    set => this._insCompanyID = value;
  }

  protected abstract void ProcessMuellerRequests(
    string un,
    string password,
    string host,
    string xml);

  public bool SendMuellerRequests()
  {
    string setting1 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("MuellerInspections.UserName", string.Empty);
    string setting2 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("MuellerInspections.Password", string.Empty);
    string setting3 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("MuellerInspections.Url", string.Empty);
    bool flag;
    if (string.IsNullOrEmpty(setting1) || string.IsNullOrEmpty(setting2) || string.IsNullOrEmpty(setting3))
    {
      int num = (int) MessageBox.Show("Missing credentials for Mueller Reports.", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
    {
      bool usingNetRate = this._quote.UsingNetRate;
      string xml;
      try
      {
        string str1 = string.Empty;
        string insuredPolicyName = this._quote.InsuredPolicyName;
        string insuredAddress1 = this._quote.InsuredAddress1;
        string insuredAddress2 = this._quote.InsuredAddress2;
        string insuredCity = this._quote.InsuredCity;
        string insuredState = this._quote.InsuredState;
        string insuredZipCode = this._quote.InsuredZipCode;
        string insuredMobileNumber = this._quote.InsuredMobileNumber;
        string shortDateString = this._quote.EffectiveDate.ToShortDateString();
        string str2 = this._quote.Premium.ToString();
        int num = this._quote.SubmissionGroup.ProducerLocation.Producer.ProducerCode;
        string str3 = num.ToString();
        string producerName = this._quote.ProducerName;
        string producerContactPhone = this._quote.ProducerContactPhone;
        string str4 = $"{this._quote.Underwriter.FirstName.Substring(0, 1)}{this._quote.Underwriter.LastName.Substring(0, 1)}";
        if (this._quote.HasPolicyNumber)
          str1 = this._quote.PolicyNumber;
        string empty = string.Empty;
        object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("Inspections_GetMuellerInsuredPhone", new object[2]
        {
          (object) "@QuoteGuid",
          (object) this._quote.QuoteGuid
        }));
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
          empty = objectValue.ToString();
        List<MuellerRequest.Inspection> inspectionList = new List<MuellerRequest.Inspection>();
        try
        {
          foreach (RRIRequest.LocationRow row in this._ds.Location.Rows)
          {
            MuellerRequest.Inspection inspection1 = new MuellerRequest.Inspection();
            num = this._quote.ControlNo;
            inspection1.PolicyID = num.ToString();
            inspection1.PolicyNumber = str1;
            inspection1.InsuredName = insuredPolicyName;
            inspection1.MailingAddress1 = insuredAddress1;
            inspection1.MailingAddress2 = insuredAddress2;
            inspection1.MailingCity = insuredCity;
            inspection1.MailingState = insuredState;
            inspection1.MailingZip = insuredZipCode;
            inspection1.SurveyAddress1 = row.Location_Address1;
            MuellerRequest.Inspection inspection2 = inspection1;
            if (!row.IsLocation_Address2Null())
              inspection2.SurveyAddress2 = row.Location_Address2;
            inspection2.SurveyCity = row.Location_City;
            inspection2.SurveyState = row.Location_State;
            if (!row.IsLocation_ZipcodeNull())
              inspection2.SurveyZip = row.Location_Zipcode;
            inspection2.InsuredPhone = empty;
            inspection2.InsuredPhone2 = insuredMobileNumber;
            inspection2.BusinessType = string.Empty;
            inspection2.SurveyType = this.SurveyType;
            inspection2.EffectiveDate = shortDateString;
            inspection2.CoverageIn = str2;
            inspection2.AgentCode = str3;
            inspection2.AgentName = producerName;
            inspection2.AgentPhone = producerContactPhone;
            if (!usingNetRate)
            {
              short? nullable = DefaultDatabase.ExecuteScalar<short?>(CommandType.Text, "select YearBuilt from tblUnderwritingLocations with (nolock) where LocationID = @ID", new object[2]
              {
                (object) "@ID",
                (object) row.Location_Id
              });
              if (nullable.HasValue)
                inspection2.YearBuilt = nullable.Value.ToString();
            }
            inspection2.UnderwriterCode = str4;
            if (!row.IsSpecial_InstructionsNull())
              inspection2.Comments = row.Special_Instructions;
            inspectionList.Add(inspection2);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        xml = this.GetXml(new MuellerRequest()
        {
          Inspections = inspectionList.ToArray()
        });
        this.ProcessMuellerRequests(setting1, setting2, setting3, xml);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show($"Inspection failed with the following message ... {Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        throw;
      }
      this.LogMuellerRequest(xml, usingNetRate);
      int num1 = (int) MessageBox.Show("Requests sent successfully to inspection company", "Request(s) Sent Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = true;
    }
    return flag;
  }

  private string GetXml(MuellerRequest tmpRequest)
  {
    XmlSerializer xmlSerializer = new XmlSerializer(tmpRequest.GetType());
    using (MemoryStream w = new MemoryStream())
    {
      using (XmlTextWriter xmlTextWriter = new XmlTextWriter((Stream) w, Encoding.UTF8))
      {
        xmlTextWriter.Namespaces = true;
        xmlSerializer.Serialize((XmlWriter) xmlTextWriter, (object) tmpRequest, InspectionRequest.GetEmptyNamespaces());
      }
      w.Close();
      string str1 = Encoding.UTF8.GetString(w.GetBuffer());
      string str2 = str1.Substring(str1.IndexOf(Convert.ToChar(60)));
      return str2.Substring(0, str2.LastIndexOf(Convert.ToChar(62)) + 1).Replace("<MuellerRequest>", string.Empty).Replace("</MuellerRequest>", string.Empty);
    }
  }

  private void LogMuellerRequest(string xmlString, bool isNetRate)
  {
    Guid userGuid = CurrentUser.Instance.UserGUID;
    if (isNetRate)
    {
      try
      {
        foreach (RRIRequest.LocationRow row in this._ds.Location.Rows)
        {
          string str = $" {RuntimeHelpers.GetObjectValue(row["Location_Address1"])}, {RuntimeHelpers.GetObjectValue(row["Location_City"])} , {RuntimeHelpers.GetObjectValue(row["Location_State"])}";
          CurrentUser.Instance.LogAction("Inspection requested for location: " + str, this._quote.ControlGuid);
          CurrentUser.Instance.LogAction("Inspection requested for location: " + str, this._quote.QuoteGuid);
          InspectionsLogging.LogInspectionRequest(this._quote.QuoteGuid, this.InspectionCompanyID, Conversions.ToInteger(row["Location_Id"]), true, userGuid, Guid.Empty, false, xmlString);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else
    {
      string empty = string.Empty;
      string str1 = string.Empty;
      string inspectionCompany = InspectionRequest.GetInspectionCompany(this.InspectionCompanyID);
      try
      {
        foreach (RRIRequest.LocationRow row1 in this._ds.Location.Rows)
        {
          DataRow row2 = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT LocationNo, BuildingNo, LocationGuid, QuoteGuid, InspectionCompanyID FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID=@LID", new object[2]
          {
            (object) "@LID",
            (object) row1.Location_Id
          });
          if (row2 != null)
          {
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblUnderwritingLocations SET InspectionRequested=@InspectionRequested WHERE LocationID=@LocationID", new object[4]
            {
              (object) "@InspectionRequested",
              (object) DateTime.Now,
              (object) "@LocationID",
              (object) row1.Location_Id
            });
            if (!row2.IsNull("LocationNo"))
              empty = row2.Field<int>("LocationNo").ToString();
            if (!row2.IsNull("BuildingNo"))
              str1 = row2.Field<string>("BuildingNo");
            Guid locationGuid = row2.Field<Guid>("LocationGuid");
            string str2 = "Inspection requested for location #";
            CurrentUser.Instance.LogAction($"{str2}{empty}, building # {str1} via {inspectionCompany}", this._quote.ControlGuid);
            CurrentUser.Instance.LogAction($"{str2}{empty}, building # {str1} via {inspectionCompany}", this._quote.QuoteGuid);
            InspectionsLogging.LogInspectionRequest(row2.Field<Guid>("QuoteGuid"), row2.Field<int>("InspectionCompanyID"), row1.Location_Id, false, userGuid, locationGuid, false, xmlString);
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }
}
