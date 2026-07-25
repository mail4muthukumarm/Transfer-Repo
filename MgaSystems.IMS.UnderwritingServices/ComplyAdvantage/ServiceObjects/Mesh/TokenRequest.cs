// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.TokenRequest
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;

internal class TokenRequest
{
  [JsonProperty("username")]
  public string Username { get; set; }

  [JsonProperty("password")]
  public string Password { get; set; }

  [JsonProperty("realm")]
  public string Realm { get; set; }

  public TokenRequest(string username, string password, string realm)
  {
    string str1 = username;
    string str2 = password;
    string str3 = realm;
    this.Username = str1;
    this.Password = str2;
    this.Realm = str3;
  }
}
