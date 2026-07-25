// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.ADFSToken
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Newtonsoft.Json;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

public class ADFSToken
{
  [JsonProperty("access_token")]
  public string AccessToken { get; set; }

  [JsonProperty("token_type")]
  public string TokenType { get; set; }

  [JsonProperty("expires_in")]
  public int ExpiresIn { get; set; }

  [JsonProperty("userName")]
  public string Username { get; set; }

  [JsonProperty(".issued")]
  public string IssuedAt { get; set; }

  [JsonProperty(".expires")]
  public string ExpiresAt { get; set; }

  [JsonProperty("id_token")]
  public string id_token { get; set; }
}
