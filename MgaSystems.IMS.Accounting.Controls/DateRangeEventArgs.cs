// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.DateRangeEventArgs
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

public class DateRangeEventArgs : CancelEventArgs
{
  private DateRangeOptions _dateRagneOption;
  private DateTime _dateFrom;
  private DateTime _dateTo;

  public DateRangeEventArgs(DateRangeOptions dateRagneOption, DateTime dateFrom, DateTime dateTo)
  {
    this._dateRagneOption = dateRagneOption;
    this._dateTo = dateTo;
    this._dateFrom = dateFrom;
  }

  public DateRangeOptions DateRangeOption => this._dateRagneOption;

  public DateTime DateRangeFrom => this._dateFrom;

  public DateTime DateRangeTo => this._dateTo;
}
