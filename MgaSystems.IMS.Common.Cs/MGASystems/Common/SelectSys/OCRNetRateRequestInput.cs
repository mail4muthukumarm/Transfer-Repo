// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.OCRNetRateRequestInput
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class OCRNetRateRequestInput
{
  [JsonProperty("Account_Id")]
  public long Account_Id { get; set; }

  [JsonProperty("UniqueIdentifier")]
  public string UniqueIdentifier { get; set; }

  [JsonProperty("FileList")]
  [Required]
  public ICollection<OCRRequestInput_FileInfo> FileList { get; set; } = (ICollection<OCRRequestInput_FileInfo>) new Collection<OCRRequestInput_FileInfo>();

  [JsonProperty("LobList")]
  [Required]
  public ICollection<OCRNetRateRequestInput_LobList> LobList { get; set; } = (ICollection<OCRNetRateRequestInput_LobList>) new Collection<OCRNetRateRequestInput_LobList>();
}
