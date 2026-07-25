// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.InputRecord
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class InputRecord
{
  [JsonProperty("EFT")]
  public InputEFT EFT { get; set; }

  [JsonProperty("Entity")]
  public InputEntity Entity { get; set; }

  [JsonProperty("ID")]
  public InputBasicID ID { get; set; }

  [JsonProperty("RecordID")]
  public long? RecordID { get; set; }

  [JsonProperty("Text")]
  public InputText Text { get; set; }
}
