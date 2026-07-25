// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects.Warnings
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects;

public class Warnings
{
  [JsonProperty("total")]
  public string total { get; set; }

  [JsonProperty("policyLimit")]
  public string policyLimit { get; set; }

  [JsonProperty("insuranceCompany")]
  public string insuranceCompany { get; set; }

  [JsonProperty("slTax")]
  public string slTax { get; set; }

  [JsonProperty("stampingFee")]
  public string stampingFee { get; set; }

  [JsonProperty("premium")]
  public string premium { get; set; }

  [JsonProperty("fmTax")]
  public string fmTax { get; set; }

  [JsonProperty("slServiceCharge")]
  public string slServiceCharge { get; set; }

  [JsonProperty("empaTax")]
  public string empaTax { get; set; }

  [JsonProperty("syndicateList")]
  public string syndicateList { get; set; }

  [JsonProperty("lineOfBusiness")]
  public string lineOfBusiness { get; set; }

  [JsonProperty("insuranceCompanyItems")]
  public string insuranceCompanyItems { get; set; }

  [JsonProperty("rpgName")]
  public string rpgName { get; set; }

  [JsonProperty("ecp")]
  public string ecp { get; set; }
}
