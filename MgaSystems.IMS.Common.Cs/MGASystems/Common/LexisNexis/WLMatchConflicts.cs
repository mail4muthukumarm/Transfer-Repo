// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.WLMatchConflicts
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class WLMatchConflicts
{
  [JsonProperty("AddressConflict")]
  public bool? AddressConflict { get; set; }

  [JsonProperty("CitizenshipConflict")]
  public bool? CitizenshipConflict { get; set; }

  [JsonProperty("CountryConflict")]
  public bool? CountryConflict { get; set; }

  [JsonProperty("DOBConflict")]
  public bool? DOBConflict { get; set; }

  [JsonProperty("EntityTypeConflict")]
  public bool? EntityTypeConflict { get; set; }

  [JsonProperty("GenderConflict")]
  public bool? GenderConflict { get; set; }

  [JsonProperty("IDConflict")]
  public bool? IDConflict { get; set; }

  [JsonProperty("PhoneConflict")]
  public bool? PhoneConflict { get; set; }
}
