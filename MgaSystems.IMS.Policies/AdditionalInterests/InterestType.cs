// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AdditionalInterests.InterestType
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

#nullable disable
namespace MGASystems.IMS.Policies.AdditionalInterests;

public class InterestType
{
  private readonly string _interestType;
  private readonly string _typeName;
  private readonly bool _addressRequired;
  private readonly bool _locationRequired;
  private readonly bool _vehicleRequired;
  private readonly bool _isDisabled;

  public InterestType(
    string interestType,
    string typeName,
    bool addressRequired,
    bool locationRequired,
    bool vehicleRequired,
    bool isDisabled)
  {
    this._interestType = interestType;
    this._typeName = typeName;
    this._addressRequired = addressRequired;
    this._locationRequired = locationRequired;
    this._vehicleRequired = vehicleRequired;
    this._isDisabled = isDisabled;
  }

  public string InterestType => this._interestType;

  public bool AddressRequired => this._addressRequired;

  public bool LocationRequired => this._locationRequired;

  public bool VehicleRequired => this._vehicleRequired;

  public bool IsDisabled => this._isDisabled;

  public override string ToString() => this._typeName;
}
