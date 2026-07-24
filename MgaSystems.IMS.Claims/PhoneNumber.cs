// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.PhoneNumber
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data;
using System.Text.RegularExpressions;

#nullable disable
namespace MGASystems.IMS.Claims;

public class PhoneNumber
{
  public PhoneNumber()
  {
  }

  public PhoneNumber(
    string phoneNumber,
    int phoneTypeId,
    string phoneType,
    string countryCode,
    string inputMask)
  {
    this.Number = phoneNumber;
    this.PhoneTypeId = phoneTypeId;
    this.PhoneType = phoneType;
    this.CountryCode = countryCode;
    this.InputMask = inputMask;
  }

  public PhoneNumber(
    int addressId,
    string phoneNumber,
    int phoneTypeId,
    string phoneType,
    string countryCode,
    string inputMask)
  {
    this.AddressId = addressId;
    this.Number = phoneNumber;
    this.PhoneTypeId = phoneTypeId;
    this.PhoneType = phoneType;
    this.CountryCode = countryCode;
    this.InputMask = inputMask;
  }

  public PhoneNumber(
    string phoneNumber,
    int phoneTypeId,
    string phoneType,
    PhoneNumber.PhoneNumberStatus status,
    string countryCode,
    string inputMask)
  {
    this.Number = phoneNumber;
    this.PhoneTypeId = phoneTypeId;
    this.PhoneType = phoneType;
    this.Status = status;
    this.CountryCode = countryCode;
    this.InputMask = inputMask;
  }

  public PhoneNumber(
    int addressId,
    string phoneNumber,
    int phoneTypeId,
    string phoneType,
    PhoneNumber.PhoneNumberStatus status,
    string countryCode,
    string inputMask)
  {
    this.AddressId = addressId;
    this.Number = phoneNumber;
    this.PhoneTypeId = phoneTypeId;
    this.PhoneType = phoneType;
    this.Status = status;
    this.CountryCode = countryCode;
    this.InputMask = inputMask;
  }

  internal int PhoneNumberId { get; set; }

  internal int AddressId { get; set; }

  internal string Number { get; set; }

  internal int PhoneTypeId { get; set; }

  internal string PhoneType { get; set; }

  internal PhoneNumber.PhoneNumberStatus Status { get; set; }

  internal string CountryCode { get; set; }

  internal string InputMask { get; set; }

  internal Regex Pattern { get; set; } = new Regex("[()\\s-]");

  public void SetAddressId(int addressId) => this.AddressId = addressId;

  internal void Save()
  {
    DefaultDatabase.ExecuteNonQuery("spClaims_InsertPhoneNumber", new object[8]
    {
      (object) "@AddressId",
      (object) this.AddressId,
      (object) "@PhoneNumber",
      (object) this.Pattern.Replace(this.Number, ""),
      (object) "@PhoneTypeId",
      (object) this.PhoneTypeId,
      (object) "@CountryCode",
      (object) this.CountryCode
    });
  }

  internal void Save(int addressId)
  {
    DefaultDatabase.ExecuteNonQuery("spClaims_InsertPhoneNumber", new object[8]
    {
      (object) "@AddressId",
      (object) addressId,
      (object) nameof (PhoneNumber),
      (object) this.Pattern.Replace(this.Number, ""),
      (object) "PhoneTypeId",
      (object) this.PhoneTypeId,
      (object) "@CountryCode",
      (object) this.CountryCode
    });
  }

  internal void Update()
  {
    DefaultDatabase.ExecuteNonQuery("spClaims_UpdatePhoneNumber", new object[8]
    {
      (object) "@PhoneNumberId",
      (object) this.PhoneNumberId,
      (object) "@PhoneNumber",
      (object) this.Pattern.Replace(this.Number, ""),
      (object) "@PhoneTypeId",
      (object) this.PhoneTypeId,
      (object) "@CountryCode",
      (object) this.CountryCode
    });
  }

  internal void Delete()
  {
    DefaultDatabase.ExecuteNonQuery("spClaims_DeletePhoneNumber", new object[2]
    {
      (object) "@PhoneNumberId",
      (object) this.PhoneNumberId
    });
  }

  public enum PhoneNumberStatus
  {
    Unchanged,
    New,
    Updated,
    Deleted,
  }
}
