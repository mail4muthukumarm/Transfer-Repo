// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.OCRQueueRequestInput
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace MGASystems.Common.SelectSys;

public class OCRQueueRequestInput
{
  [JsonProperty("Account_Id")]
  public long Account_Id { get; set; }

  [JsonProperty("UniqueIdentifier")]
  [Required(AllowEmptyStrings = true)]
  public string UniqueIdentifier { get; set; }

  [JsonProperty("FileList")]
  [Required]
  public ICollection<OCRRequestInput_FileInfo> FileList { get; set; } = (ICollection<OCRRequestInput_FileInfo>) new Collection<OCRRequestInput_FileInfo>();

  [JsonProperty("LobList")]
  public ICollection<OCRRequestInput_LobList> LobList { get; set; }
}
