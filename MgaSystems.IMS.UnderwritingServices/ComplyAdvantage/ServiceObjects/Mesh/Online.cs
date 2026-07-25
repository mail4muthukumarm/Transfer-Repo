// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.Online
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.Serializer;
using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;

public class Online
{
  [JsonProperty("device_identifier")]
  public string DeviceIdentifier { get; set; }

  [JsonProperty("device_type")]
  public string DeviceType { get; set; }

  [JsonProperty("ip_address")]
  public string IpAddress { get; set; }

  [JsonProperty("ip_format")]
  [JsonConverter(typeof (StringNullEnumConverter), new object[] {IPFormat.None})]
  public IPFormat IpFormat { get; set; }
}
