// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.ProblemDetails
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ProblemDetails
{
  private IDictionary<string, object> _additionalProperties = (IDictionary<string, object>) new Dictionary<string, object>();

  [JsonProperty("type")]
  public string Type { get; set; }

  [JsonProperty("title")]
  public string Title { get; set; }

  [JsonProperty("status")]
  public int? Status { get; set; }

  [JsonProperty("detail")]
  public string Detail { get; set; }

  [JsonProperty("instance")]
  public string Instance { get; set; }

  [JsonExtensionData]
  public IDictionary<string, object> AdditionalProperties
  {
    get => this._additionalProperties;
    set => this._additionalProperties = value;
  }
}
