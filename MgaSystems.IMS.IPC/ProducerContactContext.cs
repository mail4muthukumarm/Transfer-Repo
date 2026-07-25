// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.ProducerContactContext
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using System;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

public class ProducerContactContext
{
  private readonly Guid _contactGuid;
  private readonly Guid _locationGuid;
  private readonly string _salutation;
  private readonly string _firstName;
  private readonly string _lastName;
  private readonly string _phone;
  private readonly string _extension;
  private readonly string _fax;
  private readonly string _cell;
  private readonly string _email;
  private readonly bool _isActive;
  private readonly string _NPNNo;

  public ProducerContactContext(
    Guid contactGuid,
    Guid locationGuid,
    string salutation,
    string firstName,
    string lastName,
    string phone,
    string @extension,
    string fax,
    string cell,
    string email,
    bool isActive,
    string NPNNo)
  {
    this._contactGuid = contactGuid;
    this._locationGuid = locationGuid;
    this._salutation = salutation;
    this._firstName = firstName;
    this._lastName = lastName;
    this._phone = phone;
    this._extension = @extension;
    this._fax = fax;
    this._cell = cell;
    this._email = email;
    this._isActive = isActive;
    this._NPNNo = NPNNo;
  }

  public bool IsActive => this._isActive;

  public string Email => this._email;

  public string Cell => this._cell;

  public string Fax => this._fax;

  public Guid ContactGuid => this._contactGuid;

  public Guid LocationGuid => this._locationGuid;

  public string Salutation => this._salutation;

  public string FirstName => this._firstName;

  public string NPNNo => this._NPNNo;

  public string LastName => this._lastName;

  public string Phone => this._phone;

  public string Extension => this._extension;
}
