// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys._137Motor_NonOwnAutoLiability
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class _137Motor_NonOwnAutoLiability
{
  [JsonProperty("GroupType_Employee")]
  public bool GroupType_Employee { get; set; }

  [JsonProperty("GroupType_Volunteers")]
  public bool GroupType_Volunteers { get; set; }

  [JsonProperty("GroupType_Parteners")]
  public bool GroupType_Parteners { get; set; }

  [JsonProperty("Employee")]
  public int Employee { get; set; }

  [JsonProperty("Volunteers")]
  public int Volunteers { get; set; }

  [JsonProperty("Parteners")]
  public int Parteners { get; set; }
}
