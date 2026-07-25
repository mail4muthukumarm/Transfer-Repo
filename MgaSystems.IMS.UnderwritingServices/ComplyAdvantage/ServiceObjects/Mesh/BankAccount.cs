// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.BankAccount
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;

public class BankAccount
{
  [JsonProperty("account_number")]
  public string AccountNumber { get; set; }

  [JsonProperty("bank")]
  public Bank Bank { get; set; }

  [JsonProperty("bban")]
  public string Bban { get; set; }

  [JsonProperty("iban")]
  public string Iban { get; set; }

  [JsonProperty("sort_code")]
  public string SortCode { get; set; }
}
