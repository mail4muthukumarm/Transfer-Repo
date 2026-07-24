// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.BusinessClasses.Address
// Assembly: MgaSystems.IMS.BusinessClasses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1D253CFA-8BFA-433F-ACFB-0202E5D0A596
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessClasses.dll

#nullable disable
namespace MGASystems.IMS.BusinessClasses;

public class Address
{
  private string _address1;
  private string _address2;
  private string _city;
  private string _state;
  private string _zipCode;
  private string _zipCodeExtension;
  private string _emailAddress;
  private bool _isInternational;
  private string _IsoCountryCode;

  public Address()
  {
  }

  public Address(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string isoCountryCode)
  {
    this.CreateAddress(address1, address2, city, state, zipCode, string.Empty, string.Empty, false, isoCountryCode);
  }

  public Address(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension,
    string isoCountryCode)
  {
    this.CreateAddress(address1, address2, city, state, zipCode, zipCodeExtension, string.Empty, false, isoCountryCode);
  }

  public Address(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension,
    bool isInternational,
    string isoCountryCode)
  {
    this.CreateAddress(address1, address2, city, state, zipCode, zipCodeExtension, string.Empty, isInternational, isoCountryCode);
  }

  public Address(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    bool isInternational,
    string isoCountryCode)
  {
    this.CreateAddress(address1, address2, city, state, zipCode, string.Empty, string.Empty, isInternational, isoCountryCode);
  }

  public Address(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension,
    string emailAddress,
    string isoCountryCode)
  {
    this.CreateAddress(address1, address2, city, state, zipCode, zipCodeExtension, emailAddress, false, isoCountryCode);
  }

  public Address(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension,
    string emailAddress,
    bool isInternational,
    string isoCountryCode)
  {
    this.CreateAddress(address1, address2, city, state, zipCode, zipCodeExtension, emailAddress, isInternational, isoCountryCode);
  }

  private void CreateAddress(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension,
    string emailAddress,
    bool isInternational,
    string isoCountryCode)
  {
    this._address1 = address1;
    this._address2 = address2;
    this._city = city;
    this._state = state;
    this._zipCode = zipCode;
    this._zipCodeExtension = zipCodeExtension;
    this._emailAddress = emailAddress;
    this._isInternational = isInternational;
    this._IsoCountryCode = isoCountryCode;
  }

  public string Address1
  {
    get => this._address1;
    set => this._address1 = value;
  }

  public string Address2
  {
    get => this._address2;
    set => this._address2 = value;
  }

  public string City
  {
    get => this._city;
    set => this._city = value;
  }

  public string State
  {
    get => this._state;
    set => this._state = value;
  }

  public string ZipCode
  {
    get => this._zipCode;
    set => this._zipCode = value;
  }

  public string ZipCodeExtension
  {
    get => this._zipCodeExtension;
    set => this._zipCodeExtension = value;
  }

  public string EmailAddress
  {
    get => this._emailAddress;
    set => this._emailAddress = value;
  }

  public bool IsInternational
  {
    get => this._isInternational;
    set => this._isInternational = value;
  }

  public string IsoCountryCode
  {
    get => this._IsoCountryCode;
    set => this._IsoCountryCode = value;
  }
}
