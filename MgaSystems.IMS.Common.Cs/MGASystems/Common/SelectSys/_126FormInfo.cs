// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys._126FormInfo
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class _126FormInfo
{
  [JsonProperty("Acord_Version")]
  public string Acord_Version { get; set; }

  [JsonProperty("Year_Version")]
  public int Year_Version { get; set; }

  [JsonProperty("Sub_Version")]
  public int Sub_Version { get; set; }

  [JsonProperty("Acord_Version_Name")]
  public string Acord_Version_Name { get; set; }

  [JsonProperty("Acord_Form_Type")]
  public int Acord_Form_Type { get; set; }

  [JsonProperty("AcordAttached_Form_Type")]
  public int AcordAttached_Form_Type { get; set; }

  [JsonProperty("Acord_State")]
  public string Acord_State { get; set; }

  [JsonProperty("CoveragesAndLimits")]
  public _126_CoveragesAndLimits CoveragesAndLimits { get; set; }

  [JsonProperty("Classifications")]
  public ICollection<_126ClassificationInfo> Classifications { get; set; }
}
