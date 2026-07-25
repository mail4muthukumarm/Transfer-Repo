// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Telematics.SpeedGauge.SpeedGauge
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.Telematics.SpeedGauge.PoliciesFairScore;
using MGASystems.Common.Telematics.SpeedGauge.VehiclePolicies;
using MGASystems.Common.Telematics.SpeedGauge.VehicleRequestData;
using MGASystems.Data;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Globalization;
using System.Web;

#nullable disable
namespace MGASystems.Common.Telematics.SpeedGauge;

public class SpeedGauge : ITelematicsVendor
{
  private readonly int _carrierId = 87;
  private string _email = "integrate@mgasystems.com";
  private string _password = "wTbh8-rjfAY.-df";
  private string _token = string.Empty;
  private readonly WebService _webService;
  private const string _baseUrl = "https://www.speedgauge.net/insurance/api/";
  private string _action = string.Empty;
  private static MGASystems.Common.Telematics.SpeedGauge.SpeedGauge Instance;

  private SpeedGauge()
  {
    this._carrierId = (int) SystemSettings.GetNumericSetting("TelemetricsSendVehicles");
    this._webService = new WebService();
  }

  public static MGASystems.Common.Telematics.SpeedGauge.SpeedGauge SpeedGaugeSingleton
  {
    get
    {
      if (MGASystems.Common.Telematics.SpeedGauge.SpeedGauge.Instance == null)
        MGASystems.Common.Telematics.SpeedGauge.SpeedGauge.Instance = new MGASystems.Common.Telematics.SpeedGauge.SpeedGauge();
      return MGASystems.Common.Telematics.SpeedGauge.SpeedGauge.Instance;
    }
  }

  public int CarrierId() => this._carrierId;

  public void Authentication(string email, string password)
  {
    this._email = email;
    this._password = password;
  }

  private void Log(string result)
  {
    if (string.IsNullOrEmpty(result))
      CurrentUser.Instance.LogAction($"SpeedGauge {this._action} Failed with {this._webService.ExceptionMessage}");
    else
      CurrentUser.Instance.LogAction($"SpeedGauge {this._action} {result}");
    DefaultDatabase.ExecuteNonQuery("dbo.spLogSpeedGauge", new object[12]
    {
      (object) "@userID",
      (object) CurrentUser.Instance.UserID,
      (object) "@request",
      (object) this._webService.LastResponse.RequestMessage.ToString(),
      (object) "@response",
      (object) this._webService.LastResponse.StatusCode.ToString(),
      (object) "@result",
      result == null ? (object) string.Empty : (object) result,
      (object) "@identifierGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@context",
      (object) this._webService.Payload
    });
  }

  private int ProcessEnrollRequest(EnrollCompanyData companyEnrollementData)
  {
    int num = 0;
    if (this.IsLoggedIn())
    {
      this._action = "enrollCompany";
      this._webService.BaseUrl = "https://www.speedgauge.net/insurance/api/";
      this._webService.Url = "hooks/enroll";
      this._webService.MethodName = "POST";
      this._webService.ContentType = "application/vnd.api+json";
      this._webService.Payload = JsonConvert.SerializeObject((object) companyEnrollementData, (Formatting) 0);
      MGASystems.Common.Telematics.SpeedGauge.EnrollCompanyResponse.EnrollCompanyResponse enrollCompanyResponse = JsonConvert.DeserializeObject<MGASystems.Common.Telematics.SpeedGauge.EnrollCompanyResponse.EnrollCompanyResponse>(this._webService.InvokeAsync().Result);
      if (enrollCompanyResponse != null)
        num = enrollCompanyResponse.data.company;
    }
    return num;
  }

  private MGASystems.Common.Telematics.SpeedGauge.ListPolicies getCompanyPolicy(
    int controlNumber,
    int vehicleCount,
    EnrollCompanyData companyEnrollementData)
  {
    MGASystems.Common.Telematics.SpeedGauge.ListPolicies companyPolicy = this.ListPolicies(companyEnrollementData.business_name);
    if (companyPolicy != null && companyPolicy.meta != null && companyPolicy.meta.rows.Count == 0)
    {
      int companyId = this.ProcessEnrollRequest(companyEnrollementData);
      if (companyId > 0)
        companyPolicy = this.ListPolicies(string.Empty, companyId);
    }
    return companyPolicy;
  }

  public TelematicsSendVehicleResponse SendVehicle(
    TelematicsSendVehicleRequest request,
    EnrollCompanyData companyEnrollementData)
  {
    TelematicsSendVehicleResponse sendVehicleResponse = new TelematicsSendVehicleResponse(string.Empty, string.Empty, DateTime.Now, true);
    MGASystems.Common.Telematics.SpeedGauge.ListPolicies companyPolicy = this.getCompanyPolicy(request.controlNumber, request.vehicleCount, companyEnrollementData);
    if (companyPolicy != null && companyPolicy.meta != null && companyPolicy.meta.rows.Count > 0)
    {
      int id = companyPolicy.meta.rows[0].id;
      int companyId = companyPolicy.meta.rows[0].company__id;
      MGASystems.Common.Telematics.SpeedGauge.VehiclePolicies.VehiclePolicies vehiclePolicies1 = this.ListPolicyVehicles(id.ToString((IFormatProvider) CultureInfo.CurrentCulture));
      if (vehiclePolicies1 != null)
      {
        foreach (TelematicsSendVehicleRequest.VehicleAttributes vehicle in request.Vehicles)
        {
          string str = string.Empty;
          if (vehiclePolicies1.included != null)
          {
            foreach (Included included in vehiclePolicies1.included)
            {
              if (included.attributes.vin == vehicle.Vin)
              {
                str = included.id;
                break;
              }
            }
          }
          string vehicleRequest = this.CreateVehicleRequest(vehicle.Vin, vehicle.Alias, this.ConvertCategory(vehicle.Category), companyId.ToString((IFormatProvider) CultureInfo.CurrentCulture));
          if (str.Length > 0)
          {
            if (vehicle.IsDeleted)
              this.DeleteVehicle(str);
            else
              this.PatchVehicle(str, vehicleRequest);
          }
          else
            this.CreateNewVehicle(vehicleRequest, id.ToString((IFormatProvider) CultureInfo.CurrentCulture));
          DefaultDatabase.ExecuteNonQuery("dbo.spSpeedGaugeVIN", new object[8]
          {
            (object) "@vin",
            (object) vehicle.Vin,
            (object) "@updatetime",
            (object) DateTime.Now,
            (object) "@userID",
            (object) CurrentUser.Instance.UserID,
            (object) "@identifierGuid",
            (object) CurrentUser.Instance.UserGUID
          });
          DefaultDatabase.ExecuteNonQuery("spAddSpeedGaugeCompanyDetails", new object[10]
          {
            (object) "@userID",
            (object) CurrentUser.Instance.UserID,
            (object) "@controlNumber",
            (object) request.controlNumber,
            (object) "@policyID",
            (object) id,
            (object) "@companyID",
            (object) companyId,
            (object) "@updatetime",
            (object) DateTime.Now
          });
        }
        PolicyFairScore policyFairScore = this.GetPolicyFairScore(id.ToString((IFormatProvider) CultureInfo.CurrentCulture));
        if (policyFairScore != null)
        {
          sendVehicleResponse.FairScore = policyFairScore.meta.score.ToString((IFormatProvider) CultureInfo.CurrentCulture);
          sendVehicleResponse.Mileage = policyFairScore.meta.months[policyFairScore.meta.months.Count - 1].mileage.ToString((IFormatProvider) CultureInfo.CurrentCulture);
          sendVehicleResponse.LastUpdate = policyFairScore.meta.months[policyFairScore.meta.months.Count - 1].date;
          sendVehicleResponse.IsError = false;
          MGASystems.Common.Telematics.SpeedGauge.VehiclePolicies.VehiclePolicies vehiclePolicies2 = this.ListPolicyVehicles(id.ToString((IFormatProvider) CultureInfo.CurrentCulture));
          if (vehiclePolicies1 != null)
          {
            foreach (Included included in vehiclePolicies2.included)
              sendVehicleResponse.Vehicles.Add(included.attributes.vin);
            foreach (TelematicsSendVehicleRequest.VehicleAttributes vehicle in request.Vehicles)
            {
              if (!sendVehicleResponse.Vehicles.Contains(vehicle.Vin))
                this.Log($"VIN {vehicle.Vin} failed to be found on policy {id}, deleted status = {vehicle.IsDeleted}");
            }
          }
        }
      }
    }
    return sendVehicleResponse;
  }

  private int ConvertCategory(string category)
  {
    int num = 0;
    switch (category.ToLower(CultureInfo.CurrentCulture))
    {
      case "truck-tractor":
        num = 7;
        break;
      case "truck":
        num = 6;
        break;
      case "trailer":
        num = 5;
        break;
    }
    return num;
  }

  private string CreateVehicleRequest(string vin, string alias, int category, string companyId)
  {
    return JsonConvert.SerializeObject((object) new VehicleRequest()
    {
      data = new MGASystems.Common.Telematics.SpeedGauge.VehicleRequestData.Data()
      {
        attributes = new MGASystems.Common.Telematics.SpeedGauge.VehicleRequestData.Attributes()
        {
          alias = alias,
          vin = vin,
          category = category
        },
        relationships = new MGASystems.Common.Telematics.SpeedGauge.VehicleRequestData.Relationships()
        {
          company = new MGASystems.Common.Telematics.SpeedGauge.VehicleRequestData.Company()
          {
            data = new MGASystems.Common.Telematics.SpeedGauge.VehicleRequestData.Data()
            {
              type = "companies",
              id = companyId
            }
          }
        },
        id = companyId,
        type = "vehicles"
      }
    }, (Formatting) 0);
  }

  private bool IsLoggedIn()
  {
    if (this._token.Length == 0)
    {
      this._webService.Url = "https://www.speedgauge.net/authenticate/login";
      this._webService.MethodName = "POST";
      this._webService.Email = this._email;
      this._webService.Password = this._password;
      this._token = this._webService.InvokeAsync().Result;
      this._webService.Token = this._token;
      string str = this._token.Length > 0 ? "Success" : "Failed";
      this._action = "Loggin";
      this.Log($"Login for {this._webService.Email} {str}");
      this._webService.Email = string.Empty;
      this._webService.Password = string.Empty;
    }
    return this._token.Length > 0;
  }

  private MGASystems.Common.Telematics.SpeedGauge.ListPolicies ListPolicies(
    string companyName = "",
    int companyId = 0)
  {
    MGASystems.Common.Telematics.SpeedGauge.ListPolicies listPolicies = new MGASystems.Common.Telematics.SpeedGauge.ListPolicies();
    if (this.IsLoggedIn())
    {
      this._action = nameof (ListPolicies);
      this._webService.ContentType = string.Empty;
      this._webService.Payload = string.Empty;
      this._webService.Url = $"{"https://www.speedgauge.net/insurance/api/"}policies/table?filter[carrier]={this._carrierId}";
      this._webService.MethodName = "GET";
      if (companyName != null && companyName.Length > 0)
      {
        WebService webService = this._webService;
        webService.Url = $"{webService.Url}&filter[company__name]={HttpUtility.UrlPathEncode(companyName)}";
      }
      if (companyId != 0)
        this._webService.Url += $"&filter[company]={companyId}";
      string result = this._webService.InvokeAsync().Result;
      this.Log(result);
      if (result != null)
      {
        JsonSerializerSettings serializerSettings = new JsonSerializerSettings()
        {
          NullValueHandling = (NullValueHandling) 1,
          MissingMemberHandling = (MissingMemberHandling) 0
        };
        listPolicies = JsonConvert.DeserializeObject<MGASystems.Common.Telematics.SpeedGauge.ListPolicies>(result, serializerSettings);
      }
    }
    return listPolicies;
  }

  private PolicyFairScore GetPolicyFairScore(string policyId)
  {
    if (this.IsLoggedIn())
    {
      this._action = nameof (GetPolicyFairScore);
      this._webService.BaseUrl = "https://www.speedgauge.net/insurance/api/";
      this._webService.Url = $"policies/{policyId}/fair";
      this._webService.MethodName = "GET";
      this._webService.ContentType = "application/vnd.api+json";
      this._webService.ContentType = string.Empty;
      this._webService.Payload = string.Empty;
      string result = this._webService.InvokeAsync().Result;
      this.Log(result);
      if (result != null)
        return JsonConvert.DeserializeObject<PolicyFairScore>(result);
    }
    return (PolicyFairScore) null;
  }

  private void DeleteVehicle(string vehicleID)
  {
    if (!this.IsLoggedIn())
      return;
    this._action = nameof (DeleteVehicle);
    this._webService.BaseUrl = "https://www.speedgauge.net/insurance/api/";
    this._webService.Url = "vehicles/" + vehicleID;
    this._webService.MethodName = "DELETE";
    this._webService.ContentType = "application/vnd.api+json";
    this._webService.Payload = string.Empty;
    string result = this._webService.InvokeAsync().Result;
    this.Log(vehicleID);
  }

  private MGASystems.Common.Telematics.SpeedGauge.VehicleDetails.Vehicle CreateNewVehicle(
    string jsonVehicle,
    string policyId)
  {
    if (this.IsLoggedIn())
    {
      this._action = nameof (CreateNewVehicle);
      this._webService.BaseUrl = "https://www.speedgauge.net/insurance/api/";
      this._webService.Url = "vehicles";
      this._webService.MethodName = "POST";
      this._webService.ContentType = "application/vnd.api+json";
      this._webService.Payload = jsonVehicle;
      string result = this._webService.InvokeAsync().Result;
      this.Log(result);
      if (result != null)
      {
        MGASystems.Common.Telematics.SpeedGauge.VehicleDetails.Vehicle newVehicle = JsonConvert.DeserializeObject<MGASystems.Common.Telematics.SpeedGauge.VehicleDetails.Vehicle>(result);
        if (newVehicle != null && newVehicle.data != null && newVehicle.data.id.Length > 0)
        {
          CreateVehiclePolicyRequest vehiclePolicyRequest = new CreateVehiclePolicyRequest()
          {
            data = new MGASystems.Common.Telematics.SpeedGauge.Data()
            {
              attributes = new Attributes(),
              type = "vehicle-policies"
            }
          };
          vehiclePolicyRequest.data.attributes.AddedAt = DateTime.Now;
          vehiclePolicyRequest.data.relationships = new Relationships()
          {
            policy = new Policy()
          };
          vehiclePolicyRequest.data.relationships.policy.data = new MGASystems.Common.Telematics.SpeedGauge.Data()
          {
            type = "policies",
            id = policyId
          };
          vehiclePolicyRequest.data.relationships.vehicle = new Vehicle()
          {
            data = new MGASystems.Common.Telematics.SpeedGauge.Data()
            {
              type = "vehicles",
              id = newVehicle.data.id
            }
          };
          this._action = "vehicle-policies";
          this._webService.Url = "vehicle-policies";
          this._webService.ContentType = "application/vnd.api+json";
          this._webService.MethodName = "POST";
          this._webService.Payload = JsonConvert.SerializeObject((object) vehiclePolicyRequest, (Formatting) 0);
          this.Log(this._webService.InvokeAsync().Result);
        }
        return newVehicle;
      }
    }
    return (MGASystems.Common.Telematics.SpeedGauge.VehicleDetails.Vehicle) null;
  }

  private MGASystems.Common.Telematics.SpeedGauge.VehiclePolicies.VehiclePolicies ListPolicyVehicles(
    string policyId)
  {
    MGASystems.Common.Telematics.SpeedGauge.VehiclePolicies.VehiclePolicies vehiclePolicies = new MGASystems.Common.Telematics.SpeedGauge.VehiclePolicies.VehiclePolicies();
    if (this.IsLoggedIn())
    {
      this._action = nameof (ListPolicyVehicles);
      this._webService.Url = $"https://www.speedgauge.net/insurance/api/vehicle-policies?filter[policy]={policyId}&page[size]=1000";
      this._webService.MethodName = "GET";
      string result = this._webService.InvokeAsync().Result;
      this.Log(result);
      vehiclePolicies = JsonConvert.DeserializeObject<MGASystems.Common.Telematics.SpeedGauge.VehiclePolicies.VehiclePolicies>(result);
    }
    return vehiclePolicies;
  }

  private void PatchVehicle(string vehicleId, string jsonVehicle)
  {
    if (!this.IsLoggedIn())
      return;
    this._action = nameof (PatchVehicle);
    this._webService.Url = "https://www.speedgauge.net/insurance/api/vehicles/" + vehicleId;
    this._webService.MethodName = "PATCH";
    this._webService.ContentType = "application/vnd.api+json";
    this._webService.Payload = jsonVehicle;
    string result = this._webService.InvokeAsync().Result;
  }

  public string PolicyDetailMessage(int controlNumber)
  {
    string str = string.Empty;
    if (SystemSettings.GetBoolSetting("TelemetricsSendVehicles"))
    {
      DataSet dataSet = DefaultDatabase.ExecuteDataSet("spSpeedGaugeGetFairScore", new object[2]
      {
        (object) "@ControlNumber",
        (object) controlNumber
      });
      if (dataSet != null && dataSet.Tables[0].Rows.Count > 0)
        str = "SpeedGauge enabled.";
    }
    return str;
  }

  public bool isQuoteEnabledForAutoSend(Guid quoteGuid)
  {
    return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM dbo.tblSpeedGaugeCompanyDetails d INNER JOIN dbo.tblQuotes t ON t.ControlNo = d.ControlNumber WHERE t.QuoteGUID = @QuoteGUID", new object[2]
    {
      (object) "@QuoteGUID",
      (object) quoteGuid
    }) > 0;
  }
}
