// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.BusinessTypes
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels;

public class BusinessTypes
{
  [JsonProperty("businessTypeID")]
  public byte BusinessTypeID { get; set; }

  [JsonProperty("businessType")]
  public string BusinessType { get; set; }

  [JsonProperty("hidden")]
  public bool Hidden { get; set; }

  [JsonProperty("individual")]
  public bool Individual { get; set; }
}
