// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DriverRecord
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

#nullable disable
namespace MGASystems.Common;

public class DriverRecord
{
  private string _hintMvrInsuranceOption;
  private bool _licenseValidationLookup;
  private string _Reference;

  public string HintMvrInsuranceOption
  {
    get => this._hintMvrInsuranceOption;
    set => this._hintMvrInsuranceOption = value;
  }

  public string Reference
  {
    get => this._Reference;
    set => this._Reference = value;
  }

  public bool LicenseValidationLookup
  {
    get => this._licenseValidationLookup;
    set => this._licenseValidationLookup = value;
  }

  public string License { get; }

  public string FirstName { get; }

  public string MiddleName { get; }

  public string LastName { get; }

  public string Suffix { get; }

  public object DateOfBirth { get; }

  public object DriverState { get; }

  public object ProductID { get; }

  public object SubType { get; }

  public object Purpose { get; }

  public object Misc { get; }

  public string Billing { get; }

  public string InsuredName { get; }

  public DriverRecord(
    string driverLicense,
    string driverFirstName,
    string driverMiddleName,
    string driverLastName,
    string driverSuffix,
    object driverDOB,
    object driverState,
    object productID,
    object subType,
    object purpose,
    object misc,
    string billing,
    string insuredName)
  {
    this._hintMvrInsuranceOption = string.Empty;
    this._licenseValidationLookup = false;
    this._Reference = string.Empty;
    this.License = string.Empty;
    this.FirstName = string.Empty;
    this.MiddleName = string.Empty;
    this.LastName = string.Empty;
    this.Suffix = string.Empty;
    this.DriverState = (object) null;
    this.ProductID = (object) null;
    this.SubType = (object) null;
    this.Purpose = (object) null;
    this.Misc = (object) null;
    this.InsuredName = string.Empty;
    this.License = driverLicense;
    this.FirstName = driverFirstName;
    this.MiddleName = driverMiddleName;
    this.LastName = driverLastName;
    this.Suffix = driverSuffix;
    this.DateOfBirth = driverDOB;
    this.DriverState = driverState;
    this.ProductID = productID;
    this.SubType = subType;
    this.Purpose = purpose;
    this.Misc = misc;
    this.Billing = billing;
    this.InsuredName = insuredName;
  }
}
