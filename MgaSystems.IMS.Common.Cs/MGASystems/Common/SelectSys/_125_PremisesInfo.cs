// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys._125_PremisesInfo
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class _125_PremisesInfo
{
  [JsonProperty("Name")]
  public string Name { get; set; }

  [JsonProperty("Address1")]
  public string Address1 { get; set; }

  [JsonProperty("Address2")]
  public string Address2 { get; set; }

  [JsonProperty("City")]
  public string City { get; set; }

  [JsonProperty("State")]
  public string State { get; set; }

  [JsonProperty("County")]
  public string County { get; set; }

  [JsonProperty("ZipCode")]
  public string ZipCode { get; set; }

  [JsonProperty("LocationNo")]
  public string LocationNo { get; set; }

  [JsonProperty("BuildingNo")]
  public string BuildingNo { get; set; }

  [JsonProperty("Description")]
  public string Description { get; set; }

  [JsonProperty("FullTime_Employees")]
  public int FullTime_Employees { get; set; }

  [JsonProperty("Part_Employees")]
  public int Part_Employees { get; set; }

  [JsonProperty("Annual_Revenues")]
  public double Annual_Revenues { get; set; }

  [JsonProperty("Occupied_Area")]
  public double Occupied_Area { get; set; }

  [JsonProperty("OpenToPubliArea")]
  public double OpenToPubliArea { get; set; }

  [JsonProperty("TotalBuildingArea")]
  public double TotalBuildingArea { get; set; }

  [JsonProperty("AnyAreaLeasedToOthers")]
  public bool AnyAreaLeasedToOthers { get; set; }
}
