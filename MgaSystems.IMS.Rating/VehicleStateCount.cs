// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.VehicleStateCount
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class VehicleStateCount
{
  private string _stateID;
  private int _vehicleCount;

  public VehicleStateCount(string stateID, int vehicleCount)
  {
    this._stateID = stateID;
    this._vehicleCount = vehicleCount;
  }

  public string StateID => this._stateID;

  public int VehicleCount => this._vehicleCount;
}
