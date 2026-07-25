// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Serializer.StringNullEnumConverter
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Serializer;

public class StringNullEnumConverter : StringEnumConverter
{
  private readonly Enum[] _nullEnumValues;

  public StringNullEnumConverter()
  {
  }

  public StringNullEnumConverter(bool camelCaseText)
    : base(camelCaseText)
  {
  }

  public StringNullEnumConverter(Enum[] nullEnumValues) => this._nullEnumValues = nullEnumValues;

  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
  {
    if (this._nullEnumValues != null && Array.IndexOf<object>((object[]) this._nullEnumValues, value) != -1)
      value = (object) null;
    base.WriteJson(writer, value, serializer);
  }
}
