// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects.StateStampProperties
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.Serializer;
using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects;

public class StateStampProperties
{
  [JsonProperty("state_stamp_wording_text")]
  public string WordingText { get; set; }

  [JsonProperty("state_stamp_wording_instructions")]
  public string WordingInstructions { get; set; }

  [JsonProperty("state_stamp_wording_font_size")]
  public int? WordingFontSize { get; set; }

  [JsonProperty("state_stamp_wording_font_bold")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? WordingFontBold { get; set; }

  [JsonProperty("state_stamp_wording_font_italics")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? WordingFontItalics { get; set; }

  [JsonProperty("state_stamp_wording_font_color")]
  public string WordingFontColor { get; set; }

  [JsonProperty("state_stamp_wording_type")]
  public string WordingType { get; set; }

  [JsonProperty("state_stamp_wording_updated_at")]
  public string WordingUpdated { get; set; }
}
