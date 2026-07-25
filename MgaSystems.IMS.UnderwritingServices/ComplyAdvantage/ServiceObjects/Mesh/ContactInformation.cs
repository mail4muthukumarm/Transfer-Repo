// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.ContactInformation
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;

public class ContactInformation
{
  [JsonProperty("email_address")]
  public string[] EmailAddresses { get; set; }

  [JsonProperty("fax_number")]
  public string[] FaxNumbers { get; set; }

  [JsonProperty("phone_number")]
  public string[] PhoneNumbers { get; set; }

  [JsonProperty("url")]
  public string[] Urls { get; set; }
}
