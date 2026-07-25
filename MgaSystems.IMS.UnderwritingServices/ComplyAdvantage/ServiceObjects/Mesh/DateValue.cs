// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.DateValue
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;

public class DateValue
{
  public DateValue(DateTime date)
    : this(date.Day, date.Month, date.Year)
  {
  }

  public DateValue(int day, int month, int year)
  {
    int num1 = day;
    int num2 = month;
    int num3 = year;
    this.Day = num1;
    this.Month = num2;
    this.Year = num3;
  }

  [JsonProperty("day")]
  public int Day { get; set; }

  [JsonProperty("month")]
  public int Month { get; set; }

  [JsonProperty("year")]
  public int Year { get; set; }

  public static implicit operator DateValue(DateTime? date)
  {
    return !date.HasValue ? (DateValue) null : new DateValue(date.Value);
  }

  public static implicit operator DateValue(DateTime date) => new DateValue(date);
}
