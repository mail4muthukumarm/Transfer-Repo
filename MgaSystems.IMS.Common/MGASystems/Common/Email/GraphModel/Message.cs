// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.GraphModel.Message
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.Email.GraphModel;

[JsonObject]
public class Message
{
  [JsonProperty]
  public DateTimeOffset? ReceivedDateTime { get; set; }

  [JsonProperty]
  public DateTimeOffset? SentDateTime { get; set; }

  [JsonProperty]
  public bool? HasAttachments { get; set; }

  [JsonProperty]
  public string InternetMessageId { get; set; }

  [JsonProperty]
  public IEnumerable<InternetMessageHeader> InternetMessageHeaders { get; set; }

  [JsonProperty]
  public string Subject { get; set; }

  [JsonProperty]
  public ItemBody Body { get; set; }

  [JsonProperty]
  public string BodyPreview { get; set; }

  [JsonProperty]
  public MGASystems.Common.Email.GraphModel.Importance? Importance { get; set; }

  [JsonProperty]
  public string ParentFolderId { get; set; }

  [JsonProperty]
  public Recipient Sender { get; set; }

  [JsonProperty]
  public Recipient From { get; set; }

  [JsonProperty]
  public IEnumerable<Recipient> ToRecipients { get; set; }

  [JsonProperty]
  public IEnumerable<Recipient> CcRecipients { get; set; }

  [JsonProperty]
  public IEnumerable<Recipient> BccRecipients { get; set; }

  [JsonProperty]
  public IEnumerable<Recipient> ReplyTo { get; set; }

  [JsonProperty]
  public string ConversationId { get; set; }

  [JsonProperty]
  public ItemBody UniqueBody { get; set; }

  [JsonProperty]
  public bool? IsDeliveryReceiptRequested { get; set; }

  [JsonProperty]
  public bool? IsReadReceiptRequested { get; set; }

  [JsonProperty]
  public bool? IsRead { get; set; }

  [JsonProperty]
  public bool? IsDraft { get; set; }

  [JsonProperty]
  public string WebLink { get; set; }

  [JsonProperty]
  public InferenceClassificationType? InferenceClassification { get; set; }

  [JsonProperty]
  public FollowupFlag Flag { get; set; }

  [JsonProperty]
  public IMessageAttachmentsCollectionPage Attachments { get; set; }
}
