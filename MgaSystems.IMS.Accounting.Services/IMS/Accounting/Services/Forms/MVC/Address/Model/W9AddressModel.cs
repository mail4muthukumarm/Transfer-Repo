// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Model.W9AddressModel
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Model;

public class W9AddressModel : ValidateModelBase, IAddressModel, IValidateModel, IMvcModel, IValidate
{
  private string _address1;
  private string _address2;
  private string _state;
  private string _zipCode;
  private string _zipCodeExtension;
  private string _city;
  private string _countryCode;
  private const string DefaultISO = "USA";
  private const string DefaultZipCode = "00000";

  public string City
  {
    get => this._city;
    set
    {
      this._city = value ?? throw new InvalidOperationException("Cannot set City to null");
      this.NotifyObservers();
    }
  }

  public W9AddressModel(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension)
  {
    this._address1 = address1 ?? throw new ArgumentNullException(nameof (address1));
    this._address2 = address2 ?? throw new ArgumentNullException(nameof (address2));
    this._city = city ?? throw new ArgumentNullException(nameof (city));
    this._state = state ?? throw new ArgumentNullException(nameof (state));
    this._zipCode = zipCode ?? throw new ArgumentNullException(nameof (zipCode));
    this._zipCodeExtension = zipCodeExtension ?? throw new ArgumentNullException(nameof (zipCodeExtension));
    this._countryCode = "USA";
  }

  public W9AddressModel(
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipCodeExtension,
    string isoCountryCode)
  {
    this._address1 = address1 ?? throw new ArgumentNullException(nameof (address1));
    this._address2 = address2 ?? throw new ArgumentNullException(nameof (address2));
    this._city = city ?? throw new ArgumentNullException(nameof (city));
    this._state = state ?? throw new ArgumentNullException(nameof (state));
    this._zipCode = zipCode ?? throw new ArgumentNullException(nameof (zipCode));
    this._zipCodeExtension = zipCodeExtension ?? throw new ArgumentNullException(nameof (zipCodeExtension));
    this._countryCode = isoCountryCode ?? throw new ArgumentNullException(nameof (isoCountryCode));
  }

  public W9AddressModel()
  {
    this._address1 = string.Empty;
    this._address2 = string.Empty;
    this._city = string.Empty;
    this._state = string.Empty;
    this._zipCode = string.Empty;
    this._zipCodeExtension = string.Empty;
    this._countryCode = string.Empty;
  }

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
    validationResult.ValidateIsNotNullOrEmpty(this.Address1, "Address 1", true);
    validationResult.ValidateIsNotNullOrEmpty(this.City, "City");
    validationResult.ValidateIsNotNullOrEmpty(this.State, "State");
    if (this.CountryCode == "USA")
    {
      validationResult.ValidateIsNotNullOrEmpty(this.ZipCode, "Zip Code");
    }
    else
    {
      if (!string.IsNullOrEmpty(this.ZipCode))
        return;
      this.ZipCode = "00000";
    }
  }

  public string Address1
  {
    get => this._address1;
    set
    {
      this._address1 = value ?? throw new InvalidOperationException("Cannot set Address1 to null");
      this.NotifyObservers();
    }
  }

  public string Address2
  {
    get => this._address2;
    set
    {
      this._address2 = value ?? throw new InvalidOperationException("Cannot set Address2 to null");
      this.NotifyObservers();
    }
  }

  public string State
  {
    get => this._state;
    set
    {
      this._state = value ?? throw new InvalidOperationException("Cannot set State to null");
      this.NotifyObservers();
    }
  }

  public string ZipCode
  {
    get => this._zipCode;
    set
    {
      this._zipCode = value ?? throw new InvalidOperationException("Cannot set ZipCode to null");
      this.NotifyObservers();
    }
  }

  public string ZipCodeExtension
  {
    get => this._zipCodeExtension;
    set
    {
      this._zipCodeExtension = value ?? throw new InvalidOperationException("Cannot set ZipCodeExtension to null");
      this.NotifyObservers();
    }
  }

  public string CountryCode
  {
    get => this._countryCode;
    set
    {
      this._countryCode = string.IsNullOrEmpty(this._countryCode) || string.IsNullOrEmpty(value) ? "USA" : value;
      this.NotifyObservers();
    }
  }

  public override string ToString() => $"{this.Address1}, {this.City} {this.State} {this.ZipCode}";
}
