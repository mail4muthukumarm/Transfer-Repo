// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.Majestic.EiInspectionRequest
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.Majestic;

[Serializable]
public class EiInspectionRequest
{
  [XmlElement("AuthData")]
  public EiInspectionRequest.AuthDataNode AuthData;
  [XmlElement("RequestData")]
  public EiInspectionRequest.RequestDataNode[] RequestData;

  [Serializable]
  public class AuthDataNode
  {
    [XmlElement("AuthAgencyLogin")]
    public string AuthAgencyLogin;
    [XmlElement("AuthAgencyPassword")]
    public string AuthAgencyPassword;
    [XmlElement("AuthAgencyID")]
    public int AuthAgencyID;
  }

  [Serializable]
  public class RequestDataNode
  {
    [XmlElement("AgencyID")]
    public int AgencyID;
    [XmlElement("SourceSystemDesc")]
    public string SourceSystemDesc;
    [XmlElement("SourceAppID")]
    public string SourceAppID;
    [XmlElement("UnderwriterName")]
    public string UnderwriterName;
    [XmlElement("UnderwriterEmail")]
    public string UnderwriterEmail;
    [XmlElement("CreatedBy")]
    public string CreatedBy;
    [XmlElement("BrokerName")]
    public string BrokerName;
    [XmlElement("BrokerPhone")]
    public string BrokerPhone;
    [XmlElement("Rush")]
    public int Rush;
    [XmlElement("NeededBy")]
    public DateTime NeededBy;
    [XmlElement("EmailImportance")]
    public int EmailImportance;
    [XmlElement("DeliveryType")]
    public int DeliveryType;
    [XmlElement("DeliveryEmail")]
    public string DeliveryEmail;
    [XmlElement("DeliveryAddress")]
    public string DeliveryAddress;
    [XmlElement("DeliveryCity")]
    public string DeliveryCity;
    [XmlElement("DeliveryZip")]
    public string DeliveryZip;
    [XmlElement("InsuredName")]
    public string InsuredName;
    [XmlElement("Address1")]
    public string Address1;
    [XmlElement("Address2")]
    public string Address2;
    [XmlElement("City")]
    public string City;
    [XmlElement("State")]
    public string State;
    [XmlElement("Zip")]
    public string Zip;
    [XmlElement("PrimaryContactName")]
    public string PrimaryContactName;
    [XmlElement("PrimaryContactPhone")]
    public string PrimaryContactPhone;
    [XmlElement("AlternateContactName")]
    public string AlternateContactName;
    [XmlElement("AlternateContactPhone")]
    public string AlternateContactPhone;
    [XmlElement("CarrierName")]
    public string CarrierName;
    [XmlElement("PolicyNumber")]
    public string PolicyNumber;
    [XmlElement("PropTypeAptBldg")]
    public int PropTypeAptBldg;
    [XmlElement("PropTypeAptOfficeMerc")]
    public int PropTypeAptOfficeMerc;
    [XmlElement("PropTypeOffice")]
    public int PropTypeOffice;
    [XmlElement("PropTypeAptMer")]
    public int PropTypeAptMer;
    [XmlElement("PropTypeGardenAC")]
    public string PropTypeGardenAC;
    [XmlElement("PropTypeRetail")]
    public int PropTypeRetail;
    [XmlElement("PropTypeOther")]
    public int PropertyTypeOther;
    [XmlElement("PropTypeOtherDesc")]
    public string PropTypeOtherDesc;
    [XmlElement("PropTypeComBldg")]
    public int PropTypeComBldg;
    [XmlElement("FullReport")]
    public int FullReport;
    [XmlElement("ShortForm")]
    public int ShortForm;
    [XmlElement("Recommendation")]
    public int Recommendation;
    [XmlElement("Diagram")]
    public int Diagram;
    [XmlElement("InsToValue")]
    public int InsToValue;
    [XmlElement("InsToValueReplacement")]
    public int InsToValueReplacement;
    [XmlElement("InsToValueActualCashVal")]
    public int InsToValueActualCashVal;
    [XmlElement("PayrollConfirm")]
    public int PayrollConfirm;
    [XmlElement("PayrollAmount")]
    public Decimal PayrollAmount;
    [XmlElement("ReceiptsConfirm")]
    public int ReceiptsConfirm;
    [XmlElement("ReceiptsAmount")]
    public Decimal ReceiptsAmount;
    [XmlElement("DriveByInsp")]
    public int DriveByInsp;
    [XmlElement("CovPropBldg")]
    public int CovPropBldg;
    [XmlElement("CovPropBldgInt")]
    public int CovPropBldgInt;
    [XmlElement("CovPropBldgExt")]
    public int CovPropBldgExt;
    [XmlElement("CovPropCont")]
    public int CovPropCont;
    [XmlElement("CovVacantExt")]
    public int CovVacantExt;
    [XmlElement("CovVacantInt")]
    public int CovVacantInt;
    [XmlElement("CovMCJobsite")]
    public int CovMCJobsite;
    [XmlElement("CovMCPrem")]
    public int CovMCPrem;
    [XmlElement("CovMCPhone")]
    public int CovMCPhone;
    [XmlElement("CovHomeOwnersExterior")]
    public int CovHomeOwnersExterior;
    [XmlElement("CovHomeOwnersFullReport")]
    public int CovHomeOwnersFullReport;
    [XmlElement("CovLiability")]
    public int CovLiability;
    [XmlElement("CovAllRisk")]
    public int CovAllRisk;
    [XmlElement("CovRestaurant")]
    public int CovRestaurant;
    [XmlElement("CovWorkers")]
    public int CovWorkers;
    [XmlElement("CovAuto")]
    public int CovAuto;
    [XmlElement("CovLiquor")]
    public int CovLiquor;
    [XmlElement("CovGarageKeepers")]
    public int CovGarageKeepers;
    [XmlElement("CovGarageLiability")]
    public int CovGarageLiability;
    [XmlElement("CovGlass")]
    public int CovGlass;
    [XmlElement("CovFire")]
    public int CovFire;
    [XmlElement("CovProducts")]
    public int CovProducts;
    [XmlElement("Instructions")]
    public string Instructions;
    [XmlElement("Renewal")]
    public int Renewal;
    [XmlElement("PreviousCC")]
    public int PreviousCC;
    [XmlElement("PreviousPolicy")]
    public string PreviousPolicy;
    [XmlElement("CovBuildersRisk")]
    public int CovBuildersRisk;
    [XmlElement("BrokerAddress")]
    public string BrokerAddress;
    [XmlElement("BrokerAddress2")]
    public string BrokerAddress2;
    [XmlElement("BrokerCity")]
    public string BrokerCity;
    [XmlElement("BrokerState")]
    public string BrokerState;
    [XmlElement("BrokerZip")]
    public string BrokerZip;
    [XmlElement("AlternateContactPhoneExt")]
    public string AlternateContactPhoneExt;
    [XmlElement("PolicyPremium")]
    public Decimal PolicyPremium;
    [XmlElement("LocationNumber")]
    public string LocationNumber;
    [XmlElement("EffectiveDate")]
    public string EffectiveDate;
    [XmlElement("ExpirationDate")]
    public string ExpirationDate;
    [XmlElement("InspectionContactEmail")]
    public string InspectionContactEmail;
    [XmlElement("ProducerContactEmail")]
    public string ProducerContactEmail;
  }
}
