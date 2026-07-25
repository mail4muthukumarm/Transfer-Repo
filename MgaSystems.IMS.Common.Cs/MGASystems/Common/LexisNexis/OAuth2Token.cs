// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.OAuth2Token
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class OAuth2Token
{
  private DateTime? _expireDate;

  [JsonProperty("token_type")]
  public string Token_type { get; set; }

  [JsonProperty("expires_in")]
  public int? Expires_in { get; set; }

  [JsonProperty("expires_on")]
  public int? Expires_on { get; set; }

  [JsonProperty("not_before")]
  public int? Not_before { get; set; }

  [JsonProperty("resource")]
  public string Resource { get; set; }

  [JsonProperty("access_token")]
  public string Access_token { get; set; }

  [JsonIgnore]
  public DateTime? ExpireDate
  {
    get
    {
      if (!this._expireDate.HasValue)
      {
        int? nullable = this.Expires_on;
        int num1 = 0;
        if (nullable.GetValueOrDefault() > num1 & nullable.HasValue)
        {
          nullable = this.Expires_in;
          int num2 = 0;
          if (nullable.GetValueOrDefault() > num2 & nullable.HasValue)
          {
            nullable = this.Expires_on;
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long) nullable.Value);
            ref DateTimeOffset local = ref dateTimeOffset;
            nullable = this.Expires_in;
            double seconds = (double) -nullable.Value / 30.0;
            this._expireDate = new DateTime?(local.AddSeconds(seconds).LocalDateTime);
          }
        }
      }
      return this._expireDate;
    }
  }
}
