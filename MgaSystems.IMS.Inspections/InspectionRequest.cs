// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.InspectionRequest
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.InsuredsProducersCompanies.Insureds;
using MGASystems.IMS.Logging;
using MGASystems.IMS.Logging.Administration;
using MGASystems.IMS.Policies.Inspections.Reliable;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[LogCategory("MGASystems.IMS.Policies.Inspections.InspectionRequest", "MGASystems.IMS.Policies.Inspections.InspectionRequest")]
public class InspectionRequest
{
  private readonly Quote _quote;
  private InspectionRequest.NetRateLocations _netRateLocations;
  private Guid _lineGuid;
  private List<InspectionRequest.Report> _reports;
  private string _clientCode;
  private int _inspectionCompanyID;
  private RRIRequest _netRateInpections;
  private bool _emailInspections;
  private string _fileName;
  private static bool _alwaysSetNetRate = true;
  private string _reliableReturnGuid;
  private MGASystems.IMS.Policies.Inspections.NetRate.dsInspectionRequest _netRateLocDataset;
  private UltraGrid _BaseInspectionGrid;
  private int _currentBaseLocationID;
  private static bool _requestAsNetRate = false;
  private object _inspectionMethod;
  private InspectionRequest.RequestType _requestType;
  private int _roofInspectionCompanyID;
  private List<LocationInspectionCompany> _baseInspectionCompLocations;
  private List<LocationInspectionCompany> _listBaseInspectionCompLocations;
  private static bool _blackBoxMode = false;
  private bool _hasError;
  private RRIRequest _baseInspections;

  public InspectionRequest(Guid quoteGuid)
  {
    this._netRateLocations = new InspectionRequest.NetRateLocations();
    this._lineGuid = Guid.Empty;
    this._clientCode = string.Empty;
    this._inspectionCompanyID = -1;
    this._emailInspections = true;
    this._reliableReturnGuid = string.Empty;
    this._inspectionMethod = (object) null;
    this._requestType = InspectionRequest.RequestType.None;
    this._roofInspectionCompanyID = -1;
    this._baseInspectionCompLocations = new List<LocationInspectionCompany>();
    this._listBaseInspectionCompLocations = new List<LocationInspectionCompany>();
    this._hasError = false;
    this._quote = new Quote(quoteGuid);
    this._requestType = InspectionRequest.RequestType.None;
  }

  public UltraGrid BaseInspectionGrid
  {
    get => this._BaseInspectionGrid;
    set => this._BaseInspectionGrid = value;
  }

  public InspectionRequest.RequestType InspectionRequestingType => this._requestType;

  public List<LocationInspectionCompany> ListBaseInspectionCompLocations
  {
    get => this._listBaseInspectionCompLocations;
  }

  public bool HasError => this._hasError;

  [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
  protected virtual void InspectionsSucceeded(
    List<UnderwritingLocation> inspectedLocations,
    RRIRequest netRateInspections)
  {
    Guid quoteGuid = this._quote.QuoteGuid;
    Guid userGuid = CurrentUser.Instance.UserGUID;
    bool flag;
    try
    {
      foreach (LocationInspectionCompany inspectionCompLocation in this._listBaseInspectionCompLocations)
      {
        if (inspectionCompLocation.SuccessfullySent)
        {
          DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT LocationNo, BuildingNo, LocationGuid FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID=@LID", new object[2]
          {
            (object) "@LID",
            (object) inspectionCompLocation.Location
          });
          string empty1 = string.Empty;
          string empty2 = string.Empty;
          if (dataRow != null)
          {
            if (dataRow[0] != null && dataRow[0] != DBNull.Value)
              empty1 = dataRow[0].ToString();
            if (dataRow[1] != null && dataRow[1] != DBNull.Value)
              empty2 = dataRow[1].ToString();
            Guid locationGuid = (Guid) dataRow[2];
            string str = inspectionCompLocation.Roof ? "Roof inspection requested for location #" : "Regular inspection requested for location #";
            string inspectionCompany = InspectionRequest.GetInspectionCompany(inspectionCompLocation.InspectionCompany);
            CurrentUser.Instance.LogAction($"{str}{empty1}, building #{empty2} via {inspectionCompany}", this._quote.ControlGuid);
            CurrentUser.Instance.LogAction($"{str}{empty1}, building #{empty2} via {inspectionCompany}", this._quote.QuoteGuid);
            string xml = this._baseInspections.GetXml();
            if (this.IsUniformedXml(xml))
              InspectionsLogging.LogInspectionRequest(quoteGuid, inspectionCompLocation.InspectionCompany, inspectionCompLocation.Location, false, userGuid, locationGuid, inspectionCompLocation.Roof, xml);
            else if (!flag)
            {
              CurrentUser.Instance.LogAction($"Inspection request to '{inspectionCompany}' is not logged to the database because the XML is not uniformed", this._quote.QuoteGuid);
              flag = true;
            }
          }
        }
      }
    }
    finally
    {
      List<LocationInspectionCompany>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (!this._quote.UsingNetRate && !InspectionRequest.RequestAsNetRate)
      return;
    if (netRateInspections == null)
      return;
    try
    {
      foreach (DataRow row in netRateInspections.Location.Rows)
      {
        string str = $"{row["Location_Address1"].ToString()}, {row["Location_City"].ToString()}, {row["Location_State"].ToString()}";
        CurrentUser.Instance.LogAction("Inspection requested for location: " + str, this._quote.ControlGuid);
        CurrentUser.Instance.LogAction("Inspection requested for location: " + str, this._quote.QuoteGuid);
        string xml = this._netRateInpections.GetXml();
        if (this.IsUniformedXml(xml))
          InspectionsLogging.LogInspectionRequest(quoteGuid, this.InspectionCompanyID, Conversions.ToInteger(row["Location_Id"]), true, userGuid, Guid.Empty, false, xml);
        else if (!flag)
        {
          CurrentUser.Instance.LogAction("Inspection request is not logged to the database because the XML is not uniformed", this._quote.QuoteGuid);
          flag = true;
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

  public virtual bool OmitLocationAndBuildingNumbers() => false;

  public void AddNetRateReport(
    int netrateLocationId,
    bool costEstimator,
    bool photo,
    bool diagram)
  {
    if (this._reports == null)
      this._reports = new List<InspectionRequest.Report>();
    this._reports.Add(new InspectionRequest.Report()
    {
      NetRateLocationID = netrateLocationId,
      CostEstimator = costEstimator,
      Diagram = diagram,
      Photo = photo
    });
  }

  public void AddNetRateLocation(
    int locationId,
    int premisesId,
    string address,
    string address2,
    string city,
    string state,
    string zipcode,
    string classCode,
    string sic,
    string contactName,
    string contactPhone,
    string specialInstructions,
    UltraGrid grid,
    string locationBldg)
  {
    InspectionRequest.NetRateLocation loc = new InspectionRequest.NetRateLocation();
    InspectionRequest.NetRateLocation netRateLocation = loc;
    netRateLocation.LocationID = locationId;
    netRateLocation.ContactName = contactName;
    netRateLocation.ContactPhone = contactPhone;
    netRateLocation.UniqueID = premisesId;
    netRateLocation.SpecialInstructions = specialInstructions;
    netRateLocation.Address = address;
    netRateLocation.Address2 = address2;
    netRateLocation.City = city;
    netRateLocation.State = state;
    netRateLocation.ZipCode = zipcode;
    netRateLocation.ClassCode = classCode;
    netRateLocation.SIC = sic;
    netRateLocation.LocationBldg = locationBldg;
    this.AddClientData(loc, grid);
    this._netRateLocations.Add(loc);
  }

  protected virtual void FillInspectionCompanies(MGASystems.IMS.Policies.Inspections.IMSBase.dsInspectionRequest ds)
  {
    if (!InspectionRequest.BlackBoxMode)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.BaseInspectionGrid).Rows)
      {
        int integer = Conversions.ToInteger(row.Cells["InspectionCompanyID"].Value);
        if (ds.InspectionCompanies.FindByInspectionCompanyID(integer) == null)
          ds.InspectionCompanies.AddInspectionCompaniesRow(integer);
      }
    }
    else
    {
      try
      {
        foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DISTINCT InspectionCompanyID FROM tblUnderwritingLocations WITH (NOLOCK) WHERE Inspect=1 AND QuoteGuid = @QuoteGuid", new object[2]
        {
          (object) "@QuoteGuid",
          (object) this._quote.QuoteGuid
        }).Rows)
        {
          if (ds.InspectionCompanies.FindByInspectionCompanyID(Conversions.ToInteger(row[0])) == null)
            ds.InspectionCompanies.AddInspectionCompaniesRow(Conversions.ToInteger(row[0]));
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DISTINCT RoofInspectionCompanyID FROM tblUnderwritingLocations WITH (NOLOCK) WHERE RoofInspect = 1 AND QuoteGuid = @QuoteGuid", new object[2]
        {
          (object) "@QuoteGuid",
          (object) this._quote.QuoteGuid
        }).Rows)
        {
          if (ds.InspectionCompanies.FindByInspectionCompanyID(Conversions.ToInteger(row[0])) == null)
            ds.InspectionCompanies.AddInspectionCompaniesRow(Conversions.ToInteger(row[0]));
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

  protected virtual bool GatherLocationsToInspect(
    MGASystems.IMS.Policies.Inspections.IMSBase.dsInspectionRequest ds,
    List<UnderwritingLocation> locations,
    MGASystems.IMS.Policies.Inspections.IMSBase.dsInspectionRequest.InspectionCompaniesRow dr,
    List<UnderwritingLocation> inspectedLocations)
  {
    this._baseInspectionCompLocations.Clear();
    if (!InspectionRequest.BlackBoxMode)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.BaseInspectionGrid).Rows)
      {
        if (Conversions.ToInteger(row.Cells["InspectionCompanyID"].Value) == dr.InspectionCompanyID)
        {
          bool roof = false;
          if (row.Cells["Roof"].Value != null && row.Cells["Roof"].Value != DBNull.Value)
            roof = Conversions.ToBoolean(row.Cells["Roof"].Value);
          int integer = Conversions.ToInteger(row.Cells["LocationID"].Value);
          UnderwritingLocation underwritingLocation = new UnderwritingLocation(integer);
          locations.Add(underwritingLocation);
          inspectedLocations.Add(underwritingLocation);
          LocationInspectionCompany inspectionCompany = new LocationInspectionCompany(dr.InspectionCompanyID, integer, roof);
          this._baseInspectionCompLocations.Add(inspectionCompany);
          this._listBaseInspectionCompLocations.Add(inspectionCompany);
        }
      }
    }
    else
    {
      try
      {
        foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT LocationID FROM tblUnderwritingLocations WITH (NOLOCK) WHERE (InspectionCompanyID=@InspectionCompanyID) AND (QuoteGuid=@QuoteGuid) AND (Inspect=1) AND (ModificationCode <> @MC)", new object[6]
        {
          (object) "@MC",
          (object) "D",
          (object) "@InspectionCompanyID",
          (object) dr.InspectionCompanyID,
          (object) "@QuoteGuid",
          (object) this._quote.QuoteGuid
        }).Rows)
        {
          UnderwritingLocation underwritingLocation = new UnderwritingLocation((int) row[0]);
          locations.Add(underwritingLocation);
          inspectedLocations.Add(underwritingLocation);
          LocationInspectionCompany inspectionCompany = new LocationInspectionCompany(dr.InspectionCompanyID, Conversions.ToInteger(row[0]), false);
          this._baseInspectionCompLocations.Add(inspectionCompany);
          this._listBaseInspectionCompLocations.Add(inspectionCompany);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT LocationID FROM tblUnderwritingLocations WITH (NOLOCK) WHERE (RoofInspectionCompanyID=@InspectionCompanyID) AND (QuoteGuid=@QuoteGuid) AND (RoofInspect = 1) AND (ModificationCode <> @MC)", new object[6]
        {
          (object) "@MC",
          (object) "D",
          (object) "@InspectionCompanyID",
          (object) dr.InspectionCompanyID,
          (object) "@QuoteGuid",
          (object) this._quote.QuoteGuid
        }).Rows)
        {
          UnderwritingLocation underwritingLocation = new UnderwritingLocation((int) row[0]);
          if (!locations.Contains(underwritingLocation))
            locations.Add(underwritingLocation);
          if (!inspectedLocations.Contains(underwritingLocation))
            inspectedLocations.Add(underwritingLocation);
          LocationInspectionCompany inspectionCompany = new LocationInspectionCompany(dr.InspectionCompanyID, Conversions.ToInteger(row[0]), true);
          this._baseInspectionCompLocations.Add(inspectionCompany);
          this._listBaseInspectionCompLocations.Add(inspectionCompany);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    bool inspect;
    if (InspectionRequest.BlackBoxMode)
    {
      inspect = true;
    }
    else
    {
      string str1 = "SELECT InspectionRequested, RoofInspectionRequested FROM  tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID=@LocationID AND (InspectionCompanyID = @IC OR RoofInspectionCompanyID = @IC)";
      try
      {
        foreach (LocationInspectionCompany inspectionCompLocation in this._baseInspectionCompLocations)
        {
          DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, str1, new object[4]
          {
            (object) "@IC",
            (object) dr.InspectionCompanyID,
            (object) "@LocationID",
            (object) inspectionCompLocation.Location
          });
          if (dataRow != null && (!dataRow.IsNull("InspectionRequested") || !dataRow.IsNull("RoofInspectionRequested")))
          {
            object obj = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Address1 + @C + City + @C + State + @C + Zip AS LOC FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID = @LID", new object[4]
            {
              (object) "@LID",
              (object) inspectionCompLocation.Location,
              (object) "@C",
              (object) ", "
            }));
            if (obj != null && obj != DBNull.Value)
              obj = (object) $"\n\n{obj.ToString()}\n\n";
            string str2 = string.Empty;
            if (!dataRow.IsNull("InspectionRequested"))
              str2 = "A regular inspection has";
            if (!dataRow.IsNull("RoofInspectionRequested"))
              str2 = !str2.Equals(string.Empty) ? "Regular and roof inspections have " : "A  roof inspection has ";
            if (MessageBox.Show($"{str2 + " already been requested for location "}{obj.ToString()}Would you like to continue requesting inspections?", "Continue Requesting Inspections?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
              inspect = false;
              goto label_39;
            }
          }
        }
      }
      finally
      {
        List<LocationInspectionCompany>.Enumerator enumerator;
        enumerator.Dispose();
      }
      inspect = true;
    }
label_39:
    return inspect;
  }

  public void Send()
  {
    this._hasError = false;
    if (this._lineGuid.Equals(Guid.Empty) && this._quote.IsPackagePolicy)
    {
      this._hasError = true;
      throw new InvalidOperationException("The LineGuid property must be set for package policies prior to calling Send");
    }
    if (this._lineGuid.Equals(Guid.Empty))
      this._lineGuid = this._quote.LineGuid;
    MGASystems.IMS.Policies.Inspections.IMSBase.dsInspectionRequest ds = new MGASystems.IMS.Policies.Inspections.IMSBase.dsInspectionRequest();
    int num1 = 0;
    int num2 = 0;
    List<UnderwritingLocation> inspectedLocations = new List<UnderwritingLocation>();
    try
    {
      if (this._quote.UsingNetRate || InspectionRequest.RequestAsNetRate)
      {
        this._requestType = InspectionRequest.RequestType.NetRate;
        if (this.SendUsingNetRate())
          num1 = 1;
        else
          num2 = 1;
      }
      else
      {
        this._requestType = InspectionRequest.RequestType.Base;
        this.FillInspectionCompanies(ds);
        List<UnderwritingLocation> locations = new List<UnderwritingLocation>();
        try
        {
          foreach (MGASystems.IMS.Policies.Inspections.IMSBase.dsInspectionRequest.InspectionCompaniesRow inspectionCompany in (TypedTableBase<MGASystems.IMS.Policies.Inspections.IMSBase.dsInspectionRequest.InspectionCompaniesRow>) ds.InspectionCompanies)
          {
            if (!this.GatherLocationsToInspect(ds, locations, inspectionCompany, inspectedLocations))
              return;
            if (this.CreateRequest(locations, inspectionCompany.InspectionCompanyID))
            {
              try
              {
                foreach (LocationInspectionCompany inspectionCompLocation in this._baseInspectionCompLocations)
                {
                  if (inspectionCompany.InspectionCompanyID == inspectionCompLocation.InspectionCompany)
                  {
                    inspectionCompLocation.SuccessfullySent = true;
                    if (!inspectionCompLocation.Roof)
                      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblUnderwritingLocations SET InspectionRequested=@InspectionRequested WHERE LocationID=@LocationID", new object[4]
                      {
                        (object) "@InspectionRequested",
                        (object) DateTime.Now,
                        (object) "@LocationID",
                        (object) inspectionCompLocation.Location
                      });
                    else
                      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblUnderwritingLocations SET RoofInspectionRequested=@InspectionRequested WHERE LocationID=@LocationID", new object[4]
                      {
                        (object) "@InspectionRequested",
                        (object) DateTime.Now,
                        (object) "@LocationID",
                        (object) inspectionCompLocation.Location
                      });
                  }
                }
              }
              finally
              {
                List<LocationInspectionCompany>.Enumerator enumerator;
                enumerator.Dispose();
              }
              ++num1;
            }
            else
              ++num2;
          }
        }
        finally
        {
          IEnumerator<MGASystems.IMS.Policies.Inspections.IMSBase.dsInspectionRequest.InspectionCompaniesRow> enumerator;
          enumerator?.Dispose();
        }
      }
      if (num1 > 0)
      {
        this.InspectionsSucceeded(inspectedLocations, this._netRateInpections);
        this.SaveInspectionsInfo(this._listBaseInspectionCompLocations, this._netRateInpections);
      }
      if (num2 > 0)
      {
        if (num1 > 0)
        {
          if (this.EmailInspections)
          {
            int num3 = (int) MessageBox.Show($"{num1.ToString()} inspection requests were succesfully sent, but {num2.ToString()} requests failed.", "Some Requests Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          else
          {
            int num4 = (int) MessageBox.Show($"{num1.ToString()} inspection requests succeeded, but {num2.ToString()} requests failed.", "Some Requests Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }
        else
        {
          this.ShowErrorMessage("All inspection requests failed.", "All Requests Failed!");
          return;
        }
      }
      else if (num1 > 0)
      {
        if (this.EmailInspections)
        {
          int num5 = (int) MessageBox.Show("All inspection requests were succesfully sent to the inspection company.", "Requests Sent", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          int num6 = (int) MessageBox.Show("All inspection requests were succesfully processed.", "Requests Processed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      else
      {
        if (this.EmailInspections)
        {
          int num7 = (int) MessageBox.Show("No requests were sent!", "No Requests", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        int num8 = (int) MessageBox.Show("No requests were processed!", "No Requests Processed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      if (num1 <= 0)
        return;
      Cursor.Current = MgaCursors.WaitCursor;
      try
      {
        Messaging.SendBroadcastMessage(BroadcastMessages.InspectionRequested, (object) new InspectionRequestedEventArgs(this.InspectionCompanyID, this._quote.QuoteGuid));
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
    catch (NoLocationClassCodeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      NoLocationClassCodeException classCodeException = ex;
      this._hasError = true;
      this.ShowErrorMessage(classCodeException.Message, "Missing Location Class Codes");
      ProjectData.ClearProjectError();
    }
    catch (InspectionClientCodeNotFoundException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      InspectionClientCodeNotFoundException notFoundException = ex;
      this._hasError = true;
      this.ShowErrorMessage(notFoundException.Message, "Missing Client Codes");
      ProjectData.ClearProjectError();
    }
    catch (UnexpectedLineOfBusinessException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this._hasError = true;
      this.ShowErrorMessage("Automated inspection requests are not supported for this line of business.", "Contact Tech Support - Line of Business Not Supported");
      ProjectData.ClearProjectError();
    }
    catch (NoInspectionCompanyEmailException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      NoInspectionCompanyEmailException companyEmailException = ex;
      this._hasError = true;
      this.ShowErrorMessage(companyEmailException.Message, "Email Not Found");
      ProjectData.ClearProjectError();
    }
    catch (ProducerPhoneNotFoundException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProducerPhoneNotFoundException notFoundException = ex;
      this._hasError = true;
      this.ShowErrorMessage(notFoundException.Message, "Invalid Phone Number");
      ProjectData.ClearProjectError();
    }
    catch (WebException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this._hasError = true;
      this.ShowErrorMessage("The inspection webservice could not be contacted, it may be unavailable at this time.", "Webservice Unavailable");
      ProjectData.ClearProjectError();
    }
    catch (InspectionContactNotFoundException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this._hasError = true;
      if (MessageBox.Show("An inspection contact was not found for this insured.\n\nWould you like to add one now?", "Inspection Contact Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        FormSettings.ShowForm(typeof (frmInsuredContacts), (object) this._quote.SubmissionGroup.InsuredLocation.InsuredLocationGuid);
      ProjectData.ClearProjectError();
    }
    catch (InspectionContactMissingPhone ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this._hasError = true;
      if (MessageBox.Show("An inspection contact is missing a phone number.\n\nWould you like to add the phone number now?", "Missing Inspection Contact Phone Number", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        FormSettings.ShowForm(typeof (frmInsuredContacts), (object) this._quote.SubmissionGroup.InsuredLocation.InsuredLocationGuid);
      ProjectData.ClearProjectError();
    }
    catch (InspectionRequestException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      InspectionRequestException requestException = ex;
      this._hasError = true;
      this.ShowErrorMessage("The inspection request failed.  The message returned from the service was:\n\n" + requestException.Message, "Inspection Request Failed");
      ProjectData.ClearProjectError();
    }
    catch (InspectionRequestMissingUserEmailSettings ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      InspectionRequestMissingUserEmailSettings userEmailSettings = ex;
      this._hasError = true;
      this.ShowErrorMessage("The inspection request failed.\n\n" + userEmailSettings.Message, "Inspection Request Failed");
      ProjectData.ClearProjectError();
    }
    catch (SoapException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      SoapException soapException = ex;
      this._hasError = true;
      if (soapException.Message.Contains("Invalid Client Code"))
      {
        int num9 = (int) MessageBox.Show("The client code is invalid", "Invalid Client Code", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        ProjectData.ClearProjectError();
      }
      else
        throw;
    }
  }

  private void ShowErrorMessage(string messageTxt, string headerText)
  {
    this._hasError = true;
    int num = (int) MessageBox.Show(messageTxt, headerText, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  public static void BeginRequest(Quote q)
  {
    Guid companyLineGuid = q != null ? InspectionRequest.RequestCompanyLineGuid(q) : throw new ArgumentNullException(nameof (q));
    if (companyLineGuid.Equals(Guid.Empty))
      return;
    CompanyLine companyLine = new CompanyLine(companyLineGuid);
    QuoteDetail quoteDetail = new QuoteDetail(q.QuoteGuid, companyLineGuid);
    Form formEx;
    if (InspectionRequest.AlwaysEvaluateNetRate && quoteDetail.UsingNetRate || InspectionRequest.RequestAsNetRate)
      formEx = ObjectFactory.Instance.CreateFormEX(typeof (MGASystems.IMS.Policies.Inspections.NetRate.frmInspectionRequest), (object) quoteDetail.QuoteGuid, (object) companyLine.LineGuid);
    else
      formEx = ObjectFactory.Instance.CreateFormEX(typeof (MGASystems.IMS.Policies.Inspections.IMSBase.frmInspectionRequest), (object) quoteDetail.QuoteGuid, (object) companyLine.LineGuid);
    formEx.MdiParent = MDIControls.Instance.MDIParent;
    formEx.Show();
  }

  public static Guid RequestCompanyLineGuid(Quote q)
  {
    if (q == null)
      throw new ArgumentNullException(nameof (q));
    Guid guid1 = Guid.Empty;
    Guid guid2;
    if (q.IsPackagePolicy || q.IsMultiCompanyPolicy)
    {
      // ISSUE: variable of a compiler-generated type
      InspectionRequest._Closure\u0024__48\u002D0 closure480_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      InspectionRequest._Closure\u0024__48\u002D0 closure480_2 = new InspectionRequest._Closure\u0024__48\u002D0(closure480_1);
      IEnumerator<CompanyLine> enumerator;
      // ISSUE: reference to a compiler-generated field
      if (q.IsPackagePolicy && Guid.TryParse(MGASystems.Common.Settings.SystemSettings.GetSetting<string>("AutoSelectInspectionsDetailLine") ?? "", out closure480_2.\u0024VB\u0024Local_defaultLineGuid))
      {
        // ISSUE: reference to a compiler-generated field
        if (!closure480_2.\u0024VB\u0024Local_defaultLineGuid.Equals(Guid.Empty))
        {
          try
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            enumerator = q.CompanyLine.ChildLines.Where<CompanyLine>(closure480_2.\u0024I0 == null ? (closure480_2.\u0024I0 = new System.Func<CompanyLine, bool>(closure480_2._Lambda\u0024__0)) : closure480_2.\u0024I0).GetEnumerator();
            if (enumerator.MoveNext())
            {
              guid2 = enumerator.Current.CompanyLineGuid;
              goto label_17;
            }
          }
          finally
          {
            enumerator?.Dispose();
          }
        }
      }
      frmSelectQuoteDetail selectQuoteDetail = (frmSelectQuoteDetail) FormSettings.ShowFormDialog(typeof (frmSelectQuoteDetail), (object) q.QuoteGuid);
      MDIControls.Instance.MDIParent.Refresh();
      try
      {
        if (selectQuoteDetail.ItemSelected)
        {
          guid1 = selectQuoteDetail.CompanyLineGuid;
        }
        else
        {
          guid2 = Guid.Empty;
          goto label_17;
        }
      }
      finally
      {
        selectQuoteDetail.Dispose();
      }
    }
    else
      guid1 = q.CompanyLineGuid.Value;
    guid2 = guid1;
label_17:
    return guid2;
  }

  public static bool BlackBoxMode
  {
    get => InspectionRequest._blackBoxMode;
    set => InspectionRequest._blackBoxMode = value;
  }

  public string ClientCode
  {
    get => this._clientCode;
    set => this._clientCode = value;
  }

  [SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId = "Member")]
  public int InspectionCompanyID
  {
    get => this._inspectionCompanyID;
    set => this._inspectionCompanyID = value;
  }

  public Guid LineGuid
  {
    get => this._lineGuid;
    set => this._lineGuid = value;
  }

  [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
  public virtual List<string> EmailCC => (List<string>) null;

  public bool EmailInspections
  {
    get => this._emailInspections;
    set => this._emailInspections = value;
  }

  protected string InspectionRequestFileName => this._fileName;

  public static bool AlwaysEvaluateNetRate
  {
    get => InspectionRequest._alwaysSetNetRate;
    set => InspectionRequest._alwaysSetNetRate = value;
  }

  public static bool RequestAsNetRate
  {
    get => InspectionRequest._requestAsNetRate;
    set => InspectionRequest._requestAsNetRate = value;
  }

  public MGASystems.IMS.Policies.Inspections.NetRate.dsInspectionRequest NetRateDataset
  {
    get => this._netRateLocDataset;
    set => this._netRateLocDataset = value;
  }

  public object InspectionMethod
  {
    get => this._inspectionMethod;
    set => this._inspectionMethod = RuntimeHelpers.GetObjectValue(value);
  }

  public int RoofInspectionCompany
  {
    get => this._roofInspectionCompanyID;
    set => this._roofInspectionCompanyID = value;
  }

  public bool SendExlRequests(RRIRequest ds, int inspectionCompanyId)
  {
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      Exl exl = new Exl(ds, this._quote);
      if (!exl.ValidCredentials())
        return false;
      string reportValue = string.Empty;
      string supplementsValue = string.Empty;
      using (FormExlAdditionalInfo formEx = (FormExlAdditionalInfo) ObjectFactory.Instance.CreateFormEX(typeof (FormExlAdditionalInfo), (object) this._quote.QuoteGuid))
      {
        int num = (int) formEx.ShowDialog();
        if (formEx.NextClicked)
        {
          reportValue = formEx.Report;
          supplementsValue = formEx.Supplements;
        }
      }
      return exl.PostOrder(reportValue, supplementsValue);
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
  [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
  protected virtual bool TransmitRequest(RRIRequest ds, int inspectionCompanyId)
  {
    string str = $"{MGATempFolder.MGATempPath}Inspection_{this._quote.ControlNo.ToString()}.xml";
    int num1 = 0;
    bool flag;
    while (System.IO.File.Exists(str))
    {
      ++num1;
      try
      {
        System.IO.File.Delete(str);
        break;
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        if (num1 == 3)
        {
          int num2 = (int) MessageBox.Show("The system was unable to delete the prior inspection request for this control number.\n\nPlease ensure that this inspection request is not currently open in your email client or by another program.\n\n", "File In Use", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this._hasError = true;
          flag = false;
          ProjectData.ClearProjectError();
          goto label_15;
        }
        Thread.Sleep(3000);
        ProjectData.ClearProjectError();
      }
    }
    try
    {
      this.LogInspection(ds);
      ds.WriteXml(str);
      this.ModifyFileOnClient(str);
    }
    catch (UnauthorizedAccessException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this._hasError = true;
      int num3 = (int) MessageBox.Show($"The IMS was unable to create the following file due to insufficient user permissions:\n\n{str}\n\nPlease contact your system administrator to verify you have sufficient rights to this folder.", "Unable To Create File", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      flag = false;
      ProjectData.ClearProjectError();
      goto label_15;
    }
    this._fileName = str;
    string empty = string.Empty;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Email FROM tblFin_ExpensePayees WITH (NOLOCK) WHERE PayeeID= @PayeeID", new object[2]
    {
      (object) "@PayeeID",
      (object) inspectionCompanyId
    }));
    if (objectValue != null && objectValue != DBNull.Value)
      empty = objectValue.ToString();
    string inspectionCompanyName = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT PayeeName FROM tblFin_ExpensePayees WITH (NOLOCK) WHERE PayeeID=@IC", new object[2]
    {
      (object) "@IC",
      (object) inspectionCompanyId
    });
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(empty, string.Empty, false) == 0 && this.EmailInspections)
      throw new NoInspectionCompanyEmailException(inspectionCompanyName);
    string body = $"The attached is an XML inspection request for Control #{this._quote.ControlNo.ToString()}.";
    string subject = this.EmailSubject();
    Attachment[] attachments = new Attachment[1]
    {
      new Attachment(str)
    };
    CurrentUser.Instance.LogAction("Attempting to send inspection request(s) to " + inspectionCompanyName, this._quote.QuoteGuid);
    flag = this.SendInspectionEmail(empty, subject, body, attachments);
label_15:
    return flag;
  }

  protected virtual void LogInspection(RRIRequest ds)
  {
    string[] strArray = new string[1]
    {
      "MGASystems.IMS.Policies.Inspections.InspectionRequest"
    };
    Log.Write("Logging Inspection Request ...", strArray);
    Log.Write(ds.GetXml(), strArray);
    Log.Write("Inspection Successfully Requested and logged.", strArray);
  }

  private void FillNetRateLocationData(RRIRequest ds)
  {
    try
    {
      foreach (InspectionRequest.NetRateLocation netRateLocation in (List<InspectionRequest.NetRateLocation>) this._netRateLocations)
      {
        int uniqueId = netRateLocation.UniqueID;
        int locationId = netRateLocation.LocationID;
        RRIRequest.LocationRow locationRow1 = ds.Location.NewLocationRow();
        if (this._netRateLocations.Count == 0 || this._netRateLocations.Contains((object) uniqueId))
        {
          RRIRequest.LocationRow locationRow2 = locationRow1;
          locationRow2.Location_Address1 = InspectionRequest.EscapeXMLChars(netRateLocation.Address);
          locationRow2.Location_Address2 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(netRateLocation.Address2, string.Empty, false) == 0 ? string.Empty : InspectionRequest.EscapeXMLChars(netRateLocation.Address2);
          locationRow2.Location_City = InspectionRequest.EscapeXMLChars(netRateLocation.City);
          locationRow2.Location_State = netRateLocation.State;
          locationRow2.Location_Zipcode = netRateLocation.ZipCode;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(netRateLocation.ClassCode, string.Empty, false) != 0)
            locationRow2.Location_Description = netRateLocation.ClassCode;
          locationRow2.Location_Contact_Name = InspectionRequest.EscapeXMLChars(netRateLocation.ContactName);
          locationRow2.Location_Contact_Phone = netRateLocation.ContactPhone;
          locationRow2.Special_Instructions = InspectionRequest.EscapeXMLChars(netRateLocation.SpecialInstructions);
          locationRow2.Rush = this.SetNetRateRush(locationId);
          locationRow2.Due_Date = Strings.Format((object) this.GetInspectionDueDate(locationId), "yyyy-MM-dd");
          locationRow2.RequestRow = ds.Request[0];
          this.ModifyRequestRow(uniqueId, (DataRow) locationRow1.RequestRow);
          this.ModifyLocationRow(uniqueId, (DataRow) locationRow1, locationId);
          locationRow2.Customer_Reference_ID = this.GetCustomerReference(locationId);
          locationRow2.Location_Id = locationId;
          ds.Location.AddLocationRow(locationRow1);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(netRateLocation.SIC, string.Empty, false) != 0)
          {
            RRIRequest.SIC_CodesRow row = ds.SIC_Codes.NewSIC_CodesRow();
            row.SIC_Code = netRateLocation.SIC.ToString();
            ds.SIC_Codes.AddSIC_CodesRow(row);
            row.LocationRow = locationRow1;
          }
          this.AddNetRateReports(ds, locationRow1, uniqueId, locationId);
        }
      }
    }
    finally
    {
      List<InspectionRequest.NetRateLocation>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  protected virtual bool SetRunOnNetrateLocationData()
  {
    return !DefaultDatabase.ExecuteScalar<bool>("CompanyPriorInspection", new object[4]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid,
      (object) "@InspectionCompanyID",
      (object) this.InspectionCompanyID
    }) && this._quote.EffectiveDate.AddDays(60.0).Subtract(DateAndTime.Now).Days < 30;
  }

  private bool SetNetRateRush(int locationID)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Rush FROM tblInspectionsNetRateLocData WITH (NOLOCK) WHERE LocationID = @L", new object[2]
    {
      (object) "@L",
      (object) locationID
    }));
    return !Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) && Conversions.ToBoolean(objectValue);
  }

  private bool SendUsingNetRate()
  {
    RRIRequest ds = new RRIRequest();
    this.AddClientColumn((DataTable) ds.Location);
    this.FillNetRateRequest(ds);
    bool flag;
    try
    {
      this.FillNetRateLocationData(ds);
    }
    catch (UnratedPolicyException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this.ShowErrorMessage(ex.Message, "Unable To Find Location Data");
      flag = false;
      ProjectData.ClearProjectError();
      goto label_4;
    }
    int inspectionCompanyId = this.InspectionCompanyID;
    int num = this.TransmitRequest(ds, inspectionCompanyId) ? 1 : 0;
    this._netRateInpections = ds;
    flag = num != 0;
label_4:
    return flag;
  }

  protected virtual string GetClientCode(int inspectionCompanyID, int underwritingLocationID)
  {
    string empty = string.Empty;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetInspectionClientCode(@quoteID, @inspectionCompanyID)", new object[4]
    {
      (object) "@quoteID",
      (object) this._quote.QuoteID,
      (object) "@inspectionCompanyID",
      (object) inspectionCompanyID
    }));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
      empty = objectValue.ToString();
    return !empty.Equals(string.Empty) ? empty : throw new InspectionClientCodeNotFoundException();
  }

  protected virtual string GetNetRateClientCode() => this.ClientCode;

  private void FillNetRateRequest(RRIRequest ds)
  {
    InsuredLocation insuredLocation = this._quote.SubmissionGroup.InsuredLocation;
    RRIRequest.RequestRow requestRow1 = ds.Request.NewRequestRow();
    this.FillCommonPolicyInformation(requestRow1, insuredLocation);
    RRIRequest.RequestRow requestRow2 = requestRow1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ClientCode, string.Empty, false) == 0)
      throw new InspectionClientCodeNotFoundException();
    requestRow2.Client_Code = this.GetNetRateClientCode();
    this.GetNetRateInspectionContactsAndPhone(requestRow1);
    ds.Request.AddRequestRow(requestRow1);
  }

  protected virtual void GetNetRateInspectionContactsAndPhone(RRIRequest.RequestRow drRequest)
  {
    dsInspectionContacts inspectionContacts = new dsInspectionContacts();
    new string[1][0] = "dt";
    DefaultDatabase.LoadDataSet((DataSet) inspectionContacts, new string[1]
    {
      "dt"
    }, "GetInspectionContacts", new object[4]
    {
      (object) "@InsuredLocationGUID",
      (object) this._quote.SubmissionGroup.InsuredLocationGuid,
      (object) "@underwritingLocationID",
      (object) int.MinValue
    });
    if (inspectionContacts.dt.Count > 0)
    {
      if (!inspectionContacts.dt[0].IsFullNameNull())
        drRequest.Insured_Contact_Name = InspectionRequest.EscapeXMLChars(inspectionContacts.dt[0].FullName);
      if (!inspectionContacts.dt[0].IsPhoneNull())
        drRequest.Insured_Contact_Phone = inspectionContacts.dt[0].Phone;
      else
        this.MissingInspectionContactPhone(drRequest);
    }
    else
      this.MissingInspectionContact(drRequest);
  }

  public static bool HasLocationRoofInspect(int locationID)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT RoofInspect FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID = @ID", new object[2]
    {
      (object) "@ID",
      (object) locationID
    });
    return !dataRow.IsNull("RoofInspect") && Conversions.ToBoolean(dataRow["RoofInspect"]);
  }

  public static int LocationRoofInspectCompany(int locationID)
  {
    int num = -1;
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT RoofInspectionCompanyID FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID = @ID", new object[2]
    {
      (object) "@ID",
      (object) locationID
    });
    return dataRow.IsNull("RoofInspectionCompanyID") ? num : Conversions.ToInteger(dataRow["RoofInspectionCompanyID"]);
  }

  private bool CreateRequest(List<UnderwritingLocation> locations, int inspectionCompanyID)
  {
    RRIRequest ds = new RRIRequest();
    UnderwritingLocation ul = new UnderwritingLocation(this._baseInspectionCompLocations[0].Location);
    this.InspectionCompanyID = inspectionCompanyID;
    this.RoofInspectionCompany = -1;
    try
    {
      foreach (LocationInspectionCompany inspectionCompLocation in this._baseInspectionCompLocations)
      {
        if (inspectionCompLocation.Location == ul.LocationID && inspectionCompLocation.InspectionCompany == inspectionCompanyID && inspectionCompLocation.Roof)
          this.RoofInspectionCompany = inspectionCompanyID;
      }
    }
    finally
    {
      List<LocationInspectionCompany>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.AddBaseClientColumn((DataTable) ds.Location);
    this.FillRequest(ds, ul, inspectionCompanyID);
    try
    {
      foreach (LocationInspectionCompany inspectionCompLocation in this._baseInspectionCompLocations)
        this.FillLocationData(ds, inspectionCompLocation.Location, inspectionCompanyID);
    }
    finally
    {
      List<LocationInspectionCompany>.Enumerator enumerator;
      enumerator.Dispose();
    }
    int inspectionCompanyId = this.RoofInspectionCompany != -1 ? this.RoofInspectionCompany : this.InspectionCompanyID;
    this._baseInspections = ds;
    return this.TransmitRequest(ds, inspectionCompanyId);
  }

  protected virtual int AssignInspectionCompany(UnderwritingLocation loc)
  {
    return loc.InspectionCompanyID;
  }

  protected virtual int AssignRoofingInspectionCompany(UnderwritingLocation loc)
  {
    return InspectionRequest.LocationRoofInspectCompany(loc.LocationID);
  }

  protected virtual string PolicyLineOfBusiness()
  {
    return DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT LineName FROM lstLines WHERE LineGuid=@LineGuid", new object[2]
    {
      (object) "@LineGuid",
      (object) this.LineGuid
    });
  }

  private void FillCommonPolicyInformation(RRIRequest.RequestRow dr, InsuredLocation il)
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string empty3 = string.Empty;
    string empty4 = string.Empty;
    string empty5 = string.Empty;
    string empty6 = string.Empty;
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
        empty6 = dataRow["InsuredDBA"].ToString();
    }
    RRIRequest.RequestRow requestRow = dr;
    requestRow.Line_of_Business = this.PolicyLineOfBusiness();
    requestRow.Policy_Number = this._quote.PolicyNumber;
    requestRow.Request_Date = Strings.Format((object) DateAndTime.Now, "yyyy-MM-dd");
    requestRow.Requestor_Name = $"{CurrentUser.Instance.FirstName} {CurrentUser.Instance.LastName}";
    requestRow.Insured_Name1 = InspectionRequest.EscapeXMLChars(this._quote.InsuredPolicyName);
    requestRow.Insured_Name2 = InspectionRequest.EscapeXMLChars(empty6);
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
    this.SetAgentContactPhone(dr);
  }

  private void FillRequest(RRIRequest ds, UnderwritingLocation ul, int inspectionCompanyID)
  {
    InsuredLocation insuredLocation = this._quote.SubmissionGroup.InsuredLocation;
    RRIRequest.RequestRow requestRow1 = ds.Request.NewRequestRow();
    this.FillCommonPolicyInformation(requestRow1, insuredLocation);
    RRIRequest.RequestRow requestRow2 = requestRow1;
    requestRow2.Client_Code = this.GetClientCode(inspectionCompanyID, ul.LocationID);
    dsInspectionContacts inspectionContacts = new dsInspectionContacts();
    new string[1][0] = "dt";
    DefaultDatabase.LoadDataSet((DataSet) inspectionContacts, new string[1]
    {
      "dt"
    }, "GetInspectionContacts", new object[4]
    {
      (object) "@InsuredLocationGUID",
      (object) this._quote.SubmissionGroup.InsuredLocationGuid,
      (object) "@underwritingLocationID",
      (object) ul.LocationID
    });
    if (inspectionContacts.dt.Count > 0)
    {
      if (!inspectionContacts.dt[0].IsFullNameNull())
        requestRow2.Insured_Contact_Name = InspectionRequest.EscapeXMLChars(inspectionContacts.dt[0].FullName);
      requestRow2.Insured_Contact_Phone = inspectionContacts.dt[0].IsPhoneNull() ? string.Empty : inspectionContacts.dt[0].Phone;
    }
    else
      this.MissingInspectionContactException(requestRow1);
    ds.Request.AddRequestRow(requestRow1);
  }

  protected virtual void MissingInspectionContactException(RRIRequest.RequestRow row)
  {
    throw new InspectionContactNotFoundException();
  }

  protected virtual void SetAgentContactPhone(RRIRequest.RequestRow dr)
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
      throw new ProducerPhoneNotFoundException();
    }
  }

  public static string EscapeXMLChars(string st)
  {
    string s = st.Replace("–", string.Empty);
    return Encoding.ASCII.GetString(Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding(Encoding.ASCII.EncodingName, (EncoderFallback) new EncoderReplacementFallback(string.Empty), (DecoderFallback) new DecoderExceptionFallback()), Encoding.UTF8.GetBytes(s)));
  }

  protected virtual string GetUnderwritingLocInspectInfoProcName()
  {
    return "dbo.GetUnderwritingLocationInspectionInfo";
  }

  private void FillLocationData(RRIRequest ds, int underWritingLocationID, int inspectionCompanyID)
  {
    this._currentBaseLocationID = underWritingLocationID;
    bool isRoofInspection = false;
    if (!InspectionRequest.BlackBoxMode)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.BaseInspectionGrid).Rows)
      {
        if (Conversions.ToInteger(row.Cells["LocationID"].Value) == underWritingLocationID && Conversions.ToInteger(row.Cells["InspectionCompanyID"].Value) == inspectionCompanyID && row.Cells["Roof"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["Roof"].Value))
        {
          isRoofInspection = true;
          break;
        }
      }
    }
    else
    {
      isRoofInspection = false;
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ISNULL(RoofInspect, 0) FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID = @ID", new object[2]
      {
        (object) "@ID",
        (object) underWritingLocationID
      }));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
        isRoofInspection = Conversions.ToBoolean(objectValue);
    }
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string empty3 = string.Empty;
    if (isRoofInspection)
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT RoofInspectionContactPhone, RoofInspectionContact, RoofComments FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID = @ID", new object[3]
      {
        (object) "SELECT RoofInspectionContactPhone, RoofInspectionContact, RoofComments FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID = @ID",
        (object) "@ID",
        (object) underWritingLocationID
      });
      if (!dataRow.IsNull("RoofInspectionContact"))
        empty1 = dataRow["RoofInspectionContact"].ToString();
      if (!dataRow.IsNull("RoofInspectionContactPhone"))
        empty2 = dataRow["RoofInspectionContactPhone"].ToString();
      if (!dataRow.IsNull("RoofComments"))
        empty3 = dataRow["RoofComments"].ToString();
    }
    RRIRequest.LocationRow locationRow1 = ds.Location.NewLocationRow();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(this.GetUnderwritingLocInspectInfoProcName(), new object[4]
    {
      (object) "@underwritingLocationID",
      (object) underWritingLocationID,
      (object) "@OmitLocationBuildingNos",
      (object) this.OmitLocationAndBuildingNumbers()
    });
    if (dataTable.Rows.Count == 0)
      throw new NoLocationClassCodeException();
    DataRow row1 = dataTable.Rows[0];
    RRIRequest.LocationRow locationRow2 = locationRow1;
    locationRow2.Location_Address1 = InspectionRequest.EscapeXMLChars(row1["Address1"].ToString());
    locationRow2.Location_Address2 = InspectionRequest.EscapeXMLChars(row1["Address2"].ToString());
    locationRow2.Location_City = InspectionRequest.EscapeXMLChars(row1["City"].ToString());
    locationRow2.Location_State = row1["State"].ToString();
    locationRow2.Location_Zipcode = row1["Zip"].ToString();
    locationRow2.Location_Description = row1["ClassCode"].ToString();
    if (!isRoofInspection)
    {
      locationRow2.Location_Contact_Name = InspectionRequest.EscapeXMLChars(row1["InspectionContact"].ToString());
      locationRow2.Location_Contact_Phone = row1["InspectionContactPhone"].ToString();
      locationRow2.Special_Instructions = InspectionRequest.EscapeXMLChars(row1["Comments"].ToString());
    }
    else
    {
      locationRow2.Location_Contact_Name = InspectionRequest.EscapeXMLChars(empty1);
      locationRow2.Location_Contact_Phone = empty2;
      locationRow2.Special_Instructions = InspectionRequest.EscapeXMLChars(empty3);
    }
    locationRow2.Rush = this.SetRushOnLocationData(underWritingLocationID);
    locationRow2.Due_Date = Strings.Format((object) this.GetInspectionDueDate(underWritingLocationID), "yyyy-MM-dd");
    locationRow2.Customer_Reference_ID = this.GetCustomerReference(underWritingLocationID);
    locationRow2.RequestRow = ds.Request[0];
    locationRow2.Location_Id = underWritingLocationID;
    this.AddLocationNumber(locationRow1, underWritingLocationID);
    this.ModifyBaseRequestRow((DataRow) ds.Request[0]);
    this.ModifyBaseLocationRow((DataRow) locationRow1, underWritingLocationID);
    ds.Location.AddLocationRow(locationRow1);
    RRIRequest.SIC_CodesRow row2 = ds.SIC_Codes.NewSIC_CodesRow();
    row2.SIC_Code = row1["SIC_Code"].ToString();
    ds.SIC_Codes.AddSIC_CodesRow(row2);
    row2.LocationRow = locationRow1;
    this.AddReports(ds, locationRow1, underWritingLocationID, isRoofInspection);
    this.AddBaseClientData(locationRow1, this.BaseInspectionGrid);
    this.AddClientReports(ds, locationRow1, underWritingLocationID);
  }

  private void AddLocationNumber(RRIRequest.LocationRow row, int underWritingLocationID)
  {
    object objectValue1 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT LocationLookup FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID = @L", new object[2]
    {
      (object) "@L",
      (object) underWritingLocationID
    }));
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)) || !Conversions.ToBoolean(objectValue1))
      return;
    object objectValue2 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 BaseLocationId FROM tblUnderwritingLocationsLookup WITH (NOLOCK) WHERE LocationId = @L", new object[2]
    {
      (object) "@L",
      (object) underWritingLocationID
    }));
    if (!row.Table.Columns.Contains("LocationID"))
      row.Table.Columns.Add("LocationID", typeof (int));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
      row["LocationID"] = (object) Conversions.ToInteger(objectValue2);
    else
      row["LocationID"] = (object) underWritingLocationID;
  }

  protected virtual void AddClientReports(
    RRIRequest ds,
    RRIRequest.LocationRow drLocation,
    int underWritingLocationID)
  {
  }

  protected virtual string GetCustomerReference(int underWritingLocationID)
  {
    return this._quote.ControlNo.ToString();
  }

  protected virtual bool SetRushOnLocationData()
  {
    bool flag;
    if (DefaultDatabase.ExecuteScalar<bool>("CompanyPriorInspection", new object[4]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid,
      (object) "@InspectionCompanyID",
      (object) this.InspectionCompanyID
    }))
    {
      flag = false;
    }
    else
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Rush FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID = @LI", new object[2]
      {
        (object) "@LI",
        (object) this._currentBaseLocationID
      }));
      flag = !Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) && Conversions.ToBoolean(objectValue) || this._quote.EffectiveDate.AddDays(60.0).Subtract(DateAndTime.Now).Days < 30;
    }
    return flag;
  }

  protected virtual bool SetRushOnLocationData(int LocationID) => this.SetRushOnLocationData();

  private void AddNetRateReports(
    RRIRequest ds,
    RRIRequest.LocationRow drLocation,
    int uniqueID,
    int netRateLocationID)
  {
    if (this.IsPropertyLine(this.LineGuid))
      this.AddNetRatePropertyReports(ds, drLocation, uniqueID, netRateLocationID);
    else if (this.IsGLLine(this.LineGuid))
      this.AddNetRateGeneralLiabilityReports(ds, drLocation, uniqueID, netRateLocationID);
    else if (this.IsAutoLine(this.LineGuid))
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT VersionLCM AS Class, GKCollisionLimit AS Exposure FROM NetRate_Quote_Insur_Quote_Locat_Busin WHERE BusinessAutoID = @BusinessAutoID", new object[2]
      {
        (object) "@BusinessAutoID",
        (object) uniqueID
      });
      try
      {
        foreach (DataRow row1 in dataTable.Rows)
        {
          RRIRequest.ReportsRow row2 = ds.Reports.NewReportsRow();
          row2.Item_Name = string.Empty;
          row2.Value = string.Empty;
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["Class"])))
            row2.Item_Name = row1["Class"].ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["Exposure"])))
            row2.Value = row1["Exposure"].ToString();
          row2.LocationRow = drLocation;
          ds.Reports.AddReportsRow(row2);
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
      if (!this.IsWorkersCompLine(this.LineGuid))
        throw new UnexpectedLineOfBusinessException();
      this.AddNetRateWorkersCompReports(ds, drLocation, uniqueID, netRateLocationID);
    }
    if (this._reports == null)
      return;
    bool flag = false;
    InspectionRequest.Report report1;
    try
    {
      foreach (InspectionRequest.Report report2 in this._reports)
      {
        if (report2.NetRateLocationID == netRateLocationID)
        {
          report1 = report2;
          flag = true;
          break;
        }
      }
    }
    finally
    {
      List<InspectionRequest.Report>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (!flag)
      throw new InvalidOperationException("Could not find the report for this NetRate location");
    if (report1.CostEstimator)
    {
      RRIRequest.ReportsRow row = ds.Reports.NewReportsRow();
      row.Item_Name = "ITV";
      row.Value = string.Empty;
      row.LocationRow = drLocation;
      ds.Reports.AddReportsRow(row);
    }
    if (report1.Photo)
    {
      RRIRequest.ReportsRow row = ds.Reports.NewReportsRow();
      row.Item_Name = "Photo";
      row.Value = string.Empty;
      row.LocationRow = drLocation;
      ds.Reports.AddReportsRow(row);
    }
    if (report1.Diagram)
    {
      RRIRequest.ReportsRow row = ds.Reports.NewReportsRow();
      row.Item_Name = "Diagram";
      row.Value = string.Empty;
      row.LocationRow = drLocation;
      ds.Reports.AddReportsRow(row);
    }
    this.ModifyReports(ds, drLocation);
    this.ModifyReports(ds, drLocation, uniqueID);
  }

  protected virtual void AddNetRateGeneralLiabilityReports(
    RRIRequest ds,
    RRIRequest.LocationRow drLocation,
    int uniqueID,
    int netRateLocationID)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT Description AS Class, Exposure FROM NetRate_Quote_Insur_Quote_Locat_Liabi WHERE LocationID = @LocationID", new object[2]
    {
      (object) "@LocationID",
      (object) uniqueID
    });
    try
    {
      foreach (DataRow row1 in dataTable.Rows)
      {
        RRIRequest.ReportsRow row2 = ds.Reports.NewReportsRow();
        row2.Item_Name = string.Empty;
        row2.Value = string.Empty;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["Class"])))
          row2.Item_Name = row1["Class"].ToString();
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["Exposure"])))
          row2.Value = row1["Exposure"].ToString();
        row2.LocationRow = drLocation;
        ds.Reports.AddReportsRow(row2);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  protected virtual void AddNetRateWorkersCompReports(
    RRIRequest ds,
    RRIRequest.LocationRow drLocation,
    int uniqueID,
    int netRateLocationID)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, " SELECT Code AS Class, Payroll AS Exposure   FROM NetRate_Quote_Insur_Quote_Locat_Worke_Expos  WHERE WorkersCompID = @WorkersCompID", new object[2]
    {
      (object) "@WorkersCompID",
      (object) uniqueID
    });
    try
    {
      foreach (DataRow row1 in dataTable.Rows)
      {
        RRIRequest.ReportsRow row2 = ds.Reports.NewReportsRow();
        row2.Item_Name = string.Empty;
        row2.Value = string.Empty;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["Class"])))
          row2.Item_Name = row1["Class"].ToString();
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["Exposure"])))
          row2.Value = row1["Exposure"].ToString();
        row2.LocationRow = drLocation;
        ds.Reports.AddReportsRow(row2);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  protected virtual void AddNetRatePropertyReports(
    RRIRequest ds,
    RRIRequest.LocationRow drLocation,
    int uniqueID,
    int netRateLocationID)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT PropertyExposure, BuildingExposure, BusinessIncomeExposure FROM NetRate_Quote_Insur_Quote_Locat_Premi WHERE PremisesID=@ID", new object[2]
    {
      (object) "@ID",
      (object) uniqueID
    });
    if (dataRow["BuildingExposure"] != DBNull.Value)
    {
      RRIRequest.ReportsRow row = ds.Reports.NewReportsRow();
      row.Item_Name = "Real Property";
      row.Value = Strings.FormatCurrency(RuntimeHelpers.GetObjectValue(dataRow["BuildingExposure"]));
      row.LocationRow = drLocation;
      ds.Reports.AddReportsRow(row);
    }
    if (dataRow["PropertyExposure"] != DBNull.Value)
    {
      RRIRequest.ReportsRow row = ds.Reports.NewReportsRow();
      row.Item_Name = "Personal Property";
      row.Value = Strings.FormatCurrency(RuntimeHelpers.GetObjectValue(dataRow["PropertyExposure"]));
      row.LocationRow = drLocation;
      ds.Reports.AddReportsRow(row);
    }
    if (dataRow["BusinessIncomeExposure"] == DBNull.Value)
      return;
    RRIRequest.ReportsRow row1 = ds.Reports.NewReportsRow();
    row1.Item_Name = "Business Income";
    row1.Value = Strings.FormatCurrency(RuntimeHelpers.GetObjectValue(dataRow["BusinessIncomeExposure"]));
    row1.LocationRow = drLocation;
    ds.Reports.AddReportsRow(row1);
  }

  protected virtual string GetPropertyInspectionInfoSql() => "dbo.PropertyInspectionInfo";

  protected virtual string GetGlPropertyInspectionInfoSql()
  {
    return "SELECT CC.ClassCodeDescription + @O + CONVERT(VARCHAR(100),CC.ClassCode) + @C AS ClassCode, Exposure FROM tblGLExposures GLE INNER JOIN lstClassCodes CC ON GLE.ClassCodeID = CC.ClassCodeID WHERE LocationID=@LocationID";
  }

  protected virtual string GetWorkersCompInspectionInfoSql() => "dbo.WorkersCompInspectionInfo";

  private void AddReports(
    RRIRequest ds,
    RRIRequest.LocationRow drLocation,
    int underWritingLocationID,
    bool isRoofInspection)
  {
    Guid guid = !this._lineGuid.Equals(Guid.Empty) ? this._lineGuid : this._quote.LineGuid;
    if (this.IsPropertyLine(guid))
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(this.GetPropertyInspectionInfoSql(), new object[2]
      {
        (object) "@underwritingLocationID",
        (object) underWritingLocationID
      });
      try
      {
        foreach (DataRow row1 in dataTable.Rows)
        {
          RRIRequest.ReportsRow row2 = ds.Reports.NewReportsRow();
          row2.Item_Name = InspectionRequest.EscapeXMLChars(row1[0].ToString());
          row2.Value = Strings.FormatCurrency(RuntimeHelpers.GetObjectValue(row1[1]));
          row2.LocationRow = drLocation;
          ds.Reports.AddReportsRow(row2);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else if (this.IsGLLine(guid))
    {
      try
      {
        foreach (DataRow row3 in DefaultDatabase.ExecuteDataTable(CommandType.Text, this.GetGlPropertyInspectionInfoSql(), new object[6]
        {
          (object) "@LocationID",
          (object) underWritingLocationID,
          (object) "@O",
          (object) " (",
          (object) "@C",
          (object) ")"
        }).Rows)
        {
          RRIRequest.ReportsRow row4 = ds.Reports.NewReportsRow();
          row4.Item_Name = row3["ClassCode"].ToString();
          row4.Value = row3["Exposure"].ToString();
          row4.LocationRow = drLocation;
          ds.Reports.AddReportsRow(row4);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else if (this.IsWorkersCompLine(guid))
    {
      try
      {
        foreach (DataRow row5 in DefaultDatabase.ExecuteDataTable(this.GetWorkersCompInspectionInfoSql(), new object[2]
        {
          (object) "@QuoteID",
          (object) this._quote.QuoteID
        }).Rows)
        {
          RRIRequest.ReportsRow row6 = ds.Reports.NewReportsRow();
          row6.Item_Name = row5["ClassCode"].ToString();
          row6.Value = row5["Exposure"].ToString();
          row6.LocationRow = drLocation;
          ds.Reports.AddReportsRow(row6);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else if (this.IsAutoLine(this.LineGuid))
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT C.ClassCode AS Class, NULL AS Exposure FROM tblUnderwritingLocations AS UL INNER JOIN lstClassCodes AS C ON UL.ClassCodeID = C.ClassCodeID WHERE  UL.LocationID = @LID", new object[2]
      {
        (object) "@LID",
        (object) underWritingLocationID
      });
      try
      {
        foreach (DataRow row7 in dataTable.Rows)
        {
          RRIRequest.ReportsRow row8 = ds.Reports.NewReportsRow();
          row8.Item_Name = string.Empty;
          row8.Value = string.Empty;
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row7["Class"])))
            row8.Item_Name = row7["Class"].ToString();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row7["Exposure"])))
            row8.Value = row7["Exposure"].ToString();
          row8.LocationRow = drLocation;
          ds.Reports.AddReportsRow(row8);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else if (!this.OtherClientLine(guid, ds, drLocation, underWritingLocationID))
      throw new UnexpectedLineOfBusinessException();
    DataRow inspectionLocationReport = this.GetInspectionLocationReport(underWritingLocationID);
    if (inspectionLocationReport == null)
    {
      int num1 = (int) MessageBox.Show("There are no UnderwritingLocations for ID: " + Conversions.ToString(underWritingLocationID), "No UnderWritingLocations", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else
    {
      int num2 = Conversions.ToBoolean(inspectionLocationReport[0]) ? 1 : 0;
      bool flag = Conversions.ToBoolean(inspectionLocationReport[1]);
      bool boolean1 = Conversions.ToBoolean(inspectionLocationReport[2]);
      bool boolean2 = Conversions.ToBoolean(inspectionLocationReport[3]);
      if (num2 != 0)
      {
        RRIRequest.ReportsRow row = ds.Reports.NewReportsRow();
        row.Item_Name = "ITV";
        row.Value = string.Empty;
        row.LocationRow = drLocation;
        ds.Reports.AddReportsRow(row);
      }
      if (isRoofInspection)
      {
        flag = false;
        object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT RoofPhoto FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID = @ID", new object[2]
        {
          (object) "@ID",
          (object) underWritingLocationID
        }));
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
          flag = Conversions.ToBoolean(objectValue);
      }
      if (flag)
      {
        RRIRequest.ReportsRow row = ds.Reports.NewReportsRow();
        row.Item_Name = "Photo";
        row.Value = string.Empty;
        row.LocationRow = drLocation;
        ds.Reports.AddReportsRow(row);
      }
      if (boolean1)
      {
        RRIRequest.ReportsRow row = ds.Reports.NewReportsRow();
        row.Item_Name = "Diagram";
        row.Value = string.Empty;
        row.LocationRow = drLocation;
        ds.Reports.AddReportsRow(row);
      }
      if (!boolean2)
        return;
      RRIRequest.ReportsRow row9 = ds.Reports.NewReportsRow();
      row9.Item_Name = "RecCheck";
      row9.Value = string.Empty;
      row9.LocationRow = drLocation;
      ds.Reports.AddReportsRow(row9);
    }
  }

  protected virtual DataRow GetInspectionLocationReport(int underWritingLocationID)
  {
    return DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT CostEstimator, Photo, Diagram, RecCheck FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID=@LocationID", new object[2]
    {
      (object) "@LocationID",
      (object) underWritingLocationID
    });
  }

  protected virtual DateTime GetInspectionDueDate(int locationID)
  {
    DateTime inspectionDueDate;
    if (!this._quote.UsingNetRate)
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow("GetInspectionDueDateVariables", new object[2]
      {
        (object) "@LocationID",
        (object) locationID
      });
      if (dataRow != null)
      {
        if (dataRow[2] != DBNull.Value)
        {
          inspectionDueDate = Conversions.ToDate(dataRow[2]);
          goto label_11;
        }
        if (dataRow[0] != DBNull.Value && Conversions.ToBoolean(dataRow[0]))
        {
          inspectionDueDate = CurrentUser.ServerTime.AddDays(10.0);
          goto label_11;
        }
        if (dataRow[1] != DBNull.Value && Conversions.ToBoolean(dataRow[1]))
        {
          inspectionDueDate = CurrentUser.ServerTime.AddDays(15.0);
          goto label_11;
        }
      }
    }
    else
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("GetInspectionDueDateViaNetRate", new object[2]
      {
        (object) "@LocationID",
        (object) locationID
      }));
      if (objectValue != null && objectValue != DBNull.Value)
      {
        inspectionDueDate = Conversions.ToDate(objectValue);
        goto label_11;
      }
    }
    DateTime dateTime = this._quote.EffectiveDate;
    dateTime = dateTime.AddDays(60.0);
    int days = dateTime.Subtract(CurrentUser.ServerTime).Days;
    inspectionDueDate = days < 30 ? (days >= 15 ? CurrentUser.ServerTime.AddDays(10.0) : CurrentUser.ServerTime) : CurrentUser.ServerTime.AddDays(30.0);
label_11:
    return inspectionDueDate;
  }

  private List<string> ConvertFromAttachments(Attachment[] attachments)
  {
    List<string> stringList = new List<string>();
    Attachment[] attachmentArray = attachments;
    int index = 0;
    while (index < attachmentArray.Length)
    {
      Attachment attachment = attachmentArray[index];
      if (attachment.ContentStream is FileStream)
        stringList.Add(((FileStream) attachment.ContentStream).Name);
      checked { ++index; }
    }
    return stringList;
  }

  protected virtual bool UsingNetRateData(Guid quoteGuid, Guid companyLineGuid)
  {
    QuoteDetail quoteDetail = new QuoteDetail(quoteGuid, companyLineGuid);
    return InspectionRequest.AlwaysEvaluateNetRate && quoteDetail.UsingNetRate;
  }

  protected virtual void ModifyFileOnClient(string fileName)
  {
  }

  protected virtual void ModifyReports(RRIRequest ds, RRIRequest.LocationRow drLocation)
  {
  }

  protected virtual void ModifyReports(
    RRIRequest ds,
    RRIRequest.LocationRow drLocation,
    int uniqueID)
  {
  }

  protected virtual bool SendInspectionEmail(
    string inspectionEmail,
    string subject,
    string body,
    Attachment[] attachments)
  {
    int num = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OnlyUseExchangeToSendInspectionEmails") ? 1 : 0;
    bool setting = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OnlyUseOutlookToSendInspectionEmails");
    bool flag = false;
    UserEmail userEmail = CurrentUser.Instance.GetUserEmail();
    if (num != 0)
      flag = UsingExchange.SendMailUsingExchange(inspectionEmail, userEmail.Address, subject, body, userEmail.Domain, this.ConvertFromAttachments(attachments), this.EmailCC);
    else if (setting && CurrentUser.UsingOutlook)
    {
      flag = SMTP_Email.SendUsingOutlook(this.ConvertFromAttachments(attachments), new List<string>((IEnumerable<string>) new string[1]
      {
        inspectionEmail
      }), subject, body, this.EmailCC, SMTP_Email.ShowOrSend.Send, false);
    }
    else
    {
      try
      {
        if (string.IsNullOrEmpty(userEmail.Domain))
        {
          SMTP_Email.SuppressDialog = true;
          flag = SMTP_Email.SendMail(inspectionEmail, userEmail.Address, this.EmailCC, subject, body, attachments, true);
          SMTP_Email.SuppressDialog = false;
        }
        else
          flag = UsingExchange.SendMailUsingExchange(inspectionEmail, userEmail.Address, subject, body, userEmail.Domain, this.ConvertFromAttachments(attachments), this.EmailCC);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (!flag && CurrentUser.UsingOutlook)
        flag = SMTP_Email.SendUsingOutlook(this.ConvertFromAttachments(attachments), new List<string>((IEnumerable<string>) new string[1]
        {
          inspectionEmail
        }), subject, body, this.EmailCC, SMTP_Email.ShowOrSend.Send, false);
    }
    if (flag)
      CurrentUser.Instance.LogAction($"Control #{this._quote.ControlNo.ToString()}.  Successfully sent email to inspection company - {InspectionRequest.GetInspectionCompany(this.InspectionCompanyID)}", this._quote.QuoteGuid);
    else
      CurrentUser.Instance.LogAction($"Control #{this._quote.ControlNo.ToString()}.  Unsuccessful attempt to send email to inspection company - {InspectionRequest.GetInspectionCompany(this.InspectionCompanyID)}", this._quote.QuoteGuid);
    return flag;
  }

  protected virtual void AddClientColumn(DataTable dt)
  {
  }

  protected virtual string EmailSubject() => "Inspection Request";

  protected virtual void MissingInspectionContactPhone(RRIRequest.RequestRow drRequest)
  {
    throw new InspectionContactMissingPhone();
  }

  protected virtual void MissingInspectionContact(RRIRequest.RequestRow drRequest)
  {
    throw new InspectionContactNotFoundException();
  }

  protected virtual void AddBaseClientColumn(DataTable dt)
  {
  }

  protected virtual void ModifyRequestRow(int uniqueId, DataRow row)
  {
  }

  protected virtual void ModifyLocationRow(int uniqueId, DataRow row, int locationID)
  {
  }

  protected virtual void ModifyBaseRequestRow(DataRow row)
  {
  }

  protected virtual void ModifyBaseLocationRow(DataRow row, int underwritingLocationID)
  {
  }

  public virtual bool IsPropertyLine(Guid lineguid)
  {
    throw new InvalidOperationException("Client must override IsPropertyLine");
  }

  protected virtual bool IsGLLine(Guid lineguid)
  {
    throw new InvalidOperationException("Client must override IsGLLine");
  }

  public virtual bool IsAutoLine(Guid lineGuid)
  {
    Guid g = new Guid("ec495345-fe6a-415a-8eb9-eaea95ca3829");
    return lineGuid.Equals(g);
  }

  public virtual bool IsWorkersCompLine(Guid lineGuid)
  {
    Guid g = new Guid("c57fafa8-9561-4836-9271-72ac0872d91f");
    return lineGuid.Equals(g);
  }

  protected virtual void AddClientData(InspectionRequest.NetRateLocation loc, UltraGrid dr)
  {
  }

  protected virtual bool OtherClientLine(
    Guid lineGuid,
    RRIRequest ds,
    RRIRequest.LocationRow drLocation,
    int underWritingLocationID)
  {
    return false;
  }

  protected virtual void AddReliableColumns(dsRequest ds)
  {
  }

  protected virtual void MassageReliableColumns(dsRequest ds)
  {
  }

  protected virtual bool SendUsingReliable(RRIRequest dsRegional)
  {
    this._reliableReturnGuid = string.Empty;
    dsRequest dsRequest = new dsRequest();
    this.AddReliableColumns(dsRequest);
    try
    {
      foreach (DataTable table in (InternalDataCollectionBase) dsRegional.Tables)
      {
        try
        {
          foreach (DataRow row1 in table.Rows)
          {
            DataRow row2 = dsRequest.Tables[table.TableName].NewRow();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.TableName, "Request", false) == 0)
            {
              if (this._quote.HasRetailer)
              {
                row2["Retailer_Contact_Name"] = (object) this._quote.Retailer.LocationName;
                row2["Retailer_Contact_Phone"] = (object) this._quote.Retailer.Phone;
              }
              else
              {
                row2["Retailer_Contact_Name"] = (object) string.Empty;
                row2["Retailer_Contact_Phone"] = (object) string.Empty;
              }
              row2["Control_Number"] = (object) this._quote.ControlNo;
              row2["LineOfCoverage"] = (object) this.FormatLOB();
              row2["Unit_Cost"] = (object) "0";
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.TableName, "Location", false) == 0)
            {
              row2["IsCostReq"] = (object) false;
              row2["IsPhotoReq"] = (object) false;
              row2["IsDiagramReq"] = (object) false;
              RRIRequest.ReportsRow[] reportsRows = ((RRIRequest.LocationRow) row1).GetReportsRows();
              int index = 0;
              while (index < reportsRows.Length)
              {
                string Left = reportsRows[index]["Item_Name"].ToString();
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "ITV", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Photo", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Diagram", false) == 0)
                      row2["IsDiagramReq"] = (object) true;
                  }
                  else
                    row2["IsPhotoReq"] = (object) true;
                }
                else
                  row2["IsCostReq"] = (object) true;
                checked { ++index; }
              }
            }
            try
            {
              foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(column.ColumnName, "Insured_Name1", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(column.ColumnName, "Insured_Name2", false) == 0)
                {
                  row2["Insured_Name"] = RuntimeHelpers.GetObjectValue(row1["Insured_Name1"]);
                  if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row1["Insured_Name2"])) && !string.IsNullOrEmpty(row1["Insured_Name2"].ToString()))
                    row2["Insured_Name"] = (object) $"{row2["Insured_Name"].ToString()} ({row1["Insured_Name2"].ToString()})";
                }
                else if (InspectionRequest.ColumnExists(table, column.ColumnName) && InspectionRequest.ColumnExists(dsRequest.Tables[table.TableName], column.ColumnName))
                  row2[column.ColumnName] = RuntimeHelpers.GetObjectValue(row1[column.ColumnName]);
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
            dsRequest.Tables[table.TableName].Rows.Add(row2);
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
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.MassageReliableColumns(dsRequest);
    string retString = InspectionRequest.TransmitReliableRequest(dsRequest, this._quote.QuoteGuid);
    this.ClientPostProcessReliableRequest(dsRequest);
    this.LogReliableInspectionRequest(dsRequest, retString);
    return !retString.Equals(string.Empty);
  }

  protected virtual void ClientPostProcessReliableRequest(dsRequest dsReliable)
  {
  }

  private void LogReliableInspectionRequest(dsRequest dsRegional, string retString)
  {
    string[] strArray = new string[1]
    {
      "MGASystems.IMS.Policies.Inspections.InspectionRequest"
    };
    Log.Write("Logging Reliable Inspection Request ...", strArray);
    Log.Write(dsRegional.GetXml(), strArray);
    Log.Write("End logging Reliable Inspection Request.", strArray);
    Guid quoteGuid = this._quote.QuoteGuid;
    Guid userGuid = CurrentUser.Instance.UserGUID;
    bool usingNetRate = this._quote.UsingNetRate || InspectionRequest.RequestAsNetRate;
    string str = "SELECT LocationGuid FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID=@LID";
    try
    {
      foreach (DataRow row in dsRegional.Location.Rows)
      {
        Guid locationGuid = Guid.Empty;
        if (!usingNetRate)
        {
          object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, str, new object[2]
          {
            (object) "@LID",
            row["Location_Id"]
          }));
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
            locationGuid = (Guid) objectValue;
        }
        InspectionsLogging.LogInspectionRequest(quoteGuid, this.InspectionCompanyID, Conversions.ToInteger(row["Location_Id"]), usingNetRate, userGuid, locationGuid, false, dsRegional.GetXml());
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    CurrentUser.Instance.LogAction($"Control # {this._quote.ControlNo} - Reliable Inspection request returns {retString}", this._quote.QuoteGuid);
  }

  private static bool ColumnExists(DataTable dt, string ColumnName)
  {
    bool flag = false;
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) dt.Columns)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(column.ColumnName, ColumnName, false) == 0)
        {
          flag = true;
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
    return flag;
  }

  [Obsolete("Reliable no longer accepts inspection requests via WS call.")]
  private static string TransmitReliableRequest(dsRequest dsReliable, Guid quoteGuid) => "Success";

  protected virtual string FormatLOB() => this._quote.LineName;

  protected virtual void AddBaseClientData(RRIRequest.LocationRow loc, UltraGrid grid)
  {
  }

  [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
  private void SaveInspectionsInfo(
    List<LocationInspectionCompany> inspectedLocations,
    RRIRequest netRateInspections)
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
    string str1 = "SELECT LocationNo, BuildingNo, Address1, Address2, City, State, Zip, PhysicalBuildingNo, InspectionContact, RoofInspectionContact, InspectionContactPhone, RoofInspectionContactPhone  FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID=@LID";
    try
    {
      foreach (LocationInspectionCompany inspectedLocation in inspectedLocations)
      {
        DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, str1, new object[2]
        {
          (object) "@LID",
          (object) inspectedLocation.Location
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
          if (!inspectedLocation.Roof)
          {
            if (!dataRow.IsNull("InspectionContact"))
              obj9 = RuntimeHelpers.GetObjectValue(dataRow["InspectionContact"]);
            if (!dataRow.IsNull("InspectionContactPhone"))
              obj11 = RuntimeHelpers.GetObjectValue(dataRow["InspectionContactPhone"]);
          }
          else
          {
            if (!dataRow.IsNull("RoofInspectionContact"))
              obj9 = RuntimeHelpers.GetObjectValue(dataRow["RoofInspectionContact"]);
            if (!dataRow.IsNull("RoofInspectionContactPhone"))
              obj11 = RuntimeHelpers.GetObjectValue(dataRow["RoofInspectionContactPhone"]);
          }
          if (!dataRow.IsNull("PhysicalBuildingNo"))
            str2 = dataRow["PhysicalBuildingNo"].ToString() + " ";
          if (!dataRow.IsNull("LocationNo"))
            obj8 = (object) ("Loc #" + dataRow["LocationNo"].ToString().ToString());
          if (dataRow[1] != DBNull.Value)
          {
            object obj12 = (object) dataRow[1].ToString();
            obj8 = obj8 == null ? (object) ("Loc #, Bldg #" + obj12.ToString()) : (object) $"{obj8.ToString()}, Bldg #{obj12.ToString()}";
          }
          if (dataRow[2] != DBNull.Value)
          {
            obj3 = (object) (str2 + dataRow[2].ToString());
            obj10 = (object) $"{str2}{obj10.ToString()}{dataRow[2].ToString()}\n";
          }
          if (dataRow[3] != DBNull.Value)
            obj4 = (object) dataRow[3].ToString();
          if (dataRow[4] != DBNull.Value)
          {
            obj5 = (object) dataRow[4].ToString();
            obj10 = (object) (obj10.ToString() + dataRow[4].ToString());
          }
          if (dataRow[5] != DBNull.Value)
          {
            obj6 = (object) dataRow[5].ToString();
            obj10 = (object) $"{obj10.ToString()}, {dataRow[5].ToString()}";
          }
          if (dataRow[6] != DBNull.Value)
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
            (object) inspectedLocation.Location,
            (object) "@LocationAddress",
            obj10,
            (object) "@InspectionCompanyID",
            (object) inspectedLocation.InspectionCompany,
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
            (object) inspectedLocation.Roof
          });
          this.OnInsertUnderwritingLocation(Conversions.ToInteger(controlNo), inspectedLocation.Location);
        }
      }
    }
    finally
    {
      List<LocationInspectionCompany>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (!this._quote.UsingNetRate && !InspectionRequest.RequestAsNetRate)
      return;
    if (netRateInspections == null)
      return;
    try
    {
      foreach (DataRow row in netRateInspections.Location.Rows)
      {
        object obj13 = (object) null;
        object obj14 = (object) null;
        object obj15 = (object) null;
        object obj16 = (object) null;
        object obj17 = (object) null;
        object obj18 = (object) null;
        object obj19 = (object) null;
        object obj20 = (object) null;
        try
        {
          foreach (InspectionRequest.NetRateLocation netRateLocation in (List<InspectionRequest.NetRateLocation>) this._netRateLocations)
          {
            if (netRateLocation.LocationID == Conversions.ToInteger(row["Location_Id"]))
            {
              obj20 = (object) netRateLocation.LocationBldg;
              break;
            }
          }
        }
        finally
        {
          List<InspectionRequest.NetRateLocation>.Enumerator enumerator;
          enumerator.Dispose();
        }
        object empty = (object) string.Empty;
        if (row["Location_Address1"] != DBNull.Value)
        {
          obj13 = (object) row["Location_Address1"].ToString();
          empty = (object) obj13.ToString();
        }
        object obj21 = (object) $"{empty.ToString()}{row["Location_City"].ToString()}, {row["Location_State"].ToString()}";
        if (row["Location_Address2"] != DBNull.Value)
          obj14 = (object) row["Location_Address2"].ToString();
        if (row["Location_City"] != DBNull.Value)
        {
          obj16 = (object) row["Location_City"].ToString();
          obj21 = (object) (obj21.ToString() + obj16.ToString());
        }
        if (row["Location_State"] != DBNull.Value)
        {
          obj17 = (object) row["Location_State"].ToString();
          obj21 = (object) $"{obj21.ToString()}, {obj17.ToString()}";
        }
        if (row["Location_Zipcode"] != DBNull.Value)
        {
          obj15 = (object) row["Location_Zipcode"].ToString();
          obj21 = (object) $"{obj21.ToString()} {obj15.ToString()}";
        }
        if (row["Location_Contact_Name"] != DBNull.Value)
          obj18 = (object) row["Location_Contact_Name"].ToString();
        if (row["Location_Contact_Phone"] != DBNull.Value)
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
          (object) this.InspectionCompanyID,
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
        this.OnInsertNetRateLocation(Conversions.ToInteger(controlNo), Conversions.ToInteger(row["Location_Id"]));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  protected virtual void OnInsertNetRateLocation(int controlNo, int locationNo)
  {
  }

  protected virtual void OnInsertUnderwritingLocation(int controlNo, int locationNo)
  {
  }

  protected virtual bool SendPreferredReports(RRIRequest ds)
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
      bool flag2 = true;
      string str = $"Inspection-{Guid.NewGuid().ToString().Substring(0, 14).Replace("-", string.Empty).ToString()}-ControlNo{this._quote.ControlNo.ToString()}.xml";
      Uri requestUri = new Uri($"{empty3}/{str}");
      using (MemoryStream memoryStream = new MemoryStream())
      {
        try
        {
          ds.WriteXml((Stream) memoryStream);
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
          InspectionRequest.LogInspectionCompanyErrorReports("Preferred Reports", innerException.Message, this._quote.QuoteGuid);
          ErrorHandler.SilentHandleError(new Exception($"Inspection Request failed. Unable to upload inspection to \"{requestUri.ToString()}\"", innerException));
          int num = (int) MessageBox.Show("Could not transfer file at this moment because of the following reasons:\n\n" + innerException.Message, "Could Not Complete Transfer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          ProjectData.ClearProjectError();
        }
      }
      if (flag2)
        this.TransferFilesToPreferredReports();
      flag1 = flag2;
    }
    return flag1;
  }

  private bool ValidatePreferredReportsCredentials(
    ref string UserName,
    ref string Password,
    ref string Url)
  {
    UserName = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("PreferredReportsUserName", string.Empty);
    Password = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("PreferredReportsPassword", string.Empty);
    Url = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("PreferredReportsURL", string.Empty);
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

  public bool TransferFilesToPreferredReports()
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string empty3 = string.Empty;
    bool preferredReports;
    if (!this.ValidatePreferredReportsCredentials(ref empty1, ref empty2, ref empty3))
      preferredReports = false;
    else
      FormSettings.ShowFormDialog(typeof (FormDisplayDocuments), (object) this._quote, (object) empty1, (object) empty2, (object) empty3);
    return preferredReports;
  }

  public static void LogInspectionCompanyErrorReports(
    string companyName,
    string errorStr,
    Guid quoteGuid)
  {
    string action = $"Request inspections via {companyName} .Error - {errorStr}";
    if (action.Length > 3000)
      action = action.Substring(0, 2999);
    CurrentUser.Instance.LogAction(action, quoteGuid);
  }

  public static string GetInspectionCompany(int inspectCompanyID)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT PayeeName FROM tblFin_ExpensePayees WHERE PayeeID=@P", new object[2]
    {
      (object) "@P",
      (object) inspectCompanyID
    }));
    return Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? string.Empty : objectValue.ToString();
  }

  protected virtual bool SendUsingNationalSafety(RRIRequest ds)
  {
    string setting1 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("NationalSafetyUserName", string.Empty);
    string setting2 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("NationalSafetyPassword", string.Empty);
    string setting3 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("NationalSafetyTargetNameSpace", string.Empty);
    string setting4 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("NationalSafetyUrl", string.Empty);
    bool flag;
    if (setting1.Replace(" ", string.Empty).Length == 0 || setting2.Replace(" ", string.Empty).Length == 0 || setting3.Replace(" ", string.Empty).Length == 0 || setting4.Replace(" ", string.Empty).Length == 0)
    {
      int num = (int) MessageBox.Show("National Safety is missing setting and/or credentials.", "Missing Credentials/Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
    {
      string str1 = this._quote.EffectiveDate.ToString("yyyy-MM-ddThh:mm:ss");
      string st1 = this._quote.ProducerLocation?.LocationName ?? string.Empty;
      if (st1.Length > 50)
        st1 = st1.Substring(0, 49);
      string producerContactEmail = this._quote.ProducerContactEmail;
      string st2 = $"{this._quote.ProducerContactLast}, {this._quote.ProducerContactFirst}";
      string str2 = string.Empty;
      string str3 = string.Empty;
      DataRow dataRow1 = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT pc.Fax AS Fax, pc.Phone AS Phone FROM tblquotes q WITH (NOLOCK) INNER JOIN tblProducerContacts pc WITH (NOLOCK) ON pc.ProducerContactGUID=q.ProducerContactGuid WHERE q.QuoteGUID =@QG", new object[2]
      {
        (object) "@QG",
        (object) this._quote.QuoteGuid
      });
      if (dataRow1 != null)
      {
        if (!dataRow1.IsNull("Fax"))
          str2 = dataRow1["Fax"].ToString();
        if (!dataRow1.IsNull("Phone"))
          str3 = dataRow1["Phone"].ToString();
      }
      string str4 = string.Empty;
      string empty1 = string.Empty;
      string empty2 = string.Empty;
      string insuredPolicyName = this._quote.InsuredPolicyName;
      string st3 = string.Empty;
      string empty3 = string.Empty;
      DataRow dataRow2 = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT c.FName, c.LName, c.Phone FROM tblInsuredContacts c WITH (NOLOCK) INNER JOIN tblInsuredSpecialContacts s WITH (NOLOCK) ON  S.InsuredContactGUID = C.InsuredContactGUID INNER JOIN lstInsuredSpecialContactTypes t ON s.SpecialContactTypeID = t.SpecialContactTypeID WHERE c.InsuredLocationGUID = @LG AND t.SystemDefinedCode = @CC", new object[4]
      {
        (object) "@LG",
        (object) this._quote.SubmissionGroup.InsuredLocationGuid,
        (object) "@CC",
        (object) "INSPC"
      });
      if (dataRow2 != null)
      {
        if (dataRow2[0] != DBNull.Value)
          st3 = dataRow2[0].ToString();
        if (dataRow2[1] != DBNull.Value)
          st3 = $"{st3} {dataRow2[1].ToString()}";
        if (dataRow2[2] != DBNull.Value)
          empty3 = dataRow2[2].ToString();
      }
      if (this._quote.Underwriter.HasEmail)
        str4 = this._quote.Underwriter.Email;
      string firstName = this._quote.Underwriter.FirstName;
      string lastName = this._quote.Underwriter.LastName;
      string str5 = this._quote.Underwriter.Phone ?? string.Empty;
      string str6 = !this._quote.HasPolicyNumber ? "To be Determined" : this._quote.PolicyNumber;
      string str7 = this._quote.SubmissionGroup.InsuredLocation?.Phone ?? string.Empty;
      if (str7.Equals(string.Empty))
        str7 = "000-000-0000";
      if (str5.Equals(string.Empty))
        str5 = "000-000-0000";
      if (str3.Equals(string.Empty))
        str3 = this._quote.ProducerLocation?.Phone ?? string.Empty;
      if (str3.Equals(string.Empty))
        str3 = "222-222-2222";
      if (str2.Equals(string.Empty))
        str2 = this._quote.ProducerLocation.Fax ?? string.Empty;
      if (str2.Equals(string.Empty))
        str2 = "000-000-0000";
      string safetyAgencyCode = this.GetNationalSafetyAgencyCode();
      List<ImportInspectionsRequest.Inspection> inspectionList = new List<ImportInspectionsRequest.Inspection>();
      ImportInspectionsRequest objectAs = ObjectFactory.Instance.CreateObjectAs<ImportInspectionsRequest>();
      objectAs.UserName = setting1;
      objectAs.Password = setting2;
      try
      {
        foreach (RRIRequest.LocationRow row in ds.Location.Rows)
        {
          ImportInspectionsRequest.Inspection inspection = new ImportInspectionsRequest.Inspection();
          ImportInspectionsRequest.Agent agent = new ImportInspectionsRequest.Agent()
          {
            AgencyName = InspectionRequest.EscapeXMLChars(st1),
            AgentCode = safetyAgencyCode,
            ContactEmail = producerContactEmail,
            ContactName = InspectionRequest.EscapeXMLChars(st2),
            Fax = str2,
            Phone = str3
          };
          agent.AgentAddress = new ImportInspectionsRequest.Address()
          {
            City = InspectionRequest.EscapeXMLChars(this._quote.ProducerLocation.City),
            StateOrProvince = this._quote.ProducerLocation.State,
            Street1 = InspectionRequest.EscapeXMLChars(this._quote.ProducerLocation.Address1),
            ZipCode = this._quote.ProducerLocation.Zip
          };
          inspection.InspectionAgent = agent;
          ImportInspectionsRequest.Attributes attributes = new ImportInspectionsRequest.Attributes()
          {
            BuildingCost = 0M,
            BusinessTotalRevenue = 0M,
            BusinessType = string.Empty,
            ContentsCost = 0M,
            IsoClass = string.Empty,
            Occupancy = string.Empty
          };
          inspection.InspectionAttributes = attributes;
          inspection.CustomerKey = ds.Request[0].Client_Code;
          inspection.EffectiveDate = str1.ToString();
          ImportInspectionsRequest.ExtraFields extraFields = new ImportInspectionsRequest.ExtraFields();
          if (row.GetReportsRows().Length > 0)
          {
            List<ImportInspectionsRequest.KeyValues> keyValuesList = new List<ImportInspectionsRequest.KeyValues>();
            RRIRequest.ReportsRow[] reportsRows = row.GetReportsRows();
            int index = 0;
            while (index < reportsRows.Length)
            {
              RRIRequest.ReportsRow reportsRow = reportsRows[index];
              ImportInspectionsRequest.KeyValues keyValues = new ImportInspectionsRequest.KeyValues()
              {
                Key = InspectionRequest.EscapeXMLChars(reportsRow.Item_Name),
                Value = reportsRow.Value
              };
              keyValuesList.Add(keyValues);
              checked { ++index; }
            }
            extraFields.KeyValueOfstringstring = keyValuesList.ToArray();
          }
          inspection.IgnoreDuplicates = true;
          inspection.InspectionType = this.GetNationalSafetyInspectionType(row.Location_Id);
          inspection.IsRush = row.Rush;
          ImportInspectionsRequest.Location location = new ImportInspectionsRequest.Location()
          {
            City = InspectionRequest.EscapeXMLChars(row.Location_City),
            StateOrProvince = row.Location_State,
            Street1 = InspectionRequest.EscapeXMLChars(row.Location_Address1)
          };
          if (!row.IsLocation_Address2Null())
            location.Street2 = InspectionRequest.EscapeXMLChars(row.Location_Address2);
          if (!row.IsLocation_ZipcodeNull())
            location.ZipCode = row.Location_Zipcode;
          inspection.InspectionLocation = location;
          ImportInspectionsRequest.Mailing mailing = new ImportInspectionsRequest.Mailing()
          {
            City = InspectionRequest.EscapeXMLChars(row.Location_City),
            StateOrProvince = row.Location_State,
            Street1 = InspectionRequest.EscapeXMLChars(row.Location_Address1),
            Street2 = string.Empty,
            ZipCode = row.Location_Zipcode
          };
          inspection.InspectionMailing = mailing;
          if (!row.IsSpecial_InstructionsNull())
            inspection.Notes = InspectionRequest.EscapeXMLChars(row.Special_Instructions);
          ImportInspectionsRequest.PolicyHolder policyHolder = new ImportInspectionsRequest.PolicyHolder()
          {
            CellPhone = str7,
            HomePhone = str7
          };
          policyHolder.PolicyHolderContact = !st3.Equals(string.Empty) ? InspectionRequest.EscapeXMLChars(st3) : InspectionRequest.EscapeXMLChars(row.Location_Contact_Name);
          policyHolder.PolicyHolderName = InspectionRequest.EscapeXMLChars(insuredPolicyName);
          policyHolder.WorkPhone = !empty3.Equals(string.Empty) ? empty3 : row.Location_Contact_Phone;
          inspection.PolicyNumber = str6;
          ImportInspectionsRequest.Underwriter underwriter = new ImportInspectionsRequest.Underwriter()
          {
            CorrespondanceEmail = str4,
            FirstName = InspectionRequest.EscapeXMLChars(firstName),
            LastName = InspectionRequest.EscapeXMLChars(lastName),
            Phone = str5,
            ReportEmail = string.Empty,
            UnderwriterCode = empty2
          };
          underwriter.ReportEmail = empty1;
          inspection.InspectionUnderwriter = underwriter;
          inspection.InspectionPolicyHolder = policyHolder;
          inspectionList.Add(inspection);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      objectAs.Inspections = inspectionList.ToArray();
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(objectAs.GetType(), setting3);
        MemoryStream w = new MemoryStream();
        using (XmlTextWriter xmlTextWriter = new XmlTextWriter((Stream) w, Encoding.UTF8))
        {
          xmlTextWriter.Namespaces = true;
          xmlSerializer.Serialize((XmlWriter) xmlTextWriter, (object) objectAs, InspectionRequest.GetNamespaces());
        }
        w.Close();
        string str8 = Encoding.UTF8.GetString(w.GetBuffer());
        string str9 = str8.Substring(str8.IndexOf(Convert.ToChar(60)));
        string xmlString = str9.Substring(0, str9.LastIndexOf(Convert.ToChar(62)) + 1);
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(new Uri(setting4));
        httpWebRequest.Method = "POST";
        httpWebRequest.ContentType = "application/xml; charset=utf-8";
        string str10 = string.Empty;
        try
        {
          using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
          {
            streamWriter.Write(xmlString);
            streamWriter.Close();
            using (StreamReader streamReader = new StreamReader(httpWebRequest.GetResponse().GetResponseStream()))
            {
              while (!streamReader.EndOfStream)
                str10 += streamReader.ReadLine();
              streamReader.Close();
            }
          }
          this.LogNationalSafetyRequests(xmlString, ds);
          int rPass = 0;
          int rFail = 0;
          this.ProcessSafetyResults(str10, ds, ref rFail, ref rPass);
          int num = (int) MessageBox.Show($"# Requests Failed - {rFail.ToString()}\n\n# Requests Successful - {rPass.ToString()}", "Request Results", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = rFail <= 0;
        }
        catch (WebException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          WebException webException = ex;
          using (StreamReader streamReader = new StreamReader(webException.Response.GetResponseStream()))
          {
            while (!streamReader.EndOfStream)
              str10 += streamReader.ReadLine();
            streamReader.Close();
            if (str10.Equals(string.Empty))
            {
              str10 = webException.Message;
              if (webException.InnerException != null && !string.IsNullOrEmpty(webException.InnerException.Message))
                str10 = $"{str10}\n\n{webException.InnerException.Message}";
            }
            int num = (int) MessageBox.Show(str10, "Service Fails to Complete Inspection Request", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
            ProjectData.ClearProjectError();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          string str11 = exception.InnerException == null || string.IsNullOrEmpty(exception.InnerException.Message) ? exception.Message : exception.InnerException.ToString();
          int num = (int) MessageBox.Show(exception.Message, "Error - Service Fails to Complete Inspection Request", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          ProjectData.ClearProjectError();
        }
      }
      catch (WebException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
        ProjectData.ClearProjectError();
      }
    }
    return flag;
  }

  private void UploadPreferredLossControlFiles(string un, string pw, string url)
  {
    if (!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Inspections.Preferred.LossControl.UploadFiles"))
      return;
    using (FormDisplayDocuments formEx = (FormDisplayDocuments) ObjectFactory.Instance.CreateFormEX(typeof (FormDisplayDocuments), (object) this._quote, (object) un, (object) pw, (object) url))
    {
      formEx.UsingLossControlFileUpload = true;
      int num = (int) formEx.ShowDialog();
    }
  }

  private void LogNationalSafetyRequests(string xmlString, RRIRequest ds)
  {
    bool usingNetRate = this._quote.UsingNetRate | InspectionRequest.RequestAsNetRate;
    Guid userGuid = CurrentUser.Instance.UserGUID;
    try
    {
      foreach (RRIRequest.LocationRow row in ds.Location.Rows)
      {
        Guid locationGuid = Guid.Empty;
        if (!usingNetRate)
        {
          object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT LocationGuid FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID=@LID", new object[2]
          {
            (object) "@LID",
            (object) row.Location_Id
          }));
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
            locationGuid = (Guid) objectValue;
        }
        InspectionsLogging.LogInspectionRequest(this._quote.QuoteGuid, this.InspectionCompanyID, row.Location_Id, usingNetRate, userGuid, locationGuid, false, xmlString);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  protected virtual string GetNationalSafetyInspectionType(int locationID) => string.Empty;

  protected virtual string GetNationalSafetyAgencyCode()
  {
    return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT ProducerCode FROM tblProducers WITH (NOLOCK) WHERE ProducerGUID=@PG", new object[2]
    {
      (object) "@PG",
      (object) this._quote.ProducerLocation.ProducerGuid
    }).ToString();
  }

  private void ProcessSafetyResults(
    string streamResponse,
    RRIRequest ds,
    ref int rFail,
    ref int rPass)
  {
    string str = streamResponse;
    if (streamResponse.Length > 2900)
      str = streamResponse.Substring(0, 2899);
    CurrentUser.Instance.LogAction("National Safety Request Response. \n\n" + str, this._quote.QuoteGuid);
    XmlDocument xmlDocument = new XmlDocument();
    xmlDocument.LoadXml(streamResponse);
    XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("Successful");
    int index = 0;
    rPass = 0;
    rFail = 0;
    try
    {
      foreach (XmlNode xmlNode in elementsByTagName)
      {
        if (xmlNode.InnerXml.ToUpper().Equals("FALSE"))
        {
          ++rFail;
          CurrentUser.Instance.LogAction("Inspection request failed. " + ((RRIRequest.LocationRow) ds.Location.Rows[index]).Location_Address1, this._quote.QuoteGuid);
        }
        else
        {
          ++rPass;
          CurrentUser.Instance.LogAction("Inspection request passed. " + ((RRIRequest.LocationRow) ds.Location.Rows[index]).Location_Address1, this._quote.QuoteGuid);
        }
        ++index;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public static XmlSerializerNamespaces GetNamespaces() => new XmlSerializerNamespaces();

  public static XmlSerializerNamespaces GetEmptyNamespaces()
  {
    XmlSerializerNamespaces emptyNamespaces = new XmlSerializerNamespaces();
    emptyNamespaces.Add("", "");
    return emptyNamespaces;
  }

  protected virtual bool SendUsingRct(RRIRequest ds)
  {
    RctInspections objectAs = ObjectFactory.Instance.CreateObjectAs<RctInspections>((object) ds, (object) this._quote);
    objectAs.StandAloneInspectionCompanyID = this.InspectionCompanyID;
    objectAs.BaseInspectionMethod = RuntimeHelpers.GetObjectValue(this.InspectionMethod);
    return objectAs.SendRctRequests();
  }

  public void SetErrorValue(bool errValue) => this._hasError = errValue;

  public bool SendMajesticRequests(RRIRequest ds, int inspectionCompanyId)
  {
    bool flag1;
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Inspections.Majestic.TestRequests"))
      flag1 = this.SendMajesticRequestsTest(ds, inspectionCompanyId);
    else if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Inspections.Majestic.UseVersion2"))
    {
      flag1 = this.SendMajesticRequestsVersion2(ds, inspectionCompanyId);
    }
    else
    {
      bool flag2 = false;
      try
      {
        MajesticRequest majesticRequest = new MajesticRequest(this._quote.QuoteGuid, ds, inspectionCompanyId);
        if (!majesticRequest.IsValidCredentials())
        {
          flag1 = false;
          goto label_16;
        }
        using (FormMajesticRequestInfo formEx = (FormMajesticRequestInfo) ObjectFactory.Instance.CreateFormEX(typeof (FormMajesticRequestInfo), (object) this._quote.QuoteGuid))
        {
          int num = (int) formEx.ShowDialog();
        }
        Cursor.Current = MgaCursors.WaitCursor;
        flag2 = majesticRequest.SendRequest();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag2 = false;
        throw;
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
      flag1 = flag2;
    }
label_16:
    return flag1;
  }

  public bool SendMajesticRequestsTest(RRIRequest ds, int inspectionCompanyId)
  {
    bool flag1 = false;
    bool flag2;
    try
    {
      MajesticRequest majesticRequest = new MajesticRequest(this._quote.QuoteGuid, ds, inspectionCompanyId);
      if (!majesticRequest.IsValidCredentials())
      {
        flag2 = false;
        goto label_12;
      }
      using (FormExpertInsured formEx = (FormExpertInsured) ObjectFactory.Instance.CreateFormEX(typeof (FormExpertInsured), (object) this._quote.ControlGuid, (object) this._quote.ControlNo))
      {
        int num = (int) formEx.ShowDialog();
      }
      Cursor.Current = MgaCursors.WaitCursor;
      flag1 = majesticRequest.SendRequestTest();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag1 = false;
      throw;
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
    flag2 = flag1;
label_12:
    return flag2;
  }

  public bool SendMajesticRequestsVersion2(RRIRequest ds, int inspectionCompanyId)
  {
    bool flag1 = false;
    bool flag2;
    try
    {
      MajesticRequest majesticRequest = new MajesticRequest(this._quote.QuoteGuid, ds, inspectionCompanyId);
      if (!majesticRequest.IsValidCredentials())
      {
        flag2 = false;
        goto label_12;
      }
      using (FormExpertInsured formEx = (FormExpertInsured) ObjectFactory.Instance.CreateFormEX(typeof (FormExpertInsured), (object) this._quote.ControlGuid, (object) this._quote.ControlNo))
      {
        int num = (int) formEx.ShowDialog();
      }
      Cursor.Current = MgaCursors.WaitCursor;
      flag1 = majesticRequest.SendRequestVer2();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag1 = false;
      throw;
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
    flag2 = flag1;
label_12:
    return flag2;
  }

  public static string EscapeNationalSafetySpecialChars(string st)
  {
    st = st.Replace("&", "&amp;");
    st = st.Replace(";", "&apos;");
    st = st.Replace("#", string.Empty);
    st = st.Replace("^", string.Empty);
    st = st.Replace("!", string.Empty);
    return st;
  }

  private bool IsUniformedXml(string xml)
  {
    bool flag;
    try
    {
      XDocument.Parse(xml);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag = false;
      ProjectData.ClearProjectError();
      goto label_3;
    }
    flag = true;
label_3:
    return flag;
  }

  protected virtual bool SendMullerInspections(RRIRequest ds)
  {
    MuellerInspectionRequest objectAs = ObjectFactory.Instance.CreateObjectAs<MuellerInspectionRequest>((object) ds, (object) this._quote);
    objectAs.InspectionCompanyID = this.InspectionCompanyID;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.InspectionMethod)))
      objectAs.SurveyType = (byte) this.InspectionMethod != (byte) 2 ? "Phone" : "Physical Inspection";
    return objectAs.SendMuellerRequests();
  }

  [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
  public class NetRateLocation
  {
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public object CustomData;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public int LocationID;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public string ContactName;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public string ContactPhone;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public string SpecialInstructions;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public int UniqueID;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public string Address;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public string Address2;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public string City;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public string State;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public string ZipCode;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public string ClassCode;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public string SIC;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public string LocationBldg;
  }

  private class NetRateLocations : List<InspectionRequest.NetRateLocation>
  {
    public bool Contains(object item)
    {
      int num = (int) item;
      bool flag;
      try
      {
        foreach (InspectionRequest.NetRateLocation netRateLocation in (List<InspectionRequest.NetRateLocation>) this)
        {
          if (netRateLocation.UniqueID == num)
          {
            flag = true;
            goto label_7;
          }
        }
      }
      finally
      {
        List<InspectionRequest.NetRateLocation>.Enumerator enumerator;
        enumerator.Dispose();
      }
      flag = false;
label_7:
      return flag;
    }

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    public InspectionRequest.NetRateLocation FindByUniqueID(int uniqueID)
    {
      InspectionRequest.NetRateLocation byUniqueId;
      try
      {
        foreach (InspectionRequest.NetRateLocation netRateLocation in (List<InspectionRequest.NetRateLocation>) this)
        {
          if (netRateLocation.UniqueID == uniqueID)
          {
            byUniqueId = netRateLocation;
            goto label_6;
          }
        }
      }
      finally
      {
        List<InspectionRequest.NetRateLocation>.Enumerator enumerator;
        enumerator.Dispose();
      }
      byUniqueId = (InspectionRequest.NetRateLocation) null;
label_6:
      return byUniqueId;
    }
  }

  private struct Report
  {
    public bool CostEstimator;
    public bool Photo;
    public bool Diagram;
    public int NetRateLocationID;
  }

  public enum RequestType
  {
    None,
    NetRate,
    Base,
  }

  [SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes")]
  [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
  public struct UsernamePassword
  {
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public string Username;
    [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
    public string Password;
  }
}
