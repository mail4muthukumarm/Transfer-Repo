// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.VinService.VehicleVinVerification
// Assembly: MgaSystems.IMS.WebIntegration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 82DEE314-E11A-4163-B1B3-C42062AE6494
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.WebIntegration.dll

using MGASystems.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;

#nullable disable
namespace MgaSystems.IMS.WebIntegration.VinService;

public class VehicleVinVerification
{
  public VinVehicle vv = new VinVehicle();
  private string _vinUserName = DefaultDatabase.ExecuteScalar("GetVinServiceCredential", new object[2]
  {
    (object) "@Credential",
    (object) "VinServiceUserName"
  }).ToString();
  private string _vinPassword = DefaultDatabase.ExecuteScalar("GetVinServiceCredential", new object[2]
  {
    (object) "@Credential",
    (object) "VinServicePassword"
  }).ToString();

  public VinVehicle GetVehicleXML(string VinNumber)
  {
    HttpWebRequest httpWebRequest = WebRequest.Create("http://service.vinlink.com/report?type=" + "basic_plus" + ("&vin=" + VinNumber)) as HttpWebRequest;
    httpWebRequest.Timeout = 20000;
    httpWebRequest.Credentials = (ICredentials) new NetworkCredential(this._vinUserName, this._vinPassword);
    try
    {
      using (HttpWebResponse response = httpWebRequest.GetResponse() as HttpWebResponse)
      {
        string end = new StreamReader(response.GetResponseStream()).ReadToEnd();
        if (response.StatusDescription == "OK")
          this.ParseVehicleInfo(end);
        else
          this.vv = (VinVehicle) null;
      }
    }
    catch (WebException ex)
    {
    }
    return this.vv;
  }

  public VinVehicle GetTruckVehicleXML(string VinNumber)
  {
    HttpWebRequest httpWebRequest = WebRequest.Create("http://service.vinlink.com/report?type=" + "basic" + ("&vin=" + VinNumber)) as HttpWebRequest;
    httpWebRequest.Timeout = 20000;
    httpWebRequest.Credentials = (ICredentials) new NetworkCredential(this._vinUserName, this._vinPassword);
    try
    {
      using (HttpWebResponse response = httpWebRequest.GetResponse() as HttpWebResponse)
      {
        string end = new StreamReader(response.GetResponseStream()).ReadToEnd();
        if (response.StatusDescription == "OK")
          this.ParseTruckVehicleInfo(end);
      }
    }
    catch
    {
    }
    return this.vv;
  }

  public void ParseVehicleInfo(string vehicleString)
  {
    XElement xelement = XElement.Parse(vehicleString).Descendants((XName) "DECODED").ElementAt<XElement>(0);
    this.vv.returnedVehicleXML = vehicleString;
    this.vv.vehicleType = "C";
    foreach (XElement element in xelement.Elements())
    {
      if (element.Attribute((XName) "name").Value.ToString() == "Make")
        this.vv.make = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Model")
        this.vv.model = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Model Year")
        this.vv.year = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Curb weight")
        this.vv.baseCurbWeight = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Brake System")
        this.vv.brakeType = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "MSRP")
        this.vv.msrp = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Gross vehicle weight rating")
        this.vv.grossVehicleWeight = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Transmission/MfgCode")
        this.vv.transType = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Fuel Type")
        this.vv.fuelType = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Engine Type")
        this.vv.engineType = element.Attribute((XName) "value").Value.ToString();
      else
        this.vv.installedEquipment.Add($"{element.Attribute((XName) "name").Value.ToString()} - {element.Attribute((XName) "value").Value.ToString()}");
    }
  }

  public void ParseTruckVehicleInfo(string vehicleString)
  {
    XElement xelement = XElement.Parse(vehicleString).Descendants((XName) "DECODED").ElementAt<XElement>(0);
    this.vv.returnedVehicleXML = vehicleString;
    this.vv.vehicleType = "T";
    foreach (XElement element in xelement.Elements())
    {
      if (element.Attribute((XName) "name").Value.ToString() == "Make")
        this.vv.make = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Model")
        this.vv.model = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Model Year")
        this.vv.year = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Curb weight")
        this.vv.baseCurbWeight = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Brake System")
        this.vv.brakeType = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Gross vehicle weight rating")
        this.vv.grossVehicleWeight = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Transmission/MfgCode")
        this.vv.transType = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Fuel Type")
        this.vv.fuelType = element.Attribute((XName) "value").Value.ToString();
      else if (element.Attribute((XName) "name").Value.ToString() == "Engine Type")
        this.vv.engineType = element.Attribute((XName) "value").Value.ToString();
      else
        this.vv.installedEquipment.Add($"{element.Attribute((XName) "name").Value.ToString()} - {element.Attribute((XName) "value").Value.ToString()}");
    }
  }
}
