// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.AcordDataCapturedResults
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class AcordDataCapturedResults
{
  [JsonProperty("AcordResults")]
  public ICollection<AcordResult> AcordResults { get; set; }

  [JsonProperty("NetRateData")]
  public ICollection<MGASystems.Common.SelectSys.NetRateData> NetRateData { get; set; }

  [JsonProperty("Message")]
  public string Message { get; set; }

  [JsonProperty("Status")]
  public bool Status { get; set; }
}
