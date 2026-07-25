// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.PreferredReportsRequests
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

public class PreferredReportsRequests
{
  private RRIRequest _ds;
  private Quote _quote;
  private readonly FormSubmissionGroupInspectionRequests _fsr;
  private Guid _currentQuoteGuid;
  private readonly int _controlNo;

  public PreferredReportsRequests(Guid quoteGuid)
  {
    this._fsr = (FormSubmissionGroupInspectionRequests) null;
    this._quote = new Quote(quoteGuid);
    this._controlNo = this._quote.ControlNo;
    this._currentQuoteGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "select top 1 QuoteGuid from tblQuotes with (nolock) where controlno = @CN order by QuoteID DESC", new object[2]
    {
      (object) "@CN",
      (object) this._controlNo
    });
    try
    {
      foreach (Form openForm in (ReadOnlyCollectionBase) Application.OpenForms)
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
  }

  public object BaseInspectionMethod
  {
    get => this._BaseInspectionMethod;
    set => this._BaseInspectionMethod = RuntimeHelpers.GetObjectValue(value);
  }

  public bool SubmissionRequest { get; set; }

  public int StandAloneInspectionCompanyID { get; set; }

  public string GetClientUniqueIdentifier { get; }

  public string GetInspectionUniqueIdentifier { get; }

  public string SubmissionRequestDivision { get; set; }

  public string SubmissionRequestProgramCode { get; set; }

  public List<int> QuoteList { get; set; }

  public int SubmissionRequestInspectionCompanyID { get; set; }

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
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["InsuredAddress1"])))
        empty1 = dataRow["InsuredAddress1"].ToString();
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["InsuredAddress2"])))
        empty2 = dataRow["InsuredAddress2"].ToString();
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["InsuredCity"])))
        empty3 = dataRow["InsuredCity"].ToString();
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["InsuredZipCode"])))
        empty5 = dataRow["InsuredZipCode"].ToString();
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["InsuredState"])))
        empty4 = dataRow["InsuredState"].ToString();
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["InsuredDBA"])))
      {
        st = dataRow["InsuredDBA"].ToString();
        if (st.Length > 100)
          st = st.Substring(0, 99);
      }
    }
    RRIRequest.RequestRow requestRow = dr;
    requestRow.Line_of_Business = this._quote.LineName;
    requestRow.Policy_Number = !this._quote.HasPolicyNumber ? "Policy # TBD" : this._quote.PolicyNumber;
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
    try
    {
      foreach (DataRow row1 in DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT LocationID,InspectionContact, InspectionContactPhone, Comments, Rush, Location, ClassCode FROM tblSubmissionInspRequests WITH (NOLOCK) WHERE UserGuid=@UG AND InspectionType=@IT AND QuoteGuid=@QG ", new object[6]
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
        DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT Address,[P.O.Box] AS Address2, City, State, ZipCode FROM NetRate_Quote_Insur_Quote_Locat WITH (NOLOCK) WHERE LocationID=@LID", new object[2]
        {
          (object) "@LID",
          (object) locationRow.Location_Id
        });
        if (dataRow != null)
        {
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["Address"])))
            locationRow.Location_Address1 = InspectionRequest.EscapeXMLChars(dataRow["Address"].ToString());
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["Address2"])))
            locationRow.Location_Address2 = InspectionRequest.EscapeXMLChars(dataRow["Address2"].ToString());
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["City"])))
            locationRow.Location_City = InspectionRequest.EscapeXMLChars(dataRow["City"].ToString());
          locationRow.Location_State = dataRow["State"].ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["ZipCode"])))
            locationRow.Location_Zipcode = dataRow["ZipCode"].ToString();
        }
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["InspectionContact"])))
          locationRow.Location_Contact_Name = InspectionRequest.EscapeXMLChars(row1["InspectionContact"].ToString());
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["InspectionContactPhone"])))
          locationRow.Location_Contact_Phone = row1["InspectionContactPhone"].ToString();
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["Comments"])))
          locationRow.Special_Instructions = InspectionRequest.EscapeXMLChars(row1["Comments"].ToString());
        locationRow.Rush = !Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["Rush"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(row1["Rush"]));
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["Location"])))
          locationRow.Location_Description = InspectionRequest.EscapeXMLChars(row1["Location"].ToString());
        locationRow.Due_Date = Strings.Format((object) InspectionsHelperUtility.GetInspectionLocationDueDate(Convert.ToInt32(locationRow.Location_Id), this._currentQuoteGuid), "yyyy-MM-dd");
        locationRow.Customer_Reference_ID = InspectionsHelperUtility.GetCustomerReferenceIdentifier(Convert.ToInt32(locationRow.Location_Id), this._currentQuoteGuid);
        this._ds.Location.AddLocationRow(row2);
        locationRow.RequestRow = this._ds.Request[0];
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["ClassCode"])))
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

  private bool ValidatePreferredReportsCredentials(
    ref string UserName,
    ref string Password,
    ref string Url)
  {
    if (SystemSettings.KeyExists("PreferredReportsUserName"))
      UserName = SystemSettings.GetStringSetting("PreferredReportsUserName");
    if (SystemSettings.KeyExists("PreferredReportsPassword"))
      Password = SystemSettings.GetStringSetting("PreferredReportsPassword");
    if (SystemSettings.KeyExists("PreferredReportsURL"))
      Url = SystemSettings.GetStringSetting("PreferredReportsURL");
    bool flag;
    if (Url.Replace(" ", string.Empty).Length == 0)
    {
      int num = (int) MessageBox.Show("'Preferred Reports' has a missing URL setting required for making Inspection Request.", "Missing URL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (UserName.Replace(" ", string.Empty).Length == 0 || Password.Replace(" ", string.Empty).Length == 0)
    {
      int num = (int) MessageBox.Show("'Preferred Reports' has missing credentials settings required for making Inspection Request.", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  public bool TransferFilesToPreferredReports(Guid quoteGuid)
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string empty3 = string.Empty;
    bool preferredReports;
    if (!this.ValidatePreferredReportsCredentials(ref empty1, ref empty2, ref empty3))
      preferredReports = false;
    else
      FormSettings.ShowFormDialog(typeof (FormDisplayDocuments), (object) new Quote(quoteGuid), (object) empty1, (object) empty2, (object) empty3);
    return preferredReports;
  }

  public bool SendPreferredReportsRequests()
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string empty3 = string.Empty;
    bool flag1;
    if (!this.ValidatePreferredReportsCredentials(ref empty1, ref empty2, ref empty3))
    {
      flag1 = false;
    }
    else
    {
      this.RefreshMessage("Sending request to Preferred Reports Inspection Company ...");
      List<int> intList = new List<int>();
      try
      {
        foreach (int quote in this.QuoteList)
        {
          if (!intList.Contains(quote))
          {
            intList.Add(quote);
            bool flag2 = true;
            this._quote = (Quote) null;
            this._currentQuoteGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1 QuoteGuid FROM tblQuotes WITH (NOLOCK) WHERE ControlNo=@CN ORDER BY QuoteID DESC", new object[2]
            {
              (object) "@CN",
              (object) quote
            });
            this._quote = new Quote(this._currentQuoteGuid);
            object obj = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 InspectionType FROM tblSubmissionInspRequests WITH (NOLOCK) WHERE UserGuid=@UG AND QuoteGuid=@QG", new object[4]
            {
              (object) "@UG",
              (object) CurrentUser.Instance.UserGUID,
              (object) "@QG",
              (object) this._currentQuoteGuid
            }));
            if (obj == null || obj == DBNull.Value)
              obj = (object) "B";
            this._ds = new RRIRequest();
            RRIRequest.RequestRow requestRow = this._ds.Request.NewRequestRow();
            this.RefreshMessage($"Gathering insured and other policy information for control # {quote} ...");
            this.FillCommonPolicyInformation(requestRow, this._quote.SubmissionGroup.InsuredLocation, obj.ToString());
            requestRow.Client_Code = InspectionsHelperUtility.GetClientCode(this.SubmissionRequestInspectionCompanyID, -1, this._quote.QuoteID);
            this._ds.Request.AddRequestRow(requestRow);
            QuoteDetail quoteDetail = new QuoteDetail(this._currentQuoteGuid, InspectionRequest.RequestCompanyLineGuid(this._quote));
            this.RefreshMessage($"Gathering location information for {quote} ... ");
            if (!quoteDetail.UsingNetRate)
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
            this.RefreshMessage($"Sending web request to Preferred Reports for control # {quote} ...");
            string str = $"Inspection-{Guid.NewGuid().ToString().Substring(0, 14).Replace("-", string.Empty).ToString()}-ControlNo{this._controlNo.ToString()}.xml";
            Uri requestUri = new Uri($"{empty3}/{str}");
            using (MemoryStream memoryStream = new MemoryStream())
            {
              try
              {
                this._ds.WriteXml((Stream) memoryStream);
                memoryStream.Position = 0L;
                byte[] array = memoryStream.ToArray();
                FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(requestUri);
                ftpWebRequest.Method = "STOR";
                ftpWebRequest.Credentials = (ICredentials) new NetworkCredential(empty1, empty2);
                ftpWebRequest.Proxy = (IWebProxy) null;
                ftpWebRequest.ContentLength = (long) array.Length;
                using (Stream requestStream = ftpWebRequest.GetRequestStream())
                {
                  requestStream.Write(array, 0, array.Length);
                  requestStream.Close();
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                Exception innerException = ex;
                flag2 = false;
                InspectionRequest.LogInspectionCompanyErrorReports("Preferred Reports", innerException.Message, this._currentQuoteGuid);
                ErrorHandler.SilentHandleError(new Exception($"Inspection Request failed. Unable to upload inspection to \"{requestUri.ToString()}\"", innerException));
                int num = (int) MessageBox.Show("Could not transfer file at this moment because of the following reasons:\n\n" + innerException.Message, "Could Not Complete Transfer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ProjectData.ClearProjectError();
              }
            }
            if (flag2)
            {
              this.RefreshMessage($"Logging successful request for control # {quote} ...");
              Guid userGuid = CurrentUser.Instance.UserGUID;
              bool usingNetRate = this._quote.UsingNetRate;
              try
              {
                foreach (RRIRequest.LocationRow row in this._ds.Location.Rows)
                  InspectionsLogging.LogInspectionRequest(this._currentQuoteGuid, this.SubmissionRequestInspectionCompanyID, row.Location_Id, usingNetRate, userGuid, Guid.Empty, false, this._ds.GetXml());
              }
              finally
              {
                IEnumerator enumerator;
                if (enumerator is IDisposable)
                  (enumerator as IDisposable).Dispose();
              }
              CurrentUser.Instance.LogAction($"Inspection request sent to Preferred Reports for control # {quote}", this._currentQuoteGuid);
              this.RefreshMessage($"Getting ready to transfer documents for control # {quote} ...");
              this.TransferFilesToPreferredReports(this._currentQuoteGuid);
            }
          }
        }
      }
      finally
      {
        List<int>.Enumerator enumerator;
        enumerator.Dispose();
      }
      flag1 = true;
    }
    return flag1;
  }

  private void GetBaseSubmissionLocations()
  {
    Guid userGuid = CurrentUser.Instance.UserGUID;
    try
    {
      foreach (DataRow row1 in DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT LocationID,InspectionContact, InspectionContactPhone, Comments, Rush, Location, ClassCode FROM tblSubmissionInspRequests WITH (NOLOCK) WHERE UserGuid=@UG AND InspectionType=@IT AND QuoteGuid=@QG ", new object[6]
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
        DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT Address1, Address2, City, State, Zip FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID=@LID", new object[2]
        {
          (object) "@LID",
          (object) locationRow.Location_Id
        });
        if (dataRow != null)
        {
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["Address1"])))
            locationRow.Location_Address1 = InspectionRequest.EscapeXMLChars(dataRow["Address1"].ToString());
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["Address2"])))
            locationRow.Location_Address2 = InspectionRequest.EscapeXMLChars(dataRow["Address2"].ToString());
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["City"])))
            locationRow.Location_City = InspectionRequest.EscapeXMLChars(dataRow["City"].ToString());
          locationRow.Location_State = dataRow["State"].ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["Zip"])))
            locationRow.Location_Zipcode = dataRow["Zip"].ToString();
        }
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["InspectionContact"])))
          locationRow.Location_Contact_Name = InspectionRequest.EscapeXMLChars(row1["InspectionContact"].ToString());
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["InspectionContactPhone"])))
          locationRow.Location_Contact_Phone = InspectionRequest.EscapeXMLChars(row1["InspectionContactPhone"].ToString());
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["Comments"])))
          locationRow.Special_Instructions = InspectionRequest.EscapeXMLChars(row1["Comments"].ToString());
        locationRow.Rush = !Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["Rush"])) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(row1["Rush"]));
        locationRow.Location_Description = Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["Location"])) ? "TBD" : InspectionRequest.EscapeXMLChars(row1["Location"].ToString());
        locationRow.Due_Date = Strings.Format((object) InspectionsHelperUtility.GetInspectionLocationDueDate(locationRow.Location_Id, this._currentQuoteGuid), "yyyy-MM-dd");
        locationRow.Customer_Reference_ID = InspectionsHelperUtility.GetCustomerReferenceIdentifier(locationRow.Location_Id, this._currentQuoteGuid);
        locationRow.RequestRow = this._ds.Request[0];
        this._ds.Location.AddLocationRow(row2);
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["ClassCode"])))
        {
          RRIRequest.SIC_CodesRow row3 = this._ds.SIC_Codes.NewSIC_CodesRow();
          row3.SIC_Code = row1["ClassCode"].ToString();
          this._ds.SIC_Codes.AddSIC_CodesRow(row3);
          row3.LocationRow = row2;
        }
        this._ds.Location.AddLocationRow(row2);
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
