// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AdditionalInterests.UnderwritingLocation
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

#nullable disable
namespace MGASystems.IMS.Policies.AdditionalInterests;

public class UnderwritingLocation
{
  private readonly int _locationID;
  private readonly string _displayAs;
  private readonly int _buildingNumber;

  public UnderwritingLocation(int locationID, string displayAs)
  {
    this._locationID = locationID;
    this._displayAs = displayAs;
  }

  public UnderwritingLocation(int locationID, string displayAs, int BuildingNumber)
  {
    this._locationID = locationID;
    this._displayAs = displayAs;
    this._buildingNumber = BuildingNumber;
  }

  public int LocationID => this._locationID;

  public int BuildingNumber => this._buildingNumber;

  public override string ToString() => this._displayAs;
}
