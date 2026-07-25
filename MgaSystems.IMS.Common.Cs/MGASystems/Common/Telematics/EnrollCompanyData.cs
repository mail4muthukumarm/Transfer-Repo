// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Telematics.EnrollCompanyData
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.Telematics;

public class EnrollCompanyData
{
  public int carrier_id { get; set; }

  public string business_name { get; set; }

  public string business_telephone { get; set; }

  public string business_address_1 { get; set; }

  public string business_address_2 { get; set; }

  public string city { get; set; }

  public string state { get; set; }

  public string zip_postal_code { get; set; }

  public string country { get; set; }

  public string primary_contact_first_name { get; set; }

  public string primary_contact_last_name { get; set; }

  public string primary_contact_email { get; set; }

  public string policy_number { get; set; }

  public int vehicle_count_on_policy { get; set; }

  public string naics { get; set; }

  public string taxid { get; set; }

  public bool isValid()
  {
    bool flag = true;
    if (string.IsNullOrEmpty(this.business_name) || string.IsNullOrEmpty(this.business_telephone) || string.IsNullOrEmpty(this.business_address_1) || this.business_address_2 == null || string.IsNullOrEmpty(this.city) || string.IsNullOrEmpty(this.state) || string.IsNullOrEmpty(this.zip_postal_code) || string.IsNullOrEmpty(this.country) || string.IsNullOrEmpty(this.primary_contact_first_name) || string.IsNullOrEmpty(this.primary_contact_last_name) || string.IsNullOrEmpty(this.primary_contact_email) || string.IsNullOrEmpty(this.policy_number) || this.vehicle_count_on_policy < 1 || string.IsNullOrEmpty(this.naics) || string.IsNullOrEmpty(this.taxid))
      flag = false;
    return flag;
  }

  public List<string> invalidFields()
  {
    List<string> stringList = new List<string>();
    if (string.IsNullOrEmpty(this.business_name))
      stringList.Add("Business Name");
    if (string.IsNullOrEmpty(this.business_telephone))
      stringList.Add("Business Telephone");
    if (string.IsNullOrEmpty(this.business_address_1))
      stringList.Add("Business Address 1");
    if (this.business_address_2 == null)
      stringList.Add("Business Address 2");
    if (string.IsNullOrEmpty(this.city))
      stringList.Add("Business City");
    if (string.IsNullOrEmpty(this.state))
      stringList.Add("Business State");
    if (string.IsNullOrEmpty(this.zip_postal_code))
      stringList.Add("Business Postal Code");
    if (string.IsNullOrEmpty(this.country))
      stringList.Add("Business Country");
    if (string.IsNullOrEmpty(this.primary_contact_first_name))
      stringList.Add("Primary Contact First Name");
    if (string.IsNullOrEmpty(this.primary_contact_last_name))
      stringList.Add("Primary Contact Last Name");
    if (string.IsNullOrEmpty(this.primary_contact_email))
      stringList.Add("Primary Contact Email");
    if (string.IsNullOrEmpty(this.policy_number))
      stringList.Add("Policy Number");
    if (string.IsNullOrEmpty(this.naics))
      stringList.Add("NAICS");
    if (string.IsNullOrEmpty(this.taxid))
      stringList.Add("Tax ID");
    return stringList;
  }
}
