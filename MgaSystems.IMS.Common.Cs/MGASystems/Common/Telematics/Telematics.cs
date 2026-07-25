// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Telematics.Telematics
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.Common.Telematics;

public class Telematics
{
  private static MGASystems.Common.Telematics.Telematics _instance;
  private static ITelematicsVendor _vendor;

  private Telematics()
  {
  }

  public static MGASystems.Common.Telematics.Telematics telematicsSingleton
  {
    get
    {
      if (MGASystems.Common.Telematics.Telematics._instance == null)
        MGASystems.Common.Telematics.Telematics._instance = new MGASystems.Common.Telematics.Telematics();
      if (MGASystems.Common.Telematics.Telematics._instance != null && MGASystems.Common.Telematics.Telematics._vendor == null && SystemSettings.GetStringSetting("TelemetricsSendVehicles") == "SpeedGauge")
        MGASystems.Common.Telematics.Telematics._vendor = (ITelematicsVendor) MGASystems.Common.Telematics.SpeedGauge.SpeedGauge.SpeedGaugeSingleton;
      return MGASystems.Common.Telematics.Telematics._instance;
    }
  }

  public int CarrierId() => MGASystems.Common.Telematics.Telematics._vendor != null ? MGASystems.Common.Telematics.Telematics._vendor.CarrierId() : 0;

  public TelematicsSendVehicleResponse SendVehicle(TelematicsSendVehicleRequest sendVehicleRequest)
  {
    if (MGASystems.Common.Telematics.Telematics._vendor != null)
    {
      EnrollCompanyData enrollCompanyData = new EnrollCompanyData();
      this.getInsuredDataFroDB(sendVehicleRequest.controlNumber, sendVehicleRequest.vehicleCount, enrollCompanyData);
      if (enrollCompanyData.isValid())
        return MGASystems.Common.Telematics.Telematics._vendor.SendVehicle(sendVehicleRequest, enrollCompanyData);
    }
    return (TelematicsSendVehicleResponse) null;
  }

  public Tuple<bool, List<string>> IsValidControlNumber(int controlNumber)
  {
    bool flag = false;
    List<string> stringList = new List<string>();
    if (MGASystems.Common.Telematics.Telematics._vendor != null)
    {
      EnrollCompanyData companyEnrollementData = new EnrollCompanyData();
      this.getInsuredDataFroDB(controlNumber, 1, companyEnrollementData);
      flag = companyEnrollementData.isValid();
      if (!flag)
        stringList = companyEnrollementData.invalidFields();
    }
    return Tuple.Create<bool, List<string>>(flag, stringList);
  }

  public string PolicyDetailMessage(int controlNumber)
  {
    return MGASystems.Common.Telematics.Telematics._vendor != null ? MGASystems.Common.Telematics.Telematics._vendor.PolicyDetailMessage(controlNumber) : string.Empty;
  }

  private void getInsuredDataFroDB(
    int controlNumber,
    int numVehicles,
    EnrollCompanyData companyEnrollementData)
  {
    DataSet dataSet = DefaultDatabase.ExecuteDataSet("spSpeedGaugePolicyData", new object[2]
    {
      (object) "@ControlNo",
      (object) controlNumber
    });
    if (dataSet == null || dataSet.Tables.Count <= 0 || dataSet.Tables[0].Rows.Count <= 0)
      return;
    companyEnrollementData.carrier_id = this.CarrierId();
    companyEnrollementData.business_name = dataSet.Tables[0].Rows[0]["InsuredCorporationName"].ToString();
    companyEnrollementData.business_telephone = dataSet.Tables[0].Rows[0]["InsuredPhone"].ToString();
    companyEnrollementData.business_address_1 = dataSet.Tables[0].Rows[0]["InsuredAddress1"].ToString();
    companyEnrollementData.business_address_2 = dataSet.Tables[0].Rows[0]["InsuredAddress2"].ToString();
    companyEnrollementData.city = dataSet.Tables[0].Rows[0]["InsuredCity"].ToString();
    companyEnrollementData.state = dataSet.Tables[0].Rows[0]["InsuredState"].ToString();
    companyEnrollementData.zip_postal_code = dataSet.Tables[0].Rows[0]["InsuredZipCode"].ToString();
    companyEnrollementData.country = dataSet.Tables[0].Rows[0]["InsuredISOCountryCode"].ToString();
    companyEnrollementData.primary_contact_first_name = dataSet.Tables[0].Rows[0]["InsuredContactFName"].ToString();
    companyEnrollementData.primary_contact_last_name = dataSet.Tables[0].Rows[0]["InsuredContactLName"].ToString();
    companyEnrollementData.primary_contact_email = dataSet.Tables[0].Rows[0]["InsuredContactEmail"].ToString();
    companyEnrollementData.policy_number = dataSet.Tables[0].Rows[0]["PolicyNumber"].ToString();
    companyEnrollementData.vehicle_count_on_policy = numVehicles;
    companyEnrollementData.naics = dataSet.Tables[0].Rows[0]["NAICSCode"].ToString();
    companyEnrollementData.taxid = dataSet.Tables[0].Rows[0]["insuredFEIN"].ToString();
  }

  public bool isQuoteEnabledForAutoSend(Guid quoteGuid)
  {
    bool flag = false;
    if (MGASystems.Common.Telematics.Telematics._vendor != null)
      flag = MGASystems.Common.Telematics.Telematics._vendor.isQuoteEnabledForAutoSend(quoteGuid);
    return flag;
  }
}
