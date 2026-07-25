// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.AcordResult
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class AcordResult
{
  [JsonProperty("_125FormInfo")]
  public _125FormInfo _125FormInfo { get; set; }

  [JsonProperty("_126FormInfo")]
  public _126FormInfo _126FormInfo { get; set; }

  [JsonProperty("_127FormInfo")]
  public _127FormInfo _127FormInfo { get; set; }

  [JsonProperty("_129FormInfo")]
  public _129FormInfo _129FormInfo { get; set; }

  [JsonProperty("_137FormInfo")]
  public _137FormInfo _137FormInfo { get; set; }

  [JsonProperty("FileName")]
  public string FileName { get; set; }

  [JsonProperty("TotalPages")]
  public int TotalPages { get; set; }

  [JsonProperty("Status")]
  public bool Status { get; set; }
}
