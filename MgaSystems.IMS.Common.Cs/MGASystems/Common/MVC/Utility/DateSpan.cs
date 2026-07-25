// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.Utility.DateSpan
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;

#nullable disable
namespace MGASystems.Common.MVC.Utility;

public class DateSpan
{
  public DateSpan(DateTime start, DateTime end)
  {
    this.Start = start;
    this.End = end;
  }

  public virtual DateTime Start { get; set; }

  public virtual DateTime End { get; set; }

  public static DateSpan CurrentMonth
  {
    get
    {
      DateTime now = DateTime.Now;
      return new DateSpan(new DateTime(now.Year, now.Month, 1), new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month)));
    }
  }
}
