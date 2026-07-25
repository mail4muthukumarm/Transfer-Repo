// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.ProducerLocationContext
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using System;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

public class ProducerLocationContext
{
  private Guid _locationGuid;
  private Guid _producerGuid;
  private string _name;
  private string _address1;
  private string _address2;
  private string _city;
  private string _state;
  private string _zipCode;
  private string _phone;
  private string _fax;
  private string _email;
  private bool _isActive;
  private string _npn;

  public ProducerLocationContext(
    Guid locationGuid,
    Guid producerGuid,
    string name,
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string phone,
    string fax,
    string email,
    bool isActive,
    string npn)
  {
    this._locationGuid = locationGuid;
    this._producerGuid = producerGuid;
    this._name = name;
    this._address1 = address1;
    this._address2 = address2;
    this._city = city;
    this._state = state;
    this._zipCode = zipCode;
    this._phone = phone;
    this._fax = fax;
    this._email = email;
    this._isActive = isActive;
    this._npn = npn;
  }

  public Guid LocationGuid => this._locationGuid;

  public Guid ProducerGuid => this._producerGuid;

  public string Name => this._name;

  public string Address1 => this._address1;

  public string Address2 => this._address2;

  public string ZipCode => this._zipCode;

  public string Phone => this._phone;

  public string Fax => this._fax;

  public string Email => this._email;

  public string City => this._city;

  public string State => this._state;

  public bool IsActive => this._isActive;

  public string npn => this._npn;
}
