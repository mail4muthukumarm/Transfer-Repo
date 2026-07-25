// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.ResidentialInformation
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.Serializer;
using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;

public class ResidentialInformation
{
  [JsonProperty("country_of_residence")]
  public string CountryOfResidence { get; set; }

  [JsonProperty("residential_status")]
  [JsonConverter(typeof (StringNullEnumConverter), new object[] {ResidentialStatus.None})]
  public ResidentialStatus ResidentialStatus { get; set; }
}
