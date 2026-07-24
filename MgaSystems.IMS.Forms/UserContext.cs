// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.UserContext
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Text;

#nullable disable
namespace MGASystems.IMS.Forms;

public class UserContext
{
  private Guid _userGuid;
  private string _userName;
  private string _password;
  private string _oldPassword;
  private string _firstName;
  private string _middleName;
  private string _lastName;
  private bool _isActive;
  private string _address1;
  private string _address2;
  private string _city;
  private string _state;
  private string _zipCode;
  private string _phone;
  private string _cell;
  private string _fax;
  private string _email;
  private string _homeEmailAddress;
  private string _foreignPhone;
  private DateTime _expiryDate;
  private string _createdBy;
  private string _encryptedPassword;

  public UserContext(
    Guid userGuid,
    string userName,
    string password,
    string oldPassword,
    string firstName,
    string middleName,
    string lastName,
    bool isActive,
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string phone,
    string cell,
    string fax,
    string email,
    string homeEmailAddress,
    string foreignPhone,
    string createdBy,
    string encryptedPassword)
  {
    this._userGuid = userGuid;
    this._userName = userName;
    this._password = password;
    this._firstName = firstName;
    this._middleName = middleName;
    this._lastName = lastName;
    this._isActive = isActive;
    this._address1 = address1;
    this._address2 = address2;
    this._city = city;
    this._state = state;
    this._zipCode = zipCode;
    this._phone = phone;
    this._cell = cell;
    this._fax = fax;
    this._email = email;
    this._homeEmailAddress = homeEmailAddress;
    this._foreignPhone = foreignPhone;
    this._createdBy = createdBy;
    this._oldPassword = oldPassword;
    this._encryptedPassword = encryptedPassword;
  }

  public static long? StrToNLng(string value)
  {
    long? nlng;
    if (string.IsNullOrEmpty(value))
    {
      nlng = new long?();
    }
    else
    {
      try
      {
        StringBuilder stringBuilder = new StringBuilder();
        string str = value;
        int index = 0;
        while (index < str.Length)
        {
          char c = str[index];
          if (char.IsNumber(c))
            stringBuilder.Append(c);
          checked { ++index; }
        }
        nlng = new long?(long.Parse(stringBuilder.ToString()));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        nlng = new long?();
        ProjectData.ClearProjectError();
      }
    }
    return nlng;
  }

  public string CreatedBy => this._createdBy;

  public string HomeEmailAddress => this._homeEmailAddress;

  public string ForeignPhone => this._foreignPhone;

  public string Email => this._email;

  public string Phone => this._phone;

  public string Cell => this._cell;

  public string Fax => this._fax;

  public string ZipCode => this._zipCode;

  public string State => this._state;

  public string City => this._city;

  public string Address2 => this._address2;

  public string Address1 => this._address1;

  public bool IsActive => this._isActive;

  public string LastName => this._lastName;

  public string MiddleName => this._middleName;

  public string FirstName => this._firstName;

  public string Password => this._password;

  public string OldPassword => this._oldPassword;

  public string Username => this._userName;

  public Guid UserGuid => this._userGuid;

  public string EncryptedPassword => this._encryptedPassword;
}
