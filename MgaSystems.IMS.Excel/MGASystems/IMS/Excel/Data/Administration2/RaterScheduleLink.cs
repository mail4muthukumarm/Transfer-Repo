// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.Administration2.RaterScheduleLink
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Data.Binding;
using System;

#nullable disable
namespace MGASystems.IMS.Excel.Data.Administration2;

public class RaterScheduleLink : BindingObject
{
  public int ScheduleRaterID { get; }

  public Guid ScheduleFactorSetGuid { get; }

  public string ScheduleName { get; }

  public string ScheduleVersionTitle { get; }

  public DateTime ScheduleEffectiveDate { get; }

  public int? RowStart { get; }

  public int? RowEnd { get; private set; }

  public int? SetinelColumn { get; }

  public string NullSetinelRetVal { get; }

  public ExcelRaterFactorSet Parent { get; }

  public RaterScheduleLink(
    ExcelRaterFactorSet parent,
    int scheduleRaterID,
    Guid scheduleFactorSetGuid,
    string scheduleName,
    string scheduleVersionTitle,
    DateTime scheduleEffectiveDate,
    int? rowStart,
    int? rowEnd,
    int? setinelColumn,
    string nullSetinelRetVal)
  {
    this.Parent = parent;
    this.ScheduleRaterID = scheduleRaterID;
    this.ScheduleFactorSetGuid = scheduleFactorSetGuid;
    this.ScheduleName = scheduleName;
    this.ScheduleVersionTitle = scheduleVersionTitle;
    this.ScheduleEffectiveDate = scheduleEffectiveDate;
    this.RowStart = rowStart;
    this.RowEnd = rowEnd;
    this.SetinelColumn = setinelColumn;
    this.NullSetinelRetVal = nullSetinelRetVal;
  }
}
