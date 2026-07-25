// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.IIDIInput
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class IIDIInput
{
  [JsonProperty("Address")]
  public IIDIAddress Address { get; set; }

  [JsonProperty("DOB")]
  public IIDIDate DOB { get; set; }

  [JsonProperty("Driver")]
  public IIDIIdentification Driver { get; set; }

  [JsonProperty("Gender")]
  public string Gender { get; set; }

  [JsonProperty("HomePhone")]
  public string HomePhone { get; set; }

  [JsonProperty("IPAddress")]
  public string IPAddress { get; set; }

  [JsonProperty("Name")]
  public InputName Name { get; set; }

  [JsonProperty("NationalIDCountry")]
  public string NationalIDCountry { get; set; }

  [JsonProperty("NationalIDNumber")]
  public string NationalIDNumber { get; set; }

  [JsonProperty("Passport")]
  public IIDIPassport Passport { get; set; }

  [JsonProperty("Visa")]
  public IIDIPassport Visa { get; set; }

  [JsonProperty("WorkPhone")]
  public string WorkPhone { get; set; }
}
