// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Serializer.EmptyDictionaryConverter
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Serializer;

public class EmptyDictionaryConverter : JsonConverter
{
  private readonly Type _keyType = typeof (object);
  private readonly Type _valueType = typeof (object);

  public EmptyDictionaryConverter()
  {
  }

  public EmptyDictionaryConverter(Type keyType, Type valueType)
  {
    Type type1 = keyType;
    Type type2 = valueType;
    this._keyType = type1;
    this._valueType = type2;
  }

  public override bool CanConvert(Type objectType)
  {
    if (!objectType.ContainsGenericParameters || !objectType.GetGenericTypeDefinition().IsAssignableFrom(typeof (Dictionary<,>)))
      return false;
    return ((IEnumerable<Type>) objectType.GetGenericArguments()).Zip<Type, Type, bool>((IEnumerable<Type>) new Type[2]
    {
      this._keyType,
      this._valueType
    }, (Func<Type, Type, bool>) ((genType, constraintType) => constraintType.IsAssignableFrom(genType))).All<bool>((Func<bool, bool>) (matchType => matchType));
  }

  public override object ReadJson(
    JsonReader reader,
    Type objectType,
    object existingValue,
    JsonSerializer serializer)
  {
    JToken jtoken = JToken.Load(reader);
    JTokenType type = jtoken.Type;
    if (type == 1)
      return jtoken.ToObject(objectType, serializer);
    if (type == 2 && !jtoken.HasValues)
      return Activator.CreateInstance(objectType);
    throw new JsonSerializationException("Object or empty array expected");
  }

  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
  {
    serializer.Serialize(writer, value);
  }
}
