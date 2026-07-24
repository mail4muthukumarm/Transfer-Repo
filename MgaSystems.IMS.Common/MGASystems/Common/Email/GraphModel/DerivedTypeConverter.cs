// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.GraphModel.DerivedTypeConverter
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.Common.Email.GraphModel;

public class DerivedTypeConverter : JsonConverter
{
  internal static readonly ConcurrentDictionary<string, Type> TypeMappingCache = new ConcurrentDictionary<string, Type>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);

  public override bool CanConvert(Type objectType) => true;

  public override bool CanWrite => false;

  public override object ReadJson(
    JsonReader reader,
    Type objectType,
    object existingValue,
    JsonSerializer serializer)
  {
    JObject jObject = JObject.Load(reader);
    JToken jtoken = jObject.GetValue("@odata.type");
    object objectValue;
    if (jtoken != null)
    {
      string titleCase = StringHelper.ConvertTypeToTitleCase(jtoken.ToString().TrimStart('#'));
      Type type = (Type) null;
      if (DerivedTypeConverter.TypeMappingCache.TryGetValue(titleCase, out type))
      {
        objectValue = RuntimeHelpers.GetObjectValue(this.Create(type));
      }
      else
      {
        Assembly assembly = objectType.GetTypeInfo().Assembly;
        objectValue = RuntimeHelpers.GetObjectValue(this.Create(titleCase, assembly));
      }
      if (objectValue == null)
        objectValue = RuntimeHelpers.GetObjectValue(this.Create(objectType.AssemblyQualifiedName, (Assembly) null));
      if (objectValue != null && (object) type == null)
        DerivedTypeConverter.TypeMappingCache.TryAdd(titleCase, objectValue.GetType());
    }
    else
      objectValue = RuntimeHelpers.GetObjectValue(this.Create(objectType.AssemblyQualifiedName, (Assembly) null));
    if (objectValue == null)
      throw new SerializationException($"Unable to create instance of type '{objectType.AssemblyQualifiedName}'");
    using (JsonReader objectReader = this.GetObjectReader(reader, jObject))
    {
      serializer.Populate(objectReader, RuntimeHelpers.GetObjectValue(objectValue));
      return objectValue;
    }
  }

  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
  {
    throw new NotImplementedException();
  }

  private object Create(string typeString, Assembly typeAssembly)
  {
    return this.Create((object) typeAssembly == null ? Type.GetType(typeString) : typeAssembly.GetType(typeString));
  }

  private object Create(Type type)
  {
    if ((object) type == null)
      return (object) null;
    try
    {
      IEnumerable<ConstructorInfo> declaredConstructors = type.GetTypeInfo().DeclaredConstructors;
      Func<ConstructorInfo, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (DerivedTypeConverter._Closure\u0024__.\u0024I9\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = DerivedTypeConverter._Closure\u0024__.\u0024I9\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        DerivedTypeConverter._Closure\u0024__.\u0024I9\u002D0 = predicate = (Func<ConstructorInfo, bool>) ([SpecialName] (constructor) => !((IEnumerable<ParameterInfo>) constructor.GetParameters()).Any<ParameterInfo>() && !constructor.IsStatic);
      }
      return declaredConstructors.FirstOrDefault<ConstructorInfo>(predicate)?.Invoke(new object[0]);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception innerException = ex;
      throw new SerializationException($"Unable to create instance of type '{type.FullName}'", innerException);
    }
  }

  private JsonReader GetObjectReader(JsonReader originalReader, JObject jObject)
  {
    JsonReader reader = ((JToken) jObject).CreateReader();
    reader.Culture = originalReader.Culture;
    reader.DateParseHandling = originalReader.DateParseHandling;
    reader.DateTimeZoneHandling = originalReader.DateTimeZoneHandling;
    reader.FloatParseHandling = originalReader.FloatParseHandling;
    reader.CloseInput = false;
    return reader;
  }
}
