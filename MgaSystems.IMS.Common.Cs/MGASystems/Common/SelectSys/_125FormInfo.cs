// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys._125FormInfo
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class _125FormInfo
{
  [JsonProperty("Acord_Version")]
  public string Acord_Version { get; set; }

  [JsonProperty("Year_Version")]
  public int Year_Version { get; set; }

  [JsonProperty("Sub_Version")]
  public int Sub_Version { get; set; }

  [JsonProperty("Acord_Version_Name")]
  public string Acord_Version_Name { get; set; }

  [JsonProperty("Acord_Form_Type")]
  public int Acord_Form_Type { get; set; }

  [JsonProperty("AcordAttached_Form_Type")]
  public int AcordAttached_Form_Type { get; set; }

  [JsonProperty("Acord_State")]
  public string Acord_State { get; set; }

  [JsonProperty("PolicyInfo")]
  public _125_PolicyInfo PolicyInfo { get; set; }

  [JsonProperty("Contacts")]
  public ICollection<_125_ContactInfo> Contacts { get; set; }

  [JsonProperty("Applicants")]
  public ICollection<_125_ApplicantInfo> Applicants { get; set; }

  [JsonProperty("Premises")]
  public ICollection<_125_PremisesInfo> Premises { get; set; }

  [JsonProperty("NatureOfBusiness")]
  public _125_NatureOfBusiness NatureOfBusiness { get; set; }
}
