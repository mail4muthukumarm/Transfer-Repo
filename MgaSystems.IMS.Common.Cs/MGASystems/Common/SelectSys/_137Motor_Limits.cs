// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys._137Motor_Limits
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class _137Motor_Limits
{
  [JsonProperty("Limit")]
  public int Limit { get; set; }

  [JsonProperty("BIEachAccident")]
  public int BIEachAccident { get; set; }

  [JsonProperty("PropertyDamage")]
  public int PropertyDamage { get; set; }

  [JsonProperty("Is_CombinedSinglLimit")]
  public bool Is_CombinedSinglLimit { get; set; }

  [JsonProperty("Is_BodlyInjured")]
  public bool Is_BodlyInjured { get; set; }
}
