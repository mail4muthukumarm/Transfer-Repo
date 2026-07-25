// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.Attributes.FinanceConfigurationAttribute
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using System;

#nullable disable
namespace MGASystems.IMS.Reporting.Attributes;

public class FinanceConfigurationAttribute : Attribute
{
  public Guid ReportGuid { get; set; }

  public FinanceConfigurationAttribute(string reportGuidString)
  {
    this.ReportGuid = new Guid(reportGuidString);
  }

  public FinanceConfigurationAttribute(Guid automationReportGuid)
  {
    this.ReportGuid = automationReportGuid;
  }

  public override bool Match(object obj) => obj is FinanceConfigurationAttribute;
}
