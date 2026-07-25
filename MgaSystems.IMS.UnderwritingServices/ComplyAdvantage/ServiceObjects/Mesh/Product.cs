// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.Product
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;

public class Product
{
  [JsonProperty("bank_account")]
  public BankAccount BankAccount { get; set; }

  [JsonProperty("crypto_wallet")]
  public CryptoWallet CryptoWallet { get; set; }

  [JsonProperty("currency")]
  public string Currency { get; set; }

  [JsonProperty("monthly_payment_amount")]
  public Decimal MonthlyPaymentAmount { get; set; }

  [JsonProperty("monthly_received_amount")]
  public Decimal MonthlyReceivedAmount { get; set; }

  [JsonProperty("monthly_transaction_count")]
  public long MonthlyTransactionCount { get; set; }

  [JsonProperty("name")]
  public string Name { get; set; }

  [JsonProperty("onboarding_channel")]
  public OnboardingChannel OnboardingChannel { get; set; }

  [JsonProperty("purpose")]
  public string Purpose { get; set; }

  [JsonProperty("status")]
  public string Status { get; set; }
}
