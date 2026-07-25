// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Telematics.TelematicsSendVehicleRequest
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.Telematics;

public class TelematicsSendVehicleRequest
{
  public EnrollCompanyData enrollCompanyData { get; set; }

  public int CarrierId { get; set; }

  public int vehicleCount { get; set; }

  public int controlNumber { get; set; }

  public List<TelematicsSendVehicleRequest.VehicleAttributes> Vehicles { get; }

  public TelematicsSendVehicleRequest(string companyName, int carrierId)
  {
    this.CarrierId = carrierId;
    this.Vehicles = new List<TelematicsSendVehicleRequest.VehicleAttributes>();
  }

  public void AddVehicle(string vin, string alias, string category, bool isDeleted)
  {
    this.Vehicles.Add(new TelematicsSendVehicleRequest.VehicleAttributes(vin, alias, category, isDeleted));
  }

  public class VehicleAttributes
  {
    public string Vin { get; set; }

    public string Alias { get; set; }

    public string Category { get; set; }

    public bool IsDeleted { get; set; }

    public VehicleAttributes(string vin, string alias, string category, bool isDeleted)
    {
      this.Vin = vin;
      this.Alias = alias;
      this.Category = category;
      this.IsDeleted = isDeleted;
    }
  }
}
