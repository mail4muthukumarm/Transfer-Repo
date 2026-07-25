// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys._125_ApplicantInfo
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class _125_ApplicantInfo
{
  [JsonProperty("Business_Name")]
  public string Business_Name { get; set; }

  [JsonProperty("GLCode")]
  public string GLCode { get; set; }

  [JsonProperty("SIC")]
  public string SIC { get; set; }

  [JsonProperty("NAICS")]
  public string NAICS { get; set; }

  [JsonProperty("FIEN_OR_SOC_Sec")]
  public string FIEN_OR_SOC_Sec { get; set; }

  [JsonProperty("Business_Phone")]
  public string Business_Phone { get; set; }

  [JsonProperty("Website_Address")]
  public string Website_Address { get; set; }

  [JsonProperty("NoOfMembersAndManagers")]
  public int NoOfMembersAndManagers { get; set; }

  [JsonProperty("Business_EntityType")]
  public string Business_EntityType { get; set; }

  [JsonProperty("Business_EntityType_Id")]
  public int Business_EntityType_Id { get; set; }

  [JsonProperty("Business_EntityType_Other")]
  public string Business_EntityType_Other { get; set; }

  [JsonProperty("Mail_Address")]
  public Acord_AddressInfo Mail_Address { get; set; }
}
