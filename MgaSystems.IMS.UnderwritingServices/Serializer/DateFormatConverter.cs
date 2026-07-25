// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Serializer.DateFormatConverter
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json.Converters;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Serializer;

public class DateFormatConverter : IsoDateTimeConverter
{
  public DateFormatConverter()
  {
  }

  public DateFormatConverter(string dateFormat)
    : this()
  {
    this.DateTimeFormat = dateFormat;
  }
}
