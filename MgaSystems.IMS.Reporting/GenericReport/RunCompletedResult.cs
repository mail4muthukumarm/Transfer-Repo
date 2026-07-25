// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.GenericReport.RunCompletedResult
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using MGASystems.IMS.Reporting.AutomationReports;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting.GenericReport;

public sealed class RunCompletedResult
{
  private readonly GenericReportResultType _resultType;
  private readonly object _result;

  public GenericReportResultType ResultType => this._resultType;

  public object Result => this._result;

  internal RunCompletedResult(GenericReportResultType resultType, object result)
  {
    this._resultType = resultType;
    this._result = RuntimeHelpers.GetObjectValue(result);
  }
}
