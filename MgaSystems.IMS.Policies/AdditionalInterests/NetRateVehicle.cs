// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

#nullable disable
namespace MGASystems.IMS.Policies.AdditionalInterests;

public class NetRateVehicle
{
  private readonly int _vehicleID;
  private string _display;
  protected int _vehicleUnitNumber;
  private readonly int _locationID;
  private readonly string _defaultDisplay;

  public NetRateVehicle(int vehicleID, int vehicleUnitNumber, string display, int locationID)
  {
    this._vehicleID = vehicleID;
    this._display = display;
    this._locationID = locationID;
    this._defaultDisplay = display;
    this._vehicleUnitNumber = vehicleUnitNumber;
  }

  public int VehicleID => this._vehicleID;

  public int VehicleUnitNumber => this._vehicleUnitNumber;

  public int LocationID => this._locationID;

  public override string ToString() => this._display;

  public void SetSearchFoundDisplay() => this._display = this._defaultDisplay + "  **********";

  public void ResetToDefaultDisplay() => this._display = this._defaultDisplay;
}
