// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects.ResponseTransaction
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects;

public class ResponseTransaction
{
  private Dictionary<string, string> _warningMessages;
  private Warnings _warnings;

  [JsonProperty("id")]
  public string ID { get; set; }

  [JsonProperty("policy_number")]
  public string PolicyNumber { get; set; }

  [JsonProperty("transaction_id")]
  public string TransactionID { get; set; }

  [JsonProperty("status")]
  public int Status { get; set; }

  [JsonProperty("status_message")]
  public string StatusMessage { get; set; }

  [JsonProperty("warnings")]
  internal JRaw RawWarnings { get; set; }

  [JsonIgnore]
  public FilingTransaction RequestTransaction { get; set; }

  [JsonIgnore]
  public Dictionary<string, string> WarningMessages
  {
    get
    {
      if (this._warningMessages == null)
        this._warningMessages = ((JToken) this.RawWarnings).ToObject<Dictionary<string, string>>();
      return this._warningMessages;
    }
  }

  [JsonIgnore]
  public Warnings Warnings
  {
    get
    {
      if (this._warnings == null)
      {
        try
        {
          this._warnings = ((JToken) this.RawWarnings)?.ToObject<Warnings>() ?? new Warnings();
        }
        catch
        {
          this._warnings = new Warnings();
        }
      }
      return this._warnings;
    }
  }
}
