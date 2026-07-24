// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ClaimAddress
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data;
using MGASystems.IMS.BusinessClasses;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Claims;

public sealed class ClaimAddress : Address
{
  private PhoneNumberManager _numberManager;
  private dsPhoneNumberManager _phoneNumberDataset;
  private int? _addressId;

  public ClaimAddress()
  {
  }

  public ClaimAddress(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string isoCountryCode)
    : base(address1, address2, city, state, zipCode, isoCountryCode)
  {
  }

  public ClaimAddress(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension,
    string isoCountryCode)
    : base(address1, address2, city, state, zipCode, zipCodeExtension, isoCountryCode)
  {
  }

  public ClaimAddress(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension,
    bool isInternational,
    string isoCountryCode)
    : base(address1, address2, city, state, zipCode, zipCodeExtension, isInternational, isoCountryCode)
  {
  }

  public ClaimAddress(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    bool isInternational,
    string isoCountryCode)
    : base(address1, address2, city, state, zipCode, isInternational, isoCountryCode)
  {
  }

  public ClaimAddress(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension,
    string emailAddress,
    string isoCountryCode)
    : base(address1, address2, city, state, zipCode, zipCodeExtension, emailAddress, isoCountryCode)
  {
  }

  public ClaimAddress(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension,
    string emailAddress,
    bool isInternational,
    string isoCountryCode)
    : base(address1, address2, city, state, zipCode, zipCodeExtension, emailAddress, isInternational, isoCountryCode)
  {
  }

  public ClaimAddress(int addressId) => this._addressId = new int?(addressId);

  public ClaimAddress(
    int addressId,
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string isoCountryCode)
    : base(address1, address2, city, state, zipCode, isoCountryCode)
  {
    this._addressId = new int?(addressId);
  }

  public ClaimAddress(
    int addressId,
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension,
    string isoCountryCode)
    : base(address1, address2, city, state, zipCode, zipCodeExtension, isoCountryCode)
  {
    this._addressId = new int?(addressId);
  }

  public ClaimAddress(
    int addressId,
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension,
    bool isInternational,
    string isoCountryCode)
    : base(address1, address2, city, state, zipCode, zipCodeExtension, isInternational, isoCountryCode)
  {
    this._addressId = new int?(addressId);
  }

  public ClaimAddress(
    int addressId,
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    bool isInternational,
    string isoCountryCode)
    : base(address1, address2, city, state, zipCode, isInternational, isoCountryCode)
  {
    this._addressId = new int?(addressId);
  }

  public ClaimAddress(
    int addressId,
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension,
    string emailAddress,
    string isoCountryCode)
    : base(address1, address2, city, state, zipCode, zipCodeExtension, emailAddress, isoCountryCode)
  {
    this._addressId = new int?(addressId);
  }

  public ClaimAddress(
    int addressId,
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension,
    string emailAddress,
    bool isInternational,
    string isoCountryCode)
    : base(address1, address2, city, state, zipCode, zipCodeExtension, emailAddress, isInternational, isoCountryCode)
  {
    this._addressId = new int?(addressId);
  }

  public PhoneNumberManager NumberManager
  {
    get
    {
      if (this._numberManager == null)
        this._numberManager = new PhoneNumberManager();
      return this._numberManager;
    }
  }

  public dsPhoneNumberManager PhoneNumberDataset
  {
    get
    {
      if (this._phoneNumberDataset == null)
        this._phoneNumberDataset = new dsPhoneNumberManager();
      return this._phoneNumberDataset;
    }
  }

  public int? AddressId => this._addressId;

  public string County { get; set; }

  public void LoadPhoneNumbers(int addressId)
  {
    DefaultDatabase.LoadDataTable((DataTable) this.PhoneNumberDataset.PhoneNumbers, "spClaims_GetAddressPhoneNumbers", new object[2]
    {
      (object) "@AddressId",
      (object) addressId
    });
  }

  internal void LoadPhoneNumbers() => this._phoneNumberDataset = new dsPhoneNumberManager();
}
