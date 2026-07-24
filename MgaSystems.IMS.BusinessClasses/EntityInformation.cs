// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.BusinessClasses.EntityInformation
// Assembly: MgaSystems.IMS.BusinessClasses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1D253CFA-8BFA-433F-ACFB-0202E5D0A596
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessClasses.dll

using System;

#nullable disable
namespace MGASystems.IMS.BusinessClasses;

public class EntityInformation
{
  private string _firstName;
  private string _middleName;
  private string _lastName;
  private string _corporationName;
  private string _socialSecurityNumber;
  private DateTime? _dateofBirth;
  private string _fein;
  private int _gender;

  public EntityInformation()
  {
  }

  public EntityInformation(string firstName, string lastName)
  {
    this.CreateEntityInformation(firstName, string.Empty, lastName, string.Empty, string.Empty, DateTime.MinValue, string.Empty, 0);
  }

  public EntityInformation(string firstName, string middleName, string lastName)
  {
    this.CreateEntityInformation(firstName, middleName, lastName, string.Empty, string.Empty, DateTime.MinValue, string.Empty, 0);
  }

  public EntityInformation(
    string firstName,
    string middleName,
    string lastName,
    string corporationName,
    string fein)
  {
    this.CreateEntityInformation(firstName, middleName, lastName, corporationName, string.Empty, DateTime.MinValue, fein, 0);
  }

  public EntityInformation(
    string firstName,
    string middleName,
    string lastName,
    DateTime dateOfBirth)
  {
    this.CreateEntityInformation(firstName, middleName, lastName, string.Empty, string.Empty, dateOfBirth, string.Empty, 0);
  }

  public EntityInformation(
    string firstName,
    string middleName,
    string lastName,
    DateTime dateOfBirth,
    int gender)
  {
    this.CreateEntityInformation(firstName, middleName, lastName, string.Empty, string.Empty, dateOfBirth, string.Empty, gender);
  }

  private void CreateEntityInformation(
    string firstName,
    string middleName,
    string lastName,
    string corporationName,
    string socialSecurityNumber,
    DateTime dateOfBirth,
    string fein,
    int gender)
  {
    this._firstName = firstName;
    this._middleName = middleName;
    this._lastName = lastName;
    this._corporationName = corporationName;
    this._socialSecurityNumber = socialSecurityNumber;
    this._dateofBirth = new DateTime?(dateOfBirth);
    this._fein = fein;
    this._gender = gender;
  }

  public string FirstName
  {
    get => this._firstName;
    set => this._firstName = value;
  }

  public string MiddleName
  {
    get => this._middleName;
    set => this._middleName = value;
  }

  public string LastName
  {
    get => this._lastName;
    set => this._lastName = value;
  }

  public string CorporationName
  {
    get => this._corporationName;
    set => this._corporationName = value;
  }

  public string SocialSecurityNumber
  {
    get => this._socialSecurityNumber;
    set => this._socialSecurityNumber = value;
  }

  public DateTime? DateOfBirth
  {
    get => this._dateofBirth;
    set => this._dateofBirth = value;
  }

  public string Fein
  {
    get => this._fein;
    set => this._fein = value;
  }

  public int Gender
  {
    get => this._gender;
    set => this._gender = value;
  }
}
