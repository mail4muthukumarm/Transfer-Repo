// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.GraphModel.Attachment
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Newtonsoft.Json;
using System;

#nullable disable
namespace MGASystems.Common.Email.GraphModel;

[JsonObject]
public class Attachment : Entity
{
  protected internal Attachment()
  {
  }

  [JsonProperty]
  public DateTimeOffset? LastModifiedDateTime { get; set; }

  [JsonProperty]
  public string Name { get; set; }

  [JsonProperty]
  public string ContentType { get; set; }

  [JsonProperty]
  public int? Size { get; set; }

  [JsonProperty]
  public bool? IsInline { get; set; }
}
