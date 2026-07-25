// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.VinService.VinVehicle
// Assembly: MgaSystems.IMS.WebIntegration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 82DEE314-E11A-4163-B1B3-C42062AE6494
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.WebIntegration.dll

using System.Collections.Generic;

#nullable disable
namespace MgaSystems.IMS.WebIntegration.VinService;

public class VinVehicle
{
  public List<string> installedEquipment = new List<string>();

  public string year { get; set; }

  public string make { get; set; }

  public string model { get; set; }

  public string vin { get; set; }

  public string vinValid { get; set; }

  public string capacity { get; set; }

  public string engineType { get; set; }

  public string fuelType { get; set; }

  public string baseCurbWeight { get; set; }

  public string grossVehicleWeight { get; set; }

  public string transType { get; set; }

  public string brakeType { get; set; }

  public string absSystem { get; set; }

  public string msrp { get; set; }

  public string invoice { get; set; }

  public string vehicleType { get; set; }

  public string returnedVehicleXML { get; set; }
}
