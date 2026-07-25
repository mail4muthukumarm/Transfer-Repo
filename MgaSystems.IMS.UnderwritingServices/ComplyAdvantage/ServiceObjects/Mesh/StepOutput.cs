// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.StepOutput
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;

public class StepOutput
{
  [JsonProperty("customer_identifier")]
  public string CustomerIdentifier { get; set; }

  [JsonProperty("external_identifier")]
  public string ExternalIdentifier { get; set; }

  [JsonProperty("customer_version")]
  public int? CustomerVersion { get; set; }

  [JsonProperty("overall_level")]
  public string OverallLevel { get; set; }

  [JsonProperty("overall_value")]
  public double? OverallValue { get; set; }

  [JsonProperty("screening_result")]
  public string ScreeningResult { get; set; }

  [JsonProperty("case_identifier")]
  public string CaseIdentifier { get; set; }

  [JsonProperty("alerts")]
  public List<Alert> Alerts { get; set; }

  [JsonProperty("identifier")]
  public string Identifier { get; set; }

  [JsonProperty("activity_identifier")]
  public string ActivityIdentifier { get; set; }

  [JsonProperty("decision")]
  public string Decision { get; set; }

  [JsonProperty("result")]
  public string Result { get; set; }

  [JsonExtensionData]
  public JObject AdditionalProperties { get; set; }
}
