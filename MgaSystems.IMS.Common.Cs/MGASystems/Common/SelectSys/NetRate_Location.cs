// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.NetRate_Location
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class NetRate_Location
{
  [JsonProperty("State")]
  public string State { get; set; }

  [JsonProperty("Address")]
  public string Address { get; set; }

  [JsonProperty("ZipCode")]
  public string ZipCode { get; set; }

  [JsonProperty("City")]
  public string City { get; set; }

  [JsonProperty("County")]
  public string County { get; set; }

  [JsonProperty("LiabilityTerritory")]
  public string LiabilityTerritory { get; set; }

  [JsonProperty("BusinessAutoTerritory")]
  public string BusinessAutoTerritory { get; set; }

  [JsonProperty("LiabilityExposures")]
  public ICollection<NetRate_LiabilityExposures> LiabilityExposures { get; set; }

  [JsonProperty("CompanyOptionalCoverages")]
  public ICollection<NetRate_CompanyOptionalCoverages> CompanyOptionalCoverages { get; set; }

  [JsonProperty("LiabIRPMMod")]
  public string LiabIRPMMod { get; set; }

  [JsonProperty("BusinessAuto")]
  public NetRate_BusinessAuto BusinessAuto { get; set; }
}
