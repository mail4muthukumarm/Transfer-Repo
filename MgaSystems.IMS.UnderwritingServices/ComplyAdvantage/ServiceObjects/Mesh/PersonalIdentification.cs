// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.PersonalIdentification
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.Serializer;
using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;

public class PersonalIdentification
{
  [JsonProperty("date_of_expiry")]
  public DateValue DateOfExpiry { get; set; }

  [JsonProperty("date_of_issue")]
  public DateValue DateOfIssue { get; set; }

  [JsonProperty("issuing_country")]
  public string IssuingCountry { get; set; }

  [JsonProperty("number")]
  public string Number { get; set; }

  [JsonProperty("type")]
  [JsonConverter(typeof (StringNullEnumConverter), new object[] {IdentificationType.None})]
  public IdentificationType? Type { get; set; }
}
