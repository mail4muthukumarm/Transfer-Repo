// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.IOfflineReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using MGASystems.IMS.Reporting.ReportControls;

#nullable disable
namespace MGASystems.IMS.Reporting;

public interface IOfflineReport
{
  bool ReportHasRecords { get; }

  BaseReportControl[] GetOfflineReportControls { get; }
}
