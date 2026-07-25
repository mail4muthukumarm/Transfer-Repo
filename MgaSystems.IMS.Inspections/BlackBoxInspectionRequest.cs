// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.BlackBoxInspectionRequest
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

public class BlackBoxInspectionRequest : InspectionRequest
{
  private Guid _quoteGuid;
  private int _quoteID;
  private Quote _quote;
  private MGASystems.IMS.Policies.Inspections.IMSBase.dsInspectionRequest _dsBaseDataset;
  private MGASystems.IMS.Policies.Inspections.NetRate.dsInspectionRequest _dsNetRateDataset;
  private int _singleLocationIDRequest;

  public BlackBoxInspectionRequest(Guid quoteGuid)
    : base(quoteGuid)
  {
    this._dsBaseDataset = new MGASystems.IMS.Policies.Inspections.IMSBase.dsInspectionRequest();
    this._dsNetRateDataset = new MGASystems.IMS.Policies.Inspections.NetRate.dsInspectionRequest();
    this._singleLocationIDRequest = int.MinValue;
    this._quoteGuid = quoteGuid;
    this._quote = new Quote(quoteGuid);
    this._quoteID = this._quote.QuoteID;
  }

  public BlackBoxInspectionRequest(Guid quoteGuid, int locationID)
    : base(quoteGuid)
  {
    this._dsBaseDataset = new MGASystems.IMS.Policies.Inspections.IMSBase.dsInspectionRequest();
    this._dsNetRateDataset = new MGASystems.IMS.Policies.Inspections.NetRate.dsInspectionRequest();
    this._singleLocationIDRequest = int.MinValue;
    this._quoteGuid = quoteGuid;
    this._quote = new Quote(quoteGuid);
    this._quoteID = this._quote.QuoteID;
    this._singleLocationIDRequest = locationID;
  }

  private void GatherBaseLocations()
  {
    if (this._singleLocationIDRequest == int.MinValue)
    {
      MGASystems.IMS.Policies.Inspections.IMSBase.frmInspectionRequest.LoadBaseLocations(((MGASystems.IMS.Policies.Inspections.IMSBase.frmInspectionRequest) ObjectFactory.Instance.CreateFormEX(typeof (MGASystems.IMS.Policies.Inspections.IMSBase.frmInspectionRequest), (object) this._quoteGuid, (object) this._quote.CompanyLine.LineGuid)).LocationsStoredProcedure, this._dsBaseDataset, this._quoteGuid);
    }
    else
    {
      MGASystems.IMS.Policies.Inspections.IMSBase.frmInspectionRequest formEx = (MGASystems.IMS.Policies.Inspections.IMSBase.frmInspectionRequest) ObjectFactory.Instance.CreateFormEX(typeof (MGASystems.IMS.Policies.Inspections.IMSBase.frmInspectionRequest), (object) this._quoteGuid, (object) this._quote.CompanyLine.LineGuid);
      MGASystems.IMS.Policies.Inspections.IMSBase.frmInspectionRequest.LoadBaseLocations(this._dsBaseDataset, this._quoteGuid, this._singleLocationIDRequest);
    }
  }

  public bool BeginBlackBoxInspectionRequest()
  {
    bool flag;
    if (!SystemSettings.KeyExists("RequestInspectionsViaBlackBoxMode") || !SystemSettings.GetBoolSetting("RequestInspectionsViaBlackBoxMode"))
    {
      flag = false;
    }
    else
    {
      Guid companyLineGuid = InspectionRequest.RequestCompanyLineGuid(this._quote);
      if (companyLineGuid.Equals(Guid.Empty))
      {
        flag = false;
      }
      else
      {
        QuoteDetail quoteDetail = new QuoteDetail(this._quote.QuoteGuid, companyLineGuid);
        if (InspectionRequest.AlwaysEvaluateNetRate && quoteDetail.UsingNetRate || InspectionRequest.RequestAsNetRate)
        {
          this.GatherNetRateLocations();
          if (this._dsNetRateDataset.Locations.Count == 0)
          {
            flag = false;
          }
          else
          {
            CompanyLine companyLine = new CompanyLine(companyLineGuid);
            MGASystems.IMS.Policies.Inspections.NetRate.frmInspectionRequest formEx = (MGASystems.IMS.Policies.Inspections.NetRate.frmInspectionRequest) ObjectFactory.Instance.CreateFormEX(typeof (MGASystems.IMS.Policies.Inspections.NetRate.frmInspectionRequest), (object) quoteDetail.QuoteGuid, (object) companyLine.LineGuid);
            int num = (int) formEx.ShowDialog();
            flag = formEx.SuccessfulRequest;
          }
        }
        else
        {
          this.GatherBaseLocations();
          if (this._dsBaseDataset.RequestInspections.Count == 0)
          {
            flag = false;
          }
          else
          {
            InspectionRequest objectEx = (InspectionRequest) ObjectFactory.Instance.CreateObjectEX(typeof (InspectionRequest), (object) this._quoteGuid);
            CompanyLine companyLine = new CompanyLine(companyLineGuid);
            try
            {
              Cursor.Current = Cursors.WaitCursor;
              InspectionRequest.BlackBoxMode = true;
              objectEx.LineGuid = companyLine.LineGuid;
              objectEx.Send();
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              int num = (int) MessageBox.Show(ex.Message, "BlackBox Inspection request failed.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              flag = false;
              ProjectData.ClearProjectError();
              goto label_15;
            }
            finally
            {
              Cursor.Current = Cursors.Default;
            }
            flag = !objectEx.HasError;
          }
        }
      }
    }
label_15:
    return flag;
  }

  public void GatherNetRateLocations()
  {
    MGASystems.IMS.Policies.Inspections.NetRate.frmInspectionRequest.LoadBaseLocationsForNetRate(((MGASystems.IMS.Policies.Inspections.NetRate.frmInspectionRequest) ObjectFactory.Instance.CreateFormEX(typeof (MGASystems.IMS.Policies.Inspections.NetRate.frmInspectionRequest), (object) this._quoteGuid, (object) this._quote.CompanyLine.LineGuid)).LocationsStoredProcedure, this._dsNetRateDataset, this._quoteID, this._quote.CompanyLine.LineGuid);
  }
}
