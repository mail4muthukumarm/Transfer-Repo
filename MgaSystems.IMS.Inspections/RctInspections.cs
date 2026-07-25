// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.RctInspections
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Policies.Inspections.RCT;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

public abstract class RctInspections
{
  private RRIRequest _ds;
  private Quote _quote;
  private object _inspectionMethod;
  private bool _submissionRequest;
  private int _submissionRequestInspectionCompanyID;
  private int _standAloneInspectionCompanyID;
  private List<int> _quoteList;
  private string _submissionRequestProgramCode;
  private string _submissionRequestDivision;
  private readonly FormSubmissionGroupInspectionRequests _fsr;
  private readonly bool _underwriterEmailConsolidate;
  private string _clientUniqueID;
  private string _inspectionUniqueID;

  public object BaseInspectionMethod
  {
    get => this._inspectionMethod;
    set => this._inspectionMethod = RuntimeHelpers.GetObjectValue(value);
  }

  public bool SubmissionRequest
  {
    get => this._submissionRequest;
    set => this._submissionRequest = value;
  }

  public int SubmissionRequestInspectionCompanyID
  {
    get => this._submissionRequestInspectionCompanyID;
    set => this._submissionRequestInspectionCompanyID = value;
  }

  public int StandAloneInspectionCompanyID
  {
    get => this._standAloneInspectionCompanyID;
    set => this._standAloneInspectionCompanyID = value;
  }

  public List<int> QuoteList
  {
    get => this._quoteList;
    set => this._quoteList = value;
  }

  public string SubmissionRequestProgramCode
  {
    get => this._submissionRequestProgramCode;
    set => this._submissionRequestProgramCode = value;
  }

  public string SubmissionRequestDivision
  {
    get => this._submissionRequestDivision;
    set => this._submissionRequestDivision = value;
  }

  public Quote CurrentQuote => this._quote;

  public string GetClientUniqueIdentifier => this._clientUniqueID;

  public string GetInspectionUniqueIdentifier => this._inspectionUniqueID;

  public RctInspections(RRIRequest ds, Quote quote)
  {
    this._inspectionMethod = (object) null;
    this._submissionRequest = false;
    this._standAloneInspectionCompanyID = -1;
    this._quoteList = new List<int>();
    this._fsr = (FormSubmissionGroupInspectionRequests) null;
    this._underwriterEmailConsolidate = false;
    this._clientUniqueID = string.Empty;
    this._inspectionUniqueID = string.Empty;
    this._ds = ds;
    this._quote = quote;
    try
    {
      foreach (System.Windows.Forms.Form openForm in (ReadOnlyCollectionBase) Application.OpenForms)
      {
        if (openForm is FormSubmissionGroupInspectionRequests inspectionRequests)
          this._fsr = inspectionRequests;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this._underwriterEmailConsolidate = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("RctInspectionsConsolidateUnderwriterEmail");
  }

  protected abstract void SendRctFileOnClient(
    string fileName,
    string sftpHost,
    string un,
    string pw);

  protected abstract string RctDivision();

  protected abstract void AddRctLineOfBusinessExtensionFields(List<ExtField> rctExtensionFields);

  protected virtual void AddRctInspectionExtensionFields(List<ExtField> rctExtensionFields)
  {
  }

  private void AddInspectionContactExtFields(List<ExtField> inspContactFields)
  {
  }

  private void GetBaseSubmissionLocations()
  {
    Guid userGuid = CurrentUser.Instance.UserGUID;
    string str1 = "SELECT LocationID,InspectionContact, InspectionContactPhone, Comments, Rush, Location, ClassCode FROM tblSubmissionInspRequests WITH (NOLOCK) WHERE UserGuid=@UG AND InspectionType=@IT AND QuoteGuid=@QG ";
    string str2 = "SELECT Address1, Address2, City, State, Zip FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID=@LID";
    try
    {
      foreach (DataRow row1 in DefaultDatabase.ExecuteDataTable(CommandType.Text, str1, new object[6]
      {
        (object) "@QG",
        (object) this._quote.QuoteGuid,
        (object) "@UG",
        (object) userGuid,
        (object) "@IT",
        (object) "B"
      }).Rows)
      {
        RRIRequest.LocationRow row2 = this._ds.Location.NewLocationRow();
        RRIRequest.LocationRow locationRow = row2;
        locationRow.Location_Id = Conversions.ToInteger(row1["LocationID"]);
        DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, str2, new object[2]
        {
          (object) "@LID",
          row1["LocationID"]
        });
        if (dataRow != null)
        {
          if (dataRow["Address1"] != DBNull.Value)
            locationRow.Location_Address1 = InspectionRequest.EscapeXMLChars(dataRow["Address1"].ToString());
          if (dataRow["Address2"] != DBNull.Value)
            locationRow.Location_Address2 = InspectionRequest.EscapeXMLChars(dataRow["Address2"].ToString());
          if (dataRow["City"] != DBNull.Value)
            locationRow.Location_City = InspectionRequest.EscapeXMLChars(dataRow["City"].ToString());
          locationRow.Location_State = dataRow["State"].ToString();
          if (dataRow["Zip"] != DBNull.Value)
            locationRow.Location_Zipcode = dataRow["Zip"].ToString();
        }
        if (row1["InspectionContact"] != DBNull.Value)
          locationRow.Location_Contact_Name = InspectionRequest.EscapeXMLChars(row1["InspectionContact"].ToString());
        if (row1["InspectionContactPhone"] != DBNull.Value)
          locationRow.Location_Contact_Phone = row1["InspectionContactPhone"].ToString();
        if (row1["Comments"] != DBNull.Value)
          locationRow.Special_Instructions = InspectionRequest.EscapeXMLChars(row1["Comments"].ToString());
        if (row1["Rush"] != DBNull.Value)
          locationRow.Rush = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(row1["Rush"]));
        locationRow.Location_Description = row1["Location"] == DBNull.Value ? "TBD" : row1["Location"].ToString();
        locationRow.Due_Date = Strings.Format((object) InspectionsHelperUtility.GetInspectionLocationDueDate(Conversions.ToInteger(row1["LocationID"]), this._quote.QuoteGuid), "yyyy-MM-dd");
        locationRow.Customer_Reference_ID = InspectionsHelperUtility.GetCustomerReferenceIdentifier(Conversions.ToInteger(row1["LocationID"]), this._quote.QuoteGuid);
        locationRow.RequestRow = this._ds.Request[0];
        this._ds.Location.AddLocationRow(row2);
        if (row1["ClassCode"] != DBNull.Value && row1["ClassCode"].ToString().Length > 0)
        {
          RRIRequest.SIC_CodesRow row3 = this._ds.SIC_Codes.NewSIC_CodesRow();
          row3.SIC_Code = row1["ClassCode"].ToString();
          this._ds.SIC_Codes.AddSIC_CodesRow(row3);
          row3.LocationRow = row2;
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

  private void FillCommonPolicyInformation(
    RRIRequest.RequestRow dr,
    InsuredLocation il,
    string inspectionType)
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string empty3 = string.Empty;
    string empty4 = string.Empty;
    string empty5 = string.Empty;
    string st = string.Empty;
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT  InsuredAddress1, InsuredAddress2, InsuredCity, InsuredZipCode, InsuredState, InsuredDBA FROM tblQuotes WITH (NOLOCK) WHERE (QuoteID = @QID)", new object[2]
    {
      (object) "@QID",
      (object) this._quote.QuoteID
    });
    if (dataRow != null)
    {
      if (dataRow["InsuredAddress1"] != DBNull.Value && dataRow["InsuredAddress1"] != null)
        empty1 = dataRow["InsuredAddress1"].ToString();
      if (dataRow["InsuredAddress2"] != DBNull.Value && dataRow["InsuredAddress2"] != null)
        empty2 = dataRow["InsuredAddress2"].ToString();
      if (dataRow["InsuredCity"] != DBNull.Value && dataRow["InsuredCity"] != null)
        empty3 = dataRow["InsuredCity"].ToString();
      if (dataRow["InsuredZipCode"] != DBNull.Value && dataRow["InsuredZipCode"] != null)
        empty5 = dataRow["InsuredZipCode"].ToString();
      if (dataRow["InsuredState"] != DBNull.Value && dataRow["InsuredState"] != null)
        empty4 = dataRow["InsuredState"].ToString();
      if (dataRow["InsuredDBA"] != DBNull.Value && dataRow["InsuredDBA"] != null)
      {
        st = dataRow["InsuredDBA"].ToString();
        if (st.Length > 100)
          st = st.Substring(0, 99);
      }
    }
    RRIRequest.RequestRow requestRow = dr;
    requestRow.Line_of_Business = this._quote.LineName;
    requestRow.Policy_Number = this.GetPolicyNumber();
    requestRow.Request_Date = Strings.Format((object) DateAndTime.Now, "yyyy-MM-dd");
    requestRow.Requestor_Name = $"{CurrentUser.Instance.FirstName} {CurrentUser.Instance.LastName}";
    requestRow.Insured_Name1 = InspectionRequest.EscapeXMLChars(InspectionsHelperUtility.GetShortenedInsuredName(this._quote.InsuredPolicyName));
    requestRow.Insured_Name2 = InspectionRequest.EscapeXMLChars(st);
    requestRow.Insured_Address_1 = InspectionRequest.EscapeXMLChars(empty1);
    requestRow.Insured_Address_2 = InspectionRequest.EscapeXMLChars(empty2);
    requestRow.Insured_City = InspectionRequest.EscapeXMLChars(empty3);
    requestRow.Insured_State = empty4;
    requestRow.Insured_Zipcode = empty5;
    requestRow.Agent_Name = InspectionRequest.EscapeXMLChars(this._quote.ProducerName);
    requestRow.Carrier_Name = InspectionRequest.EscapeXMLChars(this._quote.Company);
    requestRow.Requested_For = InspectionRequest.EscapeXMLChars($"{this._quote.Underwriter.FirstName} {this._quote.Underwriter.LastName}");
    requestRow.Requested_For_Phone = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Phone FROM tblClientOffices WITH (NOLOCK) WHERE OfficeGuid=@OfficeGuid", new object[2]
    {
      (object) "@OfficeGuid",
      (object) this._quote.IssuingLocationGuid
    });
    requestRow.Agent_Contact = InspectionRequest.EscapeXMLChars($"{this._quote.ProducerContactFirst} {this._quote.ProducerContactLast}");
    this.GetInspectionContactsAndPhone(dr);
    this.SetAgentContactPhone(dr);
  }

  private void GetInspectionContactsAndPhone(RRIRequest.RequestRow drRequest)
  {
    drRequest.Insured_Contact_Name = "Missing Inspection Insured Contact";
    drRequest.Insured_Contact_Phone = "Missing Inspection Insured Contact Phone #";
    dsInspectionContacts inspectionContacts = new dsInspectionContacts();
    string[] strArray = new string[1]{ "dt" };
    DefaultDatabase.LoadDataSet((DataSet) inspectionContacts, strArray, "GetInspectionContacts", new object[4]
    {
      (object) "@InsuredLocationGUID",
      (object) this._quote.SubmissionGroup.InsuredLocationGuid,
      (object) "@underwritingLocationID",
      (object) int.MinValue
    });
    if (inspectionContacts.dt.Count <= 0)
      return;
    if (!inspectionContacts.dt[0].IsFullNameNull())
      drRequest.Insured_Contact_Name = InspectionRequest.EscapeXMLChars(inspectionContacts.dt[0].FullName);
    if (inspectionContacts.dt[0].IsPhoneNull())
      return;
    drRequest.Insured_Contact_Phone = inspectionContacts.dt[0].Phone;
  }

  private void SetAgentContactPhone(RRIRequest.RequestRow dr)
  {
    try
    {
      dr.Agent_Contact_Phone = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Phone FROM tblProducerLocations WITH (NOLOCK) WHERE ProducerLocationGuid=@ProducerLocationGuid", new object[2]
      {
        (object) "@ProducerLocationGuid",
        (object) this._quote.ProducerLocation.ProducerLocationGuid
      });
    }
    catch (InvalidCastException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      dr.Agent_Contact_Phone = "No Agent Phone #";
      ProjectData.ClearProjectError();
    }
  }

  private void GetNetRateSubmissionLocations()
  {
    Guid userGuid = CurrentUser.Instance.UserGUID;
    Guid quoteGuid = this._quote.QuoteGuid;
    string str1 = "SELECT LocationID,InspectionContact, InspectionContactPhone, Comments, Rush, Location, ClassCode FROM tblSubmissionInspRequests WITH (NOLOCK) WHERE UserGuid=@UG AND InspectionType=@IT AND QuoteGuid=@QG ";
    string str2 = "SELECT Address,[P.O.Box] AS Address2, City, State, ZipCode FROM NetRate_Quote_Insur_Quote_Locat WITH (NOLOCK) WHERE LocationID=@LID";
    try
    {
      foreach (DataRow row1 in DefaultDatabase.ExecuteDataTable(CommandType.Text, str1, new object[6]
      {
        (object) "@UG",
        (object) userGuid,
        (object) "@IT",
        (object) "N",
        (object) "@QG",
        (object) quoteGuid
      }).Rows)
      {
        RRIRequest.LocationRow row2 = this._ds.Location.NewLocationRow();
        RRIRequest.LocationRow locationRow = row2;
        locationRow.Location_Id = Convert.ToInt32(RuntimeHelpers.GetObjectValue(row1["LocationID"]));
        DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, str2, new object[2]
        {
          (object) "@LID",
          row1["LocationID"]
        });
        if (dataRow != null)
        {
          if (dataRow["Address"] != DBNull.Value)
            locationRow.Location_Address1 = InspectionRequest.EscapeXMLChars(dataRow["Address"].ToString());
          if (dataRow["Address2"] != DBNull.Value)
            locationRow.Location_Address2 = InspectionRequest.EscapeXMLChars(dataRow["Address2"].ToString());
          if (dataRow["City"] != DBNull.Value)
            locationRow.Location_City = InspectionRequest.EscapeXMLChars(dataRow["City"].ToString());
          locationRow.Location_State = dataRow["State"].ToString();
          if (dataRow["ZipCode"] != DBNull.Value)
            locationRow.Location_Zipcode = dataRow["ZipCode"].ToString();
        }
        if (row1["InspectionContact"] != DBNull.Value)
          locationRow.Location_Contact_Name = InspectionRequest.EscapeXMLChars(row1["InspectionContact"].ToString());
        if (row1["InspectionContactPhone"] != DBNull.Value)
          locationRow.Location_Contact_Phone = row1["InspectionContactPhone"].ToString();
        if (row1["Comments"] != DBNull.Value)
          locationRow.Special_Instructions = InspectionRequest.EscapeXMLChars(row1["Comments"].ToString());
        if (row1["Rush"] != DBNull.Value)
          locationRow.Rush = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(row1["Rush"]));
        locationRow.Due_Date = Strings.Format((object) InspectionsHelperUtility.GetInspectionLocationDueDate(Convert.ToInt32(RuntimeHelpers.GetObjectValue(row1["LocationID"])), this._quote.QuoteGuid), "yyyy-MM-dd");
        locationRow.Customer_Reference_ID = InspectionsHelperUtility.GetCustomerReferenceIdentifier(Convert.ToInt32(RuntimeHelpers.GetObjectValue(row1["LocationID"])), this._quote.QuoteGuid);
        locationRow.Location_Description = row1["Location"] == DBNull.Value ? "TBD" : row1["Location"].ToString();
        this._ds.Location.AddLocationRow(row2);
        locationRow.RequestRow = this._ds.Request[0];
        if (row1["ClassCode"] != DBNull.Value && row1["ClassCode"].ToString().Length > 0)
        {
          RRIRequest.SIC_CodesRow row3 = this._ds.SIC_Codes.NewSIC_CodesRow();
          row3.SIC_Code = row1["ClassCode"].ToString();
          this._ds.SIC_Codes.AddSIC_CodesRow(row3);
          row3.LocationRow = row2;
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

  private void RefreshMessage(string txt)
  {
    if (this._fsr == null)
      return;
    this._fsr.RefreshPanel(txt);
  }

  public virtual bool SendRctRequests()
  {
    string setting1 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTUserName", string.Empty);
    string setting2 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTPassword", string.Empty);
    string setting3 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTUrl", string.Empty);
    string defaultNamespace = "http://www.w3.org/2001/XMLSchema";
    bool flag;
    if (setting1.Replace(" ", string.Empty).Length == 0 || setting2.Replace(" ", string.Empty).Length == 0 || setting3.Replace(" ", string.Empty).Length == 0)
    {
      int num = (int) MessageBox.Show("Risk Control Technologies is missing setting and/or credentials.", "Missing Credentials/Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
    {
      this.RefreshMessage("Gathering xml to send to inspection company ...");
      RCTImport o = new RCTImport();
      List<MGASystems.IMS.Policies.Inspections.RCT.Inspection> inspectionList = new List<MGASystems.IMS.Policies.Inspections.RCT.Inspection>();
      List<MGASystems.IMS.Policies.Inspections.RCT.Client> clientList = new List<MGASystems.IMS.Policies.Inspections.RCT.Client>();
      if (!this.SubmissionRequest)
        this.QuoteList.Add(this._quote.ControlNo);
      List<int> intList = new List<int>();
      try
      {
        foreach (int quote in this.QuoteList)
        {
          if (!intList.Contains(quote))
          {
            intList.Add(quote);
            this.RefreshMessage("Sending request to inspection company ...");
            this._quote = (Quote) null;
            this._quote = new Quote(DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1 QuoteGuid FROM tblQuotes WITH (NOLOCK) WHERE ControlNo=@CN ORDER BY QuoteID DESC", new object[2]
            {
              (object) "@CN",
              (object) quote
            }));
            if (this.SubmissionRequest)
            {
              object obj = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 InspectionType FROM tblSubmissionInspRequests WITH (NOLOCK) WHERE UserGuid=@UG AND QuoteGuid=@QG", new object[4]
              {
                (object) "@UG",
                (object) CurrentUser.Instance.UserGUID,
                (object) "@QG",
                (object) this._quote.QuoteGuid
              }));
              if (obj == null || obj == DBNull.Value)
                obj = (object) "B";
              this._ds = new RRIRequest();
              RRIRequest.RequestRow requestRow = this._ds.Request.NewRequestRow();
              this.RefreshMessage($"Filling policy and location info for {this._quote.ControlNo.ToString()} ...");
              this.FillCommonPolicyInformation(requestRow, this._quote.SubmissionGroup.InsuredLocation, obj.ToString());
              requestRow.Client_Code = InspectionsHelperUtility.GetClientCode(this._submissionRequestInspectionCompanyID, -1, this._quote.QuoteID);
              this._ds.Request.AddRequestRow(requestRow);
              Guid empty = Guid.Empty;
              Guid companyLineGuid;
              if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("RCTRequestCompanyLineSelection"))
                companyLineGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1 CompanyLineGuid FROM tblQuoteDetails WITH (NOLOCK) WHERE QuoteGuid=@QG", new object[2]
                {
                  (object) "@QG",
                  (object) this._quote.QuoteGuid
                });
              else
                companyLineGuid = InspectionRequest.RequestCompanyLineGuid(this._quote);
              if (!new QuoteDetail(this._quote.QuoteGuid, companyLineGuid).UsingNetRate)
              {
                this.GetBaseSubmissionLocations();
                if (this._ds.Location.Count == 0)
                  continue;
              }
              else
              {
                this.GetNetRateSubmissionLocations();
                if (this._ds.Location.Count == 0)
                  continue;
              }
            }
            this.RefreshMessage($"Creating inspection for Control # {this._quote.ControlNo.ToString()} ...");
            MGASystems.IMS.Policies.Inspections.RCT.Inspection inspection = new MGASystems.IMS.Policies.Inspections.RCT.Inspection();
            inspection.InspectionUniqueID = DateTime.Now.ToString().Replace(":", string.Empty).Replace("/", string.Empty).Replace(" ", string.Empty);
            this._inspectionUniqueID = inspection.InspectionUniqueID;
            inspection.PolicyNo = this.GetPolicyNumber();
            DateTime.Now.ToShortDateString();
            inspection.DateAssigned = DateTime.SpecifyKind(DateTime.Today, DateTimeKind.Utc);
            inspection.DateAssignedSpecified = true;
            inspection.DateRequired = DateTime.SpecifyKind(DateTime.Today.AddDays(15.0), DateTimeKind.Utc);
            inspection.DateRequiredSpecified = true;
            inspection.InspectionStatus = "1";
            inspection.CreateInspection = InspectionCreateInspection.Yes;
            inspection.CreateInspectionSpecified = true;
            inspection.InspectionType = this.ClientInspectionType();
            inspection.Note = "Please follow up on request.";
            Inspector inspector = new Inspector();
            ReferenceInspector referenceInspector = new ReferenceInspector();
            string setting4 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTReferenceInspectorUniqueID", string.Empty);
            string empty1 = string.Empty;
            UnderWriter underWriter = new UnderWriter();
            UnderWriterInfo underWriterInfo = new UnderWriterInfo();
            if (!string.IsNullOrEmpty(this._quote.Underwriter.Phone))
              underWriterInfo.Phone = this._quote.Underwriter.Phone;
            if (!this._underwriterEmailConsolidate)
            {
              string setting5 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTReferenceUnderwriterUniqueID", string.Empty);
              if (!string.IsNullOrEmpty(setting5))
                underWriterInfo.UnderWriterUniqueID = setting5;
              if (this._quote.Underwriter.HasEmail)
              {
                underWriterInfo.Email = this._quote.Underwriter.Email;
                string email = this._quote.Underwriter.Email;
                if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("RCT.ShortenUnderwriterUniqueID"))
                {
                  string[] strArray = email.Split('@');
                  if (strArray.Length > 0)
                    underWriterInfo.UnderWriterUniqueID = strArray[0];
                }
              }
            }
            else if (this._quote.Underwriter.HasEmail)
            {
              underWriterInfo.Email = this._quote.Underwriter.Email;
              underWriterInfo.UnderWriterUniqueID = this._quote.Underwriter.Email;
            }
            string setting6 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTUnderwriterEmail", string.Empty);
            if (!string.IsNullOrEmpty(setting6))
              underWriterInfo.Email = setting6;
            if (string.IsNullOrEmpty(underWriterInfo.Email))
            {
              int num = (int) MessageBox.Show("Cannot continue because Underwriter email is empty.", $"Control # {this._quote.ControlNo.ToString()}.  Missing Underwriter Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              flag = false;
              goto label_122;
            }
            Name name1 = new Name();
            Name name2 = name1;
            string setting7 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTUnderwriterLastName", string.Empty);
            name2.LastName = string.IsNullOrEmpty(setting7) ? this._quote.Underwriter.LastName : setting7;
            string setting8 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTUnderwriterFirstName", string.Empty);
            name2.FirstName = string.IsNullOrEmpty(setting8) ? this._quote.Underwriter.FirstName : setting8;
            underWriterInfo.Name = name1;
            underWriterInfo.Note = "TBD";
            Company company = new Company();
            CompanyInfo companyInfo = new CompanyInfo();
            MGASystems.IMS.Policies.Inspections.RCT.Address address1 = new MGASystems.IMS.Policies.Inspections.RCT.Address();
            string setting9 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTUnderwriterInfoNodeCompanyUniqueID", string.Empty);
            if (!string.IsNullOrEmpty(setting9))
              companyInfo.CompanyUniqueID = setting9;
            string setting10 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTUnderwriterInfoNodeCompanyName", string.Empty);
            if (!string.IsNullOrEmpty(setting10))
              companyInfo.CompanyName = setting10;
            companyInfo.Type = CompanyInfoType.Insurance;
            string setting11 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTUnderwriterInfoNodeDivision", string.Empty);
            if (!string.IsNullOrEmpty(setting11))
              companyInfo.Division = setting11;
            MGASystems.IMS.Policies.Inspections.RCT.Address address2 = new MGASystems.IMS.Policies.Inspections.RCT.Address();
            string setting12 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTUnderwriterInfoNodeAddressLine", string.Empty);
            if (!string.IsNullOrEmpty(setting12))
            {
              string str = setting12;
              address2.AddressLine = str;
              address1.AddressLine = str;
            }
            string setting13 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTUnderwriterInfoNodeCity", string.Empty);
            if (!string.IsNullOrEmpty(setting13))
            {
              string str = setting13;
              address2.City = str;
              address1.City = str;
            }
            string setting14 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTUnderwriterInfoNodeState", string.Empty);
            if (!string.IsNullOrEmpty(setting14))
            {
              string str = setting14;
              address2.Item = RuntimeHelpers.GetObjectValue(Enum.Parse(typeof (USProvince), str));
              address1.Item = RuntimeHelpers.GetObjectValue(Enum.Parse(typeof (USProvince), str));
            }
            string setting15 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTUnderwriterInfoNodeZip", string.Empty);
            if (!string.IsNullOrEmpty(setting15))
            {
              string zip = setting15;
              address2.Item1 = this.MassageZipCode(zip);
              address2.Item1ElementName = Item1ChoiceType.USPostalCode;
              address1.Item1 = this.MassageZipCode(zip);
              address1.Item1ElementName = Item1ChoiceType.USPostalCode;
            }
            string setting16 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RCTUnderwriterInfoNodeCounty", string.Empty);
            if (!string.IsNullOrEmpty(setting16))
            {
              address2.County = setting16;
              address1.County = setting16;
            }
            address2.Country = AddressCountry.US;
            address1.Country = AddressCountry.US;
            underWriterInfo.Address = address1;
            companyInfo.Address = address2;
            company.Item = (object) companyInfo;
            underWriterInfo.Company = company;
            underWriter.Item = (object) underWriterInfo;
            inspection.UnderWriter = underWriter;
            inspection.Inspector = inspector;
            List<ExtField> extFieldList1 = new List<ExtField>();
            string str1 = this._quote.SIC_Code ?? string.Empty;
            if (str1.Replace(" ", "").Length > 0)
            {
              ExtField extField = new ExtField()
              {
                FieldName = "ssic",
                FieldValue = str1
              };
              extFieldList1.Add(extField);
            }
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.BaseInspectionMethod)))
            {
              ExtField extField = new ExtField()
              {
                FieldName = "SrvyLctn"
              };
              extField.FieldValue = (byte) this.BaseInspectionMethod != (byte) 2 ? "SurveyPhone" : "SurveyPhys";
              extFieldList1.Add(extField);
            }
            this.AddRctLineOfBusinessExtensionFields(extFieldList1);
            string str2 = string.Empty;
            try
            {
              foreach (RRIRequest.LocationRow row in this._ds.Location.Rows)
              {
                if (!row.IsSpecial_InstructionsNull() && row.Special_Instructions.Replace(" ", "").Length > 0)
                  str2 = str2.Replace(" ", "").Length <= 0 ? row.Special_Instructions : $"{str2}\n{row.Special_Instructions}";
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
            if (str2.Replace(" ", "").Length > 0)
            {
              ExtField extField = new ExtField()
              {
                FieldName = "specialinstructions",
                FieldValue = str2
              };
              extFieldList1.Add(extField);
            }
            this.AddInspectionContactExtFields(extFieldList1);
            ExtField extField1 = new ExtField()
            {
              FieldName = "spolef",
              FieldValue = this._quote.EffectiveDate.ToString("yyyyMMdd")
            };
            extFieldList1.Add(extField1);
            ExtField extField2 = new ExtField()
            {
              FieldName = "spolend",
              FieldValue = this._quote.ExpirationDate.ToString("yyyyMMdd")
            };
            extFieldList1.Add(extField2);
            if (this._quote.IsEndorsement)
            {
              ExtField extField3 = new ExtField()
              {
                FieldName = "scanc",
                FieldValue = this._quote.EndorsementEffective.ToString("yyyyMMdd")
              };
              extFieldList1.Add(extField3);
            }
            ExtField extField4 = new ExtField()
            {
              FieldName = "sbroker",
              FieldValue = this._quote.ProducerName
            };
            extFieldList1.Add(extField4);
            string str3 = $"{this._quote.ProducerContactFirst} {this._quote.ProducerContactLast}";
            if (str3.Replace(" ", "").Length > 0)
            {
              ExtField extField5 = new ExtField()
              {
                FieldName = "sbrokercontact",
                FieldValue = str3
              };
              extFieldList1.Add(extField5);
            }
            string empty2 = string.Empty;
            if (this._quote.ProducerContactPhone != null)
            {
              string producerContactPhone = this._quote.ProducerContactPhone;
              if (producerContactPhone.Replace(" ", "").Length > 0)
              {
                ExtField extField6 = new ExtField()
                {
                  FieldName = "sbrokerphone",
                  FieldValue = producerContactPhone
                };
                extFieldList1.Add(extField6);
              }
            }
            string str4 = "noBrokerEmail@test.com";
            if (this._quote.ProducerContactEmail != null)
            {
              str4 = this._quote.ProducerContactEmail;
              if (str4.Replace(" ", "").Length == 0)
                str4 = "noBrokerEmail@test.com";
            }
            ExtField extField7 = new ExtField()
            {
              FieldName = "sbrokeremail",
              FieldValue = str4
            };
            extFieldList1.Add(extField7);
            ExtField extField8 = new ExtField()
            {
              FieldName = "sprodof",
              FieldValue = this._quote.ProducerLocation.LocationName
            };
            extFieldList1.Add(extField8);
            ExtField extField9 = new ExtField()
            {
              FieldName = "name2",
              FieldValue = this._ds.Location[0].Location_Contact_Name
            };
            extFieldList1.Add(extField9);
            ExtField extField10 = new ExtField()
            {
              FieldName = "phone2",
              FieldValue = this._ds.Location[0].Location_Contact_Phone
            };
            extFieldList1.Add(extField10);
            this.AddRctInspectionExtensionFields(extFieldList1);
            inspection.ExtFields = extFieldList1.ToArray();
            ClientInfo clientInfo = new ClientInfo();
            clientInfo.ClientUniqueID = this.ClientUniqueIdentifier();
            this._clientUniqueID = clientInfo.ClientUniqueID;
            clientInfo.Company = new Company()
            {
              Item = (object) new ReferenceCompany()
              {
                CompanyUniqueID = this._quote.ProducerLocationGuid.ToString()
              }
            };
            referenceInspector.InspectorUniqueID = setting4;
            inspector.Item = (object) referenceInspector;
            clientInfo.Inspector = inspector;
            DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT TOP 1 Phone, Fax FROM tblInsuredLocations WHERE InsuredGUID = @ISG AND Phone IS NOT NULL", new object[2]
            {
              (object) "@ISG",
              (object) this._quote.SubmissionGroup.InsuredGuid
            });
            if (dataRow != null)
            {
              if (dataRow["Fax"] != DBNull.Value)
                clientInfo.Fax = dataRow["Fax"].ToString();
              if (dataRow["Fax"] != DBNull.Value)
                clientInfo.Phone = dataRow["Phone"].ToString();
            }
            Name name3 = new Name()
            {
              FirstName = InspectionsHelperUtility.GetShortenedInsuredName(this._quote.InsuredPolicyName)
            };
            clientInfo.Name = name3;
            MGASystems.IMS.Policies.Inspections.RCT.Address address3 = new MGASystems.IMS.Policies.Inspections.RCT.Address()
            {
              AddressLine = this._quote.InsuredAddress1,
              City = this._quote.InsuredCity,
              Item1 = this.MassageZipCode(this._quote.InsuredZipCode),
              Item1ElementName = Item1ChoiceType.USPostalCode,
              Item = RuntimeHelpers.GetObjectValue(Enum.Parse(typeof (USProvince), this._quote.InsuredState)),
              Country = AddressCountry.US,
              County = this._quote.InsuredCounty
            };
            clientInfo.Address = address3;
            MGASystems.IMS.Policies.Inspections.RCT.Client client = new MGASystems.IMS.Policies.Inspections.RCT.Client();
            client.Item = (object) clientInfo;
            clientList.Add(client);
            inspection.Client = client;
            Locations locations = new Locations();
            RRIRequest.LocationRow locationRow1 = this._ds.Location[0];
            LocationsPrimaryLocation locationsPrimaryLocation = new LocationsPrimaryLocation();
            locationsPrimaryLocation.LocationDescription = locationRow1.Location_Description;
            locationsPrimaryLocation.LocationUniqueID = locationRow1.Location_Id.ToString();
            MGASystems.IMS.Policies.Inspections.RCT.Address address4 = new MGASystems.IMS.Policies.Inspections.RCT.Address()
            {
              AddressLine = locationRow1.Location_Address1,
              City = locationRow1.Location_City,
              Item1 = this.MassageZipCode(locationRow1.Location_Zipcode),
              Item1ElementName = Item1ChoiceType.USPostalCode,
              Item = RuntimeHelpers.GetObjectValue(Enum.Parse(typeof (USProvince), locationRow1.Location_State)),
              Country = AddressCountry.US,
              County = string.Empty
            };
            locationsPrimaryLocation.Address = address4;
            locations.PrimaryLocation = locationsPrimaryLocation;
            MGASystems.IMS.Policies.Inspections.RCT.Address address5 = new MGASystems.IMS.Policies.Inspections.RCT.Address()
            {
              AddressLine = locationRow1.Location_Address1,
              City = locationRow1.Location_City,
              Item1 = this.MassageZipCode(locationRow1.Location_Zipcode),
              Item1ElementName = Item1ChoiceType.USPostalCode,
              Item = RuntimeHelpers.GetObjectValue(Enum.Parse(typeof (USProvince), locationRow1.Location_State)),
              Country = AddressCountry.US,
              County = string.Empty
            };
            inspection.Address = address5;
            List<LocationsLocation> locationsLocationList = new List<LocationsLocation>();
            for (int index = 1; index < this._ds.Location.Rows.Count; ++index)
            {
              RRIRequest.LocationRow locationRow2 = this._ds.Location[index];
              LocationsLocation locationsLocation = new LocationsLocation()
              {
                LocationType = "Secondary",
                LocationDescription = locationRow2.Location_Description,
                LocationUniqueID = locationRow2.Location_Id.ToString()
              };
              locationsLocation.LocationDescription = locationRow2.Location_Description;
              MGASystems.IMS.Policies.Inspections.RCT.Address address6 = new MGASystems.IMS.Policies.Inspections.RCT.Address()
              {
                AddressLine = locationRow2.Location_Address1,
                City = locationRow2.Location_City,
                Item1 = this.MassageZipCode(locationRow2.Location_Zipcode),
                Item1ElementName = Item1ChoiceType.USPostalCode,
                Item = RuntimeHelpers.GetObjectValue(Enum.Parse(typeof (USProvince), locationRow2.Location_State)),
                Country = AddressCountry.US,
                County = string.Empty
              };
              locationsLocation.Address = address6;
              locationsLocationList.Add(locationsLocation);
            }
            locations.Location = locationsLocationList.ToArray();
            clientInfo.Locations = locations;
            List<ExtField> extFieldList2 = new List<ExtField>();
            try
            {
              extFieldList2.Add(new ExtField()
              {
                FieldName = "DBA",
                FieldValue = InspectionsHelperUtility.GetShortenedInsuredName(this._quote.InsuredPolicyName)
              });
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ErrorHandler.SilentHandleError(ex);
              ProjectData.ClearProjectError();
            }
            ExtField extField11 = new ExtField()
            {
              FieldName = "poleffective",
              FieldValue = this._quote.EffectiveDate.ToString("yyyyMMdd")
            };
            extFieldList2.Add(extField11);
            extFieldList2.Add(new ExtField()
            {
              FieldName = "Polexpdate",
              FieldValue = this._quote.ExpirationDate.ToString("yyyyMMdd")
            });
            extFieldList2.Add(new ExtField()
            {
              FieldName = "broker",
              FieldValue = this._quote.ProducerName
            });
            string str5 = $"{this._quote.ProducerContactFirst} {this._quote.ProducerContactLast}";
            if (str5.Replace(" ", string.Empty).Length > 0)
            {
              ExtField extField12 = new ExtField()
              {
                FieldName = "brokercontact",
                FieldValue = str5
              };
              extFieldList2.Add(extField12);
            }
            string producerContactPhone1 = this._quote.ProducerContactPhone;
            if (producerContactPhone1.Replace(" ", string.Empty).Length > 0)
            {
              ExtField extField13 = new ExtField()
              {
                FieldName = "brokerphone",
                FieldValue = producerContactPhone1
              };
              extFieldList2.Add(extField13);
            }
            extFieldList2.Add(new ExtField()
            {
              FieldName = "division",
              FieldValue = this.SubmissionRequest ? this.SubmissionRequestDivision : this.RctDivision()
            });
            extFieldList2.Add(new ExtField()
            {
              FieldName = "programcode",
              FieldValue = this.SubmissionRequest ? this.SubmissionRequestProgramCode : this.GetProgramCode()
            });
            clientInfo.ExtFields = extFieldList2.ToArray();
            inspectionList.Add(inspection);
            break;
          }
        }
      }
      finally
      {
        List<int>.Enumerator enumerator;
        enumerator.Dispose();
      }
      o.Inspections = inspectionList.ToArray();
      if (o.Inspections.Length == 0)
      {
        int num = (int) MessageBox.Show("No location records requested for inspection", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
      }
      else
      {
        string empty3 = string.Empty;
        string str6;
        try
        {
          XmlSerializer xmlSerializer = new XmlSerializer(o.GetType(), defaultNamespace);
          MemoryStream w = new MemoryStream();
          using (XmlTextWriter xmlTextWriter = new XmlTextWriter((Stream) w, Encoding.UTF8))
          {
            xmlTextWriter.Namespaces = true;
            xmlSerializer.Serialize((XmlWriter) xmlTextWriter, (object) o, InspectionRequest.GetNamespaces());
          }
          w.Close();
          string str7 = Encoding.UTF8.GetString(w.GetBuffer());
          string str8 = str7.Substring(str7.IndexOf(Convert.ToChar(60)));
          str6 = str8.Substring(0, str8.LastIndexOf(Convert.ToChar(62)) + 1);
          string empty4 = string.Empty;
          string empty5 = string.Empty;
          string str9 = this.SubmissionRequest ? $"Insured # {InspectionsHelperUtility.GetShortenedInsuredName(this._quote.InsuredPolicyName)}.xml" : $"ControlNo{this._quote.ControlNo.ToString()}.xml";
          char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
          int index = 0;
          while (index < invalidFileNameChars.Length)
          {
            char ch = invalidFileNameChars[index];
            str9 = str9.Replace(Conversions.ToString(ch), string.Empty);
            checked { ++index; }
          }
          string str10 = MGATempFolder.MGATempPath + str9;
          if (File.Exists(str10))
            File.Delete(str10);
          XmlDocument xmlDocument = new XmlDocument();
          xmlDocument.LoadXml(str6);
          xmlDocument.Save(str10);
          List<string> stringList1 = new List<string>();
          stringList1.Add(str10);
          if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("RctInspectionsUploadDocuments"))
          {
            Thread.Sleep(1000);
            List<string> stringList2 = new List<string>();
            using (FormRctDocuments formRctDocuments = (FormRctDocuments) FormSettings.ShowFormDialog(typeof (FormRctDocuments), (object) this._quote, (object) setting1, (object) setting2, (object) setting3, (object) this))
              stringList2 = formRctDocuments.FilesAttached;
            try
            {
              foreach (string str11 in stringList2)
                stringList1.Add(str11);
            }
            finally
            {
              List<string>.Enumerator enumerator;
              enumerator.Dispose();
            }
          }
          try
          {
            foreach (string fileName in stringList1)
              this.SendRctFileOnClient(fileName, setting3, setting1, setting2);
          }
          finally
          {
            List<string>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          string str12 = "\n\n" + ex.Message;
          int num = (int) MessageBox.Show($"{setting3} failed with the following message ... {str12}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          throw;
        }
        if (!this.SubmissionRequest)
        {
          this.LogStandAloneRequest(str6);
          this.SaveStandAloneInspectionsInfo();
        }
        else
        {
          this.LogSubmissionRequests(str6);
          this.SaveSubmissionInspectionsInfo();
        }
        int num1 = (int) MessageBox.Show("Requests sent successfully to inspection company", "Request(s) Sent Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = true;
      }
    }
label_122:
    return flag;
  }

  private void GetCompanyNode(MGASystems.IMS.Policies.Inspections.RCT.Inspection tmpInspection)
  {
    CompanyInfo companyInfo = new CompanyInfo()
    {
      CompanyUniqueID = this._quote.ProducerLocationGuid.ToString(),
      CompanyName = this._quote.ProducerName,
      Type = CompanyInfoType.Agent
    };
    string producerContactPhone = this._quote.ProducerContactPhone;
    if (!string.IsNullOrEmpty(producerContactPhone))
      companyInfo.Phone = producerContactPhone;
    companyInfo.Division = this.RctDivision();
    MGASystems.IMS.Policies.Inspections.RCT.Address address = new MGASystems.IMS.Policies.Inspections.RCT.Address()
    {
      AddressLine = this._quote.ProducerLocation.Address1,
      City = this._quote.ProducerLocation.City,
      Item1 = this._quote.ProducerLocation.Zip,
      Item1ElementName = Item1ChoiceType.USPostalCode,
      Item = RuntimeHelpers.GetObjectValue(Enum.Parse(typeof (USProvince), this._quote.ProducerLocation.State)),
      Country = AddressCountry.US
    };
    companyInfo.Address = address;
    new Company().Item = (object) companyInfo;
  }

  protected virtual string GetProgramCode() => "AGG";

  protected virtual string ClientInspectionType()
  {
    return this._quote.PolicyType != PolicyTypes.NewBusiness ? (this._quote.PolicyType != PolicyTypes.Renewal ? "other" : "renewal") : "newbusiness";
  }

  protected virtual string ClientUniqueIdentifier()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT InsuredID FROM tblInsureds WITH (NOLOCK) WHERE InsuredGUID=@IG", new object[2]
    {
      (object) "@IG",
      (object) this._quote.SubmissionGroup.InsuredGuid
    }));
    return objectValue == null || objectValue == DBNull.Value ? "!No Identifier Found!" : objectValue.ToString();
  }

  private void LogStandAloneRequest(string xmlString)
  {
    Guid userGuid = CurrentUser.Instance.UserGUID;
    if (this._quote.UsingNetRate)
    {
      try
      {
        foreach (RRIRequest.LocationRow row in this._ds.Location.Rows)
        {
          string str = $"{row["Location_Address1"].ToString()}, {row["Location_City"].ToString()}, {row["Location_State"].ToString()}";
          CurrentUser.Instance.LogAction("Inspection requested for location: " + str, this._quote.ControlGuid);
          CurrentUser.Instance.LogAction("Inspection requested for location: " + str, this._quote.QuoteGuid);
          InspectionsLogging.LogInspectionRequest(this._quote.QuoteGuid, this.StandAloneInspectionCompanyID, Conversions.ToInteger(row["Location_Id"]), true, userGuid, Guid.Empty, false, xmlString);
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
      string empty1 = string.Empty;
      string empty2 = string.Empty;
      try
      {
        foreach (RRIRequest.LocationRow row in this._ds.Location.Rows)
        {
          DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT LocationNo, BuildingNo, LocationGuid, QuoteGuid, InspectionCompanyID FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID=@LID", new object[2]
          {
            (object) "@LID",
            (object) row.Location_Id
          });
          if (dataRow != null)
          {
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblUnderwritingLocations SET InspectionRequested=@InspectionRequested WHERE LocationID=@LocationID", new object[4]
            {
              (object) "@InspectionRequested",
              (object) DateTime.Now,
              (object) "@LocationID",
              (object) row.Location_Id
            });
            if (dataRow[0] != null && dataRow[0] != DBNull.Value)
              empty1 = dataRow[0].ToString();
            if (dataRow[1] != null && dataRow[1] != DBNull.Value)
              empty2 = dataRow[1].ToString();
            Guid locationGuid = (Guid) dataRow["LocationGuid"];
            string str = "Inspection requested for location #";
            string inspectionCompany = InspectionRequest.GetInspectionCompany(Conversions.ToInteger(dataRow["InspectionCompanyID"]));
            CurrentUser.Instance.LogAction($"{str}{empty1}, building #{empty2} via {inspectionCompany}", this._quote.ControlGuid);
            CurrentUser.Instance.LogAction($"{str}{empty1}, building #{empty2} via {inspectionCompany}", this._quote.QuoteGuid);
            InspectionsLogging.LogInspectionRequest((Guid) dataRow["QuoteGuid"], Conversions.ToInteger(dataRow["InspectionCompanyID"]), row.Location_Id, false, userGuid, locationGuid, false, xmlString);
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

  private void LogSubmissionRequests(string xmlString)
  {
    Guid userGuid = CurrentUser.Instance.UserGUID;
    string str = "SELECT LocationID, QuoteGuid, Location, InspectionType FROM tblSubmissionInspRequests WITH (NOLOCK) WHERE UserGuid=@UG AND SubmissionGroupGuid=@SG ";
    try
    {
      foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, str, new object[4]
      {
        (object) "@UG",
        (object) userGuid,
        (object) "@SG",
        (object) this._quote.SubmissionGroupGuid
      }).Rows)
      {
        Quote quote = new Quote((Guid) row["QuoteGuid"]);
        if (row["InspectionType"] != DBNull.Value)
        {
          CurrentUser.Instance.LogAction("Inspection via submission requested for location: " + row["Location"].ToString(), quote.ControlGuid);
          CurrentUser.Instance.LogAction("Inspection via submission requested for location: " + row["Location"].ToString(), quote.QuoteGuid);
          if (row["InspectionType"].ToString().Equals("N"))
          {
            InspectionsLogging.LogInspectionRequest((Guid) row["QuoteGuid"], this.SubmissionRequestInspectionCompanyID, Conversions.ToInteger(row["LocationID"]), true, userGuid, Guid.Empty, false, xmlString);
          }
          else
          {
            UnderwritingLocation underwritingLocation = new UnderwritingLocation(Conversions.ToInteger(row["LocationID"]));
            InspectionsLogging.LogInspectionRequest((Guid) row["QuoteGuid"], this.SubmissionRequestInspectionCompanyID, Conversions.ToInteger(row["LocationID"]), false, userGuid, underwritingLocation.LocationGuid, false, xmlString);
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
  }

  private void SaveStandAloneInspectionsInfo()
  {
    Guid quoteGuid = this._quote.QuoteGuid;
    object controlNo = (object) this._quote.ControlNo;
    object obj1 = (object) null;
    object insuredPolicyName = (object) this._quote.InsuredPolicyName;
    object effectiveDate = (object) this._quote.EffectiveDate;
    object serverTime = (object) CurrentUser.ServerTime;
    object obj2 = (object) $"{this._quote.Underwriter.LastName}, {this._quote.Underwriter.FirstName}";
    Guid userGuid = CurrentUser.Instance.UserGUID;
    if (this._quote.HasPolicyNumber)
      obj1 = (object) this._quote.PolicyNumber;
    int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT InsuredID FROM tblInsureds WITH (NOLOCK) WHERE InsuredGUID = @IG", new object[2]
    {
      (object) "@IG",
      (object) this._quote.SubmissionGroup.InsuredGuid
    });
    if (!this._quote.UsingNetRate)
    {
      string str1 = "SELECT LocationNo, BuildingNo, Address1, Address2, City, State, Zip, PhysicalBuildingNo, InspectionContact, RoofInspectionContact, InspectionContactPhone, RoofInspectionContactPhone, InspectionCompanyID  FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID=@LID";
      try
      {
        foreach (RRIRequest.LocationRow row in this._ds.Location.Rows)
        {
          DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, str1, new object[2]
          {
            (object) "@LID",
            (object) row.Location_Id
          });
          if (dataRow != null)
          {
            object obj3 = (object) null;
            object obj4 = (object) null;
            object obj5 = (object) null;
            object obj6 = (object) null;
            object obj7 = (object) null;
            object obj8 = (object) null;
            object obj9 = (object) null;
            object obj10 = (object) string.Empty;
            string str2 = string.Empty;
            object obj11 = (object) null;
            if (!dataRow.IsNull("InspectionContact"))
              obj9 = RuntimeHelpers.GetObjectValue(dataRow["InspectionContact"]);
            if (!dataRow.IsNull("InspectionContactPhone"))
              obj11 = RuntimeHelpers.GetObjectValue(dataRow["InspectionContactPhone"]);
            if (!dataRow.IsNull("PhysicalBuildingNo"))
              str2 = dataRow["PhysicalBuildingNo"].ToString() + " ";
            if (!dataRow.IsNull("LocationNo"))
              obj8 = (object) ("Loc #" + dataRow["LocationNo"].ToString().ToString());
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow[1])))
            {
              object obj12 = (object) dataRow[1].ToString();
              obj8 = obj8 == null ? (object) ("Loc #, Bldg #" + obj12.ToString()) : (object) $"{obj8.ToString()}, Bldg #{obj12.ToString()}";
            }
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow[2])))
            {
              obj3 = (object) (str2 + dataRow[2].ToString());
              obj10 = (object) $"{str2}{obj10.ToString()}{dataRow[2].ToString()}\n";
            }
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow[3])))
              obj4 = (object) dataRow[3].ToString();
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow[4])))
            {
              obj5 = (object) dataRow[4].ToString();
              obj10 = (object) (obj10.ToString() + dataRow[4].ToString());
            }
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow[5])))
            {
              obj6 = (object) dataRow[5].ToString();
              obj10 = (object) $"{obj10.ToString()}, {dataRow[5].ToString()}";
            }
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow[6])))
            {
              obj7 = (object) dataRow[6].ToString();
              obj10 = (object) $"{obj10.ToString()} {dataRow[6].ToString()}";
            }
            DefaultDatabase.ExecuteNonQuery("InsertAdminInspectionRow", new object[58]
            {
              (object) "@ControlNo",
              controlNo,
              (object) "@PolicyNumber",
              obj1,
              (object) "@Insured",
              insuredPolicyName,
              (object) "@LocationID",
              (object) row.Location_Id,
              (object) "@LocationAddress",
              obj10,
              (object) "@InspectionCompanyID",
              (object) this.StandAloneInspectionCompanyID,
              (object) "@EffectiveDate",
              effectiveDate,
              (object) "@OrderDate",
              serverTime,
              (object) "@DropDeadDate",
              null,
              (object) "@FollowupDate",
              null,
              (object) "@ReceivedDate",
              null,
              (object) "@Received",
              null,
              (object) "@RevisedContactInfo",
              null,
              (object) "@UWNotified",
              null,
              (object) "@AwaitingStatusFeedBack",
              null,
              (object) "@Cancelled",
              null,
              (object) "@NonProductive",
              null,
              (object) "@Address1",
              obj3,
              (object) "@Address2",
              obj4,
              (object) "@City",
              obj5,
              (object) "@State",
              obj6,
              (object) "@Zip",
              obj7,
              (object) "@LocationNumber",
              obj8,
              (object) "@InspectionContact",
              obj9,
              (object) "@InspectionContactPhone",
              obj11,
              (object) "@Underwriter",
              obj2,
              (object) "@OrderBy",
              (object) userGuid,
              (object) "@InsuredID",
              (object) num,
              (object) "@Roof",
              (object) false
            });
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
    else
    {
      try
      {
        foreach (RRIRequest.LocationRow row in this._ds.Location.Rows)
        {
          object obj13 = (object) null;
          object obj14 = (object) null;
          object obj15 = (object) null;
          object obj16 = (object) null;
          object obj17 = (object) null;
          object obj18 = (object) null;
          object obj19 = (object) null;
          object obj20 = (object) null;
          object empty = (object) string.Empty;
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row["Location_Address1"])))
          {
            obj13 = (object) row["Location_Address1"].ToString();
            empty = (object) obj13.ToString();
          }
          object obj21 = (object) $"{empty.ToString()}{row["Location_City"].ToString()}, {row["Location_State"].ToString()}";
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row["Location_Address2"])))
            obj14 = (object) row["Location_Address2"].ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row["Location_City"])))
          {
            obj16 = (object) row["Location_City"].ToString();
            obj21 = (object) (obj21.ToString() + obj16.ToString());
          }
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row["Location_State"])))
          {
            obj17 = (object) row["Location_State"].ToString();
            obj21 = (object) $"{obj21.ToString()}, {obj17.ToString()}";
          }
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row["Location_Zipcode"])))
          {
            obj15 = (object) row["Location_Zipcode"].ToString();
            obj21 = (object) $"{obj21.ToString()} {obj15.ToString()}";
          }
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row["Location_Contact_Name"])))
            obj18 = (object) row["Location_Contact_Name"].ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row["Location_Contact_Phone"])))
            obj19 = (object) row["Location_Contact_Phone"].ToString();
          DefaultDatabase.ExecuteNonQuery("SaveAdminInspectionInfo", new object[56]
          {
            (object) "@ControlNo",
            controlNo,
            (object) "@PolicyNumber",
            obj1,
            (object) "@Insured",
            insuredPolicyName,
            (object) "@LocationID",
            row["Location_Id"],
            (object) "@LocationAddress",
            obj21,
            (object) "@InspectionCompanyID",
            (object) this.StandAloneInspectionCompanyID,
            (object) "@EffectiveDate",
            effectiveDate,
            (object) "@OrderDate",
            serverTime,
            (object) "@DropDeadDate",
            null,
            (object) "@FollowupDate",
            null,
            (object) "@ReceivedDate",
            null,
            (object) "@Received",
            null,
            (object) "@RevisedContactInfo",
            null,
            (object) "@UWNotified",
            null,
            (object) "@AwaitingStatusFeedBack",
            null,
            (object) "@Cancelled",
            null,
            (object) "@NonProductive",
            null,
            (object) "@Address1",
            obj13,
            (object) "@Address2",
            obj14,
            (object) "@City",
            obj16,
            (object) "@State",
            obj17,
            (object) "@Zip",
            obj15,
            (object) "@LocationNumber",
            obj20,
            (object) "@InspectionContact",
            obj18,
            (object) "@InspectionContactPhone",
            obj19,
            (object) "@Underwriter",
            obj2,
            (object) "@OrderBy",
            (object) userGuid,
            (object) "@InsuredID",
            (object) num
          });
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

  private void SaveSubmissionInspectionsInfo()
  {
    object serverTime = (object) CurrentUser.ServerTime;
    Guid userGuid1 = CurrentUser.Instance.UserGUID;
    int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT InsuredID FROM tblInsureds WITH (NOLOCK) WHERE InsuredGUID = @IG", new object[2]
    {
      (object) "@IG",
      (object) this._quote.SubmissionGroup.InsuredGuid
    });
    Guid userGuid2 = CurrentUser.Instance.UserGUID;
    string str1 = "SELECT LocationID, QuoteGuid, Location, InspectionType, InspectionContact, InspectionContactPhone, Address, City, State, ZipCode  FROM tblSubmissionInspRequests WITH (NOLOCK) WHERE UserGuid=@UG AND SubmissionGroupGuid=@SG ";
    string str2 = "SELECT LocationNo, BuildingNo, Address1, Address2, City, State, Zip, PhysicalBuildingNo, InspectionContact, RoofInspectionContact, InspectionContactPhone, RoofInspectionContactPhone, InspectionCompanyID  FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID=@LID";
    try
    {
      foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, str1, new object[4]
      {
        (object) "@UG",
        (object) userGuid2,
        (object) "@SG",
        (object) this._quote.SubmissionGroupGuid
      }).Rows)
      {
        Quote quote = new Quote((Guid) row["QuoteGuid"]);
        Guid quoteGuid = quote.QuoteGuid;
        object controlNo = (object) quote.ControlNo;
        object obj1 = (object) null;
        object insuredPolicyName = (object) quote.InsuredPolicyName;
        object effectiveDate = (object) quote.EffectiveDate;
        object obj2 = (object) $"{quote.Underwriter.LastName}, {quote.Underwriter.FirstName}";
        if (quote.HasPolicyNumber)
          obj1 = (object) quote.PolicyNumber;
        object obj3 = (object) null;
        object obj4 = (object) null;
        object obj5 = (object) string.Empty;
        string str3 = string.Empty;
        if (row["InspectionContact"] != DBNull.Value)
          RuntimeHelpers.GetObjectValue(row["InspectionContact"]);
        if (row["InspectionContactPhone"] != DBNull.Value)
          RuntimeHelpers.GetObjectValue(row["InspectionContactPhone"]);
        if (row["InspectionType"] != DBNull.Value)
        {
          if (row["InspectionType"].ToString().Equals("N"))
          {
            DefaultDatabase.ExecuteNonQuery("SaveAdminInspectionInfo", new object[56]
            {
              (object) "@ControlNo",
              controlNo,
              (object) "@PolicyNumber",
              obj1,
              (object) "@Insured",
              insuredPolicyName,
              (object) "@LocationID",
              row["LocationID"],
              (object) "@LocationAddress",
              row["Address"],
              (object) "@InspectionCompanyID",
              (object) this.SubmissionRequestInspectionCompanyID,
              (object) "@EffectiveDate",
              effectiveDate,
              (object) "@OrderDate",
              serverTime,
              (object) "@DropDeadDate",
              null,
              (object) "@FollowupDate",
              null,
              (object) "@ReceivedDate",
              null,
              (object) "@Received",
              null,
              (object) "@RevisedContactInfo",
              null,
              (object) "@UWNotified",
              null,
              (object) "@AwaitingStatusFeedBack",
              null,
              (object) "@Cancelled",
              null,
              (object) "@NonProductive",
              null,
              (object) "@Address1",
              row["Address"],
              (object) "@Address2",
              obj3,
              (object) "@City",
              row["City"],
              (object) "@State",
              row["State"],
              (object) "@Zip",
              row["ZipCode"],
              (object) "@LocationNumber",
              obj4,
              (object) "@InspectionContact",
              row["InspectionContact"],
              (object) "@InspectionContactPhone",
              row["InspectionContactPhone"],
              (object) "@Underwriter",
              obj2,
              (object) "@OrderBy",
              (object) userGuid1,
              (object) "@InsuredID",
              (object) num
            });
          }
          else
          {
            DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, str2, new object[2]
            {
              (object) "@LID",
              row["LocationID"]
            });
            if (dataRow != null)
            {
              if (!dataRow.IsNull("PhysicalBuildingNo"))
                str3 = dataRow["PhysicalBuildingNo"].ToString() + " ";
              if (!dataRow.IsNull("LocationNo"))
                obj4 = (object) ("Loc #" + dataRow["LocationNo"].ToString().ToString());
              if (dataRow["BuildingNo"] != DBNull.Value)
              {
                object obj6 = (object) dataRow["BuildingNo"].ToString();
                obj4 = obj4 == null ? (object) ("Loc #, Bldg #" + obj6.ToString()) : (object) $"{obj4.ToString()}, Bldg #{obj6.ToString()}";
              }
              if (dataRow["Address1"] != DBNull.Value)
              {
                string str4 = str3 + dataRow["Address1"].ToString();
                obj5 = (object) $"{str3}{obj5.ToString()}{dataRow["Address1"].ToString()}\n";
              }
              if (dataRow["Address2"] != DBNull.Value)
                obj3 = (object) dataRow["Address2"].ToString();
              if (dataRow[4] != DBNull.Value)
              {
                dataRow[4].ToString();
                obj5 = (object) (obj5.ToString() + dataRow[4].ToString());
              }
              if (dataRow[5] != DBNull.Value)
              {
                dataRow[5].ToString();
                obj5 = (object) $"{obj5.ToString()}, {dataRow[5].ToString()}";
              }
              if (dataRow[6] != DBNull.Value)
              {
                dataRow[6].ToString();
                obj5 = (object) $"{obj5.ToString()} {dataRow[6].ToString()}";
              }
            }
            DefaultDatabase.ExecuteNonQuery("InsertAdminInspectionRow", new object[58]
            {
              (object) "@ControlNo",
              controlNo,
              (object) "@PolicyNumber",
              obj1,
              (object) "@Insured",
              insuredPolicyName,
              (object) "@LocationID",
              row["LocationID"],
              (object) "@LocationAddress",
              obj5,
              (object) "@InspectionCompanyID",
              (object) this.SubmissionRequestInspectionCompanyID,
              (object) "@EffectiveDate",
              effectiveDate,
              (object) "@OrderDate",
              serverTime,
              (object) "@DropDeadDate",
              null,
              (object) "@FollowupDate",
              null,
              (object) "@ReceivedDate",
              null,
              (object) "@Received",
              null,
              (object) "@RevisedContactInfo",
              null,
              (object) "@UWNotified",
              null,
              (object) "@AwaitingStatusFeedBack",
              null,
              (object) "@Cancelled",
              null,
              (object) "@NonProductive",
              null,
              (object) "@Address1",
              row["Address"],
              (object) "@Address2",
              obj3,
              (object) "@City",
              row["City"],
              (object) "@State",
              row["State"],
              (object) "@Zip",
              row["ZipCode"],
              (object) "@LocationNumber",
              obj4,
              (object) "@InspectionContact",
              row["InspectionContact"],
              (object) "@InspectionContactPhone",
              row["InspectionContactPhone"],
              (object) "@Underwriter",
              obj2,
              (object) "@OrderBy",
              (object) userGuid1,
              (object) "@InsuredID",
              (object) num,
              (object) "@Roof",
              (object) false
            });
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
  }

  private string MassageZipCode(string zip) => zip.Length > 5 ? zip.Insert(5, "-") : zip;

  public virtual void UploadDocumentsFromDocHandler(
    string fileName,
    string sftpHost,
    string un,
    string pw,
    bool isAccount)
  {
  }

  protected virtual string GetPolicyNumber()
  {
    return !this._quote.HasPolicyNumber ? "To be determined. Control # " + this._quote.ControlNo.ToString() : this._quote.PolicyNumber;
  }
}
