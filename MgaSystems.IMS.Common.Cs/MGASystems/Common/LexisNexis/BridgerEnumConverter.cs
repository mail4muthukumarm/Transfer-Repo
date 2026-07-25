// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.BridgerEnumConverter
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

#nullable disable
namespace MGASystems.Common.LexisNexis;

public class BridgerEnumConverter : StringEnumConverter
{
  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
  {
    if (value is InputEntityEntityType entityEntityType && entityEntityType >= InputEntityEntityType.Vessel)
      writer.WriteValue((int) value);
    else
      base.WriteJson(writer, value, serializer);
  }
}
