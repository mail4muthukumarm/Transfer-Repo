// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.EntityCriteriaAddress
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class EntityCriteriaAddress
{
  [JsonProperty("City")]
  public string City { get; set; }

  [JsonProperty("Country")]
  public string Country { get; set; }

  [JsonProperty("Phone")]
  public string Phone { get; set; }

  [JsonProperty("PostalCode")]
  public string PostalCode { get; set; }

  [JsonProperty("StateProvinceDistrict")]
  public string StateProvinceDistrict { get; set; }

  [JsonProperty("Street1")]
  public string Street1 { get; set; }

  [JsonProperty("Street2")]
  public string Street2 { get; set; }

  [JsonProperty("BuildingName")]
  public string BuildingName { get; set; }

  [JsonProperty("FloorNumber")]
  public string FloorNumber { get; set; }

  [JsonProperty("Suburb")]
  public string Suburb { get; set; }

  [JsonProperty("District")]
  public string District { get; set; }
}
