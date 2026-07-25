// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Serializer.BooleanIntConverter
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Serializer;

public class BooleanIntConverter : JsonConverter
{
  public bool AllowNulls { get; set; }

  public BooleanIntConverter()
    : this(false)
  {
  }

  public BooleanIntConverter(bool allowNull = false) => this.AllowNulls = allowNull;

  public override bool CanConvert(Type objectType)
  {
    Type type = Nullable.GetUnderlyingType(objectType);
    if ((object) type == null)
      type = objectType;
    return type == typeof (bool);
  }

  public override object ReadJson(
    JsonReader reader,
    Type objectType,
    object existingValue,
    JsonSerializer serializer)
  {
    long? nullable = reader.Value as long?;
    return (object) (nullable.HasValue || !this.AllowNulls ? new bool?(Convert.ToBoolean(nullable.GetValueOrDefault())) : new bool?());
  }

  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
  {
    if (this.AllowNulls && value == null)
      writer.WriteNull();
    else
      writer.WriteValue(Convert.ToInt32(value ?? (object) 0));
  }
}
