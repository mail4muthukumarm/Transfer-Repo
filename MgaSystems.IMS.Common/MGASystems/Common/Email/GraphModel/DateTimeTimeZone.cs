// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.GraphModel.DateTimeTimeZone
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Newtonsoft.Json;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.Email.GraphModel;

[JsonObject]
[JsonConverter(typeof (DerivedTypeConverter))]
public class DateTimeTimeZone
{
  [JsonProperty]
  public string DateTime { get; set; }

  [JsonProperty]
  public string TimeZone { get; set; }

  [JsonExtensionData(ReadData = true)]
  public IDictionary<string, object> AdditionalData { get; set; }

  [JsonProperty]
  public string ODataType { get; set; }
}
