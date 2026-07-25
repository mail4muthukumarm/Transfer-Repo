// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.GenericReport.GenericReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting.GenericReport;

public abstract class GenericReport : IGenericReport
{
  protected abstract object OnGenerateReport(GenerateReportArgs reportArgs);

  RunCompletedResult IGenericReport.Run(object runContext)
  {
    return this.OnRun(RuntimeHelpers.GetObjectValue(runContext));
  }

  protected virtual RunCompletedResult OnRun(object runContext)
  {
    GenerateReportArgs reportArgs = new GenerateReportArgs(RuntimeHelpers.GetObjectValue(runContext));
    object objectValue = RuntimeHelpers.GetObjectValue(this.OnGenerateReport(reportArgs));
    return new RunCompletedResult(reportArgs.ReportType, RuntimeHelpers.GetObjectValue(objectValue));
  }
}
