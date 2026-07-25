// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.MajesticRequest
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Policies.Inspections.Majestic;
using MGASystems.IMS.Policies.Inspections.MajesticExpertInsp;
using Microsoft.VisualBasic;
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
using System.Xml.Linq;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

public class MajesticRequest
{
  private readonly RRIRequest _ds;
  private Guid _quoteGuid;
  private string _uName;
  private string _pWord;
  private string _agencyID;
  private readonly int _inspectionCompanyId;
  private readonly int _controlNo;
  private readonly Guid _controlGuid;
  private const int MAX_RECORD_LENGTH = 49;

  public MajesticRequest(Guid quoteGuid, RRIRequest ds, int inspectionCompanyId)
  {
    this._uName = string.Empty;
    this._pWord = string.Empty;
    this._agencyID = string.Empty;
    this._ds = ds;
    this._quoteGuid = quoteGuid;
    this._inspectionCompanyId = inspectionCompanyId;
    Quote quote = new Quote(quoteGuid);
    this._controlNo = quote.ControlNo;
    this._controlGuid = quote.ControlGuid;
  }

  public bool IsValidCredentials()
  {
    this._uName = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("MajesticServicesUserName", string.Empty);
    bool flag;
    if (this._uName.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("Majestic Services user name setting is empty", "Majestic Services User Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
    {
      this._pWord = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("MajesticServicesPassword", string.Empty);
      if (this._pWord.Equals(string.Empty))
      {
        int num = (int) MessageBox.Show("Majestic Services password name setting is empty", "Majestic Services Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag = false;
      }
      else
      {
        this._agencyID = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("MajesticServicesAgencyID", string.Empty);
        if (this._agencyID.Equals(string.Empty))
        {
          int num = (int) MessageBox.Show("Majestic Services agency ID setting is empty", "Majestic Services Agency ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag = false;
        }
        else
          flag = true;
      }
    }
    return flag;
  }

  [Obsolete("This function is deprecated, use GetInspectionDataRow2 instead.")]
  private DataRow GetInspectionDataRow()
  {
    return DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT InspectionTypeFullReport,InspectionTypeShortForm,InspectionTypeDriveBy, InspectionTypeRecommendation,InspectionTypeDiagram,CostEstimatorInsuranceToValue,CostEstimatorReplacementCost, CostEstimatorActualCashValue, RushRequest,PropertyTypeApartmentBuilding,PropertyTypeLessorRiskOnly,PropertyTypeMercantile, PropertyTypeaBuildingOwner,PropertyTypeOfficeBuilding,PropertyTypeRetailStore,PropertyTypeOther, PropertyTypeDescription, PropertyCoverageBuilding,PropertyCoverageInterior,PropertyCoverageExterior, PropertyCoverageContents,VacantBuildingExteriorOnly,VacantBuildingInteriorRequired,ManuContrJobsite, ManuContrPremises,ManuContrPhone,HomeOwnerExterior,HomeOwnerFullReport,ConfirmAmountsPayroll,ConfirmAmountsReceipts, PayrollAmount,ReceiptsAmount,CoverageTypeLiability,CoverageTypeAllRisk,CoverageTypeRestaurant,CoverageTypeFire, CoverageTypeWorkersComp,CoverageTypeAutoFleetSurvey,CoverageTypeLiquorLegal,CoverageTypeGarageKeepers, CoverageTypeGarageLiability,CoverageTypeGlassCoverage,CoverageTypeProducts, BuildersRisk FROM tblMajesticInsuredData WHERE QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) this._quoteGuid
    });
  }

  private DataRow GetInspectionDataRow2()
  {
    return DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT InspTypeFullReport, InspTypeShortForm, InspTypeDriveBy, InspTypeRecommendation,InspTypeDiagram, CostEstimatorITV, CostEstimatorRepCost,CostEstimatorACV,\tRushRequired,PropertyTypeAptBldg, PropertyTypeLessorRiskOnly, PropertyTypeMercantile, PropertyTypeBldgOwner,\tPropertyTypeOfficeBldg,\tPropertyTypeRetailStore, PropertyTypeOther, PropertyTypeOtherDescription, PropertyCoverageBldg, PropertyCoverageInterior,\tPropertyCoverageExterior, PropertyCoverageContents, VacantBuildingExtOnly, ConfirmAmountsReceipts, VacantBuildingInteriorReq, ManContractJobsite, ManContractPremises, HomeOwnerExterior, HomeOwnerFullReport, ManContractPhone, ConfirmAmountsPayroll, PayrollAmount, ReceiptsAmount, CoverageTypeLiability, CoverageTypeAllRisk, CoverageTypeRestaurant, CoverageTypeFire, CoverageTypeWorkersComp,  CoverageTypeAutoFleetSurvey, CoverageTypeLiquorLegal, CoverageTypeGarageKeepers, CoverageTypeGarageLiability, CoverageTypeGlassCoverage, CoverageTypeProducts, BuildersRisk FROM tblExpertInsuredInfo  WHERE ControlNo = @ControlNo", new object[2]
    {
      (object) "@ControlNo",
      (object) this._controlNo
    });
  }

  [Obsolete("This function is deprecated, use GetRequestString2 instead.")]
  private string GetRequestString()
  {
    Quote quote = new Quote(this._quoteGuid);
    DataRow inspectionDataRow = this.GetInspectionDataRow();
    StringBuilder stringBuilder = new StringBuilder();
    string str1 = "<EiInspectionRequest>";
    stringBuilder.AppendLine(str1);
    string str2 = "<AuthData>";
    stringBuilder.AppendLine(str2);
    string str3 = $"<AuthAgencyLogin>{this._uName}</AuthAgencyLogin>";
    stringBuilder.AppendLine(str3);
    string str4 = $"<AuthAgencyPassword>{this._pWord}</AuthAgencyPassword>";
    stringBuilder.AppendLine(str4);
    string str5 = $"<AuthAgencyID>{this._agencyID}</AuthAgencyID>";
    stringBuilder.AppendLine(str5);
    string str6 = "</AuthData>";
    stringBuilder.AppendLine(str6);
    string str7 = "<RequestData>";
    stringBuilder.AppendLine(str7);
    string str8 = $"<AuthAgencyID>{this._agencyID}</AuthAgencyID>";
    stringBuilder.AppendLine(str8);
    string str9 = "<SourceSystemDesc></SourceSystemDesc>";
    stringBuilder.AppendLine(str9);
    string str10 = "<SourceAppID></SourceAppID>";
    stringBuilder.AppendLine(str10);
    string str11 = $"<UnderwriterName>{quote.Underwriter.FirstName} {quote.Underwriter.LastName}</UnderwriterName>";
    stringBuilder.AppendLine(str11);
    string str12 = string.Empty;
    if (quote.Underwriter.HasEmail)
      str12 = quote.Underwriter.Email;
    string str13 = $"<UnderwriterEmail>{str12}</UnderwriterEmail>";
    stringBuilder.AppendLine(str13);
    string str14 = $"<CreatedBy>{CurrentUser.Instance.FirstName} {CurrentUser.Instance.LastName}</CreatedBy>";
    stringBuilder.AppendLine(str14);
    string str15 = $"<BrokerName>{quote.ProducerName}</BrokerName>";
    stringBuilder.AppendLine(str15);
    string str16 = $"<BrokerPhone>{quote.ProducerContactPhone}</BrokerPhone>";
    stringBuilder.AppendLine(str16);
    string str17 = "<BrokerPhoneExt></BrokerPhoneExt>";
    stringBuilder.AppendLine(str17);
    string str18 = "<Rush></Rush>";
    stringBuilder.AppendLine(str18);
    string str19 = $"<NeededBy>{this._ds.Location[0].Due_Date}</NeededBy>";
    stringBuilder.AppendLine(str19);
    string str20 = "<NeededEmailImportance></NeededEmailImportance>";
    stringBuilder.AppendLine(str20);
    string str21 = "<DeliveryType>1</DeliveryType>";
    stringBuilder.AppendLine(str21);
    string str22 = "<DeliveryEmail></DeliveryEmail>";
    stringBuilder.AppendLine(str22);
    string str23 = "<DeliveryAddress></DeliveryAddress>";
    stringBuilder.AppendLine(str23);
    string str24 = "<DeliveryCity></DeliveryCity>";
    stringBuilder.AppendLine(str24);
    string str25 = "<DeliveryZip></DeliveryZip>";
    stringBuilder.AppendLine(str25);
    string str26 = "<DeliveryWsURL></DeliveryWsURL>";
    stringBuilder.AppendLine(str26);
    string str27 = quote.InsuredPolicyName;
    if (str27.Length > 100)
      str27 = str27.Substring(0, 99);
    string str28 = $"<InsuredName>{str27}</InsuredName>";
    stringBuilder.AppendLine(str28);
    string str29 = this._ds.Location[0].Location_Address1;
    if (str29.Length > 100)
      str29 = str29.Substring(0, 99);
    string str30 = $"<Address1>{str29}</Address1>";
    stringBuilder.AppendLine(str30);
    string str31 = string.Empty;
    if (!this._ds.Location[0].IsLocation_Address2Null())
      str31 = this._ds.Location[0].Location_Address2;
    if (str31.Length > 100)
      str31 = str31.Substring(0, 99);
    string str32 = $"<Address2>{str31}</Address2>";
    stringBuilder.AppendLine(str32);
    string str33 = this._ds.Location[0].Location_City;
    if (str33.Length > 50)
      str33 = str33.Substring(0, 49);
    string str34 = $"<City>{str33}</City>";
    stringBuilder.AppendLine(str34);
    string str35 = this._ds.Location[0].Location_State;
    if (str35.Length > 50)
      str35 = str35.Substring(0, 49);
    string str36 = $"<State>{str35}</State>";
    stringBuilder.AppendLine(str36);
    string str37 = this._ds.Location[0].Location_Zipcode;
    if (str37.Length > 10)
      str37 = str37.Substring(0, 9);
    string str38 = $"<Zip>{str37}</Zip>";
    stringBuilder.AppendLine(str38);
    string str39;
    string str40;
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Inspections.Majestic.UseLocationContactInfo"))
    {
      str39 = this._ds.Location[0].Location_Contact_Name;
      str40 = this._ds.Location[0].Location_Contact_Phone;
    }
    else
    {
      str39 = $"{quote.ProducerContactFirst} {quote.ProducerContactLast}";
      str40 = quote.ProducerContactPhone;
    }
    if (str39.Length > 50)
      str39 = str39.Substring(0, 49);
    if (str40.Length > 50)
      str40 = str40.Substring(0, 49);
    string str41 = $"<PrimaryContactName>{str39}</PrimaryContactName>";
    stringBuilder.AppendLine(str41);
    string str42 = $"<PrimaryContactPhone>{str40}</PrimaryContactPhone>";
    stringBuilder.AppendLine(str42);
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Inspections.Majestic.UseAlternateContactInfo"))
    {
      string str43 = $"<AlternateContactName>{str39}</AlternateContactName>";
      stringBuilder.AppendLine(str43);
      string str44 = $"<AlternateContactPhone>{str40}</AlternateContactPhone>";
      stringBuilder.AppendLine(str44);
    }
    else
    {
      string str45 = "<AlternateContactName></AlternateContactName>";
      stringBuilder.AppendLine(str45);
      string str46 = "<AlternateContactPhone></AlternateContactPhone>";
      stringBuilder.AppendLine(str46);
    }
    string str47 = quote.Company;
    if (str47.Length > 50)
      str47 = str47.Substring(0, 49);
    string str48 = $"<CarrierName>{str47}</CarrierName>";
    stringBuilder.AppendLine(str48);
    string str49 = string.Empty;
    if (quote.HasPolicyNumber)
      str49 = quote.PolicyNumber;
    if (str49.Length > 50)
      str49 = str49.Substring(0, 49);
    string str50 = $"<PolicyNumber>{str49}</PolicyNumber>";
    stringBuilder.AppendLine(str50);
    string str51 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["PropertyTypeApartmentBuilding"] != DBNull.Value)
      str51 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["PropertyTypeApartmentBuilding"])) ? "0" : "1";
    string str52 = $"<PropTypeAptBldg>{str51}</PropTypeAptBldg>";
    stringBuilder.AppendLine(str52);
    string str53 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["PropertyTypeMercantile"] != DBNull.Value)
      str53 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["PropertyTypeMercantile"])) ? "0" : "1";
    string str54 = $"<PropTypeAptOfficeMerc>{str53}</PropTypeAptOfficeMerc>";
    stringBuilder.AppendLine(str54);
    string str55 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["PropertyTypeOfficeBuilding"] != DBNull.Value)
      str55 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["PropertyTypeOfficeBuilding"])) ? "0" : "1";
    string str56 = $"<PropTypeOffice>{str55}</PropTypeOffice>";
    stringBuilder.AppendLine(str56);
    string str57 = "<PropTypeAptMer></PropTypeAptMer>";
    stringBuilder.AppendLine(str57);
    string str58 = "<PropTypeGardenAC></PropTypeGardenAC>";
    stringBuilder.AppendLine(str58);
    string str59 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["PropertyTypeRetailStore"] != DBNull.Value)
      str59 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["PropertyTypeRetailStore"])) ? "0" : "1";
    string str60 = $"<PropTypeRetail>{str59}</PropTypeRetail>";
    stringBuilder.AppendLine(str60);
    string empty1 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["PropertyTypeDescription"] != DBNull.Value)
      empty1 = inspectionDataRow["PropertyTypeDescription"].ToString();
    string str61 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["PropertyTypeOther"] != DBNull.Value)
      str61 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["PropertyTypeOther"])) ? "0" : "1";
    if (empty1.Replace(" ", string.Empty).Length > 0)
      str61 = "1";
    string str62 = $"<PropTypeOther>{str61}</PropTypeOther>";
    stringBuilder.AppendLine(str62);
    string str63 = $"<PropTypeOtherDesc>{empty1}</PropTypeOtherDesc>";
    stringBuilder.AppendLine(str63);
    string str64 = "<PropTypeComBldg></PropTypeComBldg>";
    stringBuilder.AppendLine(str64);
    string str65 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["InspectionTypeFullReport"] != DBNull.Value)
      str65 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["InspectionTypeFullReport"])) ? "0" : "1";
    string str66 = $"<FullReport>{str65}</FullReport>";
    stringBuilder.AppendLine(str66);
    string str67 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["InspectionTypeShortForm"] != DBNull.Value)
      str67 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["InspectionTypeShortForm"])) ? "0" : "1";
    string str68 = $"<ShortForm>{str67}</ShortForm>";
    stringBuilder.AppendLine(str68);
    string str69 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["InspectionTypeRecommendation"] != DBNull.Value)
      str69 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["InspectionTypeRecommendation"])) ? "0" : "1";
    string str70 = $"<Recommendation>{str69}</Recommendation>";
    stringBuilder.AppendLine(str70);
    string str71 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["InspectionTypeDiagram"] != DBNull.Value)
      str71 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["InspectionTypeDiagram"])) ? "0" : "1";
    string str72 = $"<Diagram>{str71}</Diagram>";
    stringBuilder.AppendLine(str72);
    string str73 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["CostEstimatorInsuranceToValue"] != DBNull.Value)
      str73 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["CostEstimatorInsuranceToValue"])) ? "0" : "1";
    string str74 = $"<InsToValue>{str73}</InsToValue>";
    stringBuilder.AppendLine(str74);
    string str75 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["CostEstimatorReplacementCost"] != DBNull.Value)
      str75 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["CostEstimatorReplacementCost"])) ? "0" : "1";
    string str76 = $"<InsToValueReplacement>{str75}</InsToValueReplacement>";
    stringBuilder.AppendLine(str76);
    string str77 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["CostEstimatorActualCashValue"] != DBNull.Value)
      str77 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["CostEstimatorActualCashValue"])) ? "0" : "1";
    string str78 = $"<InsToValueActualCashVal>{str77}</InsToValueActualCashVal>";
    stringBuilder.AppendLine(str78);
    string str79 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["ConfirmAmountsPayroll"] != DBNull.Value)
      str79 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["ConfirmAmountsPayroll"])) ? "0" : "1";
    string str80 = $"<PayrollConfirm>{str79}</PayrollConfirm>";
    stringBuilder.AppendLine(str80);
    string empty2 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["PayrollAmount"] != DBNull.Value)
      empty2 = inspectionDataRow["PayrollAmount"].ToString();
    string str81 = $"<PayrollAmount>{empty2}</PayrollAmount>";
    stringBuilder.AppendLine(str81);
    string str82 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["ConfirmAmountsReceipts"] != DBNull.Value)
      str82 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["ConfirmAmountsReceipts"])) ? "0" : "1";
    string str83 = $"<ReceiptsConfirm>{str82}</ReceiptsConfirm>";
    stringBuilder.AppendLine(str83);
    string empty3 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["ReceiptsAmount"] != DBNull.Value)
      empty3 = inspectionDataRow["ReceiptsAmount"].ToString();
    string str84 = $"<ReceiptsAmount>{empty3}</ReceiptsAmount>";
    stringBuilder.AppendLine(str84);
    string str85 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["InspectionTypeDriveBy"] != DBNull.Value)
      str85 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["InspectionTypeDriveBy"])) ? "0" : "1";
    string str86 = $"<DriveByInsp>{str85}</DriveByInsp>";
    stringBuilder.AppendLine(str86);
    string str87 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["PropertyCoverageBuilding"] != DBNull.Value)
      str87 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["PropertyCoverageBuilding"])) ? "0" : "1";
    string str88 = $"<CovPropBldg>{str87}</CovPropBldg>";
    stringBuilder.AppendLine(str88);
    string str89 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["PropertyCoverageInterior"] != DBNull.Value)
      str89 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["PropertyCoverageInterior"])) ? "0" : "1";
    string str90 = $"<CovPropBldgInt>{str89}</CovPropBldgInt>";
    stringBuilder.AppendLine(str90);
    string str91 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["PropertyCoverageExterior"] != DBNull.Value)
      str91 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["PropertyCoverageExterior"])) ? "0" : "1";
    string str92 = $"<CovPropBldgExt>{str91}</CovPropBldgExt>";
    stringBuilder.AppendLine(str92);
    string str93 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["PropertyCoverageContents"] != DBNull.Value)
      str93 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["PropertyCoverageContents"])) ? "0" : "1";
    string str94 = $"<CovPropCont>{str93}</CovPropCont>";
    stringBuilder.AppendLine(str94);
    string str95 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["VacantBuildingExteriorOnly"] != DBNull.Value)
      str95 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["VacantBuildingExteriorOnly"])) ? "0" : "1";
    string str96 = $"<CovVacantExt>{str95}</CovVacantExt>";
    stringBuilder.AppendLine(str96);
    string str97 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["VacantBuildingInteriorRequired"] != DBNull.Value)
      str97 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["VacantBuildingInteriorRequired"])) ? "0" : "1";
    string str98 = $"<CovVacantInt>{str97}</CovVacantInt>";
    stringBuilder.AppendLine(str98);
    string str99 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["ManuContrJobsite"] != DBNull.Value)
      str99 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["ManuContrJobsite"])) ? "0" : "1";
    string str100 = $"<CovMCJobsite>{str99}</CovMCJobsite>";
    stringBuilder.AppendLine(str100);
    string str101 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["ManuContrPremises"] != DBNull.Value)
      str101 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["ManuContrPremises"])) ? "0" : "1";
    string str102 = $"<CovMCPrem>{str101}</CovMCPrem>";
    stringBuilder.AppendLine(str102);
    string str103 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["ManuContrPhone"] != DBNull.Value)
      str103 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["ManuContrPhone"])) ? "0" : "1";
    string str104 = $"<CovMCPhone>{str103}</CovMCPhone>";
    stringBuilder.AppendLine(str104);
    string str105 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["HomeOwnerExterior"] != DBNull.Value)
      str105 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["HomeOwnerExterior"])) ? "0" : "1";
    string str106 = $"<CovHomeOwnersExterior>{str105}</CovHomeOwnersExterior>";
    stringBuilder.AppendLine(str106);
    string str107 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["HomeOwnerFullReport"] != DBNull.Value)
      str107 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["HomeOwnerFullReport"])) ? "0" : "1";
    string str108 = $"<CovHomeOwnersFullReport>{str107}</CovHomeOwnersFullReport>";
    stringBuilder.AppendLine(str108);
    string str109 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["CoverageTypeLiability"] != DBNull.Value)
      str109 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["CoverageTypeLiability"])) ? "0" : "1";
    string str110 = $"<CovLiability>{str109}</CovLiability>";
    stringBuilder.AppendLine(str110);
    string str111 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["CoverageTypeAllRisk"] != DBNull.Value)
      str111 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["CoverageTypeAllRisk"])) ? "0" : "1";
    string str112 = $"<CovAllRisk>{str111}</CovAllRisk>";
    stringBuilder.AppendLine(str112);
    string str113 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["CoverageTypeRestaurant"] != DBNull.Value)
      str113 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["CoverageTypeRestaurant"])) ? "0" : "1";
    string str114 = $"<CovRestaurant>{str113}</CovRestaurant>";
    stringBuilder.AppendLine(str114);
    string str115 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["CoverageTypeWorkersComp"] != DBNull.Value)
      str115 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["CoverageTypeWorkersComp"])) ? "0" : "1";
    string str116 = $"<CovWorkers>{str115}</CovWorkers>";
    stringBuilder.AppendLine(str116);
    string str117 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["CoverageTypeAutoFleetSurvey"] != DBNull.Value)
      str117 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["CoverageTypeAutoFleetSurvey"])) ? "0" : "1";
    string str118 = $"<CovAuto>{str117}</CovAuto>";
    stringBuilder.AppendLine(str118);
    string str119 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["CoverageTypeLiquorLegal"] != DBNull.Value)
      str119 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["CoverageTypeLiquorLegal"])) ? "0" : "1";
    string str120 = $"<CovLiquor>{str119}</CovLiquor>";
    stringBuilder.AppendLine(str120);
    string str121 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["CoverageTypeGarageKeepers"] != DBNull.Value)
      str121 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["CoverageTypeGarageKeepers"])) ? "0" : "1";
    string str122 = $"<CovGarageKeepers>{str121}</CovGarageKeepers>";
    stringBuilder.AppendLine(str122);
    string str123 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["CoverageTypeLiability"] != DBNull.Value)
      str123 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["CoverageTypeLiability"])) ? "0" : "1";
    string str124 = $"<CovGarageLiability>{str123}</CovGarageLiability>";
    stringBuilder.AppendLine(str124);
    string str125 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["CoverageTypeGlassCoverage"] != DBNull.Value)
      str125 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["CoverageTypeGlassCoverage"])) ? "0" : "1";
    string str126 = $"<CovGlass>{str125}</CovGlass>";
    stringBuilder.AppendLine(str126);
    string str127 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["CoverageTypeFire"] != DBNull.Value)
      str127 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["CoverageTypeFire"])) ? "0" : "1";
    string str128 = $"<CovFire>{str127}</CovFire>";
    stringBuilder.AppendLine(str128);
    string str129 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["CoverageTypeProducts"] != DBNull.Value)
      str129 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["CoverageTypeProducts"])) ? "0" : "1";
    string str130 = $"<CovProducts>{str129}</CovProducts>";
    stringBuilder.AppendLine(str130);
    string str131 = string.Empty;
    if (inspectionDataRow != null && inspectionDataRow["BuildersRisk"] != DBNull.Value)
      str131 = !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(inspectionDataRow["BuildersRisk"])) ? "0" : "1";
    string str132 = $"<CovBuildersRisk>{str131}</CovBuildersRisk>";
    stringBuilder.AppendLine(str132);
    string str133 = string.Empty;
    if (!this._ds.Location[0].IsSpecial_InstructionsNull())
      str133 = this._ds.Location[0].Special_Instructions;
    string str134 = $"<Instructions>{str133}</Instructions>";
    stringBuilder.AppendLine(str134);
    string str135 = "0";
    if (quote.IsRenewal || quote.IsImsRenewal)
      str135 = "1";
    string str136 = $"<Renewal>{str135}</Renewal>";
    stringBuilder.AppendLine(str136);
    string str137 = "<PreviousCC></PreviousCC>";
    stringBuilder.AppendLine(str137);
    string str138 = string.Empty;
    if (quote.IsEndorsement && quote.PreviousQuote.HasPolicyNumber)
      str138 = quote.PreviousQuote.PolicyNumber;
    string str139 = $"<PreviousPolicy>{str138}</PreviousPolicy>";
    stringBuilder.AppendLine(str139);
    string str140 = "</RequestData>";
    stringBuilder.AppendLine(str140);
    string str141 = "</EiInspectionRequest>";
    stringBuilder.AppendLine(str141);
    return stringBuilder.ToString();
  }

  [Obsolete("This function is deprecated, use SendRequestVer2 instead.")]
  public bool SendRequest()
  {
    string requestString = this.GetRequestString();
    DefaultDatabase.ExecuteNonQuery("SaveMajesticXml", new object[4]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid,
      (object) "@XmlData",
      (object) requestString
    });
    CurrentUser.Instance.LogAction("Inspections Request - Invoking Expert Insured service.", this._quoteGuid);
    string str = string.Empty;
    using (MajesticExpertInspectWebService inspectWebService = new MajesticExpertInspectWebService())
      str = inspectWebService.ImportRequest(requestString);
    bool flag;
    if (this.GetTagValue(str, "<StatusCode>", "</StatusCode>").Equals("001"))
    {
      this.LogMajesticRequest(requestString);
      flag = true;
    }
    else
    {
      InspectionRequest.LogInspectionCompanyErrorReports(DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT PayeeName FROM tblFin_ExpensePayees WITH (NOLOCK) WHERE PayeeID=@IC", new object[2]
      {
        (object) "@IC",
        (object) this._inspectionCompanyId
      }), str, this._quoteGuid);
      flag = false;
    }
    return flag;
  }

  private string GetTagValue(string xmlString, string sTag, string eTag)
  {
    string tagValue;
    if (xmlString.Equals(string.Empty))
    {
      tagValue = string.Empty;
    }
    else
    {
      int startIndex = xmlString.IndexOf(sTag) + sTag.Length;
      int num = xmlString.IndexOf(eTag, startIndex);
      tagValue = xmlString.Substring(startIndex, num - startIndex);
    }
    return tagValue;
  }

  private string GetRequestString2()
  {
    Quote quote1 = new Quote(this._quoteGuid);
    DataRow inspectionDataRow2 = this.GetInspectionDataRow2();
    EiInspectionRequest.AuthDataNode authDataNode = new EiInspectionRequest.AuthDataNode()
    {
      AuthAgencyLogin = this._uName,
      AuthAgencyPassword = this._pWord,
      AuthAgencyID = Conversions.ToInteger(this._agencyID)
    };
    string str1 = quote1.InsuredPolicyName;
    if (str1.Length > 100)
      str1 = str1.Substring(0, 99);
    string str2 = string.Empty;
    string str3 = string.Empty;
    bool setting1 = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Inspections.Majestic.UseLocationContactInfo");
    DataRow row1 = DefaultDatabase.ExecuteDataRow("dbo.GetInspectionInsuredContactInformation", new object[2]
    {
      (object) "@InsuredGuid",
      (object) quote1.SubmissionGroup.InsuredGuid
    });
    if (row1 != null)
    {
      string str4 = string.Empty;
      string str5 = string.Empty;
      if (!row1.IsNull("FName"))
        str4 = row1.Field<string>("FName");
      if (!row1.IsNull("LName"))
        str5 = row1.Field<string>("LName");
      if (!row1.IsNull("Phone"))
        str2 = row1.Field<string>("Phone").Replace("-", string.Empty);
      str3 = $"{str4} {str5}";
    }
    string str6 = string.Empty;
    string str7 = quote1.ProducerName;
    string str8;
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Inspections.Majestic.UseAlternateContactInfo"))
    {
      str8 = quote1.ProducerName;
      if (!Utility.IsNull((object) quote1.ProducerContactPhone))
        str6 = quote1.ProducerContactPhone.Replace("-", string.Empty);
      str7 = quote1.ProducerLocation.Email;
      if (string.IsNullOrEmpty(str7))
        str7 = quote1.ProducerContactEmail;
    }
    else
    {
      str8 = str3;
      str6 = str2;
    }
    if (str6.Length > 50)
      str6 = str6.Substring(0, 49);
    if (str8.Length > 50)
      str8 = str8.Substring(0, 49);
    string str9 = $"{CurrentUser.Instance.FirstName} {CurrentUser.Instance.LastName}";
    string str10 = $"{quote1.Underwriter.FirstName} {quote1.Underwriter.LastName}";
    string producerContactPhone = quote1.ProducerContactPhone;
    string str11 = Interaction.IIf(quote1.Underwriter.HasEmail, (object) quote1.Underwriter.Email, (object) string.Empty).ToString();
    bool usingNetRate = quote1.UsingNetRate;
    List<EiInspectionRequest.RequestDataNode> requestDataNodeList = new List<EiInspectionRequest.RequestDataNode>();
    string str12 = quote1.ProducerLocation.Address1;
    string address2 = quote1.ProducerLocation.Address2;
    string city = quote1.ProducerLocation.City;
    string state = quote1.ProducerLocation.State;
    string zip = quote1.ProducerLocation.Zip;
    string setting2 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("Majestic.Inspections.DeliveryEmail", string.Empty);
    string str13 = quote1.Company;
    if (str13.Length > 50)
      str13 = str13.Substring(0, 49);
    if (str12.Length > 100)
      str12 = str12.Substring(0, 99);
    string producerContactEmail = quote1.ProducerContactEmail;
    try
    {
      foreach (RRIRequest.LocationRow row2 in this._ds.Location.Rows)
      {
        EiInspectionRequest.RequestDataNode requestDataNode = new EiInspectionRequest.RequestDataNode()
        {
          AgencyID = Conversions.ToInteger(this._agencyID),
          SourceAppID = this._controlGuid.ToString(),
          UnderwriterName = str10,
          UnderwriterEmail = str11,
          CreatedBy = str9,
          BrokerName = str7,
          BrokerPhone = producerContactPhone,
          BrokerAddress = str12,
          BrokerAddress2 = address2,
          BrokerCity = city,
          State = state,
          BrokerZip = zip,
          Rush = Conversions.ToInteger(Interaction.IIf(row2.Rush, (object) 1, (object) 0)),
          NeededBy = Conversions.ToDate(row2.Due_Date),
          EmailImportance = 0
        };
        if (usingNetRate)
          requestDataNode.LocationNumber = DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT UnitNumber FROM dbo.NetRate_Quote_Insur_Quote_Locat WITH (NOLOCK) WHERE LocationID = @ID", new object[2]
          {
            (object) "@ID",
            (object) row2.Location_Id
          }).ToString();
        else
          requestDataNode.LocationNumber = DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT LocationNo FROM dbo.tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID = @ID", new object[2]
          {
            (object) "@ID",
            (object) row2.Location_Id
          }).ToString();
        if (!string.IsNullOrEmpty(setting2))
        {
          requestDataNode.DeliveryType = 0;
          requestDataNode.DeliveryEmail = setting2;
        }
        else
        {
          requestDataNode.DeliveryType = 1;
          requestDataNode.DeliveryEmail = string.Empty;
        }
        requestDataNode.DeliveryType = 1;
        requestDataNode.DeliveryAddress = string.Empty;
        requestDataNode.DeliveryCity = string.Empty;
        requestDataNode.DeliveryZip = string.Empty;
        requestDataNode.InsuredName = str1;
        string str14 = row2.Location_Address1;
        if (str14.Length > 100)
          str14 = str14.Substring(0, 99);
        requestDataNode.Address1 = str14;
        string str15 = string.Empty;
        if (!row2.IsLocation_Address2Null())
          str15 = row2.Location_Address2;
        if (str15.Length > 100)
          str15 = str15.Substring(0, 99);
        requestDataNode.Address2 = str15;
        string str16 = row2.Location_City;
        if (str16.Length > 50)
          str16 = str16.Substring(0, 49);
        requestDataNode.City = str16;
        string str17 = row2.Location_State;
        if (str17.Length > 50)
          str17 = str17.Substring(0, 49);
        requestDataNode.State = str17;
        string str18 = string.Empty;
        if (!row2.IsLocation_ZipcodeNull())
          str18 = row2.Location_Zipcode;
        if (str18.Length > 10)
          str18 = str18.Substring(0, 9);
        requestDataNode.Zip = str18;
        if (setting1)
        {
          str3 = row2.Location_Contact_Name;
          str2 = row2.Location_Contact_Phone;
        }
        if (str3.Length > 50)
          str3 = str3.Substring(0, 49);
        if (str2.Length > 50)
          str2 = str2.Substring(0, 49);
        requestDataNode.PrimaryContactName = str3;
        requestDataNode.PrimaryContactPhone = str2;
        requestDataNode.AlternateContactName = str8;
        requestDataNode.AlternateContactPhone = str6;
        requestDataNode.CarrierName = str13;
        string str19 = string.Empty;
        if (quote1.HasPolicyNumber)
          str19 = quote1.PolicyNumber;
        if (str19.Length > 50)
          str19 = str19.Substring(0, 49);
        requestDataNode.PolicyNumber = str19;
        requestDataNode.PropTypeAptBldg = 0;
        if (!inspectionDataRow2.IsNull("PropertyTypeAptBldg") && inspectionDataRow2.Field<bool>("PropertyTypeAptBldg"))
          requestDataNode.PropTypeAptBldg = 1;
        requestDataNode.PropTypeAptOfficeMerc = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("PropertyTypeMercantile") && inspectionDataRow2.Field<bool>("PropertyTypeMercantile"), (object) 1, (object) 0));
        requestDataNode.PropTypeOffice = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("PropertyTypeOfficeBldg") && inspectionDataRow2.Field<bool>("PropertyTypeOfficeBldg"), (object) 1, (object) 0));
        requestDataNode.PropTypeAptMer = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("PropertyTypeMercantile") && inspectionDataRow2.Field<bool>("PropertyTypeMercantile"), (object) 1, (object) 0));
        requestDataNode.PropTypeRetail = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("PropertyTypeRetailStore") && inspectionDataRow2.Field<bool>("PropertyTypeRetailStore"), (object) 1, (object) 0));
        requestDataNode.PropertyTypeOther = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("PropertyTypeOther") && inspectionDataRow2.Field<bool>("PropertyTypeOther"), (object) 1, (object) 0));
        requestDataNode.PropTypeOtherDesc = string.Empty;
        if (!inspectionDataRow2.IsNull("PropertyTypeOtherDescription"))
          requestDataNode.PropTypeOtherDesc = inspectionDataRow2.Field<string>("PropertyTypeOtherDescription");
        requestDataNode.FullReport = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("InspTypeFullReport") && inspectionDataRow2.Field<bool>("InspTypeFullReport"), (object) 1, (object) 0));
        requestDataNode.ShortForm = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("InspTypeShortForm") && inspectionDataRow2.Field<bool>("InspTypeShortForm"), (object) 1, (object) 0));
        requestDataNode.Recommendation = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("InspTypeRecommendation") && inspectionDataRow2.Field<bool>("InspTypeRecommendation"), (object) 1, (object) 0));
        requestDataNode.Diagram = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("InspTypeDiagram") && inspectionDataRow2.Field<bool>("InspTypeDiagram"), (object) 1, (object) 0));
        requestDataNode.InsToValue = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("CostEstimatorITV") && inspectionDataRow2.Field<bool>("CostEstimatorITV"), (object) 1, (object) 0));
        requestDataNode.InsToValueReplacement = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("CostEstimatorRepCost") && inspectionDataRow2.Field<bool>("CostEstimatorRepCost"), (object) 1, (object) 0));
        requestDataNode.InsToValueActualCashVal = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("CostEstimatorACV") && inspectionDataRow2.Field<bool>("CostEstimatorACV"), (object) 1, (object) 0));
        requestDataNode.PayrollConfirm = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("ConfirmAmountsPayroll") && inspectionDataRow2.Field<bool>("ConfirmAmountsPayroll"), (object) 1, (object) 0));
        if (!inspectionDataRow2.IsNull("PayrollAmount"))
          requestDataNode.PayrollAmount = inspectionDataRow2.Field<Decimal>("PayrollAmount");
        requestDataNode.ReceiptsConfirm = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("ConfirmAmountsReceipts") && inspectionDataRow2.Field<bool>("ConfirmAmountsReceipts"), (object) 1, (object) 0));
        if (!inspectionDataRow2.IsNull("ReceiptsAmount"))
          requestDataNode.ReceiptsAmount = inspectionDataRow2.Field<Decimal>("ReceiptsAmount");
        requestDataNode.DriveByInsp = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("InspTypeDriveBy") && inspectionDataRow2.Field<bool>("InspTypeDriveBy"), (object) 1, (object) 0));
        requestDataNode.CovPropBldg = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("PropertyCoverageBldg") && inspectionDataRow2.Field<bool>("PropertyCoverageBldg"), (object) 1, (object) 0));
        requestDataNode.CovPropBldgInt = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("PropertyCoverageInterior") && inspectionDataRow2.Field<bool>("PropertyCoverageInterior"), (object) 1, (object) 0));
        requestDataNode.CovPropBldgInt = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("PropertyCoverageExterior") && inspectionDataRow2.Field<bool>("PropertyCoverageExterior"), (object) 1, (object) 0));
        requestDataNode.CovPropCont = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("PropertyCoverageContents") && inspectionDataRow2.Field<bool>("PropertyCoverageContents"), (object) 1, (object) 0));
        requestDataNode.CovVacantExt = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("VacantBuildingExtOnly") && inspectionDataRow2.Field<bool>("VacantBuildingExtOnly"), (object) 1, (object) 0));
        requestDataNode.CovVacantInt = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("VacantBuildingInteriorReq") && inspectionDataRow2.Field<bool>("VacantBuildingInteriorReq"), (object) 1, (object) 0));
        requestDataNode.CovMCJobsite = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("ManContractJobsite") && inspectionDataRow2.Field<bool>("ManContractJobsite"), (object) 1, (object) 0));
        requestDataNode.CovMCPhone = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("ManContractPhone") && inspectionDataRow2.Field<bool>("ManContractPhone"), (object) 1, (object) 0));
        requestDataNode.CovHomeOwnersExterior = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("HomeOwnerExterior") && inspectionDataRow2.Field<bool>("HomeOwnerExterior"), (object) 1, (object) 0));
        requestDataNode.CovHomeOwnersFullReport = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("HomeOwnerFullReport") && inspectionDataRow2.Field<bool>("HomeOwnerFullReport"), (object) 1, (object) 0));
        requestDataNode.CovLiability = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("CoverageTypeLiability") && inspectionDataRow2.Field<bool>("CoverageTypeLiability"), (object) 1, (object) 0));
        requestDataNode.CovAllRisk = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("CoverageTypeAllRisk") && inspectionDataRow2.Field<bool>("CoverageTypeAllRisk"), (object) 1, (object) 0));
        requestDataNode.CovRestaurant = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("CoverageTypeRestaurant") && inspectionDataRow2.Field<bool>("CoverageTypeRestaurant"), (object) 1, (object) 0));
        requestDataNode.CovWorkers = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("CoverageTypeWorkersComp") && inspectionDataRow2.Field<bool>("CoverageTypeWorkersComp"), (object) 1, (object) 0));
        requestDataNode.CovAuto = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("CoverageTypeAutoFleetSurvey") && inspectionDataRow2.Field<bool>("CoverageTypeAutoFleetSurvey"), (object) 1, (object) 0));
        requestDataNode.CovLiquor = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("CoverageTypeLiquorLegal") && inspectionDataRow2.Field<bool>("CoverageTypeLiquorLegal"), (object) 1, (object) 0));
        requestDataNode.CovGarageKeepers = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("CoverageTypeGarageKeepers") && inspectionDataRow2.Field<bool>("CoverageTypeGarageKeepers"), (object) 1, (object) 0));
        requestDataNode.CovGarageLiability = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("CoverageTypeGarageLiability") && inspectionDataRow2.Field<bool>("CoverageTypeGarageLiability"), (object) 1, (object) 0));
        requestDataNode.CovGlass = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("CoverageTypeGlassCoverage") && inspectionDataRow2.Field<bool>("CoverageTypeGlassCoverage"), (object) 1, (object) 0));
        requestDataNode.CovFire = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("CoverageTypeFire") && inspectionDataRow2.Field<bool>("CoverageTypeFire"), (object) 1, (object) 0));
        requestDataNode.CovProducts = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("CoverageTypeProducts") && inspectionDataRow2.Field<bool>("CoverageTypeProducts"), (object) 1, (object) 0));
        requestDataNode.CovBuildersRisk = Conversions.ToInteger(Interaction.IIf(!inspectionDataRow2.IsNull("BuildersRisk") && inspectionDataRow2.Field<bool>("BuildersRisk"), (object) 1, (object) 0));
        requestDataNode.Instructions = string.Empty;
        if (!row2.IsSpecial_InstructionsNull())
          requestDataNode.Instructions = row2.Special_Instructions;
        requestDataNode.Renewal = 0;
        if (quote1.IsRenewal || quote1.IsImsRenewal)
        {
          requestDataNode.Renewal = 1;
          Guid? renewalOfQuoteGuid = quote1.RenewalOfQuoteGuid;
          if (renewalOfQuoteGuid.HasValue)
          {
            object objectValue1 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ControlNo FROM tblQuotes WITH (NOLOCK) WHERE QuoteGuid = @QG", new object[2]
            {
              (object) "@QG",
              (object) renewalOfQuoteGuid.Value
            }));
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)))
            {
              object objectValue2 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 RequestID FROM tblExpertInsuredInfo WITH (NOLOCK) WHERE ControlNo = @ControlNo", new object[2]
              {
                (object) "@ControlNO",
                objectValue1
              }));
              if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
                requestDataNode.PreviousCC = Conversions.ToInteger(objectValue2);
              Quote quote2 = Quote.FromControlNo(Conversions.ToInteger(objectValue1));
              if (quote2.HasPolicyNumber)
                requestDataNode.PreviousPolicy = quote2.PolicyNumber;
            }
          }
        }
        if (!usingNetRate)
        {
          DataRow row3 = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT ContactEmail, Rush FROM dbo.tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID = @ID", new object[2]
          {
            (object) "@ID",
            (object) row2.Location_Id
          });
          if (row3 != null)
          {
            if (!row3.IsNull("ContactEmail"))
              requestDataNode.InspectionContactEmail = row3.Field<string>("ContactEmail");
            requestDataNode.Rush = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(row3.Field<bool>("Rush"), (object) 1, (object) 0)));
          }
        }
        if (!string.IsNullOrEmpty(producerContactEmail))
          requestDataNode.ProducerContactEmail = producerContactEmail;
        requestDataNodeList.Add(requestDataNode);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return this.GetXml(new EiInspectionRequest()
    {
      AuthData = authDataNode,
      RequestData = requestDataNodeList.ToArray()
    });
  }

  private string GetXml(EiInspectionRequest tmpRequest)
  {
    XmlSerializer xmlSerializer = new XmlSerializer(tmpRequest.GetType());
    MemoryStream w = new MemoryStream();
    using (XmlTextWriter xmlTextWriter = new XmlTextWriter((Stream) w, Encoding.UTF8))
    {
      xmlTextWriter.Namespaces = true;
      xmlSerializer.Serialize((XmlWriter) xmlTextWriter, (object) tmpRequest, InspectionRequest.GetEmptyNamespaces());
    }
    w.Close();
    string str1 = Encoding.UTF8.GetString(w.GetBuffer());
    string str2 = str1.Substring(str1.IndexOf(Convert.ToChar(60)));
    return str2.Substring(0, str2.LastIndexOf(Convert.ToChar(62)) + 1);
  }

  public bool SendRequestVer2()
  {
    string requestString2 = this.GetRequestString2();
    DefaultDatabase.ExecuteNonQuery("SaveExpertInsuredXml", new object[6]
    {
      (object) "@ControlNo",
      (object) this._controlNo,
      (object) "@ControlGuid",
      (object) this._controlGuid,
      (object) "@XmlData",
      (object) requestString2
    });
    CurrentUser.Instance.LogAction("Inspections Request - Invoking Expert Insured Service Ver2", this._quoteGuid);
    string str = string.Empty;
    using (MajesticExpertInspectWebService inspectWebService = new MajesticExpertInspectWebService())
      str = inspectWebService.ImportRequest(requestString2);
    this.LogMajesticRequest(requestString2);
    int num = 0;
    XDocument xdocument = XDocument.Parse(str);
    try
    {
      foreach (XElement element in xdocument.Descendants().Elements<XElement>((XName) "ResponseData").Elements<XElement>((XName) "StatusCode"))
      {
        if (element.Value.Equals("001"))
          ++num;
      }
    }
    finally
    {
      IEnumerator<XElement> enumerator;
      enumerator?.Dispose();
    }
    bool flag;
    if (num != this._ds.Location.Count)
    {
      InspectionRequest.LogInspectionCompanyErrorReports(DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT PayeeName FROM tblFin_ExpensePayees WITH (NOLOCK) WHERE PayeeID=@IC", new object[2]
      {
        (object) "@IC",
        (object) this._inspectionCompanyId
      }), str, this._quoteGuid);
      flag = false;
    }
    else
    {
      this.SaveRequestID(str);
      flag = true;
    }
    return flag;
  }

  public bool SendRequestTest()
  {
    string requestString2 = this.GetRequestString2();
    DefaultDatabase.ExecuteNonQuery("SaveExpertInsuredXml", new object[6]
    {
      (object) "@ControlNo",
      (object) this._controlNo,
      (object) "@ControlGuid",
      (object) this._controlGuid,
      (object) "@XmlData",
      (object) requestString2
    });
    CurrentUser.Instance.LogAction("Inspections Request - Invoking Expert Insured Test Service", this._quoteGuid);
    string str = string.Empty;
    using (MajesticExpertInspectWebService inspectWebService = new MajesticExpertInspectWebService())
      str = inspectWebService.ValidateRequest(requestString2);
    bool flag;
    if (this.GetTagValue(str, "<StatusCode>", "</StatusCode>").Equals("001"))
    {
      this.SaveRequestID(str);
      this.LogMajesticRequest(requestString2);
      flag = true;
    }
    else
    {
      InspectionRequest.LogInspectionCompanyErrorReports(DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT PayeeName FROM tblFin_ExpensePayees WITH (NOLOCK) WHERE PayeeID=@IC", new object[2]
      {
        (object) "@IC",
        (object) this._inspectionCompanyId
      }), str, this._quoteGuid);
      flag = false;
    }
    return flag;
  }

  private void SaveRequestID(string str)
  {
    string tagValue = this.GetTagValue(str, "<RequestID>", "</RequestID>");
    if (string.IsNullOrEmpty(tagValue))
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblExpertInsuredInfo SET RequestID = @ID WHERE ControlNo = @CN", new object[4]
    {
      (object) "@ID",
      (object) tagValue,
      (object) "@CN",
      (object) this._controlNo
    });
  }

  private void LogMajesticRequest(string xml)
  {
    Guid userGuid = CurrentUser.Instance.UserGUID;
    bool usingNetRate = new Quote(this._quoteGuid).UsingNetRate;
    try
    {
      foreach (RRIRequest.LocationRow row in this._ds.Location.Rows)
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
        InspectionsLogging.LogInspectionRequest(this._quoteGuid, this._inspectionCompanyId, row.Location_Id, usingNetRate, userGuid, locationGuid, false, xml);
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
