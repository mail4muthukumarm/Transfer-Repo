// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.BaseResult
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices;

public class BaseResult
{
  [JsonIgnore]
  public string Method { get; set; }

  [JsonIgnore]
  public string Endpoint { get; set; }

  [JsonIgnore]
  public string Error { get; set; }

  [JsonIgnore]
  public DateTimeOffset? Timestamp { get; set; }

  [JsonIgnore]
  public bool Success => string.IsNullOrEmpty(this.Error);
}
