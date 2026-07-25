// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects.MunicipalTaxSetting
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects;

public class MunicipalTaxSetting
{
  [JsonProperty("municipality_name")]
  public string MunicipalityName { get; set; }

  [JsonProperty("line_category")]
  public string LineCategory { get; set; }
}
