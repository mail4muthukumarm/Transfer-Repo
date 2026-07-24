// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.GraphModel.EnumConverter
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common.Email.GraphModel;

public class EnumConverter : StringEnumConverter
{
  public EnumConverter() => this.CamelCaseText = true;

  public override bool CanConvert(Type objectType) => true;

  public override bool CanWrite => true;

  public override object ReadJson(
    JsonReader reader,
    Type objectType,
    object existingValue,
    JsonSerializer serializer)
  {
    object obj;
    try
    {
      obj = base.ReadJson(reader, objectType, RuntimeHelpers.GetObjectValue(existingValue), serializer);
      goto label_3;
    }
    catch (JsonSerializationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    obj = (object) null;
label_3:
    return obj;
  }

  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
  {
    base.WriteJson(writer, RuntimeHelpers.GetObjectValue(value), serializer);
  }
}
