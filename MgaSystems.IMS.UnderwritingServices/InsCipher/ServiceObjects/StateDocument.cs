// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects.StateDocument
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.Serializer;
using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects;

public class StateDocument
{
  [JsonProperty("upload_required")]
  public bool UploadRequired { get; set; }

  [JsonProperty("name")]
  public string DocumentName { get; set; }

  [JsonProperty("code")]
  public string DocumentCode { get; set; }

  [JsonProperty("document_note")]
  public string DocumentNote { get; set; }

  [JsonProperty("transaction_types")]
  public TransactionType[] TransactionTypes { get; set; }

  [JsonProperty("document_download_link")]
  public string DocumentDownloadLink { get; set; }

  [JsonProperty("last_edited_at")]
  public string LastEditedAt { get; set; }

  [JsonProperty("date_active_from")]
  public string DateActiveFrom { get; set; }

  [JsonProperty("date_active_to")]
  public string DateActiveTo { get; set; }

  [JsonProperty("document_group")]
  public string DocumentGroup { get; set; }

  [JsonProperty("rpg")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? ApplicableRiskPurchasingGroup { get; set; }

  [JsonProperty("ecp")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? ApplicableExemptCommercialPurchaser { get; set; }

  [JsonProperty("exempt")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? ApplicableTaxExempt { get; set; }

  [JsonProperty("export_list")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? ApplicableExportList { get; set; }

  [JsonProperty("who_signs")]
  public string DocumentSignee { get; set; }
}
