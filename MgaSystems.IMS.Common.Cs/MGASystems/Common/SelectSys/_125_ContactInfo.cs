// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys._125_ContactInfo
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class _125_ContactInfo
{
  [JsonProperty("Contact_Type")]
  public string Contact_Type { get; set; }

  [JsonProperty("Contact_Name")]
  public string Contact_Name { get; set; }

  [JsonProperty("Primary_Phone")]
  public string Primary_Phone { get; set; }

  [JsonProperty("Primary_Phone_Type")]
  public string Primary_Phone_Type { get; set; }

  [JsonProperty("Secondary_Phone")]
  public string Secondary_Phone { get; set; }

  [JsonProperty("Secondary_Phone_Type")]
  public string Secondary_Phone_Type { get; set; }

  [JsonProperty("Primary_Email")]
  public string Primary_Email { get; set; }

  [JsonProperty("Secondary_Email")]
  public string Secondary_Email { get; set; }

  [JsonProperty("FirstName")]
  public string FirstName { get; set; }

  [JsonProperty("LastName")]
  public string LastName { get; set; }
}
