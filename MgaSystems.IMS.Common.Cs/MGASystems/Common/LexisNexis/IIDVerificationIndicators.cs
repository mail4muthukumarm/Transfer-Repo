// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.IIDVerificationIndicators
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class IIDVerificationIndicators
{
  [JsonProperty("Address")]
  public string Address { get; set; }

  [JsonProperty("City")]
  public string City { get; set; }

  [JsonProperty("FEIN")]
  public string FEIN { get; set; }

  [JsonProperty("Name")]
  public string Name { get; set; }

  [JsonProperty("Phone")]
  public string Phone { get; set; }

  [JsonProperty("PostalCode")]
  public string PostalCode { get; set; }

  [JsonProperty("State")]
  public string State { get; set; }
}
