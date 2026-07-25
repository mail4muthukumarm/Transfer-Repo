// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.GenericReport.GenerateReportArgs
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using MGASystems.IMS.Reporting.AutomationReports;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting.GenericReport;

public class GenerateReportArgs
{
  private readonly object _runContext;
  private GenericReportResultType _reportType;

  public object RunContext => this._runContext;

  public GenericReportResultType ReportType
  {
    get => this._reportType;
    set => this._reportType = value;
  }

  internal GenerateReportArgs(object runContext)
  {
    this._runContext = RuntimeHelpers.GetObjectValue(runContext);
  }
}
