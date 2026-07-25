// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.NetRate_HiredAuto
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class NetRate_HiredAuto
{
  [JsonProperty("IfAnyCost")]
  public int IfAnyCost { get; set; }

  [JsonProperty("TotalCost")]
  public string TotalCost { get; set; }

  [JsonProperty("UninsuredMotorist")]
  public string UninsuredMotorist { get; set; }

  [JsonProperty("Medical")]
  public string Medical { get; set; }

  [JsonProperty("Comp")]
  public string Comp { get; set; }

  [JsonProperty("Coll")]
  public string Coll { get; set; }

  [JsonProperty("ClassCode")]
  public int ClassCode { get; set; }

  [JsonProperty("PhysClassCode")]
  public int PhysClassCode { get; set; }

  [JsonProperty("UninsuredMotoristBIPD")]
  public string UninsuredMotoristBIPD { get; set; }

  [JsonProperty("UnderinsMotorist")]
  public string UnderinsMotorist { get; set; }

  [JsonProperty("HoldHarmless")]
  public int HoldHarmless { get; set; }
}
